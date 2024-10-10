Module Module1
    Public Class Alumnos
        Private Nombres() As String
        Private Edades() As String

        Public Sub Inicia()
            Dim contador As Integer
            Console.WriteLine("Indique el número de alumnos que quiere registrar: ")
            contador = Console.ReadLine()
            ReDim Nombres(contador - 1)
            ReDim Edades(contador - 1)
            For contador = 0 To Nombres.GetUpperBound(0)
                Console.WriteLine("Ingrese el nombre del alumno: ")
                Nombres(contador) = Console.ReadLine()
                Console.WriteLine("Ingrese la edad del alumno: ")
                Edades(contador) = Console.ReadLine()
            Next

        End Sub
        Public Sub Mayores()
            For contador = 0 To Nombres.GetUpperBound(0)
                If Edades(contador) > 18 Then
                    Console.Write(Nombres(contador) & ", es mayor de edad con " & Edades(contador) & " años.")
                End If
            Next
        End Sub
    End Class
    Sub Main()
        Dim pupil As New Alumnos
        pupil.Inicia()
        pupil.Mayores()
        Console.WriteLine(" ")
        Console.WriteLine("Pulse una tecla apra continuar.")
        Console.ReadKey()
    End Sub

End Module