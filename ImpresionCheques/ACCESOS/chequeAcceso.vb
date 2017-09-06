

Public Class chequeAcceso



Public Function insertar (ByVal entidad  As cheque) As Integer

	Try

		With entidad

			Return ExecuteIdentity("INSERT INTO cheque (Cruzado, Fecha_Emision, Fecha_Vencimiento, Id_cuenta, Id_proveedor, Importe, No_a_la_orden, Numero) VALUES (" & .Cruzado & ",#" & .Fecha_Emision & "#,#" & .Fecha_Vencimiento & "#," & .Id_cuenta & "," & .Id_proveedor & ",'" & .Importe & "'," & .No_a_la_orden & ",""" & .Numero & """)")

		End With

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function eliminacion_fisica(ByVal id As Integer) As Boolean

        Try

            Return ExecuteNonQuery("DELETE FROM cheque WHERE Id_cheque=" & id)

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function eliminacion_logica(ByVal id As Integer) As Boolean

        Try

            Return ExecuteNonQuery("UPDATE cheque SET eliminado=True WHERE Id_cheque=" & id)

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function actualizar(ByVal entidad As cheque) As Boolean

	Try

		With entidad

			Return ExecuteNonQuery("UPDATE cheque SET Cruzado=" & .Cruzado & ", Fecha_Emision=#" & .Fecha_Emision & "#, Fecha_Vencimiento=#" & .Fecha_Vencimiento & "#, Id_cuenta=" & .Id_cuenta & ", Id_proveedor=" & .Id_proveedor & ", Importe='" & .Importe & "', No_a_la_orden=" & .No_a_la_orden & ", Numero=""" & .Numero & """ WHERE Id_cheque=" & .Id_cheque)

		End With

	Catch ex As Exception

		Throw

	End Try

End Function






Public Function recuperar() As List(Of cheque)

	Try

		Dim lista As New List(Of cheque)

		getCollection("SELECT * FROM cheque", lista)

		Return lista

	Catch ex As Exception

		Throw

	End Try

End Function






Public Function recuperar(ByVal Id_cheque As object) As cheque

	Try

		Dim nuevo As New cheque

		getObject("SELECT * FROM cheque WHERE Id_cheque=" & Id_cheque, nuevo)

		Return nuevo

	Catch ex As Exception

		Throw

	End Try

End Function




End Class