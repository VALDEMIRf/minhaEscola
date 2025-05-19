Imports System.Data.SqlClient
Imports System.Text

Public Class clsMenuDinamico
    'Collection utilizada para armazenar os itens de menu
    Private arlMenus As New ArrayList

    Public Sub AdicionarItem(ByVal pPai As Object, ByVal pMenuCaption As String, ByVal pMenuObjeto As String, Optional ByRef pEventHandler As Object = Nothing)
        'Um novo item é criado com o caption informado 
        Dim mniMenuItem As New MenuItem(pMenuCaption)

        'Se for um item principal (MainMenu), incluir um
        'item principal (nível zero)
        If TypeOf pPai Is MainMenu Then
            'Se o item já existir, dispara exception
            If Not RetornaMenu(pMenuCaption) Is Nothing Then
                Throw New Exception("Item de menu (" & pMenuCaption & ") já existe")
            End If
            'Adiciona o item criado à instância de MainMenu 
            '(recebido como parâmetro)
            pPai.MenuItems.Add(mniMenuItem)
        Else
            RetornaMenu(pPai).MenuItems.Add(mniMenuItem)
        End If

        'Adiciona o item à collection
        arlMenus.Add(mniMenuItem)

        objMenus.Add(pMenuCaption)
        objMenus.Add(pMenuObjeto)

        'Adiciona Handler para o evento Click (apenas se informado)
        If Not pEventHandler Is Nothing Then
            AddHandler mniMenuItem.Click, pEventHandler
        End If
    End Sub

    Public Function RetornaMenu(ByVal pCaption As String) As MenuItem
        Dim arlTemp As MenuItem

        For Each arlTemp In arlMenus
            'Verifica se é o item informado
            If arlTemp.Text = pCaption Then
                'Se for, retorna o item do menu
                Return arlTemp
            End If
        Next
        Return Nothing
    End Function

    Public Sub MontaMenu(ByVal pGrupo As Integer, ByRef pMenuPrincipal As MainMenu, ByRef pconMysql As SqlConnection, ByVal pEventHandler As EventHandler)

        'Dim olecmdCommand As OleDbCommand
        Dim mysqlcmdComand As SqlCommand
        Dim olerdrReader As SqlDataReader
        'Dim olerdrReader As OleDbDataReader
        Dim strQuery As New StringBuilder

        'Apaga o conteúdo da collection atual o menu existente
        arlMenus.Clear()
        objMenus.Clear()
        pMenuPrincipal.MenuItems.Clear()

        'Pesquisa todos os itens para o grupo informado
        Try
            With strQuery
                .Append("SELECT a.colunaid, a.ParentID, a.Nivel, a.Descricao, a.objeto, ")
                .Append("(select descricao from Menu where menuid = a.parentid ) ")
                .Append("as ParentDescricao, a.objeto as Objeto ")
                .Append("FROM Menu AS a, Grupo AS b, MenuGrupo AS c ")
                .Append("WHERE a.MenuID=c.menuid and ")
                .Append("b.GrupoID=c.grupoid and ")
                .Append("b.GrupoID = " & pGrupo & " ")
                .Append("ORDER BY a.colunaid, a.ParentID, a.Nivel, a.SubOrdem;")
            End With

            Dim teste As String = strQuery.ToString.ToLower

            'pconDB.Open()


            If pconMysql.State <> ConnectionState.Open Then
                pconMysql.Open()
            End If

            mysqlcmdComand = New SqlCommand(strQuery.ToString().ToLower, pconMysql)
            olerdrReader = mysqlcmdComand.ExecuteReader()


            'Para cada item retornado, adicionar item no menu.
            While olerdrReader.Read()
                'Se item nível zero (Arquivo, Editar, Help, 
                'etc), primeiro parâmetro é o MainMenu
                If olerdrReader.Item("Nivel") = 0 Then
                    AdicionarItem(pMenuPrincipal, olerdrReader.Item("Descricao"), IIf(IsDBNull(olerdrReader.Item("Objeto")), "", olerdrReader.Item("Objeto")))
                Else
                    'Se sub-item, primeiro parâmetro é o caption 
                    'do Item nível zero, isto é, pai do sub-item
                    AdicionarItem(olerdrReader.Item("ParentDescricao"),
                           olerdrReader.Item("Descricao"), olerdrReader.Item("Objeto"), pEventHandler)
                End If
            End While
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao montar os menus: " & ex.Message.ToString, "Menu Dinamico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'pconDB.Close()
    End Sub


End Class
