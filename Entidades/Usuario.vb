Public Module Usuario
    Public Property Servidor As String = ""
    Public Property ContraseñaBD As String = ""
    Public Property UsuarioBD As String = ""
    Public Property BD As String = ""
    Public Property IdApp As Integer = 0
    Public Property UsuarioApp As String = ""
    Public Property FechaNac As String = ""
    Public Property FechaReg As String = ""
    Public Property Victorias As Integer = 0
    Public Property Derrotas As Integer = 0
    Public Property ContrasenaApp As String = ""

    Public Function clear()
        IdApp = 0
        UsuarioApp = ""
        FechaNac = ""
        FechaReg = ""
        Victorias = 0
        Derrotas = 0
        ContrasenaApp = ""
    End Function
End Module
