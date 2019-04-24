Imports System.Web
Imports System.Net
Imports System.Net.Mail
Public Class Email
    ' Procédures et fonctions

    ''' <summary>
    ''' Permet d'envoyer un email
    ''' </summary>

    Private Sub envoyermail()
        Dim smtpServer As New SmtpClient()
        Dim mail As New MailMessage()
        Try
            smtpServer.Credentials = New Net.NetworkCredential(Me.TXT_email.Text, Me.TXT_passe.Text)
            smtpServer.Port = 587
            smtpServer.Host = "smtp.gmail.com"
            smtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress(Me.TXT_email.Text)
            mail.To.Add(Me.TXT_destinataire.Text)
            mail.Subject = Me.RTB_message.Text
            mail.Body = Me.TXT_sujet.Text
            smtpServer.Send(mail)
            MsgBox("Message envoyé avec succès", vbInformation, "Envoi réussi")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Permet d'effacer les champs envoyer
    ''' </summary>

    Private Sub effacerchamps()
        Me.RTB_message.Clear()
        Me.TXT_destinataire.Clear()
        Me.TXT_sujet.Clear()
    End Sub

    Private Sub BT_envoyer_Click(sender As Object, e As EventArgs) Handles BT_envoyer.Click
        ' Envoi du message
        envoyermail()
    End Sub

    Private Sub BT_effacer_Click(sender As Object, e As EventArgs) Handles BT_effacer.Click
        ' Nettoyage des champs envoyer
        effacerchamps()
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

    Private Sub Email_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Positionnement de la fenêtre
        Me.Location = New Point(-800, 200)
        Timer1.Start()
        Timer2.Start()
    End Sub
    ' Personnalisation des boutons
    Private Sub BT_envoyer_MouseHover(sender As Object, e As EventArgs) Handles BT_envoyer.MouseHover
        ' Bouton envoyer
        Me.BT_envoyer.BackColor = Color.Cyan
    End Sub
    Private Sub BT_envoyer_MouseLeave(sender As Object, e As EventArgs) Handles BT_envoyer.MouseLeave
        ' Bouton envoyer
        Me.BT_envoyer.BackColor = Color.Teal
    End Sub
    Private Sub BT_effacer_MouseHover(sender As Object, e As EventArgs) Handles BT_effacer.MouseHover
        ' Bouton effacer
        Me.BT_effacer.BackColor = Color.Cyan
    End Sub
    Private Sub BT_effacer_MouseLeave(sender As Object, e As EventArgs) Handles BT_effacer.MouseLeave
        ' Bouton effacer
        Me.BT_effacer.BackColor = Color.Teal
    End Sub

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