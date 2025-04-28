'Angel Nava
'Spring 2025
'RCET2265
'Graphics Example
'https://github.com/TheGoldenPorkchop/Etch-A-Sketch/tree/main
Option Strict On
Option Explicit On

Imports System.Media
Imports System.Runtime.CompilerServices
Imports System.Threading.Thread

Public Class GraphicEx

    Function PenWidth(Optional newWidth As Integer = -1) As Integer
        Static _penWidth As Integer = 1
        If newWidth > 100 Then
            _penWidth = 100
        ElseIf newWidth > 0 Then
            _penWidth = newWidth
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
        Static oldX, oldY As Integer

        Me.Text = $"({e.X},{e.Y}) {e.Button.ToString} FG {ForeGroundColor.ToString}"
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
                'Empty
            Case "Middle"
                Dim result As DialogResult = ColorDialog.ShowDialog()
                If result.ToString = "OK" Then
                    ForeGroundColor(ColorDialog.Color)
                End If
        End Select
        oldX = e.X
        oldY = e.Y
    End Sub


    Private Sub ChangeforegroundColor(sender As Object, e As EventArgs) Handles ForegroundColorTopMenuItem.Click, ForegroundColorMenuItem.Click, SelectColorButton.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
        If result.ToString = "OK" Then
            ForeGroundColor(ColorDialog.Color)
        End If
    End Sub


    Private Sub ClearContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearMenuItem.Click, EraseButton.Click, ClearTopMenuItem.Click
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

    Private Sub DrawSineWaveButton_Click(sender As Object, e As EventArgs) Handles DrawWaveButton.Click, DrawWaveformsTopMenuItem.Click, DrawWaveformsMenuItem.Click
        Me.Refresh()
        Graticule()
        SinWave()
        CosWave()
        TanWave()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitMenuItem.Click
        Me.Close()
    End Sub
End Class
