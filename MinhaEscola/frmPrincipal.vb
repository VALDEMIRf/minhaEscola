Public Class frmPrincipal
    Private Sub AlunosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlunosToolStripMenuItem.Click
        Dim form = New frmCadastroAlunos
        form.ShowDialog()
    End Sub

    Private Sub ProfessoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfessoresToolStripMenuItem.Click
        Dim form = New frmOcupacoes
        form.ShowDialog()
    End Sub
End Class
