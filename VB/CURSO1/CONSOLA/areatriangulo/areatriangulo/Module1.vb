Module Module1

    Sub Main()
        Dim base, altura, contador, cantidad, area As Integer

        Do
            Console.Write("Ingrese el núemro de triangulos que desee evaluar: ")
            contador = Console.ReadLine()
            For i = 1 To contador
                If contador <> 0 Then
                    Console.Write("Ingrese la altura del triangulo:")
                    altura = Console.ReadLine()
                    Console.Write("Ingrese la base del traiangulo: ")
                    base = Console.ReadLine()
                    area = ((base * altura) / 2)
                    If area >= 12 Then
                        cantidad += 1
                    End If
                    Console.WriteLine("La base, altura y superficie del triangulo son: " & base & " " & altura & " " & area)
                End If
            Next
            Console.WriteLine("Hay " & cantidad & " triangulos con superficie mayor o igual a 12")
        Loop While contador <> 0

    End Sub

End Module
