<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExit, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.46925!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.53075!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(419, 506)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnEnter, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(39, 278)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(341, 170)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'btnEnter
        '
        Me.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Image = CType(resources.GetObject("btnEnter.Image"), System.Drawing.Image)
        Me.btnEnter.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnEnter.Location = New System.Drawing.Point(130, 122)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(81, 38)
        Me.btnEnter.TabIndex = 8
        Me.btnEnter.Text = "Entrar"
        Me.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.75392!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.24609!))
        Me.TableLayoutPanel4.Controls.Add(Me.txtPassword, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 59)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(335, 50)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(117, 13)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 23)
        Me.txtPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtUser, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(335, 50)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        '
        'txtUser
        '
        Me.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(117, 13)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(200, 23)
        Me.txtUser.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.PictureBox1, 0, 1)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.12676!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.87324!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(412, 261)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "¡Bienvenido!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(123, 231)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Inicio de Sesión"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, 50)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(341, 465)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Salir"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(439, 526)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AdminLogin"
        Me.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador | Login"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnExit As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
