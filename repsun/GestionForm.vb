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

        Me.dgv_tienda.Font = New Font("Arial", 10, FontStyle.Regular)
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
    Private Sub pbx_crearTienda_Click(sender As Object, e As EventArgs) Handles pbx_crearTienda.Click
        GestionProductosOnTop.booleanCrear = True
        GestionProductosOnTop.ShowDialog()

    End Sub

    Private Sub pbx_editarTienda_Click(sender As Object, e As EventArgs) Handles pbx_editarTienda.Click
        GestionProductosOnTop.booleanCrear = False
        GestionProductosOnTop.productoUpdate = InputBox("Introduzca el codigo del producto a modificar")
        GestionProductosOnTop.ShowDialog()
    End Sub


    ' ** BOTONES BUSCAR **

    ' ** BOTONES EDITAR **

    ' ** BOTONES ELIMINAR **

End Class