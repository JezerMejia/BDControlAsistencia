﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Departamento
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtensionDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaEySDataSet = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSet()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.añadir = New System.Windows.Forms.Button()
        Me.editar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.extension = New System.Windows.Forms.Label()
        Me.extensionTxt = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.descripcionTxt = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.buscarTxt = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.Label()
        Me.DepartamentoTableAdapter = New DiseñoPantallaES_TeamGit.BDSistemaEySDataSetTableAdapters.DepartamentoTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(439, 450)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridView1, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel6, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel7, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel8, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70589!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.47059!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(414, 375)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDepartamentoDataGridViewTextBoxColumn, Me.NombreDepartamentoDataGridViewTextBoxColumn, Me.DescripcionDepartamentoDataGridViewTextBoxColumn, Me.ExtensionDepartamentoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DepartamentoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(23, 278)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(388, 94)
        Me.DataGridView1.TabIndex = 12
        '
        'IdDepartamentoDataGridViewTextBoxColumn
        '
        Me.IdDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "idDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.HeaderText = "idDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.Name = "IdDepartamentoDataGridViewTextBoxColumn"
        Me.IdDepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDepartamentoDataGridViewTextBoxColumn
        '
        Me.NombreDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "nombreDepartamento"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.HeaderText = "nombreDepartamento"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.Name = "NombreDepartamentoDataGridViewTextBoxColumn"
        '
        'DescripcionDepartamentoDataGridViewTextBoxColumn
        '
        Me.DescripcionDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "descripcionDepartamento"
        Me.DescripcionDepartamentoDataGridViewTextBoxColumn.HeaderText = "descripcionDepartamento"
        Me.DescripcionDepartamentoDataGridViewTextBoxColumn.Name = "DescripcionDepartamentoDataGridViewTextBoxColumn"
        '
        'ExtensionDepartamentoDataGridViewTextBoxColumn
        '
        Me.ExtensionDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "extensionDepartamento"
        Me.ExtensionDepartamentoDataGridViewTextBoxColumn.HeaderText = "extensionDepartamento"
        Me.ExtensionDepartamentoDataGridViewTextBoxColumn.Name = "ExtensionDepartamentoDataGridViewTextBoxColumn"
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BDSistemaEySDataSet
        '
        'BDSistemaEySDataSet
        '
        Me.BDSistemaEySDataSet.DataSetName = "BDSistemaEySDataSet"
        Me.BDSistemaEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.nuevo, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.añadir, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.editar, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.eliminar, 4, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(23, 168)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(388, 49)
        Me.TableLayoutPanel4.TabIndex = 8
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(147, 20)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(55, 23)
        Me.nuevo.TabIndex = 0
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'añadir
        '
        Me.añadir.Location = New System.Drawing.Point(208, 20)
        Me.añadir.Name = "añadir"
        Me.añadir.Size = New System.Drawing.Size(55, 23)
        Me.añadir.TabIndex = 1
        Me.añadir.Text = "Añadir"
        Me.añadir.UseVisualStyleBackColor = True
        '
        'editar
        '
        Me.editar.Location = New System.Drawing.Point(269, 20)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(55, 23)
        Me.editar.TabIndex = 2
        Me.editar.Text = "Editar"
        Me.editar.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(330, 20)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(55, 23)
        Me.eliminar.TabIndex = 3
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.72619!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.27381!))
        Me.TableLayoutPanel5.Controls.Add(Me.extension, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.extensionTxt, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(23, 58)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(388, 49)
        Me.TableLayoutPanel5.TabIndex = 9
        '
        'extension
        '
        Me.extension.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.extension.AutoSize = True
        Me.extension.Location = New System.Drawing.Point(25, 18)
        Me.extension.Name = "extension"
        Me.extension.Size = New System.Drawing.Size(56, 13)
        Me.extension.TabIndex = 0
        Me.extension.Text = "Extension:"
        '
        'extensionTxt
        '
        Me.extensionTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.extensionTxt.Location = New System.Drawing.Point(87, 14)
        Me.extensionTxt.Name = "extensionTxt"
        Me.extensionTxt.Size = New System.Drawing.Size(114, 20)
        Me.extensionTxt.TabIndex = 7
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.13542!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.86459!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.descripcionTxt, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(23, 113)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(388, 49)
        Me.TableLayoutPanel6.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripcion:"
        '
        'descripcionTxt
        '
        Me.descripcionTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.descripcionTxt.Location = New System.Drawing.Point(88, 3)
        Me.descripcionTxt.Multiline = True
        Me.descripcionTxt.Name = "descripcionTxt"
        Me.descripcionTxt.Size = New System.Drawing.Size(203, 43)
        Me.descripcionTxt.TabIndex = 8
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5567!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.4433!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Button7, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.buscarTxt, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(23, 223)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(388, 49)
        Me.TableLayoutPanel7.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.Location = New System.Drawing.Point(300, 13)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Actualizar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'buscarTxt
        '
        Me.buscarTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.buscarTxt.Location = New System.Drawing.Point(62, 14)
        Me.buscarTxt.Name = "buscarTxt"
        Me.buscarTxt.Size = New System.Drawing.Size(215, 20)
        Me.buscarTxt.TabIndex = 1
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.64948!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.35052!))
        Me.TableLayoutPanel8.Controls.Add(Me.nombreTxt, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.nombre, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(23, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(388, 49)
        Me.TableLayoutPanel8.TabIndex = 13
        '
        'nombreTxt
        '
        Me.nombreTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nombreTxt.Location = New System.Drawing.Point(86, 14)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(114, 20)
        Me.nombreTxt.TabIndex = 8
        '
        'nombre
        '
        Me.nombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(33, 18)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(47, 13)
        Me.nombre.TabIndex = 1
        Me.nombre.Text = "Nombre:"
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'Departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(455, 489)
        Me.Name = "Departamento"
        Me.Text = "Departamento"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents nuevo As Button
    Friend WithEvents añadir As Button
    Friend WithEvents editar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents extension As Label
    Friend WithEvents extensionTxt As TextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents descripcionTxt As TextBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents buscarTxt As TextBox
    Friend WithEvents BDSistemaEySDataSet As BDSistemaEySDataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As BDSistemaEySDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtensionDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents nombre As Label
End Class
