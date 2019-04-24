Imports MySql.Data.MySqlClient
Public Class Usimples
    ' Variables globales
    Public Shared nomServeur As String = ""
    Public Shared nomUser As String = ""
    Public Shared motPasse As String = ""
    Public Shared nomBase As String = ""
    ' Déclaration et définition des procédures et fonctions

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
            commande.CommandText = "SELECT code_doc AS 'Code document', titre AS Titre, nb_exemp AS 'Nombre exemplaire(s)', couverture AS Couverture, num_ray AS 'Numéro rayon', num_editeur AS 'Numéro éditeur', code_dis AS 'Code discipline' FROM document WHERE code_doc = '" & Me.TXT_code_doc_rech_us.Text & "' or titre = '" & Me.TXT_titre_rech_us.Text & "'"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            If lecteur.HasRows Then
                Me.DGV_recherche_rech_us.DataSource = source
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
    ''' Remplit les datagridview
    ''' </summary>

    Private Sub remplirdgv()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT code_doc AS 'Code document', titre AS Titre, nb_exemp AS 'Nombre exemplaire(s)', couverture AS Couverture, num_ray AS 'Numéro rayon', num_editeur AS 'Numéro éditeur', code_dis AS 'Code discipline' FROM document"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_recherche_rech_us.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub


    ''' <summary>
    ''' Réserve un document
    ''' </summary>

    Private Sub reserver()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "INSERT INTO reserver VALUES('" & Me.DTP_date_reservation_reser_us.Text & "', '" & Me.TXT_num_adherent_reser_us.Text & "', '" & Me.TXT_code_document_reser_us.Text & "')"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Réservation effectué avec succès", vbInformation, "Réservation réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_adherent_reser_us.Clear()
        Me.TXT_code_document_reser_us.Clear()
        remplirdgvannuler()
    End Sub

    ''' <summary>
    ''' Remplit le datagridview de l'onglet liste des emprunts
    ''' </summary>

    Private Sub remplirdgvlemp()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT date_emprunt AS 'Date emprunt', date_retour AS 'Date retour', num_adherent AS 'Numéro adhérent', code_doc AS 'Code document' FROM emprunter"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_lE_LE_us.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Affiche les informations personnelles de l'étudiant
    ''' </summary>

    Private Sub afficherinfosetudiant()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT adherent.num_adherent, adherent.photo, adherent.nom, adherent.prenom, adherent.nationalite, adherent.telephone, adherent.email, adherent.login, adherent.mot_passe, etudiant.num_carte, etudiant.niveau_etud, etudiant.categorie_SP FROM adherent, etudiant WHERE etudiant.num_adherent = (SELECT adherent.num_adherent FROM adherent WHERE adherent.login = '" & Form1.logininfo & "') and adherent.login = '" & Form1.logininfo & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                Me.LBL_mat_ensei_iP_us.Visible = False
                Me.TXT_mat_ensei_iP_us.Visible = False
                Me.LBL_domaine_rech_iP_us.Visible = False
                Me.TXT_domaine_rech_iP_us.Visible = False
                Me.LBL_matieres_ensei_iP_us.Visible = False
                Me.TXT_matieres_ensei_iP_us.Visible = False
                While lecteur.Read
                    Me.TXT_num_adh_iP_us.Text = lecteur.GetInt32(0)
                    Me.TXT_num_adh_iP_us.Enabled = False
                    Dim photobyte() As Byte = lecteur.GetValue(1)
                    Dim photostream As New System.IO.MemoryStream(photobyte)
                    Me.PB_IP_iP_us.Image = Image.FromStream(photostream)
                    photostream.Close()
                    Me.TXT_nom_iP_us.Text = lecteur.GetString(2)
                    Me.TXT_prenom_iP_us.Text = lecteur.GetString(3)
                    Me.TXT_nationalite_iP_us.Text = lecteur.GetString(4)
                    Me.TXT_telephone_iP_us.Text = lecteur.GetInt64(5)
                    Me.TXT_email_iP_us.Text = lecteur.GetString(6)
                    Me.TXT_login_iP_us.Text = lecteur.GetString(7)
                    Me.TXT_mot_passe_iP_us.Text = lecteur.GetString(8)
                    Me.TXT_num_carte_iP_us.Text = lecteur.GetInt32(9)
                    Me.TXT_niveau_etude_iP_us.Text = lecteur.GetString(10)
                    Me.TXT_cat_sp_iP_us.Text = lecteur.GetString(11)
                End While
            End If
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Affiche les informations personnelles de l'enseignant
    ''' </summary>

    Private Sub afficherinfosenseignant()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT adherent.num_adherent, adherent.photo, adherent.nom, adherent.prenom, adherent.nationalite, adherent.telephone, adherent.email, adherent.login, adherent.mot_passe, enseignant.mat_ensei, enseignant.domaine_rech FROM adherent, enseignant WHERE enseignant.num_adherent = (SELECT adherent.num_adherent FROM adherent WHERE adherent.login = '" & Form1.logininfo & "') and adherent.login = '" & Form1.logininfo & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                Me.LBL_num_carte_iP_us.Visible = False
                Me.TXT_num_carte_iP_us.Visible = False
                Me.LBL_niveau_etude_iP_us.Visible = False
                Me.TXT_niveau_etude_iP_us.Visible = False
                Me.LBL_cat_sp_iP_us.Visible = False
                Me.TXT_cat_sp_iP_us.Visible = False
                While lecteur.Read
                    Me.TXT_num_adh_iP_us.Text = lecteur.GetInt32(0)
                    Me.TXT_num_adh_iP_us.Enabled = False
                    Dim photobyte() As Byte = lecteur.GetValue(1)
                    Dim photostream As New System.IO.MemoryStream(photobyte)
                    Me.PB_IP_iP_us.Image = Image.FromStream(photostream)
                    photostream.Close()
                    Me.TXT_nom_iP_us.Text = lecteur.GetString(2)
                    Me.TXT_prenom_iP_us.Text = lecteur.GetString(3)
                    Me.TXT_nationalite_iP_us.Text = lecteur.GetString(4)
                    Me.TXT_telephone_iP_us.Text = lecteur.GetInt64(5)
                    Me.TXT_email_iP_us.Text = lecteur.GetString(6)
                    Me.TXT_login_iP_us.Text = lecteur.GetString(7)
                    Me.TXT_mot_passe_iP_us.Text = lecteur.GetString(8)
                    Me.TXT_mat_ensei_iP_us.Text = lecteur.GetInt32(9)
                    Me.TXT_domaine_rech_iP_us.Text = lecteur.GetString(10)
                    Me.TXT_matieres_ensei_iP_us.Text = lecteur.GetString(11)
                End While
            End If
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Permet de mettre à jour un etudiant
    ''' </summary>

    Private Sub modifieretud()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim commande2 As New MySqlCommand
        Dim photostream As New System.IO.MemoryStream()
        Me.PB_IP_iP_us.Image.Save(photostream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim photo() As Byte = photostream.GetBuffer()
        photostream.Close()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        commande.Connection = connexion
        commande2.Connection = connexion
        If (Me.TXT_num_adh_iP_us.Text <> "" And Me.TXT_nom_iP_us.Text <> "" And Me.TXT_prenom_iP_us.Text <> "" And Me.TXT_nationalite_iP_us.Text <> "" And Me.TXT_telephone_iP_us.Text <> "" And Me.TXT_login_iP_us.Text <> "" And Me.TXT_login_iP_us.Text <> "" And Me.TXT_mot_passe_iP_us.Text <> "" And Me.TXT_num_carte_iP_us.Text <> "" And Me.TXT_niveau_etude_iP_us.Text <> "" And Me.TXT_cat_sp_iP_us.Text <> "") Then
            Try
                connexion.Open()
                commande.CommandText = "UPDATE adherent SET nom = '" & Me.TXT_nom_iP_us.Text & "', prenom = '" & Me.TXT_prenom_iP_us.Text & "', photo = @photo, nationalite = '" & Me.TXT_nationalite_iP_us.Text & "', telephone = '" & Me.TXT_telephone_iP_us.Text & "', email = '" & Me.TXT_email_iP_us.Text & "', login = '" & Me.TXT_login_iP_us.Text & "', mot_passe = '" & Me.TXT_mot_passe_iP_us.Text & "' WHERE num_adherent = '" & Me.TXT_num_adh_iP_us.Text & "'"
                commande.Parameters.AddWithValue("@photo", photo)
                commande2.CommandText = "UPDATE etudiant SET num_carte = '" & Me.TXT_num_carte_iP_us.Text & "', niveau_etud = '" & Me.TXT_niveau_etude_iP_us.Text & "', categorie_SP = '" & Me.TXT_cat_sp_iP_us.Text & "'"
                commande.ExecuteNonQuery()
                connexion.Close()
                MsgBox("Informations modifiées avec succès", vbInformation, "Modification réussie")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connexion.Dispose()
            End Try
            Usuper.remplirdgvad()
            Usuper.remplirdgvajtd()
            Usuper.remplirdgvetudiants()
            Usuper.remplirdgdvenseignants()
        Else
            MsgBox("Modification impossible", vbInformation, "Erreur")
        End If
    End Sub

    ''' <summary>
    ''' Permet de mettre à jour un enseignant
    ''' </summary>

    Private Sub modifierens()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim commande2 As New MySqlCommand
        Dim photostream As New System.IO.MemoryStream()
        Me.PB_IP_iP_us.Image.Save(photostream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim photo() As Byte = photostream.GetBuffer()
        photostream.Close()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        commande.Connection = connexion
        commande2.Connection = connexion
        If (Me.TXT_num_adh_iP_us.Text <> "" And Me.TXT_nom_iP_us.Text <> "" And Me.TXT_prenom_iP_us.Text <> "" And Me.TXT_nationalite_iP_us.Text <> "" And Me.TXT_telephone_iP_us.Text <> "" And Me.TXT_email_iP_us.Text <> "" And Me.TXT_login_iP_us.Text <> "" And Me.TXT_mot_passe_iP_us.Text <> "" And Me.TXT_mat_ensei_iP_us.Text <> "" And Me.TXT_domaine_rech_iP_us.Text <> "" And Me.TXT_mat_ensei_iP_us.Text <> "") Then
            Try
                connexion.Open()
                commande.CommandText = "UPDATE adherent SET nom = '" & Me.TXT_nom_iP_us.Text & "', prenom = '" & Me.TXT_prenom_iP_us.Text & "', photo = @photo, nationalite = '" & Me.TXT_nationalite_iP_us.Text & "', telephone = '" & Me.TXT_telephone_iP_us.Text & "', email = '" & Me.TXT_email_iP_us.Text & "', login = '" & Me.TXT_login_iP_us.Text & "', mot_passe = '" & Me.TXT_mot_passe_iP_us.Text & "' WHERE num_adherent = '" & Me.TXT_num_adh_iP_us.Text & "'"
                commande.Parameters.AddWithValue("@photo", photo)
                commande2.CommandText = "UPDATE enseignant SET mat_ensei = '" & Me.TXT_mat_ensei_iP_us.Text & "', domaine_rech = '" & Me.TXT_niveau_etude_iP_us.Text & "', matiere_enseign = '" & Me.TXT_mat_ensei_iP_us.Text & "'"
                commande.ExecuteNonQuery()
                connexion.Close()
                MsgBox("Informations modifiées avec succès", vbInformation, "Modification réussie")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connexion.Dispose()
            End Try
            Usuper.remplirdgvad()
            Usuper.remplirdgvajtd()
            Usuper.remplirdgvetudiants()
            Usuper.remplirdgdvenseignants()
            MsgBox("Modification impossible", vbInformation, "Erreur")
        End If
    End Sub

    ''' <summary>
    ''' Permet d'annuler une reservation
    ''' </summary>

    Private Sub annuler()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "DELETE FROM reserver WHERE date_reservation = '" & Me.DTP_date_reservation_annuler_us.Text & "' and num_adherent = '" & Me.TXT_num_adherent_annuler_us.Text & "' and code_doc = '" & Me.TXT_code_doc_annuler_us.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            MsgBox("Réservation annulée avec succès", vbInformation, "Annulation réussie")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_adherent_annuler_us.Clear()
        Me.TXT_code_doc_annuler_us.Clear()
        remplirdgvannuler()
    End Sub

    ''' <summary>
    ''' Permet de remplir le datagridview de l'onglet annuler
    ''' </summary>

    Private Sub remplirdgvannuler()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT date_reservation AS 'Date reservation', num_adherent AS 'Numéro adherent', code_doc AS 'Code document' FROM reserver"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_annuler_annuler_us.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub
    Private Sub BT_accueil_Click(sender As Object, e As EventArgs)
        ' Affichage du formulaire Applications
        Applications.Show()
        Me.Hide()
    End Sub

    Private Sub TM_Usimples_Tick(sender As Object, e As EventArgs) Handles TM_Usimples.Tick
        ' Affichage de la date et de l'heure
        LBL_date.Text = DateString
        LBL_heure.Text = TimeString
    End Sub

    Private Sub Usimples_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Activation du timer
        TM_Usimples.Enabled = True
        ' Remplissage des datagridview
        remplirdgv()
        remplirdgvlemp()
        ' Remplissage des datagridview
        afficherinfosetudiant()
        afficherinfosenseignant()
        remplirdgvannuler()
    End Sub

    Private Sub Usimples_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Fermeture du programme
        Chargement.Close()
    End Sub

    Private Sub BT_deconnexion_Click(sender As Object, e As EventArgs)
        ' Déconnexion
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub O_etudiants_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LBL_cdoc__ens_ins_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BT_rechercher_rech_us_Click(sender As Object, e As EventArgs) Handles BT_rechercher_rech_us.Click
        ' Recherche un document
        rechercherdoc()
    End Sub

    Private Sub BT_afficher_tout_rech_us_Click(sender As Object, e As EventArgs) Handles BT_afficher_tout_rech_us.Click
        ' Remlissage du datagridview
        remplirdgv()
    End Sub

    Private Sub BT_reserver_reser_us_Click(sender As Object, e As EventArgs) Handles BT_reserver_reser_us.Click
        ' Réservation du document
        reserver()
    End Sub

    Private Sub BT_annuler_iP_us_Click(sender As Object, e As EventArgs) Handles BT_annuler_annuler_us.Click
        ' Annaulation de la reservation
        annuler()
    End Sub

    Private Sub DGV_annuler_annuler_us_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_annuler_annuler_us.CellClick
        ' Remplissage des champs de l'onglet annuler
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_annuler_annuler_us.Rows(e.RowIndex)
                Me.DTP_date_reservation_annuler_us.Text = ligne.Cells("Date reservation").Value.ToString
                Me.TXT_num_adherent_annuler_us.Text = ligne.Cells("Numéro adherent").Value.ToString
                Me.TXT_code_doc_annuler_us.Text = ligne.Cells("Code document").Value.ToString
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
        ' Vérification de la connexion
        Form1.verifierconnexion()
    End Sub

    Private Sub SeConnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeConnecterToolStripMenuItem.Click
        ' Ouverture du formulaire Serveur
        Serveur.Show()
    End Sub
    Private Sub BT_parcourir_iP_us_Click(sender As Object, e As EventArgs) Handles BT_parcourir_iP_us.Click
        ' Ouverture du file dialog
        Me.OFD_usimples.ShowDialog()
        Me.PB_IP_iP_us.ImageLocation = Me.OFD_usimples.FileName
    End Sub
    Private Sub BT_enregistrer_infop_us_Click(sender As Object, e As EventArgs) Handles BT_enregistrer_infop_us.Click
        ' Enregistrement des informations

    End Sub
    ' Personnalisation des boutons
    Private Sub BT_rechercher_rech_us_MouseHover(sender As Object, e As EventArgs) Handles BT_rechercher_rech_us.MouseHover
        ' Bouton rechercher
        Me.BT_rechercher_rech_us.BackColor = Color.Cyan
    End Sub
    Private Sub BT_rechercher_rech_us_MouseLeave(sender As Object, e As EventArgs) Handles BT_rechercher_rech_us.MouseLeave
        ' Bouton rechercher
        Me.BT_rechercher_rech_us.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_afficher_tout_rech_us_MouseHover(sender As Object, e As EventArgs) Handles BT_afficher_tout_rech_us.MouseHover
        ' Bouton afficher tout
        Me.BT_afficher_tout_rech_us.BackColor = Color.Cyan
    End Sub
    Private Sub BT_afficher_tout_rech_us_MouseLeave(sender As Object, e As EventArgs) Handles BT_afficher_tout_rech_us.MouseLeave
        ' Bouton afficher tout
        Me.BT_afficher_tout_rech_us.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_reserver_reser_us_MouseHover(sender As Object, e As EventArgs) Handles BT_reserver_reser_us.MouseHover
        ' Bouton reserver
        Me.BT_reserver_reser_us.BackColor = Color.Cyan
    End Sub
    Private Sub BT_reserver_reser_us_MouseLeave(sender As Object, e As EventArgs) Handles BT_reserver_reser_us.MouseLeave
        ' Bouton reserver
        Me.BT_reserver_reser_us.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_parcourir_iP_us_MouseHover(sender As Object, e As EventArgs) Handles BT_parcourir_iP_us.MouseHover
        ' Bouton parcourir
        Me.BT_parcourir_iP_us.BackColor = Color.Cyan
    End Sub
    Private Sub BT_parcourir_iP_us_MouseLeave(sender As Object, e As EventArgs) Handles BT_parcourir_iP_us.MouseLeave
        ' Bouton parcourir
        Me.BT_parcourir_iP_us.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_enregistrer_infop_us_MouseHover(sender As Object, e As EventArgs) Handles BT_enregistrer_infop_us.MouseHover
        ' Bouton enregistrer
        Me.BT_enregistrer_infop_us.BackColor = Color.Cyan
    End Sub
    Private Sub BT_enregistrer_infop_us_MouseLeave(sender As Object, e As EventArgs) Handles BT_enregistrer_infop_us.MouseLeave
        ' Bouton enregistrer
        Me.BT_enregistrer_infop_us.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_annuler_iP_us_MouseHover(sender As Object, e As EventArgs) Handles BT_annuler_annuler_us.MouseHover
        ' Bouton annuler
        Me.BT_annuler_annuler_us.BackColor = Color.Cyan
    End Sub
    Private Sub BT_annuler_iP_us_MouseLeave(sender As Object, e As EventArgs) Handles BT_annuler_annuler_us.MouseLeave
        ' Bouton annuler
        Me.BT_annuler_annuler_us.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub BT_logouasz_Click(sender As Object, e As EventArgs) Handles BT_logouasz.Click
        ' Ouverture du formulaire UASZ
        UASZ.Show()
    End Sub

    Private Sub BT_logomi_Click(sender As Object, e As EventArgs) Handles BT_logomi.Click
        ' Ouverture du formulaire DMI
        DMI.Show()
    End Sub

    Private Sub SeDéconnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeDéconnecterToolStripMenuItem.Click
        ' Affichage du formulaire Form1
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub AccueilToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ' Affichage du formulaire Applications
        Applications.Show()
        Me.Hide()
    End Sub

    Private Sub AfficherLaideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherLaideToolStripMenuItem.Click
        ' Affichage du formulaire Aide
        Aide.Show()
    End Sub

    Private Sub AccueilToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AccueilToolStripMenuItem.Click
        ' Affichage du formiaire Applications
        Applications.Show()
        Me.Hide()
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