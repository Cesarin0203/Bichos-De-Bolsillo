Public Class InicioSesion
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
End Class