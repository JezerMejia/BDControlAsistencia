Public Class FrmReporteAsistencia
    Private Sub FrmReporteAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDSistemaEySDataSet.Asistencia' Puede moverla o quitarla según sea necesario.
        Me.AsistenciaTableAdapter.Fill(Me.BDSistemaEySDataSet.Asistencia)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class