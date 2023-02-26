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
        Me.SuspendLayout()
        '
        'btn_tpv
        '
        Me.btn_tpv.Location = New System.Drawing.Point(941, 245)
        Me.btn_tpv.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_tpv.Name = "btn_tpv"
        Me.btn_tpv.Size = New System.Drawing.Size(297, 272)
        Me.btn_tpv.TabIndex = 4
        Me.btn_tpv.Text = "TPV"
        Me.btn_tpv.UseVisualStyleBackColor = True
        '
        'btn_gestion
        '
        Me.btn_gestion.Location = New System.Drawing.Point(706, 110)
        Me.btn_gestion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_gestion.Name = "btn_gestion"
        Me.btn_gestion.Size = New System.Drawing.Size(210, 103)
        Me.btn_gestion.TabIndex = 5
        Me.btn_gestion.Text = "GESTIÓN"
        Me.btn_gestion.UseVisualStyleBackColor = True
        '
        'btn_zonaClientes
        '
        Me.btn_zonaClientes.Location = New System.Drawing.Point(1321, 472)
        Me.btn_zonaClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_zonaClientes.Name = "btn_zonaClientes"
        Me.btn_zonaClientes.Size = New System.Drawing.Size(221, 117)
        Me.btn_zonaClientes.TabIndex = 6
        Me.btn_zonaClientes.Text = "ZONA CLIENTES"
        Me.btn_zonaClientes.UseVisualStyleBackColor = True
        '
        'btn_surtidores
        '
        Me.btn_surtidores.Location = New System.Drawing.Point(1265, 51)
        Me.btn_surtidores.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_surtidores.Name = "btn_surtidores"
        Me.btn_surtidores.Size = New System.Drawing.Size(642, 220)
        Me.btn_surtidores.TabIndex = 7
        Me.btn_surtidores.Text = "SURTIDORES"
        Me.btn_surtidores.UseVisualStyleBackColor = True
        '
        'MenuPrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.repsun.My.Resources.Resources._0_Default
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
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
End Class
