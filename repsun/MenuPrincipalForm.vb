Public Class MenuPrincipalForm
    Private Sub btn_surtidores_Click(sender As Object, e As EventArgs) Handles btn_surtidores.Click
        SurtidorOnTop.Show()
        Me.Hide()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click

    End Sub

    Private Sub btn_gestion_Click(sender As Object, e As EventArgs) Handles btn_gestion.Click
        GestionForm.Show()
        Me.Hide()
    End Sub
End Class