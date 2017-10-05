Public Class cambiarpassword_form

    Dim nombre_personal As String
    Dim pass_actual As String

    Private Sub cambiarpassword_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLQuery("SELECT nombre_personal, apellido_personal FROM personal WHERE id_personal = " + id_usuario_global, True)
        lector.Read()
        'tomar nombre del personal
        If lector.HasRows Then
            nombre_personal = lector.Item("nombre_personal") + " " + lector.Item("apellido_personal")
        End If
        CerrarConexion()
    End Sub

    Private Sub ok_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_button.Click
        'verificar que la clave estè dispnible
        SQLQuery("SELECT id_personal FROM personal WHERE pass_personal = '" + newpass_text.Text + "' AND estado_personal='activo'", True)
        lector.Read()
        If lector.HasRows Then
            MsgBox("La clave no está disponible")
            CerrarConexion()
        Else
            CerrarConexion()
            'Se cambia la contraseña antigua por la nueva contraseña
            SQLQuery("UPDATE personal SET pass_personal = '" + newpass_text.Text + "' WHERE id_personal= " + id_usuario_global, False)
            CerrarConexion()
            MsgBox("Se ha cambiado la clave de " + nombre_personal + " con exito!!")
            newpass_text.Text = ""
            id_usuario_global = ""
            Me.Close()
        End If
    End Sub
End Class