Module Module1

    Sub Main()
        Dim valor As Integer

        Do
            Console.WriteLine("Ingrese el número (0 para salir)")
            valor = Console.ReadLine()
            If valor <> 9999 Then
                If valor = 0 Then
                    Console.WriteLine("El valor es neutro")
                ElseIf valor > 0 Then
                    Console.WriteLine("El valor es positivo")
                Else
                    Console.WriteLine("El valor es negativo")
                End If
            End If
        Loop While valor <> 9999

    End Sub

End Module
