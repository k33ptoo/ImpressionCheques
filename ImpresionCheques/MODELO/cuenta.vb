



Public Class cuenta

	Dim _id_banco As Integer
Dim _id_cuenta As Integer
Dim _numero As String
Dim _observaciones As String

	Public Property id_banco As Integer
Get
Return _id_banco
End Get
Set(value As Integer)
_id_banco = value
End Set
End Property
Public Property id_cuenta As Integer
Get
Return _id_cuenta
End Get
Set(value As Integer)
_id_cuenta = value
End Set
End Property
Public Property numero As String
Get
Return _numero
End Get
Set(value As String)
_numero = value
End Set
End Property
Public Property observaciones As String
Get
Return _observaciones
End Get
Set(value As String)
_observaciones = value
End Set
End Property

End Class




