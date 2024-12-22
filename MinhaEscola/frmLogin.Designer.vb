<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.btAcessar = New System.Windows.Forms.Button()
        Me.txtSenha = New ZBobb.AlphaBlendTextBox()
        Me.txtUsuario = New ZBobb.AlphaBlendTextBox()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btAcessar
        '
        Me.btAcessar.BackColor = System.Drawing.Color.Transparent
        Me.btAcessar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAcessar.FlatAppearance.BorderSize = 0
        Me.btAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAcessar.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAcessar.ForeColor = System.Drawing.Color.White
        Me.btAcessar.Location = New System.Drawing.Point(2, 276)
        Me.btAcessar.Name = "btAcessar"
        Me.btAcessar.Size = New System.Drawing.Size(325, 43)
        Me.btAcessar.TabIndex = 3
        Me.btAcessar.UseVisualStyleBackColor = False
        '
        'txtSenha
        '
        Me.txtSenha.BackAlpha = 10
        Me.txtSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.Color.Black
        Me.txtSenha.Location = New System.Drawing.Point(79, 167)
        Me.txtSenha.Multiline = True
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(220, 32)
        Me.txtSenha.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.BackAlpha = 10
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtUsuario.Location = New System.Drawing.Point(79, 110)
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 31)
        Me.txtUsuario.TabIndex = 1
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Image = Global.MinhaEscola.My.Resources.Resources.bolinha_xis
        Me.btCancelar.Location = New System.Drawing.Point(302, 1)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(29, 26)
        Me.btCancelar.TabIndex = 4
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.BackgroundImage = Global.MinhaEscola.My.Resources.Resources.telalogin1
        Me.ClientSize = New System.Drawing.Size(333, 325)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.btAcessar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btAcessar As Button
    Friend WithEvents txtSenha As ZBobb.AlphaBlendTextBox
    Friend WithEvents txtUsuario As ZBobb.AlphaBlendTextBox
    Friend WithEvents btCancelar As Button
End Class
