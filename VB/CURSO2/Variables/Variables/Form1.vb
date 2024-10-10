Public Class Form1

    Private Sub BCalcIVA_Click(sender As Object, e As EventArgs) Handles BCalcIVA.Click
        Dim bruto, neto As Single
        bruto = TextBruto.Text
        TextNeto.Text = bruto * 1.21

    End Sub


End Class
