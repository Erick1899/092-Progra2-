Public Class Form1

    Public pos As String
    Public NoEtapa(12) As Double
    Public equipo(12) As String
    Public Kilometros(12) As Double
    Public tiempo(12) As Double
    Public Nacionalidad(12) As String
    Public TiempoTotal(12) As Double

    Dim a


    
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()
        End If
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNumeroEtapa.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxKilometros.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxTiempo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_Entradas()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click

        pos = 0
        ReDim NoEtapa(12)
        ReDim equipo(12)
        ReDim Kilometros(12)
        ReDim tiempo(12)
        ReDim Nacionalidad(12)
        ReDim TiempoTotal(12)
        limpiar_Data()

        MessageBox.Show("Vectores Limpios")
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        DataGridViewDatos.Visible = True

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click

        If pos < 12 Then

            NoEtapa(pos) = TextBoxNumeroEtapa.Text
            equipo(pos) = ComboBoxEquipo.SelectedItem
            Kilometros(pos) = TextBoxKilometros.Text
            tiempo(pos) = TextBoxTiempo.Text
            Nacionalidad(pos) = ComboBoxNacionalidad.SelectedItem

            If TextBoxTiempo.Text > 120 Then
                a = TextBoxTiempo.Text + Penalizacion1
                TiempoTotal(pos) = a
            End If

            If TextBoxTiempo.Text > 140 Then
                a = TextBoxTiempo.Text + penalizacion2
                TiempoTotal(pos) = a
            End If

            If TextBoxTiempo.Text > 160 Then
                a = TextBoxTiempo.Text + penalizacion3
                TiempoTotal(pos) = a
            End If

            If TextBoxTiempo.Text < 85 And ComboBoxEquipo.SelectedItem = "Movistar" Then
                a = TextBoxTiempo.Text - reduccion1
                TiempoTotal(pos) = a
            End If

            If TextBoxTiempo.Text < 85 And ComboBoxEquipo.SelectedItem = "Pro Team" Then
                a = TextBoxTiempo.Text - reduccion2
                TiempoTotal(pos) = a
            End If

            If TextBoxTiempo.Text <= 120 Then
                TiempoTotal(pos) = TextBoxTiempo.Text
            End If

            DataGridViewDatos.Rows.Add(pos + 1, NoEtapa(pos), equipo(pos), Kilometros(pos), tiempo(pos), Nacionalidad(pos), TiempoTotal(pos))
            pos = pos + 1

            MessageBox.Show("Datos Guardadados Exitosamente")


        Else

            MessageBox.Show("Ya se lleno el cupo")
        End If

    End Sub

    Private Sub TextBoxConsulta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxConsulta.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ButtonACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonACEPTAR.Click

        Dim existe As Boolean = True
        Dim PARAusqueda = 0
        While (PARAusqueda <= 12) And (existe)
            If (NoEtapa(PARAusqueda) = Val(TextBoxConsulta.Text)) Then
                existe = False '
            Else
                PARAusqueda = PARAusqueda + 1
            End If
        End While

        If (existe = False) Then
            MsgBox("Registro Encontrado exitosamente")
            DataGridViewDatos.Rows.Add(pos(PARAusqueda), NoEtapa(PARAusqueda), equipo(PARAusqueda), Kilometros(PARAusqueda), tiempo(PARAusqueda), Nacionalidad(PARAusqueda), TiempoTotal(PARAusqueda))

        Else

            MsgBox("INGRESE EL id", MsgBoxStyle.Information, "ERROR")

        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        GroupBox2.Visible = True
        limpiar_Data()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OrdenarAscendenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenarAscendenteToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer

        For i = 0 To 11
            For j = i + 1 To 12
                If (NoEtapa(i) < NoEtapa(j)) Then
                    temp1 = NoEtapa(i)
                    NoEtapa(i) = NoEtapa(j)
                    NoEtapa(j) = temp1

                End If

            Next j
        Next i
    End Sub
End Class
