Module Module1
    Public Class punto
        Private x, y As Integer

        Public Sub inicializa()
            Console.Write("Ingrese la coordenada x del punto: ")
            x = Console.ReadLine
            Console.Write("Ingrese la coordenada y del punto: ")
            y = Console.ReadLine()
        End Sub

        Public Sub cuadrante()
            If x > 0 And y > 0 Then
                Console.WriteLine("El punto está en el primer cuadrante.")
            ElseIf x > 0 And y < 0 Then
                Console.WriteLine("El punto está en el segundo cuadrante.")
            ElseIf x < 0 And y > 0 Then
                Console.WriteLine("El punto está en el  tercer cuadrante.")
            Else
                Console.WriteLine("El punto está en el cuarto cuadrante.")
            End If
        End Sub
    End Class
    Sub Main()
        Dim point = New punto
        point.inicializa()
        point.cuadrante()
        Console.ReadKey()
    End Sub

End Module
