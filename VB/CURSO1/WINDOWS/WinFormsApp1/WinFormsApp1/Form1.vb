Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Pantalla.Text.Length < 12 Then
            Pantalla.Text = Pantalla.Text & Button1.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Pantalla.Text.Length < 12 Then
            Pantalla.Text = Pantalla.Text & Button2.Text
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Pantalla.Text.Length < 12 Then
            Pantalla.Text = Pantalla.Text & Button3.Text
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Pantalla.Text.Length < 12 Then
            Pantalla.Text = Pantalla.Text + Button4.Text
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Pantalla.Text.Length < 12 Then
            Pantalla.Text = Pantalla.Text + Button5.Text
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Pantalla.Text.Length < 12 Then
            Pantalla.Text = Pantalla.Text + Button6.Text
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Pantalla.Text.Length < 12 Then
            Pantalla.Text = Pantalla.Text + Button7.Text
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Pantalla.Text.Length < 12 Then
            Pantalla.Text = Pantalla.Text + Button8.Text
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Pantalla.Text.Length < 12 Then
            Pantalla.Text = Pantalla.Text + Button9.Text
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Pantalla.Text.Length < 12 Then
            Pantalla.Text = Pantalla.Text + Button10.Text
        End If
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class
