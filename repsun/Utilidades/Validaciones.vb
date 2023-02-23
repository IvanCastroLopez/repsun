Imports System.Text.RegularExpressions

Public Class Validaciones

    ' ** VALIDAR NOMBRE DE USUARIO **
    ''' <summary>
    ''' Comprueba que se trata de un nombre de usuario v�lido. Debe seguir el formato "nombre.apellidoN�mero".
    ''' </summary>
    ''' <param name="nombreUsuario"></param>
    ''' <returns></returns>
    Public Shared Function ValidarNombreUsuario(nombreUsuario As String) As Boolean

        ' Patr�n con formato "nombre.apellidoN�mero"
        Dim pattern As String = "^[a-z]+\.[a-z]+$"

        ' Utilizar la funci�n Regex.IsMatch para verificar si el nombre cumple con el formato especificado
        Return Regex.IsMatch(nombreUsuario, pattern) Or nombreUsuario.Equals("admin")
    End Function

    ' ** VALIDAR CONTRASE�A**
    ''' <summary>
    ''' Comprueba la contrase�a de un usuario. Debe estar compuesta por m�s de 5 caracteres y menos de 10.
    ''' </summary>
    ''' <param name="contrasena">String: Contrase�a introducida por el usuario</param>
    ''' <returns>True si la contrase�a es v�lida, False en caso contrario.</returns>
    Public Shared Function ValidarContrasena(contrasena As String) As Boolean

        Dim caracteresValidos As String = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXTZ_-"

        ' Comprobamos que la contrase�a tiene m�s de 5 caracteres y menos de 11
        If Len(contrasena) > 5 And Len(contrasena) < 11 Then

            ' Recorro la contrase�a caracter a caracter
            For a = 1 To Len(contrasena)
                Dim ch As Char = GetChar(contrasena, a)

                ' Si el caracter no es v�lido devolvemos False.
                If Not caracteresValidos.Contains(ch) Then
                    Return False
                End If
            Next a

            ' Si la contrase�a cumple con los par�metros devolvemos true
            Return True
        Else

            ' Si la contrase�a no cumple con los par�metros devolvemos false
            Return False
        End If
    End Function

    ' ** VALIDAR EMAIL **
    ''' <summary>
    ''' Comprueba que se trata de un email v�lido. Debe contener "@" entre la parte local y el dominio
    ''' y el dominio debe de contener m�s de 3 letras antes del punto y al menos 2 despu�s.
    ''' </summary>
    ''' <param name="email">String: email que se quiere validar</param>
    ''' <returns>True si el email es v�lido, False en caso contrario.</returns>
    Public Shared Function ValidarEmail(email As String) As Boolean

        ' Definir una expresi�n regular para validar el formato del correo electr�nico
        Dim pattern As String = "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$"
        ' Utilizar la funci�n Regex.IsMatch para verificar si el correo electr�nico cumple con el formato especificado
        Return Regex.IsMatch(email, pattern)
    End Function

    ''' <summary>
    ''' Comprueba los n�meros de tel�fono. Debe tener 9 d�gitos y empiezar por 9 u 8 (para tel�fonos fijos) 
    ''' y 6 � 7, para tel�fonos m�viles.
    ''' </summary>
    ''' <param name="tlfno">String: tel�fono que se desea validar</param>
    ''' <returns>True si el telefono es v�lido, False en caso contrario.</returns>
    Public Shared Function ValidarTelefono(tlfno As String) As Boolean

        ' Verificar que el n�mero de tel�fono tenga 9 d�gitos
        If Len(tlfno) = 9 Then
            ' Inicializar variable para guardar cada d�gito del n�mero de tel�fono
            Dim digito As Char = ""
            ' Recorrer cada d�gito del n�mero de tel�fono
            For n As Integer = 1 To Len(tlfno)
                ' Obtener el d�gito actual
                digito = GetChar(tlfno, n)
                ' Verificar si el d�gito es un n�mero
                If Not IsNumeric(digito) Then
                    ' Si el d�gito no es un n�mero, el n�mero de tel�fono es inv�lido
                    Return False
                ElseIf n = 1 Then
                    ' Si es el primer d�gito del n�mero de tel�fono, verificar si es v�lido
                    Dim num As Integer = Val(digito)
                    If num <> 6 And num <> 7 And num <> 8 And num <> 9 Then
                        ' Si el primer d�gito no es v�lido, el n�mero de tel�fono es inv�lido
                        Return False
                    End If
                End If
            Next
            ' Si se han recorrido todos los d�gitos sin problemas, el n�mero de tel�fono es v�lido
            Return True
        Else
            ' Si el n�mero de tel�fono no tiene 9 d�gitos, es inv�lido
            Return False
        End If
    End Function

    ' ** VALIDAR NOMBRE **
    ''' <summary>
    ''' Comprueba si es un nombre v�lido.
    ''' </summary>
    ''' <param name="nombre">El nombre a verificar.</param>
    ''' <returns>True si el nombre no contiene n�meros, False en caso contrario.</returns>
    Public Shared Function ValidarNombre(nombre As String) As Boolean
        'La funci�n utiliza la funci�n IsNumeric para verificar si el nombre pasado como argumento es un n�mero
        'La funci�n Not invierte el valor devuelto por IsNumeric, es decir, devuelve True si el valor pasado no es un n�mero
        Return Not IsNumeric(nombre)
    End Function

    ' ** VALIDAR DNI **
    ''' <summary>
    ''' Comprueba el DNI espa�ol. Comprueba que el n�mero y el orden de los caracteres sea correcto 
    ''' y verifica mediante la f�rmula espec�fica si la letra introducida es correcta.
    ''' </summary>
    ''' <param name="dni">String: DNI introducido por el usuario en el campo de texto</param>
    ''' <returns>True si el dni es v�lido, False en caso contrario.</returns>
    Public Shared Function ValidarDni(dni As String) As Boolean
        ' Pongo el dni en may�sculas si no lo est�
        dni = dni.ToUpper
        ' Guardo la longitud del dni introducido
        Dim leng As Single = dni.Length
        ' Guardo las letras que puede contener el dni en el orden correspondiente
        Dim testString As String = "TRWAGMYFPDXBNJZSQVHLCKE"

        Dim dniNum As String = ""
        Dim dniLetra As Char
        Dim testChar As Char

        ' Compruebo que el n�mero de caracteres es correcto
        If Len(dni) <= 9 And Len(dni) > 2 Then
            ' Compruebo que el �ltimo caracter es una letra
            testChar = GetChar(dni, leng)
            If Not IsNumeric(testChar) Then
                ' si lo es lo guardo en la variable que le corresponde
                dniLetra = GetChar(dni, leng)
                ' comrpruebo caracter a caracter que todo los dem�s sin n�meros
                For a = 1 To leng - 1
                    testChar = GetChar(dni, a)
                    If Not IsNumeric(testChar) Then
                        'Si no es un n�mero devuelvo -1
                        Return False
                    End If
                    ' si es un n�mero lo a�ado a la variable que corresponde
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
            ' Si el dni no tiene el n�mero correcto de caracteres devuelvo -1
            Return False
        End If
    End Function
End Class
