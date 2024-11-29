Imports System.Runtime.InteropServices.JavaScript.JSType
Imports Microsoft.Data.SqlClient

Public Class BD

    Public Class Pokemon

        Property uuid As Integer = 0
        Property Nivel As Integer = 0
        Property Nombre As String = ""
        Property Poder_CombateMax As Integer = 0
        Property Poder_Ataque As Integer = 0
        Property Poder_Defensa As Integer = 0
        Property Puntos_HP As Integer = 0
        Property ID_Especie As Integer = 0
        Property ID_Usuario As Integer = 0


        'INSERT
        Public Function Guardar(ByVal Transaccion As SqlTransaction) As Boolean
            Try
                If Transaccion IsNot Nothing Then
                    If lConexion.Comando_Query($"Insert into Pokemon values ('{uuid}','{Nivel}','{Nombre}','{Poder_CombateMax}',{Poder_Ataque},'{Poder_Defensa}','{Puntos_HP}','{ID_Especie}','{ID_Usuario}')", Transaccion) <= 0 Then
                        Throw New Exception("Ocurrio un error al guardar el producto")
                    End If
                Else
                    If lConexion.Comando_Query($"Insert into Pokemon values  ('{uuid}','{Nivel}','{Nombre}','{Poder_CombateMax}',{Poder_Ataque},'{Poder_Defensa}','{Puntos_HP}','{ID_Especie}','{ID_Usuario}')") <= 0 Then
                        Throw New Exception("Ocurrio un error al guardar el producto")
                    End If
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function


        'UPDATE
        Public Function Actualizar(ByVal Transaccion As SqlTransaction) As Boolean
            Try
                If Transaccion IsNot Nothing Then
                    If lConexion.Comando_Query($"update Pokemon set uuid ='{uuid}',Nivel='{Nivel}',Nombre='{Nombre}',Poder_CombateMax={Poder_CombateMax},Poder_Ataque='{Poder_Ataque}',Poder_Defensa='{Poder_Defensa}',Puntos_HP='{Puntos_HP}',ID_Especie='{ID_Especie}',ID_Usuario={ID_Usuario} where uuid = {uuid}", Transaccion) <= 0 Then
                        Throw New Exception("Ocurrio un error al actualizar el producto")
                    End If
                Else
                    If lConexion.Comando_Query($"update Pokemon set uuid ='{uuid}',Nivel='{Nivel}',Nombre='{Nombre}',Poder_CombateMax={Poder_CombateMax},Poder_Ataque='{Poder_Ataque}',Poder_Defensa='{Poder_Defensa}',Puntos_HP='{Puntos_HP}',ID_Especie='{ID_Especie}',ID_Usuario={ID_Usuario} where uuid = {uuid}") <= 0 Then
                        Throw New Exception("Ocurrio un error al actualizar el producto")
                    End If
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function


        'DELETE
        Public Function Eliminar() As Boolean
            Try
                If lConexion.Comando_Query($"delete Pokemon where uuid = {uuid})") <= 0 Then
                    Throw New Exception("Ocurrio un error al eliminar el producto")
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

    End Class

    Public Class Usuario

        Property ID As Integer = 0
        Property Nombre As String = ""
        Property Fecha_Nacimiento As Date = ""
        Property Fecha_Registro As Date = ""
        Property Contrasena As String = ""
        Property Victorias As Integer = 0
        Property Derrotas As Integer = 0

        'INSERT
        Public Function Guardar(ByVal Transaccion As SqlTransaction) As Boolean
            Try
                If Transaccion IsNot Nothing Then
                    If lConexion.Comando_Query($"Insert into Usuario values ('{ID}','{Nombre}','{Nombre}','{Fecha_Nacimiento}',{Fecha_Registro},'{Contrasena}','{Victorias}','{Derrotas}')", Transaccion) <= 0 Then
                        Throw New Exception("Ocurrio un error al guardar el producto")
                    End If
                Else
                    If lConexion.Comando_Query($"Insert into Usuario values  ('{ID}','{Nombre}','{Nombre}','{Fecha_Nacimiento}',{Fecha_Registro},'{Contrasena}','{Victorias}','{Derrotas}')") <= 0 Then
                        Throw New Exception("Ocurrio un error al guardar el producto")
                    End If
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function


        'UPDATE
        Public Function Actualizar(ByVal Transaccion As SqlTransaction) As Boolean
            Try
                If Transaccion IsNot Nothing Then
                    If lConexion.Comando_Query($"update Usuario set ID ='{ID}',Nombre='{Nombre}',Fecha_Nacimiento='{Fecha_Nacimiento}',Fecha_Registro={Fecha_Registro},Contrasena='{Contrasena}',Victorias='{Victorias}',Derrotas='{Derrotas} where ID = {ID}", Transaccion) <= 0 Then
                        Throw New Exception("Ocurrio un error al actualizar el producto")
                    End If
                Else
                    If lConexion.Comando_Query($"update Usuario set ID ='{ID}',Nombre='{Nombre}',Fecha_Nacimiento='{Fecha_Nacimiento}',Fecha_Registro={Fecha_Registro},Contrasena='{Contrasena}',Victorias='{Victorias}',Derrotas='{Derrotas} where ID = {ID}") <= 0 Then
                        Throw New Exception("Ocurrio un error al actualizar el producto")
                    End If
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'DELETE
        Public Function Eliminar() As Boolean
            Try
                If lConexion.Comando_Query($"delete Usuario where ID = {ID})") <= 0 Then
                    Throw New Exception("Ocurrio un error al eliminar el producto")
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
    End Class

    Public Class Gimnasio

        Property ID As Integer = 0
        Property Nombre As String = ""
        Property ID_Lider As Integer = 0
        Property Ubicacionx As Decimal = 0
        Property Ubicaciony As Decimal = 0

        'INSERT
        Public Function Guardar(ByVal Transaccion As SqlTransaction) As Boolean
            Try
                If Transaccion IsNot Nothing Then
                    If lConexion.Comando_Query($"Insert into Gimnasio values ('{ID}','{Nombre}','{ID_Lider}',{Ubicacionx},'{Ubicaciony}')", Transaccion) <= 0 Then
                        Throw New Exception("Ocurrio un error al guardar el producto")
                    End If
                Else
                    If lConexion.Comando_Query($"Insert into Gimnasio values  ('{ID}','{Nombre}','{ID_Lider}',{Ubicacionx},'{Ubicaciony}')") <= 0 Then
                        Throw New Exception("Ocurrio un error al guardar el producto")
                    End If
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'UPDATE
        Public Function Actualizar(ByVal Transaccion As SqlTransaction) As Boolean
            Try
                If Transaccion IsNot Nothing Then
                    If lConexion.Comando_Query($"update Gimnasio set ID ='{ID}',Nombre='{Nombre}',ID_Lider='{ID_Lider}',Ubicacionx={Ubicacionx},Ubicaciony='{Ubicaciony} where ID = {ID}", Transaccion) <= 0 Then
                        Throw New Exception("Ocurrio un error al actualizar el producto")
                    End If
                Else
                    If lConexion.Comando_Query($"update Gimnasio set ID ='{ID}',Nombre='{Nombre}',ID_Lider='{ID_Lider}',Ubicacionx={Ubicacionx},Ubicaciony='{Ubicaciony} where ID = {ID}") <= 0 Then
                        Throw New Exception("Ocurrio un error al actualizar el producto")
                    End If
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'DELETE
        Public Function Eliminar() As Boolean
            Try
                If lConexion.Comando_Query($"delete Gimnasio where ID = {ID})") <= 0 Then
                    Throw New Exception("Ocurrio un error al eliminar el producto")
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
    End Class

    Public Class MetodoPago

        Property ID_Usuario As Integer = 0
        Property Numero As Integer = 0
        Property Fecha_Vencimiento As Date = ""
        Property CVV As Integer = 0


        'INSERT
        Public Function Guardar(ByVal Transaccion As SqlTransaction) As Boolean
            Try
                If Transaccion IsNot Nothing Then
                    If lConexion.Comando_Query($"Insert into MetodoPago values ('{ID_Usuario}','{Numero}','{Fecha_Vencimiento}',{CVV}')", Transaccion) <= 0 Then
                        Throw New Exception("Ocurrio un error al guardar el producto")
                    End If
                Else
                    If lConexion.Comando_Query($"Insert into MetodoPago values  ('{ID_Usuario}','{Numero}','{Fecha_Vencimiento}',{CVV}')") <= 0 Then
                        Throw New Exception("Ocurrio un error al guardar el producto")
                    End If
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'UPDATE
        Public Function Actualizar(ByVal Transaccion As SqlTransaction) As Boolean
            Try
                If Transaccion IsNot Nothing Then
                    If lConexion.Comando_Query($"update MetodoPago set ID_Usuario ='{ID_Usuario}',Numero='{Numero}',Fecha_Vencimiento='{Fecha_Vencimiento}',CVV={CVV} where ID_Usuario = {ID_Usuario}", Transaccion) <= 0 Then
                        Throw New Exception("Ocurrio un error al actualizar el producto")
                    End If
                Else
                    If lConexion.Comando_Query($"update MetodoPago set ID_Usuario ='{ID_Usuario}',Numero='{Numero}',Fecha_Vencimiento='{Fecha_Vencimiento}',CVV={CVV} where ID_Usuario = {ID_Usuario}") <= 0 Then
                        Throw New Exception("Ocurrio un error al actualizar el producto")
                    End If
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'DELETE
        Public Function Eliminar() As Boolean
            Try
                If lConexion.Comando_Query($"delete MetodoPago where ID_Usuario = {ID_Usuario})") <= 0 Then
                    Throw New Exception("Ocurrio un error al eliminar el producto")
                End If
                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
    End Class


End Class













