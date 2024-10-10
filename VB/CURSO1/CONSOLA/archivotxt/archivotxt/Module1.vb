Imports System.IO

Module Module1

    Sub Main()
        Dim archivo As StreamWriter

        archivo = File.AppendText("prueba.txt")
        archivo.WriteLine("prueba")
        archivo.Close()




    End Sub

End Module
