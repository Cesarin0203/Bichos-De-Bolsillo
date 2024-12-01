<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesion
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
        lbConnectionStatus = New Label()
        Header = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txt_Usuario = New TextBox()
        txt_Contrasena = New TextBox()
        cmd_iniciasesion = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' lbConnectionStatus
        ' 
        lbConnectionStatus.AutoSize = True
        lbConnectionStatus.Location = New Point(12, 357)
        lbConnectionStatus.Name = "lbConnectionStatus"
        lbConnectionStatus.Size = New Size(122, 15)
        lbConnectionStatus.TabIndex = 5
        lbConnectionStatus.Text = "Esperando conexión..."
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Font = New Font("Segoe UI", 28F)
        Header.Location = New Point(93, 31)
        Header.Name = "Header"
        Header.Size = New Size(158, 51)
        Header.TabIndex = 6
        Header.Text = "Acceder"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(45, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 21)
        Label1.TabIndex = 0
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(43, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 21)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña:"
        ' 
        ' txt_Usuario
        ' 
        txt_Usuario.Location = New Point(45, 127)
        txt_Usuario.Margin = New Padding(3, 2, 3, 2)
        txt_Usuario.Name = "txt_Usuario"
        txt_Usuario.Size = New Size(256, 23)
        txt_Usuario.TabIndex = 2
        ' 
        ' txt_Contrasena
        ' 
        txt_Contrasena.Location = New Point(45, 191)
        txt_Contrasena.Margin = New Padding(3, 2, 3, 2)
        txt_Contrasena.Name = "txt_Contrasena"
        txt_Contrasena.Size = New Size(256, 23)
        txt_Contrasena.TabIndex = 3
        txt_Contrasena.UseSystemPasswordChar = True
        ' 
        ' cmd_iniciasesion
        ' 
        cmd_iniciasesion.Location = New Point(66, 240)
        cmd_iniciasesion.Margin = New Padding(3, 2, 3, 2)
        cmd_iniciasesion.Name = "cmd_iniciasesion"
        cmd_iniciasesion.Size = New Size(103, 29)
        cmd_iniciasesion.TabIndex = 4
        cmd_iniciasesion.Text = "Iniciar sesión"
        cmd_iniciasesion.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(175, 240)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 29)
        Button2.TabIndex = 7
        Button2.Text = "Registrarse"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' InicioSesion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 381)
        Controls.Add(Button2)
        Controls.Add(Header)
        Controls.Add(lbConnectionStatus)
        Controls.Add(cmd_iniciasesion)
        Controls.Add(txt_Contrasena)
        Controls.Add(txt_Usuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmd_iniciasesion As Button
End Class
