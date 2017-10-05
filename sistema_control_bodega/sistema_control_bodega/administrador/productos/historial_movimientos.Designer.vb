<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historialmovimiento_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(historialmovimiento_form))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.informe_group = New System.Windows.Forms.GroupBox()
        Me.informe_button = New System.Windows.Forms.Button()
        Me.ver_button = New System.Windows.Forms.Button()
        Me.termino_date = New System.Windows.Forms.DateTimePicker()
        Me.inicio_date = New System.Windows.Forms.DateTimePicker()
        Me.tipo_combo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.historial_grid = New System.Windows.Forms.DataGridView()
        Me.idhistorial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_movimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto_movimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movimiento_historial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_inicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.informe_group.SuspendLayout()
        CType(Me.historial_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.DarkRed
        Me.Panel4.Location = New System.Drawing.Point(0, 535)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1284, 10)
        Me.Panel4.TabIndex = 65
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.DarkRed
        Me.Panel5.Location = New System.Drawing.Point(0, 549)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1284, 62)
        Me.Panel5.TabIndex = 64
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DarkRed
        Me.Panel3.Location = New System.Drawing.Point(0, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1284, 10)
        Me.Panel3.TabIndex = 63
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 62)
        Me.Panel2.TabIndex = 62
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(439, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(322, 38)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Historial Movimiento"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'informe_group
        '
        Me.informe_group.Controls.Add(Me.informe_button)
        Me.informe_group.Controls.Add(Me.ver_button)
        Me.informe_group.Controls.Add(Me.termino_date)
        Me.informe_group.Controls.Add(Me.inicio_date)
        Me.informe_group.Controls.Add(Me.tipo_combo)
        Me.informe_group.Controls.Add(Me.Label3)
        Me.informe_group.Controls.Add(Me.Label2)
        Me.informe_group.Controls.Add(Me.Label1)
        Me.informe_group.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.informe_group.Location = New System.Drawing.Point(964, 148)
        Me.informe_group.Name = "informe_group"
        Me.informe_group.Size = New System.Drawing.Size(302, 250)
        Me.informe_group.TabIndex = 61
        Me.informe_group.TabStop = False
        Me.informe_group.Text = "Filtrar"
        '
        'informe_button
        '
        Me.informe_button.Location = New System.Drawing.Point(39, 202)
        Me.informe_button.Name = "informe_button"
        Me.informe_button.Size = New System.Drawing.Size(232, 42)
        Me.informe_button.TabIndex = 36
        Me.informe_button.Text = "Generar Informe"
        Me.informe_button.UseVisualStyleBackColor = True
        '
        'ver_button
        '
        Me.ver_button.Location = New System.Drawing.Point(39, 144)
        Me.ver_button.Name = "ver_button"
        Me.ver_button.Size = New System.Drawing.Size(232, 42)
        Me.ver_button.TabIndex = 35
        Me.ver_button.Text = "Filtrar"
        Me.ver_button.UseVisualStyleBackColor = True
        '
        'termino_date
        '
        Me.termino_date.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.termino_date.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.termino_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.termino_date.Location = New System.Drawing.Point(105, 103)
        Me.termino_date.Name = "termino_date"
        Me.termino_date.Size = New System.Drawing.Size(166, 26)
        Me.termino_date.TabIndex = 34
        '
        'inicio_date
        '
        Me.inicio_date.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.inicio_date.Checked = False
        Me.inicio_date.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.inicio_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inicio_date.Location = New System.Drawing.Point(105, 63)
        Me.inicio_date.Name = "inicio_date"
        Me.inicio_date.Size = New System.Drawing.Size(166, 26)
        Me.inicio_date.TabIndex = 33
        '
        'tipo_combo
        '
        Me.tipo_combo.BackColor = System.Drawing.Color.GhostWhite
        Me.tipo_combo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.tipo_combo.FormattingEnabled = True
        Me.tipo_combo.Items.AddRange(New Object() {"Todo", "Entrada - Ingreso", "Salida - Egreso"})
        Me.tipo_combo.Location = New System.Drawing.Point(105, 27)
        Me.tipo_combo.Name = "tipo_combo"
        Me.tipo_combo.Size = New System.Drawing.Size(166, 26)
        Me.tipo_combo.TabIndex = 32
        Me.tipo_combo.Text = "Todo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Termino:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio:"
        '
        'historial_grid
        '
        Me.historial_grid.AllowUserToAddRows = False
        Me.historial_grid.AllowUserToDeleteRows = False
        Me.historial_grid.BackgroundColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.historial_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.historial_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.historial_grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idhistorial, Me.fecha_movimiento, Me.n_documento, Me.producto_movimiento, Me.movimiento_historial, Me.stock_inicial, Me.stock_documento, Me.stock_final})
        Me.historial_grid.Location = New System.Drawing.Point(26, 110)
        Me.historial_grid.Name = "historial_grid"
        Me.historial_grid.ReadOnly = True
        Me.historial_grid.Size = New System.Drawing.Size(932, 383)
        Me.historial_grid.TabIndex = 60
        '
        'idhistorial
        '
        Me.idhistorial.HeaderText = "ID"
        Me.idhistorial.Name = "idhistorial"
        Me.idhistorial.ReadOnly = True
        Me.idhistorial.Visible = False
        '
        'fecha_movimiento
        '
        Me.fecha_movimiento.HeaderText = "Fecha"
        Me.fecha_movimiento.Name = "fecha_movimiento"
        Me.fecha_movimiento.ReadOnly = True
        Me.fecha_movimiento.Width = 70
        '
        'n_documento
        '
        Me.n_documento.HeaderText = "N° Doc."
        Me.n_documento.Name = "n_documento"
        Me.n_documento.ReadOnly = True
        '
        'producto_movimiento
        '
        Me.producto_movimiento.HeaderText = "Producto"
        Me.producto_movimiento.Name = "producto_movimiento"
        Me.producto_movimiento.ReadOnly = True
        Me.producto_movimiento.Width = 200
        '
        'movimiento_historial
        '
        Me.movimiento_historial.HeaderText = "Movimiento"
        Me.movimiento_historial.Name = "movimiento_historial"
        Me.movimiento_historial.ReadOnly = True
        Me.movimiento_historial.Width = 200
        '
        'stock_inicial
        '
        Me.stock_inicial.HeaderText = "Stock Inicial"
        Me.stock_inicial.Name = "stock_inicial"
        Me.stock_inicial.ReadOnly = True
        '
        'stock_documento
        '
        Me.stock_documento.HeaderText = "Stock Documento"
        Me.stock_documento.Name = "stock_documento"
        Me.stock_documento.ReadOnly = True
        '
        'stock_final
        '
        Me.stock_final.HeaderText = "Stock Final"
        Me.stock_final.Name = "stock_final"
        Me.stock_final.ReadOnly = True
        '
        'historialmovimiento_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 611)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.informe_group)
        Me.Controls.Add(Me.historial_grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "historialmovimiento_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial Movimientos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.informe_group.ResumeLayout(False)
        Me.informe_group.PerformLayout()
        CType(Me.historial_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents informe_group As System.Windows.Forms.GroupBox
    Friend WithEvents ver_button As System.Windows.Forms.Button
    Friend WithEvents termino_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents inicio_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents tipo_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents historial_grid As System.Windows.Forms.DataGridView
    Friend WithEvents idhistorial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_movimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents n_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents producto_movimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents movimiento_historial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_inicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_final As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents informe_button As System.Windows.Forms.Button
End Class
