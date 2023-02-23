Public Class Validaciones

    ' ** VALIDAR DNI **
    ''' <summary>
    ''' Validaci�n para el DNI espa�ol. Comprueba que el n�mero y el orden de los caracteres sea correcto 
    ''' y verifica mediante la f�rmula espec�fica si la letra introducida es correcta.
    ''' </summary>
    ''' <param name="dni">String: DNI introducido por el usuario en el campo de texto</param>
    ''' <returns>Devuelve:
    '''     - True: si los datos son correctos.
    '''     - False: si los datos no son correctos.
    ''' </returns>
    Public Shared Function ValidarDNI(dni As String) As Boolean
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

    ' ** VALIDAR CONTRASE�A**
    ''' <summary>
    ''' Validaci�n para contrase�a de un usuario. Debe estar compuesta por m�s de 5 caracteres y menos de 10.
    ''' </summary>
    ''' <param name="contrasena">String: Contrase�a introducida por el usuario</param>
    ''' <returns>
    '''     - False: Si la contrase�a no es v�lida.
    '''     - True: Si la contrase�a es v�lida.
    ''' </returns>
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
End Class
