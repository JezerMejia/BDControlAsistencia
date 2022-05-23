Public Class AddDialogEmp

    Dim BDEmpleado As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim idEmp As Integer = Convert.ToInt32(idTxt.Text)

        Try
            BDEmpleado.InsertEmpleado(
                idEmp,
                nombreTxt.Text, segNombreTxt.Text,
                apellidoTxt.Text, segApellidoTxt.Text,
                passwordTxt.Text
                )
            MsgBox("Guardado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

        EmpleadoForm.UpdateData()
    End Sub
End Class