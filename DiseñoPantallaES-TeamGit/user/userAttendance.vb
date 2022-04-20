

Public Class asistencia

    Dim myClock As New Clock

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        userLogin.Show()

    End Sub

    Private Sub time_Click(sender As Object, e As EventArgs) Handles timeSystem.Click

    End Sub

    Private Sub timeNow_Tick(sender As Object, e As EventArgs) Handles timeNow.Tick
        timeSystem.Text = DateTime.Now.ToString("HH:mm:ss")
        myClock.BuildAnalogClock(Me.PictureBox1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Asistencia exitosa", "Registro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        login.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Asistencia exitosa", "Registro de salida", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        login.Show()
    End Sub
End Class