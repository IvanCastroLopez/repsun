Imports System.Text.RegularExpressions

Public Class Validaciones

    ' ** VALIDAR NOMBRE DE USUARIO **
    ''' <summary>
    ''' Comprueba que se trata de un nombre de usuario válido. Debe seguir el formato "nombre.apellidoNúmero".
    ''' </summary>
    ''' <param name="nombreUsuario"></param>
    ''' <returns></returns>
    Public Shared Function ValidarNombreUsuario(nombreUsuario As String) As Boolean

        ' Patrón con formato "nombre.apellidoNúmero"
        Dim pattern As String = "^[a-z]+\.[a-z]+$"

        ' Utilizar la función Regex.IsMatch para verificar si el nombre cumple con el formato especificado
        Return Regex.IsMatch(nombreUsuario, pattern) Or nombreUsuario.Equals("admin")
    End Function

    ' ** VALIDAR CONTRASEÑA**
    ''' <summary>
    ''' Comprueba la contraseña de un usuario. Debe estar compuesta por más de 5 caracteres y menos de 10.
    ''' </summary>
    ''' <param name="contrasena">String: Contraseña introducida por el usuario</param>
    ''' <returns>True si la contraseña es válida, False en caso contrario.</returns>
    Public Shared Function ValidarContrasena(contrasena As String) As Boolean

        Dim caracteresValidos As String = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXTZ_-"

        ' Comprobamos que la contraseña tiene más de 5 caracteres y menos de 11
        If Len(contrasena) > 5 And Len(contrasena) < 11 Then

            ' Recorro la contraseña caracter a caracter
            For a = 1 To Len(contrasena)
                Dim ch As Char = GetChar(contrasena, a)

                ' Si el caracter no es válido devolvemos False.
                If Not caracteresValidos.Contains(ch) Then
                    Return False
                End If
            Next a

            ' Si la contraseña cumple con los parámetros devolvemos true
            Return True
        Else

            ' Si la contraseña no cumple con los parámetros devolvemos false
            Return False
        End If
    End Function

    ' ** VALIDAR EMAIL **
    ''' <summary>
    ''' Comprueba que se trata de un email válido. Debe contener "@" entre la parte local y el dominio
    ''' y el dominio debe de contener más de 3 letras antes del punto y al menos 2 después.
    ''' </summary>
    ''' <param name="email">String: email que se quiere validar</param>
    ''' <returns>True si el email es válido, False en caso contrario.</returns>
    Public Shared Function ValidarEmail(email As String) As Boolean

        ' Definir una expresión regular para validar el formato del correo electrónico
        Dim pattern As String = "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$"
        ' Utilizar la función Regex.IsMatch para verificar si el correo electrónico cumple con el formato especificado
        Return Regex.IsMatch(email, pattern)
    End Function

    ''' <summary>
    ''' Comprueba los números de teléfono. Debe tener 9 dígitos y empiezar por 9 u 8 (para teléfonos fijos) 
    ''' y 6 ó 7, para teléfonos móviles.
    ''' </summary>
    ''' <param name="tlfno">String: teléfono que se desea validar</param>
    ''' <returns>True si el telefono es válido, False en caso contrario.</returns>
    Public Shared Function ValidarTelefono(tlfno As String) As Boolean

        ' Verificar que el número de teléfono tenga 9 dígitos
        If Len(tlfno) = 9 Then
            ' Inicializar variable para guardar cada dígito del número de teléfono
            Dim digito As Char = ""
            ' Recorrer cada dígito del número de teléfono
            For n As Integer = 1 To Len(tlfno)
                ' Obtener el dígito actual
                digito = GetChar(tlfno, n)
                ' Verificar si el dígito es un número
                If Not IsNumeric(digito) Then
                    ' Si el dígito no es un número, el número de teléfono es inválido
                    Return False
                ElseIf n = 1 Then
                    ' Si es el primer dígito del número de teléfono, verificar si es válido
                    Dim num As Integer = Val(digito)
                    If num <> 6 And num <> 7 And num <> 8 And num <> 9 Then
                        ' Si el primer dígito no es válido, el número de teléfono es inválido
                        Return False
                    End If
                End If
            Next
            ' Si se han recorrido todos los dígitos sin problemas, el número de teléfono es válido
            Return True
        Else
            ' Si el número de teléfono no tiene 9 dígitos, es inválido
            Return False
        End If
    End Function

    ' ** VALIDAR NOMBRE **
    ''' <summary>
    ''' Comprueba si es un nombre válido.
    ''' </summary>
    ''' <param name="nombre">El nombre a verificar.</param>
    ''' <returns>True si el nombre no contiene números, False en caso contrario.</returns>
    Public Shared Function ValidarNombre(nombre As String) As Boolean
        'La función utiliza la función IsNumeric para verificar si el nombre pasado como argumento es un número
        'La función Not invierte el valor devuelto por IsNumeric, es decir, devuelve True si el valor pasado no es un número
        Return Not IsNumeric(nombre)
    End Function

    ' ** VALIDAR DNI **
    ''' <summary>
    ''' Comprueba el DNI español. Comprueba que el número y el orden de los caracteres sea correcto 
    ''' y verifica mediante la fórmula específica si la letra introducida es correcta.
    ''' </summary>
    ''' <param name="dni">String: DNI introducido por el usuario en el campo de texto</param>
    ''' <returns>True si el dni es válido, False en caso contrario.</returns>
    Public Shared Function ValidarDni(dni As String) As Boolean
        ' Pongo el dni en mayúsculas si no lo está
        dni = dni.ToUpper
        ' Guardo la longitud del dni introducido
        Dim leng As Single = dni.Length
        ' Guardo las letras que puede contener el dni en el orden correspondiente
        Dim testString As String = "TRWAGMYFPDXBNJZSQVHLCKE"

        Dim dniNum As String = ""
        Dim dniLetra As Char
        Dim testChar As Char

        ' Compruebo que el número de caracteres es correcto
        If Len(dni) <= 9 And Len(dni) > 2 Then
            ' Compruebo que el último caracter es una letra
            testChar = GetChar(dni, leng)
            If Not IsNumeric(testChar) Then
                ' si lo es lo guardo en la variable que le corresponde
                dniLetra = GetChar(dni, leng)
                ' comrpruebo caracter a caracter que todo los demás sin números
                For a = 1 To leng - 1
                    testChar = GetChar(dni, a)
                    If Not IsNumeric(testChar) Then
                        'Si no es un número devuelvo -1
                        Return False
                    End If
                    ' si es un número lo añado a la variable que corresponde
                    dniNum &= testChar
                Next a
                ' Calculo la letra correcta con la formula correspondiente
                Dim valor As Integer
                valor = CInt(dniNum) Mod 23
                ' Busco la letra correspondiente y la comparo con la correcta
                testChar = GetChar(testString, valor + 1)
                If testChar <> dniLetra Then
                    'si la letra no es correcta devuelvo -1
                    Return False
                End If
                ' Si todo es correcto devuelve 1
                Return True
            Else
                ' Sino contiene una letra al final devuelve -1
                Return False
            End If
        Else
            ' Si el dni no tiene el número correcto de caracteres devuelvo -1
            Return False
        End If
    End Function
End Class
