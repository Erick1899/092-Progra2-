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
        Me.TBoxCantidadChumpas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RButtonLarge = New System.Windows.Forms.RadioButton()
        Me.RButtonMedium = New System.Windows.Forms.RadioButton()
        Me.RButtonSmall = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RButtonLona = New System.Windows.Forms.RadioButton()
        Me.RButtonSeda = New System.Windows.Forms.RadioButton()
        Me.RButtonAlgodon = New System.Windows.Forms.RadioButton()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TBoxCantidadChumpas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(119, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar"
        '
        'TBoxCantidadChumpas
        '
        Me.TBoxCantidadChumpas.Location = New System.Drawing.Point(190, 26)
        Me.TBoxCantidadChumpas.Name = "TBoxCantidadChumpas"
        Me.TBoxCantidadChumpas.Size = New System.Drawing.Size(100, 20)
        Me.TBoxCantidadChumpas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad de chumpas a realizar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.RButtonLarge)
        Me.GroupBox2.Controls.Add(Me.RButtonMedium)
        Me.GroupBox2.Controls.Add(Me.RButtonSmall)
        Me.GroupBox2.Location = New System.Drawing.Point(47, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccionar Tamaño"
        '
        'RButtonLarge
        '
        Me.RButtonLarge.AutoSize = True
        Me.RButtonLarge.Location = New System.Drawing.Point(50, 65)
        Me.RButtonLarge.Name = "RButtonLarge"
        Me.RButtonLarge.Size = New System.Drawing.Size(52, 17)
        Me.RButtonLarge.TabIndex = 2
        Me.RButtonLarge.TabStop = True
        Me.RButtonLarge.Text = "Large"
        Me.RButtonLarge.UseVisualStyleBackColor = True
        '
        'RButtonMedium
        '
        Me.RButtonMedium.AutoSize = True
        Me.RButtonMedium.Location = New System.Drawing.Point(50, 42)
        Me.RButtonMedium.Name = "RButtonMedium"
        Me.RButtonMedium.Size = New System.Drawing.Size(62, 17)
        Me.RButtonMedium.TabIndex = 1
        Me.RButtonMedium.TabStop = True
        Me.RButtonMedium.Text = "Medium"
        Me.RButtonMedium.UseVisualStyleBackColor = True
        '
        'RButtonSmall
        '
        Me.RButtonSmall.AutoSize = True
        Me.RButtonSmall.Location = New System.Drawing.Point(50, 20)
        Me.RButtonSmall.Name = "RButtonSmall"
        Me.RButtonSmall.Size = New System.Drawing.Size(50, 17)
        Me.RButtonSmall.TabIndex = 0
        Me.RButtonSmall.TabStop = True
        Me.RButtonSmall.Text = "Small"
        Me.RButtonSmall.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.RButtonLona)
        Me.GroupBox3.Controls.Add(Me.RButtonSeda)
        Me.GroupBox3.Controls.Add(Me.RButtonAlgodon)
        Me.GroupBox3.Location = New System.Drawing.Point(282, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccionar Material"
        '
        'RButtonLona
        '
        Me.RButtonLona.AutoSize = True
        Me.RButtonLona.Location = New System.Drawing.Point(51, 65)
        Me.RButtonLona.Name = "RButtonLona"
        Me.RButtonLona.Size = New System.Drawing.Size(49, 17)
        Me.RButtonLona.TabIndex = 3
        Me.RButtonLona.TabStop = True
        Me.RButtonLona.Text = "Lona"
        Me.RButtonLona.UseVisualStyleBackColor = True
        '
        'RButtonSeda
        '
        Me.RButtonSeda.AutoSize = True
        Me.RButtonSeda.Location = New System.Drawing.Point(51, 43)
        Me.RButtonSeda.Name = "RButtonSeda"
        Me.RButtonSeda.Size = New System.Drawing.Size(50, 17)
        Me.RButtonSeda.TabIndex = 2
        Me.RButtonSeda.TabStop = True
        Me.RButtonSeda.Text = "Seda"
        Me.RButtonSeda.UseVisualStyleBackColor = True
        '
        'RButtonAlgodon
        '
        Me.RButtonAlgodon.AutoSize = True
        Me.RButtonAlgodon.Location = New System.Drawing.Point(51, 20)
        Me.RButtonAlgodon.Name = "RButtonAlgodon"
        Me.RButtonAlgodon.Size = New System.Drawing.Size(64, 17)
        Me.RButtonAlgodon.TabIndex = 1
        Me.RButtonAlgodon.TabStop = True
        Me.RButtonAlgodon.Text = "Algodón"
        Me.RButtonAlgodon.UseVisualStyleBackColor = True
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonCalcular.Location = New System.Drawing.Point(72, 235)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(87, 46)
        Me.ButtonCalcular.TabIndex = 3
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonLimpiar.Location = New System.Drawing.Point(237, 235)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(87, 46)
        Me.ButtonLimpiar.TabIndex = 4
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonSalir.Location = New System.Drawing.Point(395, 235)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(87, 46)
        Me.ButtonSalir.TabIndex = 5
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201800986_CUBRECAMAS.My.Resources.Resources.iconos_de_ropa_clip_art_vectorial_csp21015119
        Me.ClientSize = New System.Drawing.Size(534, 313)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "FABRICA DE CHUMPAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBoxCantidadChumpas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RButtonLarge As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonMedium As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonSmall As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RButtonLona As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonSeda As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonAlgodon As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonCalcular As System.Windows.Forms.Button
    Friend WithEvents ButtonLimpiar As System.Windows.Forms.Button
    Friend WithEvents ButtonSalir As System.Windows.Forms.Button

End Class
