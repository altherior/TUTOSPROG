Module Module1

    Sub Main()
        Dim numero, dato As Integer

        numero = 1
        dato = 11
        Do While numero <= 25
            Console.WriteLine(dato)
            dato += 11
            numero += 1
        Loop
        Console.ReadKey()
    End Sub

End Module
