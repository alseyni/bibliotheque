Imports MySql.Data.MySqlClient
Public Class Serveur
    ' Déclaration et définition des procédures et fonctions

    ''' <summary>
    ''' Permet de vérifier la connexion avec la base de donée
    ''' </summary>

    Private Sub verifierconnexion()
        Dim parler = CreateObject("sapi.spvoice")
        Dim connexion As New MySqlConnection
        connexion.ConnectionString = "server=" + Me.TXT_server.Text + ";" + "userid=" + Me.TXT_nom_utilisateur.Text + ";" + "password=" + Me.TXT_mot_passe.Text + ";" + "database=" + Me.TXT_base_donnee.Text
        Try
            connexion.Open()
            parler.speak("Connexion à la base de donnée réussie")
            MsgBox("Connexion à la base de donnée réussie", vbInformation, "Connexion réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Permet d'enregistrer les informations de connexion dans les variables globales
    ''' </summary>
    Private Sub variables()
        ' Variables du formulaire Form1
        Form1.nomServeur = Me.TXT_server.Text
        Form1.nomUser = Me.TXT_nom_utilisateur.Text
        Form1.motPasse = Me.TXT_mot_passe.Text
        Form1.nomBase = Me.TXT_base_donnee.Text
        ' Variables du formulaire Discipines
        Disciplines.nomServeur = Me.TXT_server.Text
        Disciplines.nomUser = Me.TXT_nom_utilisateur.Text
        Disciplines.motPasse = Me.TXT_mot_passe.Text
        Disciplines.nomBase = Me.TXT_base_donnee.Text
        ' Variables du formulaire Documents
        Documents.nomServeur = Me.TXT_server.Text
        Documents.nomUser = Me.TXT_nom_utilisateur.Text
        Documents.motPasse = Me.TXT_mot_passe.Text
        Documents.nomBase = Me.TXT_base_donnee.Text
        ' Variables du formulaire Usimples
        Usimples.nomServeur = Me.TXT_server.Text
        Usimples.nomUser = Me.TXT_nom_utilisateur.Text
        Usimples.motPasse = Me.TXT_mot_passe.Text
        Usimples.nomBase = Me.TXT_base_donnee.Text
        ' Variables du formulaire Usuper
        Usuper.nomServeur = Me.TXT_server.Text
        Usuper.nomUser = Me.TXT_nom_utilisateur.Text
        Usuper.motPasse = Me.TXT_mot_passe.Text
        Usuper.nomBase = Me.TXT_base_donnee.Text
        ' Variables du formulaire Prêts
        Prets.nomServeur = Me.TXT_server.Text
        Prets.nomUser = Me.TXT_nom_utilisateur.Text
        Prets.motPasse = Me.TXT_mot_passe.Text
        Prets.nomBase = Me.TXT_base_donnee.Text
        ' Variables du formulaire Localisation
        Localisation.nomServeur = Me.TXT_server.Text
        Localisation.nomUser = Me.TXT_nom_utilisateur.Text
        Localisation.motPasse = Me.TXT_mot_passe.Text
        Localisation.nomBase = Me.TXT_base_donnee.Text
        MsgBox("Informations validées", vbInformation, "Validation réussie")
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

    Private Sub Serveur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Positionnement de la fenêtre
        Me.Location = New Point(-800, 300)
        Timer1.Start()
        Timer2.Start()
        ' Remplissage des champs
        Me.TXT_server.Text = "localhost"
        Me.TXT_nom_utilisateur.Text = "root"
        Me.TXT_mot_passe.Text = "super-programmeur"
        Me.TXT_base_donnee.Text = "pvb_bmi"
    End Sub

    Private Sub BT_valider_Click(sender As Object, e As EventArgs) Handles BT_valider.Click
        ' Validation des informations
        variables()
    End Sub

    Private Sub BT_verifier_Click(sender As Object, e As EventArgs) Handles BT_verifier.Click
        ' Vérification de la connexion
        verifierconnexion()
    End Sub
    'Personnalisation des boutons
    Private Sub BT_verifier_MouseHover(sender As Object, e As EventArgs) Handles BT_verifier.MouseHover
        ' Bouton verifier la connexion
        Me.BT_verifier.BackColor = Color.Cyan
    End Sub
    Private Sub BT_verifier_MouseLeave(sender As Object, e As EventArgs) Handles BT_verifier.MouseLeave
        ' Bouton verifier la connexion
        Me.BT_verifier.BackColor = Color.Teal
    End Sub
    Private Sub BT_valider_MouseHover(sender As Object, e As EventArgs) Handles BT_valider.MouseHover
        ' Bouton valider informations
        Me.BT_valider.BackColor = Color.Cyan
    End Sub
    Private Sub BT_valider_MouseLeave(sender As Object, e As EventArgs) Handles BT_valider.MouseLeave
        ' Bouton valider informations
        Me.BT_valider.BackColor = Color.Teal
    End Sub

    Private Sub LBL_fermer_Click(sender As Object, e As EventArgs) Handles LBL_fermer.Click
        ' Fermeture de la fenêtre
        Me.Close()
    End Sub
    'Personnalisation du label fermer
    Private Sub LBL_fermer_MouseHover(sender As Object, e As EventArgs) Handles LBL_fermer.MouseHover
        Me.LBL_fermer.ForeColor = Color.Red
    End Sub
    Private Sub LBL_fermer_MouseLeave(sender As Object, e As EventArgs) Handles LBL_fermer.MouseLeave
        Me.LBL_fermer.ForeColor = Color.White
    End Sub
End Class