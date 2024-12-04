Public Class PantallaPrincipal
    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Bienvenida.Text = "Hola, " & Usuario.UsuarioApp
    End Sub
    Private Sub OnFormClose(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Desea salir de la aplicacion", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        Else
            'My.Forms.MenuPrincipal.Show()
            My.Forms.MenuPrincipal.Close()
        End If
    End Sub

    Private Sub cmd_Gimnasio_Click(sender As Object, e As EventArgs) Handles cmd_Gimnasio.Click
        Try
            If FormAbierto("Gimnasios") = False Then
                Dim frm As New Gimnasios
                frm.MdiParent = Bichos_De_Bolsillo
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Close", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmd_Pokedex_Click(sender As Object, e As EventArgs) Handles cmd_Pokedex.Click
        Try
            If FormAbierto("Pokedex") = False Then
                Dim frm As New Pokedex
                frm.MdiParent = Bichos_De_Bolsillo
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Advertencia", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmd_Configuracion_Click(sender As Object, e As EventArgs) Handles cmd_Configuracion.Click
        Try
            If FormAbierto("Configuracion") = False Then
                Dim frm As New Configuracion
                frm.MdiParent = Bichos_De_Bolsillo
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Advertencia", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmd_MisPokemones_Click(sender As Object, e As EventArgs) Handles cmd_MisPokemones.Click
        Try
            If FormAbierto("MisPokemones") = False Then
                Dim frm As New MisPokemones
                frm.MdiParent = Bichos_De_Bolsillo
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Advertencia", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmd_Nidos_Click(sender As Object, e As EventArgs) Handles cmd_Nidos.Click
        Try
            If FormAbierto("Nidos") = False Then
                Dim frm As New Nidos
                frm.MdiParent = Bichos_De_Bolsillo
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Advertencia", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Cmd_InciarBatalla_Click(sender As Object, e As EventArgs) Handles Cmd_InciarBatalla.Click
        Try
            If FormAbierto("IniciarBatalla") = False Then
                Dim frm As New IniciarBatalla
                frm.MdiParent = Bichos_De_Bolsillo
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Advertencia", MessageBoxButtons.OK)
        End Try
    End Sub
End Class