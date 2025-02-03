Imports System.Data.SqlClient

Public Class frmControleMensalidades
    Dim Alunos As String
    Dim codigo As Integer
    Dim dataPagamento As Boolean
    Private Function FVerificaListBoxCursos() As Boolean
        If dgvCursos.RowCount = 0 Then
            MsgBox("Ainda não foram cadastrados nenhum curso no momento. " &
                   "Por favor cadastre pelo menos um curso para ter acesso ao controle de mensalidades.",
                   MsgBoxStyle.Information, "CS. Net Tecnologia")
            Return False
        End If
        Return True
    End Function

    Private Sub frmControleMensalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PPreencheListaBoxCursos()
        If FVerificaListBoxCursos() = False Then Exit Sub
    End Sub

    Private Sub frmControleMensalidades_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub PPreencheListaBoxCursos()
        Me.Cursor = Cursors.WaitCursor

        Try
            abrir()
            Dim sql As String
            sql = "SELECT DISTINCT tab_Cursos.CodigoCurso, tab_Cursos.NomeCurso, tab_Cursos.ValorCurso "
            sql += "FROM ((tab_AlunoCurso INNER JOIN "
            sql += "tab_Alunos ON tab_AlunoCurso.CodigoAluno = tab_Alunos.CodigoAluno) INNER JOIN "
            sql += "tab_Cursos ON tab_AlunoCurso.CodigoCurso = tab_Cursos.CodigoCurso) ORDER BY tab_Cursos.NomeCurso"

            Dim cmd As SqlCommand = New SqlCommand(sql, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            dgvCursos.DataSource = dt

            With dgvCursos
                '.Columns("CodigoCurso").Visible = False
                .EnableHeadersVisualStyles = False
                .AllowUserToResizeColumns = False
                .RowHeadersVisible = False
                .ColumnHeadersVisible = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False
                .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .Columns("ValorCurso").DefaultCellStyle.Format = "c"
                .DefaultCellStyle.Font = New Font("Verdana", 8.25, FontStyle.Bold)
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                .AllowUserToResizeRows = False
                .Columns("ValorCurso").DefaultCellStyle.ForeColor = Color.Red
                .RowTemplate.Height = 15 'define a largura da linha
                .Columns("NomeCurso").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

            ' PPreencheListBoxAlunos()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub
End Class