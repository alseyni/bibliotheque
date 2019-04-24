Public Class DMI
    Private Sub LBL_fermer_Click(sender As Object, e As EventArgs) Handles LBL_fermer.Click
        ' Fermeture de la fenêtre
        Me.Close()
    End Sub
    ' Personnalisation du label fermer
    Private Sub LBL_fermer_MouseHover(sender As Object, e As EventArgs) Handles LBL_fermer.MouseHover
        Me.LBL_fermer.ForeColor = Color.Red
    End Sub
    Private Sub LBL_fermer_MouseLeave(sender As Object, e As EventArgs) Handles LBL_fermer.MouseLeave
        Me.LBL_fermer.ForeColor = Color.White
    End Sub
End Class