<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolVacacionesForm
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
        Me.SolVacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSet()
        Me.SolVacacionesTableAdapter = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSetTableAdapters.SolVacacionesTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.IdSolVacacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionSolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHoraInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHoraFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SolVacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SolVacacionesBindingSource
        '
        Me.SolVacacionesBindingSource.DataMember = "SolVacaciones"
        Me.SolVacacionesBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SolVacacionesTableAdapter
        '
        Me.SolVacacionesTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSolVacacionesDataGridViewTextBoxColumn, Me.FechaSolDataGridViewTextBoxColumn, Me.DescripcionSolDataGridViewTextBoxColumn, Me.FechaHoraInicioDataGridViewTextBoxColumn, Me.FechaHoraFinDataGridViewTextBoxColumn, Me.IdEmpleadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SolVacacionesBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(10, 10)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(453, 264)
        Me.DataGridView1.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAdd, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnEdit, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDelete, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(453, 42)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdd.Location = New System.Drawing.Point(191, 9)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Añadir"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEdit.Location = New System.Drawing.Point(277, 9)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.Text = "Editar"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDelete.Location = New System.Drawing.Point(368, 9)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 0
        Me.BtnDelete.Text = "Eliminar"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'IdSolVacacionesDataGridViewTextBoxColumn
        '
        Me.IdSolVacacionesDataGridViewTextBoxColumn.DataPropertyName = "idSolVacaciones"
        Me.IdSolVacacionesDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdSolVacacionesDataGridViewTextBoxColumn.Name = "IdSolVacacionesDataGridViewTextBoxColumn"
        Me.IdSolVacacionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaSolDataGridViewTextBoxColumn
        '
        Me.FechaSolDataGridViewTextBoxColumn.DataPropertyName = "fechaSol"
        Me.FechaSolDataGridViewTextBoxColumn.HeaderText = "Fecha de Solicitud"
        Me.FechaSolDataGridViewTextBoxColumn.Name = "FechaSolDataGridViewTextBoxColumn"
        Me.FechaSolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionSolDataGridViewTextBoxColumn
        '
        Me.DescripcionSolDataGridViewTextBoxColumn.DataPropertyName = "descripcionSol"
        Me.DescripcionSolDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionSolDataGridViewTextBoxColumn.Name = "DescripcionSolDataGridViewTextBoxColumn"
        Me.DescripcionSolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaHoraInicioDataGridViewTextBoxColumn
        '
        Me.FechaHoraInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaHoraInicio"
        Me.FechaHoraInicioDataGridViewTextBoxColumn.HeaderText = "Inicio"
        Me.FechaHoraInicioDataGridViewTextBoxColumn.Name = "FechaHoraInicioDataGridViewTextBoxColumn"
        Me.FechaHoraInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaHoraFinDataGridViewTextBoxColumn
        '
        Me.FechaHoraFinDataGridViewTextBoxColumn.DataPropertyName = "fechaHoraFin"
        Me.FechaHoraFinDataGridViewTextBoxColumn.HeaderText = "Fin"
        Me.FechaHoraFinDataGridViewTextBoxColumn.Name = "FechaHoraFinDataGridViewTextBoxColumn"
        Me.FechaHoraFinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "ID Empleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SolVacacionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 326)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SolVacacionesForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "SolVacacionesFomr"
        CType(Me.SolVacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents SolVacacionesBindingSource As BindingSource
    Friend WithEvents SolVacacionesTableAdapter As BDSistemaEySDataSetTableAdapters.SolVacacionesTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents IdSolVacacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionSolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaHoraInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaHoraFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
