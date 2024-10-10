Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar.ToString = Chr(13) Then
            TextBox2.Focus()
        Else
            TextBox2.Text = TextBox2.Text + e.KeyChar.ToString
        End If

    End Sub
End Class
