Imports System.Data.OleDb
Imports System.Runtime.Remoting.Channels

Public Class GestionProductosOnTop
    ' Variable pública que comprueba si quieres actualizar o crear un producto
    Public Shared booleanCrear As Boolean

    ' Variable pública que guarda el producto a actualizar
    Public Shared productoUpdate As Integer


    'Aquí se establece la conexión a la base de datos mediante el proveedor Microsoft.ACE.OLEDB.12.0 y se especifica la ubicación de la base de datos.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    'Aquí se crea un adaptador de datos OleDbDataAdapter para seleccionar todos los datos de la tabla "Producto" de la base de datos.
    Public adaptador_tienda As New OleDbDataAdapter("Select * from Producto", conexion)

    'Aquí se crea un objeto DataSet llamado "gestion_dataset".
    Public gestion_dataset As New DataSet

    'Este sub se ejecuta cuando se carga el formulario GestionProductosOnTop.
    Private Sub GestionProductosOnTop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.Open()
        'Aquí se llena el DataSet "gestion_dataset" con los datos de la tabla "Producto".
        adaptador_tienda.Fill(gestion_dataset, "Producto")
        'Este bloque de código establece el título del formulario según si se está creando un nuevo producto o editando uno existente.
        If booleanCrear Then
            lbl_TituloGestionProductos.Text = "Crear un producto"
            txt_codigoProducto.Enabled = True
            txt_codigoProducto.Text = ""
            txt_nombre.Text = ""
            cbx_categoria.Text = ""
            txt_precio.Text = ""
        Else
            lbl_TituloGestionProductos.Text = "Editar un producto"
            txt_codigoProducto.Enabled = False

            Dim query As String = "SELECT * FROM Producto WHERE cod_producto=@cod"
            Dim comando As New OleDbCommand(query, conexion)
            comando.Parameters.AddWithValue("@cod", productoUpdate)
            Dim reader As OleDbDataReader = comando.ExecuteReader
            ' Cambio de todos los editText
            If reader.Read Then
                txt_codigoProducto.Text = productoUpdate
                txt_nombre.Text = reader("nombre").ToString()
                cbx_categoria.Text = reader("categoria").ToString()
                txt_precio.Text = reader("precio").ToString()
            End If
        End If
    End Sub

    Public Sub GestionProductosOnTop_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        productoUpdate = Nothing
        GestionForm.actualizarDataGridView()
        conexion.Close()
    End Sub

    'Este sub se ejecuta cuando se hace clic en el botón de acción (pbx_accion).
    Private Sub btn_accion_Click(sender As Object, e As EventArgs) Handles btn_accion.Click
        'Si booleanCrear es True, significa que se está creando un nuevo producto, por lo que se ejecuta esta sección de código.
        If booleanCrear Then
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna cod_producto es igual a la variable codigo.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM Producto WHERE cod_producto = @cod", conexion)
            consulta.Parameters.AddWithValue("@cod", productoUpdate)
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = CInt(consulta.ExecuteScalar())
            ' Comprobamos si el resultado es mayor que cero.
            If resultado = 0 Then
                ' La variable codigo existe dentro de la columna cod_producto de la tabla Producto.
                Dim ordensql As String = "Insert Into Producto (cod_producto,nombre,categoria,precio) values (@cod,@nom,@cat,@pre)"
                Dim comando As New OleDbCommand(ordensql, conexion)
                comando.Parameters.AddWithValue("@cod", txt_codigoProducto.Text)
                comando.Parameters.AddWithValue("@nom", txt_nombre.Text)
                comando.Parameters.AddWithValue("@cat", cbx_categoria.Text)
                comando.Parameters.AddWithValue("@pre", txt_precio.Text)
                Try
                    comando.ExecuteNonQuery()
                    Me.Close()
                Catch ex As Exception
                    Registros.GrabarError("Ha ocurrido un error creando el producto. Revise los campos", "Error creando el producto")
                End Try
            Else
                ' La variable codigo no existe dentro de la columna cod_producto de la tabla Producto.
                Registros.GrabarError("El código introducido ya existe en la base de datos", "El codigo de producto ya existe")
            End If

        Else 'Si booleanCrear es False, significa que se está editando un producto existente, por lo que se ejecuta esta sección de código.
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna cod_producto es igual a la variable codigo.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM Producto WHERE cod_producto = @cod", conexion)
            consulta.Parameters.AddWithValue("@cod", productoUpdate)
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = CInt(consulta.ExecuteScalar())
            ' Comprobamos si el resultado es mayor que cero.
            If resultado > 0 Then
                ' La variable codigo existe dentro de la columna cod_producto de la tabla Producto.
                Dim ordensql As String = "UPDATE Producto set nombre=@nom, categoria=@cat, precio=@pre where cod_producto=@cod"
                Dim comando As New OleDbCommand(ordensql, conexion)
                comando.Parameters.AddWithValue("@cod", txt_codigoProducto.Text)
                comando.Parameters.AddWithValue("@nom", txt_nombre.Text)
                comando.Parameters.AddWithValue("@cat", cbx_categoria.Text)
                comando.Parameters.AddWithValue("@pre", txt_precio.Text)
                Try
                    comando.ExecuteNonQuery()
                    Me.Close()
                Catch ex As Exception
                    Registros.GrabarError("Ha ocurrido un error modificando el producto. Revise los campos", "Error modificando el producto")
                End Try
            End If
        End If

    End Sub

End Class