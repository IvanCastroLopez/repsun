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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_tpv
        '
        Me.btn_tpv.Location = New System.Drawing.Point(1021, 533)
        Me.btn_tpv.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_tpv.Name = "btn_tpv"
        Me.btn_tpv.Size = New System.Drawing.Size(189, 66)
        Me.btn_tpv.TabIndex = 4
        Me.btn_tpv.Text = "TPV"
        Me.btn_tpv.UseVisualStyleBackColor = True
        '
        'btn_gestion
        '
        Me.btn_gestion.Location = New System.Drawing.Point(788, 708)
        Me.btn_gestion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_gestion.Name = "btn_gestion"
        Me.btn_gestion.Size = New System.Drawing.Size(175, 66)
        Me.btn_gestion.TabIndex = 5
        Me.btn_gestion.Text = "GESTIÓN"
        Me.btn_gestion.UseVisualStyleBackColor = True
        '
        'btn_zonaClientes
        '
        Me.btn_zonaClientes.Location = New System.Drawing.Point(1311, 609)
        Me.btn_zonaClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_zonaClientes.Name = "btn_zonaClientes"
        Me.btn_zonaClientes.Size = New System.Drawing.Size(211, 66)
        Me.btn_zonaClientes.TabIndex = 6
        Me.btn_zonaClientes.Text = "ZONA CLIENTES"
        Me.btn_zonaClientes.UseVisualStyleBackColor = True
        '
        'btn_surtidores
        '
        Me.btn_surtidores.Location = New System.Drawing.Point(1602, 401)
        Me.btn_surtidores.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_surtidores.Name = "btn_surtidores"
        Me.btn_surtidores.Size = New System.Drawing.Size(260, 73)
        Me.btn_surtidores.TabIndex = 7
        Me.btn_surtidores.Text = "SURTIDORES"
        Me.btn_surtidores.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1242, 966)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 63)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuPrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.repsun.My.Resources.Resources._0_Default
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_tpv)
        Me.Controls.Add(Me.btn_gestion)
        Me.Controls.Add(Me.btn_zonaClientes)
        Me.Controls.Add(Me.btn_surtidores)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuPrincipalForm"
        Me.Text = "MenuPrincipalForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_tpv As Button
    Friend WithEvents btn_gestion As Button
    Friend WithEvents btn_zonaClientes As Button
    Friend WithEvents btn_surtidores As Button
    Friend WithEvents Button1 As Button
End Class
