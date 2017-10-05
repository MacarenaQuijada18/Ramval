Public Class crearcategoria_form

    Private Sub agregar_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar_button.Click
        If categoria_text.Text <> "" Then
            'comprobar que el categoria no exista
            SQLQuery("SELECT * FROM categoria WHERE nombre_categoria = '" + categoria_text.Text + "' AND estado_categoria='activo'", True)
            lector.Read()
            If Not lector.HasRows Then
                CerrarConexion()
                'se agregar el nuevo categoria
                SQLQuery("INSERT INTO categoria (nombre_categoria, estado_categoria) VALUES ('" + categoria_text.Text + "', 'activo')", False)
                CerrarConexion()
                MsgBox("Se ha agregado un nuevo categoria: " + categoria_text.Text)
            Else
                MsgBox(categoria_text.Text + " ya existe")
                CerrarConexion()
            End If
        Else
            MsgBox("Ingrese nombre del categoria nuevo")
        End If

        categoria_text.Text = ""
    End Sub
End Class