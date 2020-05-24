Public Class MenuPausa
    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        FormBatalla.Timer.Start()
        FormBatalla.Timer2.Start()
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        MenuInicio.Show()
        FormBatalla.Close()
        Me.Close()
    End Sub
End Class