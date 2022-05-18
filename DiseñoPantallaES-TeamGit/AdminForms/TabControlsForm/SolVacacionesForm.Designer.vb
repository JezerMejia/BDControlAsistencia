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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BDSistemaEySDataSet = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSet()
        Me.SolVacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolVacacionesTableAdapter = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSetTableAdapters.SolVacacionesTableAdapter()
        Me.IdSolVacacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionSolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHoraInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHoraFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolVacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSolVacacionesDataGridViewTextBoxColumn, Me.FechaSolDataGridViewTextBoxColumn, Me.DescripcionSolDataGridViewTextBoxColumn, Me.FechaHoraInicioDataGridViewTextBoxColumn, Me.FechaHoraFinDataGridViewTextBoxColumn, Me.IdEmpleadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SolVacacionesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(770, 385)
        Me.DataGridView1.TabIndex = 4
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(785, 15)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(15, 385)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 15)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(15, 385)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(800, 15)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 400)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 50)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(536, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(621, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(709, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SolVacacionesBindingSource
        '
        Me.SolVacacionesBindingSource.DataMember = "SolVacaciones"
        Me.SolVacacionesBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'SolVacacionesTableAdapter
        '
        Me.SolVacacionesTableAdapter.ClearBeforeFill = True
        '
        'IdSolVacacionesDataGridViewTextBoxColumn
        '
        Me.IdSolVacacionesDataGridViewTextBoxColumn.DataPropertyName = "idSolVacaciones"
        Me.IdSolVacacionesDataGridViewTextBoxColumn.HeaderText = "idSolVacaciones"
        Me.IdSolVacacionesDataGridViewTextBoxColumn.Name = "IdSolVacacionesDataGridViewTextBoxColumn"
        Me.IdSolVacacionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaSolDataGridViewTextBoxColumn
        '
        Me.FechaSolDataGridViewTextBoxColumn.DataPropertyName = "fechaSol"
        Me.FechaSolDataGridViewTextBoxColumn.HeaderText = "fechaSol"
        Me.FechaSolDataGridViewTextBoxColumn.Name = "FechaSolDataGridViewTextBoxColumn"
        '
        'DescripcionSolDataGridViewTextBoxColumn
        '
        Me.DescripcionSolDataGridViewTextBoxColumn.DataPropertyName = "descripcionSol"
        Me.DescripcionSolDataGridViewTextBoxColumn.HeaderText = "descripcionSol"
        Me.DescripcionSolDataGridViewTextBoxColumn.Name = "DescripcionSolDataGridViewTextBoxColumn"
        '
        'FechaHoraInicioDataGridViewTextBoxColumn
        '
        Me.FechaHoraInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaHoraInicio"
        Me.FechaHoraInicioDataGridViewTextBoxColumn.HeaderText = "fechaHoraInicio"
        Me.FechaHoraInicioDataGridViewTextBoxColumn.Name = "FechaHoraInicioDataGridViewTextBoxColumn"
        '
        'FechaHoraFinDataGridViewTextBoxColumn
        '
        Me.FechaHoraFinDataGridViewTextBoxColumn.DataPropertyName = "fechaHoraFin"
        Me.FechaHoraFinDataGridViewTextBoxColumn.HeaderText = "fechaHoraFin"
        Me.FechaHoraFinDataGridViewTextBoxColumn.Name = "FechaHoraFinDataGridViewTextBoxColumn"
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        '
        'SolVacacionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SolVacacionesForm"
        Me.Text = "SolVacacionesFomr"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolVacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents SolVacacionesBindingSource As BindingSource
    Friend WithEvents SolVacacionesTableAdapter As BDSistemaEySDataSetTableAdapters.SolVacacionesTableAdapter
    Friend WithEvents IdSolVacacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionSolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaHoraInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaHoraFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
