<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.tlp_start = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_logo = New System.Windows.Forms.PictureBox()
        Me.tlp_start.SuspendLayout()
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_start
        '
        Me.tlp_start.ColumnCount = 3
        Me.tlp_start.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.tlp_start.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85715!))
        Me.tlp_start.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.tlp_start.Controls.Add(Me.pbx_logo, 1, 1)
        Me.tlp_start.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_start.Location = New System.Drawing.Point(0, 0)
        Me.tlp_start.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlp_start.Name = "tlp_start"
        Me.tlp_start.RowCount = 3
        Me.tlp_start.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.tlp_start.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85715!))
        Me.tlp_start.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.tlp_start.Size = New System.Drawing.Size(720, 439)
        Me.tlp_start.TabIndex = 1
        '
        'pbx_logo
        '
        Me.pbx_logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_logo.Image = Global.repsun.My.Resources.Resources.LogoTransparente_1
        Me.pbx_logo.Location = New System.Drawing.Point(207, 127)
        Me.pbx_logo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbx_logo.Name = "pbx_logo"
        Me.pbx_logo.Size = New System.Drawing.Size(304, 184)
        Me.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_logo.TabIndex = 0
        Me.pbx_logo.TabStop = False
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 439)
        Me.Controls.Add(Me.tlp_start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "StartForm"
        Me.Text = "Bienvenido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_start.ResumeLayout(False)
        CType(Me.pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_start As TableLayoutPanel
    Friend WithEvents pbx_logo As PictureBox
End Class
