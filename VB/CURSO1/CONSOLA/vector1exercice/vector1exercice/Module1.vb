Module Module1
    Public Class vector
        Private contador As Integer, valor(7) As Integer, mayor As Integer

        Public Sub inicia()
            For contador = 0 To 7
                Console.Write("Ingrese el valor del vector " & contador + 1 & " : ")
                valor(contador) = Console.ReadLine
            Next
        End Sub
        Public Sub Acumula()
            For contador = 0 To 7
                If valor(contador) > 36 Then
                    mayor = mayor + valor(contador)
                End If
            Next
            Console.WriteLine("El valor total de los vecotores de más de 36 es: " & mayor)
        End Sub
        Public Sub How()
            Dim more50 As Integer
            For contador = 0 To 7
                If valor(contador) > 50 Then
                    more50 += 1
                End If
            Next
            Console.WriteLine("El número de vectores mayores de 50 son: " & more50)
        End Sub
        Public Sub Total()
            Dim all As Integer
            For contador = 0 To 7
                all = all + valor(contador)
            Next
            Console.WriteLine("El valor total de vectores es de: " & all)
        End Sub
    End Class
    Sub Main()
        Dim vec As New vector
        Dim key As String
        Do
            vec.inicia()
            vec.Acumula()
            vec.How()
            vec.Total()
            Console.WriteLine("Pulse una tecla para continuar")
            key = Console.ReadLine()
        Loop While key = "Q" And key = "q"
    End Sub

End Module
