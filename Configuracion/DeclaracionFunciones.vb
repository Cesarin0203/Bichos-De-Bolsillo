Imports System.IO

Public Module DeclaracionFunciones
    Public Usuario As New Usuario
    Public lConexion As Conexion
    Public Menu_Principal As MenuPrincipal

    Public Function CargaConfiguracion() As Boolean
        Dim Archivo As StreamReader
        Try
            If Dir(My.Application.Info.DirectoryPath & "\Configuracion.txt") <> "" Then
                Archivo = New StreamReader(My.Application.Info.DirectoryPath & "\Configuracion.txt")
                Usuario.ServidorOficina = Mid(Archivo.ReadLine(), 21).Trim
                Usuario.UsuarioBD = "sa"
                Usuario.ContraseñaBD = "Lock2020"
                Usuario.BD = "PingEquipo"

                Archivo.Close()
                If Usuario.ServidorOficina = "" Then
                    MsgBox("Error en el archivo de configuración, favor de llamar a sistemas.", MsgBoxStyle.Critical Or MsgBoxStyle.OkCancel, "Error")
                    Return False
                End If
            Else
                MsgBox("No existe el archivo de configuración, favor de llamar a sistemas.", MsgBoxStyle.Critical Or MsgBoxStyle.OkCancel, "Error")
                Return False
            End If
            lConexion = New Conexion(Usuario.ServidorOficina, Usuario.UsuarioBD, Usuario.ContraseñaBD, Usuario.BD)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Return False
        End Try
    End Function
End Module
