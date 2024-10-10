Module Module1

    Sub Main()
        Dim contador, total, cateto1, cateto2, hipotenusa, equilatero, isosceles, escaleno As Integer

        Console.WriteLine("Ingrese el número de triangulos: ")
        total = Console.ReadLine()
        For contador = 1 To total
            Console.WriteLine("Ingrese uno de los catetos:")
            cateto1 = Console.ReadLine()
            Console.WriteLine("Ingrese el otro de los catetos:")
            cateto2 = Console.ReadLine()
            Console.WriteLine("Ingrese la hipotenusa:")
            hipotenusa = Console.ReadLine()
            If cateto1 = cateto2 Then
                If cateto1 = hipotenusa Then
                    equilatero += 1
                    Console.WriteLine("Triangulo equilatero")
                Else
                    isosceles += 1
                    Console.WriteLine("Triangulo isosceles")
                End If
            ElseIf cateto1 = hipotenusa Or cateto2 = hipotenusa Then
                isosceles += 1
                Console.WriteLine("Triangulo isosceles")
            Else
                escaleno += 1
                Console.WriteLine("Trinagulo escaleno")
            End If

        Next
        Console.WriteLine("El número de triangulos equilateros es de : " & equilatero)
        Console.WriteLine("El número de triangulos isosceles es de : " & isosceles)
        Console.WriteLine("El número de triangulos escalenos es de : " & escaleno)
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadLine()
    End Sub

End Module
