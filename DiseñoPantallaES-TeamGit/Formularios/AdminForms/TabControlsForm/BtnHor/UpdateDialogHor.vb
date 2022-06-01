Imports System.Data.SqlClient

Public Class UpdateDialogHor
    Dim BDHorario As New BDSistemaEySDataSetTableAdapters.HorarioTableAdapter
    Dim id As Integer
    Public Sub llenarCombo()


    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs)

        If String.IsNullOrWhiteSpace(TxtName.Text) Then
            MessageBox.Show(
                "Ingrese un nombre",
                "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Return
        End If

        BDHorario.UpdateHorario(
            TxtName.Text,
            lunesIni.Text, lunesSal.Text,
            martesIni.Text, martesSal.Text,
            miercolesIni.Text, miercolesSal.Text,
            juevesIni.Text, juevesSal.Text,
            viernesIni.Text, viernesSal.Text,
            sabadoIni.Text, sabadoSal.Text,
            domingoIni.Text, domingoSal.Text, id)
        MsgBox("Guardado")

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class