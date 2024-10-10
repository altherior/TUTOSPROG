Public Class Form1

    Dim texto, saludo As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    REM * PROCEDIMIENTOS *
    Private Sub Saludar()
        REM Dim saludo As String
        saludo = "Hola soy un procedimiento no devuelvo valores"
        TextBoxMessage.Text = saludo
    End Sub


    REM * FUNCIONES *
    Private Function RetornaSaludo()
        REM Dim saludo As String
        saludo = "Hola soy una funcion para saludar, devuelvo valores con return"
        Return saludo
    End Function

    REM * PASO POR VALOR * 
    Private Sub FuncValor(ByVal variable As String)
        MsgBox(variable)
        variable = "Variable cambiada"
        MsgBox(variable)
    End Sub


    REM * PASO POR REFERENCIA *
    Private Sub FuncRef(ByRef variable As String)
        MsgBox(variable)
        variable = "Variable cambiada"
        MsgBox(variable)
    End Sub

    Private Sub BtnProc_Click(sender As Object, e As EventArgs) Handles BtnProc.Click
        Saludar()
    End Sub

    Private Sub BtnFunc_Click(sender As Object, e As EventArgs) Handles BtnFunc.Click
        REM  Dim texto As String
        texto = RetornaSaludo()
        TextBoxMessage.Text = texto
    End Sub

    Private Sub BtnFncVal_Click(sender As Object, e As EventArgs) Handles BtnFncVal.Click
        REM Dim texto As String
        texto = "Variable original"
        FuncValor(texto)
        MsgBox(texto)


    End Sub

    Private Sub BtnFuncRef_Click(sender As Object, e As EventArgs) Handles BtnFuncRef.Click
        Dim texto As String
        texto = "Variable original"
        FuncRef(texto)
        MsgBox(texto)
    End Sub
End Class
