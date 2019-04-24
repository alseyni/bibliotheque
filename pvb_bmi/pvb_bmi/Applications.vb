Public Class Applications
    Private Sub Applications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activation du timer
        TM_applications.Enabled = True
    End Sub
    Private Sub Applications_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Fermeture du programme
        Form1.Close()
    End Sub

    Private Sub BT_disciplines_Click(sender As Object, e As EventArgs) Handles BT_disciplines.Click
        ' Affichage du formulaire Disciplines
        Disciplines.Show()
        Me.Hide()
    End Sub

    Private Sub BT_documents_Click(sender As Object, e As EventArgs) Handles BT_documents.Click
        ' Affichage du formulaire Documents
        Documents.Show()
        Me.Hide()
    End Sub

    Private Sub BT_usimple_Click(sender As Object, e As EventArgs) Handles BT_usimple.Click
        ' Affichage du formulaire Usimples
        Usimples.Show()
        Me.Hide()
    End Sub

    Private Sub BT_super_Click(sender As Object, e As EventArgs) Handles BT_super.Click
        ' Affichage du formulaire Usuper
        Usuper.Show()
        Me.Hide()
    End Sub

    Private Sub BT_prets_Click(sender As Object, e As EventArgs) Handles BT_prets.Click
        ' Affichage du formulaire Prets
        Prets.Show()
        Me.Hide()
    End Sub

    Private Sub LBL_menu_Click(sender As Object, e As EventArgs)
        'Déconnexion 
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TM_Applications_Tick(sender As Object, e As EventArgs) Handles TM_applications.Tick
        'Affichage de l'heure et de la date
        LBL_date.Text = DateString
        LBL_heure.Text = TimeString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BT_localisation.Click
        ' Affichage du formulaire Localisation
        Localisation.Show()
        Me.Hide()
    End Sub

    Private Sub VérifierLaConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VérifierLaConnectionToolStripMenuItem.Click
        ' Verification de la connexion
        Form1.verifierconnexion()
    End Sub

    Private Sub SeConnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeConnecterToolStripMenuItem.Click
        ' Affichage du formulaire serveur
        Serveur.Show()
    End Sub

    ' Personnalisation des boutons
    Private Sub BT_disciplines_MouseHover(sender As Object, e As EventArgs) Handles BT_disciplines.MouseHover
        ' Boutons disciplines
        Me.LBL_description.Text = "Espace Disciplines"
    End Sub
    Private Sub BT_disciplines_MouseLeave(sender As Object, e As EventArgs) Handles BT_disciplines.MouseLeave
        ' Boutons disciplines
        Me.LBL_description.Text = ""
    End Sub
    Private Sub BT_documents_MouseHover(sender As Object, e As EventArgs) Handles BT_documents.MouseHover
        ' Bouton documents
        Me.LBL_description.Text = "Espace Documents"
    End Sub
    Private Sub BT_documents_MouseLeave(sender As Object, e As EventArgs) Handles BT_documents.MouseLeave
        ' Bouton documents
        Me.LBL_description.Text = ""
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles BT_localisation.MouseHover
        ' Bouton localisation
        Me.LBL_description.Text = "Espace Localisation"
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles BT_localisation.MouseLeave
        'Bouton localisation
        Me.LBL_description.Text = ""
    End Sub
    Private Sub BT_usimple_MouseHover(sender As Object, e As EventArgs) Handles BT_usimple.MouseHover
        ' Bouton utilisateur simple
        Me.LBL_description.Text = "Espace Utilisteurs simple"
    End Sub
    Private Sub BT_usimple_MouseLeave(sender As Object, e As EventArgs) Handles BT_usimple.MouseLeave
        ' Bouton utilisateur simple
        Me.LBL_description.Text = ""
    End Sub
    Private Sub BT_super_MouseHover(sender As Object, e As EventArgs) Handles BT_super.MouseHover
        ' Bouton Super utilisateur
        Me.LBL_description.Text = "Espace super utilisateurs"
    End Sub
    Private Sub BT_super_MouseLeave(sender As Object, e As EventArgs) Handles BT_super.MouseLeave
        ' Bouton Super utilisateur
        Me.LBL_description.Text = ""
    End Sub
    Private Sub BT_prets_MouseHover(sender As Object, e As EventArgs) Handles BT_prets.MouseHover
        ' Bouton prêt
        Me.LBL_description.Text = "Espace Prêts"
    End Sub
    Private Sub BT_prets_MouseLeave(sender As Object, e As EventArgs) Handles BT_prets.MouseLeave
        ' Bouton prêt
        Me.LBL_description.Text = ""
    End Sub

    Private Sub BT_logouasz_Click(sender As Object, e As EventArgs) Handles BT_logouasz.Click
        ' Ouverture du formulaire UASZ
        UASZ.Show()
    End Sub

    Private Sub BT_logomi_Click(sender As Object, e As EventArgs) Handles BT_logomi.Click
        ' Ouverture du formulaire DMI
        DMI.Show()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        ' Fermeture du programme
        Chargement.Close()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        ' Affichage du formulaire Apropos
        Apropos.Show()
    End Sub

    Private Sub AfficherLaideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherLaideToolStripMenuItem.Click
        ' Affichage du formulaire Aide
        Aide.Show()
    End Sub

    Private Sub SeDéconnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeDéconnecterToolStripMenuItem.Click
        ' Affichage du formulaire principal
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub AccueilToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Affichage du formulaire Applications
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub DisciplinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisciplinesToolStripMenuItem.Click
        ' Affichage du formulaire disciplines
        Disciplines.Show()
        Me.Hide()
    End Sub

    Private Sub DocumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentsToolStripMenuItem.Click
        ' Affichage du formulaire Documents
        Documents.Show()
        Me.Hide()
    End Sub

    Private Sub LocalisationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalisationToolStripMenuItem.Click
        ' Affichage du formulaire Localisation
        Localisation.Show()
        Me.Hide()
    End Sub

    Private Sub UtilisateurSimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtilisateurSimpleToolStripMenuItem.Click
        ' Affichage du formulaire Usimples
        Usimples.Show()
        Me.Hide()
    End Sub

    Private Sub SuperUtilisateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuperUtilisateurToolStripMenuItem.Click
        ' Affichage du formulaire Usuper
        Usuper.Show()
        Me.Hide()
    End Sub

    Private Sub PrêtsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrêtsToolStripMenuItem.Click
        'Affichage du formuaire Prets
        Prets.Show()
        Me.Hide()
    End Sub
End Class