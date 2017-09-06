Imports Microsoft.Win32

Module ModRegistryManager

    Public Function existRegistryKey(ByVal subKey As String) As Boolean
        Try
            Dim regVersion As Microsoft.Win32.RegistryKey
            regVersion = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey, True)
            If regVersion Is Nothing Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function thisProgramIsInstalled(ByVal programName As String) As Boolean
        Try
            Dim AccessDBAsValue As String = String.Empty
            Dim rkACDBKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\Installer\Products")
            If IsNothing(rkACDBKey) = False Then
                For Each subKeyName In rkACDBKey.GetSubKeyNames
                    Dim RegSubKey As RegistryKey = rkACDBKey.OpenSubKey(subKeyName)
                    For Each valueName In RegSubKey.GetValueNames()
                        If valueName.ToUpper() = "PRODUCTNAME" Then
                            AccessDBAsValue = RegSubKey.GetValue(valueName.ToUpper())
                            If (AccessDBAsValue.Contains(programName)) Then
                                Return True
                            End If
                        End If
                    Next
                Next
            End If
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function get_all_installed_programs_from_registry() As List(Of String)
        Try
            Dim rkACDBKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\Installer\Products")
            Dim programsList As New List(Of String)
            If IsNothing(rkACDBKey) = False Then
                For Each subKeyName In rkACDBKey.GetSubKeyNames
                    Dim RegSubKey As RegistryKey = rkACDBKey.OpenSubKey(subKeyName)
                    For Each valueName In RegSubKey.GetValueNames()
                        If valueName.ToUpper() = "PRODUCTNAME" Then
                            programsList.Add(RegSubKey.GetValue(valueName.Trim))
                        End If
                    Next
                Next
            End If

            Return programsList

        Catch ex As Exception
            Throw
        End Try
    End Function

End Module
