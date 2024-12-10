Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class frmOcupacoes
    Private Sub frmOcupacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaGrid()


    End Sub

    Private Sub frmOcupacoes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        carregaGrid()
        ContarLinhas()
    End Sub


    Private Sub carregaGrid()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            da = New SqlDataAdapter("pa_ocupacao_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Cargos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub Limpar()
        txtOcupacao.Focus()
        txtOcupacao.Text = ""
    End Sub

    Private Sub FormatarDG()
        With dg
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Cargos"
            .Columns(1).Width = 150
        End With
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        Limpar()
        btSalvar.Enabled = True
        btEditar.Enabled = False
        btExcluir.Enabled = False
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtOcupacao.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_Ocupacao_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txtOcupacao.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                carregaGrid()
                Limpar()


            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Dim cmd As SqlCommand
        Try

            If txtOcupacao.Text.Equals(String.Empty) Then
                errErro.SetError(txtOcupacao, "Digite o nome de um Cargo")
                MsgBox("Selecione um dos Cargos listados")
                Exit Sub
            Else
                errErro.SetError(txtOcupacao, "")
            End If


            abrir()
            cmd = New SqlCommand("pa_ocupacao_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", lblOcupacao.Text)
            cmd.Parameters.AddWithValue("@nome", txtOcupacao.Text)

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            carregaGrid()
            Limpar()


        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o Cargo" + ex.Message.ToString)
            fechar()
        End Try
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If txtOcupacao.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este Cargo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_Ocupacao_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id", lblOcupacao.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                carregaGrid()
                Limpar()

                ' btnExcluir.Enabled = False
                '   btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub txtOcupacao_TextChanged(sender As Object, e As EventArgs) Handles txtOcupacao.TextChanged
        If txtOcupacao.Text = "" And dg.Rows.Count > 0 Then

            carregaGrid()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_ocupacao_listarNome", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txtOcupacao.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        btEditar.Enabled = True
        btExcluir.Enabled = True
        btSalvar.Enabled = False

        lblOcupacao.Text = dg.CurrentRow.Cells(0).Value
        txtOcupacao.Text = dg.CurrentRow.Cells(1).Value
    End Sub
End Class