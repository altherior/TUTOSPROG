Module Module1
    Public Class Articulos
        Private nombre() As String
        Private contador As Integer
        Private precio() As Single, corte As Single
        Public Sub Inicia()
            Console.WriteLine("Ingrese el número de articulos que desee gestionar: ")
            contador = Console.ReadLine()
            ReDim nombre(contador - 1)
            ReDim precio(contador - 1)
            For contador = 0 To nombre.GetUpperBound(0)
                Console.Write("Ingrese el nombre del articulo: ")
                nombre(contador) = Console.ReadLine()
                Console.Write("Ingrese el precio del articulo: ")
                precio(contador) = Console.ReadLine()
            Next
        End Sub
        Public Sub Menor()

            Console.WriteLine("Ingrese el precio de corte para buscar los productos con menor precio: ")
                corte = Console.ReadLine
                For contador = 0 To nombre.GetUpperBound(0)
                If precio(contador) < corte Then
                    Console.WriteLine(nombre(contador) & " = " & precio(contador))
                End If
            Next

        End Sub
    End Class
    Sub Main()
        Dim art As New Articulos
        art.Inicia()
        art.Menor()
        Console.WriteLine("Pulse una tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
