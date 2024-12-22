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
            dg.DataSource = dt

            ContarLinhas()

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Cursos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub Limpar()
        txtCurso.Focus()
        txtCurso.Text = ""
        txtValor.Text = ""
        txtValor.Text = "R$ 0,00"
    End Sub

    Private Sub FormatarDG()
        With dg

            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False
            .MultiSelect = False

            'altera a cor das linhas alternadas no grid
            .RowsDefaultCellStyle.BackColor = Color.White

            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Cursos"
            .Columns(2).HeaderText = "Valor"
            .Columns(1).Width = 150

            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).DefaultCellStyle.Format = "c"
            .Columns(2).DefaultCellStyle.ForeColor = Color.Red
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            'permite que o texto maior que célula não seja truncado
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub DesabilitarCampos()
        txtCurso.Enabled = False
        txtValor.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtCurso.Enabled = True
        txtValor.Enabled = True
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
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

            cmd.Parameters.AddWithValue("@NomeCurso", txtCurso.Text)
            cmd.Parameters.AddWithValue("@ValorCurso", vlValor)
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

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        btSalvarEditar.Enabled = True
        btnExcluir.Enabled = True

        lblCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtCurso.Text = dg.CurrentRow.Cells(1).Value
        txtValor.Text = dg.CurrentRow.Cells(2).Value
    End Sub

    Private Sub alterar()
        Dim cmd As SqlCommand

        Try
            Dim vlValor = Replace(txtValor.Text, ",", ".")

            abrir()
            cmd = New SqlCommand("pa_curso_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CodigoCurso", lblCodigo.Text)
            cmd.Parameters.AddWithValue("@NomeCurso", txtCurso.Text)
            cmd.Parameters.AddWithValue("@ValorCurso", vlValor)
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

                abrir()
                cmd = New SqlCommand("pa_curso_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CodigoCurso", lblCodigo.Text)
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