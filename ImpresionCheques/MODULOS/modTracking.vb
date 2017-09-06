'-----------------------------------------------------------------------------------------
'
'           USER ACTIVITY TRACKING MODULE
'           by Marcelo L. Ponce F.
'           version: 2017.05.25 19:00
'
'-----------------------------------------------------------------------------------------

Module modTracking

    Public event_list_tracked As New List(Of trackingEvent)
    Dim eventsDirectory As String = StartPath & "\UAT"
    Public tareaSendEvents As Threading.Thread
    Public trackEnable As Boolean = False

    Public Sub trackEvent(formName As String, senderName As String, eventName As String, eventDescription As String)
        Try

            If trackEnable = True Then

                Dim te As New trackingEvent

                If senderName <> "" Then
                    If eventName.Contains(senderName) = True Then
                        eventName = eventName.Replace(senderName, "").Replace("_", "")
                    End If
                End If

                te.formName = formName
                te.senderName = senderName
                te.eventName = eventName
                te.eventDescription = eventDescription
                te.eventDate = Today.Date.ToString("dd/MM/yyyy")
                te.eventTime = String.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:HH:mm:ss}", System.DateTime.Now)

                event_list_tracked.Add(te)

            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub create_UAT_directory()
        Try
            If IO.File.Exists(eventsDirectory) = False Then
                IO.Directory.CreateDirectory(eventsDirectory)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub saveEventList()
        Try
            If trackEnable = True Then
                Dim pathXML As String = eventsDirectory & "\" & Now.Year & "-" & Now.Month & "-" & Now.Day & "-" & Now.Hour & "-" & Now.Minute & "-" & Now.Second & "_" & Environment.UserName & "_.xml"
                serializeObjectToXML(event_list_tracked, pathXML)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub uploadEvents()
        Try
            Dim di As New IO.DirectoryInfo(eventsDirectory)

            For Each file In di.GetFiles



            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub sendEvents()
        Try
            If trackEnable = True Then

                If CheckForInternetConnection() = True Then

                    If IO.Directory.Exists(eventsDirectory) = False Then
                        addEvent("No se encuentra la carpeta UAT, se crea nuevamente.")
                    End If

                    Dim di As New IO.DirectoryInfo(eventsDirectory)

                    If di.GetFiles.Count > 0 Then

                        Dim infoSys As String =
                            get_current_app_information().ToString & vbCrLf &
                            get_operative_system_information().ToString & vbCrLf &
                            get_hardware_information()

                        IO.File.AppendAllText(eventsDirectory & "\infoSys.txt", infoSys)

                        Dim adjuntos As New List(Of String) From {logPathFile}

                        For Each file In di.GetFiles
                            adjuntos.Add(file.FullName)
                        Next

                        If enviarCorreoAdjunto("Información adjunta.-", False, "HC - Tracking de: " & Environment.UserName.ToUpper, adjuntos) = True Then
                            For Each file In di.GetFiles
                                IO.File.Delete(file.FullName)
                            Next
                        End If

                    Else
                        addEvent("No hay achivos de seguimiento para enviar.")
                    End If

                End If
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

End Module

Public Class trackingEvent

    Private _eventDate As String
    Public Property eventDate As String
        Get
            Return _eventDate
        End Get
        Set(ByVal value As String)
            _eventDate = value
        End Set
    End Property

    Private _eventTime As String
    Public Property eventTime As String
        Get
            Return _eventTime
        End Get
        Set(ByVal value As String)
            _eventTime = value
        End Set
    End Property

    Private _formName As String
    Public Property formName() As String
        Get
            Return _formName
        End Get
        Set(ByVal value As String)
            _formName = value
        End Set
    End Property

    Private _senderName As String
    Public Property senderName() As String
        Get
            Return _senderName
        End Get
        Set(ByVal value As String)
            _senderName = value
        End Set
    End Property

    Private _eventName As String
    Public Property eventName() As String
        Get
            Return _eventName
        End Get
        Set(ByVal value As String)
            _eventName = value
        End Set
    End Property

    Private _eventDescription As String
    Public Property eventDescription() As String
        Get
            Return _eventDescription
        End Get
        Set(ByVal value As String)
            _eventDescription = value
        End Set
    End Property

End Class
