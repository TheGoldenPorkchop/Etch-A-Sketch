<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GraphicEx
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
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForegroundColorTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ForegroundColorMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawingToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.DrawWaveButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ModeSelectGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnalogModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.MouseModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.PortsComboBox = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.XAnalogTextBox = New System.Windows.Forms.TextBox()
        Me.YAnalogTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AnalogCoordsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TopMenuStrip.SuspendLayout()
        Me.MainContextMenuStrip.SuspendLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ModeSelectGroupBox.SuspendLayout()
        Me.AnalogCoordsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(920, 30)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorTopMenuItem, Me.DrawWaveformsTopMenuItem, Me.ClearTopMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ForegroundColorTopMenuItem
        '
        Me.ForegroundColorTopMenuItem.Name = "ForegroundColorTopMenuItem"
        Me.ForegroundColorTopMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ForegroundColorTopMenuItem.Text = "Select &Color"
        '
        'DrawWaveformsTopMenuItem
        '
        Me.DrawWaveformsTopMenuItem.Name = "DrawWaveformsTopMenuItem"
        Me.DrawWaveformsTopMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsTopMenuItem.Text = "Draw Waveforms"
        '
        'ClearTopMenuItem
        '
        Me.ClearTopMenuItem.Name = "ClearTopMenuItem"
        Me.ClearTopMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ClearTopMenuItem.Text = "Erase"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorMenuItem, Me.DrawWaveformsMenuItem, Me.ClearMenuItem})
        Me.MainContextMenuStrip.Name = "ContextMenuStrip1"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(192, 76)
        '
        'ForegroundColorMenuItem
        '
        Me.ForegroundColorMenuItem.Name = "ForegroundColorMenuItem"
        Me.ForegroundColorMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.ForegroundColorMenuItem.Text = "Select &Color"
        '
        'DrawWaveformsMenuItem
        '
        Me.DrawWaveformsMenuItem.Name = "DrawWaveformsMenuItem"
        Me.DrawWaveformsMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.DrawWaveformsMenuItem.Text = "Draw Waveforms"
        '
        'ClearMenuItem
        '
        Me.ClearMenuItem.Name = "ClearMenuItem"
        Me.ClearMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.ClearMenuItem.Text = "Erase"
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.White
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 31)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(883, 328)
        Me.DrawingPictureBox.TabIndex = 1
        Me.DrawingPictureBox.TabStop = False
        Me.DrawingToolTip.SetToolTip(Me.DrawingPictureBox, "Right Click For More Options")
        '
        'DrawWaveButton
        '
        Me.DrawWaveButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawWaveButton.Location = New System.Drawing.Point(12, 365)
        Me.DrawWaveButton.Name = "DrawWaveButton"
        Me.DrawWaveButton.Size = New System.Drawing.Size(124, 73)
        Me.DrawWaveButton.TabIndex = 2
        Me.DrawWaveButton.Text = "Draw Wave"
        Me.DrawingToolTip.SetToolTip(Me.DrawWaveButton, "Draws A Sin, Cos, and Tan wave")
        Me.DrawWaveButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectColorButton.Location = New System.Drawing.Point(142, 365)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(124, 73)
        Me.SelectColorButton.TabIndex = 3
        Me.SelectColorButton.Text = "Select &Color"
        Me.DrawingToolTip.SetToolTip(Me.SelectColorButton, "Select a Color")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EraseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.EraseButton.Location = New System.Drawing.Point(272, 365)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(124, 73)
        Me.EraseButton.TabIndex = 4
        Me.EraseButton.Text = "Erase"
        Me.DrawingToolTip.SetToolTip(Me.EraseButton, "Erases the Canvas")
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(402, 365)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(124, 73)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit Button"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ModeSelectGroupBox
        '
        Me.ModeSelectGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModeSelectGroupBox.Controls.Add(Me.AnalogModeRadioButton)
        Me.ModeSelectGroupBox.Controls.Add(Me.MouseModeRadioButton)
        Me.ModeSelectGroupBox.Location = New System.Drawing.Point(532, 365)
        Me.ModeSelectGroupBox.Name = "ModeSelectGroupBox"
        Me.ModeSelectGroupBox.Size = New System.Drawing.Size(134, 73)
        Me.ModeSelectGroupBox.TabIndex = 6
        Me.ModeSelectGroupBox.TabStop = False
        Me.ModeSelectGroupBox.Text = "Mode Select"
        '
        'AnalogModeRadioButton
        '
        Me.AnalogModeRadioButton.AutoSize = True
        Me.AnalogModeRadioButton.Location = New System.Drawing.Point(6, 47)
        Me.AnalogModeRadioButton.Name = "AnalogModeRadioButton"
        Me.AnalogModeRadioButton.Size = New System.Drawing.Size(109, 20)
        Me.AnalogModeRadioButton.TabIndex = 8
        Me.AnalogModeRadioButton.Text = "Analog Mode"
        Me.AnalogModeRadioButton.UseVisualStyleBackColor = True
        '
        'MouseModeRadioButton
        '
        Me.MouseModeRadioButton.AutoSize = True
        Me.MouseModeRadioButton.Checked = True
        Me.MouseModeRadioButton.Location = New System.Drawing.Point(6, 21)
        Me.MouseModeRadioButton.Name = "MouseModeRadioButton"
        Me.MouseModeRadioButton.Size = New System.Drawing.Size(107, 20)
        Me.MouseModeRadioButton.TabIndex = 7
        Me.MouseModeRadioButton.TabStop = True
        Me.MouseModeRadioButton.Text = "Mouse Mode"
        Me.MouseModeRadioButton.UseVisualStyleBackColor = True
        '
        'PortsComboBox
        '
        Me.PortsComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PortsComboBox.FormattingEnabled = True
        Me.PortsComboBox.Location = New System.Drawing.Point(672, 390)
        Me.PortsComboBox.Name = "PortsComboBox"
        Me.PortsComboBox.Size = New System.Drawing.Size(78, 24)
        Me.PortsComboBox.TabIndex = 9
        '
        'Timer1
        '
        '
        'XAnalogTextBox
        '
        Me.XAnalogTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XAnalogTextBox.Location = New System.Drawing.Point(27, 19)
        Me.XAnalogTextBox.Name = "XAnalogTextBox"
        Me.XAnalogTextBox.ReadOnly = True
        Me.XAnalogTextBox.Size = New System.Drawing.Size(100, 22)
        Me.XAnalogTextBox.TabIndex = 9
        '
        'YAnalogTextBox
        '
        Me.YAnalogTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YAnalogTextBox.Location = New System.Drawing.Point(27, 46)
        Me.YAnalogTextBox.Name = "YAnalogTextBox"
        Me.YAnalogTextBox.ReadOnly = True
        Me.YAnalogTextBox.Size = New System.Drawing.Size(100, 22)
        Me.YAnalogTextBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Y"
        '
        'AnalogCoordsGroupBox
        '
        Me.AnalogCoordsGroupBox.Controls.Add(Me.XAnalogTextBox)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.YAnalogTextBox)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.Label2)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.Label1)
        Me.AnalogCoordsGroupBox.Location = New System.Drawing.Point(756, 365)
        Me.AnalogCoordsGroupBox.Name = "AnalogCoordsGroupBox"
        Me.AnalogCoordsGroupBox.Size = New System.Drawing.Size(139, 73)
        Me.AnalogCoordsGroupBox.TabIndex = 13
        Me.AnalogCoordsGroupBox.TabStop = False
        Me.AnalogCoordsGroupBox.Text = "Analog Coords"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(672, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Port Select"
        '
        'GraphicEx
        '
        Me.AcceptButton = Me.DrawWaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.EraseButton
        Me.ClientSize = New System.Drawing.Size(920, 450)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AnalogCoordsGroupBox)
        Me.Controls.Add(Me.PortsComboBox)
        Me.Controls.Add(Me.ModeSelectGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.DrawWaveButton)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "GraphicEx"
        Me.Text = "Form1"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.MainContextMenuStrip.ResumeLayout(False)
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ModeSelectGroupBox.ResumeLayout(False)
        Me.ModeSelectGroupBox.PerformLayout()
        Me.AnalogCoordsGroupBox.ResumeLayout(False)
        Me.AnalogCoordsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForegroundColorTopMenuItem As ToolStripMenuItem
    Friend WithEvents MainContextMenuStrip As ContextMenuStrip
    Friend WithEvents ForegroundColorMenuItem As ToolStripMenuItem
    Friend WithEvents ClearMenuItem As ToolStripMenuItem
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents ClearTopMenuItem As ToolStripMenuItem
    Friend WithEvents DrawingToolTip As ToolTip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveButton As Button
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
    Friend WithEvents ExitButton As Button
    Friend WithEvents DrawWaveformsTopMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsMenuItem As ToolStripMenuItem
    Friend WithEvents ModeSelectGroupBox As GroupBox
    Friend WithEvents MouseModeRadioButton As RadioButton
    Friend WithEvents AnalogModeRadioButton As RadioButton
    Friend WithEvents PortsComboBox As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents XAnalogTextBox As TextBox
    Friend WithEvents YAnalogTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AnalogCoordsGroupBox As GroupBox
    Friend WithEvents Label3 As Label
End Class
