Public Class nuevocargo_form

    Private Sub agregar_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar_button.Click
        If cargo_text.Text <> "" Then
            'comprobar que el cargo no exista
            SQLQuery("SELECT * FROM cargo WHERE nombre_cargo = '" + cargo_text.Text + "' AND estado_cargo='activo'", True)
            lector.Read()
            If Not lector.HasRows Then
                CerrarConexion()
                'se agregar el nuevo cargo
                SQLQuery("INSERT INTO cargo (nombre_cargo, estado_cargo) VALUES ('" + cargo_text.Text + "', 'activo')", False)
                CerrarConexion()
                MsgBox("Se ha agregado un nuevo cargo: " + cargo_text.Text)
            Else
                MsgBox(cargo_text.Text + " ya existe")
                CerrarConexion()
            End If
        Else
            MsgBox("Ingrese nombre del cargo nuevo")
        End If

        cargo_text.Text = ""
    End Sub
End Class