Module Module1

    Sub Main()
        Dim nombre1, nombre2 As String

        Console.Write("Ingrese el primer nombre: ")
        nombre1 = Console.ReadLine()
        Console.Write("Ingrese el segundo nombre: ")
        nombre2 = Console.ReadLine()

        If nombre1 = nombre2 Then
            Console.WriteLine("Los nombres son iguales.")
        Else
            Console.WriteLine("Los nombres son diferentes.")
        End If
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
