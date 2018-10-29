<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salida))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Location = New System.Drawing.Point(9, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 36)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Ver fase"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Estudio_2017_2_Exp1.My.Resources.Resources.konrad
        Me.PictureBox1.Location = New System.Drawing.Point(668, 515)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'mensaje
        '
        Me.mensaje.Font = New System.Drawing.Font("Lucida Fax", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensaje.ForeColor = System.Drawing.Color.Black
        Me.mensaje.Location = New System.Drawing.Point(52, 55)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(676, 248)
        Me.mensaje.TabIndex = 39
        Me.mensaje.Text = "Haz finalizado este experimento, gracias por tu participación."
        Me.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFinalizar.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnFinalizar.Location = New System.Drawing.Point(267, 329)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(198, 46)
        Me.btnFinalizar.TabIndex = 38
        Me.btnFinalizar.Text = "FINALIZAR"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        Me.btnFinalizar.Visible = False
        '
        'Salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 558)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.btnFinalizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Salida"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mensaje As System.Windows.Forms.Label
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button

End Class
