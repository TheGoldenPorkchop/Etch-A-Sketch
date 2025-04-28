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
        Me.ForegroundColorTopMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ForegroundColorTopMenuItem.Text = "Select &Color"
        '
        'DrawWaveformsTopMenuItem
        '
        Me.DrawWaveformsTopMenuItem.Name = "DrawWaveformsTopMenuItem"
        Me.DrawWaveformsTopMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DrawWaveformsTopMenuItem.Text = "Draw Waveforms"
        '
        'ClearTopMenuItem
        '
        Me.ClearTopMenuItem.Name = "ClearTopMenuItem"
        Me.ClearTopMenuItem.Size = New System.Drawing.Size(224, 26)
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
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(211, 104)
        '
        'ForegroundColorMenuItem
        '
        Me.ForegroundColorMenuItem.Name = "ForegroundColorMenuItem"
        Me.ForegroundColorMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.ForegroundColorMenuItem.Text = "Select &Color"
        '
        'DrawWaveformsMenuItem
        '
        Me.DrawWaveformsMenuItem.Name = "DrawWaveformsMenuItem"
        Me.DrawWaveformsMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.DrawWaveformsMenuItem.Text = "Draw Waveforms"
        '
        'ClearMenuItem
        '
        Me.ClearMenuItem.Name = "ClearMenuItem"
        Me.ClearMenuItem.Size = New System.Drawing.Size(210, 24)
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
        Me.DrawingPictureBox.Size = New System.Drawing.Size(763, 328)
        Me.DrawingPictureBox.TabIndex = 1
        Me.DrawingPictureBox.TabStop = False
        Me.DrawingToolTip.SetToolTip(Me.DrawingPictureBox, "Right Click For More Options")
        '
        'DrawWaveButton
        '
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
        Me.ExitButton.Location = New System.Drawing.Point(402, 365)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(124, 73)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit Button"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GraphicEx
        '
        Me.AcceptButton = Me.DrawWaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.EraseButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
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
End Class
