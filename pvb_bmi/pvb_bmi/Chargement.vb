Public Class Chargement
    Dim valeur As Integer = 1
    Private Sub Chargement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Démarrage du Timer
        Me.TM_chargement.Start()
    End Sub

    Private Sub TM_chargement_Tick(sender As Object, e As EventArgs) Handles TM_chargement.Tick
        ' Porpiétés de la fenêtre de chargement
        Me.PGB_chargement.Value += 1
        valeur += 1
        Me.LBL_valeur.Text = valeur & " %"
        Select Case (Me.PGB_chargement.Value)
            Case 1
                Me.LBL_message.ForeColor = Color.Red
            Case 50
                Me.LBL_message.ForeColor = Color.Yellow
            Case 90
                Me.LBL_message.ForeColor = Color.GreenYellow
            Case 97
                Me.TM_chargement.Interval = 1000
        End Select
        If (Me.PGB_chargement.Value = 100) Then
            TM_chargement.Stop()
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class