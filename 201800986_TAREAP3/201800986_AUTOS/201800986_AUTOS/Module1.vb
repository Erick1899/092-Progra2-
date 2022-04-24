Module Module1

    Public Const CostoTipo1 = 500
    Public Const CostoTipo2 = 400
    Public Const CostoTipo3 = 300
    Public Const CostoTipo4 = 200

    Public Const CostoKilometro1 = 3.0
    Public Const CostoKilometro2 = 4.0
    Public Const CostoKilometro3 = 5.0

    Sub Limpiar_Grid()

        Form1.DataGridViewDatos.Rows.Clear()

    End Sub

    Sub Limpiar_Entradas()
        Form1.TextBoxKmInicial.Clear()
        Form1.TextBoxKmFinal.Clear()
        Form1.TextBoxNoPlaca.Clear()

        Form1.LabelCostoAlquiler.Text = "0.00"
        Form1.LabelCostoKilometraje.Text = "0.00"
        Form1.LabelTotalPagar.Text = "0.00"

        Form1.ComboBoxTipoAuto.Text = "Seleccione Tipo"

    End Sub
End Module
