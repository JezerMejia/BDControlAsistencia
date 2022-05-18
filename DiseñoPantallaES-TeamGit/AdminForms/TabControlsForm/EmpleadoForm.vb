Public Class EmpleadoForm

    Dim DBEmpleado As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub EmpleadoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Empleado' table. You can move, or remove it, as needed.
        'Me.EmpleadoTableAdapter.Fill(Me.BDSistemaEySDataSet.Empleado)'
        DataGridView1.DataSource = DBEmpleado.GetData()
    End Sub
End Class