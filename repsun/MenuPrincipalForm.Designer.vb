﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_tpv = New System.Windows.Forms.Button()
        Me.btn_gestion = New System.Windows.Forms.Button()
        Me.btn_zonaClientes = New System.Windows.Forms.Button()
        Me.btn_surtidores = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_tpv, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_gestion, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_zonaClientes, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_surtidores, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_salir, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.7305!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.2695!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_tpv
        '
        Me.btn_tpv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_tpv.Location = New System.Drawing.Point(3, 50)
        Me.btn_tpv.Name = "btn_tpv"
        Me.btn_tpv.Size = New System.Drawing.Size(366, 216)
        Me.btn_tpv.TabIndex = 0
        Me.btn_tpv.Text = "TPV"
        Me.btn_tpv.UseVisualStyleBackColor = True
        '
        'btn_gestion
        '
        Me.btn_gestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_gestion.Location = New System.Drawing.Point(375, 50)
        Me.btn_gestion.Name = "btn_gestion"
        Me.btn_gestion.Size = New System.Drawing.Size(366, 216)
        Me.btn_gestion.TabIndex = 1
        Me.btn_gestion.Text = "GESTIÓN"
        Me.btn_gestion.UseVisualStyleBackColor = True
        '
        'btn_zonaClientes
        '
        Me.btn_zonaClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_zonaClientes.Location = New System.Drawing.Point(3, 272)
        Me.btn_zonaClientes.Name = "btn_zonaClientes"
        Me.btn_zonaClientes.Size = New System.Drawing.Size(366, 175)
        Me.btn_zonaClientes.TabIndex = 2
        Me.btn_zonaClientes.Text = "ZONA CLIENTES"
        Me.btn_zonaClientes.UseVisualStyleBackColor = True
        '
        'btn_surtidores
        '
        Me.btn_surtidores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_surtidores.Location = New System.Drawing.Point(375, 272)
        Me.btn_surtidores.Name = "btn_surtidores"
        Me.btn_surtidores.Size = New System.Drawing.Size(366, 175)
        Me.btn_surtidores.TabIndex = 3
        Me.btn_surtidores.Text = "SURTIDORES"
        Me.btn_surtidores.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_salir.Location = New System.Drawing.Point(747, 3)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(50, 41)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "X"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'MenuPrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "MenuPrincipalForm"
        Me.Text = "MenuPrincipalForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_tpv As Button
    Friend WithEvents btn_gestion As Button
    Friend WithEvents btn_zonaClientes As Button
    Friend WithEvents btn_surtidores As Button
    Friend WithEvents btn_salir As Button
End Class
