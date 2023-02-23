Public Class LoginForm
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
        If () Then
            MenuPrincipalForm.Show()
        Me.Hide()
    End Sub

End Class