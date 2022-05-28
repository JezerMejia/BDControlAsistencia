
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

    Private Sub btnMarkEnter_Click(sender As Object, e As EventArgs) Handles btnMarkEnter.Click
        btnMarkEnter.Enabled = False
        btnMarkExit.Enabled = True

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
        btnMarkEnter.Enabled = True
        btnMarkExit.Enabled = False

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
        btnMarkEnter.Enabled = True
        btnMarkExit.Enabled = False
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class