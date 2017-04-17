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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Entry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(134, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Entry, Me.Nombre, Me.Saldo})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 113)
        Me.DataGridView1.TabIndex = 18
        '
        'Entry
        '
        Me.Entry.HeaderText = "CardCode"
        Me.Entry.Name = "Entry"
        Me.Entry.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 139)
        Me.Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(49, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 41)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Carga Masiva Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Location = New System.Drawing.Point(-2, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 139)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "B1if"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(379, 58)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Fecha Seleccionada:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(507, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 318)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Entry As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
