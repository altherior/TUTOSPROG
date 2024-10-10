Module Module1

    Sub Main()
        Dim num1, num2, sum, product As Single

        Console.Write("Introduzca el primer número: ")
        num1 = Console.ReadLine()
        Console.Write("Introduzca el segundo número: ")
        num2 = Console.ReadLine()
        sum = num1 + num2
        product = num1 * num2
        Console.WriteLine("La suma de los dos números es: " & sum & " y el producto de los números es: " & product)
        Console.ReadKey()
    End Sub

End Module
