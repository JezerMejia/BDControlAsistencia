Imports System.Data.SqlClient

Public Class AddDialogHor
    Dim DBHorario As New BDSistemaEySDataSetTableAdapters.HorarioTableAdapter
    Dim comparacion As Integer
    Dim comparacionM As Integer
    Dim comparacionX As Integer
    Dim comparacionJ As Integer
    Dim comparacionV As Integer
    Dim comparacionS As Integer
    Dim comparacionD As Integer

    Private Function CompareTimes(inicio As ComboBox, fin As ComboBox) As Boolean
        Dim inicioDate As DateTime
        Dim finDate As DateTime

        Try
            inicioDate = DateTime.Parse(inicio.Text)
            finDate = DateTime.Parse(fin.Text)
        Catch ex As Exception
            Return False
        End Try

        If inicioDate.CompareTo(finDate) > 0 Then
            MessageBox.Show(
                "La Hora de entrada no puede ser mayor a la Hora de salida",
                "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return False
        End If
        If inicioDate.CompareTo(finDate) = 0 Then
            MessageBox.Show(
                "La Hora de entrada no puede ser igual a la Hora de salida",
                "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If (
            Not Me.CompareTimes(lunesIni, lunesSal) Or
            Not Me.CompareTimes(martesIni, martesSal) Or
            Not Me.CompareTimes(miercolesIni, miercolesSal) Or
            Not Me.CompareTimes(juevesIni, juevesSal) Or
            Not Me.CompareTimes(viernesIni, viernesSal) Or
            Not Me.CompareTimes(sabadoIni, sabadoSal) Or
            Not Me.CompareTimes(domingoIni, domingoSal)
            ) Then
            MessageBox.Show(
                "No se escribió un valor válido",
                "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return

        End If

        Try
            DBHorario.InsertHorario(
                lunesIni.Text, lunesSal.Text,
                martesIni.Text, martesSal.Text,
                miercolesIni.Text, miercolesSal.Text,
                juevesIni.Text, juevesSal.Text,
                viernesIni.Text, viernesSal.Text,
                sabadoIni.Text, sabadoSal.Text,
                domingoIni.Text, domingoSal.Text
                )
            MsgBox("Guardado")
        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class