Module Module1

    Sub Main()
        Dim lado As Integer
        Dim superficie As Integer

        Console.Write("Introduzca la longitud del lado del cuadrado: ")
        lado = Console.ReadLine()
        superficie = lado * lado
        Console.Write("La superficiel del cuadrado es: " & superficie)
        Console.ReadKey()
    End Sub

End Module
