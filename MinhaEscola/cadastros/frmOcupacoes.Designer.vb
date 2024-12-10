<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOcupacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOcupacoes))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtOcupacao = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.lblOcupacao = New System.Windows.Forms.Label()
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Size = New System.Drawing.Size(370, 41)
        Me.Panel2.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(33, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(299, 23)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "CONTROLE DE OCUPAÇÕES"
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
        'txtOcupacao
        '
        Me.txtOcupacao.Location = New System.Drawing.Point(2, 47)
        Me.txtOcupacao.Name = "txtOcupacao"
        Me.txtOcupacao.Size = New System.Drawing.Size(261, 20)
        Me.txtOcupacao.TabIndex = 38
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(2, 68)
        Me.dg.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(261, 199)
        Me.dg.TabIndex = 325
        '
        'btFechar
        '
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.FlatAppearance.BorderSize = 0
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Image = Global.MinhaEscola.My.Resources.Resources._Exit
        Me.btFechar.Location = New System.Drawing.Point(270, 202)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(75, 30)
        Me.btFechar.TabIndex = 330
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'btExcluir
        '
        Me.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExcluir.Enabled = False
        Me.btExcluir.FlatAppearance.BorderSize = 0
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExcluir.Image = Global.MinhaEscola.My.Resources.Resources.Turn_off
        Me.btExcluir.Location = New System.Drawing.Point(270, 163)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(75, 30)
        Me.btExcluir.TabIndex = 329
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
        Me.btEditar.Location = New System.Drawing.Point(270, 124)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(75, 30)
        Me.btEditar.TabIndex = 328
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
        Me.btSalvar.Location = New System.Drawing.Point(270, 86)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 30)
        Me.btSalvar.TabIndex = 327
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
        Me.btNovo.Location = New System.Drawing.Point(270, 50)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(75, 30)
        Me.btNovo.TabIndex = 326
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'lblOcupacao
        '
        Me.lblOcupacao.AutoSize = True
        Me.lblOcupacao.Location = New System.Drawing.Point(267, 42)
        Me.lblOcupacao.Name = "lblOcupacao"
        Me.lblOcupacao.Size = New System.Drawing.Size(13, 13)
        Me.lblOcupacao.TabIndex = 331
        Me.lblOcupacao.Text = "0"
        Me.lblOcupacao.Visible = False
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(156, 272)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 20)
        Me.Label7.TabIndex = 333
        Me.Label7.Text = "Total de linhas:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(279, 272)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 332
        Me.lblTotal.Text = "-"
        '
        'frmOcupacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(370, 299)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblOcupacao)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtOcupacao)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOcupacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOcupacoes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtOcupacao As TextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents btNovo As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btExcluir As Button
    Friend WithEvents btFechar As Button
    Friend WithEvents lblOcupacao As Label
    Friend WithEvents errErro As ErrorProvider
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
End Class
