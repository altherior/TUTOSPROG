Module Module1

    Sub Main()
        Dim count, data, number, positive As Integer

        Do
            Console.Write("Ingrese el número de valores a evaluar: ")
            data = Console.ReadLine()
            If data <> 0 Then
                For count = 1 To data
                    Console.WriteLine("Escriba el número a evaluar: ")
                    number = Console.ReadLine()
                    If number <= 1000 Then
                        positive += 1
                    End If
                Next
                Console.WriteLine("Hay " & positive & " números mayores o iguales a 1000")
            End If
        Loop While data <> 0

    End Sub

End Module
