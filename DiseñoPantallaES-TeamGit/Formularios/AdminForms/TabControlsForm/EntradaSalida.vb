Public Class EntradaSalida
    Dim BDAsistencia As New BDSistemaEySDataSetTableAdapters.AsistenciaTableAdapter
    Private Sub EntradaSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Asistencia' table. You can move, or remove it, as needed.
        Me.AsistenciaTableAdapter.Fill(Me.BDSistemaEySDataSet.Asistencia)
        Me.DataGridView1.DataSource = BDAsistencia.GetData()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Me.AsistenciaTableAdapter.Fill(Me.BDSistemaEySDataSet.Asistencia)
        Me.DataGridView1.DataSource = BDAsistencia.GetData()
    End Sub
End Class