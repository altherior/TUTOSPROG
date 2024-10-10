Module Module1

    Sub Main()
        Dim age1, age2 As Integer
        Dim name1, name2 As String

        Console.Write("Ingrese el nombre de la primera persona: ")
        name1 = Console.ReadLine()
        Console.Write("Ingrese la edad de la primera persona: ")
        age1 = Console.ReadLine()
        Console.Write("Ingrese el nombre de la segunda persona: ")
        name2 = Console.ReadLine()
        Console.Write("Ingrese la edad de la segundaa persona: ")
        age2 = Console.ReadLine()

        If age1 > age2 Then
            Console.WriteLine(name1 & " es mayor que " & name2)
        ElseIf age1 < age2 Then
            Console.WriteLine(name2 & " es mayor que " & name1)
        Else
            Console.WriteLine(name1 & " y " & name2 & " tienen edades identicas")
        End If
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
