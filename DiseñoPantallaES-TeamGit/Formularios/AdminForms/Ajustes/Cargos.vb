Public Class Cargos

    Dim BDCargo As New BDSistemaEySDataSetTableAdapters.CargoTableAdapter
    Dim bindingSource As New BindingSource
    Public selectedID As Integer = -1

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub

    Private Sub Cargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Cargo' table. You can move, or remove it, as needed.
        Me.CargoTableAdapter.Fill(Me.BDSistemaEySDataSet.Cargo)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles AñadirBtn.Click

        Try
            BDCargo.InsertCargo(nombreTxt.Text, descripcionTxt.Text)
            MsgBox("Guardado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

        Me.UpdateData()

    End Sub

    Public Sub UpdateData()
        Me.DataGridView1.DataSource = Me.bindingSource
        Me.bindingSource.DataSource = BDCargo.GetData()
    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        If Me.selectedID < 0 Then
            MessageBox.Show("Seleccione un cargo",
                        "Cargo no seleccionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk)
            Return
        End If

        Dim res = MessageBox.Show("¿Desea eliminar el cargo?",
                        "Eliminar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
        If res <> DialogResult.Yes Then
            Return
        End If
        Try
            BDCargo.DeleteCargo(Me.selectedID)
        Catch ex As Exception
            MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
        Me.UpdateData()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'Dim data As BDSistemaEySDataSet.CargoDataTable = Me.bindingSource.DataSource
        If (e.RowIndex < 0) Then
            Return
        End If

        Dim filas As Integer = DataGridView1.CurrentRow.Index
        Me.selectedID = DataGridView1.Item(0, filas).Value
        Me.nombreTxt.Text = DataGridView1.Item(1, filas).Value
        Me.descripcionTxt.Text = DataGridView1.Item(2, filas).Value

    End Sub

    Private Sub nuevoBtn_Click(sender As Object, e As EventArgs) Handles nuevoBtn.Click

        nombreTxt.Text = ""
        descripcionTxt.Text = ""

    End Sub

    Private Sub EditarBtn_Click(sender As Object, e As EventArgs) Handles EditarBtn.Click

        If Me.selectedID < 0 Then
            MessageBox.Show("Seleccione un cargo",
                        "Cargo no seleccionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk)
            Return
        End If

        If String.IsNullOrWhiteSpace(nombreTxt.Text) Or String.IsNullOrWhiteSpace(descripcionTxt.Text) Then
            MessageBox.Show(
                "No puede haber datos vacios",
                "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Return
        End If

        Try
            BDCargo.UpdateCargo(nombreTxt.Text, descripcionTxt.Text, Me.selectedID)
            MsgBox("Editado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

        Me.UpdateData()
    End Sub
End Class