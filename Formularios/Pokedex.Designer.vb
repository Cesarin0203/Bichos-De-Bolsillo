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
        GroupBox2 = New GroupBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        TextBox5 = New TextBox()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AccessibleDescription = "btn_Atras"
        Button1.BackColor = Color.MediumSpringGreen
        Button1.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(27, 26)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 37)
        Button1.TabIndex = 0
        Button1.Text = "<---Atras"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Red
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(441, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(603, 58)
        Label1.TabIndex = 1
        Label1.Text = "Header"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Yellow
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Location = New Point(55, 115)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(989, 416)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.MenuHighlight
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox4.ForeColor = SystemColors.Window
        TextBox4.Location = New Point(18, 343)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(924, 47)
        TextBox4.TabIndex = 6
        TextBox4.Text = "Info de la especie"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.MenuHighlight
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.Window
        TextBox3.Location = New Point(18, 272)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(924, 47)
        TextBox3.TabIndex = 5
        TextBox3.Text = "Info de la especie"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.MenuHighlight
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.Window
        TextBox2.Location = New Point(18, 203)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(924, 47)
        TextBox2.TabIndex = 4
        TextBox2.Text = "Info de la especie"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.MenuHighlight
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.Location = New Point(18, 129)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(924, 47)
        TextBox1.TabIndex = 3
        TextBox1.Text = "Info de la especie"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.MenuHighlight
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox5.ForeColor = SystemColors.Window
        TextBox5.Location = New Point(18, 58)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(924, 47)
        TextBox5.TabIndex = 7
        TextBox5.Text = "Info de la especie"
        ' 
        ' Pokedex
        ' 
        AccessibleName = "Pokedex"
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1104, 561)
        Controls.Add(GroupBox2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Pokedex"
        Text = "Pokedex"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
