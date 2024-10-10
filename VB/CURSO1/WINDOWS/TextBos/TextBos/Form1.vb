Public Class Form1
    Private Sub Sum_Click(sender As Object, e As EventArgs) Handles Sum.Click
        Dim num1, num2, result As Integer

        If NumberOne.Text <> "" And NumberTwo.Text <> "" Then
            num1 = NumberOne.Text
            num2 = NumberTwo.Text
            result = num1 + num2
            Resultado.Text = result
        End If
    End Sub

    Private Sub Message_Click(sender As Object, e As EventArgs) Handles Message.Click
        MessageBox.Show("Acuerdo Aceptado")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Message.Enabled = True
        Else
            Message.Enabled = False
        End If
    End Sub
End Class
