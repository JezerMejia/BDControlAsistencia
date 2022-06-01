Imports System.Data.SqlClient

Public Class AddDialogHor
    Dim DBHorario As New BDSistemaEySDataSetTableAdapters.HorarioTableAdapter

    Dim parent As HorarioForm

    Public Sub New(parent As HorarioForm)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.parent = parent
    End Sub

    Private Sub CompareTimes(inicio As ComboBox, fin As ComboBox)
        Dim inicioDate As DateTime
        Dim finDate As DateTime

        Dim inicioEmpty = String.IsNullOrWhiteSpace(inicio.Text)
        Dim finEmpty = String.IsNullOrWhiteSpace(fin.Text)

        If (inicioEmpty And finEmpty) Then
            Return
        End If

        If (inicioEmpty And Not finEmpty Or
            finEmpty And Not inicioEmpty) Then
            Throw New Exception("Debes de ingresar ambas fechas")
        End If

        Try
            inicioDate = DateTime.Parse(inicio.Text)
            finDate = DateTime.Parse(fin.Text)
        Catch ex As Exception
            Throw New Exception("Las fechas son inválidas")
        End Try

        If inicioDate.CompareTo(finDate) = 0 Then
            Throw New Exception("No pueden haber datos iguales")
        End If

        If inicioDate.CompareTo(finDate) > 0 Then
            Throw New Exception("La Hora de entrada no puede ser mayor a la Hora de salida")
        End If
    End Sub

    Public Function StringToNull(str As String) As String
        If String.IsNullOrWhiteSpace(str) Then
            Return Nothing
        End If
        Return str
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

            DBHorario.InsertHorario(
                TxtName.Text,
                StringToNull(lunesIni.Text), StringToNull(lunesSal.Text),
                StringToNull(martesIni.Text), StringToNull(martesSal.Text),
                StringToNull(miercolesIni.Text), StringToNull(miercolesSal.Text),
                StringToNull(juevesIni.Text), StringToNull(juevesSal.Text),
                StringToNull(viernesIni.Text), StringToNull(viernesSal.Text),
                StringToNull(sabadoIni.Text), StringToNull(sabadoSal.Text),
                StringToNull(domingoIni.Text), StringToNull(domingoSal.Text)
                )
            MsgBox("Guardado")
        Catch ex As Exception
            MessageBox.Show(
                ex.Message,
                "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try
        Me.parent.UpdateData()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class