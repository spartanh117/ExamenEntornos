Public Class MenuPausa
    ''' <summary>
    ''' metodo que devuelve la partida, reactivando los timer
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        FormBatalla.Timer.Start()
        FormBatalla.Timer2.Start()
        Me.Close()
    End Sub
    ''' <summary>
    ''' metodo que termina la partida y vuelve al menu principal
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        MenuInicio.Show()
        FormBatalla.Close()
        Me.Close()
    End Sub
End Class