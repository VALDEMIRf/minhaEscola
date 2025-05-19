<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagamentoMensalidade
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
        Me.txtCodigoMensalidade = New System.Windows.Forms.TextBox()
        Me.txtNomeAluno = New System.Windows.Forms.TextBox()
        Me.txtNomeCurso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpPagamentoParcela = New System.Windows.Forms.DateTimePicker()
        Me.dtpVencimentoParcela = New System.Windows.Forms.DateTimePicker()
        Me.txtValorParcela = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.txtJuros = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnEmDia = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnEncerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 58)
        Me.Panel2.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(77, 9)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(296, 32)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "EXCLUIR PARCELA"
        '
        'txtCodigoMensalidade
        '
        Me.txtCodigoMensalidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtCodigoMensalidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoMensalidade.ForeColor = System.Drawing.Color.White
        Me.txtCodigoMensalidade.Location = New System.Drawing.Point(109, 66)
        Me.txtCodigoMensalidade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoMensalidade.Name = "txtCodigoMensalidade"
        Me.txtCodigoMensalidade.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoMensalidade.TabIndex = 67
        '
        'txtNomeAluno
        '
        Me.txtNomeAluno.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNomeAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeAluno.ForeColor = System.Drawing.Color.White
        Me.txtNomeAluno.Location = New System.Drawing.Point(109, 88)
        Me.txtNomeAluno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeAluno.Name = "txtNomeAluno"
        Me.txtNomeAluno.Size = New System.Drawing.Size(295, 20)
        Me.txtNomeAluno.TabIndex = 66
        '
        'txtNomeCurso
        '
        Me.txtNomeCurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNomeCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCurso.ForeColor = System.Drawing.Color.White
        Me.txtNomeCurso.Location = New System.Drawing.Point(110, 113)
        Me.txtNomeCurso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeCurso.Name = "txtNomeCurso"
        Me.txtNomeCurso.Size = New System.Drawing.Size(293, 20)
        Me.txtNomeCurso.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Nome Curso.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Nome Aluno.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Código.:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEmDia)
        Me.GroupBox1.Controls.Add(Me.txtObservacao)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpPagamentoParcela)
        Me.GroupBox1.Controls.Add(Me.dtpVencimentoParcela)
        Me.GroupBox1.Controls.Add(Me.txtValorParcela)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 186)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pagamento"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(103, 109)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(292, 66)
        Me.txtObservacao.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Observação.:"
        '
        'dtpPagamentoParcela
        '
        Me.dtpPagamentoParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpPagamentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPagamentoParcela.Location = New System.Drawing.Point(138, 78)
        Me.dtpPagamentoParcela.Name = "dtpPagamentoParcela"
        Me.dtpPagamentoParcela.Size = New System.Drawing.Size(120, 23)
        Me.dtpPagamentoParcela.TabIndex = 25
        '
        'dtpVencimentoParcela
        '
        Me.dtpVencimentoParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimentoParcela.Location = New System.Drawing.Point(138, 53)
        Me.dtpVencimentoParcela.Name = "dtpVencimentoParcela"
        Me.dtpVencimentoParcela.Size = New System.Drawing.Size(120, 23)
        Me.dtpVencimentoParcela.TabIndex = 24
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtValorParcela.ForeColor = System.Drawing.Color.Green
        Me.txtValorParcela.Location = New System.Drawing.Point(138, 25)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(120, 23)
        Me.txtValorParcela.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(48, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Pagamento.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(46, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Vencimento.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(3, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Valor Mensalidade.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(5, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Desconto.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(186, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Juros.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(290, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 17)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "% ao dia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(5, 410)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 17)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Valor a ser pago.:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(139, 335)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 17)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "%"
        '
        'txtValorPago
        '
        Me.txtValorPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPago.ForeColor = System.Drawing.Color.Green
        Me.txtValorPago.Location = New System.Drawing.Point(128, 408)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtValorPago.Size = New System.Drawing.Size(100, 23)
        Me.txtValorPago.TabIndex = 76
        Me.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesconto
        '
        Me.txtDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.ForeColor = System.Drawing.Color.Blue
        Me.txtDesconto.Location = New System.Drawing.Point(92, 333)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDesconto.Size = New System.Drawing.Size(44, 23)
        Me.txtDesconto.TabIndex = 78
        Me.txtDesconto.Text = "5"
        '
        'txtJuros
        '
        Me.txtJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuros.ForeColor = System.Drawing.Color.Red
        Me.txtJuros.Location = New System.Drawing.Point(241, 333)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtJuros.Size = New System.Drawing.Size(46, 23)
        Me.txtJuros.TabIndex = 79
        Me.txtJuros.Text = "0,1"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.FlatAppearance.BorderSize = 0
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.White
        Me.btnCalcular.Image = Global.MinhaEscola.My.Resources.Resources.Check_16x16
        Me.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalcular.Location = New System.Drawing.Point(234, 410)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(135, 23)
        Me.btnCalcular.TabIndex = 80
        Me.btnCalcular.Text = "Em dia"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnEmDia
        '
        Me.btnEmDia.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEmDia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmDia.FlatAppearance.BorderSize = 0
        Me.btnEmDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmDia.ForeColor = System.Drawing.Color.White
        Me.btnEmDia.Image = Global.MinhaEscola.My.Resources.Resources.Check_16x16
        Me.btnEmDia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmDia.Location = New System.Drawing.Point(268, 76)
        Me.btnEmDia.Name = "btnEmDia"
        Me.btnEmDia.Size = New System.Drawing.Size(119, 23)
        Me.btnEmDia.TabIndex = 71
        Me.btnEmDia.Text = "Em dia"
        Me.btnEmDia.UseVisualStyleBackColor = False
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagar.FlatAppearance.BorderSize = 0
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.Color.White
        Me.btnPagar.Image = Global.MinhaEscola.My.Resources.Resources.Icojam_Onebit_4_Currency_dollar_24
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.Location = New System.Drawing.Point(9, 447)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(151, 28)
        Me.btnPagar.TabIndex = 69
        Me.btnPagar.Text = "Pagar Parcela"
        Me.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagar.UseVisualStyleBackColor = False
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
        Me.btnEncerrar.Location = New System.Drawing.Point(264, 452)
        Me.btnEncerrar.Name = "btnEncerrar"
        Me.btnEncerrar.Size = New System.Drawing.Size(105, 23)
        Me.btnEncerrar.TabIndex = 68
        Me.btnEncerrar.Text = "Encerrar"
        Me.btnEncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEncerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MinhaEscola.My.Resources.Resources.cadastroalunos
        Me.PictureBox1.Location = New System.Drawing.Point(16, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmPagamentoMensalidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(415, 494)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtJuros)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.txtValorPago)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.btnEncerrar)
        Me.Controls.Add(Me.txtCodigoMensalidade)
        Me.Controls.Add(Me.txtNomeAluno)
        Me.Controls.Add(Me.txtNomeCurso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPagamentoMensalidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPagamentoMensalidade"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPagar As Button
    Friend WithEvents btnEncerrar As Button
    Friend WithEvents txtCodigoMensalidade As TextBox
    Friend WithEvents txtNomeAluno As TextBox
    Friend WithEvents txtNomeCurso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEmDia As Button
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpPagamentoParcela As DateTimePicker
    Friend WithEvents dtpVencimentoParcela As DateTimePicker
    Friend WithEvents txtValorParcela As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents txtJuros As TextBox
    Friend WithEvents btnCalcular As Button
End Class
