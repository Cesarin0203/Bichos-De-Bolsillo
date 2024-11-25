Imports System.IO

Public Module DeclaracionFunciones
    Public lConexion As Conexion
    Public Menu_Principal As MenuPrincipal

    Public Function CargaConfiguracion() As Boolean
        Try

            Usuario.Servidor = "erick-server.database.windows.net"
            Usuario.UsuarioBD = "jugador1"
            Usuario.ContraseñaBD = "%12player34"
            Usuario.BD = "Pokemon"

            lConexion = New Conexion(Usuario.Servidor, Usuario.UsuarioBD, Usuario.ContraseñaBD, Usuario.BD)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
