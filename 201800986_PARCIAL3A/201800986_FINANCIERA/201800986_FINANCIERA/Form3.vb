Public Class Form3
    Dim I

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim existe As Boolean = True
        Dim PARAusqueda = 0
        While (PARAusqueda <= 7) And (existe)
            If (Form1.idcliente(PARAusqueda) = Val(TextBoxBuscarID.Text)) Then
                existe = False '
            Else
                PARAusqueda = PARAusqueda + 1
            End If
        End While

        If (existe = False) Then
            MsgBox("Registro Encontrado exitosamente")
            DataGridViewBusqueda.Rows.Add(Form1.pos(PARAusqueda), Form1.idcliente(PARAusqueda), Form1.viaje(PARAusqueda), Form1.DiasReserva(PARAusqueda), Form1.CantidadPersonas(PARAusqueda), Form1.PrecioporDia(PARAusqueda), Form1.Pagototal(PARAusqueda))



        Else

            MsgBox("INGRESE EL id", MsgBoxStyle.Information, "ERROR")

        End If
    End Sub
End Class