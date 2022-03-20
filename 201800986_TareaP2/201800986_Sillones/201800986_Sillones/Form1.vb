Public Class Form1

    Public pos As String

    Public NumeroVenta(8) As Integer
    Public tamaño(8) As String
    Public tela(8) As String
    Public PrecioCosto(8) As Double
    Public PrecioVenta(8) As Double

    Dim Var1 As Double




    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBoxNumVenta.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_Entradas()

    End Sub

    Private Sub LimpiarGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarGridToolStripMenuItem.Click
        Limpiar_Grid()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click

        
        If pos < 8 Then

            NumeroVenta(pos) = TBoxNumVenta.Text

            If RButtonSofa.Checked = True Then
                tamaño(pos) = "Sofá "
            End If
            If RButtonIndividual.Checked = True Then
                tamaño(pos) = " Individual "
            End If
            If RButtonDoble.Checked = True Then
                tamaño(pos) = " Doble "
            End If

            If RButtonCuero.Checked = True Then
                tela(pos) = " Cuero "
            End If
            If RButtonCuerina.Checked = True Then
                tela(pos) = " Cuerina "
            End If


            If RButtonSofa.Checked And RButtonCuero.Checked Then
                LabelPrecioCosto.Text = PrecioSofa + PrecioCuero * CantYardaSofa
                PrecioCosto(pos) = LabelPrecioCosto.Text

                LabelPrecioVenta.Text = LabelPrecioCosto.Text + LabelPrecioCosto.Text * 0.65
                PrecioVenta(pos) = LabelPrecioVenta.Text

            End If

            If RButtonSofa.Checked And RButtonCuerina.Checked Then
                LabelPrecioCosto.Text = PrecioSofa + PrecioCuerina * CantYardaSofa
                PrecioCosto(pos) = LabelPrecioCosto.Text

                LabelPrecioVenta.Text = LabelPrecioCosto.Text + LabelPrecioCosto.Text * 0.65
                PrecioVenta(pos) = LabelPrecioVenta.Text

            End If

            If RButtonIndividual.Checked And RButtonCuero.Checked Then
                LabelPrecioCosto.Text = PrecioIndividual + PrecioCuero * CantYardaIndividual
                PrecioCosto(pos) = LabelPrecioCosto.Text

                LabelPrecioVenta.Text = LabelPrecioCosto.Text + LabelPrecioCosto.Text * 0.65
                PrecioVenta(pos) = LabelPrecioVenta.Text

            End If
            If RButtonIndividual.Checked And RButtonCuerina.Checked Then
                LabelPrecioCosto.Text = PrecioIndividual + PrecioCuerina * CantYardaIndividual
                PrecioCosto(pos) = LabelPrecioCosto.Text

                LabelPrecioVenta.Text = LabelPrecioCosto.Text + LabelPrecioCosto.Text * 0.65
                PrecioVenta(pos) = LabelPrecioVenta.Text

            End If



            If RButtonDoble.Checked And RButtonCuero.Checked Then
                LabelPrecioCosto.Text = PrecioDoble + PrecioCuero * CantYardaDoble
                PrecioCosto(pos) = LabelPrecioCosto.Text

                LabelPrecioVenta.Text = LabelPrecioCosto.Text + LabelPrecioCosto.Text * 0.65
                PrecioVenta(pos) = LabelPrecioVenta.Text

            End If
            If RButtonDoble.Checked And RButtonCuerina.Checked Then
                LabelPrecioCosto.Text = PrecioDoble + PrecioCuerina * CantYardaDoble
                PrecioCosto(pos) = LabelPrecioCosto.Text

                LabelPrecioVenta.Text = LabelPrecioCosto.Text + LabelPrecioCosto.Text * 0.65
                PrecioVenta(pos) = LabelPrecioVenta.Text

            End If




            DataGridViewSillones.Rows.Add(pos + 1, NumeroVenta(pos), tamaño(pos), tela(pos), PrecioCosto(pos), PrecioVenta(pos))
            pos = pos + 1


        Else

            MessageBox.Show("Ya se lleno el cupo")

        End If





    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        pos = 0
        ReDim NumeroVenta(8)
        ReDim tamaño(8)
        ReDim tela(8)
        ReDim PrecioCosto(8)
        ReDim PrecioVenta(8)

        MessageBox.Show("Vectores Limpios")

    End Sub
End Class
