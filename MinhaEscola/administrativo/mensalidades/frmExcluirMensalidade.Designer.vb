<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExcluirMensalidade
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.dtpPagamentoParcela = New System.Windows.Forms.DateTimePicker()
        Me.dtpVencimentoParcela = New System.Windows.Forms.DateTimePicker()
        Me.txtValorParcela = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
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
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(379, 47)
        Me.Panel2.TabIndex = 38
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(58, 7)
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
        Me.txtCodigoMensalidade.Location = New System.Drawing.Point(74, 54)
        Me.txtCodigoMensalidade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoMensalidade.Name = "txtCodigoMensalidade"
        Me.txtCodigoMensalidade.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoMensalidade.TabIndex = 58
        '
        'txtNomeAluno
        '
        Me.txtNomeAluno.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNomeAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeAluno.ForeColor = System.Drawing.Color.White
        Me.txtNomeAluno.Location = New System.Drawing.Point(74, 76)
        Me.txtNomeAluno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeAluno.Name = "txtNomeAluno"
        Me.txtNomeAluno.Size = New System.Drawing.Size(295, 20)
        Me.txtNomeAluno.TabIndex = 57
        '
        'txtNomeCurso
        '
        Me.txtNomeCurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNomeCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCurso.ForeColor = System.Drawing.Color.White
        Me.txtNomeCurso.Location = New System.Drawing.Point(75, 101)
        Me.txtNomeCurso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeCurso.Name = "txtNomeCurso"
        Me.txtNomeCurso.Size = New System.Drawing.Size(293, 20)
        Me.txtNomeCurso.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Nome Curso.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Nome Aluno.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Código.:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtObservacao)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpPagamentoParcela)
        Me.GroupBox1.Controls.Add(Me.dtpVencimentoParcela)
        Me.GroupBox1.Controls.Add(Me.txtValorParcela)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 231)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pagamento"
        '
        'dtpPagamentoParcela
        '
        Me.dtpPagamentoParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpPagamentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPagamentoParcela.Location = New System.Drawing.Point(180, 80)
        Me.dtpPagamentoParcela.Name = "dtpPagamentoParcela"
        Me.dtpPagamentoParcela.Size = New System.Drawing.Size(120, 23)
        Me.dtpPagamentoParcela.TabIndex = 25
        '
        'dtpVencimentoParcela
        '
        Me.dtpVencimentoParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimentoParcela.Location = New System.Drawing.Point(180, 53)
        Me.dtpVencimentoParcela.Name = "dtpVencimentoParcela"
        Me.dtpVencimentoParcela.Size = New System.Drawing.Size(120, 23)
        Me.dtpVencimentoParcela.TabIndex = 24
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtValorParcela.ForeColor = System.Drawing.Color.Green
        Me.txtValorParcela.Location = New System.Drawing.Point(180, 25)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(120, 23)
        Me.txtValorParcela.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(86, 82)
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
        Me.Label5.Location = New System.Drawing.Point(76, 53)
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
        Me.Label4.Location = New System.Drawing.Point(45, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Valor Mensalidade.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Observação.:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(103, 109)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(255, 116)
        Me.txtObservacao.TabIndex = 27
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = Global.MinhaEscola.My.Resources.Resources.No_entry
        Me.btnExcluir.Location = New System.Drawing.Point(6, 367)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(152, 32)
        Me.btnExcluir.TabIndex = 61
        Me.btnExcluir.Text = "Excluir Parcelas"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
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
        Me.btnEncerrar.Location = New System.Drawing.Point(262, 367)
        Me.btnEncerrar.Name = "btnEncerrar"
        Me.btnEncerrar.Size = New System.Drawing.Size(105, 32)
        Me.btnEncerrar.TabIndex = 60
        Me.btnEncerrar.Text = "Encerrar"
        Me.btnEncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEncerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MinhaEscola.My.Resources.Resources.cadastroalunos
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmExcluirMensalidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(379, 406)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEncerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCodigoMensalidade)
        Me.Controls.Add(Me.txtNomeAluno)
        Me.Controls.Add(Me.txtNomeCurso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExcluirMensalidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExcluirMensalidade"
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
    Friend WithEvents txtCodigoMensalidade As TextBox
    Friend WithEvents txtNomeAluno As TextBox
    Friend WithEvents txtNomeCurso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpPagamentoParcela As DateTimePicker
    Friend WithEvents dtpVencimentoParcela As DateTimePicker
    Friend WithEvents txtValorParcela As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEncerrar As Button
End Class
