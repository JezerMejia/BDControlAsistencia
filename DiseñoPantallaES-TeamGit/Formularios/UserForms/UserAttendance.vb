
Public Class UserAttendance

    Dim AssistanceDataSet As New BDSistemaEySDataSetTableAdapters.AsistenciaTableAdapter
    Public idEmpleado As Integer = -1

    Public Sub CloseAll()
        UserLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.CloseAll()
    End Sub

    Private Sub UpdateData()
        Me.btnMarkEnter.Enabled = True
        Me.btnMarkExit.Enabled = True

        Dim existsEnter = AssistanceDataSet.DoesExistEnter(DateTime.Now.Date, Me.idEmpleado)
        Dim existsExit = AssistanceDataSet.DoesExistExit(DateTime.Now.Date, Me.idEmpleado)

        If (existsEnter) Then
            Me.btnMarkEnter.Enabled = False
        Else
            Me.btnMarkExit.Enabled = False
        End If
        If (existsExit) Then
            Me.btnMarkExit.Enabled = False
        End If
    End Sub

    Private Sub btnMarkEnter_Click(sender As Object, e As EventArgs) Handles btnMarkEnter.Click
        AssistanceDataSet.MarkAssistanceEnter(
            Me.idEmpleado,
            DateTime.Now.ToString("yyyy-MM-dd"),
            DateTime.Now.ToString("HH:mm:ss")
            )
        MessageBox.Show("Entrada Marcada Exitosamente",
                        "Registro Entrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
        Me.CloseAll()
    End Sub

    Private Sub btnMarkExit_Click(sender As Object, e As EventArgs) Handles btnMarkExit.Click
        AssistanceDataSet.MarkAssistanceExit(
            Me.idEmpleado,
            DateTime.Now.ToString("yyyy-MM-dd"),
            DateTime.Now.ToString("HH:mm:ss")
            )
        MessageBox.Show("Salida Marcada Exitosamente",
                        "Registro Salida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
        Me.CloseAll()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbFechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub UserAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UpdateData()
    End Sub

    Private Sub UserAttendance_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        UserLogin.Show()
    End Sub
End Class