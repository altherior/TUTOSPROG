Public Class Form1
    Dim cadena, palabra As String
    Dim verifica As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        cadena = TextInput01.Text
        palabra = TextWord01.Text

        verifica = cadena.Contains(palabra)

        If verifica = True Then
            MsgBox("La cadena tiene la palabra " & palabra)
        Else
            MsgBox("La cadena no tiene la palabra " & palabra)
        End If
    End Sub
End Class
