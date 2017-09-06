'-----------------------------------------------------------------------------------------
'
'           XML SERIALIZATION MODULE
'           by Marcelo L. Ponce F.
'           version: 2016.01.03 10:30
'
'-----------------------------------------------------------------------------------------

Imports System.Xml.Serialization
Imports System.IO
Imports System.Xml
Imports System.Reflection

Module modXMLSerialization

    Public Function serializeObjectToXML(ByVal currentObject As Object, ByVal filePath As String) As Boolean
        Try
            Dim mySerializer As XmlSerializer = New XmlSerializer(currentObject.GetType())
            Dim myWriter As StreamWriter = New StreamWriter(filePath)
            mySerializer.Serialize(myWriter, currentObject)
            myWriter.Close()
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function deserializeXMLFile(ByRef currentObject As Object, ByVal filePath As String) As Boolean
        Try
            If IO.File.Exists(filePath) = True Then
                Dim newObject As Object = Activator.CreateInstance(currentObject.GetType)
                Dim mySerializer As XmlSerializer = New XmlSerializer(currentObject.GetType)
                Dim myFileStream As FileStream = New FileStream(filePath, FileMode.Open)
                currentObject = mySerializer.Deserialize(myFileStream)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module