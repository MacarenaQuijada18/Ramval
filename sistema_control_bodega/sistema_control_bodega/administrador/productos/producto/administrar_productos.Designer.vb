<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrarproductos_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrarproductos_form))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ok_button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.producto_grid = New System.Windows.Forms.DataGridView()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modificar_personal = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar_personal = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.categoria_combo = New System.Windows.Forms.ComboBox()
        Me.precio_text = New System.Windows.Forms.TextBox()
        Me.nombre_text = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.producto_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Location = New System.Drawing.Point(-1, 512)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(865, 10)
        Me.Panel4.TabIndex = 66
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.ok_button)
        Me.Panel2.Location = New System.Drawing.Point(-1, 528)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(865, 62)
        Me.Panel2.TabIndex = 64
        '
        'ok_button
        '
        Me.ok_button.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok_button.Location = New System.Drawing.Point(377, 6)
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
        Me.Panel3.Location = New System.Drawing.Point(-1, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(865, 10)
        Me.Panel3.TabIndex = 65
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 62)
        Me.Panel1.TabIndex = 63
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(303, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(350, 38)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Administrar Productos"
        '
        'producto_grid
        '
        Me.producto_grid.AllowUserToAddRows = False
        Me.producto_grid.AllowUserToDeleteRows = False
        Me.producto_grid.BackgroundColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.producto_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.producto_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.producto_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_producto, Me.id_categoria, Me.nombre_producto, Me.precio_producto, Me.categoria_producto, Me.stock_producto, Me.modificar_personal, Me.eliminar_personal})
        Me.producto_grid.Location = New System.Drawing.Point(16, 84)
        Me.producto_grid.Name = "producto_grid"
        Me.producto_grid.ReadOnly = True
        Me.producto_grid.Size = New System.Drawing.Size(837, 251)
        Me.producto_grid.TabIndex = 56
        '
        'id_producto
        '
        Me.id_producto.HeaderText = "ID"
        Me.id_producto.Name = "id_producto"
        Me.id_producto.ReadOnly = True
        '
        'id_categoria
        '
        Me.id_categoria.HeaderText = "ID Categoria"
        Me.id_categoria.Name = "id_categoria"
        Me.id_categoria.ReadOnly = True
        Me.id_categoria.Visible = False
        '
        'nombre_producto
        '
        Me.nombre_producto.HeaderText = "Nombre"
        Me.nombre_producto.Name = "nombre_producto"
        Me.nombre_producto.ReadOnly = True
        Me.nombre_producto.Width = 150
        '
        'precio_producto
        '
        Me.precio_producto.HeaderText = "Precio"
        Me.precio_producto.Name = "precio_producto"
        Me.precio_producto.ReadOnly = True
        '
        'categoria_producto
        '
        Me.categoria_producto.HeaderText = "Categoria"
        Me.categoria_producto.Name = "categoria_producto"
        Me.categoria_producto.ReadOnly = True
        '
        'stock_producto
        '
        Me.stock_producto.HeaderText = "Stock"
        Me.stock_producto.Name = "stock_producto"
        Me.stock_producto.ReadOnly = True
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
        'categoria_combo
        '
        Me.categoria_combo.BackColor = System.Drawing.Color.GhostWhite
        Me.categoria_combo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoria_combo.FormattingEnabled = True
        Me.categoria_combo.Location = New System.Drawing.Point(309, 424)
        Me.categoria_combo.Name = "categoria_combo"
        Me.categoria_combo.Size = New System.Drawing.Size(298, 26)
        Me.categoria_combo.TabIndex = 72
        '
        'precio_text
        '
        Me.precio_text.BackColor = System.Drawing.Color.GhostWhite
        Me.precio_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio_text.Location = New System.Drawing.Point(309, 389)
        Me.precio_text.Name = "precio_text"
        Me.precio_text.Size = New System.Drawing.Size(299, 26)
        Me.precio_text.TabIndex = 71
        '
        'nombre_text
        '
        Me.nombre_text.BackColor = System.Drawing.Color.GhostWhite
        Me.nombre_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_text.Location = New System.Drawing.Point(309, 355)
        Me.nombre_text.Name = "nombre_text"
        Me.nombre_text.Size = New System.Drawing.Size(299, 26)
        Me.nombre_text.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(202, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 23)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Categoría:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(231, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Precio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(219, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(236, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 23)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Stock:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.GhostWhite
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(309, 464)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(299, 26)
        Me.NumericUpDown1.TabIndex = 74
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'administrarproductos_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(865, 589)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.categoria_combo)
        Me.Controls.Add(Me.precio_text)
        Me.Controls.Add(Me.nombre_text)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.producto_grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "administrarproductos_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Productos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.producto_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ok_button As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents producto_grid As System.Windows.Forms.DataGridView
    Friend WithEvents categoria_combo As System.Windows.Forms.ComboBox
    Friend WithEvents precio_text As System.Windows.Forms.TextBox
    Friend WithEvents nombre_text As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents categoria_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modificar_personal As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents eliminar_personal As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
