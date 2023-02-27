Public Class RegistrosOnTop
    Public Shared errores As Boolean = True
    Private Sub RegistrosOnTop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If errores Then
            ' Abrir el archivo de errores
            Dim rutaArchivo As String = ".\registros\errores\RegistroErrores.txt"
            Dim archivo As New System.IO.StreamReader(rutaArchivo)

            ' Leer el contenido del archivo
            Dim contenido As String = archivo.ReadToEnd()

            ' Mostrar el contenido en el control de texto multilinea
            txt_registros.Text = contenido

            ToolStripStatusLabel1.Text = ContarLineasArchivoTexto(rutaArchivo)

            ' Cerrar el archivo
            archivo.Close()
        Else
            ' Abrir el archivo de errores
            Dim rutaArchivo As String = ".\registros\accesos\RegistroAccesos.txt"
            Dim archivo As New System.IO.StreamReader(rutaArchivo)

            ' Leer el contenido del archivo
            Dim contenido As String = archivo.ReadToEnd()

            ' Mostrar el contenido en el control de texto multilinea
            txt_registros.Text = contenido
            ToolStripStatusLabel1.Text = "Numero de lineas: " & ContarLineasArchivoTexto(rutaArchivo)

            ' Cerrar el archivo
            archivo.Close()
        End If
    End Sub

    Public Function ContarLineasArchivoTexto(ByVal rutaArchivo As String) As Integer
        Dim contador As Integer = 0

        Using lectorArchivo As New System.IO.StreamReader(rutaArchivo)
            While lectorArchivo.ReadLine() IsNot Nothing
                contador += 1
            End While
        End Using

        Return contador
    End Function

End Class