Public Class Nidos
    Dim query As New Consultas
    Private Sub Nidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraerInformacion()

    End Sub
    Public Sub TraerInformacion()
        Dim TablaNidos As DataTable = query.TraerNidos
        If TablaNidos.Rows.Count = 0 Then
            Me.Close()
        End If
        Dim Item As ListViewItem = Nothing
        For Each row As DataRow In TablaNidos.Rows
            Item = New ListViewItem(row("ID").ToString)
            Item.SubItems.Add(row("Ubicacion").ToString)
            Item.SubItems.Add(row("Especie").ToString)
            Item.SubItems.Add(row("Region").ToString)
            lv_Nidos.Items.Add(Item)
        Next
    End Sub

    Private Sub cmd_Atras_Click(sender As Object, e As EventArgs) Handles cmd_Atras.Click
        Me.Close()
    End Sub
End Class