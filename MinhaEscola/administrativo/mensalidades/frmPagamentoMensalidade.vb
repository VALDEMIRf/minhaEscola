Imports System.Data.SqlClient

Public Class frmPagamentoMensalidade
    Dim nomecliente As String
    Dim codParcela As Integer
    Dim calcularJuros As Boolean = False
    Dim calcularDesconto As Boolean = False
    Dim numerodias As TimeSpan
    Dim juros As Double = 0
    Dim desconto As Double = 0
    Dim valorDaParcela As Double
    Dim vencimentoParcela As Date
    Dim pagamentoDaParcela As Date

    Private Sub frmPagamentoMensalidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
        codParcela = intCodigoParcelaPagar
        txtCodigoMensalidade.Text = intCodigoParcelaPagar
        txtNomeAluno.Text = strNomeAluno
        txtNomeCurso.Text = strNomeCurso

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
                txtValorParcela.Text = FormatCurrency(dr.Item("valorParcela").ToString(), 2)
                dtpVencimentoParcela.Value = dr.Item("vencimentoParcela")
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

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim sql As String
        Dim observacaoParcela As String = txtObservacao.Text
        Dim cmd As SqlCommand

        If txtValorPago.Text = String.Empty Then
            MsgBox("Por favor informe o valor do pagamento.", MsgBoxStyle.Information, "CS .Net Tecnologia")
            txtValorPago.Focus()
            Exit Sub
        End If



        Try
            abrir()
            cmd = New SqlCommand("pa_periodoMensalidade_AlterarPagamento", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CodigoMensalidade", codParcela)
            cmd.Parameters.AddWithValue("@valorParcela", valorDaParcela)
            'cmd.Parameters.AddWithValue("@VencimentoParcela", vencimentoDaParcela)
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

    Private Sub dtpPagamentoParcela_ValueChanged(sender As Object, e As EventArgs) Handles dtpPagamentoParcela.ValueChanged
        If dtpPagamentoParcela.Value > dtpVencimentoParcela.Value Then
            txtDesconto.Enabled = False
            txtJuros.Enabled = True
            txtValorPago.Text = ""
        ElseIf dtpPagamentoParcela.Value < dtpVencimentoParcela.Value Then
            txtDesconto.Enabled = True
            txtJuros.Enabled = False
            txtValorPago.Text = ""
        ElseIf dtpPagamentoParcela.Value = dtpVencimentoParcela.Value Then
            txtDesconto.Enabled = False
            txtJuros.Enabled = False
            txtValorPago.Text = ""
        End If
    End Sub

    Private Sub calcular()

        valorDaParcela = CDbl(txtValorParcela.Text)
        vencimentoParcela = dtpVencimentoParcela.Value.Date
        pagamentoDaParcela = dtpPagamentoParcela.Value.Date

        If pagamentoDaParcela > vencimentoParcela Then
            numerodias = pagamentoDaParcela.Subtract(vencimentoParcela)
        End If

        If calcularJuros Then
            Dim taxaJuros As Double = CDbl(txtJuros.Text) / 100
            juros = CDbl(valorDaParcela * numerodias.Days * taxaJuros)
            desconto = 0
            txtValorPago.Text = CDbl(valorDaParcela + juros).ToString("c")
        Else
            If calcularDesconto Then
                Dim taxaDesconto As Double = CDbl(txtDesconto.Text) / 100
                desconto = CDbl(valorDaParcela * taxaDesconto)
                juros = 0
                txtValorPago.Text = CDbl(valorDaParcela - desconto).ToString("c")
            Else
                juros = 0
                desconto = 0
                txtValorPago.Text = valorDaParcela.ToString("c")
            End If
        End If

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If txtValorParcela.Text = "" Then
            MsgBox("Informe o valor para aplicar o Desconto/Juros referente a esta mensalidade.",
                   MsgBoxStyle.Information, "VALDEMIR Tecnologia")
            txtValorParcela.Focus()
            Exit Sub
        End If

        If dtpPagamentoParcela.Value > dtpVencimentoParcela.Value Then
            txtDesconto.Enabled = False
            txtJuros.Enabled = True
            calcularJuros = True
            calcularDesconto = False
        Else
            If dtpPagamentoParcela.Value < dtpVencimentoParcela.Value Then
                txtDesconto.Enabled = True
                txtJuros.Enabled = False
                calcularDesconto = True
                calcularJuros = False
            Else
                If dtpPagamentoParcela.Value = dtpVencimentoParcela.Value Then
                    txtDesconto.Enabled = False
                    txtJuros.Enabled = False
                    calcularJuros = False
                    calcularDesconto = False
                End If
            End If
        End If

        'Calcula a taxas de descontos, juros
        calcular()
    End Sub

    Private Sub btnEmDia_Click(sender As Object, e As EventArgs) Handles btnEmDia.Click
        dtpPagamentoParcela.Value = dtpVencimentoParcela.Value
    End Sub

    Private Sub txtValorParcela_TextChanged(sender As Object, e As EventArgs) Handles txtValorParcela.TextChanged
        Utils.TextBoxMoeda(txtValorParcela)
    End Sub
End Class