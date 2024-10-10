Module Module1
    Public Class Dados
        Private valor As Integer
        Private Shared aleatorio As Random

        Public Sub New()
            aleatorio = New Random()
        End Sub
        Public Sub Tirar()
            valor = aleatorio.Next(1, 7)
        End Sub
        Public Sub Imprimir()
            Console.WriteLine("El valor del dado es: " & valor & ".")
        End Sub
        Public Function Retornavalor()
            Return valor
        End Function
    End Class
    Public Class Juega
        Private dado1, dado2, dado3 As Dados

        Public Sub New()
            dado1 = New Dados()
            dado2 = New Dados()
            dado3 = New Dados()

        End Sub
        Public Sub Tirada()
            dado1.Tirar()
            dado1.Imprimir()
            dado2.Tirar()
            dado2.Imprimir()
            dado3.Tirar()
            dado3.Imprimir()
            If dado1.Retornavalor = dado2.Retornavalor And dado1.Retornavalor = dado3.Retornavalor Then

                Console.BackgroundColor = ConsoleColor.Blue
                Console.ForegroundColor = ConsoleColor.Yellow
                REM Console.Clear()
                Console.WriteLine("El jugador ha ganado")
            Else

                Console.BackgroundColor = ConsoleColor.Blue
                Console.ForegroundColor = ConsoleColor.Yellow
                REM Console.Clear()
                Console.WriteLine("El jugador ha perdido")
            End If
        End Sub
    End Class

    Public Class Lanzamiento

    End Class
    Sub Main()
        Dim die As New Juega()
        die.Tirada()
        Console.ReadKey()

    End Sub

End Module
