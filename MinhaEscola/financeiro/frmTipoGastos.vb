Imports System.Data.SqlClient

Public Class frmTipoGastos
    Private Sub frmTipoGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub frmTipoGastos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            da = New SqlDataAdapter("pa_tipoGastos_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Tipos de gastos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub Limpar()
        txtTipoGasto.Focus()
        txtTipoGasto.Text = ""
    End Sub

    Private Sub FormatarDG()
        With dg
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Tipo de Gasto"
            .Columns(1).Width = 150
        End With
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        Limpar()
        btSalvar.Enabled = True
        btEditar.Enabled = False
        btExcluir.Enabled = False
        txtTipoGasto.Enabled = True
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtTipoGasto.Text <> "" Then

            Try

                If txtTipoGasto.Text.Equals(String.Empty) Then
                    errErro.SetError(txtTipoGasto, "Digite um tipo de gasto")
                    MsgBox("Selecione um dos tipos de gastos listados")
                    Exit Sub
                Else
                    errErro.SetError(txtTipoGasto, "")
                End If

                abrir()
                cmd = New SqlCommand("pa_tipoGastos_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@tipoGasto", txtTipoGasto.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Listar()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        btEditar.Enabled = True
        btExcluir.Enabled = True
        btSalvar.Enabled = False

        lblTipoGasto.Text = dg.CurrentRow.Cells(0).Value
        txtTipoGasto.Text = dg.CurrentRow.Cells(1).Value
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Dim cmd As SqlCommand
        Try

            If txtTipoGasto.Text.Equals(String.Empty) Then
                errErro.SetError(txtTipoGasto, "Digite um tipo de gasto")
                MsgBox("Selecione um dos tipos de gastos listados")
                Exit Sub
            Else
                errErro.SetError(txtTipoGasto, "")
            End If


            abrir()
            cmd = New SqlCommand("pa_tipoGastos_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idTipo", lblTipoGasto.Text)
            cmd.Parameters.AddWithValue("@tipoGasto", txtTipoGasto.Text)

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

            Listar()
            Limpar()


        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o tipo de gasto" + ex.Message.ToString)
            fechar()
        End Try
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If txtTipoGasto.Text <> "" Then

            Try
                If txtTipoGasto.Text.Equals(String.Empty) Then
                    errErro.SetError(txtTipoGasto, "Digite um tipo de gasto")
                    MsgBox("Selecione um dos tipos de gastos listados")
                    Exit Sub
                Else
                    errErro.SetError(txtTipoGasto, "")
                End If

                If (MessageBox.Show("Deseja excluir este tipo de gasto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_tipoGastos_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@idTipo", lblTipoGasto.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
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

    Private Sub txtTipoGasto_TextChanged(sender As Object, e As EventArgs) Handles txtTipoGasto.TextChanged
        If txtTipoGasto.Text = "" And dg.Rows.Count > 0 Then

            Listar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                If txtTipoGasto.Text.Equals(String.Empty) Then
                    errErro.SetError(txtTipoGasto, "Digite um tipo de gasto")
                    MsgBox("Selecione um dos tipos de gastos listados")
                    Exit Sub
                Else
                    errErro.SetError(txtTipoGasto, "")
                End If


                abrir()
                da = New SqlDataAdapter("pa_tipoGastos_listartipoGastos", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@tipoGasto", txtTipoGasto.Text)

                da.Fill(dt)
                dg.DataSource = dt

                ContarLinhas()

            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub
End Class