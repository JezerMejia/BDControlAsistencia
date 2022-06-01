Public Class Departamento

    Dim BDDep As New BDSistemaEySDataSetTableAdapters.DepartamentoTableAdapter
    Dim bindingSource As New BindingSource
    Public selectedID As Integer = -1

    Private Sub Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Departamento' table. You can move, or remove it, as needed.
        Me.DepartamentoTableAdapter.Fill(Me.BDSistemaEySDataSet.Departamento)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        nombreTxt.Text = ""
        extensionTxt.Text = ""
        descripcionTxt.Text = ""
    End Sub

    Private Sub añadir_Click(sender As Object, e As EventArgs) Handles añadir.Click
        Try
            BDDep.InsertDepartamento(nombre.Text, descripcionTxt.Text, extensionTxt.Text)
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

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
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
        Me.nombreTxt.Text = DataGridView1.Item(1, filas).Value
        Me.descripcionTxt.Text = DataGridView1.Item(2, filas).Value
        Me.extensionTxt.Text = DataGridView1.Item(3, filas).Value

    End Sub

    Private Sub editar_Click(sender As Object, e As EventArgs) Handles editar.Click
        If Me.selectedID < 0 Then
            MessageBox.Show("Seleccione un departamento",
                        "Departamento no seleccionado",
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
            BDDep.UpdateDepartamento(nombreTxt.Text, descripcionTxt.Text, extensionTxt.Text, Me.selectedID)
            MsgBox("Editado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

        Me.UpdateData()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles buscarTxt.TextChanged
        Me.bindingSource.DataSource = BDDep.GetData()

        If String.IsNullOrWhiteSpace(Me.buscarTxt.Text) Then
            Me.bindingSource.Filter = ""
            Return
        End If

        Try

            Me.bindingSource.Filter =
            "CONVERT(idDepartamento, 'System.String') Like '%" + Me.buscarTxt.Text + "%' OR " +
            "nombreDepartamento Like '%" + Me.buscarTxt.Text + "%' OR " +
            "descripcionDepartamento Like '%" + Me.buscarTxt.Text + "%' OR " +
            "extensionDepartamento Like '%" + Me.buscarTxt.Text + "%'"

            Me.DataGridView1.DataSource = bindingSource

        Catch ex As Exception
            MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class