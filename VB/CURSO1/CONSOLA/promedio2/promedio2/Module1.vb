Module Module1

    Sub Main()
        Dim numero, valor, contador As Integer
        Dim prom As Single
        numero = 0
        contador = 0
        valor = 0

        Do
            Console.WriteLine("Escriba un número:")
            valor = Console.ReadLine()
            If valor <> 0 Then
                numero = numero + valor
                contador += 1
            End If
        Loop While (valor <> 0)
        prom = numero / contador
        Console.WriteLine("El promerio es: ")
        Console.WriteLine(prom)
        Console.WriteLine("Pulse una tecla para contirnuar.")
        Console.ReadKey()
    End Sub

End Module
