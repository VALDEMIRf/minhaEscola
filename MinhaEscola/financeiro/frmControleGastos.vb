Imports System.Data.SqlClient

Public Class frmControleGastos

    ' Dim usrUsuarioLogin As New clsUsuario

    Private Sub frmControleGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        Listar()

        carregarTipoGastos()
    End Sub

    Private Sub frmControleGastos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
    End Sub

    Sub carregarTipoGastos()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_tipoGastos_listar", con)
            DA.Fill(DT)
            cmbTipoGasto.DisplayMember = "tipoGasto"
            cmbTipoGasto.ValueMember = "idTipo"
            cmbTipoGasto.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub btTipoGasto_Click(sender As Object, e As EventArgs) Handles btTipoGasto.Click
        Dim form = New frmTipoGastos
        form.ShowDialog()
    End Sub

    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            da = New SqlDataAdapter("pa_gastos_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()

            FormatarDG()

        Catch ex As Exception
            '  MessageBox.Show("Erro ao Listar os Gastos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub DesabilitarCampos()
        txtUsuarioLogado.Enabled = False
        cmbTipoGasto.Enabled = False
        txtValor.Enabled = False
        txtObs.Enabled = False
        calendario.Enabled = False
        cmbTipoGasto.Text = Nothing

    End Sub

    Private Sub HabilitarCampos()

        txtUsuarioLogado.Enabled = True
        cmbTipoGasto.Enabled = True
        txtValor.Enabled = True
        txtObs.Enabled = True
        calendario.Enabled = True

        ' txtUsuarioLogado.Text = usrUsuarioLogin.Nome

    End Sub

    Private Sub Limpar()
        txtUsuarioLogado.Focus()
        txtUsuarioLogado.Text = ""
        'txtCodigo.Text = "Novo"
        'txtUsuarioLogado.Text = strNomelUsuario
        cmbTipoGasto.Text = Nothing
        txtValor.Text = "0,00"
        txtObs.Text = ""
    End Sub

    Private Sub FormatarDG()
        With dg

            .Columns(0).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False

            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Usuário"
            .Columns(2).HeaderText = "Tipo de Gasto"
            .Columns(3).HeaderText = "Valor"
            .Columns(4).HeaderText = "Observação"
            .Columns(5).HeaderText = "Dt Cadastro"
            .Columns(6).HeaderText = "Tipo idTipo"
            .Columns(7).HeaderText = "Gasto idTipo"

            .Columns(1).Width = 100
            .Columns(2).Width = 100
            .Columns(3).Width = 70
            .Columns(4).Width = 200
        End With
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtUsuarioLogado.Text <> "" Then

            Try

                Dim valor = Replace(txtValor.Text, ",", ".")


                abrir()
                cmd = New SqlCommand("pa_gastos_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@usuario", txtUsuarioLogado.Text)
                cmd.Parameters.AddWithValue("@idTipo", cmbTipoGasto.SelectedValue)
                cmd.Parameters.AddWithValue("@valor", valor)
                cmd.Parameters.AddWithValue("@obs ", txtObs.Text)
                cmd.Parameters.AddWithValue("@data_cadastro", calendario.SelectionStart.ToShortDateString)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)

                Listar()
                Limpar()

                btSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()

            End Try
        End If
    End Sub

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        btEditar.Enabled = True
        btExcluir.Enabled = True
        btSalvar.Enabled = False

        HabilitarCampos()

        lblCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtUsuarioLogado.Text = dg.CurrentRow.Cells(1).Value
        cmbTipoGasto.Text = dg.CurrentRow.Cells(2).Value
        txtValor.Text = dg.CurrentRow.Cells(3).Value
        txtObs.Text = dg.CurrentRow.Cells(4).Value
        calendario.Text = dg.CurrentRow.Cells(5).Value

    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Dim cmd As SqlCommand

        If txtUsuarioLogado.Text <> "" Then

            Try
                Dim valor = Replace(txtValor.Text, ",", ".")

                abrir()
                cmd = New SqlCommand("pa_gastos_Editar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@codigo", lblCodigo.Text)
                cmd.Parameters.AddWithValue("@idTipo", cmbTipoGasto.SelectedValue)
                cmd.Parameters.AddWithValue("@valor", valor)
                cmd.Parameters.AddWithValue("@obs", txtObs.Text)
                cmd.Parameters.AddWithValue("@data_cadastro", calendario.SelectionStart.ToShortDateString)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao Editar os dados" + ex.Message.ToString)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        Dim cmd As SqlCommand

        If lblCodigo.Text <> "" Then

            Try
                If (MessageBox.Show("Deseja excluir este Produto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_gastos_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@codigo", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btExcluir.Enabled = False
                btEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir o Produto" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click

        btSalvar.Enabled = True
        btTipoGasto.Enabled = True
        txtUsuarioLogado.Text = usuarioNome
        HabilitarCampos()

    End Sub
End Class