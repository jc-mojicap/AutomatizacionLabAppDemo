Public Class Datos_Experimento
    Private Sub Inicio1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AjustarControles()
    End Sub

    Sub AjustarControles() 'Ajuste de elementos del formulario a la pantalla
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
                If TypeOf tControl Is PictureBox Or TypeOf tControl Is Panel Or TypeOf tControl Is Button Or TypeOf tControl Is Label Or TypeOf tControl Is ComboBox Or TypeOf tControl Is TextBox Or TypeOf tControl Is GroupBox Then
                    tControl.Top = tControl.Top + ((PorcentajeH * tControl.Top) / 100)
                    tControl.Left = tControl.Left + ((PorcentajeW * tControl.Left) / 100)
                    tControl.Width = tControl.Width + ((PorcentajeW * tControl.Width) / 100)
                    tControl.Height = tControl.Height + ((PorcentajeH * tControl.Height) / 100)
                    TamañoFuente = tControl.Font.Size + ((PorcentajeW * tControl.Font.Size) / 100)
                    tControl.Font = New Font("Lucida Fax", TamañoFuente)
                End If

                If TypeOf tControl Is GroupBox Then
                    If TypeOf tControl Is RadioButton Then
                        tControl.Font = New Font("Lucida Fax", TamañoFuente * (tControl.Font.Size) / 100)
                    End If
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
    End Sub 'Rutina para cerrar el programa en este formulario.


    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click 'Pasa la información escrita en el formulario a variables

        grupo = cbGrupo.SelectedItem 'Asigna a la variable grupo el valor puesto por el participante en el cbGrupo
        experimento = txtExperimento.Text 'Asigna a la variable experimento el valor dado en el txtExperimento
        sujeto = txtsujeto.Text 'Asigna a la variable sujeto el valor dado en el txtsujeto

        Select Case cbGrupo.SelectedIndex
            Case 0
                grupo = "1" 'Al caso 0 de cbGrupo se le asigna el valor de 1
            Case 1
                grupo = "2"
            Case 2
                grupo = "3"
        End Select

        If grupo = "" Or experimento = "" Or sujeto = "" Then 'En caso de que no se llenen todos los datos en el formulario
            MessageBox.Show("Existen campos vacíos, verifique los campos e inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim siguiente As New Datos_Participante 'Controla el paso al formulario de Datos del Participante
            siguiente.Show()
            Me.Dispose()
        End If
    End Sub


    Private Sub cbGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGrupo.SelectedIndexChanged

    End Sub
End Class
