Imports System.Drawing.Printing

Module Mod_Print

    Public _PrintDocument As New PrintDocument
    Public _PrinterSettings As New PrinterSettings
    Public _PrintPreviewDialog As New PrintPreviewDialog

    Public Enum Target_Border_Position
        TopRight = 0
        TopLeft = 1
        BottomRight = 2
        BottomLeft = 3
    End Enum

    Sub Target_Border(ByVal e As PrintPageEventArgs,
                      p As Point,
                      Optional Target_Position As Target_Border_Position = 0,
                      Optional size As Integer = 6,
                      Optional dashed As Boolean = False)
        Try

            Dim _pen As New Pen(Color.Black, 0.3)

            If dashed Then
                Dim dashValues() As Single = {3, 3}
                _pen.DashPattern = dashValues
            End If

            Select Case Target_Position

                Case Target_Border_Position.TopLeft
                    e.Graphics.DrawLine(_pen, p, New Point With {.X = p.X + size, .Y = p.Y})
                    e.Graphics.DrawLine(_pen, p, New Point With {.X = p.X, .Y = p.Y + size})

                Case Target_Border_Position.TopRight
                    e.Graphics.DrawLine(_pen, p, New Point With {.X = p.X - size, .Y = p.Y})
                    e.Graphics.DrawLine(_pen, p, New Point With {.X = p.X, .Y = p.Y + size})

                Case Target_Border_Position.BottomLeft
                    e.Graphics.DrawLine(_pen, p, New Point With {.X = p.X + size, .Y = p.Y})
                    e.Graphics.DrawLine(_pen, p, New Point With {.X = p.X, .Y = p.Y - size})

                Case Target_Border_Position.BottomRight
                    e.Graphics.DrawLine(_pen, p, New Point With {.X = p.X - size, .Y = p.Y})
                    e.Graphics.DrawLine(_pen, p, New Point With {.X = p.X, .Y = p.Y - size})

            End Select

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub _print(Optional preview As Boolean = False)
        Try
            ' Asignamos la impresora seleccionada
            _PrintDocument.PrinterSettings = _PrinterSettings

            ' Asignamos el tamaño personalizado de papel
            _PrintDocument.DefaultPageSettings.PaperSize = _PrintDocument.PrinterSettings.PaperSizes.Item(0)

            'asignamos el método de evento para cada página a imprimir
            AddHandler _PrintDocument.PrintPage, AddressOf _Printing_Page

            If preview Then
                _PrintPreviewDialog.Icon = My.Resources.imprimir
                _PrintPreviewDialog.Document = _PrintDocument
                _PrintPreviewDialog.WindowState = FormWindowState.Maximized
                _PrintPreviewDialog.ShowDialog()
            Else
                _PrintDocument.Print()
            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub _Printing_Page(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Try

            'Este evento se producirá cada vez que se imprima una nueva página
            Dim lineHeight As Single

            'La fuente a usar
            Dim regFont As New Font("Arial", 8, FontStyle.Regular)
            Dim titFont As New Font("Arial", 8, FontStyle.Bold)

            'tamaño del renglon
            lineHeight = regFont.GetHeight(e.Graphics)

            'definir unidad de medida
            e.Graphics.PageUnit = GraphicsUnit.Millimeter

            '---------------------------------------------------------------------------------------------------------
            'dibujo del comprobante

            Dim ComprobanteFont As New Font("Arial", 8, FontStyle.Bold)
            Dim XFont As New Font("Arial", 20, FontStyle.Bold)
            Dim Empresa As New Font("Arial", 12, FontStyle.Bold)
            Dim lapiz1 As System.Drawing.Pen
            lapiz1 = New Pen(Color.Black, 0.1)
            Dim lapiz2 As System.Drawing.Pen
            lapiz2 = New Pen(Color.Black, 0.3)

            Dim Margen_Izquierdo As Integer = 10
            Dim Margen_Superior As Integer = 10

            Dim x1 As Integer = Margen_Izquierdo
            Dim y1 As Integer = 5 + Margen_Superior
            Dim x2 As Integer = 190 + Margen_Izquierdo
            Dim y2 As Integer = y1 + 125

            Imprimir_cheque(e, 76, 180, New Point With {.X = 0, .Y = 0})


            'comprobante
            e.Graphics.DrawString("COMPROBANTE", ComprobanteFont, Brushes.Black, x1 + 82.7, y1 + 20)

            'indicamos que ya no hay nada más que imprimir
            e.HasMorePages = False

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Sub Imprimir_cheque(ByVal e As PrintPageEventArgs, alto As Integer, ancho As Integer, posicion As Point)
        Try

            Target_Border(e, posicion, Target_Border_Position.TopLeft)
            Target_Border(e, New Point With {.X = posicion.X + ancho, .Y = posicion.Y}, Target_Border_Position.TopRight)

            Target_Border(e, New Point With {.X = posicion.X, .Y = posicion.Y + alto}, Target_Border_Position.BottomLeft)
            Target_Border(e, New Point With {.X = posicion.X + ancho, .Y = posicion.Y + alto}, Target_Border_Position.BottomRight)

        Catch ex As Exception
            Throw
        End Try
    End Sub

End Module
