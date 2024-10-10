Imports System

Module Program
    Sub Main()
        Dim horasTrabajadas As Integer
        Dim precioHora As Single
        Dim sueldo As Single

        Console.Write("Ingrese las horas trabajadas por el operario: ")
        horasTrabajadas = Console.ReadLine()
        Console.Write("Introduzca el precio por hora: ")
        precioHora = Console.ReadLine()
        sueldo = horasTrabajadas * precioHora
        Console.Write("El sueldo total a percibir es: ")
        Console.Write(sueldo)
        Console.ReadKey()
    End Sub
End Module
