Module Module1

    Sub Main()
        Dim pacientes, numero As Integer
        Dim altura, prom As Single

        Console.Write("Ingrese el número de pacientes en el estudio: ")
        pacientes = Console.ReadLine()
        numero = 1
        Do While numero <= pacientes
            Console.WriteLine("Ingrese la altura del paciente " & numero & " :")
            altura += Console.ReadLine()
            numero += 1
        Loop
        prom = altura / pacientes
        Console.WriteLine("La media de la altura es de: " & prom)
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
