Public Class RegistroUsuario
    Dim query As New Consultas
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        InicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If txt_Contrasena.Text <> "" And txt_Usuario.Text <> "" Then
            Try
                query.RegistrarUsuario(txt_Usuario.Text, txt_Contrasena.Text, pickerFechaNac.Value.ToString("yyyy-MM-dd"))
                MsgBox("El usuario se registró correctamente. Proceda a iniciar sesión.", MsgBoxStyle.OkOnly, "Registro exitoso")
                InicioSesion.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "")
            End Try
        Else
            MsgBox("El usuario y/o contraseña no pueden estar vacíos.", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub RegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbConnectionStatus.Text = "Conexión establecida con el servidor"
    End Sub
End Class