Public Class Form1

    Const PrecioArroz As Double = 2.0
    Const PrecioFrijol As Double = 1.75
    Const PrecioAzucar As Double = 2.5
    Const IVA As Double = 0.12
    Const ValorDescuento As Double = 0.025


    Dim pagoSinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoConIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagoFinal As Double = 0





    Private Sub TextLBArroz_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextLBArroz.KeyPress

        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub TextLBFrijol_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextLBFrijol.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextLBazucar_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextLBazucar.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        pagoSinIVA = (Val(TextLBArroz.Text) * PrecioArroz) + (Val(TextLBFrijol.Text) * PrecioFrijol) + (Val(TextLBazucar.Text) * PrecioAzucar)
        valorIVA = pagoSinIVA * IVA
        pagoConIVA = pagoSinIVA + valorIVA

        descuento = ValorDescuento * pagoConIVA
        pagoFinal = pagoConIVA - descuento


        labelpagosiniva.Text = pagoSinIVA
        LabelIVA.Text = valorIVA
        LabelpagoconIVA.Text = pagoConIVA
        Labeldescuento.Text = descuento
        LabelTotal.Text = pagoFinal


    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        TextLBArroz.Clear()
        TextLBFrijol.Clear()
        TextLBazucar.Clear()

        labelpagosiniva.Text = 0.0
        LabelIVA.Text = 0.0
        LabelpagoconIVA.Text = 0.0
        Labeldescuento.Text = 0.0
        LabelTotal.Text = 0.0


    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Me.Close()

    End Sub


End Class
