Module Module1

    Sub Main()
        Dim num As Integer

        num = 1
        Do While num <= 500
            If num Mod 8 = 0 Then
                Console.WriteLine(num)
            End If
            num += 1
        Loop
        Console.ReadKey()
    End Sub

End Module
