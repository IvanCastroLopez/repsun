<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionForm
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
        Me.tlp_gestion = New System.Windows.Forms.TableLayoutPanel()
        Me.tbc_gestion = New System.Windows.Forms.TabControl()
        Me.tpg_combustible = New System.Windows.Forms.TabPage()
        Me.tpg_tienda = New System.Windows.Forms.TabPage()
        Me.tpg_empleados = New System.Windows.Forms.TabPage()
        Me.tpg_proveedores = New System.Windows.Forms.TabPage()
        Me.tpg_clientes = New System.Windows.Forms.TabPage()
        Me.pbx_close = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbx_combustible = New System.Windows.Forms.PictureBox()
        Me.pbx_logo = New System.Windows.Forms.PictureBox()
        Me.pbx_tienda = New System.Windows.Forms.PictureBox()
        Me.pbx_empleados = New System.Windows.Forms.PictureBox()
        Me.pbx_salir = New System.Windows.Forms.PictureBox()
        Me.pbx_clientes = New System.Windows.Forms.PictureBox()
        Me.pbx_proveedores = New System.Windows.Forms.PictureBox()
        Me.tlp_gestion.SuspendLayout()
        Me.tbc_gestion.SuspendLayout()
        CType(Me.pbx_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbx_combustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_tienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_gestion
        '
        Me.tlp_gestion.ColumnCount = 3
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.995658!))
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.64193!))
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.362419!))
        Me.tlp_gestion.Controls.Add(Me.tbc_gestion, 1, 1)
        Me.tlp_gestion.Controls.Add(Me.pbx_close, 2, 0)
        Me.tlp_gestion.Controls.Add(Me.Panel1, 0, 0)
        Me.tlp_gestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_gestion.Location = New System.Drawing.Point(0, 0)
        Me.tlp_gestion.Margin = New System.Windows.Forms.Padding(6)
        Me.tlp_gestion.Name = "tlp_gestion"
        Me.tlp_gestion.RowCount = 3
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.425209!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.539203!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.03559!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_gestion.Size = New System.Drawing.Size(2588, 1628)
        Me.tlp_gestion.TabIndex = 0
        '
        'tbc_gestion
        '
        Me.tlp_gestion.SetColumnSpan(Me.tbc_gestion, 2)
        Me.tbc_gestion.Controls.Add(Me.tpg_combustible)
        Me.tbc_gestion.Controls.Add(Me.tpg_tienda)
        Me.tbc_gestion.Controls.Add(Me.tpg_empleados)
        Me.tbc_gestion.Controls.Add(Me.tpg_proveedores)
        Me.tbc_gestion.Controls.Add(Me.tpg_clientes)
        Me.tbc_gestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbc_gestion.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc_gestion.Location = New System.Drawing.Point(262, 76)
        Me.tbc_gestion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbc_gestion.Name = "tbc_gestion"
        Me.tlp_gestion.SetRowSpan(Me.tbc_gestion, 2)
        Me.tbc_gestion.SelectedIndex = 0
        Me.tbc_gestion.Size = New System.Drawing.Size(2322, 1548)
        Me.tbc_gestion.TabIndex = 2
        '
        'tpg_combustible
        '
        Me.tpg_combustible.Location = New System.Drawing.Point(4, 54)
        Me.tpg_combustible.Margin = New System.Windows.Forms.Padding(4)
        Me.tpg_combustible.Name = "tpg_combustible"
        Me.tpg_combustible.Padding = New System.Windows.Forms.Padding(4)
        Me.tpg_combustible.Size = New System.Drawing.Size(2314, 1490)
        Me.tpg_combustible.TabIndex = 0
        Me.tpg_combustible.Text = "Combustible"
        Me.tpg_combustible.UseVisualStyleBackColor = True
        '
        'tpg_tienda
        '
        Me.tpg_tienda.Location = New System.Drawing.Point(4, 54)
        Me.tpg_tienda.Margin = New System.Windows.Forms.Padding(4)
        Me.tpg_tienda.Name = "tpg_tienda"
        Me.tpg_tienda.Padding = New System.Windows.Forms.Padding(4)
        Me.tpg_tienda.Size = New System.Drawing.Size(2314, 1490)
        Me.tpg_tienda.TabIndex = 1
        Me.tpg_tienda.Text = "Tienda"
        Me.tpg_tienda.UseVisualStyleBackColor = True
        '
        'tpg_empleados
        '
        Me.tpg_empleados.Location = New System.Drawing.Point(4, 54)
        Me.tpg_empleados.Margin = New System.Windows.Forms.Padding(4)
        Me.tpg_empleados.Name = "tpg_empleados"
        Me.tpg_empleados.Size = New System.Drawing.Size(2314, 1490)
        Me.tpg_empleados.TabIndex = 2
        Me.tpg_empleados.Text = "Empleados"
        Me.tpg_empleados.UseVisualStyleBackColor = True
        '
        'tpg_proveedores
        '
        Me.tpg_proveedores.Location = New System.Drawing.Point(4, 54)
        Me.tpg_proveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.tpg_proveedores.Name = "tpg_proveedores"
        Me.tpg_proveedores.Size = New System.Drawing.Size(2314, 1490)
        Me.tpg_proveedores.TabIndex = 3
        Me.tpg_proveedores.Text = "Proveedores"
        Me.tpg_proveedores.UseVisualStyleBackColor = True
        '
        'tpg_clientes
        '
        Me.tpg_clientes.Location = New System.Drawing.Point(4, 54)
        Me.tpg_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.tpg_clientes.Name = "tpg_clientes"
        Me.tpg_clientes.Size = New System.Drawing.Size(2314, 1490)
        Me.tpg_clientes.TabIndex = 4
        Me.tpg_clientes.Text = "Clientes"
        Me.tpg_clientes.UseVisualStyleBackColor = True
        '
        'pbx_close
        '
        Me.pbx_close.Location = New System.Drawing.Point(2535, 9)
        Me.pbx_close.Margin = New System.Windows.Forms.Padding(9)
        Me.pbx_close.Name = "pbx_close"
        Me.pbx_close.Size = New System.Drawing.Size(44, 54)
        Me.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_close.TabIndex = 3
        Me.pbx_close.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.pbx_combustible)
        Me.Panel1.Controls.Add(Me.pbx_logo)
        Me.Panel1.Controls.Add(Me.pbx_tienda)
        Me.Panel1.Controls.Add(Me.pbx_empleados)
        Me.Panel1.Controls.Add(Me.pbx_salir)
        Me.Panel1.Controls.Add(Me.pbx_clientes)
        Me.Panel1.Controls.Add(Me.pbx_proveedores)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20)
        Me.tlp_gestion.SetRowSpan(Me.Panel1, 3)
        Me.Panel1.Size = New System.Drawing.Size(250, 1620)
        Me.Panel1.TabIndex = 4
        '
        'pbx_combustible
        '
        Me.pbx_combustible.Image = Global.repsun.My.Resources.Resources.Combustible
        Me.pbx_combustible.Location = New System.Drawing.Point(0, 201)
        Me.pbx_combustible.Margin = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.pbx_combustible.Name = "pbx_combustible"
        Me.pbx_combustible.Size = New System.Drawing.Size(249, 93)
        Me.pbx_combustible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_combustible.TabIndex = 14
        Me.pbx_combustible.TabStop = False
        '
        'pbx_logo
        '
        Me.pbx_logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbx_logo.Image = Global.repsun.My.Resources.Resources.Logo_Transparente_2
        Me.pbx_logo.Location = New System.Drawing.Point(20, 20)
        Me.pbx_logo.Margin = New System.Windows.Forms.Padding(4)
        Me.pbx_logo.Name = "pbx_logo"
        Me.pbx_logo.Size = New System.Drawing.Size(210, 157)
        Me.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_logo.TabIndex = 7
        Me.pbx_logo.TabStop = False
        '
        'pbx_tienda
        '
        Me.pbx_tienda.Image = Global.repsun.My.Resources.Resources.Tienda
        Me.pbx_tienda.Location = New System.Drawing.Point(0, 339)
        Me.pbx_tienda.Margin = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.pbx_tienda.Name = "pbx_tienda"
        Me.pbx_tienda.Size = New System.Drawing.Size(249, 93)
        Me.pbx_tienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_tienda.TabIndex = 15
        Me.pbx_tienda.TabStop = False
        '
        'pbx_empleados
        '
        Me.pbx_empleados.Image = Global.repsun.My.Resources.Resources.Empleados
        Me.pbx_empleados.Location = New System.Drawing.Point(0, 480)
        Me.pbx_empleados.Margin = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.pbx_empleados.Name = "pbx_empleados"
        Me.pbx_empleados.Size = New System.Drawing.Size(249, 93)
        Me.pbx_empleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_empleados.TabIndex = 16
        Me.pbx_empleados.TabStop = False
        '
        'pbx_salir
        '
        Me.pbx_salir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbx_salir.Image = Global.repsun.My.Resources.Resources.Salir
        Me.pbx_salir.Location = New System.Drawing.Point(20, 1510)
        Me.pbx_salir.Margin = New System.Windows.Forms.Padding(4)
        Me.pbx_salir.Name = "pbx_salir"
        Me.pbx_salir.Size = New System.Drawing.Size(210, 90)
        Me.pbx_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_salir.TabIndex = 12
        Me.pbx_salir.TabStop = False
        '
        'pbx_clientes
        '
        Me.pbx_clientes.Image = Global.repsun.My.Resources.Resources.Proveedores
        Me.pbx_clientes.Location = New System.Drawing.Point(0, 614)
        Me.pbx_clientes.Margin = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.pbx_clientes.Name = "pbx_clientes"
        Me.pbx_clientes.Size = New System.Drawing.Size(249, 92)
        Me.pbx_clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_clientes.TabIndex = 17
        Me.pbx_clientes.TabStop = False
        '
        'pbx_proveedores
        '
        Me.pbx_proveedores.Image = Global.repsun.My.Resources.Resources.Clientes
        Me.pbx_proveedores.Location = New System.Drawing.Point(0, 757)
        Me.pbx_proveedores.Margin = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.pbx_proveedores.Name = "pbx_proveedores"
        Me.pbx_proveedores.Size = New System.Drawing.Size(249, 92)
        Me.pbx_proveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_proveedores.TabIndex = 18
        Me.pbx_proveedores.TabStop = False
        '
        'GestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2588, 1628)
        Me.Controls.Add(Me.tlp_gestion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GestionForm"
        Me.Text = "GestionForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_gestion.ResumeLayout(False)
        Me.tbc_gestion.ResumeLayout(False)
        CType(Me.pbx_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbx_combustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_tienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_gestion As TableLayoutPanel
    Friend WithEvents tbc_gestion As TabControl
    Friend WithEvents tpg_combustible As TabPage
    Friend WithEvents tpg_tienda As TabPage
    Friend WithEvents tpg_empleados As TabPage
    Friend WithEvents tpg_proveedores As TabPage
    Friend WithEvents tpg_clientes As TabPage
    Friend WithEvents pbx_close As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbx_logo As PictureBox
    Friend WithEvents pbx_salir As PictureBox
    Friend WithEvents pbx_combustible As PictureBox
    Friend WithEvents pbx_tienda As PictureBox
    Friend WithEvents pbx_empleados As PictureBox
    Friend WithEvents pbx_clientes As PictureBox
    Friend WithEvents pbx_proveedores As PictureBox
End Class
