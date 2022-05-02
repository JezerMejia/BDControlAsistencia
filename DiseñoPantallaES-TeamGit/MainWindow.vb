Public Class MainWindow
    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        Me.Hide()
        UserLogin.Show()
    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        Me.Hide()
        adminLogin.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
