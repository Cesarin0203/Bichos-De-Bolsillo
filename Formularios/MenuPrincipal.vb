﻿Public Class MenuPrincipal
    Private Sub cmd_Empezar_Click(sender As Object, e As EventArgs) Handles cmd_Empezar.Click
        If FormAbierto("InicioSesion") = False Then
            Dim frm As New InicioSesion
            frm.MdiParent = Bichos_De_Bolsillo
            frm.Show()
            '' Me.Close()
        End If

    End Sub
End Class