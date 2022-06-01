Public Class AddDialogEmp

    Dim BDEmpleado As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter

    Dim parent As EmpleadoForm

    Public Sub New(parent As EmpleadoForm)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.parent = parent
    End Sub

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

        Me.parent.UpdateData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class