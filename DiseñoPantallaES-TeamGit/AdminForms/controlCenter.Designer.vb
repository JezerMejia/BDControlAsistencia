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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.timeNow = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 451)
        Me.Panel1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ArchviosToolStripMenuItem
        '
        Me.ArchviosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchviosToolStripMenuItem.Name = "ArchviosToolStripMenuItem"
        Me.ArchviosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchviosToolStripMenuItem.Text = "Archivos"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TablasToolStripMenuItem
        '
        Me.TablasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.HorariosToolStripMenuItem, Me.EntradaSalidaToolStripMenuItem})
        Me.TablasToolStripMenuItem.Name = "TablasToolStripMenuItem"
        Me.TablasToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.TablasToolStripMenuItem.Text = "Tablas"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'EntradaSalidaToolStripMenuItem
        '
        Me.EntradaSalidaToolStripMenuItem.Name = "EntradaSalidaToolStripMenuItem"
        Me.EntradaSalidaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EntradaSalidaToolStripMenuItem.Text = "Entrada/Salida"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradaSalidaToolStripMenuItem1, Me.AtrasosToolStripMenuItem, Me.HorasTrabajadasToolStripMenuItem, Me.HorasExtraToolStripMenuItem, Me.HorasSuplementariasToolStripMenuItem, Me.HorasExtraToolStripMenuItem1, Me.NovedadesAsistenciaToolStripMenuItem, Me.PermisosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EntradaSalidaToolStripMenuItem1
        '
        Me.EntradaSalidaToolStripMenuItem1.Name = "EntradaSalidaToolStripMenuItem1"
        Me.EntradaSalidaToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.EntradaSalidaToolStripMenuItem1.Text = "Entrada/Salida"
        '
        'AtrasosToolStripMenuItem
        '
        Me.AtrasosToolStripMenuItem.Name = "AtrasosToolStripMenuItem"
        Me.AtrasosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AtrasosToolStripMenuItem.Text = "Atrasos"
        '
        'HorasTrabajadasToolStripMenuItem
        '
        Me.HorasTrabajadasToolStripMenuItem.Name = "HorasTrabajadasToolStripMenuItem"
        Me.HorasTrabajadasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.HorasTrabajadasToolStripMenuItem.Text = "Horas trabajadas"
        '
        'HorasExtraToolStripMenuItem
        '
        Me.HorasExtraToolStripMenuItem.Name = "HorasExtraToolStripMenuItem"
        Me.HorasExtraToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.HorasExtraToolStripMenuItem.Text = "Horas extra"
        '
        'HorasSuplementariasToolStripMenuItem
        '
        Me.HorasSuplementariasToolStripMenuItem.Name = "HorasSuplementariasToolStripMenuItem"
        Me.HorasSuplementariasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.HorasSuplementariasToolStripMenuItem.Text = "Horas suplementarias"
        '
        'HorasExtraToolStripMenuItem1
        '
        Me.HorasExtraToolStripMenuItem1.Name = "HorasExtraToolStripMenuItem1"
        Me.HorasExtraToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.HorasExtraToolStripMenuItem1.Text = "Ausencias"
        '
        'NovedadesAsistenciaToolStripMenuItem
        '
        Me.NovedadesAsistenciaToolStripMenuItem.Name = "NovedadesAsistenciaToolStripMenuItem"
        Me.NovedadesAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.NovedadesAsistenciaToolStripMenuItem.Text = "Novedades asistencia"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de usuario"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchviosToolStripMenuItem, Me.TablasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.timeNow)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(646, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inicio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'timeNow
        '
        Me.timeNow.AutoSize = True
        Me.timeNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeNow.Location = New System.Drawing.Point(289, 81)
        Me.timeNow.Name = "timeNow"
        Me.timeNow.Size = New System.Drawing.Size(45, 13)
        Me.timeNow.TabIndex = 0
        Me.timeNow.Text = "Label1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(14, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(654, 349)
        Me.TabControl1.TabIndex = 1
        '
        'controlCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 388)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "controlCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Control"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents timeNow As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchviosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TablasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaSalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaSalidaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AtrasosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorasTrabajadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorasExtraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorasSuplementariasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorasExtraToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NovedadesAsistenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As ToolStripMenuItem
End Class
