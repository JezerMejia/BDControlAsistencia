Imports System.Data.SqlClient

Public Class HorarioForm

    Dim BDHorario As New BDSistemaEySDataSetTableAdapters.HorarioTableAdapter
    Dim bindingSource As New BindingSource
    Public selectedID As Integer = -1

    Private Sub HorarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Horario' table. You can move, or remove it, as needed.
        Me.HorarioTableAdapter.Fill(Me.BDSistemaEySDataSet.Horario)
        Me.DataGridView1.DataSource = Me.bindingSource
        Me.bindingSource.DataSource = BDHorario.GetData()
    End Sub

    Public Sub UpdateData()
        Me.DataGridView1.DataSource = Me.bindingSource
        Me.bindingSource.DataSource = BDHorario.GetData()
    End Sub

    Public Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim addDialog As New AddDialogHor(Me)
        addDialog.Show()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.selectedID < 0 Then
            MessageBox.Show("Seleccione un Horario",
                        "Horario no seleccionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk)
            Return
        End If

        Dim res = MessageBox.Show("¿Desea eliminar el horario (" + Me.selectedID.ToString() + ") ?",
                        "Eliminar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
        If res <> DialogResult.Yes Then
            Return
        End If
        Try
            BDHorario.DeleteHorario(Me.selectedID)
        Catch ex As Exception
            MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
        Me.UpdateData()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim updateDialog As New UpdateDialogHor(Me)
        updateDialog.selectedID = Me.selectedID
        updateDialog.Show()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim data As BDSistemaEySDataSet.HorarioDataTable = Me.bindingSource.DataSource
        If (e.RowIndex < 0) Then
            Return
        End If
        Me.selectedID = data.Rows().Item(e.RowIndex).Item(0)
        Console.WriteLine(Me.selectedID)
    End Sub
End Class