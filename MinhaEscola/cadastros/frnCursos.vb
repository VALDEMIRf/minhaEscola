Imports System.Data.SqlClient

Public Class frnCursos
    Private Sub frnCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        DesabilitarCampos()
    End Sub

    Private Sub frnCursos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            da = New SqlDataAdapter("pa_curso_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dgvCursos.DataSource = dt

            ContarLinhas()

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Cursos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub Limpar()
        txtCodigo.Focus()
        txtCurso.Text = ""
        txtValor.Text = ""
        txtCodigo.Text = ""
        txtTurma.Text = ""

    End Sub

    Private Sub FormatarDG()
        With dgvCursos

            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Código"
            .Columns(2).HeaderText = "Curso"
            .Columns(3).HeaderText = "Valor"
            .Columns(4).HeaderText = "Turma"

            .Columns(1).Width = 50
            .Columns(2).Width = 150
            .Columns(3).Width = 70
            .Columns(4).Width = 70
        End With
    End Sub

    Private Sub DesabilitarCampos()
        txtCurso.Enabled = False
        txtValor.Enabled = False
        txtCodigo.Enabled = False
        txtTurma.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        txtCurso.Enabled = True
        txtValor.Enabled = True
        txtCodigo.Enabled = True
        txtTurma.Enabled = True
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgvCursos.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        HabilitarCampos()
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

            Dim vlValor = Replace(txtValor.Text, ",", ".")

            abrir()

            cmd = New SqlCommand("pa_curso_Salvar", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@codigoCurso", txtCodigo.Text)
            cmd.Parameters.AddWithValue("@NomeCurso", txtCurso.Text)
            cmd.Parameters.AddWithValue("@ValorCurso", vlValor)
            cmd.Parameters.AddWithValue("@turma", txtTurma.Text)
            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            Listar()
            Limpar()

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar este curso" + ex.Message.ToString)
        Finally
            fechar()

        End Try
    End Sub



    Private Sub dgvCursos_Click(sender As Object, e As EventArgs) Handles dgvCursos.Click
        btSalvarEditar.Enabled = True
        btnExcluir.Enabled = True

        lblCodigo.Text = dgvCursos.CurrentRow.Cells(0).Value
        txtCodigo.Text = dgvCursos.CurrentRow.Cells(1).Value
        txtCurso.Text = dgvCursos.CurrentRow.Cells(2).Value
        txtValor.Text = dgvCursos.CurrentRow.Cells(3).Value
        txtTurma.Text = dgvCursos.CurrentRow.Cells(4).Value
    End Sub

    Private Sub alterar()
        Dim cmd As SqlCommand

        Try


            If txtCurso.Text.Equals(String.Empty) Then
                ErrorProvider1.SetError(txtCurso, "Digite o nome de um curso")
                MsgBox("Selecione um dos cursos listados")
                Exit Sub
            Else
                ErrorProvider1.SetError(txtCurso, "")
            End If

            Dim vlValor = Replace(txtValor.Text, ",", ".")

            abrir()
            cmd = New SqlCommand("pa_curso_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idCurso", lblCodigo.Text)
            cmd.Parameters.AddWithValue("@codigoCurso", txtCodigo.Text)
            cmd.Parameters.AddWithValue("@NomeCurso", txtCurso.Text)
            cmd.Parameters.AddWithValue("@ValorCurso", vlValor)
            cmd.Parameters.AddWithValue("@turma", txtTurma.Text)
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
                If (MessageBox.Show("Deseja excluir este curso?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                ' int,
                abrir()
                cmd = New SqlCommand("pa_curso_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@idCurso", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao excluir este Curso" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        ' Utils.TextBoxMoeda(txtValor)
    End Sub

    Private Sub txtValor_LostFocus(sender As Object, e As EventArgs) Handles txtValor.LostFocus
        ' txtValor.Text = FormatCurrency(txtValor.Text)
    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub


End Class