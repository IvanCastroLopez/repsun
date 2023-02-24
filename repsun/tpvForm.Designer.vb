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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_teclado_2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlp_tpv.SuspendLayout()
        Me.tlp_caja.SuspendLayout()
        Me.tlp_teclado.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_tpv
        '
        Me.tlp_tpv.ColumnCount = 2
        Me.tlp_tpv.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.tlp_tpv.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlp_tpv.Controls.Add(Me.tlp_caja, 1, 0)
        Me.tlp_tpv.Controls.Add(Me.Panel1, 0, 0)
        Me.tlp_tpv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_tpv.Location = New System.Drawing.Point(0, 0)
        Me.tlp_tpv.Name = "tlp_tpv"
        Me.tlp_tpv.RowCount = 1
        Me.tlp_tpv.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_tpv.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_tpv.Size = New System.Drawing.Size(1904, 1041)
        Me.tlp_tpv.TabIndex = 0
        '
        'tlp_caja
        '
        Me.tlp_caja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.tlp_caja.ColumnCount = 1
        Me.tlp_caja.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_caja.Controls.Add(Me.tlp_teclado, 0, 1)
        Me.tlp_caja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_caja.Location = New System.Drawing.Point(1272, 3)
        Me.tlp_caja.Name = "tlp_caja"
        Me.tlp_caja.RowCount = 2
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
        Me.tlp_teclado.Controls.Add(Me.Label1, 0, 0)
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
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.tlp_teclado.SetColumnSpan(Me.Label1, 5)
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(30, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introducido:"
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
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 1035)
        Me.Panel1.TabIndex = 1
        '
        'tpvForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.tlp_tpv)
        Me.Name = "tpvForm"
        Me.Text = "tpvForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_tpv.ResumeLayout(False)
        Me.tlp_caja.ResumeLayout(False)
        Me.tlp_teclado.ResumeLayout(False)
        Me.tlp_teclado.PerformLayout()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_teclado_2 As Button
    Friend WithEvents Panel1 As Panel
End Class
