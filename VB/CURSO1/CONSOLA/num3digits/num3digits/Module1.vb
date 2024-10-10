Module Module1

    Sub Main()
        Dim num1 As Integer

        Console.Write("Ingrese el número a evaluar: ")
        num1 = Console.ReadLine()

        If num1 > 999 Then
            Console.Write("Error, el número debe de ser de tres dígitos")
        ElseIf num1 > 99 Then
            Console.Write("El  número es de tres dígitos")
        ElseIf num1 > 9 Then
            Console.Write("El número es de dos dígitos")
        Else
            Console.Write("El número es de un dígito")
        End If
        Console.ReadKey()
    End Sub

End Module
