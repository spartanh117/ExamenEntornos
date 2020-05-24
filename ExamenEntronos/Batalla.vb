Public Class FormBatalla

    Private Function getVidaJugador()
        Return lblVidaJugador.Text
    End Function
    Private Sub setVidaJugador(ByVal vida As Integer)
        lblVidaJugador.Text = vida
    End Sub

    Private Function getVidaEnemigo()
        Return lblVidaEnemigo.Text
    End Function
    Private Sub setVidaEnemigo(ByVal vida As Integer)
        lblVidaEnemigo.Text = vida
    End Sub
    Private Sub moverIzquierda()

        pbJugador.Image = My.Resources.movimiento2
        pbJugador.Location = New Point(pbJugador.Location.X - 10, pbJugador.Location.Y)

    End Sub

    Private Sub moverDerecha()

        pbJugador.Image = My.Resources.movimiento
        pbJugador.Location = New Point(pbJugador.Location.X + 10, pbJugador.Location.Y)

    End Sub
    Private Sub ataque1()
        pbJugador.Image = My.Resources.ataque2
        Dim vida As Integer = getVidaEnemigo()
        vida = vida - 100
        setVidaEnemigo(vida)
    End Sub

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

    Private Sub btnIzquierda_Click(sender As Object, e As EventArgs) Handles btnIzquierda.Click
        moverIzquierda()
    End Sub

    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        moverDerecha()
    End Sub

    Private Sub btnAtaque1_Click(sender As Object, e As EventArgs) Handles btnAtaque1.Click
        ataque1()
    End Sub

    Private Sub btnAtaque2_Click(sender As Object, e As EventArgs) Handles btnAtaque2.Click
        ataque2()
    End Sub

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

    Private Sub btnPausa_Click(sender As Object, e As EventArgs) Handles btnPausa.Click
        Timer.Stop()
        Timer2.Stop()
        MenuPausa.ShowDialog()
    End Sub
End Class
