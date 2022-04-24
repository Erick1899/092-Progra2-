Module Module1

    Public Const PrecioBiotopo = 255
    Public Const PrecioLaguna = 440
    Public Const PrecioMirador = 1190

    Sub Limpiar_Entradas()

        Form1.TextBoxIdCliente.Clear()
        Form1.TextBoxNoDias.Clear()
        Form1.TextBoxNoPersonas.Clear()

        Form1.LabelPrecioDia.Text = "0.00"
        Form1.LabelTotalPago.Text = "0.00"

        Form1.ComboBoxViaje.Text = "Seleccione Lugar de Destino"

    End Sub

    Sub Limpiar_Data()

        Form2.DataGridViewDatos.Rows.Clear()

    End Sub


End Module
