Module Module1
    Public Class Matriz
        Private mat(3, 4) As Integer
        Public Sub Inicia()
            Dim f, c As Integer
            For f = 0 To 2
                For c = 0 To 3
                    Console.WriteLine("ingrese el valor del elemento de la matriz:")
                    mat(f, c) = Console.ReadLine()
                Next
            Next
        End Sub
        Public Sub Imprime()
            Dim f, c As Integer
            For f = 0 To 2
                For c = 0 To 3
                    Console.Write(mat(f, c))
                    Console.Write("-")
                Next
                Console.WriteLine(" ")
            Next
        End Sub
    End Class
    Sub Main()
        Dim m As New Matriz
        m.Inicia()
        m.Imprime()
        Console.ReadKey()
    End Sub

End Module
