Imports System.Data.SqlClient
Imports System.Data.IO
Imports System.Text.RegularExpressions


Public Class frmEscola

    Private Sub frmEscola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub frmEscola_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
    End Sub
    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_empresa_listar", con)

            da.Fill(dt)
            dg.DataSource = dt


            '  FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os dados da Escola" + ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()

        With dg
            .Columns(0).Visible = False
            .Columns(2).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False

            .Columns(1).HeaderText = "CNPJ"
            .Columns(2).HeaderText = "ABERTURA"
            .Columns(3).HeaderText = "Nome da Empresa"
            .Columns(4).HeaderText = "Fantasia"
            .Columns(5).HeaderText = "Endereço N°"
            .Columns(6).HeaderText = "Nº "
            .Columns(7).HeaderText = "Compl."
            .Columns(8).HeaderText = "Bairro"
            .Columns(9).HeaderText = "Cidade"
            .Columns(10).HeaderText = "UF"
            .Columns(11).HeaderText = "Cep"
            .Columns(12).HeaderText = "Telefone"
            .Columns(13).HeaderText = "Email"
            .Columns(14).HeaderText = "Situação"
            .Columns(15).HeaderText = "Motivo"
            .Columns(16).HeaderText = "Contato"
            .Columns(17).HeaderText = "Tel. Contato"
            .Columns(18).HeaderText = "Dt. Cadastro"

            .Columns(1).Width = 150
            .Columns(2).Width = 300
        End With

    End Sub


    Private Sub Limpar()
        txtCNPJ.Focus()
        txtCNPJ.Text = ""
        txtRazaoSocial.Text = ""
        txtFantasia.Text = ""
        txtTel.Text = ""
        txtEmail.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtCompl.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtUF.Text = Nothing
        txtCEP.Text = ""
        txtMotivo.Text = ""
        txtSituacao.Text = ""
        txtAbertura.Text = ""
        txtContato.Text = ""
        txtTelContato.Text = ""

    End Sub

    Private Sub btBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles btBuscarEmpresa.Click
        If txtCNPJ.Text.Equals(String.Empty) Then
            errErro.SetError(txtCNPJ, "Digite um CNPJ válido")
            Exit Sub
        Else
            errErro.SetError(txtCNPJ, "")
        End If

        '  If validaCNPJ() Then
        ObterCnpj(txtCNPJ.Text)
    End Sub

    Private Sub ObterCnpj(cnpj As String)

        Dim cliente = Empresa.ObterCnpj(cnpj)

        '   MessageBox.Show("CNPJ Incorreto, digite um CNPJ válido!!!", "ERRO")

        Try
            txtRazaoSocial.Text = cliente.nome
            txtSituacao.Text = cliente.situacao
            txtAbertura.Text = cliente.abertura
            txtFantasia.Text = cliente.fantasia
            txtMotivo.Text = UTF8_to_ISO(cliente.motivo_situacao)
            txtEndereco.Text = cliente.logradouro
            txtNumero.Text = cliente.numero
            txtCompl.Text = cliente.complemento
            txtBairro.Text = cliente.bairro
            txtCEP.Text = cliente.cep
            txtCidade.Text = cliente.municipio
            txtUF.Text = cliente.uf
            txtTel.Text = cliente.telefone
            txtEmail.Text = cliente.email


        Catch ex As Exception

            '  MessageBox.Show("CNPJ Incorreto, digite um CNPJ válido!!!" + ex.Message.ToString)
            MessageBox.Show("CNPJ Incorreto, digite um CNPJ válido!!!", "ERRO")
        End Try

    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtCNPJ.Text <> "" And txtRazaoSocial.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_empresa_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cnpj", txtCNPJ.Text)
                cmd.Parameters.AddWithValue("@abertura", txtAbertura.Text)
                cmd.Parameters.AddWithValue("@razaoSocial", txtRazaoSocial.Text)
                cmd.Parameters.AddWithValue("@nomeFantasia", txtFantasia.Text)
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@num", txtNumero.Text)
                cmd.Parameters.AddWithValue("@compl", txtCompl.Text)
                cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text)
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text)
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text)
                cmd.Parameters.AddWithValue("@UF", txtUF.Text)
                cmd.Parameters.AddWithValue("@cep", txtCEP.Text)
                cmd.Parameters.AddWithValue("@telefone", txtTel.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@situacao", txtSituacao.Text)
                cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text)
                cmd.Parameters.AddWithValue("@contato", txtContato.Text)
                cmd.Parameters.AddWithValue("@telcontato", txtTelContato.Text)
                cmd.Parameters.AddWithValue("@data_cadastro", Now.ToShortDateString)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Listar()
                Limpar()

                'btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar o Fornecedor" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub


    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub


End Class