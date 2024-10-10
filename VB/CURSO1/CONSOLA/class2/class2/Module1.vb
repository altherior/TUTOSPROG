Module Module1
    Private Class triangulo
        Private lado1, lado2, lado3 As Integer

        Public Sub inicializacion()
            Console.Write("Ingrese el primer lado:  ")
            lado1 = Console.ReadLine()
            Console.Write("Ingrese el segundo lado:  ")
            lado2 = Console.ReadLine()
            Console.Write("Ingrese el tercero lado:  ")
            lado3 = Console.ReadLine()
        End Sub

        Public Sub ladomayor()
            If lado1 > lado2 And lado1 > lado3 Then
                Console.WriteLine("El primer lado es el mayor.")
            ElseIf lado2 > lado3 Then
                Console.WriteLine("El segundo lado es el mayor.")
            ElseIf lado2 <> lado3 Then
                Console.WriteLine("El tercer lado es el mayor.")

            End If
        End Sub
        Public Sub equilatero()
            If lado1 = lado2 Then
                If lado1 = lado3 Then
                    Console.WriteLine("El triangulo es equilatero")
                End If
            End If
        End Sub
    End Class
    Sub Main()
        Dim triang As New triangulo
        triang.inicializacion()
        triang.ladomayor()
        triang.equilatero()
        Console.ReadKey()
    End Sub

End Module
