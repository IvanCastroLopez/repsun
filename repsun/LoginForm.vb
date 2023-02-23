Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class LoginForm
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Public adaptador As New OleDbDataAdapter("Select * from Usuarios", conexion)
    Dim query As String = "SELECT * FROM usuarios WHERE nombre_usuario = @usuario AND contrasena = @contrasena"
    Dim comando As New OleDbCommand(query, conexion)
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cambiar tamaño de estos
        ' lbl_bienvenido
        ' lbl_username
        ' txt_user
        ' lbl_contrasena
        ' txt_contrasena
        ' btn_inicioSesion

    End Sub

    ''' <summary>
    ''' Abre el formulario "MenuPrincipalForm" y oculta el formulario actual.
    ''' </summary>
    ''' <param name="sender">Botón inicio sesión</param>
    ''' <param name="e">Click</param>
    Private Sub btn_inicioSesion_Click(sender As Object, e As EventArgs) Handles btn_inicioSesion.Click
        If Validaciones.ValidarNombreUsuario(txt_user.Text) And Validaciones.ValidarContrasena(txt_contrasena.Text) Then
            comando.Parameters.AddWithValue("@usuario", txt_user.Text)
            comando.Parameters.AddWithValue("@contrasena", txt_contrasena.Text)
            conexion.Open()
            Dim reader As OleDbDataReader = comando.ExecuteReader

            If reader.Read() Then
                Dim usuarioBD As String = reader("nombre_usuario").ToString()
                Dim contrasenaBD As String = reader("contraseña").ToString()

                Registros.grabarAccesos(usuarioBD, contrasenaBD, True)
                limpiarCampos()
                MenuPrincipalForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos.")
                Registros.grabarAccesos(txt_user.Text, txt_contrasena.Text, False)
                limpiarCampos()
            End If
        Else
            Registros.grabarError("El nombre de usuario o la contraseña están mal escritos", "Acceso invalido")
            Registros.grabarAccesos(txt_user.Text, txt_contrasena.Text, False)
            limpiarCampos()
        End If
    End Sub

    Private Sub pbx_exit_Click(sender As Object, e As EventArgs) Handles pbx_exit.Click
        conexion.Close()
        Me.Close()
    End Sub

    Private Sub limpiarCampos()
        txt_user.Clear()
        txt_contrasena.Clear()
    End Sub
End Class