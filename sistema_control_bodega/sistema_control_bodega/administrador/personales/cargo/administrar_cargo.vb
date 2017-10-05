Public Class administrarcargo_form

    'variables a ocupar
    Dim id_cargoactual As String

    Private Sub administrarcargo_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()
    End Sub

    Private Sub cargo_grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles cargo_grid.CellClick
        Try
            'cargar cuadro
            cargo_text.Text = cargo_grid(1, e.RowIndex).Value.ToString
            cargo_text.Enabled = False
            ok_button.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cargo_grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles cargo_grid.CellContentClick
        Try
            'Modificar Cargo
            If e.ColumnIndex = 2 Then
                id_cargoactual = cargo_grid(0, e.RowIndex).Value.ToString
                cargo_text.Enabled = True
                ok_button.Visible = True
            End If

            'Eliminar Cargo
            If e.ColumnIndex = 3 Then
                id_cargoactual = cargo_grid(0, e.RowIndex).Value.ToString
                Dim pregunta As MsgBoxResult
                pregunta = MsgBox("¿Esta seguro que desea eliminar este cargo?", MsgBoxStyle.YesNo, "Alerta")
                If pregunta = MsgBoxResult.Yes Then
                    SQLQuery("UPDATE cargo SET estado_cargo = 'inactivo' WHERE id_cargo = " + id_cargoactual + "", False)
                    CerrarConexion()
                    MsgBox("Se ha eliminado el cargo de " + cargo_grid(1, e.RowIndex).Value.ToString)
                    cargo_text.Text = ""
                    ActualizarGrid()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ok_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_button.Click
        'confirmar modificación
        If cargo_text.Text = "" Then
            MsgBox("Ingrese nombre de cargo")
        Else
            SQLQuery("UPDATE cargo SET nombre_cargo = '" + cargo_text.Text + "' WHERE id_cargo = " + id_cargoactual + "", False)
            CerrarConexion()
            MsgBox("Se ha modificado el cargo")
            cargo_text.Text = ""
            cargo_text.Enabled = False
            ok_button.Visible = False
            ActualizarGrid()
        End If
    End Sub

    Private Sub ActualizarGrid()
        cargo_grid.Rows.Clear()
        'Selecciona los cargos disponibles
        SQLQuery("SELECT * FROM cargo WHERE estado_cargo='activo' ORDER BY nombre_cargo", True)
        While lector.Read
            cargo_grid.Rows.Add(lector.Item("id_cargo"), lector.Item("nombre_cargo"), "Modificar", "Eliminar")
        End While
        CerrarConexion()
    End Sub
End Class