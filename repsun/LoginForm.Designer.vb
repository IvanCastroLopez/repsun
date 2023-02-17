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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_bienvenido = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.lbl_contrasena = New System.Windows.Forms.Label()
        Me.txt_contrasena = New System.Windows.Forms.TextBox()
        Me.btn_inicioSesion = New System.Windows.Forms.Button()
        Me.tlp_login.SuspendLayout()
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
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
        Me.tlp_login.Controls.Add(Me.FlowLayoutPanel2, 3, 2)
        Me.tlp_login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_login.Location = New System.Drawing.Point(0, 0)
        Me.tlp_login.Name = "tlp_login"
        Me.tlp_login.RowCount = 4
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.7!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.5!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.8!))
        Me.tlp_login.Size = New System.Drawing.Size(800, 450)
        Me.tlp_login.TabIndex = 0
        '
        'pbx_logo
        '
        Me.pbx_logo.BackColor = System.Drawing.Color.Transparent
        Me.pbx_logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_logo.Image = Global.repsun.My.Resources.Resources.Logo_Transparente_2
        Me.pbx_logo.Location = New System.Drawing.Point(86, 15)
        Me.pbx_logo.Name = "pbx_logo"
        Me.pbx_logo.Size = New System.Drawing.Size(77, 77)
        Me.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_logo.TabIndex = 0
        Me.pbx_logo.TabStop = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_bienvenido)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_username)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_user)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_contrasena)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_contrasena)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_inicioSesion)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(210, 98)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(587, 286)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'lbl_bienvenido
        '
        Me.lbl_bienvenido.AutoSize = True
        Me.lbl_bienvenido.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenido.Location = New System.Drawing.Point(3, 0)
        Me.lbl_bienvenido.Name = "lbl_bienvenido"
        Me.lbl_bienvenido.Size = New System.Drawing.Size(394, 54)
        Me.lbl_bienvenido.TabIndex = 0
        Me.lbl_bienvenido.Text = "Bienvenido a Repsun"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(3, 54)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(520, 76)
        Me.lbl_username.TabIndex = 1
        Me.lbl_username.Text = "Por favor, identifícate con tu Nombre de usuario:"
        '
        'txt_user
        '
        Me.txt_user.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.txt_user.Location = New System.Drawing.Point(3, 133)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(520, 53)
        Me.txt_user.TabIndex = 2
        '
        'lbl_contrasena
        '
        Me.lbl_contrasena.AutoSize = True
        Me.lbl_contrasena.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!)
        Me.lbl_contrasena.Location = New System.Drawing.Point(3, 189)
        Me.lbl_contrasena.Name = "lbl_contrasena"
        Me.lbl_contrasena.Size = New System.Drawing.Size(162, 38)
        Me.lbl_contrasena.TabIndex = 3
        Me.lbl_contrasena.Text = "Contraseña:"
        '
        'txt_contrasena
        '
        Me.txt_contrasena.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.txt_contrasena.Location = New System.Drawing.Point(3, 230)
        Me.txt_contrasena.Name = "txt_contrasena"
        Me.txt_contrasena.Size = New System.Drawing.Size(520, 53)
        Me.txt_contrasena.TabIndex = 4
        '
        'btn_inicioSesion
        '
        Me.btn_inicioSesion.AutoSize = True
        Me.btn_inicioSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btn_inicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inicioSesion.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicioSesion.ForeColor = System.Drawing.Color.White
        Me.btn_inicioSesion.Location = New System.Drawing.Point(529, 3)
        Me.btn_inicioSesion.Name = "btn_inicioSesion"
        Me.btn_inicioSesion.Padding = New System.Windows.Forms.Padding(12, 32, 11, 32)
        Me.btn_inicioSesion.Size = New System.Drawing.Size(401, 112)
        Me.btn_inicioSesion.TabIndex = 5
        Me.btn_inicioSesion.Text = "Iniciar Sesión"
        Me.btn_inicioSesion.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlp_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_login.ResumeLayout(False)
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_login As TableLayoutPanel
    Friend WithEvents pbx_logo As PictureBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lbl_bienvenido As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents lbl_contrasena As Label
    Friend WithEvents txt_contrasena As TextBox
    Friend WithEvents btn_inicioSesion As Button
End Class
