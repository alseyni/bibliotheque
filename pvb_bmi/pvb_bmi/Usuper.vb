Imports MySql.Data.MySqlClient
Public Class Usuper
    ' Variables globales
    Public Shared nomServeur As String = ""
    Public Shared nomUser As String = ""
    Public Shared motPasse As String = ""
    Public Shared nomBase As String = ""

    ' Déclaration et définition des procédures et fonctions


    ''' <summary>
    ''' Permet d'aciver ou de desactiver un utilisateur
    ''' </summary>

    Private Sub activer_desactiver()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        commande.Connection = connexion
        Try
            connexion.Open()
            commande.CommandText = "UPDATE adherent SET etat = '" & Me.CB_etat_AD_su.Text & "' WHERE num_adherent = '" & Me.TXT_num_adherent_AD_su.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            If Me.CB_etat_AD_su.Text = "Activé" Then
                MsgBox("Utilisateur activé", vbInformation, "Activation réussie")
            Else
                MsgBox("Utilisateur désactivé", vbInformation, "Désactivation réussie")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_adherent_AD_su.Clear()
        Me.CB_etat_AD_su.Text = ""
        remplirdgvad()
        remplirdgvajtd()
        remplirdgvetudiants()
        remplirdgdvenseignants()
    End Sub

    ''' <summary>
    ''' Remplit le datagridview de l'onglet Activer / Désactiver
    ''' </summary>

    Public Sub remplirdgvad()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT num_adherent AS 'Numéro adherent', nom AS 'Nom' , prenom AS 'Prénom',  login AS 'Login', mot_passe AS 'Mot de passe', type AS 'Type', etat AS 'Etat', photo AS 'Photo' FROM adherent"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_AD_su.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Permet d'aciver ou de desactiver un utilisateur
    ''' </summary>

    Private Sub ajouterdroit()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        commande.Connection = connexion
        Try
            connexion.Open()
            commande.CommandText = "UPDATE adherent SET type = '" & Me.CB_droit_AJD_su.Text & "' WHERE num_adherent = '" & Me.TXT_num_adherent_AJD_su.Text & "'"
            commande.ExecuteNonQuery()
            connexion.Close()
            If Me.CB_droit_AJD_su.Text = "Utilisateur simple" Then
                MsgBox("Utilisateur simple définie avec succès", vbInformation, "Définition réussie")
            Else
                MsgBox("Super utilisateur définie avec succès", vbInformation, "Définition réussie")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
        Me.TXT_num_adherent_AJD_su.Clear()
        Me.CB_droit_AJD_su.Text = ""
        remplirdgvad()
        remplirdgvajtd()
        remplirdgvetudiants()
        remplirdgdvenseignants()
    End Sub

    ''' <summary>
    ''' Remplit le datagridview de l'onglet ajouter droit
    ''' </summary>

    Public Sub remplirdgvajtd()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT num_adherent AS 'Numéro adherent', nom AS 'Nom' , prenom AS 'Prénom',  login AS 'Login', mot_passe AS 'Mot de passe', type AS 'Type', etat AS 'Etat', photo AS 'Photo' FROM adherent"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_AJD_su.DataSource = source
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
            commande.CommandText = "SELECT adherent.num_adherent, adherent.photo, adherent.nom, adherent.prenom, adherent.nationalite, adherent.telephone, adherent.email, adherent.login, adherent.mot_passe, etudiant.num_carte, etudiant.niveau_etud, etudiant.categorie_SP FROM adherent, etudiant WHERE etudiant.num_adherent = adherent.num_adherent and etudiant.num_adherent = '" & Me.TXT_num_adherent_MAJ_MAJ_su.Text & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                ' Affichage des champs de l'etudiant
                Me.LBL_num_carte_MAJ_su.Visible = True
                Me.TXT_num_carte_MAJ_su.Visible = True
                Me.LBL_niveau_etude_MAJ_su.Visible = True
                Me.TXT_niveau_etude_MAJ_su.Visible = True
                Me.LBL_cat_sp_MAJ_su.Visible = True
                Me.TXT_cat_sp_MAJ_su.Visible = True
                ' Dissimulation des champs de l'enseignant
                Me.LBL_mat_ensei_MAJ_su.Visible = False
                Me.TXT_mat_ensei_MAJ_su.Visible = False
                Me.LBL_domaine_rech_MAJ_su.Visible = False
                Me.TXT_domaine_rech_MAJ_su.Visible = False
                Me.LBL_matieres_ensei_MAJ_su.Visible = False
                Me.TXT_matieres_ensei_MAJ_su.Visible = False
                While lecteur.Read
                    Me.TXT_num_adh_MAJ_su.Text = lecteur.GetInt32(0)
                    Dim photobyte() As Byte = lecteur.GetValue(1)
                    Dim photostream As New System.IO.MemoryStream(photobyte)
                    Me.PB_photo_MAJ_su.Image = Image.FromStream(photostream)
                    Me.PB_photo2_MAJ_su.Image = Image.FromStream(photostream)
                    photostream.Close()
                    Me.TXT_nom_MAJ_su.Text = lecteur.GetString(2)
                    Me.TXT_prenom_MAJ_su.Text = lecteur.GetString(3)
                    Me.TXT_nationalite_MAJ_su.Text = lecteur.GetString(4)
                    Me.TXT_telephone_MAJ_su.Text = lecteur.GetInt64(5)
                    Me.TXT_email_MAJ_su.Text = lecteur.GetString(6)
                    Me.TXT_login_MAJ_su.Text = lecteur.GetString(7)
                    Me.TXT_mot_passe_MAJ_su.Text = lecteur.GetString(8)
                    Me.TXT_num_carte_MAJ_su.Text = lecteur.GetInt32(9)
                    Me.TXT_niveau_etude_MAJ_su.Text = lecteur.GetString(10)
                    Me.TXT_cat_sp_MAJ_su.Text = lecteur.GetString(11)
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
            commande.CommandText = "SELECT adherent.num_adherent, adherent.photo, adherent.nom, adherent.prenom, adherent.nationalite, adherent.telephone, adherent.email, adherent.login, adherent.mot_passe, enseignant.mat_ensei, enseignant.domaine_rech, matiere_enseign FROM adherent, enseignant WHERE enseignant.num_adherent = adherent.num_adherent and enseignant.num_adherent = '" & Me.TXT_num_adherent_MAJ_MAJ_su.Text & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                ' Affichage des champs de l'enseignant
                Me.LBL_mat_ensei_MAJ_su.Visible = True
                Me.TXT_mat_ensei_MAJ_su.Visible = True
                Me.LBL_domaine_rech_MAJ_su.Visible = True
                Me.TXT_domaine_rech_MAJ_su.Visible = True
                Me.LBL_matieres_ensei_MAJ_su.Visible = True
                Me.TXT_matieres_ensei_MAJ_su.Visible = True
                ' Dissimulation des champs de l'etudiant
                Me.LBL_num_carte_MAJ_su.Visible = False
                Me.TXT_num_carte_MAJ_su.Visible = False
                Me.LBL_niveau_etude_MAJ_su.Visible = False
                Me.TXT_niveau_etude_MAJ_su.Visible = False
                Me.LBL_cat_sp_MAJ_su.Visible = False
                Me.TXT_cat_sp_MAJ_su.Visible = False
                While lecteur.Read
                    Me.TXT_num_adh_MAJ_su.Text = lecteur.GetInt32(0)
                    Dim photobyte() As Byte = lecteur.GetValue(1)
                    Dim photostream As New System.IO.MemoryStream(photobyte)
                    Me.PB_photo_MAJ_su.Image = Image.FromStream(photostream)
                    Me.PB_photo2_MAJ_su.Image = Image.FromStream(photostream)
                    photostream.Close()
                    Me.TXT_nom_MAJ_su.Text = lecteur.GetString(2)
                    Me.TXT_prenom_MAJ_su.Text = lecteur.GetString(3)
                    Me.TXT_nationalite_MAJ_su.Text = lecteur.GetString(4)
                    Me.TXT_telephone_MAJ_su.Text = lecteur.GetInt64(5)
                    Me.TXT_email_MAJ_su.Text = lecteur.GetString(6)
                    Me.TXT_login_MAJ_su.Text = lecteur.GetString(7)
                    Me.TXT_mot_passe_MAJ_su.Text = lecteur.GetString(8)
                    Me.TXT_mat_ensei_MAJ_su.Text = lecteur.GetInt32(9)
                    Me.TXT_domaine_rech_MAJ_su.Text = lecteur.GetString(10)
                    Me.TXT_matieres_ensei_MAJ_su.Text = lecteur.GetString(11)
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
    ''' Permet de rechercher un etudiant
    ''' </summary>

    Private Sub rechercheretudiant()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT adherent.num_adherent, adherent.photo, adherent.nom, adherent.prenom, adherent.nationalite, adherent.telephone, adherent.email, adherent.login, adherent.mot_passe, etudiant.num_carte, etudiant.niveau_etud, etudiant.categorie_SP FROM adherent, etudiant WHERE etudiant.num_adherent = adherent.num_adherent and etudiant.num_adherent = '" & Me.TXT_numero_adherent_rech_su.Text & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                ' Affichage des champs de l'etudiant
                Me.LBL_num_carte_rech_su.Visible = True
                Me.TXT_num_carte_rech_su.Visible = True
                Me.LBL_niveau_etud_rech_su.Visible = True
                Me.TXT_niveau_etud_rech_su.Visible = True
                Me.LBL_cate_sp_rech_su.Visible = True
                Me.TXT_cate_sp_rech_su.Visible = True
                ' Dissimulation des champs de l'enseignant
                Me.LBL_mat_ensei_rech_su.Visible = False
                Me.TXT_mat_ensei_rech_su.Visible = False
                Me.LBL_domaine_recherche_rech_su.Visible = False
                Me.TXT_domaine_recherche_rech_su.Visible = False
                Me.LBL_matiere_ensei_rech_su.Visible = False
                Me.TXT_matiere_ensei_rech_su.Visible = False
                While lecteur.Read
                    Me.TXT_num_adherent_rech_su.Text = lecteur.GetInt32(0)
                    Dim photobyte() As Byte = lecteur.GetValue(1)
                    Dim photostream As New System.IO.MemoryStream(photobyte)
                    Me.PB_photo_rech_su.Image = Image.FromStream(photostream)
                    photostream.Close()
                    Me.TXT_nom_rech_su.Text = lecteur.GetString(2)
                    Me.TXT_prenom_rech_su.Text = lecteur.GetString(3)
                    Me.TXT_nationalite_rech_su.Text = lecteur.GetString(4)
                    Me.TXT_telephone_rech_su.Text = lecteur.GetInt64(5)
                    Me.TXT_email_rech_su.Text = lecteur.GetString(6)
                    Me.TXT_login_rech_su.Text = lecteur.GetString(7)
                    Me.TXT_mot_passe_rech_su.Text = lecteur.GetString(8)
                    Me.TXT_num_carte_rech_su.Text = lecteur.GetInt32(9)
                    Me.TXT_niveau_etud_rech_su.Text = lecteur.GetString(10)
                    Me.TXT_cate_sp_rech_su.Text = lecteur.GetString(11)
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
    ''' Permet de rechercher un enseignant
    ''' </summary>

    Private Sub rechercherenseignant()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT adherent.num_adherent, adherent.photo, adherent.nom, adherent.prenom, adherent.nationalite, adherent.telephone, adherent.email, adherent.login, adherent.mot_passe, enseignant.mat_ensei, enseignant.domaine_rech, enseignant.matiere_enseign FROM adherent, enseignant WHERE enseignant.num_adherent = adherent.num_adherent and enseignant.num_adherent = '" & Me.TXT_numero_adherent_rech_su.Text & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                ' Affichage des champs de l'enseignant
                Me.LBL_mat_ensei_rech_su.Visible = True
                Me.TXT_mat_ensei_rech_su.Visible = True
                Me.LBL_domaine_recherche_rech_su.Visible = True
                Me.TXT_domaine_recherche_rech_su.Visible = True
                Me.LBL_matiere_ensei_rech_su.Visible = True
                Me.TXT_matiere_ensei_rech_su.Visible = True
                ' Dissimulation des champs de l'etudiant
                Me.LBL_num_carte_rech_su.Visible = False
                Me.TXT_num_carte_rech_su.Visible = False
                Me.LBL_niveau_etud_rech_su.Visible = False
                Me.TXT_niveau_etud_rech_su.Visible = False
                Me.LBL_cate_sp_rech_su.Visible = False
                Me.TXT_cate_sp_rech_su.Visible = False
                While lecteur.Read
                    Me.TXT_num_adherent_rech_su.Text = lecteur.GetInt32(0)
                    Dim photobyte() As Byte = lecteur.GetValue(1)
                    Dim photostream As New System.IO.MemoryStream(photobyte)
                    Me.PB_photo_rech_su.Image = Image.FromStream(photostream)
                    photostream.Close()
                    Me.TXT_nom_rech_su.Text = lecteur.GetString(2)
                    Me.TXT_prenom_rech_su.Text = lecteur.GetString(3)
                    Me.TXT_nationalite_rech_su.Text = lecteur.GetString(4)
                    Me.TXT_telephone_rech_su.Text = lecteur.GetInt64(5)
                    Me.TXT_email_rech_su.Text = lecteur.GetString(6)
                    Me.TXT_login_rech_su.Text = lecteur.GetString(7)
                    Me.TXT_mot_passe_rech_su.Text = lecteur.GetString(8)
                    Me.TXT_mat_ensei_rech_su.Text = lecteur.GetInt32(9)
                    Me.TXT_domaine_recherche_rech_su.Text = lecteur.GetString(10)
                    Me.TXT_matiere_ensei_rech_su.Text = lecteur.GetString(11).ToString
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
    ''' Permet de visualiser un etudiant
    ''' </summary>

    Private Sub visualiseretudiant()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT adherent.num_adherent, adherent.photo, adherent.nom, adherent.prenom, adherent.nationalite, adherent.telephone, adherent.email, adherent.categorie, adherent.login, adherent.mot_passe, adherent.type, adherent.etat, etudiant.num_carte, etudiant.niveau_etud, etudiant.categorie_SP FROM adherent, etudiant WHERE etudiant.num_adherent = adherent.num_adherent and etudiant.num_adherent = '" & Me.TXT_num_adherent_visua_su.Text & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                Dim chaine As String = "************** Université Assane SECK de Ziguinchor **************" & vbNewLine & vbNewLine & vbNewLine
                While lecteur.Read
                    chaine += "Numéro adherent = " & lecteur.GetInt32(0) & vbNewLine
                    chaine += "Nom = " & lecteur.GetString(2) & vbNewLine
                    chaine += "Prénom = " & lecteur.GetString(3) & vbNewLine
                    chaine += "Nationalité = " & lecteur.GetString(4) & vbNewLine
                    chaine += "Téléphone = " & lecteur.GetInt64(5) & vbNewLine
                    chaine += "Email = " & lecteur.GetString(6) & vbNewLine
                    chaine += "Catégorie = " & lecteur.GetString(7) & vbNewLine
                    chaine += "Login = " & lecteur.GetString(8) & vbNewLine
                    chaine += "Mot de passe = " & lecteur.GetString(9) & vbNewLine
                    chaine += "Type = " & lecteur.GetString(10) & vbNewLine
                    chaine += "Etat = " & lecteur.GetString(11) & vbNewLine
                    chaine += "Numéro carte = " & lecteur.GetInt32(12) & vbNewLine
                    chaine += "Niveau d'étude = " & lecteur.GetString(13) & vbNewLine
                    chaine += "Catégorie socio-professionelle = " & lecteur.GetString(14) & vbNewLine
                End While
                Visualiser.RTB_visualiser.Text = chaine
                Visualiser.Show()
            End If
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub


    ''' <summary>
    ''' Permet de visualiser un enseignant
    ''' </summary>

    Private Sub visualiserenseignant()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT adherent.num_adherent, adherent.photo, adherent.nom, adherent.prenom, adherent.nationalite, adherent.telephone, adherent.email, adherent.categorie, adherent.login, adherent.mot_passe, adherent.type, adherent.etat, enseignant.mat_ensei, enseignant.domaine_rech, enseignant.matiere_enseign FROM adherent, enseignant WHERE enseignant.num_adherent = adherent.num_adherent and enseignant.num_adherent = '" & Me.TXT_num_adherent_visua_su.Text & "'"
            lecteur = commande.ExecuteReader
            If lecteur.HasRows Then
                Dim chaine As String = "************** Université Assane SECK de Ziguinchor **************" & vbNewLine & vbNewLine & vbNewLine
                While lecteur.Read
                    chaine += "Numéro adherent = " & lecteur.GetInt32(0) & vbNewLine
                    chaine += "Nom = " & lecteur.GetString(2) & vbNewLine
                    chaine += "Prénom = " & lecteur.GetString(3) & vbNewLine
                    chaine += "Nationalité = " & lecteur.GetString(4) & vbNewLine
                    chaine += "Téléphone = " & lecteur.GetInt64(5) & vbNewLine
                    chaine += "Email = " & lecteur.GetString(6) & vbNewLine
                    chaine += "Catégorie = " & lecteur.GetString(7) & vbNewLine
                    chaine += "Login = " & lecteur.GetString(8) & vbNewLine
                    chaine += "Mot de passe = " & lecteur.GetString(9) & vbNewLine
                    chaine += "Type = " & lecteur.GetString(10) & vbNewLine
                    chaine += "Etat = " & lecteur.GetString(11) & vbNewLine
                    chaine += "Matricule enseignant = " & lecteur.GetInt32(12) & vbNewLine
                    chaine += "Domaine de rechercher = " & lecteur.GetString(13) & vbNewLine
                    chaine += "Matières enseignées = " & lecteur.GetString(14) & vbNewLine
                End While
                Visualiser.RTB_visualiser.Text = chaine
                Visualiser.show
            End If
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Permet de remplir le datagridview de l'onglet etudiants
    ''' </summary>
    Public Sub remplirdgvetudiants()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT adherent.num_adherent AS 'Numéro adherent', adherent.nom AS 'Nom' , adherent.prenom AS 'Prénom', adherent.nationalite AS 'Nationalité', adherent.telephone AS 'Téléphone', adherent.email AS 'Email', adherent.categorie AS 'Catégorie', adherent.login AS 'Login', adherent.mot_passe AS 'Mot de passe', adherent.type AS 'Type', adherent.etat AS 'Etat', etudiant.num_carte AS 'Numéro carte', etudiant.niveau_etud AS 'Niveau etude', etudiant.categorie_SP AS 'Catégorie socio-professionnel', adherent.photo AS 'Photo' FROM adherent,etudiant WHERE adherent.num_adherent = etudiant.num_adherent"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_etudiants_etud_LU_su.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub


    ''' <summary>
    ''' Permet de remplir le datagridview de l'onglet enseignants
    ''' </summary>
    Public Sub remplirdgdvenseignants()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT adherent.num_adherent AS 'Numéro adherent', adherent.nom AS 'Nom' , adherent.prenom AS 'Prénom', adherent.nationalite AS 'Nationalité', adherent.telephone AS 'Téléphone', adherent.email AS 'Email', adherent.categorie AS 'Catégorie', adherent.login AS 'Login', adherent.mot_passe AS 'Mot de passe', adherent.type AS 'Type', adherent.etat AS 'Etat', enseignant.mat_ensei AS 'Matricule enseignant', enseignant.domaine_rech AS 'Domaine de recherche', enseignant.matiere_enseign AS 'Matière(s) enseignée(s)', adherent.photo AS 'Photo' FROM adherent,enseignant WHERE adherent.num_adherent = enseignant.num_adherent"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_enseignants_ensei_LU_su.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Remplit le datagridview de l'onglet liste des livres
    ''' </summary>

    Private Sub remplirdgvll()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            commande.Connection = connexion
            commande.CommandText = "SELECT code_doc AS 'Code document', titre AS 'Titre', annee_edition AS 'Année', nb_exemp AS 'Nombre exemplaire(s)', nb_exemp_dispo AS 'Nombre exemplaires', num_ray AS 'Numéro rayon', code_auteur AS 'Code auteur', num_editeur AS 'Numéro éditeur', code_dis AS 'Code discipline', couverture AS 'Couverture' FROM document"
            lecteur = commande.ExecuteReader
            source.DataSource = lecteur
            Me.DGV_liste_livres_LL_su.DataSource = source
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Affiche les livres selon des critères
    ''' </summary>

    Private Sub affichercritere()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        Dim source As New BindingSource
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        If (Me.CB_criteres_LL_su.Text = "Auteur") Then
            Try
                connexion.Open()
                commande.Connection = connexion
                commande.CommandText = "SELECT document.code_doc AS 'Code document', document.titre AS 'Titre', document.annee_edition AS 'Année edition', document.nb_exemp AS 'Nombre exemplaire(s)', document.nb_exemp_dispo AS 'Nombre exemplaires', document.couverture AS 'Couverture', document.num_ray AS 'Numéro rayon', document.code_auteur AS 'Code auteur', document.num_editeur AS 'Numéro éditeur', document.code_dis AS 'Code discipline' FROM document, auteur WHERE document.code_auteur = auteur.code_auteur and auteur.nom = '" & Me.TXT_nom_LL_su.Text & "'"
                lecteur = commande.ExecuteReader
                If (lecteur.HasRows) Then
                    source.DataSource = lecteur
                    Me.DGV_liste_livres_LL_su.DataSource = source
                    connexion.Close()
                Else
                    MsgBox("Pas de correspondance", vbCritical, "Erreur")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connexion.Dispose()
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Permet de mettre à jour un etudiant
    ''' </summary>

    Private Sub modifieretud()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim commande2 As New MySqlCommand
        Dim photostream As New System.IO.MemoryStream()
        Me.PB_photo_MAJ_su.Image.Save(photostream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim photo() As Byte = photostream.GetBuffer()
        photostream.Close()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        commande.Connection = connexion
        commande2.Connection = connexion
        If (Me.TXT_num_adherent_MAJ_MAJ_su.Text <> "" And Me.PB_photo_MAJ_su.ImageLocation <> "" And Me.TXT_nom_MAJ_su.Text <> "" And Me.TXT_prenom_MAJ_su.Text <> "" And Me.TXT_nationalite_MAJ_su.Text <> "" And Me.TXT_telephone_MAJ_su.Text <> "" And Me.TXT_email_MAJ_su.Text <> "" And Me.TXT_login_MAJ_su.Text <> "" And Me.TXT_mot_passe_MAJ_su.Text <> "" And Me.TXT_num_carte_MAJ_su.Text <> "" And Me.TXT_niveau_etude_MAJ_su.Text <> "" And Me.TXT_cat_sp_MAJ_su.Text <> "") Then
            Try
                connexion.Open()
                commande.CommandText = "UPDATE adherent SET nom = '" & Me.TXT_nom_MAJ_su.Text & "', prenom = '" & Me.TXT_prenom_MAJ_su.Text & "', photo = @photo, nationalite = '" & Me.TXT_nationalite_MAJ_su.Text & "', telephone = '" & Me.TXT_telephone_MAJ_su.Text & "', email = '" & Me.TXT_email_MAJ_su.Text & "', login = '" & Me.TXT_login_MAJ_su.Text & "', mot_passe = '" & Me.TXT_mot_passe_MAJ_su.Text & "' WHERE num_adherent = '" & Me.TXT_num_adherent_MAJ_MAJ_su.Text & "'"
                commande.Parameters.AddWithValue("@photo",photo)
                commande2.CommandText = "UPDATE etudiant SET num_carte = '" & Me.TXT_num_carte_MAJ_su.Text & "', niveau_etud = '" & Me.TXT_niveau_etude_MAJ_su.Text & "', categorie_SP = '" & Me.TXT_cat_sp_MAJ_su.Text & "'"
                commande.ExecuteNonQuery()
                connexion.Close()
                MsgBox("Informations modifiées avec succès", vbInformation, "Modification réussie")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connexion.Dispose()
            End Try
            Me.TXT_num_adherent_AJD_su.Clear()
            Me.CB_droit_AJD_su.Text = ""
            remplirdgvajtd()
            remplirdgvad()
            remplirdgvetudiants()
            remplirdgdvenseignants()
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
        Me.PB_photo_MAJ_su.Image.Save(photostream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim photo() As Byte = photostream.GetBuffer()
        photostream.Close()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        commande.Connection = connexion
        commande2.Connection = connexion
        If (Me.TXT_num_adherent_MAJ_MAJ_su.Text <> "" And Me.PB_photo_MAJ_su.ImageLocation <> "" And Me.TXT_nom_MAJ_su.Text <> "" And Me.TXT_prenom_MAJ_su.Text <> "" And Me.TXT_nationalite_MAJ_su.Text <> "" And Me.TXT_telephone_MAJ_su.Text <> "" And Me.TXT_email_MAJ_su.Text <> "" And Me.TXT_login_MAJ_su.Text <> "" And Me.TXT_mot_passe_MAJ_su.Text <> "" And Me.TXT_mat_ensei_MAJ_su.Text <> "" And Me.TXT_domaine_rech_MAJ_su.Text <> "" And Me.TXT_mat_ensei_MAJ_su.Text <> "") Then
            Try
                connexion.Open()
                commande.CommandText = "UPDATE adherent SET nom = '" & Me.TXT_nom_MAJ_su.Text & "', prenom = '" & Me.TXT_prenom_MAJ_su.Text & "', photo = @photo, nationalite = '" & Me.TXT_nationalite_MAJ_su.Text & "', telephone = '" & Me.TXT_telephone_MAJ_su.Text & "', email = '" & Me.TXT_email_MAJ_su.Text & "', login = '" & Me.TXT_login_MAJ_su.Text & "', mot_passe = '" & Me.TXT_mot_passe_MAJ_su.Text & "' WHERE num_adherent = '" & Me.TXT_num_adherent_MAJ_MAJ_su.Text & "'"
                commande.Parameters.AddWithValue("@photo", photo)
                commande2.CommandText = "UPDATE enseignant SET mat_ensei = '" & Me.TXT_mat_ensei_MAJ_su.Text & "', domaine_rech = '" & Me.TXT_niveau_etude_MAJ_su.Text & "', matiere_enseign = '" & Me.TXT_mat_ensei_MAJ_su.Text & "'"
                commande.ExecuteNonQuery()
                connexion.Close()
                MsgBox("Informations modifiées avec succès", vbInformation, "Modification réussie")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connexion.Dispose()
            End Try
            Me.TXT_num_adherent_AJD_su.Clear()
            Me.CB_droit_AJD_su.Text = ""
            remplirdgvajtd()
            remplirdgvad()
            remplirdgvetudiants()
            remplirdgdvenseignants()
        Else
            MsgBox("Modification impossible", vbInformation, "Erreur")
        End If
    End Sub

    Private Sub BT_deconnexion_Click(sender As Object, e As EventArgs)
        ' Déconnexion
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BT_accueil_Click(sender As Object, e As EventArgs)
        Applications.Show()
        Me.Hide()
    End Sub

    Private Sub TM_Usuper_Tick(sender As Object, e As EventArgs) Handles TM_Usuper.Tick
        ' Affichage de la date et de l'heure
        LBL_date.Text = DateString
        LBL_heure.Text = TimeString
    End Sub

    Private Sub Usuper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Activation du timer
        TM_Usuper.Enabled = True
        ' Remplissage des combobox
        Me.CB_etat_AD_su.Items.Add("Activé")
        Me.CB_etat_AD_su.Items.Add("Désactivé")
        Me.CB_droit_AJD_su.Items.Add("Utilisateur simple")
        Me.CB_droit_AJD_su.Items.Add("Super utilisateur")
        Me.CB_criteres_LL_su.Items.Add("Auteur")
        Me.CB_criteres_LL_su.Items.Add("editeur")
        ' Remplissage des datagridview
        remplirdgvad()
        remplirdgvajtd()
        remplirdgvetudiants()
        remplirdgdvenseignants()
        remplirdgvll()
    End Sub

    Private Sub Usuper_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Fermeture du programme
        Chargement.Close()
    End Sub

    Private Sub GB_etudiant_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GB_ens_acdes_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub BT_desactiver_ens_acdes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BT_valider_ad_su_Click(sender As Object, e As EventArgs) Handles BT_valider_AD_su.Click
        ' Activation / Désactivation de l'utilisateur
        activer_desactiver()
    End Sub

    Private Sub DGV_AD_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_AD_su.CellClick
        ' Remplissage des champs de l'onglet activer / desactiver
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_AD_su.Rows(e.RowIndex)
                Me.TXT_num_adherent_AD_su.Text = ligne.Cells("Numéro adherent").Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGV_ajtdt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_AJD_su.CellClick
        ' Remplissage des champs de l'onglet ajouter des droits
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_AD_su.Rows(e.RowIndex)
                Me.TXT_num_adherent_AJD_su.Text = ligne.Cells("Numéro adherent").Value.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BT_valider_ajdt_su_Click(sender As Object, e As EventArgs) Handles BT_valider_AJD_su.Click
        ' Définition des droits
        ajouterdroit()
    End Sub

    Private Sub BT_afficher_maj_su_Click(sender As Object, e As EventArgs) Handles BT_afficher_MAJ_MAJ_su.Click
        ' Affichage des informations
        afficherinfosetudiant()
        afficherinfosenseignant()
    End Sub

    Private Sub BT_rechercher_rech_su_Click(sender As Object, e As EventArgs) Handles BT_rechercher_rech_su.Click
        ' Recherche de l'étudiant
        rechercheretudiant()
        ' Rechercher de l'enseignant
        rechercherenseignant()
    End Sub

    Private Sub BT_parcourir_maj_su_Click(sender As Object, e As EventArgs) Handles BT_parcourir_MAJ_su.Click
        ' Ouverture du file dialog
        Me.OFD_MAJ.ShowDialog()
        Me.PB_photo_MAJ_su.ImageLocation = Me.OFD_MAJ.FileName
    End Sub

    Private Sub BT_visualier_visua_su_Click(sender As Object, e As EventArgs) Handles BT_visualier_visua_su.Click
        ' Viualisation de l'adherent
        visualiseretudiant()
        visualiserenseignant()
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
        ' Ouverture du formulaire serveur
        Serveur.Show()
    End Sub
    Private Sub BT_enregistrer_MAJ_MAJ_su_Click(sender As Object, e As EventArgs) Handles BT_enregistrer_MAJ_MAJ_su.Click
        ' Enregistement des informtions
        modifieretud()
        modifierens()
    End Sub

    Private Sub BT_logouasz_Click(sender As Object, e As EventArgs) Handles BT_logouasz.Click
        ' Ouverture du formulaire UASZ
        UASZ.Show()
    End Sub

    Private Sub BT_logomi_Click(sender As Object, e As EventArgs) Handles BT_logomi.Click
        ' Ouverture du formulaire DMI
        DMI.Show()
    End Sub

    Private Sub LBL_afficher_LL_su_Click(sender As Object, e As EventArgs) Handles BT_afficher_LL_su.Click
        ' Affichage selon des critères
        affichercritere()
    End Sub

    Private Sub BT_affichertout_LL_su_Click(sender As Object, e As EventArgs) Handles BT_affichertout_LL_su.Click
        ' Affichage de tous les critères
        remplirdgvll()
    End Sub
    ' Personnalisation des boutons
    Private Sub BT_valider_ad_su_MouseHover(sender As Object, e As EventArgs) Handles BT_valider_AD_su.MouseHover
        ' Bouton valider
        Me.BT_valider_AD_su.BackColor = Color.Cyan
    End Sub
    Private Sub BT_valider_ad_su_MouseLeave(sender As Object, e As EventArgs) Handles BT_valider_AD_su.MouseLeave
        ' Bouton valider
        Me.BT_valider_AD_su.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_valider_ajdt_su_MouseHover(sender As Object, e As EventArgs) Handles BT_valider_AJD_su.MouseHover
        ' Bouton valider
        Me.BT_valider_AJD_su.BackColor = Color.Cyan
    End Sub
    Private Sub BT_valider_ajdt_su_MouseLeave(sender As Object, e As EventArgs) Handles BT_valider_AJD_su.MouseLeave
        ' Bouton valider
        Me.BT_valider_AJD_su.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_parcourir_maj_su_MouseHover(sender As Object, e As EventArgs) Handles BT_parcourir_MAJ_su.MouseHover
        ' Bouton parcourir
        Me.BT_parcourir_MAJ_su.BackColor = Color.Cyan
    End Sub
    Private Sub BT_parcourir_maj_su_MouseLeave(sender As Object, e As EventArgs) Handles BT_parcourir_MAJ_su.MouseLeave
        ' Bouton parcourir
        Me.BT_parcourir_MAJ_su.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_afficher_maj_su_MouseHover(sender As Object, e As EventArgs) Handles BT_afficher_MAJ_MAJ_su.MouseHover
        ' Bouton afficher
        Me.BT_afficher_MAJ_MAJ_su.BackColor = Color.Cyan
    End Sub
    Private Sub BT_afficher_maj_su_MouseLeave(sender As Object, e As EventArgs) Handles BT_afficher_MAJ_MAJ_su.MouseLeave
        ' Bouton afficher
        Me.BT_afficher_MAJ_MAJ_su.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_enregistrer_MAJ_MAJ_su_MouseHover(sender As Object, e As EventArgs) Handles BT_enregistrer_MAJ_MAJ_su.MouseHover
        ' Bouton enregistrer
        Me.BT_enregistrer_MAJ_MAJ_su.BackColor = Color.Cyan
    End Sub
    Private Sub BT_enregistrer_MAJ_MAJ_su_MouseLeave(sender As Object, e As EventArgs) Handles BT_enregistrer_MAJ_MAJ_su.MouseLeave
        ' Bouton enregistrer
        Me.BT_enregistrer_MAJ_MAJ_su.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_rechercher_rech_su_MouseHover(sender As Object, e As EventArgs) Handles BT_rechercher_rech_su.MouseHover
        ' Bouton rechercher
        Me.BT_rechercher_rech_su.BackColor = Color.Cyan
    End Sub
    Private Sub BT_rechercher_rech_su_MouseLeave(sender As Object, e As EventArgs) Handles BT_rechercher_rech_su.MouseLeave
        ' Bouton rechercher
        Me.BT_rechercher_rech_su.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_visualier_visua_su_MouseHover(sender As Object, e As EventArgs) Handles BT_visualier_visua_su.MouseHover
        ' Bouton visualiser
        Me.BT_visualier_visua_su.BackColor = Color.Cyan
    End Sub
    Private Sub BT_visualier_visua_su_MouseLeave(sender As Object, e As EventArgs) Handles BT_visualier_visua_su.MouseLeave
        ' Bouton visualiser
        Me.BT_visualier_visua_su.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub LBL_afficher_LL_su_MouseHover(sender As Object, e As EventArgs) Handles BT_afficher_LL_su.MouseHover
        ' Bouton afficher
        Me.BT_afficher_LL_su.BackColor = Color.Cyan
    End Sub
    Private Sub LBL_afficher_LL_su_MouseLeave(sender As Object, e As EventArgs) Handles BT_afficher_LL_su.MouseLeave
        ' Bouton afficher
        Me.BT_afficher_LL_su.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_affichertout_LL_su_MouseHover(sender As Object, e As EventArgs) Handles BT_affichertout_LL_su.MouseHover
        ' Bouton afficher tout
        Me.BT_affichertout_LL_su.BackColor = Color.Cyan
    End Sub
    Private Sub BT_affichertout_LL_su_MouseLeave(sender As Object, e As EventArgs) Handles BT_affichertout_LL_su.MouseLeave
        ' Bouton afficher tout
        Me.BT_affichertout_LL_su.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub DGV_AD_su_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_AD_su.CellClick
        ' Affichage de la photo de l'adherent
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_AD_su.Rows(e.RowIndex)
                Dim photobyte() As Byte = ligne.Cells("photo").Value
                Dim photostream As New System.IO.MemoryStream(photobyte)
                Me.PB_photo_AD_su.Image = Image.FromStream(photostream)
                photostream.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGV_AD_su_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_AD_su.CellContentClick

    End Sub

    Private Sub DGV_AJD_su_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_AJD_su.CellClick
        ' Affichage de la photo de l'adherent
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_AD_su.Rows(e.RowIndex)
                Dim photobyte() As Byte = ligne.Cells("photo").Value
                Dim photostream As New System.IO.MemoryStream(photobyte)
                Me.PB_photo_AJD_su.Image = Image.FromStream(photostream)
                photostream.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGV_etudiants_etud_LU_su_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_etudiants_etud_LU_su.CellClick
        ' Affichage de la photo de l'adherent
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_AD_su.Rows(e.RowIndex)
                Dim photobyte() As Byte = ligne.Cells("photo").Value
                Dim photostream As New System.IO.MemoryStream(photobyte)
                Me.PB_photo_LU_us.Image = Image.FromStream(photostream)
                photostream.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGV_enseignants_ensei_LU_su_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_enseignants_ensei_LU_su.CellClick
        ' Affichage de la photo de l'adherent
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_AD_su.Rows(e.RowIndex)
                Dim photobyte() As Byte = ligne.Cells("photo").Value
                Dim photostream As New System.IO.MemoryStream(photobyte)
                Me.PB_photo_LU_us.Image = Image.FromStream(photostream)
                photostream.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGV_liste_livres_LL_su_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_liste_livres_LL_su.CellClick
        ' Affichage de la photo de l'adherent
        If e.RowIndex >= 0 Then
            Dim ligne As DataGridViewRow
            Try
                ligne = Me.DGV_liste_livres_LL_su.Rows(e.RowIndex)
                Dim photobyte() As Byte = ligne.Cells("Couverture").Value
                Dim photostream As New System.IO.MemoryStream(photobyte)
                Me.PB_couverture_LL_us.Image = Image.FromStream(photostream)
                photostream.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGV_liste_livres_LL_su_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_liste_livres_LL_su.CellContentClick

    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        ' Ouverture du formuaire Apropos
        Apropos.Show()
    End Sub

    Private Sub DGV_etudiants_etud_LU_su_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_etudiants_etud_LU_su.CellContentClick

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

    Private Sub PrêtsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrêtsToolStripMenuItem.Click
        'Affichage du formuaire Prets
        Prets.Show()
        Me.Hide()
    End Sub
End Class