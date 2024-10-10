Module Module1

    Sub Main()
        Dim num1 As Integer

        num1 = 1
        Do While num1 <= 100
            Console.WriteLine(num1)
            num1 += 1
        Loop
        Console.WriteLine("Pulse una tecla para finalizar")
        Console.ReadKey()
    End Sub

End Module
