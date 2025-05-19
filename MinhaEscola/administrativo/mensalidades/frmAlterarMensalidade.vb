Imports System.Data
Imports System.Data.SqlClient

Public Class frmAlterarMensalidade


    Private Sub frmAlterarMensalidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
        txtCodigoMensalidade.Text = intCodigoAluno
        txtNomeCliente.Text = strNomeAluno
        txtNomeCurso.Text = strNomeCurso
        txtValorParcela.Text = FormatCurrency(dblValorCurso)

        Dim dr As SqlDataReader = Nothing
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
                txtDesconto.Text = FormatCurrency(dr.Item("desconto"), 2)
                txtJuros.Text = FormatCurrency(dr.Item("juros"), 2)
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
            'MsgBox("Ocorreu um erro .:" & ex.Message)
        Finally
            dr.Close()
            ' fecha a conexao
            fechar()
        End Try

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim valorDaParcela As Double = CDbl(txtValorParcela.Text)
        Dim vencimentoDaParcela As Date = dtpVencimentoParcela.Value.Date
        Dim pagamentoDaParcela As Date = dtpPagamentoParcela.Value.Date
        Dim observacaoParcela As String = txtObservacao.Text
        Dim desconto As Double = CDbl(txtDesconto.Text)
        Dim juros As Double = CDbl(txtJuros.Text)

        Dim cmd As SqlCommand

        Try
                abrir()
            cmd = New SqlCommand("pa_periodoMensalidade_Alterar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CodigoMensalidade", txtCodigoMensalidade)
            cmd.Parameters.AddWithValue("@valorParcela", valorDaParcela)
            cmd.Parameters.AddWithValue("@VencimentoParcela", vencimentoDaParcela)
            cmd.Parameters.AddWithValue("@PagamentoParcela", pagamentoDaParcela)
            cmd.Parameters.AddWithValue("@Desconto", desconto)
            cmd.Parameters.AddWithValue("@Juros", juros)
            cmd.Parameters.AddWithValue("@Observacao", observacaoParcela)
            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub btnEncerrar_Click(sender As Object, e As EventArgs) Handles btnEncerrar.Click
        Me.Close()
    End Sub

    Private Sub txtValorParcela_TextChanged(sender As Object, e As EventArgs) Handles txtValorParcela.TextChanged
        Utils.TextBoxMoeda(Me.txtValorParcela)
    End Sub

    Private Sub txtValorParcela_GotFocus(sender As Object, e As EventArgs) Handles txtValorParcela.GotFocus
        Me.txtValorParcela.Text = Me.txtValorParcela.Text.Replace("R$ ", "").Trim
    End Sub

    Private Sub txtValorParcela_LostFocus(sender As Object, e As EventArgs) Handles txtValorParcela.LostFocus
        Me.txtValorParcela.Text = FormatCurrency(Me.txtValorParcela.Text).Trim
    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged
        Utils.TextBoxMoeda(txtDesconto)
    End Sub

    Private Sub txtDesconto_GotFocus(sender As Object, e As EventArgs) Handles txtDesconto.GotFocus
        Me.txtDesconto.Text = Me.txtDesconto.Text.Replace("R$ ", "").Trim
    End Sub

    Private Sub txtDesconto_LostFocus(sender As Object, e As EventArgs) Handles txtDesconto.LostFocus
        Me.txtDesconto.Text = FormatCurrency(Me.txtDesconto.Text).Trim
    End Sub

    Private Sub txtJuros_TextChanged(sender As Object, e As EventArgs) Handles txtJuros.TextChanged
        Utils.TextBoxMoeda(txtJuros)
    End Sub

    Private Sub txtJuros_GotFocus(sender As Object, e As EventArgs) Handles txtJuros.GotFocus
        Me.txtJuros.Text = Me.txtJuros.Text.Replace("R$ ", "").Trim
    End Sub

    Private Sub txtJuros_LostFocus(sender As Object, e As EventArgs) Handles txtJuros.LostFocus
        Me.txtJuros.Text = FormatCurrency(Me.txtJuros.Text).Trim
    End Sub
End Class