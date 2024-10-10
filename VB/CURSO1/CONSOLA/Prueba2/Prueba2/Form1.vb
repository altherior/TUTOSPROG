Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim contador As Integer
        For contador = 0 To 10
            Text = contador
            System.Threading.Thread.Sleep(500)
        Next
    End Sub
End Class
