<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCursosHorarios
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbProfSabado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbProfSexta = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbProfQuinta = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbProfQuarta = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbProfTerca = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbProfSegunda = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbSabado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSexta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbQuinta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbQuarta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTerca = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSegunda = New System.Windows.Forms.ComboBox()
        Me.chkFolga = New System.Windows.Forms.CheckBox()
        Me.mskHoras = New System.Windows.Forms.MaskedTextBox()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tcCursosHorarios = New System.Windows.Forms.TabControl()
        Me.cadastro = New System.Windows.Forms.TabPage()
        Me.lista = New System.Windows.Forms.TabPage()
        Me.dgNoite = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgTarde = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgManha = New System.Windows.Forms.DataGridView()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btSalvarEditar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btVisualizar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnHorarioCompletoDaManha = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHorarioCompletoDaTarde = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHorarioCompletoDaNoite = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcCursosHorarios.SuspendLayout()
        Me.cadastro.SuspendLayout()
        Me.lista.SuspendLayout()
        CType(Me.dgNoite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.dgTarde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgManha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(769, 47)
        Me.Panel2.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(68, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(523, 28)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "CADASTRO DE CURSOS X HORARÁRIOS"
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
        Me.btFechar.Location = New System.Drawing.Point(648, 7)
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
        Me.Label7.Location = New System.Drawing.Point(252, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Professor(a)"
        '
        'cmbProfSabado
        '
        Me.cmbProfSabado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfSabado.DropDownWidth = 220
        Me.cmbProfSabado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProfSabado.FormattingEnabled = True
        Me.cmbProfSabado.Location = New System.Drawing.Point(252, 242)
        Me.cmbProfSabado.MaxDropDownItems = 15
        Me.cmbProfSabado.Name = "cmbProfSabado"
        Me.cmbProfSabado.Size = New System.Drawing.Size(214, 24)
        Me.cmbProfSabado.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Professor(a)"
        '
        'cmbProfSexta
        '
        Me.cmbProfSexta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfSexta.DropDownWidth = 220
        Me.cmbProfSexta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProfSexta.FormattingEnabled = True
        Me.cmbProfSexta.Location = New System.Drawing.Point(255, 199)
        Me.cmbProfSexta.MaxDropDownItems = 15
        Me.cmbProfSexta.Name = "cmbProfSexta"
        Me.cmbProfSexta.Size = New System.Drawing.Size(214, 24)
        Me.cmbProfSexta.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(255, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Professor(a)"
        '
        'cmbProfQuinta
        '
        Me.cmbProfQuinta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfQuinta.DropDownWidth = 220
        Me.cmbProfQuinta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProfQuinta.FormattingEnabled = True
        Me.cmbProfQuinta.Location = New System.Drawing.Point(255, 153)
        Me.cmbProfQuinta.MaxDropDownItems = 15
        Me.cmbProfQuinta.Name = "cmbProfQuinta"
        Me.cmbProfQuinta.Size = New System.Drawing.Size(214, 24)
        Me.cmbProfQuinta.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Professor(a)"
        '
        'cmbProfQuarta
        '
        Me.cmbProfQuarta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfQuarta.DropDownWidth = 220
        Me.cmbProfQuarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProfQuarta.FormattingEnabled = True
        Me.cmbProfQuarta.Location = New System.Drawing.Point(255, 110)
        Me.cmbProfQuarta.MaxDropDownItems = 15
        Me.cmbProfQuarta.Name = "cmbProfQuarta"
        Me.cmbProfQuarta.Size = New System.Drawing.Size(214, 24)
        Me.cmbProfQuarta.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(255, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 16)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Professor(a)"
        '
        'cmbProfTerca
        '
        Me.cmbProfTerca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfTerca.DropDownWidth = 220
        Me.cmbProfTerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProfTerca.FormattingEnabled = True
        Me.cmbProfTerca.Location = New System.Drawing.Point(255, 67)
        Me.cmbProfTerca.MaxDropDownItems = 15
        Me.cmbProfTerca.Name = "cmbProfTerca"
        Me.cmbProfTerca.Size = New System.Drawing.Size(214, 24)
        Me.cmbProfTerca.TabIndex = 52
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(255, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 16)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Professor(a)"
        '
        'cmbProfSegunda
        '
        Me.cmbProfSegunda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfSegunda.DropDownWidth = 220
        Me.cmbProfSegunda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProfSegunda.FormattingEnabled = True
        Me.cmbProfSegunda.Location = New System.Drawing.Point(255, 24)
        Me.cmbProfSegunda.MaxDropDownItems = 15
        Me.cmbProfSegunda.Name = "cmbProfSegunda"
        Me.cmbProfSegunda.Size = New System.Drawing.Size(214, 24)
        Me.cmbProfSegunda.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Sábado"
        '
        'cmbSabado
        '
        Me.cmbSabado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSabado.DropDownWidth = 220
        Me.cmbSabado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSabado.FormattingEnabled = True
        Me.cmbSabado.Location = New System.Drawing.Point(6, 242)
        Me.cmbSabado.MaxDropDownItems = 15
        Me.cmbSabado.Name = "cmbSabado"
        Me.cmbSabado.Size = New System.Drawing.Size(214, 24)
        Me.cmbSabado.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Sexta-Feira"
        '
        'cmbSexta
        '
        Me.cmbSexta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexta.DropDownWidth = 220
        Me.cmbSexta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSexta.FormattingEnabled = True
        Me.cmbSexta.Location = New System.Drawing.Point(6, 199)
        Me.cmbSexta.MaxDropDownItems = 15
        Me.cmbSexta.Name = "cmbSexta"
        Me.cmbSexta.Size = New System.Drawing.Size(214, 24)
        Me.cmbSexta.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Quinta-Feira"
        '
        'cmbQuinta
        '
        Me.cmbQuinta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuinta.DropDownWidth = 220
        Me.cmbQuinta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbQuinta.FormattingEnabled = True
        Me.cmbQuinta.Location = New System.Drawing.Point(6, 153)
        Me.cmbQuinta.MaxDropDownItems = 15
        Me.cmbQuinta.Name = "cmbQuinta"
        Me.cmbQuinta.Size = New System.Drawing.Size(214, 24)
        Me.cmbQuinta.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Quarta-Feira"
        '
        'cmbQuarta
        '
        Me.cmbQuarta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuarta.DropDownWidth = 220
        Me.cmbQuarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbQuarta.FormattingEnabled = True
        Me.cmbQuarta.Location = New System.Drawing.Point(6, 110)
        Me.cmbQuarta.MaxDropDownItems = 15
        Me.cmbQuarta.Name = "cmbQuarta"
        Me.cmbQuarta.Size = New System.Drawing.Size(214, 24)
        Me.cmbQuarta.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Terça-Feira"
        '
        'cmbTerca
        '
        Me.cmbTerca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTerca.DropDownWidth = 220
        Me.cmbTerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTerca.FormattingEnabled = True
        Me.cmbTerca.Location = New System.Drawing.Point(6, 67)
        Me.cmbTerca.MaxDropDownItems = 15
        Me.cmbTerca.Name = "cmbTerca"
        Me.cmbTerca.Size = New System.Drawing.Size(214, 24)
        Me.cmbTerca.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Segunda-Feira"
        '
        'cmbSegunda
        '
        Me.cmbSegunda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSegunda.DropDownWidth = 220
        Me.cmbSegunda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSegunda.FormattingEnabled = True
        Me.cmbSegunda.Location = New System.Drawing.Point(6, 24)
        Me.cmbSegunda.MaxDropDownItems = 15
        Me.cmbSegunda.Name = "cmbSegunda"
        Me.cmbSegunda.Size = New System.Drawing.Size(214, 24)
        Me.cmbSegunda.TabIndex = 38
        '
        'chkFolga
        '
        Me.chkFolga.AutoSize = True
        Me.chkFolga.Location = New System.Drawing.Point(3, 332)
        Me.chkFolga.Name = "chkFolga"
        Me.chkFolga.Size = New System.Drawing.Size(325, 20)
        Me.chkFolga.TabIndex = 177
        Me.chkFolga.Text = "Cursos no Sábado? Se ""Sim"" marque está opção!"
        Me.chkFolga.UseVisualStyleBackColor = True
        '
        'mskHoras
        '
        Me.mskHoras.Location = New System.Drawing.Point(162, 295)
        Me.mskHoras.Mask = "99:99"
        Me.mskHoras.Name = "mskHoras"
        Me.mskHoras.Size = New System.Drawing.Size(100, 22)
        Me.mskHoras.TabIndex = 182
        Me.mskHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriodo.DropDownWidth = 220
        Me.cmbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite"})
        Me.cmbPeriodo.Location = New System.Drawing.Point(3, 293)
        Me.cmbPeriodo.MaxDropDownItems = 15
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(141, 24)
        Me.cmbPeriodo.TabIndex = 184
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(160, 275)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 16)
        Me.Label13.TabIndex = 181
        Me.Label13.Text = "Horário da Aula"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 275)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 185
        Me.Label15.Text = "Período"
        '
        'tcCursosHorarios
        '
        Me.tcCursosHorarios.Controls.Add(Me.cadastro)
        Me.tcCursosHorarios.Controls.Add(Me.lista)
        Me.tcCursosHorarios.Location = New System.Drawing.Point(4, 90)
        Me.tcCursosHorarios.Name = "tcCursosHorarios"
        Me.tcCursosHorarios.SelectedIndex = 0
        Me.tcCursosHorarios.Size = New System.Drawing.Size(753, 458)
        Me.tcCursosHorarios.TabIndex = 329
        '
        'cadastro
        '
        Me.cadastro.BackColor = System.Drawing.Color.Silver
        Me.cadastro.Controls.Add(Me.cmbSegunda)
        Me.cadastro.Controls.Add(Me.Label1)
        Me.cadastro.Controls.Add(Me.Label15)
        Me.cadastro.Controls.Add(Me.cmbTerca)
        Me.cadastro.Controls.Add(Me.cmbPeriodo)
        Me.cadastro.Controls.Add(Me.Label2)
        Me.cadastro.Controls.Add(Me.Label13)
        Me.cadastro.Controls.Add(Me.cmbQuarta)
        Me.cadastro.Controls.Add(Me.mskHoras)
        Me.cadastro.Controls.Add(Me.Label3)
        Me.cadastro.Controls.Add(Me.chkFolga)
        Me.cadastro.Controls.Add(Me.cmbQuinta)
        Me.cadastro.Controls.Add(Me.Label4)
        Me.cadastro.Controls.Add(Me.Label7)
        Me.cadastro.Controls.Add(Me.cmbProfSegunda)
        Me.cadastro.Controls.Add(Me.cmbProfSabado)
        Me.cadastro.Controls.Add(Me.Label12)
        Me.cadastro.Controls.Add(Me.Label8)
        Me.cadastro.Controls.Add(Me.cmbProfTerca)
        Me.cadastro.Controls.Add(Me.cmbProfSexta)
        Me.cadastro.Controls.Add(Me.Label11)
        Me.cadastro.Controls.Add(Me.Label6)
        Me.cadastro.Controls.Add(Me.Label9)
        Me.cadastro.Controls.Add(Me.cmbSabado)
        Me.cadastro.Controls.Add(Me.cmbProfQuarta)
        Me.cadastro.Controls.Add(Me.Label5)
        Me.cadastro.Controls.Add(Me.cmbSexta)
        Me.cadastro.Controls.Add(Me.cmbProfQuinta)
        Me.cadastro.Controls.Add(Me.Label10)
        Me.cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadastro.Location = New System.Drawing.Point(4, 22)
        Me.cadastro.Name = "cadastro"
        Me.cadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.cadastro.Size = New System.Drawing.Size(745, 432)
        Me.cadastro.TabIndex = 0
        Me.cadastro.Text = "Cadastro"
        '
        'lista
        '
        Me.lista.BackColor = System.Drawing.Color.Silver
        Me.lista.Controls.Add(Me.dgNoite)
        Me.lista.Controls.Add(Me.Panel4)
        Me.lista.Controls.Add(Me.dgTarde)
        Me.lista.Controls.Add(Me.Panel3)
        Me.lista.Controls.Add(Me.Panel1)
        Me.lista.Controls.Add(Me.dgManha)
        Me.lista.Location = New System.Drawing.Point(4, 22)
        Me.lista.Name = "lista"
        Me.lista.Padding = New System.Windows.Forms.Padding(3)
        Me.lista.Size = New System.Drawing.Size(745, 432)
        Me.lista.TabIndex = 1
        Me.lista.Text = "Lista de Aulas"
        '
        'dgNoite
        '
        Me.dgNoite.AllowUserToAddRows = False
        Me.dgNoite.AllowUserToDeleteRows = False
        Me.dgNoite.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgNoite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgNoite.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgNoite.Location = New System.Drawing.Point(3, 318)
        Me.dgNoite.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgNoite.Name = "dgNoite"
        Me.dgNoite.ReadOnly = True
        Me.dgNoite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgNoite.Size = New System.Drawing.Size(742, 110)
        Me.dgNoite.TabIndex = 333
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Crimson
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Location = New System.Drawing.Point(3, 288)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(974, 29)
        Me.Panel4.TabIndex = 332
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(311, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 18)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Noite"
        '
        'dgTarde
        '
        Me.dgTarde.AllowUserToAddRows = False
        Me.dgTarde.AllowUserToDeleteRows = False
        Me.dgTarde.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgTarde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTarde.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgTarde.Location = New System.Drawing.Point(3, 177)
        Me.dgTarde.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgTarde.Name = "dgTarde"
        Me.dgTarde.ReadOnly = True
        Me.dgTarde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTarde.Size = New System.Drawing.Size(742, 110)
        Me.dgTarde.TabIndex = 331
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Orange
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(3, 145)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(974, 32)
        Me.Panel3.TabIndex = 330
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(311, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Tarde"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 29)
        Me.Panel1.TabIndex = 329
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(311, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Manhã"
        '
        'dgManha
        '
        Me.dgManha.AllowUserToAddRows = False
        Me.dgManha.AllowUserToDeleteRows = False
        Me.dgManha.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgManha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgManha.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgManha.Location = New System.Drawing.Point(3, 34)
        Me.dgManha.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgManha.Name = "dgManha"
        Me.dgManha.ReadOnly = True
        Me.dgManha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgManha.Size = New System.Drawing.Size(742, 110)
        Me.dgManha.TabIndex = 328
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.MinhaEscola.My.Resources.Resources.Turn_off
        Me.btnExcluir.Location = New System.Drawing.Point(225, 53)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(97, 34)
        Me.btnExcluir.TabIndex = 331
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
        Me.btSalvarEditar.Location = New System.Drawing.Point(95, 49)
        Me.btSalvarEditar.Name = "btSalvarEditar"
        Me.btSalvarEditar.Size = New System.Drawing.Size(124, 45)
        Me.btSalvarEditar.TabIndex = 332
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
        Me.btNovo.Location = New System.Drawing.Point(7, 53)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(82, 34)
        Me.btNovo.TabIndex = 330
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btVisualizar})
        Me.ToolStrip1.Location = New System.Drawing.Point(345, 53)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(97, 25)
        Me.ToolStrip1.TabIndex = 333
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btVisualizar
        '
        Me.btVisualizar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHorarioCompletoDaManha, Me.btnHorarioCompletoDaTarde, Me.btnHorarioCompletoDaNoite})
        Me.btVisualizar.Image = Global.MinhaEscola.My.Resources.Resources.dados
        Me.btVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btVisualizar.Name = "btVisualizar"
        Me.btVisualizar.Size = New System.Drawing.Size(85, 22)
        Me.btVisualizar.Text = "&Visualizar"
        '
        'btnHorarioCompletoDaManha
        '
        Me.btnHorarioCompletoDaManha.Name = "btnHorarioCompletoDaManha"
        Me.btnHorarioCompletoDaManha.Size = New System.Drawing.Size(231, 22)
        Me.btnHorarioCompletoDaManha.Text = "Horários Completo da Manhã"
        '
        'btnHorarioCompletoDaTarde
        '
        Me.btnHorarioCompletoDaTarde.Name = "btnHorarioCompletoDaTarde"
        Me.btnHorarioCompletoDaTarde.Size = New System.Drawing.Size(231, 22)
        Me.btnHorarioCompletoDaTarde.Text = "Horários Completo da Tarde"
        '
        'btnHorarioCompletoDaNoite
        '
        Me.btnHorarioCompletoDaNoite.Name = "btnHorarioCompletoDaNoite"
        Me.btnHorarioCompletoDaNoite.Size = New System.Drawing.Size(231, 22)
        Me.btnHorarioCompletoDaNoite.Text = "Horários Completo da Noite"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(481, 53)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(14, 13)
        Me.lblCodigo.TabIndex = 334
        Me.lblCodigo.Text = "0"
        '
        'frmCursosHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(769, 560)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btSalvarEditar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.tcCursosHorarios)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCursosHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCursosHorarios"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcCursosHorarios.ResumeLayout(False)
        Me.cadastro.ResumeLayout(False)
        Me.cadastro.PerformLayout()
        Me.lista.ResumeLayout(False)
        CType(Me.dgNoite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgTarde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgManha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btFechar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbProfSabado As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbProfSexta As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbProfQuinta As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbProfQuarta As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbProfTerca As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbProfSegunda As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbSabado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSexta As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbQuinta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbQuarta As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTerca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSegunda As ComboBox
    Friend WithEvents chkFolga As CheckBox
    Friend WithEvents mskHoras As MaskedTextBox
    Friend WithEvents cmbPeriodo As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tcCursosHorarios As TabControl
    Friend WithEvents cadastro As TabPage
    Friend WithEvents lista As TabPage
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btSalvarEditar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btVisualizar As ToolStripDropDownButton
    Friend WithEvents btnHorarioCompletoDaManha As ToolStripMenuItem
    Friend WithEvents btnHorarioCompletoDaTarde As ToolStripMenuItem
    Friend WithEvents btnHorarioCompletoDaNoite As ToolStripMenuItem
    Friend WithEvents dgManha As DataGridView
    Private WithEvents lblCodigo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents dgTarde As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents dgNoite As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label17 As Label
End Class
