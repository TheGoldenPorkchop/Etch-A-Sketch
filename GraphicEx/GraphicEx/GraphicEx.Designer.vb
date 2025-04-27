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
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForegroundColorTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ForegroundColorMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PickWidthMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.CustomWidthMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FontMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawingToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.DrawSineWaveButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.TopMenuStrip.SuspendLayout()
        Me.MainContextMenuStrip.SuspendLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(800, 28)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorTopMenuItem, Me.BackgroundColorTopMenuItem, Me.WidthTopMenuItem, Me.FontTopMenuItem, Me.ClearTopMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ForegroundColorTopMenuItem
        '
        Me.ForegroundColorTopMenuItem.Name = "ForegroundColorTopMenuItem"
        Me.ForegroundColorTopMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ForegroundColorTopMenuItem.Text = "Foreground Color"
        '
        'BackgroundColorTopMenuItem
        '
        Me.BackgroundColorTopMenuItem.Name = "BackgroundColorTopMenuItem"
        Me.BackgroundColorTopMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BackgroundColorTopMenuItem.Text = "Background Color"
        '
        'WidthTopMenuItem
        '
        Me.WidthTopMenuItem.Name = "WidthTopMenuItem"
        Me.WidthTopMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.WidthTopMenuItem.Text = "Width"
        '
        'FontTopMenuItem
        '
        Me.FontTopMenuItem.Name = "FontTopMenuItem"
        Me.FontTopMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FontTopMenuItem.Text = "Font"
        '
        'ClearTopMenuItem
        '
        Me.ClearTopMenuItem.Name = "ClearTopMenuItem"
        Me.ClearTopMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ClearTopMenuItem.Text = "Clear"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorMenuItem, Me.BackgroundColorMenuItem, Me.WidthMenuItem, Me.FontMenuItem, Me.ClearMenuItem})
        Me.MainContextMenuStrip.Name = "ContextMenuStrip1"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(198, 124)
        '
        'ForegroundColorMenuItem
        '
        Me.ForegroundColorMenuItem.Name = "ForegroundColorMenuItem"
        Me.ForegroundColorMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.ForegroundColorMenuItem.Text = "Foreground Color"
        '
        'BackgroundColorMenuItem
        '
        Me.BackgroundColorMenuItem.Name = "BackgroundColorMenuItem"
        Me.BackgroundColorMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.BackgroundColorMenuItem.Text = "Background Color"
        '
        'WidthMenuItem
        '
        Me.WidthMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PickWidthMenuItem, Me.CustomWidthMenuItem})
        Me.WidthMenuItem.Name = "WidthMenuItem"
        Me.WidthMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.WidthMenuItem.Text = "Width"
        '
        'PickWidthMenuItem
        '
        Me.PickWidthMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox2})
        Me.PickWidthMenuItem.Name = "PickWidthMenuItem"
        Me.PickWidthMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.PickWidthMenuItem.Text = "Pick"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 27)
        '
        'CustomWidthMenuItem
        '
        Me.CustomWidthMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.CustomWidthMenuItem.Name = "CustomWidthMenuItem"
        Me.CustomWidthMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.CustomWidthMenuItem.Text = "Custom"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        '
        'FontMenuItem
        '
        Me.FontMenuItem.Name = "FontMenuItem"
        Me.FontMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.FontMenuItem.Text = "Font"
        '
        'ClearMenuItem
        '
        Me.ClearMenuItem.Name = "ClearMenuItem"
        Me.ClearMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.ClearMenuItem.Text = "Clear"
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.White
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 31)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(763, 328)
        Me.DrawingPictureBox.TabIndex = 1
        Me.DrawingPictureBox.TabStop = False
        Me.DrawingToolTip.SetToolTip(Me.DrawingPictureBox, "Right Click For More Options")
        '
        'DrawSineWaveButton
        '
        Me.DrawSineWaveButton.Location = New System.Drawing.Point(12, 365)
        Me.DrawSineWaveButton.Name = "DrawSineWaveButton"
        Me.DrawSineWaveButton.Size = New System.Drawing.Size(124, 73)
        Me.DrawSineWaveButton.TabIndex = 2
        Me.DrawSineWaveButton.Text = "Wave"
        Me.DrawingToolTip.SetToolTip(Me.DrawSineWaveButton, "Draws A Sin, Cos, and Tan wave")
        Me.DrawSineWaveButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(142, 365)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(124, 73)
        Me.SelectColorButton.TabIndex = 3
        Me.SelectColorButton.Text = "Select Color"
        Me.DrawingToolTip.SetToolTip(Me.SelectColorButton, "Select a Color")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.EraseButton.Location = New System.Drawing.Point(272, 365)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(124, 73)
        Me.EraseButton.TabIndex = 4
        Me.EraseButton.Text = "Erase"
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'GraphicEx
        '
        Me.AcceptButton = Me.DrawSineWaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.EraseButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.DrawSineWaveButton)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "GraphicEx"
        Me.Text = "Form1"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.MainContextMenuStrip.ResumeLayout(False)
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BackgroundColorMenuItem As ToolStripMenuItem
    Friend WithEvents WidthMenuItem As ToolStripMenuItem
    Friend WithEvents FontMenuItem As ToolStripMenuItem
    Friend WithEvents ClearMenuItem As ToolStripMenuItem
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents BackgroundColorTopMenuItem As ToolStripMenuItem
    Friend WithEvents WidthTopMenuItem As ToolStripMenuItem
    Friend WithEvents FontTopMenuItem As ToolStripMenuItem
    Friend WithEvents ClearTopMenuItem As ToolStripMenuItem
    Friend WithEvents PickWidthMenuItem As ToolStripMenuItem
    Friend WithEvents CustomWidthMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents DrawingToolTip As ToolTip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawSineWaveButton As Button
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents EraseButton As Button
End Class
