Imports System.Data.OleDb

Public Class GestionProductosOnTop
    ' Variable pública que comprueba si quieres actualizar o crear un producto
    Public Shared booleanCrear As Boolean

    ' Variable pública que guarda el producto a actualizar
    Public Shared productoUpdate As Integer


    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Public adaptador_tienda As New OleDbDataAdapter("Select * from Producto", conexion)
    Public gestion_dataset As New DataSet

    Private Sub GestionProductosOnTop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adaptador_tienda.Fill(gestion_dataset, "Producto")


        If booleanCrear Then
            lbl_TituloGestionProductos.Text = "Crear un producto"
        Else
            lbl_TituloGestionProductos.Text = "Editar un producto"
        End If
    End Sub

    Private Sub pbx_accion_Click(sender As Object, e As EventArgs) Handles pbx_accion.Click
        If booleanCrear Then
            Dim ordensql As String = "Insert Into Producto (cod_producto,nombre,categoria,precio) values (@cod,@nom,@cat,@pre)"
            Dim comando As New OleDbCommand(ordensql, conexion)
            comando.Parameters.AddWithValue("@cod", txt_codigoProducto.Text)
            comando.Parameters.AddWithValue("@nom", txt_nombre.Text)
            comando.Parameters.AddWithValue("@cat", cbx_categoria.Text)
            comando.Parameters.AddWithValue("@pre", txt_precio.Text)

            ' Abrir --ejecuta la query-- cerrar
            conexion.Open()
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                Registros.GrabarError("Ha ocurrido un error creando el producto. Revise los campos", "Error creando el producto")
            End Try
        Else
            Dim ordensql As String = "UPDATE Producto set cod_producto=@cod, nombre=@nom, categoria=@cat, precio=@precio where cod=@cod"
            Dim comando As New OleDbCommand(ordensql, conexion)
            comando.Parameters.AddWithValue("@cod", txt_codigoProducto.Text)
            comando.Parameters.AddWithValue("@nom", txt_nombre.Text)
            comando.Parameters.AddWithValue("@cat", cbx_categoria.Text)
            comando.Parameters.AddWithValue("@pre", txt_precio.Text)

            ' Abrir --ejecuta la query-- cerrar
            conexion.Open()
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                Registros.GrabarError("Ha ocurrido un error creando el producto. Revise los campos", "Error creando el producto")
            End Try
        End If
    End Sub

End Class