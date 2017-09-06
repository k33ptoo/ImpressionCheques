Public Class pregunta_Frm

    Dim resultado As DialogResult

    <Flags()>
    Public Enum colorOK
        AMARILLO
        ROJO
        VERDE
    End Enum

    Public Property buttonColor() As colorOK
        Get
            Return btnOk.BackColor.ToString
        End Get
        Set(ByVal value As colorOK)
            Select Case value
                Case colorOK.ROJO : btnOk.BackColor = Color.FromArgb(244, 67, 54)
                Case colorOK.VERDE : btnOk.BackColor = Color.FromArgb(45, 134, 50)
                Case colorOK.AMARILLO : btnCancel.BackColor = Color.FromArgb(206, 159, 8)
            End Select
        End Set
    End Property

    Public Property ubicacion() As Point
        Get
            Return Location
        End Get
        Set(ByVal value As Point)
            Location = value
        End Set
    End Property

    Public Property Mensaje() As String
        Get
            Return txtMensaje.Text
        End Get
        Set(ByVal value As String)
            txtMensaje.Text = value
        End Set
    End Property

    Private Sub frmDialogos_Pregunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnOk.Focus()
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Try
            DialogResult = DialogResult.OK
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            DialogResult = DialogResult.Cancel
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try
            If e.KeyChar = Chr(13) Then
                btnOk_Click(sender, Nothing)
                e.Handled = True
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

End Class