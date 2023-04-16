Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Try
            Dim archivo As FileStream = New FileStream("Archivo.bin", FileMode.Open)
            Dim lector As BinaryReader = New BinaryReader(archivo)
            Console.WriteLine(lector)
            archivo.Close()
        Catch e As FileNotFoundException
            Console.WriteLine("El archivo no se encontró.")
            Console.WriteLine(e.Message)
        Catch e As Exception
            Console.WriteLine("Ha ocurrido un error inesperado.")
            Console.WriteLine(e.Message)
        End Try
    End Sub
End Module
