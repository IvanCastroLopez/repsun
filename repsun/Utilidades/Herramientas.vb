Imports System.Data.OleDb

Public Class Herramientas

    '** CAMBIO LITROS/PRECIO **
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="litros"></param>
    ''' <param name="tipo_combustible"></param>
    ''' <returns></returns>
    Public Shared Function cambioLitrosPrecio(litros As Decimal, tipo_combustible As tipoCombustible) As Decimal

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

        ' Se obtiene el precio por litro del combustible deseado.
        Dim precioPorLitro As Decimal = res("precio_por_litro")

        ' Se cierra la conexión a la base de datos.
        conexion.Close()

        ' Devolver el precio de los litros introducidos.
        Return litros * precioPorLitro
    End Function

    Public Shared Function cambioPrecioLitros(dinero As Decimal, tipo_combustible As tipoCombustible) As Decimal

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

        ' Se obtiene el precio por litro del combustible deseado.
        Dim precioPorLitro As Decimal = res("precio_por_litro")

        ' Se cierra la conexión a la base de datos.
        conexion.Close()

        ' Devolver el litro equivalente al dinero introducido.
        Return dinero / precioPorLitro
    End Function

    ' Enumeración que define los diferentes tipos de combustibles
    Public Enum tipoCombustible
        diesel
        diesel_plus
        sin_plomo_95
        sin_plomo_98
    End Enum
End Class
