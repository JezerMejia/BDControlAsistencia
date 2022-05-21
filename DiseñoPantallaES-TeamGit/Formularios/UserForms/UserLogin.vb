Public Class UserLogin

    Public DataEmpleado As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter

    Public Overloads Sub CloseAll()
        Me.Hide()
        MainWindow.Show()
    End Sub

    Private Sub UserLogin_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.CloseAll()
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Function DoLogin() As Boolean
        Dim idText As String = Me.txtID.Text
        Dim empleado = DataEmpleado.GetEmpleadoData(idText)

        If (empleado.Rows.Count = 0) Then
            MessageBox.Show("El empleado con ID '" + idText + "' no existe",
                        "Ingreso inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
            Return False
        ElseIf empleado.Rows.Item(0).Item("password") <> Me.txtPin.Text Then
            MessageBox.Show("La contraseña es incorrecta",
                        "Ingreso inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If Not Me.DoLogin() Then
            Return
        End If
        Me.Hide()
        UserAttendance.Show()
        Me.txtID.Clear()
        Me.txtPin.Clear()
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class