<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Label1 = New Label()
        cmd_Atras = New Button()
        TabControl1 = New TabControl()
        tbCuenta = New TabPage()
        lbDerrotas = New Label()
        lbVictorias = New Label()
        lbFechaReg = New Label()
        cmdEditarFecha = New Button()
        cmdCambioContra = New Button()
        cmdEditarNombre = New Button()
        pickerFechaNac = New DateTimePicker()
        Label3 = New Label()
        lbIdJugador = New Label()
        txtNombreUsuario = New TextBox()
        Label2 = New Label()
        TabControl1.SuspendLayout()
        tbCuenta.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Snap ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(188, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(386, 47)
        Label1.TabIndex = 0
        Label1.Text = "Configuración"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' cmd_Atras
        ' 
        cmd_Atras.AccessibleDescription = "btn_Atras"
        cmd_Atras.BackColor = Color.Transparent
        cmd_Atras.FlatAppearance.BorderSize = 0
        cmd_Atras.FlatStyle = FlatStyle.Flat
        cmd_Atras.Font = New Font("Snap ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmd_Atras.ForeColor = SystemColors.ActiveCaptionText
        cmd_Atras.Location = New Point(12, 12)
        cmd_Atras.Name = "cmd_Atras"
        cmd_Atras.Size = New Size(89, 30)
        cmd_Atras.TabIndex = 6
        cmd_Atras.Text = "Atrás"
        cmd_Atras.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tbCuenta)
        TabControl1.Font = New Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(12, 48)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(562, 390)
        TabControl1.TabIndex = 0
        ' 
        ' tbCuenta
        ' 
        tbCuenta.Controls.Add(lbDerrotas)
        tbCuenta.Controls.Add(lbVictorias)
        tbCuenta.Controls.Add(lbFechaReg)
        tbCuenta.Controls.Add(cmdEditarFecha)
        tbCuenta.Controls.Add(cmdCambioContra)
        tbCuenta.Controls.Add(cmdEditarNombre)
        tbCuenta.Controls.Add(pickerFechaNac)
        tbCuenta.Controls.Add(Label3)
        tbCuenta.Controls.Add(lbIdJugador)
        tbCuenta.Controls.Add(txtNombreUsuario)
        tbCuenta.Controls.Add(Label2)
        tbCuenta.Location = New Point(4, 26)
        tbCuenta.Name = "tbCuenta"
        tbCuenta.Padding = New Padding(3)
        tbCuenta.Size = New Size(554, 360)
        tbCuenta.TabIndex = 0
        tbCuenta.Text = "Cuenta"
        tbCuenta.UseVisualStyleBackColor = True
        ' 
        ' lbDerrotas
        ' 
        lbDerrotas.AutoSize = True
        lbDerrotas.Font = New Font("Snap ITC", 12F)
        lbDerrotas.Location = New Point(21, 311)
        lbDerrotas.Name = "lbDerrotas"
        lbDerrotas.Size = New Size(110, 22)
        lbDerrotas.TabIndex = 0
        lbDerrotas.Text = "Derrotas - "
        ' 
        ' lbVictorias
        ' 
        lbVictorias.AutoSize = True
        lbVictorias.Font = New Font("Snap ITC", 12F)
        lbVictorias.Location = New Point(21, 277)
        lbVictorias.Name = "lbVictorias"
        lbVictorias.Size = New Size(115, 22)
        lbVictorias.TabIndex = 0
        lbVictorias.Text = "Victorias - "
        ' 
        ' lbFechaReg
        ' 
        lbFechaReg.AutoSize = True
        lbFechaReg.Font = New Font("Snap ITC", 12F)
        lbFechaReg.Location = New Point(21, 244)
        lbFechaReg.Name = "lbFechaReg"
        lbFechaReg.Size = New Size(191, 22)
        lbFechaReg.TabIndex = 0
        lbFechaReg.Text = "Fecha de registro - "
        ' 
        ' cmdEditarFecha
        ' 
        cmdEditarFecha.Location = New Point(263, 112)
        cmdEditarFecha.Name = "cmdEditarFecha"
        cmdEditarFecha.Size = New Size(81, 23)
        cmdEditarFecha.TabIndex = 4
        cmdEditarFecha.Text = "Editar"
        cmdEditarFecha.UseVisualStyleBackColor = True
        ' 
        ' cmdCambioContra
        ' 
        cmdCambioContra.Location = New Point(21, 157)
        cmdCambioContra.Name = "cmdCambioContra"
        cmdCambioContra.Size = New Size(157, 23)
        cmdCambioContra.TabIndex = 5
        cmdCambioContra.Text = "Cambiar contraseña"
        cmdCambioContra.UseVisualStyleBackColor = True
        ' 
        ' cmdEditarNombre
        ' 
        cmdEditarNombre.Location = New Point(263, 45)
        cmdEditarNombre.Name = "cmdEditarNombre"
        cmdEditarNombre.Size = New Size(81, 23)
        cmdEditarNombre.TabIndex = 2
        cmdEditarNombre.Text = "Editar"
        cmdEditarNombre.UseVisualStyleBackColor = True
        ' 
        ' pickerFechaNac
        ' 
        pickerFechaNac.Enabled = False
        pickerFechaNac.Location = New Point(21, 110)
        pickerFechaNac.Name = "pickerFechaNac"
        pickerFechaNac.Size = New Size(222, 23)
        pickerFechaNac.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 22)
        Label3.TabIndex = 0
        Label3.Text = "Fecha de nacimiento"
        ' 
        ' lbIdJugador
        ' 
        lbIdJugador.AutoSize = True
        lbIdJugador.Font = New Font("Snap ITC", 12F)
        lbIdJugador.Location = New Point(21, 208)
        lbIdJugador.Name = "lbIdJugador"
        lbIdJugador.Size = New Size(153, 22)
        lbIdJugador.TabIndex = 0
        lbIdJugador.Text = "ID de jugador - "
        ' 
        ' txtNombreUsuario
        ' 
        txtNombreUsuario.Enabled = False
        txtNombreUsuario.Location = New Point(21, 45)
        txtNombreUsuario.Name = "txtNombreUsuario"
        txtNombreUsuario.Size = New Size(222, 23)
        txtNombreUsuario.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 22)
        Label2.TabIndex = 0
        Label2.Text = "Nombre de usuario"
        ' 
        ' Configuracion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(585, 450)
        Controls.Add(TabControl1)
        Controls.Add(Label1)
        Controls.Add(cmd_Atras)
        Name = "Configuracion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Configuracion"
        TabControl1.ResumeLayout(False)
        tbCuenta.ResumeLayout(False)
        tbCuenta.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_Atras As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbCuenta As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents lbIdJugador As Label
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pickerFechaNac As DateTimePicker
    Friend WithEvents cmdEditarNombre As Button
    Friend WithEvents cmdCambioContra As Button
    Friend WithEvents cmdEditarFecha As Button
    Friend WithEvents lbDerrotas As Label
    Friend WithEvents lbVictorias As Label
    Friend WithEvents lbFechaReg As Label
End Class
