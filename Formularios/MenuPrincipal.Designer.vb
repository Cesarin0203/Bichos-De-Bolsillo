<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        cmd_Empezar = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' cmd_Empezar
        ' 
        cmd_Empezar.FlatStyle = FlatStyle.System
        cmd_Empezar.Font = New Font("Comic Sans MS", 20F)
        cmd_Empezar.Location = New Point(560, 387)
        cmd_Empezar.Name = "cmd_Empezar"
        cmd_Empezar.Size = New Size(200, 72)
        cmd_Empezar.TabIndex = 0
        cmd_Empezar.Text = "Empezar"
        cmd_Empezar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Comic Sans MS", 40F)
        Label1.Location = New Point(362, 237)
        Label1.Name = "Label1"
        Label1.Size = New Size(591, 101)
        Label1.TabIndex = 1
        Label1.Text = "Bichos De Bolsillo"
        ' 
        ' MenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1262, 673)
        Controls.Add(Label1)
        Controls.Add(cmd_Empezar)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "MenuPrincipal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmd_Empezar As Button
    Friend WithEvents Label1 As Label
End Class
