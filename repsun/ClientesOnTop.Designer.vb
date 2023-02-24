<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientesOnTop
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
        Me.tbc_gestion = New System.Windows.Forms.TabControl()
        Me.tpg_combustible = New System.Windows.Forms.TabPage()
        Me.tpg_tienda = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_tienda = New System.Windows.Forms.DataGridView()
        Me.tlp_botones = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_create = New System.Windows.Forms.PictureBox()
        Me.pbx_read = New System.Windows.Forms.PictureBox()
        Me.pbx_update = New System.Windows.Forms.PictureBox()
        Me.pbx_delete = New System.Windows.Forms.PictureBox()
        Me.tpg_empleados = New System.Windows.Forms.TabPage()
        Me.tpg_proveedores = New System.Windows.Forms.TabPage()
        Me.tpg_clientes = New System.Windows.Forms.TabPage()
        Me.tbc_gestion.SuspendLayout()
        Me.tpg_tienda.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv_tienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_botones.SuspendLayout()
        CType(Me.pbx_create, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_read, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbc_gestion
        '
        Me.tbc_gestion.Controls.Add(Me.tpg_combustible)
        Me.tbc_gestion.Controls.Add(Me.tpg_tienda)
        Me.tbc_gestion.Controls.Add(Me.tpg_empleados)
        Me.tbc_gestion.Controls.Add(Me.tpg_proveedores)
        Me.tbc_gestion.Controls.Add(Me.tpg_clientes)
        Me.tbc_gestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbc_gestion.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc_gestion.Location = New System.Drawing.Point(0, 0)
        Me.tbc_gestion.Margin = New System.Windows.Forms.Padding(2)
        Me.tbc_gestion.Name = "tbc_gestion"
        Me.tbc_gestion.SelectedIndex = 0
        Me.tbc_gestion.Size = New System.Drawing.Size(1243, 762)
        Me.tbc_gestion.TabIndex = 1
        '
        'tpg_combustible
        '
        Me.tpg_combustible.Location = New System.Drawing.Point(4, 34)
        Me.tpg_combustible.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_combustible.Name = "tpg_combustible"
        Me.tpg_combustible.Padding = New System.Windows.Forms.Padding(2)
        Me.tpg_combustible.Size = New System.Drawing.Size(1235, 724)
        Me.tpg_combustible.TabIndex = 0
        Me.tpg_combustible.Text = "Combustible"
        Me.tpg_combustible.UseVisualStyleBackColor = True
        '
        'tpg_tienda
        '
        Me.tpg_tienda.Controls.Add(Me.TableLayoutPanel1)
        Me.tpg_tienda.Location = New System.Drawing.Point(4, 34)
        Me.tpg_tienda.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_tienda.Name = "tpg_tienda"
        Me.tpg_tienda.Padding = New System.Windows.Forms.Padding(2)
        Me.tpg_tienda.Size = New System.Drawing.Size(1235, 724)
        Me.tpg_tienda.TabIndex = 1
        Me.tpg_tienda.Text = "Tienda"
        Me.tpg_tienda.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgv_tienda, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tlp_botones, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1231, 720)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgv_tienda
        '
        Me.dgv_tienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_tienda.Location = New System.Drawing.Point(310, 75)
        Me.dgv_tienda.Name = "dgv_tienda"
        Me.dgv_tienda.Size = New System.Drawing.Size(918, 642)
        Me.dgv_tienda.TabIndex = 0
        '
        'tlp_botones
        '
        Me.tlp_botones.ColumnCount = 1
        Me.tlp_botones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_botones.Controls.Add(Me.pbx_create, 0, 1)
        Me.tlp_botones.Controls.Add(Me.pbx_read, 0, 3)
        Me.tlp_botones.Controls.Add(Me.pbx_update, 0, 5)
        Me.tlp_botones.Controls.Add(Me.pbx_delete, 0, 7)
        Me.tlp_botones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_botones.Location = New System.Drawing.Point(3, 75)
        Me.tlp_botones.Name = "tlp_botones"
        Me.tlp_botones.RowCount = 9
        Me.tlp_botones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlp_botones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlp_botones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlp_botones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlp_botones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlp_botones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlp_botones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlp_botones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlp_botones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tlp_botones.Size = New System.Drawing.Size(301, 642)
        Me.tlp_botones.TabIndex = 1
        '
        'pbx_create
        '
        Me.pbx_create.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_create.Image = Global.repsun.My.Resources.Resources.Anadir
        Me.pbx_create.Location = New System.Drawing.Point(3, 74)
        Me.pbx_create.Name = "pbx_create"
        Me.pbx_create.Size = New System.Drawing.Size(295, 65)
        Me.pbx_create.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_create.TabIndex = 0
        Me.pbx_create.TabStop = False
        '
        'pbx_read
        '
        Me.pbx_read.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_read.Image = Global.repsun.My.Resources.Resources.Buscar
        Me.pbx_read.Location = New System.Drawing.Point(3, 216)
        Me.pbx_read.Name = "pbx_read"
        Me.pbx_read.Size = New System.Drawing.Size(295, 65)
        Me.pbx_read.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_read.TabIndex = 1
        Me.pbx_read.TabStop = False
        '
        'pbx_update
        '
        Me.pbx_update.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_update.Image = Global.repsun.My.Resources.Resources.Modificar
        Me.pbx_update.Location = New System.Drawing.Point(3, 358)
        Me.pbx_update.Name = "pbx_update"
        Me.pbx_update.Size = New System.Drawing.Size(295, 65)
        Me.pbx_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_update.TabIndex = 2
        Me.pbx_update.TabStop = False
        '
        'pbx_delete
        '
        Me.pbx_delete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_delete.Image = Global.repsun.My.Resources.Resources.Eliminar
        Me.pbx_delete.Location = New System.Drawing.Point(3, 500)
        Me.pbx_delete.Name = "pbx_delete"
        Me.pbx_delete.Size = New System.Drawing.Size(295, 65)
        Me.pbx_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_delete.TabIndex = 3
        Me.pbx_delete.TabStop = False
        '
        'tpg_empleados
        '
        Me.tpg_empleados.Location = New System.Drawing.Point(4, 34)
        Me.tpg_empleados.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_empleados.Name = "tpg_empleados"
        Me.tpg_empleados.Size = New System.Drawing.Size(1235, 724)
        Me.tpg_empleados.TabIndex = 2
        Me.tpg_empleados.Text = "Empleados"
        Me.tpg_empleados.UseVisualStyleBackColor = True
        '
        'tpg_proveedores
        '
        Me.tpg_proveedores.Location = New System.Drawing.Point(4, 34)
        Me.tpg_proveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_proveedores.Name = "tpg_proveedores"
        Me.tpg_proveedores.Size = New System.Drawing.Size(1235, 724)
        Me.tpg_proveedores.TabIndex = 3
        Me.tpg_proveedores.Text = "Proveedores"
        Me.tpg_proveedores.UseVisualStyleBackColor = True
        '
        'tpg_clientes
        '
        Me.tpg_clientes.Location = New System.Drawing.Point(4, 34)
        Me.tpg_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_clientes.Name = "tpg_clientes"
        Me.tpg_clientes.Size = New System.Drawing.Size(1235, 724)
        Me.tpg_clientes.TabIndex = 4
        Me.tpg_clientes.Text = "Clientes"
        Me.tpg_clientes.UseVisualStyleBackColor = True
        '
        'ClientesOnTop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 762)
        Me.Controls.Add(Me.tbc_gestion)
        Me.Name = "ClientesOnTop"
        Me.Text = "ClientesOnTop"
        Me.tbc_gestion.ResumeLayout(False)
        Me.tpg_tienda.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv_tienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_botones.ResumeLayout(False)
        CType(Me.pbx_create, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_read, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_delete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbc_gestion As TabControl
    Friend WithEvents tpg_combustible As TabPage
    Friend WithEvents tpg_tienda As TabPage
    Friend WithEvents tpg_empleados As TabPage
    Friend WithEvents tpg_proveedores As TabPage
    Friend WithEvents tpg_clientes As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgv_tienda As DataGridView
    Friend WithEvents tlp_botones As TableLayoutPanel
    Friend WithEvents pbx_create As PictureBox
    Friend WithEvents pbx_read As PictureBox
    Friend WithEvents pbx_update As PictureBox
    Friend WithEvents pbx_delete As PictureBox
End Class
