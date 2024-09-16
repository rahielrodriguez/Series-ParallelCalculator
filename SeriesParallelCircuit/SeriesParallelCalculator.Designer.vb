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
        Me.CircuitPictureBox = New System.Windows.Forms.PictureBox()
        Me.C1Label = New System.Windows.Forms.Label()
        Me.R1Label = New System.Windows.Forms.Label()
        Me.L1Label = New System.Windows.Forms.Label()
        Me.R2Label = New System.Windows.Forms.Label()
        Me.C2Label = New System.Windows.Forms.Label()
        Me.R3Label = New System.Windows.Forms.Label()
        Me.VgenLabel = New System.Windows.Forms.Label()
        Me.FrequencyLabel = New System.Windows.Forms.Label()
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
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
        Me.CalcMenuStrip.SuspendLayout()
        CType(Me.CircuitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CalcContextMenuStrip.SuspendLayout()
        Me.ValuesGroupBox.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.CSettingsGroupBox.SuspendLayout()
        Me.LSettingsGroupBox.SuspendLayout()
        Me.FrequencySettingsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalcMenuStrip
        '
        Me.CalcMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CalcMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IToolStripMenuItem})
        Me.CalcMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.CalcMenuStrip.Name = "CalcMenuStrip"
        Me.CalcMenuStrip.Size = New System.Drawing.Size(1140, 28)
        Me.CalcMenuStrip.TabIndex = 0
        Me.CalcMenuStrip.Text = "MenuStrip1"
        '
        'IToolStripMenuItem
        '
        Me.IToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.IToolStripMenuItem.Name = "IToolStripMenuItem"
        Me.IToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
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
        'CircuitPictureBox
        '
        Me.CircuitPictureBox.Image = Global.SeriesParallelCircuit.My.Resources.Resources.Updated_Series_Parallel_Calculator_Circuit_Schematic
        Me.CircuitPictureBox.Location = New System.Drawing.Point(7, 41)
        Me.CircuitPictureBox.Name = "CircuitPictureBox"
        Me.CircuitPictureBox.Size = New System.Drawing.Size(906, 450)
        Me.CircuitPictureBox.TabIndex = 1
        Me.CircuitPictureBox.TabStop = False
        '
        'C1Label
        '
        Me.C1Label.AutoSize = True
        Me.C1Label.Location = New System.Drawing.Point(207, 188)
        Me.C1Label.Name = "C1Label"
        Me.C1Label.Size = New System.Drawing.Size(23, 16)
        Me.C1Label.TabIndex = 2
        Me.C1Label.Text = "C1"
        '
        'R1Label
        '
        Me.R1Label.AutoSize = True
        Me.R1Label.Location = New System.Drawing.Point(326, 188)
        Me.R1Label.Name = "R1Label"
        Me.R1Label.Size = New System.Drawing.Size(24, 16)
        Me.R1Label.TabIndex = 3
        Me.R1Label.Text = "R1"
        '
        'L1Label
        '
        Me.L1Label.AutoSize = True
        Me.L1Label.Location = New System.Drawing.Point(521, 228)
        Me.L1Label.Name = "L1Label"
        Me.L1Label.Size = New System.Drawing.Size(21, 16)
        Me.L1Label.TabIndex = 4
        Me.L1Label.Text = "L1"
        '
        'R2Label
        '
        Me.R2Label.AutoSize = True
        Me.R2Label.Location = New System.Drawing.Point(539, 323)
        Me.R2Label.Name = "R2Label"
        Me.R2Label.Size = New System.Drawing.Size(24, 16)
        Me.R2Label.TabIndex = 5
        Me.R2Label.Text = "R2"
        '
        'C2Label
        '
        Me.C2Label.AutoSize = True
        Me.C2Label.Location = New System.Drawing.Point(790, 228)
        Me.C2Label.Name = "C2Label"
        Me.C2Label.Size = New System.Drawing.Size(23, 16)
        Me.C2Label.TabIndex = 6
        Me.C2Label.Text = "C2"
        '
        'R3Label
        '
        Me.R3Label.AutoSize = True
        Me.R3Label.Location = New System.Drawing.Point(772, 323)
        Me.R3Label.Name = "R3Label"
        Me.R3Label.Size = New System.Drawing.Size(24, 16)
        Me.R3Label.TabIndex = 7
        Me.R3Label.Text = "R3"
        '
        'VgenLabel
        '
        Me.VgenLabel.AutoSize = True
        Me.VgenLabel.Location = New System.Drawing.Point(34, 278)
        Me.VgenLabel.Name = "VgenLabel"
        Me.VgenLabel.Size = New System.Drawing.Size(39, 16)
        Me.VgenLabel.TabIndex = 8
        Me.VgenLabel.Text = "Vgen"
        '
        'FrequencyLabel
        '
        Me.FrequencyLabel.AutoSize = True
        Me.FrequencyLabel.Location = New System.Drawing.Point(34, 307)
        Me.FrequencyLabel.Name = "FrequencyLabel"
        Me.FrequencyLabel.Size = New System.Drawing.Size(10, 16)
        Me.FrequencyLabel.TabIndex = 9
        Me.FrequencyLabel.Text = "f"
        '
        'ResultsListBox
        '
        Me.ResultsListBox.FormattingEnabled = True
        Me.ResultsListBox.ItemHeight = 16
        Me.ResultsListBox.Location = New System.Drawing.Point(899, 39)
        Me.ResultsListBox.Name = "ResultsListBox"
        Me.ResultsListBox.Size = New System.Drawing.Size(223, 276)
        Me.ResultsListBox.TabIndex = 10
        '
        'VgenTextBox
        '
        Me.VgenTextBox.Location = New System.Drawing.Point(12, 35)
        Me.VgenTextBox.Name = "VgenTextBox"
        Me.VgenTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VgenTextBox.TabIndex = 11
        '
        'FrequencyTextBox
        '
        Me.FrequencyTextBox.Location = New System.Drawing.Point(12, 83)
        Me.FrequencyTextBox.Name = "FrequencyTextBox"
        Me.FrequencyTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FrequencyTextBox.TabIndex = 12
        '
        'VgenValueLabel
        '
        Me.VgenValueLabel.AutoSize = True
        Me.VgenValueLabel.Location = New System.Drawing.Point(17, 16)
        Me.VgenValueLabel.Name = "VgenValueLabel"
        Me.VgenValueLabel.Size = New System.Drawing.Size(39, 16)
        Me.VgenValueLabel.TabIndex = 13
        Me.VgenValueLabel.Text = "Vgen"
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
        Me.C1TextBox.TabIndex = 15
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
        Me.C2TextBox.TabIndex = 17
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
        Me.R1TextBox.TabIndex = 19
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
        Me.R2TextBox.TabIndex = 21
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
        Me.L1TextBox.TabIndex = 23
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
        Me.RwTextBox.TabIndex = 25
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
        Me.CalculateButton.TabIndex = 27
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(12, 93)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(143, 70)
        Me.ClearButton.TabIndex = 28
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(12, 168)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(143, 70)
        Me.ExitButton.TabIndex = 29
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
        Me.R3TextBox.TabIndex = 30
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
        Me.ValuesGroupBox.Size = New System.Drawing.Size(621, 114)
        Me.ValuesGroupBox.TabIndex = 32
        Me.ValuesGroupBox.TabStop = False
        Me.ValuesGroupBox.Text = "Values"
        '
        'ControlsGroupBox
        '
        Me.ControlsGroupBox.Controls.Add(Me.ExitButton)
        Me.ControlsGroupBox.Controls.Add(Me.ClearButton)
        Me.ControlsGroupBox.Controls.Add(Me.CalculateButton)
        Me.ControlsGroupBox.Location = New System.Drawing.Point(958, 372)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(170, 253)
        Me.ControlsGroupBox.TabIndex = 33
        Me.ControlsGroupBox.TabStop = False
        Me.ControlsGroupBox.Text = "GroupBox2"
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
        Me.CSettingsGroupBox.Location = New System.Drawing.Point(747, 517)
        Me.CSettingsGroupBox.Name = "CSettingsGroupBox"
        Me.CSettingsGroupBox.Size = New System.Drawing.Size(80, 73)
        Me.CSettingsGroupBox.TabIndex = 38
        Me.CSettingsGroupBox.TabStop = False
        Me.CSettingsGroupBox.Text = "CSettings"
        '
        'LSettingsGroupBox
        '
        Me.LSettingsGroupBox.Controls.Add(Me.LmicroRadioButton)
        Me.LSettingsGroupBox.Controls.Add(Me.LmilliRadioButton)
        Me.LSettingsGroupBox.Controls.Add(Me.LRadioButton)
        Me.LSettingsGroupBox.Location = New System.Drawing.Point(854, 517)
        Me.LSettingsGroupBox.Name = "LSettingsGroupBox"
        Me.LSettingsGroupBox.Size = New System.Drawing.Size(83, 105)
        Me.LSettingsGroupBox.TabIndex = 39
        Me.LSettingsGroupBox.TabStop = False
        Me.LSettingsGroupBox.Text = "LSettings"
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
        Me.FrequencySettingsGroupBox.Location = New System.Drawing.Point(646, 517)
        Me.FrequencySettingsGroupBox.Name = "FrequencySettingsGroupBox"
        Me.FrequencySettingsGroupBox.Size = New System.Drawing.Size(83, 105)
        Me.FrequencySettingsGroupBox.TabIndex = 40
        Me.FrequencySettingsGroupBox.TabStop = False
        Me.FrequencySettingsGroupBox.Text = "FSettings"
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
        'SeriesParallelCalculator
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1140, 637)
        Me.Controls.Add(Me.FrequencySettingsGroupBox)
        Me.Controls.Add(Me.LSettingsGroupBox)
        Me.Controls.Add(Me.CSettingsGroupBox)
        Me.Controls.Add(Me.ControlsGroupBox)
        Me.Controls.Add(Me.ValuesGroupBox)
        Me.Controls.Add(Me.ResultsListBox)
        Me.Controls.Add(Me.FrequencyLabel)
        Me.Controls.Add(Me.VgenLabel)
        Me.Controls.Add(Me.R3Label)
        Me.Controls.Add(Me.C2Label)
        Me.Controls.Add(Me.R2Label)
        Me.Controls.Add(Me.L1Label)
        Me.Controls.Add(Me.R1Label)
        Me.Controls.Add(Me.C1Label)
        Me.Controls.Add(Me.CircuitPictureBox)
        Me.Controls.Add(Me.CalcMenuStrip)
        Me.MainMenuStrip = Me.CalcMenuStrip
        Me.Name = "SeriesParallelCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Series-Parallel Circuit Calculator"
        Me.CalcMenuStrip.ResumeLayout(False)
        Me.CalcMenuStrip.PerformLayout()
        CType(Me.CircuitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents R2Label As Label
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
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
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
End Class
