<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class controlCenter
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.timeNow = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.añadir = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaSalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaSalidaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtrasosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorasTrabajadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorasExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorasSuplementariasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorasExtraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovedadesAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 555)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(19, 34)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(872, 430)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.timeNow)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(864, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inicio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'timeNow
        '
        Me.timeNow.AutoSize = True
        Me.timeNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeNow.Location = New System.Drawing.Point(385, 100)
        Me.timeNow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timeNow.Name = "timeNow"
        Me.timeNow.Size = New System.Drawing.Size(57, 17)
        Me.timeNow.TabIndex = 0
        Me.timeNow.Text = "Label1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.añadir)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(864, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Empleados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(735, 362)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Elminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(627, 362)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'añadir
        '
        Me.añadir.Location = New System.Drawing.Point(519, 362)
        Me.añadir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.añadir.Name = "añadir"
        Me.añadir.Size = New System.Drawing.Size(100, 28)
        Me.añadir.TabIndex = 0
        Me.añadir.Text = "Añadir"
        Me.añadir.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(864, 401)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Horarios"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchviosToolStripMenuItem, Me.TablasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(891, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchviosToolStripMenuItem
        '
        Me.ArchviosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchviosToolStripMenuItem.Name = "ArchviosToolStripMenuItem"
        Me.ArchviosToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.ArchviosToolStripMenuItem.Text = "Archivos"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TablasToolStripMenuItem
        '
        Me.TablasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.HorariosToolStripMenuItem, Me.EntradaSalidaToolStripMenuItem})
        Me.TablasToolStripMenuItem.Name = "TablasToolStripMenuItem"
        Me.TablasToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.TablasToolStripMenuItem.Text = "Tablas"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'EntradaSalidaToolStripMenuItem
        '
        Me.EntradaSalidaToolStripMenuItem.Name = "EntradaSalidaToolStripMenuItem"
        Me.EntradaSalidaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EntradaSalidaToolStripMenuItem.Text = "Entrada/Salida"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradaSalidaToolStripMenuItem1, Me.AtrasosToolStripMenuItem, Me.HorasTrabajadasToolStripMenuItem, Me.HorasExtraToolStripMenuItem, Me.HorasSuplementariasToolStripMenuItem, Me.HorasExtraToolStripMenuItem1, Me.NovedadesAsistenciaToolStripMenuItem, Me.PermisosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EntradaSalidaToolStripMenuItem1
        '
        Me.EntradaSalidaToolStripMenuItem1.Name = "EntradaSalidaToolStripMenuItem1"
        Me.EntradaSalidaToolStripMenuItem1.Size = New System.Drawing.Size(235, 26)
        Me.EntradaSalidaToolStripMenuItem1.Text = "Entrada/Salida"
        '
        'AtrasosToolStripMenuItem
        '
        Me.AtrasosToolStripMenuItem.Name = "AtrasosToolStripMenuItem"
        Me.AtrasosToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.AtrasosToolStripMenuItem.Text = "Atrasos"
        '
        'HorasTrabajadasToolStripMenuItem
        '
        Me.HorasTrabajadasToolStripMenuItem.Name = "HorasTrabajadasToolStripMenuItem"
        Me.HorasTrabajadasToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.HorasTrabajadasToolStripMenuItem.Text = "Horas trabajadas"
        '
        'HorasExtraToolStripMenuItem
        '
        Me.HorasExtraToolStripMenuItem.Name = "HorasExtraToolStripMenuItem"
        Me.HorasExtraToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.HorasExtraToolStripMenuItem.Text = "Horas extra"
        '
        'HorasSuplementariasToolStripMenuItem
        '
        Me.HorasSuplementariasToolStripMenuItem.Name = "HorasSuplementariasToolStripMenuItem"
        Me.HorasSuplementariasToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.HorasSuplementariasToolStripMenuItem.Text = "Horas suplementarias"
        '
        'HorasExtraToolStripMenuItem1
        '
        Me.HorasExtraToolStripMenuItem1.Name = "HorasExtraToolStripMenuItem1"
        Me.HorasExtraToolStripMenuItem1.Size = New System.Drawing.Size(235, 26)
        Me.HorasExtraToolStripMenuItem1.Text = "Ausencias"
        '
        'NovedadesAsistenciaToolStripMenuItem
        '
        Me.NovedadesAsistenciaToolStripMenuItem.Name = "NovedadesAsistenciaToolStripMenuItem"
        Me.NovedadesAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.NovedadesAsistenciaToolStripMenuItem.Text = "Novedades asistencia"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de usuario"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'controlCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 478)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "controlCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Control"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchviosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TablasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaSalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaSalidaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AtrasosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorasTrabajadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorasExtraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorasSuplementariasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorasExtraToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NovedadesAsistenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents timeNow As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents añadir As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Timer1 As Timer
End Class
