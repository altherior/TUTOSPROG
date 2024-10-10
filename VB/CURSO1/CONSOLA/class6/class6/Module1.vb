Module Module1
    Public Class calculadora
        Private number1, number2, suma, multiplicacion, resta, division As Single
        Public Sub Incicializacion()
            Console.Write("Escriba el  primer número: ")
            number1 = Console.ReadLine()
            Console.Write("Escriba el segundo número: ")
            number2 = Console.ReadLine()
        End Sub
        Public Sub Sum()
            suma = number1 + number2
            Console.WriteLine("La suma de ambos números es: " & suma)
        End Sub
        Public Sub Rest()
            resta = number1 - number2
            Console.WriteLine("La resta de ambos números es: " & resta)
        End Sub
        Public Sub Multi()
            multiplicacion = number1 * number2
            Console.WriteLine("La multiplicacción de ambos números es: " & multiplicacion)
        End Sub
        Public Sub Div()
            division = number1 / number2
            Console.WriteLine("El resultado de la división es: " & division)
        End Sub

    End Class
    Sub Main()
        Dim calc As New calculadora()
        Dim tcl As Char
        Do
            Console.WriteLine("Pulse una tecla para iniciar. Q para salir.")
            tcl = Console.ReadLine()
            If tcl <> "Q" Then
                calc.Incicializacion()
                calc.Sum()
                calc.Rest()
                calc.Multi()
                calc.Div()
            End If

        Loop While tcl <> "Q"

    End Sub

End Module
