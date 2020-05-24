<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuInicio
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
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pbMenuInicio = New System.Windows.Forms.PictureBox()
        CType(Me.pbMenuInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(343, 194)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar Juego"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(343, 278)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pbMenuInicio
        '
        Me.pbMenuInicio.Image = Global.ExamenEntronos.My.Resources.Resources.menuInicio
        Me.pbMenuInicio.Location = New System.Drawing.Point(177, 32)
        Me.pbMenuInicio.Name = "pbMenuInicio"
        Me.pbMenuInicio.Size = New System.Drawing.Size(428, 156)
        Me.pbMenuInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMenuInicio.TabIndex = 2
        Me.pbMenuInicio.TabStop = False
        '
        'MenuInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbMenuInicio)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIniciar)
        Me.Name = "MenuInicio"
        Me.Text = "MenuInicio"
        CType(Me.pbMenuInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pbMenuInicio As PictureBox
End Class
