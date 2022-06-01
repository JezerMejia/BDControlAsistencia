Public Class CalendarioFIni
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        AddDialogSolVac.fechIni.Text = MonthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy")
    End Sub
End Class