Public Class UpdateDialogEmp

    Dim BDEmpleado As New BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter

    Public selectedID As Integer = -1
    Dim parent As EmpleadoForm

    Public Sub New(parent As EmpleadoForm)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.parent = parent
    End Sub

    Private Sub UpdateDialogEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDSistemaEySDataSet.Horario' Puede moverla o quitarla según sea necesario.
        Me.HorarioTableAdapter.Fill(Me.BDSistemaEySDataSet.Horario)
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BDSistemaEySDataSet.Empleado)
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Departamento' table. You can move, or remove it, as needed.
        Me.DepartamentoTableAdapter.Fill(Me.BDSistemaEySDataSet.Departamento)
        'TODO: This line of code loads data into the 'BDSistemaEySDataSet.Cargo' table. You can move, or remove it, as needed.
        Me.CargoTableAdapter.Fill(Me.BDSistemaEySDataSet.Cargo)

        Me.UpdateData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub UpdateData()
        Dim empleado = Me.BDEmpleado.GetEmpleadoData(Me.selectedID)
        Dim empleadoRow = empleado.Item(0)

        Me.idTxt.Text = empleadoRow.idEmpleado
        Me.nombreTxt.Text = empleadoRow.primerNombre
        Me.snombreTxt.Text = empleadoRow.segundoNombre
        Me.apellidoTxt.Text = empleadoRow.primerApellido
        Me.sapellidoTxt.Text = empleadoRow.segundoApellido
        Me.fechIniTxt.Text = If(empleadoRow.IsfechaIngresoNull(), "", empleadoRow.fechaIngreso.ToString("yyyy-MM-dd"))
        Me.cellIdeTxt.Text = If(empleadoRow.IscedulaEmpleadoNull(), "", empleadoRow.cedulaEmpleado)
        Me.pinTxt.Text = If(empleadoRow.IspinEmpleadoNull(), "", empleadoRow.pinEmpleado)
        Me.emailPer.Text = If(empleadoRow.IsemailPersonalNull(), "", empleadoRow.emailPersonal)
        Me.emailEmpre.Text = If(empleadoRow.IsemailEmpresarialNull(), "", empleadoRow.emailEmpresarial)
        Me.telefonoTxt.Text = If(empleadoRow.IstelefonoEmpleadoNull(), "", empleadoRow.telefonoEmpleado)

        Me.cargoTxt.SelectedValue = If(empleadoRow.IsidCargoNull(), -1, empleadoRow.idCargo)
        Me.depTxt.SelectedValue = If(empleadoRow.IsidDepartamentoNull(), -1, empleadoRow.idDepartamento)
        Me.horTxt.SelectedValue = If(empleadoRow.IsidHorarioNull(), -1, empleadoRow.idHorario)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsNumeric(idTxt.Text) = False Then
            MessageBox.Show(
                "Solo se pueden ingresar ID numerico",
                "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Return
        End If

        Dim idEmpleado As Integer
        idEmpleado = CInt(Me.idTxt.Text)

        Try
            Dim fechaIni As New Nullable(Of Date)
            fechaIni = Nothing
            If (Not String.IsNullOrWhiteSpace(Me.fechIniTxt.Text)) Then
                fechaIni = Convert.ToDateTime(Me.fechIniTxt.Text)
            End If

            Dim cargoID? As Integer
            cargoID = Nothing
            If (Not String.IsNullOrWhiteSpace(Me.cargoTxt.Text)) Then
                cargoID = Convert.ToInt32(Me.cargoTxt.SelectedValue)
            End If
            Dim depID? As Integer
            depID = Nothing
            If (Not String.IsNullOrWhiteSpace(Me.depTxt.Text)) Then
                depID = Convert.ToInt32(Me.depTxt.SelectedValue)
            End If
            Dim horID? As Integer
            horID = Nothing
            If (Not String.IsNullOrWhiteSpace(Me.horTxt.Text)) Then
                horID = Convert.ToInt32(Me.horTxt.SelectedValue)
            End If
            BDEmpleado.UpdateEmpleado(nombreTxt.Text,
                                      snombreTxt.Text,
                                      apellidoTxt.Text,
                                      sapellidoTxt.Text,
                                      fechaIni,
                                      cellIdeTxt.Text,
                                      pinTxt.Text,
                                      emailPer.Text,
                                      emailEmpre.Text,
                                      telefonoTxt.Text,
                                      cargoID,
                                      depID,
                                      horID,
                                      idEmpleado)
            MsgBox("Guardado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

        Me.parent.UpdateData()
    End Sub
End Class