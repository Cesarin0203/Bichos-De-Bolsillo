<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroUsuario
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
        cmdCancelar = New Button()
        lbConnectionStatus = New Label()
        cmdAceptar = New Button()
        txt_Contrasena = New TextBox()
        txt_Usuario = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        pickerFechaNac = New DateTimePicker()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' cmdCancelar
        ' 
        cmdCancelar.Font = New Font("Microsoft Sans Serif", 9F)
        cmdCancelar.Location = New Point(170, 244)
        cmdCancelar.Margin = New Padding(3, 2, 3, 2)
        cmdCancelar.Name = "cmdCancelar"
        cmdCancelar.Size = New Size(103, 29)
        cmdCancelar.TabIndex = 12
        cmdCancelar.Text = "Cancelar"
        cmdCancelar.UseVisualStyleBackColor = True
        ' 
        ' lbConnectionStatus
        ' 
        lbConnectionStatus.AutoSize = True
        lbConnectionStatus.Location = New Point(12, 357)
        lbConnectionStatus.Name = "lbConnectionStatus"
        lbConnectionStatus.Size = New Size(122, 15)
        lbConnectionStatus.TabIndex = 13
        lbConnectionStatus.Text = "Esperando conexión..."
        ' 
        ' cmdAceptar
        ' 
        cmdAceptar.Font = New Font("Microsoft Sans Serif", 9F)
        cmdAceptar.Location = New Point(61, 244)
        cmdAceptar.Margin = New Padding(3, 2, 3, 2)
        cmdAceptar.Name = "cmdAceptar"
        cmdAceptar.Size = New Size(103, 29)
        cmdAceptar.TabIndex = 11
        cmdAceptar.Text = "Aceptar"
        cmdAceptar.UseVisualStyleBackColor = True
        ' 
        ' txt_Contrasena
        ' 
        txt_Contrasena.Location = New Point(40, 120)
        txt_Contrasena.Margin = New Padding(3, 2, 3, 2)
        txt_Contrasena.Name = "txt_Contrasena"
        txt_Contrasena.Size = New Size(256, 23)
        txt_Contrasena.TabIndex = 10
        txt_Contrasena.UseSystemPasswordChar = True
        ' 
        ' txt_Usuario
        ' 
        txt_Usuario.Location = New Point(40, 56)
        txt_Usuario.Margin = New Padding(3, 2, 3, 2)
        txt_Usuario.Name = "txt_Usuario"
        txt_Usuario.Size = New Size(256, 23)
        txt_Usuario.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(38, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 20)
        Label2.TabIndex = 7
        Label2.Text = "Contraseña:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(40, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 20)
        Label1.TabIndex = 8
        Label1.Text = "Nombre de usuario:"
        ' 
        ' pickerFechaNac
        ' 
        pickerFechaNac.Location = New Point(40, 185)
        pickerFechaNac.Name = "pickerFechaNac"
        pickerFechaNac.Size = New Size(256, 23)
        pickerFechaNac.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(40, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 20)
        Label3.TabIndex = 15
        Label3.Text = "Fecha de nacimiento:"
        ' 
        ' RegistroUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 381)
        Controls.Add(Label3)
        Controls.Add(pickerFechaNac)
        Controls.Add(cmdCancelar)
        Controls.Add(lbConnectionStatus)
        Controls.Add(cmdAceptar)
        Controls.Add(txt_Contrasena)
        Controls.Add(txt_Usuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "RegistroUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegistroUsuario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdCancelar As Button
    Friend WithEvents lbConnectionStatus As Label
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents txt_Contrasena As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pickerFechaNac As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
