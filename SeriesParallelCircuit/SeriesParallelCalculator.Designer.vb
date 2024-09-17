<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SeriesParallelCalculator
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
        Me.components = New System.ComponentModel.Container()
        Me.CalculatorToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CalcMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsListBox = New System.Windows.Forms.ListBox()
        Me.VgenTextBox = New System.Windows.Forms.TextBox()
        Me.FrequencyTextBox = New System.Windows.Forms.TextBox()
        Me.VgenValueLabel = New System.Windows.Forms.Label()
        Me.FrequencyValueLabel = New System.Windows.Forms.Label()
        Me.C1TextBox = New System.Windows.Forms.TextBox()
        Me.C1ValueLabel = New System.Windows.Forms.Label()
        Me.C2TextBox = New System.Windows.Forms.TextBox()
        Me.C2ValueLabel = New System.Windows.Forms.Label()
        Me.R1TextBox = New System.Windows.Forms.TextBox()
        Me.R1ValueLabel = New System.Windows.Forms.Label()
        Me.R2TextBox = New System.Windows.Forms.TextBox()
        Me.R2ValueLabel = New System.Windows.Forms.Label()
        Me.L1TextBox = New System.Windows.Forms.TextBox()
        Me.L1ValueLabel = New System.Windows.Forms.Label()
        Me.RwTextBox = New System.Windows.Forms.TextBox()
        Me.RwValueLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalcContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.R3TextBox = New System.Windows.Forms.TextBox()
        Me.R3ValueLabel = New System.Windows.Forms.Label()
        Me.ValuesGroupBox = New System.Windows.Forms.GroupBox()
        Me.ControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.CmicroRadioButton = New System.Windows.Forms.RadioButton()
        Me.CpicoRadioButton = New System.Windows.Forms.RadioButton()
        Me.LRadioButton = New System.Windows.Forms.RadioButton()
        Me.LmilliRadioButton = New System.Windows.Forms.RadioButton()
        Me.CSettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.LSettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.LmicroRadioButton = New System.Windows.Forms.RadioButton()
        Me.FrequencySettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.MHzRadioButton = New System.Windows.Forms.RadioButton()
        Me.kHzRadioButton = New System.Windows.Forms.RadioButton()
        Me.HzRadioButton = New System.Windows.Forms.RadioButton()
        Me.RSettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.MOhmsRadioButton = New System.Windows.Forms.RadioButton()
        Me.kOhmsRadioButton = New System.Windows.Forms.RadioButton()
        Me.OhmsRadioButton = New System.Windows.Forms.RadioButton()
        Me.VGenSettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.mVRadioButton = New System.Windows.Forms.RadioButton()
        Me.VRadioButton = New System.Windows.Forms.RadioButton()
        Me.RDisplaySettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.MOhmsDisplayRadioButton = New System.Windows.Forms.RadioButton()
        Me.kOhmsDisplayRadioButton = New System.Windows.Forms.RadioButton()
        Me.OhmsDisplayRadioButton = New System.Windows.Forms.RadioButton()
        Me.IDisplaySettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.uAmpsRadioButton = New System.Windows.Forms.RadioButton()
        Me.mAmpsRadioButton = New System.Windows.Forms.RadioButton()
        Me.AmpsRadioButton = New System.Windows.Forms.RadioButton()
        Me.CircuitPictureBox = New System.Windows.Forms.PictureBox()
        Me.CalcMenuStrip.SuspendLayout()
        Me.CalcContextMenuStrip.SuspendLayout()
        Me.ValuesGroupBox.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.CSettingsGroupBox.SuspendLayout()
        Me.LSettingsGroupBox.SuspendLayout()
        Me.FrequencySettingsGroupBox.SuspendLayout()
        Me.RSettingsGroupBox.SuspendLayout()
        Me.VGenSettingsGroupBox.SuspendLayout()
        Me.RDisplaySettingsGroupBox.SuspendLayout()
        Me.IDisplaySettingsGroupBox.SuspendLayout()
        CType(Me.CircuitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CalcMenuStrip
        '
        Me.CalcMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CalcMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IToolStripMenuItem})
        Me.CalcMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.CalcMenuStrip.Name = "CalcMenuStrip"
        Me.CalcMenuStrip.Size = New System.Drawing.Size(1496, 30)
        Me.CalcMenuStrip.TabIndex = 0
        Me.CalcMenuStrip.Text = "MenuStrip1"
        '
        'IToolStripMenuItem
        '
        Me.IToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.IToolStripMenuItem.Name = "IToolStripMenuItem"
        Me.IToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.IToolStripMenuItem.Text = "File"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ResultsListBox
        '
        Me.ResultsListBox.FormattingEnabled = True
        Me.ResultsListBox.ItemHeight = 16
        Me.ResultsListBox.Location = New System.Drawing.Point(899, 39)
        Me.ResultsListBox.Name = "ResultsListBox"
        Me.ResultsListBox.Size = New System.Drawing.Size(585, 340)
        Me.ResultsListBox.TabIndex = 10
        '
        'VgenTextBox
        '
        Me.VgenTextBox.Location = New System.Drawing.Point(12, 35)
        Me.VgenTextBox.Name = "VgenTextBox"
        Me.VgenTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VgenTextBox.TabIndex = 0
        '
        'FrequencyTextBox
        '
        Me.FrequencyTextBox.Location = New System.Drawing.Point(12, 83)
        Me.FrequencyTextBox.Name = "FrequencyTextBox"
        Me.FrequencyTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FrequencyTextBox.TabIndex = 1
        '
        'VgenValueLabel
        '
        Me.VgenValueLabel.AutoSize = True
        Me.VgenValueLabel.Location = New System.Drawing.Point(17, 16)
        Me.VgenValueLabel.Name = "VgenValueLabel"
        Me.VgenValueLabel.Size = New System.Drawing.Size(67, 16)
        Me.VgenValueLabel.TabIndex = 13
        Me.VgenValueLabel.Text = "Vgen (Vp)"
        '
        'FrequencyValueLabel
        '
        Me.FrequencyValueLabel.AutoSize = True
        Me.FrequencyValueLabel.Location = New System.Drawing.Point(17, 64)
        Me.FrequencyValueLabel.Name = "FrequencyValueLabel"
        Me.FrequencyValueLabel.Size = New System.Drawing.Size(71, 16)
        Me.FrequencyValueLabel.TabIndex = 14
        Me.FrequencyValueLabel.Text = "Frequency"
        '
        'C1TextBox
        '
        Me.C1TextBox.Location = New System.Drawing.Point(140, 34)
        Me.C1TextBox.Name = "C1TextBox"
        Me.C1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.C1TextBox.TabIndex = 2
        '
        'C1ValueLabel
        '
        Me.C1ValueLabel.AutoSize = True
        Me.C1ValueLabel.Location = New System.Drawing.Point(147, 15)
        Me.C1ValueLabel.Name = "C1ValueLabel"
        Me.C1ValueLabel.Size = New System.Drawing.Size(23, 16)
        Me.C1ValueLabel.TabIndex = 16
        Me.C1ValueLabel.Text = "C1"
        '
        'C2TextBox
        '
        Me.C2TextBox.Location = New System.Drawing.Point(140, 82)
        Me.C2TextBox.Name = "C2TextBox"
        Me.C2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.C2TextBox.TabIndex = 3
        '
        'C2ValueLabel
        '
        Me.C2ValueLabel.AutoSize = True
        Me.C2ValueLabel.Location = New System.Drawing.Point(147, 63)
        Me.C2ValueLabel.Name = "C2ValueLabel"
        Me.C2ValueLabel.Size = New System.Drawing.Size(23, 16)
        Me.C2ValueLabel.TabIndex = 18
        Me.C2ValueLabel.Text = "C2"
        '
        'R1TextBox
        '
        Me.R1TextBox.Location = New System.Drawing.Point(265, 35)
        Me.R1TextBox.Name = "R1TextBox"
        Me.R1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.R1TextBox.TabIndex = 4
        '
        'R1ValueLabel
        '
        Me.R1ValueLabel.AutoSize = True
        Me.R1ValueLabel.Location = New System.Drawing.Point(271, 16)
        Me.R1ValueLabel.Name = "R1ValueLabel"
        Me.R1ValueLabel.Size = New System.Drawing.Size(24, 16)
        Me.R1ValueLabel.TabIndex = 20
        Me.R1ValueLabel.Text = "R1"
        '
        'R2TextBox
        '
        Me.R2TextBox.Location = New System.Drawing.Point(265, 83)
        Me.R2TextBox.Name = "R2TextBox"
        Me.R2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.R2TextBox.TabIndex = 5
        '
        'R2ValueLabel
        '
        Me.R2ValueLabel.AutoSize = True
        Me.R2ValueLabel.Location = New System.Drawing.Point(271, 64)
        Me.R2ValueLabel.Name = "R2ValueLabel"
        Me.R2ValueLabel.Size = New System.Drawing.Size(24, 16)
        Me.R2ValueLabel.TabIndex = 22
        Me.R2ValueLabel.Text = "R2"
        '
        'L1TextBox
        '
        Me.L1TextBox.Location = New System.Drawing.Point(385, 83)
        Me.L1TextBox.Name = "L1TextBox"
        Me.L1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.L1TextBox.TabIndex = 7
        '
        'L1ValueLabel
        '
        Me.L1ValueLabel.AutoSize = True
        Me.L1ValueLabel.Location = New System.Drawing.Point(397, 61)
        Me.L1ValueLabel.Name = "L1ValueLabel"
        Me.L1ValueLabel.Size = New System.Drawing.Size(21, 16)
        Me.L1ValueLabel.TabIndex = 24
        Me.L1ValueLabel.Text = "L1"
        '
        'RwTextBox
        '
        Me.RwTextBox.Location = New System.Drawing.Point(504, 83)
        Me.RwTextBox.Name = "RwTextBox"
        Me.RwTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RwTextBox.TabIndex = 8
        '
        'RwValueLabel
        '
        Me.RwValueLabel.AutoSize = True
        Me.RwValueLabel.Location = New System.Drawing.Point(517, 64)
        Me.RwValueLabel.Name = "RwValueLabel"
        Me.RwValueLabel.Size = New System.Drawing.Size(87, 16)
        Me.RwValueLabel.TabIndex = 26
        Me.RwValueLabel.Text = "Rw (Optional)"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 17)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(143, 70)
        Me.CalculateButton.TabIndex = 12
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(161, 17)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(143, 70)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(310, 17)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(143, 70)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CalcContextMenuStrip
        '
        Me.CalcContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CalcContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.CalcContextMenuStrip.Name = "CalcContextMenuStrip"
        Me.CalcContextMenuStrip.Size = New System.Drawing.Size(102, 28)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem1, Me.ClearToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CalculateToolStripMenuItem1
        '
        Me.CalculateToolStripMenuItem1.Name = "CalculateToolStripMenuItem1"
        Me.CalculateToolStripMenuItem1.Size = New System.Drawing.Size(153, 26)
        Me.CalculateToolStripMenuItem1.Text = "Calculate"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(153, 26)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(153, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'R3TextBox
        '
        Me.R3TextBox.Location = New System.Drawing.Point(385, 35)
        Me.R3TextBox.Name = "R3TextBox"
        Me.R3TextBox.Size = New System.Drawing.Size(100, 22)
        Me.R3TextBox.TabIndex = 6
        '
        'R3ValueLabel
        '
        Me.R3ValueLabel.AutoSize = True
        Me.R3ValueLabel.Location = New System.Drawing.Point(394, 15)
        Me.R3ValueLabel.Name = "R3ValueLabel"
        Me.R3ValueLabel.Size = New System.Drawing.Size(24, 16)
        Me.R3ValueLabel.TabIndex = 31
        Me.R3ValueLabel.Text = "R3"
        '
        'ValuesGroupBox
        '
        Me.ValuesGroupBox.Controls.Add(Me.R3ValueLabel)
        Me.ValuesGroupBox.Controls.Add(Me.R3TextBox)
        Me.ValuesGroupBox.Controls.Add(Me.RwValueLabel)
        Me.ValuesGroupBox.Controls.Add(Me.RwTextBox)
        Me.ValuesGroupBox.Controls.Add(Me.L1ValueLabel)
        Me.ValuesGroupBox.Controls.Add(Me.L1TextBox)
        Me.ValuesGroupBox.Controls.Add(Me.R2ValueLabel)
        Me.ValuesGroupBox.Controls.Add(Me.R2TextBox)
        Me.ValuesGroupBox.Controls.Add(Me.R1ValueLabel)
        Me.ValuesGroupBox.Controls.Add(Me.R1TextBox)
        Me.ValuesGroupBox.Controls.Add(Me.C2ValueLabel)
        Me.ValuesGroupBox.Controls.Add(Me.C2TextBox)
        Me.ValuesGroupBox.Controls.Add(Me.C1ValueLabel)
        Me.ValuesGroupBox.Controls.Add(Me.C1TextBox)
        Me.ValuesGroupBox.Controls.Add(Me.FrequencyValueLabel)
        Me.ValuesGroupBox.Controls.Add(Me.VgenValueLabel)
        Me.ValuesGroupBox.Controls.Add(Me.FrequencyTextBox)
        Me.ValuesGroupBox.Controls.Add(Me.VgenTextBox)
        Me.ValuesGroupBox.Location = New System.Drawing.Point(7, 511)
        Me.ValuesGroupBox.Name = "ValuesGroupBox"
        Me.ValuesGroupBox.Size = New System.Drawing.Size(611, 114)
        Me.ValuesGroupBox.TabIndex = 32
        Me.ValuesGroupBox.TabStop = False
        Me.ValuesGroupBox.Text = "Values"
        '
        'ControlsGroupBox
        '
        Me.ControlsGroupBox.Controls.Add(Me.ExitButton)
        Me.ControlsGroupBox.Controls.Add(Me.ClearButton)
        Me.ControlsGroupBox.Controls.Add(Me.CalculateButton)
        Me.ControlsGroupBox.Location = New System.Drawing.Point(964, 392)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(464, 99)
        Me.ControlsGroupBox.TabIndex = 33
        Me.ControlsGroupBox.TabStop = False
        '
        'CmicroRadioButton
        '
        Me.CmicroRadioButton.AutoSize = True
        Me.CmicroRadioButton.Checked = True
        Me.CmicroRadioButton.Location = New System.Drawing.Point(6, 21)
        Me.CmicroRadioButton.Name = "CmicroRadioButton"
        Me.CmicroRadioButton.Size = New System.Drawing.Size(43, 20)
        Me.CmicroRadioButton.TabIndex = 34
        Me.CmicroRadioButton.TabStop = True
        Me.CmicroRadioButton.Text = "uF"
        Me.CmicroRadioButton.UseVisualStyleBackColor = True
        '
        'CpicoRadioButton
        '
        Me.CpicoRadioButton.AutoSize = True
        Me.CpicoRadioButton.Location = New System.Drawing.Point(6, 47)
        Me.CpicoRadioButton.Name = "CpicoRadioButton"
        Me.CpicoRadioButton.Size = New System.Drawing.Size(44, 20)
        Me.CpicoRadioButton.TabIndex = 35
        Me.CpicoRadioButton.TabStop = True
        Me.CpicoRadioButton.Text = "pF"
        Me.CpicoRadioButton.UseVisualStyleBackColor = True
        '
        'LRadioButton
        '
        Me.LRadioButton.AutoSize = True
        Me.LRadioButton.Checked = True
        Me.LRadioButton.Location = New System.Drawing.Point(7, 21)
        Me.LRadioButton.Name = "LRadioButton"
        Me.LRadioButton.Size = New System.Drawing.Size(38, 20)
        Me.LRadioButton.TabIndex = 36
        Me.LRadioButton.TabStop = True
        Me.LRadioButton.Text = "H"
        Me.LRadioButton.UseVisualStyleBackColor = True
        '
        'LmilliRadioButton
        '
        Me.LmilliRadioButton.AutoSize = True
        Me.LmilliRadioButton.Location = New System.Drawing.Point(7, 47)
        Me.LmilliRadioButton.Name = "LmilliRadioButton"
        Me.LmilliRadioButton.Size = New System.Drawing.Size(49, 20)
        Me.LmilliRadioButton.TabIndex = 37
        Me.LmilliRadioButton.TabStop = True
        Me.LmilliRadioButton.Text = "mH"
        Me.LmilliRadioButton.UseVisualStyleBackColor = True
        '
        'CSettingsGroupBox
        '
        Me.CSettingsGroupBox.Controls.Add(Me.CpicoRadioButton)
        Me.CSettingsGroupBox.Controls.Add(Me.CmicroRadioButton)
        Me.CSettingsGroupBox.Location = New System.Drawing.Point(964, 511)
        Me.CSettingsGroupBox.Name = "CSettingsGroupBox"
        Me.CSettingsGroupBox.Size = New System.Drawing.Size(99, 73)
        Me.CSettingsGroupBox.TabIndex = 10
        Me.CSettingsGroupBox.TabStop = False
        Me.CSettingsGroupBox.Text = "C Settings"
        '
        'LSettingsGroupBox
        '
        Me.LSettingsGroupBox.Controls.Add(Me.LmicroRadioButton)
        Me.LSettingsGroupBox.Controls.Add(Me.LmilliRadioButton)
        Me.LSettingsGroupBox.Controls.Add(Me.LRadioButton)
        Me.LSettingsGroupBox.Location = New System.Drawing.Point(1069, 511)
        Me.LSettingsGroupBox.Name = "LSettingsGroupBox"
        Me.LSettingsGroupBox.Size = New System.Drawing.Size(102, 105)
        Me.LSettingsGroupBox.TabIndex = 11
        Me.LSettingsGroupBox.TabStop = False
        Me.LSettingsGroupBox.Text = "L Settings"
        '
        'LmicroRadioButton
        '
        Me.LmicroRadioButton.AutoSize = True
        Me.LmicroRadioButton.Location = New System.Drawing.Point(7, 73)
        Me.LmicroRadioButton.Name = "LmicroRadioButton"
        Me.LmicroRadioButton.Size = New System.Drawing.Size(45, 20)
        Me.LmicroRadioButton.TabIndex = 38
        Me.LmicroRadioButton.TabStop = True
        Me.LmicroRadioButton.Text = "uH"
        Me.LmicroRadioButton.UseVisualStyleBackColor = True
        '
        'FrequencySettingsGroupBox
        '
        Me.FrequencySettingsGroupBox.Controls.Add(Me.MHzRadioButton)
        Me.FrequencySettingsGroupBox.Controls.Add(Me.kHzRadioButton)
        Me.FrequencySettingsGroupBox.Controls.Add(Me.HzRadioButton)
        Me.FrequencySettingsGroupBox.Location = New System.Drawing.Point(755, 511)
        Me.FrequencySettingsGroupBox.Name = "FrequencySettingsGroupBox"
        Me.FrequencySettingsGroupBox.Size = New System.Drawing.Size(97, 105)
        Me.FrequencySettingsGroupBox.TabIndex = 9
        Me.FrequencySettingsGroupBox.TabStop = False
        Me.FrequencySettingsGroupBox.Text = "F Settings"
        '
        'MHzRadioButton
        '
        Me.MHzRadioButton.AutoSize = True
        Me.MHzRadioButton.Location = New System.Drawing.Point(7, 73)
        Me.MHzRadioButton.Name = "MHzRadioButton"
        Me.MHzRadioButton.Size = New System.Drawing.Size(55, 20)
        Me.MHzRadioButton.TabIndex = 38
        Me.MHzRadioButton.TabStop = True
        Me.MHzRadioButton.Text = "MHz"
        Me.MHzRadioButton.UseVisualStyleBackColor = True
        '
        'kHzRadioButton
        '
        Me.kHzRadioButton.AutoSize = True
        Me.kHzRadioButton.Location = New System.Drawing.Point(7, 47)
        Me.kHzRadioButton.Name = "kHzRadioButton"
        Me.kHzRadioButton.Size = New System.Drawing.Size(51, 20)
        Me.kHzRadioButton.TabIndex = 37
        Me.kHzRadioButton.TabStop = True
        Me.kHzRadioButton.Text = "kHz"
        Me.kHzRadioButton.UseVisualStyleBackColor = True
        '
        'HzRadioButton
        '
        Me.HzRadioButton.AutoSize = True
        Me.HzRadioButton.Checked = True
        Me.HzRadioButton.Location = New System.Drawing.Point(7, 21)
        Me.HzRadioButton.Name = "HzRadioButton"
        Me.HzRadioButton.Size = New System.Drawing.Size(44, 20)
        Me.HzRadioButton.TabIndex = 36
        Me.HzRadioButton.TabStop = True
        Me.HzRadioButton.Text = "Hz"
        Me.HzRadioButton.UseVisualStyleBackColor = True
        '
        'RSettingsGroupBox
        '
        Me.RSettingsGroupBox.Controls.Add(Me.MOhmsRadioButton)
        Me.RSettingsGroupBox.Controls.Add(Me.kOhmsRadioButton)
        Me.RSettingsGroupBox.Controls.Add(Me.OhmsRadioButton)
        Me.RSettingsGroupBox.Location = New System.Drawing.Point(858, 511)
        Me.RSettingsGroupBox.Name = "RSettingsGroupBox"
        Me.RSettingsGroupBox.Size = New System.Drawing.Size(100, 105)
        Me.RSettingsGroupBox.TabIndex = 39
        Me.RSettingsGroupBox.TabStop = False
        Me.RSettingsGroupBox.Text = "R Settings"
        '
        'MOhmsRadioButton
        '
        Me.MOhmsRadioButton.AutoSize = True
        Me.MOhmsRadioButton.Location = New System.Drawing.Point(7, 73)
        Me.MOhmsRadioButton.Name = "MOhmsRadioButton"
        Me.MOhmsRadioButton.Size = New System.Drawing.Size(74, 20)
        Me.MOhmsRadioButton.TabIndex = 38
        Me.MOhmsRadioButton.TabStop = True
        Me.MOhmsRadioButton.Text = "MOhms"
        Me.MOhmsRadioButton.UseVisualStyleBackColor = True
        '
        'kOhmsRadioButton
        '
        Me.kOhmsRadioButton.AutoSize = True
        Me.kOhmsRadioButton.Location = New System.Drawing.Point(7, 47)
        Me.kOhmsRadioButton.Name = "kOhmsRadioButton"
        Me.kOhmsRadioButton.Size = New System.Drawing.Size(70, 20)
        Me.kOhmsRadioButton.TabIndex = 37
        Me.kOhmsRadioButton.TabStop = True
        Me.kOhmsRadioButton.Text = "kOhms"
        Me.kOhmsRadioButton.UseVisualStyleBackColor = True
        '
        'OhmsRadioButton
        '
        Me.OhmsRadioButton.AutoSize = True
        Me.OhmsRadioButton.Checked = True
        Me.OhmsRadioButton.Location = New System.Drawing.Point(7, 21)
        Me.OhmsRadioButton.Name = "OhmsRadioButton"
        Me.OhmsRadioButton.Size = New System.Drawing.Size(63, 20)
        Me.OhmsRadioButton.TabIndex = 36
        Me.OhmsRadioButton.TabStop = True
        Me.OhmsRadioButton.Text = "Ohms"
        Me.OhmsRadioButton.UseVisualStyleBackColor = True
        '
        'VGenSettingsGroupBox
        '
        Me.VGenSettingsGroupBox.Controls.Add(Me.mVRadioButton)
        Me.VGenSettingsGroupBox.Controls.Add(Me.VRadioButton)
        Me.VGenSettingsGroupBox.Location = New System.Drawing.Point(624, 511)
        Me.VGenSettingsGroupBox.Name = "VGenSettingsGroupBox"
        Me.VGenSettingsGroupBox.Size = New System.Drawing.Size(125, 73)
        Me.VGenSettingsGroupBox.TabIndex = 39
        Me.VGenSettingsGroupBox.TabStop = False
        Me.VGenSettingsGroupBox.Text = "Vgen Settings"
        '
        'mVRadioButton
        '
        Me.mVRadioButton.AutoSize = True
        Me.mVRadioButton.Location = New System.Drawing.Point(7, 47)
        Me.mVRadioButton.Name = "mVRadioButton"
        Me.mVRadioButton.Size = New System.Drawing.Size(48, 20)
        Me.mVRadioButton.TabIndex = 37
        Me.mVRadioButton.TabStop = True
        Me.mVRadioButton.Text = "mV"
        Me.mVRadioButton.UseVisualStyleBackColor = True
        '
        'VRadioButton
        '
        Me.VRadioButton.AutoSize = True
        Me.VRadioButton.Checked = True
        Me.VRadioButton.Location = New System.Drawing.Point(7, 21)
        Me.VRadioButton.Name = "VRadioButton"
        Me.VRadioButton.Size = New System.Drawing.Size(58, 20)
        Me.VRadioButton.TabIndex = 36
        Me.VRadioButton.TabStop = True
        Me.VRadioButton.Text = "Volts"
        Me.VRadioButton.UseVisualStyleBackColor = True
        '
        'RDisplaySettingsGroupBox
        '
        Me.RDisplaySettingsGroupBox.Controls.Add(Me.MOhmsDisplayRadioButton)
        Me.RDisplaySettingsGroupBox.Controls.Add(Me.kOhmsDisplayRadioButton)
        Me.RDisplaySettingsGroupBox.Controls.Add(Me.OhmsDisplayRadioButton)
        Me.RDisplaySettingsGroupBox.Location = New System.Drawing.Point(1337, 511)
        Me.RDisplaySettingsGroupBox.Name = "RDisplaySettingsGroupBox"
        Me.RDisplaySettingsGroupBox.Size = New System.Drawing.Size(147, 105)
        Me.RDisplaySettingsGroupBox.TabIndex = 40
        Me.RDisplaySettingsGroupBox.TabStop = False
        Me.RDisplaySettingsGroupBox.Text = "R Display Settings"
        '
        'MOhmsDisplayRadioButton
        '
        Me.MOhmsDisplayRadioButton.AutoSize = True
        Me.MOhmsDisplayRadioButton.Location = New System.Drawing.Point(7, 73)
        Me.MOhmsDisplayRadioButton.Name = "MOhmsDisplayRadioButton"
        Me.MOhmsDisplayRadioButton.Size = New System.Drawing.Size(74, 20)
        Me.MOhmsDisplayRadioButton.TabIndex = 38
        Me.MOhmsDisplayRadioButton.TabStop = True
        Me.MOhmsDisplayRadioButton.Text = "MOhms"
        Me.MOhmsDisplayRadioButton.UseVisualStyleBackColor = True
        '
        'kOhmsDisplayRadioButton
        '
        Me.kOhmsDisplayRadioButton.AutoSize = True
        Me.kOhmsDisplayRadioButton.Location = New System.Drawing.Point(7, 47)
        Me.kOhmsDisplayRadioButton.Name = "kOhmsDisplayRadioButton"
        Me.kOhmsDisplayRadioButton.Size = New System.Drawing.Size(70, 20)
        Me.kOhmsDisplayRadioButton.TabIndex = 37
        Me.kOhmsDisplayRadioButton.TabStop = True
        Me.kOhmsDisplayRadioButton.Text = "kOhms"
        Me.kOhmsDisplayRadioButton.UseVisualStyleBackColor = True
        '
        'OhmsDisplayRadioButton
        '
        Me.OhmsDisplayRadioButton.AutoSize = True
        Me.OhmsDisplayRadioButton.Checked = True
        Me.OhmsDisplayRadioButton.Location = New System.Drawing.Point(7, 21)
        Me.OhmsDisplayRadioButton.Name = "OhmsDisplayRadioButton"
        Me.OhmsDisplayRadioButton.Size = New System.Drawing.Size(63, 20)
        Me.OhmsDisplayRadioButton.TabIndex = 36
        Me.OhmsDisplayRadioButton.TabStop = True
        Me.OhmsDisplayRadioButton.Text = "Ohms"
        Me.OhmsDisplayRadioButton.UseVisualStyleBackColor = True
        '
        'IDisplaySettingsGroupBox
        '
        Me.IDisplaySettingsGroupBox.Controls.Add(Me.uAmpsRadioButton)
        Me.IDisplaySettingsGroupBox.Controls.Add(Me.mAmpsRadioButton)
        Me.IDisplaySettingsGroupBox.Controls.Add(Me.AmpsRadioButton)
        Me.IDisplaySettingsGroupBox.Location = New System.Drawing.Point(1177, 511)
        Me.IDisplaySettingsGroupBox.Name = "IDisplaySettingsGroupBox"
        Me.IDisplaySettingsGroupBox.Size = New System.Drawing.Size(154, 105)
        Me.IDisplaySettingsGroupBox.TabIndex = 39
        Me.IDisplaySettingsGroupBox.TabStop = False
        Me.IDisplaySettingsGroupBox.Text = "I Display Settings"
        '
        'uAmpsRadioButton
        '
        Me.uAmpsRadioButton.AutoSize = True
        Me.uAmpsRadioButton.Location = New System.Drawing.Point(7, 73)
        Me.uAmpsRadioButton.Name = "uAmpsRadioButton"
        Me.uAmpsRadioButton.Size = New System.Drawing.Size(70, 20)
        Me.uAmpsRadioButton.TabIndex = 38
        Me.uAmpsRadioButton.TabStop = True
        Me.uAmpsRadioButton.Text = "uAmps"
        Me.uAmpsRadioButton.UseVisualStyleBackColor = True
        '
        'mAmpsRadioButton
        '
        Me.mAmpsRadioButton.AutoSize = True
        Me.mAmpsRadioButton.Location = New System.Drawing.Point(7, 47)
        Me.mAmpsRadioButton.Name = "mAmpsRadioButton"
        Me.mAmpsRadioButton.Size = New System.Drawing.Size(74, 20)
        Me.mAmpsRadioButton.TabIndex = 37
        Me.mAmpsRadioButton.TabStop = True
        Me.mAmpsRadioButton.Text = "mAmps"
        Me.mAmpsRadioButton.UseVisualStyleBackColor = True
        '
        'AmpsRadioButton
        '
        Me.AmpsRadioButton.AutoSize = True
        Me.AmpsRadioButton.Checked = True
        Me.AmpsRadioButton.Location = New System.Drawing.Point(7, 21)
        Me.AmpsRadioButton.Name = "AmpsRadioButton"
        Me.AmpsRadioButton.Size = New System.Drawing.Size(63, 20)
        Me.AmpsRadioButton.TabIndex = 36
        Me.AmpsRadioButton.TabStop = True
        Me.AmpsRadioButton.Text = "Amps"
        Me.AmpsRadioButton.UseVisualStyleBackColor = True
        '
        'CircuitPictureBox
        '
        Me.CircuitPictureBox.Image = Global.SeriesParallelCircuit.My.Resources.Resources.Final_Series_Parallel_Calculator_Circuit_Schematic
        Me.CircuitPictureBox.Location = New System.Drawing.Point(7, 41)
        Me.CircuitPictureBox.Name = "CircuitPictureBox"
        Me.CircuitPictureBox.Size = New System.Drawing.Size(906, 450)
        Me.CircuitPictureBox.TabIndex = 1
        Me.CircuitPictureBox.TabStop = False
        '
        'SeriesParallelCalculator
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1496, 643)
        Me.Controls.Add(Me.IDisplaySettingsGroupBox)
        Me.Controls.Add(Me.RDisplaySettingsGroupBox)
        Me.Controls.Add(Me.VGenSettingsGroupBox)
        Me.Controls.Add(Me.RSettingsGroupBox)
        Me.Controls.Add(Me.FrequencySettingsGroupBox)
        Me.Controls.Add(Me.LSettingsGroupBox)
        Me.Controls.Add(Me.CSettingsGroupBox)
        Me.Controls.Add(Me.ControlsGroupBox)
        Me.Controls.Add(Me.ValuesGroupBox)
        Me.Controls.Add(Me.ResultsListBox)
        Me.Controls.Add(Me.CircuitPictureBox)
        Me.Controls.Add(Me.CalcMenuStrip)
        Me.MainMenuStrip = Me.CalcMenuStrip
        Me.Name = "SeriesParallelCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Series-Parallel Circuit Calculator"
        Me.CalcMenuStrip.ResumeLayout(False)
        Me.CalcMenuStrip.PerformLayout()
        Me.CalcContextMenuStrip.ResumeLayout(False)
        Me.ValuesGroupBox.ResumeLayout(False)
        Me.ValuesGroupBox.PerformLayout()
        Me.ControlsGroupBox.ResumeLayout(False)
        Me.CSettingsGroupBox.ResumeLayout(False)
        Me.CSettingsGroupBox.PerformLayout()
        Me.LSettingsGroupBox.ResumeLayout(False)
        Me.LSettingsGroupBox.PerformLayout()
        Me.FrequencySettingsGroupBox.ResumeLayout(False)
        Me.FrequencySettingsGroupBox.PerformLayout()
        Me.RSettingsGroupBox.ResumeLayout(False)
        Me.RSettingsGroupBox.PerformLayout()
        Me.VGenSettingsGroupBox.ResumeLayout(False)
        Me.VGenSettingsGroupBox.PerformLayout()
        Me.RDisplaySettingsGroupBox.ResumeLayout(False)
        Me.RDisplaySettingsGroupBox.PerformLayout()
        Me.IDisplaySettingsGroupBox.ResumeLayout(False)
        Me.IDisplaySettingsGroupBox.PerformLayout()
        CType(Me.CircuitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalculatorToolTip As ToolTip
    Friend WithEvents CalcMenuStrip As MenuStrip
    Friend WithEvents IToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CircuitPictureBox As PictureBox
    Friend WithEvents C1Label As Label
    Friend WithEvents R1Label As Label
    Friend WithEvents L1Label As Label
    Friend WithEvents C2Label As Label
    Friend WithEvents R3Label As Label
    Friend WithEvents VgenLabel As Label
    Friend WithEvents FrequencyLabel As Label
    Friend WithEvents ResultsListBox As ListBox
    Friend WithEvents VgenTextBox As TextBox
    Friend WithEvents FrequencyTextBox As TextBox
    Friend WithEvents VgenValueLabel As Label
    Friend WithEvents FrequencyValueLabel As Label
    Friend WithEvents C1TextBox As TextBox
    Friend WithEvents C1ValueLabel As Label
    Friend WithEvents C2TextBox As TextBox
    Friend WithEvents C2ValueLabel As Label
    Friend WithEvents R1TextBox As TextBox
    Friend WithEvents R1ValueLabel As Label
    Friend WithEvents R2TextBox As TextBox
    Friend WithEvents R2ValueLabel As Label
    Friend WithEvents L1TextBox As TextBox
    Friend WithEvents L1ValueLabel As Label
    Friend WithEvents RwTextBox As TextBox
    Friend WithEvents RwValueLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents CalcContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents R3TextBox As TextBox
    Friend WithEvents R3ValueLabel As Label
    Friend WithEvents ValuesGroupBox As GroupBox
    Friend WithEvents ControlsGroupBox As GroupBox
    Friend WithEvents CmicroRadioButton As RadioButton
    Friend WithEvents CpicoRadioButton As RadioButton
    Friend WithEvents LRadioButton As RadioButton
    Friend WithEvents LmilliRadioButton As RadioButton
    Friend WithEvents CSettingsGroupBox As GroupBox
    Friend WithEvents LSettingsGroupBox As GroupBox
    Friend WithEvents LmicroRadioButton As RadioButton
    Friend WithEvents FrequencySettingsGroupBox As GroupBox
    Friend WithEvents MHzRadioButton As RadioButton
    Friend WithEvents kHzRadioButton As RadioButton
    Friend WithEvents HzRadioButton As RadioButton
    Friend WithEvents RSettingsGroupBox As GroupBox
    Friend WithEvents MOhmsRadioButton As RadioButton
    Friend WithEvents kOhmsRadioButton As RadioButton
    Friend WithEvents OhmsRadioButton As RadioButton
    Friend WithEvents VGenSettingsGroupBox As GroupBox
    Friend WithEvents mVRadioButton As RadioButton
    Friend WithEvents VRadioButton As RadioButton
    Friend WithEvents RDisplaySettingsGroupBox As GroupBox
    Friend WithEvents MOhmsDisplayRadioButton As RadioButton
    Friend WithEvents kOhmsDisplayRadioButton As RadioButton
    Friend WithEvents OhmsDisplayRadioButton As RadioButton
    Friend WithEvents IDisplaySettingsGroupBox As GroupBox
    Friend WithEvents uAmpsRadioButton As RadioButton
    Friend WithEvents mAmpsRadioButton As RadioButton
    Friend WithEvents AmpsRadioButton As RadioButton
End Class
