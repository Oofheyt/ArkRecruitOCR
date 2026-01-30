<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecruitMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecruitMain))
        Me.FlowLayoutPanelResults = New System.Windows.Forms.FlowLayoutPanel()
        Me.ForeverForm1 = New ReaLTaiizor.Forms.ForeverForm()
        Me.ButtonStart = New ReaLTaiizor.Controls.ForeverButton()
        Me.ForeverMinimize1 = New ReaLTaiizor.Controls.ForeverMinimize()
        Me.ForeverClose1 = New ReaLTaiizor.Controls.ForeverClose()
        Me.ForeverGroupBox1 = New ReaLTaiizor.Controls.ForeverGroupBox()
        Me.ForeverTextBox6 = New ReaLTaiizor.Controls.ForeverTextBox()
        Me.ForeverTextBox5 = New ReaLTaiizor.Controls.ForeverTextBox()
        Me.ForeverTextBox4 = New ReaLTaiizor.Controls.ForeverTextBox()
        Me.ForeverTextBox3 = New ReaLTaiizor.Controls.ForeverTextBox()
        Me.ForeverTextBox2 = New ReaLTaiizor.Controls.ForeverTextBox()
        Me.ForeverTextBox1 = New ReaLTaiizor.Controls.ForeverTextBox()
        Me.ForeverGroupBox2 = New ReaLTaiizor.Controls.ForeverGroupBox()
        Me.ButtonOCRSettings = New ReaLTaiizor.Controls.ForeverButton()
        Me.CheckBox2Star = New ReaLTaiizor.Controls.ForeverCheckBox()
        Me.CheckBox1Star = New ReaLTaiizor.Controls.ForeverCheckBox()
        Me.ButtonRefresh = New ReaLTaiizor.Controls.ForeverButton()
        Me.ComboBoxWindows = New ReaLTaiizor.Controls.ForeverComboBox()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.ForeverForm1.SuspendLayout()
        Me.ForeverGroupBox1.SuspendLayout()
        Me.ForeverGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanelResults
        '
        Me.FlowLayoutPanelResults.AutoScroll = True
        Me.FlowLayoutPanelResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.FlowLayoutPanelResults.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelResults.Location = New System.Drawing.Point(13, 188)
        Me.FlowLayoutPanelResults.Name = "FlowLayoutPanelResults"
        Me.FlowLayoutPanelResults.Size = New System.Drawing.Size(934, 415)
        Me.FlowLayoutPanelResults.TabIndex = 7
        Me.FlowLayoutPanelResults.WrapContents = False
        '
        'ForeverForm1
        '
        Me.ForeverForm1.BackColor = System.Drawing.Color.White
        Me.ForeverForm1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ForeverForm1.BorderColor = System.Drawing.Color.RoyalBlue
        Me.ForeverForm1.Controls.Add(Me.ButtonStart)
        Me.ForeverForm1.Controls.Add(Me.ForeverMinimize1)
        Me.ForeverForm1.Controls.Add(Me.ForeverClose1)
        Me.ForeverForm1.Controls.Add(Me.ForeverGroupBox1)
        Me.ForeverForm1.Controls.Add(Me.ForeverGroupBox2)
        Me.ForeverForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeverForm1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeverForm1.ForeverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ForeverForm1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ForeverForm1.HeaderMaximize = False
        Me.ForeverForm1.HeaderTextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeverForm1.Image = Global.RecruitOCR.My.Resources.Resources.Recruitment_Permit_Tiny
        Me.ForeverForm1.Location = New System.Drawing.Point(0, 0)
        Me.ForeverForm1.MinimumSize = New System.Drawing.Size(210, 50)
        Me.ForeverForm1.Name = "ForeverForm1"
        Me.ForeverForm1.Padding = New System.Windows.Forms.Padding(1, 51, 1, 1)
        Me.ForeverForm1.Sizable = False
        Me.ForeverForm1.Size = New System.Drawing.Size(960, 615)
        Me.ForeverForm1.TabIndex = 23
        Me.ForeverForm1.TabStop = False
        Me.ForeverForm1.Text = "RecruitOCR"
        Me.ForeverForm1.TextColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ForeverForm1.TextLight = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(56, Byte), Integer))
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.Transparent
        Me.ButtonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonStart.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStart.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonStart.Location = New System.Drawing.Point(37, 84)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Rounded = True
        Me.ButtonStart.Size = New System.Drawing.Size(105, 69)
        Me.ButtonStart.TabIndex = 1
        Me.ButtonStart.Text = "Start OCR"
        Me.ButtonStart.TextColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        '
        'ForeverMinimize1
        '
        Me.ForeverMinimize1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ForeverMinimize1.BackColor = System.Drawing.Color.White
        Me.ForeverMinimize1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ForeverMinimize1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeverMinimize1.DefaultLocation = False
        Me.ForeverMinimize1.DownColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ForeverMinimize1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.ForeverMinimize1.Location = New System.Drawing.Point(899, 16)
        Me.ForeverMinimize1.Name = "ForeverMinimize1"
        Me.ForeverMinimize1.OverColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ForeverMinimize1.Size = New System.Drawing.Size(18, 18)
        Me.ForeverMinimize1.TabIndex = 25
        Me.ForeverMinimize1.TabStop = False
        Me.ForeverMinimize1.Text = "ForeverMinimize1"
        Me.ForeverMinimize1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ForeverClose1
        '
        Me.ForeverClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ForeverClose1.BackColor = System.Drawing.Color.White
        Me.ForeverClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ForeverClose1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeverClose1.DefaultLocation = True
        Me.ForeverClose1.DownColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ForeverClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.ForeverClose1.Location = New System.Drawing.Point(930, 16)
        Me.ForeverClose1.Name = "ForeverClose1"
        Me.ForeverClose1.OverColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ForeverClose1.Size = New System.Drawing.Size(18, 18)
        Me.ForeverClose1.TabIndex = 24
        Me.ForeverClose1.TabStop = False
        Me.ForeverClose1.Text = "ForeverClose1"
        Me.ForeverClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ForeverGroupBox1
        '
        Me.ForeverGroupBox1.ArrowColorF = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ForeverGroupBox1.ArrowColorH = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ForeverGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.ForeverGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ForeverGroupBox1.Controls.Add(Me.LabelError)
        Me.ForeverGroupBox1.Controls.Add(Me.ForeverTextBox6)
        Me.ForeverGroupBox1.Controls.Add(Me.ForeverTextBox5)
        Me.ForeverGroupBox1.Controls.Add(Me.ForeverTextBox4)
        Me.ForeverGroupBox1.Controls.Add(Me.ForeverTextBox3)
        Me.ForeverGroupBox1.Controls.Add(Me.ForeverTextBox2)
        Me.ForeverGroupBox1.Controls.Add(Me.ForeverTextBox1)
        Me.ForeverGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeverGroupBox1.Location = New System.Drawing.Point(165, 57)
        Me.ForeverGroupBox1.Name = "ForeverGroupBox1"
        Me.ForeverGroupBox1.ShowArrow = True
        Me.ForeverGroupBox1.ShowText = True
        Me.ForeverGroupBox1.Size = New System.Drawing.Size(386, 128)
        Me.ForeverGroupBox1.TabIndex = 22
        Me.ForeverGroupBox1.TabStop = False
        Me.ForeverGroupBox1.Text = "Tags found"
        Me.ForeverGroupBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        '
        'ForeverTextBox6
        '
        Me.ForeverTextBox6.BackColor = System.Drawing.Color.Transparent
        Me.ForeverTextBox6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ForeverTextBox6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ForeverTextBox6.Enabled = False
        Me.ForeverTextBox6.FocusOnHover = False
        Me.ForeverTextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ForeverTextBox6.Location = New System.Drawing.Point(254, 77)
        Me.ForeverTextBox6.MaxLength = 32767
        Me.ForeverTextBox6.Multiline = False
        Me.ForeverTextBox6.Name = "ForeverTextBox6"
        Me.ForeverTextBox6.ReadOnly = False
        Me.ForeverTextBox6.Size = New System.Drawing.Size(110, 29)
        Me.ForeverTextBox6.TabIndex = 5
        Me.ForeverTextBox6.TabStop = False
        Me.ForeverTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ForeverTextBox6.UseSystemPasswordChar = False
        '
        'ForeverTextBox5
        '
        Me.ForeverTextBox5.BackColor = System.Drawing.Color.Transparent
        Me.ForeverTextBox5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ForeverTextBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ForeverTextBox5.Enabled = False
        Me.ForeverTextBox5.FocusOnHover = False
        Me.ForeverTextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ForeverTextBox5.Location = New System.Drawing.Point(254, 42)
        Me.ForeverTextBox5.MaxLength = 32767
        Me.ForeverTextBox5.Multiline = False
        Me.ForeverTextBox5.Name = "ForeverTextBox5"
        Me.ForeverTextBox5.ReadOnly = False
        Me.ForeverTextBox5.Size = New System.Drawing.Size(110, 29)
        Me.ForeverTextBox5.TabIndex = 4
        Me.ForeverTextBox5.TabStop = False
        Me.ForeverTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ForeverTextBox5.UseSystemPasswordChar = False
        '
        'ForeverTextBox4
        '
        Me.ForeverTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.ForeverTextBox4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ForeverTextBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ForeverTextBox4.Enabled = False
        Me.ForeverTextBox4.FocusOnHover = False
        Me.ForeverTextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ForeverTextBox4.Location = New System.Drawing.Point(138, 77)
        Me.ForeverTextBox4.MaxLength = 32767
        Me.ForeverTextBox4.Multiline = False
        Me.ForeverTextBox4.Name = "ForeverTextBox4"
        Me.ForeverTextBox4.ReadOnly = False
        Me.ForeverTextBox4.Size = New System.Drawing.Size(110, 29)
        Me.ForeverTextBox4.TabIndex = 3
        Me.ForeverTextBox4.TabStop = False
        Me.ForeverTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ForeverTextBox4.UseSystemPasswordChar = False
        '
        'ForeverTextBox3
        '
        Me.ForeverTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.ForeverTextBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ForeverTextBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ForeverTextBox3.Enabled = False
        Me.ForeverTextBox3.FocusOnHover = False
        Me.ForeverTextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ForeverTextBox3.Location = New System.Drawing.Point(138, 42)
        Me.ForeverTextBox3.MaxLength = 32767
        Me.ForeverTextBox3.Multiline = False
        Me.ForeverTextBox3.Name = "ForeverTextBox3"
        Me.ForeverTextBox3.ReadOnly = False
        Me.ForeverTextBox3.Size = New System.Drawing.Size(110, 29)
        Me.ForeverTextBox3.TabIndex = 2
        Me.ForeverTextBox3.TabStop = False
        Me.ForeverTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ForeverTextBox3.UseSystemPasswordChar = False
        '
        'ForeverTextBox2
        '
        Me.ForeverTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.ForeverTextBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ForeverTextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ForeverTextBox2.Enabled = False
        Me.ForeverTextBox2.FocusOnHover = False
        Me.ForeverTextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ForeverTextBox2.Location = New System.Drawing.Point(22, 77)
        Me.ForeverTextBox2.MaxLength = 32767
        Me.ForeverTextBox2.Multiline = False
        Me.ForeverTextBox2.Name = "ForeverTextBox2"
        Me.ForeverTextBox2.ReadOnly = False
        Me.ForeverTextBox2.Size = New System.Drawing.Size(110, 29)
        Me.ForeverTextBox2.TabIndex = 1
        Me.ForeverTextBox2.TabStop = False
        Me.ForeverTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ForeverTextBox2.UseSystemPasswordChar = False
        '
        'ForeverTextBox1
        '
        Me.ForeverTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.ForeverTextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ForeverTextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ForeverTextBox1.Enabled = False
        Me.ForeverTextBox1.FocusOnHover = False
        Me.ForeverTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ForeverTextBox1.Location = New System.Drawing.Point(22, 42)
        Me.ForeverTextBox1.MaxLength = 32767
        Me.ForeverTextBox1.Multiline = False
        Me.ForeverTextBox1.Name = "ForeverTextBox1"
        Me.ForeverTextBox1.ReadOnly = True
        Me.ForeverTextBox1.Size = New System.Drawing.Size(110, 29)
        Me.ForeverTextBox1.TabIndex = 0
        Me.ForeverTextBox1.TabStop = False
        Me.ForeverTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ForeverTextBox1.UseSystemPasswordChar = False
        '
        'ForeverGroupBox2
        '
        Me.ForeverGroupBox2.ArrowColorF = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ForeverGroupBox2.ArrowColorH = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ForeverGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.ForeverGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ForeverGroupBox2.Controls.Add(Me.ComboBoxWindows)
        Me.ForeverGroupBox2.Controls.Add(Me.ButtonOCRSettings)
        Me.ForeverGroupBox2.Controls.Add(Me.CheckBox2Star)
        Me.ForeverGroupBox2.Controls.Add(Me.CheckBox1Star)
        Me.ForeverGroupBox2.Controls.Add(Me.ButtonRefresh)
        Me.ForeverGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeverGroupBox2.Location = New System.Drawing.Point(564, 57)
        Me.ForeverGroupBox2.Name = "ForeverGroupBox2"
        Me.ForeverGroupBox2.ShowArrow = True
        Me.ForeverGroupBox2.ShowText = True
        Me.ForeverGroupBox2.Size = New System.Drawing.Size(392, 128)
        Me.ForeverGroupBox2.TabIndex = 23
        Me.ForeverGroupBox2.TabStop = False
        Me.ForeverGroupBox2.Text = "Settings"
        Me.ForeverGroupBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        '
        'ButtonOCRSettings
        '
        Me.ButtonOCRSettings.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOCRSettings.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonOCRSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOCRSettings.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonOCRSettings.Location = New System.Drawing.Point(20, 75)
        Me.ButtonOCRSettings.Name = "ButtonOCRSettings"
        Me.ButtonOCRSettings.Rounded = True
        Me.ButtonOCRSettings.Size = New System.Drawing.Size(120, 34)
        Me.ButtonOCRSettings.TabIndex = 4
        Me.ButtonOCRSettings.Text = "Settings"
        Me.ButtonOCRSettings.TextColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        '
        'CheckBox2Star
        '
        Me.CheckBox2Star.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CheckBox2Star.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CheckBox2Star.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBox2Star.Checked = False
        Me.CheckBox2Star.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox2Star.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CheckBox2Star.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox2Star.Location = New System.Drawing.Point(266, 84)
        Me.CheckBox2Star.Name = "CheckBox2Star"
        Me.CheckBox2Star.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1
        Me.CheckBox2Star.Size = New System.Drawing.Size(105, 22)
        Me.CheckBox2Star.TabIndex = 6
        Me.CheckBox2Star.Text = "Exclude 2★"
        '
        'CheckBox1Star
        '
        Me.CheckBox1Star.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CheckBox1Star.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CheckBox1Star.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBox1Star.Checked = False
        Me.CheckBox1Star.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1Star.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CheckBox1Star.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox1Star.Location = New System.Drawing.Point(155, 84)
        Me.CheckBox1Star.Name = "CheckBox1Star"
        Me.CheckBox1Star.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1
        Me.CheckBox1Star.Size = New System.Drawing.Size(105, 22)
        Me.CheckBox1Star.TabIndex = 5
        Me.CheckBox1Star.Text = "Exclude 1★"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRefresh.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonRefresh.Location = New System.Drawing.Point(304, 37)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Rounded = True
        Me.ButtonRefresh.Size = New System.Drawing.Size(69, 34)
        Me.ButtonRefresh.TabIndex = 3
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        '
        'ComboBoxWindows
        '
        Me.ComboBoxWindows.BaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ComboBoxWindows.BGColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ComboBoxWindows.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxWindows.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxWindows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxWindows.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ComboBoxWindows.ForeColor = System.Drawing.Color.White
        Me.ComboBoxWindows.FormattingEnabled = True
        Me.ComboBoxWindows.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxWindows.HoverFontColor = System.Drawing.Color.White
        Me.ComboBoxWindows.ItemHeight = 18
        Me.ComboBoxWindows.Location = New System.Drawing.Point(20, 42)
        Me.ComboBoxWindows.MaxDropDownItems = 100
        Me.ComboBoxWindows.Name = "ComboBoxWindows"
        Me.ComboBoxWindows.Size = New System.Drawing.Size(276, 24)
        Me.ComboBoxWindows.Sorted = True
        Me.ComboBoxWindows.TabIndex = 2
        '
        'LabelError
        '
        Me.LabelError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(100, 9)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(269, 30)
        Me.LabelError.TabIndex = 6
        Me.LabelError.Text = "LabelError"
        Me.LabelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RecruitMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 615)
        Me.Controls.Add(Me.FlowLayoutPanelResults)
        Me.Controls.Add(Me.ForeverForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(2560, 1392)
        Me.MinimumSize = New System.Drawing.Size(126, 50)
        Me.Name = "RecruitMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecruitOCR"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ForeverForm1.ResumeLayout(False)
        Me.ForeverGroupBox1.ResumeLayout(False)
        Me.ForeverGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanelResults As FlowLayoutPanel
    Friend WithEvents ForeverForm1 As ReaLTaiizor.Forms.ForeverForm
    Friend WithEvents ForeverGroupBox1 As ReaLTaiizor.Controls.ForeverGroupBox
    Friend WithEvents ForeverTextBox6 As ReaLTaiizor.Controls.ForeverTextBox
    Friend WithEvents ForeverTextBox5 As ReaLTaiizor.Controls.ForeverTextBox
    Friend WithEvents ForeverTextBox4 As ReaLTaiizor.Controls.ForeverTextBox
    Friend WithEvents ForeverTextBox3 As ReaLTaiizor.Controls.ForeverTextBox
    Friend WithEvents ForeverTextBox2 As ReaLTaiizor.Controls.ForeverTextBox
    Friend WithEvents ForeverTextBox1 As ReaLTaiizor.Controls.ForeverTextBox
    Friend WithEvents ForeverGroupBox2 As ReaLTaiizor.Controls.ForeverGroupBox
    Friend WithEvents ComboBoxWindows As ReaLTaiizor.Controls.ForeverComboBox
    Friend WithEvents ButtonRefresh As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents ForeverMinimize1 As ReaLTaiizor.Controls.ForeverMinimize
    Friend WithEvents ForeverClose1 As ReaLTaiizor.Controls.ForeverClose
    Friend WithEvents ButtonOCRSettings As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents CheckBox2Star As ReaLTaiizor.Controls.ForeverCheckBox
    Friend WithEvents CheckBox1Star As ReaLTaiizor.Controls.ForeverCheckBox
    Friend WithEvents ButtonStart As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents LabelError As Label
End Class
