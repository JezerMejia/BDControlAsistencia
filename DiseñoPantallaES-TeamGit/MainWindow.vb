Public Class MainWindow
    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs)
        Me.Hide()
        UserLogin.Show()
    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs)
        Me.Hide()
        AdminLogin.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub


    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        AdminLogin.Show()
    End Sub

    Private Sub btnEmpleado_Click_1(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        UserLogin.Show()
    End Sub
End Class
