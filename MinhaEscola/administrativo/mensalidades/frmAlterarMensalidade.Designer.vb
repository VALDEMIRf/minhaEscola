<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlterarMensalidade
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeCurso = New System.Windows.Forms.TextBox()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.txtCodigoMensalidade = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpPagamentoParcela = New System.Windows.Forms.DateTimePicker()
        Me.dtpVencimentoParcela = New System.Windows.Forms.DateTimePicker()
        Me.txtValorParcela = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtJuros = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnEncerrar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(406, 50)
        Me.Panel2.TabIndex = 40
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(81, 13)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(273, 23)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "ALTERAR MENSALIDADE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MinhaEscola.My.Resources.Resources.cadastroalunos
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Código.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nome Aluno.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Nome Curso.:"
        '
        'txtNomeCurso
        '
        Me.txtNomeCurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNomeCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCurso.ForeColor = System.Drawing.Color.White
        Me.txtNomeCurso.Location = New System.Drawing.Point(99, 101)
        Me.txtNomeCurso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeCurso.Name = "txtNomeCurso"
        Me.txtNomeCurso.Size = New System.Drawing.Size(293, 20)
        Me.txtNomeCurso.TabIndex = 50
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNomeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCliente.ForeColor = System.Drawing.Color.White
        Me.txtNomeCliente.Location = New System.Drawing.Point(98, 76)
        Me.txtNomeCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(295, 20)
        Me.txtNomeCliente.TabIndex = 51
        '
        'txtCodigoMensalidade
        '
        Me.txtCodigoMensalidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtCodigoMensalidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoMensalidade.ForeColor = System.Drawing.Color.White
        Me.txtCodigoMensalidade.Location = New System.Drawing.Point(98, 54)
        Me.txtCodigoMensalidade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoMensalidade.Name = "txtCodigoMensalidade"
        Me.txtCodigoMensalidade.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoMensalidade.TabIndex = 52
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpPagamentoParcela)
        Me.GroupBox1.Controls.Add(Me.dtpVencimentoParcela)
        Me.GroupBox1.Controls.Add(Me.txtValorParcela)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 106)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parcela"
        '
        'dtpPagamentoParcela
        '
        Me.dtpPagamentoParcela.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dtpPagamentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPagamentoParcela.Location = New System.Drawing.Point(198, 76)
        Me.dtpPagamentoParcela.Name = "dtpPagamentoParcela"
        Me.dtpPagamentoParcela.Size = New System.Drawing.Size(120, 21)
        Me.dtpPagamentoParcela.TabIndex = 19
        '
        'dtpVencimentoParcela
        '
        Me.dtpVencimentoParcela.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dtpVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimentoParcela.Location = New System.Drawing.Point(198, 49)
        Me.dtpVencimentoParcela.Name = "dtpVencimentoParcela"
        Me.dtpVencimentoParcela.Size = New System.Drawing.Size(120, 21)
        Me.dtpVencimentoParcela.TabIndex = 18
        '
        'txtValorParcela
        '
        Me.txtValorParcela.ForeColor = System.Drawing.Color.Green
        Me.txtValorParcela.Location = New System.Drawing.Point(198, 21)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(120, 23)
        Me.txtValorParcela.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(104, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Pagamento.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(105, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Vencimento.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(63, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Valor Mensalidade.:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtJuros)
        Me.GroupBox2.Controls.Add(Me.txtDesconto)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 100)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(239, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 42)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Juros e Desconto aplicados a mensalidade."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtJuros
        '
        Me.txtJuros.ForeColor = System.Drawing.Color.Red
        Me.txtJuros.Location = New System.Drawing.Point(113, 55)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(120, 23)
        Me.txtJuros.TabIndex = 23
        '
        'txtDesconto
        '
        Me.txtDesconto.ForeColor = System.Drawing.Color.Blue
        Me.txtDesconto.Location = New System.Drawing.Point(113, 19)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(120, 23)
        Me.txtDesconto.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(21, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Desconto.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(48, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Juros.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 394)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 17)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Observações.:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(108, 343)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(286, 83)
        Me.txtObservacao.TabIndex = 56
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlterar.FlatAppearance.BorderSize = 0
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.Image = Global.MinhaEscola.My.Resources.Resources.Notes
        Me.btnAlterar.Location = New System.Drawing.Point(12, 437)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(156, 32)
        Me.btnAlterar.TabIndex = 58
        Me.btnAlterar.Text = "Alterar Parcelas"
        Me.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlterar.UseVisualStyleBackColor = False
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
        Me.btnEncerrar.Location = New System.Drawing.Point(286, 437)
        Me.btnEncerrar.Name = "btnEncerrar"
        Me.btnEncerrar.Size = New System.Drawing.Size(105, 32)
        Me.btnEncerrar.TabIndex = 57
        Me.btnEncerrar.Text = "Encerrar"
        Me.btnEncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEncerrar.UseVisualStyleBackColor = False
        '
        'frmAlterarMensalidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(406, 480)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnEncerrar)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCodigoMensalidade)
        Me.Controls.Add(Me.txtNomeCliente)
        Me.Controls.Add(Me.txtNomeCurso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAlterarMensalidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAlterarMensalidade"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomeCurso As TextBox
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents txtCodigoMensalidade As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpPagamentoParcela As DateTimePicker
    Friend WithEvents dtpVencimentoParcela As DateTimePicker
    Friend WithEvents txtValorParcela As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtJuros As TextBox
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnEncerrar As Button
End Class
