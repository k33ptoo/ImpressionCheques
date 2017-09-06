'-----------------------------------------------------------------------------------------
'
'           EMAIL MODULE
'           by Marcelo L. Ponce F.
'           version: 2017.05.25 19:00
'
'-----------------------------------------------------------------------------------------

Imports System.Net.Mail

Module modMail

    Public Function enviarCorreo(ByVal cuerpo As String, ByVal IsBodyHtml As Boolean, ByVal asunto As String) As Boolean

        'create the mail message
        Dim mail As New MailMessage()

        'set the addresses
        mail.From = New MailAddress("no-reply@yellowinformatica.com.ar")
        mail.To.Add("marcelo2108@gmail.com")

        'set the content
        mail.Subject = asunto
        mail.Body = cuerpo
        mail.IsBodyHtml = IsBodyHtml

        'set the server
        Dim smtp As New SmtpClient("mail.yellowinformatica.com.ar", "587")

        smtp.Credentials = New System.Net.NetworkCredential("no-reply@yellowinformatica.com.ar", "bwU2HjKhop")
        smtp.Timeout = 3000

        'send the message
        Try
            smtp.Send(mail)
            Return True
        Catch exc As Exception
            Return False
        End Try

    End Function

    Public Function enviarCorreoAdjunto(ByVal cuerpo As String, ByVal IsBodyHtml As Boolean, ByVal asunto As String, ByVal pathAdjunto As List(Of String)) As Boolean

        'create the mail message
        Dim mail As New MailMessage()

        'set the addresses
        mail.From = New MailAddress("no-reply@yellowinformatica.com.ar")
        mail.To.Add("marcelo2108@gmail.com")

        'set the content
        mail.Subject = asunto
        mail.Body = cuerpo
        mail.IsBodyHtml = IsBodyHtml

        'set the server
        Dim smtp As New SmtpClient("mail.yellowinformatica.com.ar", "587")

        smtp.Credentials = New Net.NetworkCredential("no-reply@yellowinformatica.com.ar", "bwU2HjKhop")
        smtp.Timeout = 3000

        For Each adj In pathAdjunto
            Dim Attach As Attachment = New Attachment(adj)
            If IsNothing(Attach) = Nothing Then
                mail.Attachments.Add(Attach)
            End If
        Next

        'send the message
        Try
            smtp.Send(mail)
            Return True
        Catch exc As Exception
            Return False
        Finally
            mail.Dispose()
        End Try

    End Function

End Module
