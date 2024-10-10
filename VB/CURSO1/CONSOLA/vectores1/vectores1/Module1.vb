Module Module1
    Public Class Sueldo
        Private bruto(4) As Single

        Public Sub Inicializa()
            Dim contador As Integer
            For contador = 0 To 4
                Console.Write("Ingrese el sueldo: ")
                bruto(contador) = Console.ReadLine()
            Next
        End Sub
        Public Sub Imprime()
            Dim contador As Integer
            Dim neto As Single
            For contador = 0 To 4
                neto = bruto(contador) / 1.2
                Console.WriteLine("El sueldo neto es de: " & neto)
            Next
        End Sub

    End Class
    Sub Main()
        Dim salario As New Sueldo()
        Dim n As Char
        Do
            Console.WriteLine("Pulse una tecla para continuar.")
            n = Console.ReadLine
            If n <> "Q" And n <> "q" Then
                salario.Inicializa()
                salario.Imprime()
            End If
        Loop Until n = "Q" And n = "q"


    End Sub

End Module
