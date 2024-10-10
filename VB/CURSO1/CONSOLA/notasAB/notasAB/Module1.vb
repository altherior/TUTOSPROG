Module Module1
    Public Class Curso
        Private cursoA(4) As Single, cursoB(4), promA, promB As Single
        Private contador As Integer

        Public Sub Inicia()
            For contador = 0 To 4
                Console.Write("Ingrese la nota del " & contador + 1 & "º alumno del grupo A: ")
                cursoA(contador) = Console.ReadLine
            Next
            For contador = 0 To 4
                Console.Write("Ingrese la nota del " & contador + 1 & "º alumno del grupo B: ")
                cursoB(contador) = Console.ReadLine
            Next
        End Sub
        Public Sub prom()
            For contador = 0 To 4
                promA = promA + cursoA(contador)
                promB = promB + cursoB(contador)
            Next
            promA = promA / 4
            promB = promB / 4
            If promA > promB Then
                Console.WriteLine("El curso que mayor promedio ha tenido ha sido el Grupo A con: " & promA)
            ElseIf promB > promA Then
                Console.WriteLine("El curso que mayor promedio ha tenido ha sido el Grupo B con: " & promB)
            End If
        End Sub
    End Class
    Sub Main()
        Dim clase As New Curso
        Dim key As String
        Do
            clase.Inicia()
            clase.prom()
            Console.WriteLine("Pulse una tecla para continuar.")
            key = Console.ReadLine
        Loop While key <> "Q" And key <> "q"
    End Sub

End Module
