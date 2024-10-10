Module Module1

    Sub Main()
        Dim num1 As Integer

        Console.Write("Ingrese el número a evaluar: ")
        num1 = Console.ReadLine()

        If num1 > 0 Then
            Console.Write("El numero es positivo")
        ElseIf num1 = 0 Then
            Console.Write("el número es nulo")
        Else
            Console.Write("El número es negativo")
        End If
        Console.ReadKey()
    End Sub

End Module
