<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniciarBatalla
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
        Label1 = New Label()
        cmd_Iniciar = New Button()
        lbl_TuUsuario = New Label()
        Label3 = New Label()
        lbl_RivalUsuario = New Label()
        cmd_Atras = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(330, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 42)
        Label1.TabIndex = 0
        Label1.Text = "LUCHA!!!" & vbCrLf
        ' 
        ' cmd_Iniciar
        ' 
        cmd_Iniciar.FlatAppearance.BorderSize = 0
        cmd_Iniciar.FlatStyle = FlatStyle.Flat
        cmd_Iniciar.Font = New Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_Iniciar.ForeColor = Color.Red
        cmd_Iniciar.Location = New Point(375, 443)
        cmd_Iniciar.Name = "cmd_Iniciar"
        cmd_Iniciar.Size = New Size(105, 40)
        cmd_Iniciar.TabIndex = 21
        cmd_Iniciar.Text = "Iniciar"
        cmd_Iniciar.UseVisualStyleBackColor = True
        ' 
        ' lbl_TuUsuario
        ' 
        lbl_TuUsuario.AutoSize = True
        lbl_TuUsuario.Font = New Font("Snap ITC", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_TuUsuario.Location = New Point(164, 131)
        lbl_TuUsuario.Name = "lbl_TuUsuario"
        lbl_TuUsuario.Size = New Size(160, 42)
        lbl_TuUsuario.TabIndex = 22
        lbl_TuUsuario.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Showcard Gothic", 72.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Goldenrod
        Label3.Location = New Point(348, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 119)
        Label3.TabIndex = 23
        Label3.Text = "VS"
        ' 
        ' lbl_RivalUsuario
        ' 
        lbl_RivalUsuario.AutoSize = True
        lbl_RivalUsuario.Font = New Font("Snap ITC", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_RivalUsuario.Location = New Point(541, 131)
        lbl_RivalUsuario.Name = "lbl_RivalUsuario"
        lbl_RivalUsuario.Size = New Size(160, 42)
        lbl_RivalUsuario.TabIndex = 24
        lbl_RivalUsuario.Text = "Usuario"
        ' 
        ' cmd_Atras
        ' 
        cmd_Atras.AccessibleDescription = "btn_Atras"
        cmd_Atras.BackColor = Color.Transparent
        cmd_Atras.FlatAppearance.BorderSize = 0
        cmd_Atras.FlatStyle = FlatStyle.Flat
        cmd_Atras.Font = New Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_Atras.ForeColor = Color.Black
        cmd_Atras.Location = New Point(12, 12)
        cmd_Atras.Name = "cmd_Atras"
        cmd_Atras.Size = New Size(88, 28)
        cmd_Atras.TabIndex = 25
        cmd_Atras.Text = "Atras"
        cmd_Atras.UseVisualStyleBackColor = False
        ' 
        ' IniciarBatalla
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(887, 534)
        Controls.Add(cmd_Atras)
        Controls.Add(lbl_RivalUsuario)
        Controls.Add(Label3)
        Controls.Add(lbl_TuUsuario)
        Controls.Add(cmd_Iniciar)
        Controls.Add(Label1)
        Name = "IniciarBatalla"
        Text = "IniciarBatalla"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_Iniciar As Button
    Friend WithEvents lbl_TuUsuario As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_RivalUsuario As Label
    Friend WithEvents cmd_Atras As Button
End Class
