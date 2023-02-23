Public Class Validaciones
    ' ** VALIDAR DNI **
    ''' <summary>
    ''' Validación para el DNI español. Comprueba que el número y el orden de los caracteres sea correcto 
    ''' y verifica mediante la fórmula específica si la letra introducida es correcta.
    ''' </summary>
    ''' <param name="dni">DNI introducido por el usuario en el campo de texto, debe pasarse como String</param>
    ''' <returns>Devuelve:
    '''     - 1: si los datos son correctos
    '''     - -1: si los datos no son correctos
    ''' </returns>
    Public Shared Function ValidarDNI(dni As String) As Boolean
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

                'Calculo la letra correcta con la formula correspondiente
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
                'Sino contiene una letra al final devuelve -1
                Return False
            End If

        Else
            ' Si el dni no tiene el número correcto de caracteres devuelvo -1
            Return False
        End If

    End Function

End Class
