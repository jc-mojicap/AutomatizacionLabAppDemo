Public Class Datos_Participante
    Dim nombre As String
    Dim edad As String
    Dim genero As String
    Dim carrera, semestre As String
    Dim cerrar As MsgBoxResult
    Dim auxCerrar As Boolean

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AjustarControles() 'Carga la rutina de ajustar controles del formulario
    End Sub

    Sub AjustarControles() 'Rutina para ajusta todos los elementos del formulario a la pantalla.
        Dim tControl As Control
        Dim desktopSize As Size
        Dim AjustarFuentesAlAncho As Boolean = True
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim PorcentajeH, TamañoFuente, PorcentajeW As Double
        Dim AntHeight As Integer = Me.Height 'tamaño inicial
        Dim AntWidth As Integer = Me.Width 'tamaño inicial
        Dim Height As Integer = desktopSize.Height
        Dim Width As Integer = desktopSize.Width
        If Me.Size.Height < desktopSize.Height And Me.Width < desktopSize.Width Then
            PorcentajeH = ((Height - AntHeight) * 100) / AntHeight
            PorcentajeW = ((Width - AntWidth) * 100) / AntWidth
            For Each tControl In Me.Controls
                If TypeOf tControl Is PictureBox Or TypeOf tControl Is Panel Or TypeOf tControl Is Button Or TypeOf tControl Is Label Or TypeOf tControl Is ComboBox Or TypeOf tControl Is TextBox Then
                    tControl.Top = tControl.Top + ((PorcentajeH * tControl.Top) / 100)
                    tControl.Left = tControl.Left + ((PorcentajeW * tControl.Left) / 100)
                    tControl.Width = tControl.Width + ((PorcentajeW * tControl.Width) / 100)
                    tControl.Height = tControl.Height + ((PorcentajeH * tControl.Height) / 100)
                    TamañoFuente = tControl.Font.Size + ((PorcentajeW * tControl.Font.Size) / 100)
                    tControl.Font = New Font("Lucida Fax", TamañoFuente)
                End If
                Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Next tControl
        End If
    End Sub

  Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrar = CType(MessageBox.Show("Desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If cerrar = MsgBoxResult.No Then
            e.Cancel = True
        End If
        If cerrar = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub butSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click 'Guarda la información del participante en el txt

        nombre = txtNombre.Text
        codigo = txtCodigo.Text
        edad = cbEdad.SelectedItem
        genero = cbGenero.SelectedItem
        carrera = cbCarrera.SelectedItem
        semestre = cbSemestre.SelectedItem

        If genero = "Femenino" Then
            genero = 1
        End If
        If genero = "Masculino" Then
            genero = 0
        End If

        If nombre = "" Or codigo = "" Or cbEdad.SelectedItem = "" Or cbGenero.SelectedItem = "" Or cbCarrera.SelectedItem = "" Or cbSemestre.SelectedItem = "" Then
            MessageBox.Show("Existen campos vacíos, verifique los campos e inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Verifica que se inserten los datos o muestra el mensaje
        Else 'Oculta los elementos que toman los datos y muestra los elementos de la instrucción de retroalimentación. 
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            cbEdad.Visible = False
            cbCarrera.Visible = False
            cbSemestre.Visible = False
            lbCodigo.Visible = False
            txtCodigo.Visible = False
            cbGenero.Visible = False
            txtNombre.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            btnSiguiente.Visible = False
            lbInstrucciones.Visible = True
            btnIncorrecto.Visible = True
            btnCorrecto.Visible = True
            btnComenzar.Visible = True
        End If
    End Sub

    Private Sub btnComenzar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComenzar.Click 'Control de creación de la carpeta y archivos que registran los datos
        Select Case grupo
            Case 1  'Para Grupo 1
                If My.Computer.FileSystem.DirectoryExists(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\") Then
                    My.Computer.FileSystem.DeleteDirectory(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If 'Verifica la existencia de la carpeta antes de iniciar el programa y si existe la reemplaza
                nombre_archivo_txt = "Grupo_1_Fase_1" 'Selecciona el archivo que leera para controlar los ensayos
                Me.Texto.Text = My.Resources.Grupo_1_Fase_1 'Llama el archivo para lectura
                My.Computer.FileSystem.CreateDirectory(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\") 'Crea la carpeta interna que guarda los datos del participante
                My.Computer.FileSystem.CreateDirectory(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\") 'Crea carpeta que guarda los txt que controlan los ensayos, pero al final se eliminan
                Texto.SaveFile(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\" & nombre_archivo_txt & ".txt", RichTextBoxStreamType.PlainText) 'Copian el archivo en recursos y lo guardan en la carpeta
                Texto.SaveFile(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\" & nombre_archivo_txt & ".txt", RichTextBoxStreamType.PlainText) 'igual
                FileOpen(1, Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\" & nombre_archivo_txt & ".txt", OpenMode.Input) 'Abre el txt que está en recursos
                FileOpen(2, Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & codigo & "(datos_participante).txt", OpenMode.Append) 'Abre el txt en el que se escriben los datos del participante
        End Select

        PrintLine(2, experimento & "; " & sujeto & "; " & grupo & "; " & nombre & "; " & codigo & "; " & edad & "; " & genero & "; " & carrera & "; " & semestre & "; " & Date.Now)
        FileClose(2) 'Guarda en el Archivo 2 los datos del participante y cierra el archivo

        Select Case grupo 'Abre los archivos txt para lectura, de acuerdo al grupo
            Case 1
                FileOpen(2, Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & codigo & ".txt", OpenMode.Append)
        End Select

        oExcel = CreateObject("Excel.Application") 'Creación archivo en Excel
        oBook = oExcel.Workbooks.Add
        oSheet = oBook.Worksheets(1)
        Dim x As New Ejecucion_Experimento
        x.Show()
        Me.Hide()

    End Sub

    Private Sub btnCorrecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrecto.Click
        My.Computer.Audio.Play(My.Resources.tada, AudioPlayMode.Background) 'Reproduce el sonido de "correcto"
    End Sub

    Private Sub btnIncorrecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncorrecto.Click
        My.Computer.Audio.Play(My.Resources.chord, AudioPlayMode.Background) 'Reproduce el sonido de "incorrecto"
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress 'Valida que el participante introduzca sólo números al formulario

        If e.Handled = Not IsNumeric(e.KeyChar) Then
            If Not Char.IsControl(e.KeyChar) Then
            Else
                MsgBox("El valor ingresado debe contener solo números")
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress 'Igual

        Dim caracteresPermitidos As String = "1234567890 " & Convert.ToChar(8)
        Dim c As Char = e.KeyChar

        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Ingrese solamente números.", "ERROR de escritura", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
    End Sub

    Sub Guardar_Archivos()
        FileClose(1)
        FileClose(2)
        Select Case grupo
            Case 1
                My.Computer.FileSystem.DeleteDirectory(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\", FileIO.DeleteDirectoryOption.DeleteAllContents)
                oBook.SaveAs(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & codigo & "Grupo1.xlsx")
                oExcel.Quit()
        End Select
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub Texto_TextChanged(sender As Object, e As EventArgs) Handles Texto.TextChanged

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
    Private Sub lbInstrucciones_Click(sender As Object, e As EventArgs) Handles lbInstrucciones.Click

    End Sub
End Class
