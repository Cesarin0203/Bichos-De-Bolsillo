Public Class TextBoxPokemon
    Public Property TipoValidacion As TipoValidacionTextbox
    Public Property NombreTextBox As String

    Enum TipoValidacionTextbox
        Ninguna = 0
        Texto = 1
        Numero = 2
        NumeroDecimal = 3
        Correo = 4
        Alfanumerico = 5
        UsuarioOContraseña = 6
    End Enum

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub txt_textbox_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
        If Me.Enabled = True And Me.ReadOnly = False Then
            Me.SelectAll()
            CType(sender, TextBox).BackColor = Color.Moccasin
        End If
    End Sub

    Private Sub txt_textbox_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
        If Me.Enabled = True And Me.ReadOnly = False Then
            CType(sender, TextBox).BackColor = Color.White
        End If
    End Sub
    Function ValidaCampoBlanco() As Boolean
        If Me.Text.Trim = "" Then
            MsgBox(String.Format("El campo {0} no puede ir en blanco, favor de verificar.", NombreTextBox.ToUpper), MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Mensaje")
            Me.Focus()
            Return False
        End If
        Return True
    End Function

    Function ValidaCampoMayor0() As Boolean
        If IsNumeric(Me.Text.Trim) = True Then
            If CDec(Me.Text.Trim) <= 0 Then
                MsgBox(String.Format("El campo {0} debe ser mayor a 0, favor de verificar.", NombreTextBox.ToUpper), MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Mensaje")
                Me.Focus()
                Return False
            End If
        Else
            MsgBox(String.Format("El campo {0} tiene formato incorrecto, favor de verificar.", NombreTextBox.ToUpper), MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Mensaje")
            Me.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub txt_textbox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If TipoValidacion = TipoValidacionTextbox.Texto Then
            If "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz .".IndexOf(e.KeyChar) < 0 And AscW(e.KeyChar) <> Keys.Enter And AscW(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = Keys.Enter Then 'Para quitar el Beep (sonido) de windows al precionar enter en textbox que no es multilinea 
                e.Handled = True
            End If
        ElseIf TipoValidacion = TipoValidacionTextbox.Alfanumerico Then
            If "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz .,0123456789".IndexOf(e.KeyChar) < 0 And AscW(e.KeyChar) <> Keys.Enter And AscW(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = Keys.Enter Then 'Para quitar el Beep (sonido) de windows al precionar enter en textbox que no es multilinea 
                e.Handled = True
            End If
        ElseIf TipoValidacion = TipoValidacionTextbox.Numero Then
            If "0123456789".IndexOf(e.KeyChar) < 0 And AscW(e.KeyChar) <> Keys.Enter And AscW(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = Keys.Enter Then 'Para quitar el Beep (sonido) de windows al precionar enter en textbox que no es multilinea 
                e.Handled = True
            End If
        ElseIf TipoValidacion = TipoValidacionTextbox.NumeroDecimal Then
            If e.KeyChar = "." Then
                If Text.IndexOf(e.KeyChar) >= 0 Then
                    e.Handled = True
                End If
            End If

            If "0123456789.".IndexOf(e.KeyChar) < 0 And AscW(e.KeyChar) <> Keys.Enter And AscW(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If

            If Asc(e.KeyChar) = Keys.Enter Then 'Para quitar el Beep (sonido) de windows al precionar enter en textbox que no es multilinea 
                e.Handled = True
            End If
        ElseIf TipoValidacion = TipoValidacionTextbox.Ninguna Then
            If "|°!¡'?=*][{}+´:;^_<>~¨´@#&¿".IndexOf(e.KeyChar) > 0 And AscW(e.KeyChar) <> Keys.Enter And AscW(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = Keys.Enter Then 'Para quitar el Beep (sonido) de windows al precionar enter en textbox que no es multilinea 
                e.Handled = True
            End If
        ElseIf TipoValidacion = TipoValidacionTextbox.Correo Then
            If "|°!¡'?=*][{}+´:;^<>~¨´#¿".IndexOf(e.KeyChar) > 0 And AscW(e.KeyChar) <> Keys.Enter And AscW(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = Keys.Enter Then 'Para quitar el Beep (sonido) de windows al precionar enter en textbox que no es multilinea 
                e.Handled = True
            End If
        ElseIf TipoValidacion = TipoValidacionTextbox.UsuarioOContraseña Then
            If "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz.,0123456789".IndexOf(e.KeyChar) < 0 And AscW(e.KeyChar) <> Keys.Enter And AscW(e.KeyChar) <> Keys.Back Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = Keys.Enter Then 'Para quitar el Beep (sonido) de windows al precionar enter en textbox que no es multilinea 
                e.Handled = True
            End If
        End If

    End Sub
End Class
