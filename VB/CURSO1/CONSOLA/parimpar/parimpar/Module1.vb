Module Module1

    Sub Main()
        Dim numbers, count, par, impar, resto As Integer

        Console.Write("Ingrese la cantidad de números a evaluar: ")
        numbers = Console.ReadLine()
        count = numbers
        Do While numbers >= 1
            Console.WriteLine("Introduzca el número " & count - (numbers - 1))
            resto = Console.ReadLine() Mod 2
            If resto <> 0 Then
                impar += 1
            Else
                par += 1
            End If
            numbers -= 1
        Loop


        Console.WriteLine("Hay " & par & " números pares")
        Console.WriteLine("Hay " & impar & " números impares")
        Console.WriteLine("Imprima una tecla para continaur")
        Console.ReadKey()
    End Sub

End Module
