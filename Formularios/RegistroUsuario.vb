Public Class RegistroUsuario
    Dim query As New Consultas
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        InicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            query.RegistrarUsuario(txt_Usuario.Text, txt_Contrasena.Text, FecNacPicker.ToString("yyyy-MM-dd"))
            MsgBox("El usuario se registró correctamente. Proceda a iniciar sesión.", MsgBoxStyle.OkOnly, "Registro exitoso")
            InicioSesion.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "")
        End Try

    End Sub
End Class