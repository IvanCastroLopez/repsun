Imports System.Data.OleDb

Public Class Herramientas

    ' ** INPUT BOX SI/NO **
    ''' <summary>
    ''' Devuelve un InputBox con opción Si/No.
    ''' </summary>
    ''' <param name="prompt">String: El texto que se muestra como mensaje en el InputBox</param>
    ''' <param name="title">String: El título que se muestra en la barra de título del InputBox.</param>
    ''' <returns>Boolean: True si el usuario selecciona "Sí", False si el usuario selecciona "No".</returns>
    Public Shared Function InputBoxSiNo(prompt As String, title As String) As Boolean
        ' Mostrar el InputBox con las opciones Si/No
        Dim result As DialogResult = MessageBox.Show(prompt, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario selecciona "Sí", devolver True. Si selecciona "No", devolver False.
        If result = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function


    ' ** INPUT BOX SOLO PARA NÚMEROS **
    ''' <summary>
    ''' Devuelve un InputBox que solo permite la entrada de números.
    ''' </summary>
    ''' <param name="prompt">String: El texto que se muestra como mensaje en el InputBox</param>
    ''' <param name="title">String: title</param>
    ''' <returns>Una cadena que contiene el número ingresado por el usuario, o una cadena vacía si el usuario cancela el InputBox.</returns>
    Public Shared Function InputBoxNumeros(prompt As String, title As String) As String
        ' Declaramos una variable para almacenar el valor ingresado por el usuario.
        Dim input As String = ""

        ' Declaramos una variable para indicar si el valor ingresado es un número válido.
        Dim isNum As Boolean = False

        ' Utilizamos un bucle While para asegurarnos de que se ingrese un número válido.
        While Not isNum
            ' Mostramos el InputBox con el texto de prompt, el título de title y el valor predeterminado de defaultValue.
            input = InputBox(prompt, title)

            ' Comprobamos si el valor ingresado es un número válido utilizando la función IsNumeric().
            If IsNumeric(input) Then
                ' Si el valor es un número válido, actualizamos la variable isNum para salir del bucle.
                isNum = True
            ElseIf input = "" Then
                'closed
                Exit Function
            Else

                ' Si el valor no es un número válido, mostramos un mensaje de error al usuario y volvemos a pedir un valor.
                Registros.GrabarError("Ingrese solo números", "Error de entrada")
            End If
        End While

        ' Devolvemos el valor ingresado por el usuario.
        Return input
    End Function

    '** CAMBIO LITROS/PRECIO **
    ''' <summary>
    ''' Realiza el cambio de litros al precio actual del combustible (sacado de la base de datos).
    ''' </summary>
    ''' <param name="litros">Decimal: Litros a cambiar</param>
    ''' <param name="tipo_combustible">tipoCombustible: Tipo de combustible</param>
    ''' <returns>El precio de la cantidad de Litros de combustible introducida</returns>
    Public Shared Function CambioLitrosPrecio(litros As Decimal, tipo_combustible As tipoCombustible) As Decimal

        ' Se crea una conexión a la base de datos de combustibles.
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
        ' Se crea un adaptador para acceder a la tabla de combustibles.
        Dim adaptador As New OleDbDataAdapter("Select * from Combustible", conexion)
        ' Se crea un dataset para almacenar los datos obtenidos de la tabla de contenidos.
        Dim midataset As New DataSet

        ' Se crea un comando que selecciona los datos del combustible deseado.
        Dim comando As New OleDbCommand("select * from Combustible where tipo_combustible=@com", conexion)
        comando.Parameters.AddWithValue("@com", tipo_combustible.ToString)

        ' Se abre la conexión a la base de datos.
        conexion.Open()

        ' Se ejecuta el comando y se obtiene un data reader con los datos del combustible.
        Dim res As OleDbDataReader = comando.ExecuteReader

        ' Se mueve el cursor al primer registro.
        If res.Read() Then
            ' Se obtiene el precio por litro del combustible deseado.
            Dim precioPorLitro As Decimal = res("precio_por_litro")

            ' Se cierra la conexión a la base de datos.
            conexion.Close()

            ' Devolver el precio de los litros introducidos.
            Return Math.Round((litros * precioPorLitro), 4)
        Else
            ' No se encontró el combustible deseado.
            conexion.Close()
            Throw New Exception("No se encontró el combustible deseado.")
        End If
    End Function

    '** CAMBIO PRECIOS/LITROS
    ''' <summary>
    ''' Realiza el cambio de dinero introducido a litros según el precio actual del combustible (sacado de la base de datos).
    ''' </summary>
    ''' <param name="dinero">Decimal: Dinero a cambiar</param>
    ''' <param name="tipo_combustible">tipoCombustible: Tipo de combustible</param>
    ''' <returns>La cantidad de combustible equivalente al dinero introducido</returns>
    Public Shared Function CambioPrecioLitros(dinero As Decimal, tipo_combustible As tipoCombustible) As Decimal

        ' Se crea una conexión a la base de datos de combustibles.
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
        ' Se crea un adaptador para acceder a la tabla de combustibles.
        Dim adaptador As New OleDbDataAdapter("Select * from Combustible", conexion)
        ' Se crea un dataset para almacenar los datos obtenidos de la tabla de contenidos.
        Dim midataset As New DataSet

        ' Se crea un comando que selecciona los datos del combustible deseado.
        Dim comando As New OleDbCommand("select * from Combustible where tipo_combustible=@com", conexion)
        comando.Parameters.AddWithValue("@com", tipo_combustible.ToString)

        ' Se abre la conexión a la base de datos.
        conexion.Open()

        ' Se ejecuta el comando y se obtiene un data reader con los datos del combustible.
        Dim res As OleDbDataReader = comando.ExecuteReader

        ' Se comprueba si hay al menos una fila en el resultado.
        If res.Read() Then
            ' Se obtiene el precio por litro del combustible deseado.
            Dim precioPorLitro As Decimal = res("precio_por_litro")

            ' Se cierra la conexión a la base de datos.
            conexion.Close()

            ' Devolver el litro equivalente al dinero introducido.
            Return Math.Round((dinero / precioPorLitro), 4)
        Else
            ' No se encontró ningún registro.
            Throw New ArgumentException("No se encontró ningún combustible con el tipo indicado.")
        End If

    End Function

    ' Enumeración que define los diferentes tipos de combustibles
    Public Enum tipoCombustible
        diesel
        diesel_plus
        sin_plomo_95
        sin_plomo_98
    End Enum

End Class
