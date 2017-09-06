'-----------------------------------------------------------------------------------------
'
'           AUXILIARY FUNCTIONS MODULE
'           by Marcelo L. Ponce F.
'           version: 2016.02.18 10:00
'
'-----------------------------------------------------------------------------------------

Imports System.Globalization
Imports System.Reflection
Imports System.Threading

Module modAuxiliarFunctions

    Public Sub mathCrash()
        Try
            Dim a As Integer = 10
            Dim b As Integer = 0
            Dim c As Integer = a / b
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function calculate_percent_value(ByVal value As Single, ByVal percent As Single) As Single
        Try
            Return (value * percent) / 100
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Calculate a percent value from inicial value (MaxValue)
    ''' </summary>
    ''' <param name="MaxValue"></param>
    ''' <param name="AnotherValue"></param>
    ''' <returns>Relative percent value</returns>
    Public Function calculate_percent(ByVal MaxValue As Single, ByVal AnotherValue As Single) As Single
        Try
            If MaxValue = 0 Then
                Return -1
            End If
            Return (AnotherValue * 100) / MaxValue
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function isOpenFrm(ByVal frm As Form) As Boolean
        Try
            If Application.OpenForms.OfType(Of Form).Contains(frm) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function countOpenFrm(ByVal frm As Form) As Integer
        Try
            Dim q = From f As Form In Application.OpenForms Where f.GetType = frm.GetType Select f
            Return q.Count
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ScreenShoot(ByVal destinyPathAndFileName As String)
        Try

            'create a bitmap of the working area
            Using bmp As New Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)

                'copy the screen to the image
                Using g = Graphics.FromImage(bmp)
                    g.CopyFromScreen(New Point(0, 0), New Point(0, 0), Screen.PrimaryScreen.WorkingArea.Size)
                End Using

                bmp.Save(destinyPathAndFileName, Imaging.ImageFormat.Png)

            End Using

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Function monthFirstDay(ByVal month As Integer, ByVal year As Integer) As Date
        Try
            Dim countDays As Integer = Date.DaysInMonth(year, month)
            Return New Date(year, month, countDays)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function mergeRFT(ByRef first As String, ByRef second As String) As String
        Try
            If first.Trim = "" Then
                If second.Trim <> "" Then
                    Return second
                End If
            End If
            If second.Trim = "" Then
                If first.Trim <> "" Then
                    Return first
                End If
            End If
            If first.Trim <> "" And second.Trim <> "" Then

                Return first.Remove(first.Length - 1, 1) & second.Remove(0, 1)

            End If
            Return ""
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function getFileNameFromPath(ByVal fileWithPath As String) As String
        Try
            If IsNothing(fileWithPath) = False Then
                Dim file() As String = fileWithPath.Split("\")
                Return file(file.Length - 1)
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function getAllFolders(ByVal directory As String) As String()
        Try
            'Create object
            Dim fi As New IO.DirectoryInfo(directory)
            'Array to store paths
            Dim path() As String = {}
            'Loop through subfolders
            For Each subfolder As IO.DirectoryInfo In fi.GetDirectories()
                'Add this folders name
                Array.Resize(path, path.Length + 1)
                path(path.Length - 1) = subfolder.FullName
                'Recall function with each subdirectory
                For Each s As String In getAllFolders(subfolder.FullName)
                    Array.Resize(path, path.Length + 1)
                    path(path.Length - 1) = s
                Next
            Next
            Return path
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Public Function moveform(ByRef sender As Object, ByRef e As MouseEventArgs, ByRef meForm As Object) As Message
        Try
            If e.Button = MouseButtons.Left Then
                sender.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Return Message.Create(meForm.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub populateEntity(ByRef current_entity As Object, ByRef ctrls As Control.ControlCollection)
        Try

            Dim controls_list =
               From ctrl As Control In ctrls
               Select ctrl

            For Each prop As PropertyInfo In current_entity.GetType.GetProperties
                Dim current = controls_list.FirstOrDefault(Function(c) c.Name.ToLower.Contains(prop.Name.ToLower))
                If IsNothing(current) = False Then
                    prop.SetValue(current_entity, current.Text.Trim, Nothing)
                End If
            Next

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub populateControls(ByRef current_entity As Object, ByRef ctrls As Control.ControlCollection)
        Try

            Dim controls_list =
               From ctrl As Control In ctrls
               Select ctrl

            For Each prop As PropertyInfo In current_entity.GetType.GetProperties

                Dim dato As String = prop.GetValue(current_entity, Nothing)
                Dim current = controls_list.FirstOrDefault(Function(c) c.Name.ToLower.Contains(prop.Name.ToLower))

                If IsNothing(current) = False Then
                    current.Text = dato
                End If

            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function rtfToText(ByVal s As String) As String
        Try
            Dim t As New RichTextBox
            t.Rtf = s
            Return t.Text
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub textBoxCast(ByRef tb As TextBox, ByRef entidad As Object, ByVal campo As String)
        Try
            tb.Text = entidad.GetType.GetProperty(campo).GetValue(entidad, Nothing)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub comboBoxCast(ByRef cb As ComboBox, ByRef entidad As Object, ByVal campo As String)
        Try
            cb.SelectedValue = entidad.GetType.GetProperty(campo).GetValue(entidad, Nothing)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub DateTimePickerCast(ByRef dtp As DateTimePicker, ByRef entidad As Object, ByVal campo As String)
        Try
            dtp.Value = entidad.GetType.GetProperty(campo).GetValue(entidad, Nothing)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function cutString(ByVal text As String, ByVal lengh As Integer) As String
        Try
            If text.Length >= lengh Then
                Return text.Substring(0, lengh - 4) & "..."
            Else
                Return text
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Use with gotfocus and leave focus events
    ''' </summary>
    ''' <param name="box"></param>
    ''' <param name="watermark"></param>
    ''' <param name="textColor"></param>
    Public Sub placeholder(ByRef box As TextBox, ByVal watermark As String, ByVal textColor As Color)
        Try
            If box.Text = watermark Then
                If box.Focused = True Then
                    box.Text = ""
                    box.ForeColor = textColor
                Else
                    box.Text = watermark
                    box.ForeColor = Color.Gray
                End If
            Else
                If box.Text = "" Then
                    box.Text = watermark
                    box.ForeColor = Color.Gray
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function textToRGB(ByVal text As String) As Color
        Try
            Dim RGBString() As String
            If IsNothing(text) = True Then
                Return Color.White
            Else
                If text.Trim = "" Then
                    Return Color.White
                End If
            End If
            RGBString = text.Split(",")
            If RGBString.Length = 3 Then
                Return Color.FromArgb(RGBString(0), RGBString(1), RGBString(2))
            Else
                Return Color.White
            End If

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function formatDate(ByVal fecha As Date) As String
        Try
            Dim resultado As String
            resultado = Format(fecha, "dd/MM/yyyy")
            Return resultado
        Catch ex As Exception
            Throw
        End Try
    End Function

    'this function has an error
    Public Function formatMoney(ByVal v As Single, Optional ByVal withSign As Boolean = False) As String
        Try
            Thread.CurrentThread.CurrentCulture = New CultureInfo("es-AR")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-AR")

            Dim curr As String = Strings.FormatCurrency(v)

            If withSign = True Then
                Return Strings.FormatCurrency(v, 2)
            Else
                Return Strings.FormatCurrency(v, 2).Replace("$", "").Trim
            End If

        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Función que ubica el cursor en el inicio de una caja de texto.
    ''' </summary>
    ''' <param name="cajaDeTexto">Identificador de la caja de texto a afectar.</param>
    Public Sub cursorAlInicioEnTextBox(ByRef cajaDeTexto As RichTextBox)
        Try
            cajaDeTexto.Focus()
            cajaDeTexto.SelectionStart = 0
            cajaDeTexto.SelectionLength = 0
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Carga elementos en un combobox y muestra el primero de ellos (si lo hay).
    ''' </summary>
    ''' <param name="combo"></param>
    ''' <param name="lista"></param>
    Public Sub cargarCombo(ByRef combo As ComboBox, ByVal lista As Object)
        Try
            combo.DataSource = lista
            If combo.Items.Count > 0 Then
                combo.SelectedIndex = 0
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Limita durante el evento KeyPress la inserción de caracteres no numéricos.
    ''' </summary>
    ''' <param name="cajaDeTexto">Identificador de la caja de texto a afectar.</param>
    ''' <param name="e">Variable KeyPressEventArgs en la funcion KeyPress</param>
    Public Sub soloNumerosEnTextBox(ByRef cajaDeTexto As TextBox, e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Dim x As Char = e.KeyChar
            If x >= "0" And x <= "9" Then 'numero
                e.Handled = False
            Else
                If x = Convert.ToChar(13) Then 'enter
                    e.Handled = False
                Else
                    If x = Convert.ToChar(8) Then 'backspace
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Limita durante el evento KeyPress la inserción de caracteres no numéricos, permitiendo las comas.
    ''' </summary>
    ''' <param name="cajaDeTexto">Identificador de la caja de texto a afectar.</param>
    ''' <param name="e">Variable KeyPressEventArgs en la funcion KeyPress</param>
    Public Sub soloNumerosEnTextBoxPermitirComas(ByRef cajaDeTexto As TextBox, e As KeyPressEventArgs, Optional ByVal AlwaysComa As Boolean = True)
        Try

            Dim x As String = e.KeyChar.ToString

            If AlwaysComa Then
                If x = "." Then
                    e.KeyChar = "," 'si escribe un punto que ponga una coma
                    x = ","
                End If
            End If


            If IsNumeric(x) = False And Not (x = "," Or x = "," Or x = vbBack) Then 'letras NO permitidas
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = Chr(13) Then 'enter NO permitido
                e.Handled = True
                Exit Sub
            End If

            If Char.IsSymbol(x) = True Then 'simbolos NO permitidos
                e.Handled = True
                Exit Sub
            End If

            If x = "," Or x = "," Then
                If buscarCaracter(cajaDeTexto.Text, x) = True Then 'ver si ya hay una aparición NO permitir
                    e.Handled = True
                    Exit Sub
                Else
                    e.Handled = False 'si es coma o punto permitir
                End If

            End If

            If IsNumeric(x) = True Then e.Handled = False 'números permitidos

            If x = vbBack Then e.Handled = False 'backspace permitido


            'If cajaDeTexto.Text.Contains(".") Or cajaDeTexto.Text.Contains(",") Then e.Handled = True
            'SendKeys.Send(vbTab)
            'e.Handled = True

        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Limita durante el evento KeyPress la inserción de caracteres no numéricos, permitiendo los puntos.
    ''' </summary>
    ''' <param name="cajaDeTexto">Identificador de la caja de texto a afectar.</param>
    ''' <param name="e">Variable KeyPressEventArgs en la funcion KeyPress</param>
    Public Sub soloNumerosEnTextBoxPermitirPuntos(ByRef cajaDeTexto As TextBox, e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Dim x As Char = e.KeyChar
            If x >= "0" And x <= "9" Then 'numero
                e.Handled = False
            Else
                If e.KeyChar = Chr(13) Then 'enter or +
                    e.Handled = True
                    SendKeys.Send(vbTab)
                Else
                    If x = Convert.ToChar(8) Then 'backspace
                        e.Handled = False
                    Else
                        If x = "." Then
                            e.Handled = False
                            Exit Sub
                        End If
                        If x = "," Then
                            e.Handled = True
                            Exit Sub
                        End If
                        If buscarCaracter(cajaDeTexto.Text, x) = True And x = "." Then 'punto
                            If x = "," Then e.KeyChar = "." 'si escribe una coma, ponga un punto.
                        ElseIf x = "-"c Then
                            e.Handled = True
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function buscarCaracter(ByVal txtval As String, ByVal car As Char) As Boolean
        Try
            For b As Integer = 1 To txtval.Length
                If Convert.ToChar(Mid(txtval, b, 1)) = car Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub negritas(ByRef text As RichTextBox)
        Try
            If IsNothing(text.SelectionFont) = False Then
                If text.SelectionFont.Bold = True Then
                    'recuperarConfig("tamañoFuente")
                    text.SelectionFont = New Font(text.SelectionFont.FontFamily, text.SelectionFont.Size, FontStyle.Regular, GraphicsUnit.Point)
                Else
                    text.SelectionFont = New Font(text.SelectionFont.FontFamily, text.SelectionFont.Size, text.SelectionFont.Style Xor FontStyle.Bold, GraphicsUnit.Point)
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub cursiva(ByRef text As RichTextBox)
        Try
            If IsNothing(text.SelectionFont) = False Then
                If text.SelectionFont.Italic = True Then
                    text.SelectionFont = New Font(text.SelectionFont.FontFamily, text.SelectionFont.Size, FontStyle.Regular, GraphicsUnit.Point)
                Else
                    text.SelectionFont = New Font(text.SelectionFont.FontFamily, text.SelectionFont.Size, text.SelectionFont.Style Xor FontStyle.Italic, GraphicsUnit.Point)
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub subrayado(ByRef text As RichTextBox)
        Try
            If IsNothing(text.SelectionFont) = False Then
                If text.SelectionFont.Underline = True Then
                    text.SelectionFont = New Font(text.SelectionFont.FontFamily, text.SelectionFont.Size, FontStyle.Regular, GraphicsUnit.Point)
                Else
                    text.SelectionFont = New Font(text.SelectionFont.FontFamily, text.SelectionFont.Size, text.SelectionFont.Style Xor FontStyle.Underline, GraphicsUnit.Point)
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Module
