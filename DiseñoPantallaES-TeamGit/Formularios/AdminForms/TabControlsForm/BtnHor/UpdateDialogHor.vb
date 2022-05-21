Imports System.Data.SqlClient

Public Class UpdateDialogHor

    Public Sub llenarCombo()


    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        conexion = "Data Source=localhost;Initial Catalog=BDSistemaEyS;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim IdHor As String

        IdHor = HorarioForm.DataGridView1.CurrentCell.Value.ToString()


        Dim adaptador As New SqlCommand("UPDATE Horario SET lunesInicio='" & lunesIni.Text & "', lunesSalida='" & lunesSal.Text & "',
                                        martesInicio='" & martesIni.Text & "', martesSalida='" & martesSal.Text & "',
                                        miercolesInicio='" & miercolesIni.Text & "', miercolesSalida='" & miercolesSal.Text & "',
                                        juevesInicio='" & juevesIni.Text & "', juevesSalida='" & juevesSal.Text & "',
                                        viernesInicio='" & viernesIni.Text & "', viernesSalida='" & viernesSal.Text & "',
                                        sabadoInicio='" & sabadoIni.Text & "', sabadoSalida='" & sabadoSal.Text & "',
                                        domingoInicio='" & domingoIni.Text & "', domingoSalida='" & domingoSal.Text & "'
                                        WHERE idHorario = " & IdHor & " ", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Registro Correcto")
        cn.Close()

    End Sub
End Class