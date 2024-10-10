Module Module1
    Public Class Sueldos
        Private sueldos() As Single, auxiliar As Single, contador As Integer


        Public Sub Inicia()
            Console.Write("Ingrese el núero de sueldos: ")
            auxiliar = Console.ReadLine
            ReDim sueldos(auxiliar - 1)
            auxiliar = 0
            For contador = 0 To sueldos.GetUpperBound(0)
                Console.Write("Ingrese el sueldo númlero " & contador & ": ")
                sueldos(contador) = Console.ReadLine()
            Next
        End Sub
        Public Sub Imprimeold()
            For contador = 0 To sueldos.GetUpperBound(0)
                Console.WriteLine("Sueldo número " & contador & ": " & sueldos(contador))
            Next
        End Sub
        Public Sub Ordena()
            For count = 0 To sueldos.GetUpperBound(0)
                For contador = 0 To sueldos.GetUpperBound(0)
                    If contador < sueldos.GetUpperBound(0) Then
                        If sueldos(contador) > sueldos(contador + 1) Then
                            auxiliar = sueldos(contador)
                            sueldos(contador) = sueldos(contador + 1)
                            sueldos(contador + 1) = auxiliar
                        End If
                    End If

                Next
            Next
        End Sub
        Public Sub ImprimeNew()
            Console.WriteLine("La lista de sueldos ordenados es: ")
            Console.WriteLine("==================================")
            For contador = 0 To sueldos.GetUpperBound(0)
                Console.WriteLine("Sueldo número " & contador & ": " & sueldos(contador))
            Next
        End Sub
    End Class
    Sub Main()
        Dim sueldo As New Sueldos
        sueldo.Inicia()
        sueldo.Imprimeold()
        sueldo.Ordena()
        sueldo.ImprimeNew()
        Console.ReadKey()
    End Sub

End Module
