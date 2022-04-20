<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asistencia
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
        Me.timeSystem = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.timeNow = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeSystem
        '
        Me.timeSystem.AutoSize = True
        Me.timeSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeSystem.Location = New System.Drawing.Point(117, 123)
        Me.timeSystem.Name = "timeSystem"
        Me.timeSystem.Size = New System.Drawing.Size(32, 13)
        Me.timeSystem.TabIndex = 0
        Me.timeSystem.Text = "hora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bienvenido empleado ******"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Marcar  Entrada"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(206, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Marcar  Salida"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 243)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'timeNow
        '
        Me.timeNow.Enabled = True
        Me.timeNow.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox1.Location = New System.Drawing.Point(103, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 278)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.timeSystem)
        Me.Name = "asistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistencia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timeSystem As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents timeNow As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
