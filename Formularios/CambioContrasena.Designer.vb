<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioContrasena
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtContrasenaActual = New TextBox()
        Label2 = New Label()
        txtContrasenaNueva = New TextBox()
        Label1 = New Label()
        txtContrasenaComf = New TextBox()
        Label3 = New Label()
        cmdAceptar = New Button()
        cmdCancelar = New Button()
        SuspendLayout()
        ' 
        ' txtContrasenaActual
        ' 
        txtContrasenaActual.Location = New Point(37, 59)
        txtContrasenaActual.Margin = New Padding(3, 2, 3, 2)
        txtContrasenaActual.Name = "txtContrasenaActual"
        txtContrasenaActual.Size = New Size(256, 23)
        txtContrasenaActual.TabIndex = 1
        txtContrasenaActual.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(37, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 22)
        Label2.TabIndex = 0
        Label2.Text = "Contraseña actual:"
        ' 
        ' txtContrasenaNueva
        ' 
        txtContrasenaNueva.Location = New Point(37, 132)
        txtContrasenaNueva.Margin = New Padding(3, 2, 3, 2)
        txtContrasenaNueva.Name = "txtContrasenaNueva"
        txtContrasenaNueva.Size = New Size(256, 23)
        txtContrasenaNueva.TabIndex = 2
        txtContrasenaNueva.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(37, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 22)
        Label1.TabIndex = 0
        Label1.Text = "Nueva contraseña:"
        ' 
        ' txtContrasenaComf
        ' 
        txtContrasenaComf.Location = New Point(37, 207)
        txtContrasenaComf.Margin = New Padding(3, 2, 3, 2)
        txtContrasenaComf.Name = "txtContrasenaComf"
        txtContrasenaComf.Size = New Size(256, 23)
        txtContrasenaComf.TabIndex = 3
        txtContrasenaComf.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(37, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(272, 22)
        Label3.TabIndex = 0
        Label3.Text = "Confirmar nueva contraseña:"
        ' 
        ' cmdAceptar
        ' 
        cmdAceptar.Font = New Font("Snap ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmdAceptar.Location = New Point(58, 267)
        cmdAceptar.Margin = New Padding(3, 2, 3, 2)
        cmdAceptar.Name = "cmdAceptar"
        cmdAceptar.Size = New Size(103, 29)
        cmdAceptar.TabIndex = 4
        cmdAceptar.Text = "Aceptar"
        cmdAceptar.UseVisualStyleBackColor = True
        ' 
        ' cmdCancelar
        ' 
        cmdCancelar.Font = New Font("Snap ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmdCancelar.Location = New Point(167, 267)
        cmdCancelar.Margin = New Padding(3, 2, 3, 2)
        cmdCancelar.Name = "cmdCancelar"
        cmdCancelar.Size = New Size(103, 29)
        cmdCancelar.TabIndex = 5
        cmdCancelar.Text = "Cancelar"
        cmdCancelar.UseVisualStyleBackColor = True
        ' 
        ' CambioContrasena
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(330, 333)
        Controls.Add(cmdCancelar)
        Controls.Add(cmdAceptar)
        Controls.Add(txtContrasenaComf)
        Controls.Add(Label3)
        Controls.Add(txtContrasenaNueva)
        Controls.Add(Label1)
        Controls.Add(txtContrasenaActual)
        Controls.Add(Label2)
        Name = "CambioContrasena"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CambioContrasena"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtContrasenaActual As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContrasenaNueva As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContrasenaComf As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents cmdCancelar As Button
End Class
