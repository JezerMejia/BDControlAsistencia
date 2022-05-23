Imports System.Data.SqlClient

Public Class AddDialogHor
    Dim DBHorario As New BDSistemaEySDataSetTableAdapters.HorarioTableAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DBHorario.InsertHorario(lunesIni.Text, lunesSal.Text,
                              martesIni.Text, martesSal.Text,
                              miercolesIni.Text, miercolesSal.Text,
                              juevesIni.Text, juevesSal.Text,
                              viernesIni.Text, viernesSal.Text,
                              sabadoIni.Text, sabadoSal.Text,
                              domingoIni.Text, domingoSal.Text)
        MsgBox("Guardado")
        actualizarRegistro()

    End Sub

    Public Sub actualizarRegistro()
        Dim conexion As String
        conexion = "Data Source=localhost;Initial Catalog=BDSistemaEyS;Integrated Security=True"
        Dim sqll As String
        sqll = "Select * from Horario"
        Dim adaptador As New SqlClient.SqlDataAdapter(sqll, conexion)
        Dim obtenerDatos As New DataSet
        adaptador.Fill(obtenerDatos, "idHorario")
        HorarioForm.DataGridView1.DataSource = obtenerDatos
        HorarioForm.DataGridView1.DataMember = "IdHorario"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        HorarioForm.Show()
    End Sub

End Class