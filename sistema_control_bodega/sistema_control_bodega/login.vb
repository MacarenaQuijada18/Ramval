Public Class login_form

    Private Sub ingresar_button_Click(sender As Object, e As EventArgs) Handles ingresar_button.Click
        Ingresar()
    End Sub

    Private Sub password_text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password_text.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Ingresar()
        End If
    End Sub

    Private Sub Ingresar()
        If password_text.Text = "" Then
            MsgBox("Ingese su clave.", MsgBoxStyle.OkOnly, "Aviso")
        Else
            SQLQuery("SELECT id_personal, id_cargo FROM personal WHERE pass_personal = '" & password_text.Text & "'", True)
            If lector.HasRows Then
                lector.Read()

                id_usuario_global = lector.Item("id_personal")
                If lector.Item("id_cargo") = "1" Then
                    'abrir administrador
                    administradornuevo_form.Visible = True
                    administradornuevo_form.administrar_button.Visible = True
                    Me.Visible = False
                ElseIf lector.Item("id_cargo") = "3" Then

                    'abrir usuario
                    pantallaprincipal_form.Visible = True
                    Me.Visible = False

                ElseIf lector.Item("id_cargo") > 3 Then

                    MsgBox("El usuario no tiene permiso de acceso", MsgBoxStyle.Critical, "Aviso")
                End If
            Else

                MsgBox("La clave que ingreso es incorrecta.", MsgBoxStyle.Critical, "Aviso")
            End If
            CerrarConexion()
            password_text.Text = ""
        End If
    End Sub

    Private Sub password_text_TextChanged(sender As Object, e As EventArgs) Handles password_text.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class