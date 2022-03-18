Module Module1

    Public Const PrecioTablet = 375
    Public Const PrecioDrone = 560
    Public Const PrecioCelular = 1450
    Public Const PrecioTelevisor = 3250

    Public Const PorcentajeComision = 0.055
    Public Const Bono1 = 0.03
    Public Const Bono2 = 0.04
    Public Const Bono3 = 0.05


    Sub Limpiar_Entradas()
        Form1.TBoxNombre.Clear()
        Form1.TBoxSueldo.Clear()

        Form1.CBoxArticulos.SelectedIndex = -1
        Form1.CBoxArticulos.Text = "Escoger Idioma "

        Form1.LabelComisión.Text = "0.00"
        Form1.LabelBono.Text = "0.00"
        Form1.LabelSueldoFinal.Text = "0.00"


    End Sub

    Sub Limpiar_Listobox()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
    End Sub




End Module
