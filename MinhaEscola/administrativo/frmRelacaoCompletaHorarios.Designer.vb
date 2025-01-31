<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelacaoCompletaHorarios
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvRelacaoCursosHorarios = New System.Windows.Forms.DataGridView()
        Me.dgvRelacaoCursosHorariosProfessores = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvRelacaoCursosHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRelacaoCursosHorariosProfessores, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Size = New System.Drawing.Size(956, 47)
        Me.Panel2.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(169, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(511, 28)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "RELAÇÃO DE CURSOS E PROFESSORES"
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
        Me.btFechar.Location = New System.Drawing.Point(851, 7)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(89, 32)
        Me.btFechar.TabIndex = 4
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(422, 6)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(96, 31)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Manhã"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Location = New System.Drawing.Point(3, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 40)
        Me.Panel1.TabIndex = 40
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(3, 272)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(950, 40)
        Me.Panel3.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(396, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Professores"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(432, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Manhã"
        '
        'dgvRelacaoCursosHorarios
        '
        Me.dgvRelacaoCursosHorarios.AllowUserToAddRows = False
        Me.dgvRelacaoCursosHorarios.AllowUserToDeleteRows = False
        Me.dgvRelacaoCursosHorarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvRelacaoCursosHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRelacaoCursosHorarios.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgvRelacaoCursosHorarios.Location = New System.Drawing.Point(3, 91)
        Me.dgvRelacaoCursosHorarios.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgvRelacaoCursosHorarios.Name = "dgvRelacaoCursosHorarios"
        Me.dgvRelacaoCursosHorarios.ReadOnly = True
        Me.dgvRelacaoCursosHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRelacaoCursosHorarios.Size = New System.Drawing.Size(950, 180)
        Me.dgvRelacaoCursosHorarios.TabIndex = 326
        '
        'dgvRelacaoCursosHorariosProfessores
        '
        Me.dgvRelacaoCursosHorariosProfessores.AllowUserToAddRows = False
        Me.dgvRelacaoCursosHorariosProfessores.AllowUserToDeleteRows = False
        Me.dgvRelacaoCursosHorariosProfessores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvRelacaoCursosHorariosProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRelacaoCursosHorariosProfessores.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgvRelacaoCursosHorariosProfessores.Location = New System.Drawing.Point(3, 314)
        Me.dgvRelacaoCursosHorariosProfessores.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgvRelacaoCursosHorariosProfessores.Name = "dgvRelacaoCursosHorariosProfessores"
        Me.dgvRelacaoCursosHorariosProfessores.ReadOnly = True
        Me.dgvRelacaoCursosHorariosProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRelacaoCursosHorariosProfessores.Size = New System.Drawing.Size(950, 180)
        Me.dgvRelacaoCursosHorariosProfessores.TabIndex = 327
        '
        'frmRelacaoCompletaHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(956, 501)
        Me.Controls.Add(Me.dgvRelacaoCursosHorariosProfessores)
        Me.Controls.Add(Me.dgvRelacaoCursosHorarios)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRelacaoCompletaHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRelacaoCompletaHorarios"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvRelacaoCursosHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRelacaoCursosHorariosProfessores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btFechar As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvRelacaoCursosHorarios As DataGridView
    Friend WithEvents dgvRelacaoCursosHorariosProfessores As DataGridView
End Class
