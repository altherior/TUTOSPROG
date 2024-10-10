Module Module1

    Sub Main()
        Dim piezas, cantidad As Integer
        Dim longx, longy As Single

        Console.Write("Introduzca el número de piezas a fabricar: ")
        piezas = Console.ReadLine()
        Do While piezas > 0
            Console.WriteLine("Introduzca las medidas de la pieza " & piezas)
            piezas -= 1
            Console.Write("Introduzca el ancho: ")
            longx = Console.ReadLine()
            Console.Write("Introduzca el largo: ")
            longy = Console.ReadLine()
            If (longx <= 1.2) And (longy <= 1.3) Then
                cantidad += 1
            End If
        Loop
        Console.WriteLine("El número de piezas viable es de: " & cantidad)
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadLine()
    End Sub

End Module
