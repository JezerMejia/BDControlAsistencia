Public Class Departamento

    Dim BDDep As New BDSistemaEySDataSetTableAdapters.DepartamentoTableAdapter
    Dim bindingSource As New BindingSource
    Public selectedID As Integer = -1

    Private Sub Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Departamento' table. You can move, or remove it, as needed.
        Me.DepartamentoTableAdapter.Fill(Me.BDSistemaEySDataSet.Departamento)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        TxtName.Text = ""
        TxtExtension.Text = ""
        TxtDescription.Text = ""
    End Sub

    Private Sub BtnAdd_Clicked(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            If (String.IsNullOrWhiteSpace(TxtName.Text)) Then
                Throw New Exception("Ingrese un nombre")
            End If
            If (String.IsNullOrWhiteSpace(TxtDescription.Text)) Then
                Throw New Exception("Ingrese una descripción")
            End If
            If (String.IsNullOrWhiteSpace(TxtExtension.Text)) Then
                Throw New Exception("Ingrese una extensión")
            End If
            BDDep.InsertDepartamento(
                TxtName.Text,
                TxtDescription.Text,
                TxtExtension.Text
                )
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
        Me.bindingSource.DataSource = BDDep.GetData()
    End Sub

    Private Sub BtnRemove_Clicked(sender As Object, e As EventArgs) Handles BtnRemove.Click
        If Me.selectedID < 0 Then
            MessageBox.Show("Seleccione un departamento",
                        "Departamento no seleccionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk)
            Return
        End If

        Dim res = MessageBox.Show("¿Desea eliminar el el departamento?",
                        "Eliminar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
        If res <> DialogResult.Yes Then
            Return
        End If
        Try
            BDDep.DeleteDepartamento(Me.selectedID)
        Catch ex As Exception
            MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
        Me.UpdateData()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If (e.RowIndex < 0) Then
            Return
        End If

        Dim filas As Integer = DataGridView1.CurrentRow.Index
        Me.selectedID = DataGridView1.Item(0, filas).Value
        Me.TxtName.Text = DataGridView1.Item(1, filas).Value
        Me.TxtDescription.Text = DataGridView1.Item(2, filas).Value
        Me.TxtExtension.Text = DataGridView1.Item(3, filas).Value
    End Sub

    Private Sub editar_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Me.selectedID < 0 Then
            MessageBox.Show("Seleccione un departamento",
                        "Departamento no seleccionado",
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
            If (String.IsNullOrWhiteSpace(TxtExtension.Text)) Then
                Throw New Exception("Ingrese una extensión")
            End If
            BDDep.UpdateDepartamento(
                TxtName.Text,
                TxtDescription.Text,
                TxtExtension.Text,
                Me.selectedID)
            MsgBox("Editado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

        Me.UpdateData()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Me.bindingSource.DataSource = BDDep.GetData()
        If String.IsNullOrWhiteSpace(Me.TxtSearch.Text) Then
            Me.bindingSource.Filter = ""
            Return
        End If
        Try

            Me.bindingSource.Filter =
            "CONVERT(idDepartamento, 'System.String') Like '%" + Me.TxtSearch.Text + "%' OR " +
            "nombreDepartamento Like '%" + Me.TxtSearch.Text + "%' OR " +
            "descripcionDepartamento Like '%" + Me.TxtSearch.Text + "%' OR " +
            "extensionDepartamento Like '%" + Me.TxtSearch.Text + "%'"

            Me.DataGridView1.DataSource = bindingSource
        Catch ex As Exception
            MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub
End Class