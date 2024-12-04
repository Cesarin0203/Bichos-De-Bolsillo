Imports System.Transactions
Imports Microsoft.Data.SqlClient

Public Class LiderarNuevoGimnasio
    Dim query As New Consultas
    Enum EnumlvGimnasio
        ID = 0
        Nombre = 1

    End Enum
    Private Sub LiderarNuevoGimnasio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraerInformacion()
    End Sub
    Public Sub TraerInformacion()
        Dim TablaGimnasiosDisponibles As DataTable = query.TraerGimnasiosSinLider
        Dim Item As ListViewItem = Nothing
        For Each row As DataRow In TablaGimnasiosDisponibles.Rows
            Item = New ListViewItem(row("ID").ToString)
            Item.SubItems.Add(row("Nombre").ToString)
            Item.SubItems.Add(row("NombreLider").ToString)
            lv_TodosGimnasiosSinLider.Items.Add(Item)
        Next
    End Sub

    Private Sub cmd_Atras_Click(sender As Object, e As EventArgs) Handles cmd_Atras.Click
        Try
            Dim Gimnasio As New BD.Gimnasio

            'Se hace la transaccion
            lConexion.Transaccion = lConexion.Conexion.BeginTransaction
            For Each item As ListViewItem In lv_TodosGimnasiosSinLider.CheckedItems
                Gimnasio.ID = item.SubItems(EnumlvGimnasio.ID).Text.Trim
                Gimnasio.ID_Lider = Usuario.IdApp
                Gimnasio.ActualizarLider(lConexion.Transaccion)
            Next

            lConexion.Transaccion.Commit()
            lConexion.Transaccion.Dispose()
            MsgBox("Gimnasio liderado con exito", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Información")
            Me.Close()
        Catch ex As Exception
            lConexion.Transaccion.Rollback()
            lConexion.Transaccion.Dispose()
        End Try
    End Sub
End Class