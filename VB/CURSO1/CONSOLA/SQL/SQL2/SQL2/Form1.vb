Imports System.Configuration
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Runtime.Intrinsics.X86
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient


Public Class Form1

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click

        Dim conexion As MySqlConnection
        conexion = New MySqlConnection("server=192.168.1.42; user id= angel ; password=blamor75; database=HOGAR")
        conexion.Open()
        Dim nombre As String = ProductBox.Text
        Dim price As String = PriceBox.Text
        Dim cadena As String = "insert into ARTICULOS (nombre, precio) values ('" & nombre & "', '" & price & "')"
        Dim comando As MySqlCommand
        comando = New MySqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        MessageBox.Show("Los datos han sido guardados")
        ProductBox.Text = ""
        PriceBox.Text = ""
        conexion.Close()
    End Sub

    Private Sub ListButton_Click(sender As Object, e As EventArgs) Handles ListButton.Click
        ListBox.Text=""
        Dim conexion As MySqlConnection
        conexion = New MySqlConnection("server=192.168.1.42; user id= angel ; password=blamor75; database=HOGAR")
        conexion.Open()
        Dim cadena As String = "select codigo, nombre, precio from ARTICULOS"
        Dim comando As MySqlCommand
        comando = New MySqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        Dim registros As MySqlDataReader
        registros = comando.ExecuteReader
        Do While registros.Read() = True
            ListBox.AppendText(registros("codigo"))
            ListBox.AppendText("-")
            ListBox.AppendText(registros("nombre"))
            ListBox.AppendText("-")
            ListBox.AppendText(registros("precio"))
            ListBox.AppendText(vbCrLf)

        Loop

    End Sub
End Class






REM ****************************************************************************************
REM * CLASE QUE ESTABLECE LOS PARAMETROS DE LA CONEXION CON EL SERVIDOR MYSQL. RASPBERRYPI *
REM ****************************************************************************************
Public Class Conexion
    Private MysqlCommand As New MySqlCommand
    Public myconexion = New MySqlConnection("server=192.168.1.42; user id= angel ; password=blamor75; database=HOGAR")
    Public Sub Inicia()
        myconexion.Open()
    End Sub
End Class


