Public Class LiderarNuevoGimnasio
    Dim query As New Consultas
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
End Class