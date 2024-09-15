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
        Me.RwLabel = New System.Windows.Forms.Label()
        Me.C2Label = New System.Windows.Forms.Label()
        Me.R2Label = New System.Windows.Forms.Label()
        Me.VgenLabel = New System.Windows.Forms.Label()
        Me.FrequencyLabel = New System.Windows.Forms.Label()
        Me.ResultsListBox = New System.Windows.Forms.ListBox()
        Me.VgenTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.VgenValueLabel = New System.Windows.Forms.Label()
        Me.FrequencyValueLabel = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.C1ValueLabel = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.C2ValueLabel = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.R1ValueLabel = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.R2ValueLabel = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.L1ValueLabel = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.RwValueLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalcContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcMenuStrip.SuspendLayout()
        CType(Me.CircuitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CalcContextMenuStrip.SuspendLayout()
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
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
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
        'RwLabel
        '
        Me.RwLabel.AutoSize = True
        Me.RwLabel.Location = New System.Drawing.Point(539, 323)
        Me.RwLabel.Name = "RwLabel"
        Me.RwLabel.Size = New System.Drawing.Size(26, 16)
        Me.RwLabel.TabIndex = 5
        Me.RwLabel.Text = "Rw"
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
        'R2Label
        '
        Me.R2Label.AutoSize = True
        Me.R2Label.Location = New System.Drawing.Point(772, 323)
        Me.R2Label.Name = "R2Label"
        Me.R2Label.Size = New System.Drawing.Size(24, 16)
        Me.R2Label.TabIndex = 7
        Me.R2Label.Text = "R2"
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
        Me.ResultsListBox.Size = New System.Drawing.Size(223, 452)
        Me.ResultsListBox.TabIndex = 10
        '
        'VgenTextBox
        '
        Me.VgenTextBox.Location = New System.Drawing.Point(12, 537)
        Me.VgenTextBox.Name = "VgenTextBox"
        Me.VgenTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VgenTextBox.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 585)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 12
        '
        'VgenValueLabel
        '
        Me.VgenValueLabel.AutoSize = True
        Me.VgenValueLabel.Location = New System.Drawing.Point(17, 518)
        Me.VgenValueLabel.Name = "VgenValueLabel"
        Me.VgenValueLabel.Size = New System.Drawing.Size(39, 16)
        Me.VgenValueLabel.TabIndex = 13
        Me.VgenValueLabel.Text = "Vgen"
        '
        'FrequencyValueLabel
        '
        Me.FrequencyValueLabel.AutoSize = True
        Me.FrequencyValueLabel.Location = New System.Drawing.Point(17, 566)
        Me.FrequencyValueLabel.Name = "FrequencyValueLabel"
        Me.FrequencyValueLabel.Size = New System.Drawing.Size(71, 16)
        Me.FrequencyValueLabel.TabIndex = 14
        Me.FrequencyValueLabel.Text = "Frequency"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(170, 537)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 15
        '
        'C1ValueLabel
        '
        Me.C1ValueLabel.AutoSize = True
        Me.C1ValueLabel.Location = New System.Drawing.Point(177, 518)
        Me.C1ValueLabel.Name = "C1ValueLabel"
        Me.C1ValueLabel.Size = New System.Drawing.Size(23, 16)
        Me.C1ValueLabel.TabIndex = 16
        Me.C1ValueLabel.Text = "C1"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(170, 585)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 17
        '
        'C2ValueLabel
        '
        Me.C2ValueLabel.AutoSize = True
        Me.C2ValueLabel.Location = New System.Drawing.Point(177, 566)
        Me.C2ValueLabel.Name = "C2ValueLabel"
        Me.C2ValueLabel.Size = New System.Drawing.Size(23, 16)
        Me.C2ValueLabel.TabIndex = 18
        Me.C2ValueLabel.Text = "C2"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(329, 537)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 19
        '
        'R1ValueLabel
        '
        Me.R1ValueLabel.AutoSize = True
        Me.R1ValueLabel.Location = New System.Drawing.Point(335, 518)
        Me.R1ValueLabel.Name = "R1ValueLabel"
        Me.R1ValueLabel.Size = New System.Drawing.Size(24, 16)
        Me.R1ValueLabel.TabIndex = 20
        Me.R1ValueLabel.Text = "R1"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(329, 585)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 21
        '
        'R2ValueLabel
        '
        Me.R2ValueLabel.AutoSize = True
        Me.R2ValueLabel.Location = New System.Drawing.Point(335, 566)
        Me.R2ValueLabel.Name = "R2ValueLabel"
        Me.R2ValueLabel.Size = New System.Drawing.Size(24, 16)
        Me.R2ValueLabel.TabIndex = 22
        Me.R2ValueLabel.Text = "R2"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(493, 537)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 22)
        Me.TextBox6.TabIndex = 23
        '
        'L1ValueLabel
        '
        Me.L1ValueLabel.AutoSize = True
        Me.L1ValueLabel.Location = New System.Drawing.Point(503, 518)
        Me.L1ValueLabel.Name = "L1ValueLabel"
        Me.L1ValueLabel.Size = New System.Drawing.Size(21, 16)
        Me.L1ValueLabel.TabIndex = 24
        Me.L1ValueLabel.Text = "L1"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(493, 585)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 22)
        Me.TextBox7.TabIndex = 25
        '
        'RwValueLabel
        '
        Me.RwValueLabel.AutoSize = True
        Me.RwValueLabel.Location = New System.Drawing.Point(503, 566)
        Me.RwValueLabel.Name = "RwValueLabel"
        Me.RwValueLabel.Size = New System.Drawing.Size(87, 16)
        Me.RwValueLabel.TabIndex = 26
        Me.RwValueLabel.Text = "Rw (Optional)"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(652, 536)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(143, 70)
        Me.CalculateButton.TabIndex = 27
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(817, 536)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(143, 70)
        Me.ClearButton.TabIndex = 28
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(979, 536)
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
        Me.CalculateToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.CalculateToolStripMenuItem1.Text = "Calculate"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'SeriesParallelCalculator
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1140, 637)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.RwValueLabel)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.L1ValueLabel)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.R2ValueLabel)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.R1ValueLabel)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.C2ValueLabel)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.C1ValueLabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.FrequencyValueLabel)
        Me.Controls.Add(Me.VgenValueLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.VgenTextBox)
        Me.Controls.Add(Me.ResultsListBox)
        Me.Controls.Add(Me.FrequencyLabel)
        Me.Controls.Add(Me.VgenLabel)
        Me.Controls.Add(Me.R2Label)
        Me.Controls.Add(Me.C2Label)
        Me.Controls.Add(Me.RwLabel)
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
    Friend WithEvents RwLabel As Label
    Friend WithEvents C2Label As Label
    Friend WithEvents R2Label As Label
    Friend WithEvents VgenLabel As Label
    Friend WithEvents FrequencyLabel As Label
    Friend WithEvents ResultsListBox As ListBox
    Friend WithEvents VgenTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents VgenValueLabel As Label
    Friend WithEvents FrequencyValueLabel As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents C1ValueLabel As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents C2ValueLabel As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents R1ValueLabel As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents R2ValueLabel As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents L1ValueLabel As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents RwValueLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents CalcContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
