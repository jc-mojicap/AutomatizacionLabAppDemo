<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datos_Participante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Datos_Participante))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbCarrera = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbSemestre = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbEdad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Texto = New System.Windows.Forms.RichTextBox()
        Me.btnIncorrecto = New System.Windows.Forms.Button()
        Me.btnCorrecto = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbInstrucciones = New System.Windows.Forms.Label()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(756, 509)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 380
        Me.PictureBox1.TabStop = False
        '
        'cbCarrera
        '
        Me.cbCarrera.AutoCompleteCustomSource.AddRange(New String() {"Psicología", "Negocios Internacionales", "Mercadeo", "Ingeniería de sistemas", "Ingeniería Industrial"})
        Me.cbCarrera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCarrera.ForeColor = System.Drawing.Color.Black
        Me.cbCarrera.FormattingEnabled = True
        Me.cbCarrera.Items.AddRange(New Object() {"Psicología", "Negocios Internacionales", "Mercadeo", "Ingeniería de sistemas", "Ingeniería Industrial"})
        Me.cbCarrera.Location = New System.Drawing.Point(255, 307)
        Me.cbCarrera.Name = "cbCarrera"
        Me.cbCarrera.Size = New System.Drawing.Size(268, 32)
        Me.cbCarrera.TabIndex = 379
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(125, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 22)
        Me.Label6.TabIndex = 378
        Me.Label6.Text = "CARRERA"
        '
        'cbSemestre
        '
        Me.cbSemestre.AutoCompleteCustomSource.AddRange(New String() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto", "Séptimo", "Octavo", "Noveno", "Décimo"})
        Me.cbSemestre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSemestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSemestre.ForeColor = System.Drawing.Color.Black
        Me.cbSemestre.FormattingEnabled = True
        Me.cbSemestre.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto", "Séptimo", "Octavo", "Noveno", "Décimo"})
        Me.cbSemestre.Location = New System.Drawing.Point(255, 356)
        Me.cbSemestre.Name = "cbSemestre"
        Me.cbSemestre.Size = New System.Drawing.Size(137, 28)
        Me.cbSemestre.TabIndex = 377
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(118, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 22)
        Me.Label5.TabIndex = 376
        Me.Label5.Text = "SEMESTRE"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbCodigo.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbCodigo.Location = New System.Drawing.Point(138, 184)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(93, 22)
        Me.lbCodigo.TabIndex = 375
        Me.lbCodigo.Text = "CÓDIGO"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(255, 180)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(137, 29)
        Me.txtCodigo.TabIndex = 374
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(161, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(470, 38)
        Me.Label2.TabIndex = 373
        Me.Label2.Text = "DATOS DEL PARTICIPANTE"
        '
        'cbGenero
        '
        Me.cbGenero.AutoCompleteCustomSource.AddRange(New String() {"Femenino", "Masculino"})
        Me.cbGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGenero.ForeColor = System.Drawing.Color.Black
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cbGenero.Location = New System.Drawing.Point(255, 262)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(137, 32)
        Me.cbGenero.TabIndex = 372
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(138, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 22)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "GÉNERO"
        '
        'cbEdad
        '
        Me.cbEdad.AutoCompleteCustomSource.AddRange(New String() {"5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50"})
        Me.cbEdad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEdad.ForeColor = System.Drawing.Color.Black
        Me.cbEdad.FormattingEnabled = True
        Me.cbEdad.Items.AddRange(New Object() {"5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50"})
        Me.cbEdad.Location = New System.Drawing.Point(255, 221)
        Me.cbEdad.Name = "cbEdad"
        Me.cbEdad.Size = New System.Drawing.Size(53, 32)
        Me.cbEdad.TabIndex = 370
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(129, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 22)
        Me.Label4.TabIndex = 369
        Me.Label4.Text = "NOMBRE "
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(255, 139)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(393, 29)
        Me.txtNombre.TabIndex = 368
        '
        'Texto
        '
        Me.Texto.Location = New System.Drawing.Point(20, -44)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(174, 54)
        Me.Texto.TabIndex = 367
        Me.Texto.Text = ""
        Me.Texto.Visible = False
        '
        'btnIncorrecto
        '
        Me.btnIncorrecto.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIncorrecto.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnIncorrecto.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncorrecto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnIncorrecto.Location = New System.Drawing.Point(576, 418)
        Me.btnIncorrecto.Name = "btnIncorrecto"
        Me.btnIncorrecto.Size = New System.Drawing.Size(220, 57)
        Me.btnIncorrecto.TabIndex = 366
        Me.btnIncorrecto.Text = "INCORRECTO"
        Me.btnIncorrecto.UseVisualStyleBackColor = False
        Me.btnIncorrecto.Visible = False
        '
        'btnCorrecto
        '
        Me.btnCorrecto.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCorrecto.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCorrecto.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorrecto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCorrecto.Location = New System.Drawing.Point(9, 436)
        Me.btnCorrecto.Name = "btnCorrecto"
        Me.btnCorrecto.Size = New System.Drawing.Size(185, 57)
        Me.btnCorrecto.TabIndex = 365
        Me.btnCorrecto.Text = "CORRECTO"
        Me.btnCorrecto.UseVisualStyleBackColor = False
        Me.btnCorrecto.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(165, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 360
        Me.Label3.Text = "EDAD"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(95, 78)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(617, 317)
        Me.PictureBox2.TabIndex = 362
        Me.PictureBox2.TabStop = False
        '
        'lbInstrucciones
        '
        Me.lbInstrucciones.BackColor = System.Drawing.Color.White
        Me.lbInstrucciones.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInstrucciones.Location = New System.Drawing.Point(73, 94)
        Me.lbInstrucciones.Name = "lbInstrucciones"
        Me.lbInstrucciones.Size = New System.Drawing.Size(691, 239)
        Me.lbInstrucciones.TabIndex = 364
        Me.lbInstrucciones.Text = resources.GetString("lbInstrucciones.Text")
        Me.lbInstrucciones.Visible = False
        '
        'btnComenzar
        '
        Me.btnComenzar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnComenzar.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnComenzar.Location = New System.Drawing.Point(318, 412)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(192, 63)
        Me.btnComenzar.TabIndex = 363
        Me.btnComenzar.Text = "COMENZAR"
        Me.btnComenzar.UseVisualStyleBackColor = False
        Me.btnComenzar.Visible = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSiguiente.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSiguiente.Location = New System.Drawing.Point(299, 456)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(192, 63)
        Me.btnSiguiente.TabIndex = 361
        Me.btnSiguiente.Text = "SIGUIENTE"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'Datos_Participante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(879, 585)
        Me.Controls.Add(Me.btnCorrecto)
        Me.Controls.Add(Me.lbInstrucciones)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbCarrera)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbSemestre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbEdad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Texto)
        Me.Controls.Add(Me.btnIncorrecto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Datos_Participante"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbGenero As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbEdad As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Texto As System.Windows.Forms.RichTextBox
    Friend WithEvents btnIncorrecto As System.Windows.Forms.Button
    Friend WithEvents btnCorrecto As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbInstrucciones As System.Windows.Forms.Label
    Friend WithEvents btnComenzar As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button

End Class
