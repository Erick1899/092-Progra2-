Public Class Form1

    Public pos As String
    Public NIT(6) As Double
    Public NOMBRE(6) As String
    Public CABINA(6) As String
    Public PERSONAS(6) As Double
    Public CLASE(6) As String
    Public PAGOINDIVIDUAL(6) As Double
    Public PAGOTOTAL(6) As Double




    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()
        End If
    End Sub

    Private Sub TextBoxNIT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNIT.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxPersonas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPersonas.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DATOSDEENTRADAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATOSDEENTRADAToolStripMenuItem.Click
        limpiar_Entradas()

    End Sub

    Private Sub OPERARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPERARToolStripMenuItem.Click

        If pos < 6 Then

            NIT(pos) = TextBoxNIT.Text
            NOMBRE(pos) = TextBoxNombre.Text
            CABINA(pos) = ComboBoxCabina.SelectedItem
            PERSONAS(pos) = TextBoxPersonas.Text
            CLASE(pos) = ComboBoxClase.SelectedItem


            If ComboBoxCabina.SelectedItem = "Sencilla" And ComboBoxClase.SelectedItem = "Primera Clase" Then
                LabelPrecioIndividual.Text = Sencilla_Primera
                LabelTotalPago.Text = Sencilla_Primera * TextBoxPersonas.Text

                PAGOINDIVIDUAL(pos) = LabelPrecioIndividual.Text
                PAGOTOTAL(pos) = LabelTotalPago.Text

            End If

            If ComboBoxCabina.SelectedItem = "Doble" And ComboBoxClase.SelectedItem = "Primera Clase" Then
                LabelPrecioIndividual.Text = Doble_Primera
                LabelTotalPago.Text = Doble_Primera * TextBoxPersonas.Text

                PAGOINDIVIDUAL(pos) = LabelPrecioIndividual.Text
                PAGOTOTAL(pos) = LabelTotalPago.Text

            End If

            If ComboBoxCabina.SelectedItem = "Compartida" And ComboBoxClase.SelectedItem = "Primera Clase" Then
                LabelPrecioIndividual.Text = compartida_Primera
                LabelTotalPago.Text = compartida_Primera * TextBoxPersonas.Text

                PAGOINDIVIDUAL(pos) = LabelPrecioIndividual.Text
                PAGOTOTAL(pos) = LabelTotalPago.Text

            End If

            If ComboBoxCabina.SelectedItem = "Sencilla" And ComboBoxClase.SelectedItem = "Segunda Clase" Then
                LabelPrecioIndividual.Text = Sencilla_Segunda
                LabelTotalPago.Text = Sencilla_Segunda * TextBoxPersonas.Text

                PAGOINDIVIDUAL(pos) = LabelPrecioIndividual.Text
                PAGOTOTAL(pos) = LabelTotalPago.Text

            End If

            If ComboBoxCabina.SelectedItem = "Doble" And ComboBoxClase.SelectedItem = "Segunda Clase" Then
                LabelPrecioIndividual.Text = Doble_Segunda
                LabelTotalPago.Text = Doble_Segunda * TextBoxPersonas.Text

                PAGOINDIVIDUAL(pos) = LabelPrecioIndividual.Text
                PAGOTOTAL(pos) = LabelTotalPago.Text

            End If

            If ComboBoxCabina.SelectedItem = "Compartida" And ComboBoxClase.SelectedItem = "Segunda Clase" Then
                LabelPrecioIndividual.Text = Compartida_Segunda
                LabelTotalPago.Text = Compartida_Segunda * TextBoxPersonas.Text

                PAGOINDIVIDUAL(pos) = LabelPrecioIndividual.Text
                PAGOTOTAL(pos) = LabelTotalPago.Text

            End If

            Form2.DataGridViewDatos.Rows.Add(pos + 1, NIT(pos), NOMBRE(pos), CABINA(pos), PERSONAS(pos), CLASE(pos), PAGOINDIVIDUAL(pos), PAGOTOTAL(pos))
            pos = pos + 1
        Else

            MessageBox.Show("Ya se lleno el cupo")

        End If




    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub VECTORESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VECTORESToolStripMenuItem.Click

        limpiar_Vectores()
        Limpiar_Data()


    End Sub
End Class
