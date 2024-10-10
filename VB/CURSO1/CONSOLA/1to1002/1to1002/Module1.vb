Module Module1

    Sub Main()
        Dim contador As Integer

        contador = 0
        For contador = 1 To 100
            Console.WriteLine(contador)
        Next
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
