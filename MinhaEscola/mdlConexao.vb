Imports System.Data.SqlClient
Imports System.Text

Module mdlConexao

    Public usuarioNome As String
    Public objMenus As New ArrayList
    Public empresaNome As String

    Public intCodigoCursoHorario As Integer
    Public intCodigoCursoHorarioExcluir As Integer
    Public intPergunta As Integer
    Public intCodigoLancamento As Integer = 0

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


    Public con As New SqlConnection("Data Source=DESKTOP-R5VHKNO\SQLEXPRESS;Initial Catalog=DBConectaEscola;Integrated Security=True")

    Sub abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub

    Sub fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub


    Public Function UTF8_to_ISO(texto As String) As String
        'Dim isoEncoding = Encoding.GetEncoding("ISO-8859-8")
        Dim isoEncoding = Encoding.GetEncoding("Windows-1252")
        Dim utfEncoding = Encoding.UTF8

        Dim bytesIso As Byte() = utfEncoding.GetBytes(texto)
        Dim bytesUtf As Byte() = Encoding.Convert(utfEncoding, isoEncoding, bytesIso)

        Dim textoISO = utfEncoding.GetString(bytesUtf)

        UTF8_to_ISO = textoISO
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

    '            empresaNome = dr.Item("razaoSocial")


    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    Finally
    '        dr.Close()
    '        fechar()
    '    End Try

    'End Sub
End Module
