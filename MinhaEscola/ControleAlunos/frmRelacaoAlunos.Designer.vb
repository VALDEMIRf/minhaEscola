<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelacaoAlunos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPesquisarNomes = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvRelacaoAlunos = New System.Windows.Forms.DataGridView()
        Me.btnVizualizar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CodigoAluno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvRelacaoAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(794, 57)
        Me.Panel2.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(230, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(339, 32)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "RELAÇÃO DE ALUNOS"
        '
        'btFechar
        '
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.FlatAppearance.BorderSize = 0
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = Global.MinhaEscola.My.Resources.Resources.Turn_off
        Me.btFechar.Location = New System.Drawing.Point(12, 63)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(92, 34)
        Me.btFechar.TabIndex = 38
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(0, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 69)
        Me.Panel1.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(122, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(377, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "De maneira fácil e rápida você pode visualizar e verificar a relação dos alunos."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(119, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(234, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Consultar Lista de Todos os Alunos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MinhaEscola.My.Resources.Resources.cadastroalunos
        Me.PictureBox1.Location = New System.Drawing.Point(31, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 60)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPesquisarNomes)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 50)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisa Nomes..."
        '
        'txtPesquisarNomes
        '
        Me.txtPesquisarNomes.Location = New System.Drawing.Point(9, 20)
        Me.txtPesquisarNomes.Name = "txtPesquisarNomes"
        Me.txtPesquisarNomes.Size = New System.Drawing.Size(741, 20)
        Me.txtPesquisarNomes.TabIndex = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvRelacaoAlunos)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(779, 257)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações dos Alunos"
        '
        'dgvRelacaoAlunos
        '
        Me.dgvRelacaoAlunos.AllowUserToAddRows = False
        Me.dgvRelacaoAlunos.AllowUserToDeleteRows = False
        Me.dgvRelacaoAlunos.AllowUserToResizeColumns = False
        Me.dgvRelacaoAlunos.AllowUserToResizeRows = False
        Me.dgvRelacaoAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRelacaoAlunos.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvRelacaoAlunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRelacaoAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRelacaoAlunos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnVizualizar, Me.CodigoAluno})
        Me.dgvRelacaoAlunos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRelacaoAlunos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRelacaoAlunos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRelacaoAlunos.EnableHeadersVisualStyles = False
        Me.dgvRelacaoAlunos.Location = New System.Drawing.Point(3, 16)
        Me.dgvRelacaoAlunos.Name = "dgvRelacaoAlunos"
        Me.dgvRelacaoAlunos.ReadOnly = True
        Me.dgvRelacaoAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRelacaoAlunos.Size = New System.Drawing.Size(773, 238)
        Me.dgvRelacaoAlunos.TabIndex = 11
        '
        'btnVizualizar
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.btnVizualizar.DefaultCellStyle = DataGridViewCellStyle1
        Me.btnVizualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVizualizar.HeaderText = "Opção"
        Me.btnVizualizar.Name = "btnVizualizar"
        Me.btnVizualizar.ReadOnly = True
        Me.btnVizualizar.Text = "Vizualizar"
        Me.btnVizualizar.UseColumnTextForButtonValue = True
        Me.btnVizualizar.Width = 45
        '
        'CodigoAluno
        '
        Me.CodigoAluno.DataPropertyName = "CodigoAluno"
        Me.CodigoAluno.HeaderText = "CodigoAluno"
        Me.CodigoAluno.Name = "CodigoAluno"
        Me.CodigoAluno.ReadOnly = True
        Me.CodigoAluno.Visible = False
        '
        'frmRelacaoAlunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 508)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btFechar)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRelacaoAlunos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRelacaoAlunos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvRelacaoAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents btFechar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPesquisarNomes As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvRelacaoAlunos As DataGridView
    Friend WithEvents btnVizualizar As DataGridViewButtonColumn
    Friend WithEvents CodigoAluno As DataGridViewTextBoxColumn
End Class
