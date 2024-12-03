Public Class Pokedex
    Dim query As New Consultas
    Private Sub Pokedex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraerInformacion()
    End Sub

    Public Sub TraerInformacion()
        Dim TablaPokemones As DataTable = query.TraerTodosPokemones
        Dim Item As ListViewItem = Nothing
        For Each row As DataRow In TablaPokemones.Rows
            Item = New ListViewItem(row("ID").ToString)
            Item.SubItems.Add(row("Evolucion").ToString)
            Item.SubItems.Add(row("Nombre").ToString)
            Item.SubItems.Add(row("Tipo").ToString)
            Item.SubItems.Add(row("ATKRAPIDO").ToString)
            Item.SubItems.Add(row("ATKCARGADO").ToString)
            lv_TodosLosPokemones.Items.Add(Item)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class