Module Module1

    Sub Main()
        Dim alumnos, aprobados, suspendidos As Integer
        Dim notas As Single

        alumnos = 10
        aprobados = 0
        suspendidos = 0
        Do While alumnos >= 1
            Console.WriteLine("Ingrese la nota del siguiente alumno: ")
            notas = Console.ReadLine()
            If notas >= 7 Then
                aprobados += 1
            Else
                suspendidos += 1
            End If
            alumnos -= 1
        Loop
        Console.WriteLine("Han aprobado " & aprobados & " alumnos")
        Console.WriteLine("Han suspendido " & suspendidos & " alumnos")
        Console.WriteLine("Pulse una tecla para continuar")
        Console.ReadKey()

    End Sub

End Module
