Module Module1

    Sub Main()
        Dim resultado, contador As Integer

        For contador = 1 To 10
            resultado = 5 * contador
            Console.WriteLine(" 5 x " & contador & " = " & resultado)
            resultado = 0
        Next
        Console.WriteLine("Presione una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
