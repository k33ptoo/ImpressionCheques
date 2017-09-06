Public Class mensaje_Frm

    Dim resultado As DialogResult
    Private _finalPosition As Point
    Private _initialPosition As Point
    Private _position_style As pStyle = 13
    Private _current_colorOK As colorOK
    Private _sender_w As Integer
    Private _sender_h As Integer
    Dim _mensaje As String = ""

    Dim _autoAjustarAlto As Boolean = False


    Overloads Sub ShowDialog(ByVal msg As String)
        Try
            If IsNothing(msg) = False Then
                mensaje = msg
            End If
            ShowDialog()
        Catch ex As Exception
            Throw
        End Try
    End Sub


    Public Enum pStyle As Integer

        InnerTopRight = 0
        InnerTopMiddle = 1
        InnerTopLeft = 2

        InnerBottomRight = 3
        InnerBottomMiddle = 4
        InnerBottomLeft = 5

        OutterTopRight = 6
        OutterTopMiddle = 7
        OutterTopLeft = 8

        OutterBottomRight = 9
        OutterBottomMiddle = 10
        OutterBottomLeft = 11

        CenterScreen = 12
        Custom = 13
        CenterIntoMe = 14

    End Enum

    <Flags()>
    Public Enum colorOK
        AMARILLO
        ROJO
        VERDE
    End Enum

    Public Property positionStyle() As pStyle
        Get
            Return _position_style
        End Get

        Set(ByVal value As pStyle)
            _position_style = value
        End Set
    End Property

    Private Sub mensaje_Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            cambiarColor()
            ubicar()
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Sub ubicar(Optional ByRef sender As Object = Nothing)
        Try
            Select Case _position_style
                Case pStyle.CenterScreen : CenterToScreen()
                Case pStyle.Custom : Location = _initialPosition
                Case pStyle.InnerBottomRight
                    Left = _initialPosition.X - (Width - _sender_w)
                    Top = _initialPosition.Y - (Height - _sender_h)
                Case pStyle.OutterBottomLeft
                    Left = _initialPosition.X
                    Top = _initialPosition.Y + _sender_h
                Case pStyle.OutterBottomRight
                    Left = _initialPosition.X - (Width - _sender_w)
                    Top = _initialPosition.Y + _sender_h
                Case pStyle.Custom
                    StartPosition = FormStartPosition.Manual
                    Location = _finalPosition
                Case pStyle.InnerBottomLeft
                    Left = _initialPosition.X
                    Top = _initialPosition.Y - (Height - _sender_h)
                Case pStyle.InnerTopRight
                    Left = _initialPosition.X - (Width - _sender_w)
                    Top = _initialPosition.Y
                Case pStyle.CenterIntoMe
                    Left = _finalPosition.X + (_sender_w / 2 - Width / 2)
                    Top = _finalPosition.Y + (_sender_h / 2 - Height / 2)
            End Select
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Property ubicacionAbsoluta() As Point
        Get
            Return _finalPosition
        End Get
        Set(ByVal value As Point)
            _finalPosition = value
        End Set
    End Property

    Public Property title() As String
        Get
            Return lblTitulo.Text
        End Get
        Set(ByVal value As String)
            lblTitulo.Text = value
        End Set
    End Property

    Public Property mensaje() As String
        Get
            Return _mensaje
        End Get
        Set(ByVal value As String)

            _mensaje = value
            lblMensaje.Text = value

            If AutoAjustarAlto = True Then

                Dim renglones() As String = value.Split(vbCrLf)

                Dim max_lengh As Integer = 0
                Dim c As Integer = 0
                For Each r In renglones
                    c = TextRenderer.MeasureText(r, lblMensaje.Font).Width
                    If c > max_lengh Then
                        max_lengh = c
                    End If
                Next

                Height = 75 + (renglones.Length * lblMensaje.Font.Height)
                Width = 150 + (max_lengh)

            End If

        End Set
    End Property

    Public Property buttonColor() As colorOK
        Get
            Return _current_colorOK
        End Get
        Set(ByVal value As colorOK)
            cambiarColor()
            _current_colorOK = value
        End Set
    End Property

    Sub cambiarColor()
        Try
            Select Case _current_colorOK
                Case colorOK.AMARILLO : btnCancel.BackColor = Color.FromArgb(206, 159, 8)
                Case colorOK.ROJO : btnCancel.BackColor = Color.FromArgb(244, 67, 54)
                Case colorOK.VERDE : btnCancel.BackColor = Color.FromArgb(45, 134, 50)
            End Select
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            DialogResult = DialogResult.Cancel
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try
            If e.KeyChar = Chr(13) Then
                btnCancel_Click(sender, Nothing)
                e.Handled = True
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try
            lblMensaje.Text = ""
            lblTitulo.Text = ""
        Catch ex As Exception
            Report_exeption(ex)
        End Try

    End Sub

    Overloads Sub ShowDialog(ByRef sender As Object,
                             ByVal absoluteLocation As Point,
                             Optional ByVal positionStyle As pStyle = pStyle.CenterScreen,
                             Optional ByVal buttonColor As colorOK = colorOK.VERDE)
        Try
            _sender_w = sender.width
            _sender_h = sender.height
            _initialPosition = absoluteLocation
            _current_colorOK = buttonColor
            Me.positionStyle = positionStyle
            ShowDialog()
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private _autoClose As Boolean
    Public Property autoClose() As Boolean
        Get
            Return _autoClose
        End Get
        Set(ByVal value As Boolean)
            _autoClose = value
        End Set
    End Property

    Public Property AutoAjustarAlto As Boolean
        Get
            Return _autoAjustarAlto
        End Get
        Set(value As Boolean)
            _autoAjustarAlto = value
        End Set
    End Property

    Dim _time As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If _autoClose = True Then
                If _time = 0 Then
                    Dispose()
                Else
                    _time -= 1
                    btnCancel.Text = "Cerrar (" & _time & ")"
                End If
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Public Sub ShowDialog2(Optional t As Integer = 0)
        Try
            _autoClose = True
            _time = t
            Timer1.Enabled = True
            ShowDialog()
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

End Class