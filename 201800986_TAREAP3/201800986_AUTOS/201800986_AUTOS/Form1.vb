Public Class Form1
    Public pos As String
    Public TipoAuto(7) As String
    Public KilometrajeInicial(7) As Double
    Public KilometrajeFinal(7) As Double
    Public NumeroPlaca(7) As Double

    Public CostoAlquiler(7) As Double
    Public CostoKilometraje(7) As Double
    Public PagoTotal(7) As Double

    Dim resta As Double
    Dim a As Double
    Dim b As Double





    Private Sub TextBoxKmInicial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxKmInicial.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub TextBoxKmFinal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxKmFinal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub TextBoxNoPlaca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNoPlaca.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click
        DataGridViewDatos.Visible = False

        If pos < 7 Then

            If ComboBoxTipoAuto.SelectedItem = "Tipo 1" Then
                TipoAuto(pos) = ComboBoxTipoAuto.SelectedItem
                KilometrajeInicial(pos) = TextBoxKmInicial.Text
                KilometrajeFinal(pos) = TextBoxKmFinal.Text
                NumeroPlaca(pos) = TextBoxNoPlaca.Text

                LabelCostoAlquiler.Text = CostoTipo1
                CostoAlquiler(pos) = LabelCostoAlquiler.Text
                resta = TextBoxKmFinal.Text - TextBoxKmInicial.Text

                If resta <= 50 Then
                    LabelCostoKilometraje.Text = CostoKilometro1 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text

                End If

                If resta >= 51 And resta <= 70 Then
                    LabelCostoKilometraje.Text = CostoKilometro2 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text
                End If

                If resta >= 71 Then
                    LabelCostoKilometraje.Text = CostoKilometro3 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text
                End If

            End If

            ' Código para el tipo 2 de auto ************************************************

            If ComboBoxTipoAuto.SelectedItem = "Tipo 2" Then
                TipoAuto(pos) = ComboBoxTipoAuto.SelectedItem
                KilometrajeInicial(pos) = TextBoxKmInicial.Text
                KilometrajeFinal(pos) = TextBoxKmFinal.Text
                NumeroPlaca(pos) = TextBoxNoPlaca.Text

                LabelCostoAlquiler.Text = CostoTipo2
                CostoAlquiler(pos) = LabelCostoAlquiler.Text
                resta = TextBoxKmFinal.Text - TextBoxKmInicial.Text

                If resta <= 50 Then
                    LabelCostoKilometraje.Text = CostoKilometro1 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text

                End If

                If resta >= 51 And resta <= 70 Then
                    LabelCostoKilometraje.Text = CostoKilometro2 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text
                End If

                If resta >= 71 Then
                    LabelCostoKilometraje.Text = CostoKilometro3 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text
                End If

            End If

            ' Código para el tipo 3 de auto **********************************************

            If ComboBoxTipoAuto.SelectedItem = "Tipo 3" Then
                TipoAuto(pos) = ComboBoxTipoAuto.SelectedItem
                KilometrajeInicial(pos) = TextBoxKmInicial.Text
                KilometrajeFinal(pos) = TextBoxKmFinal.Text
                NumeroPlaca(pos) = TextBoxNoPlaca.Text

                LabelCostoAlquiler.Text = CostoTipo3
                CostoAlquiler(pos) = LabelCostoAlquiler.Text
                resta = TextBoxKmFinal.Text - TextBoxKmInicial.Text

                If resta <= 50 Then
                    LabelCostoKilometraje.Text = CostoKilometro1 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text

                End If

                If resta >= 51 And resta <= 70 Then
                    LabelCostoKilometraje.Text = CostoKilometro2 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text
                End If

                If resta >= 71 Then
                    LabelCostoKilometraje.Text = CostoKilometro3 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text
                End If

            End If

            ' Código para el tipo 4 de auto **************************************************

            If ComboBoxTipoAuto.SelectedItem = "Tipo 4" Then
                TipoAuto(pos) = ComboBoxTipoAuto.SelectedItem
                KilometrajeInicial(pos) = TextBoxKmInicial.Text
                KilometrajeFinal(pos) = TextBoxKmFinal.Text
                NumeroPlaca(pos) = TextBoxNoPlaca.Text

                LabelCostoAlquiler.Text = CostoTipo4
                CostoAlquiler(pos) = LabelCostoAlquiler.Text
                resta = TextBoxKmFinal.Text - TextBoxKmInicial.Text

                If resta <= 50 Then
                    LabelCostoKilometraje.Text = CostoKilometro1 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text

                End If

                If resta >= 51 And resta <= 70 Then
                    LabelCostoKilometraje.Text = CostoKilometro2 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text
                End If

                If resta >= 71 Then
                    LabelCostoKilometraje.Text = CostoKilometro3 * resta
                    CostoKilometraje(pos) = LabelCostoKilometraje.Text
                    a = LabelCostoAlquiler.Text
                    b = LabelCostoKilometraje.Text
                    LabelTotalPagar.Text = a + b
                    PagoTotal(pos) = LabelTotalPagar.Text
                End If

            End If


            DataGridViewDatos.Rows.Add(pos + 1, TipoAuto(pos), KilometrajeInicial(pos), KilometrajeFinal(pos), NumeroPlaca(pos), CostoAlquiler(pos), CostoKilometraje(pos), PagoTotal(pos))
            pos = pos + 1
        Else

            MessageBox.Show("Ya se lleno el cupo")
        End If


    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        pos = 0
        ReDim TipoAuto(7)
        ReDim KilometrajeInicial(7)
        ReDim KilometrajeFinal(7)
        ReDim NumeroPlaca(7)
        ReDim CostoAlquiler(7)
        ReDim CostoKilometraje(7)
        ReDim PagoTotal(7)

        Limpiar_Grid()
        Limpiar_Entradas()


        MessageBox.Show("Vectores Limpios")

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        DataGridViewDatos.Visible = True
    End Sub
End Class
