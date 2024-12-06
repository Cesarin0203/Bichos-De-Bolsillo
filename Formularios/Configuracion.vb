Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Configuracion
    Dim query As New Consultas
    Private Sub cmd_Atras_Click(sender As Object, e As EventArgs) Handles cmd_Atras.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "Close", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarInfoUsuario()
    End Sub

    Private Function CargarInfoUsuario()
        Dim tablaInfoUsuario As New DataTable
        Try
            tablaInfoUsuario = query.GetUsuario(Usuario.IdApp)
            Usuario.UsuarioApp = tablaInfoUsuario.Rows(0)(0).ToString
            Usuario.FechaNac = tablaInfoUsuario.Rows(0)(1).ToString.Substring(0, 10)
            Usuario.FechaReg = tablaInfoUsuario.Rows(0)(2).ToString.Substring(0, 10)
            Usuario.ContrasenaApp = tablaInfoUsuario.Rows(0)(3).ToString
            Usuario.Victorias = Integer.Parse(tablaInfoUsuario.Rows(0)(4))
            Usuario.Derrotas = Integer.Parse(tablaInfoUsuario.Rows(0)(5))

            txtNombreUsuario.Text = Usuario.UsuarioApp
            pickerFechaNac.Value = stringToDate(Usuario.FechaNac)
            lbIdJugador.Text = lbIdJugador.Text & Usuario.IdApp.ToString
            lbFechaReg.Text = lbFechaReg.Text & Usuario.FechaReg
            lbVictorias.Text = lbVictorias.Text & Usuario.Victorias.ToString
            lbDerrotas.Text = lbDerrotas.Text & Usuario.Derrotas.ToString
        Catch ex As Exception
            MsgBox("Ocurrió un error al carga la información del jugador.", MsgBoxStyle.Information, "Error")
        End Try
    End Function

    Private Function stringToDate(ByVal fecha As String) As Date
        Dim fechaDate As New Date
        fechaDate = New Date(fecha.Substring(6, 4), fecha.Substring(3, 2), fecha.Substring(0, 2))
        Return fechaDate
    End Function

    Private Sub cmdEditarNombre_Click(sender As Object, e As EventArgs) Handles cmdEditarNombre.Click
        If cmdEditarNombre.Text = "Guardar" Then
            txtNombreUsuario.Enabled = False
            cmdEditarNombre.Text = "Editar"
            Try
                query.ModificarNombreUsuario(Usuario.IdApp, txtNombreUsuario.Text)
            Catch ex As Exception
                MsgBox("Ocurrió un error al guardar los cambios.", MsgBoxStyle.Information, "Error")
            End Try
        Else
            txtNombreUsuario.Enabled = True
            cmdEditarNombre.Text = "Guardar"
        End If
    End Sub

    Private Sub cmdEditarFecha_Click(sender As Object, e As EventArgs) Handles cmdEditarFecha.Click
        If cmdEditarFecha.Text = "Guardar" Then
            pickerFechaNac.Enabled = False
            cmdEditarFecha.Text = "Editar"
            Try
                query.ModificarFechaNacUsuario(Usuario.IdApp, pickerFechaNac.Value.ToString("yyyy-MM-dd"))
            Catch ex As Exception
                MsgBox("Ocurrió un error al guardar los cambios.", MsgBoxStyle.Information, "Error")
            End Try
        Else
            pickerFechaNac.Enabled = True
            cmdEditarFecha.Text = "Guardar"
        End If
    End Sub

    Private Sub cmdCambioContra_Click(sender As Object, e As EventArgs) Handles cmdCambioContra.Click
        Try
            If FormAbierto("CambioContrasena") = False Then
                Dim frm As New CambioContrasena
                frm.MdiParent = Bichos_De_Bolsillo
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Advertencia", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmdEliminarUsuario_Click(sender As Object, e As EventArgs) Handles cmdEliminarUsuario.Click
        If MessageBox.Show("¿Está seguro que desea eliminar su cuenta?" & vbLf & "Esta acción es irreversible", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                query.EliminarUsuario(Usuario.IdApp)
                MsgBox("La cuenta ha sido borrada exitosamente.", MessageBoxButtons.OK)
                Usuario.clear()

                If InicioSesion.OpenPantallaPrincipal IsNot Nothing Then
                    InicioSesion.OpenPantallaPrincipal.Close()
                    InicioSesion.OpenPantallaPrincipal = Nothing ' Clean up the reference
                End If

                My.Forms.MenuPrincipal.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("Ocurrió un error eliminar la cuenta.", MsgBoxStyle.Information, "Error")
            End Try
        End If
    End Sub
End Class