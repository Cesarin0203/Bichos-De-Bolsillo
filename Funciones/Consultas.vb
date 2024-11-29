Public Class Consultas

    Public Function ValidarInicioSesion(ByVal nombreUsuario As String, ByVal contrasena As String) As Integer
        Dim tabla As New DataTable
        tabla = lConexion.Adaptador_DataTable($"Select id from admin.Usuario Where Nombre = '{nombreUsuario}' and Contrasena = '{contrasena}'")
        If tabla.Rows.Count <= 0 Then
            Throw New Exception("El usuario o la contraseña son incorrectos")
            Return -1
        ElseIf tabla.Rows.Count = 1 Then
            Return Integer.Parse(tabla.Rows(0)(0).ToString)
        Else
            Throw New Exception("Hubo un problema al iniciar sesión. Intente de nuevo más tarde")
            Return -1
        End If
    End Function
End Class
