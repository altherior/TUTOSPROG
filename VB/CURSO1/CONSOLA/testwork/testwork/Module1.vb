Module Module1

    Sub Main()
        Dim questions, answers, perc As Integer

        Console.Write("Ingrese el núermo de preguntas: ")
        questions = Console.ReadLine()
        Console.Write("Ingrese el número de respuestas: ")
        answers = Console.ReadLine()

        perc = (answers * 100) / questions
        If perc >= 90 Then
            Console.Write("Nivel superior porcentaje 90% o superior")
        ElseIf perc >= 75 And perc < 90 Then
            Console.Write("Nivel medio porcentaje entre 75% y 90%")
        ElseIf perc >= 50 And perc < 75 Then
            Console.Write("Nivel inferior porcentaje entre 50% y 75%")
        Else
            Console.Write("Fuera de nivel, porcentaje inferior al 50%")
        End If
        Console.ReadKey()
    End Sub

End Module
