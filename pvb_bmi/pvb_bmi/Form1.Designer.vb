<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LBL_universite = New System.Windows.Forms.Label()
        Me.LBL_login = New System.Windows.Forms.Label()
        Me.LBL_passe = New System.Windows.Forms.Label()
        Me.TXT_login = New System.Windows.Forms.TextBox()
        Me.TXT_passe = New System.Windows.Forms.TextBox()
        Me.MS_form1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDeDonnéeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VérifierLaConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeConnecterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LBL_heure = New System.Windows.Forms.Label()
        Me.TM_form1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_date = New System.Windows.Forms.Label()
        Me.GB_connexion = New System.Windows.Forms.GroupBox()
        Me.PB_connexion = New System.Windows.Forms.PictureBox()
        Me.BT_connexion = New System.Windows.Forms.Button()
        Me.GB_etudiant = New System.Windows.Forms.GroupBox()
        Me.CB_catsp_etud = New System.Windows.Forms.ComboBox()
        Me.CB_type_etud = New System.Windows.Forms.ComboBox()
        Me.TXT_nadh_etud = New System.Windows.Forms.TextBox()
        Me.LBL_nadh_etud = New System.Windows.Forms.Label()
        Me.BT_parcourir_etudiant = New System.Windows.Forms.Button()
        Me.BT_ins_etudiant = New System.Windows.Forms.Button()
        Me.TXT_nom_etud = New System.Windows.Forms.TextBox()
        Me.LBL_nom_etud = New System.Windows.Forms.Label()
        Me.LBL_type_etud = New System.Windows.Forms.Label()
        Me.TXT_passe_etud = New System.Windows.Forms.TextBox()
        Me.LBL_passe_etud = New System.Windows.Forms.Label()
        Me.TXT_login_etud = New System.Windows.Forms.TextBox()
        Me.LBL_login_etud = New System.Windows.Forms.Label()
        Me.TXT_net_etud = New System.Windows.Forms.TextBox()
        Me.LBL_net_etud = New System.Windows.Forms.Label()
        Me.TXT_nat_etud = New System.Windows.Forms.TextBox()
        Me.LBL_nat_etud = New System.Windows.Forms.Label()
        Me.LBL_catsp_etud = New System.Windows.Forms.Label()
        Me.TXT_mail_etud = New System.Windows.Forms.TextBox()
        Me.LBL_mail_etud = New System.Windows.Forms.Label()
        Me.TXT_tel_etud = New System.Windows.Forms.TextBox()
        Me.LBL_tel_etud = New System.Windows.Forms.Label()
        Me.TXT_nce_etud = New System.Windows.Forms.TextBox()
        Me.LBL_nce_etud = New System.Windows.Forms.Label()
        Me.TXT_prenom_etud = New System.Windows.Forms.TextBox()
        Me.LBL_prenom_etud = New System.Windows.Forms.Label()
        Me.PB_photo_etud = New System.Windows.Forms.PictureBox()
        Me.LBL_photo_etud = New System.Windows.Forms.Label()
        Me.GB_enseignant = New System.Windows.Forms.GroupBox()
        Me.CB_type_ens = New System.Windows.Forms.ComboBox()
        Me.TXT_nadh_ens = New System.Windows.Forms.TextBox()
        Me.BT_parcourir_enseignant = New System.Windows.Forms.Button()
        Me.LBL_nadh_ens = New System.Windows.Forms.Label()
        Me.BT_ins_enseignant = New System.Windows.Forms.Button()
        Me.LBL_type_ens = New System.Windows.Forms.Label()
        Me.LBL_passe_ens = New System.Windows.Forms.Label()
        Me.TXT_passe_ens = New System.Windows.Forms.TextBox()
        Me.LBL_matiere_enseignees = New System.Windows.Forms.Label()
        Me.LBL_login_ens = New System.Windows.Forms.Label()
        Me.TXT_matiere_enseignees = New System.Windows.Forms.TextBox()
        Me.TXT_login_ens = New System.Windows.Forms.TextBox()
        Me.TXT_dr_ens = New System.Windows.Forms.TextBox()
        Me.LBL_dr_ens = New System.Windows.Forms.Label()
        Me.TXT_nat_ens = New System.Windows.Forms.TextBox()
        Me.LBL_nat_ens = New System.Windows.Forms.Label()
        Me.TXT_mail_ens = New System.Windows.Forms.TextBox()
        Me.LBL_mail_ens = New System.Windows.Forms.Label()
        Me.LBL_tel_ens = New System.Windows.Forms.Label()
        Me.TXT_tel_ens = New System.Windows.Forms.TextBox()
        Me.LBL_me_ens = New System.Windows.Forms.Label()
        Me.TXT_me_ens = New System.Windows.Forms.TextBox()
        Me.TXT_prenom_ens = New System.Windows.Forms.TextBox()
        Me.LBL_prenom_ens = New System.Windows.Forms.Label()
        Me.LBL_nom_ens = New System.Windows.Forms.Label()
        Me.TXT_nom_ens = New System.Windows.Forms.TextBox()
        Me.PB_photo_ens = New System.Windows.Forms.PictureBox()
        Me.LBL_photo_ens = New System.Windows.Forms.Label()
        Me.OFD_Form1 = New System.Windows.Forms.OpenFileDialog()
        Me.BT_logouasz = New System.Windows.Forms.Button()
        Me.BT_logomi = New System.Windows.Forms.Button()
        Me.MS_form1.SuspendLayout()
        Me.GB_connexion.SuspendLayout()
        CType(Me.PB_connexion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_etudiant.SuspendLayout()
        CType(Me.PB_photo_etud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_enseignant.SuspendLayout()
        CType(Me.PB_photo_ens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_universite
        '
        Me.LBL_universite.AutoSize = True
        Me.LBL_universite.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_universite.ForeColor = System.Drawing.Color.White
        Me.LBL_universite.Location = New System.Drawing.Point(200, 31)
        Me.LBL_universite.Name = "LBL_universite"
        Me.LBL_universite.Size = New System.Drawing.Size(769, 24)
        Me.LBL_universite.TabIndex = 2
        Me.LBL_universite.Text = "Université Assane SECK de Ziguinchor - Département Mathématique et Informatique"
        '
        'LBL_login
        '
        Me.LBL_login.AutoSize = True
        Me.LBL_login.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_login.ForeColor = System.Drawing.Color.White
        Me.LBL_login.Location = New System.Drawing.Point(6, 200)
        Me.LBL_login.Name = "LBL_login"
        Me.LBL_login.Size = New System.Drawing.Size(47, 19)
        Me.LBL_login.TabIndex = 5
        Me.LBL_login.Text = "Login"
        '
        'LBL_passe
        '
        Me.LBL_passe.AutoSize = True
        Me.LBL_passe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_passe.ForeColor = System.Drawing.Color.White
        Me.LBL_passe.Location = New System.Drawing.Point(6, 235)
        Me.LBL_passe.Name = "LBL_passe"
        Me.LBL_passe.Size = New System.Drawing.Size(100, 19)
        Me.LBL_passe.TabIndex = 5
        Me.LBL_passe.Text = "Mot de passe"
        '
        'TXT_login
        '
        Me.TXT_login.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_login.Location = New System.Drawing.Point(128, 197)
        Me.TXT_login.Name = "TXT_login"
        Me.TXT_login.Size = New System.Drawing.Size(153, 22)
        Me.TXT_login.TabIndex = 6
        '
        'TXT_passe
        '
        Me.TXT_passe.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_passe.Location = New System.Drawing.Point(128, 232)
        Me.TXT_passe.Name = "TXT_passe"
        Me.TXT_passe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_passe.Size = New System.Drawing.Size(153, 22)
        Me.TXT_passe.TabIndex = 6
        '
        'MS_form1
        '
        Me.MS_form1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.OutilsToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MS_form1.Location = New System.Drawing.Point(0, 0)
        Me.MS_form1.Name = "MS_form1"
        Me.MS_form1.Size = New System.Drawing.Size(1350, 24)
        Me.MS_form1.TabIndex = 8
        Me.MS_form1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem1.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaseDeDonnéeToolStripMenuItem})
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.OutilsToolStripMenuItem.Text = "Outils"
        '
        'BaseDeDonnéeToolStripMenuItem
        '
        Me.BaseDeDonnéeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VérifierLaConnectionToolStripMenuItem, Me.SeConnecterToolStripMenuItem})
        Me.BaseDeDonnéeToolStripMenuItem.Name = "BaseDeDonnéeToolStripMenuItem"
        Me.BaseDeDonnéeToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.BaseDeDonnéeToolStripMenuItem.Text = "Base de donnée"
        '
        'VérifierLaConnectionToolStripMenuItem
        '
        Me.VérifierLaConnectionToolStripMenuItem.Name = "VérifierLaConnectionToolStripMenuItem"
        Me.VérifierLaConnectionToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.VérifierLaConnectionToolStripMenuItem.Text = "Vérifier la connection"
        '
        'SeConnecterToolStripMenuItem
        '
        Me.SeConnecterToolStripMenuItem.Name = "SeConnecterToolStripMenuItem"
        Me.SeConnecterToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SeConnecterToolStripMenuItem.Text = "Se connecter"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AideToolStripMenuItem1, Me.AProposToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'AideToolStripMenuItem1
        '
        Me.AideToolStripMenuItem1.Name = "AideToolStripMenuItem1"
        Me.AideToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.AideToolStripMenuItem1.Text = "Visualiser l'aide"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AProposToolStripMenuItem.Text = "À propos"
        '
        'LBL_heure
        '
        Me.LBL_heure.AutoSize = True
        Me.LBL_heure.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_heure.ForeColor = System.Drawing.Color.White
        Me.LBL_heure.Location = New System.Drawing.Point(804, 79)
        Me.LBL_heure.Name = "LBL_heure"
        Me.LBL_heure.Size = New System.Drawing.Size(110, 40)
        Me.LBL_heure.TabIndex = 11
        Me.LBL_heure.Text = "Heure"
        '
        'TM_form1
        '
        Me.TM_form1.Interval = 1000
        '
        'LBL_date
        '
        Me.LBL_date.AutoSize = True
        Me.LBL_date.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_date.ForeColor = System.Drawing.Color.White
        Me.LBL_date.Location = New System.Drawing.Point(235, 79)
        Me.LBL_date.Name = "LBL_date"
        Me.LBL_date.Size = New System.Drawing.Size(88, 40)
        Me.LBL_date.TabIndex = 12
        Me.LBL_date.Text = "Date"
        '
        'GB_connexion
        '
        Me.GB_connexion.BackColor = System.Drawing.Color.Teal
        Me.GB_connexion.Controls.Add(Me.PB_connexion)
        Me.GB_connexion.Controls.Add(Me.LBL_login)
        Me.GB_connexion.Controls.Add(Me.LBL_passe)
        Me.GB_connexion.Controls.Add(Me.TXT_login)
        Me.GB_connexion.Controls.Add(Me.BT_connexion)
        Me.GB_connexion.Controls.Add(Me.TXT_passe)
        Me.GB_connexion.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_connexion.ForeColor = System.Drawing.Color.White
        Me.GB_connexion.Location = New System.Drawing.Point(991, 140)
        Me.GB_connexion.Name = "GB_connexion"
        Me.GB_connexion.Size = New System.Drawing.Size(342, 309)
        Me.GB_connexion.TabIndex = 15
        Me.GB_connexion.TabStop = False
        Me.GB_connexion.Text = "Connexion"
        '
        'PB_connexion
        '
        Me.PB_connexion.BackColor = System.Drawing.Color.White
        Me.PB_connexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PB_connexion.Image = Global.pvb_bmi.My.Resources.Resources.securite
        Me.PB_connexion.Location = New System.Drawing.Point(128, 38)
        Me.PB_connexion.Name = "PB_connexion"
        Me.PB_connexion.Size = New System.Drawing.Size(153, 153)
        Me.PB_connexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_connexion.TabIndex = 8
        Me.PB_connexion.TabStop = False
        '
        'BT_connexion
        '
        Me.BT_connexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_connexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_connexion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_connexion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_connexion.ForeColor = System.Drawing.Color.White
        Me.BT_connexion.Location = New System.Drawing.Point(128, 260)
        Me.BT_connexion.Name = "BT_connexion"
        Me.BT_connexion.Size = New System.Drawing.Size(153, 28)
        Me.BT_connexion.TabIndex = 7
        Me.BT_connexion.Text = "Connexion"
        Me.BT_connexion.UseVisualStyleBackColor = False
        '
        'GB_etudiant
        '
        Me.GB_etudiant.BackColor = System.Drawing.Color.Teal
        Me.GB_etudiant.Controls.Add(Me.CB_catsp_etud)
        Me.GB_etudiant.Controls.Add(Me.CB_type_etud)
        Me.GB_etudiant.Controls.Add(Me.TXT_nadh_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_nadh_etud)
        Me.GB_etudiant.Controls.Add(Me.BT_parcourir_etudiant)
        Me.GB_etudiant.Controls.Add(Me.BT_ins_etudiant)
        Me.GB_etudiant.Controls.Add(Me.TXT_nom_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_nom_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_type_etud)
        Me.GB_etudiant.Controls.Add(Me.TXT_passe_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_passe_etud)
        Me.GB_etudiant.Controls.Add(Me.TXT_login_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_login_etud)
        Me.GB_etudiant.Controls.Add(Me.TXT_net_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_net_etud)
        Me.GB_etudiant.Controls.Add(Me.TXT_nat_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_nat_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_catsp_etud)
        Me.GB_etudiant.Controls.Add(Me.TXT_mail_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_mail_etud)
        Me.GB_etudiant.Controls.Add(Me.TXT_tel_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_tel_etud)
        Me.GB_etudiant.Controls.Add(Me.TXT_nce_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_nce_etud)
        Me.GB_etudiant.Controls.Add(Me.TXT_prenom_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_prenom_etud)
        Me.GB_etudiant.Controls.Add(Me.PB_photo_etud)
        Me.GB_etudiant.Controls.Add(Me.LBL_photo_etud)
        Me.GB_etudiant.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_etudiant.ForeColor = System.Drawing.Color.White
        Me.GB_etudiant.Location = New System.Drawing.Point(12, 140)
        Me.GB_etudiant.Name = "GB_etudiant"
        Me.GB_etudiant.Size = New System.Drawing.Size(468, 546)
        Me.GB_etudiant.TabIndex = 16
        Me.GB_etudiant.TabStop = False
        Me.GB_etudiant.Text = "Inscription Etudiant"
        '
        'CB_catsp_etud
        '
        Me.CB_catsp_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_catsp_etud.FormattingEnabled = True
        Me.CB_catsp_etud.Location = New System.Drawing.Point(139, 386)
        Me.CB_catsp_etud.Name = "CB_catsp_etud"
        Me.CB_catsp_etud.Size = New System.Drawing.Size(145, 23)
        Me.CB_catsp_etud.TabIndex = 34
        '
        'CB_type_etud
        '
        Me.CB_type_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_type_etud.FormattingEnabled = True
        Me.CB_type_etud.Location = New System.Drawing.Point(139, 502)
        Me.CB_type_etud.Name = "CB_type_etud"
        Me.CB_type_etud.Size = New System.Drawing.Size(146, 23)
        Me.CB_type_etud.TabIndex = 33
        '
        'TXT_nadh_etud
        '
        Me.TXT_nadh_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_nadh_etud.Location = New System.Drawing.Point(139, 190)
        Me.TXT_nadh_etud.Name = "TXT_nadh_etud"
        Me.TXT_nadh_etud.Size = New System.Drawing.Size(145, 22)
        Me.TXT_nadh_etud.TabIndex = 32
        '
        'LBL_nadh_etud
        '
        Me.LBL_nadh_etud.AutoSize = True
        Me.LBL_nadh_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nadh_etud.Location = New System.Drawing.Point(4, 190)
        Me.LBL_nadh_etud.Name = "LBL_nadh_etud"
        Me.LBL_nadh_etud.Size = New System.Drawing.Size(128, 19)
        Me.LBL_nadh_etud.TabIndex = 18
        Me.LBL_nadh_etud.Text = "Numéro Adherent"
        '
        'BT_parcourir_etudiant
        '
        Me.BT_parcourir_etudiant.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_parcourir_etudiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_parcourir_etudiant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_parcourir_etudiant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_parcourir_etudiant.ForeColor = System.Drawing.Color.White
        Me.BT_parcourir_etudiant.Location = New System.Drawing.Point(304, 164)
        Me.BT_parcourir_etudiant.Name = "BT_parcourir_etudiant"
        Me.BT_parcourir_etudiant.Size = New System.Drawing.Size(107, 27)
        Me.BT_parcourir_etudiant.TabIndex = 31
        Me.BT_parcourir_etudiant.Text = "Parcourir"
        Me.BT_parcourir_etudiant.UseVisualStyleBackColor = False
        '
        'BT_ins_etudiant
        '
        Me.BT_ins_etudiant.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_ins_etudiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_ins_etudiant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_ins_etudiant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ins_etudiant.ForeColor = System.Drawing.Color.White
        Me.BT_ins_etudiant.Location = New System.Drawing.Point(304, 496)
        Me.BT_ins_etudiant.Name = "BT_ins_etudiant"
        Me.BT_ins_etudiant.Size = New System.Drawing.Size(107, 28)
        Me.BT_ins_etudiant.TabIndex = 30
        Me.BT_ins_etudiant.Text = "Inscription"
        Me.BT_ins_etudiant.UseVisualStyleBackColor = False
        '
        'TXT_nom_etud
        '
        Me.TXT_nom_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_nom_etud.Location = New System.Drawing.Point(139, 218)
        Me.TXT_nom_etud.Name = "TXT_nom_etud"
        Me.TXT_nom_etud.Size = New System.Drawing.Size(145, 22)
        Me.TXT_nom_etud.TabIndex = 6
        '
        'LBL_nom_etud
        '
        Me.LBL_nom_etud.AutoSize = True
        Me.LBL_nom_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nom_etud.Location = New System.Drawing.Point(6, 221)
        Me.LBL_nom_etud.Name = "LBL_nom_etud"
        Me.LBL_nom_etud.Size = New System.Drawing.Size(41, 19)
        Me.LBL_nom_etud.TabIndex = 5
        Me.LBL_nom_etud.Text = "Nom"
        '
        'LBL_type_etud
        '
        Me.LBL_type_etud.AutoSize = True
        Me.LBL_type_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_type_etud.Location = New System.Drawing.Point(6, 506)
        Me.LBL_type_etud.Name = "LBL_type_etud"
        Me.LBL_type_etud.Size = New System.Drawing.Size(42, 19)
        Me.LBL_type_etud.TabIndex = 28
        Me.LBL_type_etud.Text = "Type"
        '
        'TXT_passe_etud
        '
        Me.TXT_passe_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_passe_etud.Location = New System.Drawing.Point(139, 474)
        Me.TXT_passe_etud.Name = "TXT_passe_etud"
        Me.TXT_passe_etud.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_passe_etud.Size = New System.Drawing.Size(145, 22)
        Me.TXT_passe_etud.TabIndex = 27
        '
        'LBL_passe_etud
        '
        Me.LBL_passe_etud.AutoSize = True
        Me.LBL_passe_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_passe_etud.Location = New System.Drawing.Point(6, 477)
        Me.LBL_passe_etud.Name = "LBL_passe_etud"
        Me.LBL_passe_etud.Size = New System.Drawing.Size(100, 19)
        Me.LBL_passe_etud.TabIndex = 26
        Me.LBL_passe_etud.Text = "Mot de passe"
        '
        'TXT_login_etud
        '
        Me.TXT_login_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_login_etud.Location = New System.Drawing.Point(139, 444)
        Me.TXT_login_etud.Name = "TXT_login_etud"
        Me.TXT_login_etud.Size = New System.Drawing.Size(145, 22)
        Me.TXT_login_etud.TabIndex = 25
        '
        'LBL_login_etud
        '
        Me.LBL_login_etud.AutoSize = True
        Me.LBL_login_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_login_etud.Location = New System.Drawing.Point(6, 447)
        Me.LBL_login_etud.Name = "LBL_login_etud"
        Me.LBL_login_etud.Size = New System.Drawing.Size(47, 19)
        Me.LBL_login_etud.TabIndex = 24
        Me.LBL_login_etud.Text = "Login"
        '
        'TXT_net_etud
        '
        Me.TXT_net_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_net_etud.Location = New System.Drawing.Point(139, 415)
        Me.TXT_net_etud.Name = "TXT_net_etud"
        Me.TXT_net_etud.Size = New System.Drawing.Size(145, 22)
        Me.TXT_net_etud.TabIndex = 23
        '
        'LBL_net_etud
        '
        Me.LBL_net_etud.AutoSize = True
        Me.LBL_net_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_net_etud.Location = New System.Drawing.Point(6, 418)
        Me.LBL_net_etud.Name = "LBL_net_etud"
        Me.LBL_net_etud.Size = New System.Drawing.Size(110, 19)
        Me.LBL_net_etud.TabIndex = 22
        Me.LBL_net_etud.Text = "Niveau d'étude"
        '
        'TXT_nat_etud
        '
        Me.TXT_nat_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_nat_etud.Location = New System.Drawing.Point(139, 358)
        Me.TXT_nat_etud.Name = "TXT_nat_etud"
        Me.TXT_nat_etud.Size = New System.Drawing.Size(145, 22)
        Me.TXT_nat_etud.TabIndex = 19
        '
        'LBL_nat_etud
        '
        Me.LBL_nat_etud.AutoSize = True
        Me.LBL_nat_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nat_etud.Location = New System.Drawing.Point(6, 361)
        Me.LBL_nat_etud.Name = "LBL_nat_etud"
        Me.LBL_nat_etud.Size = New System.Drawing.Size(83, 19)
        Me.LBL_nat_etud.TabIndex = 18
        Me.LBL_nat_etud.Text = "Nationalité"
        '
        'LBL_catsp_etud
        '
        Me.LBL_catsp_etud.AutoSize = True
        Me.LBL_catsp_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_catsp_etud.Location = New System.Drawing.Point(6, 390)
        Me.LBL_catsp_etud.Name = "LBL_catsp_etud"
        Me.LBL_catsp_etud.Size = New System.Drawing.Size(97, 19)
        Me.LBL_catsp_etud.TabIndex = 16
        Me.LBL_catsp_etud.Text = "Catégorie SP"
        '
        'TXT_mail_etud
        '
        Me.TXT_mail_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_mail_etud.Location = New System.Drawing.Point(140, 330)
        Me.TXT_mail_etud.Name = "TXT_mail_etud"
        Me.TXT_mail_etud.Size = New System.Drawing.Size(145, 22)
        Me.TXT_mail_etud.TabIndex = 15
        '
        'LBL_mail_etud
        '
        Me.LBL_mail_etud.AutoSize = True
        Me.LBL_mail_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_mail_etud.Location = New System.Drawing.Point(4, 333)
        Me.LBL_mail_etud.Name = "LBL_mail_etud"
        Me.LBL_mail_etud.Size = New System.Drawing.Size(47, 19)
        Me.LBL_mail_etud.TabIndex = 14
        Me.LBL_mail_etud.Text = "Email"
        '
        'TXT_tel_etud
        '
        Me.TXT_tel_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_tel_etud.Location = New System.Drawing.Point(139, 302)
        Me.TXT_tel_etud.Name = "TXT_tel_etud"
        Me.TXT_tel_etud.Size = New System.Drawing.Size(145, 22)
        Me.TXT_tel_etud.TabIndex = 13
        '
        'LBL_tel_etud
        '
        Me.LBL_tel_etud.AutoSize = True
        Me.LBL_tel_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_tel_etud.Location = New System.Drawing.Point(6, 305)
        Me.LBL_tel_etud.Name = "LBL_tel_etud"
        Me.LBL_tel_etud.Size = New System.Drawing.Size(79, 19)
        Me.LBL_tel_etud.TabIndex = 12
        Me.LBL_tel_etud.Text = "Téléphone"
        '
        'TXT_nce_etud
        '
        Me.TXT_nce_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_nce_etud.Location = New System.Drawing.Point(139, 274)
        Me.TXT_nce_etud.Name = "TXT_nce_etud"
        Me.TXT_nce_etud.Size = New System.Drawing.Size(145, 22)
        Me.TXT_nce_etud.TabIndex = 10
        '
        'LBL_nce_etud
        '
        Me.LBL_nce_etud.AutoSize = True
        Me.LBL_nce_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nce_etud.Location = New System.Drawing.Point(6, 277)
        Me.LBL_nce_etud.Name = "LBL_nce_etud"
        Me.LBL_nce_etud.Size = New System.Drawing.Size(88, 19)
        Me.LBL_nce_etud.TabIndex = 9
        Me.LBL_nce_etud.Text = "Numéro CE"
        '
        'TXT_prenom_etud
        '
        Me.TXT_prenom_etud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_prenom_etud.Location = New System.Drawing.Point(139, 246)
        Me.TXT_prenom_etud.Name = "TXT_prenom_etud"
        Me.TXT_prenom_etud.Size = New System.Drawing.Size(145, 22)
        Me.TXT_prenom_etud.TabIndex = 8
        '
        'LBL_prenom_etud
        '
        Me.LBL_prenom_etud.AutoSize = True
        Me.LBL_prenom_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_prenom_etud.Location = New System.Drawing.Point(6, 249)
        Me.LBL_prenom_etud.Name = "LBL_prenom_etud"
        Me.LBL_prenom_etud.Size = New System.Drawing.Size(60, 19)
        Me.LBL_prenom_etud.TabIndex = 7
        Me.LBL_prenom_etud.Text = "Prénom"
        '
        'PB_photo_etud
        '
        Me.PB_photo_etud.BackColor = System.Drawing.Color.White
        Me.PB_photo_etud.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.Picto_user_320x320
        Me.PB_photo_etud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_photo_etud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_photo_etud.ImageLocation = ""
        Me.PB_photo_etud.Location = New System.Drawing.Point(139, 38)
        Me.PB_photo_etud.Name = "PB_photo_etud"
        Me.PB_photo_etud.Size = New System.Drawing.Size(145, 146)
        Me.PB_photo_etud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_photo_etud.TabIndex = 4
        Me.PB_photo_etud.TabStop = False
        '
        'LBL_photo_etud
        '
        Me.LBL_photo_etud.AutoSize = True
        Me.LBL_photo_etud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_photo_etud.Location = New System.Drawing.Point(6, 50)
        Me.LBL_photo_etud.Name = "LBL_photo_etud"
        Me.LBL_photo_etud.Size = New System.Drawing.Size(47, 19)
        Me.LBL_photo_etud.TabIndex = 1
        Me.LBL_photo_etud.Text = "Photo"
        '
        'GB_enseignant
        '
        Me.GB_enseignant.BackColor = System.Drawing.Color.Teal
        Me.GB_enseignant.Controls.Add(Me.CB_type_ens)
        Me.GB_enseignant.Controls.Add(Me.TXT_nadh_ens)
        Me.GB_enseignant.Controls.Add(Me.BT_parcourir_enseignant)
        Me.GB_enseignant.Controls.Add(Me.LBL_nadh_ens)
        Me.GB_enseignant.Controls.Add(Me.BT_ins_enseignant)
        Me.GB_enseignant.Controls.Add(Me.LBL_type_ens)
        Me.GB_enseignant.Controls.Add(Me.LBL_passe_ens)
        Me.GB_enseignant.Controls.Add(Me.TXT_passe_ens)
        Me.GB_enseignant.Controls.Add(Me.LBL_matiere_enseignees)
        Me.GB_enseignant.Controls.Add(Me.LBL_login_ens)
        Me.GB_enseignant.Controls.Add(Me.TXT_matiere_enseignees)
        Me.GB_enseignant.Controls.Add(Me.TXT_login_ens)
        Me.GB_enseignant.Controls.Add(Me.TXT_dr_ens)
        Me.GB_enseignant.Controls.Add(Me.LBL_dr_ens)
        Me.GB_enseignant.Controls.Add(Me.TXT_nat_ens)
        Me.GB_enseignant.Controls.Add(Me.LBL_nat_ens)
        Me.GB_enseignant.Controls.Add(Me.TXT_mail_ens)
        Me.GB_enseignant.Controls.Add(Me.LBL_mail_ens)
        Me.GB_enseignant.Controls.Add(Me.LBL_tel_ens)
        Me.GB_enseignant.Controls.Add(Me.TXT_tel_ens)
        Me.GB_enseignant.Controls.Add(Me.LBL_me_ens)
        Me.GB_enseignant.Controls.Add(Me.TXT_me_ens)
        Me.GB_enseignant.Controls.Add(Me.TXT_prenom_ens)
        Me.GB_enseignant.Controls.Add(Me.LBL_prenom_ens)
        Me.GB_enseignant.Controls.Add(Me.LBL_nom_ens)
        Me.GB_enseignant.Controls.Add(Me.TXT_nom_ens)
        Me.GB_enseignant.Controls.Add(Me.PB_photo_ens)
        Me.GB_enseignant.Controls.Add(Me.LBL_photo_ens)
        Me.GB_enseignant.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_enseignant.ForeColor = System.Drawing.Color.White
        Me.GB_enseignant.Location = New System.Drawing.Point(486, 140)
        Me.GB_enseignant.Name = "GB_enseignant"
        Me.GB_enseignant.Size = New System.Drawing.Size(499, 546)
        Me.GB_enseignant.TabIndex = 17
        Me.GB_enseignant.TabStop = False
        Me.GB_enseignant.Text = "Inscription Enseignant"
        '
        'CB_type_ens
        '
        Me.CB_type_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_type_ens.FormattingEnabled = True
        Me.CB_type_ens.Location = New System.Drawing.Point(192, 497)
        Me.CB_type_ens.Name = "CB_type_ens"
        Me.CB_type_ens.Size = New System.Drawing.Size(138, 23)
        Me.CB_type_ens.TabIndex = 33
        '
        'TXT_nadh_ens
        '
        Me.TXT_nadh_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_nadh_ens.Location = New System.Drawing.Point(192, 190)
        Me.TXT_nadh_ens.Name = "TXT_nadh_ens"
        Me.TXT_nadh_ens.Size = New System.Drawing.Size(138, 22)
        Me.TXT_nadh_ens.TabIndex = 32
        '
        'BT_parcourir_enseignant
        '
        Me.BT_parcourir_enseignant.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_parcourir_enseignant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_parcourir_enseignant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_parcourir_enseignant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_parcourir_enseignant.ForeColor = System.Drawing.Color.White
        Me.BT_parcourir_enseignant.Location = New System.Drawing.Point(342, 164)
        Me.BT_parcourir_enseignant.Name = "BT_parcourir_enseignant"
        Me.BT_parcourir_enseignant.Size = New System.Drawing.Size(112, 27)
        Me.BT_parcourir_enseignant.TabIndex = 29
        Me.BT_parcourir_enseignant.Text = "Parcourir"
        Me.BT_parcourir_enseignant.UseVisualStyleBackColor = False
        '
        'LBL_nadh_ens
        '
        Me.LBL_nadh_ens.AutoSize = True
        Me.LBL_nadh_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nadh_ens.Location = New System.Drawing.Point(16, 190)
        Me.LBL_nadh_ens.Name = "LBL_nadh_ens"
        Me.LBL_nadh_ens.Size = New System.Drawing.Size(128, 19)
        Me.LBL_nadh_ens.TabIndex = 18
        Me.LBL_nadh_ens.Text = "Numéro Adherent"
        '
        'BT_ins_enseignant
        '
        Me.BT_ins_enseignant.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_ins_enseignant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_ins_enseignant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_ins_enseignant.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ins_enseignant.ForeColor = System.Drawing.Color.White
        Me.BT_ins_enseignant.Location = New System.Drawing.Point(357, 496)
        Me.BT_ins_enseignant.Name = "BT_ins_enseignant"
        Me.BT_ins_enseignant.Size = New System.Drawing.Size(112, 28)
        Me.BT_ins_enseignant.TabIndex = 28
        Me.BT_ins_enseignant.Text = "Inscription"
        Me.BT_ins_enseignant.UseVisualStyleBackColor = False
        '
        'LBL_type_ens
        '
        Me.LBL_type_ens.AutoSize = True
        Me.LBL_type_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_type_ens.Location = New System.Drawing.Point(16, 497)
        Me.LBL_type_ens.Name = "LBL_type_ens"
        Me.LBL_type_ens.Size = New System.Drawing.Size(42, 19)
        Me.LBL_type_ens.TabIndex = 26
        Me.LBL_type_ens.Text = "Type"
        '
        'LBL_passe_ens
        '
        Me.LBL_passe_ens.AutoSize = True
        Me.LBL_passe_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_passe_ens.Location = New System.Drawing.Point(16, 469)
        Me.LBL_passe_ens.Name = "LBL_passe_ens"
        Me.LBL_passe_ens.Size = New System.Drawing.Size(100, 19)
        Me.LBL_passe_ens.TabIndex = 24
        Me.LBL_passe_ens.Text = "Mot de passe"
        '
        'TXT_passe_ens
        '
        Me.TXT_passe_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_passe_ens.Location = New System.Drawing.Point(192, 469)
        Me.TXT_passe_ens.Name = "TXT_passe_ens"
        Me.TXT_passe_ens.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_passe_ens.Size = New System.Drawing.Size(138, 22)
        Me.TXT_passe_ens.TabIndex = 25
        '
        'LBL_matiere_enseignees
        '
        Me.LBL_matiere_enseignees.AutoSize = True
        Me.LBL_matiere_enseignees.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_matiere_enseignees.Location = New System.Drawing.Point(16, 417)
        Me.LBL_matiere_enseignees.Name = "LBL_matiere_enseignees"
        Me.LBL_matiere_enseignees.Size = New System.Drawing.Size(149, 19)
        Me.LBL_matiere_enseignees.TabIndex = 22
        Me.LBL_matiere_enseignees.Text = "Matières enseignées"
        '
        'LBL_login_ens
        '
        Me.LBL_login_ens.AutoSize = True
        Me.LBL_login_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_login_ens.Location = New System.Drawing.Point(16, 444)
        Me.LBL_login_ens.Name = "LBL_login_ens"
        Me.LBL_login_ens.Size = New System.Drawing.Size(47, 19)
        Me.LBL_login_ens.TabIndex = 22
        Me.LBL_login_ens.Text = "Login"
        '
        'TXT_matiere_enseignees
        '
        Me.TXT_matiere_enseignees.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_matiere_enseignees.Location = New System.Drawing.Point(192, 414)
        Me.TXT_matiere_enseignees.Name = "TXT_matiere_enseignees"
        Me.TXT_matiere_enseignees.Size = New System.Drawing.Size(138, 22)
        Me.TXT_matiere_enseignees.TabIndex = 23
        '
        'TXT_login_ens
        '
        Me.TXT_login_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_login_ens.Location = New System.Drawing.Point(192, 441)
        Me.TXT_login_ens.Name = "TXT_login_ens"
        Me.TXT_login_ens.Size = New System.Drawing.Size(138, 22)
        Me.TXT_login_ens.TabIndex = 23
        '
        'TXT_dr_ens
        '
        Me.TXT_dr_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_dr_ens.Location = New System.Drawing.Point(192, 386)
        Me.TXT_dr_ens.Name = "TXT_dr_ens"
        Me.TXT_dr_ens.Size = New System.Drawing.Size(138, 22)
        Me.TXT_dr_ens.TabIndex = 21
        '
        'LBL_dr_ens
        '
        Me.LBL_dr_ens.AutoSize = True
        Me.LBL_dr_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_dr_ens.Location = New System.Drawing.Point(16, 390)
        Me.LBL_dr_ens.Name = "LBL_dr_ens"
        Me.LBL_dr_ens.Size = New System.Drawing.Size(165, 19)
        Me.LBL_dr_ens.TabIndex = 20
        Me.LBL_dr_ens.Text = "Domaine de Recherche"
        '
        'TXT_nat_ens
        '
        Me.TXT_nat_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_nat_ens.Location = New System.Drawing.Point(192, 358)
        Me.TXT_nat_ens.Name = "TXT_nat_ens"
        Me.TXT_nat_ens.Size = New System.Drawing.Size(138, 22)
        Me.TXT_nat_ens.TabIndex = 19
        '
        'LBL_nat_ens
        '
        Me.LBL_nat_ens.AutoSize = True
        Me.LBL_nat_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nat_ens.Location = New System.Drawing.Point(16, 361)
        Me.LBL_nat_ens.Name = "LBL_nat_ens"
        Me.LBL_nat_ens.Size = New System.Drawing.Size(83, 19)
        Me.LBL_nat_ens.TabIndex = 18
        Me.LBL_nat_ens.Text = "Nationalité"
        '
        'TXT_mail_ens
        '
        Me.TXT_mail_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_mail_ens.Location = New System.Drawing.Point(192, 330)
        Me.TXT_mail_ens.Name = "TXT_mail_ens"
        Me.TXT_mail_ens.Size = New System.Drawing.Size(138, 22)
        Me.TXT_mail_ens.TabIndex = 17
        '
        'LBL_mail_ens
        '
        Me.LBL_mail_ens.AutoSize = True
        Me.LBL_mail_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_mail_ens.Location = New System.Drawing.Point(16, 330)
        Me.LBL_mail_ens.Name = "LBL_mail_ens"
        Me.LBL_mail_ens.Size = New System.Drawing.Size(47, 19)
        Me.LBL_mail_ens.TabIndex = 16
        Me.LBL_mail_ens.Text = "Email"
        '
        'LBL_tel_ens
        '
        Me.LBL_tel_ens.AutoSize = True
        Me.LBL_tel_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_tel_ens.Location = New System.Drawing.Point(16, 302)
        Me.LBL_tel_ens.Name = "LBL_tel_ens"
        Me.LBL_tel_ens.Size = New System.Drawing.Size(79, 19)
        Me.LBL_tel_ens.TabIndex = 14
        Me.LBL_tel_ens.Text = "Téléphone"
        '
        'TXT_tel_ens
        '
        Me.TXT_tel_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_tel_ens.Location = New System.Drawing.Point(192, 302)
        Me.TXT_tel_ens.Name = "TXT_tel_ens"
        Me.TXT_tel_ens.Size = New System.Drawing.Size(138, 22)
        Me.TXT_tel_ens.TabIndex = 15
        '
        'LBL_me_ens
        '
        Me.LBL_me_ens.AutoSize = True
        Me.LBL_me_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_me_ens.Location = New System.Drawing.Point(16, 274)
        Me.LBL_me_ens.Name = "LBL_me_ens"
        Me.LBL_me_ens.Size = New System.Drawing.Size(153, 19)
        Me.LBL_me_ens.TabIndex = 12
        Me.LBL_me_ens.Text = "Matricule Enseignant"
        '
        'TXT_me_ens
        '
        Me.TXT_me_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_me_ens.Location = New System.Drawing.Point(192, 274)
        Me.TXT_me_ens.Name = "TXT_me_ens"
        Me.TXT_me_ens.Size = New System.Drawing.Size(138, 22)
        Me.TXT_me_ens.TabIndex = 13
        '
        'TXT_prenom_ens
        '
        Me.TXT_prenom_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_prenom_ens.Location = New System.Drawing.Point(192, 246)
        Me.TXT_prenom_ens.Name = "TXT_prenom_ens"
        Me.TXT_prenom_ens.Size = New System.Drawing.Size(138, 22)
        Me.TXT_prenom_ens.TabIndex = 11
        '
        'LBL_prenom_ens
        '
        Me.LBL_prenom_ens.AutoSize = True
        Me.LBL_prenom_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_prenom_ens.Location = New System.Drawing.Point(16, 249)
        Me.LBL_prenom_ens.Name = "LBL_prenom_ens"
        Me.LBL_prenom_ens.Size = New System.Drawing.Size(60, 19)
        Me.LBL_prenom_ens.TabIndex = 10
        Me.LBL_prenom_ens.Text = "Prénom"
        '
        'LBL_nom_ens
        '
        Me.LBL_nom_ens.AutoSize = True
        Me.LBL_nom_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nom_ens.Location = New System.Drawing.Point(16, 221)
        Me.LBL_nom_ens.Name = "LBL_nom_ens"
        Me.LBL_nom_ens.Size = New System.Drawing.Size(41, 19)
        Me.LBL_nom_ens.TabIndex = 8
        Me.LBL_nom_ens.Text = "Nom"
        '
        'TXT_nom_ens
        '
        Me.TXT_nom_ens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_nom_ens.Location = New System.Drawing.Point(192, 218)
        Me.TXT_nom_ens.Name = "TXT_nom_ens"
        Me.TXT_nom_ens.Size = New System.Drawing.Size(138, 22)
        Me.TXT_nom_ens.TabIndex = 9
        '
        'PB_photo_ens
        '
        Me.PB_photo_ens.BackColor = System.Drawing.Color.White
        Me.PB_photo_ens.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.Picto_user_320x320
        Me.PB_photo_ens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_photo_ens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_photo_ens.Location = New System.Drawing.Point(192, 38)
        Me.PB_photo_ens.Name = "PB_photo_ens"
        Me.PB_photo_ens.Size = New System.Drawing.Size(138, 146)
        Me.PB_photo_ens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_photo_ens.TabIndex = 5
        Me.PB_photo_ens.TabStop = False
        '
        'LBL_photo_ens
        '
        Me.LBL_photo_ens.AutoSize = True
        Me.LBL_photo_ens.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_photo_ens.Location = New System.Drawing.Point(16, 38)
        Me.LBL_photo_ens.Name = "LBL_photo_ens"
        Me.LBL_photo_ens.Size = New System.Drawing.Size(47, 19)
        Me.LBL_photo_ens.TabIndex = 4
        Me.LBL_photo_ens.Text = "Photo"
        '
        'BT_logouasz
        '
        Me.BT_logouasz.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.UASZ
        Me.BT_logouasz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_logouasz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_logouasz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BT_logouasz.Location = New System.Drawing.Point(12, 31)
        Me.BT_logouasz.Name = "BT_logouasz"
        Me.BT_logouasz.Size = New System.Drawing.Size(96, 88)
        Me.BT_logouasz.TabIndex = 18
        Me.BT_logouasz.UseVisualStyleBackColor = True
        '
        'BT_logomi
        '
        Me.BT_logomi.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.logo_ufr_couleur
        Me.BT_logomi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_logomi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_logomi.Location = New System.Drawing.Point(1091, 31)
        Me.BT_logomi.Name = "BT_logomi"
        Me.BT_logomi.Size = New System.Drawing.Size(242, 88)
        Me.BT_logomi.TabIndex = 19
        Me.BT_logomi.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.BT_connexion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.BT_logomi)
        Me.Controls.Add(Me.BT_logouasz)
        Me.Controls.Add(Me.GB_enseignant)
        Me.Controls.Add(Me.GB_etudiant)
        Me.Controls.Add(Me.GB_connexion)
        Me.Controls.Add(Me.LBL_date)
        Me.Controls.Add(Me.LBL_heure)
        Me.Controls.Add(Me.LBL_universite)
        Me.Controls.Add(Me.MS_form1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MS_form1
        Me.Name = "Form1"
        Me.Text = "Mathématique Informatique"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MS_form1.ResumeLayout(False)
        Me.MS_form1.PerformLayout()
        Me.GB_connexion.ResumeLayout(False)
        Me.GB_connexion.PerformLayout()
        CType(Me.PB_connexion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_etudiant.ResumeLayout(False)
        Me.GB_etudiant.PerformLayout()
        CType(Me.PB_photo_etud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_enseignant.ResumeLayout(False)
        Me.GB_enseignant.PerformLayout()
        CType(Me.PB_photo_ens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_universite As Label
    Friend WithEvents LBL_login As Label
    Friend WithEvents LBL_passe As Label
    Friend WithEvents TXT_login As TextBox
    Friend WithEvents TXT_passe As TextBox
    Friend WithEvents BT_connexion As Button
    Friend WithEvents MS_form1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDeDonnéeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VérifierLaConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LBL_heure As Label
    Friend WithEvents TM_form1 As Timer
    Friend WithEvents LBL_date As Label
    Friend WithEvents GB_connexion As GroupBox
    Friend WithEvents GB_etudiant As GroupBox
    Friend WithEvents GB_enseignant As GroupBox
    Friend WithEvents LBL_photo_etud As Label
    Friend WithEvents PB_photo_etud As PictureBox
    Friend WithEvents LBL_nom_etud As Label
    Friend WithEvents TXT_nom_etud As TextBox
    Friend WithEvents LBL_prenom_etud As Label
    Friend WithEvents TXT_prenom_etud As TextBox
    Friend WithEvents LBL_nce_etud As Label
    Friend WithEvents TXT_nce_etud As TextBox
    Friend WithEvents LBL_tel_etud As Label
    Friend WithEvents TXT_tel_etud As TextBox
    Friend WithEvents LBL_mail_etud As Label
    Friend WithEvents TXT_mail_etud As TextBox
    Friend WithEvents LBL_catsp_etud As Label
    Friend WithEvents LBL_nat_etud As Label
    Friend WithEvents TXT_nat_etud As TextBox
    Friend WithEvents LBL_net_etud As Label
    Friend WithEvents TXT_net_etud As TextBox
    Friend WithEvents LBL_login_etud As Label
    Friend WithEvents TXT_login_etud As TextBox
    Friend WithEvents LBL_passe_etud As Label
    Friend WithEvents TXT_passe_etud As TextBox
    Friend WithEvents LBL_type_etud As Label
    Friend WithEvents BT_ins_etudiant As Button
    Friend WithEvents PB_photo_ens As PictureBox
    Friend WithEvents LBL_photo_ens As Label
    Friend WithEvents LBL_nom_ens As Label
    Friend WithEvents TXT_nom_ens As TextBox
    Friend WithEvents TXT_prenom_ens As TextBox
    Friend WithEvents LBL_prenom_ens As Label
    Friend WithEvents LBL_me_ens As Label
    Friend WithEvents TXT_me_ens As TextBox
    Friend WithEvents LBL_tel_ens As Label
    Friend WithEvents TXT_tel_ens As TextBox
    Friend WithEvents TXT_mail_ens As TextBox
    Friend WithEvents LBL_mail_ens As Label
    Friend WithEvents TXT_nat_ens As TextBox
    Friend WithEvents LBL_nat_ens As Label
    Friend WithEvents TXT_dr_ens As TextBox
    Friend WithEvents LBL_dr_ens As Label
    Friend WithEvents LBL_login_ens As Label
    Friend WithEvents TXT_login_ens As TextBox
    Friend WithEvents LBL_passe_ens As Label
    Friend WithEvents TXT_passe_ens As TextBox
    Friend WithEvents LBL_type_ens As Label
    Friend WithEvents BT_ins_enseignant As Button
    Friend WithEvents BT_parcourir_etudiant As Button
    Friend WithEvents BT_parcourir_enseignant As Button
    Friend WithEvents OFD_Form1 As OpenFileDialog
    Friend WithEvents TXT_nadh_etud As TextBox
    Friend WithEvents LBL_nadh_etud As Label
    Friend WithEvents TXT_nadh_ens As TextBox
    Friend WithEvents LBL_nadh_ens As Label
    Friend WithEvents LBL_matiere_enseignees As Label
    Friend WithEvents TXT_matiere_enseignees As TextBox
    Friend WithEvents CB_catsp_etud As ComboBox
    Friend WithEvents CB_type_etud As ComboBox
    Friend WithEvents CB_type_ens As ComboBox
    Friend WithEvents SeConnecterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BT_logouasz As Button
    Friend WithEvents BT_logomi As Button
    Friend WithEvents PB_connexion As PictureBox
    Friend WithEvents AideToolStripMenuItem1 As ToolStripMenuItem
End Class
