Imports System.Data.OleDb

Public Class GestionForm
    Dim usuarioConectado As String
    Private Sub GestionForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        usuarioConectado = LoginForm.userConnected
        Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
        Dim adaptador As New OleDbDataAdapter("Select * from Usuarios", conexion)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 
        MenuPrincipalForm.Show()
        Me.Hide()
    End Sub


End Class