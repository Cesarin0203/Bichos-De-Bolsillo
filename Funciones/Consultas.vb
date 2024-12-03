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

    Public Function RegistrarUsuario(ByVal nombreUsuario As String, ByVal contrasena As String, ByVal fechaNacimiento As String) As Integer
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
        Try
            Return lConexion.Comando_Query($"insert into admin.Usuario (nombre, fecha_nacimiento, fecha_registro, contrasena) values ({nombreUsuario}, {fechaNacimiento}, {currentDate}, {contrasena})")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function TraerMisGimnasios(ByVal Usuario As String) As DataTable
        Dim tabla As New DataTable
        tabla = lConexion.Adaptador_DataTable($"  Select G.ID,G.Nombre,U.Nombre as NombreLider from GIMNASIO G
                  INNER JOIN admin.USUARIO U ON G.ID_Lider = U.ID
                  WHERE U.Nombre = '{Usuario}'")
        If tabla.Rows.Count <= 0 Then
            Return tabla
        Else
            Return tabla
        End If
    End Function
    Public Function TraerTodosGimnasios() As DataTable
        Dim tabla As New DataTable
        tabla = lConexion.Adaptador_DataTable($"SELECT G.ID, G.Nombre, 
               CASE 
               WHEN G.ID_Lider IS NULL THEN 'Sin Lider' 
               ELSE U.Nombre 
               END AS NombreLider 
               FROM GIMNASIO G 
               LEFT JOIN admin.USUARIO U ON G.ID_Lider = U.ID")
        If tabla.Rows.Count <= 0 Then
            MsgBox("No hay gimnasios", "Close", MessageBoxButtons.OK)
            Return tabla
        Else
            Return tabla
        End If
    End Function
    Public Function TraerGimnasiosSinLider() As DataTable
        Dim tabla As New DataTable
        tabla = lConexion.Adaptador_DataTable($"SELECT G.ID, G.Nombre, CASE 
                WHEN ID_Lider IS NULL THEN 'Sin Lider'  END AS NombreLider 
                FROM GIMNASIO G 
                WHERE ID_Lider IS NULL")
        If tabla.Rows.Count <= 0 Then
            MsgBox("No hay gimnasios para liderar", "Close", MessageBoxButtons.OK)
            Return tabla
        Else
            Return tabla
        End If
    End Function
End Class
