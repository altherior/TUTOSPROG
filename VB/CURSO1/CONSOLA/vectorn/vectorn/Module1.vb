Module Module1
    Public Class Sueldos
        Private Pagos() As Single, Inversion As Single
        Private i As Integer
        Public Sub Inicia()
            Dim n As Integer
            Console.WriteLine("Ingrese el número de sueldos: ")
            n = Console.ReadLine()
            ReDim Pagos(n - 1)
            For i = 0 To Pagos.GetUpperBound(0)
                Console.WriteLine("Escriba el sueldo del empleado " & i + 1)
                Pagos(i) = Console.ReadLine
            Next
        End Sub
        Public Sub Total()
            For i = 0 To Pagos.GetUpperBound(0)
                Inversion = Inversion + Pagos(i)
            Next
            Console.WriteLine("La inversión total de la empresa es de " & Inversion & ".")
        End Sub
    End Class
    Sub Main()
        Dim v As New Sueldos
        v.Inicia()
        v.Total()
        Console.ReadKey()
    End Sub

End Module
