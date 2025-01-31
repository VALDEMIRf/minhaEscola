Imports System.Data.SqlClient

Public Class frmRelacaoCompletaHorarios
    Private Sub frmRelacaoCompletaHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaDataGridViewCursos()

        'Desabilita a ordenação pela header
        For i As Integer = 0 To dgvRelacaoCursosHorarios.Columns.Count - 1
            dgvRelacaoCursosHorarios.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
        For i As Integer = 0 To dgvRelacaoCursosHorariosProfessores.Columns.Count - 1
            dgvRelacaoCursosHorariosProfessores.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
    End Sub

    Private Sub PCarregaDataGridViewCursos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            ' Sql = "SELECT CodigoCursoHorario, Periodo, Horas, Segunda, Terca, Quarta, Quinta, Sexta, Sabado FROM tab_CursosHorarios "
            ' Sql += "WHERE Periodo = '" & lblInfo.Text & "' ORDER BY Horas"
            da = New SqlDataAdapter("pa_CursosHorarios_listaCursosDias", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@Periodo", lblInfo.Text)
            da.Fill(dt)

            dgvRelacaoCursosHorarios.DataSource = dt
            PFormataDataGridView()

            PCarregaDataGridViewProfessores()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os professores" + ex.Message.ToString)
        Finally
            fechar()
        End Try



    End Sub

    Private Sub PCarregaDataGridViewProfessores()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim periodo As String = "Manhã"

        Try
            abrir()

            'Sql = "SELECT CodigoCursoHorario,Periodo,Horas,Profsegunda,ProfTerca,ProfQuarta,ProfQuinta,ProfSexta,ProfSabado FROM tab_CursosHorarios "
            ' Sql += "WHERE Periodo = '" & lblInfo.Text & "' ORDER BY Horas"
            da = New SqlDataAdapter("pa_CursosHorarios_listaCursosProfessores", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@Periodo", lblInfo.Text)
            da.Fill(dt)

            dgvRelacaoCursosHorariosProfessores.DataSource = dt

            PFormataDataGridViewProfessores()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar os professores" + ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub PFormataDataGridView()
        With dgvRelacaoCursosHorarios

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False
            .AllowUserToOrderColumns = False
            .MultiSelect = False
            .RowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.Font = New Font("Verdana", 9)

            .Columns(0).HeaderText = "Código"
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Periodo"
            .Columns(1).Visible = False
            .Columns(2).HeaderText = "Horário"
            .Columns(3).HeaderText = "Segunda"
            .Columns(4).HeaderText = "Terça"
            .Columns(5).HeaderText = "Quarta"
            .Columns(6).HeaderText = "Quinta"
            .Columns(7).HeaderText = "Sexta"
            .Columns(8).HeaderText = "Sábado"

            .Columns(2).DefaultCellStyle.Format = "t"

            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub PFormataDataGridViewProfessores()
        With dgvRelacaoCursosHorariosProfessores

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False
            .AllowUserToOrderColumns = False
            .MultiSelect = False
            .RowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.Font = New Font("Verdana", 9)

            .Columns(0).HeaderText = "Código"
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Periodo"
            .Columns(1).Visible = False
            .Columns(2).HeaderText = "Horário"
            .Columns(3).HeaderText = "Segunda"
            .Columns(4).HeaderText = "Terça"
            .Columns(5).HeaderText = "Quarta"
            .Columns(6).HeaderText = "Quinta"
            .Columns(7).HeaderText = "Sexta"
            .Columns(8).HeaderText = "Sábado"

            .Columns(2).DefaultCellStyle.Format = "t"

            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub
End Class