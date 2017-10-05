<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrarpersonal_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrarpersonal_form))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ok_button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cargo_box = New System.Windows.Forms.ComboBox()
        Me.direccion_text = New System.Windows.Forms.TextBox()
        Me.telefono_text = New System.Windows.Forms.TextBox()
        Me.celular_text = New System.Windows.Forms.TextBox()
        Me.apellido_text = New System.Windows.Forms.TextBox()
        Me.nombre_text = New System.Windows.Forms.TextBox()
        Me.personal_grid = New System.Windows.Forms.DataGridView()
        Me.id_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.celular_personal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cambiar_password = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.modificar_personal = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar_personal = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.personal_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Location = New System.Drawing.Point(0, 552)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(875, 10)
        Me.Panel4.TabIndex = 55
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.ok_button)
        Me.Panel2.Location = New System.Drawing.Point(0, 568)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(875, 62)
        Me.Panel2.TabIndex = 53
        '
        'ok_button
        '
        Me.ok_button.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok_button.Location = New System.Drawing.Point(386, 6)
        Me.ok_button.Name = "ok_button"
        Me.ok_button.Size = New System.Drawing.Size(112, 42)
        Me.ok_button.TabIndex = 8
        Me.ok_button.Text = "Listo"
        Me.ok_button.UseVisualStyleBackColor = True
        Me.ok_button.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DarkRed
        Me.Panel3.Location = New System.Drawing.Point(0, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(875, 10)
        Me.Panel3.TabIndex = 54
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 62)
        Me.Panel1.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(279, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(364, 38)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Administrar Personales"
        '
        'cargo_box
        '
        Me.cargo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cargo_box.Enabled = False
        Me.cargo_box.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cargo_box.FormattingEnabled = True
        Me.cargo_box.Location = New System.Drawing.Point(332, 351)
        Me.cargo_box.Name = "cargo_box"
        Me.cargo_box.Size = New System.Drawing.Size(336, 26)
        Me.cargo_box.TabIndex = 46
        '
        'direccion_text
        '
        Me.direccion_text.BackColor = System.Drawing.Color.GhostWhite
        Me.direccion_text.Enabled = False
        Me.direccion_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion_text.Location = New System.Drawing.Point(331, 445)
        Me.direccion_text.Name = "direccion_text"
        Me.direccion_text.Size = New System.Drawing.Size(337, 26)
        Me.direccion_text.TabIndex = 49
        '
        'telefono_text
        '
        Me.telefono_text.BackColor = System.Drawing.Color.GhostWhite
        Me.telefono_text.Enabled = False
        Me.telefono_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono_text.Location = New System.Drawing.Point(331, 481)
        Me.telefono_text.Name = "telefono_text"
        Me.telefono_text.Size = New System.Drawing.Size(337, 26)
        Me.telefono_text.TabIndex = 50
        '
        'celular_text
        '
        Me.celular_text.BackColor = System.Drawing.Color.GhostWhite
        Me.celular_text.Enabled = False
        Me.celular_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.celular_text.Location = New System.Drawing.Point(331, 515)
        Me.celular_text.Name = "celular_text"
        Me.celular_text.Size = New System.Drawing.Size(337, 26)
        Me.celular_text.TabIndex = 51
        '
        'apellido_text
        '
        Me.apellido_text.BackColor = System.Drawing.Color.GhostWhite
        Me.apellido_text.Enabled = False
        Me.apellido_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellido_text.Location = New System.Drawing.Point(332, 412)
        Me.apellido_text.Name = "apellido_text"
        Me.apellido_text.Size = New System.Drawing.Size(336, 26)
        Me.apellido_text.TabIndex = 48
        '
        'nombre_text
        '
        Me.nombre_text.BackColor = System.Drawing.Color.GhostWhite
        Me.nombre_text.Enabled = False
        Me.nombre_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_text.Location = New System.Drawing.Point(331, 380)
        Me.nombre_text.Name = "nombre_text"
        Me.nombre_text.Size = New System.Drawing.Size(337, 26)
        Me.nombre_text.TabIndex = 47
        '
        'personal_grid
        '
        Me.personal_grid.AllowUserToAddRows = False
        Me.personal_grid.AllowUserToDeleteRows = False
        Me.personal_grid.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.personal_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.personal_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_personal, Me.id_cargo, Me.nombre_personal, Me.apellido_personal, Me.cargo_personal, Me.direccion_personal, Me.telefono_personal, Me.celular_personal, Me.cambiar_password, Me.modificar_personal, Me.eliminar_personal})
        Me.personal_grid.Location = New System.Drawing.Point(17, 84)
        Me.personal_grid.Name = "personal_grid"
        Me.personal_grid.ReadOnly = True
        Me.personal_grid.Size = New System.Drawing.Size(844, 251)
        Me.personal_grid.TabIndex = 45
        '
        'id_personal
        '
        Me.id_personal.HeaderText = "ID"
        Me.id_personal.Name = "id_personal"
        Me.id_personal.ReadOnly = True
        Me.id_personal.Visible = False
        '
        'id_cargo
        '
        Me.id_cargo.HeaderText = "ID Cargo"
        Me.id_cargo.Name = "id_cargo"
        Me.id_cargo.ReadOnly = True
        Me.id_cargo.Visible = False
        '
        'nombre_personal
        '
        Me.nombre_personal.HeaderText = "Nombre"
        Me.nombre_personal.Name = "nombre_personal"
        Me.nombre_personal.ReadOnly = True
        Me.nombre_personal.Width = 150
        '
        'apellido_personal
        '
        Me.apellido_personal.HeaderText = "Apellido"
        Me.apellido_personal.Name = "apellido_personal"
        Me.apellido_personal.ReadOnly = True
        '
        'cargo_personal
        '
        Me.cargo_personal.HeaderText = "Cargo"
        Me.cargo_personal.Name = "cargo_personal"
        Me.cargo_personal.ReadOnly = True
        '
        'direccion_personal
        '
        Me.direccion_personal.HeaderText = "Dirección"
        Me.direccion_personal.Name = "direccion_personal"
        Me.direccion_personal.ReadOnly = True
        Me.direccion_personal.Visible = False
        '
        'telefono_personal
        '
        Me.telefono_personal.HeaderText = "Telefono"
        Me.telefono_personal.Name = "telefono_personal"
        Me.telefono_personal.ReadOnly = True
        Me.telefono_personal.Visible = False
        '
        'celular_personal
        '
        Me.celular_personal.HeaderText = "Celular"
        Me.celular_personal.Name = "celular_personal"
        Me.celular_personal.ReadOnly = True
        '
        'cambiar_password
        '
        Me.cambiar_password.HeaderText = "Cambiar Contraseña"
        Me.cambiar_password.Name = "cambiar_password"
        Me.cambiar_password.ReadOnly = True
        Me.cambiar_password.Width = 150
        '
        'modificar_personal
        '
        Me.modificar_personal.HeaderText = "Modificar"
        Me.modificar_personal.Name = "modificar_personal"
        Me.modificar_personal.ReadOnly = True
        '
        'eliminar_personal
        '
        Me.eliminar_personal.HeaderText = "Eliminar"
        Me.eliminar_personal.Name = "eliminar_personal"
        Me.eliminar_personal.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(264, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 19)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Cargo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(257, 518)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Celular:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(202, 484)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 19)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Telefono Casa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(250, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Nombre:"
        '
        'administrarpersonal_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(874, 631)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cargo_box)
        Me.Controls.Add(Me.direccion_text)
        Me.Controls.Add(Me.telefono_text)
        Me.Controls.Add(Me.celular_text)
        Me.Controls.Add(Me.apellido_text)
        Me.Controls.Add(Me.nombre_text)
        Me.Controls.Add(Me.personal_grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "administrarpersonal_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Personal"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.personal_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ok_button As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cargo_box As System.Windows.Forms.ComboBox
    Friend WithEvents direccion_text As System.Windows.Forms.TextBox
    Friend WithEvents telefono_text As System.Windows.Forms.TextBox
    Friend WithEvents celular_text As System.Windows.Forms.TextBox
    Friend WithEvents apellido_text As System.Windows.Forms.TextBox
    Friend WithEvents nombre_text As System.Windows.Forms.TextBox
    Friend WithEvents personal_grid As System.Windows.Forms.DataGridView
    Friend WithEvents id_personal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_personal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido_personal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo_personal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion_personal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono_personal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents celular_personal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cambiar_password As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents modificar_personal As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents eliminar_personal As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
