Public Class AdminLogin

    Public DataEmpleado As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        MainWindow.Show()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If String.IsNullOrWhiteSpace(txtUser.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show(
                "No puede haber datos vacios",
                "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Return
        End If

        If IsNumeric(txtUser.Text) = False Then
            MessageBox.Show(
                "Solo se pueden ingresar ID numerico",
                "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Return
        End If

        If Not Me.DoLogin() Then
            Return
        End If
        Me.Hide()
        controlCenter.Show()

    End Sub

    Private Sub AdminLogin_Closed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        MainWindow.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub

    Private Function DoLogin() As Boolean

        Dim idText As Integer
        idText = CInt(Me.txtUser.Text)
        Dim empleado = DataEmpleado.GetEmpleadoData(idText)

        If (empleado.Rows.Count = 0) Then
            MessageBox.Show("El empleado no existe",
                        "Ingreso inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
            Return False
        ElseIf empleado.Rows.Item(0).Item("pinEmpleado") <> Me.txtPassword.Text Then
            MessageBox.Show("La contraseña es incorrecta",
                        "Ingreso inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

End Class