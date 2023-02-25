Imports System.Data.OleDb

Public Class GestionForm
    Public usuarioConectado As String = LoginForm.userConnected
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Public adaptador_tienda As New OleDbDataAdapter("Select * from Producto", conexion)
    Public adaptador_empleados As New OleDbDataAdapter("Select * from Empleado", conexion)
    Public adaptador_proveedores As New OleDbDataAdapter("Select * from Proveedor", conexion)
    Public adaptador_clientes As New OleDbDataAdapter("Select * from ClienteRepsol", conexion)
    Public adaptador_combustibles As New OleDbDataAdapter("Select * from Combustible", conexion)
    Public gestion_dataset As New DataSet
    Public comandoPublic As New OleDbCommand
    Public readerPublic As OleDbDataReader
    Private Sub GestionForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        adaptador_tienda.Fill(gestion_dataset, "Producto")
        adaptador_empleados.Fill(gestion_dataset, "Empleado")
        adaptador_proveedores.Fill(gestion_dataset, "Proveedor")
        adaptador_clientes.Fill(gestion_dataset, "ClienteRepsol")

        dgv_tienda.DataSource = gestion_dataset
        dgv_tienda.DataMember = "Producto"

        dgv_empleados.DataSource = gestion_dataset
        dgv_empleados.DataMember = "Empleado"

        dgv_proveedores.DataSource = gestion_dataset
        dgv_proveedores.DataMember = "Proveedor"

        dgv_clientes.DataSource = gestion_dataset
        dgv_clientes.DataMember = "ClienteRepsol"

        actualizarDataGridView()
    End Sub

    Public Sub actualizarDataGridView()

        gestion_dataset.Tables("Producto").Clear()
        adaptador_tienda.Fill(gestion_dataset, "Producto")

        gestion_dataset.Tables("Empleado").Clear()
        adaptador_empleados.Fill(gestion_dataset, "Empleado")

        gestion_dataset.Tables("Proveedor").Clear()
        adaptador_proveedores.Fill(gestion_dataset, "Proveedor")

        gestion_dataset.Tables("ClienteRepsol").Clear()
        adaptador_clientes.Fill(gestion_dataset, "ClienteRepsol")

        ' No es necesario vaciar los DataMembers de los DataGridView
        ' ya que los DataTables que se asignan están actualizados

    End Sub

    Public Sub actualizarAjusesCombustible()

    End Sub


    ' ** BOTONES SALIR **
    Private Sub pbx_close_Click(sender As Object, e As EventArgs) Handles pbx_close.Click
        Me.Close()
    End Sub

    Private Sub pbx_salir_Click(sender As Object, e As EventArgs) Handles pbx_salir.Click
        MenuPrincipalForm.Show()
        Me.Close()
    End Sub

    ' ** BOTONES CREAR **
    ''' <summary>
    ''' Muestra GestionProductosOnTop.
    ''' </summary>
    ''' <param name="sender">Object: pbx_crearTienda</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_crearTienda_Click(sender As Object, e As EventArgs) Handles pbx_crearTienda.Click
        ' Establecemos la variable booleanCrear de la clase GestionProductosOnTop en True.
        GestionProductosOnTop.booleanCrear = True

        ' Mostramos la ventana GestionProductosOnTop.
        GestionProductosOnTop.ShowDialog()
    End Sub

    ' ** BOTONES BUSCAR **

    ' ** BOTONES EDITAR **
    ''' <summary>
    ''' Muestra un inputbox pidiendo el id del producto a modificar, si el id es válido entonces muestra GestionProductosOnTop.
    ''' </summary>
    ''' <param name="sender">Object: pbx_editarTienda</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_editarTienda_Click(sender As Object, e As EventArgs) Handles pbx_editarTienda.Click
        ' Establecemos la variable booleanCrear de la clase GestionProductosOnTop en False.
        GestionProductosOnTop.booleanCrear = False

        ' Llamamos a la función InputBoxNumeros() de la clase Herramientas para pedir al usuario que introduzca el ID del producto a editar.
        ' Pasamos los parámetros "Editar producto" como título del InputBox y una cadena vacía como valor predeterminado.
        GestionProductosOnTop.productoUpdate = Herramientas.InputBoxNumeros("Introduzca el id del producto a editar", "Editar producto")

        ' Si el usuario no cancela el InputBox (es decir, si el valor devuelto no es una cadena vacía), mostramos la ventana GestionProductosOnTop.
        If Not GestionProductosOnTop.productoUpdate = Nothing Then
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna cod_producto es igual a la variable codigo.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM Producto WHERE cod_producto = " & GestionProductosOnTop.productoUpdate, conexion)
            ' Abrimos la conexión a la base de datos.
            conexion.Open()
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = CInt(consulta.ExecuteScalar())
            ' Cerramos la conexión a la base de datos.
            conexion.Close()
            ' Comprobamos si el resultado es mayor que cero.
            If resultado > 0 Then
                ' La variable codigo existe dentro de la columna cod_producto de la tabla Producto.
                GestionProductosOnTop.ShowDialog()
            Else
                ' La variable codigo no existe dentro de la columna cod_producto de la tabla Producto.
                Registros.GrabarError("El código introducido no existe en la base de datos", "El producto seleccionado no existe")
            End If
        End If
    End Sub
    ' ** BOTONES ELIMINAR **
    Private Sub pbx_eliminartienda_Click(sender As Object, e As EventArgs) Handles pbx_eliminartienda.Click

    End Sub
    ' ** BOTONES CATEGORÍAS **
    Private Sub pbx_combustible_Click(sender As Object, e As EventArgs) Handles pbx_combustible.Click
        ' Selecciona la pestaña "Combustible" (índice 0) en el control TabControl.
        tbc_gestion.SelectTab(0)
    End Sub

    Private Sub pbx_tienda_Click(sender As Object, e As EventArgs) Handles pbx_tienda.Click
        ' Selecciona la pestaña "Tienda" (índice 1) en el control TabControl.
        tbc_gestion.SelectTab(1)
    End Sub

    Private Sub pbx_empleados_Click(sender As Object, e As EventArgs) Handles pbx_empleados.Click
        ' Selecciona la pestaña "Empleados" (índice 2) en el control TabControl.
        tbc_gestion.SelectTab(2)
    End Sub

    Private Sub pbx_proveedores_Click(sender As Object, e As EventArgs) Handles pbx_proveedores.Click
        ' Selecciona la pestaña "Proveedores" (índice 3) en el control TabControl.
        tbc_gestion.SelectTab(3)
    End Sub

    Private Sub pbx_clientes_Click(sender As Object, e As EventArgs) Handles pbx_clientes.Click
        ' Selecciona la pestaña "Clientes" (índice 4) en el control TabControl.
        tbc_gestion.SelectTab(4)
    End Sub


    ' ** GESTION COMBUSTIBLES **
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>


    ' ----
    Public Sub tpg_combustible_Enter(sender As Object, e As EventArgs) Handles tpg_combustible.Enter
        Dim queryCombustible As String = "SELECT * FROM combustible WHERE tipo_combustible = @com"
        comandoPublic = New OleDbCommand(queryCombustible, conexion)
        Dim precioPorLitro As String = readerPublic("precio_por_litro").ToString()
        Dim cantidadLitros As String = readerPublic("cantidad").ToString()
    End Sub

    Private Sub btn_rellenarTanque_Click(sender As Object, e As EventArgs) Handles btn_rellenarTanque.Click

    End Sub

    Private Sub cargarSinPlomo95()
        cbx_tipoCombustible.SelectedIndex = 0
        comandoPublic.Parameters.AddWithValue("@com", "sin_plomo_95")
        conexion.Open()
        readerPublic = comandoPublic.ExecuteReader
        nud_precioCombustible.Value = readerPublic("precio_por_litro").ToString()
        'pgb_restanteDeposito.Value

    End Sub

    Private Sub cargarSinPlomo98()
        cbx_tipoCombustible.SelectedIndex = 1
        comandoPublic.Parameters.AddWithValue("@com", "sin_plomo_98")
        conexion.Open()
        readerPublic = comandoPublic.ExecuteReader
    End Sub

    Private Sub cargarDiesel()
        cbx_tipoCombustible.SelectedIndex = 2
        comandoPublic.Parameters.AddWithValue("@com", "diesel")
        conexion.Open()
        readerPublic = comandoPublic.ExecuteReader
    End Sub

    Private Sub cargarDieselPlus()
        cbx_tipoCombustible.SelectedIndex = 3
        comandoPublic.Parameters.AddWithValue("@com", "diesel_plus")
        conexion.Open()
        readerPublic = comandoPublic.ExecuteReader
    End Sub

    ''' <summary>
    ''' Utilidad para cargar los valores de cada tipo de combustible
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbx_tipoCombustible_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tipoCombustible.SelectedIndexChanged
        If cbx_tipoCombustible.SelectedIndex = 0 Then
            cargarSinPlomo95()
        ElseIf cbx_tipoCombustible.SelectedIndex = 1 Then
            cargarSinPlomo98()
        ElseIf cbx_tipoCombustible.SelectedIndex = 2 Then
            cargarDiesel()
        ElseIf cbx_tipoCombustible.SelectedIndex = 3 Then
            cargarDieselPlus()
        End If
    End Sub

    Private Sub pgb_sinPlomo95_Click(sender As Object, e As EventArgs) Handles pgb_sinPlomo95.Click
        cargarSinPlomo95()
    End Sub

    Private Sub pgb_sinPlomo98_Click(sender As Object, e As EventArgs) Handles pgb_sinPlomo98.Click
        cargarSinPlomo98()
    End Sub

    Private Sub pgb_diesel_Click(sender As Object, e As EventArgs) Handles pgb_diesel.Click
        cargarDiesel()
    End Sub

    Private Sub pgb_dieselPlus_Click(sender As Object, e As EventArgs) Handles pgb_dieselPlus.Click
        cargarDieselPlus()
    End Sub

End Class