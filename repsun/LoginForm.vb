Imports System.Data.OleDb

Public Class LoginForm
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Public adaptador As New OleDbDataAdapter("Select * from Usuarios", conexion)
    Public midataset As New DataSet

    ''' <summary>
    ''' Abre el formulario "MenuPrincipalForm" y oculta el formulario actual.
    ''' </summary>
    ''' <param name="sender">Botón inicio sesión</param>
    ''' <param name="e">Click</param>
    Private Sub btn_inicioSesion_Click(sender As Object, e As EventArgs) Handles btn_inicioSesion.Click
        adaptador.Fill(midataset, "Usuarios")
        Dim usuario_inp As String
        Dim contrasena As String
        If Validaciones.ValidarNombreUsuario(txt_user.Text) And Validaciones.ValidarContrasena(txt_contrasena.Text) Then
            MenuPrincipalForm.Show()
            Me.Hide()
        Else
            Registros.grabarError("Acceso Inválido", "Acceso invalido")

        End If
    End Sub

    Private Sub pbx_exit_Click(sender As Object, e As EventArgs) Handles pbx_exit.Click
        Me.Close()
    End Sub
End Class