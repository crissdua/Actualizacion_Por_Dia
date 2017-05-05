<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExBodega = New System.Windows.Forms.Button()
        Me.BtnHistServ = New System.Windows.Forms.Button()
        Me.BtnUsoMaq = New System.Windows.Forms.Button()
        Me.BtnSaldos = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BtnDetener = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnMinimizar.Location = New System.Drawing.Point(181, 165)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMinimizar.TabIndex = 19
        Me.BtnMinimizar.Text = "Minimizar"
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnExBodega)
        Me.Panel1.Controls.Add(Me.BtnHistServ)
        Me.Panel1.Controls.Add(Me.BtnUsoMaq)
        Me.Panel1.Controls.Add(Me.BtnSaldos)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 127)
        Me.Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Actualizando!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnExBodega
        '
        Me.BtnExBodega.Location = New System.Drawing.Point(184, 7)
        Me.BtnExBodega.Name = "BtnExBodega"
        Me.BtnExBodega.Size = New System.Drawing.Size(75, 48)
        Me.BtnExBodega.TabIndex = 17
        Me.BtnExBodega.Text = "Existencia de Bodegas"
        Me.BtnExBodega.UseVisualStyleBackColor = True
        '
        'BtnHistServ
        '
        Me.BtnHistServ.Location = New System.Drawing.Point(262, 7)
        Me.BtnHistServ.Name = "BtnHistServ"
        Me.BtnHistServ.Size = New System.Drawing.Size(75, 48)
        Me.BtnHistServ.TabIndex = 16
        Me.BtnHistServ.Text = "Historial de Servicios"
        Me.BtnHistServ.UseVisualStyleBackColor = True
        '
        'BtnUsoMaq
        '
        Me.BtnUsoMaq.Location = New System.Drawing.Point(99, 7)
        Me.BtnUsoMaq.Name = "BtnUsoMaq"
        Me.BtnUsoMaq.Size = New System.Drawing.Size(79, 48)
        Me.BtnUsoMaq.TabIndex = 15
        Me.BtnUsoMaq.Text = "Uso de Maquina"
        Me.BtnUsoMaq.UseVisualStyleBackColor = True
        '
        'BtnSaldos
        '
        Me.BtnSaldos.Location = New System.Drawing.Point(14, 7)
        Me.BtnSaldos.Name = "BtnSaldos"
        Me.BtnSaldos.Size = New System.Drawing.Size(79, 48)
        Me.BtnSaldos.TabIndex = 0
        Me.BtnSaldos.Text = "Saldos"
        Me.BtnSaldos.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Location = New System.Drawing.Point(-2, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 125)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "B1if"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(368, 28)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Fecha Seleccionada:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(495, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "IF+C4C"
        Me.NotifyIcon1.Visible = True
        '
        'BtnDetener
        '
        Me.BtnDetener.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnDetener.Location = New System.Drawing.Point(100, 165)
        Me.BtnDetener.Name = "BtnDetener"
        Me.BtnDetener.Size = New System.Drawing.Size(75, 23)
        Me.BtnDetener.TabIndex = 24
        Me.BtnDetener.Text = "Detener"
        Me.BtnDetener.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'BtnIniciar
        '
        Me.BtnIniciar.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnIniciar.Location = New System.Drawing.Point(100, 165)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.BtnIniciar.TabIndex = 25
        Me.BtnIniciar.Text = "Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(583, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca De"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Actualizacion_Por_Dia.My.Resources.Resources.logosolutionsap
        Me.PictureBox1.Location = New System.Drawing.Point(0, 195)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 228)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.BtnDetener)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.BtnMinimizar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = " IF+C4C    Camiones y Motores S,A"
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSaldos As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnUsoMaq As Button
    Friend WithEvents BtnHistServ As Button
    Friend WithEvents BtnExBodega As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents BtnDetener As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
