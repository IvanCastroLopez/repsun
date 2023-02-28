Public Class Surtidores
    Public imgCocheAmarillo, imgCocheAzul, imgCocheCyan, imgCocheGris, imgCocheNaranja, imgCocheNegro, imgCocheRojo, imgCocheVerde As Image
    Public imagenesCoches(7) As Image
    Dim numbers = New Integer() {1, 2, 4, 8}
    Private Sub Surtidores_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmr_timer.Start()

        'Carga las imagenes
        imgCocheAmarillo = Image.FromFile("Imagenes\Surtidores\amarillo.png")
        imgCocheAzul = Image.FromFile("Imagenes\Surtidores\azul.png")
        imgCocheCyan = Image.FromFile("Imagenes\Surtidores\cyan.png")
        imgCocheGris = Image.FromFile("Imagenes\Surtidores\gris.png")
        imgCocheNaranja = Image.FromFile("Imagenes\Surtidores\naranja.png")
        imgCocheNegro = Image.FromFile("Imagenes\Surtidores\negro.png")
        imgCocheRojo = Image.FromFile("Imagenes\Surtidores\rojo.png")
        imgCocheVerde = Image.FromFile("Imagenes\Surtidores\verde.png")
        imagenesCoches = {imgCocheAmarillo, imgCocheAzul, imgCocheCyan, imgCocheGris, imgCocheNaranja, imgCocheNegro, imgCocheRojo, imgCocheVerde}

        tiempoAleatorio()
        tmr_timer.Enabled = True
    End Sub

    ''' <summary>
    ''' Boton para salir de la ventana de surtidores
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbx_salir_Click(sender As Object, e As EventArgs) Handles pbx_salir.Click
        MenuPrincipalForm.Show()
        Me.Hide()
    End Sub

    ''' <summary>
    ''' Cambia el tiempo que tarda el timer en dispararse, en un rango de entre 5 y 30 segundos
    ''' </summary>
    Private Sub tiempoAleatorio()
        Dim aleatorio As New Random()
        'Dim numeroAleatorio As Integer = aleatorio.Next(5, 31)
        Dim numeroAleatorio As Integer = aleatorio.Next(5, 20)
        tmr_timer.Interval = numeroAleatorio * 1000
    End Sub

    ''' <summary>
    ''' Cada vez que se dispare el timer creara un nuevo coche
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmr_timer_Tick(sender As Object, e As EventArgs) Handles tmr_timer.Tick
        aparcarCoche() 'Crea un nuevo coche
        tiempoAleatorio() 'Cambia el tiempo de dispararse
    End Sub

    Private Sub aparcarCoche()
        Dim aleatorio As New Random()
        Dim numeroAleatorio As Integer = aleatorio.Next(1, 5)
        Select Case numeroAleatorio
            Case 1
                If pbx_coche1.Enabled = False Then
                    pbx_coche1.Enabled = True
                    pbx_coche1.Image = generarCoche()
                    nic_surtidores.ShowBalloonTip(5000)
                Else
                    tiempoAleatorio()
                End If
            Case 2
                If pbx_coche2.Enabled = False Then
                    pbx_coche2.Enabled = True
                    pbx_coche2.Image = generarCoche()
                    nic_surtidores.ShowBalloonTip(5000)
                Else
                    tiempoAleatorio()
                End If
            Case 3
                If pbx_coche3.Enabled = False Then
                    pbx_coche3.Enabled = True
                    pbx_coche3.Image = generarCoche()
                    nic_surtidores.ShowBalloonTip(5000)
                Else
                    tiempoAleatorio()
                End If
            Case 4
                If pbx_coche4.Enabled = False Then
                    pbx_coche4.Enabled = True
                    pbx_coche4.Image = generarCoche()
                    nic_surtidores.ShowBalloonTip(5000)
                Else
                    tiempoAleatorio()
                End If
            Case Else
                MsgBox("No existe la posicion " & numeroAleatorio)
        End Select
    End Sub

    Function generarCoche() As Image
        Dim randomIndex As Integer = New Random().Next(0, 8)
        Return imagenesCoches(randomIndex)
    End Function

    Private Sub quitarCoche()

    End Sub

    Private Sub pbx_coche1_Click(sender As Object, e As EventArgs) Handles pbx_coche1.Click
        SurtidorOnTop.Show()
    End Sub

    Private Sub pbx_coche2_Click(sender As Object, e As EventArgs) Handles pbx_coche2.Click
        SurtidorOnTop.Show()
    End Sub

    Private Sub pbx_coche3_Click(sender As Object, e As EventArgs) Handles pbx_coche3.Click
        SurtidorOnTop.Show()
    End Sub

    Private Sub pbx_coche4_Click(sender As Object, e As EventArgs) Handles pbx_coche4.Click
        SurtidorOnTop.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub nic_surtidores_Click(sender As Object, e As EventArgs) Handles nic_surtidores.Click
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        Me.nic_surtidores.Visible = False
    End Sub


End Class