Public Class AdminLogin
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        MainWindow.Show()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Me.Hide()
        controlCenter.Show()
    End Sub

    Private Sub AdminLogin_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        MainWindow.Close()
    End Sub
End Class