<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class administradornuevo_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administradornuevo_form))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.administrar_group = New System.Windows.Forms.GroupBox()
        Me.ingreso_button = New System.Windows.Forms.Button()
        Me.personales_button = New System.Windows.Forms.Button()
        Me.egreso_button = New System.Windows.Forms.Button()
        Me.productos_button = New System.Windows.Forms.Button()
        Me.accion_group = New System.Windows.Forms.GroupBox()
        Me.accionuno_button = New System.Windows.Forms.Button()
        Me.accion2_button = New System.Windows.Forms.Button()
        Me.acciones_group = New System.Windows.Forms.GroupBox()
        Me.agregar_button = New System.Windows.Forms.Button()
        Me.administrar_button = New System.Windows.Forms.Button()
        Me.salir_button = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.administrar_group.SuspendLayout()
        Me.accion_group.SuspendLayout()
        Me.acciones_group.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(983, 62)
        Me.Panel2.TabIndex = 67
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(378, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(226, 38)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Administrador"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DarkRed
        Me.Panel3.Location = New System.Drawing.Point(-1, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(985, 11)
        Me.Panel3.TabIndex = 66
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 483)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 11)
        Me.Panel1.TabIndex = 67
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Location = New System.Drawing.Point(0, 500)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(985, 61)
        Me.Panel4.TabIndex = 68
        '
        'administrar_group
        '
        Me.administrar_group.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.administrar_group.AutoSize = True
        Me.administrar_group.Controls.Add(Me.ingreso_button)
        Me.administrar_group.Controls.Add(Me.personales_button)
        Me.administrar_group.Controls.Add(Me.egreso_button)
        Me.administrar_group.Controls.Add(Me.productos_button)
        Me.administrar_group.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.administrar_group.Location = New System.Drawing.Point(133, 83)
        Me.administrar_group.Name = "administrar_group"
        Me.administrar_group.Size = New System.Drawing.Size(706, 170)
        Me.administrar_group.TabIndex = 75
        Me.administrar_group.TabStop = False
        Me.administrar_group.Text = "Administrar"
        '
        'ingreso_button
        '
        Me.ingreso_button.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ingreso_button.BackColor = System.Drawing.Color.White
        Me.ingreso_button.BackgroundImage = Global.sistema_control_bodega.My.Resources.Resources.ingreso
        Me.ingreso_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ingreso_button.Location = New System.Drawing.Point(68, 25)
        Me.ingreso_button.Name = "ingreso_button"
        Me.ingreso_button.Size = New System.Drawing.Size(120, 120)
        Me.ingreso_button.TabIndex = 2
        Me.ingreso_button.UseVisualStyleBackColor = False
        '
        'personales_button
        '
        Me.personales_button.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.personales_button.BackColor = System.Drawing.Color.White
        Me.personales_button.BackgroundImage = Global.sistema_control_bodega.My.Resources.Resources.personales
        Me.personales_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.personales_button.Location = New System.Drawing.Point(505, 25)
        Me.personales_button.Name = "personales_button"
        Me.personales_button.Size = New System.Drawing.Size(121, 120)
        Me.personales_button.TabIndex = 5
        Me.personales_button.UseVisualStyleBackColor = False
        '
        'egreso_button
        '
        Me.egreso_button.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.egreso_button.BackColor = System.Drawing.Color.White
        Me.egreso_button.BackgroundImage = Global.sistema_control_bodega.My.Resources.Resources.egreso
        Me.egreso_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.egreso_button.Location = New System.Drawing.Point(214, 25)
        Me.egreso_button.Name = "egreso_button"
        Me.egreso_button.Size = New System.Drawing.Size(120, 120)
        Me.egreso_button.TabIndex = 3
        Me.egreso_button.UseVisualStyleBackColor = False
        '
        'productos_button
        '
        Me.productos_button.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.productos_button.BackColor = System.Drawing.Color.White
        Me.productos_button.BackgroundImage = Global.sistema_control_bodega.My.Resources.Resources.producto
        Me.productos_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.productos_button.Location = New System.Drawing.Point(361, 25)
        Me.productos_button.Name = "productos_button"
        Me.productos_button.Size = New System.Drawing.Size(120, 120)
        Me.productos_button.TabIndex = 4
        Me.productos_button.UseVisualStyleBackColor = False
        '
        'accion_group
        '
        Me.accion_group.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.accion_group.AutoSize = True
        Me.accion_group.Controls.Add(Me.accionuno_button)
        Me.accion_group.Controls.Add(Me.accion2_button)
        Me.accion_group.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accion_group.Location = New System.Drawing.Point(133, 261)
        Me.accion_group.Name = "accion_group"
        Me.accion_group.Size = New System.Drawing.Size(334, 170)
        Me.accion_group.TabIndex = 76
        Me.accion_group.TabStop = False
        Me.accion_group.Text = "Acción"
        Me.accion_group.Visible = False
        '
        'accionuno_button
        '
        Me.accionuno_button.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.accionuno_button.BackColor = System.Drawing.Color.White
        Me.accionuno_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.accionuno_button.Location = New System.Drawing.Point(197, 25)
        Me.accionuno_button.Name = "accionuno_button"
        Me.accionuno_button.Size = New System.Drawing.Size(116, 120)
        Me.accionuno_button.TabIndex = 7
        Me.accionuno_button.UseVisualStyleBackColor = False
        '
        'accion2_button
        '
        Me.accion2_button.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.accion2_button.BackColor = System.Drawing.Color.White
        Me.accion2_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.accion2_button.Location = New System.Drawing.Point(19, 25)
        Me.accion2_button.Name = "accion2_button"
        Me.accion2_button.Size = New System.Drawing.Size(116, 120)
        Me.accion2_button.TabIndex = 8
        Me.accion2_button.UseVisualStyleBackColor = False
        '
        'acciones_group
        '
        Me.acciones_group.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.acciones_group.AutoSize = True
        Me.acciones_group.Controls.Add(Me.agregar_button)
        Me.acciones_group.Controls.Add(Me.administrar_button)
        Me.acciones_group.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acciones_group.Location = New System.Drawing.Point(563, 261)
        Me.acciones_group.Name = "acciones_group"
        Me.acciones_group.Size = New System.Drawing.Size(276, 170)
        Me.acciones_group.TabIndex = 78
        Me.acciones_group.TabStop = False
        Me.acciones_group.Text = "Acción"
        Me.acciones_group.Visible = False
        '
        'agregar_button
        '
        Me.agregar_button.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.agregar_button.BackColor = System.Drawing.Color.White
        Me.agregar_button.BackgroundImage = Global.sistema_control_bodega.My.Resources.Resources.agregar
        Me.agregar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.agregar_button.Location = New System.Drawing.Point(20, 25)
        Me.agregar_button.Name = "agregar_button"
        Me.agregar_button.Size = New System.Drawing.Size(120, 120)
        Me.agregar_button.TabIndex = 10
        Me.agregar_button.UseVisualStyleBackColor = False
        '
        'administrar_button
        '
        Me.administrar_button.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.administrar_button.BackColor = System.Drawing.Color.White
        Me.administrar_button.BackgroundImage = Global.sistema_control_bodega.My.Resources.Resources.administrar
        Me.administrar_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.administrar_button.Location = New System.Drawing.Point(146, 25)
        Me.administrar_button.Name = "administrar_button"
        Me.administrar_button.Size = New System.Drawing.Size(120, 120)
        Me.administrar_button.TabIndex = 11
        Me.administrar_button.UseVisualStyleBackColor = False
        '
        'salir_button
        '
        Me.salir_button.BackColor = System.Drawing.Color.White
        Me.salir_button.BackgroundImage = Global.sistema_control_bodega.My.Resources.Resources.salir
        Me.salir_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.salir_button.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.salir_button.Location = New System.Drawing.Point(485, 437)
        Me.salir_button.Name = "salir_button"
        Me.salir_button.Size = New System.Drawing.Size(120, 40)
        Me.salir_button.TabIndex = 12
        Me.salir_button.UseVisualStyleBackColor = False
        '
        'administradornuevo_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.salir_button)
        Me.Controls.Add(Me.acciones_group)
        Me.Controls.Add(Me.accion_group)
        Me.Controls.Add(Me.administrar_group)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "administradornuevo_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.administrar_group.ResumeLayout(False)
        Me.accion_group.ResumeLayout(False)
        Me.acciones_group.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ingreso_button As System.Windows.Forms.Button
    Friend WithEvents egreso_button As System.Windows.Forms.Button
    Friend WithEvents productos_button As System.Windows.Forms.Button
    Friend WithEvents personales_button As System.Windows.Forms.Button
    Friend WithEvents administrar_group As System.Windows.Forms.GroupBox
    Friend WithEvents accion_group As System.Windows.Forms.GroupBox
    Friend WithEvents accionuno_button As System.Windows.Forms.Button
    Friend WithEvents accion2_button As System.Windows.Forms.Button
    Friend WithEvents acciones_group As System.Windows.Forms.GroupBox
    Friend WithEvents agregar_button As System.Windows.Forms.Button
    Friend WithEvents administrar_button As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents salir_button As System.Windows.Forms.Button
End Class
