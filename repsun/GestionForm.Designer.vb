<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_bienvenido = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.lbl_contrasena = New System.Windows.Forms.Label()
        Me.txt_contrasena = New System.Windows.Forms.TextBox()
        Me.btn_inicioSesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_bienvenido
        '
        Me.lbl_bienvenido.AutoSize = True
        Me.lbl_bienvenido.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenido.Location = New System.Drawing.Point(317, 198)
        Me.lbl_bienvenido.Name = "lbl_bienvenido"
        Me.lbl_bienvenido.Size = New System.Drawing.Size(394, 54)
        Me.lbl_bienvenido.TabIndex = 6
        Me.lbl_bienvenido.Text = "Bienvenido a Repsun"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(317, 252)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(617, 38)
        Me.lbl_username.TabIndex = 7
        Me.lbl_username.Text = "Por favor, identifícate con tu Nombre de usuario:"
        '
        'txt_user
        '
        Me.txt_user.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.txt_user.Location = New System.Drawing.Point(520, 0)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(520, 53)
        Me.txt_user.TabIndex = 8
        '
        'lbl_contrasena
        '
        Me.lbl_contrasena.AutoSize = True
        Me.lbl_contrasena.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!)
        Me.lbl_contrasena.Location = New System.Drawing.Point(317, 349)
        Me.lbl_contrasena.Name = "lbl_contrasena"
        Me.lbl_contrasena.Size = New System.Drawing.Size(162, 38)
        Me.lbl_contrasena.TabIndex = 9
        Me.lbl_contrasena.Text = "Contraseña:"
        '
        'txt_contrasena
        '
        Me.txt_contrasena.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.txt_contrasena.Location = New System.Drawing.Point(0, 0)
        Me.txt_contrasena.Name = "txt_contrasena"
        Me.txt_contrasena.Size = New System.Drawing.Size(520, 53)
        Me.txt_contrasena.TabIndex = 10
        '
        'btn_inicioSesion
        '
        Me.btn_inicioSesion.AutoSize = True
        Me.btn_inicioSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btn_inicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_inicioSesion.Font = New System.Drawing.Font("Yu Gothic UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicioSesion.ForeColor = System.Drawing.Color.White
        Me.btn_inicioSesion.Location = New System.Drawing.Point(317, 449)
        Me.btn_inicioSesion.Name = "btn_inicioSesion"
        Me.btn_inicioSesion.Padding = New System.Windows.Forms.Padding(12, 32, 11, 32)
        Me.btn_inicioSesion.Size = New System.Drawing.Size(401, 112)
        Me.btn_inicioSesion.TabIndex = 11
        Me.btn_inicioSesion.Text = "Iniciar Sesión"
        Me.btn_inicioSesion.UseVisualStyleBackColor = False
        '
        'GestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1669, 759)
        Me.Controls.Add(Me.lbl_bienvenido)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_contrasena)
        Me.Controls.Add(Me.txt_contrasena)
        Me.Controls.Add(Me.btn_inicioSesion)
        Me.Name = "GestionForm"
        Me.Text = "GestionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_bienvenido As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents lbl_contrasena As Label
    Friend WithEvents txt_contrasena As TextBox
    Friend WithEvents btn_inicioSesion As Button
End Class
