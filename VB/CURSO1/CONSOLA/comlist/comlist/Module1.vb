Module Module1

    Sub Main()
        Dim number, count, total As Integer

        number = 0
        count = 1
        Console.WriteLine("Lista 1")
        Do While count <= 15
            Console.Write("Ingrese el valor " & count & " : ")
            number += Console.ReadLine()
            count += 1
        Loop

        total = number

        number = 0
        count = 1
        Console.WriteLine("Lista 2")
        Do While count <= 15
            Console.Write("Ingrese el valor " & count & " : ")
            number += Console.ReadLine()
            count += 1
        Loop

        If total > number Then
            Console.WriteLine("lista 1 mayor")
        ElseIf total < number Then
            Console.WriteLine("lista 2 mayor")
        Else
            Console.WriteLine("Listas Iguales")
        End If
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
