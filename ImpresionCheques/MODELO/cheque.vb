



Public Class cheque

	Dim _Cruzado As Boolean
Dim _Fecha_Emision As Date
Dim _Fecha_Vencimiento As Date
Dim _Id_cheque As Integer
Dim _Id_cuenta As Integer
Dim _Id_proveedor As Integer
Dim _Importe As Single
Dim _No_a_la_orden As Boolean
Dim _Numero As String

	Public Property Cruzado As Boolean
Get
Return _Cruzado
End Get
Set(value As Boolean)
_Cruzado = value
End Set
End Property
Public Property Fecha_Emision As Date
Get
Return _Fecha_Emision
End Get
Set(value As Date)
_Fecha_Emision = value
End Set
End Property
Public Property Fecha_Vencimiento As Date
Get
Return _Fecha_Vencimiento
End Get
Set(value As Date)
_Fecha_Vencimiento = value
End Set
End Property
Public Property Id_cheque As Integer
Get
Return _Id_cheque
End Get
Set(value As Integer)
_Id_cheque = value
End Set
End Property
Public Property Id_cuenta As Integer
Get
Return _Id_cuenta
End Get
Set(value As Integer)
_Id_cuenta = value
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
Public Property Importe As Single
Get
Return _Importe
End Get
Set(value As Single)
_Importe = value
End Set
End Property
Public Property No_a_la_orden As Boolean
Get
Return _No_a_la_orden
End Get
Set(value As Boolean)
_No_a_la_orden = value
End Set
End Property
Public Property Numero As String
Get
Return _Numero
End Get
Set(value As String)
_Numero = value
End Set
End Property

End Class




