Imports MySql.Data.MySqlClient
Public Class Localisation
    ' Vaiables globales
    Dim connexion As New MySqlConnection
    Public Shared nomServeur As String = ""
    Public Shared nomUser As String = ""
    Public Shared motPasse As String = ""
    Public Shared nomBase As String = ""
    Dim commande As New MySqlCommand
    Dim lecteur As MySqlDataReader
    ' Déclarations et définition des procédures et fonctions
    ''' <summary>
    ''' Ajoute les informations dans la table rayon
    ''' </summary>
    Private Sub ajouterrayon()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "INSERT INTO rayon VALUES('" & Me.TXT_num_ray_rayons_loca.Text & "','" & Me.TXT_intitule_rayons_loca.Text & "')"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations ajoutées avec succès", vbInformation, "Ajout réussi")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_ray_rayons_loca.Text = ""
        Me.TXT_intitule_rayons_loca.Text = ""
        remplirdgvray()
    End Sub
    ''' <summary>
    ''' Modifie les informations de la table rayon
    ''' </summary>
    Private Sub modifierrayon()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "UPDATE rayon SET intitule = '" & Me.TXT_intitule_rayons_loca.Text & "' WHERE num_ray = '" & Me.TXT_num_ray_rayons_loca.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations modifiées avec succès", vbInformation, "Modification réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_ray_rayons_loca.Text = ""
        Me.TXT_intitule_rayons_loca.Text = ""
        remplirdgvray()
    End Sub
    ''' <summary>
    ''' Supprime les informations de la table rayon
    ''' </summary>
    Private Sub supprimerrayon()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "DELETE FROM rayon WHERE num_ray = '" & Me.TXT_num_ray_rayons_loca.Text & "' or intitule = '" & Me.TXT_intitule_rayons_loca.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations supprimées avec succès", vbInformation, "Suppression réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_ray_rayons_loca.Text = ""
        Me.TXT_intitule_rayons_loca.Text = ""
        remplirdgvray()
    End Sub
    ''' <summary>
    ''' Remplit le datagridview de l'onglet rayons
    ''' </summary>
    Private Sub remplirdgvray()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim commande1 As New MySqlCommand
        Dim commande2 As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT num_ray AS 'Numéro rayon', intitule AS Intitulé FROM rayon"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            DGV_rayons_rayons_loca.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Ajoute les informations dans la table groupe
    ''' </summary>
    Private Sub ajoutergroupe()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "INSERT INTO groupe VALUES('" & Me.TXT_code_groupe_groupes_loca.Text & "','" & Me.TXT_libelle_groupes_loca.Text & "')"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations ajoutées avec succès", vbInformation, "Ajout réussi")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_groupe_groupes_loca.Text = ""
        Me.TXT_libelle_groupes_loca.Text = ""
        remplirdgvgroupe()
    End Sub

    ''' <summary>
    ''' Modifie les informations de la table groupe
    ''' </summary>
    Private Sub modifiergroupe()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "UPDATE groupe SET libelle = '" & Me.TXT_libelle_groupes_loca.Text & "' WHERE code_group = '" & Me.TXT_code_groupe_groupes_loca.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations modifées avec succès", vbInformation, "Modification réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_groupe_groupes_loca.Text = ""
        Me.TXT_libelle_groupes_loca.Text = ""
        remplirdgvgroupe()
    End Sub

    ''' <summary>
    ''' Supprime les informations de la table groupe
    ''' </summary>
    Private Sub supprimergroupe()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "DELETE FROM groupe WHERE code_group = '" & Me.TXT_code_groupe_groupes_loca.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations supprimées avec succès", vbInformation, "Modification réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_groupe_groupes_loca.Text = ""
        Me.TXT_libelle_groupes_loca.Text = ""
        remplirdgvgroupe()
    End Sub

    ''' <summary>
    ''' Remplit le datagridview de l'onglet groupes
    ''' </summary>

    Private Sub remplirdgvgroupe()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim commande1 As New MySqlCommand
        Dim commande2 As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT code_group AS 'Code groupe', libelle AS Libellé FROM groupe"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            DGV_groupes_groupes_loca.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub
    Private Sub BT_ajouter_rayons_loca_Click(sender As Object, e As EventArgs) Handles BT_ajouter_rayons_loca.Click
        ' Ajout des informations dans la table rayon
        If MsgBox("Voulez-vous ajouter ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            ajouterrayon()
        End If
    End Sub

    Private Sub BT_modifier_rayons_loca_Click(sender As Object, e As EventArgs) Handles BT_modifier_rayons_loca.Click
        ' Modification des informations de la table rayon
        If MsgBox("Voulez-vous modifier ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            modifierrayon()
        End If
    End Sub

    Private Sub BT_supprimer_rayons_loca_Click(sender As Object, e As EventArgs) Handles BT_supprimer_rayons_loca.Click
        ' Suppression des informations de la table rayon
        If MsgBox("Voulez-vous supprimer ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            supprimerrayon()
        End If
    End Sub

    Private Sub Localisation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Activation du timer
        TM_Localisation.Enabled = True
        ' Remplissage du datagridview de l'onglet rayons
        remplirdgvray()
        remplirdgvgroupe()
    End Sub

    Private Sub Localisation_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Fermeture du programme
        Chargement.Close()
    End Sub

    Private Sub TM_Localisation_Tick(sender As Object, e As EventArgs) Handles TM_Localisation.Tick
        'Affichage de la date et de l'heure
        LBL_date.Text = DateString
        LBL_heure.Text = TimeString
    End Sub

    Private Sub BT_deconnexion_Click(sender As Object, e As EventArgs)
        ' Affichage du formulaire Form1
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BT_accueil_Click(sender As Object, e As EventArgs)
        ' Affichage dur formulaire Application
        Applications.Show()
        Me.Hide()
    End Sub

    Private Sub DGV_rayons_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_rayons_rayons_loca.CellClick
        ' Remplissage des textbox
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            ligne = Me.DGV_rayons_rayons_loca.Rows(e.RowIndex)
            Me.TXT_num_ray_rayons_loca.Text = ligne.Cells("Numéro rayon").Value.ToString
            Me.TXT_intitule_rayons_loca.Text = ligne.Cells("Intitulé").Value.ToString
        End If
    End Sub

    Private Sub BT_ajouter_groupes_loca_Click(sender As Object, e As EventArgs) Handles BT_ajouter_groupes_loca.Click
        ' Ajout des informations dans la table groupe
        If MsgBox("Voulez-vous ajouter ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            ajoutergroupe()
        End If
    End Sub

    Private Sub BT_modifier_groupes_loca_Click(sender As Object, e As EventArgs) Handles BT_modifier_groupes_loca.Click
        ' Modification des informtions de la table groupe
        If MsgBox("Voulez-vous modifier ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            modifiergroupe()
        End If
    End Sub

    Private Sub BT_supprimer_groupes_loca_Click(sender As Object, e As EventArgs) Handles BT_supprimer_groupes_loca.Click
        ' Suppression des informations de la table groupe
        If MsgBox("Voulez-vous supprimer ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            supprimergroupe()
        End If
    End Sub

    Private Sub DGV_groupes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_groupes_groupes_loca.CellClick
        ' Remplissage des textbox
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            ligne = Me.DGV_groupes_groupes_loca.Rows(e.RowIndex)
            Me.TXT_code_groupe_groupes_loca.Text = ligne.Cells("Code groupe").Value.ToString
            Me.TXT_libelle_groupes_loca.Text = ligne.Cells("Libellé").Value.ToString
        End If
    End Sub

    Private Sub VérifierLaConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VérifierLaConnectionToolStripMenuItem.Click
        ' Verifier la connexion
        Form1.verifierconnexion()
    End Sub

    Private Sub SeConnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeConnecterToolStripMenuItem.Click
        ' Affichage du formulaire Serveur
        Serveur.Show()
    End Sub

    Private Sub BT_logouasz_Click(sender As Object, e As EventArgs) Handles BT_logouasz.Click
        ' Ouverture du formulaire UASZ
        UASZ.Show()
    End Sub

    Private Sub BT_logomi_Click(sender As Object, e As EventArgs) Handles BT_logomi.Click
        ' Ouverture du formulaire DMI
        DMI.Show()
    End Sub
    ' Personnalisation des boutons
    Private Sub BT_ajouter_rayons_loca_MouseHover(sender As Object, e As EventArgs) Handles BT_ajouter_rayons_loca.MouseHover
        ' Bouton ajouter
        Me.BT_ajouter_rayons_loca.BackColor = Color.Cyan
    End Sub
    Private Sub BT_ajouter_rayons_loca_MouseLeave(sender As Object, e As EventArgs) Handles BT_ajouter_rayons_loca.MouseLeave
        ' Bouton ajouter
        Me.BT_ajouter_rayons_loca.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_modifier_rayons_loca_MouseHover(sender As Object, e As EventArgs) Handles BT_modifier_rayons_loca.MouseHover
        ' Bouton modifier
        Me.BT_modifier_rayons_loca.BackColor = Color.Cyan
    End Sub
    Private Sub BT_modifier_rayons_loca_MouseLeave(sender As Object, e As EventArgs) Handles BT_modifier_rayons_loca.MouseLeave
        ' Bouton modifier
        Me.BT_modifier_rayons_loca.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_supprimer_rayons_loca_MouseHover(sender As Object, e As EventArgs) Handles BT_supprimer_rayons_loca.MouseHover
        ' Bouton supprimer
        Me.BT_supprimer_rayons_loca.BackColor = Color.Cyan
    End Sub
    Private Sub BT_supprimer_rayons_loca_MouseLeave(sender As Object, e As EventArgs) Handles BT_supprimer_rayons_loca.MouseLeave
        ' Bouton supprimer
        Me.BT_supprimer_rayons_loca.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_ajouter_groupes_loca_MouseHover(sender As Object, e As EventArgs) Handles BT_ajouter_groupes_loca.MouseHover
        ' Bouton ajouter
        Me.BT_ajouter_groupes_loca.BackColor = Color.Cyan
    End Sub
    Private Sub BT_ajouter_groupes_loca_MouseLeave(sender As Object, e As EventArgs) Handles BT_ajouter_groupes_loca.MouseLeave
        ' Bouton ajouter
        Me.BT_ajouter_groupes_loca.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_modifier_groupes_loca_MouseHover(sender As Object, e As EventArgs) Handles BT_modifier_groupes_loca.MouseHover
        ' Bouton modifier
        BT_modifier_groupes_loca.BackColor = Color.Cyan
    End Sub
    Private Sub BT_modifier_groupes_loca_MouseLeave(sender As Object, e As EventArgs) Handles BT_modifier_groupes_loca.MouseLeave
        ' Bouton modifier
        BT_modifier_groupes_loca.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_supprimer_groupes_loca_MouseHover(sender As Object, e As EventArgs) Handles BT_supprimer_groupes_loca.MouseHover
        ' Bouton supprimer
        Me.BT_supprimer_groupes_loca.BackColor = Color.Cyan
    End Sub
    Private Sub BT_supprimer_groupes_loca_MouseLeave(sender As Object, e As EventArgs) Handles BT_supprimer_groupes_loca.MouseLeave
        ' Bouton supprimer
        Me.BT_supprimer_groupes_loca.BackColor = Color.Cyan
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        ' Fermeture du programme
        Form1.Close()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        ' Ouverture du formulaire Apropos
        Apropos.Show()
    End Sub

    Private Sub AccueilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccueilToolStripMenuItem.Click
        ' Affichage du formulaire Applications
        Applications.Show()
        Me.Hide()
    End Sub

    Private Sub SeDéconnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeDéconnecterToolStripMenuItem.Click
        ' Afichage du formulaire Form1
        Form1.Show()
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