<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControleMensalidades
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
        Me.btFechar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblAlunosMatriculados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCurso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblContagemAlunos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMediaContagemTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalLinhasSelecionadas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalItensSelecionados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstAlunos = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvCursos = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalLiquidoParcelas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalDesconto = New System.Windows.Forms.TextBox()
        Me.txtTotalJuros = New System.Windows.Forms.TextBox()
        Me.lblTotalBrutoParcelas = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dgvMensalidades = New System.Windows.Forms.DataGridView()
        Me.lblMensagemPagamentos = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblidCurso = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkExibirTodasMensalidadeCursos = New System.Windows.Forms.CheckBox()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.rdExbirParcelasPagas = New System.Windows.Forms.RadioButton()
        Me.rdTodasParcelas = New System.Windows.Forms.RadioButton()
        Me.rdExibirParcelasNaoPagar = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btNovaMatricula = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAlterarMatricula = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExcluirMatricula = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGerarMensalidade = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterarMensalidade = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluirMensalidade = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBaixaMensalidade = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRelatorio = New System.Windows.Forms.ToolStripButton()
        Me.btLancar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagar = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMensalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btFechar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1055, 47)
        Me.Panel2.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(230, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(477, 32)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "CONTROLE DE MENSALIDADES"
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
        'btFechar
        '
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.FlatAppearance.BorderSize = 0
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = Global.MinhaEscola.My.Resources.Resources._Exit
        Me.btFechar.Location = New System.Drawing.Point(954, 7)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(89, 32)
        Me.btFechar.TabIndex = 4
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblAlunosMatriculados, Me.lblCurso, Me.lblContagemAlunos, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel6, Me.lblMediaContagemTotal, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel3, Me.lblTotalLinhasSelecionadas, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel1, Me.lblTotalItensSelecionados})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1055, 22)
        Me.StatusStrip1.TabIndex = 340
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblAlunosMatriculados
        '
        Me.lblAlunosMatriculados.Name = "lblAlunosMatriculados"
        Me.lblAlunosMatriculados.Size = New System.Drawing.Size(227, 17)
        Me.lblAlunosMatriculados.Text = "Total de Aluno(s) Matrículado(s) no Curso"
        '
        'lblCurso
        '
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(105, 17)
        Me.lblCurso.Text = "Curso Selecionado"
        '
        'lblContagemAlunos
        '
        Me.lblContagemAlunos.Name = "lblContagemAlunos"
        Me.lblContagemAlunos.Size = New System.Drawing.Size(13, 17)
        Me.lblContagemAlunos.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(390, 17)
        Me.ToolStripStatusLabel2.Spring = True
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(46, 17)
        Me.ToolStripStatusLabel6.Text = "Média.:"
        '
        'lblMediaContagemTotal
        '
        Me.lblMediaContagemTotal.Name = "lblMediaContagemTotal"
        Me.lblMediaContagemTotal.Size = New System.Drawing.Size(44, 17)
        Me.lblMediaContagemTotal.Text = "R$ 0,00"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(22, 17)
        Me.ToolStripStatusLabel5.Text = "     "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(69, 17)
        Me.ToolStripStatusLabel3.Text = "Contagem.:"
        '
        'lblTotalLinhasSelecionadas
        '
        Me.lblTotalLinhasSelecionadas.Name = "lblTotalLinhasSelecionadas"
        Me.lblTotalLinhasSelecionadas.Size = New System.Drawing.Size(13, 17)
        Me.lblTotalLinhasSelecionadas.Text = "0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(22, 17)
        Me.ToolStripStatusLabel4.Text = "     "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel1.Text = "Soma.:"
        '
        'lblTotalItensSelecionados
        '
        Me.lblTotalItensSelecionados.Name = "lblTotalItensSelecionados"
        Me.lblTotalItensSelecionados.Size = New System.Drawing.Size(44, 17)
        Me.lblTotalItensSelecionados.Text = "R$ 0,00"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 93)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 482)
        Me.TableLayoutPanel1.TabIndex = 347
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstAlunos)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 183)
        Me.GroupBox2.TabIndex = 337
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Alunos"
        '
        'lstAlunos
        '
        Me.lstAlunos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAlunos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAlunos.FormattingEnabled = True
        Me.lstAlunos.ItemHeight = 14
        Me.lstAlunos.Location = New System.Drawing.Point(3, 18)
        Me.lstAlunos.Name = "lstAlunos"
        Me.lstAlunos.ScrollAlwaysVisible = True
        Me.lstAlunos.Size = New System.Drawing.Size(288, 162)
        Me.lstAlunos.TabIndex = 337
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCursos)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 182)
        Me.GroupBox1.TabIndex = 335
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista dos Cursos"
        '
        'dgvCursos
        '
        Me.dgvCursos.AllowUserToAddRows = False
        Me.dgvCursos.AllowUserToDeleteRows = False
        Me.dgvCursos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCursos.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgvCursos.Location = New System.Drawing.Point(2, 15)
        Me.dgvCursos.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgvCursos.Name = "dgvCursos"
        Me.dgvCursos.ReadOnly = True
        Me.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCursos.Size = New System.Drawing.Size(280, 162)
        Me.dgvCursos.TabIndex = 337
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(859, 524)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 13)
        Me.Label13.TabIndex = 355
        Me.Label13.Text = "Total Líquido Mensalidades"
        '
        'txtTotalLiquidoParcelas
        '
        Me.txtTotalLiquidoParcelas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalLiquidoParcelas.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalLiquidoParcelas.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLiquidoParcelas.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtTotalLiquidoParcelas.Location = New System.Drawing.Point(853, 540)
        Me.txtTotalLiquidoParcelas.Multiline = True
        Me.txtTotalLiquidoParcelas.Name = "txtTotalLiquidoParcelas"
        Me.txtTotalLiquidoParcelas.ReadOnly = True
        Me.txtTotalLiquidoParcelas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalLiquidoParcelas.Size = New System.Drawing.Size(188, 31)
        Me.txtTotalLiquidoParcelas.TabIndex = 354
        Me.txtTotalLiquidoParcelas.Text = "R$ 0,00"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(522, 524)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 353
        Me.Label12.Text = "Desconto"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(689, 524)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 352
        Me.Label11.Text = "Juros"
        '
        'txtTotalDesconto
        '
        Me.txtTotalDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDesconto.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalDesconto.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDesconto.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalDesconto.Location = New System.Drawing.Point(519, 540)
        Me.txtTotalDesconto.Multiline = True
        Me.txtTotalDesconto.Name = "txtTotalDesconto"
        Me.txtTotalDesconto.ReadOnly = True
        Me.txtTotalDesconto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalDesconto.Size = New System.Drawing.Size(152, 31)
        Me.txtTotalDesconto.TabIndex = 351
        Me.txtTotalDesconto.Text = "R$ 0,00"
        '
        'txtTotalJuros
        '
        Me.txtTotalJuros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalJuros.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalJuros.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalJuros.ForeColor = System.Drawing.Color.Red
        Me.txtTotalJuros.Location = New System.Drawing.Point(686, 540)
        Me.txtTotalJuros.Multiline = True
        Me.txtTotalJuros.Name = "txtTotalJuros"
        Me.txtTotalJuros.ReadOnly = True
        Me.txtTotalJuros.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalJuros.Size = New System.Drawing.Size(152, 31)
        Me.txtTotalJuros.TabIndex = 350
        Me.txtTotalJuros.Text = "R$ 0,00"
        '
        'lblTotalBrutoParcelas
        '
        Me.lblTotalBrutoParcelas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalBrutoParcelas.AutoSize = True
        Me.lblTotalBrutoParcelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBrutoParcelas.Location = New System.Drawing.Point(322, 524)
        Me.lblTotalBrutoParcelas.Name = "lblTotalBrutoParcelas"
        Me.lblTotalBrutoParcelas.Size = New System.Drawing.Size(151, 13)
        Me.lblTotalBrutoParcelas.TabIndex = 349
        Me.lblTotalBrutoParcelas.Text = "Total Bruto Mensalidades"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.txtTotal.Location = New System.Drawing.Point(319, 540)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(188, 31)
        Me.txtTotal.TabIndex = 348
        Me.txtTotal.Text = "R$ 0,00"
        '
        'dgvMensalidades
        '
        Me.dgvMensalidades.AllowUserToAddRows = False
        Me.dgvMensalidades.AllowUserToDeleteRows = False
        Me.dgvMensalidades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvMensalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMensalidades.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgvMensalidades.Location = New System.Drawing.Point(306, 298)
        Me.dgvMensalidades.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgvMensalidades.Name = "dgvMensalidades"
        Me.dgvMensalidades.ReadOnly = True
        Me.dgvMensalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMensalidades.Size = New System.Drawing.Size(735, 157)
        Me.dgvMensalidades.TabIndex = 338
        '
        'lblMensagemPagamentos
        '
        Me.lblMensagemPagamentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensagemPagamentos.BackColor = System.Drawing.Color.White
        Me.lblMensagemPagamentos.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblMensagemPagamentos.Location = New System.Drawing.Point(330, 355)
        Me.lblMensagemPagamentos.Name = "lblMensagemPagamentos"
        Me.lblMensagemPagamentos.Size = New System.Drawing.Size(684, 31)
        Me.lblMensagemPagamentos.TabIndex = 356
        Me.lblMensagemPagamentos.Text = "< Não foram encontradas nenhuma parcela no momento para o aluno selecionado. >"
        Me.lblMensagemPagamentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMensagemPagamentos.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.lblidCurso)
        Me.GroupBox3.Controls.Add(Me.txtCelular)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtBairro)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtCidade)
        Me.GroupBox3.Controls.Add(Me.txtUF)
        Me.GroupBox3.Controls.Add(Me.txtCompl)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtComplemento)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txtNum)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.txtCep)
        Me.GroupBox3.Controls.Add(Me.txtEndereco)
        Me.GroupBox3.Controls.Add(Me.txtRG)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtCPF)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.chkExibirTodasMensalidadeCursos)
        Me.GroupBox3.Controls.Add(Me.btnExportarExcel)
        Me.GroupBox3.Controls.Add(Me.rdExbirParcelasPagas)
        Me.GroupBox3.Controls.Add(Me.rdTodasParcelas)
        Me.GroupBox3.Controls.Add(Me.rdExibirParcelasNaoPagar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtNome)
        Me.GroupBox3.Controls.Add(Me.txtCodigo)
        Me.GroupBox3.Location = New System.Drawing.Point(310, 129)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(734, 159)
        Me.GroupBox3.TabIndex = 357
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalhes (Principais) do Alunos"
        '
        'lblidCurso
        '
        Me.lblidCurso.AutoSize = True
        Me.lblidCurso.Location = New System.Drawing.Point(20, 21)
        Me.lblidCurso.Name = "lblidCurso"
        Me.lblidCurso.Size = New System.Drawing.Size(13, 13)
        Me.lblidCurso.TabIndex = 206
        Me.lblidCurso.Text = "0"
        Me.lblidCurso.Visible = False
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(404, 64)
        Me.txtCelular.Mask = "(99) 9 9999-9999"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(89, 20)
        Me.txtCelular.TabIndex = 205
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(366, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 204
        Me.Label10.Text = "Fone.:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(43, 61)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(303, 21)
        Me.txtEmail.TabIndex = 203
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 202
        Me.Label8.Text = "E-mail.:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(95, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 200
        Me.Label14.Text = "Bairro: "
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(144, 133)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.ReadOnly = True
        Me.txtBairro.Size = New System.Drawing.Size(200, 20)
        Me.txtBairro.TabIndex = 199
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(348, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "Cidade: "
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(402, 135)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.ReadOnly = True
        Me.txtCidade.Size = New System.Drawing.Size(137, 20)
        Me.txtCidade.TabIndex = 197
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.Location = New System.Drawing.Point(41, 132)
        Me.txtUF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.ReadOnly = True
        Me.txtUF.Size = New System.Drawing.Size(54, 20)
        Me.txtUF.TabIndex = 196
        '
        'txtCompl
        '
        Me.txtCompl.Location = New System.Drawing.Point(369, 111)
        Me.txtCompl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(170, 20)
        Me.txtCompl.TabIndex = 194
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 195
        Me.Label5.Text = "UF:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Enabled = False
        Me.txtComplemento.Location = New System.Drawing.Point(183, 111)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.ReadOnly = True
        Me.txtComplemento.Size = New System.Drawing.Size(180, 20)
        Me.txtComplemento.TabIndex = 193
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(93, 114)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(92, 13)
        Me.Label28.TabIndex = 192
        Me.Label28.Text = "Complemento:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(41, 109)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(54, 20)
        Me.txtNum.TabIndex = 190
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 113)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 13)
        Me.Label24.TabIndex = 191
        Me.Label24.Text = "Nº "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 189
        Me.Label4.Text = "CEP :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(129, 90)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 13)
        Me.Label25.TabIndex = 188
        Me.Label25.Text = "Endereço: "
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(41, 86)
        Me.txtCep.Mask = "00000-999"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(69, 20)
        Me.txtCep.TabIndex = 186
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(196, 87)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.ReadOnly = True
        Me.txtEndereco.Size = New System.Drawing.Size(343, 20)
        Me.txtEndereco.TabIndex = 187
        '
        'txtRG
        '
        Me.txtRG.BackColor = System.Drawing.Color.White
        Me.txtRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRG.ForeColor = System.Drawing.Color.Black
        Me.txtRG.Location = New System.Drawing.Point(409, 13)
        Me.txtRG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(130, 20)
        Me.txtRG.TabIndex = 183
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(339, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 13)
        Me.Label22.TabIndex = 185
        Me.Label22.Text = "RG / RNE:"
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(238, 15)
        Me.txtCPF.Mask = "000.000.000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(92, 20)
        Me.txtCPF.TabIndex = 182
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "CPF:"
        '
        'chkExibirTodasMensalidadeCursos
        '
        Me.chkExibirTodasMensalidadeCursos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkExibirTodasMensalidadeCursos.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkExibirTodasMensalidadeCursos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkExibirTodasMensalidadeCursos.Location = New System.Drawing.Point(569, 84)
        Me.chkExibirTodasMensalidadeCursos.Name = "chkExibirTodasMensalidadeCursos"
        Me.chkExibirTodasMensalidadeCursos.Size = New System.Drawing.Size(143, 23)
        Me.chkExibirTodasMensalidadeCursos.TabIndex = 34
        Me.chkExibirTodasMensalidadeCursos.Text = "Exibir Todas Mensalidades"
        Me.chkExibirTodasMensalidadeCursos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkExibirTodasMensalidadeCursos.UseVisualStyleBackColor = True
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportarExcel.Image = Global.MinhaEscola.My.Resources.Resources.Excel_24
        Me.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarExcel.Location = New System.Drawing.Point(556, 108)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(168, 30)
        Me.btnExportarExcel.TabIndex = 32
        Me.btnExportarExcel.Text = "Exportar Excel"
        Me.btnExportarExcel.UseVisualStyleBackColor = False
        '
        'rdExbirParcelasPagas
        '
        Me.rdExbirParcelasPagas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdExbirParcelasPagas.AutoSize = True
        Me.rdExbirParcelasPagas.Location = New System.Drawing.Point(557, 41)
        Me.rdExbirParcelasPagas.Name = "rdExbirParcelasPagas"
        Me.rdExbirParcelasPagas.Size = New System.Drawing.Size(151, 17)
        Me.rdExbirParcelasPagas.TabIndex = 28
        Me.rdExbirParcelasPagas.Text = "Exibir Mensalidades Pagas"
        Me.rdExbirParcelasPagas.UseVisualStyleBackColor = True
        '
        'rdTodasParcelas
        '
        Me.rdTodasParcelas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdTodasParcelas.AutoSize = True
        Me.rdTodasParcelas.Checked = True
        Me.rdTodasParcelas.Location = New System.Drawing.Point(556, 18)
        Me.rdTodasParcelas.Name = "rdTodasParcelas"
        Me.rdTodasParcelas.Size = New System.Drawing.Size(168, 17)
        Me.rdTodasParcelas.TabIndex = 27
        Me.rdTodasParcelas.TabStop = True
        Me.rdTodasParcelas.Text = "Exibir Todas  as Mensalidades"
        Me.rdTodasParcelas.UseVisualStyleBackColor = True
        '
        'rdExibirParcelasNaoPagar
        '
        Me.rdExibirParcelasNaoPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdExibirParcelasNaoPagar.AutoSize = True
        Me.rdExibirParcelasNaoPagar.Location = New System.Drawing.Point(557, 64)
        Me.rdExibirParcelasNaoPagar.Name = "rdExibirParcelasNaoPagar"
        Me.rdExibirParcelasNaoPagar.Size = New System.Drawing.Size(174, 17)
        Me.rdExibirParcelasNaoPagar.TabIndex = 26
        Me.rdExibirParcelasNaoPagar.Text = "Exibir Mensalidades Não Pagas"
        Me.rdExibirParcelasNaoPagar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nome.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cód.:"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNome.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.White
        Me.txtNome.Location = New System.Drawing.Point(41, 38)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.ReadOnly = True
        Me.txtNome.Size = New System.Drawing.Size(427, 21)
        Me.txtNome.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(131, 14)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(54, 21)
        Me.txtCodigo.TabIndex = 0
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Transparent
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.btnGerarMensalidade, Me.btnAlterarMensalidade, Me.btnExcluirMensalidade, Me.ToolStripSeparator2, Me.btnBaixaMensalidade, Me.ToolStripSeparator3, Me.btnRelatorio})
        Me.tsMenu.Location = New System.Drawing.Point(0, 47)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsMenu.Size = New System.Drawing.Size(1055, 31)
        Me.tsMenu.TabIndex = 358
        Me.tsMenu.Text = "ToolStrip2"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNovaMatricula, Me.btnAlterarMatricula, Me.btnExcluirMatricula, Me.ToolStripSeparator4})
        Me.ToolStripDropDownButton1.Image = Global.MinhaEscola.My.Resources.Resources.opcoes
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(134, 28)
        Me.ToolStripDropDownButton1.Text = "&Menu de Opções"
        '
        'btNovaMatricula
        '
        Me.btNovaMatricula.BackColor = System.Drawing.Color.Transparent
        Me.btNovaMatricula.Name = "btNovaMatricula"
        Me.btNovaMatricula.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.btNovaMatricula.Size = New System.Drawing.Size(200, 22)
        Me.btNovaMatricula.Text = "&Nova Matricula"
        '
        'btnAlterarMatricula
        '
        Me.btnAlterarMatricula.Name = "btnAlterarMatricula"
        Me.btnAlterarMatricula.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.btnAlterarMatricula.Size = New System.Drawing.Size(200, 22)
        Me.btnAlterarMatricula.Text = "&Alterar Matricula"
        '
        'btnExcluirMatricula
        '
        Me.btnExcluirMatricula.Name = "btnExcluirMatricula"
        Me.btnExcluirMatricula.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.btnExcluirMatricula.Size = New System.Drawing.Size(200, 22)
        Me.btnExcluirMatricula.Text = "&Excluir Matricula"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(197, 6)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'btnGerarMensalidade
        '
        Me.btnGerarMensalidade.Image = Global.MinhaEscola.My.Resources.Resources.gerarmensalidade
        Me.btnGerarMensalidade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGerarMensalidade.Name = "btnGerarMensalidade"
        Me.btnGerarMensalidade.Size = New System.Drawing.Size(133, 28)
        Me.btnGerarMensalidade.Text = "Gerar Mensalidade"
        '
        'btnAlterarMensalidade
        '
        Me.btnAlterarMensalidade.Image = Global.MinhaEscola.My.Resources.Resources.Notes
        Me.btnAlterarMensalidade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterarMensalidade.Name = "btnAlterarMensalidade"
        Me.btnAlterarMensalidade.Size = New System.Drawing.Size(140, 28)
        Me.btnAlterarMensalidade.Text = "Alterar Mensalidade"
        '
        'btnExcluirMensalidade
        '
        Me.btnExcluirMensalidade.Image = Global.MinhaEscola.My.Resources.Resources.Delete
        Me.btnExcluirMensalidade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluirMensalidade.Name = "btnExcluirMensalidade"
        Me.btnExcluirMensalidade.Size = New System.Drawing.Size(140, 28)
        Me.btnExcluirMensalidade.Text = "Exlcuir Mensalidade"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'btnBaixaMensalidade
        '
        Me.btnBaixaMensalidade.Image = Global.MinhaEscola.My.Resources.Resources.Download_16
        Me.btnBaixaMensalidade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBaixaMensalidade.Name = "btnBaixaMensalidade"
        Me.btnBaixaMensalidade.Size = New System.Drawing.Size(153, 28)
        Me.btnBaixaMensalidade.Text = "Baixa em Mensalidade"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Image = Global.MinhaEscola.My.Resources.Resources.Report
        Me.btnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(82, 28)
        Me.btnRelatorio.Text = "Relatório"
        '
        'btLancar
        '
        Me.btLancar.Location = New System.Drawing.Point(325, 93)
        Me.btLancar.Name = "btLancar"
        Me.btLancar.Size = New System.Drawing.Size(131, 23)
        Me.btLancar.TabIndex = 359
        Me.btLancar.Text = "Lançar Conta"
        Me.btLancar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(859, 470)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 361
        Me.Label7.Text = "Total "
        '
        'txtTotalContasPagar
        '
        Me.txtTotalContasPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalContasPagar.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalContasPagar.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagar.ForeColor = System.Drawing.Color.Red
        Me.txtTotalContasPagar.Location = New System.Drawing.Point(853, 486)
        Me.txtTotalContasPagar.Multiline = True
        Me.txtTotalContasPagar.Name = "txtTotalContasPagar"
        Me.txtTotalContasPagar.ReadOnly = True
        Me.txtTotalContasPagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalContasPagar.Size = New System.Drawing.Size(188, 31)
        Me.txtTotalContasPagar.TabIndex = 360
        Me.txtTotalContasPagar.Text = "R$ 0,00"
        '
        'frmControleMensalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1055, 600)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalContasPagar)
        Me.Controls.Add(Me.btLancar)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblMensagemPagamentos)
        Me.Controls.Add(Me.dgvMensalidades)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotalLiquidoParcelas)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTotalDesconto)
        Me.Controls.Add(Me.txtTotalJuros)
        Me.Controls.Add(Me.lblTotalBrutoParcelas)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmControleMensalidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmControleMensalidades"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMensalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btFechar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblAlunosMatriculados As ToolStripStatusLabel
    Friend WithEvents lblCurso As ToolStripStatusLabel
    Friend WithEvents lblContagemAlunos As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents lblMediaContagemTotal As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblTotalLinhasSelecionadas As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblTotalItensSelecionados As ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstAlunos As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvCursos As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotalLiquidoParcelas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotalDesconto As TextBox
    Friend WithEvents txtTotalJuros As TextBox
    Friend WithEvents lblTotalBrutoParcelas As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dgvMensalidades As DataGridView
    Friend WithEvents lblMensagemPagamentos As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkExibirTodasMensalidadeCursos As CheckBox
    Friend WithEvents btnExportarExcel As Button
    Friend WithEvents rdExbirParcelasPagas As RadioButton
    Friend WithEvents rdTodasParcelas As RadioButton
    Friend WithEvents rdExibirParcelasNaoPagar As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtRG As TextBox
    Private WithEvents Label22 As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Private WithEvents Label2 As Label
    Friend WithEvents tsMenu As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnGerarMensalidade As ToolStripButton
    Friend WithEvents btnAlterarMensalidade As ToolStripButton
    Friend WithEvents btnExcluirMensalidade As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnBaixaMensalidade As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnRelatorio As ToolStripButton
    Friend WithEvents btNovaMatricula As ToolStripMenuItem
    Friend WithEvents btnAlterarMatricula As ToolStripMenuItem
    Friend WithEvents btnExcluirMatricula As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents txtCep As MaskedTextBox
    Private WithEvents txtEndereco As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents Label25 As Label
    Private WithEvents txtComplemento As TextBox
    Private WithEvents Label28 As Label
    Private WithEvents txtNum As TextBox
    Private WithEvents Label24 As Label
    Private WithEvents txtUF As TextBox
    Private WithEvents txtCompl As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents Label14 As Label
    Private WithEvents txtBairro As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblidCurso As Label
    Friend WithEvents btLancar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalContasPagar As TextBox
End Class
