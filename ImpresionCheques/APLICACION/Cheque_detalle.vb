Public Class Cheque_detalle

    Public Event Guardar(sender As Object, e As cheque)
    Public Event Cancelar(sender As Object, e As cheque)

    Dim _actual As New cheque
    Public Property Actual As cheque
        Get
            Return _actual
        End Get
        Set(value As cheque)
            _actual = value
        End Set
    End Property

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            RaiseEvent Guardar(sender, _actual)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            RaiseEvent Cancelar(sender, Nothing)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

End Class
