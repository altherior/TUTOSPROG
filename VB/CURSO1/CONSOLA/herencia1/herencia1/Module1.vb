Imports System.CodeDom

Module Module1
    Public Class Operacion

        Protected _valor1, _valor2, _resultado As Integer


        Public Property valor1()
            Get
                Return _valor1
            End Get
            Set
                _valor1 = Value
            End Set
        End Property
        Public Property valor2
            Get
                Return _valor2
            End Get
            Set
                _valor2 = Value
            End Set
        End Property
        Public Property resultado()
            Get
                Return _resultado
            End Get
            Set
                _resultado = Value

            End Set
        End Property
    End Class

    Public Class Suma
        Inherits Operacion
        Public Sub Operar()
            resultado = valor1 + valor2
        End Sub
    End Class

    Public Class Resta
        Inherits Operacion
        Public Sub Operar()
            resultado = valor1 - valor2
        End Sub
    End Class
    Sub Main()
        Dim sum As New Suma()
        Dim res As New Resta()
        Console.Write("Ingrese el primer número a sumar: ")
        sum.valor1 = Console.ReadLine
        Console.Write("Ingrese el segundo número a sumar: ")
        sum.valor2 = Console.ReadLine
        Console.Write("Ingrese el primer número a restar: ")
        res.valor1 = Console.ReadLine
        Console.Write("Ingrese el segundo número a restar: ")
        res.valor2 = Console.ReadLine
        sum.Operar()
        res.Operar()
        Console.WriteLine("La suma es: " & sum.resultado)
        Console.WriteLine("La resta es: " & res.resultado)
        Console.ReadKey()
    End Sub

End Module
