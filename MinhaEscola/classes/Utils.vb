Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography

Public Class Utils
    Public dadosArray() As String = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44",
                                   "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88",
                                   "999.999.999-99"}

    Public Shared Sub TextBoxMoeda(ByRef txt As TextBox)
        Dim n As String = ""
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(",", "").Replace(".", "")

            If n.Equals("") Then n = "000"
            n = n.PadLeft(3, "0")

            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)

            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Function FValidaEmail(ByVal email As String) As Boolean

        ' Pattern ou mascara de verificação
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"

        ' Verifica se o email corresponde a pattern/mascara
        Dim emailAddressMatch As Match = Regex.Match(email, pattern)

        ' Caso corresponda
        If emailAddressMatch.Success Then
            Return True
        Else
            MsgBox("E-mail informado não é válido. Verifique se digitou corretamente.",
               MsgBoxStyle.Information, "CS .Net Tecnologia")
            Return False
        End If
    End Function

    Public Function FValidaCPF(ByVal CPF As String) As Boolean
        Dim i, x, n1, n2 As Integer
        CPF = CPF.Trim
        For i = 0 To dadosArray.Length - 1
            If CPF.Length <> 14 Or dadosArray(i).Equals(CPF) Then
                Return False
            End If
        Next
        'remove a maskara
        CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)
        For x = 0 To 1
            n1 = 0
            For i = 0 To 8 + x
                n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
            Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If n2 = 10 Or n2 = 11 Then n2 = 0
            If n2 <> Val(CPF.Substring(9 + x, 1)) Then
                MsgBox("O CPF informado não é válido. Verifique se digitou corretamente.",
                       MsgBoxStyle.Information, "CS .Net Tecnologia")
                Return False
            End If
        Next
        Return True
    End Function
End Class
