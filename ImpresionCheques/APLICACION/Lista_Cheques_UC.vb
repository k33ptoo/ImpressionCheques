Public Class Lista_Cheques_UC

    Private Sub Lista_Cheques_UC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dgv_Entidades.DataSource = _lista_cheques
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            animation_vertical.ShowSync(_Cheque_detalle)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Sub Ubicar_detalle()
        Try
            _Cheque_detalle.Left = (Me.Width / 2) - (_Cheque_detalle.Width / 2)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Lista_Cheques_UC_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            Ubicar_detalle()
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub _Cheque_detalle_Cancelar(sender As Object, e As cheque) Handles _Cheque_detalle.Cancelar
        Try
            animation_vertical.HideSync(_Cheque_detalle)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub _Cheque_detalle_Guardar(sender As Object, e As cheque) Handles _Cheque_detalle.Guardar
        Try

            _chequeAcceso.insertar(e)

            animation_vertical.HideSync(_Cheque_detalle)

        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click, Dgv_Entidades.CellDoubleClick
        Try
            _Cheque_detalle.Actual = _lista_cheques.Find(Function(x) x.Id_cheque = Dgv_Entidades.SelectedRows(0).Cells("id_cheque").Value)
            animation_vertical.ShowSync(_Cheque_detalle)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try

        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try

        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

End Class
