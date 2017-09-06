Public Class CONFIGURACION

    Dim _nombre As String
    Dim _valor As String
    Dim _origen As String

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property valor As String
        Get
            Return _valor
        End Get
        Set(value As String)
            _valor = value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns>Puede ser "INI" o "BASE", según la config provenga del archivo .INI o de la base de datos.</returns>
    Public Property origen As String
        Get
            Return _origen
        End Get
        Set(value As String)
            _origen = value
        End Set
    End Property

End Class
