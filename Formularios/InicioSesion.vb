Public Class InicioSesion
    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaConfiguracion()
        Catch ex As Exception
            lbConnectionStatus.Text = "Ocurrió un error con la conexión al servidor."
        End Try
    End Sub
End Class