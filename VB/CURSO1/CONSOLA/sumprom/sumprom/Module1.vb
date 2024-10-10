Module Module1

    Sub Main()
        Dim contador As Integer
        Dim numero, suma, prom As Single

        For contador = 1 To 10
            Console.Write("Ingrese el número " & contador & " : ")
            numero = Console.ReadLine()
            suma += numero

        Next
        prom = numero / contador
        Console.WriteLine("La suma de los números es: " & suma & " y su promedio: " & prom)
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
