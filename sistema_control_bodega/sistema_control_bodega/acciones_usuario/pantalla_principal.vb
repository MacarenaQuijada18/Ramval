Public Class pantallaprincipal_form

    Private Sub pantallaprincipal_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'inicia reloj
        hora_timer.Start()

    End Sub

    Private Sub hora_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hora_timer.Tick
        'variables a utilizar
        Dim dia As String
        Dim mes As String
        Dim year As String
        Dim hora As String
        Dim minuto As String
        Dim segundo As String

        'toma fecha y hora del momento
        dia = Now.Day.ToString("D2")
        mes = Now.Month.ToString("D2")
        year = Now.Year.ToString("D2")
        hora = Now.Hour.ToString("D2")
        minuto = Now.Minute.ToString("D2")
        segundo = Now.Second.ToString("D2")

        'asigna fecha y hora a labels
        fecha_label.Text = year + "-" + mes + "-" + dia
        hora_label.Text = hora + ":" + minuto + ":" + segundo

    End Sub
    Private Sub pantallaprincipal_form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'abrir login
        login_form.Visible = True
    End Sub


End Class
