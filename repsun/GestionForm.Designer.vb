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
        Me.tlp_categorias = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_icon = New System.Windows.Forms.PictureBox()
        Me.pbx_combustible = New System.Windows.Forms.PictureBox()
        Me.pbx_tienda = New System.Windows.Forms.PictureBox()
        Me.pbx_empleados = New System.Windows.Forms.PictureBox()
        Me.pbx_proveedores = New System.Windows.Forms.PictureBox()
        Me.pbx_clientes = New System.Windows.Forms.PictureBox()
        Me.pbx_salir = New System.Windows.Forms.PictureBox()
        Me.lbl_combustible = New System.Windows.Forms.Label()
        Me.lbl_tienda = New System.Windows.Forms.Label()
        Me.lbl_Empleados = New System.Windows.Forms.Label()
        Me.lbl_proveedores = New System.Windows.Forms.Label()
        Me.lbl_clientes = New System.Windows.Forms.Label()
        Me.tlp_gestion.SuspendLayout()
        Me.tbc_gestion.SuspendLayout()
        CType(Me.pbx_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_categorias.SuspendLayout()
        CType(Me.pbx_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_combustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_tienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_gestion
        '
        Me.tlp_gestion.ColumnCount = 3
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.995657!))
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.64193!))
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.362419!))
        Me.tlp_gestion.Controls.Add(Me.tbc_gestion, 1, 1)
        Me.tlp_gestion.Controls.Add(Me.pbx_close, 2, 0)
        Me.tlp_gestion.Controls.Add(Me.tlp_categorias, 0, 0)
        Me.tlp_gestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_gestion.Location = New System.Drawing.Point(0, 0)
        Me.tlp_gestion.Name = "tlp_gestion"
        Me.tlp_gestion.RowCount = 2
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.425209!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.539203!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.03559!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_gestion.Size = New System.Drawing.Size(1412, 882)
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
        Me.tbc_gestion.Location = New System.Drawing.Point(143, 41)
        Me.tbc_gestion.Margin = New System.Windows.Forms.Padding(2)
        Me.tbc_gestion.Name = "tbc_gestion"
        Me.tlp_gestion.SetRowSpan(Me.tbc_gestion, 2)
        Me.tbc_gestion.SelectedIndex = 0
        Me.tbc_gestion.Size = New System.Drawing.Size(1267, 839)
        Me.tbc_gestion.TabIndex = 2
        '
        'tpg_combustible
        '
        Me.tpg_combustible.Location = New System.Drawing.Point(4, 34)
        Me.tpg_combustible.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_combustible.Name = "tpg_combustible"
        Me.tpg_combustible.Padding = New System.Windows.Forms.Padding(2)
        Me.tpg_combustible.Size = New System.Drawing.Size(1259, 801)
        Me.tpg_combustible.TabIndex = 0
        Me.tpg_combustible.Text = "Combustible"
        Me.tpg_combustible.UseVisualStyleBackColor = True
        '
        'tpg_tienda
        '
        Me.tpg_tienda.Location = New System.Drawing.Point(4, 34)
        Me.tpg_tienda.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_tienda.Name = "tpg_tienda"
        Me.tpg_tienda.Padding = New System.Windows.Forms.Padding(2)
        Me.tpg_tienda.Size = New System.Drawing.Size(1259, 790)
        Me.tpg_tienda.TabIndex = 1
        Me.tpg_tienda.Text = "Tienda"
        Me.tpg_tienda.UseVisualStyleBackColor = True
        '
        'tpg_empleados
        '
        Me.tpg_empleados.Location = New System.Drawing.Point(4, 34)
        Me.tpg_empleados.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_empleados.Name = "tpg_empleados"
        Me.tpg_empleados.Size = New System.Drawing.Size(1259, 790)
        Me.tpg_empleados.TabIndex = 2
        Me.tpg_empleados.Text = "Empleados"
        Me.tpg_empleados.UseVisualStyleBackColor = True
        '
        'tpg_proveedores
        '
        Me.tpg_proveedores.Location = New System.Drawing.Point(4, 34)
        Me.tpg_proveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_proveedores.Name = "tpg_proveedores"
        Me.tpg_proveedores.Size = New System.Drawing.Size(1259, 790)
        Me.tpg_proveedores.TabIndex = 3
        Me.tpg_proveedores.Text = "Proveedores"
        Me.tpg_proveedores.UseVisualStyleBackColor = True
        '
        'tpg_clientes
        '
        Me.tpg_clientes.Location = New System.Drawing.Point(4, 34)
        Me.tpg_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_clientes.Name = "tpg_clientes"
        Me.tpg_clientes.Size = New System.Drawing.Size(1259, 790)
        Me.tpg_clientes.TabIndex = 4
        Me.tpg_clientes.Text = "Clientes"
        Me.tpg_clientes.UseVisualStyleBackColor = True
        '
        'pbx_close
        '
        Me.pbx_close.Image = Global.repsun.My.Resources.Resources.Close
        Me.pbx_close.Location = New System.Drawing.Point(1383, 5)
        Me.pbx_close.Margin = New System.Windows.Forms.Padding(5)
        Me.pbx_close.Name = "pbx_close"
        Me.pbx_close.Size = New System.Drawing.Size(24, 28)
        Me.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_close.TabIndex = 3
        Me.pbx_close.TabStop = False
        '
        'tlp_categorias
        '
        Me.tlp_categorias.ColumnCount = 1
        Me.tlp_categorias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_categorias.Controls.Add(Me.pbx_icon, 0, 0)
        Me.tlp_categorias.Controls.Add(Me.pbx_combustible, 0, 2)
        Me.tlp_categorias.Controls.Add(Me.pbx_tienda, 0, 4)
        Me.tlp_categorias.Controls.Add(Me.pbx_empleados, 0, 6)
        Me.tlp_categorias.Controls.Add(Me.pbx_proveedores, 0, 8)
        Me.tlp_categorias.Controls.Add(Me.pbx_clientes, 0, 10)
        Me.tlp_categorias.Controls.Add(Me.pbx_salir, 0, 12)
        Me.tlp_categorias.Controls.Add(Me.lbl_combustible, 0, 3)
        Me.tlp_categorias.Controls.Add(Me.lbl_tienda, 0, 5)
        Me.tlp_categorias.Controls.Add(Me.lbl_Empleados, 0, 7)
        Me.tlp_categorias.Controls.Add(Me.lbl_proveedores, 0, 9)
        Me.tlp_categorias.Controls.Add(Me.lbl_clientes, 0, 11)
        Me.tlp_categorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_categorias.Location = New System.Drawing.Point(3, 3)
        Me.tlp_categorias.Name = "tlp_categorias"
        Me.tlp_categorias.RowCount = 13
        Me.tlp_gestion.SetRowSpan(Me.tlp_categorias, 3)
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28602!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.143011!))
        Me.tlp_categorias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.140868!))
        Me.tlp_categorias.Size = New System.Drawing.Size(135, 876)
        Me.tlp_categorias.TabIndex = 0
        '
        'pbx_icon
        '
        Me.pbx_icon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_icon.Image = Global.repsun.My.Resources.Resources.Logo_Transparente_2
        Me.pbx_icon.Location = New System.Drawing.Point(3, 3)
        Me.pbx_icon.Name = "pbx_icon"
        Me.pbx_icon.Size = New System.Drawing.Size(129, 119)
        Me.pbx_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_icon.TabIndex = 0
        Me.pbx_icon.TabStop = False
        '
        'pbx_combustible
        '
        Me.pbx_combustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_combustible.Image = Global.repsun.My.Resources.Resources.Combustible
        Me.pbx_combustible.Location = New System.Drawing.Point(3, 190)
        Me.pbx_combustible.Name = "pbx_combustible"
        Me.pbx_combustible.Size = New System.Drawing.Size(129, 56)
        Me.pbx_combustible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_combustible.TabIndex = 1
        Me.pbx_combustible.TabStop = False
        '
        'pbx_tienda
        '
        Me.pbx_tienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_tienda.Image = Global.repsun.My.Resources.Resources.Tienda
        Me.pbx_tienda.Location = New System.Drawing.Point(3, 314)
        Me.pbx_tienda.Name = "pbx_tienda"
        Me.pbx_tienda.Size = New System.Drawing.Size(129, 56)
        Me.pbx_tienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_tienda.TabIndex = 2
        Me.pbx_tienda.TabStop = False
        '
        'pbx_empleados
        '
        Me.pbx_empleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_empleados.Image = Global.repsun.My.Resources.Resources.Empleados
        Me.pbx_empleados.Location = New System.Drawing.Point(3, 438)
        Me.pbx_empleados.Name = "pbx_empleados"
        Me.pbx_empleados.Size = New System.Drawing.Size(129, 56)
        Me.pbx_empleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_empleados.TabIndex = 3
        Me.pbx_empleados.TabStop = False
        '
        'pbx_proveedores
        '
        Me.pbx_proveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_proveedores.Image = Global.repsun.My.Resources.Resources.Proveedores
        Me.pbx_proveedores.Location = New System.Drawing.Point(3, 562)
        Me.pbx_proveedores.Name = "pbx_proveedores"
        Me.pbx_proveedores.Size = New System.Drawing.Size(129, 56)
        Me.pbx_proveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_proveedores.TabIndex = 4
        Me.pbx_proveedores.TabStop = False
        '
        'pbx_clientes
        '
        Me.pbx_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_clientes.Image = Global.repsun.My.Resources.Resources.Clientes
        Me.pbx_clientes.Location = New System.Drawing.Point(3, 686)
        Me.pbx_clientes.Name = "pbx_clientes"
        Me.pbx_clientes.Size = New System.Drawing.Size(129, 56)
        Me.pbx_clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_clientes.TabIndex = 5
        Me.pbx_clientes.TabStop = False
        '
        'pbx_salir
        '
        Me.pbx_salir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_salir.Image = Global.repsun.My.Resources.Resources.Salir
        Me.pbx_salir.Location = New System.Drawing.Point(3, 810)
        Me.pbx_salir.Name = "pbx_salir"
        Me.pbx_salir.Size = New System.Drawing.Size(129, 63)
        Me.pbx_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_salir.TabIndex = 6
        Me.pbx_salir.TabStop = False
        '
        'lbl_combustible
        '
        Me.lbl_combustible.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_combustible.AutoSize = True
        Me.lbl_combustible.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_combustible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_combustible.Location = New System.Drawing.Point(18, 249)
        Me.lbl_combustible.Name = "lbl_combustible"
        Me.lbl_combustible.Size = New System.Drawing.Size(98, 21)
        Me.lbl_combustible.TabIndex = 7
        Me.lbl_combustible.Text = "Combustible"
        '
        'lbl_tienda
        '
        Me.lbl_tienda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_tienda.AutoSize = True
        Me.lbl_tienda.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tienda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_tienda.Location = New System.Drawing.Point(39, 373)
        Me.lbl_tienda.Name = "lbl_tienda"
        Me.lbl_tienda.Size = New System.Drawing.Size(56, 21)
        Me.lbl_tienda.TabIndex = 8
        Me.lbl_tienda.Text = "Tienda"
        '
        'lbl_Empleados
        '
        Me.lbl_Empleados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Empleados.AutoSize = True
        Me.lbl_Empleados.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Empleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_Empleados.Location = New System.Drawing.Point(24, 497)
        Me.lbl_Empleados.Name = "lbl_Empleados"
        Me.lbl_Empleados.Size = New System.Drawing.Size(86, 21)
        Me.lbl_Empleados.TabIndex = 9
        Me.lbl_Empleados.Text = "Empleados"
        '
        'lbl_proveedores
        '
        Me.lbl_proveedores.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_proveedores.AutoSize = True
        Me.lbl_proveedores.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proveedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_proveedores.Location = New System.Drawing.Point(19, 621)
        Me.lbl_proveedores.Name = "lbl_proveedores"
        Me.lbl_proveedores.Size = New System.Drawing.Size(97, 21)
        Me.lbl_proveedores.TabIndex = 10
        Me.lbl_proveedores.Text = "Proveedores"
        '
        'lbl_clientes
        '
        Me.lbl_clientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_clientes.AutoSize = True
        Me.lbl_clientes.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_clientes.Location = New System.Drawing.Point(35, 745)
        Me.lbl_clientes.Name = "lbl_clientes"
        Me.lbl_clientes.Size = New System.Drawing.Size(65, 21)
        Me.lbl_clientes.TabIndex = 11
        Me.lbl_clientes.Text = "Clientes"
        '
        'GestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1412, 882)
        Me.Controls.Add(Me.tlp_gestion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GestionForm"
        Me.Text = "GestionForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_gestion.ResumeLayout(False)
        Me.tbc_gestion.ResumeLayout(False)
        CType(Me.pbx_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_categorias.ResumeLayout(False)
        Me.tlp_categorias.PerformLayout()
        CType(Me.pbx_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_combustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_tienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_salir, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tlp_categorias As TableLayoutPanel
    Friend WithEvents pbx_icon As PictureBox
    Friend WithEvents pbx_combustible As PictureBox
    Friend WithEvents pbx_tienda As PictureBox
    Friend WithEvents pbx_empleados As PictureBox
    Friend WithEvents pbx_proveedores As PictureBox
    Friend WithEvents pbx_clientes As PictureBox
    Friend WithEvents pbx_salir As PictureBox
    Friend WithEvents lbl_combustible As Label
    Friend WithEvents lbl_tienda As Label
    Friend WithEvents lbl_Empleados As Label
    Friend WithEvents lbl_proveedores As Label
    Friend WithEvents lbl_clientes As Label
End Class
