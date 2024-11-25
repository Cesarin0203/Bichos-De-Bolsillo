Public Class Consultas

    Public Function ValidarIncioSesion(ByVal NombreUsuario As String, ByVal Contraseña As String) As Boolean
        Dim tabla As New DataTable
        Try
            tabla = lConexion.Adaptador_DataTable($"Select * from Usuarios Where Nombre = {NombreUsuario} and Contrasena = {Contraseña}")
            If tabla.Rows.Count <= 0 Then
                Throw New Exception("El Usuario o la Contraseña son incorrectos")
                Return False
            ElseIf tabla.Rows.Count < 1 Then
                Return True
            Else
                Throw New Exception("Hubo un problema al establecer la conexion, intentelo mas tarde")
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
