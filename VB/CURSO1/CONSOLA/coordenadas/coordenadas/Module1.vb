Module Module1

    Sub Main()
        Dim x, y, numero, contador, cuadrante As Integer

        Console.WriteLine("Ingrese el número de puntos a evaluar: ")
        numero = Console.ReadLine()

        For contador = 1 To numero
            Console.Write("Ingrese la coordenada x: ")
            x = Console.ReadLine()
            Console.Write("Ingrese la coordenada y: ")
            y = Console.ReadLine()
            If x > 0 Then
                If y > 0 Then
                    Console.WriteLine("Punto ingresado en el primer cuadrante.")
                Else
                    Console.WriteLine("Punto ingresado en el segundo cuadrante.")
                End If
            ElseIf y < 0 Then
                Console.WriteLine("Punto ingresado en el tercer cuadrantee.")
            ElseIf y > 0 Then
                Console.WriteLine("Punto ingresado en el cuatro cuadrante")
            End If
            If x = 0 And y = 0 Then
                Console.WriteLine("Punto ingresado en el origien.")
            End If
        Next
        Console.WriteLine("Pulse una tecla apra continuar.")
        Console.ReadKey()
    End Sub

End Module
