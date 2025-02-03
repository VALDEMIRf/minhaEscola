<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroAlunos
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
        Me.tcAlunos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmbCursos = New System.Windows.Forms.ComboBox()
        Me.cmbEstCivil = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btImagem = New System.Windows.Forms.Button()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.pbImagem = New System.Windows.Forms.PictureBox()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btConsultaCEP = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.cmbAno = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.cmbDia = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.txtNomeAluno = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btInserirOcupacao = New System.Windows.Forms.Button()
        Me.cmbOcupacaoResp = New System.Windows.Forms.ComboBox()
        Me.cmbOcupacaoMae = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCelPai = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCelResp = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCelMae = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbOcupacaoPai = New System.Windows.Forms.ComboBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.txtNomeMae = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNomeResp = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNomePai = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBuscarNome = New System.Windows.Forms.TextBox()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCPF = New System.Windows.Forms.MaskedTextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btSalvarEditar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.tcAlunos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcAlunos
        '
        Me.tcAlunos.Controls.Add(Me.TabPage1)
        Me.tcAlunos.Controls.Add(Me.TabPage2)
        Me.tcAlunos.Location = New System.Drawing.Point(4, 52)
        Me.tcAlunos.Name = "tcAlunos"
        Me.tcAlunos.SelectedIndex = 0
        Me.tcAlunos.Size = New System.Drawing.Size(1124, 213)
        Me.tcAlunos.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.groupBox1)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1116, 187)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Informações do Estudante"
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.Label30)
        Me.groupBox1.Controls.Add(Me.cmbCursos)
        Me.groupBox1.Controls.Add(Me.cmbEstCivil)
        Me.groupBox1.Controls.Add(Me.Label29)
        Me.groupBox1.Controls.Add(Me.lblCodigo)
        Me.groupBox1.Controls.Add(Me.btImagem)
        Me.groupBox1.Controls.Add(Me.txtUF)
        Me.groupBox1.Controls.Add(Me.pbImagem)
        Me.groupBox1.Controls.Add(Me.txtCompl)
        Me.groupBox1.Controls.Add(Me.txtComplemento)
        Me.groupBox1.Controls.Add(Me.Label28)
        Me.groupBox1.Controls.Add(Me.btConsultaCEP)
        Me.groupBox1.Controls.Add(Me.txtNum)
        Me.groupBox1.Controls.Add(Me.Label24)
        Me.groupBox1.Controls.Add(Me.btnProximo)
        Me.groupBox1.Controls.Add(Me.txtRG)
        Me.groupBox1.Controls.Add(Me.Label22)
        Me.groupBox1.Controls.Add(Me.txtCPF)
        Me.groupBox1.Controls.Add(Me.cmbAno)
        Me.groupBox1.Controls.Add(Me.cmbMes)
        Me.groupBox1.Controls.Add(Me.cmbDia)
        Me.groupBox1.Controls.Add(Me.Label14)
        Me.groupBox1.Controls.Add(Me.txtBairro)
        Me.groupBox1.Controls.Add(Me.Label12)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.txtCidade)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.txtCep)
        Me.groupBox1.Controls.Add(Me.Label21)
        Me.groupBox1.Controls.Add(Me.Label27)
        Me.groupBox1.Controls.Add(Me.txtCelular)
        Me.groupBox1.Controls.Add(Me.Label26)
        Me.groupBox1.Controls.Add(Me.txtTelefone)
        Me.groupBox1.Controls.Add(Me.txtEndereco)
        Me.groupBox1.Controls.Add(Me.Label25)
        Me.groupBox1.Controls.Add(Me.txtEmail)
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.cmbSexo)
        Me.groupBox1.Controls.Add(Me.label13)
        Me.groupBox1.Controls.Add(Me.txtNomeAluno)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Location = New System.Drawing.Point(7, 7)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Size = New System.Drawing.Size(1103, 173)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(7, 87)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(46, 13)
        Me.Label30.TabIndex = 332
        Me.Label30.Text = "Curso:"
        '
        'cmbCursos
        '
        Me.cmbCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCursos.FormattingEnabled = True
        Me.cmbCursos.Location = New System.Drawing.Point(6, 102)
        Me.cmbCursos.Name = "cmbCursos"
        Me.cmbCursos.Size = New System.Drawing.Size(262, 21)
        Me.cmbCursos.TabIndex = 331
        '
        'cmbEstCivil
        '
        Me.cmbEstCivil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbEstCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstCivil.FormattingEnabled = True
        Me.cmbEstCivil.Items.AddRange(New Object() {"Solteiro", "Casado", "Separado", "Divorciado", "Viúvo"})
        Me.cmbEstCivil.Location = New System.Drawing.Point(333, 64)
        Me.cmbEstCivil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbEstCivil.Name = "cmbEstCivil"
        Me.cmbEstCivil.Size = New System.Drawing.Size(127, 21)
        Me.cmbEstCivil.TabIndex = 5
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(336, 49)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 13)
        Me.Label29.TabIndex = 330
        Me.Label29.Text = "Estado Civil"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(727, 145)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(14, 13)
        Me.lblCodigo.TabIndex = 329
        Me.lblCodigo.Text = "0"
        Me.lblCodigo.Visible = False
        '
        'btImagem
        '
        Me.btImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImagem.FlatAppearance.BorderSize = 0
        Me.btImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImagem.Image = Global.MinhaEscola.My.Resources.Resources.camera
        Me.btImagem.Location = New System.Drawing.Point(1016, 140)
        Me.btImagem.Name = "btImagem"
        Me.btImagem.Size = New System.Drawing.Size(39, 22)
        Me.btImagem.TabIndex = 16
        Me.btImagem.UseVisualStyleBackColor = True
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.Location = New System.Drawing.Point(902, 64)
        Me.txtUF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.ReadOnly = True
        Me.txtUF.Size = New System.Drawing.Size(54, 20)
        Me.txtUF.TabIndex = 189
        '
        'pbImagem
        '
        Me.pbImagem.Location = New System.Drawing.Point(974, 14)
        Me.pbImagem.Name = "pbImagem"
        Me.pbImagem.Size = New System.Drawing.Size(120, 120)
        Me.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagem.TabIndex = 328
        Me.pbImagem.TabStop = False
        '
        'txtCompl
        '
        Me.txtCompl.Location = New System.Drawing.Point(713, 64)
        Me.txtCompl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(183, 20)
        Me.txtCompl.TabIndex = 15
        '
        'txtComplemento
        '
        Me.txtComplemento.Enabled = False
        Me.txtComplemento.Location = New System.Drawing.Point(543, 64)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.ReadOnly = True
        Me.txtComplemento.Size = New System.Drawing.Size(159, 20)
        Me.txtComplemento.TabIndex = 187
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(540, 49)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(87, 13)
        Me.Label28.TabIndex = 186
        Me.Label28.Text = "Complemento"
        '
        'btConsultaCEP
        '
        Me.btConsultaCEP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConsultaCEP.FlatAppearance.BorderSize = 0
        Me.btConsultaCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConsultaCEP.Image = Global.MinhaEscola.My.Resources.Resources.Find1
        Me.btConsultaCEP.Location = New System.Drawing.Point(548, 23)
        Me.btConsultaCEP.Name = "btConsultaCEP"
        Me.btConsultaCEP.Size = New System.Drawing.Size(39, 22)
        Me.btConsultaCEP.TabIndex = 13
        Me.btConsultaCEP.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(479, 64)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(54, 20)
        Me.txtNum.TabIndex = 14
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(476, 49)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 13)
        Me.Label24.TabIndex = 183
        Me.Label24.Text = "Nº "
        '
        'btnProximo
        '
        Me.btnProximo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProximo.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProximo.ForeColor = System.Drawing.Color.White
        Me.btnProximo.Location = New System.Drawing.Point(837, 140)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(123, 25)
        Me.btnProximo.TabIndex = 17
        Me.btnProximo.Text = "Próximo..."
        Me.btnProximo.UseVisualStyleBackColor = False
        '
        'txtRG
        '
        Me.txtRG.BackColor = System.Drawing.Color.White
        Me.txtRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRG.ForeColor = System.Drawing.Color.Black
        Me.txtRG.Location = New System.Drawing.Point(3, 64)
        Me.txtRG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(134, 20)
        Me.txtRG.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 49)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 13)
        Me.Label22.TabIndex = 181
        Me.Label22.Text = "RG / RNE"
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(368, 24)
        Me.txtCPF.Mask = "000.000.000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(92, 20)
        Me.txtCPF.TabIndex = 2
        '
        'cmbAno
        '
        Me.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Items.AddRange(New Object() {"1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.cmbAno.Location = New System.Drawing.Point(77, 146)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(51, 21)
        Me.cmbAno.TabIndex = 8
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbMes.Location = New System.Drawing.Point(41, 146)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(37, 21)
        Me.cmbMes.TabIndex = 7
        '
        'cmbDia
        '
        Me.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDia.FormattingEnabled = True
        Me.cmbDia.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDia.Location = New System.Drawing.Point(5, 146)
        Me.cmbDia.Name = "cmbDia"
        Me.cmbDia.Size = New System.Drawing.Size(37, 21)
        Me.cmbDia.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(476, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 169
        Me.Label14.Text = "Bairro "
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(479, 104)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.ReadOnly = True
        Me.txtBairro.Size = New System.Drawing.Size(244, 20)
        Me.txtBairro.TabIndex = 168
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(371, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 165
        Me.Label12.Text = "CPF*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(727, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Cidade "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(904, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "UF"
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(730, 104)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.ReadOnly = True
        Me.txtCidade.Size = New System.Drawing.Size(230, 20)
        Me.txtCidade.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(482, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "CEP *"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(477, 24)
        Me.txtCep.Mask = "00000-999"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(69, 20)
        Me.txtCep.TabIndex = 12
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 131)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 13)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Data Nascimento"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(370, 89)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 13)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "Celular"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(373, 104)
        Me.txtCelular.Mask = "(99) 9 9999-9999"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(89, 20)
        Me.txtCelular.TabIndex = 10
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(270, 89)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 13)
        Me.Label26.TabIndex = 30
        Me.Label26.Text = "Telefone"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(274, 104)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(92, 20)
        Me.txtTelefone.TabIndex = 9
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(593, 24)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.ReadOnly = True
        Me.txtEndereco.Size = New System.Drawing.Size(367, 20)
        Me.txtEndereco.TabIndex = 28
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(595, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 13)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Endereço "
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(143, 147)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(314, 20)
        Me.txtEmail.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "E-mail"
        '
        'cmbSexo
        '
        Me.cmbSexo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cmbSexo.Location = New System.Drawing.Point(185, 64)
        Me.cmbSexo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(100, 21)
        Me.cmbSexo.TabIndex = 4
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(188, 49)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(40, 13)
        Me.label13.TabIndex = 17
        Me.label13.Text = "Sexo "
        '
        'txtNomeAluno
        '
        Me.txtNomeAluno.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtNomeAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeAluno.ForeColor = System.Drawing.Color.White
        Me.txtNomeAluno.Location = New System.Drawing.Point(3, 24)
        Me.txtNomeAluno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeAluno.Name = "txtNomeAluno"
        Me.txtNomeAluno.Size = New System.Drawing.Size(359, 20)
        Me.txtNomeAluno.TabIndex = 1
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(5, 11)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(87, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Nome Aluno *"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.ImageIndex = 2
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1116, 187)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Informações de Filiação"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btInserirOcupacao)
        Me.GroupBox2.Controls.Add(Me.cmbOcupacaoResp)
        Me.GroupBox2.Controls.Add(Me.cmbOcupacaoMae)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtCelPai)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtCelResp)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtCelMae)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmbOcupacaoPai)
        Me.GroupBox2.Controls.Add(Me.btnVoltar)
        Me.GroupBox2.Controls.Add(Me.txtNomeMae)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtObs)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtNomeResp)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtNomePai)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1050, 167)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'btInserirOcupacao
        '
        Me.btInserirOcupacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btInserirOcupacao.FlatAppearance.BorderSize = 0
        Me.btInserirOcupacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInserirOcupacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInserirOcupacao.Image = Global.MinhaEscola.My.Resources.Resources.Create
        Me.btInserirOcupacao.Location = New System.Drawing.Point(529, 128)
        Me.btInserirOcupacao.Name = "btInserirOcupacao"
        Me.btInserirOcupacao.Size = New System.Drawing.Size(27, 26)
        Me.btInserirOcupacao.TabIndex = 328
        Me.btInserirOcupacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btInserirOcupacao.UseVisualStyleBackColor = True
        '
        'cmbOcupacaoResp
        '
        Me.cmbOcupacaoResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOcupacaoResp.FormattingEnabled = True
        Me.cmbOcupacaoResp.Location = New System.Drawing.Point(314, 101)
        Me.cmbOcupacaoResp.Name = "cmbOcupacaoResp"
        Me.cmbOcupacaoResp.Size = New System.Drawing.Size(255, 21)
        Me.cmbOcupacaoResp.TabIndex = 25
        '
        'cmbOcupacaoMae
        '
        Me.cmbOcupacaoMae.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOcupacaoMae.FormattingEnabled = True
        Me.cmbOcupacaoMae.Location = New System.Drawing.Point(315, 61)
        Me.cmbOcupacaoMae.Name = "cmbOcupacaoMae"
        Me.cmbOcupacaoMae.Size = New System.Drawing.Size(255, 21)
        Me.cmbOcupacaoMae.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(571, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 13)
        Me.Label20.TabIndex = 191
        Me.Label20.Text = "Celular"
        '
        'txtCelPai
        '
        Me.txtCelPai.Location = New System.Drawing.Point(577, 26)
        Me.txtCelPai.Mask = "(99) 9 9999-9999"
        Me.txtCelPai.Name = "txtCelPai"
        Me.txtCelPai.Size = New System.Drawing.Size(89, 20)
        Me.txtCelPai.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(572, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 189
        Me.Label15.Text = "Celular"
        '
        'txtCelResp
        '
        Me.txtCelResp.Location = New System.Drawing.Point(574, 101)
        Me.txtCelResp.Mask = "(99) 9 9999-9999"
        Me.txtCelResp.Name = "txtCelResp"
        Me.txtCelResp.Size = New System.Drawing.Size(89, 20)
        Me.txtCelResp.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(572, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 187
        Me.Label10.Text = "Celular"
        '
        'txtCelMae
        '
        Me.txtCelMae.Location = New System.Drawing.Point(575, 63)
        Me.txtCelMae.Mask = "(99) 9 9999-9999"
        Me.txtCelMae.Name = "txtCelMae"
        Me.txtCelMae.Size = New System.Drawing.Size(89, 20)
        Me.txtCelMae.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(311, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 185
        Me.Label9.Text = "Ocupação *"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(313, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 13)
        Me.Label17.TabIndex = 183
        Me.Label17.Text = "Ocupação *"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(313, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 181
        Me.Label11.Text = "Ocupação *"
        '
        'cmbOcupacaoPai
        '
        Me.cmbOcupacaoPai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOcupacaoPai.FormattingEnabled = True
        Me.cmbOcupacaoPai.Location = New System.Drawing.Point(316, 25)
        Me.cmbOcupacaoPai.Name = "cmbOcupacaoPai"
        Me.cmbOcupacaoPai.Size = New System.Drawing.Size(255, 21)
        Me.cmbOcupacaoPai.TabIndex = 19
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.ForeColor = System.Drawing.Color.White
        Me.btnVoltar.Location = New System.Drawing.Point(919, 135)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(114, 25)
        Me.btnVoltar.TabIndex = 28
        Me.btnVoltar.Text = "Voltar..."
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'txtNomeMae
        '
        Me.txtNomeMae.Location = New System.Drawing.Point(3, 62)
        Me.txtNomeMae.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeMae.Name = "txtNomeMae"
        Me.txtNomeMae.Size = New System.Drawing.Size(305, 20)
        Me.txtNomeMae.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nome da Mãe"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(728, 34)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObs.Size = New System.Drawing.Size(313, 80)
        Me.txtObs.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(727, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Observações"
        '
        'txtNomeResp
        '
        Me.txtNomeResp.Location = New System.Drawing.Point(3, 101)
        Me.txtNomeResp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeResp.Name = "txtNomeResp"
        Me.txtNomeResp.Size = New System.Drawing.Size(305, 20)
        Me.txtNomeResp.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 87)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Responsável"
        '
        'txtNomePai
        '
        Me.txtNomePai.Location = New System.Drawing.Point(3, 25)
        Me.txtNomePai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomePai.Name = "txtNomePai"
        Me.txtNomePai.Size = New System.Drawing.Size(305, 20)
        Me.txtNomePai.TabIndex = 18
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 13)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "Nome do Pai"
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
        Me.Panel2.Size = New System.Drawing.Size(1140, 47)
        Me.Panel2.TabIndex = 36
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(230, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(361, 32)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "CONTROLE DE ALUNOS"
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
        Me.btFechar.Location = New System.Drawing.Point(1039, 7)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(89, 32)
        Me.btFechar.TabIndex = 4
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1006, 582)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 327
        Me.Label7.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(1068, 582)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 326
        Me.lblTotal.Text = "-"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbCPF)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtBuscarNome)
        Me.GroupBox3.Controls.Add(Me.rbNome)
        Me.GroupBox3.Controls.Add(Me.txtBuscarCPF)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(11, 273)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox3.Size = New System.Drawing.Size(433, 45)
        Me.GroupBox3.TabIndex = 325
        Me.GroupBox3.TabStop = False
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.ForeColor = System.Drawing.Color.Black
        Me.rbCPF.Location = New System.Drawing.Point(147, 16)
        Me.rbCPF.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(52, 21)
        Me.rbCPF.TabIndex = 16
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "CPF"
        Me.rbCPF.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Buscar:"
        '
        'txtBuscarNome
        '
        Me.txtBuscarNome.Location = New System.Drawing.Point(222, 17)
        Me.txtBuscarNome.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarNome.Name = "txtBuscarNome"
        Me.txtBuscarNome.Size = New System.Drawing.Size(170, 23)
        Me.txtBuscarNome.TabIndex = 17
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.ForeColor = System.Drawing.Color.Black
        Me.rbNome.Location = New System.Drawing.Point(73, 16)
        Me.rbNome.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(63, 21)
        Me.rbNome.TabIndex = 15
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'txtBuscarCPF
        '
        Me.txtBuscarCPF.Location = New System.Drawing.Point(222, 16)
        Me.txtBuscarCPF.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarCPF.Mask = "999,999,999-99"
        Me.txtBuscarCPF.Name = "txtBuscarCPF"
        Me.txtBuscarCPF.Size = New System.Drawing.Size(170, 23)
        Me.txtBuscarCPF.TabIndex = 18
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(9, 323)
        Me.dg.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(1098, 251)
        Me.dg.TabIndex = 324
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.MinhaEscola.My.Resources.Resources.apagar
        Me.btnExcluir.Location = New System.Drawing.Point(977, 280)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(108, 37)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Deletar"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btSalvarEditar
        '
        Me.btSalvarEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvarEditar.FlatAppearance.BorderSize = 0
        Me.btSalvarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvarEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvarEditar.Image = Global.MinhaEscola.My.Resources.Resources.Notes
        Me.btSalvarEditar.Location = New System.Drawing.Point(847, 275)
        Me.btSalvarEditar.Name = "btSalvarEditar"
        Me.btSalvarEditar.Size = New System.Drawing.Size(124, 45)
        Me.btSalvarEditar.TabIndex = 29
        Me.btSalvarEditar.Text = "Salvar/Editar"
        Me.btSalvarEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvarEditar.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.Image = Global.MinhaEscola.My.Resources.Resources.New_document
        Me.btNovo.Location = New System.Drawing.Point(759, 279)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(82, 34)
        Me.btNovo.TabIndex = 0
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'frmCadastroAlunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1140, 610)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tcAlunos)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btSalvarEditar)
        Me.Controls.Add(Me.btNovo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCadastroAlunos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Alunos"
        Me.tcAlunos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btNovo As Button
    Friend WithEvents btSalvarEditar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btFechar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tcAlunos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents cmbAno As ComboBox
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents cmbDia As ComboBox
    Friend WithEvents btnProximo As Button
    Private WithEvents Label14 As Label
    Private WithEvents txtBairro As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label4 As Label
    Friend WithEvents txtCidade As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents txtCep As MaskedTextBox
    Private WithEvents Label21 As Label
    Private WithEvents Label27 As Label
    Friend WithEvents txtCelular As MaskedTextBox
    Private WithEvents Label26 As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Private WithEvents txtEndereco As TextBox
    Private WithEvents Label25 As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents cmbSexo As ComboBox
    Private WithEvents label13 As Label
    Friend WithEvents txtNomeAluno As TextBox
    Private WithEvents label6 As Label
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents Label17 As Label
    Private WithEvents Label11 As Label
    Friend WithEvents cmbOcupacaoPai As ComboBox
    Private WithEvents txtNomeMae As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents txtObs As TextBox
    Private WithEvents Label16 As Label
    Private WithEvents txtNomeResp As TextBox
    Private WithEvents Label19 As Label
    Private WithEvents txtNomePai As TextBox
    Private WithEvents Label23 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents btConsultaCEP As Button
    Private WithEvents txtNum As TextBox
    Private WithEvents Label24 As Label
    Friend WithEvents txtRG As TextBox
    Private WithEvents Label22 As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Private WithEvents txtCompl As TextBox
    Private WithEvents txtComplemento As TextBox
    Private WithEvents Label28 As Label
    Private WithEvents txtUF As TextBox
    Friend WithEvents btnVoltar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBuscarNome As TextBox
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents txtBuscarCPF As MaskedTextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents pbImagem As PictureBox
    Friend WithEvents btImagem As Button
    Private WithEvents Label20 As Label
    Friend WithEvents txtCelPai As MaskedTextBox
    Private WithEvents Label15 As Label
    Friend WithEvents txtCelResp As MaskedTextBox
    Private WithEvents Label10 As Label
    Friend WithEvents txtCelMae As MaskedTextBox
    Private WithEvents Label9 As Label
    Private WithEvents lblCodigo As Label
    Friend WithEvents btInserirOcupacao As Button
    Friend WithEvents cmbOcupacaoResp As ComboBox
    Friend WithEvents cmbOcupacaoMae As ComboBox
    Private WithEvents cmbEstCivil As ComboBox
    Private WithEvents Label29 As Label
    Private WithEvents Label30 As Label
    Friend WithEvents cmbCursos As ComboBox
End Class
