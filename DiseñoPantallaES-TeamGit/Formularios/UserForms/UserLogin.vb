Public Class UserLogin

    Public Overloads Sub CloseAll()
        Me.Hide()
        MainWindow.Show()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs)
        Me.Hide()
        UserAttendance.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.CloseAll()
    End Sub

    Private Sub UserLogin_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.CloseAll()
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        UserAttendance.Show()
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class