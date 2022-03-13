Public Class Form1

    Dim var1 As Double

    

    
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()
        End If
    End Sub



    Private Sub TBoxNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBoxNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TBoxCarnet_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBoxCarnet.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TBoxCantidadHoras_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBoxCantidadHoras.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click

        limpiar_Entradas()

    End Sub

    Private Sub CalculosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculosToolStripMenuItem.Click

        If TBoxCarnet.Text = "" Then
            MessageBox.Show("Error Ingrese Carnet del Estudiante")
            Exit Sub
        End If
        If TBoxNombre.Text = "" Then
            MessageBox.Show("Error Ingrese Nombre del Estudiante")
            Exit Sub
        End If
        If TBoxCantidadHoras.Text = "" Then
            MessageBox.Show("Error Ingrese Cantidad de Horas a cursar por día")
            Exit Sub
        End If
        If CBoxSabado.Checked = False And CBoxViernes.Checked = False Then
            MessageBox.Show("Error Seleccione Día a Estudiar")
            Exit Sub
        End If
        If RButtonCheque.Checked = False And RButtonEfectivo.Checked = False Then
            MessageBox.Show("Error Seleccione Método de Pago ")
            Exit Sub
        End If
        If ComboBoxIdiomas.SelectedItem = "" Then
            MessageBox.Show("Error Seleccione Idioma a Estudiar")
            Exit Sub
        End If
       

        If indice < 8 Then
            Matriz_Iidiomas(0, indice) = TBoxCarnet.Text
            Matriz_Iidiomas(1, indice) = TBoxNombre.Text
            Matriz_Iidiomas(2, indice) = ComboBoxIdiomas.SelectedItem
            Matriz_Iidiomas(3, indice) = DateFECHA.Value
            Matriz_Iidiomas(4, indice) = TBoxCantidadHoras.Text


            If CBoxViernes.Checked Then
                Matriz_Iidiomas(5, indice) = CBoxViernes.Text
            ElseIf CBoxSabado.Checked Then
                Matriz_Iidiomas(5, indice) = CBoxSabado.Text
            End If
            If CBoxViernes.Checked And CBoxSabado.Checked Then
                Matriz_Iidiomas(5, indice) = "Viernes y Sábado"
            End If


            If RButtonCheque.Checked Then
                Matriz_Iidiomas(6, indice) = RButtonCheque.Text

            ElseIf RButtonEfectivo.Checked Then
                Matriz_Iidiomas(6, indice) = RButtonEfectivo.Text
            End If

            ' Codigo solo para ingles -------------------------------------------------------------------
            If ComboBoxIdiomas.SelectedItem = "Inglés" And RButtonEfectivo.Checked Then
                LabelParcial.Text = CostoIngles * TBoxCantidadHoras.Text
                LabelDescuento.Text = LabelParcial.Text * DescuentoEfectivo
                LabelTotal.Text = LabelParcial.Text - LabelDescuento.Text

                Matriz_Iidiomas(7, indice) = LabelDescuento.Text
                Matriz_Iidiomas(8, indice) = "0"
                Matriz_Iidiomas(9, indice) = LabelParcial.Text
                Matriz_Iidiomas(10, indice) = LabelTotal.Text

            End If

            If ComboBoxIdiomas.SelectedItem = "Inglés" And RButtonCheque.Checked Then
                LabelParcial.Text = CostoIngles * TBoxCantidadHoras.Text
                LabelDescuento.Text = LabelParcial.Text * DescuentoCheque
                LabelTotal.Text = LabelParcial.Text - LabelDescuento.Text

                Matriz_Iidiomas(7, indice) = LabelDescuento.Text
                Matriz_Iidiomas(8, indice) = "0"
                Matriz_Iidiomas(9, indice) = LabelParcial.Text
                Matriz_Iidiomas(10, indice) = LabelTotal.Text

            End If

            ' Codigo solo para portugues -----------------------------------------------------------

            If ComboBoxIdiomas.SelectedItem = "Portugués" And RButtonEfectivo.Checked Then
                LabelParcial.Text = CostoPortugues * TBoxCantidadHoras.Text
                LabelDescuento.Text = LabelParcial.Text * DescuentoEfectivo
                LabelTotal.Text = LabelParcial.Text - LabelDescuento.Text

                Matriz_Iidiomas(7, indice) = LabelDescuento.Text
                Matriz_Iidiomas(8, indice) = "0"
                Matriz_Iidiomas(9, indice) = LabelParcial.Text
                Matriz_Iidiomas(10, indice) = LabelTotal.Text

            End If

            If ComboBoxIdiomas.SelectedItem = "Portugués" And RButtonCheque.Checked Then
                LabelParcial.Text = CostoPortugues * TBoxCantidadHoras.Text
                LabelDescuento.Text = LabelParcial.Text * DescuentoCheque
                LabelTotal.Text = LabelParcial.Text - LabelDescuento.Text

                Matriz_Iidiomas(7, indice) = LabelDescuento.Text
                Matriz_Iidiomas(8, indice) = "0"
                Matriz_Iidiomas(9, indice) = LabelParcial.Text
                Matriz_Iidiomas(10, indice) = LabelTotal.Text

            End If

            ' Codigo solo para Frances -----------------------------------------------------------

            If ComboBoxIdiomas.SelectedItem = "Francés" And RButtonEfectivo.Checked Then
                LabelParcial.Text = CostoFrances * TBoxCantidadHoras.Text
                LabelDescuento.Text = LabelParcial.Text * DescuentoEfectivo
                LabelTotal.Text = LabelParcial.Text - LabelDescuento.Text

                Matriz_Iidiomas(7, indice) = LabelDescuento.Text
                Matriz_Iidiomas(8, indice) = "0"
                Matriz_Iidiomas(9, indice) = LabelParcial.Text
                Matriz_Iidiomas(10, indice) = LabelTotal.Text

            End If

            If ComboBoxIdiomas.SelectedItem = "Francés" And RButtonCheque.Checked Then
                LabelParcial.Text = CostoPortugues * TBoxCantidadHoras.Text
                LabelDescuento.Text = LabelParcial.Text * DescuentoCheque
                LabelTotal.Text = LabelParcial.Text - LabelDescuento.Text

                Matriz_Iidiomas(7, indice) = LabelDescuento.Text
                Matriz_Iidiomas(8, indice) = "0"
                Matriz_Iidiomas(9, indice) = LabelParcial.Text
                Matriz_Iidiomas(10, indice) = LabelTotal.Text

            End If

            ' Codigo para los 2 días de clase -----------------------------------------------------------

            If ComboBoxIdiomas.SelectedItem = "Francés" And CBoxSabado.Checked And CBoxViernes.Checked Then
                LabelParcial.Text = CostoFrances * TBoxCantidadHoras.Text
                LabelDescuento.Text = LabelParcial.Text * DescuentoDias
                LabelTotal.Text = LabelParcial.Text - LabelDescuento.Text

                Matriz_Iidiomas(7, indice) = "0"
                Matriz_Iidiomas(8, indice) = LabelDescuento.Text
                Matriz_Iidiomas(9, indice) = LabelParcial.Text
                Matriz_Iidiomas(10, indice) = LabelTotal.Text

            End If

            If ComboBoxIdiomas.SelectedItem = "Inglés" And CBoxSabado.Checked And CBoxViernes.Checked Then
                LabelParcial.Text = CostoIngles * TBoxCantidadHoras.Text
                LabelDescuento.Text = LabelParcial.Text * DescuentoDias
                LabelTotal.Text = LabelParcial.Text - LabelDescuento.Text

                Matriz_Iidiomas(7, indice) = "0"
                Matriz_Iidiomas(8, indice) = LabelDescuento.Text
                Matriz_Iidiomas(9, indice) = LabelParcial.Text
                Matriz_Iidiomas(10, indice) = LabelTotal.Text

            End If

            If ComboBoxIdiomas.SelectedItem = "Portugués" And CBoxSabado.Checked And CBoxViernes.Checked Then
                LabelParcial.Text = CostoPortugues * TBoxCantidadHoras.Text
                LabelDescuento.Text = LabelParcial.Text * DescuentoDias
                LabelTotal.Text = LabelParcial.Text - LabelDescuento.Text

                Matriz_Iidiomas(7, indice) = "0"
                Matriz_Iidiomas(8, indice) = LabelDescuento.Text
                Matriz_Iidiomas(9, indice) = LabelParcial.Text
                Matriz_Iidiomas(10, indice) = LabelTotal.Text

            End If

          


                DGVIdiomas.Rows.Add(indice + 1, Matriz_Iidiomas(0, indice), Matriz_Iidiomas(1, indice), Matriz_Iidiomas(2, indice), Matriz_Iidiomas(3, indice), Matriz_Iidiomas(4, indice), Matriz_Iidiomas(5, indice), Matriz_Iidiomas(6, indice), Matriz_Iidiomas(7, indice), Matriz_Iidiomas(8, indice), Matriz_Iidiomas(9, indice), Matriz_Iidiomas(10, indice))
                indice = indice + 1

            Else
                MessageBox.Show("Ya se lleno el cupo")

        End If



    End Sub

    
    Private Sub ComboBoxIdiomas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIdiomas.SelectedIndexChanged
        

    End Sub

    Private Sub LimpiarDatagridviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarDatagridviewToolStripMenuItem.Click

        If MsgBox("¿Desea eliminar todos los registros?", vbQuestion + vbYesNo, "Limpieza") = vbYes Then
            limpiar_Matriz()
            Limpiar_DGV()
            limpiar_Entradas()
        Else
            TBoxCarnet.Focus()
        End If


    End Sub
End Class
