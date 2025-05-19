Module mdlVariaveis
    Public usuarioNome As String
    Public objMenus As New ArrayList
    Public empresaNome As String
    Public codParcela As Integer
    Public strNomeAluno As String
    Public intCodigoAluno As Integer
    Public strNomeCurso As String
    Public intCodigoCurso As Integer
    Public strPerfilUsuario As String

    Public intCodigoCursoHorario As Integer
    Public intCodigoCursoHorarioExcluir As Integer
    Public intPergunta As Integer
    Public intCodigoLancamento As Integer = 0

    Public intCodigoParcelaExcluir As Integer
    Public intCodigoParcelaPagar As Integer
    Public strSenhaUsuario As String
    Public strLoginUsuario As String
    Public intNovaMatricula As Integer
    Public dblValorCurso As Double
    Public intCodigoUsuario As Integer
    Public intAviso As Integer
    Public intCodigoSerial As Integer
    Public intDiasSerial As Integer
    Public strSerial As String


    Public ProdutoEscolhidoLista As String
    Public SaldoProdutoEscolhidoLista As Integer
    Public SaidaProdutoEscolhidoLista As Integer

    Public Codigo As Integer
    Public Periodo As String
    Public Horas As String
    Public Segunda As String
    Public Terca As String
    Public Quarta As String
    Public Quinta As String
    Public Sexta As String
    Public Sabado As String
    Public ProfSegunda As String
    Public ProfTerca As String
    Public ProfQuarta As String
    Public ProfQuinta As String
    Public ProfSexta As String
    Public ProfSabado As String
    Public strSqlExcel As String



    Public Function VerificaDiaNaoUtil(ByVal dataParcela As Date) As Date
        'se for sabado ou domingo transfere para dia util
        If dataParcela.DayOfWeek = DayOfWeek.Sunday Then
            dataParcela = dataParcela.AddDays(1)
        ElseIf dataParcela.DayOfWeek = DayOfWeek.Saturday Then
            dataParcela = dataParcela.AddDays(2)
        End If
        Return dataParcela
    End Function

    Public Sub PVerificaACorAtual()
        If My.Settings.intVerificaCorAtual = 0 Then

            '  frmControleCaixa.dgvResumo.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            frmRelacaoCompletaHorarios.dgvRelacaoCursosHorarios.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            frmRelacaoCompletaHorarios.dgvRelacaoCursosHorariosProfessores.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            '  frmCadastroCursosHorarios.btnConfirmar.BackColor = My.Settings.strCorAtualSistema
            '  frmCadastroCursosHorarios.btnCancelar.BackColor = My.Settings.strCorAtualSistema

            ' frmProfessores .txtProfessor.BackColor = My.Settings.strCorAtualSistema
            ' frmCadastroProfessores.btnVizualizarRelacaoAlunos.BackColor = My.Settings.strCorAtualSistema

            '  frmControleMatricula.dgvCursosAlunos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            '  frmAniversariantes.dgvAniversariantes.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            '   frmControleBancario.dgvControleBancario.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            ' frmControleGastos.dgvControleGastos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            frmControleGastos.txtUsuarioLogado.BackColor = My.Settings.strCorAtualSistema

            'frmCursosHorarios.dgvCursosHorariosManha.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmCursosHorarios.dgvCursosHorariosTarde.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmCursosHorarios.dgvCursosHorariosNoite.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            '' frmControleCursosAlunos.dgvCursosAlunos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmCadastroCursos.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema
            'frmCadastroCursos.dgvRelacaoCursos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            ''
            'frmCadastroPeriodicidade.txtPeriodo.BackColor = My.Settings.strCorAtualSistema
            'frmCadastroPeriodicidade.dgvPeriodo.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema



            'frmCadastroPeriodicidade.txtPeriodo.BackColor = My.Settings.strCorAtualSistema
            'frmCadastroPeriodicidade.dgvPeriodo.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmExcluiMatricula.txtCodigoAluno.BackColor = My.Settings.strCorAtualSistema
            'frmExcluiMatricula.txtCodigoCurso.BackColor = My.Settings.strCorAtualSistema
            'frmExcluiMatricula.txtNomeAluno.BackColor = My.Settings.strCorAtualSistema
            'frmExcluiMatricula.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema
            'frmExcluiMatricula.dgvMensalidades.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmListaAlunos.btnRelatorio.BackColor = My.Settings.strCorAtualSistema
            'frmListaAlunos.btnConfirmar.BackColor = My.Settings.strCorAtualSistema
            'frmListaAlunos.dgvRelacaoAlunos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmMudarImagemPerfil.painelImagemUsuario.BackColor = My.Settings.strCorAtualSistema
            'frmMudarImagemPerfil.btnProcurar.BackColor = My.Settings.strCorAtualSistema
            'frmMudarImagemPerfil.btnRemoverImagem.BackColor = My.Settings.strCorAtualSistema
            'frmMudarImagemPerfil.btnSalvar.BackColor = My.Settings.strCorAtualSistema

            'frmListaAlunos.dgvRelacaoAlunos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmListaAlunos.btnConfirmar.BackColor = My.Settings.strCorAtualSistema
            'frmListaAlunos.btnRelatorio.BackColor = My.Settings.strCorAtualSistema

            'frmControleCursosPagos.dgvCursosPagos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            frmAguarde.picProcesso.BackColor = My.Settings.strCorAtualSistema

            'frmJanelaSeguranca.Panel.BackColor = My.Settings.strCorAtualSistema
            'frmJanelaSeguranca.btnLogar.BackColor = My.Settings.strCorAtualSistema
            'frmJanelaSeguranca.btnOk.BackColor = My.Settings.strCorAtualSistema



            'frmMudarSenha.txtNomeUsuario.BackColor = My.Settings.strCorAtualSistema
            'frmMudarSenha.txtEmail.BackColor = My.Settings.strCorAtualSistema
            'frmMudarSenha.btnConfirmar.BackColor = My.Settings.strCorAtualSistema
            'frmMudarSenha.btnFechar.BackColor = My.Settings.strCorAtualSistema
            'frmMudarSenha.txtLoginUsuario.BackColor = My.Settings.strCorAtualSistema

            'frmConfigEmail.btnConfirmar.BackColor = My.Settings.strCorAtualSistema

            'frmRelacaoProfessores.dgvRelacaoProfessores.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmRelacaoProfessores.dgvRelacaoProfessores.Columns("btnVizualizar").DefaultCellStyle.BackColor = My.Settings.strCorAtualSistema

            'frmRelacaoAlunos.dgvRelacaoAlunos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmRelacaoAlunos.dgvRelacaoAlunos.Columns("btnVizualizar").DefaultCellStyle.BackColor = My.Settings.strCorAtualSistema

            'frmCadastroAlunos.btnVizualizarRelacaoAlunos.BackColor = My.Settings.strCorAtualSistema
            frmCadastroAlunos.txtNomeAluno.BackColor = My.Settings.strCorAtualSistema
            frmCadastroAlunos.btnProximo.BackColor = My.Settings.strCorAtualSistema
            'frmCadastroAlunos.btnProximoPage.BackColor = My.Settings.strCorAtualSistema
            frmCadastroAlunos.btnVoltar.BackColor = My.Settings.strCorAtualSistema

            'frmUsuarios.dgvUsuarios.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmUsuarios.btnProcurar.BackColor = My.Settings.strCorAtualSistema

            frmControleMensalidades.dgvMensalidades.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            frmControleMensalidades.btnExportarExcel.BackColor = My.Settings.strCorAtualSistema
            frmControleMensalidades.txtNome.BackColor = My.Settings.strCorAtualSistema

            frmGeraMensalidade.txtNomeAlunos.BackColor = My.Settings.strCorAtualSistema
            frmGeraMensalidade.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema
            frmGeraMensalidade.btnGerarParcelas.BackColor = My.Settings.strCorAtualSistema
            frmGeraMensalidade.btnEncerrar.BackColor = My.Settings.strCorAtualSistema

            frmAlterarMensalidade.txtCodigoMensalidade.BackColor = My.Settings.strCorAtualSistema
            frmAlterarMensalidade.txtNomeCliente.BackColor = My.Settings.strCorAtualSistema
            frmAlterarMensalidade.btnAlterar.BackColor = My.Settings.strCorAtualSistema
            frmAlterarMensalidade.btnEncerrar.BackColor = My.Settings.strCorAtualSistema
            frmAlterarMensalidade.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema
            frmAlterarMensalidade.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema

            'frmExcluirMensalidade.txtCodigoMensalidade.BackColor = My.Settings.strCorAtualSistema
            'frmExcluirMensalidade.txtNomeAluno.BackColor = My.Settings.strCorAtualSistema
            'frmExcluirMensalidade.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema
            'frmExcluirMensalidade.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema
            'frmExcluirMensalidade.btnExcluir.BackColor = My.Settings.strCorAtualSistema
            'frmExcluirMensalidade.btnEncerrar.BackColor = My.Settings.strCorAtualSistema

            'frmPagamentoMensalidade.txtCodigoMensalidade.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.txtNomeAluno.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.btnEmDia.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.btnCalcular.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.btnPagar.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.btnEncerrar.BackColor = My.Settings.strCorAtualSistema


        End If

        If My.Settings.intVerificaCorAtual = 1 Then

            ' frmControleCaixa.dgvResumo.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            frmRelacaoCompletaHorarios.dgvRelacaoCursosHorarios.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            frmRelacaoCompletaHorarios.dgvRelacaoCursosHorariosProfessores.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmCadastroCursosHorarios.btnConfirmar.BackColor = My.Settings.strCorAtualSistema
            'frmCadastroCursosHorarios.btnCancelar.BackColor = My.Settings.strCorAtualSistema

            'frmCadastroProfessores.txtProfessor.BackColor = My.Settings.strCorAtualSistema
            'frmCadastroProfessores.btnVizualizarRelacaoAlunos.BackColor = My.Settings.strCorAtualSistema

            'frmControleMatricula.dgvCursosAlunos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmAniversariantes.dgvAniversariantes.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmControleBancario.dgvControleBancario.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmControleGastos.dgvControleGastos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            frmControleGastos.txtUsuarioLogado.BackColor = My.Settings.strCorAtualSistema

            'frmCursosHorarios.dgvCursosHorariosManha.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmCursosHorarios.dgvCursosHorariosTarde.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmCursosHorarios.dgvCursosHorariosNoite.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmControleCursosAlunos.dgvCursosAlunos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmCadastroCursos.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema
            'frmCadastroCursos.dgvRelacaoCursos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmCadastroPeriodicidade.txtPeriodo.BackColor = My.Settings.strCorAtualSistema
            'frmCadastroPeriodicidade.dgvPeriodo.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema



            'frmCadastroPeriodicidade.txtPeriodo.BackColor = My.Settings.strCorAtualSistema
            'frmCadastroPeriodicidade.dgvPeriodo.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmExcluiMatricula.txtCodigoAluno.BackColor = My.Settings.strCorAtualSistema
            'frmExcluiMatricula.txtCodigoCurso.BackColor = My.Settings.strCorAtualSistema
            'frmExcluiMatricula.txtNomeAluno.BackColor = My.Settings.strCorAtualSistema
            'frmExcluiMatricula.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema

            'frmExcluiMatricula.dgvMensalidades.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmListaAlunos.btnRelatorio.BackColor = My.Settings.strCorAtualSistema
            'frmListaAlunos.btnConfirmar.BackColor = My.Settings.strCorAtualSistema
            'frmListaAlunos.dgvRelacaoAlunos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            'frmMudarImagemPerfil.painelImagemUsuario.BackColor = My.Settings.strCorAtualSistema
            'frmMudarImagemPerfil.btnProcurar.BackColor = My.Settings.strCorAtualSistema
            'frmMudarImagemPerfil.btnRemoverImagem.BackColor = My.Settings.strCorAtualSistema
            'frmMudarImagemPerfil.btnSalvar.BackColor = My.Settings.strCorAtualSistema

            'frmListaAlunos.dgvRelacaoAlunos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmListaAlunos.btnConfirmar.BackColor = My.Settings.strCorAtualSistema
            'frmListaAlunos.btnRelatorio.BackColor = My.Settings.strCorAtualSistema

            'frmControleCursosPagos.dgvCursosPagos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema

            frmAguarde.picProcesso.BackColor = My.Settings.strCorAtualSistema



            'frmMudarSenha.txtNomeUsuario.BackColor = My.Settings.strCorAtualSistema
            'frmMudarSenha.txtEmail.BackColor = My.Settings.strCorAtualSistema
            'frmMudarSenha.btnConfirmar.BackColor = My.Settings.strCorAtualSistema
            'frmMudarSenha.btnFechar.BackColor = My.Settings.strCorAtualSistema
            'frmMudarSenha.txtLoginUsuario.BackColor = My.Settings.strCorAtualSistema

            'frmConfigEmail.btnConfirmar.BackColor = My.Settings.strCorAtualSistema

            'frmRelacaoProfessores.dgvRelacaoProfessores.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmRelacaoProfessores.dgvRelacaoProfessores.Columns("btnVizualizar").DefaultCellStyle.BackColor = My.Settings.strCorAtualSistema

            'frmRelacaoAlunos.dgvRelacaoAlunos.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmRelacaoAlunos.dgvRelacaoAlunos.Columns("btnVizualizar").DefaultCellStyle.BackColor = My.Settings.strCorAtualSistema

            'frmCadastroAlunos.btnVizualizarRelacaoAlunos.BackColor = My.Settings.strCorAtualSistema
            frmCadastroAlunos.txtNomeAluno.BackColor = My.Settings.strCorAtualSistema
            frmCadastroAlunos.btnProximo.BackColor = My.Settings.strCorAtualSistema
            'frmCadastroAlunos.btnProximoPage.BackColor = My.Settings.strCorAtualSistema
            frmCadastroAlunos.btnVoltar.BackColor = My.Settings.strCorAtualSistema

            'frmUsuarios.dgvUsuarios.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            'frmUsuarios.btnProcurar.BackColor = My.Settings.strCorAtualSistema

            frmControleMensalidades.dgvMensalidades.RowsDefaultCellStyle.SelectionBackColor = My.Settings.strCorAtualSistema
            frmControleMensalidades.btnExportarExcel.BackColor = My.Settings.strCorAtualSistema
            frmControleMensalidades.txtNome.BackColor = My.Settings.strCorAtualSistema

            frmGeraMensalidade.txtNomeAlunos.BackColor = My.Settings.strCorAtualSistema
            frmGeraMensalidade.txtNomeCurso.BackColor = My.Settings.strCorAtualSistema
            frmGeraMensalidade.btnGerarParcelas.BackColor = My.Settings.strCorAtualSistema
            frmGeraMensalidade.btnEncerrar.BackColor = My.Settings.strCorAtualSistema

            frmAlterarMensalidade.txtCodigoMensalidade.BackColor = My.Settings.strCorAtualSistema
            frmAlterarMensalidade.txtNomeCliente.BackColor = My.Settings.strCorAtualSistema
            frmAlterarMensalidade.btnAlterar.BackColor = My.Settings.strCorAtualSistema
            frmAlterarMensalidade.btnEncerrar.BackColor = My.Settings.strCorAtualSistema

            'frmExcluirMensalidade.txtCodigoMensalidade.BackColor = My.Settings.strCorAtualSistema
            'frmExcluirMensalidade.txtNomeAluno.BackColor = My.Settings.strCorAtualSistema
            'frmExcluirMensalidade.btnExcluir.BackColor = My.Settings.strCorAtualSistema
            'frmExcluirMensalidade.btnEncerrar.BackColor = My.Settings.strCorAtualSistema

            'frmPagamentoMensalidade.txtCodigoMensalidade.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.txtNomeAluno.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.btnEmDia.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.btnCalcular.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.btnPagar.BackColor = My.Settings.strCorAtualSistema
            'frmPagamentoMensalidade.btnEncerrar.BackColor = My.Settings.strCorAtualSistema


        End If
    End Sub


End Module
