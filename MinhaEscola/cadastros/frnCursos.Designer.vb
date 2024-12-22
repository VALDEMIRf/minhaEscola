<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnCursos
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btSalvarEditar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Size = New System.Drawing.Size(488, 41)
        Me.Panel2.TabIndex = 38
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(42, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(256, 23)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "CONTROLE DE CURSOS"
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
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(3, 85)
        Me.dg.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(473, 199)
        Me.dg.TabIndex = 327
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(3, 60)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(366, 20)
        Me.txtCurso.TabIndex = 326
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(375, 60)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(99, 20)
        Me.txtValor.TabIndex = 328
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 329
        Me.Label1.Text = "Descrição do Curso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(399, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 330
        Me.Label2.Text = "Valor"
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.MinhaEscola.My.Resources.Resources.apagar
        Me.btnExcluir.Location = New System.Drawing.Point(223, 293)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(108, 37)
        Me.btnExcluir.TabIndex = 332
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
        Me.btSalvarEditar.Location = New System.Drawing.Point(93, 288)
        Me.btSalvarEditar.Name = "btSalvarEditar"
        Me.btSalvarEditar.Size = New System.Drawing.Size(124, 45)
        Me.btSalvarEditar.TabIndex = 333
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
        Me.btNovo.Location = New System.Drawing.Point(5, 292)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(82, 34)
        Me.btNovo.TabIndex = 331
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(441, 305)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 334
        Me.lblTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 335
        Me.Label3.Text = "N° Linhas"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(467, 44)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(13, 13)
        Me.lblCodigo.TabIndex = 336
        Me.lblCodigo.Text = "0"
        '
        'btFechar
        '
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.FlatAppearance.BorderSize = 0
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = Global.MinhaEscola.My.Resources.Resources.back_32
        Me.btFechar.Location = New System.Drawing.Point(375, 3)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(105, 32)
        Me.btFechar.TabIndex = 14
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'frnCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(488, 341)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btSalvarEditar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtCurso)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frnCursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frnCursos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btSalvarEditar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btFechar As Button
End Class
