Module Module1

    Public Const PrecioSofa = 250.99
    Public Const PrecioIndividual = 150.99
    Public Const PrecioDoble = 200.99

    Public Const CantYardaSofa = 8
    Public Const CantYardaIndividual = 3.5
    Public Const CantYardaDoble = 6

    Public Const PrecioCuero = 75.0
    Public Const PrecioCuerina = 45.99



    Sub limpiar_Entradas()

        Form1.TBoxNumVenta.Clear()

        Form1.LabelPrecioCosto.Text = "0.00"
        Form1.LabelPrecioVenta.Text = "0.00"

        Form1.RButtonSofa.Checked = False
        Form1.RButtonIndividual.Checked = False
        Form1.RButtonDoble.Checked = False
        Form1.RButtonCuero.Checked = False
        Form1.RButtonCuerina.Checked = False

        

    End Sub

    Sub Limpiar_Grid()

        Form1.DataGridViewSillones.Rows.Clear()

    End Sub

    Sub Limpiar_Vectores()



    End Sub


End Module
