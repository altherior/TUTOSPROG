Module Module1
    Public Class vector
        Private Contador As Integer, vector1(3) As Integer, vector2(3) As Integer, vector3(3) As Integer

        Public Sub Inicia()
            For Contador = 0 To 3
                Console.WriteLine("Ingrese el valor del vector " & Contador + 1 & " del grupo 1: ")
                vector1(Contador) = Console.ReadLine()
            Next
            For Contador = 0 To 3
                Console.WriteLine("Ingrese el valor del vector " & Contador + 1 & " del grupo 2: ")
                vector2(Contador) = Console.ReadLine()
            Next
        End Sub
        Public Sub Suma()
            For Contador = 0 To 3
                vector3(Contador) = vector1(Contador) + vector2(Contador)
                Console.WriteLine("La suma del elemento " & Contador + 1 & " de ambos vectores es " & vector3(Contador))
            Next
        End Sub
    End Class
    Sub Main()
        Dim v As New vector
        Dim key As String
        Do
            v.Inicia()
            v.Suma()
            Console.WriteLine("Pulse una tecla para continuar.")
            key = Console.ReadLine()
        Loop While key = "Q" And key = "q"
    End Sub

End Module
