Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TBoxCantidadChumpas.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    
    Private Sub ButtonLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLimpiar.Click

        limpiar()

    End Sub

    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()

        Else

            limpiar()

        End If


    End Sub


    Private Sub ButtonCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalcular.Click
        If (TBoxCantidadChumpas.Text = "") Then
            MsgBox("Error, No ingreso Cantidad de Chumpas a realizar")
            TBoxCantidadChumpas.Focus()
            Exit Sub
        End If

        'codigo para tamaño Small

        If RButtonSmall.Checked = True And RButtonAlgodon.Checked = True Then
            Module1.PrecioCosto = Module1.PManoObraSmall * TBoxCantidadChumpas.Text + (Module1.Palgodon * Module1.yardaSmall) * TBoxCantidadChumpas.Text
            Form2.LabelPrecioCosto.Text = Module1.PrecioCosto

            Module1.cantVenta = Form2.LabelPrecioCosto.Text * 0.65
            Module1.PrecioVenta = Module1.PrecioCosto + Module1.cantVenta
            Form2.LabelPrecioVenta.Text = Module1.PrecioVenta

        End If

        If RButtonSmall.Checked = True And RButtonSeda.Checked = True Then
            Module1.PrecioCosto = Module1.PManoObraSmall * TBoxCantidadChumpas.Text + (Module1.Pseda * Module1.yardaSmall) * TBoxCantidadChumpas.Text
            Form2.LabelPrecioCosto.Text = Module1.PrecioCosto

            Module1.cantVenta = Form2.LabelPrecioCosto.Text * 0.65
            Module1.PrecioVenta = Module1.PrecioCosto + Module1.cantVenta
            Form2.LabelPrecioVenta.Text = Module1.PrecioVenta

        End If

        If RButtonSmall.Checked = True And RButtonLona.Checked = True Then
            Module1.PrecioCosto = Module1.PManoObraSmall * TBoxCantidadChumpas.Text + (Module1.PLona * Module1.yardaSmall) * TBoxCantidadChumpas.Text
            Form2.LabelPrecioCosto.Text = Module1.PrecioCosto

            Module1.cantVenta = Form2.LabelPrecioCosto.Text * 0.65
            Module1.PrecioVenta = Module1.PrecioCosto + Module1.cantVenta
            Form2.LabelPrecioVenta.Text = Module1.PrecioVenta

        End If

        ' codigo para tamaño mediano 

        If RButtonMedium.Checked = True And RButtonAlgodon.Checked = True Then
            Module1.PrecioCosto = Module1.PManoObraMedium * TBoxCantidadChumpas.Text + (Module1.Palgodon * Module1.yardaMedium) * TBoxCantidadChumpas.Text
            Form2.LabelPrecioCosto.Text = Module1.PrecioCosto

            Module1.cantVenta = Form2.LabelPrecioCosto.Text * 0.65
            Module1.PrecioVenta = Module1.PrecioCosto + Module1.cantVenta
            Form2.LabelPrecioVenta.Text = Module1.PrecioVenta

        End If

        If RButtonMedium.Checked = True And RButtonSeda.Checked = True Then
            Module1.PrecioCosto = Module1.PManoObraMedium * TBoxCantidadChumpas.Text + (Module1.Pseda * Module1.yardaMedium) * TBoxCantidadChumpas.Text
            Form2.LabelPrecioCosto.Text = Module1.PrecioCosto

            Module1.cantVenta = Form2.LabelPrecioCosto.Text * 0.65
            Module1.PrecioVenta = Module1.PrecioCosto + Module1.cantVenta
            Form2.LabelPrecioVenta.Text = Module1.PrecioVenta

        End If

        If RButtonMedium.Checked = True And RButtonLona.Checked = True Then
            Module1.PrecioCosto = Module1.PManoObraMedium * TBoxCantidadChumpas.Text + (Module1.PLona * Module1.yardaMedium) * TBoxCantidadChumpas.Text
            Form2.LabelPrecioCosto.Text = Module1.PrecioCosto

            Module1.cantVenta = Form2.LabelPrecioCosto.Text * 0.65
            Module1.PrecioVenta = Module1.PrecioCosto + Module1.cantVenta
            Form2.LabelPrecioVenta.Text = Module1.PrecioVenta

        End If

        ' codigo para tamaño Large

        If RButtonLarge.Checked = True And RButtonAlgodon.Checked = True Then
            Module1.PrecioCosto = Module1.PManoObraLarge * TBoxCantidadChumpas.Text + (Module1.Palgodon * Module1.yardaLarge) * TBoxCantidadChumpas.Text
            Form2.LabelPrecioCosto.Text = Module1.PrecioCosto

            Module1.cantVenta = Form2.LabelPrecioCosto.Text * 0.65
            Module1.PrecioVenta = Module1.PrecioCosto + Module1.cantVenta
            Form2.LabelPrecioVenta.Text = Module1.PrecioVenta

        End If

        If RButtonLarge.Checked = True And RButtonSeda.Checked = True Then
            Module1.PrecioCosto = Module1.PManoObraLarge * TBoxCantidadChumpas.Text + (Module1.Pseda * Module1.yardaLarge) * TBoxCantidadChumpas.Text
            Form2.LabelPrecioCosto.Text = Module1.PrecioCosto

            Module1.cantVenta = Form2.LabelPrecioCosto.Text * 0.65
            Module1.PrecioVenta = Module1.PrecioCosto + Module1.cantVenta
            Form2.LabelPrecioVenta.Text = Module1.PrecioVenta

        End If

        If RButtonLarge.Checked = True And RButtonLona.Checked = True Then
            Module1.PrecioCosto = Module1.PManoObraLarge * TBoxCantidadChumpas.Text + (Module1.PLona * Module1.yardaLarge) * TBoxCantidadChumpas.Text
            Form2.LabelPrecioCosto.Text = Module1.PrecioCosto

            Module1.cantVenta = Form2.LabelPrecioCosto.Text * 0.65
            Module1.PrecioVenta = Module1.PrecioCosto + Module1.cantVenta
            Form2.LabelPrecioVenta.Text = Module1.PrecioVenta

        End If

        Form2.Show()
        Me.Hide()


    End Sub

End Class
