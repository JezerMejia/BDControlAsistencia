﻿Public Class SolVacacionesForm
    Private Sub SolVacacionesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.SolVacaciones' table. You can move, or remove it, as needed.
        Me.SolVacacionesTableAdapter.Fill(Me.BDSistemaEySDataSet.SolVacaciones)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddDialogSolVac.Show()
    End Sub
End Class