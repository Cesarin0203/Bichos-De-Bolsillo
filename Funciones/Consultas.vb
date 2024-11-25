Public Class Consultas

    Public Function ValidarInicioSesion(ByVal nombreUsuario As String, ByVal contrasena As String) As Boolean
        Dim tabla As New DataTable
        Try
            tabla = lConexion.Adaptador_DataTable($"Select id from admin.Usuario Where Nombre = '{nombreUsuario}' and Contrasena = '{contrasena}'")
            If tabla.Rows.Count <= 0 Then
                Throw New Exception("El usuario o la contraseña son incorrectos")
                Return False
            ElseIf tabla.Rows.Count = 1 Then
                Return True
            Else
                Throw New Exception("Hubo un problema al iniciar sesión. Intente de nuevo más tarde")
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
