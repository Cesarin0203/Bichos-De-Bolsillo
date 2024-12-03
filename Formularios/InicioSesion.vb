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
            txt_Contasena.Enabled = False
        End Try
    End Sub


    Private Sub cmd_iniciasesion_Click(sender As Object, e As EventArgs) Handles cmdIniciarSesion.Click
        Try
            Usuario.IdApp = query.ValidarInicioSesion(Me.txt_Usuario.Text, Me.txt_Contasena.Text)
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
    End Sub
End Class