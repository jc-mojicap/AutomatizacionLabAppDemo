<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejecucion_Experimento
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ejecucion_Experimento))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbIntruccionesAudio = New System.Windows.Forms.Label()
        Me.btnReproducir_Instr = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Texto = New System.Windows.Forms.RichTextBox()
        Me.picIAM3 = New System.Windows.Forms.PictureBox()
        Me.picIAM2 = New System.Windows.Forms.PictureBox()
        Me.picIAM1 = New System.Windows.Forms.PictureBox()
        Me.picIAM0 = New System.Windows.Forms.PictureBox()
        Me.lbInstruccion = New System.Windows.Forms.Label()
        Me.tmrIntervaloEntreRespuestas = New System.Windows.Forms.Timer(Me.components)
        Me.tmpBloqueoClic = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIAM3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIAM2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIAM1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIAM0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Estudio_2017_2_Exp1.My.Resources.Resources.konrad
        Me.PictureBox1.Location = New System.Drawing.Point(663, 514)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 264
        Me.PictureBox1.TabStop = False
        '
        'lbIntruccionesAudio
        '
        Me.lbIntruccionesAudio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbIntruccionesAudio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbIntruccionesAudio.Font = New System.Drawing.Font("Lucida Fax", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIntruccionesAudio.ForeColor = System.Drawing.Color.Black
        Me.lbIntruccionesAudio.Location = New System.Drawing.Point(49, 18)
        Me.lbIntruccionesAudio.Name = "lbIntruccionesAudio"
        Me.lbIntruccionesAudio.Size = New System.Drawing.Size(694, 180)
        Me.lbIntruccionesAudio.TabIndex = 263
        Me.lbIntruccionesAudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbIntruccionesAudio.Visible = False
        '
        'btnReproducir_Instr
        '
        Me.btnReproducir_Instr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReproducir_Instr.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReproducir_Instr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnReproducir_Instr.Location = New System.Drawing.Point(257, 239)
        Me.btnReproducir_Instr.Name = "btnReproducir_Instr"
        Me.btnReproducir_Instr.Size = New System.Drawing.Size(255, 78)
        Me.btnReproducir_Instr.TabIndex = 262
        Me.btnReproducir_Instr.Text = "REPRODUCIR INSTRUCCIONES"
        Me.btnReproducir_Instr.UseVisualStyleBackColor = False
        Me.btnReproducir_Instr.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAceptar.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAceptar.Location = New System.Drawing.Point(291, 468)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(183, 40)
        Me.btnAceptar.TabIndex = 261
        Me.btnAceptar.Text = "SIGUIENTE"
        Me.btnAceptar.UseVisualStyleBackColor = False
        Me.btnAceptar.Visible = False
        '
        'Texto
        '
        Me.Texto.Location = New System.Drawing.Point(6, 4)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(174, 54)
        Me.Texto.TabIndex = 259
        Me.Texto.Text = ""
        Me.Texto.Visible = False
        '
        'picIAM3
        '
        Me.picIAM3.BackColor = System.Drawing.Color.White
        Me.picIAM3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picIAM3.Location = New System.Drawing.Point(564, 256)
        Me.picIAM3.Name = "picIAM3"
        Me.picIAM3.Size = New System.Drawing.Size(140, 140)
        Me.picIAM3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIAM3.TabIndex = 258
        Me.picIAM3.TabStop = False
        Me.picIAM3.Visible = False
        '
        'picIAM2
        '
        Me.picIAM2.BackColor = System.Drawing.Color.White
        Me.picIAM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picIAM2.Location = New System.Drawing.Point(304, 256)
        Me.picIAM2.Name = "picIAM2"
        Me.picIAM2.Size = New System.Drawing.Size(140, 140)
        Me.picIAM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIAM2.TabIndex = 257
        Me.picIAM2.TabStop = False
        Me.picIAM2.Visible = False
        '
        'picIAM1
        '
        Me.picIAM1.BackColor = System.Drawing.Color.White
        Me.picIAM1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picIAM1.Location = New System.Drawing.Point(60, 256)
        Me.picIAM1.Name = "picIAM1"
        Me.picIAM1.Size = New System.Drawing.Size(140, 140)
        Me.picIAM1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIAM1.TabIndex = 256
        Me.picIAM1.TabStop = False
        Me.picIAM1.Visible = False
        '
        'picIAM0
        '
        Me.picIAM0.BackColor = System.Drawing.Color.White
        Me.picIAM0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picIAM0.Location = New System.Drawing.Point(304, 18)
        Me.picIAM0.Name = "picIAM0"
        Me.picIAM0.Size = New System.Drawing.Size(140, 140)
        Me.picIAM0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIAM0.TabIndex = 255
        Me.picIAM0.TabStop = False
        '
        'lbInstruccion
        '
        Me.lbInstruccion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbInstruccion.Font = New System.Drawing.Font("Lucida Fax", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInstruccion.ForeColor = System.Drawing.Color.Black
        Me.lbInstruccion.Location = New System.Drawing.Point(43, 5)
        Me.lbInstruccion.Name = "lbInstruccion"
        Me.lbInstruccion.Size = New System.Drawing.Size(702, 330)
        Me.lbInstruccion.TabIndex = 260
        Me.lbInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbInstruccion.Visible = False
        '
        'tmrIntervaloEntreRespuestas
        '
        '
        'tmpBloqueoClic
        '
        '
        'Timer1
        '
        '
        'Ejecucion_Experimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(780, 558)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbIntruccionesAudio)
        Me.Controls.Add(Me.btnReproducir_Instr)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Texto)
        Me.Controls.Add(Me.picIAM3)
        Me.Controls.Add(Me.picIAM2)
        Me.Controls.Add(Me.picIAM1)
        Me.Controls.Add(Me.picIAM0)
        Me.Controls.Add(Me.lbInstruccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ejecucion_Experimento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIAM3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIAM2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIAM1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIAM0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbIntruccionesAudio As System.Windows.Forms.Label
    Friend WithEvents btnReproducir_Instr As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Texto As System.Windows.Forms.RichTextBox
    Friend WithEvents picIAM3 As System.Windows.Forms.PictureBox
    Friend WithEvents picIAM2 As System.Windows.Forms.PictureBox
    Friend WithEvents picIAM1 As System.Windows.Forms.PictureBox
    Friend WithEvents picIAM0 As System.Windows.Forms.PictureBox
    Friend WithEvents lbInstruccion As System.Windows.Forms.Label
    Friend WithEvents tmrIntervaloEntreRespuestas As System.Windows.Forms.Timer
    Friend WithEvents tmpBloqueoClic As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
