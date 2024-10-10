Module Module1

    Sub Main()
        Dim count, num, mult3, mult5 As Integer

        mult3 = 0
        mult5 = 0
        num = 0
        For count = 1 To 10
            Console.Write("Intrese el número a comprobar: ")
            num = Console.ReadLine()
            If num Mod 3 = 0 Then
                mult3 += 1
                If num Mod 5 = 0 Then
                    mult5 += 1
                    Console.WriteLine("El número es multiplo de 3 y 5 al mismo tiempo.")
                Else
                    Console.WriteLine("El núemro es multiplo de 3")

                End If
            ElseIf num Mod 5 = 0 Then
                mult5 += 1
                Console.WriteLine("El número es multimplo de 5")
            End If
        Next
        Console.WriteLine("Hay " & mult3 & " números multiplos de 3")
        Console.WriteLine("Hay " & mult5 & " números multiplos de 5")
        Console.WriteLine("Pulsa una tecla para continuar")
        Console.ReadKey()
    End Sub

End Module
