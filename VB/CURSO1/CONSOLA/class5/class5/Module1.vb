Module Module1
    Public Class Employ
        Private name As String
        Private cash As Integer

        Public Sub Inicializa()
            Console.Write("Escriba el nombre del empleado: ")
            name = Console.ReadLine()
            Console.Write(" Escriba el sueldo del empleado: ")
            cash = Console.ReadLine()
        End Sub
        Public Sub Printer()
            Console.WriteLine("El empleado se llama: " & name)
            Console.WriteLine("El sueldo del empleado es: " & cash)
        End Sub
        Public Sub Impuestos()
            If cash >= 3000 Then
                Console.WriteLine("El empleado debe de pagar impuestos")
            ElseIf cash < 3000 And cash > 0 Then
                Console.WriteLine("El empleado no debe de pagar impuestos")
            End If
        End Sub

    End Class
    Sub Main()
        Dim workman As New Employ()
        workman.Inicializa()
        workman.Printer()
        workman.Impuestos()
        Console.ReadKey()
    End Sub

End Module
