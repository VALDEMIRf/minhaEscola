Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmCadastroAlunos

    Dim imgNome As String
    Private ImagemCarregada As Image
    Private _create As Net.HttpWebRequest

    Private Sub frmCadastroAlunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarImagem()
        carregarOcupacaoPai()
        carregarOcupacaoMae()
        carregarOcupacaoResp()
        Listar()

    End Sub

    Private Sub frmCadastroAlunos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        carregarOcupacaoPai()
        carregarOcupacaoMae()
        carregarOcupacaoResp()
        Listar()
    End Sub

    Sub carregarOcupacaoPai()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_ocupacao_listar", con)
            DA.Fill(DT)

            cmbOcupacaoPai.ValueMember = "id"
            cmbOcupacaoPai.DisplayMember = "nome"
            cmbOcupacaoPai.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub carregarOcupacaoMae()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_ocupacao_listar", con)
            DA.Fill(DT)

            cmbOcupacaoMae.ValueMember = "id"
            cmbOcupacaoMae.DisplayMember = "nome"
            cmbOcupacaoMae.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Sub carregarOcupacaoResp()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_ocupacao_listar", con)
            DA.Fill(DT)

            cmbOcupacaoResp.ValueMember = "id"
            cmbOcupacaoResp.DisplayMember = "nome"
            cmbOcupacaoResp.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

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
        lblCodigo.Text = 0
        txtCPF.Text = ""
        txtRG.Text = ""
        cmbSexo.Text = Nothing
        cmbEstCivil.Text = Nothing
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
        carregarImagem()


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

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Alunos" + ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()

        With dg
            .Columns(0).Visible = False
            .Columns(20).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(31).Visible = False
            .Columns(32).Visible = False
            .Columns(33).Visible = False
            .Columns(34).Visible = False
            .Columns(35).Visible = False
            .Columns(36).Visible = False
            .Columns(37).Visible = False

            .Columns(0).HeaderText = "CodigoAluno"
            .Columns(1).HeaderText = "NomeAluno"
            .Columns(2).HeaderText = "CPF"
            .Columns(3).HeaderText = "RG"
            .Columns(4).HeaderText = "Sexo"
            .Columns(5).HeaderText = "est Civil"
            .Columns(6).HeaderText = "Dia"
            .Columns(7).HeaderText = "Mês"
            .Columns(8).HeaderText = "Ano"
            .Columns(9).HeaderText = "Telefone"
            .Columns(10).HeaderText = "Celular"
            .Columns(11).HeaderText = "Email"
            .Columns(12).HeaderText = "CEP"
            .Columns(13).HeaderText = "Endereço"
            .Columns(14).HeaderText = "Núm."
            .Columns(15).HeaderText = "Compl"
            .Columns(16).HeaderText = "Compl2"
            .Columns(17).HeaderText = "UF"
            .Columns(18).HeaderText = "Bairro"
            .Columns(19).HeaderText = "Cidade"
            .Columns(20).HeaderText = "Foto"
            .Columns(21).HeaderText = "Pai"
            .Columns(22).HeaderText = "Profissao Pai"
            .Columns(23).HeaderText = "Tel Pai"
            .Columns(24).HeaderText = "Mãe"
            .Columns(25).HeaderText = "Profissao Mãe"
            .Columns(26).HeaderText = "Tel Mae"
            .Columns(27).HeaderText = "Responsável"
            .Columns(28).HeaderText = "Profissão Resp."
            .Columns(29).HeaderText = "Tel Resp"
            .Columns(30).HeaderText = "Obs."
            .Columns(31).HeaderText = "Dt Cadastro"
            .Columns(32).HeaderText = "ID OcupacaoPai"
            .Columns(33).HeaderText = "ID AlunoPai"
            .Columns(34).HeaderText = "ID OcupacaoMae"
            .Columns(35).HeaderText = "ID AlunoMae"
            .Columns(36).HeaderText = "ID OcupacaoResp"
            .Columns(37).HeaderText = "ID AlunoResp"


            '.Columns(1).Width = 150
            '.Columns(2).Width = 110
            '.Columns(5).Width = 100
            '.Columns(6).Width = 80
            '.Columns(7).Width = 100
            '.Columns(8).Width = 120
            '.Columns(9).Width = 120
            '.Columns(10).Width = 200
            '.Columns(11).Width = 80
            '.Columns(12).Width = 30
            '.Columns(13).Width = 140
            '.Columns(14).Width = 75
            '.Columns(15).Width = 150
            '.Columns(16).Width = 150
            '.Columns(17).Width = 150
            '.Columns(19).Width = 180
        End With

    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub btConsultaCEP_Click(sender As Object, e As EventArgs) Handles btConsultaCEP.Click
        If validaCEP() Then
            ObterCep(txtCep.Text)
            ' MessageBox.Show("Digite um cep válido!!!!")
        End If
    End Sub

    Private Function validaCEP()
        Dim rgxCep = New Regex("^\d{5}-\d{3}$")
        If Not rgxCep.IsMatch(txtCep.Text) Then
            MessageBox.Show("Digite um cep válido!!!!")
            txtCep.Focus()
            Return False
        End If
        Return True
    End Function


    Private Sub btImagem_Click(sender As Object, e As EventArgs) Handles btImagem.Click
        pbImagem.Visible = True
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"}

            If OFD.ShowDialog = DialogResult.OK Then
                ImagemCarregada = Image.FromFile(OFD.FileName)
                pbImagem.Image = ImagemCarregada
            End If
        End Using
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        HabilitarCampos()
        Limpar()
        btSalvarEditar.Enabled = True
        ' btConsultaCEP.Enabled = True
        btnExcluir.Enabled = False
    End Sub

    Private Sub btSalvarEditar_Click(sender As Object, e As EventArgs) Handles btSalvarEditar.Click
        If lblCodigo.Text > 0 Then
            alterar()
        Else
            gravar()
        End If
    End Sub

    Sub carregarImagem()

        Dim img As String = "https://www.buritama.sp.leg.br/imagens/parlamentares-2013-2016/sem-foto.jpg/image"

        Dim req As System.Net.HttpWebRequest
        Dim resp As System.Net.HttpWebResponse
        req = Net.WebRequest.Create(img)
        req = req.Create(img)

        resp = req.GetResponse

        ImagemCarregada = New Bitmap(resp.GetResponseStream)
        pbImagem.Image = ImagemCarregada
        req.Abort()

    End Sub

    Private Sub gravar()

        Dim cmd As SqlCommand

        Try

            'CARREGANDO IMAGEM NO BANCO
            Dim MS As New IO.MemoryStream
            ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim byteArray = MS.ToArray

            abrir()
            cmd = New SqlCommand("pa_aluno_Salvar", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@NomeAluno", txtNomeAluno.Text)
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
            cmd.Parameters.AddWithValue("@rg", txtRG.Text)
            cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text)
            cmd.Parameters.AddWithValue("@estCivil", cmbEstCivil.Text)
            cmd.Parameters.AddWithValue("@dia", cmbDia.Text)
            cmd.Parameters.AddWithValue("@mes", cmbMes.Text)
            cmd.Parameters.AddWithValue("@ano", cmbAno.Text)
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text)
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@cep", txtCep.Text)
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
            cmd.Parameters.AddWithValue("@num", txtNum.Text)
            cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text)
            cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
            cmd.Parameters.AddWithValue("@uf", txtUF.Text)
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
            cmd.Parameters.AddWithValue("@imagem", byteArray)
            cmd.Parameters.AddWithValue("@NomePai", txtNomePai.Text)
            cmd.Parameters.AddWithValue("@OcupacaoPai", cmbOcupacaoPai.SelectedValue)
            cmd.Parameters.AddWithValue("@celularPai", txtCelPai.Text)
            cmd.Parameters.AddWithValue("@NomeMae", txtNomeMae.Text)
            cmd.Parameters.AddWithValue("@OcupacaoMae", cmbOcupacaoMae.SelectedValue)
            cmd.Parameters.AddWithValue("@celularMae", txtCelMae.Text)
            cmd.Parameters.AddWithValue("@NomeResp", txtNomeResp.Text)
            cmd.Parameters.AddWithValue("@OcupacaoResp", cmbOcupacaoResp.SelectedValue)
            cmd.Parameters.AddWithValue("@celularResp", txtCelResp.Text)
            cmd.Parameters.AddWithValue("@Observacao", txtObs.Text)
            cmd.Parameters.AddWithValue("@DataCadastro", Now.ToShortDateString)

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            Limpar()
            Listar()
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
        Finally
            fechar()

        End Try
    End Sub

    Private Sub ObterCep(cep As String)

        Dim dsCep = clsCep.ObterCep(cep)
        Try
            txtEndereco.Text = UTF8_to_ISO(dsCep.logradouro)
            txtComplemento.Text = UTF8_to_ISO(dsCep.complemento)
            txtBairro.Text = UTF8_to_ISO(dsCep.bairro)
            txtCidade.Text = UTF8_to_ISO(dsCep.localidade)
            txtUF.Text = dsCep.uf
        Catch ex As Exception
            MessageBox.Show("CEP Incorreto, digite um CEP válido!!!", "ERRO")
        End Try

    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub btInserirOcupacao_Click(sender As Object, e As EventArgs) Handles btInserirOcupacao.Click
        Dim form = New frmOcupacoes
        form.ShowDialog()
    End Sub

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click

        txtCPF.Enabled = False
        txtRG.Enabled = False

        lblCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNomeAluno.Text = dg.CurrentRow.Cells(1).Value
        txtCPF.Text = dg.CurrentRow.Cells(2).Value
        txtRG.Text = dg.CurrentRow.Cells(3).Value
        cmbSexo.Text = dg.CurrentRow.Cells(4).Value
        cmbEstCivil.Text = dg.CurrentRow.Cells(5).Value
        cmbDia.Text = dg.CurrentRow.Cells(6).Value
        cmbMes.Text = dg.CurrentRow.Cells(7).Value
        cmbAno.Text = dg.CurrentRow.Cells(8).Value
        txtTelefone.Text = dg.CurrentRow.Cells(9).Value
        txtCelular.Text = dg.CurrentRow.Cells(10).Value
        txtEmail.Text = dg.CurrentRow.Cells(11).Value
        txtCep.Text = dg.CurrentRow.Cells(12).Value
        txtEndereco.Text = dg.CurrentRow.Cells(13).Value
        txtNum.Text = dg.CurrentRow.Cells(14).Value
        txtComplemento.Text = dg.CurrentRow.Cells(15).Value
        txtCompl.Text = dg.CurrentRow.Cells(16).Value
        txtUF.Text = dg.CurrentRow.Cells(17).Value
        txtBairro.Text = dg.CurrentRow.Cells(18).Value
        txtCidade.Text = dg.CurrentRow.Cells(19).Value
        ' = dg.CurrentRow.Cells(20).Value
        txtNomePai.Text = dg.CurrentRow.Cells(21).Value
        cmbOcupacaoPai.Text = dg.CurrentRow.Cells(22).Value
        txtCelPai.Text = dg.CurrentRow.Cells(23).Value
        txtNomeMae.Text = dg.CurrentRow.Cells(24).Value
        cmbOcupacaoMae.Text = dg.CurrentRow.Cells(25).Value
        txtCelMae.Text = dg.CurrentRow.Cells(26).Value
        txtNomeResp.Text = dg.CurrentRow.Cells(27).Value
        cmbOcupacaoResp.Text = dg.CurrentRow.Cells(28).Value
        txtCelResp.Text = dg.CurrentRow.Cells(29).Value
        txtObs.Text = dg.CurrentRow.Cells(30).Value


        Dim tempImagem As Byte() = DirectCast(dg.CurrentRow.Cells(20).Value, Byte())
        If tempImagem Is Nothing Then
            MessageBox.Show("Imagem não localizada", "Erro")
            Exit Sub
        End If
        Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
        Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
        fs.Write(tempImagem, 0, tempImagem.Length)
        fs.Flush()
        fs.Close()
        ImagemCarregada = Image.FromFile(strArquivo)
        pbImagem.Image = ImagemCarregada

    End Sub

    Private Sub alterar()
        Dim cmd As SqlCommand

        Try

            'CARREGANDO IMAGEM NO BANCO
            Dim MS As New IO.MemoryStream
            ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim byteArray = MS.ToArray

            abrir()
            cmd = New SqlCommand("pa_aluno_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.AddWithValue("@CodigoAluno", lblCodigo.Text)
            cmd.Parameters.AddWithValue("@NomeAluno", txtNomeAluno.Text)
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
            cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text)
            cmd.Parameters.AddWithValue("@estCivil", cmbEstCivil.Text)
            cmd.Parameters.AddWithValue("@dia", cmbDia.Text)
            cmd.Parameters.AddWithValue("@mes", cmbMes.Text)
            cmd.Parameters.AddWithValue("@ano", cmbAno.Text)
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text)
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@cep", txtCep.Text)
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
            cmd.Parameters.AddWithValue("@num", txtNum.Text)
            cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text)
            cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
            cmd.Parameters.AddWithValue("@uf", txtUF.Text)
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
            cmd.Parameters.AddWithValue("@imagem", byteArray)
            cmd.Parameters.AddWithValue("@NomePai", txtNomePai.Text)
            cmd.Parameters.AddWithValue("@OcupacaoPai", cmbOcupacaoPai.SelectedValue)
            cmd.Parameters.AddWithValue("@celularPai", txtCelPai.Text)
            cmd.Parameters.AddWithValue("@NomeMae", txtNomeMae.Text)
            cmd.Parameters.AddWithValue("@OcupacaoMae", cmbOcupacaoMae.SelectedValue)
            cmd.Parameters.AddWithValue("@celularMae", txtCelMae.Text)
            cmd.Parameters.AddWithValue("@NomeResp", txtNomeResp.Text)
            cmd.Parameters.AddWithValue("@OcupacaoResp", cmbOcupacaoResp.SelectedValue)
            cmd.Parameters.AddWithValue("@celularResp", txtCelResp.Text)
            cmd.Parameters.AddWithValue("@Observacao", txtObs.Text)
            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Limpar()
            Listar()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
        Finally
            fechar()

        End Try


    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If lblCodigo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este funcionário?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_aluno_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CodigoAluno", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscarCPF.Text = ""
        txtBuscarNome.Text = ""
        txtBuscarNome.Visible = True
        txtBuscarCPF.Visible = False
        txtBuscarNome.Focus()
        Listar()
    End Sub

    Private Sub rbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        txtBuscarCPF.Text = ""
        txtBuscarNome.Text = ""
        txtBuscarNome.Visible = False
        txtBuscarCPF.Visible = True
        txtBuscarCPF.Focus()
        Listar()
    End Sub

    Private Sub txtBuscarNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNome.TextChanged
        If txtBuscarNome.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_aluno_Nomebuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NomeAluno", txtBuscarNome.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtBuscarCPF_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBuscarCPF.MaskInputRejected
        If txtBuscarCPF.Text = "   .   .   -" And dg.Rows.Count > 0 Then
            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_aluno_Cpfbuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@cpf", txtBuscarCPF.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
            Finally

                fechar()
            End Try
        End If
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        tcAlunos.SelectedIndex = 1
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        tcAlunos.SelectedIndex = 0
    End Sub
End Class