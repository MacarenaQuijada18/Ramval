<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrador_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administrador_form))
        Me.administrador_menu = New System.Windows.Forms.MenuStrip()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarCategoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearCategoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarCategoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IVAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarDespachadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarDespachadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearLocalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarLocalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.administrador_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'administrador_menu
        '
        Me.administrador_menu.BackColor = System.Drawing.Color.AliceBlue
        Me.administrador_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosToolStripMenuItem, Me.IngresosToolStripMenuItem, Me.EgresosToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.PersonalesToolStripMenuItem, Me.LocalesToolStripMenuItem})
        Me.administrador_menu.Location = New System.Drawing.Point(0, 0)
        Me.administrador_menu.Name = "administrador_menu"
        Me.administrador_menu.Size = New System.Drawing.Size(484, 24)
        Me.administrador_menu.TabIndex = 1
        Me.administrador_menu.Text = "administrador_menu"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.IngresosToolStripMenuItem.Text = "Ingresos"
        '
        'EgresosToolStripMenuItem
        '
        Me.EgresosToolStripMenuItem.Name = "EgresosToolStripMenuItem"
        Me.EgresosToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.EgresosToolStripMenuItem.Text = "Egresos"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarProductoToolStripMenuItem, Me.GestionarCategoríaToolStripMenuItem, Me.GestionarStockToolStripMenuItem, Me.IVAToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'GestionarProductoToolStripMenuItem
        '
        Me.GestionarProductoToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.GestionarProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearProductoToolStripMenuItem, Me.AdministrarProductoToolStripMenuItem})
        Me.GestionarProductoToolStripMenuItem.Name = "GestionarProductoToolStripMenuItem"
        Me.GestionarProductoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.GestionarProductoToolStripMenuItem.Text = "Gestionar Producto"
        '
        'CrearProductoToolStripMenuItem
        '
        Me.CrearProductoToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.CrearProductoToolStripMenuItem.Name = "CrearProductoToolStripMenuItem"
        Me.CrearProductoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CrearProductoToolStripMenuItem.Text = "Crear Producto"
        '
        'AdministrarProductoToolStripMenuItem
        '
        Me.AdministrarProductoToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.AdministrarProductoToolStripMenuItem.Name = "AdministrarProductoToolStripMenuItem"
        Me.AdministrarProductoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AdministrarProductoToolStripMenuItem.Text = "Administrar Producto"
        '
        'GestionarCategoríaToolStripMenuItem
        '
        Me.GestionarCategoríaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.GestionarCategoríaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearCategoríaToolStripMenuItem, Me.AdministrarCategoríaToolStripMenuItem})
        Me.GestionarCategoríaToolStripMenuItem.Name = "GestionarCategoríaToolStripMenuItem"
        Me.GestionarCategoríaToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.GestionarCategoríaToolStripMenuItem.Text = "Gestionar Categoría"
        '
        'CrearCategoríaToolStripMenuItem
        '
        Me.CrearCategoríaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.CrearCategoríaToolStripMenuItem.Name = "CrearCategoríaToolStripMenuItem"
        Me.CrearCategoríaToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.CrearCategoríaToolStripMenuItem.Text = "Crear Categoría"
        '
        'AdministrarCategoríaToolStripMenuItem
        '
        Me.AdministrarCategoríaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.AdministrarCategoríaToolStripMenuItem.Name = "AdministrarCategoríaToolStripMenuItem"
        Me.AdministrarCategoríaToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AdministrarCategoríaToolStripMenuItem.Text = "Administrar Categoría"
        '
        'GestionarStockToolStripMenuItem
        '
        Me.GestionarStockToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.GestionarStockToolStripMenuItem.Name = "GestionarStockToolStripMenuItem"
        Me.GestionarStockToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.GestionarStockToolStripMenuItem.Text = "Historial de Movimiento"
        Me.GestionarStockToolStripMenuItem.Visible = False
        '
        'IVAToolStripMenuItem
        '
        Me.IVAToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.IVAToolStripMenuItem.Name = "IVAToolStripMenuItem"
        Me.IVAToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.IVAToolStripMenuItem.Text = "IVA"
        '
        'PersonalesToolStripMenuItem
        '
        Me.PersonalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarPersonalToolStripMenuItem, Me.GestionarCargosToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.PersonalesToolStripMenuItem.Name = "PersonalesToolStripMenuItem"
        Me.PersonalesToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.PersonalesToolStripMenuItem.Text = "Personales"
        '
        'GestionarPersonalToolStripMenuItem
        '
        Me.GestionarPersonalToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.GestionarPersonalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearPersonalToolStripMenuItem, Me.AdministrarPersonalToolStripMenuItem})
        Me.GestionarPersonalToolStripMenuItem.Name = "GestionarPersonalToolStripMenuItem"
        Me.GestionarPersonalToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.GestionarPersonalToolStripMenuItem.Text = "Gestionar Personal"
        '
        'CrearPersonalToolStripMenuItem
        '
        Me.CrearPersonalToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.CrearPersonalToolStripMenuItem.Name = "CrearPersonalToolStripMenuItem"
        Me.CrearPersonalToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CrearPersonalToolStripMenuItem.Text = "Crear Personal"
        '
        'AdministrarPersonalToolStripMenuItem
        '
        Me.AdministrarPersonalToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.AdministrarPersonalToolStripMenuItem.Name = "AdministrarPersonalToolStripMenuItem"
        Me.AdministrarPersonalToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AdministrarPersonalToolStripMenuItem.Text = "Administrar Personal"
        '
        'GestionarCargosToolStripMenuItem
        '
        Me.GestionarCargosToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.GestionarCargosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearCargosToolStripMenuItem, Me.AdministrarCargosToolStripMenuItem})
        Me.GestionarCargosToolStripMenuItem.Name = "GestionarCargosToolStripMenuItem"
        Me.GestionarCargosToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.GestionarCargosToolStripMenuItem.Text = "Gestionar Cargos"
        '
        'CrearCargosToolStripMenuItem
        '
        Me.CrearCargosToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.CrearCargosToolStripMenuItem.Name = "CrearCargosToolStripMenuItem"
        Me.CrearCargosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CrearCargosToolStripMenuItem.Text = "Crear Cargos"
        '
        'AdministrarCargosToolStripMenuItem
        '
        Me.AdministrarCargosToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.AdministrarCargosToolStripMenuItem.Name = "AdministrarCargosToolStripMenuItem"
        Me.AdministrarCargosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AdministrarCargosToolStripMenuItem.Text = "Administrar Cargos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarDespachadorToolStripMenuItem, Me.AdministrarDespachadorToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem1.Text = "Gestionar Despachador"
        '
        'AgregarDespachadorToolStripMenuItem
        '
        Me.AgregarDespachadorToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.AgregarDespachadorToolStripMenuItem.Name = "AgregarDespachadorToolStripMenuItem"
        Me.AgregarDespachadorToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AgregarDespachadorToolStripMenuItem.Text = "Agregar Despachador"
        '
        'AdministrarDespachadorToolStripMenuItem
        '
        Me.AdministrarDespachadorToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.AdministrarDespachadorToolStripMenuItem.Name = "AdministrarDespachadorToolStripMenuItem"
        Me.AdministrarDespachadorToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AdministrarDespachadorToolStripMenuItem.Text = "Administrar Despachador"
        '
        'LocalesToolStripMenuItem
        '
        Me.LocalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearLocalToolStripMenuItem, Me.AdministrarLocalesToolStripMenuItem})
        Me.LocalesToolStripMenuItem.Name = "LocalesToolStripMenuItem"
        Me.LocalesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.LocalesToolStripMenuItem.Text = "Locales"
        '
        'CrearLocalToolStripMenuItem
        '
        Me.CrearLocalToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.CrearLocalToolStripMenuItem.Name = "CrearLocalToolStripMenuItem"
        Me.CrearLocalToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CrearLocalToolStripMenuItem.Text = "Crear Local"
        '
        'AdministrarLocalesToolStripMenuItem
        '
        Me.AdministrarLocalesToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.AdministrarLocalesToolStripMenuItem.Name = "AdministrarLocalesToolStripMenuItem"
        Me.AdministrarLocalesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AdministrarLocalesToolStripMenuItem.Text = "Administrar Locales"
        '
        'administrador_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.administrador_menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.administrador_menu
        Me.MaximizeBox = False
        Me.Name = "administrador_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.administrador_menu.ResumeLayout(False)
        Me.administrador_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents administrador_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents PedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EgresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarCategoríaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearCategoríaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarCategoríaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarPersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearPersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarPersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarCargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearCargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarCargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearLocalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarLocalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarDespachadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarDespachadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IVAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
