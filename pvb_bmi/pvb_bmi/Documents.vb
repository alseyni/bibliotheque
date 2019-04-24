Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Documents
    ' Variables globales
    Public Shared nomServeur As String = ""
    Public Shared nomUser As String = ""
    Public Shared motPasse As String = ""
    Public Shared nomBase As String = ""

    ' Procédures et fonctions
    ''' <summary>
    ''' Permet d'ajouter les informations dans la table document
    ''' </summary>

    Private Sub ajouterdoc()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim couverturestream As New System.IO.MemoryStream()
        Me.PB_couverture_MAJ_doc.Image.Save(couverturestream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim couverture() As Byte = couverturestream.GetBuffer()
        couverturestream.Close()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "INSERT INTO document VALUES ('" & Me.TXT_code_doc_MAJ_doc.Text & "', '" & Me.TXT_titre_MAJ_doc.Text & "', '" & Me.TXT_annee_edition_MAJ_doc.Text & "', '" & Me.TXT_nb_exemp_MAJ_doc.Text & "', '" & Me.TXT_nb_exemp_MAJ_doc.Text & "', @couverture, '" & Me.TXT_num_rayon_MAJ_doc.Text & "', '" & Me.TXT_code_aut_MAJ_doc.Text & "', '" & Me.TXT_num_editeur_MAJ_doc.Text & "', '" & Me.TXT_code_dis_MAJ_doc.Text & "')"
            commande.Parameters.AddWithValue("@couverture", couverture)
            commande.ExecuteNonQuery()
            MsgBox("Document ajouté avec succès", vbInformation, "Ajout réussi")
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_doc_MAJ_doc.Clear()
        Me.TXT_titre_MAJ_doc.Clear()
        Me.TXT_nb_exemp_MAJ_doc.Clear()
        Me.TXT_num_rayon_MAJ_doc.Clear()
        Me.TXT_code_aut_MAJ_doc.Clear()
        Me.TXT_code_dis_MAJ_doc.Clear()
        Me.TXT_couverture_MAJ_doc.Clear()
        Me.OFD_Documents.FileName = Nothing
        Me.PB_couverture_MAJ_doc.ImageLocation = OFD_Documents.FileName
        Me.TXT_num_editeur_MAJ_doc.Clear()
        Me.TXT_annee_edition_MAJ_doc.Clear()
        remplirdgv()
    End Sub

    ''' <summary>
    ''' Modifie les informations de la table document
    ''' </summary>

    Private Sub modifierdoc()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Try
            Dim couverturestream As New System.IO.MemoryStream()
            Me.PB_couverture_MAJ_doc.Image.Save(couverturestream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim couverture() As Byte = couverturestream.GetBuffer()
            couverturestream.Close()
            connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
            Try
                connexion.Open()
                commande.Connection = connexion
                commande.CommandText = "UPDATE document set code_doc = '" & Me.TXT_code_doc_MAJ_doc.Text & "', titre = '" & Me.TXT_titre_MAJ_doc.Text & "', annee_edition = '" & Me.TXT_annee_edition_MAJ_doc.Text & "', nb_exemp = '" & Me.TXT_nb_exemp_MAJ_doc.Text & "', couverture = @couverture, num_ray = '" & Me.TXT_num_rayon_MAJ_doc.Text & "', code_auteur = '" & Me.TXT_code_aut_MAJ_doc.Text & "', num_editeur = '" & Me.TXT_num_editeur_MAJ_doc.Text & "', code_dis = '" & Me.TXT_code_dis_MAJ_doc.Text & "' WHERE code_doc = '" & Me.TXT_code_doc_MAJ_doc.Text & "'"
                commande.Parameters.AddWithValue("@couverture", couverture)
                commande.ExecuteNonQuery()
                MsgBox("Les informations ont été modifié avec succès", vbInformation, "Modification réussi")
                connexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connexion.Dispose()
            End Try
            Me.TXT_code_doc_MAJ_doc.Clear()
            Me.TXT_titre_MAJ_doc.Clear()
            Me.TXT_nb_exemp_MAJ_doc.Clear()
            Me.TXT_num_rayon_MAJ_doc.Clear()
            Me.TXT_code_aut_MAJ_doc.Clear()
            Me.TXT_code_dis_MAJ_doc.Clear()
            Me.OFD_Documents.FileName = Nothing
            Me.PB_couverture_MAJ_doc.ImageLocation = OFD_Documents.FileName
            Me.TXT_num_editeur_MAJ_doc.Clear()
            Me.TXT_annee_edition_MAJ_doc.Clear()
            remplirdgv()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Supprime un enregistrement dans la table document
    ''' </summary>

    Private Sub supprimerdoc()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "DELETE FROM document WHERE code_doc = '" & Me.TXT_code_doc_MAJ_doc.Text & "'"
            commande.ExecuteNonQuery()
            MsgBox("Les informations ont été supprimé avec succès", vbInformation, "Suppression réussi")
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_doc_MAJ_doc.Clear()
        Me.TXT_titre_MAJ_doc.Clear()
        Me.TXT_nb_exemp_MAJ_doc.Clear()
        Me.TXT_num_rayon_MAJ_doc.Clear()
        Me.TXT_code_aut_MAJ_doc.Clear()
        Me.TXT_code_dis_MAJ_doc.Clear()
        Me.OFD_Documents.FileName = Nothing
        Me.PB_couverture_MAJ_doc.ImageLocation = OFD_Documents.FileName
        Me.TXT_num_editeur_MAJ_doc.Clear()
        Me.TXT_annee_edition_MAJ_doc.Clear()
        remplirdgv()
    End Sub

    ''' <summary>
    ''' Remplit les datagridview
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
            commande.CommandText = "SELECT code_doc AS 'Code document', titre AS 'Titre', annee_edition AS 'Année edition', nb_exemp AS 'Nombre exemplaire(s)',  nb_exemp_dispo AS 'Nombre exemplaire disponible', num_ray AS 'Numéro rayon', code_auteur AS 'Code auteur', num_editeur AS 'Numéro éditeur', code_dis AS 'Code discipline', couverture AS 'Couverture' FROM document"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_MAJ_MAJ_doc.DataSource = source
            Me.DGV_recherche_rech_doc.DataSource = source
            Me.DGV_visualiser_visua_doc.DataSource = source
            Me.DGV_liste_documents_LD_doc.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Recherche un document
    ''' </summary>

    Private Sub rechercherdoc()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT code_doc AS 'Code document', titre AS 'Titre', annee_edition AS 'Année', nb_exemp AS 'Nombre exemplaire(s)',  nb_exemp_dispo AS 'Nombre exemplaire disponible', num_ray AS 'Numéro rayon', code_auteur AS 'Code auteur', num_editeur AS 'Numéro éditeur', code_dis AS 'Code discipline', couverture AS 'Couverture' FROM document WHERE code_doc = '" & Me.TXT_code_doc_rech_doc.Text & "' or titre = '" & Me.TXT_titre_rech_doc.Text & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                source.DataSource = lecteur
                Me.DGV_recherche_rech_doc.DataSource = source
                connexion.Close()
            Else
                MsgBox("La recherche n'a donné aucun résultat", vbCritical, "Erreur")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Ajoute un auteur dans la table auteur 
    ''' </summary>

    Private Sub ajouterauteur()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "INSERT INTO auteur values ('" & Me.TXT_code_auteur_LA_doc.Text & "', '" & Me.TXT_nom_LA_doc.Text & "', '" & Me.TXT_prenom_LA_doc.Text & "')"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations ajoutées avec succcès", vbInformation, "Ajout réussi")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_auteur_LA_doc.Clear()
        Me.TXT_nom_LA_doc.Clear()
        Me.TXT_prenom_LA_doc.Clear()
        remplirdgvla()
        Disciplines.remplirdgvla()
    End Sub

    ''' <summary>
    ''' Modifie les informations de la table auteur
    ''' </summary>

    Private Sub modifierauteur()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "UPDATE auteur SET nom = '" & Me.TXT_nom_LA_doc.Text & "', prenom = '" & Me.TXT_prenom_LA_doc.Text & "' WHERE code_auteur = '" & Me.TXT_code_auteur_LA_doc.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations modifiées avec succcès", vbInformation, "Modification réussi")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_auteur_LA_doc.Clear()
        Me.TXT_nom_LA_doc.Clear()
        Me.TXT_prenom_LA_doc.Clear()
        remplirdgvla()
        Disciplines.remplirdgvla()
    End Sub

    ''' <summary>
    ''' Supprime un enregistrement dans la table auteur
    ''' </summary>

    Private Sub supprimerauteur()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "DELETE FROM auteur WHERE code_auteur = '" & Me.TXT_code_auteur_LA_doc.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations supprimées avec succcès", vbInformation, "Suppression réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_code_auteur_LA_doc.Clear()
        Me.TXT_nom_LA_doc.Clear()
        Me.TXT_prenom_LA_doc.Clear()
        remplirdgvla()
        Disciplines.remplirdgvla()
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
            commande.CommandText = "SELECT code_auteur AS 'Code auteur', nom AS 'Nom', prenom AS 'Prénom' FROM auteur WHERE code_auteur = '" & Me.TXT_code_auteur_rech_LA_doc.Text & "' or nom = '" & Me.TXT_nom_rech_LA_doc.Text & "' or prenom = '" & Me.TXT_prenom_rech_LA_doc.Text & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                source.DataSource = lecteur
                DGV_lA_LA_doc.DataSource = source
                connexion.Close()
            Else
                MsgBox("La recherche n'a donné aucun résultat", vbCritical, "Erreur")
            End If
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
            commande.CommandText = "SELECT code_auteur AS 'Code auteur', nom AS 'Nom', prenom AS 'Prénom' FROM auteur"
            lecteur = commande.ExecuteReader()
            source.DataSource = lecteur
            DGV_lA_LA_doc.DataSource = source
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
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "INSERT INTO editeur values ('" & Me.TXT_num_edit_LE_doc.Text & "','" & Me.TXT_nom_LE_doc.Text & "')"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations ajoutées avec succcès", vbInformation, "Ajout réussi")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_edit_LE_doc.Clear()
        Me.TXT_nom_LE_doc.Clear()
        remplirdgvle()
        Disciplines.remplirdgvle()
    End Sub

    ''' <summary>
    ''' Modifie les informations de la table editeur
    ''' </summary>

    Private Sub modifierediteur()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "UPDATE editeur SET num_editeur = '" & Me.TXT_num_edit_LE_doc.Text & "', nom = '" & Me.TXT_nom_LE_doc.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations modifiées avec succcès", vbInformation, "Modification réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_edit_LE_doc.Clear()
        Me.TXT_nom_LE_doc.Clear()
        remplirdgvle()
        Disciplines.remplirdgvle()
    End Sub

    ''' <summary>
    ''' Supprime un enregistrement dans la table editeur
    ''' </summary>

    Private Sub supprimerediteur()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "DELETE FROM editeur WHERE num_editeur = '" & Me.TXT_num_edit_LE_doc.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Informations supprimées avec succcès", vbInformation, "Suppression réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_edit_LE_doc.Clear()
        Me.TXT_nom_LE_doc.Clear()
        remplirdgvle()
        Disciplines.remplirdgvle()
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
            commande.CommandText = "SELECT num_editeur AS 'Numéro éditeur', nom AS 'Nom' FROM editeur WHERE num_editeur = '" & Me.TXT_num_edit_rech_LE_doc.Text & "' or nom = '" & Me.TXT_nom_rech_LE_doc.Text & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                source.DataSource = lecteur
                DGV_LE_LE_doc.DataSource = source
                connexion.Close()
            Else
                MsgBox("La recherche n'a donné aucun résultat", vbCritical, "Erreur")
            End If
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
            commande.CommandText = "Select num_editeur As 'Numéro éditeur', nom As 'Nom' FROM editeur"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            DGV_LE_LE_doc.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    Private Sub BT_parcourir_maj_Click(sender As Object, e As EventArgs) Handles BT_parcourir_MAJ_doc.Click
        ' Ouverture du fichier
        Me.OFD_Documents.ShowDialog()
        Me.TXT_couverture_MAJ_doc.Text = Me.OFD_Documents.FileName
        Me.PB_couverture_MAJ_doc.ImageLocation = Me.OFD_Documents.FileName
    End Sub

    Private Sub BT_deconnexion_Click(sender As Object, e As EventArgs)
        'Déconnexion 
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TM_Documents_Tick(sender As Object, e As EventArgs) Handles TM_Documents.Tick
        'Affichage de l'heure et de la date
        LBL_date.Text = DateString
        LBL_heure.Text = TimeString
    End Sub

    Private Sub Documents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Activation du timer
        TM_Documents.Enabled = True
        ' Remplissage des datagridview
        remplirdgv()
        remplirdgvla()
        remplirdgvle()
    End Sub

    Private Sub Documents_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Fermeture du programme
        Chargement.Close()
    End Sub

    Private Sub BT_accueil_Click(sender As Object, e As EventArgs)
        ' Affichage du formulaire Applications
        Applications.Show()
        Me.Hide()
    End Sub

    Private Sub BT_ajouter_maj_Click(sender As Object, e As EventArgs) Handles BT_ajouter_MAJ_doc.Click
        ' Ajout d'un document
        If MsgBox("Voulez-vous ajouter ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            ajouterdoc()
        End If
    End Sub
    Private Sub BT_modifier_MAJ_doc_Click(sender As Object, e As EventArgs) Handles BT_modifier_MAJ_doc.Click
        ' Modification du document
        If MsgBox("Voulez-vous ajouter ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            modifierdoc()
        End If
    End Sub

    Private Sub BT_supprimer_MAJ_doc_Click(sender As Object, e As EventArgs) Handles BT_supprimer_MAJ_doc.Click
        ' Suppression du document
        If MsgBox("Voulez-vous supprimer ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            supprimerdoc()
        End If
    End Sub

    Private Sub DGV_MAJ_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_MAJ_MAJ_doc.CellClick
        ' Remplissage des textbox de l'onglet Mises à jour
        If e.RowIndex >= 0 Then
            Try
                Dim ligne As DataGridViewRow
                ligne = Me.DGV_MAJ_MAJ_doc.Rows(e.RowIndex)
                Me.TXT_code_doc_MAJ_doc.Text = ligne.Cells("Code document").Value.ToString
                Me.TXT_titre_MAJ_doc.Text = ligne.Cells("Titre").Value.ToString
                Me.TXT_nb_exemp_MAJ_doc.Text = ligne.Cells("Nombre exemplaire(s)").Value.ToString
                Me.TXT_num_rayon_MAJ_doc.Text = ligne.Cells("Numéro rayon").Value.ToString
                Me.TXT_num_editeur_MAJ_doc.Text = ligne.Cells("Numéro éditeur").Value.ToString
                Me.TXT_annee_edition_MAJ_doc.Text = ligne.Cells("Année edition").Value.ToString
                Me.TXT_code_dis_MAJ_doc.Text = ligne.Cells("Code discipline").Value.ToString
                Me.TXT_code_aut_MAJ_doc.Text = ligne.Cells("Code auteur").Value.ToString
                Dim photobyte() As Byte = ligne.Cells("couverture").Value
                Dim photostream As New System.IO.MemoryStream(photobyte)
                Me.PB_couverture_MAJ_doc.Image = Image.FromStream(photostream)
                photostream.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BT_rechercher_rech_doc_Click(sender As Object, e As EventArgs) Handles BT_rechercher_rech_doc.Click
        ' Recherche du document
        rechercherdoc()
    End Sub

    Private Sub BT_afficher_tout_rech_doc_Click(sender As Object, e As EventArgs) Handles BT_afficher_tout_rech_doc.Click
        ' Remplissage du datagridview
        remplirdgv()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_visualiser_visua_doc.CellClick
        ' Remplissage du formulaire visualiser
        Dim chaine As String = "************** Université Assane SECK de Ziguinchor **************" & vbNewLine & vbNewLine & vbNewLine
        If e.RowIndex >= 0 Then
            Try
                Dim ligne As DataGridViewRow
                ligne = DGV_visualiser_visua_doc.Rows(e.RowIndex)
                chaine += "Code document = " & ligne.Cells("Code document").Value.ToString & vbNewLine
                chaine += "Titre = " & ligne.Cells("Titre").Value.ToString & vbNewLine
                chaine += "Nombre d'exemplaires = " & ligne.Cells("Nombre exemplaire(s)").Value.ToString & vbNewLine
                chaine += "Numéro rayon = " & ligne.Cells("Numéro rayon").Value.ToString & vbNewLine
                chaine += "Numéro éditeur = " & ligne.Cells("Numéro éditeur").Value.ToString & vbNewLine
                chaine += "Code discipline = " & ligne.Cells("Code discipline").Value.ToString & vbNewLine
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Visualiser.RTB_visualiser.Text = chaine
    End Sub

    Private Sub BT_visualiser_visua_doc_Click(sender As Object, e As EventArgs) Handles BT_visualiser_visua_doc.Click
        ' Affichage du formulaire visualiser
        Visualiser.Show()
    End Sub

    Private Sub DGV_MAJ_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_MAJ_MAJ_doc.CellContentClick

    End Sub

    Private Sub BT_ajouter_la_doc_Click(sender As Object, e As EventArgs) Handles BT_ajouter_LA_doc.Click
        ' Ajout des informations dans la table auteur
        If MsgBox("Voulez-vous ajouter ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            ajouterauteur()
        End If
    End Sub

    Private Sub BT_modifier_la_doc_Click(sender As Object, e As EventArgs) Handles BT_modifier_LA_doc.Click
        ' Modification des inforamtions de la table auteur
        If MsgBox("Voulez-vous modifier ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            modifierauteur()
        End If
    End Sub

    Private Sub BT_supprimer_la_dis_Click(sender As Object, e As EventArgs) Handles BT_supprimer_LA_doc.Click
        ' Suppression des informations de la table auteur
        If MsgBox("Voulez-vous supprimer ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            supprimerauteur()
        End If
    End Sub

    Private Sub BT_rechercher_la_doc_Click(sender As Object, e As EventArgs) Handles BT_rechercher_LA_doc.Click
        ' Recherche d'un auteur
        rechercherauteur()
    End Sub

    Private Sub BT_afficher_tout_la_doc_Click(sender As Object, e As EventArgs) Handles BT_afficher_tout_LA_doc.Click
        ' Remplissage du gatagridview de l'onglet auteur
        remplirdgvla()
    End Sub

    Private Sub DGV_la_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_lA_LA_doc.CellClick
        ' Remplissage des textbox de l'onglet auteur
        If e.RowIndex >= 0 Then
            Try
                Dim ligne As DataGridViewRow
                ligne = Me.DGV_lA_LA_doc.Rows(e.RowIndex)
                Me.TXT_code_auteur_LA_doc.Text = ligne.Cells("Code auteur").Value.ToString
                Me.TXT_nom_LA_doc.Text = ligne.Cells("Nom").Value.ToString
                Me.TXT_prenom_LA_doc.Text = ligne.Cells("Prénom").Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BT_ajouter_le_doc_Click(sender As Object, e As EventArgs) Handles BT_ajouter_LE_doc.Click
        ' Ajoute les in formations dans la table editeur
        If MsgBox("Voulez-vous ajouter ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            ajouterediteur()
        End If
    End Sub

    Private Sub BT_modifier_le_doc_Click(sender As Object, e As EventArgs) Handles BT_modifier_LE_doc.Click
        ' Modifie les informations de la table editeur
        If MsgBox("Voulez-vous modifier ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            modifierediteur()
        End If
    End Sub

    Private Sub BT_supprimer_le_doc_Click(sender As Object, e As EventArgs) Handles BT_supprimer_LE_doc.Click
        ' Supprime les informations de la table editeur
        If MsgBox("Voulez-vous modifier ces informations ?", vbYesNo, "Veuillez confirmer") = vbYes Then
            supprimerediteur()
        End If
    End Sub

    Private Sub BT_rechercher_le_doc_Click(sender As Object, e As EventArgs) Handles BT_rechercher_LE_doc.Click
        ' Permet de rechercher un editeur
        rechercherediteur()
    End Sub

    Private Sub BT_afficher_tout_le_doc_Click(sender As Object, e As EventArgs) Handles BT_afficher_tout_LE_doc.Click
        ' Remplissage du datagridview de l'onglet editeur
        remplirdgvle()
    End Sub

    Private Sub DGV_le_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_LE_LE_doc.CellClick
        ' Remplissage des textbox de l'onglet editeur
        If e.RowIndex >= 0 Then
            Try
                Dim ligne As DataGridViewRow
                ligne = Me.DGV_LE_LE_doc.Rows(e.RowIndex)
                Me.TXT_num_edit_LE_doc.Text = ligne.Cells("Numéro éditeur").Value.ToString
                Me.TXT_nom_LE_doc.Text = ligne.Cells("Nom").Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        ' Fermeture du programme
        Form1.Close()
    End Sub

    Private Sub VérifierLaConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VérifierLaConnectionToolStripMenuItem.Click
        ' Verification de la connexion
        Form1.verifierconnexion()
    End Sub

    Private Sub SeConnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeConnecterToolStripMenuItem.Click
        ' Affichage du formulaire Serveur
        Serveur.Show()
    End Sub
    ' Personnaliser les boutons
    Private Sub BT_parcourir_maj_MouseHover(sender As Object, e As EventArgs) Handles BT_parcourir_MAJ_doc.MouseHover
        ' Bouton parcourir
        Me.BT_parcourir_MAJ_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_parcourir_maj_MouseLeave(sender As Object, e As EventArgs) Handles BT_parcourir_MAJ_doc.MouseLeave
        ' Bouton parcourir
        Me.BT_parcourir_MAJ_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_ajouter_maj_MouseHover(sender As Object, e As EventArgs) Handles BT_ajouter_MAJ_doc.MouseHover
        ' Bouton ajouter
        Me.BT_ajouter_MAJ_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_ajouter_maj_MouseLeave(sender As Object, e As EventArgs) Handles BT_ajouter_MAJ_doc.MouseLeave
        ' Bouton ajouter
        Me.BT_ajouter_MAJ_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_modifier_MAJ_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_modifier_MAJ_doc.MouseHover
        ' Bouton modifier
        Me.BT_modifier_MAJ_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_modifier_MAJ_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_modifier_MAJ_doc.MouseLeave
        ' Bouton modifier
        Me.BT_modifier_MAJ_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_supprimer_MAJ_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_supprimer_MAJ_doc.MouseHover
        ' Bouton supprimer
        Me.BT_supprimer_MAJ_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_supprimer_MAJ_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_supprimer_MAJ_doc.MouseLeave
        ' Bouton supprimer
        Me.BT_supprimer_MAJ_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_rechercher_rech_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_rechercher_rech_doc.MouseHover
        ' Bouton rechercher
        Me.BT_rechercher_rech_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_rechercher_rech_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_rechercher_rech_doc.MouseLeave
        ' Bouton rechercher
        Me.BT_rechercher_rech_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_afficher_tout_rech_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_afficher_tout_rech_doc.MouseHover
        ' Bouton afficher tout
        Me.BT_afficher_tout_rech_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_afficher_tout_rech_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_afficher_tout_rech_doc.MouseLeave
        ' Bouton afficher tout
        Me.BT_afficher_tout_rech_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_visualiser_visua_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_visualiser_visua_doc.MouseHover
        ' Bouton visualiser
        Me.BT_visualiser_visua_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_visualiser_visua_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_visualiser_visua_doc.MouseLeave
        ' Bouton visualiser
        Me.BT_visualiser_visua_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_ajouter_la_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_ajouter_LA_doc.MouseHover
        ' Bouton ajouter
        Me.BT_ajouter_LA_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_ajouter_la_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_ajouter_LA_doc.MouseLeave
        ' Bouton ajouter
        Me.BT_ajouter_LA_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_modifier_la_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_modifier_LA_doc.MouseHover
        ' Bouton modifier
        Me.BT_modifier_LA_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_modifier_la_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_modifier_LA_doc.MouseLeave
        ' Bouton modifier
        Me.BT_modifier_LA_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_supprimer_la_dis_MouseHover(sender As Object, e As EventArgs) Handles BT_supprimer_LA_doc.MouseHover
        ' Bouton supprimer
        Me.BT_supprimer_LA_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_supprimer_la_dis_MouseLeave(sender As Object, e As EventArgs) Handles BT_supprimer_LA_doc.MouseLeave
        ' Bouton supprimer
        Me.BT_supprimer_LA_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_rechercher_la_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_rechercher_LA_doc.MouseHover
        ' Bouton rechercher
        Me.BT_rechercher_LA_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_rechercher_la_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_rechercher_LA_doc.MouseLeave
        ' Bouton rechercher
        Me.BT_rechercher_LA_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_afficher_tout_la_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_afficher_tout_LA_doc.MouseHover
        ' Bouton afficher tout
        Me.BT_afficher_tout_LA_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_afficher_tout_la_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_afficher_tout_LA_doc.MouseLeave
        ' Bouton afficher tout
        Me.BT_afficher_tout_LA_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_ajouter_le_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_ajouter_LE_doc.MouseHover
        ' Bouton ajouter
        Me.BT_ajouter_LE_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_ajouter_le_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_ajouter_LE_doc.MouseLeave
        ' Bouton ajouter
        Me.BT_ajouter_LE_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_modifier_le_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_modifier_LE_doc.MouseHover
        ' Bouton modifier
        Me.BT_modifier_LE_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_modifier_le_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_modifier_LE_doc.MouseLeave
        ' Bouton modifier
        Me.BT_modifier_LE_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_supprimer_le_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_supprimer_LE_doc.MouseHover
        ' Bouton supprimer
        Me.BT_supprimer_LE_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_supprimer_le_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_supprimer_LE_doc.MouseLeave
        ' Bouton supprimer
        Me.BT_supprimer_LE_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_rechercher_le_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_rechercher_LE_doc.MouseHover
        ' Bouton rechercher
        Me.BT_rechercher_LE_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_rechercher_le_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_rechercher_LE_doc.MouseLeave
        ' Bouton rechercher
        Me.BT_rechercher_LE_doc.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_afficher_tout_le_doc_MouseHover(sender As Object, e As EventArgs) Handles BT_afficher_tout_LE_doc.MouseHover
        ' Bouton afficher tout
        Me.BT_afficher_tout_LE_doc.BackColor = Color.Cyan
    End Sub
    Private Sub BT_afficher_tout_le_doc_MouseLeave(sender As Object, e As EventArgs) Handles BT_afficher_tout_LE_doc.MouseLeave
        ' Bouton afficher tout
        Me.BT_afficher_tout_LE_doc.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub BT_logouasz_Click(sender As Object, e As EventArgs) Handles BT_logouasz.Click
        ' Ouverture du formulaire UASZ
        UASZ.Show()
    End Sub

    Private Sub BT_logomi_Click(sender As Object, e As EventArgs) Handles BT_logomi.Click
        ' Ouverture du formulaire DMI
        DMI.Show()
    End Sub

    Private Sub DGV_liste_documents_LD_doc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_liste_documents_LD_doc.CellClick
        ' Affichage de la couverture du document
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_liste_documents_LD_doc.Rows(e.RowIndex)
                Dim photobyte() As Byte = ligne.Cells("couverture").Value
                Dim photostream As New System.IO.MemoryStream(photobyte)
                Me.PB_couverture_LD_doc.Image = Image.FromStream(photostream)
                photostream.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGV_recherche_rech_doc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_recherche_rech_doc.CellClick
        ' Affichage de la couverture du document
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_recherche_rech_doc.Rows(e.RowIndex)
                Dim photobyte() As Byte = ligne.Cells("couverture").Value
                Dim photostream As New System.IO.MemoryStream(photobyte)
                Me.PB_couverture_rech_doc.Image = Image.FromStream(photostream)
                photostream.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGV_liste_documents_LD_doc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_liste_documents_LD_doc.CellContentClick

    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        ' Ouverture du formulaire Apropos
        Apropos.Show()
    End Sub

    Private Sub DGV_recherche_rech_doc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_recherche_rech_doc.CellContentClick

    End Sub

    Private Sub SeDéconnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeDéconnecterToolStripMenuItem.Click
        ' Affichage du formulaire Form1
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub AccueilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccueilToolStripMenuItem.Click
        ' Affichage du formiaire Applications
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