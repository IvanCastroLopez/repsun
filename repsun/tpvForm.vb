Imports System.Data.OleDb

Public Class tpvForm
    ' Aquí se establece la conexión a la base de datos mediante el proveedor Microsoft.ACE.OLEDB.12.0 y se especifica la ubicación de la base de datos.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    'Aquí se crea un adaptador de datos OleDbDataAdapter para seleccionar todos los datos de la tabla "Producto" de la base de datos.
    Public adaptador_tienda As New OleDbDataAdapter("Select * from Producto", conexion)

    'Aquí se crea un objeto DataSet llamado "gestion_dataset".
    Public gestion_dataset As New DataSet

    ' Creamos un objeto DataTable para almacenar los productos del carrito.
    Public carrito As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearTLP("Comida")
        CrearTLP("Bebida")
        CrearTLP("Otros")

        ' Configuramos el DataGridView con las columnas de cantidad, código, nombre y precio.
        dgv_carrito.Columns.Add("Cantidad", "Cantidad")
        dgv_carrito.Columns.Add("Codigo", "Código")
        dgv_carrito.Columns.Add("Nombre", "Nombre")
        dgv_carrito.Columns.Add("Precio", "Precio")

        ' Configuramos las propiedades del DataGridView.
        dgv_carrito.AutoResizeColumns()
        dgv_carrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Configuramos el objeto DataTable carrito.
        carrito.Columns.Add("Codigo", GetType(Integer))
        carrito.Columns.Add("Nombre", GetType(String))
        carrito.Columns.Add("Precio", GetType(Decimal))
        carrito.Columns.Add("Cantidad", GetType(Integer))
        carrito.PrimaryKey = New DataColumn() {carrito.Columns("Codigo")}

        ' Configuramos el estilo de las filas del DataGridView.
        dgv_carrito.RowsDefaultCellStyle.BackColor = Color.White
        dgv_carrito.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
    End Sub


    Private Sub CrearTLP(Categoria As String)
        Try
            'Limpiar el DataSet y establecer la consulta SQL para seleccionar solo los productos de la categoría especificada
            gestion_dataset.Tables.Clear()

            adaptador_tienda.SelectCommand.CommandText = "SELECT * FROM Producto WHERE Categoria = @categoria"
            adaptador_tienda.SelectCommand.Parameters.Clear()
            adaptador_tienda.SelectCommand.Parameters.AddWithValue("@categoria", Categoria)

            'Llenar el DataSet con los productos de la categoría especificada
            adaptador_tienda.Fill(gestion_dataset, "Producto")

            'Contar el número de productos en la categoría especificada
            Dim numProductos As Integer = gestion_dataset.Tables("Producto").Rows.Count

            Dim numRows As Integer = Math.Ceiling(numProductos / 5)

            Dim nombre As String = "tlp_" & Categoria

            ' Buscar el control con el nombre especificado
            Dim controlTLP() As Control = Me.Controls.Find(nombre, True)

            Dim tlp As TableLayoutPanel

            ' Verificar si se encontró el control y si es un TableLayoutPanel
            If controlTLP IsNot Nothing AndAlso controlTLP.Length > 0 AndAlso TypeOf controlTLP(0) Is TableLayoutPanel Then
                ' Almacenar el control encontrado en una variable del tipo TableLayoutPanel
                tlp = CType(controlTLP(0), TableLayoutPanel)

                ' Ahora puedes hacer referencia a tlpComida para realizar cualquier operación
                ' Por ejemplo, modificar alguna propiedad del TableLayoutPanel
                tlp.RowStyles.Clear()
            End If

            ' Borramos todas las filas del tlp_comida
            tlp.RowStyles.Clear()

            ' Creamos un estilo de fila con una altura fija para que todas las filas sean iguales

            Dim productos As DataTable = gestion_dataset.Tables("Producto")


            For row As Integer = 0 To numRows - 1

                Dim rowStyle As New RowStyle(SizeType.Percent, 100 / numRows)
                tlp.RowStyles.Add(rowStyle)

                For col As Integer = 0 To 4
                    Dim index As Integer = row * 5 + col

                    If index >= numProductos Then
                        Exit For
                    End If

                    Dim codigoItem As Integer = productos.Rows(index)("cod_producto")
                    Dim nombreItem As String = productos.Rows(index)("nombre").ToString()
                    Dim precioItem As Decimal = productos.Rows(index)("precio")

                    Dim btn As New Button()
                    btn.Text = nombreItem & vbCrLf & FormatCurrency(precioItem)
                    btn.Dock = DockStyle.Fill
                    AddHandler btn.Click, Sub(sender As Object, e As EventArgs)
                                              AgregarProducto(codigoItem)
                                          End Sub
                    tlp.Controls.Add(btn, col, row)
                Next
            Next
        Catch ex As Exception
            Registros.GrabarError("Ha ocurrido un error creando las tablas. Llame al técnico responsable del sistema", "Error creando tablas")
        End Try


    End Sub






    ' ** CARRITO DE COMPRA **
    Private Function ObtenerProductoPorCodigo(codigo As Integer) As DataRow
        Dim productos As DataTable = gestion_dataset.Tables("Producto")
        Dim producto As DataRow = Nothing

        For Each row As DataRow In productos.Rows
            If row("cod_producto") = codigo Then
                producto = row
                Exit For
            End If
        Next

        Return producto
    End Function

    Private Sub AgregarProducto(codigo As Integer)
        Dim productos As DataTable = gestion_dataset.Tables("Producto")

        ' Buscamos el producto en la tabla
        Dim productoFila As DataRow = productos.Rows.Find(codigo)

        If productoFila IsNot Nothing Then
            ' Si el producto ya existe, incrementamos la cantidad
            Dim cantidad As Integer = productoFila("cantidad")
            productoFila("cantidad") = cantidad + 1

            ' Buscamos la fila correspondiente en el DataGridView y actualizamos la cantidad
            For Each row As DataGridViewRow In dgv_carrito.Rows
                If row.Cells("codigo").Value = codigo Then
                    row.Cells("cantidad").Value = cantidad + 1
                    Exit Sub
                End If
            Next
        Else
            ' Si el producto no existe, lo añadimos a la tabla
            productoFila = productos.NewRow()
            productoFila("cod_producto") = codigo
            productoFila("cantidad") = 1

            Dim productoInfo As DataRow = ObtenerProductoPorCodigo(codigo)

            If productoInfo IsNot Nothing Then
                productoFila("nombre") = productoInfo("nombre").ToString()
                productoFila("precio") = productoInfo("precio")
            End If

            productos.Rows.Add(productoFila)

            ' Añadimos una nueva fila al DataGridView
            Dim newRow As Integer = dgv_carrito.Rows.Add()
            dgv_carrito.Rows(newRow).Cells("cantidad").Value = 1
            dgv_carrito.Rows(newRow).Cells("codigo").Value = codigo
            dgv_carrito.Rows(newRow).Cells("nombre").Value = productoFila("nombre")
            dgv_carrito.Rows(newRow).Cells("precio").Value = productoFila("precio")
        End If
    End Sub
End Class