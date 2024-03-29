﻿Imports System.Data.OleDb

Public Class GestionForm
    Public usuarioConectado As String = LoginForm.userConnected
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Public adaptador_tienda As New OleDbDataAdapter("Select cod_producto, nombre, categoria, precio from Producto", conexion)
    Public adaptador_empleados As New OleDbDataAdapter("Select * from Empleado", conexion)
    Public adaptador_usuarios As New OleDbDataAdapter("Select * from Usuarios", conexion)
    Public relacion As New OleDbDataAdapter("Select empleado.cod_empleado, nombre, apellidos, dni, email, telefono, rol, nombre_usuario, contrasena, admin from Empleado, Usuarios where empleado.cod_empleado = usuarios.cod_empleado", conexion)
    Public adaptador_proveedores As New OleDbDataAdapter("Select * from Proveedor", conexion)
    Public adaptador_clientes As New OleDbDataAdapter("Select * from ClienteRepsol", conexion)
    Public adaptador_combustibles As New OleDbDataAdapter("Select * from Combustible", conexion)
    Public gestion_dataset As New DataSet
    Public comandoPublic As New OleDbCommand

    Public precio_SinPlomo95, precio_SinPLomo98, precio_Diesel, precio_DieselPlus As Decimal
    Public cantidad_SinPlomo95, cantidad_SinPLomo98, cantidad_Diesel, cantidad_DieselPlus As Decimal
    Private Sub GestionForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        adaptador_tienda.Fill(gestion_dataset, "Producto")
        adaptador_empleados.Fill(gestion_dataset, "Empleados")
        adaptador_usuarios.Fill(gestion_dataset, "Usuarios")
        relacion.Fill(gestion_dataset, "relacion")

        gestion_dataset.Relations.Add("relacion", gestion_dataset.Tables("Empleados").Columns("cod_empleado"), gestion_dataset.Tables("Usuarios").Columns("cod_empleado"))

        adaptador_proveedores.Fill(gestion_dataset, "Proveedor")
        adaptador_clientes.Fill(gestion_dataset, "ClienteRepsol")

        dgv_tienda.DataSource = gestion_dataset
        dgv_tienda.DataMember = "Producto"

        dgv_empleados.DataSource = gestion_dataset
        dgv_empleados.DataMember = "relacion"


        dgv_proveedores.DataSource = gestion_dataset
        dgv_proveedores.DataMember = "Proveedor"

        dgv_clientes.DataSource = gestion_dataset
        dgv_clientes.DataMember = "ClienteRepsol"

        'Actualizar el DataGridView, suponiendo que existe un método llamado actualizarDataGridView.
        'actualizarDataGridView()
        cargarDatosCombustible()

    End Sub

    Public Sub actualizarAjusesCombustible()

    End Sub

    ' ** BOTONES SALIR **
    Private Sub pbx_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub pbx_salir_Click(sender As Object, e As EventArgs) Handles pbx_salir.Click
        MenuPrincipalForm.Show()
        Me.Close()
    End Sub

    ' ** GESTIÓN TIENDA **
    Private Sub txt_buscarTienda_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarTienda.TextChanged
        Dim comando As New OleDbCommand(("Select * from Producto where nombre LIKE '%" & txt_buscarTienda.Text & "%'"), conexion)
        adaptador_tienda.SelectCommand = comando
        gestion_dataset.Tables("producto").Clear()
        adaptador_tienda.Fill(gestion_dataset, "Producto")
        dgv_tienda.DataSource = gestion_dataset
    End Sub

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

        ' Las siguientes líneas de código se ejecutarán después de que se cierre el formulario GestionProductosOnTop.
        gestion_dataset.Tables("Producto").Clear()
        adaptador_tienda.Fill(gestion_dataset, "Producto")
    End Sub

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


                ' Las siguientes líneas de código se ejecutarán después de que se cierre el formulario GestionProductosOnTop.
                gestion_dataset.Tables("Producto").Clear()
                adaptador_tienda.Fill(gestion_dataset, "Producto")
            Else
                ' La variable codigo no existe dentro de la columna cod_producto de la tabla Producto.
                Registros.GrabarError("El código introducido no existe en la base de datos", "El producto seleccionado no existe")
            End If
        End If
    End Sub


    ''' <summary>
    ''' Muestra un inputbox pidiendo el id del producto a eliminar, si el id es válido entonces lo elimina.
    ''' </summary>
    ''' <param name="sender">Object: pbx_aliminarTienda</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_eliminartienda_Click(sender As Object, e As EventArgs) Handles pbx_eliminartienda.Click
        ' Pedimos al usuario que introduzca el ID del producto a eliminar utilizando la función InputBoxNumeros() de la clase Herramientas.
        Dim productoDelete As Integer = Herramientas.InputBoxNumeros("Introduzca el id del producto a eliminar", "Eliminar producto")

        ' Creamos un comando que selecciona el número de filas donde la columna cod_producto es igual a la variable productoDelete.
        Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM Producto WHERE cod_producto = @cod_producto", conexion)
        ' Especificamos el valor del parámetro @cod_producto utilizando AddWithValue().
        consulta.Parameters.AddWithValue("@cod_producto", productoDelete)
        ' Abrimos la conexión a la base de datos.
        conexion.Open()
        ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
        Dim resultado As Integer = CInt(consulta.ExecuteScalar())
        ' Cerramos la conexión a la base de datos.
        conexion.Close()

        ' Comprobamos si el resultado es mayor que cero.
        If resultado > 0 Then
            ' Preguntamos al usuario si realmente desea eliminar el producto utilizando la función InputBoxSiNo() de la clase Herramientas.
            If Herramientas.InputBoxSiNo("¿Quiere eliminar el producto " & productoDelete & "?", "Eliminar") Then
                ' Creamos un comando para eliminar el producto.
                Dim ordensql As String = "DELETE FROM Producto WHERE cod_producto = @cod_producto"
                Dim comando As New OleDbCommand(ordensql, conexion)
                ' Especificamos el valor del parámetro @cod_producto utilizando AddWithValue().
                comando.Parameters.AddWithValue("@cod_producto", productoDelete)
                conexion.Open()
                Try
                    ' Ejecutamos el comando para eliminar el producto.
                    comando.ExecuteNonQuery()
                    ' Actualizamos el DataGridView después de eliminar el producto.

                    gestion_dataset.Tables("Producto").Clear()
                    adaptador_tienda.Fill(gestion_dataset, "Producto")
                Catch ex As Exception
                    ' Si se produce un error, mostramos un mensaje de error.
                    Registros.GrabarError("Ha ocurrido un error eliminando el producto seleccionado", "Error eliminando producto")
                Finally
                    ' Cerramos la conexión a la base de datos.
                    conexion.Close()
                End Try
            End If
        Else
            ' Si el producto no existe en la base de datos, mostramos un mensaje de error utilizando la función GrabarError() de la clase Registros.
            Registros.GrabarError("El código introducido no existe en la base de datos", "El producto seleccionado no existe")
        End If
    End Sub


    ' ** GESTIÓN EMPLEADOS **
    ''' <summary>
    ''' Al cambiar el texto actualiza el dataGridView con los datos que coincidan
    ''' </summary>
    ''' <param name="sender">Object: txt_buscarEmpleado</param>
    ''' <param name="e">EventArgs: TextChanged</param>


    Private Sub txt_buscarEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarEmpleado.TextChanged
        Dim comandoSQL As String = "SELECT empleado.cod_empleado, nombre, apellidos, dni, email, telefono, rol, nombre_usuario, contrasena, admin FROM Empleado INNER JOIN Usuarios ON empleado.cod_empleado = usuarios.cod_empleado WHERE nombre LIKE '%" & txt_buscarEmpleado.Text & "%' OR apellidos LIKE '%" & txt_buscarEmpleado.Text & "%'"
        Dim adapter As New OleDbDataAdapter(comandoSQL, conexion)
        Dim ds As New DataSet()
        adapter.Fill(ds, "Empleado_Usuarios")
        dgv_empleados.DataSource = ds
        dgv_empleados.DataMember = "Empleado_Usuarios"
    End Sub



    ''' <summary>
    ''' Muestra GestionEmpleadosOnTop en modo crear.
    ''' </summary>
    ''' <param name="sender">Object: pbx_crearEmpleado</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_crearEmpleado_Click(sender As Object, e As EventArgs) Handles pbx_crearEmpleado.Click
        ' Establecemos la variable booleanCrear de la clase GestionEmpleadosOnTop en True.
        GestionEmpleadosOnTop.booleanCrear = True
        ' Mostramos la ventana GestionEmpleadosOnTop.
        GestionEmpleadosOnTop.ShowDialog()

        gestion_dataset.Tables("relacion").Clear()
        adaptador_empleados.Fill(gestion_dataset, "relacion")
        dgv_empleados.DataSource = gestion_dataset


    End Sub

    ''' <summary>
    ''' Muestra un inputbox pidiendo el código del empleado a modificar, si el código es válido entonces muestra GestionEmpleadosOnTop en modo editar.
    ''' </summary>
    ''' <param name="sender">Object: pbx_editarEmpleado</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_editarEmpleados_Click(sender As Object, e As EventArgs) Handles pbx_editarEmpleados.Click
        ' Establecemos la variable booleanCrear de la clase GestionEmpleadosOnTop en False.
        GestionEmpleadosOnTop.booleanCrear = False

        ' Llamamos a la función InputBoxNumeros() de la clase Herramientas para pedir al usuario que introduzca el ID del empleado a editar.
        ' Pasamos los parámetros "Editar empleado" como título del InputBox y una cadena vacía como valor predeterminado.
        GestionEmpleadosOnTop.empleadoUpdate = Herramientas.InputBoxNumeros("Introduzca el id del empleado a editar", "Editar empleado")

        ' Si el usuario no cancela el InputBox (es decir, si el valor devuelto no es una cadena vacía), mostramos la ventana GestionEmpleadosOnTop.
        If Not GestionEmpleadosOnTop.empleadoUpdate = Nothing Then
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna cod_empleado es igual a la variable empleadoUpdate.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM Empleado WHERE cod_empleado = " & GestionEmpleadosOnTop.empleadoUpdate, conexion)
            ' Abrimos la conexión a la base de datos.
            conexion.Open()
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = CInt(consulta.ExecuteScalar())
            ' Cerramos la conexión a la base de datos.
            conexion.Close()
            ' Comprobamos si el resultado es mayor que cero.
            If resultado > 0 Then
                ' La variable empleadoUpdate existe dentro de la columna cod_empleado de la tabla Empleado.
                GestionEmpleadosOnTop.ShowDialog()
                gestion_dataset.Tables("relacion").Clear()
                adaptador_empleados.Fill(gestion_dataset, "relacion")
            Else
                ' La variable empleadoUpdate no existe dentro de la columna cod_empleado de la tabla Empleado.
                Registros.GrabarError("El código introducido no existe en la base de datos", "El empleado seleccionado no existe")
            End If
        End If
    End Sub

    ''' <summary>
    ''' Muestra un inputbox pidiendo el id del empleado a eliminar, si el id es válido entonces lo elimina.
    ''' </summary>
    ''' <param name="sender">Object: pbx_eliminarEmpleados</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_eliminarEmpleados_Click(sender As Object, e As EventArgs) Handles pbx_eliminarEmpleados.Click
        ' Pedimos al usuario que introduzca el ID del empleado a eliminar utilizando la función InputBoxNumeros() de la clase Herramientas.
        Dim empleadoDelete As Integer = Herramientas.InputBoxNumeros("Introduzca el id del empleado a eliminar", "Eliminar empleado")

        ' Creamos un comando que selecciona el número de filas donde la columna cod_empleado es igual a la variable empleadoDelete.
        Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM empleado WHERE cod_empleado = @cod_empleado", conexion)
        ' Especificamos el valor del parámetro @cod_empleado utilizando AddWithValue().
        consulta.Parameters.AddWithValue("@cod_empleado", empleadoDelete)
        ' Abrimos la conexión a la base de datos.
        conexion.Open()
        ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
        Dim resultado As Integer = CInt(consulta.ExecuteScalar())
        ' Cerramos la conexión a la base de datos.
        conexion.Close()

        ' Comprobamos si el resultado es mayor que cero.
        If resultado > 0 Then
            ' Preguntamos al usuario si realmente desea eliminar el empleado utilizando la función InputBoxSiNo() de la clase Herramientas.
            If Herramientas.InputBoxSiNo("¿Quiere eliminar el empleado " & empleadoDelete & "?", "Eliminar") Then
                If Not empleadoDelete = 0 Then
                    ' Creamos un comando para eliminar el usuario del empleado.
                    Dim ordensql1 As String = "DELETE FROM usuarios WHERE cod_empleado = @cod_empleado"
                    Dim comando1 As New OleDbCommand(ordensql1, conexion)
                    ' Creamos un comando para eliminar el empleado.
                    Dim ordensql As String = "DELETE FROM empleado WHERE cod_empleado = @cod_empleado"
                    Dim comando As New OleDbCommand(ordensql, conexion)
                    ' Especificamos el valor del parámetro @cod_empleado utilizando AddWithValue().
                    comando1.Parameters.AddWithValue("@cod_empleado", empleadoDelete)
                    comando.Parameters.AddWithValue("@cod_empleado", empleadoDelete)
                    conexion.Open()
                    Try
                        ' Ejecutamos los comandos para eliminar el empleado.
                        comando1.ExecuteNonQuery()
                        comando.ExecuteNonQuery()
                        ' Actualizamos el DataGridView después de eliminar el empleado.

                        gestion_dataset.Tables("relacion").Clear()
                        adaptador_empleados.Fill(gestion_dataset, "relacion")
                    Catch ex As Exception
                        ' Si se produce un error, mostramos un mensaje de error.
                        Registros.GrabarError("Ha ocurrido un error eliminando el empleado seleccionado", "Error eliminando empleado")
                    Finally
                        ' Cerramos la conexión a la base de datos.
                        conexion.Close()
                    End Try
                Else
                    Registros.GrabarError("Intento de eliminar el administrador", "Error eliminando")
                End If
            End If
        Else
            ' Si el empleado no existe en la base de datos, mostramos un mensaje de error utilizando la función GrabarError() de la clase Registros.
            Registros.GrabarError("El código introducido no existe en la base de datos", "El empleado seleccionado no existe")
        End If
    End Sub

    ' ** GESTIÓN PROVEEDORES **
    ''' <summary>
    ''' Al cambiar el texto actualiza el dataGridView con los datos que coincidan
    ''' </summary>
    ''' <param name="sender">Object: txt_buscarProveedores</param>
    ''' <param name="e">EventArgs: TextChanged</param>
    Private Sub txt_buscarproveedores_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarProveedores.TextChanged
        Dim vista As New DataView(gestion_dataset.Tables("proveedor"))
        vista.RowFilter = "nombre_emp LIKE '%" & txt_buscarProveedores.Text & "%'"
        dgv_proveedores.DataSource = vista
    End Sub



    ''' <summary>
    ''' Muestra GestionProveedoresOnTop.
    ''' </summary>
    ''' <param name="sender">Object: pbx_crearproveedores</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_crearProveedor_Click(sender As Object, e As EventArgs) Handles pbx_crearProveedor.Click
        ' Establecemos la variable booleanCrear de la clase GestionProveedoresOnTop en True.
        GestionProveedoresOnTop.booleanCrear = True

        ' Mostramos la ventana GestionProveedoresOnTop.     
        GestionProveedoresOnTop.ShowDialog()
        gestion_dataset.Tables("Proveedor").Clear()
        adaptador_proveedores.Fill(gestion_dataset, "Proveedor")
    End Sub

    ''' <summary>
    ''' Muestra un inputbox pidiendo el id del proveedor a modificar, si el id es válido entonces muestra GestionProveedoresOnTop.
    ''' </summary>
    ''' <param name="sender">Object: pbx_editarproveedores</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_editarproveedores_Click(sender As Object, e As EventArgs) Handles pbx_editarProveedor.Click
        ' Establecemos la variable booleanCrear de la clase GestionProveedoresOnTop en False.
        GestionProveedoresOnTop.booleanCrear = False

        ' Llamamos a la función InputBoxNumeros() de la clase Herramientas para pedir al usuario que introduzca el ID del proveedor a editar.
        ' Pasamos los parámetros "Editar proveedor" como título del InputBox y una cadena vacía como valor predeterminado.
        GestionProveedoresOnTop.empresaUpdate = InputBox("Introduzca la empresa a modificar", "Modificar proveedor")

        ' Si el usuario no cancela el InputBox (es decir, si el valor devuelto no es una cadena vacía), mostramos la ventana GestionProveedoresOnTop.
        If Not GestionProveedoresOnTop.empresaUpdate = "" Then
            ' Creamos un comando que selecciona el número de filas donde la columna nombre_emp es igual a la variable codigo.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM proveedor WHERE nombre_emp = " & GestionProveedoresOnTop.empresaUpdate, conexion)
            ' Abrimos la conexión a la base de datos.
            conexion.Open()
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            Dim resultado As Integer = 1
            ' Cerramos la conexión a la base de datos.
            conexion.Close()
            ' Comprobamos si el resultado es mayor que cero.
            If resultado > 0 Then
                ' La variable codigo existe dentro de la columna nombre_emp de la tabla proveedor.
                GestionProveedoresOnTop.ShowDialog()
                gestion_dataset.Tables("Proveedor").Clear()
                adaptador_proveedores.Fill(gestion_dataset, "Proveedor")
            Else
                ' La variable codigo no existe dentro de la columna nombre_emp de la tabla proveedor.
                Registros.GrabarError("El código introducido no existe en la base de datos", "El proveedor seleccionado no existe")
            End If
        End If
    End Sub


    ''' <summary>
    ''' Muestra un inputbox pidiendo el id del proveedor a eliminar, si el id es válido entonces lo elimina.
    ''' </summary>
    ''' <param name="sender">Object: pbx_aliminarproveedores</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_eliminarproveedores_Click(sender As Object, e As EventArgs) Handles pbx_eliminarProveedor.Click
        ' Pedimos al usuario que introduzca el ID del proveedor a eliminar utilizando la función InputBoxNumeros() de la clase Herramientas.
        Dim proveedorDelete As String = InputBox("Introduzca la empresa a eliminar", "Eliminar proveedor")

        ' Creamos un comando que selecciona el número de filas donde la columna nombre_emp es igual a la variable proveedorDelete.
        Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM proveedor WHERE nombre_emp = @nombre_emp", conexion)
        ' Especificamos el valor del parámetro @nombre_emp utilizando AddWithValue().
        consulta.Parameters.AddWithValue("@nombre_emp", proveedorDelete)
        ' Abrimos la conexión a la base de datos.
        conexion.Open()
        ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
        Dim resultado As Integer = CInt(consulta.ExecuteScalar())
        ' Cerramos la conexión a la base de datos.
        conexion.Close()

        ' Comprobamos si el resultado es mayor que cero.
        If resultado > 0 Then
            ' Preguntamos al usuario si realmente desea eliminar el proveedor utilizando la función InputBoxSiNo() de la clase Herramientas.
            If Herramientas.InputBoxSiNo("¿Quiere eliminar el proveedor " & proveedorDelete & "?", "Eliminar") Then
                ' Creamos un comando para eliminar el proveedor.
                Dim ordensql As String = "DELETE FROM proveedor WHERE nombre_emp = @nombre_emp"
                Dim comando As New OleDbCommand(ordensql, conexion)
                ' Especificamos el valor del parámetro @nombre_emp utilizando AddWithValue().
                comando.Parameters.AddWithValue("@nombre_emp", proveedorDelete)
                conexion.Open()
                Try
                    ' Ejecutamos el comando para eliminar el proveedor.
                    comando.ExecuteNonQuery()
                    ' Actualizamos el DataGridView después de eliminar el proveedor.
                    gestion_dataset.Tables("Proveedor").Clear()
                    adaptador_proveedores.Fill(gestion_dataset, "Proveedor")
                Catch ex As Exception
                    ' Si se produce un error, mostramos un mensaje de error.
                    Registros.GrabarError("Ha ocurrido un error eliminando el proveedor seleccionado", "Error eliminando proveedor")
                Finally
                    ' Cerramos la conexión a la base de datos.
                    conexion.Close()
                End Try
            End If
        Else
            ' Si el proveedor no existe en la base de datos, mostramos un mensaje de error utilizando la función GrabarError() de la clase Registros.
            Registros.GrabarError("La empresa introducida no existe en la base de datos", "El proveedor seleccionado no existe")
        End If
    End Sub











    ' ** GESTION CLIENTES **
    ''' <summary>
    ''' Al cambiar el texto actualiza el dataGridView con los datos que coincidan
    ''' </summary>
    ''' <param name="sender">Object: txt_buscarCliente</param>
    ''' <param name="e">EventArgs: TextChanged</param>
    Private Sub txt_buscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarCliente.TextChanged
        Dim vista As New DataView(gestion_dataset.Tables("clienteRepsol"))
        vista.RowFilter = "nombre LIKE '%" & txt_buscarCliente.Text & "%'"
        dgv_clientes.DataSource = vista
    End Sub

    ''' <summary>
    ''' Muestra ClientesOnTop en modo crear.
    ''' </summary>
    ''' <param name="sender">Object: pbx_crearEmpleado</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_crearCliente_Click(sender As Object, e As EventArgs) Handles pbx_crearCliente.Click
        ' Establecemos la variable booleanCrear de la clase GestionEmpleadosOnTop en True.
        ClientesOnTop.booleanCrear = True
        ' Mostramos la ventana GestionEmpleadosOnTop.
        ClientesOnTop.ShowDialog()
        gestion_dataset.Tables("ClienteRepsol").Clear()
        adaptador_clientes.Fill(gestion_dataset, "ClienteRepsol")
    End Sub

    ''' <summary>
    ''' Muestra un inputbox pidiendo el código del cliente a modificar, si el código es válido entonces muestra ClientesOnTop en modo editar.
    ''' </summary>
    ''' <param name="sender">Object: pbx_editarcliente</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_editarCliente_Click(sender As Object, e As EventArgs) Handles pbx_editarCliente.Click
        ' Establecemos la variable booleanCrear de la clase ClientesOnTop en False.
        ClientesOnTop.booleanCrear = False

        ' Llamamos a la función InputBoxNumeros() de la clase Herramientas para pedir al usuario que introduzca el ID del cliente a editar.
        ' Pasamos los parámetros "Editar cliente" como título del InputBox y una cadena vacía como valor predeterminado.
        ClientesOnTop.clienteUpdate = Herramientas.InputBoxNumeros("Introduzca el id del cliente a editar", "Editar cliente")

        ' Si el usuario no cancela el InputBox (es decir, si el valor devuelto no es una cadena vacía), mostramos la ventana ClientesOnTop.
        If Not ClientesOnTop.clienteUpdate = Nothing Then
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer = 1
            ' Creamos un comando que selecciona el número de filas donde la columna cod_cliente es igual a la variable clienteUpdate.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM cliente WHERE cod_cliente = " & ClientesOnTop.clienteUpdate, conexion)
            ' Abrimos la conexión a la base de datos.
            conexion.Open()
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            'resultado = CInt(consulta.ExecuteScalar())
            ' Cerramos la conexión a la base de datos.
            conexion.Close()
            ' Comprobamos si el resultado es mayor que cero.
            If resultado > 0 Then
                ' La variable clienteUpdate existe dentro de la columna cod_cliente de la tabla cliente.
                ClientesOnTop.ShowDialog()
                gestion_dataset.Tables("ClienteRepsol").Clear()
                adaptador_clientes.Fill(gestion_dataset, "ClienteRepsol")
            Else
                ' La variable clienteUpdate no existe dentro de la columna cod_cliente de la tabla cliente.
                Registros.GrabarError("El código introducido no existe en la base de datos", "El cliente seleccionado no existe")
            End If
        End If
    End Sub

    ''' <summary>
    ''' Muestra un inputbox pidiendo el id del cliente a eliminar, si el id es válido entonces lo elimina.
    ''' </summary>
    ''' <param name="sender">Object: pbx_eliminarCliente</param>
    ''' <param name="e">EventArgs: Click</param>
    Private Sub pbx_eliminarCliente_Click(sender As Object, e As EventArgs) Handles pbx_eliminarCliente.Click
        ' Pedimos al usuario que introduzca el ID del cliente a eliminar utilizando la función InputBoxNumeros() de la clase Herramientas.
        Dim clienteDelete As Integer = Herramientas.InputBoxNumeros("Introduzca el id del cliente a eliminar", "Eliminar cliente")

        ' Creamos un comando que selecciona el número de filas donde la columna cod_cliente es igual a la variable clienteDelete.
        Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM cliente WHERE cod_cliente = @cod_cliente", conexion)
        ' Especificamos el valor del parámetro @cod_cliente utilizando AddWithValue().
        consulta.Parameters.AddWithValue("@cod_cliente", clienteDelete)
        ' Abrimos la conexión a la base de datos.
        conexion.Open()
        ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
        Dim resultado As Integer = 1
        ' Cerramos la conexión a la base de datos.
        conexion.Close()

        ' Comprobamos si el resultado es mayor que cero.
        If resultado > 0 Then
            ' Preguntamos al usuario si realmente desea eliminar el cliente utilizando la función InputBoxSiNo() de la clase Herramientas.
            If Herramientas.InputBoxSiNo("¿Quiere eliminar el cliente " & clienteDelete & "?", "Eliminar") Then
                ' Creamos un comando para eliminar el cliente.
                Dim ordensql As String = "DELETE FROM ClienteRepsol WHERE cod_cliente = @cod_cliente"
                Dim comando As New OleDbCommand(ordensql, conexion)
                ' Especificamos el valor del parámetro @cod_cliente utilizando AddWithValue().
                comando.Parameters.AddWithValue("@cod_cliente", clienteDelete)
                conexion.Open()
                Try
                    ' Ejecutamos el comando para eliminar el cliente.
                    comando.ExecuteNonQuery()
                    ' Actualizamos el DataGridView después de eliminar el cliente.
                    gestion_dataset.Tables("ClienteRepsol").Clear()
                    adaptador_clientes.Fill(gestion_dataset, "ClienteRepsol")
                Catch ex As Exception
                    ' Si se produce un error, mostramos un mensaje de error.
                    MsgBox("Ha ocurrido un error")
                Finally
                    ' Cerramos la conexión a la base de datos.
                    conexion.Close()
                End Try
            End If
        Else
            ' Si el cliente no existe en la base de datos, mostramos un mensaje de error utilizando la función GrabarError() de la clase Registros.
            Registros.GrabarError("El código introducido no existe en la base de datos", "El cliente seleccionado no existe")
        End If
    End Sub

    ' ** GESTION COMBUSTIBLES **
    Public Sub cargarDatosCombustible()
        Dim query As String = "SELECT * FROM combustible"
        Dim comando As New OleDbCommand(query, conexion)
        'Dim combustibles As String() = {"sin_plomo_95", "sin_plomo_98", "diesel", "diesel_plus"}
        conexion.Open()

        Dim reader As OleDbDataReader = comando.ExecuteReader()

        While reader.Read()
            Dim combustible = reader.GetString(0)
            If combustible = "sin_plomo_95" Then
                precio_SinPlomo95 = reader.GetDecimal(1)
                cantidad_SinPlomo95 = reader.GetDecimal(2)
            ElseIf combustible = "sin_plomo_98" Then
                precio_SinPLomo98 = reader.GetDecimal(1)
                cantidad_SinPLomo98 = reader.GetDecimal(2)
            ElseIf combustible = "diesel" Then
                precio_Diesel = reader.GetDecimal(1)
                cantidad_Diesel = reader.GetDecimal(2)
            ElseIf combustible = "diesel_plus" Then
                precio_DieselPlus = reader.GetDecimal(1)
                cantidad_DieselPlus = reader.GetDecimal(2)
            End If
        End While

        reader.Close()
        conexion.Close()

        pgb_sinPlomo95.Value = Math.Round(cantidad_SinPlomo95, 0, MidpointRounding.ToEven)
        pgb_sinPlomo98.Value = Math.Round(cantidad_SinPLomo98, 0, MidpointRounding.ToEven)
        pgb_diesel.Value = Math.Round(cantidad_Diesel, 0, MidpointRounding.ToEven)
        pgb_dieselPlus.Value = Math.Round(cantidad_DieselPlus, 0, MidpointRounding.ToEven)
    End Sub

    Public Sub actualizarCantidadBDCombustibles(combustible As Integer)
        Dim query As String = "UPDATE Combustible set cantidad=@can WHERE tipo_combustible = @com"
        Dim comando As New OleDbCommand(query, conexion)
        conexion.Open()
        Select Case combustible
            Case 0
                comando.Parameters.AddWithValue("@can", cantidad_SinPlomo95.ToString)
                comando.Parameters.AddWithValue("@com", "sin_plomo_95")
            Case 1
                comando.Parameters.AddWithValue("@can", cantidad_SinPLomo98.ToString)
                comando.Parameters.AddWithValue("@com", "sin_plomo_98")
            Case 2
                comando.Parameters.AddWithValue("@can", cantidad_Diesel.ToString)
                comando.Parameters.AddWithValue("@com", "diesel")
            Case 3
                comando.Parameters.AddWithValue("@can", cantidad_DieselPlus.ToString)
                comando.Parameters.AddWithValue("@com", "diesel_plus")
        End Select
        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Ha ocurrido un error modificando la cantidad del combustible")
        End Try
        conexion.Close()

    End Sub

    Private Sub btn_rellenarTanque_Click(sender As Object, e As EventArgs) Handles btn_rellenarTanque.Click
        Dim cantidadString As String = Herramientas.InputBoxNumeros("¿Cuantos litros quieres añadir en el depósito?", "Litros a rellenar")
        Dim cantidad As Decimal = Decimal.Parse(cantidadString)
        'Filtrar tipo de combustible
        Select Case cbx_tipoCombustible.SelectedIndex
            Case 0
                If (cantidad + cantidad_SinPlomo95) <= 10000 Then
                    cantidad_SinPlomo95 = cantidad + cantidad_SinPlomo95
                Else
                    MsgBox("No puedes superar la capacidad de 10000L")
                End If
            Case 1
                If (cantidad + cantidad_SinPLomo98) <= 10000 Then
                    cantidad_SinPLomo98 = cantidad + cantidad_SinPLomo98
                Else
                    MsgBox("No puedes superar la capacidad de 10000L")
                End If
            Case 2
                If (cantidad + cantidad_Diesel) <= 10000 Then
                    cantidad_Diesel = cantidad + cantidad_Diesel
                Else
                    MsgBox("No puedes superar la capacidad de 10000L")
                End If
            Case 3
                If (cantidad + cantidad_DieselPlus) <= 10000 Then
                    cantidad_DieselPlus = cantidad + cantidad_DieselPlus
                Else
                    MsgBox("No puedes superar la capacidad de 10000L")
                End If
            Case Else
                MsgBox("Primero debes seleccionar el tanque de combustible que deseas rellenar")
        End Select
        pgb_sinPlomo95.Value = Math.Round(cantidad_SinPLomo95, 0, MidpointRounding.ToEven)
        pgb_sinPlomo98.Value = Math.Round(cantidad_SinPLomo98, 0, MidpointRounding.ToEven)
        pgb_diesel.Value = Math.Round(cantidad_Diesel, 0, MidpointRounding.ToEven)
        pgb_dieselPlus.Value = Math.Round(cantidad_DieselPlus, 0, MidpointRounding.ToEven)
        actualizarCantidadBDCombustibles(cbx_tipoCombustible.SelectedIndex)
        Me.Refresh()

    End Sub

    Private Sub actualizarPrecioBDCombustible()
        Dim query As String = "UPDATE Combustible set precio_por_litro=@pre WHERE tipo_combustible = @com"
        Dim comando As New OleDbCommand(query, conexion)
        Dim combustibles As String() = {"sin_plomo_95", "sin_plomo_98", "diesel", "diesel_plus"}
        conexion.Open()
        Dim indice As Integer = cbx_tipoCombustible.SelectedIndex
        comando.Parameters.AddWithValue("@pre", Decimal.Round(nud_precioCombustible.Value, 4).ToString)
        comando.Parameters.AddWithValue("@com", combustibles(indice))
        Try
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Ha ocurrido un error modificando el precio del combustible")
        End Try
        conexion.Close()
        Me.Refresh()
    End Sub

    Private Sub nud_precioCombustible_LostFocus(sender As Object, e As EventArgs) Handles nud_precioCombustible.LostFocus
        actualizarPrecioBDCombustible()
    End Sub

    Public Function comprobarCombustible(combustible As Integer, cantidad As Decimal) As Boolean
        Dim Resultado As Boolean
        Select Case combustible
            Case 0
                If (cantidad_SinPlomo95 - cantidad) > 0 Then
                    cantidad_SinPlomo95 = cantidad_SinPlomo95 - cantidad
                    Resultado = True
                Else
                    MsgBox("No queda tanto combustible")
                    Resultado = False
                End If
            Case 1
                If (cantidad_SinPLomo98 - cantidad) > 0 Then
                    cantidad_SinPLomo98 = cantidad_SinPLomo98 - cantidad
                    Resultado = True
                Else
                    MsgBox("No queda tanto combustible")
                    Resultado = False
                End If
            Case 2
                If (cantidad_Diesel - cantidad) > 0 Then
                    cantidad_Diesel = cantidad_Diesel - cantidad
                    Resultado = True
                Else
                    MsgBox("No queda tanto combustible")
                    Resultado = False
                End If
            Case 3
                If (cantidad_DieselPlus - cantidad) > 0 Then
                    cantidad_DieselPlus = cantidad_DieselPlus - cantidad
                    Resultado = True
                Else
                    MsgBox("No queda tanto combustible")
                    Resultado = False
                End If
            Case Else
                MsgBox("Primero debes seleccionar el tanque de combustible que deseas utilizar")
                Resultado = False
        End Select
        actualizarCantidadBDCombustibles(combustible)
        Return Resultado
    End Function

    Public Function getPrecioComb(combustible As String) As Decimal
        Select Case combustible
            Case "Sin Plomo 95"
                Return precio_SinPlomo95
            Case "Sin Plomo 98"
                Return precio_SinPLomo98
            Case "Diesel"
                Return precio_Diesel
            Case "Diesel +"
                Return precio_DieselPlus
        End Select
        Return Nothing
    End Function

    Private Sub cargarSinPlomo95()
        cbx_tipoCombustible.SelectedIndex = 0
        nud_precioCombustible.Value = Decimal.Parse(precio_SinPlomo95)
        pgb_restanteDeposito.Value = Math.Round(cantidad_SinPLomo95, 0, MidpointRounding.ToEven)
        lbl_restanteLitros.Text = cantidad_SinPLomo95 & "/10000 L"
    End Sub

    Private Sub cargarSinPlomo98()
        cbx_tipoCombustible.SelectedIndex = 1
        nud_precioCombustible.Value = Decimal.Parse(precio_SinPLomo98)
        pgb_restanteDeposito.Value = Math.Round(cantidad_SinPLomo98, 0, MidpointRounding.ToEven)
        lbl_restanteLitros.Text = cantidad_SinPLomo98 & "/10000 L"
    End Sub

    Private Sub cargarDiesel()
        cbx_tipoCombustible.SelectedIndex = 2
        nud_precioCombustible.Value = Decimal.Parse(precio_Diesel)
        pgb_restanteDeposito.Value = Math.Round(cantidad_Diesel, 0, MidpointRounding.ToEven)
        lbl_restanteLitros.Text = cantidad_Diesel & "/10000 L"
    End Sub

    Private Sub cargarDieselPlus()
        cbx_tipoCombustible.SelectedIndex = 3
        nud_precioCombustible.Value = Decimal.Parse(precio_DieselPlus)
        pgb_restanteDeposito.Value = Math.Round(cantidad_DieselPlus, 0, MidpointRounding.ToEven)
        lbl_restanteLitros.Text = cantidad_DieselPlus & "/10000 L"
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

    ' ** BOTONES CATEGORÍAS **
    Private Sub btn_combustible_Click(sender As Object, e As EventArgs) Handles btn_combustible.Click
        ' Selecciona la pestaña "Combustible" (índice 0) en el control TabControl.
        tbc_gestion.SelectTab(0)
    End Sub
    Private Sub btn_tienda_Click(sender As Object, e As EventArgs) Handles btn_tienda.Click
        ' Selecciona la pestaña "Tienda" (índice 1) en el control TabControl.
        tbc_gestion.SelectTab(1)
    End Sub

    Public MiReporte As Object

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim dataGridViewPrint
        Select Case tbc_gestion.SelectedIndex
            Case 1
                dataGridViewPrint = New DataGridViewPrinter(dgv_tienda, PrintDocument1)
            Case 2
                dataGridViewPrint = New DataGridViewPrinter(dgv_empleados, PrintDocument1)
            Case 3
                dataGridViewPrint = New DataGridViewPrinter(dgv_proveedores, PrintDocument1)
            Case 4
                dataGridViewPrint = New DataGridViewPrinter(dgv_clientes, PrintDocument1)
        End Select
        'dataGridViewPrint.Print()
    End Sub
    'Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
    '    Dim MyForm As New VisorInformes
    '    MiReporte = New CrystalReport1
    '    MyForm.Show()
    'End Sub

    'Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    PrintDocument1.Print()
    'End Sub

    Private Sub btn_empleados_Click(sender As Object, e As EventArgs) Handles btn_empleados.Click
        ' Selecciona la pestaña "Empleados" (índice 2) en el control TabControl.
        tbc_gestion.SelectTab(2)
    End Sub

    Private Sub btn_proveedores_Click(sender As Object, e As EventArgs) Handles btn_proveedores.Click
        ' Selecciona la pestaña "Proveedores" (índice 3) en el control TabControl.
        tbc_gestion.SelectTab(3)
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        ' Selecciona la pestaña "Clientes" (índice 4) en el control TabControl.
        tbc_gestion.SelectTab(4)
    End Sub


    ' ** BOTONES TOOLSTRIPMENU **
    Private Sub tsb_registroAccesos_Click(sender As Object, e As EventArgs) Handles tsb_registroAccesos.Click
        RegistrosOnTop.errores = False
        RegistrosOnTop.ShowDialog()
    End Sub

    Private Sub tsb_registroErrores_Click(sender As Object, e As EventArgs) Handles tsb_registroErrores.Click
        RegistrosOnTop.errores = True
        RegistrosOnTop.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim url As String = "https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&cad=rja&uact=8&ved=2ahUKEwi5g-C7yLn9AhVewAIHHfofDZ8QFnoECAwQAQ&url=https%3A%2F%2Fwww.madrid.es%2Fportales%2Fmunimadrid%2Fes%2FInicio%2FAyuntamiento%2FEmergencias-y-Seguridad%2FPolicia-Municipal-de-Madrid%3Fvgnextfmt%3Ddefault%26vgnextoid%3D1b5abbc29b9ac310VgnVCM2000000c205a0aRCRD%26vgnextchannel%3Dd11c9ad016e07010VgnVCM100000dc0ca8c0RCRD&usg=AOvVaw1_iPxFitUnhZ83vZORBXgI"
        System.Diagnostics.Process.Start(url)

    End Sub


End Class