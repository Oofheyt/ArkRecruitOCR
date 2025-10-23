Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports RecruitOCR.RecruitMain
Imports Windows.Foundation
Imports Windows.Storage.Streams

Public Class Settings

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxWindows.DisplayMember = "Title"
        ComboBoxWindows.ValueMember = "Handle"

        NumericUpDownLeft.Value = My.Settings.CropLeft
        NumericUpDownTop.Value = My.Settings.CropTop
        NumericUpDownRight.Value = My.Settings.CropRight
        NumericUpDownBottom.Value = My.Settings.CropBottom
        NumericUpDownFuzzy.Value = My.Settings.FuzzyDist
        TrackBarDelay.Value = My.Settings.Delay

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

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        My.Settings.CropLeft = NumericUpDownLeft.Value
        My.Settings.CropTop = NumericUpDownTop.Value
        My.Settings.CropRight = NumericUpDownRight.Value
        My.Settings.CropBottom = NumericUpDownBottom.Value
        My.Settings.FuzzyDist = NumericUpDownFuzzy.Value
        My.Settings.Delay = TrackBarDelay.Value
        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

        Me.Close()

    End Sub

    Private Sub FormSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        RecruitMain.ComboBoxWindows.Items.Clear()

        For Each item In ComboBoxWindows.Items
            RecruitMain.ComboBoxWindows.Items.Add(item)
        Next

        If ComboBoxWindows.SelectedIndex >= 0 Then
            RecruitMain.ComboBoxWindows.SelectedIndex = ComboBoxWindows.SelectedIndex
        End If

        PictureBoxOCRPreview.Image = My.Resources.tagtemplate

    End Sub

    Private Async Sub ButtonTestImage_Click(sender As Object, e As EventArgs) Handles ButtonTestImage.Click
        If ComboBoxWindows.SelectedIndex = 0 Then
            MessageBox.Show("Select a process first", "No process selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selected = ComboBoxWindows.SelectedItem
        Dim targetHwnd As IntPtr = selected.Handle

        SetForegroundWindow(targetHwnd)
        Await Task.Delay(TrackBarDelay.Value)

        Dim rect As RECT
        If Not GetWindowRect(targetHwnd, rect) Then
            MessageBox.Show("Failed to get window rect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim width As Integer = Math.Max(1, rect.Right - rect.Left)
        Dim height As Integer = Math.Max(1, rect.Bottom - rect.Top)

        Try
            Using bmp As New Bitmap(width, height, PixelFormat.Format32bppArgb)
                Using g As Graphics = Graphics.FromImage(bmp)
                    g.CopyFromScreen(rect.Left, rect.Top, 0, 0, New Size(width, height), CopyPixelOperation.SourceCopy)
                End Using
                Dim leftCrop As Double = NumericUpDownLeft.Value / 100
                Dim topCrop As Double = NumericUpDownTop.Value / 100
                Dim rightCrop As Double = NumericUpDownRight.Value / 100
                Dim bottomCrop As Double = NumericUpDownBottom.Value / 100

                Using cropped As Bitmap = CropBitmap(bmp, leftCrop, topCrop, rightCrop, bottomCrop)
                    PictureBoxOCRPreview.Image = DirectCast(cropped.Clone(), Bitmap)
                    If cropped.Size.Height <= 30 Then
                        NotifyTestBlank.Visible = True
                    End If
                End Using
            End Using
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "OCR match error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If PictureBoxOCRPreview.Image IsNot Nothing Then
            PictureBoxOCRPreview.BackgroundImage = Nothing
        End If

        Me.Activate()

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click

        RefreshProcList()

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click

        Dim result As DialogResult = MessageBox.Show("This will reset all OCR settings to default values. Do you want to proceed?", "Reset settings", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then
            NumericUpDownTop.Value = 50
            NumericUpDownBottom.Value = 32
            NumericUpDownLeft.Value = 29
            NumericUpDownRight.Value = 33
            NumericUpDownFuzzy.Value = 2
            TrackBarDelay.Value = 10
            PictureBoxOCRPreview.BackgroundImage = My.Resources.tagtemplate
            PictureBoxOCRPreview.Image = Nothing
        Else
            ':)
        End If

    End Sub

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowRect(hWnd As IntPtr, ByRef lpRect As RECT) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(hWnd As IntPtr) As Boolean
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