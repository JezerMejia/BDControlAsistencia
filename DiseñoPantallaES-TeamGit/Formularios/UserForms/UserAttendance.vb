
Public Class UserAttendance

    Dim Tiempo As DateTime


    Public Sub CloseAll()
        UserLogin.Close()
        MainWindow.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.CloseAll()
    End Sub

    Private Sub btnMarkEnter_Click(sender As Object, e As EventArgs) Handles btnMarkEnter.Click
        MessageBox.Show("Asistencia exitosa",
                        "Registro de entrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub btnMarkExit_Click(sender As Object, e As EventArgs) Handles btnMarkExit.Click
        MessageBox.Show("Asistencia exitosa",
                        "Registro de salida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbFecha.Text = DateTime.Now.ToLongDateString()
        Tiempo = Now.ToString("HH:mm:ss")
        lbHora.Text = Tiempo
    End Sub

    Private Sub UserAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class