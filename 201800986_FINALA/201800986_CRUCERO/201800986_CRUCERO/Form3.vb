Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim existe As Boolean = True
        Dim PARAusqueda = 0
        While (PARAusqueda <= 6) And (existe)
            If (Form1.NIT(PARAusqueda) = Val(TextBoxBuscarNit.Text)) Then
                existe = False '
            Else
                PARAusqueda = PARAusqueda + 1
            End If
        End While

        If (existe = False) Then
            MsgBox("Registro Encontrado exitosamente")
            DataGridViewBusqueda.Rows.Add(Form1.pos(PARAusqueda), Form1.NIT(PARAusqueda), Form1.NOMBRE(PARAusqueda), Form1.CABINA(PARAusqueda), Form1.PERSONAS(PARAusqueda), Form1.CLASE(PARAusqueda), Form1.PAGOINDIVIDUAL(PARAusqueda), Form1.PAGOTOTAL(PARAusqueda))



        Else

            MsgBox("INGRESE EL NIT", MsgBoxStyle.Information, "ERROR")

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class