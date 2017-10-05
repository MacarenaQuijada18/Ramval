<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrarcargo_form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrarcargo_form))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ok_button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cargo_text = New System.Windows.Forms.TextBox()
        Me.cargo_grid = New System.Windows.Forms.DataGridView()
        Me.id_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modificar_cargo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar_cargo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cargo_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Location = New System.Drawing.Point(-4, 365)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(492, 10)
        Me.Panel4.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.ok_button)
        Me.Panel1.Location = New System.Drawing.Point(0, 380)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 61)
        Me.Panel1.TabIndex = 43
        '
        'ok_button
        '
        Me.ok_button.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok_button.Location = New System.Drawing.Point(184, 6)
        Me.ok_button.Name = "ok_button"
        Me.ok_button.Size = New System.Drawing.Size(112, 42)
        Me.ok_button.TabIndex = 3
        Me.ok_button.Text = "Listo"
        Me.ok_button.UseVisualStyleBackColor = True
        Me.ok_button.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkRed
        Me.Panel3.Location = New System.Drawing.Point(0, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(489, 10)
        Me.Panel3.TabIndex = 44
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(489, 61)
        Me.Panel2.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Administrar Cargos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 19)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Nombre:"
        '
        'cargo_text
        '
        Me.cargo_text.BackColor = System.Drawing.Color.GhostWhite
        Me.cargo_text.Enabled = False
        Me.cargo_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cargo_text.Location = New System.Drawing.Point(136, 322)
        Me.cargo_text.Name = "cargo_text"
        Me.cargo_text.Size = New System.Drawing.Size(316, 26)
        Me.cargo_text.TabIndex = 40
        '
        'cargo_grid
        '
        Me.cargo_grid.AllowUserToAddRows = False
        Me.cargo_grid.AllowUserToDeleteRows = False
        Me.cargo_grid.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.cargo_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cargo_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_cargo, Me.nombre_cargo, Me.modificar_cargo, Me.eliminar_cargo})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cargo_grid.DefaultCellStyle = DataGridViewCellStyle1
        Me.cargo_grid.Location = New System.Drawing.Point(12, 93)
        Me.cargo_grid.Name = "cargo_grid"
        Me.cargo_grid.ReadOnly = True
        Me.cargo_grid.Size = New System.Drawing.Size(462, 223)
        Me.cargo_grid.TabIndex = 39
        '
        'id_cargo
        '
        Me.id_cargo.HeaderText = "ID Cargo"
        Me.id_cargo.Name = "id_cargo"
        Me.id_cargo.ReadOnly = True
        Me.id_cargo.Visible = False
        '
        'nombre_cargo
        '
        Me.nombre_cargo.HeaderText = "Cargo"
        Me.nombre_cargo.Name = "nombre_cargo"
        Me.nombre_cargo.ReadOnly = True
        Me.nombre_cargo.Width = 200
        '
        'modificar_cargo
        '
        Me.modificar_cargo.HeaderText = "Modificar"
        Me.modificar_cargo.Name = "modificar_cargo"
        Me.modificar_cargo.ReadOnly = True
        '
        'eliminar_cargo
        '
        Me.eliminar_cargo.HeaderText = "Eliminar"
        Me.eliminar_cargo.Name = "eliminar_cargo"
        Me.eliminar_cargo.ReadOnly = True
        '
        'administrarcargo_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 441)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cargo_text)
        Me.Controls.Add(Me.cargo_grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "administrarcargo_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Cargo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cargo_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ok_button As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cargo_text As System.Windows.Forms.TextBox
    Friend WithEvents cargo_grid As System.Windows.Forms.DataGridView
    Friend WithEvents id_cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modificar_cargo As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents eliminar_cargo As System.Windows.Forms.DataGridViewButtonColumn
End Class
