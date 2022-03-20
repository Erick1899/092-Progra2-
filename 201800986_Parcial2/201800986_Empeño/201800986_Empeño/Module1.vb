Module Module1

    Public Const CobroTVCORTO = 250
    Public Const CobroTVLARGO = 300
    Public Const CobroCELCORTO = 550
    Public Const CobroCELLARGO = 600
    Public Const CobroLAPTOPCORTO = 770
    Public Const CobroLAPTOPLARGO = 800
    Public Const CobroREFRICORTO = 1000
    Public Const CobroREFRILARGO = 1200

    Public Const DescuentoTV_REFRI_CORTO = 0.15
    Public Const DescuentoTV_REFRI_LARGO = 0.05
    Public Const DescuentoCEL_LAPTOP_LARGO = 0.1
    Public Const DescuentoCEL_LAPTOP_CORTO = 0.05



    Public Matriz_Empeño(8, 6)
    Public indice = 0

    Sub limpiar_Entradas()
        Form1.TextBoxNombre.Clear()
        Form1.TextBoxCUI.Clear()
        Form1.TextBoxDIRECCION.Clear()
        Form1.TextBoxEMPLEO.Clear()
        Form1.TextBoxCOSTOTV.Clear()
        Form1.TextBoxCOSTOREFRI.Clear()
        Form1.TextBoxCOSTOLAPTOP.Clear()
        Form1.TextBoxCOSTOCEL.Clear()

        Form1.RadioButtonCORTO.Checked = False
        Form1.RadioButtonLARGO.Checked = False

    End Sub

    Sub limpiar_listbox()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()



    End Sub

    Sub limpiar_Matriz()
        indice = 0
        ReDim Matriz_Empeño(8, 6)
    End Sub


End Module
