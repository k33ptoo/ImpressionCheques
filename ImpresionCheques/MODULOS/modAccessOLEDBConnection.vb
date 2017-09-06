'-----------------------------------------------------------------------------------------
'
'           ACCESS OLEDB CONNECTION MODULE
'           by Marcelo L. Ponce F.
'           version: 2017.05.25 19:00
'
'-----------------------------------------------------------------------------------------

Imports System.Data.OleDb
Imports System.Reflection

Module modAccessOLEDBConnection

    Public db_path_data_base As String
    Public db_connection_string As String
    Public db_connection As New OleDbConnection
    Public db_command As New OleDbCommand
    Public db_reader As OleDbDataReader
    Public Const dbPass As String = "kuEnm763"
    Dim keyWords() As String = Split("xp_ ;update;insert;select;drop;alter;create;rename;delete;replace;sp_", ";")

    Public Function detectSqlKeyWord(ByVal sql As String) As Boolean
        Try
            If keyWords.Any(Function(b) sql.ToLower().Contains(b.ToLower())) Then
                Throw New Exception("Se detecto una posible inyección SQL.")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function startConnection() As Boolean
        Try
            db_path_data_base &= "\db_be.accdb"
            If IO.File.Exists(db_path_data_base) = False Then
                db_path_data_base = Application.StartupPath & "\db_be.accdb"
            End If
            If IO.File.Exists(db_path_data_base) Then
                db_connection_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & db_path_data_base & ";Persist Security Info=False; OLE DB Services=-1; Jet OLEDB:Database Password=" & dbPass
            Else
                Return False
            End If
            db_connection.ConnectionString = db_connection_string
            db_command.Connection = db_connection

            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ExecuteNonQuery(ByVal sql As String) As Boolean
        Try
            db_command.CommandText = sql
            If db_connection.State = ConnectionState.Closed Then
                db_connection.Open()
            End If
            db_command.ExecuteNonQuery()
        Catch ex As Exception
            Throw
        Finally
            db_connection.Close()
        End Try
        Return True
    End Function

    Public Function ExecuteIdentity(ByVal sql As String) As Integer
        Dim resultado As Object
        Try
            db_command.CommandText = sql
            If db_connection.State = ConnectionState.Closed Then
                db_connection.Open()
            End If
            db_command.ExecuteNonQuery()
            db_command.CommandText = "Select @@Identity"
            resultado = db_command.ExecuteScalar
        Catch ex As Exception
            Throw
        Finally
            db_connection.Close()
        End Try
        Return resultado
    End Function

    Public Function ExecuteScalar(ByVal sql As String) As String
        Dim resultado As Object
        Try
            If db_connection.State = ConnectionState.Closed Then
                db_connection.Open()
            End If
            db_command.CommandText = sql
            resultado = db_command.ExecuteScalar
        Catch ex As Exception
            Throw
        Finally
            db_connection.Close()
        End Try
        If IsDBNull(resultado) Then
            Return -1
        Else
            Return resultado
        End If
    End Function

    Public Function ExecuteReader(ByVal sql As String) As Boolean
        Try
            db_command.CommandText = sql
            If db_connection.State = ConnectionState.Closed Then
                db_connection.Open()
            End If
            db_command.ExecuteReader()
        Catch ex As Exception
            Throw
        Finally
            db_reader.Close()
            db_connection.Close()
        End Try
        Return True
    End Function

    Public Function GetNewID(ByVal table As String, ByVal field As String) As Integer
        Try
            Dim tabla() As String = table.Split(".")
            Dim last As Integer
            If tabla.Count = 2 Then
                last = ExecuteScalar("SELECT max(" & field.Trim() & ") FROM " & tabla(1))
            Else
                last = ExecuteScalar("SELECT max(" & field.Trim() & ") FROM " & table)
            End If
            Return last + 1
        Catch ex As Exception
            Return 1
        End Try
    End Function

    Private Sub OleDbCast(ByRef db_reader As OleDb.OleDbDataReader,
                          ByRef entidad_actual As Object,
                          Optional cboolCompatibility As Boolean = False,
                          Optional stringToboolean As Boolean = False)
        Try
            Dim columns_count = db_reader.FieldCount
            For i As Integer = 0 To columns_count
                Dim T As Type = entidad_actual.GetType()
                Try
                    For Each prop As PropertyInfo In T.GetProperties
                        Dim Ty As String = db_reader.Item(prop.Name).GetType.ToString
                        Select Case Ty
                            Case "System.DateTime" : prop.SetValue(entidad_actual, DateTime.Parse(db_reader.Item(prop.Name)), Nothing)
                            Case "System.String"
                                If (db_reader.Item(prop.Name) = "False" Or db_reader.Item(prop.Name) = "True") And stringToboolean = True Then
                                    prop.SetValue(entidad_actual, Boolean.Parse(db_reader.Item(prop.Name)), Nothing)
                                Else
                                    prop.SetValue(entidad_actual, db_reader.Item(prop.Name), Nothing)
                                End If
                            Case "System.Int16"
                                If cboolCompatibility = True Then
                                    prop.SetValue(entidad_actual, Convert.ToBoolean(db_reader.Item(prop.Name)), Nothing)
                                Else
                                    prop.SetValue(entidad_actual, Int16.Parse(db_reader.Item(prop.Name)), Nothing)
                                End If
                            Case "System.Int32" : prop.SetValue(entidad_actual, Integer.Parse(db_reader.Item(prop.Name)), Nothing)
                            Case "System.Single" : prop.SetValue(entidad_actual, Single.Parse(db_reader.Item(prop.Name)), Nothing)
                            Case "System.Boolean" : prop.SetValue(entidad_actual, Boolean.Parse(db_reader.Item(prop.Name)), Nothing)
                            Case "System.DBNull" : prop.SetValue(entidad_actual, Nothing, Nothing)
                        End Select
                    Next
                Catch ex As Exception
                    Throw New Exception("Agregar el campo """ & ex.Message & """ en la tabla " & T.Name.ToUpper, ex)
                End Try
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function isEngineException(ByVal msg As String) As Boolean
        Try
            If msg = "El proveedor 'Microsoft.ACE.OLEDB.12.0' no está registrado en el equipo local." Then
                MsgBox(msg)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub getCollection(ByRef sql As String, ByRef current_list As Object, Optional cboolCompatibility As Boolean = False)
        Try
            Dim objectType = current_list.GetType.GetGenericArguments(0)
            Dim newObject As Object
            db_command.CommandText = sql
            Try
                If db_connection.State = ConnectionState.Closed Then
                    db_connection.Open()
                End If
                db_reader = db_command.ExecuteReader(CommandBehavior.CloseConnection)
                While (db_reader.Read)
                    newObject = Activator.CreateInstance(objectType)
                    OleDbCast(db_reader, newObject, cboolCompatibility)
                    current_list.Add(newObject)
                End While
            Catch ex As Exception
                If isEngineException(ex.Message) = False Then
                    Throw
                Else
                    Exit Sub
                End If
            Finally
                If IsNothing(db_reader) = False Then
                    db_reader.Close()
                    db_connection.Close()
                End If
            End Try
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function getCollectionGeneric(ByVal sql As String) As DataTable
        Try
            Dim ds As New DataSet
            If db_connection.State = ConnectionState.Closed Then
                db_connection.Open()
            End If
            Dim oledbAdapter As New OleDbDataAdapter(sql, db_connection)
            oledbAdapter.Fill(ds)
            oledbAdapter.Dispose()
            db_connection.Close()
            Return ds.Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function getObject(ByRef sql As String, ByRef new_object As Object) As Object
        Try
            db_command.CommandText = sql
            Try
                If db_connection.State = ConnectionState.Closed Then
                    db_connection.Open()
                End If
                db_reader = db_command.ExecuteReader(CommandBehavior.CloseConnection)
                While (db_reader.Read)
                    OleDbCast(db_reader, new_object)
                End While
                Return new_object
            Catch ex As Exception
                Throw
            Finally
                db_reader.Close()
                db_connection.Close()
            End Try
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function convertToAccessDateTime(ByVal dateTime As DateTime) As String
        Try
            Dim initial_date As String
            Dim ampm As String = ""
            Dim s As String
            Dim hour As String = ""
            initial_date =
            Format(dateTime.Month, "00") & "/" &
            Format(dateTime.Day, "00") & "/" &
            Format(dateTime.Year, "0000")
            s = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern
            Try
                If s <> "H:mm" Then
                    ampm = Format(dateTime, "tt")
                    ampm = ampm.Remove(1, 1)
                    ampm = ampm.Remove(2, 1).ToUpper()
                End If
                If s = "H:mm" Then
                    If dateTime.Hour >= 12 Then
                        ampm = " PM"
                    Else
                        ampm = " AM"
                    End If
                End If
                hour = Format(dateTime, "hh:mm:ss")
            Catch ex As Exception
                Throw
            End Try
            initial_date = initial_date & " " & hour & ampm
            Return initial_date
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module
