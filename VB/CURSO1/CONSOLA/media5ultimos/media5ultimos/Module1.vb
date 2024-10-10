Module Module1

    Sub Main()
        Dim number, contador As Integer
        Dim media As Single
        For contador = 1 To 10
            Console.WriteLine("Ingrese el número:")
            number = Console.ReadLine()
            If contador >= 6 Then
                media = media + number
            End If
        Next
        media = media / 5
        Console.WriteLine("La media de los últimos cinco numeros es: " & media)
        Console.ReadKey()
    End Sub

End Module
