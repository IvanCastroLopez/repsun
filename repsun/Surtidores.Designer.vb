<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Surtidores
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
        Me.components = New System.ComponentModel.Container()
        Me.tlp_posicionCoches = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_salir = New System.Windows.Forms.PictureBox()
        Me.pbx_coche1 = New System.Windows.Forms.PictureBox()
        Me.pbx_coche2 = New System.Windows.Forms.PictureBox()
        Me.pbx_coche3 = New System.Windows.Forms.PictureBox()
        Me.pbx_coche4 = New System.Windows.Forms.PictureBox()
        Me.tmr_timer = New System.Windows.Forms.Timer(Me.components)
        Me.tlp_posicionCoches.SuspendLayout()
        CType(Me.pbx_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_coche1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_coche2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_coche3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_coche4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_posicionCoches
        '
        Me.tlp_posicionCoches.BackgroundImage = Global.repsun.My.Resources.Resources.vistaSurtidores
        Me.tlp_posicionCoches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tlp_posicionCoches.ColumnCount = 5
        Me.tlp_posicionCoches.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_posicionCoches.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_posicionCoches.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_posicionCoches.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_posicionCoches.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_posicionCoches.Controls.Add(Me.pbx_salir, 4, 0)
        Me.tlp_posicionCoches.Controls.Add(Me.pbx_coche1, 1, 1)
        Me.tlp_posicionCoches.Controls.Add(Me.pbx_coche2, 3, 1)
        Me.tlp_posicionCoches.Controls.Add(Me.pbx_coche3, 1, 3)
        Me.tlp_posicionCoches.Controls.Add(Me.pbx_coche4, 3, 3)
        Me.tlp_posicionCoches.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_posicionCoches.Location = New System.Drawing.Point(0, 0)
        Me.tlp_posicionCoches.Name = "tlp_posicionCoches"
        Me.tlp_posicionCoches.RowCount = 5
        Me.tlp_posicionCoches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_posicionCoches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_posicionCoches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_posicionCoches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_posicionCoches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_posicionCoches.Size = New System.Drawing.Size(1896, 1016)
        Me.tlp_posicionCoches.TabIndex = 0
        '
        'pbx_salir
        '
        Me.pbx_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbx_salir.BackColor = System.Drawing.Color.Transparent
        Me.pbx_salir.Image = Global.repsun.My.Resources.Resources.Close
        Me.pbx_salir.Location = New System.Drawing.Point(1781, 15)
        Me.pbx_salir.Margin = New System.Windows.Forms.Padding(15)
        Me.pbx_salir.Name = "pbx_salir"
        Me.pbx_salir.Size = New System.Drawing.Size(100, 71)
        Me.pbx_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_salir.TabIndex = 0
        Me.pbx_salir.TabStop = False
        '
        'pbx_coche1
        '
        Me.pbx_coche1.BackColor = System.Drawing.Color.Transparent
        Me.pbx_coche1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_coche1.Enabled = False
        Me.pbx_coche1.Location = New System.Drawing.Point(287, 104)
        Me.pbx_coche1.Name = "pbx_coche1"
        Me.pbx_coche1.Size = New System.Drawing.Size(562, 298)
        Me.pbx_coche1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_coche1.TabIndex = 1
        Me.pbx_coche1.TabStop = False
        '
        'pbx_coche2
        '
        Me.pbx_coche2.BackColor = System.Drawing.Color.Transparent
        Me.pbx_coche2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_coche2.Enabled = False
        Me.pbx_coche2.Location = New System.Drawing.Point(1044, 104)
        Me.pbx_coche2.Name = "pbx_coche2"
        Me.pbx_coche2.Size = New System.Drawing.Size(562, 298)
        Me.pbx_coche2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_coche2.TabIndex = 2
        Me.pbx_coche2.TabStop = False
        '
        'pbx_coche3
        '
        Me.pbx_coche3.BackColor = System.Drawing.Color.Transparent
        Me.pbx_coche3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_coche3.Enabled = False
        Me.pbx_coche3.Location = New System.Drawing.Point(287, 611)
        Me.pbx_coche3.Name = "pbx_coche3"
        Me.pbx_coche3.Size = New System.Drawing.Size(562, 298)
        Me.pbx_coche3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_coche3.TabIndex = 3
        Me.pbx_coche3.TabStop = False
        '
        'pbx_coche4
        '
        Me.pbx_coche4.BackColor = System.Drawing.Color.Transparent
        Me.pbx_coche4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_coche4.Enabled = False
        Me.pbx_coche4.Location = New System.Drawing.Point(1044, 611)
        Me.pbx_coche4.Name = "pbx_coche4"
        Me.pbx_coche4.Size = New System.Drawing.Size(562, 298)
        Me.pbx_coche4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_coche4.TabIndex = 4
        Me.pbx_coche4.TabStop = False
        '
        'tmr_timer
        '
        Me.tmr_timer.Interval = 1000
        '
        'Surtidores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.repsun.My.Resources.Resources.vistaSurtidores
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1896, 1016)
        Me.Controls.Add(Me.tlp_posicionCoches)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Surtidores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surtidores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_posicionCoches.ResumeLayout(False)
        CType(Me.pbx_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_coche1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_coche2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_coche3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_coche4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_posicionCoches As TableLayoutPanel
    Friend WithEvents pbx_salir As PictureBox
    Friend WithEvents pbx_coche1 As PictureBox
    Friend WithEvents pbx_coche2 As PictureBox
    Friend WithEvents pbx_coche3 As PictureBox
    Friend WithEvents pbx_coche4 As PictureBox
    Friend WithEvents tmr_timer As Timer
End Class
