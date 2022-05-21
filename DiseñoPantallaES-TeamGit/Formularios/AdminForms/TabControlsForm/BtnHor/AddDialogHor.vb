Imports System.Data.SqlClient

Public Class AddDialogHor
    Private Sub TableLayoutPanel7_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel7.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        conexion = "Data Source=localhost;Initial Catalog=BDSistemaEyS;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("INSERT INTO Horario (" +
                    "lunesInicio, lunesSalida, " +
                    "martesInicio, martesSalida, " +
                    "miercolesInicio, miercolesSalida," +
                    "juevesInicio, juevesSalida," +
                    "viernesInicio, viernesSalida," +
                    "sabadoInicio, sabadoSalida," +
                    "domingoInicio, domingoSalida) " +
                    "VALUES (" +
                    $"'{lunesIni.Text}', '{lunesSal.Text}'," +
                    $"'{martesIni.Text}', '{martesSal.Text}', " +
                    $"'{miercolesIni.Text}','{miercolesSal.Text}', " +
                    $"'{juevesIni.Text}', '{juevesSal.Text}', " +
                    $"'{viernesIni.Text}', '{viernesSal.Text}'," +
                    $"'{sabadoIni.Text}', '{sabadoIni.Text}', " +
                    $"'{domingoIni.Text}', '{domingoSal.Text}');", cn)

        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Registro Correcto")
        cn.Close()
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

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub
End Class