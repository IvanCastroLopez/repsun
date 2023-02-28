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

    Private productos As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearTLP("Comida")
        CrearTLP("Bebida")
        CrearTLP("Otros")

        ' Configuramos el DataGridView con las columnas de cantidad, código, nombre y precio.
        dgv_carrito.Columns.Add("Cantidad", "Cantidad")
        dgv_carrito.Columns.Add("Codigo", "Código")
        dgv_carrito.Columns.Add("Total", "Total")
        dgv_carrito.Columns.Add("Precio por Litro", "Precio por Litro")

        ' Configuramos las propiedades del DataGridView.
        dgv_carrito.AutoResizeColumns()
        dgv_carrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Configuramos el objeto DataTable carrito.
        carrito.Columns.Add("Cod_cesta", GetType(Integer))
        carrito.Columns.Add("Codigo", GetType(Integer))
        carrito.Columns.Add("Cantidad", GetType(Integer))
        carrito.Columns.Add("Total", GetType(Decimal))
        carrito.Columns.Add("Precio_por_litro", GetType(Decimal))

        ' Configuramos el estilo de las filas del DataGridView.
        dgv_carrito.RowsDefaultCellStyle.BackColor = Color.White
        dgv_carrito.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        ' Configuramos la clave primaria del DataTable carrito.
        carrito.PrimaryKey = New DataColumn() {carrito.Columns("Cod_cesta")}
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


    Private Sub AgregarProducto(codigo As Integer)
        ' Creamos el objeto DataTable productos
        Dim productos As DataTable = gestion_dataset.Tables("Producto")
        ' Establecemos la clave principal en la columna "cod_producto"
        productos.PrimaryKey = New DataColumn() {productos.Columns("cod_producto")}

        Dim cesta As DataTable = gestion_dataset.Tables("CestaCompra")

        ' Buscamos el producto en la tabla
        Dim productoFila As DataRow = productos.Rows.Find(codigo)

        If productoFila IsNot Nothing Then
            ' Si el producto ya existe, incrementamos la cantidad y actualizamos el total
            Dim cantidad As Integer = 0
            Dim precio As Decimal = 0

            Dim cestaFila As DataRow = cesta.Rows.Find(codigo)

            If cestaFila IsNot Nothing Then
                cantidad = cestaFila("cantidad")
                precio = cestaFila("precio_por_litro")
                cestaFila("cantidad") = cantidad + 1
                cestaFila("total") = (cantidad + 1) * precio
            Else
                cantidad = 1
                precio = productoFila("precio")
                Dim newRow As DataRow = cesta.NewRow()
                newRow("cod_producto") = codigo
                newRow("cantidad") = 1
                newRow("precio_por_litro") = precio
                newRow("total") = precio
                cesta.Rows.Add(newRow)
            End If

            ' Buscamos la fila correspondiente en el DataGridView y actualizamos la cantidad y el total
            For Each row As DataGridViewRow In dgv_carrito.Rows
                If row.Cells("codigo").Value = codigo Then
                    row.Cells("cantidad").Value = cantidad
                    row.Cells("total").Value = cantidad * precio
                    Exit Sub
                End If
            Next
        Else
            MessageBox.Show("El código del producto no existe")
        End If
    End Sub
End Class