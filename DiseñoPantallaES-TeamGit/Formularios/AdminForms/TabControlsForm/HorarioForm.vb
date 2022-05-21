Imports System.Data.SqlClient

Public Class HorarioForm
    Private Sub HorarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Horario' table. You can move, or remove it, as needed.
        Me.HorarioTableAdapter.Fill(Me.BDSistemaEySDataSet.Horario)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AddDialogHor.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim NumeroDeFilaSeleccionada As Integer
        Dim conexion As String
        conexion = "Data Source=localhost;Initial Catalog=BDSistemaEyS;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        If DataGridView1.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DataGridView1.CurrentRow.Index
            MessageBox.Show("Selecciona una fila")
        Else

            Dim IdHor As String

            IdHor = Me.DataGridView1.CurrentCell.Value.ToString()

            Dim adaptador As New SqlCommand("DELETE FROM Horario WHERE idHorario = " +
            $"{IdHor};", cn)

            cn.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("Registro Correcto")
            cn.Close()
            actualizarRegistro()

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