<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.tlp_login = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_logo = New System.Windows.Forms.PictureBox()
        Me.tlp_inLogin = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_bienvenido = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txt_contrasena = New System.Windows.Forms.TextBox()
        Me.lbl_contrasena = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.btn_inicioSesion = New System.Windows.Forms.Button()
        Me.tlp_login.SuspendLayout()
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_inLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_login
        '
        Me.tlp_login.BackgroundImage = Global.repsun.My.Resources.Resources.Login_Background
        Me.tlp_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tlp_login.ColumnCount = 4
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.2!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.0!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_login.Controls.Add(Me.pbx_logo, 1, 1)
        Me.tlp_login.Controls.Add(Me.tlp_inLogin, 3, 2)
        Me.tlp_login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_login.Location = New System.Drawing.Point(0, 0)
        Me.tlp_login.Name = "tlp_login"
        Me.tlp_login.RowCount = 4
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.7!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.5!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.8!))
        Me.tlp_login.Size = New System.Drawing.Size(1920, 1080)
        Me.tlp_login.TabIndex = 0
        '
        'pbx_logo
        '
        Me.pbx_logo.BackColor = System.Drawing.Color.Transparent
        Me.pbx_logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_logo.Image = Global.repsun.My.Resources.Resources.Logo_Transparente_2
        Me.pbx_logo.Location = New System.Drawing.Point(202, 32)
        Me.pbx_logo.Name = "pbx_logo"
        Me.pbx_logo.Size = New System.Drawing.Size(193, 193)
        Me.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_logo.TabIndex = 0
        Me.pbx_logo.TabStop = False
        '
        'tlp_inLogin
        '
        Me.tlp_inLogin.ColumnCount = 3
        Me.tlp_inLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.47142!))
        Me.tlp_inLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 664.0!))
        Me.tlp_inLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.tlp_inLogin.Controls.Add(Me.btn_inicioSesion, 0, 5)
        Me.tlp_inLogin.Controls.Add(Me.txt_user, 0, 4)
        Me.tlp_inLogin.Controls.Add(Me.lbl_contrasena, 0, 3)
        Me.tlp_inLogin.Controls.Add(Me.txt_contrasena, 0, 2)
        Me.tlp_inLogin.Controls.Add(Me.lbl_bienvenido, 0, 0)
        Me.tlp_inLogin.Controls.Add(Me.lbl_username, 0, 1)
        Me.tlp_inLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_inLogin.Location = New System.Drawing.Point(500, 231)
        Me.tlp_inLogin.Name = "tlp_inLogin"
        Me.tlp_inLogin.RowCount = 6
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.tlp_inLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 274.0!))
        Me.tlp_inLogin.Size = New System.Drawing.Size(1417, 696)
        Me.tlp_inLogin.TabIndex = 1
        '
        'lbl_bienvenido
        '
        Me.lbl_bienvenido.AutoSize = True
        Me.lbl_bienvenido.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenido.Location = New System.Drawing.Point(3, 0)
        Me.lbl_bienvenido.Name = "lbl_bienvenido"
        Me.lbl_bienvenido.Size = New System.Drawing.Size(394, 54)
        Me.lbl_bienvenido.TabIndex = 7
        Me.lbl_bienvenido.Text = "Bienvenido a Repsun"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(3, 145)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(520, 58)
        Me.lbl_username.TabIndex = 8
        Me.lbl_username.Text = "Por favor, identifícate con tu Nombre de usuario:"
        '
        'txt_contrasena
        '
        Me.txt_contrasena.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.txt_contrasena.Location = New System.Drawing.Point(3, 206)
        Me.txt_contrasena.Name = "txt_contrasena"
        Me.txt_contrasena.Size = New System.Drawing.Size(520, 53)
        Me.txt_contrasena.TabIndex = 11
        '
        'lbl_contrasena
        '
        Me.lbl_contrasena.AutoSize = True
        Me.lbl_contrasena.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!)
        Me.lbl_contrasena.Location = New System.Drawing.Point(3, 287)
        Me.lbl_contrasena.Name = "lbl_contrasena"
        Me.lbl_contrasena.Size = New System.Drawing.Size(162, 38)
        Me.lbl_contrasena.TabIndex = 12
        Me.lbl_contrasena.Text = "Contraseña:"
        '
        'txt_user
        '
        Me.txt_user.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.txt_user.Location = New System.Drawing.Point(3, 343)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(520, 53)
        Me.txt_user.TabIndex = 13
        '
        'btn_inicioSesion
        '
        Me.btn_inicioSesion.AutoSize = True
        Me.btn_inicioSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btn_inicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inicioSesion.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicioSesion.ForeColor = System.Drawing.Color.White
        Me.btn_inicioSesion.Location = New System.Drawing.Point(3, 424)
        Me.btn_inicioSesion.Name = "btn_inicioSesion"
        Me.btn_inicioSesion.Padding = New System.Windows.Forms.Padding(12, 32, 11, 32)
        Me.btn_inicioSesion.Size = New System.Drawing.Size(401, 112)
        Me.btn_inicioSesion.TabIndex = 14
        Me.btn_inicioSesion.Text = "Iniciar Sesión"
        Me.btn_inicioSesion.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.tlp_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_login.ResumeLayout(False)
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_inLogin.ResumeLayout(False)
        Me.tlp_inLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_login As TableLayoutPanel
    Friend WithEvents pbx_logo As PictureBox
    Friend WithEvents tlp_inLogin As TableLayoutPanel
    Friend WithEvents lbl_bienvenido As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents txt_contrasena As TextBox
    Friend WithEvents lbl_contrasena As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents btn_inicioSesion As Button
End Class
