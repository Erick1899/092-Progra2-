Public Class Form1
    Public pos As String

    Public nombre(7) As String
    Public Sueldo(7) As Integer
    Public Articulo(7) As String
    Public Comision(7) As Integer

    Public Bono(7) As Integer
    Public SueldoFinal(7) As Integer

    
    Private Sub TBoxSueldo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBoxSueldo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
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


    Private Sub ButtonLimpiarEntradas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLimpiarEntradas.Click
        Limpiar_Entradas()

    End Sub

    Private Sub ButtonCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalcular.Click
        nombre(pos) = TBoxNombre.Text
        ListBox1.Items.Add(nombre(pos))

        Sueldo(pos) = TBoxSueldo.Text
        ListBox2.Items.Add(Sueldo(pos))

        Articulo(pos) = CBoxArticulos.SelectedItem
        ListBox3.Items.Add(Articulo(pos))
        pos = pos + 1

        ' Codigo solo para sueldo Rango 1 -------------------------------------------------------------------

        If TBoxSueldo.Text <= 2000 And CBoxArticulos.SelectedItem = "Tablet" Then
            LabelComisión.Text = PorcentajeComision * PrecioTablet
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono1 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If

        If TBoxSueldo.Text <= 2000 And CBoxArticulos.SelectedItem = "Drone" Then
            LabelComisión.Text = PorcentajeComision * PrecioDrone
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono1 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If

        If TBoxSueldo.Text <= 2000 And CBoxArticulos.SelectedItem = "Celular" Then
            LabelComisión.Text = PorcentajeComision * PrecioCelular
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono1 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If

        If TBoxSueldo.Text <= 2000 And CBoxArticulos.SelectedItem = "Televisor" Then
            LabelComisión.Text = PorcentajeComision * PrecioTelevisor
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono1 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If

        ' Codigo solo para sueldo Rango 2 -------------------------------------------------------------------

        If TBoxSueldo.Text <= 5000 And CBoxArticulos.SelectedItem = "Tablet" Then
            LabelComisión.Text = PorcentajeComision * PrecioTablet
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono2 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If

        If TBoxSueldo.Text <= 5000 And CBoxArticulos.SelectedItem = "Drone" Then
            LabelComisión.Text = PorcentajeComision * PrecioDrone
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono2 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If

        If TBoxSueldo.Text <= 5000 And CBoxArticulos.SelectedItem = "Celular" Then
            LabelComisión.Text = PorcentajeComision * PrecioCelular
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono2 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If

        If TBoxSueldo.Text <= 5000 And CBoxArticulos.SelectedItem = "Televisor" Then
            LabelComisión.Text = PorcentajeComision * PrecioTelevisor
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono2 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If


        ' Codigo solo para sueldo Rango 3 -------------------------------------------------------------------

        If TBoxSueldo.Text > 5000 And CBoxArticulos.SelectedItem = "Tablet" Then
            LabelComisión.Text = PorcentajeComision * PrecioTablet
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono3 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If

        If TBoxSueldo.Text > 5000 And CBoxArticulos.SelectedItem = "Drone" Then
            LabelComisión.Text = PorcentajeComision * PrecioDrone
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono3 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If

        If TBoxSueldo.Text > 5000 And CBoxArticulos.SelectedItem = "Celular" Then
            LabelComisión.Text = PorcentajeComision * PrecioCelular
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono3 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If

        If TBoxSueldo.Text > 5000 And CBoxArticulos.SelectedItem = "Televisor" Then
            LabelComisión.Text = PorcentajeComision * PrecioTelevisor
            Comision(pos) = LabelComisión.Text
            ListBox4.Items.Add(Comision(pos))

            LabelBono.Text = Bono3 * TBoxSueldo.Text
            Bono(pos) = LabelBono.Text
            ListBox5.Items.Add(Bono(pos))

            LabelSueldoFinal.Text = TBoxSueldo.Text * LabelComisión.Text + LabelBono.Text
            SueldoFinal(pos) = LabelSueldoFinal.Text
            ListBox6.Items.Add(SueldoFinal(pos))
        End If






    End Sub
End Class
