﻿Public Class MenuPrincipalForm

    Private Sub btn_surtidores_Click(sender As Object, e As EventArgs) Handles btn_surtidores.Click
        SurtidorOnTop.Show()
        Me.Hide()
    End Sub

    Private Sub MenuPrincipalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_gestion_Click_1(sender As Object, e As EventArgs) Handles btn_gestion.Click
        GestionForm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_tpv_Click_1(sender As Object, e As EventArgs) Handles btn_tpv.Click
        tpvForm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_zonaClientes_Click_1(sender As Object, e As EventArgs) Handles btn_zonaClientes.Click
        ClientesOnTop.booleanCrear = True
        ClientesOnTop.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class