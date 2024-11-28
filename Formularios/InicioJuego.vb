Public Class InicioJuego
    Private Sub OnFormClose(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        Else
            'My.Forms.MenuPrincipal.Show()
            My.Forms.MenuPrincipal.Close()
        End If
    End Sub
End Class