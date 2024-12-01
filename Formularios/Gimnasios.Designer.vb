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
        GroupBox2 = New GroupBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Yellow
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Location = New Point(44, 117)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1017, 416)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.MenuHighlight
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.Window
        TextBox2.Location = New Point(18, 221)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(924, 47)
        TextBox2.TabIndex = 10
        TextBox2.Text = "Info del Gimnasio"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.RoyalBlue
        Label3.Location = New Point(18, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 26)
        Label3.TabIndex = 9
        Label3.Text = "Tus Gimnasios"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.MenuHighlight
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.Location = New Point(18, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(924, 47)
        TextBox1.TabIndex = 8
        TextBox1.Text = "Info del Gimnasio"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(18, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(229, 26)
        Label2.TabIndex = 7
        Label2.Text = "Tus Gimnasios"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.MenuHighlight
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox4.ForeColor = SystemColors.Window
        TextBox4.Location = New Point(18, 363)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(924, 47)
        TextBox4.TabIndex = 6
        TextBox4.Text = "Info del Gimnasio"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.MenuHighlight
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.Window
        TextBox3.Location = New Point(18, 293)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(924, 47)
        TextBox3.TabIndex = 5
        TextBox3.Text = "Info del Gimnasio"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Red
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(458, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(603, 58)
        Label1.TabIndex = 4
        Label1.Text = "Lista de Gimnasios"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' Button1
        ' 
        Button1.AccessibleDescription = "btn_Atras"
        Button1.BackColor = Color.MediumSpringGreen
        Button1.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(44, 28)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 37)
        Button1.TabIndex = 3
        Button1.Text = "<---Atras"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Gimnasios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1104, 561)
        Controls.Add(GroupBox2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Gimnasios"
        Text = "Gimnasios"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
