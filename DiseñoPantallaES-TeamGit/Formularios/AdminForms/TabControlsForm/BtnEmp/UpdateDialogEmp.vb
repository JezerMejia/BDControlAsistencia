Public Class UpdateDialogEmp

    Dim BDEmpleado As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter

    Public selectedID As Integer = -1
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub UpdateDialogEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BDSistemaEySDataSet.Empleado)
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Departamento' table. You can move, or remove it, as needed.
        Me.DepartamentoTableAdapter.Fill(Me.BDSistemaEySDataSet.Departamento)
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Cargo' table. You can move, or remove it, as needed.
        Me.CargoTableAdapter.Fill(Me.BDSistemaEySDataSet.Cargo)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsNumeric(idTxt.Text) = False Then
            MessageBox.Show(
                "Solo se pueden ingresar ID numerico",
                "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Return
        End If

        Dim idText As Integer
        idText = CInt(Me.idTxt.Text)

        BDEmpleado.UpdateEmpleado(idTxt.Text,
                                      nombreTxt.Text,
                                      apellidoTxt.Text,
                                      sapellidoTxt.Text,
                                      Convert.ToDateTime(fechIniTxt.Text),
                                      cellIdeTxt.Text,
                                      pinTxt.Text,
                                      emailPer.Text,
                                      emailEmpre.Text,
                                      telefonoTxt.Text,
                                      Convert.ToInt32(cargoTxt.Text),
                                      Convert.ToInt32(depTxt.Text),
                                      Convert.ToInt32(horTxt.Text), idText)
    End Sub
End Class