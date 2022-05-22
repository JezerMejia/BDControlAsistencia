<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDialogEmp
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.idTxt = New System.Windows.Forms.TextBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.segNombreTxt = New System.Windows.Forms.TextBox()
        Me.apellidoTxt = New System.Windows.Forms.TextBox()
        Me.segApellidoTxt = New System.Windows.Forms.TextBox()
        Me.passwordTxt = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(312, 427)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(179, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(26, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.15106!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.84894!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 349)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(306, 69)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66337!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.33663!))
        Me.TableLayoutPanel3.Controls.Add(Me.id, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.idTxt, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.nombreTxt, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.segNombreTxt, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.apellidoTxt, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.segApellidoTxt, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.passwordTxt, 2, 5)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 63)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(306, 274)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(17, 0)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(18, 13)
        Me.id.TabIndex = 0
        Me.id.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Segundo Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Segundo apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pin"
        '
        'idTxt
        '
        Me.idTxt.Location = New System.Drawing.Point(115, 3)
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(100, 20)
        Me.idTxt.TabIndex = 6
        '
        'nombreTxt
        '
        Me.nombreTxt.Location = New System.Drawing.Point(115, 48)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(100, 20)
        Me.nombreTxt.TabIndex = 7
        '
        'segNombreTxt
        '
        Me.segNombreTxt.Location = New System.Drawing.Point(115, 93)
        Me.segNombreTxt.Name = "segNombreTxt"
        Me.segNombreTxt.Size = New System.Drawing.Size(100, 20)
        Me.segNombreTxt.TabIndex = 8
        '
        'apellidoTxt
        '
        Me.apellidoTxt.Location = New System.Drawing.Point(115, 138)
        Me.apellidoTxt.Name = "apellidoTxt"
        Me.apellidoTxt.Size = New System.Drawing.Size(100, 20)
        Me.apellidoTxt.TabIndex = 9
        '
        'segApellidoTxt
        '
        Me.segApellidoTxt.Location = New System.Drawing.Point(115, 183)
        Me.segApellidoTxt.Name = "segApellidoTxt"
        Me.segApellidoTxt.Size = New System.Drawing.Size(100, 20)
        Me.segApellidoTxt.TabIndex = 10
        '
        'passwordTxt
        '
        Me.passwordTxt.Location = New System.Drawing.Point(115, 228)
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.Size = New System.Drawing.Size(100, 20)
        Me.passwordTxt.TabIndex = 11
        '
        'AddDialogEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 447)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AddDialogEmp"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "AddDialogEmp"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents idTxt As TextBox
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents segNombreTxt As TextBox
    Friend WithEvents apellidoTxt As TextBox
    Friend WithEvents segApellidoTxt As TextBox
    Friend WithEvents passwordTxt As TextBox
End Class
