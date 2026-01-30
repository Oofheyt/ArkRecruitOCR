Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports ReaLTaiizor.Controls
Imports ReaLTaiizor.Forms
Imports RecruitOCR.RecruitMain

'WinRT namespaces (requires Windows.winmd)
Imports Windows.Foundation
Imports Windows.Globalization
Imports Windows.Graphics.Imaging
Imports Windows.Media.Ocr
Imports Windows.Storage.Streams

Public Class RecruitMain

    Private ReadOnly Whitelist As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
    "Guard", "Sniper", "Defender", "Medic", "Supporter", "Caster", "Specialist", "Vanguard", "Melee", "Ranged",
    "Top Operator", "Crowd-Control", "Nuker", "Senior Operator", "Healing", "Support", "Starter", "DP-Recovery",
    "DPS", "Survival", "AoE", "Defense", "Slow", "Debuff", "Fast-Redeploy", "Shift", "Summon", "Robot", "Elemental"
    }

    Private ReadOnly ImageCache As New Dictionary(Of String, Image)()

    Public Class OperatorData
        Public Property Name As String
        Public Property Trait As String
        Public Property Nation As String
        Public Property Group As String
        Public Property Team As String
        Public Property Position As String
        Public Property TagList As List(Of String)
        Public Property Description As String
        Public Property DescriptionTagLine As String
        Public Property Rarity As Integer
        Public Property Role As String
        Public Property ClassBranch As String
        Public Property InternalID As String
    End Class

    Public Class RecruitCombo
        Public Property Tags As List(Of String)
        Public Property Operators As List(Of OperatorData)
        Public Property MinStar As Integer
        Public Property MaxStar As Integer
        Public Property Guarantee As Boolean
        Public Property SortScore As Integer ' used internally for ordering
    End Class

    Public Class OperatorFile
        Public Property Version As String
        Public Property Operators As List(Of OperatorData)
    End Class

    Public Sub EnableDarkModeForForm(frm As Form)
        Try
            'immersive (20) dark mode (1) for the form itself
            DwmSetWindowAttribute(frm.Handle, 20, 1, Marshal.SizeOf(1))
            ApplyDarkModeRecursive(frm.Controls)
        Catch
            'unsupported
        End Try
    End Sub

    Private Sub ApplyDarkModeRecursive(ctrls As Control.ControlCollection)
        For Each c As Control In ctrls
            Try
                SetWindowTheme(c.Handle, "DarkMode_Explorer", Nothing)
            Catch
                'unsupported
            End Try

            If c.HasChildren Then
                ApplyDarkModeRecursive(c.Controls)
            End If
        Next
    End Sub

    Private Sub RecruitMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EnableDarkModeForForm(Me)

        RefreshProcList()

        'attempt to fetch the same process as last time
        If Not String.IsNullOrEmpty(My.Settings.LastProcess) Then
            For i As Integer = 0 To ComboBoxWindows.Items.Count - 1
                Dim item = ComboBoxWindows.Items(i)
                Dim itemType = item.GetType()
                Dim titleProp = itemType.GetProperty("Title")
                If titleProp IsNot Nothing Then
                    Dim title = titleProp.GetValue(item, Nothing).ToString()
                    If String.Equals(title, My.Settings.LastProcess, StringComparison.OrdinalIgnoreCase) Then
                        ComboBoxWindows.SelectedIndex = i
                        Exit For
                    End If
                End If
            Next
        End If

        CheckBox1Star.Checked = My.Settings.Exclude1Star
        CheckBox2Star.Checked = My.Settings.Exclude2Star
        LabelError.Text = ""

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click

        RefreshProcList()

    End Sub

    Private Sub RefreshProcList()

        'populate open windows
        ComboBoxWindows.Items.Clear()
        ComboBoxWindows.Items.Add("")
        For Each proc As Process In Process.GetProcesses()
            Try
                If Not String.IsNullOrEmpty(proc.MainWindowTitle) Then
                    ComboBoxWindows.Items.Add(New With {
                        Key .Handle = proc.MainWindowHandle,
                        Key .Title = proc.MainWindowTitle
                    })
                End If
            Catch
                'ignore processes we can't query
            End Try
        Next

        'show titles only in the dropdown
        ComboBoxWindows.DisplayMember = "Title"
        ComboBoxWindows.ValueMember = "Handle"

        If ComboBoxWindows.Items.Count > 0 Then
            ComboBoxWindows.SelectedIndex = 0
        End If
    End Sub

    Private Sub ButtonOCRSettings_Click(sender As Object, e As EventArgs) Handles ButtonOCRSettings.Click

        Settings.ComboBoxWindows.Items.Clear()

        For Each item In ComboBoxWindows.Items
            Settings.ComboBoxWindows.Items.Add(item)
        Next

        If ComboBoxWindows.SelectedIndex >= 0 Then
            Settings.ComboBoxWindows.SelectedIndex = ComboBoxWindows.SelectedIndex
        End If

        Settings.ShowDialog()

    End Sub

    Private Async Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click

        LabelError.Text = ""

        If ComboBoxWindows.SelectedIndex = 0 Then
            MessageBox.Show("Select a process first", "No process selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        FlowLayoutPanelResults.VerticalScroll.Value = 0

        Dim selected = ComboBoxWindows.SelectedItem
        Dim targetHwnd As IntPtr = selected.Handle

        SetForegroundWindow(targetHwnd)
        Await Task.Delay(My.Settings.Delay)

        Dim rect As RECT
        If Not GetWindowRect(targetHwnd, rect) Then
            MessageBox.Show("Failed to get window rect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim width As Integer = Math.Max(1, rect.Right - rect.Left)
        Dim height As Integer = Math.Max(1, rect.Bottom - rect.Top)

        Dim jsonText As String = System.Text.Encoding.UTF8.GetString(My.Resources.operators_with_ids)
        Dim fileObj = JsonConvert.DeserializeObject(Of OperatorFile)(jsonText)
        Dim allOps = fileObj.Operators

        'ocr and results here
        Try
            Using bmp As New Bitmap(width, height, PixelFormat.Format32bppArgb)
                Using g As Graphics = Graphics.FromImage(bmp)
                    g.CopyFromScreen(rect.Left, rect.Top, 0, 0, New Size(width, height), CopyPixelOperation.SourceCopy)
                End Using

                Dim leftCrop As Double = My.Settings.CropLeft / 100
                Dim topCrop As Double = My.Settings.CropTop / 100
                Dim rightCrop As Double = My.Settings.CropRight / 100
                Dim bottomCrop As Double = My.Settings.CropBottom / 100

                Using cropped As Bitmap = CropBitmap(bmp, leftCrop, topCrop, rightCrop, bottomCrop)
                    Dim extracted As String = Await PerformOCR(cropped)
                    Dim matches As List(Of String) = FilterOcrResult(extracted)
                    If matches.Count < 1 Or matches.Count > 5 Then
                        LabelError.Text = "Match count invalid - check OCR/window settings and try again!"
                        Me.Activate()
                        Return
                    End If

                    PopulateTextBoxes(matches)

                    Dim excludedRarities As New List(Of Integer)
                    If CheckBox1Star.Checked Then excludedRarities.Add(1)
                    If CheckBox2Star.Checked Then excludedRarities.Add(2)

                    Dim combos = Await Task.Run(Function() RecruitmentLogic.CalculateRecruitCombos(allOps, matches, excludedRarities))

                    DisplayRecruitResults(combos)

                End Using
            End Using
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "OCR match error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Activate()

    End Sub

    Private Async Function PerformOCR(bmp As Bitmap) As Task(Of String)

        Using ms As New MemoryStream()
            bmp.Save(ms, ImageFormat.Bmp)
            ms.Position = 0

            Dim ras As IRandomAccessStream = Await AsRandomAccessStreamFromStreamAsync(ms) 'IRandomAccessStream (WinRT)
            Dim decoder As BitmapDecoder = Await AsTask(BitmapDecoder.CreateAsync(ras))
            Dim softwareBitmap As SoftwareBitmap = Await AsTask(decoder.GetSoftwareBitmapAsync())

            Dim lang As New Language("en")
            Dim ocrEngine As OcrEngine = OcrEngine.TryCreateFromLanguage(lang)
            If ocrEngine Is Nothing Then
                Return "OCR engine is not available (en)"
            End If

            Dim ocrResult As OcrResult = Await AsTask(ocrEngine.RecognizeAsync(softwareBitmap))

            Dim sb As New StringBuilder()
            For Each line As OcrLine In ocrResult.Lines
                sb.AppendLine(line.Text)
            Next

            Return sb.ToString()
        End Using

    End Function

    Private Function FilterOcrResult(rawText As String) As List(Of String)

        Dim matches As New List(Of String)
        Dim lines As String() = rawText.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)

        For Each line In lines
            Dim normalisedLine = NormaliseText(line)
            If Whitelist.Contains(normalisedLine) Then
                matches.Add(normalisedLine)
                Continue For
            End If

            For Each word In normalisedLine.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
                Dim normalisedWord = NormaliseText(word)

                If Whitelist.Contains(normalisedWord) Then
                    matches.Add(normalisedWord)
                    Continue For
                End If

                'fuzzy search
                Dim bestMatch = Whitelist.OrderBy(Function(w) Levenshtein(normalisedWord, w)).FirstOrDefault()
                Dim distance = If(bestMatch IsNot Nothing, Levenshtein(normalisedWord, bestMatch), Integer.MaxValue)
                If bestMatch IsNot Nothing AndAlso Levenshtein(normalisedWord, bestMatch) <= My.Settings.FuzzyDist Then
                    matches.Add(bestMatch)
                End If
            Next
        Next

        matches = matches.Distinct(StringComparer.OrdinalIgnoreCase).ToList()

        'blech!
        'If matches.Count < 2 OrElse matches.Count > 5 Then
        '    Throw New InvalidOperationException($"Match count of {matches.Count} outside of allowed bounds (2 to 5).")
        'End If

        Return matches

    End Function

    Private Function NormaliseText(input As String) As String

        If String.IsNullOrWhiteSpace(input) Then Return ""

        input = input.Replace("–"c, "-"c).Replace("—"c, "-"c) 'endash/emdash to hyphen
        input = System.Text.RegularExpressions.Regex.Replace(input, "[^\w\s-]", "") 'punctuation remove regex (except -)
        input = input.Trim() 'remove leading and trailing spaces

        Return input

    End Function

    Private Function Levenshtein(s As String, t As String) As Integer

        Dim n = s.Length, m = t.Length
        Dim d(n + 1, m + 1) As Integer

        If n = 0 Then Return m
        If m = 0 Then Return n

        For i = 0 To n
            d(i, 0) = i
        Next
        For j = 0 To m
            d(0, j) = j
        Next

        For i = 1 To n
            For j = 1 To m
                Dim cost = If(s(i - 1) = t(j - 1), 0, 1)
                d(i, j) = Math.Min(Math.Min(d(i - 1, j) + 1, d(i, j - 1) + 1), d(i - 1, j - 1) + cost)
            Next
        Next

        Return d(n, m)

    End Function

    Private Sub PopulateTextBoxes(matches As List(Of String))

        Dim boxes = {ForeverTextBox1, ForeverTextBox2, ForeverTextBox3, ForeverTextBox4, ForeverTextBox5, ForeverTextBox6}

        For Each tb In boxes
            tb.Text = ""
        Next

        For i As Integer = 0 To Math.Min(matches.Count, boxes.Length) - 1
            boxes(i).Text = matches(i)
        Next

        Dim fourStarWords As String() = {"Specialist", "Crowd-Control", "Nuker", "Support", "Debuff", "Fast-Redeploy", "Shift", "Summon"}

        For Each box In boxes
            If box.Text = "" Then
                box.BorderColor = Color.FromArgb(32, 42, 56)
            ElseIf box.Text = "Top Operator" Then
                box.BorderColor = Color.Orange
            ElseIf box.Text = "Senior Operator" Then
                box.BorderColor = Color.Yellow
            ElseIf fourStarWords.Contains(box.Text, StringComparer.OrdinalIgnoreCase) Then
                box.BorderColor = Color.Violet
            ElseIf box.Text = "Robot" Then
                box.BorderColor = Color.DarkGray
            Else
                box.BorderColor = Color.White
            End If
            box.Invalidate()
            box.Update()
        Next

    End Sub


    Private Sub DisplayRecruitResults(results As List(Of RecruitCombo))

        FlowLayoutPanelResults.SuspendLayout()

        For Each ctrl As Control In FlowLayoutPanelResults.Controls
            ctrl.Dispose()
        Next

        FlowLayoutPanelResults.Controls.Clear()

        For Each result In results
            Dim card = BuildResultCard(result)
            FlowLayoutPanelResults.Controls.Add(card)
        Next

        FlowLayoutPanelResults.ResumeLayout()

    End Sub

    Private Function BuildResultCard(result As RecruitCombo) As Panel

        'background section
        Dim card As New Panel With {
        .AutoSize = True,
        .BackColor = Color.FromArgb(36, 44, 56),
        .Padding = New Padding(8),
        .Margin = New Padding(5)
    }

        'tag label section (left)
        Dim tagsPanel As New FlowLayoutPanel With {
        .AutoSize = False,
        .FlowDirection = FlowDirection.LeftToRight,
        .Margin = New Padding(0, 0, 10, 0),
        .Width = 140
        }
        For Each TagRes In result.Tags
            tagsPanel.Controls.Add(New Label With {
            .Text = TagRes,
            .AutoSize = True,
            .BackColor = Color.DimGray,
            .ForeColor = Color.White,
            .Padding = New Padding(6, 3, 6, 3),
            .Margin = New Padding(2),
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        })
        Next

        'operator icon section (right)
        Dim opsPanel As New FlowLayoutPanel With {
        .AutoSize = True,
        .FlowDirection = FlowDirection.LeftToRight,
        .Margin = New Padding(0)
        }

        'operator icons
        For Each op In result.Operators
            Dim rarityColor = GetRarityColor(op.Rarity)
            Dim opPanel As New Panel With {
                .Size = New Size(75, 100),
                .BackColor = rarityColor,
                .Margin = New Padding(2),
                .Padding = New Padding(2)
            }

            'operator picture
            Dim pic As New PictureBox With {
                .Dock = DockStyle.Top,
                .Height = 64,
                .SizeMode = PictureBoxSizeMode.Zoom
            }
            Dim img = GetOperatorImage(op.InternalID)
            If img IsNot Nothing Then pic.Image = img

            'operator name
            Dim lbl As New Label With {
                .Dock = DockStyle.Bottom,
                .Text = op.Name,
                .TextAlign = ContentAlignment.MiddleCenter,
                .ForeColor = Color.Black,
                .Font = New Font("Segoe UI", 8, FontStyle.Regular),
                .Height = 30,
                .AutoEllipsis = True
            }

            opPanel.Controls.Add(pic)
            opPanel.Controls.Add(lbl)

            'operator click events
            AddHandler opPanel.Click, Sub()
                                          Dim infoForm As New OperatorInfo With {
                                              .OperatorInternalId = op.InternalID
                                          }
                                          infoForm.ShowDialog()
                                      End Sub
            AddHandler pic.Click, Sub()
                                      Dim infoForm As New OperatorInfo With {
                                          .OperatorInternalId = op.InternalID
                                      }
                                      infoForm.ShowDialog()
                                  End Sub
            AddHandler lbl.Click, Sub()
                                      Dim infoForm As New OperatorInfo With {
                                          .OperatorInternalId = op.InternalID
                                      }
                                      infoForm.ShowDialog()
                                  End Sub

            opsPanel.Controls.Add(opPanel)
        Next

        'final combine
        Dim container As New FlowLayoutPanel With {
            .AutoSize = True,
            .FlowDirection = FlowDirection.LeftToRight,
            .BackColor = Color.Transparent
        }
        container.Controls.Add(tagsPanel)
        container.Controls.Add(opsPanel)
        card.Controls.Add(container)

        Return card
    End Function

    Private Function GetRarityColor(rarity As Integer) As Color
        Select Case rarity
            Case 6 : Return Color.FromArgb(255, 132, 4) 'orange
            Case 5 : Return Color.FromArgb(252, 172, 8) 'gold
            Case 4 : Return Color.FromArgb(188, 136, 188) 'purple
            Case 3 : Return Color.FromArgb(70, 130, 180) 'blue
            Case 2 : Return Color.FromArgb(191, 198, 49) 'green
            Case 1 : Return Color.FromArgb(128, 128, 128) 'grey
            Case Else : Return Color.FromArgb(158, 158, 158) 'lighter grey
        End Select
    End Function

    Private Function GetOperatorImage(internalId As String) As Image

        If ImageCache.ContainsKey(internalId) Then Return ImageCache(internalId)

        Try
            Dim img = CType(My.Resources.ResourceManager.GetObject(internalId), Image)
            If img IsNot Nothing Then ImageCache.Add(internalId, img)
            Return img
        Catch
            Return Nothing
        End Try

    End Function

    Private Sub RecruitMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If ComboBoxWindows.SelectedIndex > 0 Then
            My.Settings.LastProcess = ComboBoxWindows.Text
        End If

        My.Settings.Exclude1Star = CheckBox1Star.Checked()
        My.Settings.Exclude2Star = CheckBox2Star.Checked()

    End Sub

     <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowRect(hWnd As IntPtr, ByRef lpRect As RECT) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(hWnd As IntPtr) As Boolean
    End Function

    <DllImport("uxtheme.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SetWindowTheme(hwnd As IntPtr, pszSubAppName As String, pszSubIdList As String) As Integer
    End Function

    <DllImport("dwmapi.dll")>
    Private Shared Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, <[In]> ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    'crop helper: takes bitmap and returns the cropped region
    Private Function CropBitmap(src As Bitmap, leftPct As Double, topPct As Double, rightPct As Double, bottomPct As Double) As Bitmap
        Dim cropLeft As Integer = CInt(src.Width * leftPct)
        Dim cropTop As Integer = CInt(src.Height * topPct)
        Dim cropRight As Integer = CInt(src.Width * rightPct)
        Dim cropBottom As Integer = CInt(src.Height * bottomPct)

        Dim cropWidth As Integer = src.Width - cropLeft - cropRight
        Dim cropHeight As Integer = src.Height - cropTop - cropBottom

        Dim target As New Bitmap(cropWidth, cropHeight)

        Using g As Graphics = Graphics.FromImage(target)
            g.DrawImage(src, New Rectangle(0, 0, cropWidth, cropHeight),
                    New Rectangle(cropLeft, cropTop, cropWidth, cropHeight),
                    GraphicsUnit.Pixel)
        End Using

        Return target
    End Function

    'async helper: convert WinRT IAsyncOperation(Of T) to Task(Of T)
    Private Function AsTask(Of T)(operation As IAsyncOperation(Of T)) As Task(Of T)
        Dim tcs As New TaskCompletionSource(Of T)()
        operation.Completed = Sub(op, status)
                                  Select Case status
                                      Case AsyncStatus.Completed
                                          Try
                                              tcs.SetResult(op.GetResults())
                                          Catch ex As Exception
                                              tcs.SetException(ex)
                                          End Try
                                      Case AsyncStatus.Error
                                          tcs.SetException(New Exception("Async operation failed"))
                                      Case AsyncStatus.Canceled
                                          tcs.SetCanceled()
                                  End Select
                              End Sub
        Return tcs.Task
    End Function

    'task helper: convert WinRT IAsyncAction to Task
    Private Function AsTask(operation As IAsyncAction) As Task
        Dim tcs As New TaskCompletionSource(Of Object)()
        operation.Completed = Sub(op, status)
                                  Select Case status
                                      Case AsyncStatus.Completed
                                          tcs.SetResult(Nothing)
                                      Case AsyncStatus.Error
                                          tcs.SetException(New Exception("Async action failed"))
                                      Case AsyncStatus.Canceled
                                          tcs.SetCanceled()
                                  End Select
                              End Sub
        Return tcs.Task
    End Function

    'steam helper: write .net stream bytes into InMemoryRandomAccessStream
    Private Async Function AsRandomAccessStreamFromStreamAsync(stream As Stream) As Task(Of IRandomAccessStream)
        Dim ras As New InMemoryRandomAccessStream()
        Dim writer As New DataWriter(ras.GetOutputStreamAt(0))

        Dim buffer As Byte()
        If TypeOf stream Is MemoryStream Then
            buffer = DirectCast(stream, MemoryStream).ToArray()
        Else
            Using ms2 As New MemoryStream()
                stream.CopyTo(ms2)
                buffer = ms2.ToArray()
            End Using
        End If

        writer.WriteBytes(buffer)
        Await AsTask(writer.StoreAsync())
        writer.DetachStream()
        ras.Seek(0)
        Return ras
    End Function

End Class

Public Module RecruitmentLogic

    'generate valid tag combinations
    Private Function GetTagSubsets(tags As List(Of String)) As List(Of List(Of String))
        Dim result As New List(Of List(Of String))
        Dim count = 2 ^ tags.Count
        For i = 1 To count - 1
            Dim subset As New List(Of String)
            For j = 0 To tags.Count - 1
                If (i And (1 << j)) <> 0 Then subset.Add(tags(j))
            Next
            result.Add(subset)
        Next
        Return result
    End Function

    Public Function CalculateRecruitCombos(allOps As List(Of OperatorData), selectedTags As List(Of String),
                                           Optional excludedRarities As IEnumerable(Of Integer) = Nothing) As List(Of RecruitCombo)

        Dim excludeSet As HashSet(Of Integer) = Nothing
        If excludedRarities IsNot Nothing Then
            excludeSet = New HashSet(Of Integer)(excludedRarities)
        End If

        Dim results As New List(Of RecruitCombo)
        Dim hasTopOp As Boolean = selectedTags.Any(Function(t) t.Equals("Top Operator", StringComparison.OrdinalIgnoreCase))
        Dim hasSeniorOp As Boolean = selectedTags.Any(Function(t) t.Equals("Senior Operator", StringComparison.OrdinalIgnoreCase))
        Dim allCombos = GetTagSubsets(selectedTags)

        For Each combo In allCombos
            Dim matches = allOps.Where(Function(op)
                                           If hasTopOp Then
                                               If op.Rarity < 6 Then Return False
                                           ElseIf hasSeniorOp Then
                                               If op.Rarity <> 5 Then Return False
                                           Else
                                               If op.Rarity = 6 Then Return False
                                           End If

                                           Dim effectiveTags As New List(Of String)(op.TagList) From {
                                           op.Role,
                                           op.Position
                                           }

                                           Return combo.All(Function(tag) effectiveTags.Contains(tag, StringComparer.OrdinalIgnoreCase))
                                       End Function).ToList()

            If excludeSet IsNot Nothing Then
                matches = matches.Where(Function(op) Not excludeSet.Contains(op.Rarity)).ToList()
            End If
            If Not matches.Any() Then
                Continue For
            End If

            If matches.Any() Then
                Dim finalTags As New List(Of String)(combo)

                'top/senior are not operator tags so we need to put them in
                If hasTopOp AndAlso Not finalTags.Contains("Top Operator") Then
                    finalTags.Add("Top Operator")
                End If
                If hasSeniorOp AndAlso Not finalTags.Contains("Senior Operator") Then
                    finalTags.Add("Senior Operator")
                End If

                If finalTags.Count > 3 Then
                    'we can only pick up to 3 tags, 4+ tag combos are not valid
                Else
                    Dim rc As New RecruitCombo With {
                        .Tags = finalTags,
                        .Operators = matches,
                        .MinStar = matches.Min(Function(o) o.Rarity),
                        .MaxStar = matches.Max(Function(o) o.Rarity),
                        .Guarantee = (matches.Count = 1)
                    }
                    results.Add(rc)
                End If
            End If
        Next

        For Each r In results
            r.SortScore = GetComboPriority(r)
        Next

        results = results _
        .OrderByDescending(Function(r) r.SortScore) _
        .ThenBy(Function(r) r.Operators.Count) _
        .ThenBy(Function(r) r.Tags.Count) _
        .ToList()

        Return results
    End Function

    Private Function GetComboPriority(r As RecruitCombo) As Integer

        Select Case True
            Case r.MaxStar = 6 AndAlso r.Guarantee : Return 900
            Case r.MaxStar = 6 : Return 850

            Case r.MaxStar = 5 AndAlso r.Guarantee : Return 800
            Case r.MaxStar = 5 AndAlso r.MinStar = 5 : Return 750

            Case r.MaxStar = 5 AndAlso r.MinStar = 4 : Return 700
            Case r.MaxStar = 4 AndAlso r.Guarantee : Return 650
            Case r.MaxStar = 4 AndAlso r.MinStar = 4 : Return 600

            Case r.MaxStar = 4 AndAlso r.MinStar = 3 : Return 550
            Case r.MaxStar = 3 AndAlso r.MinStar = 3 : Return 450

            Case r.MaxStar = 3 AndAlso r.MinStar = 2 : Return 400

            'robots!!
            Case r.MaxStar = 1 : Return 200

            Case r.MaxStar = 2 : Return 150

            Case Else : Return (r.MinStar * 10) + r.MaxStar
        End Select

    End Function

End Module