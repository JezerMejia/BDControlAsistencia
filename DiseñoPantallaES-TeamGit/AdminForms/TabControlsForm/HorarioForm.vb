Public Class HorarioForm
    Private Sub HorarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Horario' table. You can move, or remove it, as needed.
        Me.HorarioTableAdapter.Fill(Me.BDSistemaEySDataSet.Horario)

    End Sub
End Class