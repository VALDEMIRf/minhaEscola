Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class frmCadGrupos
    Private Sub frmCadGrupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaGrid()
        ultimoRegistro()
    End Sub

    Private Sub frmCadGrupos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        carregaGrid()
        '  ultimoRegistro()
    End Sub

    Private Sub carregaGrid()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            da = New SqlDataAdapter("pa_grupo_listar", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Grupos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub Limpar()
        txtGrupo.Focus()
        txtGrupo.Text = ""
    End Sub

    Private Sub FormatarDG()
        With dg
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Grupos"
            .Columns(1).Width = 150
        End With
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        Limpar()
        btSalvar.Enabled = True
        txtGrupo.Enabled = True
        txtGrupo.Focus()
        btEditar.Enabled = False
        btExcluir.Enabled = False
    End Sub

    Private Sub ultimoRegistro()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim dr As SqlDataReader = Nothing
        Dim sql As String
        Dim cmd As SqlCommand
        Dim n As Integer
        Try
            abrir()
            'da = New SqlDataAdapter(pa_professor_listarDisciplina", con)
            'da.SelectCommand.CommandType = CommandType.StoredProcedure

            'da.Fill(dt)
            'dg.DataSource = dt
            sql = "pa_grupo_ultimoRegistro"
            cmd = New SqlCommand(sql, con)

            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

            If dr.HasRows Then
                dr.Read()

                n = dr.Item("grupoID")

                lblUltimoRegistro.Text = n.ToString
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Alunos" + ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub


    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        Dim cmd As SqlCommand

        If txtGrupo.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("pa_grupo_Salvar", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@grupoID", lblUltimoRegistro.Text)
                cmd.Parameters.AddWithValue("@descricao", txtGrupo.Text)

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

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click

    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click

    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click

    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub
End Class