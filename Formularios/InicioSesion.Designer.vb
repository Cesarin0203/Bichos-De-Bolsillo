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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' lbConnectionStatus
        ' 
        lbConnectionStatus.AutoSize = True
        lbConnectionStatus.Location = New Point(12, 483)
        lbConnectionStatus.Name = "lbConnectionStatus"
        lbConnectionStatus.Size = New Size(152, 20)
        lbConnectionStatus.TabIndex = 5
        lbConnectionStatus.Text = "Esperando conexión..."
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.Font = New Font("Segoe UI", 28F)
        Header.Location = New Point(100, 32)
        Header.Name = "Header"
        Header.Size = New Size(195, 62)
        Header.TabIndex = 6
        Header.Text = "Acceder"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(51, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 28)
        Label1.TabIndex = 0
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(51, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 28)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña:"
        ' 
        ' txt_Usuario
        ' 
        txt_Usuario.Location = New Point(51, 152)
        txt_Usuario.Name = "txt_Usuario"
        txt_Usuario.Size = New Size(292, 27)
        txt_Usuario.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(51, 238)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(292, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(76, 303)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 29)
        Button1.TabIndex = 4
        Button1.Text = "Iniciar sesión"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(200, 303)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 29)
        Button2.TabIndex = 7
        Button2.Text = "Registrarse"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' InicioSesion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(394, 512)
        Controls.Add(Button2)
        Controls.Add(Header)
        Controls.Add(lbConnectionStatus)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
