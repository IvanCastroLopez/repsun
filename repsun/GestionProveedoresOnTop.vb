Imports System.Data.OleDb
Imports System.Runtime.Remoting.Channels

Public Class GestionProveedoresOnTop
    ' Variable pública que comprueba si quieres actualizar o crear un proveedor
    Public Shared booleanCrear As Boolean

    ' Variable pública que guarda el proveedor a actualizar
    Public Shared empresaUpdate As String


    'Aquí se establece la conexión a la base de datos mediante el proveedor Microsoft.ACE.OLEDB.12.0 y se especifica la ubicación de la base de datos.
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    'Aquí se crea un adaptador de datos OleDbDataAdapter para seleccionar todos los datos de la tabla "proveedor" de la base de datos.
    Public adaptador_tienda As New OleDbDataAdapter("Select * from proveedor", conexion)

    'Aquí se crea un objeto DataSet llamado "gestion_dataset".
    Public gestion_dataset As New DataSet

    'Este sub se ejecuta cuando se carga el formulario GestionProveedoresOnTop.
    Private Sub GestionProveedoresOnTop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.Open()
        'Aquí se llena el DataSet "gestion_dataset" con los datos de la tabla "proveedor".
        adaptador_tienda.Fill(gestion_dataset, "proveedor")
        'Este bloque de código establece el título del formulario según si se está creando un nuevo proveedor o editando uno existente.
        If booleanCrear Then
            lbl_TituloGestionProveedores.Text = "Crear un proveedor"
            txt_nombreProveedorEmpresa.Text = ""
            txt_nombreProveedorRepresentante.Text = ""
            TextBox1.Text = ""
            txt_telefono.Text = ""
            txt_email.Text = ""
        Else
            lbl_TituloGestionProveedores.Text = "Editar un proveedor"

            Dim query As String = "SELECT * FROM proveedor WHERE nombre_emp = @emp"
            Dim comando As New OleDbCommand(query, conexion)
            comando.Parameters.AddWithValue("@emp", empresaUpdate)
            Dim reader As OleDbDataReader = comando.ExecuteReader
            ' Cambio de todos los editText
            If reader.Read Then
                txt_nombreProveedorEmpresa.Text = reader("nombre_emp").ToString
                txt_nombreProveedorRepresentante.Text = reader("nombre").ToString
                TextBox1.Text = reader("apellidos").ToString
                txt_telefono.Text = reader("telefono").ToString
                txt_email.Text = reader("email").ToString
            End If
        End If
    End Sub

    Public Sub GestionProveedoresOnTop_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        empresaUpdate = ""
        conexion.Close()
    End Sub

    'Este sub se ejecuta cuando se hace clic en el botón de acción (pbx_accion).
    Private Sub btn_accion_Click(sender As Object, e As EventArgs) Handles btn_accion.Click

    End Sub

End Class