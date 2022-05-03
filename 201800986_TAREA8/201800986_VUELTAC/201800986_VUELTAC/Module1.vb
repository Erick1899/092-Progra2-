Module Module1

    Public Const Penalizacion1 = 30
    Public Const penalizacion2 = 40
    Public Const penalizacion3 = 50
    Public Const reduccion1 = 15
    Public Const reduccion2 = 10


    Sub limpiar_Entradas()
        Form1.TextBoxKilometros.Clear()
        Form1.TextBoxNumeroEtapa.Clear()
        Form1.TextBoxTiempo.Clear()
        Form1.ComboBoxEquipo.Text = "Seleccione Equipo"
        Form1.ComboBoxNacionalidad.Text = "Seleccione Nacionalidad"
    End Sub

    Sub limpiar_Vectores()


    End Sub

    Sub limpiar_Data()
        Form1.DataGridViewDatos.Rows.Clear()
    End Sub

End Module
