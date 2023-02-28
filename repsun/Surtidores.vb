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

        cocheAleatorio()
    End Sub

    ''' <summary>
    ''' Boton para salir de la ventana de surtidores
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbx_salir_Click(sender As Object, e As EventArgs) Handles pbx_salir.Click
        MenuPrincipalForm.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Cambia el tiempo que tarda el timer en dispararse, en un rango de entre 5 y 30 segundos
    ''' </summary>
    Private Sub tiempoAleatorio()
        Dim aleatorio As New Random()
        Dim numeroAleatorio As Integer = aleatorio.Next(5, 31)
        tmr_timer.Interval = numeroAleatorio * 1000
    End Sub

    ''' <summary>
    ''' Cada vez que se dispare el timer creara un nuevo coche
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmr_timer_Tick(sender As Object, e As EventArgs) Handles tmr_timer.Tick
        nuevoCoche() 'Crea un nuevo coche
        tiempoAleatorio() 'Cambia el tiempo de dispararse
    End Sub

    Private Sub nuevoCoche()

    End Sub

    Function cocheAleatorio()
        Dim randomIndex As Integer = New Random().Next(0, 8)


        pbx_coche1.Image = imagenesCoches(randomIndex)
    End Function

    Function posicionAleatoria()


    End Function

    Private Sub colocarCoche()

    End Sub

    Private Sub quitarCoche()

    End Sub


End Class