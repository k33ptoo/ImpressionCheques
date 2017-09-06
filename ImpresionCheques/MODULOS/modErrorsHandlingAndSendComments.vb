'-----------------------------------------------------------------------------------------
'
'           ERRORS HANDLING AND SEND COMMENTS
'           by Marcelo L. Ponce F.
'           version: 2017.07.12 01:00
'
'-----------------------------------------------------------------------------------------

Imports System.Threading

Module modErrorsHandlingAndSendComments

    Public tareaReportarError As Thread
    Public tareaReportarComentario As Thread
    Dim mail_body As String
    Dim path_Captura As String = StartPath & "\captura.png"
    Dim path_excep As String = StartPath & "\excep.txt"
    Public informeUsuario As String = ""
    Dim comentarioUsuario As String = ""

    Sub EnviarCorreoXExcepcion()
        Try

            If IO.File.Exists(path_Captura) = True And IO.File.Exists(path_excep) = True Then
                enviarCorreoAdjunto(mail_body, True, Application.ProductName & " - EXCEPCIÓN CONTROLADA: " & Environment.UserName.ToUpper, New List(Of String) From {path_Captura, path_excep})
                IO.File.Delete(path_Captura)
                IO.File.Delete(path_excep)
            Else
                enviarCorreo(mail_body, True, Application.ProductName & " - EXCEPCIÓN CONTROLADA: " & Environment.UserName.ToUpper)
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Report_exeption(ByVal excep As Exception)
        Try

            Dim st = New StackTrace(excep, True)

            mail_body = "EXCEPCIÓN CONTROLADA en " & Application.ProductName.ToUpper & vbCrLf & vbCrLf

            mail_body &=
                "La Excepción se produjo el: " & Now.ToString & vbCrLf & vbCrLf &
                "Mensaje: " & excep.Message.ToString & vbCrLf & vbCrLf &
                "Archivo: " & getFileNameFromPath(st.GetFrame(0).GetFileName).ToString & vbCrLf & vbCrLf &
                "Linea: " & st.GetFrame(0).GetFileLineNumber.ToString & vbCrLf & vbCrLf

            If informeUsuario <> "" Then
                mail_body &= "Explicación del usuario: " & informeUsuario & vbCrLf & vbCrLf
            End If

            mail_body &=
                "Pila de llamadas: " & vbCrLf & excep.StackTrace.ToString & vbCrLf & vbCrLf &
                "Excepción detallada: " & vbCrLf & excep.ToString & vbCrLf & vbCrLf &
                "Información de la aplicación: " & vbCrLf & get_current_app_information().ToString & vbCrLf & vbCrLf &
                "Información del sistema operativo: " & vbCrLf & get_operative_system_information().ToString

            ScreenShoot(path_Captura)

            IO.File.AppendAllText(path_excep, mail_body)

            mail_body = "Informacion adjunta.-"

            If listaEquiposDeLosDesarrolladores.Contains(Environment.MachineName) = False Then

                tareaReportarError = New Thread(AddressOf EnviarCorreoXExcepcion) With {.IsBackground = True}
                tareaReportarError.Start()

                mensaje_Frm.title = "Excepción controlada"
                mensaje_Frm.mensaje = "Se produjo una excepción en el sistema." & vbCrLf & "Se informará al desarrollador sobre este problema." & vbCrLf & "Probalemente no se completo la tarea." & vbCrLf & "Te ofrecemos disculpas por el inconveniente."
                mensaje_Frm.Width = 450
                mensaje_Frm.Height = 200
                mensaje_Frm.AutoAjustarAlto = False
                mensaje_Frm.ShowDialog(Main, Main.Location, mensaje_Frm.pStyle.CenterScreen, mensaje_Frm.colorOK.AMARILLO)

            Else
                If MsgBox(excep.Message & vbCrLf & "¿Buscar información?" & vbCrLf & vbCrLf & excep.StackTrace,
                       MsgBoxStyle.YesNo, "Excepción controlada") = MsgBoxResult.Yes Then
                    Process.Start("https://www.google.com.ar/search?q=vb.net%20" & excep.Message)
                End If
            End If

            addEvent(excep.Message)

        Catch ex As Exception
            addEvent(ex.Message)
        End Try
    End Sub

    Sub enviarComentario()
        Try
            If enviarCorreo(comentarioUsuario, False, Application.ProductName.ToUpper & " - COMENTARIO DE " & Environment.UserName.ToUpper) = True Then
                MessageBox.Show("Tu mensaje fue enviado, ¡gracias!")
            End If
        Catch ex As Exception
            addEvent(ex.Message)
        End Try
    End Sub

    Public Sub send_comments(ByVal comment As String)
        Try
            comentarioUsuario = "Comentario del usuario: " & vbCrLf & comment &
                vbCrLf & vbCrLf & "Información del sistema" & vbCrLf & "---------------" & vbCrLf & get_all_system_Information()

            If listaEquiposDeLosDesarrolladores.Contains(Environment.MachineName) = False Then
                tareaReportarComentario = New Thread(AddressOf enviarComentario)
                tareaReportarError.IsBackground = True
                tareaReportarComentario.Start()
            Else
                MessageBox.Show(comentarioUsuario)
            End If
        Catch ex As Exception
            addEvent(ex.Message)
        End Try
    End Sub

    Public Sub send_log()
        Try
            Dim body As String = "REGISTRO DE EVENTOS:" & vbCrLf & "--------------------" & vbCrLf & IO.File.ReadAllText(logPathFile) & vbCrLf & vbCrLf

            body &= vbCrLf & "INFORMACIÓN DEL SISTEMA:" & vbCrLf & "------------------------" & vbCrLf & get_all_system_Information()

            If listaEquiposDeLosDesarrolladores.Contains(Environment.MachineName) = False Then
                If enviarCorreo(body, False, Application.ProductName.ToUpper & " - LOG DE EVENTOS: " & Environment.UserName) = True Then
                    MessageBox.Show("Tu mensaje fue enviado, ¡gracias!")
                End If
            Else
                MessageBox.Show(body)
            End If
        Catch ex As Exception
            addEvent(ex.Message)
        End Try
    End Sub

End Module
