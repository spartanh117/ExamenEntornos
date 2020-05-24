Public Class FormBatalla
    Dim control = True

    Private Sub batalla_keyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        control = False
    End Sub

    Private Sub batalla_keyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        control = True
        If e.KeyData Like Keys.A Then
            moverIzquierda()
        ElseIf e.KeyData Like Keys.D Then
            moverDerecha()
        End If
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

    End Sub

    Private Sub ataque2()
        pbJugador.Image = My.Resources.ataque3

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
        If pbenemigo.Location.X > pbJugador.Location.X Then
            pbenemigo.Location = New Point(pbenemigo.Location.X - 10, pbenemigo.Location.Y)
        ElseIf pbenemigo.Location.X < pbJugador.Location.X Then
            pbenemigo.Location = New Point(pbenemigo.Location.X + 10, pbenemigo.Location.Y)
        End If
    End Sub
End Class
