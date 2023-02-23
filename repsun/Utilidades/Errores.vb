Public Class Errores

    ''' <summary>
    ''' Muestra una caja de mensaje con un mensaje.
    ''' Graba en un fichero el error enviado junto a la hora y fecha en el.
    ''' </summary>
    ''' <param name="message"></param>
    ''' <param name="titulo"></param>
    ''' <returns></returns>
    Public Shared Function grabarError(message As String, titulo As String) As Integer
        Try
            MsgBox(message, 48, titulo)
            FileOpen(1, ".\logs\errores\RegistroError.txt", OpenMode.Append)
            Dim hora As String = Now.ToString
            WriteLine(1, hora, message)
            FileClose(1)
            Return 1
        Catch ex As Exception
            MsgBox("Error grabando el error. Llame al técnico responsable del sistema", 48, "ERROR")
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
