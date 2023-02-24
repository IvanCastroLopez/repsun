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
        Me.pbx_createTienda = New System.Windows.Forms.PictureBox()
        Me.pbx_readTienda = New System.Windows.Forms.PictureBox()
        Me.pbx_updateTienda = New System.Windows.Forms.PictureBox()
        Me.pbx_deleteTienda = New System.Windows.Forms.PictureBox()
        Me.tpg_empleados = New System.Windows.Forms.TabPage()
        Me.tpg_proveedores = New System.Windows.Forms.TabPage()
        Me.tpg_clientes = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_createEmpleado = New System.Windows.Forms.PictureBox()
        Me.pbx_readEmpleado = New System.Windows.Forms.PictureBox()
        Me.pbx_updateEmpleados = New System.Windows.Forms.PictureBox()
        Me.pbx_deleteEmpleado = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_createProveedor = New System.Windows.Forms.PictureBox()
        Me.pbx_readProveedor = New System.Windows.Forms.PictureBox()
        Me.pbx_updateProveedor = New System.Windows.Forms.PictureBox()
        Me.pbx_deleteProveedor = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_createCliente = New System.Windows.Forms.PictureBox()
        Me.pbx_readCliente = New System.Windows.Forms.PictureBox()
        Me.pbx_updateCliente = New System.Windows.Forms.PictureBox()
        Me.pbx_deleteCliente = New System.Windows.Forms.PictureBox()
        Me.tbc_gestion.SuspendLayout()
        Me.tpg_tienda.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv_tienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_botones.SuspendLayout()
        CType(Me.pbx_createTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_readTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_updateTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_deleteTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpg_empleados.SuspendLayout()
        Me.tpg_proveedores.SuspendLayout()
        Me.tpg_clientes.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.pbx_createEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_readEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_updateEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_deleteEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.pbx_createProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_readProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_updateProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_deleteProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.pbx_createCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_readCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_updateCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_deleteCliente, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbc_gestion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbc_gestion.Name = "tbc_gestion"
        Me.tbc_gestion.SelectedIndex = 0
        Me.tbc_gestion.Size = New System.Drawing.Size(2279, 1407)
        Me.tbc_gestion.TabIndex = 1
        '
        'tpg_combustible
        '
        Me.tpg_combustible.Location = New System.Drawing.Point(4, 54)
        Me.tpg_combustible.Margin = New System.Windows.Forms.Padding(4)
        Me.tpg_combustible.Name = "tpg_combustible"
        Me.tpg_combustible.Padding = New System.Windows.Forms.Padding(4)
        Me.tpg_combustible.Size = New System.Drawing.Size(2271, 1349)
        Me.tpg_combustible.TabIndex = 0
        Me.tpg_combustible.Text = "Combustible"
        Me.tpg_combustible.UseVisualStyleBackColor = True
        '
        'tpg_tienda
        '
        Me.tpg_tienda.Controls.Add(Me.TableLayoutPanel1)
        Me.tpg_tienda.Location = New System.Drawing.Point(4, 54)
        Me.tpg_tienda.Margin = New System.Windows.Forms.Padding(4)
        Me.tpg_tienda.Name = "tpg_tienda"
        Me.tpg_tienda.Padding = New System.Windows.Forms.Padding(4)
        Me.tpg_tienda.Size = New System.Drawing.Size(2271, 1349)
        Me.tpg_tienda.TabIndex = 1
        Me.tpg_tienda.Text = "Tienda"
        Me.tpg_tienda.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgv_tienda, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tlp_botones, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(2263, 1341)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'dgv_tienda
        '
        Me.dgv_tienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_tienda.Location = New System.Drawing.Point(345, 140)
        Me.dgv_tienda.Margin = New System.Windows.Forms.Padding(6)
        Me.dgv_tienda.Name = "dgv_tienda"
        Me.dgv_tienda.RowHeadersWidth = 72
        Me.dgv_tienda.Size = New System.Drawing.Size(1912, 1195)
        Me.dgv_tienda.TabIndex = 0
        '
        'tlp_botones
        '
        Me.tlp_botones.ColumnCount = 1
        Me.tlp_botones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_botones.Controls.Add(Me.pbx_createTienda, 0, 1)
        Me.tlp_botones.Controls.Add(Me.pbx_readTienda, 0, 3)
        Me.tlp_botones.Controls.Add(Me.pbx_updateTienda, 0, 5)
        Me.tlp_botones.Controls.Add(Me.pbx_deleteTienda, 0, 7)
        Me.tlp_botones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_botones.Location = New System.Drawing.Point(6, 140)
        Me.tlp_botones.Margin = New System.Windows.Forms.Padding(6)
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
        Me.tlp_botones.Size = New System.Drawing.Size(327, 1195)
        Me.tlp_botones.TabIndex = 1
        '
        'pbx_createTienda
        '
        Me.pbx_createTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_createTienda.Image = Global.repsun.My.Resources.Resources.Anadir
        Me.pbx_createTienda.Location = New System.Drawing.Point(6, 138)
        Me.pbx_createTienda.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_createTienda.Name = "pbx_createTienda"
        Me.pbx_createTienda.Size = New System.Drawing.Size(315, 120)
        Me.pbx_createTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_createTienda.TabIndex = 0
        Me.pbx_createTienda.TabStop = False
        '
        'pbx_readTienda
        '
        Me.pbx_readTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_readTienda.Image = Global.repsun.My.Resources.Resources.Buscar
        Me.pbx_readTienda.Location = New System.Drawing.Point(6, 402)
        Me.pbx_readTienda.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_readTienda.Name = "pbx_readTienda"
        Me.pbx_readTienda.Size = New System.Drawing.Size(315, 120)
        Me.pbx_readTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_readTienda.TabIndex = 1
        Me.pbx_readTienda.TabStop = False
        '
        'pbx_updateTienda
        '
        Me.pbx_updateTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_updateTienda.Image = Global.repsun.My.Resources.Resources.Modificar
        Me.pbx_updateTienda.Location = New System.Drawing.Point(6, 666)
        Me.pbx_updateTienda.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_updateTienda.Name = "pbx_updateTienda"
        Me.pbx_updateTienda.Size = New System.Drawing.Size(315, 120)
        Me.pbx_updateTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_updateTienda.TabIndex = 2
        Me.pbx_updateTienda.TabStop = False
        '
        'pbx_deleteTienda
        '
        Me.pbx_deleteTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_deleteTienda.Image = Global.repsun.My.Resources.Resources.Eliminar
        Me.pbx_deleteTienda.Location = New System.Drawing.Point(6, 930)
        Me.pbx_deleteTienda.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_deleteTienda.Name = "pbx_deleteTienda"
        Me.pbx_deleteTienda.Size = New System.Drawing.Size(315, 120)
        Me.pbx_deleteTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_deleteTienda.TabIndex = 3
        Me.pbx_deleteTienda.TabStop = False
        '
        'tpg_empleados
        '
        Me.tpg_empleados.Controls.Add(Me.TableLayoutPanel2)
        Me.tpg_empleados.Location = New System.Drawing.Point(4, 54)
        Me.tpg_empleados.Margin = New System.Windows.Forms.Padding(4)
        Me.tpg_empleados.Name = "tpg_empleados"
        Me.tpg_empleados.Size = New System.Drawing.Size(2271, 1349)
        Me.tpg_empleados.TabIndex = 2
        Me.tpg_empleados.Text = "Empleados"
        Me.tpg_empleados.UseVisualStyleBackColor = True
        '
        'tpg_proveedores
        '
        Me.tpg_proveedores.Controls.Add(Me.TableLayoutPanel4)
        Me.tpg_proveedores.Location = New System.Drawing.Point(4, 54)
        Me.tpg_proveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.tpg_proveedores.Name = "tpg_proveedores"
        Me.tpg_proveedores.Size = New System.Drawing.Size(2271, 1349)
        Me.tpg_proveedores.TabIndex = 3
        Me.tpg_proveedores.Text = "Proveedores"
        Me.tpg_proveedores.UseVisualStyleBackColor = True
        '
        'tpg_clientes
        '
        Me.tpg_clientes.Controls.Add(Me.TableLayoutPanel6)
        Me.tpg_clientes.Location = New System.Drawing.Point(4, 54)
        Me.tpg_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.tpg_clientes.Name = "tpg_clientes"
        Me.tpg_clientes.Size = New System.Drawing.Size(2271, 1349)
        Me.tpg_clientes.TabIndex = 4
        Me.tpg_clientes.Text = "Clientes"
        Me.tpg_clientes.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(2271, 1349)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(346, 140)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.Size = New System.Drawing.Size(1919, 1203)
        Me.DataGridView1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.pbx_createEmpleado, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.pbx_readEmpleado, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.pbx_updateEmpleados, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.pbx_deleteEmpleado, 0, 7)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 140)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 9
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(328, 1203)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'pbx_createEmpleado
        '
        Me.pbx_createEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_createEmpleado.Image = Global.repsun.My.Resources.Resources.Anadir
        Me.pbx_createEmpleado.Location = New System.Drawing.Point(6, 139)
        Me.pbx_createEmpleado.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_createEmpleado.Name = "pbx_createEmpleado"
        Me.pbx_createEmpleado.Size = New System.Drawing.Size(316, 121)
        Me.pbx_createEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_createEmpleado.TabIndex = 0
        Me.pbx_createEmpleado.TabStop = False
        '
        'pbx_readEmpleado
        '
        Me.pbx_readEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_readEmpleado.Image = Global.repsun.My.Resources.Resources.Buscar
        Me.pbx_readEmpleado.Location = New System.Drawing.Point(6, 405)
        Me.pbx_readEmpleado.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_readEmpleado.Name = "pbx_readEmpleado"
        Me.pbx_readEmpleado.Size = New System.Drawing.Size(316, 121)
        Me.pbx_readEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_readEmpleado.TabIndex = 1
        Me.pbx_readEmpleado.TabStop = False
        '
        'pbx_updateEmpleados
        '
        Me.pbx_updateEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_updateEmpleados.Image = Global.repsun.My.Resources.Resources.Modificar
        Me.pbx_updateEmpleados.Location = New System.Drawing.Point(6, 671)
        Me.pbx_updateEmpleados.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_updateEmpleados.Name = "pbx_updateEmpleados"
        Me.pbx_updateEmpleados.Size = New System.Drawing.Size(316, 121)
        Me.pbx_updateEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_updateEmpleados.TabIndex = 2
        Me.pbx_updateEmpleados.TabStop = False
        '
        'pbx_deleteEmpleado
        '
        Me.pbx_deleteEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_deleteEmpleado.Image = Global.repsun.My.Resources.Resources.Eliminar
        Me.pbx_deleteEmpleado.Location = New System.Drawing.Point(6, 937)
        Me.pbx_deleteEmpleado.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_deleteEmpleado.Name = "pbx_deleteEmpleado"
        Me.pbx_deleteEmpleado.Size = New System.Drawing.Size(316, 121)
        Me.pbx_deleteEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_deleteEmpleado.TabIndex = 3
        Me.pbx_deleteEmpleado.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.DataGridView2, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(2271, 1349)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(346, 140)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 72
        Me.DataGridView2.Size = New System.Drawing.Size(1919, 1203)
        Me.DataGridView2.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.pbx_createProveedor, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.pbx_readProveedor, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.pbx_updateProveedor, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.pbx_deleteProveedor, 0, 7)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 140)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 9
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(328, 1203)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'pbx_createProveedor
        '
        Me.pbx_createProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_createProveedor.Image = Global.repsun.My.Resources.Resources.Anadir
        Me.pbx_createProveedor.Location = New System.Drawing.Point(6, 139)
        Me.pbx_createProveedor.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_createProveedor.Name = "pbx_createProveedor"
        Me.pbx_createProveedor.Size = New System.Drawing.Size(316, 121)
        Me.pbx_createProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_createProveedor.TabIndex = 0
        Me.pbx_createProveedor.TabStop = False
        '
        'pbx_readProveedor
        '
        Me.pbx_readProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_readProveedor.Image = Global.repsun.My.Resources.Resources.Buscar
        Me.pbx_readProveedor.Location = New System.Drawing.Point(6, 405)
        Me.pbx_readProveedor.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_readProveedor.Name = "pbx_readProveedor"
        Me.pbx_readProveedor.Size = New System.Drawing.Size(316, 121)
        Me.pbx_readProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_readProveedor.TabIndex = 1
        Me.pbx_readProveedor.TabStop = False
        '
        'pbx_updateProveedor
        '
        Me.pbx_updateProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_updateProveedor.Image = Global.repsun.My.Resources.Resources.Modificar
        Me.pbx_updateProveedor.Location = New System.Drawing.Point(6, 671)
        Me.pbx_updateProveedor.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_updateProveedor.Name = "pbx_updateProveedor"
        Me.pbx_updateProveedor.Size = New System.Drawing.Size(316, 121)
        Me.pbx_updateProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_updateProveedor.TabIndex = 2
        Me.pbx_updateProveedor.TabStop = False
        '
        'pbx_deleteProveedor
        '
        Me.pbx_deleteProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_deleteProveedor.Image = Global.repsun.My.Resources.Resources.Eliminar
        Me.pbx_deleteProveedor.Location = New System.Drawing.Point(6, 937)
        Me.pbx_deleteProveedor.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_deleteProveedor.Name = "pbx_deleteProveedor"
        Me.pbx_deleteProveedor.Size = New System.Drawing.Size(316, 121)
        Me.pbx_deleteProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_deleteProveedor.TabIndex = 3
        Me.pbx_deleteProveedor.TabStop = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.DataGridView3, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(2271, 1349)
        Me.TableLayoutPanel6.TabIndex = 3
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(346, 140)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 72
        Me.DataGridView3.Size = New System.Drawing.Size(1919, 1203)
        Me.DataGridView3.TabIndex = 0
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.pbx_createCliente, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.pbx_readCliente, 0, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.pbx_updateCliente, 0, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.pbx_deleteCliente, 0, 7)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(6, 140)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 9
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(328, 1203)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'pbx_createCliente
        '
        Me.pbx_createCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_createCliente.Image = Global.repsun.My.Resources.Resources.Anadir
        Me.pbx_createCliente.Location = New System.Drawing.Point(6, 139)
        Me.pbx_createCliente.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_createCliente.Name = "pbx_createCliente"
        Me.pbx_createCliente.Size = New System.Drawing.Size(316, 121)
        Me.pbx_createCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_createCliente.TabIndex = 0
        Me.pbx_createCliente.TabStop = False
        '
        'pbx_readCliente
        '
        Me.pbx_readCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_readCliente.Image = Global.repsun.My.Resources.Resources.Buscar
        Me.pbx_readCliente.Location = New System.Drawing.Point(6, 405)
        Me.pbx_readCliente.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_readCliente.Name = "pbx_readCliente"
        Me.pbx_readCliente.Size = New System.Drawing.Size(316, 121)
        Me.pbx_readCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_readCliente.TabIndex = 1
        Me.pbx_readCliente.TabStop = False
        '
        'pbx_updateCliente
        '
        Me.pbx_updateCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_updateCliente.Image = Global.repsun.My.Resources.Resources.Modificar
        Me.pbx_updateCliente.Location = New System.Drawing.Point(6, 671)
        Me.pbx_updateCliente.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_updateCliente.Name = "pbx_updateCliente"
        Me.pbx_updateCliente.Size = New System.Drawing.Size(316, 121)
        Me.pbx_updateCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_updateCliente.TabIndex = 2
        Me.pbx_updateCliente.TabStop = False
        '
        'pbx_deleteCliente
        '
        Me.pbx_deleteCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_deleteCliente.Image = Global.repsun.My.Resources.Resources.Eliminar
        Me.pbx_deleteCliente.Location = New System.Drawing.Point(6, 937)
        Me.pbx_deleteCliente.Margin = New System.Windows.Forms.Padding(6)
        Me.pbx_deleteCliente.Name = "pbx_deleteCliente"
        Me.pbx_deleteCliente.Size = New System.Drawing.Size(316, 121)
        Me.pbx_deleteCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_deleteCliente.TabIndex = 3
        Me.pbx_deleteCliente.TabStop = False
        '
        'ClientesOnTop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2279, 1407)
        Me.Controls.Add(Me.tbc_gestion)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ClientesOnTop"
        Me.Text = "ClientesOnTop"
        Me.tbc_gestion.ResumeLayout(False)
        Me.tpg_tienda.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv_tienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_botones.ResumeLayout(False)
        CType(Me.pbx_createTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_readTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_updateTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_deleteTienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpg_empleados.ResumeLayout(False)
        Me.tpg_proveedores.ResumeLayout(False)
        Me.tpg_clientes.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.pbx_createEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_readEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_updateEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_deleteEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.pbx_createProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_readProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_updateProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_deleteProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.pbx_createCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_readCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_updateCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_deleteCliente, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pbx_createTienda As PictureBox
    Friend WithEvents pbx_readTienda As PictureBox
    Friend WithEvents pbx_updateTienda As PictureBox
    Friend WithEvents pbx_deleteTienda As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents pbx_createEmpleado As PictureBox
    Friend WithEvents pbx_readEmpleado As PictureBox
    Friend WithEvents pbx_updateEmpleados As PictureBox
    Friend WithEvents pbx_deleteEmpleado As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents pbx_createProveedor As PictureBox
    Friend WithEvents pbx_readProveedor As PictureBox
    Friend WithEvents pbx_updateProveedor As PictureBox
    Friend WithEvents pbx_deleteProveedor As PictureBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents pbx_createCliente As PictureBox
    Friend WithEvents pbx_readCliente As PictureBox
    Friend WithEvents pbx_updateCliente As PictureBox
    Friend WithEvents pbx_deleteCliente As PictureBox
End Class
