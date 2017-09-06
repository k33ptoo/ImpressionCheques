Public Class configuracionAcceso

    Public Function recuperar(ByVal nombre As String) As CONFIGURACION
        Try
            Dim nuevo As New CONFIGURACION
            getObject("select *, ""BASE"" as origen from CONFIGURACIONES where nombre=""" & nombre & """", nuevo)
            Return nuevo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function existe(ByVal nombre As String) As Boolean
        Try
            Return ExecuteScalar("select iif(count(*) = 1, True, False) from CONFIGURACIONES where nombre=""" & nombre & """")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function recuperar() As List(Of CONFIGURACION)
        Try
            Dim lista As New List(Of CONFIGURACION)
            getCollection("select nombre, valor as valor,""BASE"" as origen from CONFIGURACIONES", lista)
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function insertar(ByVal entidad As CONFIGURACION) As String
        Try
            Return ExecuteIdentity("insert into CONFIGURACIONES (nombre, valor) values (""" & entidad.nombre.Trim.ToLower & """,""" & entidad.valor & """)")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function actualizar(ByVal entidad As CONFIGURACION) As Boolean
        Try
            Return ExecuteNonQuery("UPDATE CONFIGURACIONES SET valor=""" & entidad.valor & """ WHERE nombre=""" & entidad.nombre.Trim.ToLower & """")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function eliminar(ByVal nombre As String) As Boolean
        Try
            Return ExecuteNonQuery("delete from CONFIGURACIONES where nombre=" & nombre)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
