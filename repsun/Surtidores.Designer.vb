<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Surtidores
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Surtidores))
        Me.tlp_posicionCoches = New System.Windows.Forms.TableLayoutPanel()
        Me.pbx_salir = New System.Windows.Forms.PictureBox()
        Me.pbx_coche1 = New System.Windows.Forms.PictureBox()
        Me.pbx_coche2 = New System.Windows.Forms.PictureBox()
        Me.pbx_coche3 = New System.Windows.Forms.PictureBox()
        Me.pbx_coche4 = New System.Windows.Forms.PictureBox()
        Me.btn_vaciarCoches = New System.Windows.Forms.Button()
        Me.chk_estadoSimulador = New System.Windows.Forms.CheckBox()
        Me.tmr_timer = New System.Windows.Forms.Timer(Me.components)
        Me.nic_surtidores = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
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
        Me.tlp_posicionCoches.Controls.Add(Me.btn_vaciarCoches, 3, 0)
        Me.tlp_posicionCoches.Controls.Add(Me.chk_estadoSimulador, 1, 0)
        Me.tlp_posicionCoches.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_posicionCoches.Location = New System.Drawing.Point(0, 0)
        Me.tlp_posicionCoches.Margin = New System.Windows.Forms.Padding(2)
        Me.tlp_posicionCoches.Name = "tlp_posicionCoches"
        Me.tlp_posicionCoches.RowCount = 5
        Me.tlp_posicionCoches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_posicionCoches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_posicionCoches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlp_posicionCoches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_posicionCoches.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_posicionCoches.Size = New System.Drawing.Size(1034, 550)
        Me.tlp_posicionCoches.TabIndex = 0
        '
        'pbx_salir
        '
        Me.pbx_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbx_salir.BackColor = System.Drawing.Color.Transparent
        Me.pbx_salir.Image = Global.repsun.My.Resources.Resources.Close_white
        Me.pbx_salir.Location = New System.Drawing.Point(971, 8)
        Me.pbx_salir.Margin = New System.Windows.Forms.Padding(8)
        Me.pbx_salir.Name = "pbx_salir"
        Me.pbx_salir.Size = New System.Drawing.Size(55, 38)
        Me.pbx_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_salir.TabIndex = 0
        Me.pbx_salir.TabStop = False
        '
        'pbx_coche1
        '
        Me.pbx_coche1.BackColor = System.Drawing.Color.Transparent
        Me.pbx_coche1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_coche1.Enabled = False
        Me.pbx_coche1.Location = New System.Drawing.Point(157, 57)
        Me.pbx_coche1.Margin = New System.Windows.Forms.Padding(2)
        Me.pbx_coche1.Name = "pbx_coche1"
        Me.pbx_coche1.Size = New System.Drawing.Size(306, 161)
        Me.pbx_coche1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_coche1.TabIndex = 1
        Me.pbx_coche1.TabStop = False
        '
        'pbx_coche2
        '
        Me.pbx_coche2.BackColor = System.Drawing.Color.Transparent
        Me.pbx_coche2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_coche2.Enabled = False
        Me.pbx_coche2.Location = New System.Drawing.Point(570, 57)
        Me.pbx_coche2.Margin = New System.Windows.Forms.Padding(2)
        Me.pbx_coche2.Name = "pbx_coche2"
        Me.pbx_coche2.Size = New System.Drawing.Size(306, 161)
        Me.pbx_coche2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_coche2.TabIndex = 2
        Me.pbx_coche2.TabStop = False
        '
        'pbx_coche3
        '
        Me.pbx_coche3.BackColor = System.Drawing.Color.Transparent
        Me.pbx_coche3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_coche3.Enabled = False
        Me.pbx_coche3.Location = New System.Drawing.Point(157, 332)
        Me.pbx_coche3.Margin = New System.Windows.Forms.Padding(2)
        Me.pbx_coche3.Name = "pbx_coche3"
        Me.pbx_coche3.Size = New System.Drawing.Size(306, 161)
        Me.pbx_coche3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_coche3.TabIndex = 3
        Me.pbx_coche3.TabStop = False
        '
        'pbx_coche4
        '
        Me.pbx_coche4.BackColor = System.Drawing.Color.Transparent
        Me.pbx_coche4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_coche4.Enabled = False
        Me.pbx_coche4.Location = New System.Drawing.Point(570, 332)
        Me.pbx_coche4.Margin = New System.Windows.Forms.Padding(2)
        Me.pbx_coche4.Name = "pbx_coche4"
        Me.pbx_coche4.Size = New System.Drawing.Size(306, 161)
        Me.pbx_coche4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_coche4.TabIndex = 4
        Me.pbx_coche4.TabStop = False
        '
        'btn_vaciarCoches
        '
        Me.btn_vaciarCoches.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_vaciarCoches.AutoSize = True
        Me.btn_vaciarCoches.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vaciarCoches.Location = New System.Drawing.Point(579, 11)
        Me.btn_vaciarCoches.Margin = New System.Windows.Forms.Padding(11)
        Me.btn_vaciarCoches.Name = "btn_vaciarCoches"
        Me.btn_vaciarCoches.Size = New System.Drawing.Size(125, 33)
        Me.btn_vaciarCoches.TabIndex = 6
        Me.btn_vaciarCoches.Text = "Quitar coches"
        Me.btn_vaciarCoches.UseVisualStyleBackColor = True
        '
        'chk_estadoSimulador
        '
        Me.chk_estadoSimulador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_estadoSimulador.Appearance = System.Windows.Forms.Appearance.Button
        Me.chk_estadoSimulador.AutoSize = True
        Me.chk_estadoSimulador.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_estadoSimulador.Location = New System.Drawing.Point(362, 11)
        Me.chk_estadoSimulador.Margin = New System.Windows.Forms.Padding(11)
        Me.chk_estadoSimulador.Name = "chk_estadoSimulador"
        Me.chk_estadoSimulador.Size = New System.Drawing.Size(92, 33)
        Me.chk_estadoSimulador.TabIndex = 5
        Me.chk_estadoSimulador.Text = "Simulador OFF"
        Me.chk_estadoSimulador.UseVisualStyleBackColor = True
        '
        'tmr_timer
        '
        Me.tmr_timer.Interval = 1000
        '
        'nic_surtidores
        '
        Me.nic_surtidores.BalloonTipText = "Hay un nuevo coche esperando en los surtidores"
        Me.nic_surtidores.BalloonTipTitle = "Nuevo coche"
        Me.nic_surtidores.Icon = CType(resources.GetObject("nic_surtidores.Icon"), System.Drawing.Icon)
        Me.nic_surtidores.Text = "Nuevo coche"
        Me.nic_surtidores.Visible = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\castr\source\repos\IvanCastroLopez\repsun\repsun\bin\Debug\Repsun_Ayuda." &
    "chm"
        '
        'Surtidores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.repsun.My.Resources.Resources.vistaSurtidores
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1034, 550)
        Me.Controls.Add(Me.tlp_posicionCoches)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Surtidores"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surtidores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_posicionCoches.ResumeLayout(False)
        Me.tlp_posicionCoches.PerformLayout()
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
    Friend WithEvents nic_surtidores As NotifyIcon
    Friend WithEvents chk_estadoSimulador As CheckBox
    Friend WithEvents btn_vaciarCoches As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
