Public Class MisPokemones
    Dim query As New Consultas
    Private Sub cmd_Atras_Click(sender As Object, e As EventArgs) Handles cmd_Atras.Click
        Me.Close()
    End Sub
    Public Sub TraerInformacion()
        Dim TablaPokemones As DataTable = query.TraerMisPokemones(Usuario.IdApp)
        If TablaPokemones.Rows.Count = 0 Then
            Me.Close()
        End If
        Dim Item As ListViewItem = Nothing
        For Each row As DataRow In TablaPokemones.Rows
            Item = New ListViewItem(row("ID").ToString)
            Item.SubItems.Add(row("Nivel").ToString)
            Item.SubItems.Add(row("Evolucion").ToString)
            Item.SubItems.Add(row("Nombre").ToString)
            Item.SubItems.Add(row("Tipo").ToString)
            Item.SubItems.Add(row("Vida").ToString)
            Item.SubItems.Add(row("CombateMaximo").ToString)
            Item.SubItems.Add(row("Ataque").ToString)
            Item.SubItems.Add(row("Defensa").ToString)
            Item.SubItems.Add(row("ATKRAPIDO").ToString)
            Item.SubItems.Add(row("ATKCARGADO").ToString)
            lv_TodosMisPokemones.Items.Add(Item)
        Next
    End Sub

    Private Sub MisPokemones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraerInformacion()

    End Sub
End Class