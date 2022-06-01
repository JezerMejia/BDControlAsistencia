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
            Throw New Exception("No se pueden dejar datos vacios")
            Return False
        End Try

        If inicioDate.CompareTo(finDate) = 0 Then
            Throw New Exception("No pueden datos iguales")
            Return False
        End If

        If inicioDate.CompareTo(finDate) > 0 Then
            Throw New Exception("La Hora de entrada no puede ser mayor a la Hora de salida")
            Return False
        End If

        Return True
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If String.IsNullOrWhiteSpace(Me.TxtName.Text) Then
            MessageBox.Show(
                "Ingrese un nombre",
                "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Return
        End If

        Try
            Me.CompareTimes(lunesIni, lunesSal)
            Me.CompareTimes(martesIni, martesSal)
            Me.CompareTimes(miercolesIni, miercolesSal)
            Me.CompareTimes(juevesIni, juevesSal)
            Me.CompareTimes(viernesIni, viernesSal)
            Me.CompareTimes(sabadoIni, sabadoSal)
            Me.CompareTimes(domingoIni, domingoSal)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End Try

        'MessageBox.Show(
        '    "No se escribió un valor válido",
        '    "Error", MessageBoxButtons.OK,
        '    MessageBoxIcon.Error)
        'Return

        'MessageBox.Show(
        '    "La Hora de entrada no puede ser mayor a la Hora de salida",
        '    "Error", MessageBoxButtons.OK,
        '    MessageBoxIcon.Error)

        'MessageBox.Show(
        '    "La Hora de entrada no puede ser igual a la Hora de salida",
        '    "Error", MessageBoxButtons.OK,
        '    MessageBoxIcon.Error)

        Try
            DBHorario.InsertHorario(
                TxtName.Text,
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