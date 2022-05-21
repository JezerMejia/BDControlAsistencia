Public Class UserLogin

    Public Overloads Sub CloseAll()
        Me.Hide()
        MainWindow.Show()
    End Sub

    Private Sub UserLogin_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.CloseAll()
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Me.Hide()
        UserAttendance.Show()
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class