Module Module1

    Sub Main()
        Dim alumnos, aprobados, suspendidos As Integer
        Dim nota As Single

        For alumnos = 1 To 10
            Console.Write("Ingrese la nota media del alumno: ")
            nota = Console.ReadLine()
            If nota >= 5 And nota <= 10 Then
                Console.WriteLine("Alumno aprobado.")
                aprobados += 1
            ElseIf nota <= 4 And nota >= 0 Then
                Console.WriteLine("Alumnos suspendido.")
                suspendidos += 1
            Else
                Console.WriteLine("Nota incorrecta. vuelva a introducirla")
            End If
        Next
        Console.WriteLine("El número de alumnos aprobados es: " & aprobados)
        Console.WriteLine("El número de alumnos suspendidos es: " & suspendidos)
        Console.WriteLine("Pulsa una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
