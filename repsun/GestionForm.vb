﻿Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
    Dim readerPublic As OleDbDataReader
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
        gestion_dataset.Clear()
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
                    actualizarDataGridView()
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


    ' ** GESTIÓN EMPLELADOS **
    ''' <summary>
    ''' Al cambiar el texto actualiza el dataGridView con los datos que coincidan
    ''' </summary>
    ''' <param name="sender">Object: txt_buscarEmpleado</param>
    ''' <param name="e">EventArgs: TextChanged</param>
    Private Sub txt_buscarEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarEmpleado.TextChanged
        Dim comando As New OleDbCommand(("SELECT * FROM empleados WHERE nombre LIKE '%" & txt_buscarEmpleado.Text & "%'"), conexion)
        adaptador_empleados.SelectCommand = comando
        gestion_dataset.Clear()
        adaptador_empleados.Fill(gestion_dataset, "empleados")
        dgv_empleados.DataSource = gestion_dataset
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
                    ' Creamos un comando para eliminar el empleado.
                    Dim ordensql As String = "DELETE FROM empleado WHERE cod_empleado = @cod_empleado"
                    Dim comando As New OleDbCommand(ordensql, conexion)
                    ' Especificamos el valor del parámetro @cod_empleado utilizando AddWithValue().
                    comando.Parameters.AddWithValue("@cod_empleado", empleadoDelete)
                    conexion.Open()
                    Try
                        ' Ejecutamos el comando para eliminar el empleado.
                        comando.ExecuteNonQuery()
                        ' Actualizamos el DataGridView después de eliminar el empleado.
                        actualizarDataGridView()
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
    ' ** GESTIÓN proveedores **
    Private Sub txt_buscarproveedores_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarProveedores.TextChanged
        Dim comando As New OleDbCommand(("Select * from proveedor where nombre LIKE '%" & txt_buscarProveedores.Text & "%'"), conexion)
        adaptador_proveedores.SelectCommand = comando
        gestion_dataset.Clear()
        adaptador_proveedores.Fill(gestion_dataset, "proveedor")
        dgv_proveedores.DataSource = gestion_dataset
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
        actualizarDataGridView()
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
        GestionProveedoresOnTop.empresaUpdate = Herramientas.InputBoxNumeros("Introduzca el id del proveedor a editar", "Editar proveedor")

        ' Si el usuario no cancela el InputBox (es decir, si el valor devuelto no es una cadena vacía), mostramos la ventana GestionProveedoresOnTop.
        If Not GestionProveedoresOnTop.empresaUpdate = "" Then
            ' Creamos una variable para almacenar el resultado de la consulta.
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna cod_proveedor es igual a la variable codigo.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM proveedor WHERE cod_proveedor = " & GestionProveedoresOnTop.empresaUpdate, conexion)
            ' Abrimos la conexión a la base de datos.
            conexion.Open()
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = CInt(consulta.ExecuteScalar())
            ' Cerramos la conexión a la base de datos.
            conexion.Close()
            ' Comprobamos si el resultado es mayor que cero.
            If resultado > 0 Then
                ' La variable codigo existe dentro de la columna cod_proveedor de la tabla proveedor.
                GestionProveedoresOnTop.ShowDialog()
            Else
                ' La variable codigo no existe dentro de la columna cod_proveedor de la tabla proveedor.
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
        Dim proveedorDelete As Integer = Herramientas.InputBoxNumeros("Introduzca el id del proveedor a eliminar", "Eliminar proveedor")

        ' Creamos un comando que selecciona el número de filas donde la columna cod_proveedor es igual a la variable proveedorDelete.
        Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM proveedor WHERE cod_proveedor = @cod_proveedor", conexion)
        ' Especificamos el valor del parámetro @cod_proveedor utilizando AddWithValue().
        consulta.Parameters.AddWithValue("@cod_proveedor", proveedorDelete)
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
                Dim ordensql As String = "DELETE FROM proveedor WHERE cod_proveedor = @cod_proveedor"
                Dim comando As New OleDbCommand(ordensql, conexion)
                ' Especificamos el valor del parámetro @cod_proveedor utilizando AddWithValue().
                comando.Parameters.AddWithValue("@cod_proveedor", proveedorDelete)
                conexion.Open()
                Try
                    ' Ejecutamos el comando para eliminar el proveedor.
                    comando.ExecuteNonQuery()
                    ' Actualizamos el DataGridView después de eliminar el proveedor.
                    actualizarDataGridView()
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
            Registros.GrabarError("El código introducido no existe en la base de datos", "El proveedor seleccionado no existe")
        End If
    End Sub
    ' ** GESTION CLIENTES **
    ''' <summary>
    ''' Al cambiar el texto actualiza el dataGridView con los datos que coincidan
    ''' </summary>
    ''' <param name="sender">Object: txt_buscarCliente</param>
    ''' <param name="e">EventArgs: TextChanged</param>
    Private Sub txt_buscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarCliente.TextChanged
        Dim comando As New OleDbCommand(("SELECT * FROM clientes WHERE nombre LIKE '%" & txt_buscarCliente.Text & "%'"), conexion)
        adaptador_clientes.SelectCommand = comando
        gestion_dataset.Clear()
        adaptador_clientes.Fill(gestion_dataset, "clientes")
        dgv_clientes.DataSource = gestion_dataset
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
        actualizarDataGridView()
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
            Dim resultado As Integer
            ' Creamos un comando que selecciona el número de filas donde la columna cod_cliente es igual a la variable clienteUpdate.
            Dim consulta As New OleDbCommand("SELECT COUNT(*) FROM cliente WHERE cod_cliente = " & ClientesOnTop.clienteUpdate, conexion)
            ' Abrimos la conexión a la base de datos.
            conexion.Open()
            ' Ejecutamos el comando y almacenamos el resultado en la variable resultado.
            resultado = CInt(consulta.ExecuteScalar())
            ' Cerramos la conexión a la base de datos.
            conexion.Close()
            ' Comprobamos si el resultado es mayor que cero.
            If resultado > 0 Then
                ' La variable clienteUpdate existe dentro de la columna cod_cliente de la tabla cliente.
                ClientesOnTop.ShowDialog()
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
        Dim resultado As Integer = CInt(consulta.ExecuteScalar())
        ' Cerramos la conexión a la base de datos.
        conexion.Close()

        ' Comprobamos si el resultado es mayor que cero.
        If resultado > 0 Then
            ' Preguntamos al usuario si realmente desea eliminar el cliente utilizando la función InputBoxSiNo() de la clase Herramientas.
            If Herramientas.InputBoxSiNo("¿Quiere eliminar el cliente " & clienteDelete & "?", "Eliminar") Then
                ' Creamos un comando para eliminar el cliente.
                Dim ordensql As String = "DELETE FROM cliente WHERE cod_cliente = @cod_cliente"
                Dim comando As New OleDbCommand(ordensql, conexion)
                ' Especificamos el valor del parámetro @cod_cliente utilizando AddWithValue().
                comando.Parameters.AddWithValue("@cod_cliente", clienteDelete)
                conexion.Open()
                Try
                    ' Ejecutamos el comando para eliminar el cliente.
                    comando.ExecuteNonQuery()
                    ' Actualizamos el DataGridView después de eliminar el cliente.
                    actualizarDataGridView()
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

    ' ----
    Public Sub tpg_combustible_Enter(sender As Object, e As EventArgs) Handles tpg_combustible.Enter
        Dim queryCombustible As String = "SELECT * FROM combustible WHERE tipo_combustible = @com"
        comandoPublic = New OleDbCommand(queryCombustible, conexion)
    End Sub

    Private Sub btn_rellenarTanque_Click(sender As Object, e As EventArgs) Handles btn_rellenarTanque.Click


    End Sub


    Private Sub cargarSinPlomo95()
        cbx_tipoCombustible.SelectedIndex = 0
        comandoPublic.Parameters.AddWithValue("@com", "sin_plomo_95")
        conexion.Open()
        readerPublic = comandoPublic.ExecuteReader
        If readerPublic.Read Then
            nud_precioCombustible.Value = Decimal.Parse(readerPublic("precio_por_litro").ToString)
            Dim cantidadL As Decimal = Decimal.Parse(readerPublic("cantidad").ToString)
            pgb_restanteDeposito.Value = Math.Round(cantidadL, 0, MidpointRounding.ToEven)
            lbl_restanteLitros.Text = cantidadL & "/10000 L"
        End If
        readerPublic.Close()
        conexion.Close()
    End Sub

    Private Sub cargarSinPlomo98()
        cbx_tipoCombustible.SelectedIndex = 0
        comandoPublic.Parameters.AddWithValue("@com", "sin_plomo_98")
        conexion.Open()
        readerPublic = comandoPublic.ExecuteReader
        If readerPublic.Read Then
            nud_precioCombustible.Value = Decimal.Parse(readerPublic("precio_por_litro").ToString)
            Dim cantidadL As Decimal = Decimal.Parse(readerPublic("cantidad").ToString)
            pgb_restanteDeposito.Value = Math.Round(cantidadL, 0, MidpointRounding.ToEven)
            lbl_restanteLitros.Text = cantidadL & "/10000 L"
        End If
        readerPublic.Close()
        conexion.Close()
    End Sub

    Private Sub cargarDiesel()
        cbx_tipoCombustible.SelectedIndex = 0
        comandoPublic.Parameters.AddWithValue("@com", "diesel")
        conexion.Open()
        readerPublic = comandoPublic.ExecuteReader
        If readerPublic.Read Then
            nud_precioCombustible.Value = Decimal.Parse(readerPublic("precio_por_litro").ToString)
            Dim cantidadL As Decimal = Decimal.Parse(readerPublic("cantidad").ToString)
            pgb_restanteDeposito.Value = Math.Round(cantidadL, 0, MidpointRounding.ToEven)
            lbl_restanteLitros.Text = cantidadL & "/10000 L"
        End If
        readerPublic.Close()
        conexion.Close()
    End Sub

    Private Sub cargarDieselPlus()
        cbx_tipoCombustible.SelectedIndex = 0
        comandoPublic.Parameters.AddWithValue("@com", "diesel_plus")
        conexion.Open()
        readerPublic = comandoPublic.ExecuteReader
        If readerPublic.Read Then
            nud_precioCombustible.Value = Decimal.Parse(readerPublic("precio_por_litro").ToString)
            Dim cantidadL As Decimal = Decimal.Parse(readerPublic("cantidad").ToString)
            pgb_restanteDeposito.Value = Math.Round(cantidadL, 0, MidpointRounding.ToEven)
            lbl_restanteLitros.Text = cantidadL & "/10000 L"
        End If
        readerPublic.Close()
        conexion.Close()
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

End Class