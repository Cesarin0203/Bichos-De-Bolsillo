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
        txt_Contasena = New TextBox()
        cmdIniciarSesion = New Button()
        cmdRegistrarse = New Button()
        SuspendLayout()
        ' 
        ' lbConnectionStatus
        ' 
        lbConnectionStatus.AutoSize = True
        lbConnectionStatus.Location = New Point(12, 357)
        lbConnectionStatus.Margin = New Padding(4, 0, 4, 0)
        lbConnectionStatus.Name = "lbConnectionStatus"
        lbConnectionStatus.Size = New Size(122, 15)
        lbConnectionStatus.TabIndex = 5
        lbConnectionStatus.Text = "Esperando conexión..."
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Header.Location = New Point(93, 31)
        Header.Margin = New Padding(4, 0, 4, 0)
        Header.Name = "Header"
        Header.Size = New Size(163, 42)
        Header.TabIndex = 0
        Header.Text = "Acceder"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(46, 104)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 20)
        Label1.TabIndex = 0
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 168)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 20)
        Label2.TabIndex = 0
        Label2.Text = "Contraseña:"
        ' 
        ' txt_Usuario
        ' 
        txt_Usuario.Location = New Point(46, 127)
        txt_Usuario.Margin = New Padding(4, 2, 4, 2)
        txt_Usuario.Name = "txt_Usuario"
        txt_Usuario.Size = New Size(256, 23)
        txt_Usuario.TabIndex = 1
        ' 
        ' txt_Contasena
        ' 
        txt_Contrasena.Location = New Point(46, 192)
        txt_Contrasena.Margin = New Padding(4, 2, 4, 2)
        txt_Contrasena.Name = "txt_Contrasena"
        txt_Contrasena.Size = New Size(256, 23)
        txt_Contrasena.TabIndex = 2
        txt_Contrasena.UseSystemPasswordChar = True
        ' 
        ' cmdIniciarSesion
        ' 
        cmdIniciarSesion.Font = New Font("Microsoft Sans Serif", 10.0F)
        cmdIniciarSesion.Location = New Point(66, 240)
        cmdIniciarSesion.Margin = New Padding(4, 2, 4, 2)
        cmdIniciarSesion.Name = "cmdIniciarSesion"
        cmdIniciarSesion.Size = New Size(103, 29)
        cmdIniciarSesion.TabIndex = 3
        cmdIniciarSesion.Text = "Iniciar sesión"
        cmdIniciarSesion.UseVisualStyleBackColor = True
        ' 
        ' cmdRegistrarse
        ' 
        cmdRegistrarse.Font = New Font("Microsoft Sans Serif", 10.0F)
        cmdRegistrarse.Location = New Point(175, 240)
        cmdRegistrarse.Margin = New Padding(4, 2, 4, 2)
        cmdRegistrarse.Name = "cmdRegistrarse"
        cmdRegistrarse.Size = New Size(108, 29)
        cmdRegistrarse.TabIndex = 4
        cmdRegistrarse.Text = "Registrarse"
        cmdRegistrarse.UseVisualStyleBackColor = True
        ' 
        ' InicioSesion
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 381)
        Controls.Add(cmdRegistrarse)
        Controls.Add(Header)
        Controls.Add(lbConnectionStatus)
        Controls.Add(cmdIniciarSesion)
        Controls.Add(txt_Contasena)
        Controls.Add(txt_Usuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 2, 4, 2)
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
    Friend WithEvents txt_Contasena As TextBox
    Friend WithEvents cmdIniciarSesion As Button
    Friend WithEvents cmdRegistrarse As Button
End Class
