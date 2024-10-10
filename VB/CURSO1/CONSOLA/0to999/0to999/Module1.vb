Module Module1

    Sub Main()
        Dim numero As Integer

        Do
            Console.WriteLine("Ingrese el número: ")
            numero = Console.ReadLine()
            If numero >= 100 Then
                Console.WriteLine("El número tiene tres cifras.")
            ElseIf numero >= 10 And numero < 100 Then
                Console.WriteLine("El número tiene dos cifras.")
            ElseIf numero > 0 Then
                Console.WriteLine("El número tiene 1 única cifra.")
            End If
        Loop While (numero <> 0)
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
