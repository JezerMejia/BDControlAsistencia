

Public Class UserAttendance

    Dim myClock As New clock

    Public Sub CloseAll()
        Me.Hide()
        UserLogin.Show()
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

    Private Sub UserAttendance_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.CloseAll()
    End Sub
End Class