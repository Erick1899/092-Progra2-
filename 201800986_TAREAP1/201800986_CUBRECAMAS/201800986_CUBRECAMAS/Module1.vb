Module Module1

    Public Const PManoObraSmall = 65.5
    Public Const PManoObraMedium = 85.99
    Public Const PManoObraLarge = 99.99

    Public Const Palgodon = 15.0
    Public Const Pseda = 23.99
    Public Const PLona = 30.99

    Public Const yardaSmall = 2
    Public Const yardaMedium = 2.5
    Public Const yardaLarge = 3

    Public PrecioCosto As Double
    Public PrecioVenta As Double
    Public cantVenta As Double










    Sub limpiar()
        Form1.TBoxCantidadChumpas.Clear()
        Form1.RButtonSmall.Checked = False
        Form1.RButtonMedium.Checked = False
        Form1.RButtonLarge.Checked = False
        Form1.RButtonAlgodon.Checked = False
        Form1.RButtonLona.Checked = False
        Form1.RButtonSeda.Checked = False

    End Sub

    Sub limpiarForm2()
        Form2.LabelPrecioCosto.Text = "0.00"
        Form2.LabelPrecioVenta.Text = "0.00"

    End Sub



End Module
