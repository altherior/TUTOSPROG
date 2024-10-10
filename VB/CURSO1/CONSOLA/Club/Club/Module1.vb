

Module Module1
    Public Class Socio
        Private Nombre As String
        Private Antiguedad As Integer
        Public Sub New()
            Console.Clear()
            Console.WriteLine("Escriba el nombre del socio: ")
            Nombre = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Escriba la antiguedadd del socio en años: ")
            Antiguedad = Console.ReadLine()
        End Sub
        Public Sub Imprimir()
            Console.WriteLine("El socio más antiguo es: " & Nombre)
        End Sub
        Public Function RetornarAntiguedad()
            Return Antiguedad
        End Function
    End Class

    Public Class Club
        Private socio1, socio2, socio3 As Socio
        Public Sub New()
            socio1 = New Socio()
            socio2 = New Socio()
            socio3 = New Socio()
        End Sub
        Public Sub MayorAntiguedadd()
            If socio1.RetornarAntiguedad > socio2.RetornarAntiguedad And socio1.RetornarAntiguedad > socio3.RetornarAntiguedad Then
                socio1.Imprimir()
            ElseIf socio2.RetornarAntiguedad > socio3.RetornarAntiguedad Then
                socio2.Imprimir()
            Else
                socio3.Imprimir()
            End If
        End Sub
    End Class
    Sub Main()
        Dim c As New Club()
        c.MayorAntiguedadd()
        Console.ReadKey()

    End Sub

End Module
