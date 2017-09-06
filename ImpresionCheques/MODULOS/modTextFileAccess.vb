'-----------------------------------------------------------------------------------------
'
'           TEXT FILE ACCESS MODULE
'           by Marcelo L. Ponce F.
'           version: 2016.28.08 12:00
'
'-----------------------------------------------------------------------------------------

Imports System.IO

Public Class modTExtFileAccess

    Public Sub Escribir_Mostrar_TXT(texto_completo As Object, ruta_nombre_archivo As String, Optional ByVal agregar_al_existente As Boolean = True)

        Try

            My.Computer.FileSystem.WriteAllText(ruta_nombre_archivo, texto_completo, agregar_al_existente)
            Process.Start(ruta_nombre_archivo)

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Function listFiles(ByVal folderPath As String) As String()
        Try
            Return Directory.GetFiles(folderPath)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function readFile(ByVal filePath As String) As String
        Try
            Dim objReader As New StreamReader(filePath, Text.Encoding.Default)
            Dim resultado As String = objReader.ReadToEnd
            objReader.Close()
            Return resultado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CreateDirectory(ByVal directoryName As String) As Boolean
        Try
            Directory.CreateDirectory(directoryName)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function createTextFile(ByVal fileName As String) As Boolean
        Try
            File.CreateText(fileName).Dispose()
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function writeTextFile(ByVal fileName As String, ByVal textContent As String) As Boolean
        Try
            File.WriteAllText(fileName, textContent, System.Text.Encoding.Default)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function append(ByVal fileName As String, ByVal textContent As String) As Boolean
        Try
            File.AppendAllText(fileName, textContent, System.Text.Encoding.Default)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function existFile(ByVal fileName As String) As Boolean
        Try
            Dim r As Boolean
            r = File.Exists(fileName)
            Return r
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function deleteDirectory(ByVal folderName As String) As Boolean
        Try
            Directory.Delete(folderName, True)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function existFolder(ByVal folderName As String) As Boolean
        Try
            Dim r As Boolean
            r = Directory.Exists(folderName)
            Return r
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function deleteFile(ByVal fileName As String) As Boolean
        Try
            File.Delete(fileName)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
