Module Module1
    Public Class compara
        Public Function mayor(ByVal lado1 As Integer, lado2 As Integer, lado3 As Integer)
            Dim resultado As Integer
            Console.WriteLine(lado1)
            If (lado1 > lado2 And lado1 > lado3) Then
                resultado = lado1
            Else
                If lado2 > lado3 Then
                    resultado = lado2
                Else
                    resultado = lado3
                End If
            End If

            Return resultado

        End Function
        Public Function menor(ByVal lado1 As Integer, lado2 As Integer, lado3 As Integer)
            Dim resultado As Integer
            If lado1 < lado2 And lado1 < lado3 Then
                resultado = lado1
            ElseIf lado2 < lado3 Then
                resultado = lado2
            Else
                resultado = lado3
            End If
            Return resultado
        End Function
    End Class

    Sub Main()
        Dim chequea As New compara()
        Dim lad1, lad2, lad3, mayor, menor As Integer

        Console.Write("Ingrese el primer lado: ")
        lad1 = console.readline()
        Console.Write("Ingrese el segundo lado: ")
        lad2 = console.readline()
        Console.Write("Ingrese el tercer lado: ")
        lad3 = console.readline()
        mayor = chequea.mayor(lad1, lad2, lad3)
        menor = chequea.menor(lad1, lad2, lad3)
        Console.WriteLine("El lado mayor es: " & mayor)
        Console.WriteLine("El lado menor es: " & menor)

        Console.ReadKey()

    End Sub

End Module
