Imports System.IO

Public Module DeclaracionFunciones
    Public Usuario As New Usuario
    Public lConexion As Conexion
    Public Menu_Principal As MenuPrincipal

    Public Function CargaConfiguracion() As Integer
        Usuario.Servidor = "erick-server.database.windows.net"
        Usuario.UsuarioBD = "jugador1"
        Usuario.ContraseñaBD = "%12player34"
        Usuario.BD = "Pokemon"

        lConexion = New Conexion(Usuario.Servidor, Usuario.UsuarioBD, Usuario.ContraseñaBD, Usuario.BD)
        Return 1
    End Function
End Module
