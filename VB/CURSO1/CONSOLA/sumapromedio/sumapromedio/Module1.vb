Module Module1

    Sub Main()
        Dim num1, num2, num3, num4, sum, prom As Single

        Console.Write("Ingrese el primer número: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese el segundo número: ")
        num2 = Console.ReadLine()
        Console.Write("Ingrese el tercero número: ")
        num3 = Console.ReadLine()
        Console.Write("Ingrese el cuarto número: ")
        num4 = Console.ReadLine()

        sum = num1 + num2 + num3 + num4
        prom = sum / 4

        Console.WriteLine("La suma de los cuatro números es: " & sum)
        Console.WriteLine("El promedio de los cuatro números es: " & prom)
        Console.ReadKey()

    End Sub

End Module
