Imports Microsoft.Reporting.WinForms

Module ConfigGlobal

    Sub VerReporteAsist(ByVal tbl As DataTable, ByVal nombreDs As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDs, tbl)
            With FrmReporteAsistencia
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al mostrar reporte")
        End Try

    End Sub
    Sub VerReporteCargo(ByVal tbl As DataTable, ByVal nombreDs As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDs, tbl)
            With FrmReporteCargo
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al mostrar reporte")
        End Try
    End Sub
    Sub VerReporteDep(ByVal tbl As DataTable, ByVal nombreDs As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDs, tbl)
            With FrmReporteDepartamento
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al mostrar reporte")
        End Try
    End Sub
    Sub VerReporteEmp(ByVal tbl As DataTable, ByVal nombreDs As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDs, tbl)
            With FrmReporteEmpleado
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al mostrar reporte")
        End Try
    End Sub
    Sub VerReporteVacaciones(ByVal tbl As DataTable, ByVal nombreDs As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDs, tbl)
            With FrmReporteEmpleado
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al mostrar reporte")
        End Try
    End Sub
End Module
