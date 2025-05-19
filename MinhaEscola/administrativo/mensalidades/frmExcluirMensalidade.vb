Imports System.Data.SqlClient

Public Class frmExcluirMensalidade
    Private Sub frmExcluirMensalidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
        txtCodigoMensalidade.Text = intCodigoParcelaExcluir
        txtNomeAluno.Text = strNomeAluno
        txtNomeCurso.Text = strNomeCurso
        txtValorParcela.Text = FormatCurrency(dblValorCurso)

        Dim dr As SqlDataReader = Nothing
        ' abre a conexao
        Try
            abrir()
            ' cria um command para esta conexao
            Dim cmd As New SqlCommand("pa_Mensalidade_AlterarMensalidade", con)
            ' Cria uma consulta paremetrizada
            cmd.Parameters.Add(New SqlParameter("@CodigoMensalidade", codParcela))

            ' executa a consulta.
            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
            ' exibe o resultado nas caixas de texto
            If dr.HasRows Then
                dr.Read()
                txtValorParcela.Text = FormatCurrency(dr.Item("valorParcela").ToString, 2)
                dtpVencimentoParcela.Value = dr.Item("vencimentoParcela")
                'verifica o campo pagmentoParcela
                If dr.IsDBNull(5) Then
                    dtpPagamentoParcela.Value = Now
                Else
                    dtpPagamentoParcela.Value = dr.Item("pagamentoParcela")
                End If
                txtObservacao.Text = dr.Item("observacao").ToString
            Else
                'limpa as caixas de texto
                For Each ctl As Control In Me.Controls
                    If TypeOf ctl Is TextBox Then ctl.Text = ""
                Next ctl
            End If
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
            ' fecha a conexao
            fechar()
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If (MsgBox("Tem certeza que deseja excluir a mensalidade? Após confirmação, não será possível reverter!",
                   MsgBoxStyle.YesNo, "CS .Net Tecnologia") = MsgBoxResult.Yes) Then

            Try
                If (MessageBox.Show("Deseja excluir esta parcela?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_Mensalidade_ExcluirMensalidade", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CodigoMensalidade", txtCodigoMensalidade.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Catch ex As Exception
                MessageBox.Show("Erro ao  excluir os dados" + ex.Message.ToString)
                fechar()
            End Try

        End If
    End Sub

    Private Sub btnEncerrar_Click(sender As Object, e As EventArgs) Handles btnEncerrar.Click
        Me.Close()
    End Sub
End Class