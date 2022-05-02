Public Class UserLogin

    Public Overloads Sub CloseAll()
        Me.Hide()
        MainWindow.Show()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Me.Hide()
        UserAttendance.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.CloseAll()
    End Sub

    Private Sub UserLogin_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.CloseAll()
    End Sub
End Class