Public Class administrador_form
    Private Sub CrearProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearProductoToolStripMenuItem.Click
        'Abrir formulario dentro del administrador
        nuevoproducto_form.MdiParent = Me
        nuevoproducto_form.Visible = True
    End Sub

    Private Sub AdministrarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarProductoToolStripMenuItem.Click
        'Abrir formulario dentro del administrador
        administrarproductos_form.MdiParent = Me
        administrarproductos_form.Visible = True
    End Sub

    Private Sub AdministrarCategoríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarCategoríaToolStripMenuItem.Click
        'Abrir formulario dentro del administrador
        administrarcategoria_form.MdiParent = Me
        administrarcategoria_form.Visible = True
    End Sub

    Private Sub HistorialDeMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Abrir formulario dentro del administrador
        historialmovimiento_form.MdiParent = Me
        historialmovimiento_form.Visible = True
    End Sub


    Private Sub CrearCategoríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearCategoríaToolStripMenuItem.Click
        'Abrir formulario dentro del administrador
        crearcategoria_form.MdiParent = Me
        crearcategoria_form.Visible = True
    End Sub

    Private Sub administrador_form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'abrir login
        login_form.Visible = True
    End Sub

    Private Sub GestionarStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarStockToolStripMenuItem.Click
        'Abrir historial movimiento
        historialmovimiento_form.MdiParent = Me
        historialmovimiento_form.Visible = True
    End Sub

End Class