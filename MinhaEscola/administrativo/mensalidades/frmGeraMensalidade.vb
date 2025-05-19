Imports System.Data.SqlClient
Imports System.Data

Public Class frmGeraMensalidade
    Private Sub frmGeraMensalidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
        chkGerarNovasParcelas.Checked = False
        txtNomeAlunos.Text = strNomeAluno
        txtNomeCurso.Text = strNomeCurso
        '  txtValorTotalCurso.Text = FormatCurrency(dblValorCurso)
        '  txtValorCadaParcela.Text = FormatCurrency(dblValorCurso)

        txtValorTotalCurso.Text = FormatCurrency(dblValorCurso)
        txtValorCadaParcela.Text = FormatCurrency(dblValorCurso)

        preencheCombo()
        ' cboPeriodo.SelectedIndex = 3
    End Sub

    Private Sub preencheCombo()

        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_periodo_listar", con)
            DA.Fill(DT)

            cboPeriodo.DisplayMember = "DescricaoPeriodo"
            ' cboPeriodo.ValueMember = "DiasPeriodo"
            cboPeriodo.ValueMember = "CodigoPeriodo"
            cboPeriodo.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub btnGerarParcelas_Click(sender As Object, e As EventArgs) Handles btnGerarParcelas.Click
        If frmControleMensalidades.dgvMensalidades.Rows.Count > 1 And chkGerarNovasParcelas.Checked = False Then
            MsgBox("Ja existem parcelas geradas para este cliente. Para gerar novas parcelas marque esta opção no formulário",
                   MsgBoxStyle.Information, "CS .Net Tecnologia")
        Else
            If txtNomeCurso.Text.Length <= 0 Then
                MsgBox("O campo descrição do produto tem preenchimento obrigatório.", MsgBoxStyle.Information, "VAL  Tecnologia")
                Me.txtNomeCurso.Focus()
                Exit Sub
            End If
            If txtValorTotalCurso.Text.Length <= 0 Then
                MsgBox("O campo valor da parcela tem preenchimento obrigatório", MsgBoxStyle.Information, "VAL Tecnologia")
                Me.txtValorTotalCurso.Focus()
                Exit Sub
            End If

            If frmControleMensalidades.dgvMensalidades.Rows.Count > 0 Then
                removeParcelasExistentes(intCodigoAluno)
            End If

            Dim NomeProduto As String = txtNomeCurso.Text
            Dim numerodias As Integer = cboPeriodo.SelectedValue
            Dim dataInicioParcela As DateTime = dtpDataPrimeiraParcela.Value.Date
            Dim valorParcela As Double = CDbl(txtValorCadaParcela.Text)
            Dim numeroParcela As Integer = 1

            Dim cmd As SqlCommand

            Dim Juros As String = "R$ 0,00"
            Dim Desconto As String = "R$ 0,00"

            Dim novaParcela As DateTime = Now
            novaParcela = dataInicioParcela.AddDays(numerodias)

            novaParcela = VerificaDiaNaoUtil(novaParcela)

            'Me.Cursor = Cursors.WaitCursor
            Try

                abrir()
                For i = 1 To Val(nupQuantidadeParcelas.Value)

                    cmd = New SqlCommand("pa_periodoMensalidade_Salvar", con)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@CodigoAluno", intCodigoAluno)
                    cmd.Parameters.AddWithValue("@idCurso", intCodigoCurso)
                    cmd.Parameters.AddWithValue("@NomeCurso", NomeProduto)
                    cmd.Parameters.AddWithValue("@valorParcela", valorParcela)
                    cmd.Parameters.AddWithValue("@numeroParcela", numeroParcela)
                    cmd.Parameters.AddWithValue("@vencimentoParcela", novaParcela)
                    cmd.Parameters.AddWithValue("@PagamentoParcela", "")
                    cmd.Parameters.AddWithValue("@Juros", Juros)
                    cmd.Parameters.AddWithValue("@Desconto", Desconto)
                    cmd.Parameters.AddWithValue("@Observacao", "")
                    cmd.Parameters.AddWithValue("@situacao", "Nao Paga")
                    '  cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()

                    'Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                    ' MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                    numeroParcela += 1
                    novaParcela = novaParcela.AddDays(numerodias)
                    novaParcela = VerificaDiaNaoUtil(novaParcela)
                Next

                frmAguardar.ShowDialog()
                'Me.Cursor = Cursors.Default
                MsgBox("As mensalidades para o curso de " & txtNomeCurso.Text & " foram geradas com sucesso.",
                           MsgBoxStyle.Information, "VALDEMIR Tecnologia")
                Me.Dispose()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try

        End If
    End Sub

    Private Sub removeParcelasExistentes(ByVal codcliente As Integer)
        Dim cmd As SqlCommand

        Try
            If (MessageBox.Show("Deseja excluir este Aluno?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

            abrir()
            cmd = New SqlCommand("pa_aluno_Excluir", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CodigoAluno", codcliente)
            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar os dados" + ex.Message)
            fechar()
        End Try

    End Sub

    Private Sub chkGerarNovasParcelas_CheckedChanged(sender As Object, e As EventArgs) Handles chkGerarNovasParcelas.CheckedChanged
        If chkGerarNovasParcelas.Checked = True Then
            If strPerfilUsuario <> "admin" Then
                chkGerarNovasParcelas.Checked = False
                MsgBox("Para gerar novamente as mensalidades para o curso de " & txtNomeCurso.Text & " contate o Administrador.",
                       MsgBoxStyle.Information, "VAL Tecnologia")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnEncerrar_Click(sender As Object, e As EventArgs) Handles btnEncerrar.Click
        Me.Close()
    End Sub

    Private Sub nupQuantidadeParcelas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nupQuantidadeParcelas.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub nupQuantidadeParcelas_ValueChanged(sender As Object, e As EventArgs) Handles nupQuantidadeParcelas.ValueChanged
        Try
            If nupQuantidadeParcelas.Value > 1 Then
                Dim valortotalcurso, valorparcelas As Double
                valortotalcurso = txtValorTotalCurso.Text
                valorparcelas = nupQuantidadeParcelas.Value
                txtValorCadaParcela.Text = FormatCurrency(valortotalcurso / valorparcelas)
            ElseIf nupQuantidadeParcelas.Value = 1 Then
                txtValorCadaParcela.Text = FormatCurrency(txtValorTotalCurso.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class