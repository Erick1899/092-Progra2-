Module Module1

    Public Const Sencilla_Primera = 400
    Public Const Doble_Primera = 700
    Public Const compartida_Primera = 350

    Public Const Sencilla_Segunda = 375
    Public Const Doble_Segunda = 600
    Public Const Compartida_Segunda = 300

    Sub limpiar_Entradas()
        Form1.TextBoxNIT.Clear()
        Form1.TextBoxNombre.Clear()
        Form1.TextBoxPersonas.Clear()
        Form1.ComboBoxCabina.Text = "Seleccione el tipo de Cabina"
        Form1.ComboBoxClase.Text = "Selecciones el tipo de clase"
        Form1.LabelTotalPago.Text = "0.00"
        Form1.LabelPrecioIndividual.Text = "0.00"

    End Sub

    Sub limpiar_Vectores()

        Form1.pos = 0
        ReDim Form1.NIT(6)
        ReDim Form1.NOMBRE(6)
        ReDim Form1.CABINA(6)
        ReDim Form1.PERSONAS(6)
        ReDim Form1.CLASE(6)
        ReDim Form1.PAGOINDIVIDUAL(6)
        ReDim Form1.PAGOTOTAL(6)

        MessageBox.Show("Vectores Limpios")
    End Sub

    Sub Limpiar_Data()

        Form2.DataGridViewDatos.Rows.Clear()
        Form3.DataGridViewBusqueda.Rows.Clear()


    End Sub
End Module
