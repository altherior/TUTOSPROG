Module Module1

    Sub Main()
        Dim contador, numero, multiplo, resultado As Integer


        Do
            Console.WriteLine("Indtroduzca un número del 1 al 10")
            numero = Console.ReadLine()
        Loop While numero < 1 Or numero >= 10
        For multiplo = 1 To 12
            resultado = numero * multiplo
            Console.WriteLine(numero & " * " & multiplo & " = " & resultado)
        Next

        Console.WriteLine("Presione una tecla para continuar")
        Console.ReadKey()
    End Sub

End Module
