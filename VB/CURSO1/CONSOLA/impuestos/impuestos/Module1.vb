Module Module1

    Sub Main()
        Dim sueldo As Single
        Console.Write("Ingrese el sueldo del trabajador :")
        sueldo = Console.ReadLine()
        If sueldo > 1080 Then
            Console.Write("Esta persona debe de declarar impuestos")
        End If
        Console.ReadKey()

    End Sub

End Module
