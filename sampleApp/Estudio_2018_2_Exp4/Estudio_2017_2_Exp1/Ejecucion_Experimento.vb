Option Explicit On
Imports VB = Microsoft.VisualBasic
Public Class Ejecucion_Experimento
    Inherits System.Windows.Forms.Form 'Declaración de las variables
    Dim vEncabezado As String
    Dim vCriterio, vNúmerodeEnsayos, vRetroalimentacion, vRegresa, vRepeticiones, vCheckFinal As Integer
    Dim vNumerosaleatoreos(1000), vContador, vCorrecto, vContadorAux, vCaso As Integer
    Dim bloqueAuxF1 As Integer = 1
    Dim hora1, minuto1, segundo1, milisegundo1 As Integer
    Dim vRespuesta, Ensayo As String
    Dim vTiempo1, vTiempodeReacción, vTrack, vEnsayos((1000), (4))
    Dim cerrar As MsgBoxResult
    Dim en, aux1 As Integer
    Public vFase As Integer
    Dim ensayoEs(4) As String
    Dim vRespuestaDada As String
    Dim r
    Dim terminaPrograma As Boolean
    Dim segundo2, minuto2, hora2, milisegundo2, segundo3, milisegundo3 As Integer
    Dim auxInstr_audio As Integer

    Private Sub FIAM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloque = 1
        AjustarControles() 'Llama la rutina para ajustar objetos a la pantalla
        Entrada_Información_Ensayo() 'Realiza lectura de información del txt
        MostrarInstruccion() 'Hace la reproducción de los audios de instrucciones auditivas
    End Sub

    '----------------------PROCESO QUE AJUSTA LOS CONTROLES AL TAMAÑO DE LA PANTALLA DEL PC
    Sub AjustarControles()
        Dim tControl As Control
        Dim desktopSize As Size
        Dim AjustarFuentesAlAncho As Boolean = True
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim PorcentajeH, TamañoFuente, PorcentajeW As Double
        Dim AntHeight As Integer = Me.Height
        Dim AntWidth As Integer = Me.Width
        Dim Height As Integer = desktopSize.Height
        Dim Width As Integer = desktopSize.Width
        If Me.Size.Height < desktopSize.Height And Me.Width < desktopSize.Width Then
            PorcentajeH = ((Height - AntHeight) * 100) / AntHeight
            PorcentajeW = ((Width - AntWidth) * 100) / AntWidth
            For Each tControl In Me.Controls
                If TypeOf tControl Is Label Then
                    TamañoFuente = tControl.Font.Size + ((PorcentajeW * tControl.Font.Size) / 100)
                    tControl.Font = New Font("Cambria", TamañoFuente)
                End If
                If TypeOf tControl Is PictureBox Or TypeOf tControl Is Panel Or TypeOf tControl Is Button Or TypeOf tControl Is Label Or TypeOf tControl Is TextBox Then
                    tControl.Top = tControl.Top + ((PorcentajeH * tControl.Top) / 100)
                    tControl.Left = tControl.Left + ((PorcentajeW * tControl.Left) / 100)
                    tControl.Width = tControl.Width + ((PorcentajeW * tControl.Width) / 100)
                    tControl.Height = tControl.Height + ((PorcentajeH * tControl.Height) / 100)
                End If
                Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Next tControl
        End If
    End Sub


    '------------------------PROCESO QUE SE REALIZA AL CERRAR EL PROGRAMA MANUALMENTE
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrar = CType(MessageBox.Show("Desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If cerrar = MsgBoxResult.No Then
            e.Cancel = True
        End If
        If cerrar = MsgBoxResult.Yes Then
            Guardar_Archivos() 'Guarda lo recogido hasta ahora, cierra los archivos y borra lo que no se necesita
            oExcel.Quit()
            End
        End If
    End Sub

    'CONTROLA LA REPRODUCCIÓN DE LAS INSTRUCCIONES AL INICIO DE CADA FASE
    Sub MostrarInstruccion()
        If vMostrarMensaje = False Then
            picIAM0.Visible = False
            btnReproducir_Instr.Visible = True
            lbIntruccionesAudio.Text = "Antes de continuar haga click en el botón ""reproducir instrucciones"" y escuche las instrucciones por los audífonos. "
            lbIntruccionesAudio.Visible = True
        End If

        If RepiteFase = True Then
            If auxMsjRepoteFase = True Then
                Load_Random_Ensayos()
                Show_Rand_Estímulos()
                Randomize_Posición_Estímulos()
                auxMsjRepoteFase = False
            End If
        End If
    End Sub
    '-------------------  REPRODUCE LA INSTRUCCIÓN DE ACUERDO A LA FASE EN LA QUE SE ENCUENTRE EL PARTICIPANTE ---------------------------------------------
    Private Sub btnReproducir_Instr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReproducir_Instr.Click
        btnReproducir_Instr.Visible = False
        btnAceptar.Visible = False

        Select Case Instr_Audio ' Esta variable hace referencia a la fase
            Case 1
                My.Computer.Audio.Play(My.Resources.FASE_1_EXP__4, AudioPlayMode.WaitToComplete)
                reproducir_Instruccion()
            Case 2
                My.Computer.Audio.Play(My.Resources.FASE_2_EXP__4, AudioPlayMode.WaitToComplete)
                reproducir_Instruccion()
            Case 3
                My.Computer.Audio.Play(My.Resources.FASE_3_EXP__4, AudioPlayMode.WaitToComplete)
                reproducir_Instruccion()
            Case 4
                My.Computer.Audio.Play(My.Resources.FASE_4_EXP__4, AudioPlayMode.WaitToComplete)
                reproducir_Instruccion()
            Case 5
                My.Computer.Audio.Play(My.Resources.FASE_5_EXP__4, AudioPlayMode.WaitToComplete)
                reproducir_Instruccion()
            Case 6
                My.Computer.Audio.Play(My.Resources.FASE_6_EXP__4, AudioPlayMode.WaitToComplete)
                reproducir_Instruccion()
            Case 7
                My.Computer.Audio.Play(My.Resources.FASE_7_EXP__4, AudioPlayMode.WaitToComplete)
                reproducir_Instruccion()
            Case 8
                My.Computer.Audio.Play(My.Resources.FASE_8_EXP__4, AudioPlayMode.WaitToComplete)
                reproducir_Instruccion()
            Case 9
                My.Computer.Audio.Play(My.Resources.FASE_9_EXP__4, AudioPlayMode.WaitToComplete)
                reproducir_Instruccion()
            Case 10
                My.Computer.Audio.Play(My.Resources.FASE_10_EXP__4, AudioPlayMode.WaitToComplete)
                reproducir_Instruccion()
        End Select

    End Sub
    '--------- PROCESO QUE EJECUTA EL PROGRAMA CUANDO TERMINA DE REPRODUCIR UNA INSTRUCCIÓN --------------------------------
    'Aparece el botón "Reproducir instrucciones" y el botón "Siguiente". 
    Sub reproducir_Instruccion()
        My.Computer.Audio.Stop()
        Instr_Audio = vFase
        btnAceptar.Visible = True
        btnReproducir_Instr.Visible = True
        milisegundo2 = 0
        segundo2 = 0
        vMostrarMensaje = True

    End Sub
    '----------------- PROCESO DEL BOTÓN LUEGO DE REPRODUCIR UNA INSTRUCCIÓN -----------------------------
    'Controla el cambio en el formulario para iniciar la primera fase
    Private Sub bntAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        My.Computer.Audio.Stop()
        lbIntruccionesAudio.Visible = False
        btnReproducir_Instr.Visible = False
        lbInstruccion.Visible = False
        btnAceptar.Visible = False
        picIAM0.Visible = True
        Load_Random_Ensayos()
        Show_Rand_Estímulos()
        Randomize_Posición_Estímulos()
    End Sub


    '------------------- PROCESO QUE TRAE DEL TXT LAS CONDICIONES PARA CADA FASE---------------------------------------------
    Sub Entrada_Información_Ensayo()
        Input(1, vEncabezado)
        vInstrucciones = LineInput(1)
        Input(1, vEncabezado)
        Input(1, vFase)
        Input(1, vEncabezado)
        Input(1, vNúmerodeEnsayos)
        Input(1, vEncabezado)
        Input(1, vRetroalimentacion)
        Input(1, vEncabezado)
        Input(1, vCriterio)
        Input(1, vEncabezado)
        Input(1, vRegresa)
        Input(1, vEncabezado)
        Input(1, vCheckFinal)
        Instr_Audio = vFase 'De acuerdo a la fase, reproduce la instrucción correspondiente
    End Sub
    '-------------------PROCESO QUE TRAE DEL TXT CADA UNO DE LOS ENSAYOS ---------------------------------------------
    Sub Load_Random_Ensayos() 'Guarda los ensayos en un vector
        Dim i, r
        For i = 1 To vNúmerodeEnsayos
            Input(1, vEnsayos(i, 4))
            Input(1, vEnsayos(i, 0))
            Input(1, vEnsayos(i, 1))
            Input(1, vEnsayos(i, 2))
            Input(1, vEnsayos(i, 3))
        Next i
        Randomize()
        For i = 1 To vNúmerodeEnsayos
            r = Int(vNúmerodeEnsayos * Rnd() + 1)
            If vNumerosaleatoreos(r) < 1 Then
                vNumerosaleatoreos(r) = i
            Else
                i = i - 1
            End If
        Next i
    End Sub
    Sub Show_Rand_Estímulos() 'Controla la cantidad de ensayos que se están presentando
        vContador = vContador + 1
        vContadorAux += 1
        aContador = aContador + 1
    End Sub


    '----------------------------------- PROCESO QUE ALEATORIZA LOS ESTIMULOS PRESENTADOS EN CADA ENSAYO, VERIFICA SI EL PARTICIPANTE CUMPLIO O NO CON EL CRITERIO
    Sub Randomize_Posición_Estímulos()
        Try
            Dim pasofase = vCriterio <= vCorrecto
            If vContador > vNúmerodeEnsayos Then 'SI COMPLETÓ LA CANTIDAD DE ENSAYOS
                If pasofase Then 'SI CUMPLIÓ CON EL CRITERIO (PASÓ FASE)
                    bloque = 1
                    pasofase = True
                    If vCheckFinal = 1 Then
                        en = 2
                        Siguiente_Fase()
                        Exit Sub
                    End If
                    If vCheckFinal = 0 Then
                        en = 1
                        vMostrarMensaje = False
                        Siguiente_Fase()
                    End If

                Else 'NO CUMPLIÓ CON EL CRITERIO (NO PASÓ FASE)
                    bloque += 1
                    'cantidad_maxima_repeticionesxFase()  '<RUTINA INACTIVA>
                    Regresa_Fase()
                    Start_Over_Again()
                End If

            Else  'SI NO COMPLETÓ LA CANTIDAD DE ENSAYOS

                picIAM0.Enabled = True
                picIAM1.Enabled = True
                picIAM2.Enabled = True
                picIAM3.Enabled = True

                Randomize()
                r = Int(6 * Rnd() + 1)
                Dim RM As Resources.ResourceManager
                RM = New Resources.ResourceManager("Estudio_2017_2_Exp1.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                Select Case r
                    Case 1
                        picIAM0.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 0))
                        picIAM1.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 1))
                        picIAM2.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 2))
                        picIAM3.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 3))
                        vTrack = 1
                    Case 2
                        picIAM0.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 0))
                        picIAM1.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 1))
                        picIAM2.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 3))
                        picIAM3.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 2))
                        vTrack = 1
                    Case 3
                        picIAM0.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 0))
                        picIAM1.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 2))
                        picIAM2.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 1))
                        picIAM3.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 3))
                        vTrack = 2
                    Case 4
                        picIAM0.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 0))
                        picIAM1.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 2))
                        picIAM2.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 3))
                        picIAM3.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 1))
                        vTrack = 3
                    Case 5
                        picIAM0.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 0))
                        picIAM1.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 3))
                        picIAM2.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 2))
                        picIAM3.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 1))
                        vTrack = 3
                    Case 6
                        picIAM0.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 0))
                        picIAM1.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 3))
                        picIAM2.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 1))
                        picIAM3.Image = RM.GetObject(vEnsayos(vNumerosaleatoreos(vContador), 2))
                        vTrack = 2
                End Select
                vCaso = r
                Reg_Ensayos()
            End If
        Catch e As Exception
            Guardar_Archivos()
        End Try
    End Sub
    'CONTROLA LA CANTIDAD DE REPETICIONES MÁXIMAS PERMITIDAS PARA UNA FASE
    Sub cantidad_maxima_repeticionesxFase()
        If vRepeticiones = 3 Then 'Si la fase se repite hasta máximo 3 veces.
            Start_Over_Again()
            If bloque = 4 Then
                en = 2
                Siguiente_Fase()
                Exit Sub
            End If
        End If

        If vRepeticiones = -1 Then 'Si la fase se repite ilimitadamente hasta alcanzar el criterio
            Start_Over_Again()
        End If

        If vRepeticiones = 0 Then 'Si la fase no se repite
            en = 2
            Siguiente_Fase()
            Exit Sub
        End If
    End Sub

    '--------PROCESO QUE SE EJECUTA CUANDO LA VARIABLE REGRESA ES IGUAL A 1, SE DEVUELVE A LA FASE ANTERIOR
    Sub Regresa_Fase()
        If vRegresa = 1 Then
            tmrIntervaloEntreRespuestas.Enabled = False
            picIAM0.Visible = False
            Timer1.Stop()
            bloque = 1
            FileClose(1)

            numeroFase = vFase - 1
            If grupo = 1 Then
                Select Case numeroFase
                    Case 7
                        nombre_Repite_Fase = "Grupo_1_Fase_7" 'NOMBRE_REPITE_FASE ES EL NOMBRE DEL ARCHIVO TXT CORRESPONDIENTE A LA FASE A DONDE ES DEVUELTO EL PARTICIPANTE 
                        Me.Texto.Text = My.Resources.Grupo_1_Fase_7 'CARGA EL TXT AL PROYECTO PARA PODER SER LEIDO POR EL PROGRAMA
                End Select
            End If


            'ABRE EL ARCHIVO CORRESPONDIENTE A LA FASE A REPETIR
            If grupo = 1 Then
                My.Computer.FileSystem.DeleteDirectory(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\")
                Texto.SaveFile(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\" & nombre_Repite_Fase & ".txt", RichTextBoxStreamType.PlainText)
                Texto.SaveFile(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\" & nombre_Repite_Fase & ".txt", RichTextBoxStreamType.PlainText)
                FileOpen(1, Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\" & nombre_Repite_Fase & ".txt", OpenMode.Input)
                RepiteFase = True
        End If
            MsgBox("Vuelve a la fase Anterior", MsgBoxStyle.OkOnly, "Mensaje")
            If MsgBoxResult.Ok = 1 Then
                auxMsjRepoteFase = True
                Dim x As New Ejecucion_Experimento()
                x.Show()
                Me.Dispose()
            End If
            Start_Over_Again()
            Exit Sub
        End If
    End Sub
    'GUARDA LOS VALORES DE LAS VARIABLES ENSAYO POR ENSAYO EN EL EXCEL
    Sub Reg_Ensayos()
        Select Case r
            Case 1
                vtipoEnsayo = vEnsayos(vNumerosaleatoreos(vContador), 4)
                ensayoEs(0) = vEnsayos(vNumerosaleatoreos(vContador), 0)
                ensayoEs(1) = vEnsayos(vNumerosaleatoreos(vContador), 1)
                ensayoEs(2) = vEnsayos(vNumerosaleatoreos(vContador), 2)
                ensayoEs(3) = vEnsayos(vNumerosaleatoreos(vContador), 3)
            Case 2
                vtipoEnsayo = vEnsayos(vNumerosaleatoreos(vContador), 4)
                ensayoEs(0) = vEnsayos(vNumerosaleatoreos(vContador), 0)
                ensayoEs(1) = vEnsayos(vNumerosaleatoreos(vContador), 1)
                ensayoEs(2) = vEnsayos(vNumerosaleatoreos(vContador), 3)
                ensayoEs(3) = vEnsayos(vNumerosaleatoreos(vContador), 2)
            Case 3
                vtipoEnsayo = vEnsayos(vNumerosaleatoreos(vContador), 4)
                ensayoEs(0) = vEnsayos(vNumerosaleatoreos(vContador), 0)
                ensayoEs(1) = vEnsayos(vNumerosaleatoreos(vContador), 2)
                ensayoEs(2) = vEnsayos(vNumerosaleatoreos(vContador), 1)
                ensayoEs(3) = vEnsayos(vNumerosaleatoreos(vContador), 3)
            Case 4
                vtipoEnsayo = vEnsayos(vNumerosaleatoreos(vContador), 4)
                ensayoEs(0) = vEnsayos(vNumerosaleatoreos(vContador), 0)
                ensayoEs(1) = vEnsayos(vNumerosaleatoreos(vContador), 2)
                ensayoEs(2) = vEnsayos(vNumerosaleatoreos(vContador), 3)
                ensayoEs(3) = vEnsayos(vNumerosaleatoreos(vContador), 1)
            Case 5
                vtipoEnsayo = vEnsayos(vNumerosaleatoreos(vContador), 4)
                ensayoEs(0) = vEnsayos(vNumerosaleatoreos(vContador), 0)
                ensayoEs(1) = vEnsayos(vNumerosaleatoreos(vContador), 3)
                ensayoEs(2) = vEnsayos(vNumerosaleatoreos(vContador), 2)
                ensayoEs(3) = vEnsayos(vNumerosaleatoreos(vContador), 1)
            Case 6
                vtipoEnsayo = vEnsayos(vNumerosaleatoreos(vContador), 4)
                ensayoEs(0) = vEnsayos(vNumerosaleatoreos(vContador), 0)
                ensayoEs(1) = vEnsayos(vNumerosaleatoreos(vContador), 3)
                ensayoEs(2) = vEnsayos(vNumerosaleatoreos(vContador), 1)
                ensayoEs(3) = vEnsayos(vNumerosaleatoreos(vContador), 2)
        End Select
    End Sub


    '-----------------------------PROCESO QUE VERIFICA SI LA RESPUESTA DADA ES CORRECTA O INCORRECTA, DA PASO AL SIGUIENTE ENSAYO Y ESCRIBE EN EL TXT
    Private Sub picIAM0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picIAM0.Click, picIAM1.Click, picIAM2.Click, picIAM3.Click
        Try
            Dim clickenBotón As PictureBox
            clickenBotón = CType(sender, PictureBox)

            If clickenBotón.Name = picIAM0.Name() Then
                picIAM0.Visible = False
                tmrIntervaloEntreRespuestas.Enabled = False
                picIAM1.Visible = True
                picIAM2.Visible = True
                picIAM3.Visible = True

                picIAM1.Enabled = False
                picIAM2.Enabled = False
                picIAM3.Enabled = False
                tmpBloqueoClic.Start()
                vTiempo1 = VB.Timer

            ElseIf vCaso = 1 And clickenBotón.Name = picIAM1.Name Or
               vCaso = 2 And clickenBotón.Name = picIAM1.Name Or
               vCaso = 3 And clickenBotón.Name = picIAM2.Name Or
               vCaso = 4 And clickenBotón.Name = picIAM3.Name Or
               vCaso = 5 And clickenBotón.Name = picIAM3.Name Or
               vCaso = 6 And clickenBotón.Name = picIAM2.Name Then
                vRespuestaDada = vEnsayos(vNumerosaleatoreos(vContador), 1)
            ElseIf vCaso = 1 And clickenBotón.Name = picIAM2.Name Or
               vCaso = 2 And clickenBotón.Name = picIAM3.Name Or
               vCaso = 3 And clickenBotón.Name = picIAM1.Name Or
               vCaso = 4 And clickenBotón.Name = picIAM1.Name Or
               vCaso = 5 And clickenBotón.Name = picIAM2.Name Or
               vCaso = 6 And clickenBotón.Name = picIAM3.Name Then
                vRespuestaDada = vEnsayos(vNumerosaleatoreos(vContador), 2)
            ElseIf vCaso = 1 And clickenBotón.Name = picIAM3.Name Or
                vCaso = 2 And clickenBotón.Name = picIAM2.Name Or
                vCaso = 3 And clickenBotón.Name = picIAM3.Name Or
                vCaso = 4 And clickenBotón.Name = picIAM2.Name Or
                vCaso = 5 And clickenBotón.Name = picIAM1.Name Or
                vCaso = 6 And clickenBotón.Name = picIAM1.Name Then
                vRespuestaDada = vEnsayos(vNumerosaleatoreos(vContador), 3)
            End If
            If vContador < 10 Then
                Ensayo = "Ensayo 0"
            Else
                Ensayo = "Ensayo "
            End If
            If clickenBotón.Name = picIAM1.Name() And vTrack = 1 Or
                clickenBotón.Name = picIAM2.Name() And vTrack = 2 Or
                clickenBotón.Name = picIAM3.Name And vTrack = 3 Then
                vTiempodeReacción = VB.Timer - vTiempo1
                vCorrecto = vCorrecto + 1
                vRespuesta = "CORRECTO "
                acierto = 1
                If vRetroalimentacion = 1 Then
                    My.Computer.Audio.Play(My.Resources.tada, AudioPlayMode.Background)
                    Siguiente_Fase()
                End If

                If vRetroalimentacion = 0 Then
                    Siguiente_Fase()
                End If
                If vFase = 1 Then
                    PrintLine(2, codigo & ";" & vFase & ";" & bloque & ";" & vContadorAux & ";" & vEnsayos(vNumerosaleatoreos(vContador), 4) & ";" & vEnsayos(vNumerosaleatoreos(vContador), 0) & ";" & vEnsayos(vNumerosaleatoreos(vContador), 1) & ";" & vRespuestaDada & ";" & acierto & ";" & vTiempodeReacción)
                Else
                    PrintLine(2, codigo & ";" & vFase & ";" & bloque & ";" & vContador & ";" & vEnsayos(vNumerosaleatoreos(vContador), 4) & ";" & vEnsayos(vNumerosaleatoreos(vContador), 0) & ";" & vEnsayos(vNumerosaleatoreos(vContador), 1) & ";" & vRespuestaDada & ";" & acierto & ";" & vTiempodeReacción)
                End If
                Registrar_Informacion()
                picIAM0.Visible = False
                picIAM1.Visible = False
                picIAM2.Visible = False
                picIAM3.Visible = False
                tmrIntervaloEntreRespuestas.Enabled = True
                Show_Rand_Estímulos()
                Randomize_Posición_Estímulos()
            Else
                If clickenBotón.Name = picIAM2.Name() Or
                    clickenBotón.Name = picIAM1.Name() Or
                    clickenBotón.Name = picIAM3.Name Then
                    vTiempodeReacción = VB.Timer - vTiempo1
                    vRespuesta = "INCORRECTO "
                    acierto = 0
                    If vRetroalimentacion = 1 Then
                        My.Computer.Audio.Play(My.Resources.chord, AudioPlayMode.Background)
                        Siguiente_Fase()
                    End If
                    If vRetroalimentacion = 0 Then
                        Siguiente_Fase()
                    End If

                    If vFase = 1 Then
                        PrintLine(2, codigo & ";" & vFase & ";" & bloque & ";" & vContadorAux & ";" & vEnsayos(vNumerosaleatoreos(vContador), 4) & ";" & vEnsayos(vNumerosaleatoreos(vContador), 0) & ";" & vEnsayos(vNumerosaleatoreos(vContador), 1) & ";" & vRespuestaDada & ";" & acierto & ";" & vTiempodeReacción)
                    Else
                        PrintLine(2, codigo & ";" & vFase & ";" & bloque & ";" & vContador & ";" & vEnsayos(vNumerosaleatoreos(vContador), 4) & ";" & vEnsayos(vNumerosaleatoreos(vContador), 0) & ";" & vEnsayos(vNumerosaleatoreos(vContador), 1) & ";" & vRespuestaDada & ";" & acierto & ";" & vTiempodeReacción)
                    End If
                    Registrar_Informacion()
                    picIAM0.Visible = False
                    picIAM1.Visible = False
                    picIAM2.Visible = False
                    picIAM3.Visible = False
                    tmrIntervaloEntreRespuestas.Enabled = True
                    Show_Rand_Estímulos()
                    Randomize_Posición_Estímulos()
                End If
            End If
        Catch a As Exception
            Guardar_Archivos()
        End Try
    End Sub



    '--------------------------PROCESO QUE PERMITE REPETIR DE NUEVO LA FASE EN CASO DE QUE EL PARTICPANTE NO HAYA CUMPLIDO CON EL CRITERIO
    Sub Start_Over_Again()
        Dim i, r
        For i = 1 To vNúmerodeEnsayos
            vNumerosaleatoreos(i) = 0
        Next i
        vContador = 1
        vCorrecto = 0

        For i = 1 To vNúmerodeEnsayos '
            r = Int(vNúmerodeEnsayos * Rnd() + 1)
            If vNumerosaleatoreos(r) < 1 Then
                vNumerosaleatoreos(r) = i
            Else
                i = i - 1
            End If
        Next i
    End Sub


    '----------------------------------------PROCESO QUE VA GUARDANDO EN EL EXCEL, LOS RESULTADOS DEL PARTICIPANTE DURANTE CADA ENSAYO ----------------------------- 
    Sub Registrar_Informacion()
        If numero_Celda = 0 Then
            numero_Celda = 1
            oSheet.Range("A" & numero_Celda).Value = "Fase"
            oSheet.Range("B" & numero_Celda).Value = "Bloque"
            oSheet.Range("C" & numero_Celda).Value = "# de Ensayo"
            oSheet.Range("D" & numero_Celda).Value = "Tipo de Ensayo"
            oSheet.Range("E" & numero_Celda).Value = "Ensayo"
            oSheet.Range("F" & numero_Celda).Value = "Respuesta Dada"
            oSheet.Range("G" & numero_Celda).Value = "Acierto"
            oSheet.Range("H" & numero_Celda).Value = "Tiempo de Reacción"
            oSheet.Range("A" & numero_Celda & ":" & "B" & numero_Celda & ":" & "C" & numero_Celda & ":" & "D" & numero_Celda & ":" & "E" & numero_Celda & ":" & "F" & numero_Celda & ":" & "G" & numero_Celda & ":" & "H" & numero_Celda).Font.Bold = True
        End If
        numero_Celda += 1
        oSheet.Range("A" & (numero_Celda)).Value = vFase
        oSheet.Range("B" & (numero_Celda)).Value = bloque
        oSheet.Range("C" & numero_Celda).Value = vContador
        oSheet.Range("D" & (numero_Celda)).Value = vEnsayos(vNumerosaleatoreos(vContador), 4)
        oSheet.Range("E" & (numero_Celda)).Value = vEnsayos(vNumerosaleatoreos(vContador), 0) & ";" & vEnsayos(vNumerosaleatoreos(vContador), 1)
        oSheet.Range("F" & (numero_Celda)).Value = vRespuestaDada
        oSheet.Range("G" & (numero_Celda)).Value = acierto
        oSheet.Range("H" & (numero_Celda)).Value = vTiempodeReacción

    End Sub


    '------------------- PROCESO QUE SE EJECUTA LUEGO DE QUE EL PARTICIPANTE DÁ CLIC SOBRE ALGUNO DE LOS ESTÍMULOS -------------------------------------------
    Sub Siguiente_Fase()
        If en = 0 Then 'Valida información para presentar siguiente ensayo
            picIAM0.Visible = False
            tmrIntervaloEntreRespuestas.Enabled = False
            Timer1.Start()
            If segundo1 = 1 Then
                segundo1 = 0
                milisegundo1 = 0
                Timer1.Stop()
                tmrIntervaloEntreRespuestas.Enabled = True
            End If
        End If

        If en = 1 Then 'Valida la información para presentar instrucciones de la siguiente fase
            picIAM0.Visible = False
            tmrIntervaloEntreRespuestas.Enabled = False
            Timer1.Start()
            If milisegundo1 = 59 Then
                sigFase = vFase + 1
                vFase = sigFase
                segundo1 = 0
                milisegundo1 = 0
                Timer1.Stop()
                Dim x As New Mensaje_Siguiente_Fase()
                x.Show()
                Me.Dispose()
            End If
        End If

        If en = 2 Then 'Valida la información para la salida del programa en la última fase
            picIAM0.Visible = False
            vMostrarMensaje = True
            tmrIntervaloEntreRespuestas.Enabled = False
            Timer1.Start()
            If milisegundo1 = 59 Then
                segundo1 = 0
                milisegundo1 = 0
                Timer1.Stop()
                Guardar_Archivos()
                oExcel.Quit()
                Dim x As New Salida()
                x.Show()
                Me.Dispose()
                Exit Sub
            End If
        End If
    End Sub
    'CONTROL DE LOS INTERVALOS ENTRE ENSAYOS
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 10
        milisegundo1 += 1
        If milisegundo1 = 60 Then
            segundo1 += 1
            milisegundo1 = 0
        End If
        If segundo1 = 60 Then
            minuto1 += 1
            segundo1 = 0
        End If
        If minuto1 = 60 Then
            hora1 += 1
            minuto1 = 0
        End If
        Siguiente_Fase()
    End Sub
    Private Sub tmrIntervaloEntreRespuestas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrIntervaloEntreRespuestas.Tick
        picIAM0.Visible = True
    End Sub


    '-------------------  GUARDA LA INFORMACIÓN DEL PROCESO DEL PARTICIPANTE (CUANDO EL PARTICIPANTE CIERRA LA APLICACIÓN O CUANDO SE TERMINA EL EXPERIMENTO ) ---------------------------------------------
    Sub Guardar_Archivos()
        Try
            FileClose(1)
            FileClose(2)
            Select Case grupo
                Case 1
                    My.Computer.FileSystem.DeleteDirectory(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & "txt\", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    oBook.SaveAs(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 1\" & codigo & "\" & codigo & "Grupo1.xlsx")
                    oExcel.Quit()
                Case 2
                    My.Computer.FileSystem.DeleteDirectory(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 2\" & codigo & "\" & "txt\", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    oBook.SaveAs(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 2\" & codigo & "\" & codigo & "Grupo2.xlsx")
                    oExcel.Quit()
                Case 3
                    My.Computer.FileSystem.DeleteDirectory(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 3\" & codigo & "\" & "txt\", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    oBook.SaveAs(Archivo & "\" & nombre_Carpeta_Resultados & "\Grupo 3\" & codigo & "\" & codigo & "Grupo3.xlsx")
                    oExcel.Quit()
            End Select
        Catch e As Exception
            MsgBox("Ha ocurrido un error con la aplicación y deberá cerrarse. A continución, seleccione una ruta para guardar el archivo excel, dicho archivo contiene los datos del participante obtenidos durante el desarrollo de la aplicación.")
            oExcel.Quit()
            End
        End Try
    End Sub


    '--------------------------- PROCESO PARA INICIAR EL TIEMPO EN EL QUE LOS ESTÍMULOS INFERIORES DURAN INHABILITADOS ----------------------
    Private Sub tmpBloqueoClic_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmpBloqueoClic.Tick
        tmpBloqueoClic.Interval = 10
        milisegundo3 += 1
        If milisegundo3 = 60 Then
            segundo3 += 1
            milisegundo3 = 0
        End If
        habilitarClic()
    End Sub
    Sub habilitarClic() ' segundo3 = Hace referencia al tiempo que duran los estímulos inferiores inhabilitados, cuando el tiempo se cumpla, el participante podrá hacer clic sobre ellos
        If segundo3 = 0 Then '2
            tmpBloqueoClic.Stop()
            segundo3 = 0
            milisegundo3 = 0
            picIAM1.Enabled = True
            picIAM2.Enabled = True
            picIAM3.Enabled = True
        End If
    End Sub



End Class