Module Module1

    Sub Main()
        Dim num1, num2, sum, dif, product, div, rest As Integer

        Console.Write("Ingrese el primer número: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese el segundo número: ")
        num2 = Console.ReadLine()

        sum = num1 + num2
        dif = num1 - num2
        product = num1 * num2
        div = num1 / num2
        rest = num1 Mod num2

        If num1 > num2 Then
            Console.WriteLine("La suma es: " & sum)
            Console.WriteLine("La diferencia es: " & dif)
        Else
            Console.WriteLine("El producto es: " & product)
            Console.WriteLine("La division es: " & div)
            Console.WriteLine("El resto de su división es: " & rest)
        End If
        Console.ReadKey()
    End Sub

End Module
