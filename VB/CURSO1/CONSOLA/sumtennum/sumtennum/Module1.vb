Module Module1

    Sub Main()
        Dim number, count As Integer
        count = 1
        number = 0
        Do While count <= 10
            Console.WriteLine("Ingrese el numéro " & count & " : ")
            number = number + Console.ReadLine()
            count += 1
        Loop
        Console.WriteLine("La suma de los diez númeroe es: " & number)
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
