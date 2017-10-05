<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevoproducto_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nuevoproducto_form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre_text = New System.Windows.Forms.TextBox()
        Me.precio_text = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.agregar_button = New System.Windows.Forms.Button()
        Me.categoria_combo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.stock_numeric = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.stock_numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(40, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(52, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio:"
        '
        'nombre_text
        '
        Me.nombre_text.BackColor = System.Drawing.Color.GhostWhite
        Me.nombre_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_text.Location = New System.Drawing.Point(130, 113)
        Me.nombre_text.Name = "nombre_text"
        Me.nombre_text.Size = New System.Drawing.Size(157, 26)
        Me.nombre_text.TabIndex = 3
        '
        'precio_text
        '
        Me.precio_text.BackColor = System.Drawing.Color.GhostWhite
        Me.precio_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio_text.Location = New System.Drawing.Point(130, 145)
        Me.precio_text.Name = "precio_text"
        Me.precio_text.Size = New System.Drawing.Size(157, 26)
        Me.precio_text.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkRed
        Me.Panel3.Location = New System.Drawing.Point(0, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(327, 10)
        Me.Panel3.TabIndex = 63
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 61)
        Me.Panel2.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(278, 38)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Agregar Producto"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Location = New System.Drawing.Point(-2, 236)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(327, 10)
        Me.Panel4.TabIndex = 64
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.agregar_button)
        Me.Panel1.Location = New System.Drawing.Point(-2, 249)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 61)
        Me.Panel1.TabIndex = 63
        '
        'agregar_button
        '
        Me.agregar_button.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar_button.Location = New System.Drawing.Point(105, 7)
        Me.agregar_button.Name = "agregar_button"
        Me.agregar_button.Size = New System.Drawing.Size(112, 42)
        Me.agregar_button.TabIndex = 2
        Me.agregar_button.Text = "Agregar"
        Me.agregar_button.UseVisualStyleBackColor = True
        '
        'categoria_combo
        '
        Me.categoria_combo.BackColor = System.Drawing.Color.GhostWhite
        Me.categoria_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoria_combo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoria_combo.FormattingEnabled = True
        Me.categoria_combo.Location = New System.Drawing.Point(131, 81)
        Me.categoria_combo.Name = "categoria_combo"
        Me.categoria_combo.Size = New System.Drawing.Size(156, 26)
        Me.categoria_combo.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 23)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Categoría:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(57, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Stock:"
        '
        'stock_numeric
        '
        Me.stock_numeric.BackColor = System.Drawing.Color.GhostWhite
        Me.stock_numeric.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.stock_numeric.Location = New System.Drawing.Point(130, 177)
        Me.stock_numeric.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.stock_numeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.stock_numeric.Name = "stock_numeric"
        Me.stock_numeric.Size = New System.Drawing.Size(157, 26)
        Me.stock_numeric.TabIndex = 68
        Me.stock_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.stock_numeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.GhostWhite
        Me.NumericUpDown1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(130, 209)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(157, 26)
        Me.NumericUpDown1.TabIndex = 70
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(24, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 23)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Stock Min:"
        '
        'nuevoproducto_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(324, 310)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stock_numeric)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.categoria_combo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.precio_text)
        Me.Controls.Add(Me.nombre_text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "nuevoproducto_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Producto"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.stock_numeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre_text As System.Windows.Forms.TextBox
    Friend WithEvents precio_text As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents agregar_button As System.Windows.Forms.Button
    Friend WithEvents categoria_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents stock_numeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label6 As Label
End Class
