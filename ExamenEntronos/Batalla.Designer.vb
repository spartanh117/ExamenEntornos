<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBatalla
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
        Me.PBenemigo = New System.Windows.Forms.PictureBox()
        Me.PBJugador = New System.Windows.Forms.PictureBox()
        Me.btnIzquierda = New System.Windows.Forms.Button()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.btnAtaque1 = New System.Windows.Forms.Button()
        Me.btnAtaque2 = New System.Windows.Forms.Button()
        Me.btnAtaque3 = New System.Windows.Forms.Button()
        CType(Me.PBenemigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBJugador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBenemigo
        '
        Me.PBenemigo.Image = Global.ExamenEntronos.My.Resources.Resources.enemigo_unscreen
        Me.PBenemigo.Location = New System.Drawing.Point(559, 190)
        Me.PBenemigo.Name = "PBenemigo"
        Me.PBenemigo.Size = New System.Drawing.Size(167, 176)
        Me.PBenemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBenemigo.TabIndex = 1
        Me.PBenemigo.TabStop = False
        '
        'PBJugador
        '
        Me.PBJugador.Image = Global.ExamenEntronos.My.Resources.Resources.posicion1
        Me.PBJugador.Location = New System.Drawing.Point(63, 172)
        Me.PBJugador.Name = "PBJugador"
        Me.PBJugador.Size = New System.Drawing.Size(107, 194)
        Me.PBJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBJugador.TabIndex = 0
        Me.PBJugador.TabStop = False
        '
        'btnIzquierda
        '
        Me.btnIzquierda.Location = New System.Drawing.Point(63, 389)
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(33, 33)
        Me.btnIzquierda.TabIndex = 2
        Me.btnIzquierda.Text = "A"
        Me.btnIzquierda.UseVisualStyleBackColor = True
        '
        'btnDerecha
        '
        Me.btnDerecha.Location = New System.Drawing.Point(102, 389)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(31, 33)
        Me.btnDerecha.TabIndex = 3
        Me.btnDerecha.Text = "D"
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'btnAtaque1
        '
        Me.btnAtaque1.Location = New System.Drawing.Point(12, 12)
        Me.btnAtaque1.Name = "btnAtaque1"
        Me.btnAtaque1.Size = New System.Drawing.Size(75, 26)
        Me.btnAtaque1.TabIndex = 4
        Me.btnAtaque1.Text = "Ataque 1"
        Me.btnAtaque1.UseVisualStyleBackColor = True
        '
        'btnAtaque2
        '
        Me.btnAtaque2.Location = New System.Drawing.Point(95, 12)
        Me.btnAtaque2.Name = "btnAtaque2"
        Me.btnAtaque2.Size = New System.Drawing.Size(75, 26)
        Me.btnAtaque2.TabIndex = 5
        Me.btnAtaque2.Text = "Ataque 2"
        Me.btnAtaque2.UseVisualStyleBackColor = True
        '
        'btnAtaque3
        '
        Me.btnAtaque3.Location = New System.Drawing.Point(176, 12)
        Me.btnAtaque3.Name = "btnAtaque3"
        Me.btnAtaque3.Size = New System.Drawing.Size(75, 26)
        Me.btnAtaque3.TabIndex = 6
        Me.btnAtaque3.Text = "Ataque 3"
        Me.btnAtaque3.UseVisualStyleBackColor = True
        '
        'FormBatalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAtaque3)
        Me.Controls.Add(Me.btnAtaque2)
        Me.Controls.Add(Me.btnAtaque1)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.btnIzquierda)
        Me.Controls.Add(Me.PBenemigo)
        Me.Controls.Add(Me.PBJugador)
        Me.Name = "FormBatalla"
        Me.Text = "Batalla"
        CType(Me.PBenemigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBJugador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBJugador As PictureBox
    Friend WithEvents PBenemigo As PictureBox
    Friend WithEvents btnIzquierda As Button
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnAtaque1 As Button
    Friend WithEvents btnAtaque2 As Button
    Friend WithEvents btnAtaque3 As Button
End Class
