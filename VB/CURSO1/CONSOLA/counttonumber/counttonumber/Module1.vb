Module Module1

    Sub Main()
        Dim num1, num2 As Integer

        num1 = 1
        Console.Write("Ingrese el número a evaluar: ")
        num2 = Console.ReadLine()

        Do While num1 <= num2
            Console.WriteLine(num1)
            num1 += 1
        Loop
        Console.WriteLine("Pulse cualquier tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
