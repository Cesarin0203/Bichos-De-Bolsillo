Public Class Gimnasios
    Dim query As New Consultas
    Private Sub Gimnasios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraerInformacion(Usuario.UsuarioApp)
    End Sub

    Private Sub cmd_Atras_Click(sender As Object, e As EventArgs) Handles cmd_Atras.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "Close", MessageBoxButtons.OK)
        End Try
    End Sub
    Public Sub TraerInformacion(ByVal Usuario As String)
        Dim TablaMisGimnasios As DataTable = query.TraerMisGimnasios(Usuario)
        Dim Item As ListViewItem = Nothing
        For Each row As DataRow In TablaMisGimnasios.Rows
            Item = New ListViewItem(row("ID").ToString)
            Item.SubItems.Add(row("Nombre").ToString)
            Item.SubItems.Add(row("NombreLider").ToString)
            lv_TusGimnasios.Items.Add(Item)

        Next

        Dim TablaGimnasios As DataTable = query.TraerTodosGimnasios
        For Each row As DataRow In TablaGimnasios.Rows
            Item = New ListViewItem(row("ID").ToString)
            Item.SubItems.Add(row("Nombre").ToString)
            Item.SubItems.Add(row("NombreLider").ToString)
            lv_TodosLosGimnasios.Items.Add(Item)
        Next


    End Sub

    Private Sub liderar_Click(sender As Object, e As EventArgs) Handles liderar.Click
        If FormAbierto("LiderarNuevoGimnasio") = False Then
            Dim frm As New LiderarNuevoGimnasio
            frm.MdiParent = Bichos_De_Bolsillo
            frm.Show()
        End If
    End Sub
End Class