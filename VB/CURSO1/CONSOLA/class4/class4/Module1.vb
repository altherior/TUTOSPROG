Module Module1
    Public Class cuadrado
        Private lado, superficie, per As Integer

        Public Sub inicializa()
            Console.WriteLine("Introduzca el lado del cuadrado: ")
            lado = Console.ReadLine()

        End Sub
        Public Sub perimetro()
            per = 4 * lado
            Console.WriteLine("El perimetro del cuadrado es: " & per)
        End Sub
        Public Sub area()
            superficie = lado * lado
            Console.WriteLine("La superficie del cuadrado es: " & superficie)
        End Sub
    End Class
    Sub Main()
        Dim cuad As New cuadrado
        cuad.inicializa()
        cuad.perimetro()
        cuad.area()
        Console.ReadKey()
    End Sub

End Module
