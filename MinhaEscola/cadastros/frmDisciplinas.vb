Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmDisciplinas
    Private Sub frmDisciplinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaGrid()
        ContarLinhas()
    End Sub

    Private Sub frmDisciplinas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        carregaGrid()
        ContarLinhas()
    End Sub

    Private Sub carregaGrid()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            da = New SqlDataAdapter("pa_disciplina_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as Disciplinas" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub txtDisciplina_TextChanged(sender As Object, e As EventArgs) Handles txtDisciplina.TextChanged
        If txtCodigoDisciplina.Text = "" And txtDisciplina.Text = "" And dg.Rows.Count > 0 Then

            carregaGrid()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("pa_disciplina_listarNome", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@disciplina", txtDisciplina.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub DesabilitarCampos()
        txtCodigoDisciplina.Enabled = False
        txtDisciplina.Enabled = False
        txtValor.Enabled = False
        txtTurma.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        txtCodigoDisciplina.Focus()
        txtCodigoDisciplina.Enabled = True
        txtDisciplina.Enabled = True
        txtValor.Enabled = True
        txtTurma.Enabled = True
    End Sub

    Private Sub Limpar()
        lblID.Text = 0
        txtCodigoDisciplina.Focus()
        txtCodigoDisciplina.Text = ""
        txtDisciplina.Text = ""
        txtValor.Text = ""
        txtTurma.Text = ""

    End Sub

    Private Sub FormatarDG()
        With dg
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Código"
            .Columns(2).HeaderText = "Disciplina"
            .Columns(3).HeaderText = "Valor"
            .Columns(4).HeaderText = "Turma"

            .Columns(1).Width = 50
            .Columns(2).Width = 150
            .Columns(3).Width = 70
            .Columns(4).Width = 70
        End With
    End Sub
    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        HabilitarCampos()
        Limpar()
        btSalvar.Enabled = True

    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtCodigoDisciplina.Text <> "" Then

            Try

                Dim valor = Replace(txtValor.Text, ",", ".")

                abrir()
                cmd = New SqlCommand("pa_disciplina_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@codigoDisciplina", txtCodigoDisciplina.Text)
                cmd.Parameters.AddWithValue("@disciplina", txtDisciplina.Text)
                cmd.Parameters.AddWithValue("@valor", valor)
                cmd.Parameters.AddWithValue("@turma", txtTurma.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                carregaGrid()
                Limpar()


            Catch ex As Exception
                MessageBox.Show("Erro ao salvar esta disciplina" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Dim cmd As SqlCommand
        Try

            If txtCodigoDisciplina.Text.Equals(String.Empty) Then
                errErro.SetError(txtCodigoDisciplina, "Digite o nome de uma disciplina")
                MsgBox("Selecione uma das disciplinas listados")
                Exit Sub
            Else
                errErro.SetError(txtCodigoDisciplina, "")
            End If

            Dim valor = Replace(txtValor.Text, ",", ".")

            abrir()
            cmd = New SqlCommand("pa_disciplina_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idDisciplina", lblID.Text)
            cmd.Parameters.AddWithValue("@codigoDisciplina", txtCodigoDisciplina.Text)
            cmd.Parameters.AddWithValue("@disciplina", txtDisciplina.Text)
            cmd.Parameters.AddWithValue("@valor", valor)
            cmd.Parameters.AddWithValue("@turma", txtTurma.Text)

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            carregaGrid()
            Limpar()


        Catch ex As Exception
            MessageBox.Show("Erro ao editar esta disciplina" + ex.Message.ToString)
            fechar()
        End Try
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If txtCodigoDisciplina.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir esta Disciplina?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_disciplina_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@idDisciplina", lblID.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                carregaGrid()
                Limpar()

                btExcluir.Enabled = False
                btEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir esta Disciplina" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        btEditar.Enabled = True
        btExcluir.Enabled = True
        btSalvar.Enabled = False

        lblID.Text = dg.CurrentRow.Cells(0).Value
        txtCodigoDisciplina.Text = dg.CurrentRow.Cells(1).Value
        txtDisciplina.Text = dg.CurrentRow.Cells(2).Value
        txtValor.Text = dg.CurrentRow.Cells(3).Value
        txtTurma.Text = dg.CurrentRow.Cells(4).Value
    End Sub
End Class