Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class IniciarBatalla
    Dim query As New Consultas
    Private Sub cmd_Atras_Click(sender As Object, e As EventArgs) Handles cmd_Atras.Click
        Me.Close()
    End Sub

    Private Sub IniciarBatalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraerInformacion()
    End Sub

    Public Sub TraerInformacion()
        lbl_TuUsuario.Text = Usuario.UsuarioApp

        Dim tabla As DataTable = query.TraerUsuariosListosParaCombate(Usuario.IdApp)
        For Each row As DataRow In tabla.Rows
            cb_rivales.Items.Add(row("Nombre").ToString)
        Next
    End Sub

    Private Sub cmd_Iniciar_Click(sender As Object, e As EventArgs) Handles cmd_Iniciar.Click
        If cb_rivales.SelectedIndex = -1 Then
            MsgBox("Seleccione un rival", MsgBoxStyle.OkOnly, "Advertencia")
        End If
        Dim IDRival As Integer = query.TraerIdRival(cb_rivales.Text)
        Dim Ganador As Integer = query.TraerCombate(CInt(Usuario.IdApp), IDRival)
        lbl_Resultado.Visible = True
        If Ganador = 1 Then
            lbl_Resultado.Text = "GANADOR!!!"
            lbl_Resultado.ForeColor = Color.Green
        Else
            lbl_Resultado.Text = "PERDEDOR :("
            lbl_Resultado.ForeColor = Color.Red
        End If
    End Sub
End Class