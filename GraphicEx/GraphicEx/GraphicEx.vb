'Angel Nava
'Spring 2025
'RCET2265
'Graphics Example
'link
Option Strict On
Option Explicit On

Imports System.Media
Imports System.Runtime.CompilerServices
Imports System.Threading.Thread


'ToDo List
' [ ] Add functionality for all context menu items
'   [ ] background color
'   [ ] pen width as drop down or text input with max width defined
'   [ ] font
' [ ] Match functionality between context meny and top menu
' [X] add tool tip on picture box
' [ ] plot sine wavve
' [ ] add erase mode
' [ ] draw shape(s) tool
' [ ] add about form
' [ ] add splash screen
' [ ] Fill Bucket tool Would be Cool (jelly of the month)

Public Class GraphicEx

    Function BackGroundColor(Optional newColor As Color = Nothing) As Color
        Static _backColor As Color = Color.White

        If newColor <> Nothing Then
            _backColor = newColor
        End If

        Return _backColor
    End Function

    Function PenWidth(Optional newWidth As Integer = -1) As Integer
        Static _penWidth As Integer = 1
        If newWidth > 100 Then
            _penwidth = 100
        ElseIf newWidth > 0 Then
            _penwidth = newWidth
        End If

        Return _penWidth
    End Function

    Function ForeGroundColor(Optional newColor As Color = Nothing) As Color
        Static _foreColor As Color = Color.Black

        If newColor <> Nothing Then
            _foreColor = newColor
        End If

        Return _foreColor
    End Function

    Sub SinWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Orange)
        Dim ymax As Integer
        Dim oldX, oldY, newY As Integer
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim degreesPerPoint As Double = 360 / DrawingPictureBox.Width

        ymax = yOffset
        oldY = yOffset
        ymax *= -1
        For x = 0 To DrawingPictureBox.Width
            newY = CInt(ymax * Math.Sin((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
            g.DrawLine(pen, oldX, oldY, x, newY)
            oldX = x
            oldY = newY

        Next

        g.Dispose()
    End Sub

    Sub CosWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Blue)
        Dim ymax As Integer
        Dim oldX, oldY, newY As Integer
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim degreesPerPoint As Double = 360 / DrawingPictureBox.Width

        ymax = yOffset
        oldY = yOffset
        ymax *= -1
        For x = 0 To DrawingPictureBox.Width
            newY = CInt(ymax * Math.Cos((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
            g.DrawLine(pen, oldX, oldY, x, newY)
            oldX = x
            oldY = newY

        Next

        g.Dispose()
    End Sub

    Sub TanWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Red)
        Dim ymax As Integer
        Dim oldX, oldY, newY As Integer
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim degreesPerPoint As Double = 360 / DrawingPictureBox.Width

        ymax = yOffset
        oldY = yOffset
        ymax *= -1
        For x = 0 To DrawingPictureBox.Width
            Try
                newY = CInt(ymax * Math.Tan((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
                g.DrawLine(pen, oldX, oldY, x, newY)
                oldX = x
                oldY = newY
            Catch ex As Exception
                'MsgBox("Oops. Something Went wrong with Trying to graph the Tangent Line.")
            End Try


        Next

        g.Dispose()
    End Sub

    Sub Graticule()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        ' Draw vertical lines
        For x As Integer = 0 To DrawingPictureBox.Width Step (DrawingPictureBox.Width \ 10)
            g.DrawLine(pen, x, 0, x, DrawingPictureBox.Height)
        Next
        ' Draw horizontal lines
        For y As Integer = 0 To DrawingPictureBox.Height Step (DrawingPictureBox.Height \ 10)
            g.DrawLine(pen, 0, y, DrawingPictureBox.Width, y)
        Next
        g.Dispose()
    End Sub

    Sub DrawWithMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForeGroundColor, PenWidth())
        g.DrawLine(pen, oldX, oldY, newX, newY)

        g.Dispose()
    End Sub

    'Event Handlers --------------------------------------------------------

    Private Sub GraphicEx_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown
        Static oldX, oldY, LastVerticalLineX As Integer
        Dim lastColor As Color
        Dim lastWidth As Integer
        Me.Text = $"({e.X},{e.Y}) {e.Button.ToString} FG {ForeGroundColor.ToString}"
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
                'MsgBox("Yippee!")
            Case "middle"
                'ToDo
                'Manually draw a line from top to bottom in the middle
                ''DrawWithMouse(DrawingPictureBox.Width, 0, DrawingPictureBox.Width \ 2, DrawingPictureBox.Height)
                'Draws a line top to bottom on the current mouse location
                lastColor = ForeGroundColor() 'save user color
                lastWidth = PenWidth() 'save user penwidth
                PenWidth(3) ' set wider pen width to elimate nasty ghosting
                ForeGroundColor(BackGroundColor()) ' set foreground color to background color
                DrawWithMouse(LastVerticalLineX, 0, LastVerticalLineX, DrawingPictureBox.Height) ' erase last line

                PenWidth(1) ' set width to 1 pixel
                ForeGroundColor(lastColor) ' revert foreground color to user defined color
                DrawWithMouse(e.X, 0, e.X, DrawingPictureBox.Height) ' draw vertical line
                LastVerticalLineX = e.X ' store x position of last line
                PenWidth(lastWidth) ' revert line to user pen width


        End Select
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub ChangeBackgroundColor(sender As Object, e As EventArgs) Handles BackgroundColorTopMenuItem.Click, BackgroundColorMenuItem.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
        If result.ToString = "OK" Then
            BackGroundColor(ColorDialog.Color)
        End If
        'this following line erases everything
        'DrawingPictureBox.BackColor = BackGroundColor()

    End Sub

    Private Sub ChangeforegroundColor(sender As Object, e As EventArgs) Handles ForegroundColorTopMenuItem.Click, ForegroundColorMenuItem.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
        If result.ToString = "OK" Then
            ForeGroundColor(ColorDialog.Color)
        End If
    End Sub


    Private Sub ClearContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearMenuItem.Click
        Dim woag As Integer = 20
        'https://freesound.org/
        Try
            My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        For i = 1 To 3
            Me.Top += woag
            Me.Left += woag
            Sleep(100)
            woag *= -1
        Next

        DrawingPictureBox.Refresh() '.BackColor = BackgroundColor()

    End Sub

    Private Sub ChangePenWidth(sender As Object, e As EventArgs) Handles WidthMenuItem.Click, WidthTopMenuItem.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        About.Show()
    End Sub

    Private Sub GraphicEx_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Static isStartUp As Boolean = True
        If isStartUp Then
            SplashForm.Show()
            isStartUp = False
        End If
    End Sub

    Private Sub DrawSineWaveButton_Click(sender As Object, e As EventArgs) Handles DrawSineWaveButton.Click
        Graticule()
        SinWave()
        CosWave()
        TanWave()
    End Sub

    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click
        Dim woag As Integer = 20
        'https://freesound.org/
        Try
            My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        For i = 1 To 3
            Me.Top += woag
            Me.Left += woag
            Sleep(100)
            woag *= -1
        Next

        DrawingPictureBox.Refresh() '.BackColor = BackgroundColor()
    End Sub

    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
        If result.ToString = "OK" Then
            ForeGroundColor(ColorDialog.Color)
        End If
    End Sub
End Class
