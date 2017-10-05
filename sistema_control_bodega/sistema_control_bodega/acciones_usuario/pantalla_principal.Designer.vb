<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pantallaprincipal_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pantallaprincipal_form))
        Me.pedido_button = New System.Windows.Forms.Button()
        Me.hora_label = New System.Windows.Forms.Label()
        Me.fecha_label = New System.Windows.Forms.Label()
        Me.hora_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.logo_picture = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pedido_button
        '
        Me.pedido_button.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.pedido_button.Location = New System.Drawing.Point(6, 53)
        Me.pedido_button.Name = "pedido_button"
        Me.pedido_button.Size = New System.Drawing.Size(325, 50)
        Me.pedido_button.TabIndex = 0
        Me.pedido_button.Text = "Realizar Venta"
        Me.pedido_button.UseVisualStyleBackColor = True
        '
        'hora_label
        '
        Me.hora_label.AutoSize = True
        Me.hora_label.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.hora_label.Location = New System.Drawing.Point(1050, 90)
        Me.hora_label.Name = "hora_label"
        Me.hora_label.Size = New System.Drawing.Size(122, 26)
        Me.hora_label.TabIndex = 3
        Me.hora_label.Text = "HH:MM:SS"
        '
        'fecha_label
        '
        Me.fecha_label.AutoSize = True
        Me.fecha_label.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.fecha_label.Location = New System.Drawing.Point(910, 90)
        Me.fecha_label.Name = "fecha_label"
        Me.fecha_label.Size = New System.Drawing.Size(136, 26)
        Me.fecha_label.TabIndex = 4
        Me.fecha_label.Text = "dd/mm/aaaa"
        '
        'hora_timer
        '
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkRed
        Me.Panel3.Location = New System.Drawing.Point(1, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1184, 10)
        Me.Panel3.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 73)
        Me.Panel1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(470, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 46)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Modulo Venta"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Location = New System.Drawing.Point(1, 567)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1184, 10)
        Me.Panel4.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(0, 580)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1184, 62)
        Me.Panel2.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pedido_button)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 415)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 136)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'logo_picture
        '
        Me.logo_picture.Image = CType(resources.GetObject("logo_picture.Image"), System.Drawing.Image)
        Me.logo_picture.Location = New System.Drawing.Point(12, 95)
        Me.logo_picture.Name = "logo_picture"
        Me.logo_picture.Size = New System.Drawing.Size(295, 148)
        Me.logo_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo_picture.TabIndex = 2
        Me.logo_picture.TabStop = False
        '
        'pantallaprincipal_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 641)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.fecha_label)
        Me.Controls.Add(Me.hora_label)
        Me.Controls.Add(Me.logo_picture)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "pantallaprincipal_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pantalla Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.logo_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pedido_button As System.Windows.Forms.Button
    Friend WithEvents logo_picture As System.Windows.Forms.PictureBox
    Friend WithEvents hora_label As System.Windows.Forms.Label
    Friend WithEvents fecha_label As System.Windows.Forms.Label
    Friend WithEvents hora_timer As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
