Imports System.Data.OleDb

Public Class GestionForm
    Public usuarioConectado As String = LoginForm.userConnected
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Public adaptador_tienda As New OleDbDataAdapter("Select * from Producto", conexion)
    Public adaptador_empleados As New OleDbDataAdapter("Select * from Empleado", conexion)
    Public adaptador_proveedores As New OleDbDataAdapter("Select * from Proveedor", conexion)
    Public adaptador_clientes As New OleDbDataAdapter("Select * from ClienteRepsol", conexion)
    Public gestion_dataset As New DataSet
    Private Sub GestionForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        adaptador_tienda.Fill(gestion_dataset, "Producto")
        adaptador_empleados.Fill(gestion_dataset, "Empleado")
        adaptador_proveedores.Fill(gestion_dataset, "Proveedor")
        adaptador_clientes.Fill(gestion_dataset, "ClienteRepsol")

        dgv_tienda.DataSource = gestion_dataset
        dgv_tienda.DataMember = "Producto"

        Me.dgv_empleados.Font = New Font("Arial", 10, FontStyle.Regular)
        dgv_empleados.DataSource = gestion_dataset
        dgv_empleados.DataMember = "Empleado"

        Me.dgv_proveedores.Font = New Font("Arial", 10, FontStyle.Regular)
        dgv_proveedores.DataSource = gestion_dataset
        dgv_proveedores.DataMember = "Proveedor"

        Me.dgv_clientes.Font = New Font("Arial", 10, FontStyle.Regular)
        dgv_clientes.DataSource = gestion_dataset
        dgv_clientes.DataMember = "ClienteRepsol"
    End Sub

    ' ** BOTONES SALIR **
    Private Sub pbx_close_Click(sender As Object, e As EventArgs) Handles pbx_close.Click
        Me.Close()
    End Sub

    Private Sub pbx_salir_Click(sender As Object, e As EventArgs) Handles pbx_salir.Click
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
        If Not GestionProductosOnTop.productoUpdate = "" Then
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

End Class