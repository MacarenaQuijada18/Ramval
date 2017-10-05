Public Class administradornuevo_form

    Dim gestion_actual As String
    Dim accion_actual As String

    Private Sub salir_button_Click(sender As Object, e As EventArgs) Handles salir_button.Click
        'abrir login
        login_form.Visible = True
        Me.Close()
    End Sub

    Private Sub administradornuevo_form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'abrir login
        login_form.Visible = True
    End Sub


    Private Sub productos_button_Click(sender As Object, e As EventArgs) Handles productos_button.Click
        accion_group.Visible = True
        accion_group.Text = "Productos"
        gestion_actual = "Productos"
        accionuno_button.BackgroundImage = sistema_control_bodega.My.Resources.producto
        accion2_button.BackgroundImage = sistema_control_bodega.My.Resources.categoria
        acciones_group.Visible = False
        acciones_group.Text = "Productos"
    End Sub

    'ingreso boton personal'
    Private Sub personales_button_Click(sender As Object, e As EventArgs) Handles personales_button.Click
        accion_group.Visible = True
        accion_group.Text = "Personales"
        gestion_actual = "Personales"
        accionuno_button.BackgroundImage = sistema_control_bodega.My.Resources.personales
        accion2_button.BackgroundImage = sistema_control_bodega.My.Resources.cargo
        acciones_group.Visible = False
        acciones_group.Text = "Personales"
    End Sub


    Private Sub accionuno_button_Click(sender As Object, e As EventArgs) Handles accionuno_button.Click

        If gestion_actual = "Personales" Then
            accion_actual = "Personal"
            acciones_group.Text = "Personal"
            acciones_group.Visible = True
        ElseIf gestion_actual = "Productos" Then
            accion_actual = "Producto"
            acciones_group.Text = "Producto"
            acciones_group.Visible = True
        Else
            MsgBox("Seleccione una acción", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub accion2_button_Click(sender As Object, e As EventArgs) Handles accion2_button.Click
        If gestion_actual = "Personales" Then
            accion_actual = "Cargo"
            acciones_group.Text = "Cargo"
            acciones_group.Visible = True
        ElseIf gestion_actual = "Productos" Then
            accion_actual = "Categoria"
            acciones_group.Text = "Categoria"
            acciones_group.Visible = True
        Else
            MsgBox("Seleccione una acción", MsgBoxStyle.Critical, "Error")
        End If
    End Sub



    Private Sub agregar_button_Click(sender As Object, e As EventArgs) Handles agregar_button.Click

        If accion_actual = "Producto" Then
            nuevoproducto_form.Visible = True
        ElseIf accion_actual = "Categoria" Then
            crearcategoria_form.Visible = True
        ElseIf accion_actual = "Cargo" Then
            nuevocargo_form.Visible = True
        ElseIf accion_actual = "Personal" Then
            nuevopersonal_form.Visible = True
        Else
            MsgBox("Seleccione una acción", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub administrar_button_Click(sender As Object, e As EventArgs) Handles administrar_button.Click

        If accion_actual = "Producto" Then
            administrarproductos_form.Visible = True
        ElseIf accion_actual = "Categoria" Then
            administrarcategoria_form.Visible = True
        ElseIf accion_actual = "Personal" Then
            administrarpersonal_form.Visible = True
        ElseIf accion_actual = "Cargo" Then
            administrarcargo_form.Visible = True
        Else
            MsgBox("Seleccione una acción", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub egreso_button_Click(sender As Object, e As EventArgs) Handles egreso_button.Click

    End Sub
End Class