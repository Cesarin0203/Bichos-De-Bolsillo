﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Header.Name = "Header"
        Header.Size = New Size(163, 42)
        Header.TabIndex = 0
        Header.Text = "Acceder"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(45, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 20)
        Label1.TabIndex = 0
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 20)
        Label2.TabIndex = 0
        Label2.Text = "Contraseña:"
        ' 
        ' txt_Usuario
        ' 
        txt_Usuario.Location = New Point(45, 127)
        txt_Usuario.Margin = New Padding(3, 2, 3, 2)
        txt_Usuario.Name = "txt_Usuario"
        txt_Usuario.Size = New Size(256, 23)
        txt_Usuario.TabIndex = 1
        ' 
        ' txt_Contasena
        ' 
        txt_Contasena.Location = New Point(45, 191)
        txt_Contasena.Margin = New Padding(3, 2, 3, 2)
        txt_Contasena.Name = "txt_Contasena"
        txt_Contasena.Size = New Size(256, 23)
        txt_Contasena.TabIndex = 2
        txt_Contasena.UseSystemPasswordChar = True
        ' 
        ' cmdIniciarSesion
        ' 
        cmdIniciarSesion.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdIniciarSesion.Location = New Point(66, 240)
        cmdIniciarSesion.Margin = New Padding(3, 2, 3, 2)
        cmdIniciarSesion.Name = "cmdIniciarSesion"
        cmdIniciarSesion.Size = New Size(103, 29)
        cmdIniciarSesion.TabIndex = 3
        cmdIniciarSesion.Text = "Iniciar sesión"
        cmdIniciarSesion.UseVisualStyleBackColor = True
        ' 
        ' cmdRegistrarse
        ' 
        cmdRegistrarse.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmdRegistrarse.Location = New Point(175, 240)
        cmdRegistrarse.Margin = New Padding(3, 2, 3, 2)
        cmdRegistrarse.Name = "cmdRegistrarse"
        cmdRegistrarse.Size = New Size(109, 29)
        cmdRegistrarse.TabIndex = 4
        cmdRegistrarse.Text = "Registrarse"
        cmdRegistrarse.UseVisualStyleBackColor = True
        ' 
        ' InicioSesion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
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
    Friend WithEvents txt_Contasena As TextBox
    Friend WithEvents cmdIniciarSesion As Button
    Friend WithEvents cmdRegistrarse As Button
End Class
