Public Class Mensaje_Siguiente_Fase
    Dim cerrar As MsgBoxResult

    Private Sub Mensaje_SigFase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AjustarControles()
        Mensaje.Font = New Font("Lucida FAx", 38, System.Drawing.FontStyle.Bold)
        Mensaje.Text = "¡BIEN HECHO! " & vbNewLine & vbNewLine & " PASASTE A LA FASE " & sigFase
    End Sub

    Sub AjustarControles() 'Rutina para permitir que los controles se ajusten a la resolucion de pantalla
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

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cerrar = CType(MessageBox.Show("Desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If cerrar = MsgBoxResult.No Then
            e.Cancel = True
        End If

        If cerrar = MsgBoxResult.Yes Then
            Guardar_Archivos()
            oExcel.Quit()
            End
        End If
    End Sub

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vMostrarMensaje = False
        Dim x As New Ejecucion_Experimento()
        x.Show()
        Me.Dispose()
    End Sub


End Class
