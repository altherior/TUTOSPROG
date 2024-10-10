Module Module1

    Sub Main()
        Dim positivo, negativo, multiplo, numero, pares, count As Integer
        Console.BackgroundColor = ConsoleColor.Blue
        Console.ForegroundColor = ConsoleColor.White
        Console.Clear()

        For count = 1 To 10
            Console.WriteLine("Ingrese el número: ")
            numero = Console.ReadLine()
            If numero > 0 Then
                positivo += 1
            ElseIf numero < 0 Then
                negativo += 1
            End If
            If numero Mod 15 = 0 Then
                multiplo += 1
            End If
            If numero Mod 2 = 0 Then
                pares += 1
            End If
        Next
        Console.WriteLine("la cantidad de positivos es:" & positivo)
        Console.WriteLine("la cantidad de negativos es: " & negativo)
        Console.WriteLine("La cantidad de pares es: " & pares)
        Console.WriteLine("la cantidad de multiplos de 15: " & multiplo)
        Console.WriteLine("Pulse una tecla para continuar")
        Console.ReadKey()
    End Sub

End Module
