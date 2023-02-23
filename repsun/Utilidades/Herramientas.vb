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
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
        Dim adaptador As New OleDbDataAdapter("Select * from Combustible", conexion)
        Dim midataset As New DataSet

        Dim comando As New OleDbCommand("select * from Combustible where tipo_combustible=@com", conexion)
        comando.Parameters.AddWithValue("@com", tipo_combustible.ToString)

        conexion.Open()
        Dim res As OleDbDataReader = comando.ExecuteReader
        Dim precioPorLitro As Decimal = res("precio_por_litro")

        Return litros * precioPorLitro
    End Function

    Public Shared Function cambioPrecioLitros(precio As Decimal, tipo_combustible As tipoCombustible) As Decimal
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
        Dim adaptador As New OleDbDataAdapter("Select * from Combustible", conexion)
        Dim midataset As New DataSet

        Dim comando As New OleDbCommand("select * from Combustible where tipo_combustible=@com", conexion)
        comando.Parameters.AddWithValue("@com", tipo_combustible.ToString)

        conexion.Open()
        Dim res As OleDbDataReader = comando.ExecuteReader
        Dim precioPorLitro As Decimal = res("precio_por_litro")

        Return precio / precioPorLitro
    End Function

    ' Enumeración que define los diferentes tipos de combustibles
    Public Enum tipoCombustible
        diesel
        diesel_plus
        sin_plomo_95
        sin_plomo_98
    End Enum
End Class
