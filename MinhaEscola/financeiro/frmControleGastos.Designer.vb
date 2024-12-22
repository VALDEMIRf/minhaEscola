<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControleGastos
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
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControleGastos))
        Dim Label3 As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbTipoGasto = New System.Windows.Forms.ComboBox()
        Me.txtUsuarioLogado = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.calendario = New System.Windows.Forms.MonthCalendar()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btTipoGasto = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        UsuarioLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.Location = New System.Drawing.Point(3, 50)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(136, 13)
        UsuarioLabel.TabIndex = 40
        UsuarioLabel.Text = "Nome Usuário Logado "
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(610, 55)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 43
        ValorLabel.Text = "Valor "
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(442, 106)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(97, 13)
        Label1.TabIndex = 47
        Label1.Text = "Informe a data "
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(3, 104)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(81, 13)
        Label2.TabIndex = 49
        Label2.Text = "Observações"
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
        Me.Panel2.Size = New System.Drawing.Size(683, 41)
        Me.Panel2.TabIndex = 39
        '
        'btFechar
        '
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.FlatAppearance.BorderSize = 0
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = Global.MinhaEscola.My.Resources.Resources.back_32
        Me.btFechar.Location = New System.Drawing.Point(564, 5)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(105, 32)
        Me.btFechar.TabIndex = 11
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
        Me.Label18.Size = New System.Drawing.Size(240, 23)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "CONTROLE DE Gastos"
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
        'cmbTipoGasto
        '
        Me.cmbTipoGasto.BackColor = System.Drawing.SystemColors.Control
        Me.cmbTipoGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoGasto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoGasto.FormattingEnabled = True
        Me.cmbTipoGasto.Location = New System.Drawing.Point(289, 68)
        Me.cmbTipoGasto.Name = "cmbTipoGasto"
        Me.cmbTipoGasto.Size = New System.Drawing.Size(241, 21)
        Me.cmbTipoGasto.TabIndex = 3
        '
        'txtUsuarioLogado
        '
        Me.txtUsuarioLogado.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtUsuarioLogado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioLogado.ForeColor = System.Drawing.Color.White
        Me.txtUsuarioLogado.Location = New System.Drawing.Point(3, 66)
        Me.txtUsuarioLogado.Multiline = True
        Me.txtUsuarioLogado.Name = "txtUsuarioLogado"
        Me.txtUsuarioLogado.ReadOnly = True
        Me.txtUsuarioLogado.Size = New System.Drawing.Size(279, 25)
        Me.txtUsuarioLogado.TabIndex = 2
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.ForeColor = System.Drawing.Color.Red
        Me.txtValor.Location = New System.Drawing.Point(611, 69)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(50, 21)
        Me.txtValor.TabIndex = 5
        Me.txtValor.Text = "0,00"
        '
        'calendario
        '
        Me.calendario.Location = New System.Drawing.Point(442, 123)
        Me.calendario.Name = "calendario"
        Me.calendario.TabIndex = 7
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(3, 121)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(429, 162)
        Me.txtObs.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(526, 486)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 20)
        Me.Label7.TabIndex = 350
        Me.Label7.Text = "Total de linhas:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(649, 486)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 349
        Me.lblTotal.Text = "-"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(638, 95)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(13, 13)
        Me.lblCodigo.TabIndex = 348
        Me.lblCodigo.Text = "0"
        Me.lblCodigo.Visible = False
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(3, 321)
        Me.dg.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(668, 165)
        Me.dg.TabIndex = 351
        '
        'btTipoGasto
        '
        Me.btTipoGasto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btTipoGasto.Enabled = False
        Me.btTipoGasto.FlatAppearance.BorderSize = 0
        Me.btTipoGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTipoGasto.Image = Global.MinhaEscola.My.Resources.Resources.Create
        Me.btTipoGasto.Location = New System.Drawing.Point(533, 63)
        Me.btTipoGasto.Name = "btTipoGasto"
        Me.btTipoGasto.Size = New System.Drawing.Size(31, 32)
        Me.btTipoGasto.TabIndex = 4
        Me.btTipoGasto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btTipoGasto.UseVisualStyleBackColor = True
        '
        'btExcluir
        '
        Me.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExcluir.Enabled = False
        Me.btExcluir.FlatAppearance.BorderSize = 0
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExcluir.Image = Global.MinhaEscola.My.Resources.Resources.Turn_off
        Me.btExcluir.Location = New System.Drawing.Point(251, 288)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(75, 30)
        Me.btExcluir.TabIndex = 10
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btExcluir.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEditar.Enabled = False
        Me.btEditar.FlatAppearance.BorderSize = 0
        Me.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEditar.Image = Global.MinhaEscola.My.Resources.Resources.Notes
        Me.btEditar.Location = New System.Drawing.Point(167, 288)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(75, 30)
        Me.btEditar.TabIndex = 9
        Me.btEditar.Text = "Editar"
        Me.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btSalvar
        '
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.Enabled = False
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Image = Global.MinhaEscola.My.Resources.Resources.Apply
        Me.btSalvar.Location = New System.Drawing.Point(81, 288)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 30)
        Me.btSalvar.TabIndex = 8
        Me.btSalvar.Text = "Gravar"
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(5, 290)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(75, 30)
        Me.btNovo.TabIndex = 1
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Red
        Label3.Location = New System.Drawing.Point(584, 71)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(28, 17)
        Label3.TabIndex = 352
        Label3.Text = "R$"
        '
        'frmControleGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(683, 515)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.btTipoGasto)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.calendario)
        Me.Controls.Add(Me.cmbTipoGasto)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.txtUsuarioLogado)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmControleGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmControleGastos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btFechar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbTipoGasto As ComboBox
    Friend WithEvents txtUsuarioLogado As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents calendario As MonthCalendar
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btExcluir As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents btTipoGasto As Button
End Class
