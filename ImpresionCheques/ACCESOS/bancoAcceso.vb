

Public Class bancoAcceso



Public Function insertar (ByVal entidad  As banco) As Integer

	Try

		With entidad

			Return ExecuteIdentity("INSERT INTO banco (nombre) VALUES (""" & .nombre & """)")

		End With

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function eliminacion_fisica(ByVal id As Integer) As Boolean

        Try

            Return ExecuteNonQuery("DELETE FROM banco WHERE id_banco=" & id)

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function eliminacion_logica(ByVal id As Integer) As Boolean

        Try

            Return ExecuteNonQuery("UPDATE banco SET eliminado=True WHERE id_banco=" & id)

        Catch ex As Exception

            Throw

        End Try

End Function






Public Function actualizar(ByVal entidad As banco) As Boolean

	Try

		With entidad

			Return ExecuteNonQuery("UPDATE banco SET nombre=""" & .nombre & """ WHERE id_banco=" & .id_banco)

		End With

	Catch ex As Exception

		Throw

	End Try

End Function






Public Function recuperar() As List(Of banco)

	Try

		Dim lista As New List(Of banco)

		getCollection("SELECT * FROM banco", lista)

		Return lista

	Catch ex As Exception

		Throw

	End Try

End Function






Public Function recuperar(ByVal id_banco As object) As banco

	Try

		Dim nuevo As New banco

		getObject("SELECT * FROM banco WHERE id_banco=" & id_banco, nuevo)

		Return nuevo

	Catch ex As Exception

		Throw

	End Try

End Function




End Class