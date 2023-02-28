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

    Private Sub pbx_salir_Click(sender As Object, e As EventArgs) Handles pbx_salir.Click
        MenuPrincipalForm.Show()
        Me.Close()
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