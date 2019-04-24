Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Form1
    ' Variables globales
    Public Shared nomServeur As String = ""
    Public Shared nomUser As String = ""
    Public Shared motPasse As String = ""
    Public Shared nomBase As String = ""
    Public Shared logininfo As String = ""
    ' Procédures et fonctions

    ''' <summary>
    ''' ' Permet de tester la connexion avec la base de donnée MySQL
    ''' </summary>

    Public Sub verifierconnexion()
        Dim parler = CreateObject("sapi.spvoice")
        Dim connexion As New MySqlConnection
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        Try
            connexion.Open()
            parler.speak("Connexion à la base de donnée réussie")
            MsgBox("Connexion à la base de donnée réussie", vbInformation, "Information")
            connexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connexion.Close()
        End Try
    End Sub

    ''' <summary>
    ''' ' Permet de se connecter à l'application
    ''' </summary>
    ''' 

    Private Sub login()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim lecteur As MySqlDataReader
        If (Me.TXT_login.Text = "" Or Me.TXT_passe.Text = "") Then
            MsgBox("Veuillez saisir votre nom d'utilisateur et votre mot de passe SVP", vbCritical, "Erreur")
        Else
            If (Me.TXT_login.Text = "admin" Or Me.TXT_passe.Text = "bmi2016") Then
                Applications.Show()
                Me.Hide()
            Else
                connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
                commande.Connection = connexion
                Try
                    connexion.Open()
                    commande.CommandText = "Select login, mot_passe FROM adherent WHERE  login = '" & Me.TXT_login.Text & "' and mot_passe = '" & Me.TXT_passe.Text & "' and type  = '" & "Super utilisateur" & "' and etat = '" & "Activé" & "'"
                    lecteur = commande.ExecuteReader
                    If lecteur.HasRows Then
                        Usuper.Show()
                        Me.Hide()
                    Else
                        connexion.Close()
                        commande.Connection = connexion
                        connexion.Open()
                        commande.CommandText = "SELECT login, mot_passe FROM adherent WHERE login = '" & Me.TXT_login.Text & "' and mot_passe = '" & Me.TXT_passe.Text & "' and type  = '" & "Utilisateur simple" & "' and etat = '" & "Activé" & "'"
                        lecteur = commande.ExecuteReader
                        If lecteur.HasRows Then
                            Usimples.AllerÀToolStripMenuItem.Enabled = False
                            Usimples.Show()
                            Me.Hide()
                        Else
                            connexion.Close()
                            commande.Connection = connexion
                            connexion.Open()
                            commande.CommandText = "SELECT login, mot_passe FROM adherent WHERE login = '" & Me.TXT_login.Text & "' and mot_passe = '" & Me.TXT_passe.Text & "' and type  = '" & "Super utilisateur" & "' or type = '" & "Utilisateur simple" & "' and etat = '" & "Désactivé" & "'"
                            lecteur = commande.ExecuteReader
                            If lecteur.HasRows Then
                                MsgBox("Votre compte n'est pas activé", vbInformation, "Erreur")
                            End If
                        End If
                    End If
                    connexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                connexion.Dispose()
            End If
        End If
        Me.TXT_login.Clear()
        Me.TXT_passe.Clear()
    End Sub

    ''' <summary>
    ''' ' Permet d'inscrire un étudiant dans la base de donnée
    ''' </summary>

    Private Sub inscrireetudiant()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim commande2 As New MySqlCommand
        Dim photostream As New System.IO.MemoryStream()
        Me.PB_photo_etud.Image.Save(photostream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim photo() As Byte = photostream.GetBuffer()
        photostream.Close()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        If (Me.TXT_nadh_etud.Text = "" Or Me.PB_photo_etud.ImageLocation = "" Or Me.TXT_nom_etud.Text = "" Or Me.TXT_prenom_etud.Text = "" Or Me.TXT_nat_etud.Text = "" Or Me.TXT_tel_etud.Text = "" Or Me.TXT_mail_etud.Text = "" Or Me.TXT_login_etud.Text = "" Or Me.TXT_passe_etud.Text = "" Or Me.CB_type_etud.Text = "") Then
            MsgBox("Veuillez remplir tous les champs SVP", vbCritical, "Erreur")
        Else
            Try
                connexion.Open()
                commande.Connection = connexion
                commande2.Connection = connexion
                commande.CommandText = "INSERT INTO adherent values ('" & Me.TXT_nadh_etud.Text & "', @photo, '" & Me.TXT_nom_etud.Text & "', '" & Me.TXT_prenom_etud.Text & "', '" & Me.TXT_nat_etud.Text & "', '" & Me.TXT_tel_etud.Text & "', '" & Me.TXT_mail_etud.Text & "', '" & "Etudiant" & "', '" & Me.TXT_login_etud.Text & "', '" & Me.TXT_passe_etud.Text & "', '" & Me.CB_type_etud.Text & "', '" & "Désactivé" & "')"
                commande.Parameters.AddWithValue("@photo", photo)
                commande2.CommandText = "INSERT INTO etudiant values ('" & Me.TXT_nce_etud.Text & "', '" & Me.TXT_net_etud.Text & "', '" & Me.CB_catsp_etud.Text & "', '" & Me.TXT_nadh_etud.Text & "')"
                commande.ExecuteNonQuery()
                commande2.ExecuteNonQuery()
                Me.OFD_Form1.FileName = Nothing
                Me.PB_photo_etud.ImageLocation = OFD_Form1.FileName
                Me.TXT_nadh_etud.Clear()
                Me.TXT_nom_etud.Clear()
                Me.TXT_prenom_etud.Clear()
                Me.TXT_nat_etud.Clear()
                Me.TXT_tel_etud.Clear()
                Me.TXT_mail_etud.Clear()
                Me.TXT_login_etud.Clear()
                Me.TXT_passe_etud.Clear()
                Me.CB_type_etud.Text = ""
                Me.TXT_nce_etud.Clear()
                Me.TXT_net_etud.Clear()
                Me.CB_catsp_etud.Text = ""
                MsgBox("Vous avez été inscrit avec succès" & vbNewLine & "Vous pourrez utiliser l'application une fois votre compte activé", vbInformation, "Inscription réussi")
                connexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connexion.Dispose()
            End Try
        End If
    End Sub

    ''' <summary>
    ''' ' Permet d'inscrire un enseignant dans la base de donnée
    ''' </summary>

    Private Sub inscrireenseignant()
        Dim connexion As New MySqlConnection
        Dim commande As New MySqlCommand
        Dim commande2 As New MySqlCommand
        Dim photostream As New System.IO.MemoryStream()
        Me.PB_photo_ens.Image.Save(photostream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim photo() As Byte = photostream.GetBuffer()
        photostream.Close()
        connexion.ConnectionString = "server=" + nomServeur + ";" + "userid=" + nomUser + ";" + "password=" + motPasse + ";" + "database=" + nomBase
        If (Me.TXT_nadh_ens.Text = "" Or Me.PB_photo_ens.ImageLocation = "" Or Me.TXT_nom_ens.Text = "" Or Me.TXT_prenom_ens.Text = "" Or Me.TXT_nat_ens.Text = "" Or Me.TXT_tel_ens.Text = "" Or Me.TXT_mail_ens.Text = "" Or Me.TXT_login_ens.Text = "" Or Me.TXT_passe_ens.Text = "" Or Me.CB_type_ens.Text = "") Then
            MsgBox("Veuillez remplir tous les champs SVP", vbCritical, "Erreur")
        Else
            Try
                connexion.Open()
                commande.Connection = connexion
                commande2.Connection = connexion
                commande.CommandText = "INSERT INTO adherent values('" & Me.TXT_nadh_ens.Text & "', @photo, '" & Me.TXT_nom_ens.Text & "', '" & Me.TXT_prenom_ens.Text & "', '" & Me.TXT_nat_ens.Text & "', '" & Me.TXT_tel_ens.Text & "', '" & Me.TXT_mail_ens.Text & "', '" & "Enseignant" & "', '" & Me.TXT_login_ens.Text & "', '" & Me.TXT_passe_ens.Text & "', '" & Me.CB_type_ens.Text & "', '" & "Désactivé" & "')"
                commande.Parameters.AddWithValue("@photo", photo)
                commande2.CommandText = "INSERT INTO enseignant values('" & Me.TXT_me_ens.Text & "', '" & Me.TXT_dr_ens.Text & "', '" & Me.TXT_matiere_enseignees.Text & "', '" & Me.TXT_nadh_ens.Text & "')"
                commande.ExecuteNonQuery()
                commande2.ExecuteNonQuery()
                Me.OFD_Form1.FileName = Nothing
                Me.PB_photo_ens.ImageLocation = OFD_Form1.FileName
                Me.TXT_nadh_ens.Clear()
                Me.TXT_nom_ens.Clear()
                Me.TXT_prenom_ens.Clear()
                Me.TXT_nat_ens.Clear()
                Me.TXT_tel_ens.Clear()
                Me.TXT_mail_ens.Clear()
                Me.TXT_login_ens.Clear()
                Me.TXT_passe_ens.Clear()
                Me.CB_type_ens.Text = ""
                Me.TXT_me_ens.Clear()
                Me.TXT_dr_ens.Clear()
                Me.TXT_matiere_enseignees.Clear()
                MsgBox("Vous avez été inscrit avec succès" & vbNewLine & "Vous pourrez utiliser l'application une fois votre compte activé", vbInformation, "Inscription réussi")
                connexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connexion.Dispose()
            End Try
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activation du timer
        Me.TM_form1.Enabled = True
        ' Remplissage des combobox Etudiant
        Me.CB_catsp_etud.Items.Add("Etudiant")
        Me.CB_catsp_etud.Items.Add("Professionnel")
        Me.CB_type_etud.Items.Add("Utilisateur simple")
        Me.CB_type_etud.Items.Add("Super utilisateur")
        ' Remplissage des combobox Enseignant
        Me.CB_type_ens.Items.Add("Utilisateur simple")
        Me.CB_type_ens.Items.Add("Super utilisateur")
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        'Fermeture du programme
        Chargement.Close()
    End Sub

    Private Sub BT_connexion_Click(sender As Object, e As EventArgs) Handles BT_connexion.Click
        ' Stockage du login de l'utilisateur dans la variable logininfo
        logininfo = Me.TXT_login.Text
        login()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub VérifierLaConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VérifierLaConnectionToolStripMenuItem.Click
        Call verifierconnexion()
    End Sub

    Private Sub TM_Tick(sender As Object, e As EventArgs) Handles TM_form1.Tick
        ' Affichage de la date et de l'heure
        Me.LBL_date.Text = DateString
        Me.LBL_heure.Text = TimeString
    End Sub

    Private Sub LBL_heure_Click(sender As Object, e As EventArgs) Handles LBL_heure.Click

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub BT_parcourir_etudiant_Click(sender As Object, e As EventArgs) Handles BT_parcourir_etudiant.Click
        'Ajouter une photo au formulaire etudiant
        Me.OFD_form1.ShowDialog()
        Me.PB_photo_etud.ImageLocation = Me.OFD_form1.FileName
    End Sub

    Private Sub BT_parcourir_enseignant_Click(sender As Object, e As EventArgs) Handles BT_parcourir_enseignant.Click
        'Ajouter une photo au formulaire enseignant
        Me.OFD_form1.ShowDialog()
        Me.PB_photo_ens.ImageLocation = Me.OFD_form1.FileName
    End Sub

    Private Sub GB_etudiant_Enter(sender As Object, e As EventArgs) Handles GB_etudiant.Enter

    End Sub

    Private Sub BT_ins_etudiant_Click(sender As Object, e As EventArgs) Handles BT_ins_etudiant.Click
        ' Inscription de l'étudiant
        inscrireetudiant()
    End Sub

    Private Sub BT_ins_enseignant_Click(sender As Object, e As EventArgs) Handles BT_ins_enseignant.Click
        ' Inscription de l'enseignant
        inscrireenseignant()
    End Sub

    Private Sub LBL_login_Click(sender As Object, e As EventArgs) Handles LBL_login.Click

    End Sub

    Private Sub OutilsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutilsToolStripMenuItem.Click

    End Sub

    Private Sub SeConnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeConnecterToolStripMenuItem.Click
        ' Affichage du formulaire Serveur
        Serveur.Show()
    End Sub

    'Personnalisation des boutons
    Private Sub BT_parcourir_etudiant_MouseHover(sender As Object, e As EventArgs) Handles BT_parcourir_etudiant.MouseHover
        ' Bouton parcourir
        BT_parcourir_etudiant.BackColor = Color.Cyan
    End Sub

    Private Sub BT_parcourir_etudiant_MouseLeave(sender As Object, e As EventArgs) Handles BT_parcourir_etudiant.MouseLeave
        ' Bouton parcourir
        BT_parcourir_etudiant.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_ins_etudiant_MouseHover(sender As Object, e As EventArgs) Handles BT_ins_etudiant.MouseHover
        ' Bouton inscription
        BT_ins_etudiant.BackColor = Color.Cyan
    End Sub

    Private Sub BT_ins_etudiant_MouseLeave(sender As Object, e As EventArgs) Handles BT_ins_etudiant.MouseLeave
        ' Bouton inscription
        BT_ins_etudiant.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub BT_parcourir_enseignant_MouseHover(sender As Object, e As EventArgs) Handles BT_parcourir_enseignant.MouseHover
        ' Bouton parcourir
        BT_parcourir_enseignant.BackColor = Color.Cyan
    End Sub

    Private Sub BT_parcourir_enseignant_MouseLeave(sender As Object, e As EventArgs) Handles BT_parcourir_enseignant.MouseLeave
        ' Bouton parcourir
        BT_parcourir_enseignant.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub BT_ins_enseignant_MouseHover(sender As Object, e As EventArgs) Handles BT_ins_enseignant.MouseHover
        ' Bouton inscription
        BT_ins_enseignant.BackColor = Color.Cyan
    End Sub
    Private Sub BT_ins_enseignant_MouseLeave(sender As Object, e As EventArgs) Handles BT_ins_enseignant.MouseLeave
        ' Bouton inscription
        BT_ins_enseignant.BackColor = Color.DarkSlateGray
    End Sub
    Private Sub BT_connexion_MouseHover(sender As Object, e As EventArgs) Handles BT_connexion.MouseHover
        ' Bouton connexion
        BT_connexion.BackColor = Color.Cyan
    End Sub
    Private Sub BT_connexion_MouseLeave(sender As Object, e As EventArgs) Handles BT_connexion.MouseLeave
        ' Bouton connexion
        BT_connexion.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        ' Fermeture du programme
        Chargement.Close()
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
        ' Afichage du formulaire Apropos
        Apropos.Show()
    End Sub

    Private Sub AideToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AideToolStripMenuItem1.Click
        ' Affichage du formulaire Aide
        Aide.Show()
    End Sub
End Class
