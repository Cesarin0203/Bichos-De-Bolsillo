<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiderarNuevoGimnasio
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
        cmd_Atras = New Button()
        lv_TodosGimnasiosSinLider = New ListView()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        SuspendLayout()
        ' 
        ' cmd_Atras
        ' 
        cmd_Atras.AccessibleDescription = "btn_Atras"
        cmd_Atras.BackColor = Color.Transparent
        cmd_Atras.FlatAppearance.BorderSize = 0
        cmd_Atras.FlatStyle = FlatStyle.Flat
        cmd_Atras.Font = New Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_Atras.ForeColor = Color.OliveDrab
        cmd_Atras.Location = New Point(251, 236)
        cmd_Atras.Name = "cmd_Atras"
        cmd_Atras.Size = New Size(89, 30)
        cmd_Atras.TabIndex = 4
        cmd_Atras.Text = "Listo"
        cmd_Atras.UseVisualStyleBackColor = False
        ' 
        ' lv_TodosGimnasiosSinLider
        ' 
        lv_TodosGimnasiosSinLider.CheckBoxes = True
        lv_TodosGimnasiosSinLider.Columns.AddRange(New ColumnHeader() {ColumnHeader4, ColumnHeader5, ColumnHeader6})
        lv_TodosGimnasiosSinLider.Location = New Point(12, 12)
        lv_TodosGimnasiosSinLider.Name = "lv_TodosGimnasiosSinLider"
        lv_TodosGimnasiosSinLider.Size = New Size(328, 217)
        lv_TodosGimnasiosSinLider.TabIndex = 11
        lv_TodosGimnasiosSinLider.UseCompatibleStateImageBehavior = False
        lv_TodosGimnasiosSinLider.View = View.Details
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "ID"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Nombre"
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Lider"
        ColumnHeader6.Width = 100
        ' 
        ' LiderarNuevoGimnasio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 276)
        Controls.Add(lv_TodosGimnasiosSinLider)
        Controls.Add(cmd_Atras)
        Name = "LiderarNuevoGimnasio"
        Text = "LiderarNuevoGimnasio"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmd_Atras As Button
    Friend WithEvents lv_TodosGimnasiosSinLider As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
