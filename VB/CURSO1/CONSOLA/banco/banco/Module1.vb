Imports System.Security.Policy

Module Module1

    Sub Main()
        Dim ncuenta As Integer
        Dim saldo As Single

        Do
            Console.WriteLine("Ingrese el número de cuenta: ")
            ncuenta = Console.ReadLine()
            If ncuenta >= 0 Then
                Console.Write("Ingrese el saldo actual: ")
                saldo = Console.ReadLine()
                If saldo = 0 Then
                    Console.WriteLine("El saldo de la cuenta es nulo. Nulo.")
                ElseIf saldo < 0 Then
                    Console.WriteLine("El saldo de la cuenta es negativo. Deudor.")
                ElseIf saldo > 0 Then
                    Console.WriteLine("El sado de la cuenta es positivo. Acreedor.")
                End If
            End If
        Loop While ncuenta >= 0

    End Sub

End Module
