<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NightForm1 = New ReaLTaiizor.Forms.NightForm()
        Me.ButtonCancel = New ReaLTaiizor.Controls.ForeverButton()
        Me.ButtonSave = New ReaLTaiizor.Controls.ForeverButton()
        Me.ForeverGroupBox2 = New ReaLTaiizor.Controls.ForeverGroupBox()
        Me.NotifyTestBlank = New ReaLTaiizor.Controls.ForeverNotification()
        Me.ButtonTestImage = New ReaLTaiizor.Controls.ForeverButton()
        Me.ButtonReset = New ReaLTaiizor.Controls.ForeverButton()
        Me.NumericUpDownFuzzy = New ReaLTaiizor.Controls.CrownNumeric()
        Me.NumericUpDownLeft = New ReaLTaiizor.Controls.CrownNumeric()
        Me.NumericUpDownBottom = New ReaLTaiizor.Controls.CrownNumeric()
        Me.NumericUpDownRight = New ReaLTaiizor.Controls.CrownNumeric()
        Me.NumericUpDownTop = New ReaLTaiizor.Controls.CrownNumeric()
        Me.TrackBarDelay = New ReaLTaiizor.Controls.ForeverTrackBar()
        Me.ButtonClose = New ReaLTaiizor.Controls.ForeverClose()
        Me.ForeverGroupBox1 = New ReaLTaiizor.Controls.ForeverGroupBox()
        Me.ComboBoxWindows = New ReaLTaiizor.Controls.ForeverComboBox()
        Me.ButtonRefresh = New ReaLTaiizor.Controls.ForeverButton()
        Me.PoisonToolTip1 = New ReaLTaiizor.Controls.PoisonToolTip()
        Me.PictureBoxOCRPreview = New System.Windows.Forms.PictureBox()
        Me.NightForm1.SuspendLayout()
        Me.ForeverGroupBox2.SuspendLayout()
        CType(Me.NumericUpDownFuzzy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ForeverGroupBox1.SuspendLayout()
        CType(Me.PictureBoxOCRPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Capture delay (ms):"
        Me.PoisonToolTip1.SetToolTip(Me.Label7, "Increase this if your chosen window" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "doesn't appear in time for the OCR.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fuzzy distance:"
        Me.PoisonToolTip1.SetToolTip(Me.Label2, "OCR can edit a misread word match up to a tag." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only increase if your OCR struggl" &
        "es to match words." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Examples:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Media"" > ""Medic"" = 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Meaty"" > ""Melee"" = 3")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Crop adjust (%)"
        Me.PoisonToolTip1.SetToolTip(Me.Label1, "Adjust the crop % until the tags" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fill the space like the example.")
        '
        'NightForm1
        '
        Me.NightForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.NightForm1.Controls.Add(Me.ButtonCancel)
        Me.NightForm1.Controls.Add(Me.ButtonSave)
        Me.NightForm1.Controls.Add(Me.ForeverGroupBox2)
        Me.NightForm1.Controls.Add(Me.ButtonClose)
        Me.NightForm1.Controls.Add(Me.ForeverGroupBox1)
        Me.NightForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NightForm1.DrawIcon = False
        Me.NightForm1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NightForm1.HeadColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.NightForm1.Location = New System.Drawing.Point(0, 0)
        Me.NightForm1.MinimumSize = New System.Drawing.Size(100, 42)
        Me.NightForm1.Name = "NightForm1"
        Me.NightForm1.Padding = New System.Windows.Forms.Padding(0, 31, 0, 0)
        Me.NightForm1.Size = New System.Drawing.Size(453, 502)
        Me.NightForm1.TabIndex = 29
        Me.NightForm1.Text = "Settings"
        Me.NightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Center
        Me.NightForm1.TitleBarTextColor = System.Drawing.Color.Gainsboro
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCancel.BaseColor = System.Drawing.Color.Gray
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonCancel.Location = New System.Drawing.Point(267, 451)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Rounded = True
        Me.ButtonCancel.Size = New System.Drawing.Size(95, 34)
        Me.ButtonCancel.TabIndex = 31
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.TextColor = System.Drawing.Color.White
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonSave.Location = New System.Drawing.Point(90, 451)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Rounded = True
        Me.ButtonSave.Size = New System.Drawing.Size(95, 34)
        Me.ButtonSave.TabIndex = 30
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.TextColor = System.Drawing.Color.White
        '
        'ForeverGroupBox2
        '
        Me.ForeverGroupBox2.ArrowColorF = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ForeverGroupBox2.ArrowColorH = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ForeverGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.ForeverGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ForeverGroupBox2.Controls.Add(Me.NotifyTestBlank)
        Me.ForeverGroupBox2.Controls.Add(Me.ButtonTestImage)
        Me.ForeverGroupBox2.Controls.Add(Me.ButtonReset)
        Me.ForeverGroupBox2.Controls.Add(Me.NumericUpDownFuzzy)
        Me.ForeverGroupBox2.Controls.Add(Me.NumericUpDownLeft)
        Me.ForeverGroupBox2.Controls.Add(Me.NumericUpDownBottom)
        Me.ForeverGroupBox2.Controls.Add(Me.NumericUpDownRight)
        Me.ForeverGroupBox2.Controls.Add(Me.NumericUpDownTop)
        Me.ForeverGroupBox2.Controls.Add(Me.TrackBarDelay)
        Me.ForeverGroupBox2.Controls.Add(Me.PictureBoxOCRPreview)
        Me.ForeverGroupBox2.Controls.Add(Me.Label7)
        Me.ForeverGroupBox2.Controls.Add(Me.Label1)
        Me.ForeverGroupBox2.Controls.Add(Me.Label2)
        Me.ForeverGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeverGroupBox2.Location = New System.Drawing.Point(0, 125)
        Me.ForeverGroupBox2.Name = "ForeverGroupBox2"
        Me.ForeverGroupBox2.ShowArrow = True
        Me.ForeverGroupBox2.ShowText = True
        Me.ForeverGroupBox2.Size = New System.Drawing.Size(453, 318)
        Me.ForeverGroupBox2.TabIndex = 29
        Me.ForeverGroupBox2.Text = "OCR"
        Me.ForeverGroupBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer))
        '
        'NotifyTestBlank
        '
        Me.NotifyTestBlank.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.NotifyTestBlank.Close = True
        Me.NotifyTestBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NotifyTestBlank.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NotifyTestBlank.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Info
        Me.NotifyTestBlank.Location = New System.Drawing.Point(22, 198)
        Me.NotifyTestBlank.Name = "NotifyTestBlank"
        Me.NotifyTestBlank.Size = New System.Drawing.Size(419, 42)
        Me.NotifyTestBlank.TabIndex = 30
        Me.NotifyTestBlank.Text = "Blank image? Make sure your window is not minimised!"
        Me.NotifyTestBlank.Visible = False
        '
        'ButtonTestImage
        '
        Me.ButtonTestImage.BackColor = System.Drawing.Color.Transparent
        Me.ButtonTestImage.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ButtonTestImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTestImage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonTestImage.Location = New System.Drawing.Point(179, 266)
        Me.ButtonTestImage.Name = "ButtonTestImage"
        Me.ButtonTestImage.Rounded = True
        Me.ButtonTestImage.Size = New System.Drawing.Size(95, 34)
        Me.ButtonTestImage.TabIndex = 29
        Me.ButtonTestImage.Text = "Test image"
        Me.ButtonTestImage.TextColor = System.Drawing.Color.White
        '
        'ButtonReset
        '
        Me.ButtonReset.BackColor = System.Drawing.Color.Transparent
        Me.ButtonReset.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReset.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ButtonReset.Location = New System.Drawing.Point(358, 273)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Rounded = True
        Me.ButtonReset.Size = New System.Drawing.Size(76, 27)
        Me.ButtonReset.TabIndex = 28
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.TextColor = System.Drawing.Color.White
        '
        'NumericUpDownFuzzy
        '
        Me.NumericUpDownFuzzy.Location = New System.Drawing.Point(147, 70)
        Me.NumericUpDownFuzzy.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownFuzzy.Name = "NumericUpDownFuzzy"
        Me.NumericUpDownFuzzy.Size = New System.Drawing.Size(49, 25)
        Me.NumericUpDownFuzzy.TabIndex = 25
        Me.PoisonToolTip1.SetToolTip(Me.NumericUpDownFuzzy, "OCR can edit a misread word match up to a tag." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only increase if your OCR struggl" &
        "es to match words." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Examples:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Media"" > ""Medic"" = 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Meaty"" > ""Melee"" = 3")
        Me.NumericUpDownFuzzy.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NumericUpDownLeft
        '
        Me.NumericUpDownLeft.DecimalPlaces = 1
        Me.NumericUpDownLeft.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownLeft.Location = New System.Drawing.Point(21, 181)
        Me.NumericUpDownLeft.Maximum = New Decimal(New Integer() {499, 0, 0, 65536})
        Me.NumericUpDownLeft.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownLeft.Name = "NumericUpDownLeft"
        Me.NumericUpDownLeft.Size = New System.Drawing.Size(49, 25)
        Me.NumericUpDownLeft.TabIndex = 24
        Me.PoisonToolTip1.SetToolTip(Me.NumericUpDownLeft, "Adjust the crop % until the tags" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fill the space like the example.")
        Me.NumericUpDownLeft.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'NumericUpDownBottom
        '
        Me.NumericUpDownBottom.DecimalPlaces = 1
        Me.NumericUpDownBottom.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownBottom.Location = New System.Drawing.Point(202, 235)
        Me.NumericUpDownBottom.Maximum = New Decimal(New Integer() {399, 0, 0, 65536})
        Me.NumericUpDownBottom.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownBottom.Name = "NumericUpDownBottom"
        Me.NumericUpDownBottom.Size = New System.Drawing.Size(49, 25)
        Me.NumericUpDownBottom.TabIndex = 23
        Me.PoisonToolTip1.SetToolTip(Me.NumericUpDownBottom, "Adjust the crop % until the tags" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fill the space like the example.")
        Me.NumericUpDownBottom.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'NumericUpDownRight
        '
        Me.NumericUpDownRight.DecimalPlaces = 1
        Me.NumericUpDownRight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownRight.Location = New System.Drawing.Point(382, 181)
        Me.NumericUpDownRight.Maximum = New Decimal(New Integer() {499, 0, 0, 65536})
        Me.NumericUpDownRight.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownRight.Name = "NumericUpDownRight"
        Me.NumericUpDownRight.Size = New System.Drawing.Size(49, 25)
        Me.NumericUpDownRight.TabIndex = 22
        Me.PoisonToolTip1.SetToolTip(Me.NumericUpDownRight, "Adjust the crop % until the tags" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fill the space like the example.")
        Me.NumericUpDownRight.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'NumericUpDownTop
        '
        Me.NumericUpDownTop.DecimalPlaces = 1
        Me.NumericUpDownTop.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownTop.Location = New System.Drawing.Point(202, 128)
        Me.NumericUpDownTop.Maximum = New Decimal(New Integer() {599, 0, 0, 65536})
        Me.NumericUpDownTop.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownTop.Name = "NumericUpDownTop"
        Me.NumericUpDownTop.Size = New System.Drawing.Size(49, 25)
        Me.NumericUpDownTop.TabIndex = 21
        Me.PoisonToolTip1.SetToolTip(Me.NumericUpDownTop, "Adjust the crop % until the tags" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fill the space like the example.")
        Me.NumericUpDownTop.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'TrackBarDelay
        '
        Me.TrackBarDelay.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TrackBarDelay.BaseColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TrackBarDelay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBarDelay.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TrackBarDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TrackBarDelay.HatchColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TrackBarDelay.Location = New System.Drawing.Point(147, 41)
        Me.TrackBarDelay.Maximum = 150
        Me.TrackBarDelay.Minimum = 0
        Me.TrackBarDelay.Name = "TrackBarDelay"
        Me.TrackBarDelay.ShowValue = True
        Me.TrackBarDelay.Size = New System.Drawing.Size(258, 23)
        Me.TrackBarDelay.SliderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.TrackBarDelay.Style = ReaLTaiizor.Controls.ForeverTrackBar._Style.Slider
        Me.TrackBarDelay.TabIndex = 20
        Me.TrackBarDelay.Text = "ForeverTrackBar1"
        Me.PoisonToolTip1.SetToolTip(Me.TrackBarDelay, "Increase this if your chosen window" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "doesn't appear in time for the OCR.")
        Me.TrackBarDelay.TrackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TrackBarDelay.Value = 10
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.White
        Me.ButtonClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.DefaultLocation = False
        Me.ButtonClose.DownColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonClose.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.ButtonClose.Location = New System.Drawing.Point(429, 7)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.OverColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonClose.Size = New System.Drawing.Size(18, 18)
        Me.ButtonClose.TabIndex = 25
        Me.ButtonClose.Text = "ForeverClose1"
        Me.ButtonClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ForeverGroupBox1
        '
        Me.ForeverGroupBox1.ArrowColorF = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ForeverGroupBox1.ArrowColorH = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ForeverGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.ForeverGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ForeverGroupBox1.Controls.Add(Me.ComboBoxWindows)
        Me.ForeverGroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.ForeverGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeverGroupBox1.Location = New System.Drawing.Point(0, 44)
        Me.ForeverGroupBox1.Name = "ForeverGroupBox1"
        Me.ForeverGroupBox1.ShowArrow = True
        Me.ForeverGroupBox1.ShowText = True
        Me.ForeverGroupBox1.Size = New System.Drawing.Size(453, 87)
        Me.ForeverGroupBox1.TabIndex = 28
        Me.ForeverGroupBox1.Text = "Window"
        Me.ForeverGroupBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(220, Byte), Integer))
        '
        'ComboBoxWindows
        '
        Me.ComboBoxWindows.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ComboBoxWindows.BGColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ComboBoxWindows.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxWindows.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxWindows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxWindows.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ComboBoxWindows.ForeColor = System.Drawing.Color.White
        Me.ComboBoxWindows.FormattingEnabled = True
        Me.ComboBoxWindows.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ComboBoxWindows.HoverFontColor = System.Drawing.Color.White
        Me.ComboBoxWindows.ItemHeight = 18
        Me.ComboBoxWindows.Location = New System.Drawing.Point(18, 39)
        Me.ComboBoxWindows.MaxDropDownItems = 100
        Me.ComboBoxWindows.Name = "ComboBoxWindows"
        Me.ComboBoxWindows.Size = New System.Drawing.Size(338, 24)
        Me.ComboBoxWindows.Sorted = True
        Me.ComboBoxWindows.TabIndex = 26
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRefresh.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ButtonRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonRefresh.Location = New System.Drawing.Point(365, 33)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Rounded = True
        Me.ButtonRefresh.Size = New System.Drawing.Size(69, 34)
        Me.ButtonRefresh.TabIndex = 27
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextColor = System.Drawing.Color.White
        '
        'PoisonToolTip1
        '
        Me.PoisonToolTip1.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.PoisonToolTip1.StyleManager = Nothing
        Me.PoisonToolTip1.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        '
        'PictureBoxOCRPreview
        '
        Me.PictureBoxOCRPreview.BackColor = System.Drawing.Color.IndianRed
        Me.PictureBoxOCRPreview.BackgroundImage = CType(resources.GetObject("PictureBoxOCRPreview.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxOCRPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxOCRPreview.Location = New System.Drawing.Point(76, 156)
        Me.PictureBoxOCRPreview.Name = "PictureBoxOCRPreview"
        Me.PictureBoxOCRPreview.Size = New System.Drawing.Size(300, 75)
        Me.PictureBoxOCRPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxOCRPreview.TabIndex = 2
        Me.PictureBoxOCRPreview.TabStop = False
        Me.PoisonToolTip1.SetToolTip(Me.PictureBoxOCRPreview, "Adjust the crop % until the tags" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fill the space like the example.")
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 502)
        Me.Controls.Add(Me.NightForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(2560, 1392)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(126, 50)
        Me.Name = "Settings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormTheme1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NightForm1.ResumeLayout(False)
        Me.ForeverGroupBox2.ResumeLayout(False)
        Me.ForeverGroupBox2.PerformLayout()
        CType(Me.NumericUpDownFuzzy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ForeverGroupBox1.ResumeLayout(False)
        CType(Me.PictureBoxOCRPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxOCRPreview As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NightForm1 As ReaLTaiizor.Forms.NightForm
    Friend WithEvents ButtonClose As ReaLTaiizor.Controls.ForeverClose
    Friend WithEvents ButtonRefresh As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents ComboBoxWindows As ReaLTaiizor.Controls.ForeverComboBox
    Friend WithEvents ForeverGroupBox1 As ReaLTaiizor.Controls.ForeverGroupBox
    Friend WithEvents ForeverGroupBox2 As ReaLTaiizor.Controls.ForeverGroupBox
    Friend WithEvents TrackBarDelay As ReaLTaiizor.Controls.ForeverTrackBar
    Friend WithEvents NumericUpDownTop As ReaLTaiizor.Controls.CrownNumeric
    Friend WithEvents NumericUpDownLeft As ReaLTaiizor.Controls.CrownNumeric
    Friend WithEvents NumericUpDownBottom As ReaLTaiizor.Controls.CrownNumeric
    Friend WithEvents NumericUpDownRight As ReaLTaiizor.Controls.CrownNumeric
    Friend WithEvents NumericUpDownFuzzy As ReaLTaiizor.Controls.CrownNumeric
    Friend WithEvents ButtonTestImage As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents ButtonReset As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents ButtonCancel As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents ButtonSave As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents PoisonToolTip1 As ReaLTaiizor.Controls.PoisonToolTip
    Friend WithEvents NotifyTestBlank As ReaLTaiizor.Controls.ForeverNotification
End Class
