Public Class SplashForm
    Private Sub SplashForm_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub SplashForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        GraphicEx.SendToBack()
        GraphicEx.Hide()
        SplashTimer.Enabled() = True
    End Sub

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        SplashTimer.Enabled = False
        GraphicEx.Show()
        Me.Close()
    End Sub

End Class