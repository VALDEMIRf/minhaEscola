Public Class clsUsuario
    Private strNome As String
    Private shtGrupo As Short
    Public Property Nome()
        Get
            Return strNome
        End Get
        Set(ByVal Value)
            strNome = Value
        End Set
    End Property

    Public Property Grupo()
        Get
            Return shtGrupo
        End Get
        Set(ByVal Value)
            shtGrupo = Value
        End Set
    End Property

End Class
