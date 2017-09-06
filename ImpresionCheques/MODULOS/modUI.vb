'-----------------------------------------------------------------------------------------
'
'           UI FACILITIES FOR WINFORMS
'           by Marcelo L. Ponce F.
'           version: 2017-05-20 19:00
'
'-----------------------------------------------------------------------------------------

Imports System.Globalization
Imports System.Drawing.Text
Imports System.Text.RegularExpressions

Module modUI

    Public Sub load_autocomplete(ByRef target As ComboBox, ByVal arregle As Array)
        Try
            Dim instcol = New AutoCompleteStringCollection()
            instcol.AddRange(arregle)
            target.AutoCompleteCustomSource = instcol
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function capitalize(ByVal input As String) As String
        Try
            input = input.ToLower
            Return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function SimplifySpaces(ByVal input As String) As String
        Try
            Return Regex.Replace(input, " {2,}", " ")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub disable_special_characters(ByRef e As KeyPressEventArgs)
        Try
            Dim result As Boolean = True

            If Char.IsLetterOrDigit(e.KeyChar) Then
                result = False
            End If

            If e.KeyChar = "." Or
                e.KeyChar = "," Or
                e.KeyChar = "-" Or
                e.KeyChar = ":" Or
                e.KeyChar = "%" Or
                e.KeyChar = vbCr Or
                e.KeyChar = vbBack Or
                e.KeyChar = " " Then
                result = False
            End If

            e.Handled = result

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_hide_identity(ByRef dgv As DataGridView)
        Try
            With dgv
                For Each c As DataGridViewColumn In .Columns
                    If c.Name.Contains("id_") Or c.Name.Contains("Id_") Then
                        c.Visible = False
                    End If
                Next
            End With
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_selectCell(ByRef grill As DataGridView, ByVal fieldName As String, ByVal fieldValue As String)
        Try
            grill.ClearSelection()
            For Each item As DataGridViewRow In grill.Rows
                If item.Cells.Item(fieldName).Value = fieldValue Then
                    For Each cell As DataGridViewCell In item.Cells
                        If cell.Visible = True Then
                            cell.Selected = True
                            Exit Sub
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub comboBoxTextCenter(ByRef combo As ComboBox, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Try
            If e.Index <> -1 Then
                Dim newObject = Activator.CreateInstance(combo.Items.Item(e.Index).GetType)
                newObject = combo.Items.Item(e.Index)
                Dim objType As Type = newObject.GetType()
                Dim pInfo As System.Reflection.PropertyInfo = objType.GetProperty(combo.DisplayMember)
                Dim PropValue As Object = pInfo.GetValue(newObject, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing)
                Using st As New StringFormat With {.Alignment = StringAlignment.Center}
                    objType = newObject.GetType()
                    pInfo = objType.GetProperty(combo.DisplayMember)
                    PropValue = pInfo.GetValue(newObject, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing)
                    TextRenderer.DrawText(e.Graphics, PropValue, e.Font, e.Bounds, Color.Black, TextFormatFlags.HorizontalCenter)
                End Using
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub comboBoxUppercase(ByRef e As ListControlConvertEventArgs)
        Try
            e.Value = e.Value.ToString().ToUpperInvariant()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_cellShortDate(ByRef grid As DataGridView, ByRef e As DataGridViewCellFormattingEventArgs, ByVal ColumnIndex As Integer)
        Try
            If e.ColumnIndex = ColumnIndex Then
                grid.Columns(ColumnIndex).DefaultCellStyle.Format = "dd/MM/yyyy"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_accounting(ByRef grid As DataGridView, ByRef e As DataGridViewCellFormattingEventArgs, ByVal ColumnIndex As Integer)
        Try
            If e.ColumnIndex = ColumnIndex Then
                grid.Columns(ColumnIndex).DefaultCellStyle.Format = "0.0.0.0.0"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_clearSelection(ByRef gridView As DataGridView)
        Try
            gridView = CType(gridView, DataGridView)
            gridView.ClearSelection()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_cellMoney(ByRef grid As DataGridView, ByRef e As DataGridViewCellFormattingEventArgs, ByVal ColumnIndex As Integer)
        Try
            If e.ColumnIndex = ColumnIndex Then
                grid.Columns(ColumnIndex).DefaultCellStyle.Format = "$ #,###,##0.00"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_cellThousands(ByRef grid As DataGridView, ByRef e As DataGridViewCellFormattingEventArgs, ByVal ColumnIndex As Integer)
        Try
            If e.ColumnIndex = ColumnIndex Then
                grid.Columns(ColumnIndex).DefaultCellStyle.Format = "#,###,##0.00"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_totalElements(ByRef grd As DataGridView, ByRef lbl As Label, Optional ByVal singularText As String = "elemento", Optional ByVal pluralText As String = "")
        Try
            With grd
                Select Case .RowCount
                    Case Is = 1 : lbl.Text = (.RowCount & " " & singularText).Trim
                    Case Is > 1, Is = 0
                        If pluralText = "" Then
                            lbl.Text = (.RowCount & " " & singularText & "s").Trim
                        Else
                            lbl.Text = (.RowCount & " " & pluralText).Trim
                        End If
                End Select
            End With
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function dgv_widthLessCurrent(ByRef columns As DataGridViewColumnCollection, ByVal currentColumnName As String) As Integer
        Try
            Dim sum As Integer
            For Each item As DataGridViewColumn In columns
                If (item.Name <> currentColumnName) And item.Visible = True Then
                    sum += item.Width
                End If
            Next
            Return sum + SystemInformation.VerticalScrollBarWidth + 1
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub dgv_cellPercent(ByRef grid As DataGridView, ByRef e As DataGridViewCellFormattingEventArgs, ByVal ColumnIndex As Integer)
        Try
            If e.ColumnIndex = ColumnIndex Then
                grid.Columns(ColumnIndex).DefaultCellStyle.Format = "0.00 \%"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_cellFormat(ByRef grid As DataGridView, ByRef e As DataGridViewCellFormattingEventArgs, ByVal ColumnIndex As Integer, ByVal format As String)
        Try
            If e.ColumnIndex = ColumnIndex Then
                grid.Columns(ColumnIndex).DefaultCellStyle.Format = format
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_cellShortDateWithHour(ByRef grid As DataGridView, ByRef e As DataGridViewCellFormattingEventArgs, ByVal ColumnIndex As Integer)
        Try
            If e.ColumnIndex = ColumnIndex Then
                grid.Columns(ColumnIndex).DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub dgv_cellUppercase(ByRef e As DataGridViewCellFormattingEventArgs, ByVal ColumnIndex As Integer)
        Try
            If e.ColumnIndex = ColumnIndex Then
                If IsNothing(e.Value) = False Then
                    e.Value = e.Value.ToString().ToUpper()
                    e.FormattingApplied = True
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Dgv_cellLowercase(ByRef e As DataGridViewCellFormattingEventArgs, ByVal ColumnIndex As Integer)
        Try
            If e.ColumnIndex = ColumnIndex Then
                e.Value = e.Value.ToString().ToLower()
                e.FormattingApplied = True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function Get_Control_Location(ByVal control As Control, Optional ByVal offset_X As Integer = 0, Optional ByVal offset_Y As Integer = 0) As Point
        Try
            If IsNothing(control.Parent) = True Then
                Return control.Location
            End If
            Return control.Location + Get_Control_Location(control.Parent) + New Point(offset_X, offset_Y)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub SetFont(ctrl As Control)
        Try
            Dim pfc As PrivateFontCollection = New PrivateFontCollection
            pfc.AddFontFile("Resources\Roboto-Medium.ttf")
            ctrl.Font = New Font(pfc.Families(0), 65, FontStyle.Regular)
            ctrl.ForeColor = Color.Red
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub circularControl(ByRef ctrl As Control)
        Try
            ctrl.BackColor = Color.Red
            Dim path As New Drawing2D.GraphicsPath
            path.AddEllipse(New RectangleF(0, 0, 50, 50))
            Dim circle As New Region(path)
            ctrl.Region = circle
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Module
