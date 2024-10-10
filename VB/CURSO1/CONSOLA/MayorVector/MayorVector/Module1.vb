Module Module1
    Public Class Vector
        Private nombres() As String
        Private sueldo() As Integer, contador As Integer, super As Integer, pos As Integer

        Public Sub Inicia()
            Console.Write("Ingrese el número de empleados: ")
            contador = Console.ReadLine
            ReDim nombres(contador - 1)
            ReDim sueldo(contador - 1)
            For contador = 0 To nombres.GetUpperBound(0)
                Console.Write("Ingrese el nombre del empleado número " & contador + 1 & ": ")
                nombres(contador) = Console.ReadLine
                Console.Write("Ingrese el sueldo del empleado: ")
                sueldo(contador) = Console.ReadLine
            Next
        End Sub

        Public Sub Mayor()
            For contador = 0 To nombres.GetUpperBound(0)
                If sueldo(contador) > super Then
                    super = sueldo(contador)
                    pos = contador
                End If
            Next
            Console.WriteLine("El empleado con mayor sueldo es " & nombres(pos))
            Console.WriteLine("Tiene un sueldo de " & sueldo(pos))
        End Sub
    End Class
    Sub Main()
        Dim v As New Vector
        v.Inicia()
        v.Mayor()
        Console.ReadKey()
    End Sub

End Module
