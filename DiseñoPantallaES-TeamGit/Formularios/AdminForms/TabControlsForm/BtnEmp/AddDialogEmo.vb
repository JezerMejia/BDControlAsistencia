Public Class AddDialogEmp

    Dim BDEmpleado As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim idEmp As Integer

        idEmp = Convert.ToInt32(idTxt.Text)

        BDEmpleado.InsertEmpleado(idEmp, nombreTxt.Text, segNombreTxt.Text, apellidoTxt.Text, segApellidoTxt.Text, passwordTxt.Text)

        MsgBox("Guardado")

    End Sub
End Class