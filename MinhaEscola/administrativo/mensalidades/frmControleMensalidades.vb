Imports System.Data.SqlClient
Imports System.Text

Public Class frmControleMensalidades
    Dim Alunos As String
    Dim codigo As Integer
    Dim dataPagamento As Boolean


    Private Sub frmControleMensalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PPreencheListaBoxCursos()
        PCarregaInformacoesIniciais()
        ''  If FVerificaListBoxCursos() = False Then Exit Sub
    End Sub

    Private Sub frmControleMensalidades_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        PPreencheListaBoxCursos()
    End Sub

    Private Function FVerificaListBoxCursos() As Boolean
        If dgvCursos.RowCount = 0 Then
            MsgBox("Ainda não foram cadastrados nenhum curso no momento. " &
                   "Por favor cadastre pelo menos um curso para ter acesso ao controle de mensalidades.",
                   MsgBoxStyle.Information, "VAL TESTE Tecnologia")
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

            FormatarDGCursos()

            PPreencheListBoxAlunos()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        Finally
            fechar()
        End Try

    End Sub

    Private Sub FormatarDGCursos()

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
            .Columns(1).Visible = False
            .Columns(5).Visible = False

        End With
    End Sub


    Private Sub dgvCursos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellEnter
        PPreencheListBoxAlunos()
    End Sub

    Public Sub PPreencheListBoxAlunos()
        ' Dim dt As New DataTable
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim v As Integer
        ' v = lblidCurso.Text

        lblidCurso.Text = dgvCursos.CurrentRow.Cells(1).Value

        Try
            abrir()
            da = New SqlDataAdapter("pa_Mensalidade_preencheAlunos", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@idCurso", dgvCursos.CurrentRow.Cells(0).Value)

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
                txtCodigo.Text = ""
                txtCPF.Text = ""
                txtRG.Text = ""
                txtNome.Text = ""
                txtEmail.Text = ""
                txtCelular.Text = ""
                txtCep.Text = ""
                txtEndereco.Text = ""
                txtNum.Text = ""
                txtComplemento.Text = ""
                txtCompl.Text = ""
                txtUF.Text = ""
                txtBairro.Text = ""
                txtCidade.Text = ""
                txtTotal.Text = "R$ 0,00"
                txtTotalDesconto.Text = "R$ 0,00"
                txtTotalJuros.Text = "R$ 0,00"
                txtTotalLiquidoParcelas.Text = "R$ 0,00"
            End If

        Catch ex As Exception
            '  MsgBox(ex.Message.ToString, MsgBoxStyle.Information, "VALDEM Tecnologia")
        Finally
            fechar()
        End Try

    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub


    Private Sub Listar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("pa_Mensalidade_listaMensalidade", con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.Fill(dt)
            dgvMensalidades.DataSource = dt

            ' ContarLinhas()

            ' FormatarDGMensalidades()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar as mensalidades" + ex.Message.ToString)
        Finally

            fechar()
        End Try

    End Sub

    Private Sub FormatarDGMensalidades()

        With dgvMensalidades
            '.AutoGenerateColumns = True
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False

            .Columns(3).DefaultCellStyle.ForeColor = Color.DarkGreen
            .Columns(7).DefaultCellStyle.ForeColor = Color.Blue
            .Columns(8).DefaultCellStyle.ForeColor = Color.Red

            'altera a cor das linhas alternadas no grid
            .RowsDefaultCellStyle.BackColor = Color.White

            'altera o nome das colunas

            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "idAluno"
            .Columns(2).HeaderText = "idCurso"
            .Columns(3).HeaderText = "Curso"
            .Columns(4).HeaderText = "Valor"
            .Columns(5).HeaderText = "Parcela(s)"
            .Columns(6).HeaderText = "Vencimento"
            .Columns(7).HeaderText = "Pagamento"
            .Columns(8).HeaderText = "Desconto"
            .Columns(9).HeaderText = "Juros"
            .Columns(10).HeaderText = "Observação"
            .Columns(11).HeaderText = "Situação"

            'formata as colunas valor, vencimento e pagamento
            .Columns(4).DefaultCellStyle.Format = "c"
            .Columns(6).DefaultCellStyle.Format = "d"
            .Columns(7).DefaultCellStyle.Format = "d"
            .Columns(8).DefaultCellStyle.Format = "c"
            .Columns(9).DefaultCellStyle.Format = "c"

            'esconde a coluna
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).Visible = False

            'permite que o texto maior que célula não seja truncado
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True

            'define o alinhamamento 
            .Columns("valorParcela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("juros").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("desconto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("numeroParcela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("vencimentoParcela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("pagamentoParcela").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub


    Private Sub CalculaContas()
        Dim dblContasPagas, dblContasNaoPagas, dblTotalContas, dblContasAtrasadas As Double



        For Each linha As DataGridViewRow In dgvMensalidades.Rows

            Dim vlcompra = Replace(linha.Cells(4).Value, ".", ",")

            'Total de todas as Contas
            dblTotalContas = dblTotalContas + vlcompra

            'Total Contas Pagas
            'If linha.Cells("situacao").Value = "Paga" Then
            '    dblContasPagas = dblContasPagas + vlcompra
            'End If

            ''Total Contas Não Pagas
            'If linha.Cells("situacao").Value = "Não Paga" Then
            '    dblContasNaoPagas = dblContasNaoPagas + vlcompra
            'End If

            ''Total Contas Atrasadas
            'If linha.Cells("situacao").Value = "Vencida" Then
            '    dblContasAtrasadas = dblContasAtrasadas + vlcompra
            'End If

        Next

        ' txtTotalContasPagas.Text = FormatCurrency(dblContasPagas)
        ' txtTotalContasNaoPagas.Text = FormatCurrency(dblContasNaoPagas)
        txtTotalContasPagar.Text = FormatCurrency(dblTotalContas)
        ' txtTotalContasAtrasadas.Text = FormatCurrency(dblContasAtrasadas)

    End Sub

    Private Sub PCarregaInformacoesIniciais()
        ' Listar()
        CalculaContas()
        'Mostra todas as parcelas       
        rdTodasParcelas.Checked = True
        'obtem o nome selecionado no listbox
        Alunos = lstAlunos.Text


        '    '    '    'Dim codigo As Integer = Convert.ToInt32(lstAlunos.SelectedValue.ToString())
        codigo = lstAlunos.SelectedValue

        'exibe o nome e sobrenome do Alunos
        PExibeDadosAlunos(Alunos)
        '    '    '    'Exibe as parcelas dos alunos
        '    ' exibeParcelasAlunos(codigo)

        '    '    'Calcula o valor liquido das parcelas
        '    PValorLiquidoParcelas()

        '    '    'Verifica a quantidade de alunos
        '    'PVerificaQtdAlunos()

        '    '    '    'Verifica a cor atual do sistema
        '    '    ' PVerificaACorAtual()
        '    '    Me.Cursor = Cursors.Default
    End Sub


    Private Sub lstAlunos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlunos.SelectedIndexChanged
        PCarregaInformacoesIniciais()
    End Sub

    Private Sub rdTodasParcelas_CheckedChanged(sender As Object, e As EventArgs) Handles rdTodasParcelas.CheckedChanged
        Me.Cursor = Cursors.WaitCursor
        If rdTodasParcelas.Checked = True Then
            codigo = lstAlunos.SelectedValue
            exibeParcelasAlunos(codigo, True, False, False)
        End If

    End Sub

    Private Sub exibeParcelasAlunos(ByVal cod As Integer, Optional ByVal TodasParcelas As Boolean = True,
                                      Optional ByVal Pagas As Boolean = False, Optional ByVal NaoPaga As Boolean = False)
        Try
            abrir()

            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            If TodasParcelas = True And Pagas = False And NaoPaga = False Then
                da = New SqlDataAdapter("pa_Mensalidade_ExibeParcelaAluno1", con)
                'Exportar para excel
                '  strSqlExcel = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao " &
                '         "FROM tab_Mensalidades WHERE CodigoAluno=" & Me.lstAlunos.SelectedValue
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@CodigoAluno", cod)
                da.SelectCommand.Parameters.AddWithValue("@idCurso", dgvCursos.CurrentRow().Cells(0).Value)

                da.Fill(dt)

                dgvMensalidades.DataSource = dt

            End If
        Catch ex As Exception
            MsgBox("Erro.: " + ex.Message)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub PExibeDadosAlunos(ByVal nome As String)

        Dim strQuery As New StringBuilder
        Dim bolResult As Boolean
        Dim dr As SqlDataReader = Nothing
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try

            abrir()

            Dim cmd As New SqlCommand("pa_Mensalidade_pesquisaNome", con)
            cmd.CommandType = CommandType.StoredProcedure

            ' Cria uma consulta paremetrizada
            cmd.Parameters.AddWithValue("@NomeAluno", nome)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtCodigo.Text = dr.Item("CodigoAluno")
                txtCPF.Text = dr.Item("cpf")
                txtRG.Text = dr.Item("rg")
                txtNome.Text = dr.Item("NomeAluno")
                txtEmail.Text = dr.Item("email")
                txtCelular.Text = dr.Item("celular")
                txtCep.Text = dr.Item("cep")
                txtEndereco.Text = dr.Item("endereco")
                txtNum.Text = dr.Item("num")
                txtComplemento.Text = dr.Item("complemento")
                txtCompl.Text = dr.Item("compl")
                txtUF.Text = dr.Item("UF")
                txtBairro.Text = dr.Item("bairro")
                txtCidade.Text = dr.Item("cidade")
            Else
                'limpa as caixas de texto
                For Each ctl As Control In Me.Controls
                    If TypeOf ctl Is TextBox Then ctl.Text = ""
                Next ctl

            End If
        Catch ex As Exception
            Throw New Exception("Ocorreu um erro ao autenticar o usuário: " & ex.Message.ToString)

        Finally
            dr.Close()
            fechar()
        End Try
    End Sub

    'Private Sub PExibeTodasMensalidadesDosCursos()

    '    Dim dt As New DataTable
    '    Dim da As SqlDataAdapter
    '    Try
    '        abrir()

    '        da = New SqlDataAdapter("pa_Mensalidade_preencheCursos", con)
    '        da.SelectCommand.CommandType = CommandType.StoredProcedure
    '        da.Fill(dt)
    '        dgvMensalidades.DataSource = dt

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

    '        Dim dt As New DataTable
    '        Dim da As SqlDataAdapter

    '        If TodasParcelas = True And Pagas = False And NaoPagas = False Then
    '            da = New SqlDataAdapter("pa_Mensalidade_ExibeParcelaAluno1", con)
    '            'Exportar para excel
    '            '  strSqlExcel = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao " &
    '            '         "FROM tab_Mensalidades WHERE CodigoAluno=" & Me.lstAlunos.SelectedValue
    '            da.SelectCommand.CommandType = CommandType.StoredProcedure
    '            da.SelectCommand.Parameters.AddWithValue("@CodigoAluno", cod)
    '            da.SelectCommand.Parameters.AddWithValue("@idCurso", dgvCursos.CurrentRow().Cells(0).Value)

    '            da.Fill(dt)

    '            dgvMensalidades.DataSource = dt

    '        End If
    '        If TodasParcelas = False And Pagas = True And NaoPagas = False Then
    '            da = New SqlDataAdapter("pa_Mensalidade_ExibeParcelaAluno2", con)
    '            'Exportar para excel
    '            'strSqlExcel = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao FROM tab_Mensalidades WHERE CodigoAluno=" & Me.lstAlunos.SelectedValue &
    '            ' " AND (NOT (tab_Mensalidades.pagamentoParcela IS NULL))"
    '            da.SelectCommand.CommandType = CommandType.StoredProcedure
    '            da.SelectCommand.Parameters.AddWithValue("@CodigoAluno", cod)
    '            da.SelectCommand.Parameters.AddWithValue("@idCurso", dgvCursos.CurrentRow().Cells(0).Value)

    '            da.Fill(dt)

    '            dgvMensalidades.DataSource = dt
    '        End If
    '        If TodasParcelas = False And Pagas = False And NaoPagas = False Then
    '            da = New SqlDataAdapter("pa_Mensalidade_ExibeParcelaAluno3", con)
    '            'Exportar para excel
    '            'strSqlExcel = "SELECT CodigoMensalidade, CodigoAluno, NomeCurso, ValorParcela, NumeroParcela, VencimentoParcela, PagamentoParcela, Desconto, Juros, Observacao FROM tab_Mensalidades WHERE CodigoAluno=" & Me.lstAlunos.SelectedValue &
    '            '  "  AND (tab_Mensalidades.pagamentoParcela IS NULL)"
    '            da.SelectCommand.CommandType = CommandType.StoredProcedure
    '            da.SelectCommand.Parameters.AddWithValue("@CodigoAluno", cod)
    '            da.SelectCommand.Parameters.AddWithValue("@idCurso", dgvCursos.CurrentRow().Cells(0).Value)

    '            da.Fill(dt)

    '            dgvMensalidades.DataSource = dt
    '        End If



    '        'Forma a datagridview para receber os valores das parcelas

    '        PFormataDataGridView()

    '        'Verifica se tem dados na datagridview
    '        ' PVerificaDadosNaGrid()

    '        'Exibe o total das parcelas
    '        exibeTotal()

    '        'Exibe o total de desconto das parcelas
    '        exibeTotalDesconto()

    '        'Exibe o total de juros de cada parcela
    '        exibeTotalJuros()

    '        'Exibe o total do valor liquido das parcelas
    '        PValorLiquidoParcelas()

    '    Catch ex As Exception
    '        MsgBox("Erro.: " + ex.Message.ToString)
    '    Finally
    '        fechar()
    '    End Try

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
    '        'CodigoMensalidade	CodigoAluno	NomeCurso	ValorParcela	NumeroParcela	VencimentoParcela	PagamentoParcela	Desconto	Juros	Observacao
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
    '        dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
    '        If dr.HasRows Then
    '            dr.Read()
    '            dblValorCurso = dr.Item("ValorCurso")
    '        End If
    '    Catch ex As Exception
    '    Finally
    '        dr.Close()
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub rdTodasParcelas_CheckedChanged(sender As Object, e As EventArgs) Handles rdTodasParcelas.CheckedChanged

    'End Sub

    'Private Sub rdExbirParcelasPagas_CheckedChanged(sender As Object, e As EventArgs) Handles rdExbirParcelasPagas.CheckedChanged
    '    Me.Cursor = Cursors.WaitCursor
    '    If rdExbirParcelasPagas.Checked = True Then
    '        codigo = lstAlunos.SelectedValue
    '        exibeParcelasAlunos(codigo, False, True, False)
    '    End If
    '    Me.Cursor = Cursors.Default
    'End Sub

    'Private Sub rdExibirParcelasNaoPagar_CheckedChanged(sender As Object, e As EventArgs) Handles rdExibirParcelasNaoPagar.CheckedChanged
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
    '        tsMenu.Enabled = False
    '        dgvCursos.Enabled = False
    '        lstAlunos.Enabled = False
    '        rdExbirParcelasPagas.Enabled = False
    '        rdExibirParcelasNaoPagar.Enabled = False
    '        rdTodasParcelas.Enabled = False
    '        PExibeTodasMensalidadesDosCursos()
    '        Me.Cursor = Cursors.Default
    '    ElseIf chkExibirTodasMensalidadeCursos.Checked = False Then
    '        tsMenu.Enabled = True
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

    '        If ResultadoQuery = 0 Then

    '            If (MessageBox.Show("Tem certeza que deseja excluir o Aluno.: " & Me.lstAlunos.Text & "?", "Valdemir Tecnologia",
    '                                    MessageBoxButtons.YesNo) <> vbYes) Then Exit Sub

    '            Dim sql As String = "DELETE FROM tab_Alunos WHERE CodigoAluno=" & Me.lstAlunos.SelectedValue
    '            Dim Cmd As SqlCommand = New SqlCommand(sql, con)
    '            Cmd.ExecuteNonQuery()
    '            PPreencheListBoxAlunos()
    '        Else
    '            MsgBox("Para excluir um Aluno da lista, primeiro exclua todas as menslidade(s) refente ao mesmo.", MsgBoxStyle.Information,
    '                       "Valdemir Tecnologia")
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub PVerificaQtdAlunos()
    '    Try
    '        lblCurso.Text = dgvCursos.CurrentRow().Cells(3).Value & ".:"
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

    'Private Sub dgvMensalidades_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMensalidades.CellEnter
    '    '---Quando o usuário clicar no controle , exibe o conteudo da célula referente a primeira coluna (Column=0)
    '    Try
    '        'codigo da parcela
    '        codParcela = dgvMensalidades.Rows(e.RowIndex).Cells(0).Value
    '        'data pagamento
    '        If dgvMensalidades.Rows(e.RowIndex).Cells(6).Value = Nothing Then
    '            dataPagamento = False
    '        Else
    '            dataPagamento = True
    '        End If
    '    Catch
    '        dataPagamento = False
    '    End Try
    'End Sub

    'Private Sub dgvMensalidades_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMensalidades.SelectionChanged
    '    GetSelectedRowCollection()
    'End Sub

    'Private Sub btnGerarMensalidade_Click(sender As Object, e As EventArgs) Handles btnGerarMensalidade.Click
    '    If lstAlunos.Items.Count = 0 Then
    '        MsgBox("Para gerar mensalidade primeiro matrícule um aluno no curso de " & dgvCursos.CurrentRow().Cells(1).Value & ".",
    '               MsgBoxStyle.Information, "VALDEMIR Tecnologia")
    '        Exit Sub
    '    End If
    '    'Obtem o valor do curso
    '    PBuscaValorCurso()
    '    strNomeAluno = Me.lstAlunos.Text
    '    intCodigoAluno = Me.lstAlunos.SelectedValue
    '    strNomeCurso = dgvCursos.CurrentRow().Cells(3).Value
    '    intCodigoCurso = dgvCursos.CurrentRow().Cells(0).Value
    '    frmGeraMensalidade.ShowDialog()
    '    exibeParcelasAlunos(lstAlunos.SelectedValue)
    'End Sub

    'Private Sub btnAlterarMensalidade_Click(sender As Object, e As EventArgs) Handles btnAlterarMensalidade.Click
    '    If dgvMensalidades.RowCount = 0 Then
    '        MsgBox("Não existem mensalidades geradas até o presente momento.",
    '               MsgBoxStyle.Information, "CS .Net Tecnologia")
    '        Exit Sub
    '    End If
    '    If Not strPerfilUsuario.Equals("admin") Then
    '        MsgBox("Para alterar dados de uma mensalidade contate o Administrador.", MsgBoxStyle.Information, "CS .Net Tecnologia")
    '    Else
    '        If dataPagamento = False Then
    '            MessageBox.Show("Ainda não foi realizado o pagamento desta mensalidade." &
    '                            Environment.NewLine & Environment.NewLine &
    '                            "Para alterar uma mensalidade primeiro realize o pagamento da mesma.", "CS .Net Tecnologia",
    '                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '        Else
    '            If codParcela > 0 Then
    '                'Obtem o valor do curso
    '                PBuscaValorCurso()
    '                strNomeAluno = Me.lstAlunos.Text
    '                intCodigoAluno = Me.lstAlunos.SelectedValue
    '                strNomeCurso = dgvCursos.CurrentRow().Cells(3).Value
    '                frmAlterarMensalidade.ShowDialog()
    '                exibeParcelasAlunos(codigo, True)
    '            Else
    '                MessageBox.Show("Selecione uma mensalidade para que possa ser realizado o pagamento.", "CS .Net Tecnologia",
    '                              MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '            End If
    '        End If
    '    End If
    'End Sub

    ''Private Sub btnExcluirMensalidade_Click(sender As Object, e As EventArgs) Handles btnExcluirMensalidade.Click
    ''    If dgvMensalidades.RowCount = 0 Then
    ''        MsgBox("Não existem mensalidades geradas até o presente momento.",
    ''               MsgBoxStyle.Information, "CS .Net Tecnologia")
    ''        Exit Sub
    ''    End If
    ''    If Not strPerfilUsuario.Equals("Administrador") Then
    ''        MessageBox.Show("Para excluir dados de uma mensalidade contate o Administrador.", "CS .Net Tecnologia",
    ''                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    ''    Else
    ''        If codParcela > 0 Then
    ''            'Obtem o valor do curso
    ''            PBuscaValorCurso()
    ''            strNomeAluno = Me.lstAlunos.Text
    ''            intCodigoParcelaExcluir = codParcela
    ''            strNomeCurso = dgvCursos.CurrentRow().Cells(1).Value
    ''            frmExcluirMensalidade.ShowDialog()
    ''            exibeParcelasAlunos(lstAlunos.SelectedValue)
    ''        Else
    ''            MessageBox.Show("Selecione uma mensalidade para que possa ser realizado o pagamento.", "CS .Net Tecnologia",
    ''                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    ''        End If
    ''    End If
    ''End Sub

    ''Private Sub btnBaixaMensalidade_Click(sender As Object, e As EventArgs) Handles btnBaixaMensalidade.Click
    ''    If dgvMensalidades.RowCount = 0 Then
    ''        MsgBox("Não existem mensalidades geradas até o presente momento.",
    ''               MsgBoxStyle.Information, "CS .Net Tecnologia")
    ''        Exit Sub
    ''    End If
    ''    If codParcela > 0 Then
    ''        If dataPagamento Then
    ''            MessageBox.Show("O pagamento desta mensalidade já foi efetuado.", "CS .Net Tecnologia",
    ''                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    ''        Else
    ''            strNomeAluno = Me.lstAlunos.Text
    ''            intCodigoParcelaPagar = codParcela
    ''            strNomeCurso = dgvCursos.CurrentRow().Cells(1).Value
    ''            frmPagamentoMensalidade.ShowDialog()
    ''            exibeParcelasAlunos(codigo, True)
    ''            'Calcula o valor liquido das parcelas.
    ''            PValorLiquidoParcelas()
    ''        End If
    ''    Else
    ''        MessageBox.Show("Selecione uma mensalidade para que possa ser realizado o pagamento.", "CS .Net Tecnologia",
    ''                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    ''    End If

    ''    'Transfere o curso pago para a lista de cursos pagos
    ''    Dim linha As DataGridViewRow
    ''    Dim contRegistros As Integer = dgvMensalidades.RowCount
    ''    Dim contSelecionados As Integer = 0

    ''    For Each linha In dgvMensalidades.Rows
    ''        If linha.Cells("pagamentoParcela").Value.ToString <> "" Then
    ''            contSelecionados += 1
    ''        End If
    ''    Next

    ''    If contRegistros = contSelecionados Then
    ''        intPergunta = MsgBox("Todas as mensalidades deste curso foram pagas. É aconselhavel que tranfira para a lista de cursos pagos." &
    ''                             " Deseja que o sistema transfira o curso de " & lstAlunos.Text & " agora?",
    ''                           MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CS .Net Tecnologia")
    ''        If intPergunta = vbNo Then Exit Sub
    ''        frmAguarde.ShowDialog()
    ''        PTransfereCursosPagos()
    ''        MsgBox("Todas as mensalidades foram transferidas para a lista de cursos pagos com sucesso.",
    ''               MsgBoxStyle.Information, "CS .Net Tecnologia")
    ''    Else
    ''        Exit Sub
    ''    End If
    ''End Sub


    ''Private Sub PTransfereCursosPagos()
    ''    Me.Cursor = Cursors.WaitCursor

    ''    Try
    ''        abrir()
    ''        For i As Integer = 0 To dgvMensalidades.RowCount - 1

    ''            Dim CodigoAluno As String = dgvMensalidades.CurrentRow().Cells("CodigoAluno").Value
    ''            Dim CodigoCurso As String = dgvCursos.CurrentRow().Cells(0).Value
    ''            Dim valorParcela As String = dgvMensalidades.CurrentRow().Cells("valorParcela").Value
    ''            Dim numeroParcela As String = dgvMensalidades.CurrentRow().Cells("numeroParcela").Value
    ''            Dim vencimentoParcela As String = dgvMensalidades.CurrentRow().Cells("vencimentoParcela").Value
    ''            Dim pagamentoParcela As String = dgvMensalidades.CurrentRow().Cells("pagamentoParcela").Value
    ''            Dim juros As String = dgvMensalidades.CurrentRow().Cells("juros").Value
    ''            Dim desconto As String = dgvMensalidades.CurrentRow().Cells("desconto").Value
    ''            Dim observacao As String = dgvMensalidades.CurrentRow().Cells("observacao").Value

    ''            Dim cmd As SqlCommand
    ''            'Dim sql As String  'pa_CursosPagos_Salvar
    ''            'sql = "Insert Into tbCursosPagos(CodigoAluno,idCurso,valorParcela,"
    ''            'sql += "numeroParcela,vencimentoParcela,pagamentoParcela,juros,desconto, observacao) values(?,?,?,?,?,?,?,?,?)"

    ''            'Dim cmd As New OleDbCommand(sql, con)
    ''            cmd = New SqlCommand("pa_CursosPagos_Salvar", con)
    ''            cmd.CommandType = CommandType.StoredProcedure
    ''            cmd.Parameters.AddWithValue("@CodigoAluno", CodigoAluno)
    ''            cmd.Parameters.AddWithValue("@idCurso", CodigoCurso)
    ''            cmd.Parameters.AddWithValue("@valorParcela", valorParcela)
    ''            cmd.Parameters.AddWithValue("@numeroParcela", numeroParcela)
    ''            cmd.Parameters.AddWithValue("@vencimentoParcela", vencimentoParcela)
    ''            cmd.Parameters.AddWithValue("@pagamentoParcela", pagamentoParcela)
    ''            cmd.Parameters.AddWithValue("@juros", juros)
    ''            cmd.Parameters.AddWithValue("@desconto", desconto)
    ''            cmd.Parameters.AddWithValue("@observacao", observacao)
    ''            cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
    ''            cmd.ExecuteNonQuery()

    ''            Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
    ''            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)


    ''            'Exclui conforme adiciona na tabela de cursos pagos
    ''            PExcluiCursoPago()

    ''            'pega o codigo do aluno e atualiza a grid para exluir a proxima mensalidade
    ''            exibeParcelasAlunos(lstAlunos.SelectedValue)
    ''        Next

    ''        'Exclui aluno do curso pago
    ''        PExlcuiAlunoCursoConcluido()

    ''        'Preencha novamente os cursos e seus alunos
    ''        PPreencheListaBoxCursos()
    ''        Me.Cursor = Cursors.Default
    ''        'MessageBox.Show("As mensalidades foram transferidas com sucesso.", "CS .Net Tecnologia", MessageBoxButtons.OK _
    ''        '                      , MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    ''    Catch ex As Exception
    ''        MsgBox(ex.Message.ToString)
    ''    Finally
    ''        fechar()
    ''    End Try

    ''End Sub

    'Private Sub PExcluiCursoPago()

    '    Try
    '        abrir()
    '        Dim CodigoMensalidade As String = dgvMensalidades.CurrentRow().Cells("CodigoMensalidade").Value
    '        Dim cmd As SqlCommand

    '        cmd = New SqlCommand("pa_CursosPagos_Excluir", con)
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.AddWithValue("@CodigoMensalidade", CodigoMensalidade)
    '        cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
    '        cmd.ExecuteNonQuery()

    '        Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
    '        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    Finally
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub PExlcuiAlunoCursoConcluido()
    '    Dim cmd As SqlCommand
    '    Dim CodigoCurso As String = dgvCursos.CurrentRow().Cells(0).Value
    '    Dim codAluno As String = lstAlunos.SelectedValue

    '    Try
    '        abrir()
    '        Dim sql As String = " DELETE tab_AlunoCurso FROM  tab_AlunoCurso " &
    '                                " WHERE tab_AlunoCurso.[CodigoAluno] =" & lstAlunos.SelectedValue &
    '                                " And tab_AlunoCurso.[CodigoCurso] = " & dgvCursos.CurrentRow().Cells(0).Value



    '        'Dim cmd As New OleDbCommand(sql, con)
    '        cmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    Finally
    '        fechar()
    '    End Try

    'End Sub

    'Private Sub btNovaMatricula_Click(sender As Object, e As EventArgs) Handles btNovaMatricula.Click

    'End Sub

    'Private Sub btnAlterarMatricula_Click(sender As Object, e As EventArgs) Handles btnAlterarMatricula.Click

    'End Sub

    'Private Sub btnExcluirMatricula_Click(sender As Object, e As EventArgs) Handles btnExcluirMatricula.Click

    'End Sub
End Class