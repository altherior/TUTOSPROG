Module Module1

    Sub Main()
        Dim idiom, maths, history, prom As Single

        Console.Write("Introduzca la nota de lenguaje: ")
        idiom = Console.ReadLine()
        Console.Write("Introduzca la nota de matemáticas: ")
        maths = Console.ReadLine()
        Console.Write("Introduzca la nota de historia: ")
        history = Console.ReadLine()

        prom = (idiom + maths + history) / 3
        If prom >= 7 Then
            Console.WriteLine("El alumno es promocionado")
        ElseIf prom < 7 And prom >= 4 Then
            Console.WriteLine("El alumno es promocionado pero lo ha hecho regular y debe repasar")
        Else
            Console.WriteLine("El alumno no promociona. Debe repetir curso")
        End If
        Console.ReadKey()

    End Sub

End Module
