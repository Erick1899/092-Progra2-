Module Module1

    Public Const PEncamamientoyPrivada = 350
    Public Const PEncamamientoySemi = 250
    Public Const PEncamamientoyNormal = 150
    Public Const POperaciónyPrivada = 550
    Public Const POperacionySemi = 400
    Public Const POperacionyNormal = 300
    Public Const PMaternidadyPrivada = 450
    Public Const PMaternidadySemi = 350
    Public Const PMaternidadyNormal = 250

    Public SubTOTAL As Double
    Public Descuento As Double
    Public Total As Double

    Public Const pagocheque_efectivo = 0.15
    Public Const pagodebito = 0.08
    Public Const pagocredito = 0.05



    Sub limpiar()

        Form1.TextBoxNombrePaciente.Clear()
        Form1.TextBoxNit.Clear()
        Form1.TextBoxDiasHospi.Clear()
        Form1.TextBoxHonorarios.Clear()

        Form1.RButtonPrivada.Checked = False
        Form1.RButtonSemi.Checked = False
        Form1.RButtonNoPrivada.Checked = False

        Form1.RButtonEfectivo.Checked = False
        Form1.RButtonCheque.Checked = False
        Form1.RButtonCredito.Checked = False
        Form1.RButtonDebito.Checked = False

        Form1.CBoxEncamamiento.Checked = False
        Form1.CBoxMaternidad.Checked = False
        Form1.CBoxOperacion.Checked = False

    End Sub

    Sub Limpiar2()
        Form2.LabelSubTotal.Text = " 0.00"
        Form2.LabelDescuento.Text = "0.00"
        Form2.LabelTotalaPagar.Text = "0.00"


    End Sub

    Sub limpiarlistbox()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()




    End Sub

End Module
