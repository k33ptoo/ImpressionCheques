

Public Class proveedorAcceso



Public Function insertar (ByVal entidad  As proveedor) As Integer

	Try

		With entidad

			Return ExecuteIdentity("INSERT INTO proveedor (Cuit, razon_social) VALUES (""" & .Cuit & """,""" & .razon_social & """)")

		End With

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function eliminacion_fisica(ByVal id As Integer) As Boolean

        Try

            Return ExecuteNonQuery("DELETE FROM proveedor WHERE Id_proveedor=" & id)

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function eliminacion_logica(ByVal id As Integer) As Boolean

        Try

            Return ExecuteNonQuery("UPDATE proveedor SET eliminado=True WHERE Id_proveedor=" & id)

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function actualizar(ByVal entidad As proveedor) As Boolean

	Try

		With entidad

			Return ExecuteNonQuery("UPDATE proveedor SET Cuit=""" & .Cuit & """, razon_social=""" & .razon_social & """ WHERE Id_proveedor=" & .Id_proveedor)

		End With

	Catch ex As Exception

		Throw

	End Try

End Function






Public Function recuperar() As List(Of proveedor)

	Try

		Dim lista As New List(Of proveedor)

		getCollection("SELECT * FROM proveedor", lista)

		Return lista

	Catch ex As Exception

		Throw

	End Try

End Function






Public Function recuperar(ByVal Id_proveedor As object) As proveedor

	Try

		Dim nuevo As New proveedor

		getObject("SELECT * FROM proveedor WHERE Id_proveedor=" & Id_proveedor, nuevo)

		Return nuevo

	Catch ex As Exception

		Throw

	End Try

End Function




End Class