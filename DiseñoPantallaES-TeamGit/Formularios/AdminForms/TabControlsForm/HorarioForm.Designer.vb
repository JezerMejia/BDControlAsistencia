<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HorarioForm
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.IdHorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LunesInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LunesSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MartesInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MartesSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiercolesInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiercolesSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JuevesInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JuevesSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViernesInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViernesSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SabadoInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SabadoSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomingoInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomingoSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSet()
        Me.HorarioTableAdapter = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSetTableAdapters.HorarioTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 461)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHorarioDataGridViewTextBoxColumn, Me.LunesInicioDataGridViewTextBoxColumn, Me.LunesSalidaDataGridViewTextBoxColumn, Me.MartesInicioDataGridViewTextBoxColumn, Me.MartesSalidaDataGridViewTextBoxColumn, Me.MiercolesInicioDataGridViewTextBoxColumn, Me.MiercolesSalidaDataGridViewTextBoxColumn, Me.JuevesInicioDataGridViewTextBoxColumn, Me.JuevesSalidaDataGridViewTextBoxColumn, Me.ViernesInicioDataGridViewTextBoxColumn, Me.ViernesSalidaDataGridViewTextBoxColumn, Me.SabadoInicioDataGridViewTextBoxColumn, Me.SabadoSalidaDataGridViewTextBoxColumn, Me.DomingoInicioDataGridViewTextBoxColumn, Me.DomingoSalidaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HorarioBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(15, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(754, 396)
        Me.DataGridView1.TabIndex = 6
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(769, 15)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(15, 396)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 15)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(15, 396)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnEliminar, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 411)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 50)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(696, 20)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 0
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(608, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(521, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Añadir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(784, 15)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'IdHorarioDataGridViewTextBoxColumn
        '
        Me.IdHorarioDataGridViewTextBoxColumn.DataPropertyName = "idHorario"
        Me.IdHorarioDataGridViewTextBoxColumn.HeaderText = "idHorario"
        Me.IdHorarioDataGridViewTextBoxColumn.Name = "IdHorarioDataGridViewTextBoxColumn"
        Me.IdHorarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LunesInicioDataGridViewTextBoxColumn
        '
        Me.LunesInicioDataGridViewTextBoxColumn.DataPropertyName = "lunesInicio"
        Me.LunesInicioDataGridViewTextBoxColumn.HeaderText = "lunesInicio"
        Me.LunesInicioDataGridViewTextBoxColumn.Name = "LunesInicioDataGridViewTextBoxColumn"
        '
        'LunesSalidaDataGridViewTextBoxColumn
        '
        Me.LunesSalidaDataGridViewTextBoxColumn.DataPropertyName = "lunesSalida"
        Me.LunesSalidaDataGridViewTextBoxColumn.HeaderText = "lunesSalida"
        Me.LunesSalidaDataGridViewTextBoxColumn.Name = "LunesSalidaDataGridViewTextBoxColumn"
        '
        'MartesInicioDataGridViewTextBoxColumn
        '
        Me.MartesInicioDataGridViewTextBoxColumn.DataPropertyName = "martesInicio"
        Me.MartesInicioDataGridViewTextBoxColumn.HeaderText = "martesInicio"
        Me.MartesInicioDataGridViewTextBoxColumn.Name = "MartesInicioDataGridViewTextBoxColumn"
        '
        'MartesSalidaDataGridViewTextBoxColumn
        '
        Me.MartesSalidaDataGridViewTextBoxColumn.DataPropertyName = "martesSalida"
        Me.MartesSalidaDataGridViewTextBoxColumn.HeaderText = "martesSalida"
        Me.MartesSalidaDataGridViewTextBoxColumn.Name = "MartesSalidaDataGridViewTextBoxColumn"
        '
        'MiercolesInicioDataGridViewTextBoxColumn
        '
        Me.MiercolesInicioDataGridViewTextBoxColumn.DataPropertyName = "miercolesInicio"
        Me.MiercolesInicioDataGridViewTextBoxColumn.HeaderText = "miercolesInicio"
        Me.MiercolesInicioDataGridViewTextBoxColumn.Name = "MiercolesInicioDataGridViewTextBoxColumn"
        '
        'MiercolesSalidaDataGridViewTextBoxColumn
        '
        Me.MiercolesSalidaDataGridViewTextBoxColumn.DataPropertyName = "miercolesSalida"
        Me.MiercolesSalidaDataGridViewTextBoxColumn.HeaderText = "miercolesSalida"
        Me.MiercolesSalidaDataGridViewTextBoxColumn.Name = "MiercolesSalidaDataGridViewTextBoxColumn"
        '
        'JuevesInicioDataGridViewTextBoxColumn
        '
        Me.JuevesInicioDataGridViewTextBoxColumn.DataPropertyName = "juevesInicio"
        Me.JuevesInicioDataGridViewTextBoxColumn.HeaderText = "juevesInicio"
        Me.JuevesInicioDataGridViewTextBoxColumn.Name = "JuevesInicioDataGridViewTextBoxColumn"
        '
        'JuevesSalidaDataGridViewTextBoxColumn
        '
        Me.JuevesSalidaDataGridViewTextBoxColumn.DataPropertyName = "juevesSalida"
        Me.JuevesSalidaDataGridViewTextBoxColumn.HeaderText = "juevesSalida"
        Me.JuevesSalidaDataGridViewTextBoxColumn.Name = "JuevesSalidaDataGridViewTextBoxColumn"
        '
        'ViernesInicioDataGridViewTextBoxColumn
        '
        Me.ViernesInicioDataGridViewTextBoxColumn.DataPropertyName = "viernesInicio"
        Me.ViernesInicioDataGridViewTextBoxColumn.HeaderText = "viernesInicio"
        Me.ViernesInicioDataGridViewTextBoxColumn.Name = "ViernesInicioDataGridViewTextBoxColumn"
        '
        'ViernesSalidaDataGridViewTextBoxColumn
        '
        Me.ViernesSalidaDataGridViewTextBoxColumn.DataPropertyName = "viernesSalida"
        Me.ViernesSalidaDataGridViewTextBoxColumn.HeaderText = "viernesSalida"
        Me.ViernesSalidaDataGridViewTextBoxColumn.Name = "ViernesSalidaDataGridViewTextBoxColumn"
        '
        'SabadoInicioDataGridViewTextBoxColumn
        '
        Me.SabadoInicioDataGridViewTextBoxColumn.DataPropertyName = "sabadoInicio"
        Me.SabadoInicioDataGridViewTextBoxColumn.HeaderText = "sabadoInicio"
        Me.SabadoInicioDataGridViewTextBoxColumn.Name = "SabadoInicioDataGridViewTextBoxColumn"
        '
        'SabadoSalidaDataGridViewTextBoxColumn
        '
        Me.SabadoSalidaDataGridViewTextBoxColumn.DataPropertyName = "sabadoSalida"
        Me.SabadoSalidaDataGridViewTextBoxColumn.HeaderText = "sabadoSalida"
        Me.SabadoSalidaDataGridViewTextBoxColumn.Name = "SabadoSalidaDataGridViewTextBoxColumn"
        '
        'DomingoInicioDataGridViewTextBoxColumn
        '
        Me.DomingoInicioDataGridViewTextBoxColumn.DataPropertyName = "domingoInicio"
        Me.DomingoInicioDataGridViewTextBoxColumn.HeaderText = "domingoInicio"
        Me.DomingoInicioDataGridViewTextBoxColumn.Name = "DomingoInicioDataGridViewTextBoxColumn"
        '
        'DomingoSalidaDataGridViewTextBoxColumn
        '
        Me.DomingoSalidaDataGridViewTextBoxColumn.DataPropertyName = "domingoSalida"
        Me.DomingoSalidaDataGridViewTextBoxColumn.HeaderText = "domingoSalida"
        Me.DomingoSalidaDataGridViewTextBoxColumn.Name = "DomingoSalidaDataGridViewTextBoxColumn"
        '
        'HorarioBindingSource
        '
        Me.HorarioBindingSource.DataMember = "Horario"
        Me.HorarioBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HorarioTableAdapter
        '
        Me.HorarioTableAdapter.ClearBeforeFill = True
        '
        'HorarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HorarioForm"
        Me.Text = "HorarioFomr"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents HorarioBindingSource As BindingSource
    Friend WithEvents HorarioTableAdapter As BDSistemaEySDataSetTableAdapters.HorarioTableAdapter
    Friend WithEvents IdHorarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LunesInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LunesSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MartesInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MartesSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiercolesInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiercolesSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JuevesInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JuevesSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViernesInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViernesSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SabadoInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SabadoSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomingoInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomingoSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
