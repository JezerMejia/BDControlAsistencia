Public Class Departamento
    Private Sub Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Departamento' table. You can move, or remove it, as needed.
        Me.DepartamentoTableAdapter.Fill(Me.BDSistemaEySDataSet.Departamento)

    End Sub
End Class