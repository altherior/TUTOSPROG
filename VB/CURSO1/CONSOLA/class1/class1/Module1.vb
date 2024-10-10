Module Module1
    Public Class persona
        Private name As String
        Private age As Integer
        Public Sub Inicializar()
            Console.Write("Ingese el nombre del usuario: ")
            name = Console.ReadLine()
            Console.Write("Ingrese la edad del usuario: ")
            age = Console.ReadLine()
        End Sub

        Public Sub Imprimir()
            Console.WriteLine("El nombre del usuario es: " & name)
            Console.WriteLine("La edad del usuario es: " & age)
        End Sub

        Public Sub Mayoredad()
            If age >= 18 Then
                Console.WriteLine("El usuario es mayor de edad y puede votar.")
            Else
                Console.WriteLine("El usuario es menor de edad.")
            End If
            Console.ReadKey()
        End Sub

    End Class
    Sub Main()
        Dim person As persona
        person = New persona()
        person.Inicializar()
        person.Imprimir()
        person.Mayoredad()

    End Sub

End Module
