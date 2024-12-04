Public Class CambioContrasena
    Dim query As New Consultas
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If txtContrasenaActual.Text = Usuario.ContrasenaApp Then
            If txtContrasenaNueva.Text = txtContrasenaComf.Text Then
                Try
                    query.ModificarContrasena(Usuario.IdApp, txtContrasenaNueva.Text)
                    MsgBox("La contraseña ha sido cambiada exitosamente.", MsgBoxStyle.Information, "")
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Ocurrió un error al guardar los cambios.", MsgBoxStyle.Information, "Error")
                End Try
            Else
                MsgBox("Las nuevas contraseñas no coinciden.", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("La contraseña actual no es correcta.", MsgBoxStyle.Information, "Error")
        End If
    End Sub
End Class