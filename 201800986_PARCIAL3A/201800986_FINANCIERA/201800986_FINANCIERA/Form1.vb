Public Class Form1

    Public pos As String
    Public idcliente(7) As Double
    Public viaje(7) As String
    Public DiasReserva(7) As Double
    Public CantidadPersonas(7) As Double
    Public PrecioporDia(7) As Double
    Public Pagototal(7) As Double





    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()
        End If
    End Sub

    Private Sub TextBoxIdCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxIdCliente.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxNoDias_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNoDias.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxNoPersonas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNoPersonas.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click

        If pos < 7 Then

            idcliente(pos) = TextBoxIdCliente.Text
            DiasReserva(pos) = TextBoxNoDias.Text
            CantidadPersonas(pos) = TextBoxNoPersonas.Text



            If ComboBoxViaje.SelectedItem = "Laguna Brava (Huehuetenango)" Then

                viaje(pos) = ComboBoxViaje.SelectedItem
                LabelPrecioDia.Text = PrecioLaguna
                PrecioporDia(pos) = LabelPrecioDia.Text
                LabelTotalPago.Text = PrecioLaguna * TextBoxNoDias.Text * TextBoxNoPersonas.Text
                Pagototal(pos) = LabelTotalPago.Text

            End If

            If ComboBoxViaje.SelectedItem = "Mirador (Petén)" Then

                viaje(pos) = ComboBoxViaje.SelectedItem
                LabelPrecioDia.Text = PrecioMirador
                PrecioporDia(pos) = LabelPrecioDia.Text
                LabelTotalPago.Text = PrecioMirador * TextBoxNoDias.Text * TextBoxNoPersonas.Text
                Pagototal(pos) = LabelTotalPago.Text

            End If

            If ComboBoxViaje.SelectedItem = "Biotopo del Quetzal (Baja Verapaz)" Then

                viaje(pos) = ComboBoxViaje.SelectedItem
                LabelPrecioDia.Text = PrecioBiotopo
                PrecioporDia(pos) = LabelPrecioDia.Text
                LabelTotalPago.Text = PrecioBiotopo * TextBoxNoDias.Text * TextBoxNoPersonas.Text
                Pagototal(pos) = LabelTotalPago.Text

            End If


            Form2.DataGridViewDatos.Rows.Add(pos + 1, idcliente(pos), viaje(pos), DiasReserva(pos), CantidadPersonas(pos), PrecioporDia(pos), Pagototal(pos))
            pos = pos + 1
        Else

            MessageBox.Show("Ya se lleno el cupo")
        End If

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        pos = 0
        ReDim idcliente(7)
        ReDim viaje(7)
        ReDim DiasReserva(7)
        ReDim CantidadPersonas(7)
        ReDim PrecioporDia(7)
        ReDim Pagototal(7)

        Limpiar_Entradas()
        Limpiar_Data()


        MessageBox.Show("Vectores Limpios")

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class
