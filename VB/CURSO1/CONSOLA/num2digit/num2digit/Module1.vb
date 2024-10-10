Module Module1

    Sub Main()
        Dim num1 As Integer

        Console.Write("Ingrese el numero a evaluar: ")
        num1 = Console.ReadLine()

        If num1 >= 10 Then
            Console.WriteLine("El número tiene dos digitos")
        Else
            Console.WriteLine("El número tiene un digito")
        End If
        Console.ReadKey()
    End Sub

End Module
