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
        Me.HorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.HorarioTableAdapter = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSetTableAdapters.HorarioTableAdapter()
        Me.IdHorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreHorario = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 356)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHorarioDataGridViewTextBoxColumn, Me.nombreHorario, Me.LunesInicioDataGridViewTextBoxColumn, Me.LunesSalidaDataGridViewTextBoxColumn, Me.MartesInicioDataGridViewTextBoxColumn, Me.MartesSalidaDataGridViewTextBoxColumn, Me.MiercolesInicioDataGridViewTextBoxColumn, Me.MiercolesSalidaDataGridViewTextBoxColumn, Me.JuevesInicioDataGridViewTextBoxColumn, Me.JuevesSalidaDataGridViewTextBoxColumn, Me.ViernesInicioDataGridViewTextBoxColumn, Me.ViernesSalidaDataGridViewTextBoxColumn, Me.SabadoInicioDataGridViewTextBoxColumn, Me.SabadoSalidaDataGridViewTextBoxColumn, Me.DomingoInicioDataGridViewTextBoxColumn, Me.DomingoSalidaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HorarioBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(476, 314)
        Me.DataGridView1.TabIndex = 6
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDelete, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnEdit, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAdd, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 314)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(476, 42)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDelete.Location = New System.Drawing.Point(393, 9)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 0
        Me.BtnDelete.Text = "Eliminar"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEdit.Location = New System.Drawing.Point(303, 9)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.Text = "Editar"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdd.Location = New System.Drawing.Point(216, 9)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Añadir"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'HorarioTableAdapter
        '
        Me.HorarioTableAdapter.ClearBeforeFill = True
        '
        'IdHorarioDataGridViewTextBoxColumn
        '
        Me.IdHorarioDataGridViewTextBoxColumn.DataPropertyName = "idHorario"
        Me.IdHorarioDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdHorarioDataGridViewTextBoxColumn.Name = "IdHorarioDataGridViewTextBoxColumn"
        Me.IdHorarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'nombreHorario
        '
        Me.nombreHorario.DataPropertyName = "nombreHorario"
        Me.nombreHorario.HeaderText = "Nombre"
        Me.nombreHorario.Name = "nombreHorario"
        Me.nombreHorario.ReadOnly = True
        '
        'LunesInicioDataGridViewTextBoxColumn
        '
        Me.LunesInicioDataGridViewTextBoxColumn.DataPropertyName = "lunesInicio"
        Me.LunesInicioDataGridViewTextBoxColumn.HeaderText = "Lunes Inicio"
        Me.LunesInicioDataGridViewTextBoxColumn.Name = "LunesInicioDataGridViewTextBoxColumn"
        Me.LunesInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LunesSalidaDataGridViewTextBoxColumn
        '
        Me.LunesSalidaDataGridViewTextBoxColumn.DataPropertyName = "lunesSalida"
        Me.LunesSalidaDataGridViewTextBoxColumn.HeaderText = "Lunes Salida"
        Me.LunesSalidaDataGridViewTextBoxColumn.Name = "LunesSalidaDataGridViewTextBoxColumn"
        Me.LunesSalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MartesInicioDataGridViewTextBoxColumn
        '
        Me.MartesInicioDataGridViewTextBoxColumn.DataPropertyName = "martesInicio"
        Me.MartesInicioDataGridViewTextBoxColumn.HeaderText = "Martes Inicio"
        Me.MartesInicioDataGridViewTextBoxColumn.Name = "MartesInicioDataGridViewTextBoxColumn"
        Me.MartesInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MartesSalidaDataGridViewTextBoxColumn
        '
        Me.MartesSalidaDataGridViewTextBoxColumn.DataPropertyName = "martesSalida"
        Me.MartesSalidaDataGridViewTextBoxColumn.HeaderText = "Martes Salida"
        Me.MartesSalidaDataGridViewTextBoxColumn.Name = "MartesSalidaDataGridViewTextBoxColumn"
        Me.MartesSalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiercolesInicioDataGridViewTextBoxColumn
        '
        Me.MiercolesInicioDataGridViewTextBoxColumn.DataPropertyName = "miercolesInicio"
        Me.MiercolesInicioDataGridViewTextBoxColumn.HeaderText = "Miércoles Inicio"
        Me.MiercolesInicioDataGridViewTextBoxColumn.Name = "MiercolesInicioDataGridViewTextBoxColumn"
        Me.MiercolesInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiercolesSalidaDataGridViewTextBoxColumn
        '
        Me.MiercolesSalidaDataGridViewTextBoxColumn.DataPropertyName = "miercolesSalida"
        Me.MiercolesSalidaDataGridViewTextBoxColumn.HeaderText = "Miércoles Salida"
        Me.MiercolesSalidaDataGridViewTextBoxColumn.Name = "MiercolesSalidaDataGridViewTextBoxColumn"
        Me.MiercolesSalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JuevesInicioDataGridViewTextBoxColumn
        '
        Me.JuevesInicioDataGridViewTextBoxColumn.DataPropertyName = "juevesInicio"
        Me.JuevesInicioDataGridViewTextBoxColumn.HeaderText = "Jueves Inicio"
        Me.JuevesInicioDataGridViewTextBoxColumn.Name = "JuevesInicioDataGridViewTextBoxColumn"
        Me.JuevesInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JuevesSalidaDataGridViewTextBoxColumn
        '
        Me.JuevesSalidaDataGridViewTextBoxColumn.DataPropertyName = "juevesSalida"
        Me.JuevesSalidaDataGridViewTextBoxColumn.HeaderText = "Jueves Salida"
        Me.JuevesSalidaDataGridViewTextBoxColumn.Name = "JuevesSalidaDataGridViewTextBoxColumn"
        Me.JuevesSalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViernesInicioDataGridViewTextBoxColumn
        '
        Me.ViernesInicioDataGridViewTextBoxColumn.DataPropertyName = "viernesInicio"
        Me.ViernesInicioDataGridViewTextBoxColumn.HeaderText = "Viernes Inicio"
        Me.ViernesInicioDataGridViewTextBoxColumn.Name = "ViernesInicioDataGridViewTextBoxColumn"
        Me.ViernesInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViernesSalidaDataGridViewTextBoxColumn
        '
        Me.ViernesSalidaDataGridViewTextBoxColumn.DataPropertyName = "viernesSalida"
        Me.ViernesSalidaDataGridViewTextBoxColumn.HeaderText = "Viernes Salida"
        Me.ViernesSalidaDataGridViewTextBoxColumn.Name = "ViernesSalidaDataGridViewTextBoxColumn"
        Me.ViernesSalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SabadoInicioDataGridViewTextBoxColumn
        '
        Me.SabadoInicioDataGridViewTextBoxColumn.DataPropertyName = "sabadoInicio"
        Me.SabadoInicioDataGridViewTextBoxColumn.HeaderText = "Sábado Inicio"
        Me.SabadoInicioDataGridViewTextBoxColumn.Name = "SabadoInicioDataGridViewTextBoxColumn"
        Me.SabadoInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SabadoSalidaDataGridViewTextBoxColumn
        '
        Me.SabadoSalidaDataGridViewTextBoxColumn.DataPropertyName = "sabadoSalida"
        Me.SabadoSalidaDataGridViewTextBoxColumn.HeaderText = "Sábado Salida"
        Me.SabadoSalidaDataGridViewTextBoxColumn.Name = "SabadoSalidaDataGridViewTextBoxColumn"
        Me.SabadoSalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DomingoInicioDataGridViewTextBoxColumn
        '
        Me.DomingoInicioDataGridViewTextBoxColumn.DataPropertyName = "domingoInicio"
        Me.DomingoInicioDataGridViewTextBoxColumn.HeaderText = "Domingo Inicio"
        Me.DomingoInicioDataGridViewTextBoxColumn.Name = "DomingoInicioDataGridViewTextBoxColumn"
        Me.DomingoInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DomingoSalidaDataGridViewTextBoxColumn
        '
        Me.DomingoSalidaDataGridViewTextBoxColumn.DataPropertyName = "domingoSalida"
        Me.DomingoSalidaDataGridViewTextBoxColumn.HeaderText = "Domingo Salida"
        Me.DomingoSalidaDataGridViewTextBoxColumn.Name = "DomingoSalidaDataGridViewTextBoxColumn"
        Me.DomingoSalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HorarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 376)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HorarioForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "HorarioFomr"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents HorarioBindingSource As BindingSource
    Friend WithEvents HorarioTableAdapter As BDSistemaEySDataSetTableAdapters.HorarioTableAdapter
    Friend WithEvents IdHorarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreHorario As DataGridViewTextBoxColumn
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
