

Public Class cuentaAcceso



Public Function insertar (ByVal entidad  As cuenta) As Integer

	Try

		With entidad

			Return ExecuteIdentity("INSERT INTO cuenta (id_banco, numero, observaciones) VALUES (" & .id_banco & ",""" & .numero & """,""" & .observaciones & """)")

		End With

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function eliminacion_fisica(ByVal id As Integer) As Boolean

        Try

            Return ExecuteNonQuery("DELETE FROM cuenta WHERE id_cuenta=" & id)

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function eliminacion_logica(ByVal id As Integer) As Boolean

        Try

            Return ExecuteNonQuery("UPDATE cuenta SET eliminado=True WHERE id_cuenta=" & id)

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function actualizar(ByVal entidad As cuenta) As Boolean

	Try

		With entidad

			Return ExecuteNonQuery("UPDATE cuenta SET id_banco=" & .id_banco & ", numero=""" & .numero & """, observaciones=""" & .observaciones & """ WHERE id_cuenta=" & .id_cuenta)

		End With

	Catch ex As Exception

		Throw

	End Try

End Function






Public Function recuperar() As List(Of cuenta)

	Try

		Dim lista As New List(Of cuenta)

		getCollection("SELECT * FROM cuenta", lista)

		Return lista

	Catch ex As Exception

		Throw

	End Try

End Function






Public Function recuperar(ByVal id_cuenta As object) As cuenta

	Try

		Dim nuevo As New cuenta

		getObject("SELECT * FROM cuenta WHERE id_cuenta=" & id_cuenta, nuevo)

		Return nuevo

	Catch ex As Exception

		Throw

	End Try

End Function




End Class