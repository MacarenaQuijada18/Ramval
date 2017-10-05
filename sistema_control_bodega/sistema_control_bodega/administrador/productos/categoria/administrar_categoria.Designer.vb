<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrarcategoria_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrarcategoria_form))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ok_button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.categoria_text = New System.Windows.Forms.TextBox()
        Me.categoria_grid = New System.Windows.Forms.DataGridView()
        Me.id_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modificar_categoria = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar_categoria = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.categoria_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Location = New System.Drawing.Point(-4, 365)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(492, 10)
        Me.Panel4.TabIndex = 52
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.ok_button)
        Me.Panel1.Location = New System.Drawing.Point(0, 380)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 61)
        Me.Panel1.TabIndex = 50
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
        Me.Panel3.TabIndex = 51
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(489, 61)
        Me.Panel2.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Administrar Categorías"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 19)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Nombre:"
        '
        'categoria_text
        '
        Me.categoria_text.BackColor = System.Drawing.Color.GhostWhite
        Me.categoria_text.Enabled = False
        Me.categoria_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoria_text.Location = New System.Drawing.Point(136, 322)
        Me.categoria_text.Name = "categoria_text"
        Me.categoria_text.Size = New System.Drawing.Size(316, 26)
        Me.categoria_text.TabIndex = 47
        '
        'categoria_grid
        '
        Me.categoria_grid.AllowUserToAddRows = False
        Me.categoria_grid.AllowUserToDeleteRows = False
        Me.categoria_grid.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.categoria_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.categoria_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_categoria, Me.nombre_categoria, Me.modificar_categoria, Me.eliminar_categoria})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.categoria_grid.DefaultCellStyle = DataGridViewCellStyle1
        Me.categoria_grid.Location = New System.Drawing.Point(12, 93)
        Me.categoria_grid.Name = "categoria_grid"
        Me.categoria_grid.ReadOnly = True
        Me.categoria_grid.Size = New System.Drawing.Size(462, 223)
        Me.categoria_grid.TabIndex = 46
        '
        'id_categoria
        '
        Me.id_categoria.HeaderText = "ID Cargo"
        Me.id_categoria.Name = "id_categoria"
        Me.id_categoria.ReadOnly = True
        Me.id_categoria.Visible = False
        '
        'nombre_categoria
        '
        Me.nombre_categoria.HeaderText = "Categoria"
        Me.nombre_categoria.Name = "nombre_categoria"
        Me.nombre_categoria.ReadOnly = True
        Me.nombre_categoria.Width = 200
        '
        'modificar_categoria
        '
        Me.modificar_categoria.HeaderText = "Modificar"
        Me.modificar_categoria.Name = "modificar_categoria"
        Me.modificar_categoria.ReadOnly = True
        '
        'eliminar_categoria
        '
        Me.eliminar_categoria.HeaderText = "Eliminar"
        Me.eliminar_categoria.Name = "eliminar_categoria"
        Me.eliminar_categoria.ReadOnly = True
        '
        'administrarcategoria_form
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
        Me.Controls.Add(Me.categoria_text)
        Me.Controls.Add(Me.categoria_grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "administrarcategoria_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Categoria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.categoria_grid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents categoria_text As System.Windows.Forms.TextBox
    Friend WithEvents categoria_grid As System.Windows.Forms.DataGridView
    Friend WithEvents id_categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modificar_categoria As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents eliminar_categoria As System.Windows.Forms.DataGridViewButtonColumn
End Class
