Imports System.Linq.Expressions
Imports System.Xml.Schema

Module Module1

    Sub Main()
        Dim sueldo, employs, mayor, medio, total As Integer

        Do While employs <= 0
            Console.Write("Ingrese el número de empleados de la empresa: ")
            employs = Console.ReadLine()
        Loop

        Do While employs >= 1
            sueldo = 0
            Do While sueldo > 500 Or sueldo < 100
                Console.WriteLine("Ingrese el sueldo del empleado nº: " & employs)
                sueldo = Console.ReadLine()
            Loop
            employs -= 1
            If sueldo > 300 Then
                mayor += 1
            Else
                medio += 1
            End If
            total += sueldo
        Loop
        Console.WriteLine("El número de empleados superior a  $300 es: " & mayor)
        Console.WriteLine("El número de empleaaso con sueldo entre $100 y $300 es: " & medio)
        Console.WriteLine("La empresa ha de invertir $" & total & " dolares en sueldos.")
        Console.WriteLine("Presione una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
