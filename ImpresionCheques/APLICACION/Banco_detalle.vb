Public Class Banco_detalle

    Public Event Guardar(sender As Object, e As banco)
    Public Event Cancelar(sender As Object, e As banco)

    Dim _actual As New banco
    Public Property Actual As banco
        Get
            Return _actual
        End Get
        Set(value As banco)
            _actual = value
            Cargar_datos()
        End Set
    End Property

    Sub Cargar_datos()
        Try
            Txt_Nombre.Text = _actual.nombre
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            _actual.nombre = Txt_Nombre.Text
            RaiseEvent Guardar(sender, _actual)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Try
            RaiseEvent Cancelar(sender, Nothing)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

End Class
