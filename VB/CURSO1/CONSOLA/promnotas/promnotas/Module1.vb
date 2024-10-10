Module Module1

    Sub Main()
        Dim idiom, maths, history, prom As Single

        Console.Write("Ingrese la nota de lenguaje: ")
        idiom = Console.ReadLine()
        Console.Write("Ingrese la nota de matemáticas: ")
        maths = Console.ReadLine()
        Console.Write("Introduzca la nota de historia: ")
        history = Console.ReadLine()

        prom = (idiom + maths + history) / 3

        If prom > 7 Then
            Console.WriteLine("El alumno promociona al siguiente curso")
        Else
            Console.WriteLine("El alumno se ve obligado a repetir curso")
        End If
        Console.ReadKey()

    End Sub

End Module
