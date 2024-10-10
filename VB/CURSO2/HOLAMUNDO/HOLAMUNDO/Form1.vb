Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Public myarchivo As String
    Private Sub BUTTONHI_Click(sender As Object, e As EventArgs) Handles ButtonSaludo.Click
        myarchivo = My.Computer.FileSystem.ReadAllText("\\HOLAMUNDO\data.txt")
        MsgBox("Hola Mundo", MsgBoxStyle.Information)
        TextFile.Text = myarchivo

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class
