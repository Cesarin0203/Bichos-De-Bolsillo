<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gimnasios
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
        Label2 = New Label()
        Label1 = New Label()
        cmd_Atras = New Button()
        lv_TusGimnasios = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        lv_TodosLosGimnasios = New ListView()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        Label3 = New Label()
        liderar = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(92, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(229, 31)
        Label2.TabIndex = 7
        Label2.Text = "Tus Gimnasios"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(154, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(386, 47)
        Label1.TabIndex = 4
        Label1.Text = "Lista de Gimnasios"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' cmd_Atras
        ' 
        cmd_Atras.AccessibleDescription = "btn_Atras"
        cmd_Atras.BackColor = Color.Transparent
        cmd_Atras.FlatAppearance.BorderSize = 0
        cmd_Atras.FlatStyle = FlatStyle.Flat
        cmd_Atras.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_Atras.ForeColor = SystemColors.ActiveCaptionText
        cmd_Atras.Location = New Point(2, 12)
        cmd_Atras.Name = "cmd_Atras"
        cmd_Atras.Size = New Size(89, 30)
        cmd_Atras.TabIndex = 3
        cmd_Atras.Text = "Atras"
        cmd_Atras.UseVisualStyleBackColor = False
        ' 
        ' lv_TusGimnasios
        ' 
        lv_TusGimnasios.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        lv_TusGimnasios.Location = New Point(97, 92)
        lv_TusGimnasios.Name = "lv_TusGimnasios"
        lv_TusGimnasios.Size = New Size(328, 114)
        lv_TusGimnasios.TabIndex = 8
        lv_TusGimnasios.UseCompatibleStateImageBehavior = False
        lv_TusGimnasios.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nombre"
        ColumnHeader2.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Lider"
        ColumnHeader3.Width = 100
        ' 
        ' lv_TodosLosGimnasios
        ' 
        lv_TodosLosGimnasios.Columns.AddRange(New ColumnHeader() {ColumnHeader4, ColumnHeader5, ColumnHeader6})
        lv_TodosLosGimnasios.Location = New Point(97, 240)
        lv_TodosLosGimnasios.Name = "lv_TodosLosGimnasios"
        lv_TodosLosGimnasios.Size = New Size(328, 217)
        lv_TodosLosGimnasios.TabIndex = 10
        lv_TodosLosGimnasios.UseCompatibleStateImageBehavior = False
        lv_TodosLosGimnasios.View = View.Details
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
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.RoyalBlue
        Label3.Location = New Point(92, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(333, 31)
        Label3.TabIndex = 9
        Label3.Text = "Todos los Gimnasios"
        ' 
        ' liderar
        ' 
        liderar.AccessibleDescription = "btn_Atras"
        liderar.BackColor = Color.Transparent
        liderar.FlatAppearance.BorderSize = 0
        liderar.FlatStyle = FlatStyle.System
        liderar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        liderar.ForeColor = SystemColors.ActiveCaptionText
        liderar.Location = New Point(236, 463)
        liderar.Name = "liderar"
        liderar.Size = New Size(189, 30)
        liderar.TabIndex = 11
        liderar.Text = "Liderar Nuevo Gimnasio"
        liderar.UseVisualStyleBackColor = False
        ' 
        ' Gimnasios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(552, 535)
        Controls.Add(liderar)
        Controls.Add(lv_TodosLosGimnasios)
        Controls.Add(Label3)
        Controls.Add(lv_TusGimnasios)
        Controls.Add(Label1)
        Controls.Add(cmd_Atras)
        Controls.Add(Label2)
        ForeColor = SystemColors.Control
        Name = "Gimnasios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gimnasios"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_Atras As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lv_TusGimnasios As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents lv_TodosLosGimnasios As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents liderar As Button
End Class
