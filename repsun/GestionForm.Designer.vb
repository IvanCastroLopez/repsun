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
        Me.tlp_combustible = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.nud_precioCombustible = New System.Windows.Forms.NumericUpDown()
        Me.lbl_precioCombustible = New System.Windows.Forms.Label()
        Me.lbl_tipoCombustible = New System.Windows.Forms.Label()
        Me.lbl_restante = New System.Windows.Forms.Label()
        Me.pgb_restanteDeposito = New System.Windows.Forms.ProgressBar()
        Me.lbl_euro = New System.Windows.Forms.Label()
        Me.lbl_restanteLitros = New System.Windows.Forms.Label()
        Me.btn_rellenarTanque = New System.Windows.Forms.Button()
        Me.cbx_tipoCombustible = New System.Windows.Forms.ComboBox()
        Me.tlp_depositosCombustibles = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_diesel = New System.Windows.Forms.Label()
        Me.lbl_dieselPlus = New System.Windows.Forms.Label()
        Me.lbl_sinPlomo95 = New System.Windows.Forms.Label()
        Me.pgb_sinPlomo95 = New System.Windows.Forms.ProgressBar()
        Me.pgb_sinPlomo98 = New System.Windows.Forms.ProgressBar()
        Me.pgb_dieselPlus = New System.Windows.Forms.ProgressBar()
        Me.pgb_diesel = New System.Windows.Forms.ProgressBar()
        Me.lbl_sinPlomo98 = New System.Windows.Forms.Label()
        Me.lbl_ = New System.Windows.Forms.Label()
        Me.tpg_tienda = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp_botonesTienda = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_eliminartienda = New System.Windows.Forms.PictureBox()
        Me.pbx_editarTienda = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbx_crearTienda = New System.Windows.Forms.PictureBox()
        Me.txt_buscarTienda = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgv_tienda = New System.Windows.Forms.DataGridView()
        Me.tpg_empleados = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_eliminarEmpleados = New System.Windows.Forms.PictureBox()
        Me.pbx_editarEmpleados = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbx_crearEmpleados = New System.Windows.Forms.PictureBox()
        Me.txt_buscarEmpleado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_empleados = New System.Windows.Forms.DataGridView()
        Me.tpg_proveedores = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_eliminarProveedor = New System.Windows.Forms.PictureBox()
        Me.pbx_editarProveedor = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbx_crearProveedor = New System.Windows.Forms.PictureBox()
        Me.txt_buscarProveedores = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_proveedores = New System.Windows.Forms.DataGridView()
        Me.tpg_clientes = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_eliminarCliente = New System.Windows.Forms.PictureBox()
        Me.pbx_editarCliente = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pbx_crearCliente = New System.Windows.Forms.PictureBox()
        Me.txt_buscarCliente = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
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
        Me.tpg_combustible.SuspendLayout()
        Me.tlp_combustible.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.nud_precioCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_depositosCombustibles.SuspendLayout()
        Me.tpg_tienda.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlp_botonesTienda.SuspendLayout()
        CType(Me.pbx_eliminartienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_editarTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_crearTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_tienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpg_empleados.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.pbx_eliminarEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_editarEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_crearEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpg_proveedores.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.pbx_eliminarProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_editarProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_crearProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpg_clientes.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.pbx_eliminarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_editarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_crearCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlp_gestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.tlp_gestion.ColumnCount = 3
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.995657!))
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.64193!))
        Me.tlp_gestion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.362419!))
        Me.tlp_gestion.Controls.Add(Me.tbc_gestion, 0, 1)
        Me.tlp_gestion.Controls.Add(Me.tlp_categorias, 0, 0)
        Me.tlp_gestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_gestion.Location = New System.Drawing.Point(0, 0)
        Me.tlp_gestion.Name = "tlp_gestion"
        Me.tlp_gestion.RowCount = 3
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.425209!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.814059!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.76418!))
        Me.tlp_gestion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_gestion.Size = New System.Drawing.Size(1412, 882)
        Me.tlp_gestion.TabIndex = 1
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
        Me.tbc_gestion.Location = New System.Drawing.Point(142, 40)
        Me.tbc_gestion.Margin = New System.Windows.Forms.Padding(1)
        Me.tbc_gestion.Name = "tbc_gestion"
        Me.tbc_gestion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tlp_gestion.SetRowSpan(Me.tbc_gestion, 2)
        Me.tbc_gestion.SelectedIndex = 0
        Me.tbc_gestion.Size = New System.Drawing.Size(1269, 841)
        Me.tbc_gestion.TabIndex = 4
        '
        'tpg_combustible
        '
        Me.tpg_combustible.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tpg_combustible.Controls.Add(Me.tlp_combustible)
        Me.tpg_combustible.Location = New System.Drawing.Point(4, 34)
        Me.tpg_combustible.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_combustible.Name = "tpg_combustible"
        Me.tpg_combustible.Size = New System.Drawing.Size(1261, 803)
        Me.tpg_combustible.TabIndex = 0
        Me.tpg_combustible.Text = "Combustible"
        '
        'tlp_combustible
        '
        Me.tlp_combustible.BackColor = System.Drawing.Color.White
        Me.tlp_combustible.ColumnCount = 2
        Me.tlp_combustible.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_combustible.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.tlp_combustible.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.tlp_combustible.Controls.Add(Me.tlp_depositosCombustibles, 0, 0)
        Me.tlp_combustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_combustible.Location = New System.Drawing.Point(0, 0)
        Me.tlp_combustible.Name = "tlp_combustible"
        Me.tlp_combustible.RowCount = 2
        Me.tlp_combustible.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_combustible.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlp_combustible.Size = New System.Drawing.Size(1261, 803)
        Me.tlp_combustible.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.nud_precioCombustible, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_precioCombustible, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_tipoCombustible, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_restante, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.pgb_restanteDeposito, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_euro, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_restanteLitros, 2, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_rellenarTanque, 1, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.cbx_tipoCombustible, 1, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(192, 83)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 18
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555277!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555277!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555277!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555277!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555277!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555277!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555277!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555277!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555277!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1066, 717)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'nud_precioCombustible
        '
        Me.nud_precioCombustible.AutoSize = True
        Me.nud_precioCombustible.DecimalPlaces = 4
        Me.nud_precioCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nud_precioCombustible.Font = New System.Drawing.Font("Yu Gothic UI", 15.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_precioCombustible.Location = New System.Drawing.Point(214, 196)
        Me.nud_precioCombustible.Margin = New System.Windows.Forms.Padding(1)
        Me.nud_precioCombustible.Name = "nud_precioCombustible"
        Me.nud_precioCombustible.Size = New System.Drawing.Size(317, 36)
        Me.nud_precioCombustible.TabIndex = 12
        '
        'lbl_precioCombustible
        '
        Me.lbl_precioCombustible.AutoSize = True
        Me.lbl_precioCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_precioCombustible.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precioCombustible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_precioCombustible.Location = New System.Drawing.Point(216, 156)
        Me.lbl_precioCombustible.Name = "lbl_precioCombustible"
        Me.lbl_precioCombustible.Size = New System.Drawing.Size(313, 39)
        Me.lbl_precioCombustible.TabIndex = 11
        Me.lbl_precioCombustible.Text = "Precio"
        Me.lbl_precioCombustible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tipoCombustible
        '
        Me.lbl_tipoCombustible.AutoSize = True
        Me.lbl_tipoCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_tipoCombustible.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipoCombustible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_tipoCombustible.Location = New System.Drawing.Point(216, 78)
        Me.lbl_tipoCombustible.Name = "lbl_tipoCombustible"
        Me.lbl_tipoCombustible.Size = New System.Drawing.Size(313, 39)
        Me.lbl_tipoCombustible.TabIndex = 10
        Me.lbl_tipoCombustible.Text = "Combustible"
        Me.lbl_tipoCombustible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_restante
        '
        Me.lbl_restante.AutoSize = True
        Me.lbl_restante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_restante.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_restante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_restante.Location = New System.Drawing.Point(216, 234)
        Me.lbl_restante.Name = "lbl_restante"
        Me.lbl_restante.Size = New System.Drawing.Size(313, 39)
        Me.lbl_restante.TabIndex = 17
        Me.lbl_restante.Text = "Restante en el depósito"
        Me.lbl_restante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pgb_restanteDeposito
        '
        Me.pgb_restanteDeposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb_restanteDeposito.Location = New System.Drawing.Point(216, 276)
        Me.pgb_restanteDeposito.Name = "pgb_restanteDeposito"
        Me.pgb_restanteDeposito.Size = New System.Drawing.Size(313, 33)
        Me.pgb_restanteDeposito.TabIndex = 16
        '
        'lbl_euro
        '
        Me.lbl_euro.AutoSize = True
        Me.lbl_euro.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_euro.Font = New System.Drawing.Font("Yu Gothic UI", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_euro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_euro.Location = New System.Drawing.Point(535, 195)
        Me.lbl_euro.Name = "lbl_euro"
        Me.lbl_euro.Size = New System.Drawing.Size(25, 39)
        Me.lbl_euro.TabIndex = 18
        Me.lbl_euro.Text = "€"
        Me.lbl_euro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_restanteLitros
        '
        Me.lbl_restanteLitros.AutoSize = True
        Me.lbl_restanteLitros.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_restanteLitros.Font = New System.Drawing.Font("Yu Gothic UI", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_restanteLitros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_restanteLitros.Location = New System.Drawing.Point(535, 273)
        Me.lbl_restanteLitros.Name = "lbl_restanteLitros"
        Me.lbl_restanteLitros.Size = New System.Drawing.Size(108, 39)
        Me.lbl_restanteLitros.TabIndex = 20
        Me.lbl_restanteLitros.Text = "0/10000 L"
        Me.lbl_restanteLitros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_rellenarTanque
        '
        Me.btn_rellenarTanque.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btn_rellenarTanque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_rellenarTanque.ForeColor = System.Drawing.Color.White
        Me.btn_rellenarTanque.Location = New System.Drawing.Point(214, 352)
        Me.btn_rellenarTanque.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_rellenarTanque.Name = "btn_rellenarTanque"
        Me.TableLayoutPanel3.SetRowSpan(Me.btn_rellenarTanque, 2)
        Me.btn_rellenarTanque.Size = New System.Drawing.Size(317, 76)
        Me.btn_rellenarTanque.TabIndex = 21
        Me.btn_rellenarTanque.Text = "Rellenar"
        Me.btn_rellenarTanque.UseVisualStyleBackColor = False
        '
        'cbx_tipoCombustible
        '
        Me.cbx_tipoCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbx_tipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tipoCombustible.Font = New System.Drawing.Font("Yu Gothic UI", 15.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_tipoCombustible.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cbx_tipoCombustible.Items.AddRange(New Object() {"Sin Plomo 95", "Sin Plomo 98", "Diesel", "Diesel +"})
        Me.cbx_tipoCombustible.Location = New System.Drawing.Point(214, 118)
        Me.cbx_tipoCombustible.Margin = New System.Windows.Forms.Padding(1)
        Me.cbx_tipoCombustible.Name = "cbx_tipoCombustible"
        Me.cbx_tipoCombustible.Size = New System.Drawing.Size(317, 38)
        Me.cbx_tipoCombustible.TabIndex = 22
        '
        'tlp_depositosCombustibles
        '
        Me.tlp_depositosCombustibles.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tlp_depositosCombustibles.ColumnCount = 1
        Me.tlp_depositosCombustibles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_depositosCombustibles.Controls.Add(Me.lbl_diesel, 0, 10)
        Me.tlp_depositosCombustibles.Controls.Add(Me.lbl_dieselPlus, 0, 12)
        Me.tlp_depositosCombustibles.Controls.Add(Me.lbl_sinPlomo95, 0, 6)
        Me.tlp_depositosCombustibles.Controls.Add(Me.pgb_sinPlomo95, 0, 5)
        Me.tlp_depositosCombustibles.Controls.Add(Me.pgb_sinPlomo98, 0, 7)
        Me.tlp_depositosCombustibles.Controls.Add(Me.pgb_dieselPlus, 0, 11)
        Me.tlp_depositosCombustibles.Controls.Add(Me.pgb_diesel, 0, 9)
        Me.tlp_depositosCombustibles.Controls.Add(Me.lbl_sinPlomo98, 0, 8)
        Me.tlp_depositosCombustibles.Controls.Add(Me.lbl_, 0, 2)
        Me.tlp_depositosCombustibles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_depositosCombustibles.Location = New System.Drawing.Point(3, 3)
        Me.tlp_depositosCombustibles.Name = "tlp_depositosCombustibles"
        Me.tlp_depositosCombustibles.RowCount = 18
        Me.tlp_combustible.SetRowSpan(Me.tlp_depositosCombustibles, 2)
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_depositosCombustibles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlp_depositosCombustibles.Size = New System.Drawing.Size(183, 797)
        Me.tlp_depositosCombustibles.TabIndex = 3
        '
        'lbl_diesel
        '
        Me.lbl_diesel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_diesel.AutoSize = True
        Me.lbl_diesel.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_diesel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_diesel.Location = New System.Drawing.Point(57, 440)
        Me.lbl_diesel.Name = "lbl_diesel"
        Me.lbl_diesel.Size = New System.Drawing.Size(69, 30)
        Me.lbl_diesel.TabIndex = 10
        Me.lbl_diesel.Text = "Diesel"
        '
        'lbl_dieselPlus
        '
        Me.lbl_dieselPlus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_dieselPlus.AutoSize = True
        Me.lbl_dieselPlus.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dieselPlus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_dieselPlus.Location = New System.Drawing.Point(47, 528)
        Me.lbl_dieselPlus.Name = "lbl_dieselPlus"
        Me.lbl_dieselPlus.Size = New System.Drawing.Size(89, 30)
        Me.lbl_dieselPlus.TabIndex = 11
        Me.lbl_dieselPlus.Text = "Diesel +"
        '
        'lbl_sinPlomo95
        '
        Me.lbl_sinPlomo95.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_sinPlomo95.AutoSize = True
        Me.lbl_sinPlomo95.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sinPlomo95.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_sinPlomo95.Location = New System.Drawing.Point(24, 264)
        Me.lbl_sinPlomo95.Name = "lbl_sinPlomo95"
        Me.lbl_sinPlomo95.Size = New System.Drawing.Size(134, 30)
        Me.lbl_sinPlomo95.TabIndex = 9
        Me.lbl_sinPlomo95.Text = "Sin Plomo 95"
        '
        'pgb_sinPlomo95
        '
        Me.pgb_sinPlomo95.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb_sinPlomo95.Location = New System.Drawing.Point(3, 223)
        Me.pgb_sinPlomo95.Name = "pgb_sinPlomo95"
        Me.pgb_sinPlomo95.Size = New System.Drawing.Size(177, 38)
        Me.pgb_sinPlomo95.TabIndex = 12
        '
        'pgb_sinPlomo98
        '
        Me.pgb_sinPlomo98.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb_sinPlomo98.Location = New System.Drawing.Point(3, 311)
        Me.pgb_sinPlomo98.Name = "pgb_sinPlomo98"
        Me.pgb_sinPlomo98.Size = New System.Drawing.Size(177, 38)
        Me.pgb_sinPlomo98.TabIndex = 13
        '
        'pgb_dieselPlus
        '
        Me.pgb_dieselPlus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb_dieselPlus.Location = New System.Drawing.Point(3, 487)
        Me.pgb_dieselPlus.Name = "pgb_dieselPlus"
        Me.pgb_dieselPlus.Size = New System.Drawing.Size(177, 38)
        Me.pgb_dieselPlus.TabIndex = 14
        '
        'pgb_diesel
        '
        Me.pgb_diesel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb_diesel.Location = New System.Drawing.Point(3, 399)
        Me.pgb_diesel.Name = "pgb_diesel"
        Me.pgb_diesel.Size = New System.Drawing.Size(177, 38)
        Me.pgb_diesel.TabIndex = 15
        '
        'lbl_sinPlomo98
        '
        Me.lbl_sinPlomo98.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_sinPlomo98.AutoSize = True
        Me.lbl_sinPlomo98.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sinPlomo98.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_sinPlomo98.Location = New System.Drawing.Point(24, 352)
        Me.lbl_sinPlomo98.Name = "lbl_sinPlomo98"
        Me.lbl_sinPlomo98.Size = New System.Drawing.Size(134, 30)
        Me.lbl_sinPlomo98.TabIndex = 9
        Me.lbl_sinPlomo98.Text = "Sin Plomo 98"
        '
        'lbl_
        '
        Me.lbl_.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_.AutoSize = True
        Me.lbl_.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_.Location = New System.Drawing.Point(22, 88)
        Me.lbl_.Name = "lbl_"
        Me.tlp_depositosCombustibles.SetRowSpan(Me.lbl_, 2)
        Me.lbl_.Size = New System.Drawing.Size(139, 60)
        Me.lbl_.TabIndex = 16
        Me.lbl_.Text = "Combustible Restante"
        Me.lbl_.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tpg_tienda
        '
        Me.tpg_tienda.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tpg_tienda.Controls.Add(Me.TableLayoutPanel1)
        Me.tpg_tienda.Location = New System.Drawing.Point(4, 34)
        Me.tpg_tienda.Margin = New System.Windows.Forms.Padding(2)
        Me.tpg_tienda.Name = "tpg_tienda"
        Me.tpg_tienda.Size = New System.Drawing.Size(1261, 803)
        Me.tpg_tienda.TabIndex = 1
        Me.tpg_tienda.Text = "Tienda"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tlp_botonesTienda, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgv_tienda, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1261, 803)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tlp_botonesTienda
        '
        Me.tlp_botonesTienda.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tlp_botonesTienda.ColumnCount = 1
        Me.tlp_botonesTienda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_botonesTienda.Controls.Add(Me.pbx_eliminartienda, 0, 11)
        Me.tlp_botonesTienda.Controls.Add(Me.pbx_editarTienda, 0, 9)
        Me.tlp_botonesTienda.Controls.Add(Me.Label11, 0, 10)
        Me.tlp_botonesTienda.Controls.Add(Me.Label12, 0, 12)
        Me.tlp_botonesTienda.Controls.Add(Me.Label10, 0, 8)
        Me.tlp_botonesTienda.Controls.Add(Me.pbx_crearTienda, 0, 7)
        Me.tlp_botonesTienda.Controls.Add(Me.txt_buscarTienda, 0, 4)
        Me.tlp_botonesTienda.Controls.Add(Me.Label9, 0, 3)
        Me.tlp_botonesTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_botonesTienda.Location = New System.Drawing.Point(3, 3)
        Me.tlp_botonesTienda.Name = "tlp_botonesTienda"
        Me.tlp_botonesTienda.RowCount = 18
        Me.TableLayoutPanel1.SetRowSpan(Me.tlp_botonesTienda, 2)
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.tlp_botonesTienda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_botonesTienda.Size = New System.Drawing.Size(183, 797)
        Me.tlp_botonesTienda.TabIndex = 3
        '
        'pbx_eliminartienda
        '
        Me.pbx_eliminartienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_eliminartienda.Image = Global.repsun.My.Resources.Resources.Eliminar
        Me.pbx_eliminartienda.Location = New System.Drawing.Point(1, 485)
        Me.pbx_eliminartienda.Margin = New System.Windows.Forms.Padding(1)
        Me.pbx_eliminartienda.Name = "pbx_eliminartienda"
        Me.pbx_eliminartienda.Size = New System.Drawing.Size(181, 42)
        Me.pbx_eliminartienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_eliminartienda.TabIndex = 3
        Me.pbx_eliminartienda.TabStop = False
        '
        'pbx_editarTienda
        '
        Me.pbx_editarTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_editarTienda.Image = Global.repsun.My.Resources.Resources.Modificar
        Me.pbx_editarTienda.Location = New System.Drawing.Point(3, 399)
        Me.pbx_editarTienda.Name = "pbx_editarTienda"
        Me.pbx_editarTienda.Size = New System.Drawing.Size(177, 38)
        Me.pbx_editarTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_editarTienda.TabIndex = 2
        Me.pbx_editarTienda.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(58, 440)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 30)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Editar"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(48, 528)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 30)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Eliminar"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(60, 352)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 30)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Crear"
        '
        'pbx_crearTienda
        '
        Me.pbx_crearTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_crearTienda.Image = Global.repsun.My.Resources.Resources.Anadir
        Me.pbx_crearTienda.Location = New System.Drawing.Point(1, 309)
        Me.pbx_crearTienda.Margin = New System.Windows.Forms.Padding(1)
        Me.pbx_crearTienda.Name = "pbx_crearTienda"
        Me.pbx_crearTienda.Size = New System.Drawing.Size(181, 42)
        Me.pbx_crearTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_crearTienda.TabIndex = 0
        Me.pbx_crearTienda.TabStop = False
        '
        'txt_buscarTienda
        '
        Me.txt_buscarTienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_buscarTienda.Location = New System.Drawing.Point(2, 178)
        Me.txt_buscarTienda.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscarTienda.Name = "txt_buscarTienda"
        Me.txt_buscarTienda.Size = New System.Drawing.Size(179, 32)
        Me.txt_buscarTienda.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(1, 146)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 30)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Buscar"
        '
        'dgv_tienda
        '
        Me.dgv_tienda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_tienda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgv_tienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_tienda.Location = New System.Drawing.Point(192, 83)
        Me.dgv_tienda.MultiSelect = False
        Me.dgv_tienda.Name = "dgv_tienda"
        Me.dgv_tienda.ReadOnly = True
        Me.dgv_tienda.RowHeadersWidth = 72
        Me.dgv_tienda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_tienda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tienda.Size = New System.Drawing.Size(1066, 717)
        Me.dgv_tienda.TabIndex = 0
        '
        'tpg_empleados
        '
        Me.tpg_empleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tpg_empleados.Controls.Add(Me.TableLayoutPanel2)
        Me.tpg_empleados.Location = New System.Drawing.Point(4, 34)
        Me.tpg_empleados.Margin = New System.Windows.Forms.Padding(1)
        Me.tpg_empleados.Name = "tpg_empleados"
        Me.tpg_empleados.Size = New System.Drawing.Size(1261, 803)
        Me.tpg_empleados.TabIndex = 2
        Me.tpg_empleados.Text = "Empleados"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgv_empleados, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1261, 803)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.pbx_eliminarEmpleados, 0, 11)
        Me.TableLayoutPanel5.Controls.Add(Me.pbx_editarEmpleados, 0, 9)
        Me.TableLayoutPanel5.Controls.Add(Me.Label1, 0, 10)
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 12)
        Me.TableLayoutPanel5.Controls.Add(Me.Label3, 0, 8)
        Me.TableLayoutPanel5.Controls.Add(Me.pbx_crearEmpleados, 0, 7)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_buscarEmpleado, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 18
        Me.TableLayoutPanel2.SetRowSpan(Me.TableLayoutPanel5, 2)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(185, 799)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'pbx_eliminarEmpleados
        '
        Me.pbx_eliminarEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_eliminarEmpleados.Image = Global.repsun.My.Resources.Resources.Eliminar
        Me.pbx_eliminarEmpleados.Location = New System.Drawing.Point(1, 485)
        Me.pbx_eliminarEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.pbx_eliminarEmpleados.Name = "pbx_eliminarEmpleados"
        Me.pbx_eliminarEmpleados.Size = New System.Drawing.Size(183, 42)
        Me.pbx_eliminarEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_eliminarEmpleados.TabIndex = 3
        Me.pbx_eliminarEmpleados.TabStop = False
        '
        'pbx_editarEmpleados
        '
        Me.pbx_editarEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_editarEmpleados.Image = Global.repsun.My.Resources.Resources.Modificar
        Me.pbx_editarEmpleados.Location = New System.Drawing.Point(2, 398)
        Me.pbx_editarEmpleados.Margin = New System.Windows.Forms.Padding(2)
        Me.pbx_editarEmpleados.Name = "pbx_editarEmpleados"
        Me.pbx_editarEmpleados.Size = New System.Drawing.Size(181, 40)
        Me.pbx_editarEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_editarEmpleados.TabIndex = 2
        Me.pbx_editarEmpleados.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(59, 440)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Editar"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 528)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 30)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Eliminar"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(61, 352)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 30)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Crear"
        '
        'pbx_crearEmpleados
        '
        Me.pbx_crearEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_crearEmpleados.Image = Global.repsun.My.Resources.Resources.Anadir
        Me.pbx_crearEmpleados.Location = New System.Drawing.Point(1, 309)
        Me.pbx_crearEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.pbx_crearEmpleados.Name = "pbx_crearEmpleados"
        Me.pbx_crearEmpleados.Size = New System.Drawing.Size(183, 42)
        Me.pbx_crearEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_crearEmpleados.TabIndex = 0
        Me.pbx_crearEmpleados.TabStop = False
        '
        'txt_buscarEmpleado
        '
        Me.txt_buscarEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_buscarEmpleado.Location = New System.Drawing.Point(2, 178)
        Me.txt_buscarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscarEmpleado.Name = "txt_buscarEmpleado"
        Me.txt_buscarEmpleado.Size = New System.Drawing.Size(181, 32)
        Me.txt_buscarEmpleado.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Buscar"
        '
        'dgv_empleados
        '
        Me.dgv_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_empleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_empleados.Location = New System.Drawing.Point(191, 82)
        Me.dgv_empleados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_empleados.MultiSelect = False
        Me.dgv_empleados.Name = "dgv_empleados"
        Me.dgv_empleados.ReadOnly = True
        Me.dgv_empleados.RowHeadersWidth = 72
        Me.dgv_empleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_empleados.Size = New System.Drawing.Size(1068, 719)
        Me.dgv_empleados.TabIndex = 0
        '
        'tpg_proveedores
        '
        Me.tpg_proveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tpg_proveedores.Controls.Add(Me.TableLayoutPanel4)
        Me.tpg_proveedores.Location = New System.Drawing.Point(4, 34)
        Me.tpg_proveedores.Margin = New System.Windows.Forms.Padding(1)
        Me.tpg_proveedores.Name = "tpg_proveedores"
        Me.tpg_proveedores.Size = New System.Drawing.Size(1261, 803)
        Me.tpg_proveedores.TabIndex = 3
        Me.tpg_proveedores.Text = "Proveedores"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dgv_proveedores, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1261, 803)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.pbx_eliminarProveedor, 0, 11)
        Me.TableLayoutPanel7.Controls.Add(Me.pbx_editarProveedor, 0, 9)
        Me.TableLayoutPanel7.Controls.Add(Me.Label5, 0, 10)
        Me.TableLayoutPanel7.Controls.Add(Me.Label6, 0, 12)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7, 0, 8)
        Me.TableLayoutPanel7.Controls.Add(Me.pbx_crearProveedor, 0, 7)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_buscarProveedores, 0, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 18
        Me.TableLayoutPanel4.SetRowSpan(Me.TableLayoutPanel7, 2)
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(185, 799)
        Me.TableLayoutPanel7.TabIndex = 3
        '
        'pbx_eliminarProveedor
        '
        Me.pbx_eliminarProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_eliminarProveedor.Image = Global.repsun.My.Resources.Resources.Eliminar
        Me.pbx_eliminarProveedor.Location = New System.Drawing.Point(1, 485)
        Me.pbx_eliminarProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.pbx_eliminarProveedor.Name = "pbx_eliminarProveedor"
        Me.pbx_eliminarProveedor.Size = New System.Drawing.Size(183, 42)
        Me.pbx_eliminarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_eliminarProveedor.TabIndex = 3
        Me.pbx_eliminarProveedor.TabStop = False
        '
        'pbx_editarProveedor
        '
        Me.pbx_editarProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_editarProveedor.Image = Global.repsun.My.Resources.Resources.Modificar
        Me.pbx_editarProveedor.Location = New System.Drawing.Point(2, 398)
        Me.pbx_editarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.pbx_editarProveedor.Name = "pbx_editarProveedor"
        Me.pbx_editarProveedor.Size = New System.Drawing.Size(181, 40)
        Me.pbx_editarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_editarProveedor.TabIndex = 2
        Me.pbx_editarProveedor.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(59, 440)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 30)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Editar"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(49, 528)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 30)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Eliminar"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(61, 352)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 30)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Crear"
        '
        'pbx_crearProveedor
        '
        Me.pbx_crearProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_crearProveedor.Image = Global.repsun.My.Resources.Resources.Anadir
        Me.pbx_crearProveedor.Location = New System.Drawing.Point(1, 309)
        Me.pbx_crearProveedor.Margin = New System.Windows.Forms.Padding(1)
        Me.pbx_crearProveedor.Name = "pbx_crearProveedor"
        Me.pbx_crearProveedor.Size = New System.Drawing.Size(183, 42)
        Me.pbx_crearProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_crearProveedor.TabIndex = 0
        Me.pbx_crearProveedor.TabStop = False
        '
        'txt_buscarProveedores
        '
        Me.txt_buscarProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_buscarProveedores.Location = New System.Drawing.Point(2, 178)
        Me.txt_buscarProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscarProveedores.Name = "txt_buscarProveedores"
        Me.txt_buscarProveedores.Size = New System.Drawing.Size(181, 32)
        Me.txt_buscarProveedores.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1, 146)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 30)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Buscar"
        '
        'dgv_proveedores
        '
        Me.dgv_proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_proveedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_proveedores.Location = New System.Drawing.Point(191, 82)
        Me.dgv_proveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_proveedores.MultiSelect = False
        Me.dgv_proveedores.Name = "dgv_proveedores"
        Me.dgv_proveedores.ReadOnly = True
        Me.dgv_proveedores.RowHeadersWidth = 72
        Me.dgv_proveedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_proveedores.Size = New System.Drawing.Size(1068, 719)
        Me.dgv_proveedores.TabIndex = 0
        '
        'tpg_clientes
        '
        Me.tpg_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tpg_clientes.Controls.Add(Me.TableLayoutPanel6)
        Me.tpg_clientes.Location = New System.Drawing.Point(4, 34)
        Me.tpg_clientes.Margin = New System.Windows.Forms.Padding(1)
        Me.tpg_clientes.Name = "tpg_clientes"
        Me.tpg_clientes.Size = New System.Drawing.Size(1261, 803)
        Me.tpg_clientes.TabIndex = 4
        Me.tpg_clientes.Text = "Clientes"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.dgv_clientes, 1, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1261, 803)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.pbx_eliminarCliente, 0, 11)
        Me.TableLayoutPanel8.Controls.Add(Me.pbx_editarCliente, 0, 9)
        Me.TableLayoutPanel8.Controls.Add(Me.Label13, 0, 10)
        Me.TableLayoutPanel8.Controls.Add(Me.Label14, 0, 12)
        Me.TableLayoutPanel8.Controls.Add(Me.Label15, 0, 8)
        Me.TableLayoutPanel8.Controls.Add(Me.pbx_crearCliente, 0, 7)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_buscarCliente, 0, 4)
        Me.TableLayoutPanel8.Controls.Add(Me.Label16, 0, 3)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 18
        Me.TableLayoutPanel6.SetRowSpan(Me.TableLayoutPanel8, 2)
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555833!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555278!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(185, 799)
        Me.TableLayoutPanel8.TabIndex = 3
        '
        'pbx_eliminarCliente
        '
        Me.pbx_eliminarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_eliminarCliente.Image = Global.repsun.My.Resources.Resources.Eliminar
        Me.pbx_eliminarCliente.Location = New System.Drawing.Point(1, 485)
        Me.pbx_eliminarCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.pbx_eliminarCliente.Name = "pbx_eliminarCliente"
        Me.pbx_eliminarCliente.Size = New System.Drawing.Size(183, 42)
        Me.pbx_eliminarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_eliminarCliente.TabIndex = 3
        Me.pbx_eliminarCliente.TabStop = False
        '
        'pbx_editarCliente
        '
        Me.pbx_editarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_editarCliente.Image = Global.repsun.My.Resources.Resources.Modificar
        Me.pbx_editarCliente.Location = New System.Drawing.Point(2, 398)
        Me.pbx_editarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.pbx_editarCliente.Name = "pbx_editarCliente"
        Me.pbx_editarCliente.Size = New System.Drawing.Size(181, 40)
        Me.pbx_editarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_editarCliente.TabIndex = 2
        Me.pbx_editarCliente.TabStop = False
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(59, 440)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 30)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Editar"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(49, 528)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 30)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Eliminar"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(61, 352)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 30)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Crear"
        '
        'pbx_crearCliente
        '
        Me.pbx_crearCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_crearCliente.Image = Global.repsun.My.Resources.Resources.Anadir
        Me.pbx_crearCliente.Location = New System.Drawing.Point(1, 309)
        Me.pbx_crearCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.pbx_crearCliente.Name = "pbx_crearCliente"
        Me.pbx_crearCliente.Size = New System.Drawing.Size(183, 42)
        Me.pbx_crearCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_crearCliente.TabIndex = 0
        Me.pbx_crearCliente.TabStop = False
        '
        'txt_buscarCliente
        '
        Me.txt_buscarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_buscarCliente.Location = New System.Drawing.Point(2, 178)
        Me.txt_buscarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscarCliente.Name = "txt_buscarCliente"
        Me.txt_buscarCliente.Size = New System.Drawing.Size(181, 32)
        Me.txt_buscarCliente.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(1, 146)
        Me.Label16.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 30)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Buscar"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_clientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_clientes.Location = New System.Drawing.Point(191, 82)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_clientes.MultiSelect = False
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersWidth = 72
        Me.dgv_clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clientes.Size = New System.Drawing.Size(1068, 719)
        Me.dgv_clientes.TabIndex = 0
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
        Me.lbl_combustible.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_combustible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_combustible.Location = New System.Drawing.Point(3, 249)
        Me.lbl_combustible.Name = "lbl_combustible"
        Me.lbl_combustible.Size = New System.Drawing.Size(129, 30)
        Me.lbl_combustible.TabIndex = 7
        Me.lbl_combustible.Text = "Combustible"
        '
        'lbl_tienda
        '
        Me.lbl_tienda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_tienda.AutoSize = True
        Me.lbl_tienda.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tienda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_tienda.Location = New System.Drawing.Point(30, 373)
        Me.lbl_tienda.Name = "lbl_tienda"
        Me.lbl_tienda.Size = New System.Drawing.Size(75, 30)
        Me.lbl_tienda.TabIndex = 8
        Me.lbl_tienda.Text = "Tienda"
        '
        'lbl_Empleados
        '
        Me.lbl_Empleados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Empleados.AutoSize = True
        Me.lbl_Empleados.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Empleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_Empleados.Location = New System.Drawing.Point(10, 497)
        Me.lbl_Empleados.Name = "lbl_Empleados"
        Me.lbl_Empleados.Size = New System.Drawing.Size(114, 30)
        Me.lbl_Empleados.TabIndex = 9
        Me.lbl_Empleados.Text = "Empleados"
        '
        'lbl_proveedores
        '
        Me.lbl_proveedores.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_proveedores.AutoSize = True
        Me.lbl_proveedores.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proveedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_proveedores.Location = New System.Drawing.Point(4, 621)
        Me.lbl_proveedores.Name = "lbl_proveedores"
        Me.lbl_proveedores.Size = New System.Drawing.Size(127, 30)
        Me.lbl_proveedores.TabIndex = 10
        Me.lbl_proveedores.Text = "Proveedores"
        '
        'lbl_clientes
        '
        Me.lbl_clientes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_clientes.AutoSize = True
        Me.lbl_clientes.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lbl_clientes.Location = New System.Drawing.Point(24, 745)
        Me.lbl_clientes.Name = "lbl_clientes"
        Me.lbl_clientes.Size = New System.Drawing.Size(86, 30)
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
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "GestionForm"
        Me.Text = "GestionForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_gestion.ResumeLayout(False)
        Me.tbc_gestion.ResumeLayout(False)
        Me.tpg_combustible.ResumeLayout(False)
        Me.tlp_combustible.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.nud_precioCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_depositosCombustibles.ResumeLayout(False)
        Me.tlp_depositosCombustibles.PerformLayout()
        Me.tpg_tienda.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tlp_botonesTienda.ResumeLayout(False)
        Me.tlp_botonesTienda.PerformLayout()
        CType(Me.pbx_eliminartienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_editarTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_crearTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_tienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpg_empleados.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.pbx_eliminarEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_editarEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_crearEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpg_proveedores.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.pbx_eliminarProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_editarProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_crearProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpg_clientes.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.pbx_eliminarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_editarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_crearCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tlp_botonesTienda As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents pbx_eliminartienda As PictureBox
    Friend WithEvents pbx_editarTienda As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pbx_crearTienda As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dgv_tienda As DataGridView
    Friend WithEvents tpg_empleados As TabPage
    Friend WithEvents tpg_proveedores As TabPage
    Friend WithEvents tpg_clientes As TabPage
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
    Friend WithEvents tlp_combustible As TableLayoutPanel
    Friend WithEvents tlp_depositosCombustibles As TableLayoutPanel
    Friend WithEvents lbl_diesel As Label
    Friend WithEvents lbl_dieselPlus As Label
    Friend WithEvents lbl_sinPlomo95 As Label
    Friend WithEvents pgb_sinPlomo95 As ProgressBar
    Friend WithEvents pgb_sinPlomo98 As ProgressBar
    Friend WithEvents pgb_dieselPlus As ProgressBar
    Friend WithEvents lbl_sinPlomo98 As Label
    Friend WithEvents pgb_diesel As ProgressBar
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lbl_ As Label
    Friend WithEvents lbl_tipoCombustible As Label
    Friend WithEvents lbl_precioCombustible As Label
    Friend WithEvents nud_precioCombustible As NumericUpDown
    Friend WithEvents pgb_restanteDeposito As ProgressBar
    Friend WithEvents lbl_restante As Label
    Friend WithEvents lbl_euro As Label
    Friend WithEvents lbl_restanteLitros As Label
    Friend WithEvents btn_rellenarTanque As Button
    Friend WithEvents cbx_tipoCombustible As ComboBox
    Friend WithEvents txt_buscarTienda As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents pbx_eliminarEmpleados As PictureBox
    Friend WithEvents pbx_editarEmpleados As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pbx_crearEmpleados As PictureBox
    Friend WithEvents txt_buscarEmpleado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv_empleados As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents pbx_eliminarProveedor As PictureBox
    Friend WithEvents pbx_editarProveedor As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pbx_crearProveedor As PictureBox
    Friend WithEvents txt_buscarProveedores As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_proveedores As DataGridView
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents pbx_eliminarCliente As PictureBox
    Friend WithEvents pbx_editarCliente As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents pbx_crearCliente As PictureBox
    Friend WithEvents txt_buscarCliente As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dgv_clientes As DataGridView
End Class
