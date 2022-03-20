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
        Me.TBoxNumVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelPrecioVenta = New System.Windows.Forms.Label()
        Me.LabelPrecioCosto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewSillones = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RButtonSofa = New System.Windows.Forms.RadioButton()
        Me.RButtonIndividual = New System.Windows.Forms.RadioButton()
        Me.RButtonDoble = New System.Windows.Forms.RadioButton()
        Me.RButtonCuero = New System.Windows.Forms.RadioButton()
        Me.RButtonCuerina = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewSillones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.RButtonDoble)
        Me.GroupBox1.Controls.Add(Me.RButtonIndividual)
        Me.GroupBox1.Controls.Add(Me.RButtonSofa)
        Me.GroupBox1.Controls.Add(Me.TBoxNumVenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Compra"
        '
        'TBoxNumVenta
        '
        Me.TBoxNumVenta.Location = New System.Drawing.Point(143, 93)
        Me.TBoxNumVenta.Name = "TBoxNumVenta"
        Me.TBoxNumVenta.Size = New System.Drawing.Size(100, 20)
        Me.TBoxNumVenta.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero de Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tamaño del Sillon"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Aquamarine
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarGridToolStripMenuItem, Me.SalirToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(618, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.CalcularToolStripMenuItem.Text = "Calcular "
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarGridToolStripMenuItem
        '
        Me.LimpiarGridToolStripMenuItem.Name = "LimpiarGridToolStripMenuItem"
        Me.LimpiarGridToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.LimpiarGridToolStripMenuItem.Text = "Limpiar Grid"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.SalirToolStripMenuItem.Text = "Salir "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelPrecioVenta)
        Me.GroupBox2.Controls.Add(Me.LabelPrecioCosto)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(334, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 112)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Venta"
        '
        'LabelPrecioVenta
        '
        Me.LabelPrecioVenta.AutoSize = True
        Me.LabelPrecioVenta.Location = New System.Drawing.Point(152, 79)
        Me.LabelPrecioVenta.Name = "LabelPrecioVenta"
        Me.LabelPrecioVenta.Size = New System.Drawing.Size(28, 13)
        Me.LabelPrecioVenta.TabIndex = 5
        Me.LabelPrecioVenta.Text = "0.00"
        '
        'LabelPrecioCosto
        '
        Me.LabelPrecioCosto.AutoSize = True
        Me.LabelPrecioCosto.Location = New System.Drawing.Point(152, 38)
        Me.LabelPrecioCosto.Name = "LabelPrecioCosto"
        Me.LabelPrecioCosto.Size = New System.Drawing.Size(28, 13)
        Me.LabelPrecioCosto.TabIndex = 4
        Me.LabelPrecioCosto.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Q. "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Q."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Precio Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Precio Costo"
        '
        'DataGridViewSillones
        '
        Me.DataGridViewSillones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSillones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridViewSillones.Location = New System.Drawing.Point(22, 245)
        Me.DataGridViewSillones.Name = "DataGridViewSillones"
        Me.DataGridViewSillones.Size = New System.Drawing.Size(571, 150)
        Me.DataGridViewSillones.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Registro"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Numero de Venta"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tamaño Sillon "
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tipo Tela"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio Costo"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Precio Venta"
        Me.Column6.Name = "Column6"
        '
        'RButtonSofa
        '
        Me.RButtonSofa.AutoSize = True
        Me.RButtonSofa.Location = New System.Drawing.Point(143, 20)
        Me.RButtonSofa.Name = "RButtonSofa"
        Me.RButtonSofa.Size = New System.Drawing.Size(47, 17)
        Me.RButtonSofa.TabIndex = 6
        Me.RButtonSofa.TabStop = True
        Me.RButtonSofa.Text = "Sofá"
        Me.RButtonSofa.UseVisualStyleBackColor = True
        '
        'RButtonIndividual
        '
        Me.RButtonIndividual.AutoSize = True
        Me.RButtonIndividual.Location = New System.Drawing.Point(143, 43)
        Me.RButtonIndividual.Name = "RButtonIndividual"
        Me.RButtonIndividual.Size = New System.Drawing.Size(70, 17)
        Me.RButtonIndividual.TabIndex = 7
        Me.RButtonIndividual.TabStop = True
        Me.RButtonIndividual.Text = "Individual"
        Me.RButtonIndividual.UseVisualStyleBackColor = True
        '
        'RButtonDoble
        '
        Me.RButtonDoble.AutoSize = True
        Me.RButtonDoble.Location = New System.Drawing.Point(143, 65)
        Me.RButtonDoble.Name = "RButtonDoble"
        Me.RButtonDoble.Size = New System.Drawing.Size(53, 17)
        Me.RButtonDoble.TabIndex = 8
        Me.RButtonDoble.TabStop = True
        Me.RButtonDoble.Text = "Doble"
        Me.RButtonDoble.UseVisualStyleBackColor = True
        '
        'RButtonCuero
        '
        Me.RButtonCuero.AutoSize = True
        Me.RButtonCuero.Location = New System.Drawing.Point(55, 19)
        Me.RButtonCuero.Name = "RButtonCuero"
        Me.RButtonCuero.Size = New System.Drawing.Size(53, 17)
        Me.RButtonCuero.TabIndex = 9
        Me.RButtonCuero.TabStop = True
        Me.RButtonCuero.Text = "Cuero"
        Me.RButtonCuero.UseVisualStyleBackColor = True
        '
        'RButtonCuerina
        '
        Me.RButtonCuerina.AutoSize = True
        Me.RButtonCuerina.Location = New System.Drawing.Point(131, 19)
        Me.RButtonCuerina.Name = "RButtonCuerina"
        Me.RButtonCuerina.Size = New System.Drawing.Size(64, 17)
        Me.RButtonCuerina.TabIndex = 10
        Me.RButtonCuerina.TabStop = True
        Me.RButtonCuerina.Text = "Cuerina "
        Me.RButtonCuerina.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RButtonCuero)
        Me.GroupBox3.Controls.Add(Me.RButtonCuerina)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 51)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Tela"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(618, 419)
        Me.Controls.Add(Me.DataGridViewSillones)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "FABRICA SILLONES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewSillones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBoxNumVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelPrecioVenta As System.Windows.Forms.Label
    Friend WithEvents LabelPrecioCosto As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewSillones As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RButtonCuerina As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonCuero As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonDoble As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonSofa As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LimpiarVectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
