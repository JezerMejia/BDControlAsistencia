Imports DiseñoPantallaES_TeamGit.CalendarioFSol

Public Class AddDialogSolVac

    Dim BDSolVacaciones As New BDSistemaEySDataSetTableAdapters.SolVacacionesTableAdapter

    Private Sub AddDialogSolVac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BDSistemaEySDataSet.Empleado)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CalendarFS.Click
        CalendarioFSol.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CalendarioFIni.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CalendarioFSal.Show()
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        Dim idEmp As Integer = Convert.ToInt32(idEmpTxt.Text)

        If String.IsNullOrWhiteSpace(fechsolTxt.Text) Or String.IsNullOrWhiteSpace(descripcion.Text) Or String.IsNullOrWhiteSpace(fechIni.Text) Or String.IsNullOrWhiteSpace(fechFin.Text) Then
            MessageBox.Show(
                "No puede haber datos vacios",
                "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Return
        End If

        Try
            BDSolVacaciones.InsertSolVacacion(Convert.ToDateTime(fechsolTxt.Text), descripcion.Text, Convert.ToDateTime(fechIni.Text), Convert.ToDateTime(fechFin.Text), idEmp)
            MsgBox("Guardado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

        EmpleadoForm.UpdateData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class