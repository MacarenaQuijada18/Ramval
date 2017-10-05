Public Class nuevoproducto_form

    Dim id_categoria As String

    Private Sub nuevoproducto_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizarcombo()
    End Sub

    Private Sub agregar_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar_button.Click
        'verificar que todos los campos tengan datos
        If nombre_text.Text = "" Or precio_text.Text = "" Or categoria_combo.Text = "" Then
            MsgBox("Debe llenar todos los cuadros necesarios", MsgBoxStyle.OkOnly, "Alerta!")
        Else
            'insertar datos
            SQLQuery("INSERT INTO producto (id_categoria, nombre_producto, precio_producto, stock_producto, estado_producto, Stock_min) VALUES (" + id_categoria + ", '" + nombre_text.Text + "', '" + precio_text.Text + "', " & stock_numeric.Value.ToString & ", 'activo', " & NumericUpDown1.Value.ToString & ")", False)
            CerrarConexion()
            MsgBox("Se agrego el producto " + nombre_text.Text + ".", MsgBoxStyle.OkOnly, "Aviso")
            VaciarCampos()
            Actualizarcombo()
        End If
    End Sub

    Private Sub categoria_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles categoria_combo.SelectedIndexChanged
        'Tomar id de categoria
        SQLQuery("SELECT id_categoria FROM categoria WHERE nombre_categoria = '" + categoria_combo.Text + "'", True)
        lector.Read()
        If lector.HasRows Then
            id_categoria = lector.Item("id_categoria")
        End If
        CerrarConexion()
    End Sub

    Private Sub cancelar_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Actualizarcombo()
        categoria_combo.Items.Clear()
        SQLQuery("SELECT nombre_categoria FROM categoria WHERE estado_categoria='activo' ORDER BY nombre_categoria", True)
        While lector.Read
            categoria_combo.Items.Add(lector.Item("nombre_categoria"))
        End While
        CerrarConexion()
    End Sub

    Private Sub VaciarCampos()
        categoria_combo.SelectedItem = ""
        nombre_text.Text = ""
        precio_text.Text = ""
    End Sub

    Private Sub stock_numeric_ValueChanged(sender As Object, e As EventArgs) Handles stock_numeric.ValueChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class