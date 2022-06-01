Imports System.Data.SqlClient

Public Class UpdateDialogHor
    Dim BDHorario As New BDSistemaEySDataSetTableAdapters.HorarioTableAdapter
    Public selectedID As Integer

    Dim parent As HorarioForm

    Public Sub New(parent As HorarioForm)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.parent = parent
    End Sub

    Public Function DateToString(horario As DataRow, index As Integer) As String
        Dim time As String = ""
        If (Not horario.IsNull(index)) Then
            time = horario.Item(index)
        End If
        Return time
    End Function

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

    Public Sub UpdateData()
        Dim horario = Me.BDHorario.GetHorarioData(Me.selectedID)
        Dim horarioRow = horario.Item(0)

        Me.TxtName.Text = horarioRow.nombreHorario
        Me.lunesIni.Text = Me.DateToString(horarioRow, 2)
        Me.lunesSal.Text = Me.DateToString(horarioRow, 3)
        Me.martesIni.Text = Me.DateToString(horarioRow, 4)
        Me.martesSal.Text = Me.DateToString(horarioRow, 5)
        Me.miercolesIni.Text = Me.DateToString(horarioRow, 6)
        Me.miercolesSal.Text = Me.DateToString(horarioRow, 7)
        Me.juevesIni.Text = Me.DateToString(horarioRow, 8)
        Me.juevesSal.Text = Me.DateToString(horarioRow, 9)
        Me.viernesIni.Text = Me.DateToString(horarioRow, 10)
        Me.viernesSal.Text = Me.DateToString(horarioRow, 11)
        Me.sabadoIni.Text = Me.DateToString(horarioRow, 12)
        Me.sabadoSal.Text = Me.DateToString(horarioRow, 13)
        Me.domingoIni.Text = Me.DateToString(horarioRow, 14)
        Me.domingoSal.Text = Me.DateToString(horarioRow, 15)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub UpdateDialogHor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UpdateData()
    End Sub
    Public Function StringToNull(str As String) As String
        If String.IsNullOrWhiteSpace(str) Then
            Return Nothing
        End If
        Return str
    End Function

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        If String.IsNullOrWhiteSpace(TxtName.Text) Then
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

            BDHorario.UpdateHorario(
                TxtName.Text,
                StringToNull(lunesIni.Text), StringToNull(lunesSal.Text),
                StringToNull(martesIni.Text), StringToNull(martesSal.Text),
                StringToNull(miercolesIni.Text), StringToNull(miercolesSal.Text),
                StringToNull(juevesIni.Text), StringToNull(juevesSal.Text),
                StringToNull(viernesIni.Text), StringToNull(viernesSal.Text),
                StringToNull(sabadoIni.Text), StringToNull(sabadoSal.Text),
                StringToNull(domingoIni.Text), StringToNull(domingoSal.Text),
                selectedID)
            MsgBox("Guardado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try
        Me.parent.UpdateData()
    End Sub
End Class