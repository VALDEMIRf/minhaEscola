<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.lblVersao = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEscola = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVersa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVersao.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVersao
        '
        Me.lblVersao.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblEscola, Me.ToolStripStatusLabel2, Me.lblVersa})
        Me.lblVersao.Location = New System.Drawing.Point(0, 735)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(1148, 22)
        Me.lblVersao.TabIndex = 1
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel1.Text = "Escola:"
        '
        'lblEscola
        '
        Me.lblEscola.BackColor = System.Drawing.Color.White
        Me.lblEscola.Name = "lblEscola"
        Me.lblEscola.Size = New System.Drawing.Size(40, 17)
        Me.lblEscola.Text = "Escola"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(30, 3, 0, 2)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel2.Text = "Versão:"
        '
        'lblVersa
        '
        Me.lblVersa.BackColor = System.Drawing.Color.White
        Me.lblVersa.Name = "lblVersa"
        Me.lblVersa.Size = New System.Drawing.Size(23, 17)
        Me.lblVersa.Text = "ver"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1148, 757)
        Me.Controls.Add(Me.lblVersao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Inteligente de Controle Escolar"
        Me.lblVersao.ResumeLayout(False)
        Me.lblVersao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVersao As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblEscola As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblVersa As ToolStripStatusLabel
End Class
