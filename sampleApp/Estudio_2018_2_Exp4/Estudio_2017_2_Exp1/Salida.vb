Public Class Salida

    Dim cerrar As MsgBoxResult
    Dim segundo, milisegundo As Integer

    Private Sub Salida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AjustarControles()
        mensaje.Text = "Haz finalizado este experimento, gracias por tu participación."

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
            End
        End If
    End Sub

    Private Sub butFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        End
    End Sub
End Class
