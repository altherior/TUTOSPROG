Module Module1
    Public Class tabla
        Private i As Integer
        Public Sub multiplica(ByVal numero As Integer)
            For i = 1 To 10
                Console.WriteLine(i & " * " & numero & " = " & (i * numero))
            Next
        End Sub
    End Class

    Sub Main()
        Dim n As Char
        Dim num As Integer
        Dim table As New tabla

        Do
            Console.WriteLine("Pulse una tecla para inciar. Q para salir")
            n = Console.ReadLine()
            If (n <> "Q" And n <> "q") Then
                Console.WriteLine("Ingrese el número: ")
                num = Console.ReadLine()
                table.multiplica(num)

            End If
        Loop While (n <> "Q" And n <> "q")
    End Sub

End Module
