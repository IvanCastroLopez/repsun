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

    Private Sub tlp_login_Paint(sender As Object, e As PaintEventArgs) Handles tlp_login.Paint

    End Sub

    Private Sub btn_inicioSesion_Click(sender As Object, e As EventArgs)
        MenuPrincipalForm.ShowDialog()
        Me.Hide()
    End Sub
End Class