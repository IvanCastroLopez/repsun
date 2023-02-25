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
        'Aquí se llena el DataSet "gestion_dataset" con los datos de la tabla "Producto".
        adaptador_tienda.Fill(gestion_dataset, "Producto")

        'Este bloque de código establece el título del formulario según si se está creando un nuevo producto o editando uno existente.
        If booleanCrear Then
            lbl_TituloGestionProductos.Text = "Crear un producto"
        Else
            lbl_TituloGestionProductos.Text = "Editar un producto"
        End If
    End Sub

    Public Sub GestionProductosOnTop_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        productoUpdate = Nothing
    End Sub

    'Este sub se ejecuta cuando se hace clic en el botón de acción (pbx_accion).
    Private Sub pbx_accion_Click(sender As Object, e As EventArgs) Handles pbx_accion.Click
        'Si booleanCrear es True, significa que se está creando un nuevo producto, por lo que se ejecuta esta sección de código.
        If booleanCrear Then
            Dim ordensql As String = "Insert Into Producto (cod_producto,nombre,categoria,precio) values (@cod,@nom,@cat,@pre)"
            Dim comando As New OleDbCommand(ordensql, conexion)
            comando.Parameters.AddWithValue("@cod", txt_codigoProducto.Text)
            comando.Parameters.AddWithValue("@nom", txt_nombre.Text)
            comando.Parameters.AddWithValue("@cat", cbx_categoria.Text)
            comando.Parameters.AddWithValue("@pre", txt_precio.Text)

            'Se abre la conexión a la base de datos, se ejecuta el comando y se captura cualquier excepción que se produzca.
            conexion.Open()
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                Registros.GrabarError("Ha ocurrido un error creando el producto. Revise los campos", "Error creando el producto")
            End Try
        Else 'Si booleanCrear es False, significa que se está editando un producto existente, por lo que se ejecuta esta sección de código.
            Dim ordensql As String = "UPDATE Producto set cod_producto=@cod, nombre=@nom, categoria=@cat, precio=@precio where cod=@cod"
            Dim comando As New OleDbCommand(ordensql, conexion)
            comando.Parameters.AddWithValue("@cod", txt_codigoProducto.Text)
            comando.Parameters.AddWithValue("@nom", txt_nombre.Text)
            comando.Parameters.AddWithValue("@cat", cbx_categoria.Text)
            comando.Parameters.AddWithValue("@pre", txt_precio.Text)

            'Se abre la conexión a la base de datos, se ejecuta el comando y se captura cualquier excepción que se produzca.
            conexion.Open()
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                Registros.GrabarError("Ha ocurrido un error creando el producto. Revise los campos", "Error creando el producto")
            End Try
        End If

        ' Se cierra la conexion a la base de datos.
        conexion.Close()
    End Sub

End Class