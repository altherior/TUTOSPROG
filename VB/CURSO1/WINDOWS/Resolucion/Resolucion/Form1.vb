Public Class Form1
    Private Sub SetRes_Click(sender As Object, e As EventArgs) Handles SetRes.Click
        Me.Close()
    End Sub

    Private Sub Radio640_Click(sender As Object, e As EventArgs) Handles Radio640.Click
        If Radio640.Checked Then
            Width = 640
            Height = 480
            SetRes.Location = New Point(435, 349)
        End If
    End Sub

    Private Sub Radio800_Click(sender As Object, e As EventArgs) Handles Radio800.Click
        If Radio800.Checked Then
            Width = 800
            Height = 600
            SetRes.Location = New Point(595, 469)
        End If
    End Sub

    Private Sub Radio1024_Click(sender As Object, e As EventArgs) Handles Radio1024.Click
        If Radio1024.Checked Then
            Width = 1024
            Height = 768
            SetRes.Location = New Point(819, 637)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class
