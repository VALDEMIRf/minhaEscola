Imports System.Data.SqlClient
Imports System.Text

Public Class frmLogin

    'Instância local da classe que armazena o usuário
    Private usrUsuario = New clsUsuario
    'Instância local do objeto de conexão
    Private conDB As New SqlConnection

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
    End Sub

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Public Sub New(ByRef pUsuario As clsUsuario, ByVal pconBD As System.Data.SqlClient.SqlConnection)
        'Chamo o construtor da classe base para que as 
        'rotinas básicas sejam executadas
        Me.New()
        usrUsuario = pUsuario
        conDB = pconBD
    End Sub

    Private Sub btAcessar_Click(sender As Object, e As EventArgs) Handles btAcessar.Click
        Try
            If UsuarioValido(txtUsuario.Text, txtSenha.Text) Then
                Me.Close()
            Else
                MessageBox.Show("Usuário/senha inválidos.", "Menu Dinamico", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Menu Dinamico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function UsuarioValido(ByVal pstrUsuario As String, ByVal pstrSenha As String) As Boolean
        Dim olecmdCommand As SqlCommand
        Dim olerdrReader As SqlDataReader
        Dim strQuery As New StringBuilder
        Dim bolResult As Boolean

        Try
            'conDB.Open()
            abrir()
            strQuery.Append("select u.Nome, u.GrupoID,e.razaoSocial from usuario as u,tbEmpresa as e ")
            ' strQuery.Append("pa_Login ")

            strQuery.Append("where nome = '" & txtUsuario.Text.ToUpper() & "' ")
            strQuery.Append("and senha = '" & txtSenha.Text.ToUpper() & "' ")

            olecmdCommand = New SqlCommand(strQuery.ToString(), con)

            olecmdCommand = New SqlCommand(strQuery.ToString().ToLower, con)
            olerdrReader = olecmdCommand.ExecuteReader()

            If olerdrReader.Read() Then
                usrUsuario.Nome = olerdrReader.Item("Nome")
                usrUsuario.Grupo = olerdrReader.Item("GrupoID")
                empresaNome = olerdrReader.Item("razaoSocial")
                usuarioNome = olerdrReader.Item("Nome")


                bolResult = True
            End If
        Catch ex As Exception
            Throw New Exception("Ocorreu um erro ao autenticar o usuário: " & ex.Message.ToString)
            bolResult = False
        Finally
            ' conDB.Close()
            fechar()
        End Try

        Return bolResult
    End Function

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Application.Exit()
    End Sub

    Private Sub btAcessar_MouseHover(sender As Object, e As EventArgs) Handles btAcessar.MouseHover
        'btAcessar.BackColor = Color.White
        '  btAcessar.ForeColor = Color.DarkTurquoise
    End Sub

    Private Sub btAcessar_MouseLeave(sender As Object, e As EventArgs) Handles btAcessar.MouseLeave
        ' btAcessar.BackColor = Color.DarkTurquoise
        ' btAcessar.ForeColor = Color.White
    End Sub

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

    '            empresaNome = dr.Item("razaoSocial")


    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    Finally
    '        dr.Close()
    '        fechar()
    '    End Try

    'End Sub

End Class