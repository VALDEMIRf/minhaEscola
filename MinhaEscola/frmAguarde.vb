Public Class frmAguarde
    Private Sub frmAguarde_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        PVerificaACorAtual()
        tmTimer.Start()
    End Sub

    Private Sub frmAguarde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub

    Private Sub tmTimer_Tick(sender As Object, e As EventArgs) Handles tmTimer.Tick
        picProcesso.Width = picProcesso.Width + 5
        If picProcesso.Width = 475 Then
            picProcesso.Visible = False
            picProcesso.Width = 15
            tmTimer.Stop()
            Me.Dispose()
        End If
    End Sub
End Class