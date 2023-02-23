'Public Class UtilidadResolucion
'    Dim smallSize As Size = New Size(800, 600)
'    Dim middleSize As Size = New Size(1440, 900)
'    Dim largeSize As Size = New Size(1900, 1200)

'    Private Function AutoSuitableScreen() As ScreenSize
'        Dim enumSize As ScreenSize = New ScreenSize()
'        Dim Primary As Size = Screen.PrimaryScreen.WorkingArea.Size
'        If Primary.Width * Primary.Height <= smallSize.Width * smallSize.Height Then
'            enumSize = ScreenSize.Pequeño
'        ElseIf smallSize.Width * smallSize.Height < Primary.Width * Primary.Height AndAlso
'            Primary.Width * Primary.Height <= middleSize.Width * middleSize.Height Then
'            enumSize = ScreenSize.Mediano
'        ElseIf (middleSize.Width * middleSize.Height < Primary.Width * Primary.Height AndAlso
'                Primary.Width * Primary.Height <= largeSize.Width * largeSize.Height) Then
'            enumSize = ScreenSize.Grande
'        Else
'            enumSize = ScreenSize.MuyGrande
'        End If
'        Return enumSize
'    End Function


'    Private Sub AutoLayout(size As ScreenSize)

'        Select Case size
'            Case ScreenSize.Pequeño
'                AutoSizeForm(smallSize)
'                Me.FontHeight = 10
'            Case ScreenSize.Mediano
'                AutoSizeForm(middleSize)
'                Me.FontHeight = 14
'            Case ScreenSize.Grande
'                AutoSizeForm(largeSize)
'                Me.FontHeight = 20
'            Case ScreenSize.MuyGrande
'                AutoSizeForm(Screen.PrimaryScreen.WorkingArea.Size)
'                Me.FontHeight = 24
'        End Select

'    End Sub

'    'model
'    Private Sub AutoSizeForm(size As Size)
'        Dim Width As Int32 = size.Width
'        Dim Height As Int32 = size.Height

'        Me.Size = New Size(Width / 4, Height / 2)
'        'setting control's location, size...
'        Me.textBox1.Location = New Point(Width / 10, Height / 8) 'modify To your setting
'        Me.textBox1.Size = New Size(Width / 10, Height / 8) 'modify To your setting
'        Me.textBox1.Font = Me.Font
'        '...
'    End Sub

'End Class

Public Enum ScreenSize
    Pequeño
    Mediano
    Grande
    MuyGrande
End Enum