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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_tipoCombustible = New System.Windows.Forms.ComboBox()
        Me.txt_precioTotal = New System.Windows.Forms.TextBox()
        Me.txt_litros = New System.Windows.Forms.TextBox()
        Me.tlp_surtidorGeneral.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_surtidorGeneral
        '
        Me.tlp_surtidorGeneral.BackgroundImage = Global.repsun.My.Resources.Resources.SurtidorOnTop
        Me.tlp_surtidorGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tlp_surtidorGeneral.ColumnCount = 3
        Me.tlp_surtidorGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.38536!))
        Me.tlp_surtidorGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.61464!))
        Me.tlp_surtidorGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 696.0!))
        Me.tlp_surtidorGeneral.Controls.Add(Me.SplitContainer1, 1, 2)
        Me.tlp_surtidorGeneral.Controls.Add(Me.TableLayoutPanel1, 1, 1)
        Me.tlp_surtidorGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_surtidorGeneral.Location = New System.Drawing.Point(0, 0)
        Me.tlp_surtidorGeneral.Name = "tlp_surtidorGeneral"
        Me.tlp_surtidorGeneral.RowCount = 4
        Me.tlp_surtidorGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76401!))
        Me.tlp_surtidorGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23599!))
        Me.tlp_surtidorGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.tlp_surtidorGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203.0!))
        Me.tlp_surtidorGeneral.Size = New System.Drawing.Size(2150, 1170)
        Me.tlp_surtidorGeneral.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(736, 829)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProgressBar1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(17, 42, 34, 17)
        Me.SplitContainer1.Size = New System.Drawing.Size(713, 133)
        Me.SplitContainer1.SplitterDistance = 546
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(17, 42)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(495, 74)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.UseWaitCursor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_tipoCombustible, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_precioTotal, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_litros, 2, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(735, 422)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(715, 400)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'cbx_tipoCombustible
        '
        Me.cbx_tipoCombustible.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_tipoCombustible.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.cbx_tipoCombustible, 2)
        Me.cbx_tipoCombustible.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_tipoCombustible.ForeColor = System.Drawing.Color.White
        Me.cbx_tipoCombustible.FormattingEnabled = True
        Me.cbx_tipoCombustible.Items.AddRange(New Object() {"Sin Plomo 95", "Sin Plomo 98", "Diesel", "Diesel +"})
        Me.cbx_tipoCombustible.Location = New System.Drawing.Point(110, 71)
        Me.cbx_tipoCombustible.Name = "cbx_tipoCombustible"
        Me.cbx_tipoCombustible.Size = New System.Drawing.Size(887, 65)
        Me.cbx_tipoCombustible.TabIndex = 0
        '
        'txt_precioTotal
        '
        Me.txt_precioTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_precioTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_precioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_precioTotal.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precioTotal.ForeColor = System.Drawing.Color.White
        Me.txt_precioTotal.Location = New System.Drawing.Point(295, 171)
        Me.txt_precioTotal.Name = "txt_precioTotal"
        Me.txt_precioTotal.Size = New System.Drawing.Size(564, 98)
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
        Me.txt_litros.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_litros.ForeColor = System.Drawing.Color.White
        Me.txt_litros.Location = New System.Drawing.Point(295, 271)
        Me.txt_litros.Name = "txt_litros"
        Me.txt_litros.Size = New System.Drawing.Size(564, 98)
        Me.txt_litros.TabIndex = 2
        Me.txt_litros.Text = "00,00"
        '
        'SurtidorOnTop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(2150, 1170)
        Me.Controls.Add(Me.tlp_surtidorGeneral)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(2174, 1234)
        Me.Name = "SurtidorOnTop"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surtidor"
        Me.TopMost = True
        Me.tlp_surtidorGeneral.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_surtidorGeneral As TableLayoutPanel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbx_tipoCombustible As ComboBox
    Friend WithEvents txt_precioTotal As TextBox
    Friend WithEvents txt_litros As TextBox
End Class
