Public Class MenuInicio
    ''' <summary>
    ''' metodo que inica el juego mostrndo el formBatalla
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        FormBatalla.Show()
    End Sub
    ''' <summary>
    ''' metodo que cierra la aplicacion
    ''' </summary>
    ''' <param name="sender">objeto sobre el que se ha producido el evento</param>
    ''' <param name="e"> el evento producido</param>
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class