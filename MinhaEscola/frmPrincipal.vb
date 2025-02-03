Imports System.Data.SqlClient

Public Class frmPrincipal

    Inherits System.Windows.Forms.Form
    'Instância do objeto onde o menu será montado 
    Private mmnMenuPrincipal As New MainMenu
    'Instância da classe que manipula os menus
    Private mndMenuD As New clsMenuDinamico
    'Instância da classe que armazena o usuário
    Private usrUsuario = New clsUsuario
    'Instância do objeto de conexão
    Private conDB As New SqlConnection

    Private dsform As String = ""
    Private dsform2 As String = ""


    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Atribui atributo ao menu do form
        Me.Menu = mmnMenuPrincipal
        conDB.ConnectionString = "Data Source=DESKTOP-R5VHKNO\SQLEXPRESS;Initial Catalog=DBConectaEscola;Integrated Security=True"

        'Monta o menu default (nenhum usuário autenticado)
        Try
            mndMenuD.MontaMenu(0, mmnMenuPrincipal, conDB,
                       AddressOf EventoMenu_Click)

        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro durante a criação dos menus: " & ex.Message.ToString, "Menu Dinamico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conectar(sender, e)


    End Sub

    Public Sub New()
        MyBase.New()

        InitializeComponent()

    End Sub

    Private Sub frmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                End
        End Select
    End Sub

    Private Sub EventoMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Apresento o item clicado e, após o casting, 
        'obtenho a propriedade Text do objeto
        Select Case CType(sender, MenuItem).Text
            Case "&Conectar"
                Conectar(sender, e)
            Case "&Desconectar"
                'Executa o método MontaMenu p/ o menu Default
                Try
                    ' lblNomeUsuario.Text = ""
                    lblEscola.Text = ""
                    ' usrUsuarioLogin = ""
                    mndMenuD.MontaMenu(0, mmnMenuPrincipal,
                   conDB, AddressOf EventoMenu_Click)
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro durante a criação dos menus: " & ex.Message.ToString,
           "Menu Dinamico", MessageBoxButtons.OK,
           MessageBoxIcon.Error)
                End Try
            Case "Sai&r"
                Me.Close()
            Case Else

                procuraopcao(CType(sender, MenuItem).Text)

        End Select
        'É possível manipular os atributos do menu através
        'do método RetornaMenu (collection)
        'Ex: mndMenuD.RetornaMenu("Form1").Enabled = False
        'Não esqueça do Try...Catch
    End Sub

    Private Sub Conectar(ByVal sender As Object, ByVal e As System.EventArgs)
        'Variável para formulário de login
        Dim frm As frmLogin
        Dim usrUsuarioLogin As New clsUsuario

        'Nova instância do form de login, usando construtor
        'customizado, passando a instância da classe 
        'usuário e instância do objeto conexâo no BD
        frm = New frmLogin(usrUsuarioLogin, conDB)
        'Carregar form no modo modal
        frm.ShowDialog(Me)

        'Se um usuário foi autenticado, montar menu
        If Not usrUsuarioLogin.Nome Is Nothing Then
            mndMenuD.MontaMenu(usrUsuarioLogin.Grupo, mmnMenuPrincipal, con, AddressOf EventoMenu_Click)
            Me.Text = "SISTEMA INTELIGENTE DE CONTRLOLE ESCOLAR        -        Usuário: " & usrUsuarioLogin.Nome & "                                               Logado as: " & Now

            '  lblRecebeNome.Text = empresaNome
            ' lblEscola.Text = empresaNome
            lblVersa.Text = "Versão: " & My.Application.Info.Version.ToString
        End If
    End Sub

    Private Sub procuraopcao(ByVal opcao As String)

        dsform2 = ""
        dsform = opcao

        Dim i As Integer = 0
        Dim x As Integer = objMenus.Count

        For i = 0 To x - 1
            If objMenus.Item(i) = dsform Then
                dsform2 = objMenus.Item(i + 1)
                Exit For
            End If
        Next

        Try
            If ((dsform2 <> "") And (dsform2 <> "x")) Then
                ' CarregaForm(dsform2).Show()  ''' Deixa abrir form um em cima do outro
                Dim f As Form = CarregaForm(dsform2)
                AddHandler f.KeyDown, AddressOf frmPrincipal_KeyDown
                f.ShowDialog() ' Não Deixa abrir form um em cima do outro
            Else
                MessageBox.Show("Item """ & dsform & """ Indisponível.", "Menu Dinâmico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu Um Erro Durante a Carga do Item do Menu: " & ex.Message.ToString, "Menu Dinamico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Function CarregaForm(ByVal FormName As String) As Form
        Dim Fullname As String = Application.ProductName & "." & FormName
        Return Activator.CreateInstance(Type.GetType(Fullname, True, True))

    End Function

    'Private Sub listaMinhaEmpresa()
    '    Dim dr As SqlDataReader = Nothing


    '    Try
    '        abrir()

    '        'strQuery.Append("select u.Nome, u.GrupoID,e.razaoSocial from usuario as u,tbEmpresa as e ")

    '        Dim sql As String = "SELECT razaoSocial FROM tbEmpresa "
    '        Dim cmd As SqlCommand = New SqlCommand(sql, con)
    '        dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

    '        If dr.HasRows Then
    '            dr.Read()

    '            lblEscola.Text = dr.Item("razaoSocial")
    '            ' empresaNome = lblEscola.Text

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    Finally
    '        dr.Close()
    '        fechar()
    '    End Try

    'End Sub


End Class
