



Public Class proveedor

	Dim _Cuit As String
Dim _Id_proveedor As Integer
Dim _razon_social As String

	Public Property Cuit As String
Get
Return _Cuit
End Get
Set(value As String)
_Cuit = value
End Set
End Property
Public Property Id_proveedor As Integer
Get
Return _Id_proveedor
End Get
Set(value As Integer)
_Id_proveedor = value
End Set
End Property
Public Property razon_social As String
Get
Return _razon_social
End Get
Set(value As String)
_razon_social = value
End Set
End Property

End Class




