<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipalForm
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
        Me.btn_tpv = New System.Windows.Forms.Button()
        Me.btn_gestion = New System.Windows.Forms.Button()
        Me.btn_zonaClientes = New System.Windows.Forms.Button()
        Me.btn_surtidores = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.tlp_layoutBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.tlp_layoutBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_tpv
        '
        Me.btn_tpv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_tpv.AutoSize = True
        Me.btn_tpv.BackColor = System.Drawing.Color.White
        Me.btn_tpv.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tpv.Location = New System.Drawing.Point(577, 249)
        Me.btn_tpv.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tpv.Name = "btn_tpv"
        Me.btn_tpv.Size = New System.Drawing.Size(127, 40)
        Me.btn_tpv.TabIndex = 4
        Me.btn_tpv.Text = "TPV"
        Me.btn_tpv.UseVisualStyleBackColor = False
        '
        'btn_gestion
        '
        Me.btn_gestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_gestion.AutoSize = True
        Me.btn_gestion.BackColor = System.Drawing.Color.White
        Me.btn_gestion.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gestion.Location = New System.Drawing.Point(420, 365)
        Me.btn_gestion.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gestion.Name = "btn_gestion"
        Me.btn_gestion.Size = New System.Drawing.Size(119, 40)
        Me.btn_gestion.TabIndex = 5
        Me.btn_gestion.Text = "GESTIÓN"
        Me.btn_gestion.UseVisualStyleBackColor = False
        '
        'btn_zonaClientes
        '
        Me.btn_zonaClientes.AutoSize = True
        Me.btn_zonaClientes.BackColor = System.Drawing.Color.White
        Me.btn_zonaClientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_zonaClientes.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_zonaClientes.Location = New System.Drawing.Point(734, 293)
        Me.btn_zonaClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_zonaClientes.Name = "btn_zonaClientes"
        Me.btn_zonaClientes.Size = New System.Drawing.Size(153, 54)
        Me.btn_zonaClientes.TabIndex = 6
        Me.btn_zonaClientes.Text = "ZONA CLIENTES"
        Me.btn_zonaClientes.UseVisualStyleBackColor = False
        '
        'btn_surtidores
        '
        Me.btn_surtidores.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_surtidores.AutoSize = True
        Me.btn_surtidores.BackColor = System.Drawing.Color.White
        Me.btn_surtidores.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_surtidores.Location = New System.Drawing.Point(891, 191)
        Me.btn_surtidores.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_surtidores.Name = "btn_surtidores"
        Me.btn_surtidores.Size = New System.Drawing.Size(153, 40)
        Me.btn_surtidores.TabIndex = 7
        Me.btn_surtidores.Text = "SURTIDORES"
        Me.btn_surtidores.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.AutoSize = True
        Me.btn_salir.BackColor = System.Drawing.Color.White
        Me.btn_salir.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(596, 481)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(134, 40)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'tlp_layoutBotones
        '
        Me.tlp_layoutBotones.BackColor = System.Drawing.Color.Transparent
        Me.tlp_layoutBotones.BackgroundImage = Global.repsun.My.Resources.Resources._0_Default
        Me.tlp_layoutBotones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tlp_layoutBotones.ColumnCount = 5
        Me.tlp_layoutBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlp_layoutBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_layoutBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_layoutBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_layoutBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlp_layoutBotones.Controls.Add(Me.btn_surtidores, 4, 1)
        Me.tlp_layoutBotones.Controls.Add(Me.btn_tpv, 2, 2)
        Me.tlp_layoutBotones.Controls.Add(Me.btn_gestion, 1, 4)
        Me.tlp_layoutBotones.Controls.Add(Me.btn_zonaClientes, 3, 3)
        Me.tlp_layoutBotones.Controls.Add(Me.btn_salir, 2, 6)
        Me.tlp_layoutBotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_layoutBotones.Location = New System.Drawing.Point(0, 0)
        Me.tlp_layoutBotones.Margin = New System.Windows.Forms.Padding(2)
        Me.tlp_layoutBotones.Name = "tlp_layoutBotones"
        Me.tlp_layoutBotones.RowCount = 8
        Me.tlp_layoutBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlp_layoutBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_layoutBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_layoutBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_layoutBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_layoutBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_layoutBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_layoutBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlp_layoutBotones.Size = New System.Drawing.Size(1047, 585)
        Me.tlp_layoutBotones.TabIndex = 9
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = ".\Debug\Repsun_Ayuda.chm"
        '
        'MenuPrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.repsun.My.Resources.Resources._0_Default
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1047, 585)
        Me.Controls.Add(Me.tlp_layoutBotones)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuPrincipalForm"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "MenuPrincipalForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp_layoutBotones.ResumeLayout(False)
        Me.tlp_layoutBotones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_tpv As Button
    Friend WithEvents btn_gestion As Button
    Friend WithEvents btn_zonaClientes As Button
    Friend WithEvents btn_surtidores As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents tlp_layoutBotones As TableLayoutPanel
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
