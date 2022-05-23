Imports System.Drawing
Imports System.Windows.Forms

Public Class controlCenter
    Dim asist As New BDSistemaEySDataSetTableAdapters.AsistenciaTableAdapter
    Dim carg As New BDSistemaEySDataSetTableAdapters.CargoTableAdapter
    Dim emp As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter
    Dim dep As New BDSistemaEySDataSetTableAdapters.DepartamentoTableAdapter
    Dim vac As New BDSistemaEySDataSetTableAdapters.SolVacacionesTableAdapter

    Dim tblasist As New BDSistemaEySDataSet.AsistenciaDataTable
    Dim tblcarg As New BDSistemaEySDataSet.CargoDataTable
    Dim tblemp As New BDSistemaEySDataSet.EmpleadoDataTable
    Dim tbldep As New BDSistemaEySDataSet.DepartamentoDataTable
    Dim tblvac As New BDSistemaEySDataSet.SolVacacionesDataTable
    Public Sub CloseAll()
        Me.Hide()
        AdminLogin.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.CloseAll()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub HorariosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim page = New TabPage("Empleados")
        Dim empForm = New EmpleadoForm With {.TopMost = False, .TopLevel = False, .FormBorderStyle = FormBorderStyle.None, .Dock = DockStyle.Fill}

        empForm.Show()
        page.Controls.Add(empForm)

        TabControl1.TabPages.Add(page)
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

            If (e.Index <> 0) Then
                Dim closeImage = New Bitmap(Application.StartupPath.Replace("bin\Debug", "") & "\Resources\borrar.png")
                e.Graphics.DrawImage(closeImage, Convert.ToInt32((tabRect.Right - closeImage.Width)), Convert.ToInt32(tabRect.Top + (tabRect.Height - closeImage.Height) / 2))
            End If
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

    Private Sub ControlCenter_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        MainWindow.Close()
    End Sub

    Private Sub EntradaSalidaToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HorariosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HorariosToolStripMenuItem.Click
        Dim page = New TabPage("Horarios")
        Dim horarioForm = New HorarioForm With {.TopMost = False, .TopLevel = False, .FormBorderStyle = FormBorderStyle.None, .Dock = DockStyle.Fill}

        horarioForm.Show()
        page.Controls.Add(horarioForm)

        TabControl1.TabPages.Add(page)
    End Sub

    Private Sub EntradaSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaSalidaToolStripMenuItem.Click
        Dim page = New TabPage("Entrada Salida")
        Dim EntraySal = New EntradaSalida With {.TopMost = False, .TopLevel = False, .FormBorderStyle = FormBorderStyle.None, .Dock = DockStyle.Fill}

        EntraySal.Show()
        page.Controls.Add(EntraySal)

        TabControl1.TabPages.Add(page)
    End Sub

    Private Sub SolicitudDeVacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudDeVacacionesToolStripMenuItem.Click
        Dim page = New TabPage("Solicitd de vacaciones")
        Dim solVac = New SolVacacionesForm With {.TopMost = False, .TopLevel = False, .FormBorderStyle = FormBorderStyle.None, .Dock = DockStyle.Fill}

        solVac.Show()
        page.Controls.Add(solVac)

        TabControl1.TabPages.Add(page)
    End Sub

    Private Sub AsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsistenciaToolStripMenuItem.Click
        asist.Fill(tblasist)
        VerReporteAsist(tblasist, "DataSetAsistencia", ".\Reportes\RptAsistenciaEmp.rdlc")

    End Sub

    Private Sub CargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem.Click
        carg.Fill(tblcarg)
        VerReporteCargo(tblcarg, "DataSetCargos", ".\Reportes\RptCargos.rdlc")

    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        emp.Fill(tblemp)
        VerReporteEmp(tblemp, "DataSetEmp", ".\Reportes\RptEmpleado.rdlc")

    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click
        dep.Fill(tbldep)
        VerReporteDep(tblemp, "DataSetDep", ".\Reportes\RptDepartamento.rdlc")

    End Sub

    Private Sub VacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacacionesToolStripMenuItem.Click
        vac.Fill(tblvac)
        VerReporteVacaciones(tblvac, "DataSetSolVac", ".\Reportes\RptVacaciones.rdlc")
    End Sub
End Class