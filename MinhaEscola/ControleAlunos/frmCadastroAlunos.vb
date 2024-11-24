Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmCadastroAlunos

    Dim imgNome As String
    Private Sub frmCadastroAlunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Listar()

    End Sub

    Private Sub DesabilitarCampos()
        txtNomeAluno.Enabled = False
        txtCPF.Enabled = False
        txtRG.Enabled = False
        cmbSexo.Enabled = False
        cmbDia.Enabled = False
        cmbMes.Enabled = False
        cmbAno.Enabled = False
        txtTelefone.Enabled = False
        txtCelular.Enabled = False
        txtEmail.Enabled = False
        txtNum.Enabled = False
        txtCompl.Enabled = False
        txtNomePai.Enabled = False
        txtNomeMae.Enabled = False
        txtNomeResp.Enabled = False
        cmbOcupacaoPai.Enabled = False
        cmbOcupacaoMae.Enabled = False
        cmbOcupacaoResp.Enabled = False
        txtCelPai.Enabled = False
        txtCelMae.Enabled = False
        txtCelResp.Enabled = False
        txtObs.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNomeAluno.Focus()
        txtNomeAluno.Enabled = True
        txtCPF.Enabled = True
        txtRG.Enabled = True
        cmbSexo.Enabled = True
        cmbDia.Enabled = True
        cmbMes.Enabled = True
        cmbAno.Enabled = True
        txtTelefone.Enabled = True
        txtCelular.Enabled = True
        txtEmail.Enabled = True
        txtNum.Enabled = True
        txtCompl.Enabled = True
        txtNomePai.Enabled = True
        txtNomeMae.Enabled = True
        txtNomeResp.Enabled = True
        cmbOcupacaoPai.Enabled = True
        cmbOcupacaoMae.Enabled = True
        cmbOcupacaoResp.Enabled = True
        txtCelPai.Enabled = True
        txtCelMae.Enabled = True
        txtCelResp.Enabled = True
        txtObs.Enabled = True
    End Sub

    Private Sub Limpar()
        txtNomeAluno.Focus()
        txtNomeAluno.Text = ""
        txtCPF.Text = ""
        txtRG.Text = ""
        cmbSexo.Text = Nothing
        cmbDia.Text = Nothing
        cmbMes.Text = Nothing
        cmbAno.Text = Nothing
        txtTelefone.Text = ""
        txtCelular.Text = ""
        txtEmail.Text = ""
        txtCep.Text = ""
        txtEndereco.Text = ""
        txtNum.Text = ""
        txtComplemento.Text = ""
        txtCompl.Text = ""
        txtUF.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtNomePai.Text = ""
        txtNomeMae.Text = ""
        txtNomeResp.Text = ""
        cmbOcupacaoPai.Text = Nothing
        cmbOcupacaoMae.Text = Nothing
        cmbOcupacaoResp.Text = Nothing
        txtCelPai.Text = ""
        txtCelMae.Text = ""
        txtCelResp.Text = ""
        txtObs.Text = ""
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_aluno_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()

            ' FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Alunos" + ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()

        With dg
            .Columns(0).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(20).Visible = False
            .Columns(21).Visible = False

            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "CPF"
            .Columns(3).HeaderText = "RG"
            .Columns(4).HeaderText = "Est. Civil"
            .Columns(5).HeaderText = "Naturalidade"
            .Columns(6).HeaderText = "Sexo"
            .Columns(7).HeaderText = "Nascimento"
            .Columns(8).HeaderText = "Telefone"
            .Columns(9).HeaderText = "Celular"
            .Columns(10).HeaderText = "Email"
            .Columns(11).HeaderText = "CEP"
            .Columns(12).HeaderText = "UF"
            .Columns(13).HeaderText = "Endereço"
            .Columns(14).HeaderText = "Num"
            .Columns(15).HeaderText = "Compl"
            .Columns(16).HeaderText = "Compl2"
            .Columns(17).HeaderText = "Bairro"
            .Columns(18).HeaderText = "Cidade"
            .Columns(19).HeaderText = "Obs."
            .Columns(20).HeaderText = "Data Cadastro"

            .Columns(1).Width = 150
            .Columns(2).Width = 110
            .Columns(5).Width = 100
            .Columns(6).Width = 80
            .Columns(7).Width = 100
            .Columns(8).Width = 120
            .Columns(9).Width = 120
            .Columns(10).Width = 200
            .Columns(11).Width = 80
            .Columns(12).Width = 30
            .Columns(13).Width = 140
            .Columns(14).Width = 75
            .Columns(15).Width = 150
            .Columns(16).Width = 150
            .Columns(17).Width = 150
            .Columns(19).Width = 180
        End With

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub btConsultaCEP_Click(sender As Object, e As EventArgs) Handles btConsultaCEP.Click

    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click

    End Sub

    Private Sub btImagem_Click(sender As Object, e As EventArgs) Handles btImagem.Click

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        HabilitarCampos()
        Limpar()
        btSalvarEditar.Enabled = True
        btnExcluir.Enabled = False
    End Sub

    Private Sub btSalvarEditar_Click(sender As Object, e As EventArgs) Handles btSalvarEditar.Click
        If lblCodigo.Text > 0 Then
            alterar()
        Else
            gravar()
        End If
    End Sub

    Private Sub gravar()

        Dim cmd As SqlCommand

        Try

            abrir()
            cmd = New SqlCommand("pa_aluno_Salvar", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@NomeAluno", txtNomeAluno.Text)
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
            cmd.Parameters.AddWithValue("@rg", txtCliente.SelectedValue)
            cmd.Parameters.AddWithValue("@sexo", txtDescricao.Text)
            cmd.Parameters.AddWithValue("@dia", txtFormaPagto.SelectedValue)
            cmd.Parameters.AddWithValue("@mes", valorConta)
            cmd.Parameters.AddWithValue("@ano", txtObs.Text)
            cmd.Parameters.AddWithValue("@telefone", txtVencimento.Text)
            cmd.Parameters.AddWithValue("@celular", mskData.Text)
            cmd.Parameters.AddWithValue("@email", valorDesconto)
            cmd.Parameters.AddWithValue("@cep", valorJuros)
            cmd.Parameters.AddWithValue("@endereco", valorPago)
            cmd.Parameters.AddWithValue("@num", txtSituacao.Text)
            cmd.Parameters.AddWithValue("@complemento", usuarioNome)
            cmd.Parameters.AddWithValue("@compl", txtDataEntrada.Text)
            cmd.Parameters.AddWithValue("@uf", txtNDoc.Text)
            cmd.Parameters.AddWithValue("@bairro", txtConta.SelectedValue)
            cmd.Parameters.AddWithValue("@cidade", txtCliente.SelectedValue)
            cmd.Parameters.AddWithValue("@imagem", txtDescricao.Text)
            cmd.Parameters.AddWithValue("@NomePai", txtFormaPagto.SelectedValue)
            cmd.Parameters.AddWithValue("@OcupacaoPai", valorConta)
            cmd.Parameters.AddWithValue("@celularPai", txtObs.Text)
            cmd.Parameters.AddWithValue("@NomeMae", txtVencimento.Text)
            cmd.Parameters.AddWithValue("@OcupacaoMae", mskData.Text)
            cmd.Parameters.AddWithValue("@celularMae", valorDesconto)
            cmd.Parameters.AddWithValue("@NomeResp", valorJuros)
            cmd.Parameters.AddWithValue("@OcupacaoResp", valorPago)
            cmd.Parameters.AddWithValue("@celularResp", txtSituacao.Text)
            cmd.Parameters.AddWithValue("@Observacao", usuarioNome)
            cmd.Parameters.AddWithValue("@DataCadastro", txtDataEntrada.Text)

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            ' btSalvar.Enabled = False


        Catch ex As Exception
            MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
        Finally
            fechar()

            End Try


    End Sub

    Private Sub alterar()
        Dim cmd As SqlCommand

        If txtNDoc.Text <> "" Then

            Try

                Dim valorConta = Replace(txtValor.Text, ",", ".")
                Dim valorParela = Replace(txtValorParcelas.Text, ",", ".")
                Dim valorDesconto = Replace(txtDesconto.Text, ",", ".")
                Dim valorJuros = Replace(txtJuros.Text, ",", ".")
                Dim valorPago = Replace(txtValoraPagar.Text, ",", ".")

                abrir()
                cmd = New SqlCommand("pa_ContasPagar_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_conta", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@numDocto", "")
                cmd.Parameters.AddWithValue("@id_categoriacontas", txtConta.SelectedValue)
                cmd.Parameters.AddWithValue("@id_cliente", txtCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@id_formaPag", txtFormaPagto.SelectedValue)
                cmd.Parameters.AddWithValue("@valor", valorConta)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.AddWithValue("@vencimento", txtVencimento.Text)
                cmd.Parameters.AddWithValue("@datapagamento", mskData.Text)
                cmd.Parameters.AddWithValue("@desconto", valorDesconto)
                cmd.Parameters.AddWithValue("@juros", valorJuros)
                cmd.Parameters.AddWithValue("@valorpago", valorPago)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click

    End Sub
End Class