Public Class administrarproductos_form

    'variables a utilizar
    Dim idproducto As String
    Dim categoriaid As String

    Private Sub administrarproductos_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrid()
        ActualizarBox()
    End Sub

    Private Sub ActualizarGrid()
        producto_grid.Rows.Clear()
        SQLQuery("SELECT producto.id_producto, producto.id_categoria, producto.nombre_producto, producto.precio_producto, categoria.nombre_categoria, stock_producto FROM producto, categoria WHERE producto.id_categoria = categoria.id_categoria AND estado_producto = 'activo' ORDER BY nombre_producto", True)
        While lector.Read
            producto_grid.Rows.Add(lector.Item("id_producto"), lector.Item("id_categoria"), lector.Item("nombre_producto"), lector.Item("precio_producto"), lector.Item("nombre_categoria"), lector.Item("stock_producto"), "Modificar", "Eliminar")
        End While
        CerrarConexion()
    End Sub

    Private Sub ActualizarBox()
        categoria_combo.Items.Clear()
        SQLQuery("SELECT nombre_categoria FROM categoria ORDER BY nombre_categoria", True)
        While lector.Read
            categoria_combo.Items.Add(lector.Item("nombre_categoria"))
        End While
        CerrarConexion()
    End Sub

    Private Sub producto_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles producto_grid.CellClick
        Try
            'producto seleccionado

            'id_producto (0)
            'id_categoria (1)
            'nombre_producto (2)
            'precio_producto (3)
            'categoria_producto (4)
            'modificar_producto (5)
            'eliminar_producto (6)

            categoria_combo.Enabled = False
            nombre_text.Enabled = False
            precio_text.Enabled = False
            NumericUpDown1.Enabled = False
            ok_button.Visible = False

            nombre_text.Text = producto_grid(2, e.RowIndex).Value.ToString
            precio_text.Text = producto_grid(3, e.RowIndex).Value.ToString
            categoria_combo.SelectedItem = producto_grid(4, e.RowIndex).Value.ToString
            NumericUpDown1.Value = producto_grid(5, e.RowIndex).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub producto_grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles producto_grid.CellContentClick
        Try

            'Modificar datos
            If e.ColumnIndex = 6 Then
                id_producto_global = producto_grid(0, e.RowIndex).Value.ToString
                categoria_combo.Enabled = True
                nombre_text.Enabled = True
                precio_text.Enabled = True
                NumericUpDown1.Enabled = True
                ok_button.Visible = True
            End If

            'Eliminar Datos
            If e.ColumnIndex = 7 Then
                id_producto_global = producto_grid(0, e.RowIndex).Value.ToString
                Dim pregunta As MsgBoxResult
                pregunta = MsgBox("¿Esta seguro que desea eliminarlo?", MsgBoxStyle.YesNo, "Alerta")
                If pregunta = MsgBoxResult.Yes Then
                    SQLQuery("UPDATE producto SET  estado_producto = 'inactivo' WHERE id_producto = " + id_producto_global + "", False)
                    CerrarConexion()
                    MsgBox("Se ha eliminado el producto " + producto_grid(2, e.RowIndex).Value.ToString + ".")
                    categoria_combo.SelectedIndex = 0
                    nombre_text.Text = ""
                    precio_text.Text = ""
                    id_producto_global = ""
                    ActualizarGrid()
                    ActualizarBox()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ok_button_Click(sender As Object, e As EventArgs) Handles ok_button.Click
        'verificar llenar todos los campos para poder editar
        If categoria_combo.Text = "" Or nombre_text.Text = "" Then
            MsgBox("Debe llenar todos los cuadros necesarios")
        Else
            'tomar id del cargo
            SQLQuery("SELECT id_categoria FROM categoria WHERE nombre_categoria = '" + categoria_combo.SelectedItem.ToString + "'", True)
            lector.Read()
            If lector.HasRows Then
                categoriaid = lector.Item("id_categoria")
                CerrarConexion()
            End If

            SQLQuery("UPDATE producto SET id_categoria = " + categoriaid + ", nombre_producto = '" + nombre_text.Text + "', precio_producto ='" + precio_text.Text + "', stock_producto = " & NumericUpDown1.Value.ToString & " WHERE id_producto = " + id_producto_global, False)
            CerrarConexion()
            MsgBox("Los datos se han modificado con exito.")

            categoria_combo.Enabled = False
            nombre_text.Enabled = False
            precio_text.Enabled = False
            ok_button.Visible = False
            id_producto_global = ""
            categoriaid = ""

            ActualizarBox()
            ActualizarGrid()
        End If
    End Sub
End Class