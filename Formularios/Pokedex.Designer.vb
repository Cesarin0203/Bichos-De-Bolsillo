<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pokedex
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Button1 = New Button()
        Label1 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        lv_TodosLosPokemones = New ListView()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AccessibleDescription = "btn_Atras"
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 28)
        Button1.TabIndex = 0
        Button1.Text = "Atras"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Snap ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(106, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 49)
        Label1.TabIndex = 1
        Label1.Text = "Pokedex"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' lv_TodosLosPokemones
        ' 
        lv_TodosLosPokemones.Columns.AddRange(New ColumnHeader() {ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader1, ColumnHeader2, ColumnHeader3})
        lv_TodosLosPokemones.Location = New Point(12, 61)
        lv_TodosLosPokemones.Name = "lv_TodosLosPokemones"
        lv_TodosLosPokemones.Size = New Size(674, 340)
        lv_TodosLosPokemones.TabIndex = 11
        lv_TodosLosPokemones.UseCompatibleStateImageBehavior = False
        lv_TodosLosPokemones.View = View.Details
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "ID"
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
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "ATKRAPIDO"
        ColumnHeader2.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "ATKCARGADO"
        ColumnHeader3.Width = 150
        ' 
        ' Pokedex
        ' 
        AccessibleName = "Pokedex"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(698, 424)
        Controls.Add(lv_TodosLosPokemones)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Pokedex"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pokedex"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lv_TodosLosPokemones As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
