Imports System.Data.SqlClient

Public Class HorarioForm

    Dim BDHorario As New BDSistemaEySDataSetTableAdapters.HorarioTableAdapter

    Private Sub HorarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Horario' table. You can move, or remove it, as needed.
        Me.HorarioTableAdapter.Fill(Me.BDSistemaEySDataSet.Horario)

    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddDialogHor.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Dim NumeroDeFilaSeleccionada As Integer


        If DataGridView1.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DataGridView1.CurrentRow.Index
            MessageBox.Show("Selecciona una fila")
        Else

            Dim IdHor As String
            Dim resp As VariantType

            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then

                IdHor = Me.DataGridView1.CurrentCell.Value.ToString()

                BDHorario.EliminarHor(IdHor)

                MsgBox("Registro Correcto")
                actualizarRegistro()

            End If

        End If
    End Sub

    Public Sub actualizarRegistro()
        Dim conexion As String
        conexion = "Data Source=localhost;Initial Catalog=BDSistemaEyS;Integrated Security=True"
        Dim sqll As String
        sqll = "Select * from Horario"
        Dim adaptador As New SqlClient.SqlDataAdapter(sqll, conexion)
        Dim obtenerDatos As New DataSet
        adaptador.Fill(obtenerDatos, "idHorario")
        DataGridView1.DataSource = obtenerDatos
        DataGridView1.DataMember = "IdHorario"
    End Sub


    Public Sub updateDatos()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateDialogHor.Show()
    End Sub
End Class