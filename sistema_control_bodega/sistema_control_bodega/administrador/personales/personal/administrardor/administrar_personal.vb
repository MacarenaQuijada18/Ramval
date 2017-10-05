
Public Class administrarpersonal_form
    'variables a utilizar
    Dim id_usuario As String
    Dim cargoid As String

    Private Sub administrar_personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()
        ActualizarBox()
    End Sub

    Private Sub personal_grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles personal_grid.CellClick
        Try
            'personal seleccionado

            'id_personal(0)
            'id_cargo (1)
            'nombre_personal (2)
            'nombre_cargo (3)
            'apellido_personal (4)
            'direccion_personal(5)
            'telefono_personal (6)
            'celular_personal (7)
            'cambiar_contraseña (8)
            'modificar (9)
            'eliminar (10)

            cargo_box.Enabled = False
            nombre_text.Enabled = False
            apellido_text.Enabled = False
            direccion_text.Enabled = False
            telefono_text.Enabled = False
            celular_text.Enabled = False
            ok_button.Visible = False

            nombre_text.Text = personal_grid(2, e.RowIndex).Value.ToString
            apellido_text.Text = personal_grid(3, e.RowIndex).Value.ToString
            cargo_box.SelectedItem = personal_grid(4, e.RowIndex).Value.ToString
            direccion_text.Text = personal_grid(5, e.RowIndex).Value.ToString
            telefono_text.Text = personal_grid(6, e.RowIndex).Value.ToString
            celular_text.Text = personal_grid(7, e.RowIndex).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub personal_grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles personal_grid.CellContentClick
        Try
            'Cambiar Contraseña
            If e.ColumnIndex = 8 Then
                id_usuario_global = personal_grid(0, e.RowIndex).Value.ToString
                cambiarpassword_form.Visible = True
            End If

            'Modificar datos
            If e.ColumnIndex = 9 Then
                id_usuario_global = personal_grid(0, e.RowIndex).Value.ToString
                cargo_box.Enabled = True
                nombre_text.Enabled = True
                apellido_text.Enabled = True
                direccion_text.Enabled = True
                telefono_text.Enabled = True
                celular_text.Enabled = True
                ok_button.Visible = True
            End If

            'Eliminar Datos
            If e.ColumnIndex = 10 Then
                id_usuario_global = personal_grid(0, e.RowIndex).Value.ToString
                Dim pregunta As MsgBoxResult
                pregunta = MsgBox("¿Esta seguro que desea eliminarlo?", MsgBoxStyle.YesNo, "Alerta")
                If pregunta = MsgBoxResult.Yes Then
                    SQLQuery("UPDATE personal SET  estado_personal = 'inactivo' WHERE id_personal = " + id_usuario_global + "", False)
                    CerrarConexion()
                    MsgBox("Se ha eliminado a " + personal_grid(2, e.RowIndex).Value.ToString + " " + personal_grid(3, e.RowIndex).Value.ToString)
                    cargo_box.SelectedIndex = 0
                    nombre_text.Text = ""
                    apellido_text.Text = ""
                    direccion_text.Text = ""
                    telefono_text.Text = ""
                    celular_text.Text = ""
                    id_usuario_global = ""
                    ActualizarGrid()
                    ActualizarBox()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ok_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_button.Click
        'verificar llenar todos los campos para poder editar
        If cargo_box.Text = "" Or nombre_text.Text = "" Then
            MsgBox("Debe llenar todos los cuadros necesarios")
        Else
            'tomar id del cargo
            SQLQuery("SELECT id_cargo FROM cargo WHERE nombre_cargo= '" + cargo_box.SelectedItem.ToString + "'", True)
            lector.Read()
            If lector.HasRows Then
                cargoid = lector.Item("id_cargo")
                CerrarConexion()
            End If

            SQLQuery("UPDATE personal SET id_cargo = " + cargoid + ", nombre_personal = '" + nombre_text.Text + "', apellido_personal='" + apellido_text.Text + "', direccion_personal='" + direccion_text.Text + "', telefono_personal='" + telefono_text.Text + "', celular_personal='" + celular_text.Text + "' WHERE id_personal = " + id_usuario_global, False)
            CerrarConexion()
            MsgBox("Los Datos se han modificado con exito")

            cargo_box.Enabled = False
            nombre_text.Enabled = False
            apellido_text.Enabled = False
            direccion_text.Enabled = False
            telefono_text.Enabled = False
            celular_text.Enabled = False
            ok_button.Visible = False
            id_usuario_global = ""
            cargoid = ""

            ActualizarBox()
            ActualizarGrid()
        End If
    End Sub

    Private Sub ActualizarGrid()
        personal_grid.Rows.Clear()
        SQLQuery("SELECT personal.id_personal, personal.id_cargo, personal.nombre_personal, personal.apellido_personal, cargo.nombre_cargo, personal.direccion_personal, personal.telefono_personal, personal.celular_personal FROM personal, cargo WHERE personal.id_cargo=cargo.id_cargo AND estado_personal='activo' ORDER BY nombre_personal", True)
        While lector.Read
            personal_grid.Rows.Add(lector.Item("id_personal"), lector.Item("id_cargo"), lector.Item("nombre_personal"), lector.Item("apellido_personal"), lector.Item("nombre_cargo"), lector.Item("direccion_personal"), lector.Item("telefono_personal"), lector.Item("celular_personal"), "Cambiar Contraseña", "Modificar", "Eliminar")
        End While
        CerrarConexion()
    End Sub

    Private Sub ActualizarBox()
        cargo_box.Items.Clear()
        SQLQuery("SELECT nombre_cargo FROM cargo ORDER BY nombre_cargo", True)
        While lector.Read
            cargo_box.Items.Add(lector.Item("nombre_cargo"))
        End While
        CerrarConexion()
    End Sub

End Class