<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBatalla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBatalla))
        Me.btnIzquierda = New System.Windows.Forms.Button()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.btnAtaque1 = New System.Windows.Forms.Button()
        Me.btnAtaque2 = New System.Windows.Forms.Button()
        Me.pbenemigo = New System.Windows.Forms.PictureBox()
        Me.pbJugador = New System.Windows.Forms.PictureBox()
        Me.lblVidaJugador = New System.Windows.Forms.Label()
        Me.lblVidaEnemigo = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbenemigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJugador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnAtaque1.Size = New System.Drawing.Size(93, 26)
        Me.btnAtaque1.TabIndex = 4
        Me.btnAtaque1.Text = "Ataque 1"
        Me.btnAtaque1.UseVisualStyleBackColor = True
        '
        'btnAtaque2
        '
        Me.btnAtaque2.Location = New System.Drawing.Point(111, 12)
        Me.btnAtaque2.Name = "btnAtaque2"
        Me.btnAtaque2.Size = New System.Drawing.Size(96, 26)
        Me.btnAtaque2.TabIndex = 5
        Me.btnAtaque2.Text = "Ataque 2"
        Me.btnAtaque2.UseVisualStyleBackColor = True
        '
        'pbenemigo
        '
        Me.pbenemigo.Image = CType(resources.GetObject("pbenemigo.Image"), System.Drawing.Image)
        Me.pbenemigo.Location = New System.Drawing.Point(559, 190)
        Me.pbenemigo.Name = "pbenemigo"
        Me.pbenemigo.Size = New System.Drawing.Size(167, 176)
        Me.pbenemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbenemigo.TabIndex = 1
        Me.pbenemigo.TabStop = False
        '
        'pbJugador
        '
        Me.pbJugador.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbJugador.Image = CType(resources.GetObject("pbJugador.Image"), System.Drawing.Image)
        Me.pbJugador.Location = New System.Drawing.Point(63, 149)
        Me.pbJugador.Name = "pbJugador"
        Me.pbJugador.Size = New System.Drawing.Size(107, 194)
        Me.pbJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbJugador.TabIndex = 0
        Me.pbJugador.TabStop = False
        '
        'lblVidaJugador
        '
        Me.lblVidaJugador.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidaJugador.Location = New System.Drawing.Point(37, 59)
        Me.lblVidaJugador.Name = "lblVidaJugador"
        Me.lblVidaJugador.Size = New System.Drawing.Size(107, 35)
        Me.lblVidaJugador.TabIndex = 6
        Me.lblVidaJugador.Text = "1000"
        '
        'lblVidaEnemigo
        '
        Me.lblVidaEnemigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidaEnemigo.Location = New System.Drawing.Point(600, 59)
        Me.lblVidaEnemigo.Name = "lblVidaEnemigo"
        Me.lblVidaEnemigo.Size = New System.Drawing.Size(112, 35)
        Me.lblVidaEnemigo.TabIndex = 7
        Me.lblVidaEnemigo.Text = "1000"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'FormBatalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblVidaEnemigo)
        Me.Controls.Add(Me.lblVidaJugador)
        Me.Controls.Add(Me.btnAtaque2)
        Me.Controls.Add(Me.btnAtaque1)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.btnIzquierda)
        Me.Controls.Add(Me.pbenemigo)
        Me.Controls.Add(Me.pbJugador)
        Me.Name = "FormBatalla"
        Me.Text = "Batalla"
        CType(Me.pbenemigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJugador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbJugador As PictureBox
    Friend WithEvents pbenemigo As PictureBox
    Friend WithEvents btnIzquierda As Button
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnAtaque1 As Button
    Friend WithEvents btnAtaque2 As Button
    Friend WithEvents lblVidaJugador As Label
    Friend WithEvents lblVidaEnemigo As Label
    Friend WithEvents Timer As Timer
End Class
