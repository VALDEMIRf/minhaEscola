Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmCursosHorarios

    Private Sub frmCursosHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        PCarregaCursoSegunda()
        PCarregaComboBox()
        Listar()
        Limpar()

    End Sub

    Private Sub frmCursosHorarios_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        PCarregaCursoSegunda()
        PCarregaComboBox()
        Listar()
    End Sub

    Private Sub PCarregaComboBox()

        PCarregaCursoSegunda()
        PCarregaCursoTerca()
        PCarregaCursoQuarta()
        PCarregaCursoQuinta()
        PCarregaCursoSexta()
        PCarregaCursoSabado()

        PCarregaProfSegunda()
        PCarregaProfTerca()
        PCarregaProfQuarta()
        PCarregaProfQuinta()
        PCarregaprofSexta()
        PCarregaProfSabado()

    End Sub

    Private Sub PCarregaProfSegunda()

        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_professor_listarNome", con)
            DA.Fill(DT)

            cmbProfSegunda.ValueMember = "CodigoProfessor"
            cmbProfSegunda.DisplayMember = "NomeProfessor"
            cmbProfSegunda.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PCarregaProfTerca()

        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_professor_listarNome", con)
            DA.Fill(DT)

            cmbProfTerca.ValueMember = "CodigoProfessor"
            cmbProfTerca.DisplayMember = "NomeProfessor"
            cmbProfTerca.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try


    End Sub

    Private Sub PCarregaProfQuarta()

        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_professor_listarNome", con)
            DA.Fill(DT)

            cmbProfQuarta.ValueMember = "CodigoProfessor"
            cmbProfQuarta.DisplayMember = "NomeProfessor"
            cmbProfQuarta.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PCarregaProfQuinta()

        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_professor_listarNome", con)
            DA.Fill(DT)

            cmbProfQuinta.ValueMember = "CodigoProfessor"
            cmbProfQuinta.DisplayMember = "NomeProfessor"
            cmbProfQuinta.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PCarregaprofSexta()

        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_professor_listarNome", con)
            DA.Fill(DT)

            cmbProfSexta.ValueMember = "CodigoProfessor"
            cmbProfSexta.DisplayMember = "NomeProfessor"
            cmbProfSexta.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PCarregaProfSabado()

        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_professor_listarNome", con)
            DA.Fill(DT)

            cmbProfSabado.ValueMember = "CodigoProfessor"
            cmbProfSabado.DisplayMember = "NomeProfessor"
            cmbProfSabado.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    ''' <summary>
    ''' Incia a parte dos cursos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PCarregaCursoSegunda()

        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_curso_listar", con)
            DA.Fill(DT)

            cmbSegunda.ValueMember = "CodigoCurso"
            cmbSegunda.DisplayMember = "NomeCurso"
            cmbSegunda.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub

    Private Sub PCarregaCursoTerca()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_curso_listar", con)
            DA.Fill(DT)

            cmbTerca.ValueMember = "CodigoCurso"
            cmbTerca.DisplayMember = "NomeCurso"
            cmbTerca.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PCarregaCursoQuarta()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_curso_listar", con)
            DA.Fill(DT)

            cmbQuarta.ValueMember = "CodigoCurso"
            cmbQuarta.DisplayMember = "NomeCurso"
            cmbQuarta.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PCarregaCursoQuinta()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_curso_listar", con)
            DA.Fill(DT)

            cmbQuinta.ValueMember = "CodigoCurso"
            cmbQuinta.DisplayMember = "NomeCurso"
            cmbQuinta.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PCarregaCursoSexta()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_curso_listar", con)
            DA.Fill(DT)

            cmbSexta.ValueMember = "CodigoCurso"
            cmbSexta.DisplayMember = "NomeCurso"
            cmbSexta.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PCarregaCursoSabado()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("pa_curso_listar", con)
            DA.Fill(DT)

            cmbSabado.ValueMember = "CodigoCurso"
            cmbSabado.DisplayMember = "NomeCurso"
            cmbSabado.DataSource = DT

        Catch ex As Exception : MessageBox.Show(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub Listar()
        ListarManha()
        ListarTarde()
        ListarNoite()
    End Sub

    Private Sub ListarManha()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            da = New SqlDataAdapter("pa_CursosHorarios_listaCursosHorariosManha", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dgManha.DataSource = dt

            '  ContarLinhas()

            FormatarDGManha()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Cursos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub ListarTarde()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            da = New SqlDataAdapter("pa_CursosHorarios_listaCursosHorariosTarde", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dgTarde.DataSource = dt

            '  ContarLinhas()

            FormatarDGTarde()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Cursos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub ListarNoite()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            da = New SqlDataAdapter("pa_CursosHorarios_listaCursosHorariosNoite", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dgNoite.DataSource = dt

            '  ContarLinhas()

            FormatarDGNoite()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os Cursos" + ex.Message.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub FormatarDGManha()

        With dgManha
            .Columns(0).Visible = False

            .Columns(0).HeaderText = "Codigo"
            .Columns(1).HeaderText = "Periodo"
            .Columns(2).HeaderText = "Hora"
            .Columns(3).HeaderText = "Segunda"
            .Columns(4).HeaderText = "Terça"
            .Columns(5).HeaderText = "Quarta"
            .Columns(6).HeaderText = "Quinta"
            .Columns(7).HeaderText = "Sexta"
            .Columns(8).HeaderText = "Sábado"

            .Columns(1).Width = 60
            .Columns(2).Width = 50
            '.Columns(5).Width = 100
            '.Columns(6).Width = 80
            '.Columns(7).Width = 100
            '.Columns(8).Width = 120

        End With

    End Sub

    Private Sub FormatarDGNoite()

        With dgManha
            .Columns(0).Visible = False

            .Columns(0).HeaderText = "Codigo"
            .Columns(1).HeaderText = "Periodo"
            .Columns(2).HeaderText = "Hora"
            .Columns(3).HeaderText = "Segunda"
            .Columns(4).HeaderText = "Terça"
            .Columns(5).HeaderText = "Quarta"
            .Columns(6).HeaderText = "Quinta"
            .Columns(7).HeaderText = "Sexta"
            .Columns(8).HeaderText = "Sábado"

            .Columns(1).Width = 60
            .Columns(2).Width = 50
            '.Columns(5).Width = 100
            '.Columns(6).Width = 80
            '.Columns(7).Width = 100
            '.Columns(8).Width = 120

        End With

    End Sub

    Private Sub FormatarDGTarde()

        With dgManha
            .Columns(0).Visible = False

            .Columns(0).HeaderText = "Codigo"
            .Columns(1).HeaderText = "Periodo"
            .Columns(2).HeaderText = "Hora"
            .Columns(3).HeaderText = "Segunda"
            .Columns(4).HeaderText = "Terça"
            .Columns(5).HeaderText = "Quarta"
            .Columns(6).HeaderText = "Quinta"
            .Columns(7).HeaderText = "Sexta"
            .Columns(8).HeaderText = "Sábado"

            .Columns(1).Width = 60
            .Columns(2).Width = 50
            '.Columns(5).Width = 100
            '.Columns(6).Width = 80
            '.Columns(7).Width = 100
            '.Columns(8).Width = 120

        End With

    End Sub

    Private Sub DesabilitarCampos()
        cmbSegunda.Enabled = False
        cmbTerca.Enabled = False
        cmbQuarta.Enabled = False
        cmbQuinta.Enabled = False
        cmbSexta.Enabled = False
        cmbSabado.Enabled = False
        cmbProfSegunda.Enabled = False
        cmbProfTerca.Enabled = False
        cmbProfQuarta.Enabled = False
        cmbProfQuinta.Enabled = False
        cmbProfSexta.Enabled = False
        cmbProfSabado.Enabled = False
        cmbPeriodo.Enabled = False
        mskHoras.Enabled = False
        btSalvarEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub HabilitarCampos()
        cmbSegunda.Focus()
        cmbSegunda.Enabled = True
        cmbTerca.Enabled = True
        cmbQuarta.Enabled = True
        cmbQuinta.Enabled = True
        cmbSexta.Enabled = True
        cmbSabado.Enabled = True
        cmbProfSegunda.Enabled = True
        cmbProfTerca.Enabled = True
        cmbProfQuarta.Enabled = True
        cmbProfQuinta.Enabled = True
        cmbProfSexta.Enabled = True
        cmbProfSabado.Enabled = True
        cmbPeriodo.Enabled = True
        mskHoras.Enabled = True
        btSalvarEditar.Enabled = True
        btnExcluir.Enabled = True
    End Sub

    Private Sub Limpar()
        cmbSegunda.Focus()
        cmbSegunda.Text = Nothing
        cmbTerca.Text = Nothing
        cmbQuarta.Text = Nothing
        cmbQuinta.Text = Nothing
        cmbSexta.Text = Nothing
        cmbSabado.Text = Nothing
        cmbProfSegunda.Text = Nothing
        cmbProfTerca.Text = Nothing
        cmbProfQuarta.Text = Nothing
        cmbProfQuinta.Text = Nothing
        cmbProfSexta.Text = Nothing
        cmbProfSabado.Text = Nothing
        cmbPeriodo.Text = Nothing
        mskHoras.Text = ""
    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub chkFolga_CheckedChanged(sender As Object, e As EventArgs) Handles chkFolga.CheckedChanged
        If chkFolga.Checked = True Then
            cmbSabado.Enabled = False
            cmbProfSabado.Enabled = False
        Else
            cmbSabado.Enabled = True
            cmbProfSabado.Enabled = True
        End If
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        HabilitarCampos()
        Limpar()
        btSalvarEditar.Enabled = True
        btnExcluir.Enabled = False
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

            abrir()
            cmd = New SqlCommand("pa_CursosHorarios_Salvar", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Periodo", cmbPeriodo.Text)
            cmd.Parameters.AddWithValue("@Horas", mskHoras.Text)
            cmd.Parameters.AddWithValue("@Segunda", cmbSegunda.Text)
            cmd.Parameters.AddWithValue("@Terca", cmbTerca.Text)
            cmd.Parameters.AddWithValue("@Quarta", cmbQuarta.Text)
            cmd.Parameters.AddWithValue("@Quinta", cmbQuinta.Text)
            cmd.Parameters.AddWithValue("@Sexta", cmbSexta.Text)
            If chkFolga.Checked = True Then
                cmd.Parameters.AddWithValue("@Sabado", "")
            Else
                cmd.Parameters.AddWithValue("@Sabado", cmbSabado.Text)
            End If

            cmd.Parameters.AddWithValue("@ProfSegunda", cmbProfSegunda.Text)
            cmd.Parameters.AddWithValue("@ProfTerca", cmbProfTerca.Text)
            cmd.Parameters.AddWithValue("@ProfQuarta", cmbProfQuarta.Text)
            cmd.Parameters.AddWithValue("@ProfQuinta", cmbProfQuinta.Text)
            cmd.Parameters.AddWithValue("@ProfSexta", cmbProfSexta.Text)

            If chkFolga.Checked = True Then
                cmd.Parameters.AddWithValue("@ProfSabado", "")
            Else
                cmd.Parameters.AddWithValue("@ProfSabado", cmbProfSabado.Text)
            End If

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

    Private Sub dgManha_Click(sender As Object, e As EventArgs) Handles dgManha.Click
        tcCursosHorarios.SelectedIndex = 0
        HabilitarCampos()
        btSalvarEditar.Enabled = True
        btnExcluir.Enabled = True

        lblCodigo.Text = dgManha.CurrentRow.Cells(0).Value
        cmbPeriodo.Text = dgManha.CurrentRow.Cells(1).Value
        mskHoras.Text = dgManha.CurrentRow.Cells(2).Value
        cmbSegunda.Text = dgManha.CurrentRow.Cells(3).Value
        cmbTerca.Text = dgManha.CurrentRow.Cells(4).Value
        cmbQuarta.Text = dgManha.CurrentRow.Cells(5).Value
        cmbQuinta.Text = dgManha.CurrentRow.Cells(6).Value
        cmbSexta.Text = dgManha.CurrentRow.Cells(7).Value
        cmbSabado.Text = dgManha.CurrentRow.Cells(8).Value
        cmbProfSegunda.Text = dgManha.CurrentRow.Cells(9).Value
        cmbProfTerca.Text = dgManha.CurrentRow.Cells(10).Value
        cmbProfQuarta.Text = dgManha.CurrentRow.Cells(11).Value
        cmbProfQuinta.Text = dgManha.CurrentRow.Cells(12).Value
        cmbProfSexta.Text = dgManha.CurrentRow.Cells(13).Value
        cmbProfSabado.Text = dgManha.CurrentRow.Cells(14).Value

    End Sub

    Private Sub dgTarde_Click(sender As Object, e As EventArgs) Handles dgTarde.Click
        tcCursosHorarios.SelectedIndex = 0
        btSalvarEditar.Enabled = True
        btnExcluir.Enabled = True

        lblCodigo.Text = dgTarde.CurrentRow.Cells(0).Value
        cmbPeriodo.Text = dgTarde.CurrentRow.Cells(1).Value
        mskHoras.Text = dgTarde.CurrentRow.Cells(2).Value
        cmbSegunda.Text = dgTarde.CurrentRow.Cells(3).Value
        cmbTerca.Text = dgTarde.CurrentRow.Cells(4).Value
        cmbQuarta.Text = dgTarde.CurrentRow.Cells(5).Value
        cmbQuinta.Text = dgTarde.CurrentRow.Cells(6).Value
        cmbSexta.Text = dgTarde.CurrentRow.Cells(7).Value
        cmbSabado.Text = dgTarde.CurrentRow.Cells(8).Value
        cmbProfSegunda.Text = dgTarde.CurrentRow.Cells(9).Value
        cmbProfTerca.Text = dgTarde.CurrentRow.Cells(10).Value
        cmbProfQuarta.Text = dgTarde.CurrentRow.Cells(11).Value
        cmbProfQuinta.Text = dgTarde.CurrentRow.Cells(12).Value
        cmbProfSexta.Text = dgTarde.CurrentRow.Cells(13).Value
        cmbProfSabado.Text = dgTarde.CurrentRow.Cells(14).Value
    End Sub

    Private Sub dgNoite_Click(sender As Object, e As EventArgs) Handles dgNoite.Click
        tcCursosHorarios.SelectedIndex = 0
        btSalvarEditar.Enabled = True
        btnExcluir.Enabled = True

        lblCodigo.Text = dgNoite.CurrentRow.Cells(0).Value
        cmbPeriodo.Text = dgNoite.CurrentRow.Cells(1).Value
        mskHoras.Text = dgNoite.CurrentRow.Cells(2).Value
        cmbSegunda.Text = dgNoite.CurrentRow.Cells(3).Value
        cmbTerca.Text = dgNoite.CurrentRow.Cells(4).Value
        cmbQuarta.Text = dgNoite.CurrentRow.Cells(5).Value
        cmbQuinta.Text = dgNoite.CurrentRow.Cells(6).Value
        cmbSexta.Text = dgNoite.CurrentRow.Cells(7).Value
        cmbSabado.Text = dgNoite.CurrentRow.Cells(8).Value
        cmbProfSegunda.Text = dgNoite.CurrentRow.Cells(9).Value
        cmbProfTerca.Text = dgNoite.CurrentRow.Cells(10).Value
        cmbProfQuarta.Text = dgNoite.CurrentRow.Cells(11).Value
        cmbProfQuinta.Text = dgNoite.CurrentRow.Cells(12).Value
        cmbProfSexta.Text = dgNoite.CurrentRow.Cells(13).Value
        cmbProfSabado.Text = dgNoite.CurrentRow.Cells(14).Value
    End Sub

    Private Sub alterar()
        Dim cmd As SqlCommand

        Try


            abrir()
            cmd = New SqlCommand("pa_CursosHorarios_Editar", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CodigoCursoHorario", lblCodigo.Text)

            cmd.Parameters.AddWithValue("@Periodo", cmbPeriodo.Text)
            cmd.Parameters.AddWithValue("@Horas", mskHoras.Text)
            cmd.Parameters.AddWithValue("@Segunda", cmbSegunda.Text)
            cmd.Parameters.AddWithValue("@Terca", cmbTerca.Text)
            cmd.Parameters.AddWithValue("@Quarta", cmbQuarta.Text)
            cmd.Parameters.AddWithValue("@Quinta", cmbQuinta.Text)
            cmd.Parameters.AddWithValue("@Sexta", cmbSexta.Text)
            If chkFolga.Checked = True Then
                cmd.Parameters.AddWithValue("@Sabado", "")
            Else
                cmd.Parameters.AddWithValue("@Sabado", cmbSabado.Text)
            End If

            cmd.Parameters.AddWithValue("@ProfSegunda", cmbProfSegunda.Text)
            cmd.Parameters.AddWithValue("@ProfTerca", cmbProfTerca.Text)
            cmd.Parameters.AddWithValue("@ProfQuarta", cmbProfQuarta.Text)
            cmd.Parameters.AddWithValue("@ProfQuinta", cmbProfQuinta.Text)
            cmd.Parameters.AddWithValue("@ProfSexta", cmbProfSexta.Text)

            If chkFolga.Checked = True Then
                cmd.Parameters.AddWithValue("@ProfSabado", "")
            Else
                cmd.Parameters.AddWithValue("@ProfSabado", cmbProfSabado.Text)
            End If

            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()

            Listar()
            Limpar()


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
                If (MessageBox.Show("Deseja excluir este Aluno?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub

                abrir()
                cmd = New SqlCommand("pa_CursosHorarios_Excluir", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CodigoCursoHorario", lblCodigo.Text)
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnExcluir.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message.ToString)
            Finally
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnHorarioCompletoDaManha_Click(sender As Object, e As EventArgs) Handles btnHorarioCompletoDaManha.Click
        If dgManha.RowCount = 0 Then
            MsgBox("Não existem nenhuma relação de horários cadastrados no momento.", MsgBoxStyle.Information, "CS .Net Tecnologia")
            Exit Sub
        End If
        frmRelacaoCompletaHorarios.lblInfo.Text = "Manhã"
        frmRelacaoCompletaHorarios.ShowDialog()
    End Sub

    Private Sub btnHorarioCompletoDaTarde_Click(sender As Object, e As EventArgs) Handles btnHorarioCompletoDaTarde.Click
        If dgTarde.RowCount = 0 Then
            MsgBox("Não existem nenhuma relação de horários cadastrados no momento.", MsgBoxStyle.Information, "CS .Net Tecnologia")
            Exit Sub
        End If
        frmRelacaoCompletaHorarios.lblInfo.BackColor = Color.Orange
        frmRelacaoCompletaHorarios.lblInfo.Text = "Tarde"
        frmRelacaoCompletaHorarios.ShowDialog()
    End Sub

    Private Sub btnHorarioCompletoDaNoite_Click(sender As Object, e As EventArgs) Handles btnHorarioCompletoDaNoite.Click
        If dgNoite.RowCount = 0 Then
            MsgBox("Não existem nenhuma relação de horários cadastrados no momento.", MsgBoxStyle.Information, "CS .Net Tecnologia")
            Exit Sub
        End If
        frmRelacaoCompletaHorarios.lblInfo.BackColor = Color.Crimson
        frmRelacaoCompletaHorarios.lblInfo.Text = "Noite"
        frmRelacaoCompletaHorarios.ShowDialog()
    End Sub
End Class

