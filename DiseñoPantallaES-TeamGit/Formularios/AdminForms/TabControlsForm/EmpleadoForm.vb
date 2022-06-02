Public Class EmpleadoForm

    Dim DBEmpleado As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter
    Dim bindingSource As New BindingSource
    Public selectedID As Integer = -1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim addDialog As New AddDialogEmp(Me)
        addDialog.Show()
    End Sub

    Private Sub EmpleadoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDSistemaEySDataSet.vwEmpleado' Puede moverla o quitarla según sea necesario.
        Me.VwEmpleadoTableAdapter.Fill(Me.BDSistemaEySDataSet.vwEmpleado)
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BDSistemaEySDataSet.Empleado)
        Me.DataGridView1.DataSource = Me.bindingSource
        Me.bindingSource.DataSource = DBEmpleado.GetData()
    End Sub

    Public Sub UpdateData()
        Me.DataGridView1.DataSource = Me.bindingSource
        Me.bindingSource.DataSource = DBEmpleado.GetData()
    End Sub

    Protected Sub FillViewData()
        Me.CmbxID.Text = Me.selectedID
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim data As BDSistemaEySDataSet.EmpleadoDataTable = Me.bindingSource.DataSource
        If (e.RowIndex < 0) Then
            Return
        End If
        Me.selectedID = data.Rows().Item(e.RowIndex).Item(0)
        Me.CmbxID.Text = Me.selectedID
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        If String.IsNullOrWhiteSpace(Me.TxtSearch.Text) Then
            Me.bindingSource.Filter = ""
            Return
        End If
        Me.bindingSource.Filter =
            "CONVERT(idEmpleado, 'System.String') Like '%" + Me.TxtSearch.Text + "%' OR " +
            "primerNombre Like '%" + Me.TxtSearch.Text + "%' OR " +
            "segundoNombre Like '%" + Me.TxtSearch.Text + "%' OR " +
            "primerApellido Like '%" + Me.TxtSearch.Text + "%' OR " +
            "segundoApellido Like '%" + Me.TxtSearch.Text + "%' OR " +
            "cedulaEmpleado Like '%" + Me.TxtSearch.Text + "%'"
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Me.selectedID < 0 Then
            MessageBox.Show("Seleccione un Empleado",
                        "Empleado no seleccionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk)
            Return
        End If
        Dim updateDialog As New UpdateDialogEmp(Me)
        updateDialog.selectedID = Me.selectedID
        updateDialog.Show()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.selectedID < 0 Then
            MessageBox.Show("Seleccione un Empleado",
                        "Empleado no seleccionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk)
            Return
        End If
        Dim empData = DBEmpleado.GetEmpleadoData(Me.selectedID).Rows.Item(0)
        Dim empName As String = empData.Item("primerNombre") + " " + empData.Item("segundoNombre")
        Dim empApellido As String = empData.Item("primerApellido") + " " + empData.Item("segundoApellido")
        Dim empFullName As String = empName.Trim() + " " + empApellido.Trim()

        Dim res = MessageBox.Show("¿Desea eliminar el empleado """ + empFullName.Trim() + """ (" + Me.selectedID.ToString() + ") ?",
                        "Eliminar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
        If res <> DialogResult.Yes Then
            Return
        End If
        Try
            DBEmpleado.DeleteEmpleado(Me.selectedID)
        Catch ex As Exception
            MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
        Me.UpdateData()
    End Sub
    Private Sub CmbxID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbxID.SelectedIndexChanged
        Me.selectedID = Me.CmbxID.SelectedValue
    End Sub
End Class