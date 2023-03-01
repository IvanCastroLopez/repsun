Imports System.Data.OleDb

Public Class ClientesOnTop
    ' Variable pública que comprueba si quieres actualizar o crear un Cliente Repsol
    Public Shared booleanCrear As Boolean

    ' Variable pública que guarda el ClienteRepsol a actualizar
    Public Shared clienteUpdate As Integer

    'Aquí se establece la conexión a la base de datos mediante el proveedor Microsoft.ACE.OLEDB.12.0 y se especifica la ubicación de la base de datos.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    'Aquí se crea un adaptador de datos OleDbDataAdapter para seleccionar todos los datos de la tabla "ClienteRepsol" de la base de datos.
    Public adaptador_clientes As New OleDbDataAdapter("Select * from ClienteRepsol", conexion)

    'Aquí se crea un objeto DataSet llamado "gestion_dataset".
    Public gestion_dataset As New DataSet

    'Este sub se ejecuta cuando se carga el formulario ClientesOnTop.
    Private Sub ClientesOnTop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.Open()
        'Aquí se llena el DataSet "gestion_dataset" con los datos de la tabla "ClienteRepsol".
        adaptador_clientes.Fill(gestion_dataset, "ClienteRepsol")
        'Este bloque de código establece el título del formulario según si se está creando un nuevo cliente o editando uno existente.
        If booleanCrear Then
            lbl_TituloGestionclientes.Text = "Crear un cliente"
            txt_codigoCliente.Enabled = True
            txt_codigoCliente.Text = ""
            txt_nombre.Text = ""
            txt_apellidos.Text = ""
            txt_dni.Text = ""
            txt_email.Text = ""
        Else
            lbl_TituloGestionclientes.Text = "Editar un cliente"
            txt_codigoCliente.Enabled = False

            Dim query As String = "SELECT * FROM ClienteRepsol WHERE cod_cliente=@cod"
            Dim comando As New OleDbCommand(query, conexion)
            comando.Parameters.AddWithValue("@cod", clienteUpdate)
            Dim reader As OleDbDataReader = comando.ExecuteReader
            ' Cambio de todos los editText
            If reader.Read Then
                txt_codigoCliente.Text = clienteUpdate
                txt_nombre.Text = reader("nombre").ToString()
                txt_apellidos.Text = reader("apellidos").ToString()
                txt_dni.Text = reader("dni").ToString()
                txt_email.Text = reader("email").ToString()
                dtp_fechaAlta.Value = reader("fecha_alta")
            End If
        End If
    End Sub

    Public Sub GestionclientesOnTop_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        clienteUpdate = Nothing
        conexion.Close()
    End Sub

    'Este sub se ejecuta cuando se hace clic en el botón de acción (pbx_accion).
    Private Sub btn_accion_Click(sender As Object, e As EventArgs) Handles btn_accion.Click
        'Si booleanCrear es True, significa que se está creando un nuevo cliente, por lo que se ejecuta esta sección de código.
        If booleanCrear Then
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna cod_cliente es igual a la variable codigo.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM ClienteRepsol WHERE cod_cliente = @cod", conexion)
            consulta.Parameters.AddWithValue("@cod", txt_codigoCliente.Text)
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = CInt(consulta.ExecuteScalar())
            ' Comprobamos si el resultado es mayor que cero.
            If resultado = 0 Then
                If Validaciones.ValidarNombre(txt_nombre.Text) And Validaciones.ValidarNombre(txt_apellidos.Text) And Validaciones.ValidarDni(txt_dni.Text) And Validaciones.ValidarEmail(txt_email.Text) Then
                    ' La variable codigo existe dentro de la columna cod_cliente de la tabla cliente.
                    Dim ordensql As String = "Insert Into ClienteRepsol (cod_cliente,nombre,apellidos,fecha_alta,email,dni) values (@cod,@nom,@ape,@dat,@ema,@dni)"
                    Dim comando As New OleDbCommand(ordensql, conexion)
                    comando.Parameters.AddWithValue("@cod", txt_codigoCliente.Text)
                    comando.Parameters.AddWithValue("@nom", txt_nombre.Text)
                    comando.Parameters.AddWithValue("@ape", txt_apellidos.Text)
                    comando.Parameters.AddWithValue("@dat", dtp_fechaAlta.Text)
                    comando.Parameters.AddWithValue("@ema", txt_email.Text)
                    comando.Parameters.AddWithValue("@dni", txt_dni.Text)
                    Try
                        comando.ExecuteNonQuery()
                        Me.Close()
                        ' Mostramos un mensaje de éxito.
                        MessageBox.Show("Cliente creado con éxito.")
                        ImprimirTarjeta(txt_codigoCliente.Text, txt_nombre.Text, txt_apellidos.Text, txt_dni.Text, txt_email.Text, dtp_fechaAlta.Text)
                    Catch ex As Exception
                        Registros.GrabarError("Ha ocurrido un error creando el cliente. Llame al técnico responsable del sistema", "Error creando el cliente")
                    End Try
                Else
                    ' Los valores están mal.
                    Registros.GrabarError("Ha ocurrido un error creando el cliente. Revise los campos", "Error creando el Cleinte")

                End If
            Else
                ' La variable codigo no existe dentro de la columna cod_cliente de la tabla cliente.
                Registros.GrabarError("El código introducido ya existe en la base de datos", "El codigo de cliente ya existe")
            End If

        Else 'Si booleanCrear es False, significa que se está editando un cliente existente, por lo que se ejecuta esta sección de código.
            Dim ordensql As String = "UPDATE ClienteRepsol set nombre=@nom, apellidos=@ape, dni=@dni, email=@ema, fecha_alta=@dat WHERE cod_cliente=@cod"
            Dim comando As New OleDbCommand(ordensql, conexion)
            comando.Parameters.AddWithValue("@nom", txt_nombre.Text)
            comando.Parameters.AddWithValue("@ape", txt_apellidos.Text)
            comando.Parameters.AddWithValue("@dni", txt_dni.Text)
            comando.Parameters.AddWithValue("@ema", txt_email.Text)
            comando.Parameters.AddWithValue("@dat", dtp_fechaAlta.Text)
            comando.Parameters.AddWithValue("@cod", txt_codigoCliente.Text)
            Try
                comando.ExecuteNonQuery()
                Me.Close()
            Catch ex As Exception
                Registros.GrabarError("Ha ocurrido un error modificando el cliente. Revise los campos", "Error modificando el cliente")
            End Try
            ' Mostramos un mensaje de éxito.
            MessageBox.Show("Cliente modificado con éxito.")
        End If

    End Sub

    Private Sub ImprimirTarjeta(ByVal codigoCliente As String, ByVal nombre As String, ByVal apellidos As String, ByVal dni As String, ByVal email As String, ByVal fechaAlta As Date)
        ' Crear un objeto PrintDocument
        Dim pd As New Printing.PrintDocument()

        ' Establecer el controlador de eventos PrintPage para imprimir la página
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     ' Definir la fuente y el tamaño de letra
                                     Dim font As New Font("Arial", 12)

                                     ' Definir la posición de la primera línea de texto
                                     Dim yPos As Integer = 100

                                     ' Imprimir los datos del cliente en la tarjeta
                                     e.Graphics.DrawString("Código de cliente: " & codigoCliente, font, Brushes.Black, New Point(50, yPos))
                                     yPos += 20
                                     e.Graphics.DrawString("Nombre: " & nombre, font, Brushes.Black, New Point(50, yPos))
                                     yPos += 20
                                     e.Graphics.DrawString("Apellidos: " & apellidos, font, Brushes.Black, New Point(50, yPos))
                                     yPos += 20
                                     e.Graphics.DrawString("DNI: " & dni, font, Brushes.Black, New Point(50, yPos))
                                     yPos += 20
                                     e.Graphics.DrawString("Email: " & email, font, Brushes.Black, New Point(50, yPos))
                                     yPos += 20
                                     e.Graphics.DrawString("Fecha de alta: " & fechaAlta.ToShortDateString(), font, Brushes.Black, New Point(50, yPos))
                                 End Sub

        ' Mostrar el cuadro de diálogo de impresión
        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            pd.PrinterSettings = printDialog.PrinterSettings
            pd.Print()
        End If
    End Sub

End Class
' ⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑⓑ