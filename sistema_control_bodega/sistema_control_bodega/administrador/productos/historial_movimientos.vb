Public Class historialmovimiento_form

    Private Sub historialmovimiento_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
    End Sub

    Public Sub CargarGrid()
        historial_grid.Rows.Clear()
        SQLQuery("SELECT movimiento_stock.*, producto.nombre_producto FROM movimiento_stock INNER JOIN producto ON movimiento_stock.id_producto = producto.id_producto", True)
        If lector.HasRows Then
            While lector.Read
                historial_grid.Rows.Add(lector.Item("id_movimiento_stock"), lector.Item("fecha_movimiento").ToString.Substring(0, 10), lector.Item("n_documento"), lector.Item("nombre_producto"), lector.Item("tipo_movimiento"), lector.Item("stock_inicial"), lector.Item("stock_documento"), lector.Item("stock_final"))
            End While
        End If
    End Sub

    Private Sub ver_button_Click(sender As Object, e As EventArgs) Handles ver_button.Click
        historial_grid.Rows.Clear()


        If tipo_combo.Text = "" Or tipo_combo.Text = "Todo" Then
            SQLQuery("SELECT movimiento_stock.*, producto.nombre_producto FROM movimiento_stock INNER JOIN producto ON movimiento_stock.id_producto = producto.id_producto WHERE fecha_movimiento BETWEEN '" & inicio_date.Value.Year.ToString & "-" & inicio_date.Value.Month.ToString & "-" & inicio_date.Value.Day.ToString & "' AND '" & termino_date.Value.Year.ToString & "-" & termino_date.Value.Month.ToString & "-" & termino_date.Value.Day.ToString & "'", True)
        Else
            SQLQuery("SELECT movimiento_stock.*, producto.nombre_producto FROM movimiento_stock INNER JOIN producto ON movimiento_stock.id_producto = producto.id_producto WHERE tipo_movimiento = '" & tipo_combo.Text & "' AND fecha_movimiento BETWEEN '" & inicio_date.Value.Year.ToString & "-" & inicio_date.Value.Month.ToString & "-" & inicio_date.Value.Day.ToString & "' AND '" & termino_date.Value.Year.ToString & "-" & termino_date.Value.Month.ToString & "-" & termino_date.Value.Day.ToString & "'", True)
        End If
        If lector.HasRows Then
            While lector.Read
                historial_grid.Rows.Add(lector.Item("id_movimiento_stock"), lector.Item("fecha_movimiento").ToString.Substring(0, 10), lector.Item("n_documento"), lector.Item("nombre_producto"), lector.Item("tipo_movimiento"), lector.Item("stock_inicial"), lector.Item("stock_documento"), lector.Item("stock_final"))
            End While
        End If
    End Sub

End Class