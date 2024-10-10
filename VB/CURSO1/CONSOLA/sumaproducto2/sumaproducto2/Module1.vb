Module Module1

    Sub Main()
        Dim num1, num2, num3, num4, sum, product As Single

        Console.Write("Ingrese el primer número: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese el segundo número: ")
        num2 = Console.ReadLine()
        Console.Write("Ingrese el tercer número: ")
        num3 = Console.ReadLine()
        Console.Write("Ingrese el cuarto número: ")
        num4 = Console.ReadLine()

        sum = num1 + num2
        product = num3 * num4
        Console.WriteLine("La suma de " & num1 & " y de " & num2 & " es: " & sum)
        Console.WriteLine("El producto de los números " & num3 & " y de " & num4 & " es: " & product)
        Console.ReadKey()

    End Sub

End Module
