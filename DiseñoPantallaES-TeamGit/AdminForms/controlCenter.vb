Imports System.Drawing
Imports System.Windows.Forms

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

    Private Sub HorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorariosToolStripMenuItem.Click

    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim t As New TabPage("Empleado")
        Dim ls As New TabPage

        TabControl1.Controls.Add(t)

    End Sub

    Public Sub New()
        InitializeComponent()
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        TabControl1.SizeMode = TabSizeMode.Fixed
    End Sub

    Private Sub tabControl_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Try
            Dim tabPage = Me.TabControl1.TabPages(e.Index)
            Dim tabRect = Me.TabControl1.GetTabRect(e.Index)
            tabRect.Inflate(-2, -2)
            'Se invo'
            Dim closeImage = New Bitmap(Application.StartupPath.Replace("bin\Debug", "") & "\Resources\borrar.png")
            e.Graphics.DrawImage(closeImage, Convert.ToInt32((tabRect.Right - closeImage.Width)), Convert.ToInt32(tabRect.Top + (tabRect.Height - closeImage.Height) / 2))
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub tabControl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TabControl1.MouseDown
        Dim r As Rectangle = TabControl1.GetTabRect(Me.TabControl1.SelectedIndex)
        Dim closeButton As Rectangle = New Rectangle(r.Right - 15, r.Top + 4, 9, 7)

        If closeButton.Contains(e.Location) Then
            Me.TabControl1.TabPages.Remove(Me.TabControl1.SelectedTab)
        End If
    End Sub


End Class