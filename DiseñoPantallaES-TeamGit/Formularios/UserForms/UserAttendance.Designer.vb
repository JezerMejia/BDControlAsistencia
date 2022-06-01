<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserAttendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAttendance))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbFechaHora = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMarkEnter = New System.Windows.Forms.Button()
        Me.btnMarkExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFechaHora, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(317, 291)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lbFechaHora
        '
        Me.lbFechaHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbFechaHora.AutoSize = True
        Me.lbFechaHora.Location = New System.Drawing.Point(115, 134)
        Me.lbFechaHora.Name = "lbFechaHora"
        Me.lbFechaHora.Size = New System.Drawing.Size(86, 13)
        Me.lbFechaHora.TabIndex = 4
        Me.lbFechaHora.Text = "LabelFechaHora"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnMarkEnter, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnMarkExit, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 197)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(313, 58)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnMarkEnter
        '
        Me.btnMarkEnter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMarkEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarkEnter.Image = CType(resources.GetObject("btnMarkEnter.Image"), System.Drawing.Image)
        Me.btnMarkEnter.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnMarkEnter.Location = New System.Drawing.Point(8, 11)
        Me.btnMarkEnter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMarkEnter.Name = "btnMarkEnter"
        Me.btnMarkEnter.Size = New System.Drawing.Size(140, 36)
        Me.btnMarkEnter.TabIndex = 0
        Me.btnMarkEnter.Text = "Marcar Entrada"
        Me.btnMarkEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMarkEnter.UseVisualStyleBackColor = True
        '
        'btnMarkExit
        '
        Me.btnMarkExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMarkExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarkExit.Image = CType(resources.GetObject("btnMarkExit.Image"), System.Drawing.Image)
        Me.btnMarkExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarkExit.Location = New System.Drawing.Point(167, 11)
        Me.btnMarkExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMarkExit.Name = "btnMarkExit"
        Me.btnMarkExit.Size = New System.Drawing.Size(134, 36)
        Me.btnMarkExit.TabIndex = 1
        Me.btnMarkExit.Text = "Marcar Salida"
        Me.btnMarkExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMarkExit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'UserAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(337, 311)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(303, 331)
        Me.Name = "UserAttendance"
        Me.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado | Marcar Asistencia"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbFechaHora As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnMarkEnter As Button
    Friend WithEvents btnMarkExit As Button
End Class
