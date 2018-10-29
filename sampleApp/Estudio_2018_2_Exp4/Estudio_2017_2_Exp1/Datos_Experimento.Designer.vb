<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datos_Experimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Datos_Experimento))
        Me.txtExperimento = New System.Windows.Forms.TextBox()
        Me.cbGrupo = New System.Windows.Forms.ComboBox()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbGrupo = New System.Windows.Forms.Label()
        Me.lbsujeto = New System.Windows.Forms.Label()
        Me.txtsujeto = New System.Windows.Forms.TextBox()
        Me.lbExperimento = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtExperimento
        '
        Me.txtExperimento.BackColor = System.Drawing.Color.White
        Me.txtExperimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExperimento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtExperimento.Location = New System.Drawing.Point(340, 196)
        Me.txtExperimento.Name = "txtExperimento"
        Me.txtExperimento.Size = New System.Drawing.Size(170, 29)
        Me.txtExperimento.TabIndex = 268
        '
        'cbGrupo
        '
        Me.cbGrupo.BackColor = System.Drawing.Color.White
        Me.cbGrupo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbGrupo.FormattingEnabled = True
        Me.cbGrupo.Items.AddRange(New Object() {"Grupo 1"})
        Me.cbGrupo.Location = New System.Drawing.Point(340, 298)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(170, 32)
        Me.cbGrupo.TabIndex = 267
        '
        'btnComenzar
        '
        Me.btnComenzar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnComenzar.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnComenzar.Location = New System.Drawing.Point(271, 444)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(211, 47)
        Me.btnComenzar.TabIndex = 266
        Me.btnComenzar.Text = "SIGUIENTE"
        Me.btnComenzar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(182, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(393, 32)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = "DATOS DEL EXPERIMENTO"
        '
        'lbGrupo
        '
        Me.lbGrupo.AutoSize = True
        Me.lbGrupo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbGrupo.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGrupo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbGrupo.Location = New System.Drawing.Point(219, 306)
        Me.lbGrupo.Name = "lbGrupo"
        Me.lbGrupo.Size = New System.Drawing.Size(87, 24)
        Me.lbGrupo.TabIndex = 263
        Me.lbGrupo.Text = "GRUPO"
        '
        'lbsujeto
        '
        Me.lbsujeto.AutoSize = True
        Me.lbsujeto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbsujeto.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsujeto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbsujeto.Location = New System.Drawing.Point(219, 253)
        Me.lbsujeto.Name = "lbsujeto"
        Me.lbsujeto.Size = New System.Drawing.Size(93, 24)
        Me.lbsujeto.TabIndex = 262
        Me.lbsujeto.Text = "SUJETO"
        '
        'txtsujeto
        '
        Me.txtsujeto.BackColor = System.Drawing.Color.White
        Me.txtsujeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsujeto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtsujeto.Location = New System.Drawing.Point(340, 250)
        Me.txtsujeto.Name = "txtsujeto"
        Me.txtsujeto.Size = New System.Drawing.Size(287, 29)
        Me.txtsujeto.TabIndex = 261
        '
        'lbExperimento
        '
        Me.lbExperimento.AutoSize = True
        Me.lbExperimento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbExperimento.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbExperimento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbExperimento.Location = New System.Drawing.Point(146, 196)
        Me.lbExperimento.Name = "lbExperimento"
        Me.lbExperimento.Size = New System.Drawing.Size(166, 24)
        Me.lbExperimento.TabIndex = 260
        Me.lbExperimento.Text = "EXPERIMENTO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(65, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(650, 234)
        Me.PictureBox1.TabIndex = 265
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Estudio_2017_2_Exp1.My.Resources.Resources.konrad
        Me.PictureBox2.Location = New System.Drawing.Point(669, 517)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(111, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 269
        Me.PictureBox2.TabStop = False
        '
        'Datos_Experimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 558)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtExperimento)
        Me.Controls.Add(Me.cbGrupo)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbGrupo)
        Me.Controls.Add(Me.lbsujeto)
        Me.Controls.Add(Me.txtsujeto)
        Me.Controls.Add(Me.lbExperimento)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Datos_Experimento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtExperimento As System.Windows.Forms.TextBox
    Friend WithEvents cbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents btnComenzar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbGrupo As System.Windows.Forms.Label
    Friend WithEvents lbsujeto As System.Windows.Forms.Label
    Friend WithEvents txtsujeto As System.Windows.Forms.TextBox
    Friend WithEvents lbExperimento As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
