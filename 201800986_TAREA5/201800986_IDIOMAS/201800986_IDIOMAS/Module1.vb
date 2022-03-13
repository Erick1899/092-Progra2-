Module Module1

    Public Const CostoIngles = 150
    Public Const CostoPortugues = 80
    Public Const CostoFrances = 125

    Public Const DescuentoEfectivo = 0.02
    Public Const DescuentoCheque = 0.015
    Public Const DescuentoDias = 0.05

    

    Public Matriz_Iidiomas(10, 8)
    Public indice = 0




    Sub limpiar_Entradas()
        Form1.TBoxCarnet.Clear()
        Form1.TBoxNombre.Clear()
        Form1.TBoxCantidadHoras.Clear()

        Form1.CBoxSabado.Checked = False
        Form1.CBoxViernes.Checked = False

        Form1.RButtonCheque.Checked = False
        Form1.RButtonEfectivo.Checked = False

        Form1.LabelParcial.Text = "0.00"
        Form1.LabelDescuento.Text = "0.00"
        Form1.LabelTotal.Text = "0.00"

        Form1.ComboBoxIdiomas.SelectedIndex = -1
        Form1.ComboBoxIdiomas.Text = "Escoger Idioma "

    End Sub


    Sub limpiar_Matriz()

        indice = 0
        ReDim Matriz_Iidiomas(10, 8)

    End Sub

    Sub Limpiar_DGV()

        Form1.DGVIdiomas.Rows.Clear()

    End Sub

End Module