Public Class GestionForm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbx_close.Click
        MenuPrincipalForm.Show()
        Me.Hide()
    End Sub
End Class