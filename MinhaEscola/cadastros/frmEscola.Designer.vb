<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscola
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEscola))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtAbertura = New System.Windows.Forms.TextBox()
        Me.txtTelContato = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.btBuscarEmpresa = New System.Windows.Forms.Button()
        Me.txtContato = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSituacao = New System.Windows.Forms.TextBox()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.txtFantasia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.btFechar)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(459, 41)
        Me.Panel2.TabIndex = 40
        '
        'btFechar
        '
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.FlatAppearance.BorderSize = 0
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = Global.MinhaEscola.My.Resources.Resources.back_32
        Me.btFechar.Location = New System.Drawing.Point(347, 3)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(105, 32)
        Me.btFechar.TabIndex = 14
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(42, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(257, 23)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "CADASTRO DA ESCOLA"
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
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(267, 50)
        Me.Label27.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(50, 13)
        Me.Label27.TabIndex = 249
        Me.Label27.Text = "Abertura:"
        '
        'txtAbertura
        '
        Me.txtAbertura.Enabled = False
        Me.txtAbertura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbertura.ForeColor = System.Drawing.Color.Black
        Me.txtAbertura.Location = New System.Drawing.Point(319, 45)
        Me.txtAbertura.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtAbertura.Name = "txtAbertura"
        Me.txtAbertura.ReadOnly = True
        Me.txtAbertura.Size = New System.Drawing.Size(122, 21)
        Me.txtAbertura.TabIndex = 248
        '
        'txtTelContato
        '
        Me.txtTelContato.ForeColor = System.Drawing.Color.Black
        Me.txtTelContato.Location = New System.Drawing.Point(239, 310)
        Me.txtTelContato.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelContato.Mask = "(99) 00000-0000"
        Me.txtTelContato.Name = "txtTelContato"
        Me.txtTelContato.Size = New System.Drawing.Size(91, 20)
        Me.txtTelContato.TabIndex = 247
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(209, 314)
        Me.Label19.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 246
        Me.Label19.Text = "Tel.:"
        '
        'txtCNPJ
        '
        Me.txtCNPJ.ForeColor = System.Drawing.Color.Black
        Me.txtCNPJ.Location = New System.Drawing.Point(60, 45)
        Me.txtCNPJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCNPJ.Mask = "##.###.###/####-##"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(125, 20)
        Me.txtCNPJ.TabIndex = 223
        Me.txtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btBuscarEmpresa
        '
        Me.btBuscarEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.btBuscarEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscarEmpresa.FlatAppearance.BorderSize = 0
        Me.btBuscarEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btBuscarEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscarEmpresa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscarEmpresa.ForeColor = System.Drawing.Color.Black
        Me.btBuscarEmpresa.Image = CType(resources.GetObject("btBuscarEmpresa.Image"), System.Drawing.Image)
        Me.btBuscarEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBuscarEmpresa.Location = New System.Drawing.Point(190, 41)
        Me.btBuscarEmpresa.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btBuscarEmpresa.Name = "btBuscarEmpresa"
        Me.btBuscarEmpresa.Size = New System.Drawing.Size(35, 27)
        Me.btBuscarEmpresa.TabIndex = 238
        Me.btBuscarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBuscarEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBuscarEmpresa.UseVisualStyleBackColor = False
        '
        'txtContato
        '
        Me.txtContato.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContato.ForeColor = System.Drawing.Color.Black
        Me.txtContato.Location = New System.Drawing.Point(60, 310)
        Me.txtContato.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(148, 21)
        Me.txtContato.TabIndex = 245
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 225
        Me.Label4.Text = "CNPJ:"
        '
        'txtMotivo
        '
        Me.txtMotivo.Enabled = False
        Me.txtMotivo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivo.ForeColor = System.Drawing.Color.Black
        Me.txtMotivo.Location = New System.Drawing.Point(60, 286)
        Me.txtMotivo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(387, 21)
        Me.txtMotivo.TabIndex = 241
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(15, 291)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "Motivo:"
        '
        'txtSituacao
        '
        Me.txtSituacao.Enabled = False
        Me.txtSituacao.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSituacao.ForeColor = System.Drawing.Color.Black
        Me.txtSituacao.Location = New System.Drawing.Point(303, 213)
        Me.txtSituacao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(144, 21)
        Me.txtSituacao.TabIndex = 244
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.Enabled = False
        Me.txtRazaoSocial.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazaoSocial.ForeColor = System.Drawing.Color.Black
        Me.txtRazaoSocial.Location = New System.Drawing.Point(60, 69)
        Me.txtRazaoSocial.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.ReadOnly = True
        Me.txtRazaoSocial.Size = New System.Drawing.Size(386, 21)
        Me.txtRazaoSocial.TabIndex = 215
        '
        'txtFantasia
        '
        Me.txtFantasia.Enabled = False
        Me.txtFantasia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFantasia.ForeColor = System.Drawing.Color.Black
        Me.txtFantasia.Location = New System.Drawing.Point(60, 91)
        Me.txtFantasia.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.ReadOnly = True
        Me.txtFantasia.Size = New System.Drawing.Size(386, 21)
        Me.txtFantasia.TabIndex = 227
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(252, 217)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 243
        Me.Label9.Text = "Situacao:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(10, 318)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 237
        Me.Label11.Text = "Contato:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(35, 142)
        Me.Label13.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 13)
        Me.Label13.TabIndex = 231
        Me.Label13.Text = "N°:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.ForeColor = System.Drawing.Color.Black
        Me.txtEndereco.Location = New System.Drawing.Point(60, 114)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.ReadOnly = True
        Me.txtEndereco.Size = New System.Drawing.Size(387, 21)
        Me.txtEndereco.TabIndex = 217
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(3, 120)
        Me.Label12.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 226
        Me.Label12.Text = "Endereço:"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.Black
        Me.txtNumero.Location = New System.Drawing.Point(60, 137)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(50, 21)
        Me.txtNumero.TabIndex = 218
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(11, 95)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 228
        Me.Label7.Text = "Fantasia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 224
        Me.Label2.Text = "Nome:"
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.ForeColor = System.Drawing.Color.Black
        Me.txtTel.Location = New System.Drawing.Point(60, 237)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(285, 21)
        Me.txtTel.TabIndex = 240
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(114, 142)
        Me.Label14.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 232
        Me.Label14.Text = "Compl.:"
        '
        'txtCompl
        '
        Me.txtCompl.Enabled = False
        Me.txtCompl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompl.ForeColor = System.Drawing.Color.Black
        Me.txtCompl.Location = New System.Drawing.Point(157, 138)
        Me.txtCompl.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.ReadOnly = True
        Me.txtCompl.Size = New System.Drawing.Size(130, 21)
        Me.txtCompl.TabIndex = 219
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.ForeColor = System.Drawing.Color.Black
        Me.txtBairro.Location = New System.Drawing.Point(60, 166)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(386, 21)
        Me.txtBairro.TabIndex = 220
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 217)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 235
        Me.Label1.Text = "UF:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(16, 170)
        Me.Label16.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 234
        Me.Label16.Text = "Bairro:"
        '
        'txtCEP
        '
        Me.txtCEP.Enabled = False
        Me.txtCEP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCEP.ForeColor = System.Drawing.Color.Black
        Me.txtCEP.Location = New System.Drawing.Point(160, 214)
        Me.txtCEP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(89, 21)
        Me.txtCEP.TabIndex = 239
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(11, 196)
        Me.Label15.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 233
        Me.Label15.Text = "Cidade:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(126, 217)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 236
        Me.Label17.Text = "CEP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 267)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 230
        Me.Label5.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(60, 261)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(384, 21)
        Me.txtEmail.TabIndex = 216
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.ForeColor = System.Drawing.Color.Black
        Me.txtCidade.Location = New System.Drawing.Point(60, 192)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(386, 21)
        Me.txtCidade.TabIndex = 221
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 229
        Me.Label6.Text = "Telefone:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplemento.ForeColor = System.Drawing.Color.Black
        Me.txtComplemento.Location = New System.Drawing.Point(293, 137)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.ReadOnly = True
        Me.txtComplemento.Size = New System.Drawing.Size(154, 21)
        Me.txtComplemento.TabIndex = 250
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.Location = New System.Drawing.Point(60, 213)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(58, 20)
        Me.txtUF.TabIndex = 251
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(6, 340)
        Me.dg.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(445, 136)
        Me.dg.TabIndex = 252
        '
        'btSalvar
        '
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Image = Global.MinhaEscola.My.Resources.Resources.Apply
        Me.btSalvar.Location = New System.Drawing.Point(353, 307)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(90, 30)
        Me.btSalvar.TabIndex = 346
        Me.btSalvar.Text = "Gravar"
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'frmEscola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(459, 482)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtUF)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtAbertura)
        Me.Controls.Add(Me.txtTelContato)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCNPJ)
        Me.Controls.Add(Me.btBuscarEmpresa)
        Me.Controls.Add(Me.txtContato)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSituacao)
        Me.Controls.Add(Me.txtRazaoSocial)
        Me.Controls.Add(Me.txtFantasia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCompl)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCEP)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEscola"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEscola"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btFechar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtAbertura As TextBox
    Friend WithEvents txtTelContato As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCNPJ As MaskedTextBox
    Friend WithEvents btBuscarEmpresa As Button
    Friend WithEvents txtContato As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSituacao As TextBox
    Friend WithEvents txtRazaoSocial As TextBox
    Friend WithEvents txtFantasia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCompl As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents txtUF As TextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents btSalvar As Button
    Friend WithEvents errErro As ErrorProvider
End Class
