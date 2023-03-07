<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SurtidorOnTop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SurtidorOnTop))
        Me.tlp_surtidorGeneral = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp_pantallaSurtidor = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_tipoCombustible = New System.Windows.Forms.ComboBox()
        Me.txt_precioTotal = New System.Windows.Forms.TextBox()
        Me.txt_litros = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pgb_gasolinaSurtidor = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.tlp_surtidorGeneral.SuspendLayout()
        Me.tlp_pantallaSurtidor.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_surtidorGeneral
        '
        Me.tlp_surtidorGeneral.BackgroundImage = Global.repsun.My.Resources.Resources.SurtidorOnTop
        Me.tlp_surtidorGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tlp_surtidorGeneral.ColumnCount = 3
        Me.tlp_surtidorGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tlp_surtidorGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.0!))
        Me.tlp_surtidorGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tlp_surtidorGeneral.Controls.Add(Me.tlp_pantallaSurtidor, 1, 1)
        Me.tlp_surtidorGeneral.Controls.Add(Me.TableLayoutPanel1, 1, 2)
        Me.tlp_surtidorGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_surtidorGeneral.Location = New System.Drawing.Point(0, 0)
        Me.tlp_surtidorGeneral.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlp_surtidorGeneral.Name = "tlp_surtidorGeneral"
        Me.tlp_surtidorGeneral.RowCount = 4
        Me.tlp_surtidorGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.0!))
        Me.tlp_surtidorGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tlp_surtidorGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_surtidorGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_surtidorGeneral.Size = New System.Drawing.Size(1099, 606)
        Me.tlp_surtidorGeneral.TabIndex = 0
        '
        'tlp_pantallaSurtidor
        '
        Me.tlp_pantallaSurtidor.BackColor = System.Drawing.Color.Transparent
        Me.tlp_pantallaSurtidor.ColumnCount = 4
        Me.tlp_pantallaSurtidor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_pantallaSurtidor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0!))
        Me.tlp_pantallaSurtidor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0!))
        Me.tlp_pantallaSurtidor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.tlp_pantallaSurtidor.Controls.Add(Me.cbx_tipoCombustible, 1, 1)
        Me.tlp_pantallaSurtidor.Controls.Add(Me.txt_precioTotal, 2, 3)
        Me.tlp_pantallaSurtidor.Controls.Add(Me.txt_litros, 2, 5)
        Me.tlp_pantallaSurtidor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_pantallaSurtidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlp_pantallaSurtidor.Location = New System.Drawing.Point(375, 220)
        Me.tlp_pantallaSurtidor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlp_pantallaSurtidor.Name = "tlp_pantallaSurtidor"
        Me.tlp_pantallaSurtidor.RowCount = 7
        Me.tlp_pantallaSurtidor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.tlp_pantallaSurtidor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_pantallaSurtidor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_pantallaSurtidor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_pantallaSurtidor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_pantallaSurtidor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_pantallaSurtidor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tlp_pantallaSurtidor.Size = New System.Drawing.Size(347, 202)
        Me.tlp_pantallaSurtidor.TabIndex = 1
        '
        'cbx_tipoCombustible
        '
        Me.cbx_tipoCombustible.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_tipoCombustible.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tlp_pantallaSurtidor.SetColumnSpan(Me.cbx_tipoCombustible, 2)
        Me.cbx_tipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tipoCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_tipoCombustible.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_tipoCombustible.ForeColor = System.Drawing.Color.White
        Me.cbx_tipoCombustible.FormattingEnabled = True
        Me.cbx_tipoCombustible.Items.AddRange(New Object() {"Sin Plomo 95", "Sin Plomo 98", "Diesel", "Diesel +"})
        Me.cbx_tipoCombustible.Location = New System.Drawing.Point(54, 36)
        Me.cbx_tipoCombustible.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbx_tipoCombustible.Name = "cbx_tipoCombustible"
        Me.cbx_tipoCombustible.Size = New System.Drawing.Size(245, 29)
        Me.cbx_tipoCombustible.TabIndex = 0
        '
        'txt_precioTotal
        '
        Me.txt_precioTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_precioTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_precioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_precioTotal.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precioTotal.ForeColor = System.Drawing.Color.White
        Me.txt_precioTotal.Location = New System.Drawing.Point(144, 86)
        Me.txt_precioTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_precioTotal.MaxLength = 5
        Me.txt_precioTotal.Name = "txt_precioTotal"
        Me.txt_precioTotal.Size = New System.Drawing.Size(155, 22)
        Me.txt_precioTotal.TabIndex = 1
        Me.txt_precioTotal.Text = "00,00"
        '
        'txt_litros
        '
        Me.txt_litros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_litros.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_litros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_litros.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_litros.ForeColor = System.Drawing.Color.White
        Me.txt_litros.Location = New System.Drawing.Point(144, 136)
        Me.txt_litros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_litros.MaxLength = 5
        Me.txt_litros.Name = "txt_litros"
        Me.txt_litros.Size = New System.Drawing.Size(155, 22)
        Me.txt_litros.TabIndex = 2
        Me.txt_litros.Text = "00,00"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pgb_gasolinaSurtidor, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(376, 427)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(345, 84)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'pgb_gasolinaSurtidor
        '
        Me.pgb_gasolinaSurtidor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb_gasolinaSurtidor.Location = New System.Drawing.Point(3, 31)
        Me.pgb_gasolinaSurtidor.Name = "pgb_gasolinaSurtidor"
        Me.pgb_gasolinaSurtidor.Size = New System.Drawing.Size(242, 22)
        Me.pgb_gasolinaSurtidor.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(292, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Pagar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\castr\source\repos\IvanCastroLopez\repsun\repsun\bin\Debug\Repsun_Ayuda." &
    "chm"
        '
        'SurtidorOnTop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1099, 606)
        Me.Controls.Add(Me.tlp_surtidorGeneral)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1099, 598)
        Me.Name = "SurtidorOnTop"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surtidor"
        Me.tlp_surtidorGeneral.ResumeLayout(False)
        Me.tlp_pantallaSurtidor.ResumeLayout(False)
        Me.tlp_pantallaSurtidor.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_surtidorGeneral As TableLayoutPanel
    Friend WithEvents tlp_pantallaSurtidor As TableLayoutPanel
    Friend WithEvents cbx_tipoCombustible As ComboBox
    Friend WithEvents txt_precioTotal As TextBox
    Friend WithEvents txt_litros As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pgb_gasolinaSurtidor As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
