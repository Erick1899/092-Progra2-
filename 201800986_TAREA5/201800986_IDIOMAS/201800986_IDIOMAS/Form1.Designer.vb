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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBoxViernes = New System.Windows.Forms.CheckBox()
        Me.CBoxSabado = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RButtonEfectivo = New System.Windows.Forms.RadioButton()
        Me.RButtonCheque = New System.Windows.Forms.RadioButton()
        Me.DateFECHA = New System.Windows.Forms.DateTimePicker()
        Me.TBoxCantidadHoras = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxIdiomas = New System.Windows.Forms.ComboBox()
        Me.TBoxNombre = New System.Windows.Forms.TextBox()
        Me.TBoxCarnet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarDatagridviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGVIdiomas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelDescuento = New System.Windows.Forms.Label()
        Me.LabelParcial = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DGVIdiomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DateFECHA)
        Me.GroupBox1.Controls.Add(Me.TBoxCantidadHoras)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxIdiomas)
        Me.GroupBox1.Controls.Add(Me.TBoxNombre)
        Me.GroupBox1.Controls.Add(Me.TBoxCarnet)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 205)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Datos del Estudiante "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBoxViernes)
        Me.GroupBox3.Controls.Add(Me.CBoxSabado)
        Me.GroupBox3.Location = New System.Drawing.Point(357, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 79)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Días a Recibir el Curso"
        '
        'CBoxViernes
        '
        Me.CBoxViernes.AutoSize = True
        Me.CBoxViernes.Location = New System.Drawing.Point(68, 28)
        Me.CBoxViernes.Name = "CBoxViernes"
        Me.CBoxViernes.Size = New System.Drawing.Size(61, 17)
        Me.CBoxViernes.TabIndex = 8
        Me.CBoxViernes.Text = "Viernes"
        Me.CBoxViernes.UseVisualStyleBackColor = True
        '
        'CBoxSabado
        '
        Me.CBoxSabado.AutoSize = True
        Me.CBoxSabado.Location = New System.Drawing.Point(68, 51)
        Me.CBoxSabado.Name = "CBoxSabado"
        Me.CBoxSabado.Size = New System.Drawing.Size(63, 17)
        Me.CBoxSabado.TabIndex = 9
        Me.CBoxSabado.Text = "Sábado"
        Me.CBoxSabado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RButtonEfectivo)
        Me.GroupBox2.Controls.Add(Me.RButtonCheque)
        Me.GroupBox2.Location = New System.Drawing.Point(542, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 85)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago"
        '
        'RButtonEfectivo
        '
        Me.RButtonEfectivo.AutoSize = True
        Me.RButtonEfectivo.Location = New System.Drawing.Point(80, 19)
        Me.RButtonEfectivo.Name = "RButtonEfectivo"
        Me.RButtonEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.RButtonEfectivo.TabIndex = 11
        Me.RButtonEfectivo.TabStop = True
        Me.RButtonEfectivo.Text = "Efectivo"
        Me.RButtonEfectivo.UseVisualStyleBackColor = True
        '
        'RButtonCheque
        '
        Me.RButtonCheque.AutoSize = True
        Me.RButtonCheque.Location = New System.Drawing.Point(82, 56)
        Me.RButtonCheque.Name = "RButtonCheque"
        Me.RButtonCheque.Size = New System.Drawing.Size(62, 17)
        Me.RButtonCheque.TabIndex = 12
        Me.RButtonCheque.TabStop = True
        Me.RButtonCheque.Text = "Cheque"
        Me.RButtonCheque.UseVisualStyleBackColor = True
        '
        'DateFECHA
        '
        Me.DateFECHA.Location = New System.Drawing.Point(134, 136)
        Me.DateFECHA.Name = "DateFECHA"
        Me.DateFECHA.Size = New System.Drawing.Size(196, 20)
        Me.DateFECHA.TabIndex = 15
        '
        'TBoxCantidadHoras
        '
        Me.TBoxCantidadHoras.Location = New System.Drawing.Point(203, 168)
        Me.TBoxCantidadHoras.Name = "TBoxCantidadHoras"
        Me.TBoxCantidadHoras.Size = New System.Drawing.Size(49, 20)
        Me.TBoxCantidadHoras.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(18, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cantidad de horas a cursar por Día"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(18, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha de Inscripción "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Idioma a Estudiar"
        '
        'ComboBoxIdiomas
        '
        Me.ComboBoxIdiomas.FormattingEnabled = True
        Me.ComboBoxIdiomas.Items.AddRange(New Object() {"Inglés", "Portugués", "Francés"})
        Me.ComboBoxIdiomas.Location = New System.Drawing.Point(134, 101)
        Me.ComboBoxIdiomas.Name = "ComboBoxIdiomas"
        Me.ComboBoxIdiomas.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxIdiomas.TabIndex = 4
        Me.ComboBoxIdiomas.Text = "Escoger Idioma"
        '
        'TBoxNombre
        '
        Me.TBoxNombre.Location = New System.Drawing.Point(262, 60)
        Me.TBoxNombre.Name = "TBoxNombre"
        Me.TBoxNombre.Size = New System.Drawing.Size(263, 20)
        Me.TBoxNombre.TabIndex = 3
        '
        'TBoxCarnet
        '
        Me.TBoxCarnet.Location = New System.Drawing.Point(262, 31)
        Me.TBoxCarnet.Name = "TBoxCarnet"
        Me.TBoxCarnet.Size = New System.Drawing.Size(263, 20)
        Me.TBoxCarnet.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(195, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(195, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carnet "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarDatagridviewToolStripMenuItem, Me.CalculosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(783, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarDatagridviewToolStripMenuItem
        '
        Me.LimpiarDatagridviewToolStripMenuItem.Name = "LimpiarDatagridviewToolStripMenuItem"
        Me.LimpiarDatagridviewToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.LimpiarDatagridviewToolStripMenuItem.Text = "Limpiar Datagridview"
        '
        'CalculosToolStripMenuItem
        '
        Me.CalculosToolStripMenuItem.Name = "CalculosToolStripMenuItem"
        Me.CalculosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CalculosToolStripMenuItem.Text = "Calculos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DGVIdiomas
        '
        Me.DGVIdiomas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGVIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVIdiomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.DGVIdiomas.Location = New System.Drawing.Point(0, 325)
        Me.DGVIdiomas.Name = "DGVIdiomas"
        Me.DGVIdiomas.Size = New System.Drawing.Size(783, 175)
        Me.DGVIdiomas.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Registro"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Carnet"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Idioma"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Fecha Inscripción "
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Horas/Día Estudio"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Día de Clases"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Pago"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Descuento 1"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Descuento 2"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Pago Parcial"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Total a Pagar"
        Me.Column12.Name = "Column12"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.LabelTotal)
        Me.GroupBox4.Controls.Add(Me.LabelDescuento)
        Me.GroupBox4.Controls.Add(Me.LabelParcial)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(189, 247)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(466, 61)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resultados"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(358, 33)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(28, 13)
        Me.LabelTotal.TabIndex = 11
        Me.LabelTotal.Text = "0.00"
        '
        'LabelDescuento
        '
        Me.LabelDescuento.AutoSize = True
        Me.LabelDescuento.Location = New System.Drawing.Point(234, 33)
        Me.LabelDescuento.Name = "LabelDescuento"
        Me.LabelDescuento.Size = New System.Drawing.Size(28, 13)
        Me.LabelDescuento.TabIndex = 10
        Me.LabelDescuento.Text = "0.00"
        '
        'LabelParcial
        '
        Me.LabelParcial.AutoSize = True
        Me.LabelParcial.ForeColor = System.Drawing.Color.Black
        Me.LabelParcial.Location = New System.Drawing.Point(123, 32)
        Me.LabelParcial.Name = "LabelParcial"
        Me.LabelParcial.Size = New System.Drawing.Size(28, 13)
        Me.LabelParcial.TabIndex = 9
        Me.LabelParcial.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(334, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Q."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(219, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Q."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(107, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Q."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(324, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total A Pagar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Descuento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pago Parcial"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global._201800986_IDIOMAS.My.Resources.Resources.fondo2
        Me.ClientSize = New System.Drawing.Size(783, 574)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DGVIdiomas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cursos Libres Idiomas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DGVIdiomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxIdiomas As System.Windows.Forms.ComboBox
    Friend WithEvents TBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TBoxCarnet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RButtonEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonCheque As System.Windows.Forms.RadioButton
    Friend WithEvents DateFECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents TBoxCantidadHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBoxSabado As System.Windows.Forms.CheckBox
    Friend WithEvents CBoxViernes As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LimpiarEntradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarDatagridviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DGVIdiomas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents LabelDescuento As System.Windows.Forms.Label
    Friend WithEvents LabelParcial As System.Windows.Forms.Label

End Class
