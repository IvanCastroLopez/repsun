﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.tlp_caja = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp_teclado = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_teclado_0 = New System.Windows.Forms.Button()
        Me.btn_teclado_9 = New System.Windows.Forms.Button()
        Me.btn_teclado_8 = New System.Windows.Forms.Button()
        Me.btn_teclado_7 = New System.Windows.Forms.Button()
        Me.btn_teclado_cobrar = New System.Windows.Forms.Button()
        Me.btn_teclado_coma = New System.Windows.Forms.Button()
        Me.btn_teclado_6 = New System.Windows.Forms.Button()
        Me.btn_teclado_5 = New System.Windows.Forms.Button()
        Me.btn_teclado_4 = New System.Windows.Forms.Button()
        Me.btn_teclado_restar = New System.Windows.Forms.Button()
        Me.btn_tecladoExacto = New System.Windows.Forms.Button()
        Me.btn_teclado_3 = New System.Windows.Forms.Button()
        Me.btn_teclado_1 = New System.Windows.Forms.Button()
        Me.txt_introducido = New System.Windows.Forms.TextBox()
        Me.lbl_introducido = New System.Windows.Forms.Label()
        Me.btn_teclado_2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_carrito = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_totalSinImpuestos = New System.Windows.Forms.Label()
        Me.lbl_impuestos = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_combustible = New System.Windows.Forms.DataGridView()
        Me.tlp_tpv.SuspendLayout()
        Me.tlp_caja.SuspendLayout()
        Me.tlp_teclado.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgv_carrito, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_combustible, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlp_tpv.Name = "tlp_tpv"
        Me.tlp_tpv.RowCount = 2
        Me.tlp_tpv.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_tpv.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334!))
        Me.tlp_tpv.Size = New System.Drawing.Size(1904, 1041)
        Me.tlp_tpv.TabIndex = 0
        '
        'tlp_caja
        '
        Me.tlp_caja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.tlp_caja.ColumnCount = 1
        Me.tlp_caja.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_caja.Controls.Add(Me.tlp_teclado, 0, 1)
        Me.tlp_caja.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.tlp_caja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_caja.Location = New System.Drawing.Point(1272, 3)
        Me.tlp_caja.Name = "tlp_caja"
        Me.tlp_caja.RowCount = 2
        Me.tlp_tpv.SetRowSpan(Me.tlp_caja, 2)
        Me.tlp_caja.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlp_caja.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlp_caja.Size = New System.Drawing.Size(629, 1035)
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
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_0, 3, 4)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_9, 2, 4)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_8, 1, 4)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_7, 0, 4)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_cobrar, 4, 3)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_coma, 3, 3)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_6, 2, 3)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_5, 1, 3)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_4, 0, 3)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_restar, 4, 2)
        Me.tlp_teclado.Controls.Add(Me.btn_tecladoExacto, 3, 2)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_3, 2, 2)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_1, 0, 2)
        Me.tlp_teclado.Controls.Add(Me.txt_introducido, 0, 1)
        Me.tlp_teclado.Controls.Add(Me.lbl_introducido, 0, 0)
        Me.tlp_teclado.Controls.Add(Me.btn_teclado_2, 1, 2)
        Me.tlp_teclado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_teclado.Location = New System.Drawing.Point(3, 624)
        Me.tlp_teclado.Name = "tlp_teclado"
        Me.tlp_teclado.RowCount = 5
        Me.tlp_teclado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_teclado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_teclado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_teclado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_teclado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_teclado.Size = New System.Drawing.Size(623, 408)
        Me.tlp_teclado.TabIndex = 0
        '
        'btn_teclado_0
        '
        Me.btn_teclado_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_0.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_0.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_0.Location = New System.Drawing.Point(354, 308)
        Me.btn_teclado_0.Name = "btn_teclado_0"
        Me.btn_teclado_0.Size = New System.Drawing.Size(111, 97)
        Me.btn_teclado_0.TabIndex = 14
        Me.btn_teclado_0.Text = "0"
        Me.btn_teclado_0.UseVisualStyleBackColor = False
        '
        'btn_teclado_9
        '
        Me.btn_teclado_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_9.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_9.Location = New System.Drawing.Point(237, 308)
        Me.btn_teclado_9.Name = "btn_teclado_9"
        Me.btn_teclado_9.Size = New System.Drawing.Size(111, 97)
        Me.btn_teclado_9.TabIndex = 13
        Me.btn_teclado_9.Text = "9"
        Me.btn_teclado_9.UseVisualStyleBackColor = False
        '
        'btn_teclado_8
        '
        Me.btn_teclado_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_8.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_8.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_8.Location = New System.Drawing.Point(120, 308)
        Me.btn_teclado_8.Name = "btn_teclado_8"
        Me.btn_teclado_8.Size = New System.Drawing.Size(111, 97)
        Me.btn_teclado_8.TabIndex = 12
        Me.btn_teclado_8.Text = "8"
        Me.btn_teclado_8.UseVisualStyleBackColor = False
        '
        'btn_teclado_7
        '
        Me.btn_teclado_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_7.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_7.Location = New System.Drawing.Point(3, 308)
        Me.btn_teclado_7.Name = "btn_teclado_7"
        Me.btn_teclado_7.Size = New System.Drawing.Size(111, 97)
        Me.btn_teclado_7.TabIndex = 11
        Me.btn_teclado_7.Text = "7"
        Me.btn_teclado_7.UseVisualStyleBackColor = False
        '
        'btn_teclado_cobrar
        '
        Me.btn_teclado_cobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_teclado_cobrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_cobrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_cobrar.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_cobrar.Location = New System.Drawing.Point(471, 206)
        Me.btn_teclado_cobrar.Name = "btn_teclado_cobrar"
        Me.tlp_teclado.SetRowSpan(Me.btn_teclado_cobrar, 2)
        Me.btn_teclado_cobrar.Size = New System.Drawing.Size(149, 199)
        Me.btn_teclado_cobrar.TabIndex = 10
        Me.btn_teclado_cobrar.Text = "Cobrar"
        Me.btn_teclado_cobrar.UseVisualStyleBackColor = False
        '
        'btn_teclado_coma
        '
        Me.btn_teclado_coma.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_coma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_coma.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_coma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_coma.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_coma.Location = New System.Drawing.Point(354, 206)
        Me.btn_teclado_coma.Name = "btn_teclado_coma"
        Me.btn_teclado_coma.Size = New System.Drawing.Size(111, 96)
        Me.btn_teclado_coma.TabIndex = 9
        Me.btn_teclado_coma.Text = ","
        Me.btn_teclado_coma.UseVisualStyleBackColor = False
        '
        'btn_teclado_6
        '
        Me.btn_teclado_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_6.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_6.Location = New System.Drawing.Point(237, 206)
        Me.btn_teclado_6.Name = "btn_teclado_6"
        Me.btn_teclado_6.Size = New System.Drawing.Size(111, 96)
        Me.btn_teclado_6.TabIndex = 8
        Me.btn_teclado_6.Text = "6"
        Me.btn_teclado_6.UseVisualStyleBackColor = False
        '
        'btn_teclado_5
        '
        Me.btn_teclado_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_5.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_5.Location = New System.Drawing.Point(120, 206)
        Me.btn_teclado_5.Name = "btn_teclado_5"
        Me.btn_teclado_5.Size = New System.Drawing.Size(111, 96)
        Me.btn_teclado_5.TabIndex = 7
        Me.btn_teclado_5.Text = "5"
        Me.btn_teclado_5.UseVisualStyleBackColor = False
        '
        'btn_teclado_4
        '
        Me.btn_teclado_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_4.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_4.Location = New System.Drawing.Point(3, 206)
        Me.btn_teclado_4.Name = "btn_teclado_4"
        Me.btn_teclado_4.Size = New System.Drawing.Size(111, 96)
        Me.btn_teclado_4.TabIndex = 6
        Me.btn_teclado_4.Text = "4"
        Me.btn_teclado_4.UseVisualStyleBackColor = False
        '
        'btn_teclado_restar
        '
        Me.btn_teclado_restar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_restar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_restar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_restar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_restar.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_restar.Location = New System.Drawing.Point(471, 104)
        Me.btn_teclado_restar.Name = "btn_teclado_restar"
        Me.btn_teclado_restar.Size = New System.Drawing.Size(149, 96)
        Me.btn_teclado_restar.TabIndex = 5
        Me.btn_teclado_restar.Text = "<---"
        Me.btn_teclado_restar.UseVisualStyleBackColor = False
        '
        'btn_tecladoExacto
        '
        Me.btn_tecladoExacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_tecladoExacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_tecladoExacto.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_tecladoExacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tecladoExacto.ForeColor = System.Drawing.Color.White
        Me.btn_tecladoExacto.Location = New System.Drawing.Point(354, 104)
        Me.btn_tecladoExacto.Name = "btn_tecladoExacto"
        Me.btn_tecladoExacto.Size = New System.Drawing.Size(111, 96)
        Me.btn_tecladoExacto.TabIndex = 4
        Me.btn_tecladoExacto.Text = "Exacto"
        Me.btn_tecladoExacto.UseVisualStyleBackColor = False
        '
        'btn_teclado_3
        '
        Me.btn_teclado_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_3.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_3.Location = New System.Drawing.Point(237, 104)
        Me.btn_teclado_3.Name = "btn_teclado_3"
        Me.btn_teclado_3.Size = New System.Drawing.Size(111, 96)
        Me.btn_teclado_3.TabIndex = 3
        Me.btn_teclado_3.Text = "3"
        Me.btn_teclado_3.UseVisualStyleBackColor = False
        '
        'btn_teclado_1
        '
        Me.btn_teclado_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_1.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_1.Location = New System.Drawing.Point(3, 104)
        Me.btn_teclado_1.Name = "btn_teclado_1"
        Me.btn_teclado_1.Size = New System.Drawing.Size(111, 96)
        Me.btn_teclado_1.TabIndex = 0
        Me.btn_teclado_1.Text = "1"
        Me.btn_teclado_1.UseVisualStyleBackColor = False
        '
        'txt_introducido
        '
        Me.tlp_teclado.SetColumnSpan(Me.txt_introducido, 5)
        Me.txt_introducido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_introducido.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_introducido.Location = New System.Drawing.Point(30, 43)
        Me.txt_introducido.Margin = New System.Windows.Forms.Padding(30, 3, 30, 3)
        Me.txt_introducido.Name = "txt_introducido"
        Me.txt_introducido.Size = New System.Drawing.Size(563, 50)
        Me.txt_introducido.TabIndex = 0
        '
        'lbl_introducido
        '
        Me.lbl_introducido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_introducido.AutoSize = True
        Me.tlp_teclado.SetColumnSpan(Me.lbl_introducido, 5)
        Me.lbl_introducido.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_introducido.Location = New System.Drawing.Point(30, 3)
        Me.lbl_introducido.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.lbl_introducido.Name = "lbl_introducido"
        Me.lbl_introducido.Size = New System.Drawing.Size(161, 37)
        Me.lbl_introducido.TabIndex = 1
        Me.lbl_introducido.Text = "Introducido:"
        '
        'btn_teclado_2
        '
        Me.btn_teclado_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btn_teclado_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_teclado_2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_teclado_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teclado_2.ForeColor = System.Drawing.Color.White
        Me.btn_teclado_2.Location = New System.Drawing.Point(120, 104)
        Me.btn_teclado_2.Name = "btn_teclado_2"
        Me.btn_teclado_2.Size = New System.Drawing.Size(111, 96)
        Me.btn_teclado_2.TabIndex = 2
        Me.btn_teclado_2.Text = "2"
        Me.btn_teclado_2.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_totalSinImpuestos, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_impuestos, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Total, 0, 5)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(623, 615)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'dgv_carrito
        '
        Me.dgv_carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_carrito.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgv_carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_carrito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_carrito.Location = New System.Drawing.Point(0, 0)
        Me.dgv_carrito.Name = "dgv_carrito"
        Me.dgv_carrito.Size = New System.Drawing.Size(617, 301)
        Me.dgv_carrito.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(210, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 70)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Eliminar todo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(417, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(203, 70)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lbl_totalSinImpuestos
        '
        Me.lbl_totalSinImpuestos.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_totalSinImpuestos, 3)
        Me.lbl_totalSinImpuestos.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalSinImpuestos.Location = New System.Drawing.Point(3, 383)
        Me.lbl_totalSinImpuestos.Name = "lbl_totalSinImpuestos"
        Me.lbl_totalSinImpuestos.Size = New System.Drawing.Size(190, 30)
        Me.lbl_totalSinImpuestos.TabIndex = 3
        Me.lbl_totalSinImpuestos.Text = "Total sin impuestos"
        '
        'lbl_impuestos
        '
        Me.lbl_impuestos.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_impuestos, 3)
        Me.lbl_impuestos.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_impuestos.Location = New System.Drawing.Point(3, 444)
        Me.lbl_impuestos.Name = "lbl_impuestos"
        Me.lbl_impuestos.Size = New System.Drawing.Size(114, 30)
        Me.lbl_impuestos.TabIndex = 4
        Me.lbl_impuestos.Text = "Impuestos:"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_Total, 3)
        Me.lbl_Total.Font = New System.Drawing.Font("Yu Gothic UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(3, 520)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(92, 40)
        Me.lbl_Total.TabIndex = 6
        Me.lbl_Total.Text = "Total: "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 176)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1263, 862)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.BackgroundImage = Global.repsun.My.Resources.Resources.tpv
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 46)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1255, 812)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1249, 806)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.pbx_sp95, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(116, 76)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(448, 287)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'pbx_sp95
        '
        Me.pbx_sp95.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.pbx_sp95.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_sp95.Image = Global.repsun.My.Resources.Resources.sin_plomo_95
        Me.pbx_sp95.Location = New System.Drawing.Point(3, 3)
        Me.pbx_sp95.Name = "pbx_sp95"
        Me.pbx_sp95.Size = New System.Drawing.Size(442, 223)
        Me.pbx_sp95.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_sp95.TabIndex = 0
        Me.pbx_sp95.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(135, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 37)
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(683, 76)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(448, 287)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'pbx_sp98
        '
        Me.pbx_sp98.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pbx_sp98.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_sp98.Image = Global.repsun.My.Resources.Resources.sin_plomo_98
        Me.pbx_sp98.Location = New System.Drawing.Point(3, 3)
        Me.pbx_sp98.Name = "pbx_sp98"
        Me.pbx_sp98.Size = New System.Drawing.Size(442, 223)
        Me.pbx_sp98.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_sp98.TabIndex = 0
        Me.pbx_sp98.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(135, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 37)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sin plomo 98"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.pbx_diesela, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(116, 442)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(448, 287)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(179, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 37)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Diesel"
        '
        'pbx_diesela
        '
        Me.pbx_diesela.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pbx_diesela.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_diesela.Image = Global.repsun.My.Resources.Resources.diesel_a
        Me.pbx_diesela.Location = New System.Drawing.Point(3, 3)
        Me.pbx_diesela.Name = "pbx_diesela"
        Me.pbx_diesela.Size = New System.Drawing.Size(442, 223)
        Me.pbx_diesela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_diesela.TabIndex = 0
        Me.pbx_diesela.TabStop = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.pbx_diesela_plus, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(683, 442)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(448, 287)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'pbx_diesela_plus
        '
        Me.pbx_diesela_plus.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pbx_diesela_plus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_diesela_plus.Image = Global.repsun.My.Resources.Resources.diesel_a_plus
        Me.pbx_diesela_plus.Location = New System.Drawing.Point(3, 3)
        Me.pbx_diesela_plus.Name = "pbx_diesela_plus"
        Me.pbx_diesela_plus.Size = New System.Drawing.Size(442, 223)
        Me.pbx_diesela_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_diesela_plus.TabIndex = 0
        Me.pbx_diesela_plus.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(166, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 37)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Diesel +"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage2.Controls.Add(Me.tbc_tienda)
        Me.TabPage2.Location = New System.Drawing.Point(4, 46)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1255, 812)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tienda"
        '
        'tbc_tienda
        '
        Me.tbc_tienda.Controls.Add(Me.tpg_comida)
        Me.tbc_tienda.Controls.Add(Me.tpg_bebida)
        Me.tbc_tienda.Controls.Add(Me.tpg_otros)
        Me.tbc_tienda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbc_tienda.Location = New System.Drawing.Point(3, 3)
        Me.tbc_tienda.Name = "tbc_tienda"
        Me.tbc_tienda.SelectedIndex = 0
        Me.tbc_tienda.Size = New System.Drawing.Size(1249, 806)
        Me.tbc_tienda.TabIndex = 0
        '
        'tpg_comida
        '
        Me.tpg_comida.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpg_comida.BackgroundImage = Global.repsun.My.Resources.Resources.tpv
        Me.tpg_comida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tpg_comida.Controls.Add(Me.tlp_Comida)
        Me.tpg_comida.Location = New System.Drawing.Point(4, 46)
        Me.tpg_comida.Name = "tpg_comida"
        Me.tpg_comida.Padding = New System.Windows.Forms.Padding(3)
        Me.tpg_comida.Size = New System.Drawing.Size(1241, 756)
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
        Me.tlp_Comida.Location = New System.Drawing.Point(3, 3)
        Me.tlp_Comida.Name = "tlp_Comida"
        Me.tlp_Comida.RowCount = 1
        Me.tlp_Comida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Comida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 750.0!))
        Me.tlp_Comida.Size = New System.Drawing.Size(1235, 750)
        Me.tlp_Comida.TabIndex = 0
        '
        'tpg_bebida
        '
        Me.tpg_bebida.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpg_bebida.BackgroundImage = Global.repsun.My.Resources.Resources.tpv
        Me.tpg_bebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tpg_bebida.Controls.Add(Me.tlp_Bebida)
        Me.tpg_bebida.Location = New System.Drawing.Point(4, 46)
        Me.tpg_bebida.Name = "tpg_bebida"
        Me.tpg_bebida.Padding = New System.Windows.Forms.Padding(3)
        Me.tpg_bebida.Size = New System.Drawing.Size(1241, 756)
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
        Me.tlp_Bebida.Location = New System.Drawing.Point(3, 3)
        Me.tlp_Bebida.Name = "tlp_Bebida"
        Me.tlp_Bebida.RowCount = 1
        Me.tlp_Bebida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Bebida.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 774.0!))
        Me.tlp_Bebida.Size = New System.Drawing.Size(1235, 750)
        Me.tlp_Bebida.TabIndex = 1
        '
        'tpg_otros
        '
        Me.tpg_otros.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tpg_otros.BackgroundImage = Global.repsun.My.Resources.Resources.tpv
        Me.tpg_otros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tpg_otros.Controls.Add(Me.tlp_Otros)
        Me.tpg_otros.Location = New System.Drawing.Point(4, 46)
        Me.tpg_otros.Name = "tpg_otros"
        Me.tpg_otros.Padding = New System.Windows.Forms.Padding(3)
        Me.tpg_otros.Size = New System.Drawing.Size(1241, 756)
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
        Me.tlp_Otros.Location = New System.Drawing.Point(3, 3)
        Me.tlp_Otros.Name = "tlp_Otros"
        Me.tlp_Otros.RowCount = 1
        Me.tlp_Otros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_Otros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 774.0!))
        Me.tlp_Otros.Size = New System.Drawing.Size(1235, 750)
        Me.tlp_Otros.TabIndex = 2
        '
        'Panel1
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.dgv_combustible)
        Me.Panel1.Controls.Add(Me.dgv_carrito)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 301)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.repsun.My.Resources.Resources.LogoTransparente_1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'dgv_combustible
        '
        Me.dgv_combustible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_combustible.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgv_combustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_combustible.ColumnHeadersVisible = False
        Me.dgv_combustible.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_combustible.Location = New System.Drawing.Point(0, 269)
        Me.dgv_combustible.Name = "dgv_combustible"
        Me.dgv_combustible.Size = New System.Drawing.Size(617, 32)
        Me.dgv_combustible.TabIndex = 1
        '
        'tpvForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.tlp_tpv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tpvForm"
        Me.Text = "tpvForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_tpv.ResumeLayout(False)
        Me.tlp_caja.ResumeLayout(False)
        Me.tlp_teclado.ResumeLayout(False)
        Me.tlp_teclado.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgv_carrito, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_combustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_tpv As TableLayoutPanel
    Friend WithEvents tlp_caja As TableLayoutPanel
    Friend WithEvents tlp_teclado As TableLayoutPanel
    Friend WithEvents btn_teclado_0 As Button
    Friend WithEvents btn_teclado_9 As Button
    Friend WithEvents btn_teclado_8 As Button
    Friend WithEvents btn_teclado_7 As Button
    Friend WithEvents btn_teclado_cobrar As Button
    Friend WithEvents btn_teclado_coma As Button
    Friend WithEvents btn_teclado_6 As Button
    Friend WithEvents btn_teclado_5 As Button
    Friend WithEvents btn_teclado_4 As Button
    Friend WithEvents btn_teclado_restar As Button
    Friend WithEvents btn_tecladoExacto As Button
    Friend WithEvents btn_teclado_3 As Button
    Friend WithEvents btn_teclado_1 As Button
    Friend WithEvents txt_introducido As TextBox
    Friend WithEvents lbl_introducido As Label
    Friend WithEvents btn_teclado_2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tbc_tienda As TabControl
    Friend WithEvents tpg_comida As TabPage
    Friend WithEvents tpg_bebida As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgv_carrito As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
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
End Class
