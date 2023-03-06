Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports repsun.Herramientas

Public Class SurtidorOnTop
    Private dineroTotal As Decimal

    ' Aquí se establece la conexión a la base de datos mediante el proveedor Microsoft.ACE.OLEDB.12.0 y se especifica la ubicación de la base de datos.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Public adaptador_clientes As New OleDbDataAdapter("Select * from ClienteRepsol", conexion)
    Private Sub SurtidorOnTop_Load(sender As Object, e As EventArgs) Handles Me.Load
        GestionForm.cargarDatosCombustible()
    End Sub

    Private Sub txt_precioTotal_LostFocus(sender As Object, e As EventArgs) Handles txt_precioTotal.LostFocus
        Dim dinero As Decimal

        If cbx_tipoCombustible.Text = "Sin Plomo 95" Then
            If Decimal.TryParse(txt_precioTotal.Text, dinero) Then
                txt_litros.Text = Herramientas.CambioPrecioLitros(txt_precioTotal.Text, tipoCombustible.sin_plomo_95)
            ElseIf txt_precioTotal.Text = "" Then

            Else
                MessageBox.Show("Los valores introducidos no son válidos.")
            End If
        ElseIf cbx_tipoCombustible.Text = "Sin Plomo 98" Then
            If Decimal.TryParse(txt_precioTotal.Text, dinero) Then
                txt_litros.Text = Herramientas.CambioPrecioLitros(txt_precioTotal.Text, tipoCombustible.sin_plomo_98)
            ElseIf txt_precioTotal.Text = "" Then

            Else
                MessageBox.Show("Los valores introducidos no son válidos.")
            End If
        ElseIf cbx_tipoCombustible.Text = "Diesel" Then
            If Decimal.TryParse(txt_precioTotal.Text, dinero) Then
                txt_litros.Text = Herramientas.CambioPrecioLitros(txt_precioTotal.Text, tipoCombustible.diesel)
            ElseIf txt_precioTotal.Text = "" Then

            Else
                MessageBox.Show("Los valores introducidos no son válidos.")
            End If
        ElseIf cbx_tipoCombustible.Text = "Diesel +" Then
            If Decimal.TryParse(txt_precioTotal.Text, dinero) Then
                txt_litros.Text = Herramientas.CambioPrecioLitros(txt_precioTotal.Text, tipoCombustible.diesel_plus)
            ElseIf txt_precioTotal.Text = "" Then

            Else
                MessageBox.Show("Los valores introducidos no son válidos.")
            End If
        Else

        End If



    End Sub

    Private Sub txt_litros_LostFocus(sender As Object, e As EventArgs) Handles txt_litros.LostFocus

        Dim dinero As Decimal
        If cbx_tipoCombustible.Text = "Sin Plomo 95" Then
            If Decimal.TryParse(txt_litros.Text, dinero) Then
                txt_precioTotal.Text = Herramientas.CambioLitrosPrecio(txt_litros.Text, tipoCombustible.sin_plomo_95)
            ElseIf txt_litros.Text = "" Then

            Else
                MessageBox.Show("Los valores introducidos no son válidos.")
            End If
        ElseIf cbx_tipoCombustible.Text = "Sin Plomo 98" Then
            If Decimal.TryParse(txt_litros.Text, dinero) Then
                txt_precioTotal.Text = Herramientas.CambioLitrosPrecio(txt_litros.Text, tipoCombustible.sin_plomo_98)
            ElseIf txt_litros.Text = "" Then

            Else
                MessageBox.Show("Los valores introducidos no son válidos.")
            End If
        ElseIf cbx_tipoCombustible.Text = "Diesel" Then
            If Decimal.TryParse(txt_litros.Text, dinero) Then
                txt_precioTotal.Text = Herramientas.CambioLitrosPrecio(txt_litros.Text, tipoCombustible.diesel)
            ElseIf txt_litros.Text = "" Then

            Else
                MessageBox.Show("Los valores introducidos no son válidos.")
            End If
        ElseIf cbx_tipoCombustible.Text = "Diesel +" Then
            If Decimal.TryParse(txt_litros.Text, dinero) Then
                txt_precioTotal.Text = Herramientas.CambioLitrosPrecio(txt_litros.Text, tipoCombustible.diesel_plus)
            ElseIf txt_litros.Text = "" Then

            Else
                MessageBox.Show("Los valores introducidos no son válidos.")
            End If
        Else

        End If


    End Sub

    Dim cliente As Boolean = False

    Dim codCliente As String
    Dim nombreCliente As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userInput As String = String.Empty
        Dim ComprobacionCantidad As Boolean = GestionForm.comprobarCombustible(cbx_tipoCombustible.SelectedIndex, Decimal.Parse(txt_litros.Text))

        MsgBox(ComprobacionCantidad) 'borrar

        If ComprobacionCantidad Then
            userInput = InputBox("Pregunte si es cliente, si lo es, introduzca su código de cliente: ", "¿Es Cliente?")

            If userInput = String.Empty Then
                ' El usuario hizo clic en Cancelar
                'Exit Sub
            Else
                If ExisteClienteRepsol(userInput) Then
                    cliente = True
                    Dim queryCliente As String = "SELECT COUNT(*) FROM ClienteRepsol WHERE cod_cliente = @cod_cliente"
                    Dim queryCliente2 As String = "SELECT * FROM ClienteRepsol WHERE cod_cliente = @cod_cliente"
                    Dim comandoCliente As New OleDbCommand(queryCliente, conexion)
                    comandoCliente.Parameters.AddWithValue("@cod_cliente", userInput)
                    Dim comandoCliente2 As New OleDbCommand(queryCliente2, conexion)
                    comandoCliente2.Parameters.AddWithValue("@cod_cliente", userInput)
                    Dim readerPublicCliente As OleDbDataReader
                    conexion.Open()
                    readerPublicCliente = comandoCliente2.ExecuteReader
                    If readerPublicCliente.Read Then
                        codCliente = userInput
                        nombreCliente = readerPublicCliente("nombre")
                    End If
                    readerPublicCliente.Close()
                    conexion.Close()
                End If
            End If

            Dim resultado As DialogResult = MessageBox.Show("¿Va a pagar con tarjeta?", "Opciones de Pago", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintTicket
            PrintDocument1.Print()
            If resultado = DialogResult.Yes Then
                MsgBox("Pago Correcto")
                AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintTicket
                PrintDocument1.Print()
                Me.Close()
            ElseIf resultado = DialogResult.No Then
                ' Acción para el botón "Cancelar"
                MsgBox("No se puede pagar con efectivo")
            ElseIf resultado = DialogResult.Cancel Then
                ' Acción para el botón "Cancelar"
                MsgBox("Pago cancelado.")
            End If
        Else
            Me.Refresh()
        End If
        Dispose()
    End Sub

    Public Function ExisteClienteRepsol(ByVal cod_cliente As Integer) As Boolean
        Dim existe As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM ClienteRepsol WHERE cod_cliente = @cod_cliente"
        conexion.Open()

        Using cmd As New OleDbCommand(query, conexion)
            cmd.Parameters.AddWithValue("@cod_cliente", cod_cliente)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                existe = True
            End If
        End Using
        conexion.Close()
        Return existe
    End Function

    Private Sub PrintTicket(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim introducido As Integer = txt_precioTotal.Text
        ' Fuente que usaremos en el ticket (Usaremos Courier new ya que todos los caracteres miden lo mismo)
        Dim printFont As System.Drawing.Font = New Font("Courier New", 12, FontStyle.Regular)
        ' Dim printFont As System.Drawing.Font = New Font("Arial", 9, FontStyle.Italic)

        ' creamos variables que nos ayudarán a la impresión del ticket.
        Dim topMargin As Double = ev.MarginBounds.Top
        Dim yPos As Double = 0
        Dim tab As String = "    "

        ' imprime la imagen
        ' ev.Graphics.DrawImage(Image.FromFile(".\Imagenes\Logo\LogoTicketRepsun.png"), x espacio, y espacio, ancho, alto)
        ev.Graphics.DrawImage(Image.FromFile(".\Imagenes\Logo\LogoTicketRepsun.png"), 195, 50, 200, 113)

        yPos += 160
        ' Imprime la cabecera
        ev.Graphics.DrawString("Autovía A-6", printFont, Brushes.Black, 240, yPos)
        yPos += 20
        ev.Graphics.DrawString("pk: 7,800 Madrid", printFont, Brushes.Black, 210, yPos)
        yPos += 20
        ev.Graphics.DrawString("Repsun A6 SL", printFont, Brushes.Black, 230, yPos)
        yPos += 20
        ev.Graphics.DrawString("CIF: B85989903", printFont, Brushes.Black, 220, yPos)
        yPos += 20
        ev.Graphics.DrawString("FACTURA SIMPLIFICADA", printFont, Brushes.Black, 190, yPos)
        yPos += 30
        ev.Graphics.DrawString("-----------------------------------", printFont, Brushes.Black, 120, yPos)
        yPos += 30
        ev.Graphics.DrawString(Now, printFont, Brushes.Black, 200, yPos)
        yPos += 30
        ev.Graphics.DrawString("-----------------------------------", printFont, Brushes.Black, 120, yPos)
        yPos += 20

        ' Imprime los articulos

        ev.Graphics.DrawString(txt_litros.Text.ToString() & "L", printFont, Brushes.Black, 130, yPos)
        ev.Graphics.DrawString(cbx_tipoCombustible.Text.ToString(), printFont, Brushes.Black, 160, yPos)
        Dim precioTotal As Decimal = Decimal.Parse(txt_precioTotal.Text)
        yPos += 20
        ev.Graphics.DrawString("-----------------------------------", printFont, Brushes.Black, 120, yPos)

        yPos += 30
        If Not cliente Then
            ev.Graphics.DrawString(txt_litros.Text.ToString() & "€", New Font("Courier New", 15, FontStyle.Bold), Brushes.Black, 390, yPos)
            yPos += 30
        Else
            ev.Graphics.DrawString(txt_litros.Text.ToString() & "€" & " -2% = " & (txt_precioTotal.Text - txt_precioTotal.Text * 0.02), New Font("Courier New", 15, FontStyle.Bold), Brushes.Black, 280, yPos)
            yPos += 30
        End If

        ev.Graphics.DrawString("IVA INCLUIDO", New Font("Courier New", 9, FontStyle.Regular), Brushes.Black, 380, yPos)
        yPos += 20

        ev.Graphics.DrawString("-----------------------------------", printFont, Brushes.Black, 120, yPos)
        yPos += 20

        ev.Graphics.DrawString("Base Imp", printFont, Brushes.Black, 140, yPos)
        ev.Graphics.DrawString("%IVA", printFont, Brushes.Black, 300, yPos)
        ev.Graphics.DrawString("IVA", printFont, Brushes.Black, 440, yPos)
        yPos += 20


        Dim impuestos As Decimal = txt_precioTotal.Text * 0.21

        ev.Graphics.DrawString(Math.Round(txt_precioTotal.Text - impuestos).ToString, printFont, Brushes.Black, 150, yPos)
        ev.Graphics.DrawString("21,00", printFont, Brushes.Black, 300, yPos)
        ev.Graphics.DrawString(Math.Round(impuestos, 2).ToString, printFont, Brushes.Black, 430, yPos)
        yPos += 20

        ev.Graphics.DrawString("Forma de pago", printFont, Brushes.Black, 230, yPos)
        yPos += 20

        ev.Graphics.DrawString("Tarjeta: ", printFont, Brushes.Black, 130, yPos)
        If introducido >= 10 Then
            ev.Graphics.DrawString(txt_precioTotal.Text, printFont, Brushes.Black, 420, yPos)
        Else
            ev.Graphics.DrawString(txt_precioTotal.Text, printFont, Brushes.Black, 430, yPos)
        End If
        yPos += 20
        yPos += 40

        yPos += 40
        ev.Graphics.DrawString("Firme aquí:", printFont, Brushes.Black, 130, yPos)
        yPos += 20
        ev.Graphics.DrawString("-----------------------------------", printFont, Brushes.Black, 120, yPos)
        yPos += 80

        ev.Graphics.DrawString("-----------------------------------", printFont, Brushes.Black, 120, yPos)
        yPos += 40

        If cliente Then
            ev.Graphics.DrawString("GRACIAS POR VENIR " & nombreCliente, New Font("Courier New", 14, FontStyle.Bold), Brushes.Black, 130, yPos)
            yPos += 20
        End If
        ev.Graphics.DrawString("INCLUIDA BONIFICACION", New Font("Courier New", 14, FontStyle.Bold), Brushes.Black, 140, yPos)
        yPos += 20
        ev.Graphics.DrawString("R.D. LEY 6/2022", New Font("Courier New", 14, FontStyle.Bold), Brushes.Black, 160, yPos)

        ev.HasMorePages = False

    End Sub


End Class