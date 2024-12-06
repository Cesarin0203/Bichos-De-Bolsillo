<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        cmd_Empezar = New Button()
        lbTitulo = New Label()
        SuspendLayout()
        ' 
        ' cmd_Empezar
        ' 
        cmd_Empezar.Anchor = AnchorStyles.None
        cmd_Empezar.FlatStyle = FlatStyle.System
        cmd_Empezar.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_Empezar.ForeColor = Color.Red
        cmd_Empezar.Location = New Point(465, 309)
        cmd_Empezar.Margin = New Padding(3, 2, 3, 2)
        cmd_Empezar.MaximumSize = New Size(175, 54)
        cmd_Empezar.MinimumSize = New Size(175, 54)
        cmd_Empezar.Name = "cmd_Empezar"
        cmd_Empezar.Size = New Size(175, 54)
        cmd_Empezar.TabIndex = 0
        cmd_Empezar.Text = "Empezar"
        cmd_Empezar.UseVisualStyleBackColor = True
        ' 
        ' lbTitulo
        ' 
        lbTitulo.Anchor = AnchorStyles.None
        lbTitulo.FlatStyle = FlatStyle.Popup
        lbTitulo.Font = New Font("Consolas", 60F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbTitulo.ForeColor = Color.Goldenrod
        lbTitulo.Location = New Point(124, 183)
        lbTitulo.Margin = New Padding(0)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(857, 101)
        lbTitulo.TabIndex = 1
        lbTitulo.Text = "Bichos de Bolsillo"
        lbTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1104, 561)
        Controls.Add(lbTitulo)
        Controls.Add(cmd_Empezar)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(500, 248)
        Name = "MenuPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmd_Empezar As Button
    Friend WithEvents lbTitulo As Label
End Class
