Public Class MenuPrincipal
    Private Sub cmd_Empezar_Click(sender As Object, e As EventArgs) Handles cmd_Empezar.Click
        If FormAbierto("InicioSesion") = False Then
            Dim frm As New InicioSesion
            frm.MdiParent = Bichos_De_Bolsillo
            frm.Show()

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class