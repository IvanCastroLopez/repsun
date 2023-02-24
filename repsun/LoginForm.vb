Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class LoginForm
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Public adaptador As New OleDbDataAdapter("Select * from Usuarios", conexion)
    Dim query As String = "SELECT * FROM usuarios WHERE nombre_usuario = @usuario AND contrasena = @contrasena"
    Dim comando As New OleDbCommand(query, conexion)
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Nothing
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
                Dim contrasenaBD As String = reader("contrasena").ToString()

                Registros.GrabarAccesos(usuarioBD, contrasenaBD, True)
                limpiarCampos()
                MenuPrincipalForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos.")
                Registros.GrabarAccesos(txt_user.Text, txt_contrasena.Text, False)
                limpiarCampos()
            End If
        Else
            Registros.GrabarError("El nombre de usuario o la contraseña están mal escritos", "Acceso invalido")
            Registros.GrabarAccesos(txt_user.Text, txt_contrasena.Text, False)
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
        Me.ActiveControl = Nothing
    End Sub

    Private Sub txt_user_GotFocus(sender As Object, e As EventArgs) Handles txt_user.GotFocus
        If txt_user.Text = "nombre.apellido1" Then
            txt_user.Text = ""
            txt_user.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_user_LostFocus(sender As Object, e As EventArgs) Handles txt_user.LostFocus
        If txt_user.Text = "" Then
            txt_user.Text = "nombre.apellido1"
            txt_user.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txt_contrasena_GotFocus(sender As Object, e As EventArgs) Handles txt_contrasena.GotFocus
        If txt_contrasena.Text = "contraseña" Then
            txt_contrasena.Text = ""
            txt_contrasena.UseSystemPasswordChar = True
            txt_contrasena.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_contrasena_LostFocus(sender As Object, e As EventArgs) Handles txt_contrasena.LostFocus
        If txt_contrasena.Text = "" Then
            txt_contrasena.Text = "contraseña"
            txt_contrasena.UseSystemPasswordChar = False
            txt_contrasena.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txt_contrasena_TextChanged(sender As Object, e As EventArgs) Handles txt_contrasena.TextChanged
        txt_contrasena.UseSystemPasswordChar = True
        txt_contrasena.ForeColor = Color.Black
    End Sub

    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged

    End Sub
End Class