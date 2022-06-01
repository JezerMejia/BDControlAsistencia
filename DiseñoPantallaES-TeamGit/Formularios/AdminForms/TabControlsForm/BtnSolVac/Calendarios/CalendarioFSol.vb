Public Class CalendarioFSol

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        AddDialogSolVac.fechsolTxt.Text = MonthCalendar1.SelectionRange.Start.ToString("dd-MM-yyyy")
    End Sub

End Class