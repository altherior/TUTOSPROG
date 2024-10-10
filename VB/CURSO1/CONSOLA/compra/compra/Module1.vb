Module Module1

    Sub Main()
        Dim priceunit, pricetotal, count As Single


        Console.Write("Introduzca el coste del articulo: ")
        priceunit = Console.ReadLine()
        Console.Write("Introduzca el número de articulos que lleva el comprador: ")
        count = Console.ReadLine()
        pricetotal = count * priceunit

        Console.WriteLine("El cliente ha de abonar: " & pricetotal)
        Console.ReadKey()
    End Sub

End Module
