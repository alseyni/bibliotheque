Imports MySql.Data.MySqlClient

Public Class Prets
    ' Variables globales
    Public Shared nomServeur As String = ""
    Public Shared nomUser As String = ""
    Public Shared motPasse As String = ""
    Public Shared nomBase As String = ""
    ' Procédures et fonctions

    ''' <summary>
    ''' Permet d'enregistrer un prêt
    ''' </summary>

    Private Sub enregistrerpret()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim commande2 As New MySqlCommand
        Dim commande3 As New MySqlCommand
        Dim lecteur As MySqlDataReader
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande2.Connection = connexion
            commande3.Connection = connexion
            commande3.CommandText = "SELECT * FROM document WHERE code_doc = '" & Me.TXT_cod_doc_enr_prets.Text & "' and nb_exemp_dispo != 0"
            lecteur = commande3.ExecuteReader
            If lecteur.HasRows Then
                Try
                    lecteur.Close()
                    commande.CommandText = "INSERT INTO emprunter VALUES ('" & Me.DTP_date_emprunt_enr_prets.Text & "','" & Me.DTP_date_retour_enr_prets.Text & "', '" & Me.TXT_num_adherent_enr_prets.Text & "', '" & Me.TXT_cod_doc_enr_prets.Text & "')"
                    commande2.CommandText = "UPDATE document SET nb_exemp_dispo = nb_exemp_dispo - 1 WHERE code_doc = '" & Me.TXT_cod_doc_enr_prets.Text & "'"
                    commande.ExecuteNonQuery()
                    commande2.ExecuteNonQuery()
                    MsgBox("Prêt enregistré avec succès", vbInformation, "Enregistrement réussi")
                    connexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    connexion.Dispose()
                End Try
            Else
                MsgBox("Aucun exemplaire disponible pour ce document", vbCritical, "Erreur")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_adherent_enr_prets.Clear()
        Me.TXT_cod_doc_enr_prets.Clear()
        remplirdgvpret()
        remplirdgvemail()
        remplirdgvretard()
        remplirdgvhistorique()
        Documents.remplirdgv()
    End Sub

    ''' <summary>
    ''' Permet de remplir le datagridview de l'onglet enregistrement
    ''' </summary>

    Private Sub remplirdgvpret()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT date_emprunt AS 'Date emprunt', date_retour AS 'Date retour', num_adherent AS 'Numéro adherent', code_doc AS 'Code document' FROM emprunter"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_prets_enre_prets.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Permet de restituer un document
    ''' </summary>

    Private Sub restituerpret()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim commande2 As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande2.Connection = connexion
            commande.CommandText = "UPDATE document SET nb_exemp_dispo = nb_exemp_dispo + 1  WHERE code_doc = '" & Me.TXT_code_doc_restitution_prets.Text & "'"
            commande2.CommandText = "DELETE FROM emprunter WHERE num_adherent = '" & Me.TXT_num_adherent_restitution_prets.Text & "' and code_doc = '" & Me.TXT_code_doc_restitution_prets.Text & "'"
            commande.ExecuteNonQuery()
            commande2.ExecuteNonQuery()
            MsgBox("Document restitué avec succès", vbInformation, "Restitution réussie")
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_adherent_restitution_prets.Text = ""
        Me.TXT_code_doc_restitution_prets.Text = ""
        remplirdgvpret()
        remplirdgvemail()
        remplirdgvretard()
        remplirdgvhistorique()
    End Sub

    ''' <summary>
    ''' Permet de remplir le datagridview de l'onglet email
    ''' </summary>

    Private Sub remplirdgvemail()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT adherent.num_adherent AS 'Numéro adherent', adherent.nom AS 'Nom', adherent.prenom AS 'Prénom', adherent.email AS 'Adresse mail' FROM adherent, emprunter WHERE adherent.num_adherent = emprunter.num_adherent And emprunter.date_retour < DATE( NOW() )"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_email_email_prets.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Permet de pré-remplir le formulaire Email
    ''' </summary>

    Private Sub remplirmail()
        Dim destinataire As String = Me.TXT_email_email_prets.Text
        Dim sujet As String = "Restitution d'un document de la BMI"
        Dim message As String = "LA BMI Vous informe que vous avez accusé un retard dans la restitition du document."
        Email.TXT_destinataire.Text = destinataire
        Email.TXT_sujet.Text = sujet
        Email.RTB_message.Text = message
        Email.Show()
    End Sub


    ''' <summary>
    ''' Permet de remplir le datagridview de l'onglet retard
    ''' </summary>

    Private Sub remplirdgvretard()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT  emprunter.code_doc AS 'Code document', emprunter.date_emprunt AS 'Date emprunt', emprunter.date_retour AS 'Date retour', adherent.num_adherent AS 'Numéro adherent', adherent.nom AS 'Nom', adherent.prenom AS 'Prénom', adherent.email AS 'Adresse mail' FROM adherent, emprunter WHERE adherent.num_adherent = emprunter.num_adherent And emprunter.date_retour < DATE( NOW() )"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_retard_retard_prets.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Permet de remplir le datagridview de l'onglet historique
    ''' </summary>

    Private Sub remplirdgvhistorique()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT date_emprunt AS 'Date emprunt', date_retour AS 'Date retour', num_adherent AS 'Numéro adherent', code_doc AS 'Code document' FROM emprunter"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_historique_prets.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    Private Sub BT_accueil_Click(sender As Object, e As EventArgs) 
        Applications.Show()
        Me.Hide()
    End Sub

    Private Sub TM_prets_Tick(sender As Object, e As EventArgs) Handles TM_prets.Tick
        ' Affichage de la date et de l'heure
        LBL_date.Text = DateString
        LBL_heure.Text = TimeString
    End Sub

    Private Sub Prets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Activation du timer
        TM_prets.Enabled = True
        ' Remplissage des datagridview
        remplirdgvpret()
        remplirdgvemail()
        remplirdgvretard()
        remplirdgvhistorique()
    End Sub

    Private Sub Prets_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Fermeture du programme
        Chargement.Close()
    End Sub

    Private Sub BT_deconnexion_Click(sender As Object, e As EventArgs) 
        ' Déconnexion
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BT_enregistrer_enr_prets_Click(sender As Object, e As EventArgs) Handles BT_enregistrer_enr_prets.Click
        ' Enregistrement d'un prêt
        enregistrerpret()
    End Sub

    Private Sub BT_restituer_restitution_prets_Click(sender As Object, e As EventArgs) Handles BT_restituer_restitution_prets.Click
        ' Restitution du document
        restituerpret()
    End Sub

    Private Sub DGV_email_email_prets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_email_email_prets.CellClick
        ' Remplissage des textbox
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_email_email_prets.Rows(e.RowIndex)
                Me.TXT_num_adherent_email_prets.Text = ligne.Cells("Numéro adherent").Value.ToString
                Me.TXT_nom_email_prets.Text = ligne.Cells("Nom").Value.ToString
                Me.TXT_prenom_email_prets.Text = ligne.Cells("Prénom").Value.ToString
                Me.TXT_email_email_prets.Text = ligne.Cells("Adresse mail").Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BT_email_email_prets_Click(sender As Object, e As EventArgs) Handles BT_email_email_prets.Click
        ' Remplissage et affichage du formulaire email
        remplirmail()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        ' Fermeture du programme
        Form1.Close()
    End Sub

    Private Sub VérifierLaConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VérifierLaConnectionToolStripMenuItem.Click
        ' Vérification de la connexion
        Form1.verifierconnexion()
    End Sub

    Private Sub SeConnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeConnecterToolStripMenuItem.Click
        ' Affichage du formulaire Serveur
        Serveur.Show()
    End Sub
    ' Personnalisation des boutons
    Private Sub BT_enregistrer_enr_prets_MouseHover(sender As Object, e As EventArgs) Handles BT_enregistrer_enr_prets.MouseHover
        ' Bouton enregistrer
        Me.BT_enregistrer_enr_prets.BackColor = Color.Cyan
    End Sub
    Private Sub BT_enregistrer_enr_prets_MouseLeave(sender As Object, e As EventArgs) Handles BT_enregistrer_enr_prets.MouseLeave
        ' Bouton enregistrer
        Me.BT_enregistrer_enr_prets.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_restituer_restitution_prets_MouseHover(sender As Object, e As EventArgs) Handles BT_restituer_restitution_prets.MouseHover
        ' Bouton restituer
        Me.BT_restituer_restitution_prets.BackColor = Color.Cyan
    End Sub
    Private Sub BT_restituer_restitution_prets_MouseLeave(sender As Object, e As EventArgs) Handles BT_restituer_restitution_prets.MouseLeave
        ' Bouton restituer
        Me.BT_restituer_restitution_prets.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_email_email_prets_MouseHover(sender As Object, e As EventArgs) Handles BT_email_email_prets.MouseHover
        ' Bouton envoyer un email
        Me.BT_email_email_prets.BackColor = Color.Cyan
    End Sub
    Private Sub BT_email_email_prets_MouseLeave(sender As Object, e As EventArgs) Handles BT_email_email_prets.MouseLeave
        ' Bouton envoyer un email
        Me.BT_email_email_prets.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub BT_logouasz_Click(sender As Object, e As EventArgs) Handles BT_logouasz.Click
        ' Ouverture du formulaire UASZ
        UASZ.Show()
    End Sub

    Private Sub BT_logomi_Click(sender As Object, e As EventArgs) Handles BT_logomi.Click
        ' Ouverture du formulaire DMI
        DMI.Show()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        ' Ouverture du formulaire Apropos
        Apropos.Show()
    End Sub

    Private Sub SeDéconnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeDéconnecterToolStripMenuItem.Click
        ' Affichage du formulaire Form1
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub AccueilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccueilToolStripMenuItem.Click
        ' Affichage du formulaire Applications
        Applications.Show()
        Me.Hide()
    End Sub

    Private Sub AfficherLaideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherLaideToolStripMenuItem.Click
        ' Affichage du formulaire Aide
        Aide.Show()
    End Sub

    Private Sub DisciplinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisciplinesToolStripMenuItem.Click
        ' Affichage du formulaire Disciplines
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
End Class