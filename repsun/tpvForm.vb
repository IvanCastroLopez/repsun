﻿Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class tpvForm
    ' Aquí se establece la conexión a la base de datos mediante el proveedor Microsoft.ACE.OLEDB.12.0 y se especifica la ubicación de la base de datos.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    'Aquí se crea un adaptador de datos OleDbDataAdapter para seleccionar todos los datos de la tabla "Producto" de la base de datos.
    Public adaptador_tienda As New OleDbDataAdapter("Select * from Producto", conexion)
    Public adaptador_cesta As New OleDbDataAdapter("SELECT * FROM CestaCompra", conexion)

    'Aquí se crea un objeto DataSet llamado "gestion_dataset".
    Public gestion_dataset As New DataSet

    ' Creamos un objeto DataTable para almacenar los productos del carrito.
    Public carrito As New DataTable

    Public cod_cesta As New Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearTLP("Comida")
        CrearTLP("Bebida")
        CrearTLP("Otros")

        adaptador_tienda.Fill(gestion_dataset, "Producto")
        adaptador_cesta.Fill(gestion_dataset, "CestaCompra")

        ' Configuramos el DataGridView con las columnas de cantidad, código, nombre y precio.
        dgv_carrito.Columns.Add("Cantidad", "Cantidad o l")
        dgv_carrito.Columns.Add("Codigo", "Código")
        dgv_carrito.Columns.Add("Total", "Total")
        dgv_carrito.Columns.Add("Precio por Litro", "Precio ud o l")

        ' Configuramos las propiedades del DataGridView.
        dgv_carrito.AutoResizeColumns()
        dgv_carrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Configuramos el objeto DataTable carrito.
        carrito.Columns.Add("Cod_cesta", GetType(Integer))
        carrito.Columns.Add("Cod_producto", GetType(Integer))
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
                                              agregarProducto(codigoItem)
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
        Dim producto As DataRow = Nothing

        ' Crear un comando para obtener el producto por código
        Dim cmd As New OleDbCommand("SELECT * FROM Producto WHERE cod_producto = @codigo", conexion)
        cmd.Parameters.AddWithValue("@codigo", codigo)

        Try
            ' Abrir la conexión y ejecutar el comando
            conexion.Open()
            Dim adaptador As New OleDbDataAdapter(cmd)
            Dim tablaProductos As New DataTable()
            adaptador.Fill(tablaProductos)

            ' Obtener la primera fila de la tabla
            If tablaProductos.Rows.Count > 0 Then
                producto = tablaProductos.Rows(0)
            End If
        Catch ex As Exception
            ' Mostrar un mensaje de error si ocurre una excepción
            MessageBox.Show("Error al obtener el producto: " & ex.Message)
        Finally
            ' Cerrar la conexión
            conexion.Close()
        End Try

        Return producto
    End Function


    Private Sub agregarProducto(codigo As Integer)
        ' Buscar el producto en la base de datos
        Dim producto As DataRow = ObtenerProductoPorCodigo(codigo)

        If producto IsNot Nothing Then
            ' Buscar si el producto ya está en la cesta
            Dim cestaFila As DataRow = carrito.Rows.Find(codigo)

            If cestaFila IsNot Nothing Then
                ' Si el producto ya está en la cesta, actualizar la cantidad, el precio y el total
                cestaFila("cantidad") = CInt(cestaFila("cantidad")) + 1
                cestaFila("total") = CDec(cestaFila("cantidad")) * CDec(cestaFila("precio_por_litro"))
            Else
                ' Si el producto no está en la cesta, añadir una nueva fila
                Dim nuevaFila As DataRow = carrito.NewRow()
                nuevaFila("cod_cesta") = codigo
                nuevaFila("cod_producto") = codigo
                nuevaFila("cantidad") = 1
                nuevaFila("total") = producto("precio")
                nuevaFila("precio_por_litro") = producto("precio")
                carrito.Rows.Add(nuevaFila)
            End If

            ' Actualizar el DataGridView con los datos de la cesta
            dgv_carrito.Rows.Clear()

            For Each filaCesta As DataRow In carrito.Rows
                Dim filaProducto As DataRow = ObtenerProductoPorCodigo(filaCesta("cod_producto"))

                If filaProducto IsNot Nothing Then
                    dgv_carrito.Rows.Add({filaCesta("cantidad"), filaCesta("cod_producto"), filaProducto("nombre"), filaCesta("precio_por_litro")})
                End If
            Next
        Else
            MessageBox.Show("El código del producto no existe.")
        End If

        actualizarCampos(ObtenerTotalCarrito())
    End Sub



    ' ** TOTAL **
    Private Function ObtenerTotalCarrito() As Decimal
        Dim totalCarrito As Decimal = 0

        For Each fila As DataRow In carrito.Rows
            totalCarrito += CDec(fila("cantidad")) * CDec(fila("precio_por_litro"))
        Next

        Return totalCarrito
    End Function

    Private Function actualizarCampos(Total As Decimal)
        Dim impuestos As Decimal = Total * 0.21
        Dim totalSinImpuestos As Decimal = Total - impuestos

        lbl_Total.Text = "Total: " & Math.Round(Total, 2) & "€"
        lbl_impuestos.Text = "Impuestos: " & Math.Round(impuestos, 2) & "€"
        lbl_totalSinImpuestos.Text = "Total sin impuestos: " & Math.Round(totalSinImpuestos, 2) & "€"
    End Function

    Private Sub pbx_sp95_Click(sender As Object, e As EventArgs) Handles pbx_sp95.Click, pbx_sp98.Click, pbx_diesela.Click, pbx_diesela_plus.Click
        If sender.Equals(pbx_sp95) Then
            ' Mostrar el InputBox
            Dim valores As Tuple(Of Decimal, Decimal) = ObtenerValoresDineroCombustible(Herramientas.tipoCombustible.sin_plomo_95)

            If valores IsNot Nothing Then
                Dim dinero As Decimal = valores.Item1
                Dim combustible As String = valores.Item2
            Else

            End If
        ElseIf sender = pbx_sp98 Then
            ' Mostrar el InputBox
            Dim valores As Tuple(Of Decimal, Decimal) = ObtenerValoresDineroCombustible(Herramientas.tipoCombustible.sin_plomo_98)

            If valores IsNot Nothing Then
                Dim dinero As Decimal = valores.Item1
                Dim combustible As String = valores.Item2
            Else

            End If
        ElseIf sender = pbx_diesela Then
            ' Mostrar el InputBox
            Dim valores As Tuple(Of Decimal, Decimal) = ObtenerValoresDineroCombustible(Herramientas.tipoCombustible.diesel)

            If valores IsNot Nothing Then
                Dim dinero As Decimal = valores.Item1
                Dim combustible As String = valores.Item2
            Else

            End If
        ElseIf sender = pbx_diesela_plus Then
            ' Mostrar el InputBox
            Dim valores As Tuple(Of Decimal, Decimal) = ObtenerValoresDineroCombustible(Herramientas.tipoCombustible.diesel_plus)

            If valores IsNot Nothing Then
                Dim dinero As Decimal = valores.Item1
                Dim combustible As String = valores.Item2
            Else

            End If
        End If
    End Sub

    Function ObtenerValoresDineroCombustible(tipoCombustible As Herramientas.tipoCombustible) As Tuple(Of Decimal, Decimal)
        Dim dinero As Decimal
        Dim combustible As Decimal

        Dim inputBoxForm As New Form()
        inputBoxForm.FormBorderStyle = FormBorderStyle.FixedDialog
        inputBoxForm.MaximizeBox = False
        inputBoxForm.MinimizeBox = False
        inputBoxForm.StartPosition = FormStartPosition.CenterScreen
        inputBoxForm.Width = 300
        inputBoxForm.Height = 200

        Dim dineroLabel As New Label()
        dineroLabel.AutoSize = True
        dineroLabel.Text = "Dinero:"
        dineroLabel.Font = New Font(dineroLabel.Font.FontFamily, 12)
        dineroLabel.Location = New Point(20, 20)

        Dim dineroTextBox As New TextBox()
        dineroTextBox.Location = New Point(110, 20)
        dineroTextBox.Width = 150
        dineroTextBox.Font = New Font(dineroTextBox.Font.FontFamily, 12)

        Dim combustibleLabel As New Label()
        combustibleLabel.AutoSize = True
        combustibleLabel.Text = "Combustible:"
        combustibleLabel.Font = New Font(combustibleLabel.Font.FontFamily, 10)
        combustibleLabel.Location = New Point(20, 60)

        Dim combustibleTextBox As New TextBox()
        combustibleTextBox.Location = New Point(110, 60)
        combustibleTextBox.Width = 150
        combustibleTextBox.Font = New Font(combustibleTextBox.Font.FontFamily, 12)

        Dim aceptarButton As New Button()
        aceptarButton.Text = "Aceptar"
        aceptarButton.Font = New Font(aceptarButton.Font.FontFamily, 10)
        aceptarButton.DialogResult = DialogResult.OK
        aceptarButton.Location = New Point(20, 100)

        Dim cancelarButton As New Button()
        cancelarButton.Text = "Cancelar"
        cancelarButton.Font = New Font(cancelarButton.Font.FontFamily, 10)
        cancelarButton.DialogResult = DialogResult.Cancel
        cancelarButton.Location = New Point(180, 100)

        AddHandler aceptarButton.Click, Sub()
                                            If Decimal.TryParse(dineroTextBox.Text, dinero) AndAlso Decimal.TryParse(combustibleTextBox.Text, combustible) Then
                                                inputBoxForm.DialogResult = DialogResult.OK
                                                inputBoxForm.Close()
                                            Else
                                                MessageBox.Show("Los valores introducidos no son válidos.")
                                            End If
                                        End Sub

        AddHandler cancelarButton.Click, Sub()
                                             inputBoxForm.DialogResult = DialogResult.Cancel
                                             inputBoxForm.Close()
                                         End Sub

        AddHandler dineroTextBox.LostFocus, Sub()
                                                If Decimal.TryParse(dineroTextBox.Text, dinero) Then
                                                    combustibleTextBox.Text = Herramientas.CambioPrecioLitros(dineroTextBox.Text, tipoCombustible)
                                                ElseIf dineroTextBox.Text = "" Then

                                                Else
                                                    MessageBox.Show("Los valores introducidos no son válidos.")
                                                End If
                                            End Sub

        AddHandler combustibleTextBox.LostFocus, Sub()
                                                     If Decimal.TryParse(combustibleTextBox.Text, dinero) Then
                                                         dineroTextBox.Text = Herramientas.CambioLitrosPrecio(combustibleTextBox.Text, tipoCombustible)
                                                     ElseIf combustibleTextBox.Text = "" Then

                                                     Else
                                                         MessageBox.Show("Los valores introducidos no son válidos.")
                                                     End If
                                                 End Sub

        inputBoxForm.Controls.Add(dineroLabel)
        inputBoxForm.Controls.Add(dineroTextBox)
        inputBoxForm.Controls.Add(combustibleLabel)
        inputBoxForm.Controls.Add(combustibleTextBox)
        inputBoxForm.Controls.Add(aceptarButton)
        inputBoxForm.Controls.Add(cancelarButton)

        While inputBoxForm.ShowDialog() = DialogResult.OK
            Return Tuple.Create(dinero, combustible)
        End While

        Return Nothing
    End Function


End Class