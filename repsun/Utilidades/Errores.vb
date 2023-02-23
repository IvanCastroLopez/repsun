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
            FileOpen(1, ".\registros\errores\RegistroErrores.txt", OpenMode.Append)

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


    ''' <summary>
    ''' Este método se encarga de registrar los accesos al sistema en un archivo de texto.
    ''' </summary>
    ''' <param name="nombreUsuario">El nombre del usuario que intentó acceder al sistema.</param>
    ''' <param name="contrasena">La contraseña proporcionada por el usuario.</param>
    ''' <param name="acceso">Un valor booleano que indica si el acceso fue exitoso o no.</param>
    ''' <returns>Un entero que indica si se pudo grabar el acceso correctamente (1) o si hubo un error (0).</returns>
    Public Shared Function grabarAccesos(nombreUsuario As String, contrasena As String, acceso As Boolean) As Integer
        Try
            Dim accesoValido As String
            If (acceso) Then
                accesoValido = "[Acceso Válido]"
            Else
                accesoValido = "[Acceso Denegado]"
            End If
            ' Abre el archivo de texto para grabar el registro del acceso.
            FileOpen(1, ".\registros\accesos\RegistroAccesos.txt", OpenMode.Append)
            ' Obtiene la fecha y hora actual.
            Dim hora As String = Now.ToString
            ' Construye el registro del acceso.
            Dim registro As String = hora + " " + accesoValido + " | Nombre de usuario: " + nombreUsuario + " | Contraseña: " + contrasena
            ' Graba el registro en el archivo de texto.
            WriteLine(1, registro)
            ' Cierra el archivo de texto.
            FileClose(1)
            ' Devolver 1 para indicar que se grabó el acceso correctamente.
            Return 1
        Catch ex As Exception
            ' Si ocurre un error al grabar el acceso, muestra un mensaje de error.
            MsgBox("Error grabando el login. Llame al técnico responsable del sistema", 48, "ERROR")
            ' Devolver 0 para indicar que hubo un error al grabar el acceso.
            Return 0
        End Try

    End Function
End Class
