Imports System.Data.SqlClient

Public Class frmControleMensalidades
    Dim Alunos As String
    Dim codigo As Integer
    Dim dataPagamento As Boolean


    Private Sub frmControleMensalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PPreencheListaBoxCursos()
        ''  If FVerificaListBoxCursos() = False Then Exit Sub
    End Sub

    Private Sub frmControleMensalidades_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Function FVerificaListBoxCursos() As Boolean
        If dgvCursos.RowCount = 0 Then
            MsgBox("Ainda não foram cadastrados nenhum curso no momento. " &
                   "Por favor cadastre pelo menos um curso para ter acesso ao controle de mensalidades.",
                   MsgBoxStyle.Information, "VAL Tecnologia")
            Return False
        End If
        Return True
    End Function

    Private Sub PPreencheListaBoxCursos()
        Me.Cursor = Cursors.WaitCursor
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()

            da = New SqlDataAdapter("pa_Mensalidade_preencheCursos", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            dgvCursos.DataSource = dt


            FormatarDG()


            PPreencheListBoxAlunos()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()

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
            .Columns(0).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False


        End With

    End Sub


    Private Sub dgvCursos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellEnter
        PPreencheListBoxAlunos()
    End Sub

    Public Sub PPreencheListBoxAlunos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_Mensalidade_preencheAlunos", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@idCurso", dgvCursos.CurrentRow().Cells(0).Value)

            da.Fill(dt)
            lstAlunos.ValueMember = "CodigoAluno"
            lstAlunos.DisplayMember = "NomeAluno"
            lstAlunos.DataSource = dt


            'Verifica se tem dados na datagridview
            If lstAlunos.Items.Count = 0 Then
                    dgvMensalidades.DataSource = Nothing
                    dgvMensalidades.Refresh()
                    lblMensagemPagamentos.Visible = True

                    'Limpa as caixas de texto
                    txtNome.Text = ""
                    txtCodigo.Text = ""
                '  txtDocumento.Text = ""
                txtEndereco.Text = ""
                    txtCep.Text = ""
                    txtCidade.Text = ""
                    txtUF.Text = ""
                    txtEmail.Text = ""
                txtCelular.Text = ""
                txtTotal.Text = "R$ 0,00"
                    txtTotalDesconto.Text = "R$ 0,00"
                    txtTotalJuros.Text = "R$ 0,00"
                    txtTotalLiquidoParcelas.Text = "R$ 0,00"
                End If
            Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Information, "VAL Tecnologia")
        Finally
            fechar()
        End Try

    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub


    Private Sub PCarregaInformacoesIniciais()
        '  Me.Cursor = Cursors.WaitCursor

        'Mostra todas as parcelas       
        '  rdTodasParcelas.Checked = True

        '    'obtem o nome selecionado no listbox
        ' Alunos = lstAlunos.Text

        '    'Dim codigo As Integer = Convert.ToInt32(lstAlunos.SelectedValue.ToString())
        '    codigo = lstAlunos.SelectedValue

        '    'exibe o nome e sobrenome do Alunos
        '    PExibeDadosAlunos(Alunos)
        '    'Exibe as parcelas dos alunos
        '    exibeParcelasAlunos(codigo)

        '    'Calcula o valor liquido das parcelas
        '    PValorLiquidoParcelas()

        '    'Verifica a quantidade de alunos
        '    PVerificaQtdAlunos()

        '    'Verifica a cor atual do sistema
        '    '  PVerificaACorAtual()
        '    ' Me.Cursor = Cursors.Default
    End Sub


    'Private Sub lstAlunos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlunos.SelectedIndexChanged
    '    PCarregaInformacoesIniciais()
    'End Sub

    'Private Sub PExibeDadosAlunos(ByVal nome As String)
    '    Dim dr As SqlDataReader = Nothing
    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter
    '    ' abre a conexao
    '    abrir()

    '    ' cria um command para esta conexao
    '    ' da = New SqlDataAdapter("pa_Mensalidade_pesquisaNome", con)
    '    '  da.SelectCommand.CommandType = CommandType.StoredProcedure
    '    ' da.Fill(dt)
    '    '  dg.DataSource = dt
    '    Dim cmd As New SqlCommand("pa_Mensalidade_pesquisaNome", con)

    '    ' Cria uma consulta paremetrizada
    '    cmd.Parameters.Add(New SqlParameter("NomeAluno", txtNome.Text))
    '    Try
    '            ' executa a consulta.
    '            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
    '            ' exibe o resultado nas caixas de texto
    '            If dr.HasRows Then
    '                dr.Read()
    '                txtCodigo.Text = dr.Item("CodigoAluno")
    '            ' txtDocumento.Text = dr.Item("documento")
    '            txtNome.Text = dr.Item("NomeAluno").ToString
    '                txtEndereco.Text = dr.Item("Endereco").ToString
    '                txtCidade.Text = dr.Item("Cidade").ToString
    '                txtUF.Text = dr.Item("Estado").ToString
    '                txtCep.Text = dr.Item("Cep").ToString
    '                txtEmail.Text = dr.Item("email")
    '            txtCelular.Text = dr.Item("telefone")
    '        Else
    '                'limpa as caixas de texto
    '                For Each ctl As Control In Me.Controls
    '                    If TypeOf ctl Is TextBox Then ctl.Text = ""
    '                Next ctl
    '            End If
    '        Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    Finally
    '            dr.Close()
    '        ' fecha a conexao
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub PExibeTodasMensalidadesDosCursos()

    '    Try
    '        Dim dt As New DataTable
    '        Dim da As SqlDataAdapter

    '        abrir()

    '        da = New SqlDataAdapter("pa_Mensalidade_listaMensalidade", con)
    '        da.SelectCommand.CommandType = CommandType.StoredProcedure
    '        da.Fill(dt)
    '        dgvMensalidades.DataSource = dt

    '        '  Dim sql As String = ""

    '        'sql = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, " &
    '        '    "VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao " &
    '        '    "FROM tab_Mensalidades ORDER BY CodigoMensalidade"
    '        'Exportar para excel
    '        strSqlExcel = "pa_Mensalidade_listaMensalidade"


    '        'Forma a datagridview para receber os valores das parcelas
    '        PFormataDataGridView()

    '        'Verifica se tem dados na datagridview
    '        PVerificaDadosNaGrid()

    '        'Exibe o total das parcelas
    '        exibeTotal()

    '        'Exibe o total de desconto das parcelas
    '        exibeTotalDesconto()

    '        'Exibe o total de juros de cada parcela
    '        exibeTotalJuros()

    '        'Exibe o total do valor liquido das parcelas
    '        PValorLiquidoParcelas()
    '    Catch ex As Exception
    '        'MsgBox("Erro.: " + ex.Message)
    '    Finally
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub exibeParcelasAlunos(ByVal cod As Integer, Optional ByVal TodasParcelas As Boolean = True,
    '                                  Optional ByVal Pagas As Boolean = False, Optional ByVal NaoPagas As Boolean = False)

    '    Try
    '        abrir()
    '        Dim sql As String = ""

    '        'If TodasParcelas = True And Pagas = False And NaoPagas = False Then
    '        '    sql = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao " &
    '        '        "FROM tab_Mensalidades WHERE CodigoAluno=? AND CodigoCurso=?"
    '        If TodasParcelas = True And Pagas = False And NaoPagas = False Then
    '            sql = "pa_Mensalidade_ExibeParcelaAluno1"

    '            'Exportar para excel
    '            strSqlExcel = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao " &
    '                    "FROM tbMensalidades WHERE CodigoAluno=" & Me.lstAlunos.SelectedValue
    '            ' strSqlExcel = "pa_Mensalidade_ExibeParcelaAlunoExcel_1" & Me.lstAlunos.SelectedValue
    '        End If

    '        If TodasParcelas = False And Pagas = True And NaoPagas = False Then
    '            'sql = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao " &
    '            '        " FROM tbMensalidades WHERE CodigoAluno=? AND CodigoCurso=? AND (NOT (tbMensalidades.pagamentoParcela IS NULL))"
    '            sql = "pa_Mensalidade_ExibeParcelaAluno2"

    '            'Exportar para excel
    '            strSqlExcel = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao FROM tbMensalidades WHERE CodigoAluno=" & Me.lstAlunos.SelectedValue &
    '                              " AND (NOT (tbMensalidades.pagamentoParcela IS NULL))"
    '            ' strSqlExcel = "pa_Mensalidade_ExibeParcelaAlunoExcel_2"

    '        End If

    '        If TodasParcelas = False And Pagas = False And NaoPagas = False Then
    '            '  sql = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao " &
    '            '       "FROM tab_Mensalidades WHERE CodigoAluno=?  AND CodigoCurso=? AND (tab_Mensalidades.pagamentoParcela IS NULL)"

    '            sql = "pa_Mensalidade_ExibeParcelaAluno3"

    '            'Exportar para excel
    '            strSqlExcel = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao FROM tbMensalidades WHERE CodigoAluno=" & Me.lstAlunos.SelectedValue &
    '                              "  AND (tbMensalidades.pagamentoParcela IS NULL)"
    '            'strSqlExcel = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao FROM tab_Mensalidades WHERE CodigoAluno=" & Me.lstAlunos.SelectedValue &
    '            '                  "  AND (tbMensalidades.pagamentoParcela IS NULL)"
    '        End If

    '        ' cria um command para esta conexao
    '        Dim cmd As New SqlCommand(sql, con)

    '        ' Cria uma consulta paremetrizada
    '        cmd.Parameters.Add(New SqlParameter("CodigoAluno", cod))
    '        cmd.Parameters.Add(New SqlParameter("idCurso", dgvCursos.CurrentRow().Cells(0).Value))
    '        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
    '        Dim dt As DataTable = New DataTable
    '            da.Fill(dt)
    '            dgvMensalidades.DataSource = dt

    '            'Forma a datagridview para receber os valores das parcelas
    '            PFormataDataGridView()

    '            'Verifica se tem dados na datagridview
    '            PVerificaDadosNaGrid()

    '            'Exibe o total das parcelas
    '            exibeTotal()

    '            'Exibe o total de desconto das parcelas
    '            exibeTotalDesconto()

    '            'Exibe o total de juros de cada parcela
    '            exibeTotalJuros()

    '            'Exibe o total do valor liquido das parcelas
    '            PValorLiquidoParcelas()
    '        Catch ex As Exception
    '            'MsgBox("Erro.: " + ex.Message)
    '        Finally
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub PVerificaDadosNaGrid()
    '    If Me.dgvMensalidades.RowCount = 0 Then
    '        Me.lblMensagemPagamentos.Visible = True
    '        Me.txtTotal.Text = "R$ 0,00"
    '        Me.txtTotalDesconto.Text = "R$ 0,00"
    '        Me.txtTotalJuros.Text = "R$ 0,00"
    '        Me.txtTotalLiquidoParcelas.Text = "R$ 0,00"
    '    Else
    '        Me.lblMensagemPagamentos.Visible = False
    '    End If
    'End Sub

    'Private Sub PFormataDataGridView()

    '    With dgvMensalidades
    '        '.AutoGenerateColumns = True
    '        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    '        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
    '        .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
    '        .AllowUserToResizeColumns = False
    '        .EnableHeadersVisualStyles = False

    '        .Columns(3).DefaultCellStyle.ForeColor = Color.DarkGreen
    '        .Columns(7).DefaultCellStyle.ForeColor = Color.Blue
    '        .Columns(8).DefaultCellStyle.ForeColor = Color.Red

    '        'altera a cor das linhas alternadas no grid
    '        .RowsDefaultCellStyle.BackColor = Color.White

    '        'altera o nome das colunas
    '        .Columns(0).HeaderText = "Código"
    '        .Columns(1).HeaderText = "Aluno"
    '        .Columns(2).HeaderText = "Curso"
    '        .Columns(3).HeaderText = "Valor"
    '        .Columns(4).HeaderText = "Parcela(s)"
    '        .Columns(5).HeaderText = "Vencimento"
    '        .Columns(6).HeaderText = "Pagamento"
    '        .Columns(7).HeaderText = "Desconto"
    '        .Columns(8).HeaderText = "Juros"
    '        .Columns(9).HeaderText = "Observação"

    '        'formata as colunas valor, vencimento e pagamento
    '        .Columns(3).DefaultCellStyle.Format = "c"
    '        .Columns(7).DefaultCellStyle.Format = "c"
    '        .Columns(8).DefaultCellStyle.Format = "c"
    '        .Columns(5).DefaultCellStyle.Format = "d"
    '        .Columns(6).DefaultCellStyle.Format = "d"

    '        'esconde a coluna
    '        .Columns("CodigoAluno").Visible = False

    '        'seleciona a linha inteira
    '        .SelectionMode = DataGridViewSelectionMode.FullRowSelect

    '        ' exibe nulos formatados            
    '        .Columns(6).DefaultCellStyle.NullValue = " - "

    '        'permite que o texto maior que célula não seja truncado
    '        .DefaultCellStyle.WrapMode = DataGridViewTriState.True

    '        'define o alinhamamento 
    '        .Columns("valorParcela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    '        .Columns("juros").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    '        .Columns("desconto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    '        .Columns("numeroParcela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        .Columns("vencimentoParcela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        .Columns("pagamentoParcela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '    End With
    'End Sub

    'Private Function Total() As Double
    '    Dim Tot As Double = 0
    '    Dim i As Integer = 0
    '    For i = 0 To dgvMensalidades.Rows.Count - 1
    '        Tot = Tot + Convert.ToDouble(dgvMensalidades.Rows(i).Cells("valorParcela").Value)
    '    Next i
    '    Return Tot
    'End Function

    'Private Sub exibeTotal()
    '    If dgvMensalidades.Rows.Count > 0 Then
    '        txtTotal.Text = Total().ToString("c")
    '    End If
    'End Sub

    'Private Function TotalJuros() As Double
    '    Dim jur As Double = 0
    '    Dim i As Integer = 0
    '    For i = 0 To dgvMensalidades.Rows.Count - 1
    '        jur = jur + Convert.ToDouble(dgvMensalidades.Rows(i).Cells("juros").Value)
    '    Next i
    '    Return jur
    'End Function

    'Private Sub exibeTotalJuros()
    '    If dgvMensalidades.Rows.Count > 0 Then
    '        txtTotalJuros.Text = TotalJuros().ToString("c")
    '    End If
    'End Sub

    'Private Function TotalDesconto() As Double
    '    Dim Desconto As Double = 0
    '    Dim i As Integer = 0
    '    For i = 0 To dgvMensalidades.Rows.Count - 1
    '        Desconto = Desconto + Convert.ToDouble(dgvMensalidades.Rows(i).Cells("desconto").Value)
    '    Next i

    '    Return Desconto
    'End Function

    'Private Sub exibeTotalDesconto()
    '    If dgvMensalidades.Rows.Count > 0 Then
    '        txtTotalDesconto.Text = TotalDesconto().ToString("c")
    '    End If
    'End Sub

    'Private Sub PValorLiquidoParcelas()
    '    Dim TotalBruto As Double = Me.txtTotal.Text
    '    Dim Desconto As Double = Me.txtTotalDesconto.Text
    '    Dim Juros As Double = Me.txtTotalJuros.Text
    '    Dim Liquido As Double = Me.txtTotalLiquidoParcelas.Text

    '    Liquido = TotalBruto + Juros - Desconto
    '    Me.txtTotalLiquidoParcelas.Text = (Liquido).ToString("c")
    'End Sub

    'Private Sub PBuscaValorCurso()
    '    Dim dr As SqlDataReader = Nothing

    '    Try
    '        abrir()
    '        Dim sql As String = "SELECT ValorCurso FROM tbCursos WHERE idCurso=" & dgvCursos.CurrentRow().Cells(0).Value
    '        Dim cmd As SqlCommand = New SqlCommand(sql, con)
    '            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
    '            If dr.HasRows Then
    '                dr.Read()
    '                dblValorCurso = dr.Item("ValorCurso")
    '            End If
    '        Catch ex As Exception
    '        Finally
    '            dr.Close()
    '            fechar()
    '        End Try

    'End Sub

    'Private Sub rdTodasParcelas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdTodasParcelas.CheckedChanged
    '    Me.Cursor = Cursors.WaitCursor
    '    If rdTodasParcelas.Checked = True Then
    '        codigo = lstAlunos.SelectedValue
    '        exibeParcelasAlunos(codigo, True, False, False)
    '    End If
    '    Me.Cursor = Cursors.Default
    'End Sub

    'Private Sub rdExbirParcelasPagas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdExbirParcelasPagas.CheckedChanged
    '    Me.Cursor = Cursors.WaitCursor
    '    If rdExbirParcelasPagas.Checked = True Then
    '        codigo = lstAlunos.SelectedValue
    '        exibeParcelasAlunos(codigo, False, True, False)
    '    End If
    '    Me.Cursor = Cursors.Default
    'End Sub

    'Private Sub rdExibirParcelasNaoPagar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdExibirParcelasNaoPagar.CheckedChanged
    '    Me.Cursor = Cursors.WaitCursor
    '    If rdExibirParcelasNaoPagar.Checked = True Then
    '        codigo = lstAlunos.SelectedValue
    '        exibeParcelasAlunos(codigo, False, False, False)
    '    End If
    '    Me.Cursor = Cursors.Default
    'End Sub

    'Private Sub chkExibirTodasMensalidadeCursos_CheckedChanged(sender As Object, e As EventArgs) Handles chkExibirTodasMensalidadeCursos.CheckedChanged
    '    Me.Cursor = Cursors.WaitCursor
    '    If chkExibirTodasMensalidadeCursos.Checked = True Then
    '        ToolStrip2.Enabled = False
    '        dgvCursos.Enabled = False
    '        lstAlunos.Enabled = False
    '        rdExbirParcelasPagas.Enabled = False
    '        rdExibirParcelasNaoPagar.Enabled = False
    '        rdTodasParcelas.Enabled = False
    '        PExibeTodasMensalidadesDosCursos()
    '        Me.Cursor = Cursors.Default
    '    ElseIf chkExibirTodasMensalidadeCursos.Checked = False Then
    '        ToolStrip2.Enabled = True
    '        dgvCursos.Enabled = True
    '        lstAlunos.Enabled = True
    '        rdExbirParcelasPagas.Enabled = True
    '        rdExibirParcelasNaoPagar.Enabled = True
    '        rdTodasParcelas.Enabled = True
    '        PPreencheListaBoxCursos()
    '    End If
    'End Sub

    'Private Sub PExcluiAlunos()

    '    Try
    '        abrir()
    '        Dim ResultadoQuery As Integer = 0
    '        Dim sqlconsulta As String = "SELECT COUNT(*) FROM tbAlunos INNER JOIN tbMensalidades ON tbAlunos.CodigoAluno = tbMensalidade.CodigoAluno WHERE tbAlunos.CodigoAluno=" & Me.lstAlunos.SelectedValue
    '        Dim CmdConsulta As SqlCommand = New SqlCommand(sqlconsulta, con)
    '        ResultadoQuery = CmdConsulta.ExecuteScalar

    '            If ResultadoQuery = 0 Then

    '                If (MessageBox.Show("Tem certeza que deseja excluir o Aluno.: " & Me.lstAlunos.Text & "?", "CS .Net Tecnologia",
    '                                    MessageBoxButtons.YesNo) <> vbYes) Then Exit Sub

    '                Dim sql As String = "DELETE FROM tab_Alunos WHERE CodigoAluno=" & Me.lstAlunos.SelectedValue
    '            Dim Cmd As SqlCommand = New SqlCommand(sql, con)
    '            Cmd.ExecuteNonQuery()
    '                PPreencheListBoxAlunos()
    '            Else
    '            MsgBox("Para excluir um Aluno da lista, primeiro exclua todas as mensalidade(s) referente ao mesmo.", MsgBoxStyle.Information,
    '                       "CS .Net Tecnologia")
    '        End If
    '        Catch ex As Exception
    '            Throw ex
    '        Finally
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub PVerificaQtdAlunos()
    '    Try
    '        lblCurso.Text = dgvCursos.CurrentRow().Cells(1).Value & ".:"
    '        lblContagemAlunos.Text = "0"
    '        lblContagemAlunos.Text = Format(CInt(lblContagemAlunos.Text) + Me.lstAlunos.Items.Count, "00000").ToString
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Function GetSelectedRowCollection()

    '    Dim total As Double
    '    Dim LinhasSelecionadas As Integer

    '    If Me.dgvMensalidades.SelectedRows.Count > 0 Then

    '        Dim drc As DataGridViewSelectedRowCollection = Me.dgvMensalidades.SelectedRows

    '        For i As Integer = 0 To drc.Count - 1
    '            Dim TotalValor As Double = drc(i).Cells("valorParcela").Value
    '            Dim Linhas As Double = Me.dgvMensalidades.SelectedRows.Count
    '            Dim Media As Double

    '            total = total + TotalValor
    '            LinhasSelecionadas = Linhas
    '            Media = total / LinhasSelecionadas

    '            Me.lblTotalItensSelecionados.Text = (total).ToString("c")
    '            Me.lblTotalLinhasSelecionadas.Text = LinhasSelecionadas
    '            Me.lblMediaContagemTotal.Text = (Media).ToString("c")
    '        Next
    '    Else
    '        Return Nothing
    '    End If

    '    Return True
    'End Function



    'Private Sub PTransfereCursosPagos()
    '    Me.Cursor = Cursors.WaitCursor

    '    Try
    '        abrir()
    '        For i As Integer = 0 To dgvMensalidades.RowCount - 1

    '            Dim CodigoAluno As String = dgvMensalidades.CurrentRow().Cells("CodigoAluno").Value
    '            Dim CodigoCurso As String = dgvCursos.CurrentRow().Cells(0).Value
    '            Dim valorParcela As String = dgvMensalidades.CurrentRow().Cells("valorParcela").Value
    '            Dim numeroParcela As String = dgvMensalidades.CurrentRow().Cells("numeroParcela").Value
    '            Dim vencimentoParcela As String = dgvMensalidades.CurrentRow().Cells("vencimentoParcela").Value
    '            Dim pagamentoParcela As String = dgvMensalidades.CurrentRow().Cells("pagamentoParcela").Value
    '            Dim juros As String = dgvMensalidades.CurrentRow().Cells("juros").Value
    '            Dim desconto As String = dgvMensalidades.CurrentRow().Cells("desconto").Value
    '            Dim observacao As String = dgvMensalidades.CurrentRow().Cells("observacao").Value


    '            Dim sql As String
    '            sql = "Insert Into tab_CursosPagos(CodigoAluno,CodigoCurso,valorParcela,"
    '            sql += "numeroParcela,vencimentoParcela,pagamentoParcela,juros,desconto, observacao) values(?,?,?,?,?,?,?,?,?)"

    '            Dim cmd As New SqlCommand(sql, con)
    '            cmd.Parameters.Add(New SqlParameter("CodigoAluno", CodigoAluno))
    '            cmd.Parameters.Add(New SqlParameter("CodigoCurso", CodigoCurso))
    '            cmd.Parameters.Add(New SqlParameter("valorParcela", valorParcela))
    '            cmd.Parameters.Add(New SqlParameter("numeroParcela", numeroParcela))
    '            cmd.Parameters.Add(New SqlParameter("vencimentoParcela", vencimentoParcela))
    '            cmd.Parameters.Add(New SqlParameter("pagamentoParcela", pagamentoParcela))
    '            cmd.Parameters.Add(New SqlParameter("juros", juros))
    '            cmd.Parameters.Add(New SqlParameter("desconto", desconto))
    '            cmd.Parameters.Add(New SqlParameter("observacao", observacao))
    '            cmd.ExecuteNonQuery()

    '            'Exclui conforme adiciona na tabela de cursos pagos
    '            PExcluiCursoPago()

    '            'pega o codigo do aluno e atualiza a grid para exluir a proxima mensalidade
    '            exibeParcelasAlunos(lstAlunos.SelectedValue)
    '        Next

    '        'Exclui aluno do curso pago
    '        PExlcuiAlunoCursoConcluido()

    '        'Preencha novamente os cursos e seus alunos
    '        PPreencheListaBoxCursos()
    '        Me.Cursor = Cursors.Default
    '        MessageBox.Show("As mensalidades foram transferidas com sucesso.", "CS .Net Tecnologia", MessageBoxButtons.OK _
    '                              , MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    Finally
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub PExcluiCursoPago()

    '    Try
    '        abrir()
    '        Dim CodigoMensalidade As String = dgvMensalidades.CurrentRow().Cells("CodigoMensalidade").Value
    '            Dim sql As String = "Delete * From tbMensalidades Where CodigoMensalidade=" & CodigoMensalidade
    '        Dim cmd As New SqlCommand(sql, con)
    '        cmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    Finally
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub PExlcuiAlunoCursoConcluido()

    '    Try
    '        abrir()
    '        Dim sql As String = " DELETE tbAlunoCurso FROM  tbAlunoCurso " &
    '                                " WHERE tbAlunoCurso.[CodigoAluno] =" & lstAlunos.SelectedValue &
    '                                " And tbAlunoCurso.[idCurso] = " & dgvCursos.CurrentRow().Cells(0).Value
    '        Dim cmd As New SqlCommand(sql, con)
    '        cmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    Finally
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub PVerificaQtdAlunos()
    '    Try
    '        lblCurso.Text = dgvCursos.CurrentRow().Cells(1).Value & ".:"
    '        lblContagemAlunos.Text = "0"
    '        lblContagemAlunos.Text = Format(CInt(lblContagemAlunos.Text) + Me.lstAlunos.Items.Count, "00000").ToString
    '    Catch ex As Exception

    '    End Try
    'End Sub

End Class