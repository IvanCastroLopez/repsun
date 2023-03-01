Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Security

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

    Public total As New Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearTLP("Comida")
        CrearTLP("Bebida")
        CrearTLP("Otros")

        adaptador_tienda.Fill(gestion_dataset, "Producto")
        adaptador_cesta.Fill(gestion_dataset, "CestaCompra")

        ' Configuramos el DataGridView con las columnas de cantidad, código, nombre y precio.
        dgv_carrito.Columns.Add("Cantidad", "Cantidad")
        dgv_carrito.Columns.Add("cod_producto", "")
        dgv_carrito.Columns.Add("Nombre", "Nombre")
        dgv_carrito.Columns.Add("Total", "Total")
        dgv_carrito.Columns.Add("Precio por Litro", "Precio ud o l")
        dgv_carrito.Columns.Add("cod_producto", "")
        dgv_carrito.Columns("cod_producto").Visible = False

        dgv_combustible.Columns.Add("Cantidad", "Cantidad")
        dgv_combustible.Columns.Add("Nombre", "Nombre")
        dgv_combustible.Columns.Add("PrecioPorLitro", "Precio/Litro")
        dgv_combustible.Columns.Add("PrecioTotal", "Precio Total")

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

            dgv_carrito.Rows.Clear()


            For Each filaCesta As DataRow In carrito.Rows
                Dim filaProducto As DataRow = ObtenerProductoPorCodigo(filaCesta("cod_producto"))
                If filaProducto IsNot Nothing Then
                    dgv_carrito.Rows.Add({filaCesta("cantidad"), filaProducto("cod_producto"), filaProducto("nombre"), filaCesta("total"), filaCesta("precio_por_litro")})
                End If
            Next

        End If

        actualizarCampos(ObtenerTotalCarrito())
    End Sub



    ' ** TOTAL **
    Private Function ObtenerTotalCarrito() As Decimal
        Dim totalCarrito As Decimal = 0

        For Each fila As DataRow In carrito.Rows
            totalCarrito += CDec(fila("cantidad")) * CDec(fila("precio_por_litro"))
        Next

        totalCarrito += total
        Return totalCarrito
    End Function

    Private Function actualizarCampos(Total As Decimal)
        Dim impuestos As Decimal = Total * 0.21
        Dim totalSinImpuestos As Decimal = Total - impuestos

        lbl_Total.Text = "Total: " & Math.Round(Total, 2) & "€"
        lbl_impuestos.Text = "Impuestos: " & Math.Round(impuestos, 2) & "€"
        lbl_totalSinImpuestos.Text = "Total sin impuestos: " & Math.Round(totalSinImpuestos, 2) & "€"
    End Function

    Dim combustible As Boolean = False
    Private Sub pbx_sp95_Click(sender As Object, e As EventArgs) Handles pbx_sp95.Click, pbx_sp98.Click, pbx_diesela.Click, pbx_diesela_plus.Click
        Dim producto As String = ""
        Dim precio As Decimal = 0
        Dim cantidad As Integer = 0
        Dim preciolitro As Decimal = 0
        If combustible Then
            MsgBox("Ya hay un combustible dentro de la venta")
            Exit Sub
        ElseIf sender.Equals(pbx_sp95) Then
            ' Obtener el precio y la cantidad de combustible
            Dim valores As Tuple(Of Decimal, Decimal) = ObtenerValoresDineroCombustible(Herramientas.tipoCombustible.sin_plomo_95)
            If valores IsNot Nothing Then
                Dim dinero As Decimal = valores.Item1
                Dim combustible As Decimal = valores.Item2
                ' Calcular el precio por litro
                precio = dinero
                preciolitro = dinero / combustible
                producto = "Gasolina sin plomo 95"
                cantidad = Math.Round(combustible, 0)
                combustible = True
            End If
        ElseIf sender.Equals(pbx_sp98) Then
            ' Obtener el precio y la cantidad de combustible
            Dim valores As Tuple(Of Decimal, Decimal) = ObtenerValoresDineroCombustible(Herramientas.tipoCombustible.sin_plomo_98)
            If valores IsNot Nothing Then
                Dim dinero As Decimal = valores.Item1
                Dim combustible As Decimal = valores.Item2
                ' Calcular el precio por litro
                precio = dinero
                preciolitro = dinero / combustible
                producto = "Gasolina sin plomo 98"
                cantidad = Math.Round(combustible, 0)
                combustible = True
            End If
        ElseIf sender.Equals(pbx_diesela) Then
            ' Obtener el precio y la cantidad de combustible
            Dim valores As Tuple(Of Decimal, Decimal) = ObtenerValoresDineroCombustible(Herramientas.tipoCombustible.diesel)
            If valores IsNot Nothing Then
                Dim dinero As Decimal = valores.Item1
                Dim combustible As Decimal = valores.Item2
                ' Calcular el precio por litro
                precio = dinero
                preciolitro = dinero / combustible
                producto = "Diesel A"
                cantidad = Math.Round(combustible, 0)
                combustible = True
            End If
        ElseIf sender.Equals(pbx_diesela_plus) Then
            ' Obtener el precio y la cantidad de combustible
            Dim valores As Tuple(Of Decimal, Decimal) = ObtenerValoresDineroCombustible(Herramientas.tipoCombustible.diesel_plus)
            If valores IsNot Nothing Then
                Dim dinero As Decimal = valores.Item1
                Dim combustible As Decimal = valores.Item2
                ' Calcular el precio por litro
                precio = dinero
                preciolitro = dinero / combustible
                producto = "Diesel A+"
                cantidad = Math.Round(combustible, 0)
                combustible = True
            End If
        End If
        If producto <> "" And precio > 0 Then
            ' Crear una nueva fila con el producto y el precio por litro
            Dim nuevaFila As DataGridViewRow = New DataGridViewRow()
            nuevaFila.CreateCells(dgv_combustible)
            nuevaFila.Cells(0).Value = cantidad
            nuevaFila.Cells(1).Value = producto
            nuevaFila.Cells(2).Value = precio.ToString("C")
            nuevaFila.Cells(3).Value = Math.Round(preciolitro, 4).ToString
            ' Agregar la fila al dgv
            dgv_combustible.Rows.Add(nuevaFila)

            total += precio
        End If

        actualizarCampos(ObtenerTotalCarrito())
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

    ' ** ELIMINAR ** 
    Private Sub btn_eliminarTodo_Click(sender As Object, e As EventArgs) Handles btn_eliminarTodo.Click
        dgv_carrito.Rows.Clear()
        carrito.Clear()
        total = 0
        dgv_combustible.Rows.Clear()

        actualizarCampos(ObtenerTotalCarrito())
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If dgv_carrito.SelectedRows.Count > 0 Then
            ' Obtener la fila seleccionada
            Dim filaSeleccionada As DataGridViewRow = dgv_carrito.SelectedRows(0)

            ' Obtener el código de producto de la fila seleccionada
            Dim codigoProducto As Integer = CInt(filaSeleccionada.Cells("cod_producto").Value)

            ' Eliminar la fila del DataGridView
            dgv_carrito.Rows.Remove(filaSeleccionada)

            ' Eliminar la fila del DataTable
            For Each filaCesta As DataRow In carrito.Rows
                If CInt(filaCesta("cod_producto")) = codigoProducto Then
                    filaCesta.Delete()
                    Exit For
                End If
            Next

            ' Actualizar los totales
            actualizarCampos(ObtenerTotalCarrito())
        Else
            MessageBox.Show("Seleccione una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' ** CAJA **
    ' *** TECLADO VIRTUAL ***
    ' TECLADO NUMÉRICO
    Private Sub btn_teclado_Click(sender As Object, e As EventArgs) Handles btn_0.Click, btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click, btn_coma.Click
        txt_introducido.Text = txt_introducido.Text & sender.text
    End Sub

    ' BOTÓN EXACTO
    Private Sub btn_exacto_Click(sender As Object, e As EventArgs) Handles btn_exacto.Click
        txt_introducido.Text = Math.Round(ObtenerTotalCarrito(), 2)
    End Sub

    ' BOTÓN BORRAR
    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        If txt_introducido.Text <> "" Then
            txt_introducido.Text = txt_introducido.Text.Remove(txt_introducido.Text.Length - 1)
        End If
    End Sub

    ' BOTON SALIR
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MenuPrincipalForm.Show()
        Me.Hide()
    End Sub

    ' BOTON COBRAR
    Private Sub btn_teclado_cobrar_Click(sender As Object, e As EventArgs) Handles btn_teclado_cobrar.Click
        If txt_introducido.Text >= Math.Round(ObtenerTotalCarrito(), 2) Then
            Dim resultado As DialogResult = MessageBox.Show("¿Va a pagar con tarjeta?", "Opciones de Pago", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                ' Acción para el botón "Tarjeta"
                MsgBox("Pago con tarjeta seleccionado.")
            ElseIf resultado = DialogResult.No Then
                ' Acción para el botón "Efectivo"
                MsgBox("Pago en efectivo seleccionado.")
            ElseIf resultado = DialogResult.Cancel Then
                ' Acción para el botón "Cancelar"
                MsgBox("Pago cancelado.")
            End If
        Else
            Registros.GrabarError("Dinero insuficiente", "No cobrar")
        End If
    End Sub

End Class