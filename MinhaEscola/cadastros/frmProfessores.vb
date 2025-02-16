Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmProfessores
    Dim imgNome As String
    Private ImagemCarregada As Image
    Private _create As Net.HttpWebRequest

    Private Sub frmProfessores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        carregarImagem()
        carregarDisciplina()

        Listar()
        btSalvarEditar.Enabled = False
    End Sub

    Private Sub frmProfessores_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Listar()
        carregarDisciplina()

    End Sub

    Sub carregarDisciplina()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_disciplina_listar", con)
            DA.Fill(DT)

            txtDisciplina.ValueMember = "idDisciplina"
            txtDisciplina.DisplayMember = "disciplina"
            txtDisciplina.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtCPF.Enabled = False
        txtRG.Enabled = False
        txtNacionalidade.Enabled = False
        cmbSexo.Enabled = False
        txtTitulo.Enabled = False
        cmbEstCivil.Enabled = False
        cmbDia.Enabled = False
        cmbMes.Enabled = False
        cmbAno.Enabled = False
        txtTelefone.Enabled = False
        txtCelular.Enabled = False
        txtEmail.Enabled = False
        txtNum.Enabled = False
        txtCompl.Enabled = False
        txtQuantAulas.Enabled = False
        txtCargaHorariaAula.Enabled = False
        txtCargaHorariaTotal.Enabled = False
        txtDataAdmissao.Enabled = False
        txtDataDemissao.Enabled = False
        txtTurnosLeciona.Enabled = False
        txtEscolaridade.Enabled = False
        txtPosGraduacao.Enabled = False
        txtInstituicao.Enabled = False
        txtStatus.Enabled = False
        txtCodInep.Enabled = False
        txtorgaoRegistro.Enabled = False
        txtCodRegistro.Enabled = False
        txtObs.Enabled = False
        txtDtAtualizacao.Enabled = False
        txtDtRegistroFalta.Enabled = False
        txtAulaRegistroFalta.Enabled = False
        txtAnotarRegistroFalta.Enabled = False
        txtCodDisciplina.Enabled = False
        txtDisciplina.Enabled = False
        txtValorDisciplina.Enabled = False
        txtTurmaDisciplina.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNome.Focus()
        txtNome.Enabled = True
        txtCPF.Enabled = True
        txtRG.Enabled = True
        txtNacionalidade.Enabled = True
        cmbSexo.Enabled = True
        txtTitulo.Enabled = True
        cmbEstCivil.Enabled = True
        cmbDia.Enabled = True
        cmbMes.Enabled = True
        cmbAno.Enabled = True
        txtTelefone.Enabled = True
        txtCelular.Enabled = True
        txtEmail.Enabled = True
        txtNum.Enabled = True
        txtCompl.Enabled = True
        txtQuantAulas.Enabled = True
        txtCargaHorariaAula.Enabled = True
        txtCargaHorariaTotal.Enabled = True
        txtDataAdmissao.Enabled = True
        txtDataDemissao.Enabled = True
        txtTurnosLeciona.Enabled = True
        txtEscolaridade.Enabled = True
        txtPosGraduacao.Enabled = True
        txtInstituicao.Enabled = True
        txtStatus.Enabled = True
        txtCodInep.Enabled = True
        txtorgaoRegistro.Enabled = True
        txtCodRegistro.Enabled = True
        txtObs.Enabled = True
        txtDtAtualizacao.Enabled = True
        txtDtRegistroFalta.Enabled = True
        txtAulaRegistroFalta.Enabled = True
        txtAnotarRegistroFalta.Enabled = True
        txtCodDisciplina.Enabled = True
        txtDisciplina.Enabled = True
        txtValorDisciplina.Enabled = True
        txtTurmaDisciplina.Enabled = True
    End Sub

    Private Sub Limpar()

        lblCodigo.Text = 0
        txtNome.Text = ""
        txtCPF.Text = ""
        txtRG.Text = ""
        txtNacionalidade.Text = ""
        cmbSexo.Text = Nothing
        txtTitulo.Text = ""
        cmbEstCivil.Text = ""
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
        txtQuantAulas.Text = 0
        txtCargaHorariaAula.Text = 0
        txtCargaHorariaTotal.Text = 0
        txtDataAdmissao.Text = ""
        txtDataDemissao.Text = ""
        txtTurnosLeciona.Text = Nothing
        txtEscolaridade.Text = Nothing
        txtPosGraduacao.Text = Nothing
        txtInstituicao.Text = ""
        txtStatus.Text = Nothing
        txtCodInep.Text = ""
        txtorgaoRegistro.Text = ""
        txtCodRegistro.Text = ""
        txtObs.Text = ""
        txtDtAtualizacao.Text = ""
        txtDtRegistroFalta.Text = ""
        txtAulaRegistroFalta.Text = ""
        txtAnotarRegistroFalta.Text = ""
        txtCodDisciplina.Text = ""
        txtDisciplina.Text = Nothing
        txtValorDisciplina.Text = ""
        txtTurmaDisciplina.Text = ""

        carregarImagem()

    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_professor_listar", con)
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
            '.Columns(20).Visible = False
            '.Columns(3).Visible = False
            '.Columns(4).Visible = False
            '.Columns(5).Visible = False
            '.Columns(6).Visible = False
            '.Columns(31).Visible = False
            '.Columns(32).Visible = False
            .Columns(33).Visible = False
            .Columns(34).Visible = False
            .Columns(35).Visible = False
            '.Columns(36).Visible = False
            .Columns(37).Visible = False

            .Columns(0).HeaderText = "Codigo"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "CPF"
            .Columns(3).HeaderText = "RG"
            .Columns(4).HeaderText = "Nacionalidade"
            .Columns(5).HeaderText = "Sexo"
            .Columns(6).HeaderText = "Título"
            .Columns(7).HeaderText = "Esr.Civil"
            .Columns(8).HeaderText = "Dia de Nasc."
            .Columns(9).HeaderText = "Mês de Nasc."
            .Columns(10).HeaderText = "Ano de Nasc."
            .Columns(11).HeaderText = "Telefone"
            .Columns(12).HeaderText = "Celular"
            .Columns(13).HeaderText = "Email"
            .Columns(14).HeaderText = "Cep"
            .Columns(15).HeaderText = "Endereço"
            .Columns(16).HeaderText = "Num."
            .Columns(17).HeaderText = "Complemento"
            .Columns(18).HeaderText = "Compl 2"
            .Columns(19).HeaderText = "UF"
            .Columns(20).HeaderText = "Bairro"
            .Columns(21).HeaderText = "Cidade"
            .Columns(22).HeaderText = "Foto"
            .Columns(23).HeaderText = "Quant. Aulas"
            .Columns(24).HeaderText = "Carga Horaria Aula"
            .Columns(25).HeaderText = "Carga Horaria Total"
            .Columns(26).HeaderText = "Dt Admissão"
            .Columns(27).HeaderText = "Dt demissão"
            .Columns(28).HeaderText = "Turnos"
            .Columns(29).HeaderText = "Escolaridade"
            .Columns(30).HeaderText = "Pós Graduação"
            .Columns(31).HeaderText = "Instituição"
            .Columns(32).HeaderText = "Status"
            .Columns(33).HeaderText = "Cod. Inep"
            .Columns(34).HeaderText = "Orgao Registro"
            .Columns(35).HeaderText = "Cod. Registro"
            .Columns(36).HeaderText = "Obs."
            .Columns(37).HeaderText = "Dt Atualização"
            .Columns(38).HeaderText = "Dt Registro Falta"
            .Columns(39).HeaderText = "Aula Faltante"
            .Columns(40).HeaderText = "Anotação da Falta"
            .Columns(41).HeaderText = "Nacionalidade"
            .Columns(42).HeaderText = "Cod. Disciplina"
            .Columns(43).HeaderText = "Disciplina"
            .Columns(44).HeaderText = "Valor"
            .Columns(45).HeaderText = "Turma"



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

    Private Sub btImagem_Click(sender As Object, e As EventArgs) Handles btImagem.Click
        pbImagem.Visible = True
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"}

            If OFD.ShowDialog = DialogResult.OK Then
                ImagemCarregada = Image.FromFile(OFD.FileName)
                pbImagem.Image = ImagemCarregada
            End If
        End Using
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
                da = New SqlDataAdapter("pa_professor_Nomebuscar", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NomeProfessor", txtBuscarNome.Text)

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
        If txtBuscarCPF.Text = "   .   .   - " And dg.Rows.Count > 0 Then
            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_professor_Cpfbuscar", con)
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

    Private Sub btProximoInformacao_Click(sender As Object, e As EventArgs) Handles btProximoInformacao.Click
        tcProfessores.SelectedIndex = 1

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

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If lblCodigo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este Professor?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_professor_Excluir", con)   '@CodigoProfessor
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CodigoProfessor", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub gravar()

        Dim cmd As SqlCommand

        Try

            Dim valorDisciplina = Replace(txtValorDisciplina.Text, ",", ".")

            'CARREGANDO IMAGEM NO BANCO
            Dim MS As New IO.MemoryStream
            ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim byteArray = MS.ToArray

            abrir()
            cmd = New SqlCommand("pa_professor_Salvar", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@NomeProfessor", txtNome.Text)
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
            cmd.Parameters.AddWithValue("@rg", txtRG.Text)
            cmd.Parameters.AddWithValue("@nacionalidade", txtNacionalidade.Text)
            cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text)
            cmd.Parameters.AddWithValue("@titEleitoral", txtTitulo.Text)
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
            cmd.Parameters.AddWithValue("@UF", txtUF.Text)
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
            cmd.Parameters.AddWithValue("@imagem", byteArray)
            cmd.Parameters.AddWithValue("@qtdAulas", txtQuantAulas.Text)
            cmd.Parameters.AddWithValue("@cargaHorariaAulas", txtCargaHorariaAula.Text)
            cmd.Parameters.AddWithValue("@cargaTotalAulas", txtCargaHorariaTotal.Text)
            cmd.Parameters.AddWithValue("@dtAdmissao", txtDataAdmissao.Text)
            cmd.Parameters.AddWithValue("@dtDemissao", txtDataDemissao.Text)
            cmd.Parameters.AddWithValue("@turno", txtTurnosLeciona.Text)
            cmd.Parameters.AddWithValue("@escolaridade", txtEscolaridade.Text)
            cmd.Parameters.AddWithValue("@posGraduacao", txtPosGraduacao.Text)
            cmd.Parameters.AddWithValue("@instituicao", txtInstituicao.Text)
            cmd.Parameters.AddWithValue("@StatusProfessor", txtStatus.Text)
            cmd.Parameters.AddWithValue("@CodINEP", txtCodInep.Text)
            cmd.Parameters.AddWithValue("@orgaoRegistro", txtorgaoRegistro.Text)
            cmd.Parameters.AddWithValue("@codigoRegistro", txtCodRegistro.Text)
            cmd.Parameters.AddWithValue("@ObsProfessor", txtObs.Text)
            cmd.Parameters.AddWithValue("@dtAtualizacao", txtDtAtualizacao.Text)
            cmd.Parameters.AddWithValue("@dtRegistroFaltas", txtDtRegistroFalta.Text)
            cmd.Parameters.AddWithValue("@aulasfalta", txtAulaRegistroFalta.Text)
            cmd.Parameters.AddWithValue("@anotacaoFaltas", txtAnotarRegistroFalta.Text)
            cmd.Parameters.AddWithValue("@CodigoDisciplina", txtCodDisciplina.Text)
            cmd.Parameters.AddWithValue("@idDisciplina", txtDisciplina.SelectedValue)
            cmd.Parameters.AddWithValue("@valorDisciplina", valorDisciplina)
            cmd.Parameters.AddWithValue("@turma", txtTurmaDisciplina.Text)
            cmd.Parameters.AddWithValue("@DataCadProfessor", Now.ToShortDateString)
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

    Private Sub alterar()
        Dim cmd As SqlCommand

        Try

            Dim valorDisciplina = Replace(txtValorDisciplina.Text, ",", ".")

            'CARREGANDO IMAGEM NO BANCO
            Dim MS As New IO.MemoryStream
            ImagemCarregada.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim byteArray = MS.ToArray

            abrir()
            cmd = New SqlCommand("pa_professor_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.AddWithValue("@CodigoAluno", lblCodigo.Text)
            cmd.Parameters.AddWithValue("@NomeProfessor", txtNome.Text)
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text)
            'cmd.Parameters.AddWithValue("@rg", txtRG.Text)
            cmd.Parameters.AddWithValue("@nacionalidade", txtNacionalidade.Text)
            cmd.Parameters.AddWithValue("@sexo", cmbSexo.Text)
            cmd.Parameters.AddWithValue("@titEleitoral", txtTitulo.Text)
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
            cmd.Parameters.AddWithValue("@UF", txtUF.Text)
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
            cmd.Parameters.AddWithValue("@imagem", byteArray)
            cmd.Parameters.AddWithValue("@qtdAulas", txtQuantAulas.Text)
            cmd.Parameters.AddWithValue("@cargaHorariaAulas", txtCargaHorariaAula.Text)
            cmd.Parameters.AddWithValue("@cargaTotalAulas", txtCargaHorariaTotal.Text)
            cmd.Parameters.AddWithValue("@dtAdmissao", txtDataAdmissao.Text)
            cmd.Parameters.AddWithValue("@dtDemissao", txtDataDemissao.Text)
            cmd.Parameters.AddWithValue("@turno", txtTurnosLeciona.Text)
            cmd.Parameters.AddWithValue("@escolaridade", txtEscolaridade.Text)
            cmd.Parameters.AddWithValue("@posGraduacao", txtPosGraduacao.Text)
            cmd.Parameters.AddWithValue("@instituicao", txtInstituicao.Text)
            cmd.Parameters.AddWithValue("@StatusProfessor", txtStatus.Text)
            cmd.Parameters.AddWithValue("@CodINEP", txtCodInep.Text)
            cmd.Parameters.AddWithValue("@orgaoRegistro", txtorgaoRegistro.Text)
            cmd.Parameters.AddWithValue("@codigoRegistro", txtCodRegistro.Text)
            cmd.Parameters.AddWithValue("@ObsProfessor", txtObs.Text)
            cmd.Parameters.AddWithValue("@dtAtualizacao", txtDtAtualizacao.Text)
            cmd.Parameters.AddWithValue("@dtRegistroFaltas", txtDtRegistroFalta.Text)
            cmd.Parameters.AddWithValue("@aulasfalta", txtAulaRegistroFalta.Text)
            cmd.Parameters.AddWithValue("@anotacaoFaltas", txtAnotarRegistroFalta.Text)
            cmd.Parameters.AddWithValue("@CodigoDisciplina", txtCodDisciplina.Text)
            cmd.Parameters.AddWithValue("@idDisciplina", txtDisciplina.SelectedValue)
            cmd.Parameters.AddWithValue("@valorDisciplina", valorDisciplina)
            cmd.Parameters.AddWithValue("@turma", txtTurmaDisciplina.Text)
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

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick

        HabilitarCampos()

        txtCPF.Enabled = False
        txtRG.Enabled = False

        btSalvarEditar.Enabled = True
        btnExcluir.Enabled = True

        lblCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNome.Text = dg.CurrentRow.Cells(1).Value
        txtCPF.Text = dg.CurrentRow.Cells(2).Value
        txtRG.Text = dg.CurrentRow.Cells(3).Value
        txtNacionalidade.Text = dg.CurrentRow.Cells(4).Value
        cmbSexo.Text = dg.CurrentRow.Cells(5).Value
        txtTitulo.Text = dg.CurrentRow.Cells(6).Value
        cmbEstCivil.Text = dg.CurrentRow.Cells(7).Value
        cmbDia.Text = dg.CurrentRow.Cells(8).Value
        cmbMes.Text = dg.CurrentRow.Cells(9).Value
        cmbAno.Text = dg.CurrentRow.Cells(10).Value
        txtTelefone.Text = dg.CurrentRow.Cells(11).Value
        txtCelular.Text = dg.CurrentRow.Cells(12).Value
        txtEmail.Text = dg.CurrentRow.Cells(13).Value
        txtCep.Text = dg.CurrentRow.Cells(14).Value
        txtEndereco.Text = dg.CurrentRow.Cells(15).Value
        txtNum.Text = dg.CurrentRow.Cells(16).Value
        txtComplemento.Text = dg.CurrentRow.Cells(17).Value
        txtCompl.Text = dg.CurrentRow.Cells(18).Value
        txtUF.Text = dg.CurrentRow.Cells(19).Value
        txtBairro.Text = dg.CurrentRow.Cells(20).Value
        txtCidade.Text = dg.CurrentRow.Cells(21).Value
        ' pbImagem = dg.CurrentRow.Cells(22).Value
        txtQuantAulas.Text = dg.CurrentRow.Cells(23).Value
        txtCargaHorariaAula.Text = dg.CurrentRow.Cells(24).Value
        txtCargaHorariaTotal.Text = dg.CurrentRow.Cells(25).Value
        txtDataAdmissao.Text = dg.CurrentRow.Cells(26).Value
        txtDataDemissao.Text = dg.CurrentRow.Cells(27).Value
        txtTurnosLeciona.Text = dg.CurrentRow.Cells(28).Value
        txtEscolaridade.Text = dg.CurrentRow.Cells(29).Value
        txtPosGraduacao.Text = dg.CurrentRow.Cells(30).Value
        txtInstituicao.Text = dg.CurrentRow.Cells(31).Value
        txtStatus.Text = dg.CurrentRow.Cells(32).Value
        txtCodInep.Text = dg.CurrentRow.Cells(33).Value
        txtorgaoRegistro.Text = dg.CurrentRow.Cells(34).Value
        txtCodRegistro.Text = dg.CurrentRow.Cells(35).Value
        txtObs.Text = dg.CurrentRow.Cells(36).Value
        txtDtAtualizacao.Text = dg.CurrentRow.Cells(37).Value
        txtDtRegistroFalta.Text = dg.CurrentRow.Cells(38).Value
        txtAulaRegistroFalta.Text = dg.CurrentRow.Cells(39).Value
        txtAnotarRegistroFalta.Text = dg.CurrentRow.Cells(40).Value
        txtCodDisciplina.Text = dg.CurrentRow.Cells(41).Value
        txtDisciplina.Text = dg.CurrentRow.Cells(42).Value
        txtValorDisciplina.Text = dg.CurrentRow.Cells(43).Value
        txtTurmaDisciplina.Text = dg.CurrentRow.Cells(44).Value


        Dim tempImagem As Byte() = DirectCast(dg.CurrentRow.Cells(22).Value, Byte())
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

    Private Sub btProximoRegistro_Click(sender As Object, e As EventArgs) Handles btProximoRegistro.Click
        tcProfessores.SelectedIndex = 2
    End Sub

    Private Sub btProximoHistorico_Click(sender As Object, e As EventArgs) Handles btProximoHistorico.Click
        tcProfessores.SelectedIndex = 3
    End Sub

    Private Sub btVoltarProfessor_Click(sender As Object, e As EventArgs) Handles btVoltarProfessor.Click
        tcProfessores.SelectedIndex = 0
    End Sub

    Private Sub btInserirDisciplina_Click(sender As Object, e As EventArgs) Handles btInserirDisciplina.Click

    End Sub

    Private Sub ListarDisciplinas()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim dr As SqlDataReader = Nothing
        Dim sql As String
        Dim cmd As SqlCommand

        Try
            abrir()
            'da = New SqlDataAdapter(pa_professor_listarDisciplina", con)
            'da.SelectCommand.CommandType = CommandType.StoredProcedure

            'da.Fill(dt)
            'dg.DataSource = dt
            sql = "
            Select codigoDisciplina,valor,turma FROM tbDisciplinas WHERE disciplina='" & txtDisciplina.Text & "'"
            cmd = New SqlCommand(sql, con)

            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

            If dr.HasRows Then
                dr.Read()
                txtCodDisciplina.Text = dr.Item("codigoDisciplina")
                txtValorDisciplina.Text = dr.Item("valor")
                txtTurmaDisciplina.Text = dr.Item("turma")
            End If

            ContarLinhas()

            ' FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Alunos" + ex.Message.ToString)
        Finally

            fechar()
        End Try
    End Sub

    Private Sub ContarQuantDisciplinas()
        Dim total As Integer = dgDisciplina.Rows.Count
        lblquantDisc.Text = CInt(total)

    End Sub

    Private Sub txtDisciplina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtDisciplina.SelectedIndexChanged
        ListarDisciplinas()
    End Sub
End Class