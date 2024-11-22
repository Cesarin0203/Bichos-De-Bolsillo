Imports System.IO

Public Module DeclaracionFunciones
    Public Usuario As New Usuario
    Public lConexion As Conexion
    Public Menu_Principal As MenuPrincipal

    Public Function CargaConfiguracion() As Conexion
        Usuario.Servidor = "erick-server.database.windows.net"
        Usuario.UsuarioBD = "Erick2254"
        Usuario.ContraseñaBD = "Evangelion01"
        Usuario.BD = "Pokemon"

        lConexion = New Conexion(Usuario.Servidor, Usuario.UsuarioBD, Usuario.ContraseñaBD, Usuario.BD)
        Return lConexion
    End Function
End Module
