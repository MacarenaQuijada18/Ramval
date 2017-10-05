Public Class administrarcategoria_form
    Dim id_categoriaactual As String

    Private Sub administrarcategoria_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()
    End Sub

    Private Sub categoria_grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles categoria_grid.CellClick
        Try
            'cargar cuadro
            categoria_text.Text = categoria_grid(1, e.RowIndex).Value.ToString
            categoria_text.Enabled = False
            ok_button.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub categoria_grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles categoria_grid.CellContentClick
        Try
            'Modificar categoria
            If e.ColumnIndex = 2 Then
                id_categoriaactual = categoria_grid(0, e.RowIndex).Value.ToString
                categoria_text.Enabled = True
                ok_button.Visible = True
            End If

            'Eliminar categoria
            If e.ColumnIndex = 3 Then
                id_categoriaactual = categoria_grid(0, e.RowIndex).Value.ToString
                Dim pregunta As MsgBoxResult
                pregunta = MsgBox("¿Esta seguro que desea eliminar este categoria?", MsgBoxStyle.YesNo, "Alerta")
                If pregunta = MsgBoxResult.Yes Then
                    SQLQuery("UPDATE categoria SET estado_categoria = 'inactivo' WHERE id_categoria = " + id_categoriaactual + "", False)
                    CerrarConexion()
                    MsgBox("Se ha eliminado el categoria de " + categoria_grid(1, e.RowIndex).Value.ToString)
                    categoria_text.Text = ""
                    ActualizarGrid()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ok_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_button.Click
        'confirmar modificación
        If categoria_text.Text = "" Then
            MsgBox("Ingrese nombre de categoria")
        Else
            SQLQuery("UPDATE categoria SET nombre_categoria = '" + categoria_text.Text + "' WHERE id_categoria = " + id_categoriaactual + "", False)
            CerrarConexion()
            MsgBox("Se ha modificado el categoria")
            categoria_text.Text = ""
            categoria_text.Enabled = False
            ok_button.Visible = False
            ActualizarGrid()
        End If
    End Sub

    Private Sub ActualizarGrid()
        categoria_grid.Rows.Clear()
        'Selecciona los categorias disponibles
        SQLQuery("SELECT * FROM categoria WHERE estado_categoria='activo' ORDER BY nombre_categoria", True)
        While lector.Read
            categoria_grid.Rows.Add(lector.Item("id_categoria"), lector.Item("nombre_categoria"), "Modificar", "Eliminar")
        End While
        CerrarConexion()
    End Sub
End Class