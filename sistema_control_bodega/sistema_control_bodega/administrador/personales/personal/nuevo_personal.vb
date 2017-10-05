Public Class nuevopersonal_form

    Dim id_cargo As String

    Private Sub agregarpersonal_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Actualizar Box de Cargo
        ActualizarBox()
    End Sub

    Private Sub agregar_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar_button.Click
        'verificar que todos los campos tengan datos
        If cargo_box.Text = "" Or nombre_text.Text = "" Or clave_text.Text = "" Then
            MsgBox("Debe llenar todos los cuadros necesarios", MsgBoxStyle.OkOnly, "Alerta!")
        Else
            'verificar que la contraseña esté disponible
            SQLQuery("SELECT id_personal FROM personal WHERE pass_personal = '" + clave_text.Text + "' AND estado_personal='activo'", True)
            lector.Read()
            If lector.HasRows Then
                MsgBox("La clave no está disponible", MsgBoxStyle.OkOnly, "Alerta!")
                CerrarConexion()
            Else
                CerrarConexion()
                SQLQuery("INSERT INTO personal (id_cargo, nombre_personal, apellido_personal, pass_personal, direccion_personal, telefono_personal, celular_personal, estado_personal) VALUES (" + id_cargo + ", '" + nombre_text.Text + "', '" + apellido_text.Text + "', '" + clave_text.Text + "', '" + direccion_text.Text + "', '" + telefono_text.Text + "', '" + celular_text.Text + "', 'activo')", False)
                CerrarConexion()
                MsgBox("Se agrego ha " + nombre_text.Text + " " + apellido_text.Text, MsgBoxStyle.OkOnly, "Aviso")
                VaciarCampos()
                ActualizarBox()
            End If
        End If
    End Sub

    Private Sub cargo_box_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cargo_box.SelectedIndexChanged
        'Tomar id de cargo
        SQLQuery("SELECT id_cargo FROM cargo WHERE nombre_cargo= '" + cargo_box.Text + "'", True)
        lector.Read()
        If lector.HasRows Then
            id_cargo = lector.Item("id_cargo")
        End If
        CerrarConexion()
    End Sub

    Private Sub cancelar_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ActualizarBox()
        cargo_box.Items.Clear()
        SQLQuery("SELECT nombre_cargo FROM cargo WHERE estado_cargo='activo' ORDER BY nombre_cargo", True)
        While lector.Read
            cargo_box.Items.Add(lector.Item("nombre_cargo"))
        End While
        CerrarConexion()
    End Sub

    Private Sub VaciarCampos()
        cargo_box.SelectedItem = ""
        nombre_text.Text = ""
        apellido_text.Text = ""
        direccion_text.Text = ""
        telefono_text.Text = ""
        celular_text.Text = ""
        clave_text.Text = ""
    End Sub
End Class