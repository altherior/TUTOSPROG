Module Module1
    Public Class Empresa
        Private turnoManana(3) As Single
        Private turnoTarde(3) As Single
        Public Sub Inicia()
            Dim contador As Integer
            For contador = 0 To 3
                Console.WriteLine("Ingrese el sueldo del empleado de mañana número " & contador + 1)
                turnoManana(contador) = Console.ReadLine
                Console.WriteLine("Ingrese el sueldo del empleado de tarde número: " & contador + 1)
                turnoTarde(contador) = Console.ReadLine
            Next
        End Sub
        Public Sub Imprime()
            Dim turno As Boolean
            turno = False
            For contador = 0 To 7
                If turno = False Then
                    Console.WriteLine("El sueldo del empleado de mañana número: " & turnoManana(contador))
                    If contador >= 3 Then
                        turno = True
                    End If
                ElseIf turno = True Then
                    Console.WriteLine("El sueldo del empleado de tarde número: " & turnoTarde(contador - 4))
                End If
            Next
        End Sub
    End Class
    Sub Main()
        Dim emp As New Empresa
        Dim n As String
        Do
            Console.WriteLine("Pulse una tecla para continuar.")
            n = Console.ReadLine()
            emp.Inicia()
            emp.Imprime()
        Loop While n <> "Q" And n <> "q"
    End Sub

End Module
