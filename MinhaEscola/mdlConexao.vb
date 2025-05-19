Imports System.Data.SqlClient
Imports System.Text

Module mdlConexao

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

End Module
