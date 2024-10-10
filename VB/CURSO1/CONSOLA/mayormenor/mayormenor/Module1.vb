Module Module1

    Sub Main()
        Dim num1, num2 As Single

        Console.Write("Introduzca el primer número: ")
        num1 = Console.ReadLine()
        Console.Write("Introduzca el segundo número: ")
        num2 = Console.ReadLine()
        If num1 < num2 Then
            Console.Write("El número " & num2 & " es el mayor")
        Else
            Console.Write("El número " & num1 & " es el mayor")
        End If
        Console.ReadKey()
    End Sub

End Module
