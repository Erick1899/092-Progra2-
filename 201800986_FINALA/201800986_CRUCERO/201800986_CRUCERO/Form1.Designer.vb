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
        Me.TextBoxPersonas = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxNIT = New System.Windows.Forms.TextBox()
        Me.ComboBoxClase = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxCabina = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelTotalPago = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPERARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORDENDECESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATOSDEENTRADAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelPrecioIndividual = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxPersonas)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox1.Controls.Add(Me.TextBoxNIT)
        Me.GroupBox1.Controls.Add(Me.ComboBoxClase)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCabina)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 187)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Datos"
        '
        'TextBoxPersonas
        '
        Me.TextBoxPersonas.Location = New System.Drawing.Point(140, 113)
        Me.TextBoxPersonas.Name = "TextBoxPersonas"
        Me.TextBoxPersonas.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPersonas.TabIndex = 9
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(60, 46)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(180, 20)
        Me.TextBoxNombre.TabIndex = 8
        '
        'TextBoxNIT
        '
        Me.TextBoxNIT.Location = New System.Drawing.Point(60, 20)
        Me.TextBoxNIT.Name = "TextBoxNIT"
        Me.TextBoxNIT.Size = New System.Drawing.Size(180, 20)
        Me.TextBoxNIT.TabIndex = 7
        '
        'ComboBoxClase
        '
        Me.ComboBoxClase.FormattingEnabled = True
        Me.ComboBoxClase.Items.AddRange(New Object() {"Primera Clase", "Segunda Clase"})
        Me.ComboBoxClase.Location = New System.Drawing.Point(60, 146)
        Me.ComboBoxClase.Name = "ComboBoxClase"
        Me.ComboBoxClase.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxClase.TabIndex = 6
        Me.ComboBoxClase.Text = "Seleccione tipo de clase"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Clase"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "No. de Personas a Viajar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cabina"
        '
        'ComboBoxCabina
        '
        Me.ComboBoxCabina.FormattingEnabled = True
        Me.ComboBoxCabina.Items.AddRange(New Object() {"Sencilla", "Doble", "Compartida"})
        Me.ComboBoxCabina.Location = New System.Drawing.Point(60, 79)
        Me.ComboBoxCabina.Name = "ComboBoxCabina"
        Me.ComboBoxCabina.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxCabina.TabIndex = 2
        Me.ComboBoxCabina.Text = "Seleccione el tipo de Cabina"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIT"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelPrecioIndividual)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LabelTotalPago)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos A Pagar de Reserva"
        '
        'LabelTotalPago
        '
        Me.LabelTotalPago.AutoSize = True
        Me.LabelTotalPago.Location = New System.Drawing.Point(171, 69)
        Me.LabelTotalPago.Name = "LabelTotalPago"
        Me.LabelTotalPago.Size = New System.Drawing.Size(28, 13)
        Me.LabelTotalPago.TabIndex = 2
        Me.LabelTotalPago.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(144, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Q. "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total a Pagar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPERARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.CONSULTARToolStripMenuItem, Me.ORDENDECESToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(628, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPERARToolStripMenuItem
        '
        Me.OPERARToolStripMenuItem.Name = "OPERARToolStripMenuItem"
        Me.OPERARToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.OPERARToolStripMenuItem.Text = "OPERAR"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'ORDENDECESToolStripMenuItem
        '
        Me.ORDENDECESToolStripMenuItem.Name = "ORDENDECESToolStripMenuItem"
        Me.ORDENDECESToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.ORDENDECESToolStripMenuItem.Text = "ORDEN DESCENDENTE"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VECTORESToolStripMenuItem, Me.DATOSDEENTRADAToolStripMenuItem})
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'VECTORESToolStripMenuItem
        '
        Me.VECTORESToolStripMenuItem.Name = "VECTORESToolStripMenuItem"
        Me.VECTORESToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.VECTORESToolStripMenuItem.Text = "VECTORES"
        '
        'DATOSDEENTRADAToolStripMenuItem
        '
        Me.DATOSDEENTRADAToolStripMenuItem.Name = "DATOSDEENTRADAToolStripMenuItem"
        Me.DATOSDEENTRADAToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DATOSDEENTRADAToolStripMenuItem.Text = "DATOS DE ENTRADA"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Precio por Persona"
        '
        'LabelPrecioIndividual
        '
        Me.LabelPrecioIndividual.AutoSize = True
        Me.LabelPrecioIndividual.Location = New System.Drawing.Point(171, 33)
        Me.LabelPrecioIndividual.Name = "LabelPrecioIndividual"
        Me.LabelPrecioIndividual.Size = New System.Drawing.Size(28, 13)
        Me.LabelPrecioIndividual.TabIndex = 5
        Me.LabelPrecioIndividual.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(144, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Q. "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(628, 241)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Reserva de Cruceros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPersonas As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNIT As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCabina As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OPERARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ORDENDECESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VECTORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATOSDEENTRADAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelTotalPago As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelPrecioIndividual As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
