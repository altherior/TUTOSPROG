Module Module1
    Public Class Dado
        Private _valor As Integer

        Public Property valor() As Integer
            Get
                Return _valor
            End Get

            Private Set(value As Integer)
                _valor = value
            End Set
        End Property

        Public Shared aleatorio As Random
        Public Sub New()
            aleatorio = New Random()
        End Sub
        Public Sub Tirada()
            valor = aleatorio.Next(1, 7)
        End Sub
        Public Sub Imprime()
            Console.WriteLine("La tirada es de : " & valor)
        End Sub

    End Class
    Sub Main()
        Dim dice1, dice2, dice3 As New Dado
        Dim i As Integer
        dice1.Tirada()
        dice1.Imprime()
        dice2.Tirada()
        dice2.Imprime()
        dice3.Tirada()
        dice3.Imprime()
        For i = 0 To 2
            Console.WriteLine()
        Next
        If dice1.valor > dice2.valor And dice1.valor > dice3.valor Then
            Console.WriteLine("El valor ganador es la tirada 1 con " & dice1.valor)
        ElseIf dice2.valor > dice3.valor Then
            Console.WriteLine("El valor ganador es la tirada 2 con " & dice2.valor)
        Else
            Console.WriteLine("El valor ganador es la tirada 3 con " & dice3.valor)
        End If
        Console.ReadKey()

    End Sub

End Module
