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
        lbTitulo = New Label()
        SuspendLayout()
        ' 
        ' cmd_Empezar
        ' 
        cmd_Empezar.Anchor = AnchorStyles.None
        cmd_Empezar.FlatStyle = FlatStyle.System
        cmd_Empezar.Font = New Font("Comic Sans MS", 20F)
        cmd_Empezar.Location = New Point(531, 412)
        cmd_Empezar.MaximumSize = New Size(200, 72)
        cmd_Empezar.MinimumSize = New Size(200, 72)
        cmd_Empezar.Name = "cmd_Empezar"
        cmd_Empezar.Size = New Size(200, 72)
        cmd_Empezar.TabIndex = 0
        cmd_Empezar.Text = "Empezar"
        cmd_Empezar.UseVisualStyleBackColor = True
        ' 
        ' lbTitulo
        ' 
        lbTitulo.Anchor = AnchorStyles.None
        lbTitulo.FlatStyle = FlatStyle.Popup
        lbTitulo.Font = New Font("Comic Sans MS", 40F)
        lbTitulo.Location = New Point(325, 263)
        lbTitulo.Margin = New Padding(0)
        lbTitulo.MinimumSize = New Size(543, 107)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(613, 107)
        lbTitulo.TabIndex = 1
        lbTitulo.Text = "Bichos De Bolsillo"
        lbTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1262, 748)
        Controls.Add(lbTitulo)
        Controls.Add(cmd_Empezar)
        MinimumSize = New Size(569, 318)
        Name = "MenuPrincipal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmd_Empezar As Button
    Friend WithEvents lbTitulo As Label
End Class
