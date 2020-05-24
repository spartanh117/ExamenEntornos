Public Class FormBatalla
    ''' <summary>
    ''' Metodo que devuelve la vida del jugador
    ''' </summary>
    ''' <returns>la vida del jugador</returns>
    Private Function getVidaJugador()
        Return lblVidaJugador.Text
    End Function
    ''' <summary>
    ''' Modifica la vida del jugador
    ''' </summary>
    ''' <param name="vida">Integer que representa la vida del jugador</param>
    Private Sub setVidaJugador(ByVal vida As Integer)
        lblVidaJugador.Text = vida
    End Sub
    ''' <summary>
    ''' Metodo que devuelve la vida del enemigo
    ''' </summary>
    ''' <returns>la vida del enemigo</returns>
    Private Function getVidaEnemigo()
        Return lblVidaEnemigo.Text
    End Function
    ''' <summary>
    ''' Modifica la vida del jugador
    ''' </summary>
    ''' <param name="vida">Integer que representa la vida del Enemigo</param>
    Private Sub setVidaEnemigo(ByVal vida As Integer)
        lblVidaEnemigo.Text = vida
    End Sub
    ''' <summary>
    ''' metodo que cambia la imagen del jugador y que lo mueve hacia la izquierda
    ''' </summary>
    Private Sub moverIzquierda()

        pbJugador.Image = My.Resources.movimiento2
        pbJugador.Location = New Point(pbJugador.Location.X - 10, pbJugador.Location.Y)

    End Sub
    ''' <summary>
    ''' metodo que cambia la imagen del jugador y que lo mueve hacia la derecha
    ''' </summary>
    Private Sub moverDerecha()

        pbJugador.Image = My.Resources.movimiento
        pbJugador.Location = New Point(pbJugador.Location.X + 10, pbJugador.Location.Y)

    End Sub
    ''' <summary>
    ''' metodo que cambia la imagen del jugador y realiza el ataque 1(a distancia)
    ''' </summary>
    Private Sub ataque1()
        pbJugador.Image = My.Resources.ataque2
        Dim vida As Integer = getVidaEnemigo() 'He cambiado la asgnacion directa por un metodo getVida que devuelve el valor del label que muestra la vida de los personajes
        vida = vida - 100
        setVidaEnemigo(vida) 'He cambiado la asgnacion directa por un metodo que cambia del valor el label que muestra la vida de los personajes
        vida = vida - 100
    End Sub
    ''' <summary>
    ''' metodo que cambia la imagen del jugador y realiza el ataque 2(cuerpo a cuerpo)
    ''' </summary>
    Private Sub ataque2()
        pbJugador.Image = My.Resources.ataque3
        Dim rango1 As Integer = pbenemigo.Location.X - 95
        Dim rango2 As Integer = pbenemigo.Location.X + 95
        If pbJugador.Location.X > rango1 And pbJugador.Location.X < rango2 Then
            Dim vida As Integer = getVidaEnemigo()
            vida = vida - 200
            setVidaEnemigo(vida)
        End If
    End Sub
    ''' <summary>
    ''' manejador del evento click en el boton de mober hacia la izquierda
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub btnIzquierda_Click(sender As Object, e As EventArgs) Handles btnIzquierda.Click
        moverIzquierda()
    End Sub
    ''' <summary>
    ''' manejador del evento click en el boton de mober hacia la derecha
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        moverDerecha()
    End Sub
    ''' <summary>
    ''' manejador del evento click en el boton de ataque 1
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub btnAtaque1_Click(sender As Object, e As EventArgs) Handles btnAtaque1.Click
        ataque1()
    End Sub
    ''' <summary>
    ''' manejador del evento click en el boton de ataque 2
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub btnAtaque2_Click(sender As Object, e As EventArgs) Handles btnAtaque2.Click
        ataque2()
    End Sub
    ''' <summary>
    ''' metodo que mueve al enemigo hacia la posicion del juador y una vez se encuntre ahi, lo ataca
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If (pbenemigo.Location.X - 85) > pbJugador.Location.X Then
            pbenemigo.Location = New Point(pbenemigo.Location.X - 10, pbenemigo.Location.Y)
        ElseIf (pbenemigo.Location.X + 85) < pbJugador.Location.X Then
            pbenemigo.Location = New Point(pbenemigo.Location.X + 10, pbenemigo.Location.Y)
        End If
        Dim rango1 As Integer = pbJugador.Location.X - 95
        Dim rango2 As Integer = pbJugador.Location.X + 95
        If pbenemigo.Location.X > rango1 And pbenemigo.Location.X < rango2 Then
            Dim vida As Integer = getVidaJugador()
            vida = vida - 100
            setVidaJugador(vida)
        End If
    End Sub
    ''' <summary>
    ''' metodo que controla el fin de la partida
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If getVidaEnemigo() <= 0 Then
            Timer.Stop()
            Timer2.Stop()
            MsgBox("has ganado")
            Me.Close()
        ElseIf getVidaJugador() <= 0 Then
            Timer.Stop()
            Timer2.Stop()
            MsgBox("has perdido")
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' metodo que abre el menu de pausa, deneteniendo los dos timer
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub btnPausa_Click(sender As Object, e As EventArgs) Handles btnPausa.Click
        Timer.Stop()
        Timer2.Stop()
        MenuPausa.ShowDialog()
    End Sub
End Class
