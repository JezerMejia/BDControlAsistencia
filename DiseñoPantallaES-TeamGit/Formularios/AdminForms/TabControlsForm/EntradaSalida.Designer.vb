<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradaSalida
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.AsistenciaTableAdapter = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSetTableAdapters.AsistenciaTableAdapter()
        Me.VwAsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwAsistenciaTableAdapter = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSetTableAdapters.vwAsistenciaTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAsistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.VwAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 318)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FechaAsistenciaDataGridViewTextBoxColumn, Me.EntradaDataGridViewTextBoxColumn, Me.SalidaDataGridViewTextBoxColumn, Me.IDEmpleadoDataGridViewTextBoxColumn, Me.EmpleadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwAsistenciaBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(460, 274)
        Me.DataGridView1.TabIndex = 4
        '
        'AsistenciaBindingSource
        '
        Me.AsistenciaBindingSource.DataMember = "Asistencia"
        Me.AsistenciaBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnUpdate, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(460, 44)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnUpdate.Location = New System.Drawing.Point(377, 10)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 0
        Me.BtnUpdate.Text = "Actualizar"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'AsistenciaTableAdapter
        '
        Me.AsistenciaTableAdapter.ClearBeforeFill = True
        '
        'VwAsistenciaBindingSource
        '
        Me.VwAsistenciaBindingSource.DataMember = "vwAsistencia"
        Me.VwAsistenciaBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'VwAsistenciaTableAdapter
        '
        Me.VwAsistenciaTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaAsistenciaDataGridViewTextBoxColumn
        '
        Me.FechaAsistenciaDataGridViewTextBoxColumn.DataPropertyName = "Fecha Asistencia"
        Me.FechaAsistenciaDataGridViewTextBoxColumn.HeaderText = "Fecha Asistencia"
        Me.FechaAsistenciaDataGridViewTextBoxColumn.Name = "FechaAsistenciaDataGridViewTextBoxColumn"
        Me.FechaAsistenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntradaDataGridViewTextBoxColumn
        '
        Me.EntradaDataGridViewTextBoxColumn.DataPropertyName = "Entrada"
        Me.EntradaDataGridViewTextBoxColumn.HeaderText = "Entrada"
        Me.EntradaDataGridViewTextBoxColumn.Name = "EntradaDataGridViewTextBoxColumn"
        Me.EntradaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalidaDataGridViewTextBoxColumn
        '
        Me.SalidaDataGridViewTextBoxColumn.DataPropertyName = "Salida"
        Me.SalidaDataGridViewTextBoxColumn.HeaderText = "Salida"
        Me.SalidaDataGridViewTextBoxColumn.Name = "SalidaDataGridViewTextBoxColumn"
        Me.SalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDEmpleadoDataGridViewTextBoxColumn
        '
        Me.IDEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ID Empleado"
        Me.IDEmpleadoDataGridViewTextBoxColumn.HeaderText = "ID Empleado"
        Me.IDEmpleadoDataGridViewTextBoxColumn.Name = "IDEmpleadoDataGridViewTextBoxColumn"
        Me.IDEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadoDataGridViewTextBoxColumn
        '
        Me.EmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado"
        Me.EmpleadoDataGridViewTextBoxColumn.HeaderText = "Empleado"
        Me.EmpleadoDataGridViewTextBoxColumn.Name = "EmpleadoDataGridViewTextBoxColumn"
        Me.EmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntradaSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EntradaSalida"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "EntradaSalida"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.VwAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents AsistenciaBindingSource As BindingSource
    Friend WithEvents AsistenciaTableAdapter As BDSistemaEySDataSetTableAdapters.AsistenciaTableAdapter
    Friend WithEvents VwAsistenciaBindingSource As BindingSource
    Friend WithEvents VwAsistenciaTableAdapter As BDSistemaEySDataSetTableAdapters.vwAsistenciaTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAsistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
