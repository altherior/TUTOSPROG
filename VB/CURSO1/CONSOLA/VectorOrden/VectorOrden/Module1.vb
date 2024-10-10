Module Module1
    Public Class Vector
        Private vec1(9) As Integer, contador As Integer
        Public Sub Inicia()
            For contador = 0 To 9
                Console.WriteLine("Ingrese el valor del " & contador + 1 & "º elemnto del vector:")
                vec1(contador) = Console.ReadLine()
            Next
        End Sub
        Public Sub Orden()
            Dim orden As Integer
            For contador = 0 To 8
                If vec1(contador + 1) > vec1(contador) Then
                    orden = 0
                End If
            Next
            If orden = 0 Then
                Console.WriteLine("Esta ordenador de menor a mayor.")
            Else
                Console.WriteLine("Esta ordenado de mayor a menor.")
            End If
        End Sub
    End Class
    Sub Main()
        Dim v As New Vector
        v.Inicia()
        v.Orden()
        Console.ReadKey()
    End Sub

End Module
