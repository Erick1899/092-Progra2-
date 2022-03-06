Public Class Form1
    Public pos As String

    Public nombre(6) As String
    Public NIT(6) As Integer
    Public NumHospitalizado(6) As Integer
    Public honorario(6) As Integer

    Public habitacion(6) As String
    Public servicio(6) As String
    Public tipopago(6) As String







    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()

        Else

            limpiar()

        End If
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarEntradasToolStripMenuItem1.Click

        limpiar()

    End Sub


    Private Sub TextBoxNit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxDiasHospi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxDiasHospi.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxHonorarios_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxHonorarios.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxNombrePaciente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNombrePaciente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    
    Private Sub LimpiarEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        
        Form2.Show()
        Me.Hide()

        If (TextBoxNombrePaciente.Text = "" Or TextBoxNit.Text = "" Or TextBoxDiasHospi.Text = "" Or TextBoxHonorarios.Text = "") Then
            MsgBox("Error, No ingreso Datos del paciente")
            TextBoxNombrePaciente.Focus()
            TextBoxNit.Focus()
            TextBoxDiasHospi.Focus()
            TextBoxHonorarios.Focus()
            Exit Sub
        End If

        nombre(pos) = TextBoxNombrePaciente.Text
        ListBox1.Items.Add(nombre(pos))

        NIT(pos) = TextBoxNit.Text
        ListBox2.Items.Add(NIT(pos))

        NumHospitalizado(pos) = TextBoxDiasHospi.Text
        ListBox3.Items.Add(NumHospitalizado(pos))

        honorario(pos) = TextBoxHonorarios.Text
        ListBox4.Items.Add(honorario(pos))



        If (RButtonPrivada.Checked) Then
            habitacion(pos) = "Privada"
            ListBox5.Items.Add(habitacion(pos))
        ElseIf (RButtonSemi.Checked) Then
            habitacion(pos) = "Semi-Privada"
            ListBox5.Items.Add(habitacion(pos))
        ElseIf (RButtonNoPrivada.Checked) Then
            habitacion(pos) = "No Privada"
            ListBox5.Items.Add(habitacion(pos))
        End If

        If (CBoxEncamamiento.Checked) Then
            servicio(pos) = "Encamamiento"
            ListBox6.Items.Add(servicio(pos))
        ElseIf (CBoxOperacion.Checked) Then
            servicio(pos) = "Operación"
            ListBox6.Items.Add(servicio(pos))
        ElseIf (CBoxMaternidad.Checked) Then
            servicio(pos) = "Maternidad"
            ListBox6.Items.Add(servicio(pos))

        End If

        If (RButtonEfectivo.Checked) Then
            tipopago(pos) = "Efectivo"
            ListBox7.Items.Add(tipopago(pos))
        ElseIf (RButtonCheque.Checked) Then
            tipopago(pos) = "Cheque"
            ListBox7.Items.Add(tipopago(pos))
        ElseIf (RButtonCredito.Checked) Then
            tipopago(pos) = "Tarjeta de Crédito"
            ListBox7.Items.Add(tipopago(pos))
        ElseIf (RButtonDebito.Checked) Then
            tipopago(pos) = "Tarjeta de Débito"
            ListBox7.Items.Add(tipopago(pos))
        End If
        pos = pos + 1







        'Tipo de servicio Encamamiento----------------------------------------------------------------------------

        If CBoxEncamamiento.Checked = True And RButtonPrivada.Checked = True Then
            Module1.SubTOTAL = Module1.PEncamamientoyPrivada
            Form2.LabelSubTotal.Text = Module1.SubTOTAL

            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxEncamamiento.Checked = True And RButtonSemi.Checked = True Then
            Module1.SubTOTAL = Module1.PEncamamientoySemi
            Form2.LabelSubTotal.Text = Module1.SubTOTAL

            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxEncamamiento.Checked = True And RButtonNoPrivada.Checked = True Then
            Module1.SubTOTAL = Module1.PEncamamientoyNormal
            Form2.LabelSubTotal.Text = Module1.SubTOTAL

            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        'Tipo de Servicio OPERACIÓN---------------------------------------------------------------------

        If CBoxOperacion.Checked = True And RButtonPrivada.Checked = True Then
            Module1.SubTOTAL = Module1.POperaciónyPrivada
            Form2.LabelSubTotal.Text = Module1.SubTOTAL

            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxOperacion.Checked = True And RButtonSemi.Checked = True Then
            Module1.SubTOTAL = Module1.POperacionySemi
            Form2.LabelSubTotal.Text = Module1.SubTOTAL

            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxOperacion.Checked = True And RButtonNoPrivada.Checked = True Then
            Module1.SubTOTAL = Module1.POperacionyNormal
            Form2.LabelSubTotal.Text = Module1.SubTOTAL

            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        'Tipo de Servicio Maternidad---------------------------------------------------------------------

        If CBoxMaternidad.Checked = True And RButtonPrivada.Checked = True Then
            Module1.SubTOTAL = Module1.PMaternidadyPrivada
            Form2.LabelSubTotal.Text = Module1.SubTOTAL

            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxMaternidad.Checked = True And RButtonSemi.Checked = True Then
            Module1.SubTOTAL = Module1.PMaternidadySemi
            Form2.LabelSubTotal.Text = Module1.SubTOTAL

            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxMaternidad.Checked = True And RButtonNoPrivada.Checked = True Then
            Module1.SubTOTAL = Module1.PMaternidadyNormal
            Form2.LabelSubTotal.Text = Module1.SubTOTAL

            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        'Codigo para dos opciones de servicio---------------------------------------------------------------------

        ' ENCAMAMIENTO Y OPERACIÓN-------------------------------------------------------------------------------

        If CBoxEncamamiento.Checked = True And CBoxOperacion.Checked = True And RButtonPrivada.Checked = True Then

            Module1.SubTOTAL = Module1.PEncamamientoyPrivada + Module1.POperaciónyPrivada
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxEncamamiento.Checked = True And CBoxOperacion.Checked = True And RButtonSemi.Checked = True Then

            Module1.SubTOTAL = Module1.PEncamamientoySemi + Module1.POperacionySemi
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxEncamamiento.Checked = True And CBoxOperacion.Checked = True And RButtonNoPrivada.Checked = True Then

            Module1.SubTOTAL = Module1.PEncamamientoyNormal + Module1.POperacionyNormal
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If


        ' Maternidad Y OPERACIÓN-------------------------------------------------------------------------------

        If CBoxMaternidad.Checked = True And CBoxOperacion.Checked = True And RButtonPrivada.Checked = True Then

            Module1.SubTOTAL = Module1.PMaternidadyPrivada + Module1.POperaciónyPrivada
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxMaternidad.Checked = True And CBoxOperacion.Checked = True And RButtonSemi.Checked = True Then

            Module1.SubTOTAL = Module1.PMaternidadySemi + Module1.POperacionySemi
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxMaternidad.Checked = True And CBoxOperacion.Checked = True And RButtonNoPrivada.Checked = True Then

            Module1.SubTOTAL = Module1.PMaternidadyNormal + Module1.POperacionyNormal
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        ' ENCAMAMIENTO Y MATERNIDAD-------------------------------------------------------------------------------

        If CBoxEncamamiento.Checked = True And CBoxMaternidad.Checked = True And RButtonPrivada.Checked = True Then

            Module1.SubTOTAL = Module1.PEncamamientoyPrivada + Module1.PMaternidadyPrivada
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxEncamamiento.Checked = True And CBoxMaternidad.Checked = True And RButtonSemi.Checked = True Then

            Module1.SubTOTAL = Module1.PEncamamientoySemi + Module1.PMaternidadySemi
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxEncamamiento.Checked = True And CBoxEncamamiento.Checked = True And RButtonNoPrivada.Checked = True Then

            Module1.SubTOTAL = Module1.PEncamamientoyNormal + Module1.PMaternidadyNormal
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        'Codigo para las tres opciones de servicio---------------------------------------------------------------------

        ' ENCAMAMIENTO, OPERACION Y Matenidad -------------------------------------------------------------------------------

        If CBoxEncamamiento.Checked = True And CBoxOperacion.Checked = True And CBoxMaternidad.Checked = True And RButtonPrivada.Checked = True Then
            Module1.SubTOTAL = Module1.PEncamamientoyPrivada + Module1.POperaciónyPrivada + Module1.PMaternidadyPrivada
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxEncamamiento.Checked = True And CBoxOperacion.Checked = True And CBoxMaternidad.Checked = True And RButtonSemi.Checked = True Then
            Module1.SubTOTAL = Module1.PEncamamientoySemi + Module1.POperacionySemi + Module1.PMaternidadySemi
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If

        If CBoxEncamamiento.Checked = True And CBoxOperacion.Checked = True And CBoxMaternidad.Checked = True And RButtonNoPrivada.Checked = True Then
            Module1.SubTOTAL = Module1.PEncamamientoyNormal + Module1.POperacionyNormal + Module1.PMaternidadyNormal
            Form2.LabelSubTotal.Text = Module1.SubTOTAL
            If RButtonCheque.Checked = True Or RButtonEfectivo.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocheque_efectivo
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonDebito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagodebito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If
            If RButtonCredito.Checked = True Then
                Module1.Descuento = Module1.SubTOTAL * Module1.pagocredito
                Form2.LabelDescuento.Text = Module1.Descuento
                Form2.LabelTotalaPagar.Text = Module1.SubTOTAL + Module1.Descuento
            End If

        End If



    End Sub

    Private Sub LimpiarListboxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarListboxToolStripMenuItem.Click
        limpiarlistbox()

    End Sub
End Class
