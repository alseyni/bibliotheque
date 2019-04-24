Imports MySql.Data.MySqlClient
Public Class Disciplines
    Dim connexion As New MySqlConnection
    Public Shared nomServeur As String = ""
    Public Shared nomUser As String = ""
    Public Shared motPasse As String = ""
    Public Shared nomBase As String = ""
    Dim commande As New MySqlCommand
    Dim lecteur As MySqlDataReader
    Dim source As New BindingSource
    ' Déclaration des procédures et fonctions
    ''' <summary>
    ''' ' Ajoute des données dans la table discipline
    ''' </summary>

    Private Sub ajouterdiscipline()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "INSERT INTO discipline values('" & Me.TXT_code_dis_MAJ_dis.Text & "', '" & Me.TXT_intitule_MAJ_dis.Text & "', '" & Me.TXT_code_groupe_MAJ_dis.Text & "')"
            commande.ExecuteNonQuery()
            MsgBox("Informations ajoutées avec succès", vbInformation, "Ajout réussi")
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_dis_MAJ_dis.Clear()
        Me.TXT_intitule_MAJ_dis.Clear()
        Me.TXT_code_groupe_MAJ_dis.Clear()
        remplirdgv()
    End Sub

    ''' <summary>
    ''' ' Remplit le datagridview de l'onglet mise à jour
    ''' </summary>

    Public Sub remplirdgv()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT code_dis AS 'Code discipline', intitule AS 'Intitulé', code_group AS 'Code groupe' FROM discipline"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            DGV_MAJ.DataSource = source
            DGV_recherche_rech_dis.DataSource = source
            DGV_LD_lD_dis.DataSource = source
            DGV_visualiser_visua_dis.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' ' Modifie les informations de la table discipline
    ''' </summary>

    Private Sub modifier()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "UPDATE discipline set intitule = '" & Me.TXT_intitule_MAJ_dis.Text & "', code_group = '" & Me.TXT_code_groupe_MAJ_dis.Text & "' WHERE code_dis = '" & Me.TXT_code_dis_MAJ_dis.Text & "'"
            commande.ExecuteNonQuery()
            MsgBox("Les informations ont été modifié avec succès", vbInformation, "Modification réussi")
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_dis_MAJ_dis.Clear()
        Me.TXT_intitule_MAJ_dis.Clear()
        Me.TXT_code_groupe_MAJ_dis.Clear()
        remplirdgv()
    End Sub

    ''' <summary>
    ''' ' Supprime un enregistrement dans la table discipline
    ''' </summary>

    Private Sub supprimer()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "DELETE FROM discipline WHERE code_dis = '" & Me.TXT_code_dis_MAJ_dis.Text & "'"
            commande.ExecuteNonQuery()
            MsgBox("Les informations ont été supprimé avec succès", vbInformation, "Suppression réussi")
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_dis_MAJ_dis.Clear()
        Me.TXT_intitule_MAJ_dis.Clear()
        Me.TXT_code_groupe_MAJ_dis.Clear()
        remplirdgv()
    End Sub

    ''' <summary>
    ''' ' Recherche une discipline suivant un ou plusieurs critères
    ''' </summary>

    Private Sub rechercher()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT code_dis AS 'Code discipline', intitule AS 'Intitulé', code_group AS 'Code groupe' FROM discipline WHERE code_dis = '" & Me.TXT_code_dis_rech_dis.Text & "'or intitule = '" & Me.TXT_intitule_rech_dis.Text & "'or code_group = '" & Me.TXT_code_groupe_rech.Text & "'"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            DGV_MAJ.DataSource = source
            DGV_recherche_rech_dis.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Ajoute les informations dans la table auteur
    ''' </summary>

    Private Sub ajouterauteur()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "INSERT INTO auteur values ('" & Me.TXT_code_auteur_lA_dis.Text & "','" & Me.TXT_nom_lA_dis.Text & "', '" & Me.TXT_prenom_lA_dis.Text & "')"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations ajoutées avec succcès", vbInformation, "Ajout réussi")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_auteur_lA_dis.Clear()
        Me.TXT_nom_lA_dis.Clear()
        Me.TXT_prenom_lA_dis.Clear()
        remplirdgvla()
        Documents.remplirdgvla()
    End Sub

    ''' <summary>
    ''' Modifie les informations de la table auteur
    ''' </summary>

    Private Sub modifierauteur()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "UPDATE auteur SET nom = '" & Me.TXT_nom_lA_dis.Text & "', prenom = '" & Me.TXT_prenom_lA_dis.Text & "' WHERE code_auteur = '" & Me.TXT_code_auteur_lA_dis.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations modifiées avec succcès", vbInformation, "Modification réussi")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_auteur_lA_dis.Clear()
        Me.TXT_nom_lA_dis.Clear()
        Me.TXT_prenom_lA_dis.Clear()
        remplirdgvla()
        Documents.remplirdgvla()
    End Sub

    ''' <summary>
    ''' Supprime un enregistrement dans la table auteur
    ''' </summary>

    Private Sub supprimerauteur()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "DELETE FROM auteur WHERE code_auteur = '" & Me.TXT_code_auteur_lA_dis.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations supprimées avec succcès", vbInformation, "Suppression réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_auteur_lA_dis.Clear()
        Me.TXT_nom_lA_dis.Clear()
        Me.TXT_prenom_lA_dis.Clear()
        remplirdgvla()
        Documents.remplirdgvla()
    End Sub

    ''' <summary>
    ''' Permet de rechercher un auteur
    ''' </summary>

    Private Sub rechercherauteur()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT code_auteur AS 'Code auteur', nom AS Nom, prenom AS Prénom FROM auteur WHERE code_auteur = '" & Me.TXT_code_auteur_rech_lA_dis.Text & "' or nom = '" & Me.TXT_nom_rech_lA_dis.Text & "' or prenom = '" & Me.TXT_prenom_rech_lA_dis.Text & "'"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            DGV_lA_lA_dis.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Remplit le datagridview de l'onglet auteur
    ''' </summary>

    Public Sub remplirdgvla()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT code_auteur AS 'Code auteur', nom AS Nom, prenom AS Prénom FROM auteur"
            lecteur = commande.ExecuteReader()
            source.DataSource = lecteur
            DGV_lA_lA_dis.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Ajoute les informations dans la table editeur
    ''' </summary>

    Private Sub ajouterediteur()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "INSERT INTO editeur values ('" & Me.TXT_num_edit_LE_dis.Text & "','" & Me.TXT_nom_LE_dis.Text & "')"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations ajoutées avec succcès", vbInformation, "Ajout réussi")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_edit_LE_dis.Clear()
        Me.TXT_nom_LE_dis.Clear()
        remplirdgvle()
        Documents.remplirdgvle()
    End Sub

    ''' <summary>
    ''' Modifie les informations de la table editeur
    ''' </summary>

    Private Sub modifierediteur()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "UPDATE editeur SET num_editeur = '" & Me.TXT_num_edit_LE_dis.Text & "', nom = '" & Me.TXT_nom_LE_dis.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations modifiées avec succcès", vbInformation, "Modification réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_edit_LE_dis.Clear()
        Me.TXT_nom_LE_dis.Clear()
        remplirdgvle()
        Documents.remplirdgvle()
    End Sub

    ''' <summary>
    ''' Supprime un enregistrement dans la table editeur
    ''' </summary>

    Private Sub supprimerediteur()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "DELETE FROM editeur WHERE num_editeur = '" & Me.TXT_num_edit_LE_dis.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations supprimées avec succcès", vbInformation, "Suppression réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_edit_LE_dis.Clear()
        Me.TXT_nom_LE_dis.Clear()
        remplirdgvle()
        Documents.remplirdgvle()
    End Sub

    ''' <summary>
    ''' Permet de rechercher un editeur
    ''' </summary>

    Private Sub rechercherediteur()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT num_editeur AS 'Numéro éditeur', nom AS Nom FROM editeur WHERE num_editeur = '" & Me.TXT_num_edit_rech_LE_dis.Text & "' or nom = '" & Me.TXT_nom_rech_LE_dis.Text & "'"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            DGV_lE_LE_dis.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Remplit le datagridview de l'onglet liste des editeurs
    ''' </summary>

    Public Sub remplirdgvle()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        commande.Connection = connexion
        Try
            connexion.Open()
            commande.CommandText = "Select num_editeur As 'Numéro éditeur', nom As Nom FROM editeur"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            DGV_lE_LE_dis.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles O_recherche.Click

    End Sub

    Private Sub BT_accueil_Click(sender As Object, e As EventArgs)
        ' Affichage du formulaire Applications
        Applications.Show()
        Me.Hide()
    End Sub

    Private Sub TM_Disciplines_Tick(sender As Object, e As EventArgs) Handles TM_Disciplines.Tick
        'Affichage de la date et de l'heure
        LBL_date.Text = DateString
        LBL_heure.Text = TimeString
    End Sub

    Private Sub Disciplines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activation du timer
        TM_Disciplines.Enabled = True
        ' Remplissage des datagridview
        remplirdgv()
        remplirdgvla()
        remplirdgvle()
    End Sub

    Private Sub Disciplines_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Fermeture du programme
        Chargement.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LBL_intitule_Click(sender As Object, e As EventArgs) Handles LBL_intitule_MAJ_dis.Click

    End Sub

    Private Sub O_maj_Click(sender As Object, e As EventArgs) Handles O_maj.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_lA_lA_dis.CellClick
        ' Remplissage des champs de l'onglet Liste des auteurs
        If e.RowIndex >= 0 Then
            Try
                Dim ligne As DataGridViewRow
                ligne = Me.DGV_lA_lA_dis.Rows(e.RowIndex)
                Me.TXT_code_auteur_lA_dis.Text = ligne.Cells("Code auteur").Value.ToString
                Me.TXT_nom_lA_dis.Text = ligne.Cells("Nom").Value.ToString
                Me.TXT_prenom_lA_dis.Text = ligne.Cells("Prénom").Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TBC_disciplines_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TBC_disciplines.SelectedIndexChanged

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BT_deconnexion_Click(sender As Object, e As EventArgs)
        ' Déconnexion
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub LBL_grouper_rech_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BT_ajouter_maj_Click(sender As Object, e As EventArgs) Handles BT_ajouter_MAJ_dis.Click
        ' Ajout d'une discipline
        If MsgBox("Voulez-vous ajouter ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            ajouterdiscipline()
        End If
    End Sub

    Private Sub TXT_libelle_maj_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DGV_MAJ_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_MAJ.CellClick
        ' ' Remplissage des champs de l'onglet Mises à jour
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_MAJ.Rows(e.RowIndex)
                TXT_code_dis_MAJ_dis.Text = ligne.Cells("Code discipline").Value.ToString
                TXT_intitule_MAJ_dis.Text = ligne.Cells("Intitulé").Value.ToString
                TXT_code_groupe_MAJ_dis.Text = ligne.Cells("Code groupe").Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TXT_intitule_rech_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BT_modifier_maj_Click(sender As Object, e As EventArgs) Handles BT_modifier_MAJ_dis.Click
        ' Modification de l'enregistrement
        If MsgBox("Voulez-vous modifier ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            modifier()
        End If
    End Sub

    Private Sub BT_supprimer_maj_Click(sender As Object, e As EventArgs) Handles BT_supprimer_MAJ_dis.Click
        ' Suppression de l'enregistrement
        If MsgBox("Voulez-vous supprimer ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            supprimer()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BT_afficher_tout_rech_dis.Click
        ' Affichage de tous les enregistrements
        remplirdgv()
    End Sub

    Private Sub BT_rechercher_rech_Click(sender As Object, e As EventArgs) Handles BT_rechercher_rech_dis.Click
        ' Recherche de l'enregistrement
        rechercher()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_LD_lD_dis.CellContentClick

    End Sub

    Private Sub BT_visualiser_visua_Click(sender As Object, e As EventArgs) Handles BT_visualiser_visua_dis.Click
        ' Affichage du formulaire visualiser
        Visualiser.Show()
    End Sub

    Private Sub DGV_visua_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_visualiser_visua_dis.CellClick
        ' Remplissage du formulaire visualiser
        Dim chaine As String = ""
        If e.RowIndex >= 0 Then
            Try
                Dim ligne As DataGridViewRow
                ligne = Me.DGV_MAJ.Rows(e.RowIndex)
                chaine += "Université Assane SECK de Ziguinchor" & vbNewLine & vbNewLine & vbNewLine
                chaine += "Code discipline = " & ligne.Cells("Code discipline").Value.ToString & vbNewLine
                chaine += "Intitulé = " & ligne.Cells("Intitulé").Value.ToString & vbNewLine
                chaine += "Code groupe = " & ligne.Cells("Code groupe").Value.ToString & vbNewLine
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Visualiser.RTB_visualiser.Text = chaine
    End Sub

    Private Sub DGV_MAJ_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_MAJ.CellContentClick

    End Sub

    Private Sub DataGridView5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_lE_LE_dis.CellClick
        ' ' Remplissage des champs de l'onglet Liste des editeurs
        If e.RowIndex >= 0 Then
            Try
                Dim ligne As DataGridViewRow
                ligne = Me.DGV_lE_LE_dis.Rows(e.RowIndex)
                Me.TXT_num_edit_LE_dis.Text = ligne.Cells("Numéro éditeur").Value.ToString
                Me.TXT_nom_LE_dis.Text = ligne.Cells("Nom").Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BT_ajouter_la_dis_Click(sender As Object, e As EventArgs) Handles BT_ajouter_lA_dis.Click
        ' Ajout des informtions dans la table auteur
        If MsgBox("Voulez-vous ajouter ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            ajouterauteur()
        End If
    End Sub

    Private Sub BT_modifier_la_dis_Click(sender As Object, e As EventArgs) Handles BT_modifier_lA_dis.Click
        ' Modification des informations de la table auteur
        If MsgBox("Voulez-vous modifier ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            modifierauteur()
        End If
    End Sub

    Private Sub BT_supprimer_la_dis_Click(sender As Object, e As EventArgs) Handles BT_supprimer_lA_dis.Click
        ' Suppression des informations de la table auteur
        If MsgBox("Voulez-vous supprimer ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            supprimerauteur()
        End If
    End Sub

    Private Sub BT_rechercher_la_dis_Click(sender As Object, e As EventArgs) Handles BT_rechercher_lA_dis.Click
        ' Recherche d'un auteur
        rechercherauteur()
    End Sub

    Private Sub BT_afficher_tout_la_dis_Click(sender As Object, e As EventArgs) Handles BT_afficher_tout_lA_dis.Click
        ' Remplissage du datagridview
        remplirdgvla()
    End Sub

    Private Sub BT_ajouter_le_dis_Click(sender As Object, e As EventArgs) Handles BT_ajouter_LE_dis.Click
        ' Ajout d'un éditeur
        If MsgBox("Voulez-vous modifier ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            ajouterediteur()
        End If
    End Sub

    Private Sub BT_modifier_le_dis_Click(sender As Object, e As EventArgs) Handles BT_modifier_LE_dis.Click
        ' Modification d'un éditeur
        If MsgBox("Voulez-vous modifier ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            modifierediteur()
        End If
    End Sub

    Private Sub BT_supprimer_le_dis_Click(sender As Object, e As EventArgs) Handles BT_supprimer_LE_dis.Click
        ' Suppression d'un éditeur
        If MsgBox("Voulez-vous supprimer ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            supprimerediteur()
        End If
    End Sub

    Private Sub BT_rechercher_le_dis_Click(sender As Object, e As EventArgs) Handles BT_rechercher_LE_dis.Click
        ' Recherche d'un éditeur
        rechercherediteur()
    End Sub

    Private Sub BT_afficher_tout_le_dis_Click(sender As Object, e As EventArgs) Handles BT_afficher_tout_LE_dis.Click
        ' Remplissage du datagridview
        remplirdgvle()
    End Sub

    Private Sub DGV_visua_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_visualiser_visua_dis.CellContentClick

    End Sub

    Private Sub DGV_la_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_lA_lA_dis.CellContentClick

    End Sub

    Private Sub DGV_le_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_lE_LE_dis.CellContentClick

    End Sub

    Private Sub VérifierLaConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VérifierLaConnectionToolStripMenuItem.Click
        ' Verifier la connexion
        Form1.verifierconnexion()
    End Sub

    Private Sub SeConnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeConnecterToolStripMenuItem.Click
        ' Affichage du formulaire
        Serveur.Show()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        ' Fermeture du programme
        Form1.Close()
    End Sub
    ' Personnalisation des boutons
    Private Sub BT_ajouter_maj_MouseHover(sender As Object, e As EventArgs) Handles BT_ajouter_MAJ_dis.MouseHover
        ' Bouton ajouter
        Me.BT_ajouter_MAJ_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_ajouter_maj_MouseLeave(sender As Object, e As EventArgs) Handles BT_ajouter_MAJ_dis.MouseLeave
        ' Bouton ajouter
        Me.BT_ajouter_MAJ_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_modifier_maj_MouseHover(sender As Object, e As EventArgs) Handles BT_modifier_MAJ_dis.MouseHover
        ' Bouton modifier
        Me.BT_modifier_MAJ_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_modifier_maj_MouseLeave(sender As Object, e As EventArgs) Handles BT_modifier_MAJ_dis.MouseLeave
        ' Bouton modifier
        Me.BT_modifier_MAJ_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_supprimer_maj_MouseHover(sender As Object, e As EventArgs) Handles BT_supprimer_MAJ_dis.MouseHover
        ' Bouton supprimer
        Me.BT_supprimer_MAJ_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_supprimer_maj_MouseLeave(sender As Object, e As EventArgs) Handles BT_supprimer_MAJ_dis.MouseLeave
        ' Bouton supprimer
        Me.BT_supprimer_MAJ_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_rechercher_rech_MouseHover(sender As Object, e As EventArgs) Handles BT_rechercher_rech_dis.MouseHover
        ' Bouton rechercher
        Me.BT_rechercher_rech_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_rechercher_rech_MouseLeave(sender As Object, e As EventArgs) Handles BT_rechercher_rech_dis.MouseLeave
        ' Bouton rechercher
        Me.BT_rechercher_rech_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles BT_afficher_tout_rech_dis.MouseHover
        ' Bouton afficher tout
        Me.BT_afficher_tout_rech_dis.BackColor = Color.Cyan
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles BT_afficher_tout_rech_dis.MouseLeave
        ' Bouton afficher tout
        Me.BT_afficher_tout_rech_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_visualiser_visua_MouseHover(sender As Object, e As EventArgs) Handles BT_visualiser_visua_dis.MouseHover
        ' Bouton visualiser
        Me.BT_visualiser_visua_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_visualiser_visua_MouseLeave(sender As Object, e As EventArgs) Handles BT_visualiser_visua_dis.MouseLeave
        ' Bouton visualiser
        Me.BT_visualiser_visua_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_ajouter_la_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_ajouter_lA_dis.MouseHover
        ' Bouton ajouter
        Me.BT_ajouter_lA_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_ajouter_la_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_ajouter_lA_dis.MouseLeave
        ' Bouton ajouter
        Me.BT_ajouter_lA_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_modifier_la_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_modifier_lA_dis.MouseHover
        ' Bouton  modifier
        Me.BT_modifier_lA_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_modifier_la_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_modifier_lA_dis.MouseLeave
        ' Bouton  modifier
        Me.BT_modifier_lA_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_supprimer_la_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_supprimer_lA_dis.MouseHover
        ' Bouton supprimer
        Me.BT_supprimer_lA_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_supprimer_la_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_supprimer_lA_dis.MouseLeave
        ' Bouton supprimer
        Me.BT_supprimer_lA_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_rechercher_la_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_rechercher_lA_dis.MouseHover
        ' Bouton rechercher
        Me.BT_rechercher_lA_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_rechercher_la_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_rechercher_lA_dis.MouseLeave
        ' Bouton rechercher
        Me.BT_rechercher_lA_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_afficher_tout_la_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_afficher_tout_lA_dis.MouseHover
        ' Bouton afficher tout
        Me.BT_afficher_tout_lA_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_afficher_tout_la_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_afficher_tout_lA_dis.MouseLeave
        ' Bouton afficher tout
        Me.BT_afficher_tout_lA_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_ajouter_le_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_ajouter_LE_dis.MouseHover
        ' Bouton ajouter
        Me.BT_ajouter_LE_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_ajouter_le_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_ajouter_LE_dis.MouseLeave
        ' Bouton ajouter
        Me.BT_ajouter_LE_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_modifier_le_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_modifier_LE_dis.MouseHover
        ' Bouton modifier
        Me.BT_modifier_LE_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_modifier_le_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_modifier_LE_dis.MouseLeave
        ' Bouton modifier
        Me.BT_modifier_LE_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_supprimer_le_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_supprimer_LE_dis.MouseHover
        ' Bouton supprimer
        Me.BT_supprimer_LE_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_supprimer_le_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_supprimer_LE_dis.MouseLeave
        ' Bouton supprimer
        Me.BT_supprimer_LE_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_rechercher_le_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_rechercher_LE_dis.MouseHover
        ' Bouton rechercher
        Me.BT_rechercher_LE_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_rechercher_le_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_rechercher_LE_dis.MouseLeave
        ' Bouton rechercher
        Me.BT_rechercher_LE_dis.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_afficher_tout_le_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_afficher_tout_LE_dis.MouseHover
        ' Bouton afficher tout
        Me.BT_afficher_tout_LE_dis.BackColor = Color.Cyan
    End Sub
    Private Sub BT_afficher_tout_le_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_afficher_tout_LE_dis.MouseLeave
        ' Bouton afficher tout
        Me.BT_afficher_tout_LE_dis.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub BT_logouasz_Click(sender As Object, e As EventArgs) Handles BT_logouasz.Click
        ' Ouverture du formulaire UASZ
        UASZ.Show()
    End Sub

    Private Sub BT_logomi_Click(sender As Object, e As EventArgs) Handles BT_logomi.Click
        ' Ouverure du formuliare DMI
        DMI.Show()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        ' Ouverture du formulaire Apropos
        Apropos.Show()
    End Sub

    Private Sub AfficherLaideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherLaideToolStripMenuItem.Click
        ' Affichage du formulaire Aide
        Aide.Show()
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