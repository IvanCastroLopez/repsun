﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.lbl_perdido = New System.Windows.Forms.Label()
        Me.err_errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txt_contrasena = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.pbx_exit = New System.Windows.Forms.PictureBox()
        Me.tlp_inLogin = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_inicioSesion = New System.Windows.Forms.Button()
        Me.lbl_bienvenido = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_contrasena = New System.Windows.Forms.Label()
        Me.pbx_logo = New System.Windows.Forms.PictureBox()
        Me.tlp_login = New System.Windows.Forms.TableLayoutPanel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.err_errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_inLogin.SuspendLayout()
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_login.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_perdido
        '
        Me.lbl_perdido.AutoSize = True
        Me.lbl_perdido.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!)
        Me.lbl_perdido.Location = New System.Drawing.Point(2, 220)
        Me.lbl_perdido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_perdido.Name = "lbl_perdido"
        Me.lbl_perdido.Size = New System.Drawing.Size(220, 51)
        Me.lbl_perdido.TabIndex = 0
        Me.lbl_perdido.Text = "Contraseña"
        '
        'err_errorProvider
        '
        Me.err_errorProvider.ContainerControl = Me
        '
        'txt_contrasena
        '
        Me.txt_contrasena.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.txt_contrasena.ForeColor = System.Drawing.Color.Black
        Me.err_errorProvider.SetIconPadding(Me.txt_contrasena, 5)
        Me.txt_contrasena.Location = New System.Drawing.Point(4, 174)
        Me.txt_contrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_contrasena.MaxLength = 10
        Me.txt_contrasena.Name = "txt_contrasena"
        Me.txt_contrasena.Size = New System.Drawing.Size(526, 44)
        Me.txt_contrasena.TabIndex = 2
        '
        'txt_user
        '
        Me.txt_user.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.txt_user.ForeColor = System.Drawing.Color.Gray
        Me.err_errorProvider.SetIconPadding(Me.txt_user, 5)
        Me.txt_user.Location = New System.Drawing.Point(4, 98)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_user.MaxLength = 20
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(526, 44)
        Me.txt_user.TabIndex = 1
        Me.txt_user.Text = "nombre.apellido1"
        '
        'pbx_exit
        '
        Me.pbx_exit.BackColor = System.Drawing.Color.Transparent
        Me.pbx_exit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_exit.Image = Global.repsun.My.Resources.Resources.Close
        Me.pbx_exit.Location = New System.Drawing.Point(1028, 8)
        Me.pbx_exit.Margin = New System.Windows.Forms.Padding(8)
        Me.pbx_exit.Name = "pbx_exit"
        Me.tlp_login.SetRowSpan(Me.pbx_exit, 2)
        Me.pbx_exit.Size = New System.Drawing.Size(22, 17)
        Me.pbx_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_exit.TabIndex = 2
        Me.pbx_exit.TabStop = False
        '
        'tlp_inLogin
        '
        Me.tlp_inLogin.ColumnCount = 1
        Me.tlp_login.SetColumnSpan(Me.tlp_inLogin, 2)
        Me.tlp_inLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_inLogin.Controls.Add(Me.btn_inicioSesion, 0, 5)
        Me.tlp_inLogin.Controls.Add(Me.txt_contrasena, 0, 4)
        Me.tlp_inLogin.Controls.Add(Me.txt_user, 0, 2)
        Me.tlp_inLogin.Controls.Add(Me.lbl_bienvenido, 0, 0)
        Me.tlp_inLogin.Controls.Add(Me.lbl_username, 0, 1)
        Me.tlp_inLogin.Controls.Add(Me.lbl_contrasena, 0, 3)
        Me.tlp_inLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_inLogin.Location = New System.Drawing.Point(274, 131)
        Me.tlp_inLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.tlp_inLogin.Name = "tlp_inLogin"
        Me.tlp_inLogin.RowCount = 6
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852!))
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.481482!))
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.88889!))
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.481482!))
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.88889!))
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.74074!))
        Me.tlp_inLogin.Size = New System.Drawing.Size(782, 380)
        Me.tlp_inLogin.TabIndex = 0
        '
        'btn_inicioSesion
        '
        Me.btn_inicioSesion.AutoSize = True
        Me.btn_inicioSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btn_inicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inicioSesion.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicioSesion.ForeColor = System.Drawing.Color.White
        Me.btn_inicioSesion.Location = New System.Drawing.Point(0, 222)
        Me.btn_inicioSesion.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_inicioSesion.Name = "btn_inicioSesion"
        Me.btn_inicioSesion.Size = New System.Drawing.Size(389, 61)
        Me.btn_inicioSesion.TabIndex = 3
        Me.btn_inicioSesion.Text = "Iniciar Sesión"
        Me.btn_inicioSesion.UseVisualStyleBackColor = False
        '
        'lbl_bienvenido
        '
        Me.lbl_bienvenido.AutoSize = True
        Me.lbl_bienvenido.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenido.Location = New System.Drawing.Point(2, 0)
        Me.lbl_bienvenido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_bienvenido.Name = "lbl_bienvenido"
        Me.lbl_bienvenido.Size = New System.Drawing.Size(324, 45)
        Me.lbl_bienvenido.TabIndex = 0
        Me.lbl_bienvenido.Text = "Bienvenido a Repsun"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_username.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(2, 70)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(778, 24)
        Me.lbl_username.TabIndex = 0
        Me.lbl_username.Text = "Nombre de usuario"
        '
        'lbl_contrasena
        '
        Me.lbl_contrasena.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_contrasena.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!)
        Me.lbl_contrasena.Location = New System.Drawing.Point(3, 146)
        Me.lbl_contrasena.Name = "lbl_contrasena"
        Me.lbl_contrasena.Size = New System.Drawing.Size(776, 24)
        Me.lbl_contrasena.TabIndex = 4
        Me.lbl_contrasena.Text = "Contraseña"
        '
        'pbx_logo
        '
        Me.pbx_logo.BackColor = System.Drawing.Color.Transparent
        Me.pbx_logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_logo.Image = Global.repsun.My.Resources.Resources.Logo_Transparente_2
        Me.pbx_logo.Location = New System.Drawing.Point(116, 34)
        Me.pbx_logo.Margin = New System.Windows.Forms.Padding(7)
        Me.pbx_logo.Name = "pbx_logo"
        Me.tlp_login.SetRowSpan(Me.pbx_logo, 2)
        Me.pbx_logo.Size = New System.Drawing.Size(95, 88)
        Me.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_logo.TabIndex = 0
        Me.pbx_logo.TabStop = False
        '
        'tlp_login
        '
        Me.tlp_login.BackgroundImage = Global.repsun.My.Resources.Resources.Login_Background
        Me.tlp_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tlp_login.ColumnCount = 5
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.2!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.83334!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.333333!))
        Me.tlp_login.Controls.Add(Me.pbx_logo, 1, 1)
        Me.tlp_login.Controls.Add(Me.tlp_inLogin, 3, 3)
        Me.tlp_login.Controls.Add(Me.pbx_exit, 4, 0)
        Me.tlp_login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_login.Location = New System.Drawing.Point(0, 0)
        Me.tlp_login.Margin = New System.Windows.Forms.Padding(4)
        Me.tlp_login.Name = "tlp_login"
        Me.tlp_login.RowCount = 5
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.555809!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.025057!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.17312!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.35644!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.66337!))
        Me.tlp_login.Size = New System.Drawing.Size(1058, 596)
        Me.tlp_login.TabIndex = 0
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = ".\Debug\Repsun_Ayuda.chm"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1058, 596)
        Me.Controls.Add(Me.tlp_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginForm"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.err_errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_exit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_inLogin.ResumeLayout(False)
        Me.tlp_inLogin.PerformLayout()
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_login.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_perdido As Label
    Friend WithEvents err_errorProvider As ErrorProvider
    Friend WithEvents tlp_login As TableLayoutPanel
    Friend WithEvents pbx_logo As PictureBox
    Friend WithEvents tlp_inLogin As TableLayoutPanel
    Friend WithEvents btn_inicioSesion As Button
    Friend WithEvents txt_contrasena As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents lbl_bienvenido As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_contrasena As Label
    Friend WithEvents pbx_exit As PictureBox
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
