Public Class controlCenter
    Private Sub ArchviosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchviosToolStripMenuItem.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HorasExtraToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HorasExtraToolStripMenuItem1.Click

    End Sub



    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
        adminLogin.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        timeNow.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeNow.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
End Class