Public Class Lista_Bancos_UC

    Private Sub Lista_Cheques_UC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Cargar_datos()
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            _Banco_detalle.Actual = New banco With {.id_banco = -1}
            animation_vertical.ShowSync(_Banco_detalle)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Sub Ubicar_detalle()
        Try
            _Banco_detalle.Left = (Me.Width / 2) - (_Banco_detalle.Width / 2)
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

    Private Sub _Cheque_detalle_Cancelar(sender As Object, e As banco) Handles _Banco_detalle.Cancelar
        Try
            animation_vertical.HideSync(_Banco_detalle)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Sub Cargar_datos()
        Try
            _lista_bancos = _bancoAcceso.recuperar

            Dim query =
                From b In _lista_bancos
                Order By b.nombre Ascending
                Select b

            With Dgv_Entidades
                .DataSource = query.ToList
                If .RowCount > 0 Then
                    .Columns("id_banco").Visible = False
                End If
                .ClearSelection()
            End With

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub _Cheque_detalle_Guardar(sender As Object, e As banco) Handles _Banco_detalle.Guardar
        Try
            If Validar(e) Then
                If e.id_banco <> -1 Then
                    _bancoAcceso.actualizar(e)
                Else
                    _bancoAcceso.insertar(e)
                End If
                Cargar_datos()
                animation_vertical.HideSync(_Banco_detalle)
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Function Validar(e As banco) As Boolean
        Try
            If e.nombre.Trim = "" Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click, Dgv_Entidades.CellDoubleClick
        Try
            If Dgv_Entidades.SelectedRows.Count = 1 Then
                _Banco_detalle.Actual = _lista_bancos.Find(Function(x) x.id_banco = Dgv_Entidades.SelectedRows(0).Cells("id_banco").Value)
                animation_vertical.ShowSync(_Banco_detalle)
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If Dgv_Entidades.SelectedRows.Count = 1 Then


                pregunta_Frm.buttonColor = pregunta_Frm.colorOK.ROJO
                pregunta_Frm.Mensaje = "¿Eliminar el banco actual?"
                pregunta_Frm.ubicacion = Get_Control_Location(BtnEliminar, -175, 70)

                If pregunta_Frm.ShowDialog() = DialogResult.OK Then
                    _bancoAcceso.eliminacion_fisica(Dgv_Entidades.SelectedRows(0).Cells("id_banco").Value)
                    Cargar_datos()
                End If

            End If
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
