Public Class EntradaSalida
    Private Sub EntradaSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Asistencia' table. You can move, or remove it, as needed.
        Me.AsistenciaTableAdapter.Fill(Me.BDSistemaEySDataSet.Asistencia)

    End Sub
End Class