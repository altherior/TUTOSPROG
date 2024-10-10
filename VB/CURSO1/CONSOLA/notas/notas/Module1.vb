Module Module1
    Public Class Notas
        Private Nombres() As String
        Private Nota() As Single
        Private contador As Integer
        Public Sub Inicia()
            Console.Write("Ingrese el número de alumnos: ")
            contador = Console.ReadLine
            ReDim Nombres(contador - 1)
            ReDim Nota(contador - 1)
            For contador = 0 To Nombres.GetUpperBound(0)
                Console.Write("Ingrese el nombre del alumno" & contador + 1 & ": ")
                Nombres(contador) = Console.ReadLine
                Console.Write("Ingrese la nota del alumno: ")
                Nota(contador) = Console.ReadLine
            Next
        End Sub
        Public Sub Ordena()
            Dim Contador, Contador2 As Integer
            Dim auxnota As Single
            Dim auxnombre As String
            For Contador = 0 To Nota.GetUpperBound(0) - 1
                For Contador2 = 0 To Nota.GetUpperBound(0) - 1
                    If Nota(Contador2) > Nota(Contador + 1) Then
                        auxnota = Nota(Contador)
                        Nota(Contador) = Nota(Contador + 1)
                        Nota(Contador + 1) = auxnota
                        auxnombre = Nombres(Contador)
                        Nombres(Contador) = Nombres(Contador + 1)
                        Nombres(Contador + 1) = auxnombre
                    End If
                Next
            Next
        End Sub
        Public Sub Imprime()
            For contador = 0 To Nombres.GetUpperBound(0)
                Console.WriteLine(Nombres(contador) & " tiene la nota de: " & Nota(contador))
            Next
        End Sub
    End Class
    Sub Main()
        Dim n As New Notas
        n.Inicia()
        n.Ordena()
        n.Imprime()
        Console.ReadKey()

    End Sub

End Module
