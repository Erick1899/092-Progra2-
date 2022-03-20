Public Class Form1

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCUI.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCOSTOTV.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNombre.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxEMPLEO.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()

        Else

            limpiar_Entradas()


        End If
    End Sub

    Private Sub LIMPIARLISTBOXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIMPIARLISTBOXToolStripMenuItem.Click
        limpiar_listbox()

    End Sub


    Private Sub ACEPTARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACEPTARToolStripMenuItem.Click


        If indice < 6 Then

            Matriz_Empeño(0, indice) = TextBoxNombre.Text
            ListBox1.Items.Add(Matriz_Empeño(0, indice))

            Matriz_Empeño(1, indice) = TextBoxCUI.Text
            ListBox2.Items.Add(Matriz_Empeño(1, indice))

            Matriz_Empeño(2, indice) = TextBoxDIRECCION.Text
            ListBox3.Items.Add(Matriz_Empeño(2, indice))

            Matriz_Empeño(3, indice) = TextBoxEMPLEO.Text
            ListBox4.Items.Add(Matriz_Empeño(3, indice))

            If RadioButtonCORTO.Checked = True And CheckBoxTV.Checked = True Then
                Matriz_Empeño(4, indice) = "TV"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroTVCORTO + TextBoxCOSTOTV.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = "0"
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If

            If RadioButtonLARGO.Checked = True And CheckBoxTV.Checked = True Then
                Matriz_Empeño(4, indice) = "TV"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroTVLARGO + TextBoxCOSTOTV.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = "0"
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If


            If RadioButtonCORTO.Checked = True And CheckBoxCEL.Checked = True Then
                Matriz_Empeño(4, indice) = "TELEFONO"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroCELCORTO + TextBoxCOSTOCEL.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = "0"
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If
            If RadioButtonLARGO.Checked = True And CheckBoxCEL.Checked = True Then
                Matriz_Empeño(4, indice) = "TELEFONO"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroCELLARGO + TextBoxCOSTOCEL.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = "0"
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If
            If RadioButtonCORTO.Checked = True And CheckBoxLAPTOP.Checked = True Then
                Matriz_Empeño(4, indice) = "LAPTOP"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroLAPTOPCORTO + TextBoxCOSTOLAPTOP.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = "0"
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If

            If RadioButtonLARGO.Checked = True And CheckBoxLAPTOP.Checked = True Then
                Matriz_Empeño(4, indice) = "LAPTOP"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroLAPTOPLARGO + TextBoxCOSTOLAPTOP.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = "0"
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If
            If RadioButtonCORTO.Checked = True And CheckBoxREFRI.Checked = True Then
                Matriz_Empeño(4, indice) = "REFRIGERADORA"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroREFRICORTO + TextBoxCOSTOREFRI.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = "0"
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If
            If RadioButtonLARGO.Checked = True And CheckBoxREFRI.Checked = True Then
                Matriz_Empeño(4, indice) = "REFRIGERADORA"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroREFRILARGO + TextBoxCOSTOREFRI.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = "0"
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If

            'codigo para tv y Refrigeradora----------------------------------------------------------------------------

            If RadioButtonCORTO.Checked = True And CheckBoxTV.Checked = True And CheckBoxREFRI.Checked = True Then
                Matriz_Empeño(4, indice) = "TV Y REFRIGERADORA"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroREFRICORTO + TextBoxCOSTOREFRI.Text + CobroTVCORTO + TextBoxCOSTOTV.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = LabelPagoParcial.Text * DescuentoTV_REFRI_CORTO
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If

            If RadioButtonLARGO.Checked = True And CheckBoxTV.Checked = True And CheckBoxREFRI.Checked = True Then
                Matriz_Empeño(4, indice) = "TV Y REFRIGERADORA"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroREFRILARGO + TextBoxCOSTOREFRI.Text + CobroTVLARGO + TextBoxCOSTOTV.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = LabelPagoParcial.Text * DescuentoTV_REFRI_LARGO
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If

            'codigo para Telefono y Laptop----------------------------------------------------------------------------
            If RadioButtonCORTO.Checked = True And CheckBoxCEL.Checked = True And CheckBoxLAPTOP.Checked = True Then
                Matriz_Empeño(4, indice) = "TELEFONO Y LAPTOP"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroCELCORTO + TextBoxCOSTOREFRI.Text + CobroLAPTOPCORTO + TextBoxCOSTOTV.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = LabelPagoParcial.Text * DescuentoCEL_LAPTOP_CORTO
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If
            If RadioButtonLARGO.Checked = True And CheckBoxCEL.Checked = True And CheckBoxLAPTOP.Checked = True Then
                Matriz_Empeño(4, indice) = "TELEFONO Y LAPTOP"
                ListBox5.Items.Add(Matriz_Empeño(4, indice))

                LabelPagoParcial.Text = CobroCELLARGO + TextBoxCOSTOREFRI.Text + CobroLAPTOPLARGO + TextBoxCOSTOTV.Text
                Matriz_Empeño(5, indice) = LabelPagoParcial.Text
                ListBox6.Items.Add(Matriz_Empeño(5, indice))

                LabelDescuento.Text = LabelPagoParcial.Text * DescuentoCEL_LAPTOP_LARGO
                Matriz_Empeño(6, indice) = LabelDescuento.Text
                ListBox7.Items.Add(Matriz_Empeño(6, indice))

                LabelPagoTotal.Text = LabelPagoParcial.Text + LabelDescuento.Text
                Matriz_Empeño(7, indice) = LabelPagoTotal.Text
                ListBox8.Items.Add(Matriz_Empeño(7, indice))

            End If

            indice = indice + 1
        Else

            MessageBox.Show(" Matriz LLENA")

        End If

    End Sub

    Private Sub CheckBoxTV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTV.CheckedChanged
        TextBoxCOSTOTV.Enabled = True
    End Sub

    Private Sub CheckBoxLAPTOP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxLAPTOP.CheckedChanged
        TextBoxCOSTOLAPTOP.Enabled = True

    End Sub

    Private Sub CheckBoxCEL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxCEL.CheckedChanged
        TextBoxCOSTOCEL.Enabled = True

    End Sub

    Private Sub CheckBoxREFRI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxREFRI.CheckedChanged
        TextBoxCOSTOREFRI.Enabled = True
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        limpiar_Matriz()

    End Sub


End Class
