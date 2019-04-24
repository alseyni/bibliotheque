Public Class Visualiser
    Private Sub BT_apercu_Click(sender As Object, e As EventArgs) Handles BT_apercu.Click
        If RTB_visualiser.Text = "" Then
            MsgBox("Veuillez saisir du texte", vbInformation, "Attention")
        Else
            Try
                PPD_visualiser.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BT_imprimer_Click(sender As Object, e As EventArgs) Handles BT_imprimer.Click
        Try
            PD_visualiser.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PD_visualiser_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD_visualiser.PrintPage
        Dim font1 As New Font("times new roman", 16, FontStyle.Regular)
        e.Graphics.DrawString(RTB_visualiser.Text, font1, Brushes.Black, 100, 100)
    End Sub

    Private Sub RTB_visualiser_TextChanged(sender As Object, e As EventArgs) Handles RTB_visualiser.TextChanged

    End Sub

    Private Sub Visualiser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Positionnement de la fenêtre
        Me.Location = New Point(-800, 200)
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Proriétés du timer 1
        Try
            Dim x As Double
            x = "0,20"
            If Me.Opacity <= 0.8 Then
                Me.Opacity = x
            ElseIf (Me.Opacity + x > 0.8) Then
                Timer1.Stop()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Proriétés du timer 2
        Me.Left += 20
        If Me.Left = 0 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub LBL_fermer_Click(sender As Object, e As EventArgs) Handles LBL_fermer.Click
        ' Fermeture de la fenêtre
        Me.Close()
    End Sub
    'Personnalisation des boutons
    Private Sub BT_apercu_MouseHover(sender As Object, e As EventArgs) Handles BT_apercu.MouseHover
        ' Bouton apercu
        Me.BT_apercu.BackColor = Color.Cyan
    End Sub
    Private Sub BT_apercu_MouseLeave(sender As Object, e As EventArgs) Handles BT_apercu.MouseLeave
        ' Bouton apercu
        Me.BT_apercu.BackColor = Color.Teal
    End Sub
    Private Sub BT_imprimer_MouseHover(sender As Object, e As EventArgs) Handles BT_imprimer.MouseHover
        ' Bouton imprimer
        Me.BT_imprimer.BackColor = Color.Cyan
    End Sub
    Private Sub BT_imprimer_MouseLeave(sender As Object, e As EventArgs) Handles BT_imprimer.MouseLeave
        ' Bouton imprimer
        Me.BT_imprimer.BackColor = Color.Teal
    End Sub
    ' Personnalisation du label fermer
    Private Sub LBL_fermer_MouseHover(sender As Object, e As EventArgs) Handles LBL_fermer.MouseHover
        Me.LBL_fermer.ForeColor = Color.Red
    End Sub
    Private Sub LBL_fermer_MouseLeave(sender As Object, e As EventArgs) Handles LBL_fermer.MouseLeave
        Me.LBL_fermer.ForeColor = Color.White
    End Sub
End Class