Module Module1
    Public Class Altura
        Private estatura(4) As Single, promedia As Single

        Public Sub Media()
            Dim contador As Integer
            For contador = 0 To 4
                Console.Write("Escriba la estatura del individuo: ")
                estatura(contador) = Console.ReadLine()
                promedia = promedia + estatura(contador)
            Next
            promedia = promedia / contador
            Console.WriteLine("La media de los individuos es de: " & promedia)
        End Sub
        Public Sub Checkmedia()
            Dim menor, mayor As Integer
            For contador = 0 To 4
                If estatura(contador) <= promedia Then
                    menor += 1
                Else
                    mayor += 1
                End If
            Next
            Console.WriteLine("Hay " & menor & " menores a la media")
            Console.WriteLine("Hay " & mayor & " mayores a la media")
        End Sub
    End Class
    Sub Main()
        Dim person As New Altura
        person.Media()
        person.Checkmedia()

        Console.ReadKey()
    End Sub

End Module
