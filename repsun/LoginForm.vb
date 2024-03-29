﻿Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class LoginForm
    Public Shared userConnected As String
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
        comprobarCamposVacios()
        Try
            If Validaciones.ValidarNombreUsuario(txt_user.Text) And Validaciones.ValidarContrasena(txt_contrasena.Text) Then
                comando.Parameters.AddWithValue("@usuario", txt_user.Text)
                comando.Parameters.AddWithValue("@contrasena", txt_contrasena.Text)
                conexion.Open()
                Dim reader As OleDbDataReader = comando.ExecuteReader

                If reader.Read() Then
                    Dim usuarioBD As String = reader("nombre_usuario").ToString()
                    Dim contrasenaBD As String = reader("contrasena").ToString()

                    Registros.GrabarAccesos(usuarioBD, contrasenaBD, True)
                    userConnected = usuarioBD
                    limpiarCampos()
                    MenuPrincipalForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos.")
                    Registros.GrabarAccesos(txt_user.Text, txt_contrasena.Text, False)
                    limpiarCampos()
                    Me.Refresh()
                End If
            Else
                Registros.GrabarError("El nombre de usuario o la contraseña están mal escritos", "Acceso invalido")
                Registros.GrabarAccesos(txt_user.Text, txt_contrasena.Text, False)
                limpiarCampos()
            End If
            conexion.Close()
        Catch ex As Exception
            Registros.GrabarError("Error iniciando sesión. Inténtelo de nuevo. Si el error persiste llame al técnico responsable del sistema", "Error Inicio Sesión")
        End Try

    End Sub



    Private Sub pbx_exit_Click(sender As Object, e As EventArgs) Handles pbx_exit.Click
        End
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
        txt_user.Text = txt_user.Text.Trim
        If txt_user.Text = "" Then
            txt_user.Text = "nombre.apellido1"
            txt_user.ForeColor = Color.Gray
        End If
        comprobarCamposVacios()
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
        comprobarCamposVacios()
    End Sub

    Private Sub txt_contrasena_TextChanged(sender As Object, e As EventArgs) Handles txt_contrasena.TextChanged
        txt_contrasena.UseSystemPasswordChar = True
        txt_contrasena.ForeColor = Color.Black
        comprobarCamposVacios()
    End Sub

    Private Sub comprobarCamposVacios()
        txt_user.Text = txt_user.Text.Trim
        txt_contrasena.Text = txt_contrasena.Text.Trim
        If txt_user.Text.Length = 0 Then
            Me.err_errorProvider.SetError(txt_user, "Ingresa una usuario para continuar")
        ElseIf txt_contrasena.Text.Length = 0 Then
            Me.err_errorProvider.SetError(txt_contrasena, "Ingresa una contraseña para continuar")
        ElseIf txt_user.Text.Length > 0 And txt_contrasena.Text.Length > 0 Then
            Me.err_errorProvider.Clear()
        End If
    End Sub
End Class