Imports System.Data.OleDb

Public Class GestionEmpleadosOnTop
    ' Variable pública que guarda el empleado a actualizar
    Public Shared empleadoUpdate As Integer

    Public Shared booleanCrear As Boolean

    'Aquí se establece la conexión a la base de datos mediante el proveedor Microsoft.ACE.OLEDB.12.0 y se especifica la ubicación de la base de datos.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    'Aquí se crea un adaptador de datos OleDbDataAdapter para seleccionar todos los datos de la tabla "Empleado" de la base de datos.
    Public adaptador_tienda As New OleDbDataAdapter("Select * from Empleado", conexion)

    'Aquí se crea un objeto DataSet llamado "gestion_dataset".
    Public gestion_dataset As New DataSet

    'Este sub se ejecuta cuando se carga el formulario GestionEmpleados.
    Private Sub GestionEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.Open()
        'Aquí se llena el DataSet "gestion_dataset" con los datos de la tabla "Empleado".
        adaptador_tienda.Fill(gestion_dataset, "Empleado")
        'Este bloque de código establece el título del formulario según si se está creando un nuevo empleado o editando uno existente.
        If booleanCrear Then
            lbl_TituloGestionEmpleados.Text = "Crear un empleado"
            txt_codigoEmpleado.Enabled = True
            txt_codigoEmpleado.Text = ""
            txt_nombre.Text = ""
            txt_apellidos.Text = ""
            txt_dni.Text = ""
            txt_email.Text = ""
            txt_telefono.Text = ""
        Else
            lbl_TituloGestionEmpleados.Text = "Editar un empleado"
            txt_codigoEmpleado.Enabled = False

            Dim query As String = "SELECT * FROM Empleado WHERE cod_empleado=@cod"
            Dim comando As New OleDbCommand(query, conexion)
            comando.Parameters.AddWithValue("@cod", empleadoUpdate)
            Dim reader As OleDbDataReader = comando.ExecuteReader
            ' Cambio de todos los editText
            If reader.Read Then
                txt_codigoEmpleado.Text = empleadoUpdate
                txt_dni.Text = reader("dni").ToString()
                txt_nombre.Text = reader("nombre").ToString()
                txt_apellidos.Text = reader("apellidos").ToString()
            End If
        End If
    End Sub

    Public Sub GestionEmpleados_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        empleadoUpdate = Nothing
        GestionForm.actualizarDataGridView()
        conexion.Close()
    End Sub

    'Este sub se ejecuta cuando se hace clic en el botón de acción (btn_accion).
    Private Sub btn_accion_Click(sender As Object, e As EventArgs) Handles btn_accion.Click
        'Si booleanCrear es True, significa que se está creando un nuevo empleado, por lo que se ejecuta esta sección de código.
        If booleanCrear Then
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna cod_empleado es igual a la variable codigo.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM Empleado WHERE cod_empleado = @cod", conexion)
            consulta.Parameters.AddWithValue("@cod", empleadoUpdate)
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = 0
            ' Comprobamos si el resultado es mayor que cero.
            If resultado = 0 Then
                If Validaciones.ValidarNombreUsuario(txt_nombreUsuario.Text) And Validaciones.ValidarContrasena(txt_contrasena.Text) And Validaciones.ValidarEmail(txt_email.Text) And Validaciones.ValidarDni(txt_dni.Text) And Validaciones.ValidarNombre(txt_nombre.Text) And Validaciones.ValidarNombre(txt_apellidos.Text) And IsNumeric(txt_telefono.Text) And IsNumeric(txt_codigoEmpleado) Then
                    ' Si el resultado es igual a cero, significa que no existe ningún empleado con ese código y se puede crear uno nuevo.
                    ' Creamos un comando que inserta los datos del nuevo empleado en la tabla Empleado
                    Dim ordensql As String = "INSERT INTO Empleado (cod_empleado, dni, nombre, apellidos, email, telefono, rol) VALUES (@cod, @dni, @nom, @ape, @ema, @tfn, @rol)"
                    Dim comando As New OleDbCommand(ordensql, conexion)
                    comando.Parameters.AddWithValue("@cod", txt_codigoEmpleado.Text)
                    comando.Parameters.AddWithValue("@dni", txt_dni.Text)
                    comando.Parameters.AddWithValue("@nom", txt_nombre.Text)
                    comando.Parameters.AddWithValue("@ape", txt_apellidos.Text)
                    comando.Parameters.AddWithValue("@ema", txt_email.Text)
                    comando.Parameters.AddWithValue("@tfn", txt_telefono.Text)
                    comando.Parameters.AddWithValue("@rol", cbx_rol.Text)

                    Dim ordensql1 As String = "INSERT INTO Usuario (nombre_usuario, admin, cod_empleado, contrasena) VALUES (@nom, @adm, @cod, @pas)"
                    Dim comando1 As New OleDbCommand(ordensql1, conexion)
                    comando1.Parameters.AddWithValue("@nom", txt_nombreUsuario.Text)
                    comando1.Parameters.AddWithValue("@adm", False)
                    comando1.Parameters.AddWithValue("@cod", txt_codigoEmpleado.Text)
                    comando1.Parameters.AddWithValue("@pas", txt_contrasena)
                    ' Ejecutamos el comando.
                    Try
                        comando.ExecuteNonQuery()
                        comando1.ExecuteNonQuery()
                        ' Mostramos un mensaje de éxito.
                        MessageBox.Show("Empleado creado con éxito.")
                        ' Cerramos el formulario.
                        Me.Close()
                    Catch ex As Exception
                        Registros.GrabarError("Ha ocurrido un error creando el empleado. Llame al técnico responsable del sistema", "Error creando el empleado")
                    End Try
                Else
                    Registros.GrabarError("Ha ocurrido un error creando el empleado. Revise los campos", "Error creando el empleado")

                End If
            Else
                ' Si el resultado es mayor que cero, significa que ya existe un empleado con ese código y no se puede crear otro con el mismo código.
                Registros.GrabarError("Ya existe un empleado con ese código", "Error creando el empleado")
            End If

        Else
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna cod_empleado es igual a la variable codigo.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM Empleado WHERE cod_empleado = @cod", conexion)
            consulta.Parameters.AddWithValue("@cod", empleadoUpdate)
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = CInt(consulta.ExecuteScalar())
            ' Comprobamos si el resultado es mayor que cero.
            If resultado = 0 Then
                If Validaciones.ValidarNombreUsuario(txt_nombreUsuario.Text) And Validaciones.ValidarContrasena(txt_contrasena.Text) And Validaciones.ValidarEmail(txt_email.Text) And Validaciones.ValidarDni(txt_dni.Text) And Validaciones.ValidarNombre(txt_nombre.Text) And Validaciones.ValidarNombre(txt_apellidos.Text) And IsNumeric(txt_telefono.Text) And IsNumeric(txt_codigoEmpleado) Then
                    ' Si booleanCrear es False, significa que se está actualizando un empleado existente, por lo que se ejecuta esta sección de código.
                    ' Creamos un comando que actualiza los datos del empleado seleccionado en la tabla Empleado.
                    Dim ordensql As String = "UPDATE Empleado set dni=@dni, nombre=@nom, apellido=@ape, email=@ema, telefono=@tfn, rol=@rol where cod_empleado=@cod"
                    Dim comando As New OleDbCommand(ordensql, conexion)
                    comando.Parameters.AddWithValue("@dni", txt_dni.Text)
                    comando.Parameters.AddWithValue("@nom", txt_nombre.Text)
                    comando.Parameters.AddWithValue("@ape", txt_apellidos.Text)
                    comando.Parameters.AddWithValue("@ema", txt_email.Text)
                    comando.Parameters.AddWithValue("@tfn", txt_telefono.Text)
                    comando.Parameters.AddWithValue("@rol", cbx_rol.Text)
                    comando.Parameters.AddWithValue("@cod", txt_codigoEmpleado.Text)

                    Dim ordensql1 As String = "UPDATE Usuario set nombre_usuario=@nom, admin=@adm, contrasena=@pas where cod_empleado=@cod"
                    Dim comando1 As New OleDbCommand(ordensql1, conexion)
                    comando1.Parameters.AddWithValue("@nom", txt_nombreUsuario.Text)
                    comando1.Parameters.AddWithValue("@adm", False)
                    comando1.Parameters.AddWithValue("@pas", txt_contrasena)
                    comando1.Parameters.AddWithValue("@cod", txt_codigoEmpleado.Text)
                Else
                    Registros.GrabarError("Ha ocurrido un error creando el empleado. Revise los campos", "Error creando el empleado")
                End If
            Else
                Registros.GrabarError("No existe ningún empleado con ese código", "Error modificando el empleado")
            End If

        End If
    End Sub

End Class