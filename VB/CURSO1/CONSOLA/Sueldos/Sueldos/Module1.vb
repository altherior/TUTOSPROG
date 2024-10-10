Imports System.Collections.Specialized

Module Module1
    Public Class Sueldo
        Private contador As Integer, pagos() As Integer

        Public Sub Inicia()
            Dim i As Integer
            Console.WriteLine("Ingrese el número de sueldos a almacenar: ")
            contador = Console.ReadLine()
            ReDim pagos(contador - 1)
            For i = 0 To pagos.GetUpperBound(0)
                Console.WriteLine("Ingrese el sueldo para el empleado " & i + 1 & " :")
                pagos(i) = Console.ReadLine()
            Next
        End Sub
        Public Sub Imprime()
            Dim i As Integer
            For i = 0 To pagos.GetUpperBound(0)
                Console.WriteLine(pagos(i))
            Next
        End Sub
    End Class
    Sub Main()
        Dim v As New Sueldo
        v.Inicia()
        v.Imprime()

        Console.ReadKey()
    End Sub

End Module
