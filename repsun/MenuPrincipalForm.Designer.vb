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
        Me.SuspendLayout()
        '
        'btn_tpv
        '
        Me.btn_tpv.BackColor = System.Drawing.Color.White
        Me.btn_tpv.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tpv.Location = New System.Drawing.Point(999, 531)
        Me.btn_tpv.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_tpv.Name = "btn_tpv"
        Me.btn_tpv.Size = New System.Drawing.Size(233, 66)
        Me.btn_tpv.TabIndex = 4
        Me.btn_tpv.Text = "TPV"
        Me.btn_tpv.UseVisualStyleBackColor = False
        '
        'btn_gestion
        '
        Me.btn_gestion.BackColor = System.Drawing.Color.White
        Me.btn_gestion.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gestion.Location = New System.Drawing.Point(766, 706)
        Me.btn_gestion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_gestion.Name = "btn_gestion"
        Me.btn_gestion.Size = New System.Drawing.Size(219, 66)
        Me.btn_gestion.TabIndex = 5
        Me.btn_gestion.Text = "GESTIÓN"
        Me.btn_gestion.UseVisualStyleBackColor = False
        '
        'btn_zonaClientes
        '
        Me.btn_zonaClientes.BackColor = System.Drawing.Color.White
        Me.btn_zonaClientes.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_zonaClientes.Location = New System.Drawing.Point(1289, 607)
        Me.btn_zonaClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_zonaClientes.Name = "btn_zonaClientes"
        Me.btn_zonaClientes.Size = New System.Drawing.Size(255, 66)
        Me.btn_zonaClientes.TabIndex = 6
        Me.btn_zonaClientes.Text = "ZONA CLIENTES"
        Me.btn_zonaClientes.UseVisualStyleBackColor = False
        '
        'btn_surtidores
        '
        Me.btn_surtidores.BackColor = System.Drawing.Color.White
        Me.btn_surtidores.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_surtidores.Location = New System.Drawing.Point(1580, 399)
        Me.btn_surtidores.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_surtidores.Name = "btn_surtidores"
        Me.btn_surtidores.Size = New System.Drawing.Size(304, 73)
        Me.btn_surtidores.TabIndex = 7
        Me.btn_surtidores.Text = "SURTIDORES"
        Me.btn_surtidores.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.White
        Me.btn_salir.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.85714!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(1220, 964)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(181, 63)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'MenuPrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.repsun.My.Resources.Resources._0_Default
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.btn_salir)
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
    Friend WithEvents btn_salir As Button
End Class
