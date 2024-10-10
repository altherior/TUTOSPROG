Module Module1
    Public Class Empleados
        Private nombre() As String
        Private sueldo() As Integer, contador As Integer

        Public Sub Inicia()
            Console.Write("Ingrese el númeero de empleados de la empresa: ")
            contador = Console.ReadLine
            ReDim nombre(contador - 1)
            ReDim sueldo(contador - 1)
            For contador = 0 To nombre.GetUpperBound(0)
                Console.WriteLine("Ingrese el nombre del empleado: ")
                nombre(contador) = Console.ReadLine
                Console.WriteLine("Ingrese el sueldo del empleado: ")
                sueldo(contador) = Console.ReadLine()
            Next
        End Sub
        Public Sub Mayor()
            For contador = 0 To nombre.GetUpperBound(0)
                If sueldo(contador) > 3500 Then
                    Console.WriteLine("El empleado " & nombre(contador) & " tiene un sueldo superoior a 3500€.")
                End If
            Next
        End Sub
        Public Sub Menor()
            For contador = 0 To nombre.GetUpperBound(0)
                If sueldo(contador) < 2500 Then
                    Console.WriteLine("El empleado " & nombre(contador) & " tiene un sueldo inferior a 2500€.")
                End If
            Next
        End Sub
        Public Sub Gastos()
            Dim total As Integer
            For contador = 0 To nombre.GetUpperBound(0)
                total = total + sueldo(contador)
            Next
            Console.WriteLine("La inversión total de la empresa es de : " & total & "€")
        End Sub
    End Class
    Sub Main()
        Dim employ As New Empleados

        employ.Inicia()
        employ.Mayor()
        employ.Menor()
        employ.Gastos()
        Console.ReadKey()
    End Sub

End Module
