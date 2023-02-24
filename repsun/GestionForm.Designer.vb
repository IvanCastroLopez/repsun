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
        Me.tlp_botonesGestion = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.tlp_gestion.SuspendLayout()
        Me.tbc_gestion.SuspendLayout()
        Me.tlp_botonesGestion.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_gestion
        '
        Me.tlp_gestion.ColumnCount = 3
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.67857!))
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.363445!))
        Me.tlp_gestion.Controls.Add(Me.tbc_gestion, 1, 1)
        Me.tlp_gestion.Controls.Add(Me.tlp_botonesGestion, 0, 0)
        Me.tlp_gestion.Controls.Add(Me.PictureBox1, 2, 0)
        Me.tlp_gestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_gestion.Location = New System.Drawing.Point(0, 0)
        Me.tlp_gestion.Name = "tlp_gestion"
        Me.tlp_gestion.RowCount = 3
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.418828!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.536984!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.9!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_gestion.Size = New System.Drawing.Size(1904, 1041)
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
        Me.tbc_gestion.Location = New System.Drawing.Point(382, 48)
        Me.tbc_gestion.Margin = New System.Windows.Forms.Padding(2)
        Me.tbc_gestion.Name = "tbc_gestion"
        Me.tlp_gestion.SetRowSpan(Me.tbc_gestion, 2)
        Me.tbc_gestion.SelectedIndex = 0
        Me.tbc_gestion.Size = New System.Drawing.Size(1520, 991)
        Me.tbc_gestion.TabIndex = 2
        '
        'tpg_combustible
        '
        Me.tpg_combustible.Location = New System.Drawing.Point(4, 34)
        Me.tpg_combustible.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_combustible.Name = "tpg_combustible"
        Me.tpg_combustible.Padding = New System.Windows.Forms.Padding(2)
        Me.tpg_combustible.Size = New System.Drawing.Size(1512, 953)
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
        Me.tpg_tienda.Size = New System.Drawing.Size(1512, 953)
        Me.tpg_tienda.TabIndex = 1
        Me.tpg_tienda.Text = "Tienda"
        Me.tpg_tienda.UseVisualStyleBackColor = True
        '
        'tpg_empleados
        '
        Me.tpg_empleados.Location = New System.Drawing.Point(4, 34)
        Me.tpg_empleados.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_empleados.Name = "tpg_empleados"
        Me.tpg_empleados.Size = New System.Drawing.Size(1512, 953)
        Me.tpg_empleados.TabIndex = 2
        Me.tpg_empleados.Text = "Empleados"
        Me.tpg_empleados.UseVisualStyleBackColor = True
        '
        'tpg_proveedores
        '
        Me.tpg_proveedores.Location = New System.Drawing.Point(4, 34)
        Me.tpg_proveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_proveedores.Name = "tpg_proveedores"
        Me.tpg_proveedores.Size = New System.Drawing.Size(1512, 953)
        Me.tpg_proveedores.TabIndex = 3
        Me.tpg_proveedores.Text = "Proveedores"
        Me.tpg_proveedores.UseVisualStyleBackColor = True
        '
        'tpg_clientes
        '
        Me.tpg_clientes.Location = New System.Drawing.Point(4, 34)
        Me.tpg_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_clientes.Name = "tpg_clientes"
        Me.tpg_clientes.Size = New System.Drawing.Size(1512, 953)
        Me.tpg_clientes.TabIndex = 4
        Me.tpg_clientes.Text = "Clientes"
        Me.tpg_clientes.UseVisualStyleBackColor = True
        '
        'tlp_botonesGestion
        '
        Me.tlp_botonesGestion.ColumnCount = 1
        Me.tlp_botonesGestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_botonesGestion.Controls.Add(Me.btn_delete, 0, 4)
        Me.tlp_botonesGestion.Controls.Add(Me.btn_update, 0, 3)
        Me.tlp_botonesGestion.Controls.Add(Me.btn_read, 0, 2)
        Me.tlp_botonesGestion.Controls.Add(Me.PictureBox2, 0, 0)
        Me.tlp_botonesGestion.Controls.Add(Me.btn_create, 0, 1)
        Me.tlp_botonesGestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_botonesGestion.Location = New System.Drawing.Point(3, 3)
        Me.tlp_botonesGestion.Name = "tlp_botonesGestion"
        Me.tlp_botonesGestion.RowCount = 5
        Me.tlp_gestion.SetRowSpan(Me.tlp_botonesGestion, 3)
        Me.tlp_botonesGestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.13698!))
        Me.tlp_botonesGestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.96576!))
        Me.tlp_botonesGestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.96576!))
        Me.tlp_botonesGestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.96576!))
        Me.tlp_botonesGestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.96576!))
        Me.tlp_botonesGestion.Size = New System.Drawing.Size(374, 1035)
        Me.tlp_botonesGestion.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.repsun.My.Resources.Resources.Logo_Transparente_2
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(30)
        Me.PictureBox2.Size = New System.Drawing.Size(368, 368)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.repsun.My.Resources.Resources.Close
        Me.PictureBox1.Location = New System.Drawing.Point(1863, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btn_create
        '
        Me.btn_create.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_create.Location = New System.Drawing.Point(30, 404)
        Me.btn_create.Margin = New System.Windows.Forms.Padding(30)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(314, 105)
        Me.btn_create.TabIndex = 1
        Me.btn_create.Text = "Crear"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'btn_read
        '
        Me.btn_read.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_read.Location = New System.Drawing.Point(30, 569)
        Me.btn_read.Margin = New System.Windows.Forms.Padding(30)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(314, 105)
        Me.btn_read.TabIndex = 2
        Me.btn_read.Text = "Buscar"
        Me.btn_read.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_update.Location = New System.Drawing.Point(30, 734)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(30)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(314, 105)
        Me.btn_update.TabIndex = 3
        Me.btn_update.Text = "Modificar"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_delete.Location = New System.Drawing.Point(30, 899)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(30)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(314, 106)
        Me.btn_delete.TabIndex = 4
        Me.btn_delete.Text = "Eliminar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'GestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.tlp_gestion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GestionForm"
        Me.Text = "GestionForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_gestion.ResumeLayout(False)
        Me.tbc_gestion.ResumeLayout(False)
        Me.tlp_botonesGestion.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_gestion As TableLayoutPanel
    Friend WithEvents tlp_botonesGestion As TableLayoutPanel
    Friend WithEvents tbc_gestion As TabControl
    Friend WithEvents tpg_combustible As TabPage
    Friend WithEvents tpg_tienda As TabPage
    Friend WithEvents tpg_empleados As TabPage
    Friend WithEvents tpg_proveedores As TabPage
    Friend WithEvents tpg_clientes As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_create As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_read As Button
End Class
