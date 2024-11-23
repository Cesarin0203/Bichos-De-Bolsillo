
Imports Microsoft.Data.SqlClient
Public Class Conexion
    Public Class Item_Query

        Sub New(ByVal sColumna As String, ByVal sValor As Object, ByVal bEntre_Comillas As Boolean)
            Columna = sColumna
            Valor = sValor
            Entre_Comillas = bEntre_Comillas
        End Sub

        Public Property Columna As String
        Public Property Valor As Object
        Public Property Entre_Comillas As Boolean

    End Class

    Public Class Parametros
        Public Shared Property Servidor As String = ""
        Public Shared Property Usuario As String = ""
        Public Shared Property Password As String = ""
        Public Shared Property Base_Datos As String = ""

    End Class


    Public WithEvents Conexion As SqlConnection = Nothing
    Public WithEvents Comando As SqlCommand = Nothing
    Public WithEvents Adaptador As SqlDataAdapter = Nothing
    Public WithEvents Transaccion As SqlTransaction = Nothing
    Sub New(ByVal strServidor As String, ByVal strUsuario As String, ByVal strPassword As String, ByVal strBase_Datos As String)
        Parametros.Servidor = strServidor
        Parametros.Usuario = strUsuario
        Parametros.Password = strPassword
        Parametros.Base_Datos = strBase_Datos
        Conexion = New SqlConnection()
        'Conexion.ConnectionString = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};MultipleActiveResultSets=True", strServidor, strBase_Datos, strUsuario, strPassword)
        Conexion.ConnectionString = String.Format("server={0};Initial Catalog={1};Persist Security Info=True;TrustServerCertificate=False;User ID={2};Password={3};MultipleActiveResultSets=True",
            strServidor,
            strBase_Datos,
            strUsuario,
            strPassword)
    End Sub
    Public Function TestConexion() As Boolean
        Try
            Conexion.Open()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Function Comando_Query(ByVal SQL As String) As Integer
        Try
            Dim comando As New SqlCommand(SQL, lConexion.Conexion, lConexion.Transaccion)
            Return comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function Comando_Query(ByVal SQL As String, ByVal Transaccion As SqlTransaction) As Integer
        Try
            Dim comando As New SqlCommand(SQL, lConexion.Conexion, Transaccion)
            Return comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function Adaptador_DataSet(ByVal Comando_SQL As String) As DataSet
        Try
            Dim Adaptador_TMP As New SqlDataAdapter(Comando_SQL, lConexion.Conexion)
            Dim DS As New DataSet
            Adaptador_TMP.Fill(DS)
            Adaptador_TMP.Dispose()
            Adaptador_TMP = Nothing
            Return DS
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function Adaptador_DataTable(ByVal Comando_SQL As String) As DataTable
        Try
            Dim Adaptador_TMP As New SqlDataAdapter(Comando_SQL, lConexion.Conexion)
            Dim Tabla As New DataTable
            Adaptador_TMP.Fill(Tabla)
            Adaptador_TMP.Dispose()
            Adaptador_TMP = Nothing
            Return Tabla
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function Adaptador_DataTable(ByVal Comando_SQL As String, ByVal Transaccion As SqlTransaction) As DataTable
        Try
            Dim Adaptador_TMP As New SqlDataAdapter(Comando_SQL, lConexion.Conexion)
            Dim Tabla As New DataTable
            Adaptador_TMP.SelectCommand.Transaction = Transaccion
            Adaptador_TMP.SelectCommand.CommandTimeout = 1000
            Adaptador_TMP.Fill(Tabla)
            Adaptador_TMP.Dispose()
            Adaptador_TMP = Nothing
            Return Tabla
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


End Class
