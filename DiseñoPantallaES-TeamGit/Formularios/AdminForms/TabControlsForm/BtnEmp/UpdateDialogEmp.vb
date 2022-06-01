Public Class UpdateDialogEmp

    Public selectedID As Integer = -1
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub UpdateDialogEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Departamento' table. You can move, or remove it, as needed.
        Me.DepartamentoTableAdapter.Fill(Me.BDSistemaEySDataSet.Departamento)
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Cargo' table. You can move, or remove it, as needed.
        Me.CargoTableAdapter.Fill(Me.BDSistemaEySDataSet.Cargo)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class