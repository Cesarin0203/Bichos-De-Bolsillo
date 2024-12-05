Imports System.Runtime.InteropServices.JavaScript.JSType

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
        Return lConexion.Comando_Query($"insert into admin.Usuario (nombre, fecha_nacimiento, fecha_registro, contrasena) values ('{nombreUsuario}', '{fechaNacimiento}', '{currentDate}', '{contrasena}')")
    End Function

    Public Function GetUsuario(ByVal idUsuario As Integer) As DataTable
        Dim tabla As New DataTable
        tabla = lConexion.Adaptador_DataTable($"Select nombre, fecha_nacimiento, fecha_registro, contrasena, victorias, derrotas from admin.Usuario Where id = {idUsuario}")
        Return tabla
    End Function

    Public Function ModificarContrasena(ByVal idUsuario As String, ByVal nuevaContra As String) As Integer
        Return lConexion.Comando_Query($"Update admin.Usuario set contrasena = '{nuevaContra}' where id = {idUsuario}")
    End Function

    Public Function ModificarNombreUsuario(ByVal idUsuario As String, ByVal nombreUsuario As String) As Integer
        Return lConexion.Comando_Query($"Update admin.Usuario set nombre = '{nombreUsuario}' where id = {idUsuario}")
    End Function

    Public Function ModificarFechaNacUsuario(ByVal idUsuario As String, ByVal fechaNac As String) As Integer
        Return lConexion.Comando_Query($"Update admin.Usuario set fecha_nacimiento = '{fechaNac}' where id = {idUsuario}")
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
            MsgBox("No hay gimnasios", MsgBoxStyle.OkOnly, "Advertencia")
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
            MsgBox("No hay gimnasios para liderar", MsgBoxStyle.OkOnly, "Advertencia")
            Return tabla
        Else
            Return tabla
        End If
    End Function
    Public Function TraerTodosPokemones() As DataTable
        Dim tabla As New DataTable
        tabla = lConexion.Adaptador_DataTable($"select P.uuid as ID, E.ID_Evolucion as Evolucion,P.Nombre, T.Nombre as Tipo , AR.Nombre as ATKRAPIDO, AC.Nombre as ATKCARGADO From Pokemon P 
                inner JOIN atributo.ESPECIE E on P.ID_Especie = E.ID
                Inner JOIN atributo.TIPO T on E.ID_Tipo = T.ID
                Inner JOIN atributo.ATKCARGADO AC on E.ID_Atkcargado = AC.ID
                Inner JOIN atributo.ATKRAPIDO AR on E.ID_Atkrapido = AR.ID")
        If tabla.Rows.Count <= 0 Then
            MsgBox("No hay pokemones", MsgBoxStyle.OkOnly, "Advertencia")
            Return tabla
        Else
            Return tabla
        End If
    End Function
    Public Function TraerMisPokemones(ByVal ID As Integer) As DataTable
        Dim tabla As New DataTable
        tabla = lConexion.Adaptador_DataTable($"select P.uuid as ID,P.Nivel as Nivel, E.ID_Evolucion as Evolucion,P.Nombre, T.Nombre as Tipo ,P.Puntos_HP as Vida,P.Poder_CombateMax as CombateMaximo,P.Poder_Ataque as Ataque,P.Poder_Defensa as Defensa, AR.Nombre as ATKRAPIDO, AC.Nombre as ATKCARGADO 
                From Pokemon P 
                inner JOIN atributo.ESPECIE E on P.ID_Especie = E.ID
                Inner JOIN atributo.TIPO T on E.ID_Tipo = T.ID
                Inner JOIN atributo.ATKCARGADO AC on E.ID_Atkcargado = AC.ID
                Inner JOIN atributo.ATKRAPIDO AR on E.ID_Atkrapido = AR.ID
                WHERE P.ID_Usuario = {ID}")
        If tabla.Rows.Count <= 0 Then
            MsgBox("No cuentas con pokemones", MsgBoxStyle.OkOnly, "Advertencia")

            Return tabla
        Else
            Return tabla
        End If
    End Function

    Public Function TraerNidos() As DataTable
        Dim tabla As New DataTable
        tabla = lConexion.Adaptador_DataTable($"Select N.ID, N.Ubicacion, E.Nombre as Especie,R.Nombre as Region from jugabilidad.nido N
                inner join atributo.ESPECIE E on E.ID = N.ID_Especie
                inner join jugabilidad.region R on N.ID_Region = R.ID")
        If tabla.Rows.Count <= 0 Then
            MsgBox("No se encontraron nidos", MsgBoxStyle.OkOnly, "Advertencia")

            Return tabla
        Else
            Return tabla
        End If
    End Function
    Public Function TraerUsuariosListosParaCombate(ByVal IDUsuario As String) As DataTable
        Dim tabla As New DataTable
        tabla = lConexion.Adaptador_DataTable($"SELECT U.Nombre 
                FROM admin.Usuario U 
                INNER JOIN jugabilidad.Pokemon P ON U.ID = P.ID_Usuario 
                WHERE U.ID <> {IDUsuario} 
                GROUP BY U.Nombre, U.ID HAVING COUNT(P.uuid) >= 3;")
        If tabla.Rows.Count <= 0 Then
            MsgBox("No se encontraron nidos", MsgBoxStyle.OkOnly, "Advertencia")

            Return tabla
        Else
            Return tabla
        End If
    End Function
    Public Function TraerIdRival(ByVal NombreRival As String) As Integer
        Try
            Dim ID As Integer = 0
            Dim tabla As New DataTable
            tabla = lConexion.Adaptador_DataTable($"Select ID from admin.usuario Where Nombre = '{NombreRival}'")
            If tabla.Rows.Count > 0 Then

                ID = CInt(tabla.Rows(0)("ID").ToString.Trim)

            Else
                Throw New Exception("No se logró obtener ID")
            End If
            Return ID
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function TraerCombate(ByVal IDUsuario As Integer, ByVal IDRival As Integer) As Integer
        Try
            Dim Ganador As Integer = 0
            Dim tabla As New DataTable
            tabla = lConexion.Adaptador_DataTable($"Exec jugabilidad.sp_SimularCombatesEntreUsuarios {IDUsuario},{IDRival}")
            If tabla.Rows.Count > 0 Then

                Ganador = CInt(tabla.Rows(0)("Ganador").ToString.Trim)

            Else
                Throw New Exception("No se logró hacer el combate")
            End If
            Return Ganador
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
