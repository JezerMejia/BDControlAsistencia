Public Class AddDialogSolVac

    Dim BDEmpleado As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        Try
            BDEmpleado.GetData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddDialogSolVac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BDSistemaEySDataSet.Empleado)

    End Sub
End Class