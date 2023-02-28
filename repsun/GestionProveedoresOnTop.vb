Imports System.Data.OleDb
Imports System.Runtime.Remoting.Channels

Public Class GestionProveedoresOnTop
    ' Variable pública que comprueba si quieres actualizar o crear un proveedor
    Public Shared booleanCrear As Boolean

    ' Variable pública que guarda el proveedor a actualizar
    Public Shared empresaUpdate As String


    'Aquí se establece la conexión a la base de datos mediante el proveedor Microsoft.ACE.OLEDB.12.0 y se especifica la ubicación de la base de datos.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    'Aquí se crea un adaptador de datos OleDbDataAdapter para seleccionar todos los datos de la tabla "proveedor" de la base de datos.
    Public adaptador_tienda As New OleDbDataAdapter("Select * from proveedor", conexion)

    'Aquí se crea un objeto DataSet llamado "gestion_dataset".
    Public gestion_dataset As New DataSet

    'Este sub se ejecuta cuando se carga el formulario GestionProveedoresOnTop.
    Private Sub GestionProveedoresOnTop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.Open()
        'Aquí se llena el DataSet "gestion_dataset" con los datos de la tabla "proveedor".
        adaptador_tienda.Fill(gestion_dataset, "proveedor")
        'Este bloque de código establece el título del formulario según si se está creando un nuevo proveedor o editando uno existente.
        If booleanCrear Then
            lbl_TituloGestionProveedores.Text = "Crear un proveedor"
            MyBase.Text = "Crear un proveedor"
            txt_nombreProveedorEmpresa.Text = ""
            txt_nombreProveedorRepresentante.Text = ""
            txt_apellidos.Text = ""
            txt_telefono.Text = ""
            txt_email.Text = ""
        Else
            lbl_TituloGestionProveedores.Text = "Editar un proveedor"
            MyBase.Text = "Editar un proveedor"

            Dim query As String = "SELECT * FROM proveedor WHERE nombre_emp = @emp"
            Dim comando As New OleDbCommand(query, conexion)
            comando.Parameters.AddWithValue("@emp", empresaUpdate)
            Dim reader As OleDbDataReader = comando.ExecuteReader
            ' Cambio de todos los editText
            If reader.Read Then
                txt_nombreProveedorEmpresa.Text = reader("nombre_emp").ToString
                txt_nombreProveedorRepresentante.Text = reader("nombre").ToString
                txt_apellidos.Text = reader("apellidos").ToString
                txt_telefono.Text = reader("telefono").ToString
                txt_email.Text = reader("email").ToString
            End If
        End If
    End Sub

    Public Sub GestionProveedoresOnTop_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        empresaUpdate = ""
        conexion.Close()
    End Sub

    'Este sub se ejecuta cuando se hace clic en el botón de acción (pbx_accion).
    Private Sub btn_accion_Click(sender As Object, e As EventArgs) Handles btn_accion.Click
        'Si booleanCrear es True, significa que se está creando un nuevo proveedor, por lo que se ejecuta esta sección de código.
        If booleanCrear Then
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna nombre_emp es igual a la variable codigo.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM proveedor WHERE nombre_emp = @emp", conexion)
            consulta.Parameters.AddWithValue("@emp", txt_nombreProveedorEmpresa.Text)
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = CInt(consulta.ExecuteScalar())
            ' Comprobamos si el resultado es mayor que cero.
            If resultado = 0 Then
                If Validaciones.ValidarEmail(txt_email.Text) And Validaciones.ValidarNombre(txt_nombreProveedorRepresentante.Text) And Validaciones.ValidarNombre(txt_nombreProveedorRepresentante.Text) And IsNumeric(txt_telefono.Text) Then
                    ' La variable codigo existe dentro de la columna nombre_emp de la tabla proveedor.
                    Dim ordensql As String = "Insert Into Proveedor (nombre,apellidos,nombre_emp,telefono,email) values (@nom,@ape,@emp,@tfn,@ema)"
                    Dim comando As New OleDbCommand(ordensql, conexion)
                    comando.Parameters.AddWithValue("@nom", txt_nombreProveedorRepresentante.Text)
                    comando.Parameters.AddWithValue("@ape", txt_apellidos.Text)
                    comando.Parameters.AddWithValue("@emp", txt_nombreProveedorEmpresa.Text)
                    comando.Parameters.AddWithValue("@tfn", txt_telefono.Text)
                    comando.Parameters.AddWithValue("@ema", txt_email.Text)
                    Try
                        comando.ExecuteNonQuery()
                        Me.Close()
                    Catch ex As Exception
                        Registros.GrabarError("Ha ocurrido un error creando el proveedor. Llame al técnico responsable del sistema", "Error creando el proveedor")
                    End Try
                    ' Mostramos un mensaje de éxito.
                    MessageBox.Show("proveedor creado con éxito.")
                Else
                    ' La variable codigo no existe dentro de la columna nombre_emp de la tabla proveedor.
                    Registros.GrabarError("El código introducido ya existe en la base de datos", "El codigo de proveedor ya existe")
                End If
            Else
                Registros.GrabarError("Ha ocurrido un error creando el proveedor. Revise los campos", "Error creando el proveedor")

            End If


        Else 'Si booleanCrear es False, significa que se está editando un proveedor existente, por lo que se ejecuta esta sección de código.
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna nombre_emp es igual a la variable codigo.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM proveedor WHERE nombre_emp = @cod", conexion)
            consulta.Parameters.AddWithValue("@cod", empresaUpdate)
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = CInt(consulta.ExecuteScalar())
            ' Comprobamos si el resultado es mayor que cero.
            If resultado > 0 Then
                If Validaciones.ValidarEmail(txt_email.Text) And Validaciones.ValidarNombre(txt_nombreProveedorRepresentante.Text) And Validaciones.ValidarNombre(txt_nombreProveedorRepresentante.Text) And IsNumeric(txt_telefono.Text) Then
                    ' La variable codigo existe dentro de la columna nombre_emp de la tabla proveedor.
                    Dim ordensql As String = "UPDATE proveedor set nombre=@nom, apellidos=@ape, telefono=@tfn, email=@ema WHERE nombre_emp=@emp"
                    Dim comando As New OleDbCommand(ordensql, conexion)
                    comando.Parameters.AddWithValue("@nom", txt_nombreProveedorRepresentante.Text)
                    comando.Parameters.AddWithValue("@ape", txt_apellidos.Text)
                    comando.Parameters.AddWithValue("@tfn", txt_telefono.Text)
                    comando.Parameters.AddWithValue("@ema", txt_email.Text)
                    comando.Parameters.AddWithValue("@emp", txt_nombreProveedorEmpresa.Text)
                    Try
                        comando.ExecuteNonQuery()
                        Me.Close()
                    Catch ex As Exception
                        Registros.GrabarError("Ha ocurrido un error modificando el proveedor. Revise los campos", "Error modificando el proveedor")
                    End Try
                    ' Mostramos un mensaje de éxito.
                    MessageBox.Show("Proveedor modificado con éxito.")

                End If
            Else
                Registros.GrabarError("Ha ocurrido un error creando el proveedor. Revise los campos", "Error creando el proveedor")
            End If

            End If

    End Sub

End Class