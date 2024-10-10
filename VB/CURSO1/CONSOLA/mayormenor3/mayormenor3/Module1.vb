Module Module1

    Sub Main()
        Dim num1, num2, num3 As Integer
        Console.Write("Ingrese el primer número: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese el segundo número: ")
        num2 = Console.ReadLine()
        Console.Write("Ingres el tercer número: ")
        num3 = Console.ReadLine()

        If num1 > num2 Then
            If num1 > num3 Then
                Console.Write("El mayor es el número 1")
            End If
        ElseIf num2 > num3 Then
            Console.Write("El mayor es el número 2")
        Else
            Console.Write("El mayor es el número 3")
        End If
        Console.ReadKey()
    End Sub

End Module
