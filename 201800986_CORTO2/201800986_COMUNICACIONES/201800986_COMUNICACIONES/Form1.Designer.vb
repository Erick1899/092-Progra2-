<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBoxArticulos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBoxSueldo = New System.Windows.Forms.TextBox()
        Me.TBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonLimpiarVectores = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonLimpiarEntradas = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelComisión = New System.Windows.Forms.Label()
        Me.LabelBono = New System.Windows.Forms.Label()
        Me.LabelSueldoFinal = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBoxArticulos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBoxSueldo)
        Me.GroupBox1.Controls.Add(Me.TBoxNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Datos del Vendedor "
        '
        'CBoxArticulos
        '
        Me.CBoxArticulos.FormattingEnabled = True
        Me.CBoxArticulos.Items.AddRange(New Object() {"Tablet", "Drone", "Celular ", "Televisor "})
        Me.CBoxArticulos.Location = New System.Drawing.Point(153, 102)
        Me.CBoxArticulos.Name = "CBoxArticulos"
        Me.CBoxArticulos.Size = New System.Drawing.Size(145, 21)
        Me.CBoxArticulos.TabIndex = 5
        Me.CBoxArticulos.Text = "Seleccione Articulo "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Articulo Vendido"
        '
        'TBoxSueldo
        '
        Me.TBoxSueldo.Location = New System.Drawing.Point(153, 68)
        Me.TBoxSueldo.Name = "TBoxSueldo"
        Me.TBoxSueldo.Size = New System.Drawing.Size(224, 20)
        Me.TBoxSueldo.TabIndex = 3
        '
        'TBoxNombre
        '
        Me.TBoxNombre.Location = New System.Drawing.Point(153, 33)
        Me.TBoxNombre.Name = "TBoxNombre"
        Me.TBoxNombre.Size = New System.Drawing.Size(226, 20)
        Me.TBoxNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sueldo del Vendedor  "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Vendedor "
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(425, 52)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 32)
        Me.ButtonCalcular.TabIndex = 1
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'ButtonLimpiarVectores
        '
        Me.ButtonLimpiarVectores.Location = New System.Drawing.Point(408, 142)
        Me.ButtonLimpiarVectores.Name = "ButtonLimpiarVectores"
        Me.ButtonLimpiarVectores.Size = New System.Drawing.Size(118, 35)
        Me.ButtonLimpiarVectores.TabIndex = 2
        Me.ButtonLimpiarVectores.Text = "Limpiar Vectores"
        Me.ButtonLimpiarVectores.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelSueldoFinal)
        Me.GroupBox2.Controls.Add(Me.LabelBono)
        Me.GroupBox2.Controls.Add(Me.LabelComisión)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(549, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del Vendedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Sueldo Final "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Bono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Comisión "
        '
        'ButtonLimpiarEntradas
        '
        Me.ButtonLimpiarEntradas.Location = New System.Drawing.Point(425, 90)
        Me.ButtonLimpiarEntradas.Name = "ButtonLimpiarEntradas"
        Me.ButtonLimpiarEntradas.Size = New System.Drawing.Size(91, 46)
        Me.ButtonLimpiarEntradas.TabIndex = 4
        Me.ButtonLimpiarEntradas.Text = "Limpiar Entradas"
        Me.ButtonLimpiarEntradas.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(97, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Q."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Q."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(97, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Q."
        '
        'LabelComisión
        '
        Me.LabelComisión.AutoSize = True
        Me.LabelComisión.Location = New System.Drawing.Point(121, 30)
        Me.LabelComisión.Name = "LabelComisión"
        Me.LabelComisión.Size = New System.Drawing.Size(28, 13)
        Me.LabelComisión.TabIndex = 6
        Me.LabelComisión.Text = "0.00"
        '
        'LabelBono
        '
        Me.LabelBono.AutoSize = True
        Me.LabelBono.Location = New System.Drawing.Point(121, 55)
        Me.LabelBono.Name = "LabelBono"
        Me.LabelBono.Size = New System.Drawing.Size(28, 13)
        Me.LabelBono.TabIndex = 7
        Me.LabelBono.Text = "0.00"
        '
        'LabelSueldoFinal
        '
        Me.LabelSueldoFinal.AutoSize = True
        Me.LabelSueldoFinal.Location = New System.Drawing.Point(121, 79)
        Me.LabelSueldoFinal.Name = "LabelSueldoFinal"
        Me.LabelSueldoFinal.Size = New System.Drawing.Size(28, 13)
        Me.LabelSueldoFinal.TabIndex = 8
        Me.LabelSueldoFinal.Text = "0.00"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(11, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(116, 95)
        Me.ListBox1.TabIndex = 5
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(133, 42)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 6
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(259, 42)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 7
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(385, 42)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 95)
        Me.ListBox4.TabIndex = 8
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(511, 42)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(120, 95)
        Me.ListBox5.TabIndex = 9
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.Location = New System.Drawing.Point(637, 42)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(120, 95)
        Me.ListBox6.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(133, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Sueldo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(259, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Articulo  Vendido"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(382, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Comisión"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(508, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Bono"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(637, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Sueldo Final "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox5)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.ListBox2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.ListBox3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.ListBox4)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ListBox6)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(768, 154)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 354)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ButtonLimpiarEntradas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonLimpiarVectores)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "COMUNICACIONES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBoxSueldo As System.Windows.Forms.TextBox
    Friend WithEvents TBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCalcular As System.Windows.Forms.Button
    Friend WithEvents ButtonLimpiarVectores As System.Windows.Forms.Button
    Friend WithEvents CBoxArticulos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonLimpiarEntradas As System.Windows.Forms.Button
    Friend WithEvents LabelSueldoFinal As System.Windows.Forms.Label
    Friend WithEvents LabelBono As System.Windows.Forms.Label
    Friend WithEvents LabelComisión As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox6 As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
