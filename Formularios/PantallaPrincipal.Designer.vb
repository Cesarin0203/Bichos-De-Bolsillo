<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaPrincipal
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
        lbl_Bienvenida = New Label()
        Label2 = New Label()
        cmd_Pokedex = New Button()
        cmd_Nidos = New Button()
        Cmd_InciarBatalla = New Button()
        cmd_Gimnasio = New Button()
        cmd_Configuracion = New Button()
        cmd_MisPokemones = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_Bienvenida
        ' 
        lbl_Bienvenida.AutoSize = True
        lbl_Bienvenida.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_Bienvenida.Location = New Point(12, 537)
        lbl_Bienvenida.Name = "lbl_Bienvenida"
        lbl_Bienvenida.Size = New Size(89, 16)
        lbl_Bienvenida.TabIndex = 0
        lbl_Bienvenida.Text = "Hola, Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(358, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(290, 37)
        Label2.TabIndex = 0
        Label2.Text = "Bichos De Bolsillo"
        ' 
        ' cmd_Pokedex
        ' 
        cmd_Pokedex.FlatAppearance.BorderColor = Color.White
        cmd_Pokedex.FlatAppearance.BorderSize = 0
        cmd_Pokedex.FlatStyle = FlatStyle.Flat
        cmd_Pokedex.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_Pokedex.ForeColor = Color.Red
        cmd_Pokedex.Location = New Point(12, 12)
        cmd_Pokedex.Name = "cmd_Pokedex"
        cmd_Pokedex.Size = New Size(128, 30)
        cmd_Pokedex.TabIndex = 1
        cmd_Pokedex.Text = "Pokedex"
        cmd_Pokedex.UseVisualStyleBackColor = True
        ' 
        ' cmd_Nidos
        ' 
        cmd_Nidos.FlatAppearance.BorderSize = 0
        cmd_Nidos.FlatStyle = FlatStyle.Flat
        cmd_Nidos.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_Nidos.ForeColor = Color.Red
        cmd_Nidos.Location = New Point(12, 82)
        cmd_Nidos.Name = "cmd_Nidos"
        cmd_Nidos.Size = New Size(109, 30)
        cmd_Nidos.TabIndex = 3
        cmd_Nidos.Text = "Nidos"
        cmd_Nidos.UseVisualStyleBackColor = True
        ' 
        ' Cmd_InciarBatalla
        ' 
        Cmd_InciarBatalla.FlatAppearance.BorderSize = 0
        Cmd_InciarBatalla.FlatStyle = FlatStyle.Flat
        Cmd_InciarBatalla.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Cmd_InciarBatalla.ForeColor = Color.Red
        Cmd_InciarBatalla.Location = New Point(295, 438)
        Cmd_InciarBatalla.Name = "Cmd_InciarBatalla"
        Cmd_InciarBatalla.Size = New Size(198, 34)
        Cmd_InciarBatalla.TabIndex = 4
        Cmd_InciarBatalla.Text = "Iniciar Batalla"
        Cmd_InciarBatalla.UseVisualStyleBackColor = True
        ' 
        ' cmd_Gimnasio
        ' 
        cmd_Gimnasio.FlatAppearance.BorderSize = 0
        cmd_Gimnasio.FlatStyle = FlatStyle.Flat
        cmd_Gimnasio.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_Gimnasio.ForeColor = Color.Red
        cmd_Gimnasio.Location = New Point(12, 48)
        cmd_Gimnasio.Name = "cmd_Gimnasio"
        cmd_Gimnasio.Size = New Size(128, 28)
        cmd_Gimnasio.TabIndex = 2
        cmd_Gimnasio.Text = "Gimnasios"
        cmd_Gimnasio.UseVisualStyleBackColor = True
        ' 
        ' cmd_Configuracion
        ' 
        cmd_Configuracion.FlatAppearance.BorderSize = 0
        cmd_Configuracion.FlatStyle = FlatStyle.Flat
        cmd_Configuracion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_Configuracion.Image = My.Resources.Resources.emotion_gear
        cmd_Configuracion.ImageAlign = ContentAlignment.MiddleLeft
        cmd_Configuracion.Location = New Point(897, 513)
        cmd_Configuracion.Name = "cmd_Configuracion"
        cmd_Configuracion.Size = New Size(195, 36)
        cmd_Configuracion.TabIndex = 6
        cmd_Configuracion.Text = "Configuracion"
        cmd_Configuracion.TextImageRelation = TextImageRelation.ImageBeforeText
        cmd_Configuracion.UseVisualStyleBackColor = True
        ' 
        ' cmd_MisPokemones
        ' 
        cmd_MisPokemones.FlatAppearance.BorderSize = 0
        cmd_MisPokemones.FlatStyle = FlatStyle.Flat
        cmd_MisPokemones.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmd_MisPokemones.ForeColor = Color.Red
        cmd_MisPokemones.Location = New Point(587, 439)
        cmd_MisPokemones.Name = "cmd_MisPokemones"
        cmd_MisPokemones.Size = New Size(199, 34)
        cmd_MisPokemones.TabIndex = 5
        cmd_MisPokemones.Text = "Mis Pokemones"
        cmd_MisPokemones.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Pikachu
        PictureBox1.Location = New Point(358, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(387, 365)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PantallaPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1104, 561)
        Controls.Add(PictureBox1)
        Controls.Add(cmd_MisPokemones)
        Controls.Add(cmd_Configuracion)
        Controls.Add(cmd_Gimnasio)
        Controls.Add(Cmd_InciarBatalla)
        Controls.Add(cmd_Nidos)
        Controls.Add(cmd_Pokedex)
        Controls.Add(Label2)
        Controls.Add(lbl_Bienvenida)
        Name = "PantallaPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PantallaPrincipal"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_Bienvenida As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_Pokedex As Button
    Friend WithEvents cmd_Nidos As Button
    Friend WithEvents Cmd_InciarBatalla As Button
    Friend WithEvents cmd_Gimnasio As Button
    Friend WithEvents cmd_Configuracion As Button
    Friend WithEvents cmd_MisPokemones As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
