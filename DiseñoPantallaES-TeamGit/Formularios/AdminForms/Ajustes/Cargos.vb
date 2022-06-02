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

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            If (String.IsNullOrWhiteSpace(TxtName.Text)) Then
                Throw New Exception("Ingrese un nombre")
            End If
            If (String.IsNullOrWhiteSpace(TxtDescription.Text)) Then
                Throw New Exception("Ingrese una descripción")
            End If
            BDCargo.InsertCargo(TxtName.Text, TxtDescription.Text)
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

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
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

        Dim filas As Integer = e.RowIndex
        Me.selectedID = DataGridView1.Item(0, filas).Value
        Me.TxtName.Text = DataGridView1.Item(1, filas).Value
        Me.TxtDescription.Text = DataGridView1.Item(2, filas).Value
    End Sub

    Private Sub BtnNew_Clicked(sender As Object, e As EventArgs) Handles BtnNew.Click
        TxtName.Text = ""
        TxtDescription.Text = ""
    End Sub

    Private Sub BtnEdit_Clicked(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Me.selectedID < 0 Then
            MessageBox.Show("Seleccione un cargo",
                        "Cargo no seleccionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk)
            Return
        End If

        Try
            If (String.IsNullOrWhiteSpace(TxtName.Text)) Then
                Throw New Exception("Ingrese un nombre")
            End If
            If (String.IsNullOrWhiteSpace(TxtDescription.Text)) Then
                Throw New Exception("Ingrese una descripción")
            End If
            BDCargo.UpdateCargo(
                TxtName.Text, TxtDescription.Text,
                Me.selectedID
                )
            MsgBox("Editado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

        Me.UpdateData()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Me.bindingSource.DataSource = BDCargo.GetData()
        If String.IsNullOrWhiteSpace(Me.TxtSearch.Text) Then
            Me.bindingSource.Filter = ""
            Return
        End If

        Try
            Me.bindingSource.Filter =
            "CONVERT(idCargo, 'System.String') Like '%" + Me.TxtSearch.Text + "%' OR " +
            "nombreCargo Like '%" + Me.TxtSearch.Text + "%' OR " +
            "descripcionCargo Like '%" + Me.TxtSearch.Text + "%'"

            Me.DataGridView1.DataSource = bindingSource
        Catch ex As Exception
            MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.UpdateData()
    End Sub
End Class