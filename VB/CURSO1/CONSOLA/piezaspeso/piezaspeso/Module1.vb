Module Module1

    Sub Main()
        Dim peso As Single
        Dim max, med, min As Integer

        Do
            Console.Write("Ingrese el peso de la pieza (0 para finalizar): ")
            peso = Console.ReadLine()
            If peso <> 0 Then
                If peso > 10.2 Then
                    max += 1
                ElseIf peso <= 10.2 And peso > 9.8 Then
                    med += 1
                Else
                    min += 1
                End If
            End If
        Loop While (peso <> 0)
        Console.WriteLine("El número de piezas mayores de 10,2 Kg es de : " & max)
        Console.WriteLine("El número de piezas mayores de 9,8 Kg es de : " & med)
        Console.WriteLine("El número de piezas menores de 9,8 Kg es de : " & min)
        Console.WriteLine("Presione una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
