<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDialogEmp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.horTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fechIniTxt = New System.Windows.Forms.TextBox()
        Me.cargoTxt = New System.Windows.Forms.ComboBox()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSet()
        Me.cellIdeTxt = New System.Windows.Forms.TextBox()
        Me.depTxt = New System.Windows.Forms.ComboBox()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pinTxt = New System.Windows.Forms.TextBox()
        Me.sapellidoTxt = New System.Windows.Forms.TextBox()
        Me.apellidoTxt = New System.Windows.Forms.TextBox()
        Me.snombreTxt = New System.Windows.Forms.TextBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CargoTableAdapter = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSetTableAdapters.CargoTableAdapter()
        Me.DepartamentoTableAdapter = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSetTableAdapters.DepartamentoTableAdapter()
        Me.idTxt = New System.Windows.Forms.ComboBox()
        Me.emailPe = New System.Windows.Forms.Label()
        Me.emailEmpr = New System.Windows.Forms.Label()
        Me.emailPer = New System.Windows.Forms.TextBox()
        Me.emailEmpre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.telefonoTxt = New System.Windows.Forms.TextBox()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.15106!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.84894!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(89, 312)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(306, 44)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(26, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(179, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(484, 369)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(13, 41)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(458, 236)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.horTxt, 1, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.fechIniTxt, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.cargoTxt, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.cellIdeTxt, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.depTxt, 1, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.telefonoTxt, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(232, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 6
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(223, 230)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'horTxt
        '
        Me.horTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.horTxt.Location = New System.Drawing.Point(120, 200)
        Me.horTxt.Name = "horTxt"
        Me.horTxt.Size = New System.Drawing.Size(100, 20)
        Me.horTxt.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Fecha de Ingreso:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Cédula de Indentidad:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Cargo:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Departamento:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(70, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Horario:"
        '
        'fechIniTxt
        '
        Me.fechIniTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.fechIniTxt.Location = New System.Drawing.Point(120, 47)
        Me.fechIniTxt.Name = "fechIniTxt"
        Me.fechIniTxt.Size = New System.Drawing.Size(100, 20)
        Me.fechIniTxt.TabIndex = 9
        '
        'cargoTxt
        '
        Me.cargoTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cargoTxt.DataSource = Me.CargoBindingSource
        Me.cargoTxt.DisplayMember = "nombreCargo"
        Me.cargoTxt.FormattingEnabled = True
        Me.cargoTxt.Location = New System.Drawing.Point(120, 122)
        Me.cargoTxt.Name = "cargoTxt"
        Me.cargoTxt.Size = New System.Drawing.Size(100, 21)
        Me.cargoTxt.TabIndex = 11
        Me.cargoTxt.ValueMember = "idCargo"
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cellIdeTxt
        '
        Me.cellIdeTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cellIdeTxt.Location = New System.Drawing.Point(120, 85)
        Me.cellIdeTxt.Name = "cellIdeTxt"
        Me.cellIdeTxt.Size = New System.Drawing.Size(100, 20)
        Me.cellIdeTxt.TabIndex = 10
        '
        'depTxt
        '
        Me.depTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.depTxt.DataSource = Me.DepartamentoBindingSource
        Me.depTxt.DisplayMember = "nombreDepartamento"
        Me.depTxt.FormattingEnabled = True
        Me.depTxt.Location = New System.Drawing.Point(120, 160)
        Me.depTxt.Name = "depTxt"
        Me.depTxt.Size = New System.Drawing.Size(100, 21)
        Me.depTxt.TabIndex = 12
        Me.depTxt.ValueMember = "idDepartamento"
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.emailEmpr, 0, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.pinTxt, 1, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.sapellidoTxt, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.apellidoTxt, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.snombreTxt, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.nombreTxt, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.idTxt, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.emailPe, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.emailPer, 1, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.emailEmpre, 1, 7)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(8, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 8
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50187!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50187!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(212, 230)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "PIN:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Segundo Apellido:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Segundo Nombre:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre:"
        '
        'pinTxt
        '
        Me.pinTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pinTxt.Location = New System.Drawing.Point(102, 144)
        Me.pinTxt.Name = "pinTxt"
        Me.pinTxt.Size = New System.Drawing.Size(100, 20)
        Me.pinTxt.TabIndex = 11
        '
        'sapellidoTxt
        '
        Me.sapellidoTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.sapellidoTxt.Location = New System.Drawing.Point(102, 116)
        Me.sapellidoTxt.Name = "sapellidoTxt"
        Me.sapellidoTxt.Size = New System.Drawing.Size(100, 20)
        Me.sapellidoTxt.TabIndex = 10
        '
        'apellidoTxt
        '
        Me.apellidoTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.apellidoTxt.Location = New System.Drawing.Point(102, 88)
        Me.apellidoTxt.Name = "apellidoTxt"
        Me.apellidoTxt.Size = New System.Drawing.Size(100, 20)
        Me.apellidoTxt.TabIndex = 9
        '
        'snombreTxt
        '
        Me.snombreTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.snombreTxt.Location = New System.Drawing.Point(102, 60)
        Me.snombreTxt.Name = "snombreTxt"
        Me.snombreTxt.Size = New System.Drawing.Size(100, 20)
        Me.snombreTxt.TabIndex = 8
        '
        'nombreTxt
        '
        Me.nombreTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nombreTxt.Location = New System.Drawing.Point(102, 32)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(100, 20)
        Me.nombreTxt.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'idTxt
        '
        Me.idTxt.DataSource = Me.EmpleadoBindingSource
        Me.idTxt.DisplayMember = "idEmpleado"
        Me.idTxt.FormattingEnabled = True
        Me.idTxt.Location = New System.Drawing.Point(102, 3)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(107, 21)
        Me.idTxt.TabIndex = 17
        Me.idTxt.ValueMember = "idEmpleado"
        '
        'emailPe
        '
        Me.emailPe.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.emailPe.AutoSize = True
        Me.emailPe.Location = New System.Drawing.Point(21, 175)
        Me.emailPe.Name = "emailPe"
        Me.emailPe.Size = New System.Drawing.Size(75, 13)
        Me.emailPe.TabIndex = 18
        Me.emailPe.Text = "Email personal"
        '
        'emailEmpr
        '
        Me.emailEmpr.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.emailEmpr.AutoSize = True
        Me.emailEmpr.Location = New System.Drawing.Point(7, 206)
        Me.emailEmpr.Name = "emailEmpr"
        Me.emailEmpr.Size = New System.Drawing.Size(89, 13)
        Me.emailEmpr.TabIndex = 19
        Me.emailEmpr.Text = "Email Empresarial"
        '
        'emailPer
        '
        Me.emailPer.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.emailPer.Location = New System.Drawing.Point(102, 172)
        Me.emailPer.Name = "emailPer"
        Me.emailPer.Size = New System.Drawing.Size(100, 20)
        Me.emailPer.TabIndex = 20
        '
        'emailEmpre
        '
        Me.emailEmpre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.emailEmpre.Location = New System.Drawing.Point(102, 203)
        Me.emailEmpre.Name = "emailEmpre"
        Me.emailEmpre.Size = New System.Drawing.Size(100, 20)
        Me.emailEmpre.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(65, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Telefono"
        '
        'telefonoTxt
        '
        Me.telefonoTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.telefonoTxt.Location = New System.Drawing.Point(120, 9)
        Me.telefonoTxt.Name = "telefonoTxt"
        Me.telefonoTxt.Size = New System.Drawing.Size(100, 20)
        Me.telefonoTxt.TabIndex = 15
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'UpdateDialogEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 369)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(500, 408)
        Me.Name = "UpdateDialogEmp"
        Me.Text = "Editar | Empleado"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents horTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents fechIniTxt As TextBox
    Friend WithEvents cargoTxt As ComboBox
    Friend WithEvents cellIdeTxt As TextBox
    Friend WithEvents depTxt As ComboBox
    Friend WithEvents pinTxt As TextBox
    Friend WithEvents sapellidoTxt As TextBox
    Friend WithEvents apellidoTxt As TextBox
    Friend WithEvents snombreTxt As TextBox
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As BDSistemaEySDataSetTableAdapters.CargoTableAdapter
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As BDSistemaEySDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents idTxt As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents telefonoTxt As TextBox
    Friend WithEvents emailEmpr As Label
    Friend WithEvents emailPe As Label
    Friend WithEvents emailPer As TextBox
    Friend WithEvents emailEmpre As TextBox
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As BDSistemaEySDataSetTableAdapters.EmpleadoTableAdapter
End Class
