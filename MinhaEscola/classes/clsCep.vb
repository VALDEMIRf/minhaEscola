Imports System.Net
Imports Newtonsoft.Json

Public Class clsCep
    Property logradouro As String
    Property complemento As String
    Property bairro As String
    Property localidade As String
    Property uf As String
    Property cep As String
    Property ibge As String
    Property gia As String
    Property ddd As String
    Property siafi As String

    Public Shared Function ObterCep(csCep As String) As clsCep

        'Dim url = "https://www.receitaws.com.br/v1/cnpj/" + csCep
        Dim url = "https://viacep.com.br/ws/" + csCep + "/json/"
        Dim json = New WebClient().DownloadString(url)

        Dim cep = JsonConvert.DeserializeObject(Of clsCep)(json)

        Return cep

    End Function

End Class
