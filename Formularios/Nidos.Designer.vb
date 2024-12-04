<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nidos
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
        lv_Nidos = New ListView()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        Label1 = New Label()
        cmd_Atras = New Button()
        SuspendLayout()
        ' 
        ' lv_Nidos
        ' 
        lv_Nidos.Columns.AddRange(New ColumnHeader() {ColumnHeader4, ColumnHeader7, ColumnHeader5, ColumnHeader6})
        lv_Nidos.Location = New Point(14, 59)
        lv_Nidos.Name = "lv_Nidos"
        lv_Nidos.Size = New Size(428, 211)
        lv_Nidos.TabIndex = 17
        lv_Nidos.UseCompatibleStateImageBehavior = False
        lv_Nidos.View = View.Details
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "ID"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Ubicacion"
        ColumnHeader7.Width = 150
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Especie"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Region"
        ColumnHeader6.Width = 100
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Snap ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(106, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 49)
        Label1.TabIndex = 16
        Label1.Text = "Nidos"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' cmd_Atras
        ' 
        cmd_Atras.AccessibleDescription = "btn_Atras"
        cmd_Atras.BackColor = Color.Transparent
        cmd_Atras.FlatAppearance.BorderSize = 0
        cmd_Atras.FlatStyle = FlatStyle.Flat
        cmd_Atras.Font = New Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_Atras.ForeColor = Color.Black
        cmd_Atras.Location = New Point(12, 10)
        cmd_Atras.Name = "cmd_Atras"
        cmd_Atras.Size = New Size(88, 28)
        cmd_Atras.TabIndex = 15
        cmd_Atras.Text = "Atras"
        cmd_Atras.UseVisualStyleBackColor = False
        ' 
        ' Nidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 296)
        Controls.Add(lv_Nidos)
        Controls.Add(Label1)
        Controls.Add(cmd_Atras)
        Name = "Nidos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Nidos"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lv_Nidos As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_Atras As Button
End Class
