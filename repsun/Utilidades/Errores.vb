Public Class Errores

    ''' <summary>
    ''' Función que muestra un mensaje de error en una ventana de mensaje y graba el error en un archivo de registro.
    ''' </summary>
    ''' <param name="message">Mensaje de error a mostrar.</param>
    ''' <param name="titulo">Título de la ventana de mensaje de error.</param>
    ''' <returns>Devuelve un valor entero: 1 si se grabó el error correctamente y 0 si hubo un error al grabar el error.</returns>
    Public Shared Function grabarError(message As String, titulo As String) As Integer
        Try
            ' Mostrar mensaje de error en ventana de mensaje
            MsgBox(message, 48, titulo)
            ' Abrir archivo de registro de errores en modo de apertura de archivo para añadir información
            FileOpen(1, ".\logs\errores\RegistroError.txt", OpenMode.Append)

            ' Obtener la hora actual como una cadena
            Dim hora As String = Now.ToString

            ' Escribir la hora y el mensaje de error en el archivo de registro de errores
            WriteLine(1, hora, message)

            ' Cerrar archivo de registro de errores
            FileClose(1)

            ' Devolver 1 si se grabó el error correctamente
            Return 1
        Catch ex As Exception
            ' Mostrar mensaje de error si hubo un error al grabar el error
            MsgBox("Error grabando el error. Llame al técnico responsable del sistema", 48, "ERROR")

            ' Devolver 0 si hubo un error al grabar el error
            Return 0
        End Try
    End Function


    Public Shared Function grabarAccesos(nombreUsuario As String, contrasena As String, acceso As Boolean) As Integer
        Try
            Dim accesoValido As String
            If (acceso) Then
                accesoValido = "[Acceso Válido]"
            Else
                accesoValido = "[Acceso Denegado]"
            End If

            FileOpen(1, ".\logs\accesos\Accesos.txt", OpenMode.Append)
            Dim hora As String = Now.ToString
            Dim registro As String = hora + " " + accesoValido + " | Nombre de usuario: " + nombreUsuario + " | Contraseña: " + contrasena
            WriteLine(1, registro)
            FileClose(1)
            Return 1
        Catch ex As Exception
            MsgBox("Error grabando el login. Llame al técnico responsable del sistema", 48, "ERROR")
            Return 0
        End Try
    End Function
End Class
