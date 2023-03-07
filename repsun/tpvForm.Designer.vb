<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tpvForm
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
        Me.tlp_tpv = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tlp_caja = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp_teclado = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_teclado_cobrar = New System.Windows.Forms.Button()
        Me.btn_coma = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_atras = New System.Windows.Forms.Button()
        Me.btn_exacto = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.txt_introducido = New System.Windows.Forms.TextBox()
        Me.lbl_introducido = New System.Windows.Forms.Label()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_combustible = New System.Windows.Forms.DataGridView()
        Me.dgv_carrito = New System.Windows.Forms.DataGridView()
        Me.lbl_totalSinImpuestos = New System.Windows.Forms.Label()
        Me.lbl_impuestos = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.btn_eliminarTodo = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_sp95 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_sp98 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbx_diesela = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_diesela_plus = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbc_tienda = New System.Windows.Forms.TabControl()
        Me.tpg_comida = New System.Windows.Forms.TabPage()
        Me.tlp_Comida = New System.Windows.Forms.TableLayoutPanel()
        Me.tpg_bebida = New System.Windows.Forms.TabPage()
        Me.tlp_Bebida = New System.Windows.Forms.TableLayoutPanel()
        Me.tpg_otros = New System.Windows.Forms.TabPage()
        Me.tlp_Otros = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.tlp_tpv.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_caja.SuspendLayout()
        Me.tlp_teclado.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_combustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_carrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.pbx_sp95, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.pbx_sp98, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.pbx_diesela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.pbx_diesela_plus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.tbc_tienda.SuspendLayout()
        Me.tpg_comida.SuspendLayout()
        Me.tpg_bebida.SuspendLayout()
        Me.tpg_otros.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_tpv
        '
        Me.tlp_tpv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tlp_tpv.ColumnCount = 2
        Me.tlp_tpv.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.tlp_tpv.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlp_tpv.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tlp_tpv.Controls.Add(Me.tlp_caja, 1, 0)
        Me.tlp_tpv.Controls.Add(Me.TabControl1, 0, 1)
        Me.tlp_tpv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_tpv.Location = New System.Drawing.Point(0, 0)
        Me.tlp_tpv.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tlp_tpv.Name = "tlp_tpv"
        Me.tlp_tpv.RowCount = 2
        Me.tlp_tpv.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_tpv.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334!))
        Me.tlp_tpv.Size = New System.Drawing.Size(2588, 1628)
        Me.tlp_tpv.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.repsun.My.Resources.Resources.LogoTransparente_1
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(317, 259)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'tlp_caja
        '
        Me.tlp_caja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.tlp_caja.ColumnCount = 1
        Me.tlp_caja.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_caja.Controls.Add(Me.tlp_teclado, 0, 1)
        Me.tlp_caja.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.tlp_caja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_caja.Location = New System.Drawing.Point(1731, 6)
        Me.tlp_caja.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tlp_caja.Name = "tlp_caja"
        Me.tlp_caja.RowCount = 2
        Me.tlp_tpv.SetRowSpan(Me.tlp_caja, 2)
        Me.tlp_caja.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlp_caja.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlp_caja.Size = New System.Drawing.Size(851, 1616)
        Me.tlp_caja.TabIndex = 0
        '
        'tlp_teclado
        '
        Me.tlp_teclado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.tlp_teclado.ColumnCount = 5
        Me.tlp_teclado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86793!))
        Me.tlp_teclado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86793!))
        Me.tlp_teclado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86793!))
        Me.tlp_teclado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86793!))
        Me.tlp_teclado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5283!))
        Me.tlp_teclado.Controls.Add(Me.btn_0, 3, 4)
        Me.tlp_teclado.Controls.Add(Me.btn_9, 2, 4)
        Me.tlp_teclado.Controls.Add(Me.btn_8, 1, 4)
        Me.tlp_teclado.Controls.Add(Me.btn_7, 0, 4)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_cobrar, 4, 3)
        Me.tlp_teclado.Controls.Add(Me.btn_coma, 3, 3)
        Me.tlp_teclado.Controls.Add(Me.btn_6, 2, 3)
        Me.tlp_teclado.Controls.Add(Me.btn_5, 1, 3)
        Me.tlp_teclado.Controls.Add(Me.btn_4, 0, 3)
        Me.tlp_teclado.Controls.Add(Me.btn_atras, 4, 2)
        Me.tlp_teclado.Controls.Add(Me.btn_exacto, 3, 2)
        Me.tlp_teclado.Controls.Add(Me.btn_3, 2, 2)
        Me.tlp_teclado.Controls.Add(Me.btn_1, 0, 2)
        Me.tlp_teclado.Controls.Add(Me.txt_introducido, 0, 1)
        Me.tlp_teclado.Controls.Add(Me.lbl_introducido, 0, 0)
        Me.tlp_teclado.Controls.Add(Me.btn_2, 1, 2)
        Me.tlp_teclado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_teclado.Location = New System.Drawing.Point(6, 975)
        Me.tlp_teclado.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tlp_teclado.Name = "tlp_teclado"
        Me.tlp_teclado.RowCount = 5
        Me.tlp_teclado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_teclado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_teclado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_teclado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_teclado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_teclado.Size = New System.Drawing.Size(839, 635)
        Me.tlp_teclado.TabIndex = 0
        '
        'btn_0
        '
        Me.btn_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_0.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_0.ForeColor = System.Drawing.Color.White
        Me.btn_0.Location = New System.Drawing.Point(480, 480)
        Me.btn_0.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(146, 149)
        Me.btn_0.TabIndex = 14
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = False
        '
        'btn_9
        '
        Me.btn_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_9.ForeColor = System.Drawing.Color.White
        Me.btn_9.Location = New System.Drawing.Point(322, 480)
        Me.btn_9.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(146, 149)
        Me.btn_9.TabIndex = 13
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = False
        '
        'btn_8
        '
        Me.btn_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_8.ForeColor = System.Drawing.Color.White
        Me.btn_8.Location = New System.Drawing.Point(164, 480)
        Me.btn_8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(146, 149)
        Me.btn_8.TabIndex = 12
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = False
        '
        'btn_7
        '
        Me.btn_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_7.ForeColor = System.Drawing.Color.White
        Me.btn_7.Location = New System.Drawing.Point(6, 480)
        Me.btn_7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(146, 149)
        Me.btn_7.TabIndex = 11
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = False
        '
        'btn_teclado_cobrar
        '
        Me.btn_teclado_cobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_teclado_cobrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_cobrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_cobrar.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_cobrar.Location = New System.Drawing.Point(638, 322)
        Me.btn_teclado_cobrar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_teclado_cobrar.Name = "btn_teclado_cobrar"
        Me.tlp_teclado.SetRowSpan(Me.btn_teclado_cobrar, 2)
        Me.btn_teclado_cobrar.Size = New System.Drawing.Size(195, 307)
        Me.btn_teclado_cobrar.TabIndex = 10
        Me.btn_teclado_cobrar.Text = "Cobrar"
        Me.btn_teclado_cobrar.UseVisualStyleBackColor = False
        '
        'btn_coma
        '
        Me.btn_coma.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_coma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_coma.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_coma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_coma.ForeColor = System.Drawing.Color.White
        Me.btn_coma.Location = New System.Drawing.Point(480, 322)
        Me.btn_coma.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_coma.Name = "btn_coma"
        Me.btn_coma.Size = New System.Drawing.Size(146, 146)
        Me.btn_coma.TabIndex = 9
        Me.btn_coma.Text = ","
        Me.btn_coma.UseVisualStyleBackColor = False
        '
        'btn_6
        '
        Me.btn_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_6.ForeColor = System.Drawing.Color.White
        Me.btn_6.Location = New System.Drawing.Point(322, 322)
        Me.btn_6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(146, 146)
        Me.btn_6.TabIndex = 8
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = False
        '
        'btn_5
        '
        Me.btn_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_5.ForeColor = System.Drawing.Color.White
        Me.btn_5.Location = New System.Drawing.Point(164, 322)
        Me.btn_5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(146, 146)
        Me.btn_5.TabIndex = 7
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = False
        '
        'btn_4
        '
        Me.btn_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_4.ForeColor = System.Drawing.Color.White
        Me.btn_4.Location = New System.Drawing.Point(6, 322)
        Me.btn_4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(146, 146)
        Me.btn_4.TabIndex = 6
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = False
        '
        'btn_atras
        '
        Me.btn_atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_atras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_atras.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_atras.ForeColor = System.Drawing.Color.White
        Me.btn_atras.Location = New System.Drawing.Point(638, 164)
        Me.btn_atras.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_atras.Name = "btn_atras"
        Me.btn_atras.Size = New System.Drawing.Size(195, 146)
        Me.btn_atras.TabIndex = 5
        Me.btn_atras.Text = "<---"
        Me.btn_atras.UseVisualStyleBackColor = False
        '
        'btn_exacto
        '
        Me.btn_exacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_exacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_exacto.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_exacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exacto.ForeColor = System.Drawing.Color.White
        Me.btn_exacto.Location = New System.Drawing.Point(480, 164)
        Me.btn_exacto.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_exacto.Name = "btn_exacto"
        Me.btn_exacto.Size = New System.Drawing.Size(146, 146)
        Me.btn_exacto.TabIndex = 4
        Me.btn_exacto.Text = "Exacto"
        Me.btn_exacto.UseVisualStyleBackColor = False
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_3.ForeColor = System.Drawing.Color.White
        Me.btn_3.Location = New System.Drawing.Point(322, 164)
        Me.btn_3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(146, 146)
        Me.btn_3.TabIndex = 3
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = False
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_1.ForeColor = System.Drawing.Color.White
        Me.btn_1.Location = New System.Drawing.Point(6, 164)
        Me.btn_1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(146, 146)
        Me.btn_1.TabIndex = 0
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = False
        '
        'txt_introducido
        '
        Me.tlp_teclado.SetColumnSpan(Me.txt_introducido, 5)
        Me.txt_introducido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_introducido.Enabled = False
        Me.txt_introducido.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_introducido.Location = New System.Drawing.Point(55, 69)
        Me.txt_introducido.Margin = New System.Windows.Forms.Padding(55, 6, 55, 6)
        Me.txt_introducido.MaxLength = 6
        Me.txt_introducido.Name = "txt_introducido"
        Me.txt_introducido.Size = New System.Drawing.Size(729, 82)
        Me.txt_introducido.TabIndex = 0
        '
        'lbl_introducido
        '
        Me.lbl_introducido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_introducido.AutoSize = True
        Me.tlp_teclado.SetColumnSpan(Me.lbl_introducido, 5)
        Me.lbl_introducido.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_introducido.Location = New System.Drawing.Point(55, 0)
        Me.lbl_introducido.Margin = New System.Windows.Forms.Padding(55, 0, 6, 0)
        Me.lbl_introducido.Name = "lbl_introducido"
        Me.lbl_introducido.Size = New System.Drawing.Size(284, 63)
        Me.lbl_introducido.TabIndex = 1
        Me.lbl_introducido.Text = "Introducido:"
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_2.ForeColor = System.Drawing.Color.White
        Me.btn_2.Location = New System.Drawing.Point(164, 164)
        Me.btn_2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(146, 146)
        Me.btn_2.TabIndex = 2
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_totalSinImpuestos, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_impuestos, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Total, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_eliminarTodo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_eliminar, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox2, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(839, 957)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel1
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.dgv_combustible)
        Me.Panel1.Controls.Add(Me.dgv_carrito)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(6, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 466)
        Me.Panel1.TabIndex = 3
        '
        'dgv_combustible
        '
        Me.dgv_combustible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_combustible.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgv_combustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_combustible.ColumnHeadersVisible = False
        Me.dgv_combustible.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_combustible.Location = New System.Drawing.Point(0, 407)
        Me.dgv_combustible.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgv_combustible.Name = "dgv_combustible"
        Me.dgv_combustible.RowHeadersWidth = 72
        Me.dgv_combustible.Size = New System.Drawing.Size(827, 59)
        Me.dgv_combustible.TabIndex = 1
        '
        'dgv_carrito
        '
        Me.dgv_carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_carrito.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgv_carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_carrito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_carrito.Location = New System.Drawing.Point(0, 0)
        Me.dgv_carrito.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgv_carrito.Name = "dgv_carrito"
        Me.dgv_carrito.RowHeadersWidth = 72
        Me.dgv_carrito.Size = New System.Drawing.Size(827, 466)
        Me.dgv_carrito.TabIndex = 0
        '
        'lbl_totalSinImpuestos
        '
        Me.lbl_totalSinImpuestos.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_totalSinImpuestos, 3)
        Me.lbl_totalSinImpuestos.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalSinImpuestos.Location = New System.Drawing.Point(6, 597)
        Me.lbl_totalSinImpuestos.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_totalSinImpuestos.Name = "lbl_totalSinImpuestos"
        Me.lbl_totalSinImpuestos.Size = New System.Drawing.Size(336, 50)
        Me.lbl_totalSinImpuestos.TabIndex = 3
        Me.lbl_totalSinImpuestos.Text = "Total sin impuestos"
        '
        'lbl_impuestos
        '
        Me.lbl_impuestos.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_impuestos, 3)
        Me.lbl_impuestos.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_impuestos.Location = New System.Drawing.Point(6, 692)
        Me.lbl_impuestos.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_impuestos.Name = "lbl_impuestos"
        Me.lbl_impuestos.Size = New System.Drawing.Size(201, 50)
        Me.lbl_impuestos.TabIndex = 4
        Me.lbl_impuestos.Text = "Impuestos:"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_Total, 3)
        Me.lbl_Total.Font = New System.Drawing.Font("Yu Gothic UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(6, 810)
        Me.lbl_Total.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(161, 68)
        Me.lbl_Total.TabIndex = 6
        Me.lbl_Total.Text = "Total: "
        '
        'btn_eliminarTodo
        '
        Me.btn_eliminarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_eliminarTodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_eliminarTodo.FlatAppearance.BorderSize = 0
        Me.btn_eliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminarTodo.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminarTodo.Location = New System.Drawing.Point(6, 6)
        Me.btn_eliminarTodo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_eliminarTodo.Name = "btn_eliminarTodo"
        Me.btn_eliminarTodo.Size = New System.Drawing.Size(267, 107)
        Me.btn_eliminarTodo.TabIndex = 1
        Me.btn_eliminarTodo.Text = "Eliminar todo"
        Me.btn_eliminarTodo.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_eliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_eliminar.FlatAppearance.BorderSize = 0
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(285, 6)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(267, 107)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.repsun.My.Resources.Resources.Salir
        Me.PictureBox2.Location = New System.Drawing.Point(650, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(183, 107)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 277)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1713, 1345)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.BackgroundImage = Global.repsun.My.Resources.Resources.tpv
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 71)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabPage1.Size = New System.Drawing.Size(1705, 1270)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Combustible"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TableLayoutPanel1.BackgroundImage = Global.repsun.My.Resources.Resources.tpv
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 3, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1693, 1258)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.pbx_sp95, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(159, 120)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(603, 445)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'pbx_sp95
        '
        Me.pbx_sp95.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.pbx_sp95.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_sp95.Image = Global.repsun.My.Resources.Resources.sin_plomo_95
        Me.pbx_sp95.Location = New System.Drawing.Point(6, 6)
        Me.pbx_sp95.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pbx_sp95.Name = "pbx_sp95"
        Me.pbx_sp95.Size = New System.Drawing.Size(591, 344)
        Me.pbx_sp95.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_sp95.TabIndex = 0
        Me.pbx_sp95.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(142, 356)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(318, 65)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Sin plomo 95"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.pbx_sp98, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(927, 120)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(603, 445)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'pbx_sp98
        '
        Me.pbx_sp98.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pbx_sp98.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_sp98.Image = Global.repsun.My.Resources.Resources.sin_plomo_98
        Me.pbx_sp98.Location = New System.Drawing.Point(6, 6)
        Me.pbx_sp98.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pbx_sp98.Name = "pbx_sp98"
        Me.pbx_sp98.Size = New System.Drawing.Size(591, 344)
        Me.pbx_sp98.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_sp98.TabIndex = 0
        Me.pbx_sp98.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(142, 356)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 65)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sin plomo 98"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.pbx_diesela, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(159, 691)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(603, 445)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(221, 356)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 65)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Diesel"
        '
        'pbx_diesela
        '
        Me.pbx_diesela.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pbx_diesela.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_diesela.Image = Global.repsun.My.Resources.Resources.diesel_a
        Me.pbx_diesela.Location = New System.Drawing.Point(6, 6)
        Me.pbx_diesela.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pbx_diesela.Name = "pbx_diesela"
        Me.pbx_diesela.Size = New System.Drawing.Size(591, 344)
        Me.pbx_diesela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_diesela.TabIndex = 0
        Me.pbx_diesela.TabStop = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.pbx_diesela_plus, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(927, 691)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(603, 445)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'pbx_diesela_plus
        '
        Me.pbx_diesela_plus.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pbx_diesela_plus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_diesela_plus.Image = Global.repsun.My.Resources.Resources.diesel_a_plus
        Me.pbx_diesela_plus.Location = New System.Drawing.Point(6, 6)
        Me.pbx_diesela_plus.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pbx_diesela_plus.Name = "pbx_diesela_plus"
        Me.pbx_diesela_plus.Size = New System.Drawing.Size(591, 344)
        Me.pbx_diesela_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_diesela_plus.TabIndex = 0
        Me.pbx_diesela_plus.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(198, 356)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 65)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Diesel +"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage2.Controls.Add(Me.tbc_tienda)
        Me.TabPage2.Location = New System.Drawing.Point(4, 71)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabPage2.Size = New System.Drawing.Size(2308, 1516)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tienda"
        '
        'tbc_tienda
        '
        Me.tbc_tienda.Controls.Add(Me.tpg_comida)
        Me.tbc_tienda.Controls.Add(Me.tpg_bebida)
        Me.tbc_tienda.Controls.Add(Me.tpg_otros)
        Me.tbc_tienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbc_tienda.Location = New System.Drawing.Point(6, 6)
        Me.tbc_tienda.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbc_tienda.Name = "tbc_tienda"
        Me.tbc_tienda.SelectedIndex = 0
        Me.tbc_tienda.Size = New System.Drawing.Size(2296, 1504)
        Me.tbc_tienda.TabIndex = 0
        '
        'tpg_comida
        '
        Me.tpg_comida.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpg_comida.BackgroundImage = Global.repsun.My.Resources.Resources.tpv
        Me.tpg_comida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tpg_comida.Controls.Add(Me.tlp_Comida)
        Me.tpg_comida.Location = New System.Drawing.Point(4, 71)
        Me.tpg_comida.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tpg_comida.Name = "tpg_comida"
        Me.tpg_comida.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tpg_comida.Size = New System.Drawing.Size(2288, 1429)
        Me.tpg_comida.TabIndex = 0
        Me.tpg_comida.Text = "Comida"
        '
        'tlp_Comida
        '
        Me.tlp_Comida.AutoScroll = True
        Me.tlp_Comida.ColumnCount = 5
        Me.tlp_Comida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Comida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Comida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Comida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Comida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Comida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Comida.Location = New System.Drawing.Point(6, 6)
        Me.tlp_Comida.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tlp_Comida.Name = "tlp_Comida"
        Me.tlp_Comida.RowCount = 1
        Me.tlp_Comida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Comida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1338.0!))
        Me.tlp_Comida.Size = New System.Drawing.Size(2276, 1417)
        Me.tlp_Comida.TabIndex = 0
        '
        'tpg_bebida
        '
        Me.tpg_bebida.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpg_bebida.BackgroundImage = Global.repsun.My.Resources.Resources.tpv
        Me.tpg_bebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tpg_bebida.Controls.Add(Me.tlp_Bebida)
        Me.tpg_bebida.Location = New System.Drawing.Point(4, 71)
        Me.tpg_bebida.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tpg_bebida.Name = "tpg_bebida"
        Me.tpg_bebida.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tpg_bebida.Size = New System.Drawing.Size(2282, 1413)
        Me.tpg_bebida.TabIndex = 1
        Me.tpg_bebida.Text = "Bebida"
        '
        'tlp_Bebida
        '
        Me.tlp_Bebida.AutoScroll = True
        Me.tlp_Bebida.ColumnCount = 5
        Me.tlp_Bebida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Bebida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Bebida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Bebida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Bebida.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Bebida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Bebida.Location = New System.Drawing.Point(6, 6)
        Me.tlp_Bebida.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tlp_Bebida.Name = "tlp_Bebida"
        Me.tlp_Bebida.RowCount = 1
        Me.tlp_Bebida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Bebida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1409.0!))
        Me.tlp_Bebida.Size = New System.Drawing.Size(2270, 1401)
        Me.tlp_Bebida.TabIndex = 1
        '
        'tpg_otros
        '
        Me.tpg_otros.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpg_otros.BackgroundImage = Global.repsun.My.Resources.Resources.tpv
        Me.tpg_otros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tpg_otros.Controls.Add(Me.tlp_Otros)
        Me.tpg_otros.Location = New System.Drawing.Point(4, 71)
        Me.tpg_otros.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tpg_otros.Name = "tpg_otros"
        Me.tpg_otros.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tpg_otros.Size = New System.Drawing.Size(2282, 1413)
        Me.tpg_otros.TabIndex = 2
        Me.tpg_otros.Text = "Otros"
        '
        'tlp_Otros
        '
        Me.tlp_Otros.AutoScroll = True
        Me.tlp_Otros.ColumnCount = 5
        Me.tlp_Otros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Otros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Otros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Otros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Otros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_Otros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_Otros.Location = New System.Drawing.Point(6, 6)
        Me.tlp_Otros.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tlp_Otros.Name = "tlp_Otros"
        Me.tlp_Otros.RowCount = 1
        Me.tlp_Otros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Otros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1409.0!))
        Me.tlp_Otros.Size = New System.Drawing.Size(2270, 1401)
        Me.tlp_Otros.TabIndex = 2
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\castr\source\repos\IvanCastroLopez\repsun\repsun\bin\Debug\Repsun_Ayuda." &
    "chm"
        '
        'tpvForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2588, 1628)
        Me.Controls.Add(Me.tlp_tpv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpKeyword(Me, "")
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "tpvForm"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "tpvForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_tpv.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_caja.ResumeLayout(False)
        Me.tlp_teclado.ResumeLayout(False)
        Me.tlp_teclado.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_combustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_carrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.pbx_sp95, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.pbx_sp98, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.pbx_diesela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.pbx_diesela_plus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.tbc_tienda.ResumeLayout(False)
        Me.tpg_comida.ResumeLayout(False)
        Me.tpg_bebida.ResumeLayout(False)
        Me.tpg_otros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_tpv As TableLayoutPanel
    Friend WithEvents tlp_caja As TableLayoutPanel
    Friend WithEvents tlp_teclado As TableLayoutPanel
    Friend WithEvents btn_0 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_teclado_cobrar As Button
    Friend WithEvents btn_coma As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_atras As Button
    Friend WithEvents btn_exacto As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents txt_introducido As TextBox
    Friend WithEvents lbl_introducido As Label
    Friend WithEvents btn_2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tbc_tienda As TabControl
    Friend WithEvents tpg_comida As TabPage
    Friend WithEvents tpg_bebida As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgv_carrito As DataGridView
    Friend WithEvents btn_eliminarTodo As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents lbl_totalSinImpuestos As Label
    Friend WithEvents lbl_impuestos As Label
    Friend WithEvents lbl_Total As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents pbx_sp95 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents pbx_sp98 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents pbx_diesela As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents pbx_diesela_plus As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tpg_otros As TabPage
    Friend WithEvents tlp_Comida As TableLayoutPanel
    Friend WithEvents tlp_Bebida As TableLayoutPanel
    Friend WithEvents tlp_Otros As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_combustible As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
