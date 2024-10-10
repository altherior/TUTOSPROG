Public Class Form1
    Private Sub ButtonHello_Click(sender As Object, e As EventArgs) Handles ButtonHello.Click
        LabelMessage.Text = "HOLA MUNDO CRUEL."
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub
End Class
