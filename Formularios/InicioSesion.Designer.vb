<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbConnectionStatus = New Label()
        Header = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txt_Usuario = New TextBox()
        txt_Contrasena = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' lbConnectionStatus
        ' 
        lbConnectionStatus.AutoSize = True
        lbConnectionStatus.Location = New Point(14, 476)
        lbConnectionStatus.Name = "lbConnectionStatus"
        lbConnectionStatus.Size = New Size(152, 20)
        lbConnectionStatus.TabIndex = 5
        lbConnectionStatus.Text = "Esperando conexión..."
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Font = New Font("Segoe UI", 28.0F)
        Header.Location = New Point(106, 41)
        Header.Name = "Header"
        Header.Size = New Size(195, 62)
        Header.TabIndex = 0
        Header.Text = "Acceder"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F)
        Label1.Location = New Point(51, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 28)
        Label1.TabIndex = 0
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F)
        Label2.Location = New Point(49, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 28)
        Label2.TabIndex = 0
        Label2.Text = "Contraseña:"
        ' 
        ' txt_Usuario
        ' 
        txt_Usuario.Location = New Point(51, 169)
        txt_Usuario.Name = "txt_Usuario"
        txt_Usuario.Size = New Size(292, 27)
        txt_Usuario.TabIndex = 1
        ' 
        ' txt_Contrasena
        ' 
        txt_Contrasena.Location = New Point(51, 255)
        txt_Contrasena.Name = "txt_Contrasena"
        txt_Contrasena.Size = New Size(292, 27)
        txt_Contrasena.TabIndex = 2
        txt_Contrasena.UseSystemPasswordChar = True
        ' 
        ' cmdIniciarSesion
        ' 
        cmdIniciarSesion.Location = New Point(75, 320)
        cmdIniciarSesion.Name = "cmdIniciarSesion"
        cmdIniciarSesion.Size = New Size(118, 39)
        cmdIniciarSesion.TabIndex = 3
        cmdIniciarSesion.Text = "Iniciar sesión"
        cmdIniciarSesion.UseVisualStyleBackColor = True
        ' 
        ' cmdRegistrarse
        ' 
        cmdRegistrarse.Location = New Point(200, 320)
        cmdRegistrarse.Name = "cmdRegistrarse"
        cmdRegistrarse.Size = New Size(118, 39)
        cmdRegistrarse.TabIndex = 4
        cmdRegistrarse.Text = "Registrarse"
        cmdRegistrarse.UseVisualStyleBackColor = True
        ' 
        ' InicioSesion
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(393, 508)
        Controls.Add(cmdRegistrarse)
        Controls.Add(Header)
        Controls.Add(lbConnectionStatus)
        Controls.Add(cmdIniciarSesion)
        Controls.Add(txt_Contrasena)
        Controls.Add(txt_Usuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "InicioSesion"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbConnectionStatus As Label
    Friend WithEvents Header As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents txt_Contrasena As TextBox
    Friend WithEvents cmdIniciarSesion As Button
    Friend WithEvents cmdRegistrarse As Button
End Class
