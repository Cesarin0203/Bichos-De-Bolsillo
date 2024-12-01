Imports System.Drawing.Text
Public Class MenuPrincipal
    Private Sub cmd_Empezar_Click(sender As Object, e As EventArgs) Handles cmd_Empezar.Click
        Me.ResizeRedraw = True
        If FormAbierto("InicioSesion") = False Then
            Dim frm As New InicioSesion
            frm.MdiParent = Bichos_De_Bolsillo
            frm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarFuente()
    End Sub

    Private Sub CargarFuente()

    End Sub
End Class