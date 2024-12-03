<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MisPokemones
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
        lv_TodosMisPokemones = New ListView()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        ColumnHeader11 = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        ColumnHeader13 = New ColumnHeader()
        Label1 = New Label()
        cmd_Atras = New Button()
        SuspendLayout()
        ' 
        ' lv_TodosMisPokemones
        ' 
        lv_TodosMisPokemones.Columns.AddRange(New ColumnHeader() {ColumnHeader4, ColumnHeader7, ColumnHeader5, ColumnHeader6, ColumnHeader1, ColumnHeader8, ColumnHeader9, ColumnHeader10, ColumnHeader11, ColumnHeader12, ColumnHeader13})
        lv_TodosMisPokemones.Location = New Point(12, 61)
        lv_TodosMisPokemones.Name = "lv_TodosMisPokemones"
        lv_TodosMisPokemones.Size = New Size(1015, 452)
        lv_TodosMisPokemones.TabIndex = 14
        lv_TodosMisPokemones.UseCompatibleStateImageBehavior = False
        lv_TodosMisPokemones.View = View.Details
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "ID"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Nivel"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Evolucion"
        ColumnHeader5.Width = 80
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Nombre"
        ColumnHeader6.Width = 120
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Tipo"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Vida"
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Poder Maximo"
        ColumnHeader9.Width = 100
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Ataque"
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.Text = "Defensa"
        ' 
        ' ColumnHeader12
        ' 
        ColumnHeader12.Text = "ATKRAPIDO"
        ColumnHeader12.Width = 150
        ' 
        ' ColumnHeader13
        ' 
        ColumnHeader13.Text = "ATKCARGADO"
        ColumnHeader13.Width = 150
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Snap ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(106, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(311, 49)
        Label1.TabIndex = 13
        Label1.Text = "Mis Pokemones"
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
        cmd_Atras.Location = New Point(12, 12)
        cmd_Atras.Name = "cmd_Atras"
        cmd_Atras.Size = New Size(88, 28)
        cmd_Atras.TabIndex = 12
        cmd_Atras.Text = "Atras"
        cmd_Atras.UseVisualStyleBackColor = False
        ' 
        ' MisPokemones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1040, 532)
        Controls.Add(lv_TodosMisPokemones)
        Controls.Add(Label1)
        Controls.Add(cmd_Atras)
        Name = "MisPokemones"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MisPokemones"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lv_TodosMisPokemones As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_Atras As Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
End Class
