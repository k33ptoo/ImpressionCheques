'-----------------------------------------------------------------------------------------
'
'           LOG MANAGER
'           by Marcelo L. Ponce F.
'           version: 2016.01.03 10:30
'
'-----------------------------------------------------------------------------------------

Imports System.IO

Module modLogManager

    Public logPathDirectory As String = StartPath & "\LOG"
    Public logPathFile As String = logPathDirectory & "\events.txt"
    Public currentLogState As String

    Public Sub create_Log_file()
        Try

            If listaEquiposDeLosDesarrolladores.Contains(Environment.MachineName) = True Then
                File.Delete(logPathFile)
            End If

            If Directory.Exists(logPathDirectory) = False Then
                Directory.CreateDirectory(logPathDirectory)
            End If
            If File.Exists(logPathFile) = False Then
                File.Create(logPathFile).Dispose()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub addEvent(ByVal textEvent As String)
        Try
            If File.Exists(logPathFile) = True Then
                Using sw As StreamWriter = File.AppendText(logPathFile)
                    sw.WriteLine(Now & ": " & textEvent)
                End Using
            End If
            trackEvent(Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, "", Reflection.MethodInfo.GetCurrentMethod().Name, textEvent)
        Catch ex As Exception
             Throw
        End Try
    End Sub

    Public Function readLog() As String
        Try
            If File.Exists(logPathFile) = True Then
                currentLogState = File.ReadAllText(logPathFile)
            End If
            Return currentLogState
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module
