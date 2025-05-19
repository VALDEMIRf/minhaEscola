<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeraMensalidade
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEncerrar = New System.Windows.Forms.Button()
        Me.btnGerarParcelas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNomeAlunos = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDataPrimeiraParcela = New System.Windows.Forms.DateTimePicker()
        Me.txtValorCadaParcela = New System.Windows.Forms.TextBox()
        Me.nupQuantidadeParcelas = New System.Windows.Forms.NumericUpDown()
        Me.txtValorTotalCurso = New System.Windows.Forms.TextBox()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.txtNomeCurso = New System.Windows.Forms.TextBox()
        Me.chkGerarNovasParcelas = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nupQuantidadeParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(382, 41)
        Me.Panel2.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(64, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(233, 23)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "GERA MENSALIDADE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MinhaEscola.My.Resources.Resources.cadastroalunos
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnEncerrar
        '
        Me.btnEncerrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEncerrar.FlatAppearance.BorderSize = 0
        Me.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncerrar.ForeColor = System.Drawing.Color.White
        Me.btnEncerrar.Image = Global.MinhaEscola.My.Resources.Resources.Remove_16x16
        Me.btnEncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEncerrar.Location = New System.Drawing.Point(237, 368)
        Me.btnEncerrar.Name = "btnEncerrar"
        Me.btnEncerrar.Size = New System.Drawing.Size(105, 32)
        Me.btnEncerrar.TabIndex = 14
        Me.btnEncerrar.Text = "Encerrar"
        Me.btnEncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEncerrar.UseVisualStyleBackColor = False
        '
        'btnGerarParcelas
        '
        Me.btnGerarParcelas.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnGerarParcelas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGerarParcelas.FlatAppearance.BorderSize = 0
        Me.btnGerarParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGerarParcelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGerarParcelas.ForeColor = System.Drawing.Color.White
        Me.btnGerarParcelas.Image = Global.MinhaEscola.My.Resources.Resources.dados
        Me.btnGerarParcelas.Location = New System.Drawing.Point(6, 368)
        Me.btnGerarParcelas.Name = "btnGerarParcelas"
        Me.btnGerarParcelas.Size = New System.Drawing.Size(141, 32)
        Me.btnGerarParcelas.TabIndex = 40
        Me.btnGerarParcelas.Text = "Gerar Parcelas"
        Me.btnGerarParcelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGerarParcelas.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Nome Aluno.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Periodicidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Valor Total Curso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Descrição do Curso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Quantidade de Parcelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Data da primeira parcela"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(207, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Valor cada Parcela"
        '
        'txtNomeAlunos
        '
        Me.txtNomeAlunos.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNomeAlunos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeAlunos.ForeColor = System.Drawing.Color.White
        Me.txtNomeAlunos.Location = New System.Drawing.Point(101, 12)
        Me.txtNomeAlunos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeAlunos.Name = "txtNomeAlunos"
        Me.txtNomeAlunos.Size = New System.Drawing.Size(255, 20)
        Me.txtNomeAlunos.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNomeAlunos)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 40)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpDataPrimeiraParcela)
        Me.GroupBox2.Controls.Add(Me.txtValorCadaParcela)
        Me.GroupBox2.Controls.Add(Me.nupQuantidadeParcelas)
        Me.GroupBox2.Controls.Add(Me.txtValorTotalCurso)
        Me.GroupBox2.Controls.Add(Me.cboPeriodo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtNomeCurso)
        Me.GroupBox2.Controls.Add(Me.chkGerarNovasParcelas)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 269)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parcelas"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(194, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 56)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Haverá casos em que pode ocorrer diferenças de R$ 0,01 centavos."
        '
        'dtpDataPrimeiraParcela
        '
        Me.dtpDataPrimeiraParcela.CalendarFont = New System.Drawing.Font("Verdana", 8.25!)
        Me.dtpDataPrimeiraParcela.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dtpDataPrimeiraParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataPrimeiraParcela.Location = New System.Drawing.Point(25, 225)
        Me.dtpDataPrimeiraParcela.Name = "dtpDataPrimeiraParcela"
        Me.dtpDataPrimeiraParcela.Size = New System.Drawing.Size(150, 21)
        Me.dtpDataPrimeiraParcela.TabIndex = 55
        '
        'txtValorCadaParcela
        '
        Me.txtValorCadaParcela.Location = New System.Drawing.Point(197, 176)
        Me.txtValorCadaParcela.Name = "txtValorCadaParcela"
        Me.txtValorCadaParcela.Size = New System.Drawing.Size(140, 22)
        Me.txtValorCadaParcela.TabIndex = 54
        '
        'nupQuantidadeParcelas
        '
        Me.nupQuantidadeParcelas.Location = New System.Drawing.Point(25, 177)
        Me.nupQuantidadeParcelas.Name = "nupQuantidadeParcelas"
        Me.nupQuantidadeParcelas.Size = New System.Drawing.Size(120, 22)
        Me.nupQuantidadeParcelas.TabIndex = 53
        Me.nupQuantidadeParcelas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtValorTotalCurso
        '
        Me.txtValorTotalCurso.Location = New System.Drawing.Point(198, 121)
        Me.txtValorTotalCurso.Name = "txtValorTotalCurso"
        Me.txtValorTotalCurso.Size = New System.Drawing.Size(140, 22)
        Me.txtValorTotalCurso.TabIndex = 52
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Items.AddRange(New Object() {"semanal", "quinenal", "mensal", "bimestral", "semestral", "anual"})
        Me.cboPeriodo.Location = New System.Drawing.Point(25, 120)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(153, 24)
        Me.cboPeriodo.TabIndex = 51
        '
        'txtNomeCurso
        '
        Me.txtNomeCurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNomeCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCurso.ForeColor = System.Drawing.Color.White
        Me.txtNomeCurso.Location = New System.Drawing.Point(25, 73)
        Me.txtNomeCurso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeCurso.Name = "txtNomeCurso"
        Me.txtNomeCurso.Size = New System.Drawing.Size(330, 20)
        Me.txtNomeCurso.TabIndex = 50
        '
        'chkGerarNovasParcelas
        '
        Me.chkGerarNovasParcelas.AutoSize = True
        Me.chkGerarNovasParcelas.Location = New System.Drawing.Point(25, 24)
        Me.chkGerarNovasParcelas.Name = "chkGerarNovasParcelas"
        Me.chkGerarNovasParcelas.Size = New System.Drawing.Size(183, 20)
        Me.chkGerarNovasParcelas.TabIndex = 45
        Me.chkGerarNovasParcelas.Text = "Re-Gerar Novas Parcelas"
        Me.chkGerarNovasParcelas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkGerarNovasParcelas.UseVisualStyleBackColor = True
        '
        'frmGeraMensalidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(382, 408)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGerarParcelas)
        Me.Controls.Add(Me.btnEncerrar)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGeraMensalidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGeraMensalidade"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nupQuantidadeParcelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEncerrar As Button
    Friend WithEvents btnGerarParcelas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNomeAlunos As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNomeCurso As TextBox
    Friend WithEvents chkGerarNovasParcelas As CheckBox
    Friend WithEvents dtpDataPrimeiraParcela As DateTimePicker
    Friend WithEvents txtValorCadaParcela As TextBox
    Friend WithEvents nupQuantidadeParcelas As NumericUpDown
    Friend WithEvents txtValorTotalCurso As TextBox
    Friend WithEvents cboPeriodo As ComboBox
    Friend WithEvents Label8 As Label
End Class
