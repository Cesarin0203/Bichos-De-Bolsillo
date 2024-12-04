Public Class InicioSesion
    Dim query As New Consultas
    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaConfiguracion()

        Try
            lConexion.Conexion.Open()
            lbConnectionStatus.Text = "Conexión establecida con el servidor"
        Catch ex As Exception
            lbConnectionStatus.Text = "Ocurrió un error de conexión. Intente de nuevo más tarde"
            txt_Usuario.Enabled = False
            txt_Contrasena.Enabled = False
        End Try
    End Sub

    Private Sub OnFormClose(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.MenuPrincipal.Show()
    End Sub


    Private Sub cmd_iniciasesion_Click(sender As Object, e As EventArgs) Handles cmdIniciarSesion.Click
        If txt_Contrasena.Text <> "" And txt_Usuario.Text <> "" Then
            Try
                Usuario.IdApp = query.ValidarInicioSesion(Me.txt_Usuario.Text, Me.txt_Contrasena.Text)
                If Not (Usuario.IdApp = -1) Then
                    Usuario.UsuarioApp = Me.txt_Usuario.Text
                    'Usuario.ContrasenaApp = Me.txt_Contrasena.Text
                    lbConnectionStatus.Text = $"Inicio de sesión exitoso. Id = {Usuario.IdApp}"
                    If FormAbierto("PantallaPrincipal") = False Then
                        Dim frm As New PantallaPrincipal
                        'frm.MdiParent = My.Forms.MenuPrincipal
                        frm.Show()
                        Me.Close()
                        My.Forms.MenuPrincipal.Hide()
                    End If
                Else
                    lbConnectionStatus.Text = "Ocurrió un error al intentar acceder."
                End If
            Catch ex As Exception
                lbConnectionStatus.Text = ex.Message
            End Try
        Else
            MsgBox("El usuario y/o contraseña no pueden estar vacíos.", MsgBoxStyle.Information, "Error")
        End If


    End Sub

    Private Sub cmdRegistrarse_Click(sender As Object, e As EventArgs) Handles cmdRegistrarse.Click
        If FormAbierto("RegistroUsuario") = False Then
            Dim frm As New RegistroUsuario
            'frm.MdiParent = My.Forms.InicioSesion
            frm.Show()
            Me.Hide()
        End If
    End Sub
End Class