Public Class frmPrincipal
    Private Sub AlunosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlunosToolStripMenuItem.Click
        Dim form = New frmCadastroAlunos
        form.ShowDialog()
    End Sub
End Class
