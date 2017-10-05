<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevopersonal_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nuevopersonal_form))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.agregar_button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cargo_box = New System.Windows.Forms.ComboBox()
        Me.direccion_text = New System.Windows.Forms.TextBox()
        Me.telefono_text = New System.Windows.Forms.TextBox()
        Me.celular_text = New System.Windows.Forms.TextBox()
        Me.clave_text = New System.Windows.Forms.TextBox()
        Me.apellido_text = New System.Windows.Forms.TextBox()
        Me.nombre_text = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Location = New System.Drawing.Point(-1, 329)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(451, 10)
        Me.Panel4.TabIndex = 62
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.agregar_button)
        Me.Panel1.Location = New System.Drawing.Point(0, 342)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 61)
        Me.Panel1.TabIndex = 61
        '
        'agregar_button
        '
        Me.agregar_button.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar_button.Location = New System.Drawing.Point(129, 10)
        Me.agregar_button.Name = "agregar_button"
        Me.agregar_button.Size = New System.Drawing.Size(202, 37)
        Me.agregar_button.TabIndex = 8
        Me.agregar_button.Text = "Agregar Nuevo"
        Me.agregar_button.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkRed
        Me.Panel3.Location = New System.Drawing.Point(0, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(451, 10)
        Me.Panel3.TabIndex = 60
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(-1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(451, 61)
        Me.Panel2.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 20.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(113, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 38)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Nueva Persona"
        '
        'cargo_box
        '
        Me.cargo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cargo_box.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cargo_box.FormattingEnabled = True
        Me.cargo_box.Location = New System.Drawing.Point(129, 82)
        Me.cargo_box.Name = "cargo_box"
        Me.cargo_box.Size = New System.Drawing.Size(300, 26)
        Me.cargo_box.TabIndex = 45
        '
        'direccion_text
        '
        Me.direccion_text.BackColor = System.Drawing.Color.GhostWhite
        Me.direccion_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion_text.Location = New System.Drawing.Point(129, 214)
        Me.direccion_text.Name = "direccion_text"
        Me.direccion_text.Size = New System.Drawing.Size(300, 26)
        Me.direccion_text.TabIndex = 49
        '
        'telefono_text
        '
        Me.telefono_text.BackColor = System.Drawing.Color.GhostWhite
        Me.telefono_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono_text.Location = New System.Drawing.Point(129, 250)
        Me.telefono_text.Name = "telefono_text"
        Me.telefono_text.Size = New System.Drawing.Size(300, 26)
        Me.telefono_text.TabIndex = 50
        '
        'celular_text
        '
        Me.celular_text.BackColor = System.Drawing.Color.GhostWhite
        Me.celular_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.celular_text.Location = New System.Drawing.Point(129, 291)
        Me.celular_text.Name = "celular_text"
        Me.celular_text.Size = New System.Drawing.Size(300, 26)
        Me.celular_text.TabIndex = 51
        '
        'clave_text
        '
        Me.clave_text.BackColor = System.Drawing.Color.GhostWhite
        Me.clave_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clave_text.Location = New System.Drawing.Point(129, 179)
        Me.clave_text.Name = "clave_text"
        Me.clave_text.Size = New System.Drawing.Size(300, 26)
        Me.clave_text.TabIndex = 48
        Me.clave_text.UseSystemPasswordChar = True
        '
        'apellido_text
        '
        Me.apellido_text.BackColor = System.Drawing.Color.GhostWhite
        Me.apellido_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellido_text.Location = New System.Drawing.Point(129, 146)
        Me.apellido_text.Name = "apellido_text"
        Me.apellido_text.Size = New System.Drawing.Size(300, 26)
        Me.apellido_text.TabIndex = 47
        '
        'nombre_text
        '
        Me.nombre_text.BackColor = System.Drawing.Color.GhostWhite
        Me.nombre_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_text.Location = New System.Drawing.Point(129, 114)
        Me.nombre_text.Name = "nombre_text"
        Me.nombre_text.Size = New System.Drawing.Size(300, 26)
        Me.nombre_text.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 19)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Cargo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Celular:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 19)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Telefono Casa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Clave:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Nombre:"
        '
        'nuevopersonal_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(449, 401)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cargo_box)
        Me.Controls.Add(Me.direccion_text)
        Me.Controls.Add(Me.telefono_text)
        Me.Controls.Add(Me.celular_text)
        Me.Controls.Add(Me.clave_text)
        Me.Controls.Add(Me.apellido_text)
        Me.Controls.Add(Me.nombre_text)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "nuevopersonal_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Personal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents agregar_button As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cargo_box As System.Windows.Forms.ComboBox
    Friend WithEvents direccion_text As System.Windows.Forms.TextBox
    Friend WithEvents telefono_text As System.Windows.Forms.TextBox
    Friend WithEvents celular_text As System.Windows.Forms.TextBox
    Friend WithEvents clave_text As System.Windows.Forms.TextBox
    Friend WithEvents apellido_text As System.Windows.Forms.TextBox
    Friend WithEvents nombre_text As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
