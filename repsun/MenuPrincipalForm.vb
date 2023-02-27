Public Class MenuPrincipalForm
    Public imgDefault, imgCliente, imgTienda, imgGestion, imgSurtidores, imgSalir As Image
    Private Sub MenuPrincipalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            imgDefault = Image.FromFile("Imagenes\MenuVisual\0-Default.png")
            tlp_layoutBotones.BackgroundImage = imgDefault
            imgCliente = Image.FromFile("Imagenes\MenuVisual\2-Cliente.png")
            imgTienda = Image.FromFile("Imagenes\MenuVisual\3-Tienda.png")
            imgGestion = Image.FromFile("Imagenes\MenuVisual\4-Gestion.png")
            imgSurtidores = Image.FromFile("Imagenes\MenuVisual\5-Surtidores.png")
            imgSalir = Image.FromFile("Imagenes\MenuVisual\Salir.png")
        Catch ex As Exception
            Registros.GrabarError("Hubo un problema al cargar las imagenes", "Error Imagenes")
        End Try
    End Sub

    Private Sub btn_surtidores_Click(sender As Object, e As EventArgs) Handles btn_surtidores.Click
        Surtidores.Show()
        Me.Hide()
    End Sub

    Private Sub btn_gestion_Click(sender As Object, e As EventArgs) Handles btn_gestion.Click
        GestionForm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_tpv_Click(sender As Object, e As EventArgs) Handles btn_tpv.Click
        tpvForm.Show()
        Me.Hide()
    End Sub

    Private Sub btn_zonaClientes_Click(sender As Object, e As EventArgs) Handles btn_zonaClientes.Click
        ClientesOnTop.booleanCrear = True
        ClientesOnTop.ShowDialog()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub



    '** EFECTO HOVER BOTONES **
    Private Sub setDefaultBackground()
        tlp_layoutBotones.BackgroundImage = imgDefault
    End Sub
    Private Sub btn_gestion_MouseHover(sender As Object, e As EventArgs) Handles btn_gestion.MouseHover
        tlp_layoutBotones.BackgroundImage = imgGestion
    End Sub
    Private Sub btn_gestion_MouseLeave(sender As Object, e As EventArgs) Handles btn_gestion.MouseLeave
        setDefaultBackground()
    End Sub
    Private Sub btn_salir_MouseHover(sender As Object, e As EventArgs) Handles btn_salir.MouseHover
        tlp_layoutBotones.BackgroundImage = imgSalir
    End Sub
    Private Sub btn_salir_MouseLeave(sender As Object, e As EventArgs) Handles btn_salir.MouseLeave
        setDefaultBackground()
    End Sub
    Private Sub btn_surtidores_MouseHover(sender As Object, e As EventArgs) Handles btn_surtidores.MouseHover
        tlp_layoutBotones.BackgroundImage = imgSurtidores
    End Sub
    Private Sub btn_surtidores_MouseLeave(sender As Object, e As EventArgs) Handles btn_surtidores.MouseLeave
        setDefaultBackground()
    End Sub
    Private Sub btn_tpv_MouseHover(sender As Object, e As EventArgs) Handles btn_tpv.MouseHover
        tlp_layoutBotones.BackgroundImage = imgTienda
    End Sub
    Private Sub btn_tpv_MouseLeave(sender As Object, e As EventArgs) Handles btn_tpv.MouseLeave
        setDefaultBackground()
    End Sub
    Private Sub btn_zonaClientes_MouseHover(sender As Object, e As EventArgs) Handles btn_zonaClientes.MouseHover
        tlp_layoutBotones.BackgroundImage = imgCliente
    End Sub
    Private Sub btn_zonaClientes_MouseLeave(sender As Object, e As EventArgs) Handles btn_zonaClientes.MouseLeave
        setDefaultBackground()
    End Sub
End Class