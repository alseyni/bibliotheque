<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Applications
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
        Me.LBL_gestion = New System.Windows.Forms.Label()
        Me.LBL_universite = New System.Windows.Forms.Label()
        Me.LBL_date = New System.Windows.Forms.Label()
        Me.LBL_heure = New System.Windows.Forms.Label()
        Me.TM_applications = New System.Windows.Forms.Timer(Me.components)
        Me.MS_applications = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeDéconnecterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDeDonnéeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VérifierLaConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeConnecterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllerÀToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisciplinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalisationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilisateurSimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuperUtilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrêtsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherLaideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BT_localisation = New System.Windows.Forms.Button()
        Me.BT_prets = New System.Windows.Forms.Button()
        Me.BT_super = New System.Windows.Forms.Button()
        Me.BT_usimple = New System.Windows.Forms.Button()
        Me.BT_documents = New System.Windows.Forms.Button()
        Me.BT_disciplines = New System.Windows.Forms.Button()
        Me.BT_logouasz = New System.Windows.Forms.Button()
        Me.BT_logomi = New System.Windows.Forms.Button()
        Me.LBL_description = New System.Windows.Forms.Label()
        Me.MS_applications.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_gestion
        '
        Me.LBL_gestion.AutoSize = True
        Me.LBL_gestion.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_gestion.ForeColor = System.Drawing.Color.White
        Me.LBL_gestion.Location = New System.Drawing.Point(488, 93)
        Me.LBL_gestion.Name = "LBL_gestion"
        Me.LBL_gestion.Size = New System.Drawing.Size(137, 31)
        Me.LBL_gestion.TabIndex = 10
        Me.LBL_gestion.Text = "GESTION"
        '
        'LBL_universite
        '
        Me.LBL_universite.AutoSize = True
        Me.LBL_universite.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_universite.ForeColor = System.Drawing.Color.White
        Me.LBL_universite.Location = New System.Drawing.Point(180, 36)
        Me.LBL_universite.Name = "LBL_universite"
        Me.LBL_universite.Size = New System.Drawing.Size(769, 24)
        Me.LBL_universite.TabIndex = 12
        Me.LBL_universite.Text = "Université Assane SECK de Ziguinchor - Département Mathématique et Informatique"
        '
        'LBL_date
        '
        Me.LBL_date.AutoSize = True
        Me.LBL_date.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_date.ForeColor = System.Drawing.Color.White
        Me.LBL_date.Location = New System.Drawing.Point(218, 84)
        Me.LBL_date.Name = "LBL_date"
        Me.LBL_date.Size = New System.Drawing.Size(88, 40)
        Me.LBL_date.TabIndex = 20
        Me.LBL_date.Text = "Date"
        '
        'LBL_heure
        '
        Me.LBL_heure.AutoSize = True
        Me.LBL_heure.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_heure.ForeColor = System.Drawing.Color.White
        Me.LBL_heure.Location = New System.Drawing.Point(795, 84)
        Me.LBL_heure.Name = "LBL_heure"
        Me.LBL_heure.Size = New System.Drawing.Size(110, 40)
        Me.LBL_heure.TabIndex = 21
        Me.LBL_heure.Text = "Heure"
        '
        'TM_applications
        '
        Me.TM_applications.Interval = 1000
        '
        'MS_applications
        '
        Me.MS_applications.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CompteToolStripMenuItem, Me.OutilsToolStripMenuItem, Me.AllerÀToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MS_applications.Location = New System.Drawing.Point(0, 0)
        Me.MS_applications.Name = "MS_applications"
        Me.MS_applications.Size = New System.Drawing.Size(1354, 24)
        Me.MS_applications.TabIndex = 25
        Me.MS_applications.Text = "MenuStrip1"
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
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'CompteToolStripMenuItem
        '
        Me.CompteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeDéconnecterToolStripMenuItem})
        Me.CompteToolStripMenuItem.Name = "CompteToolStripMenuItem"
        Me.CompteToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CompteToolStripMenuItem.Text = "Compte"
        '
        'SeDéconnecterToolStripMenuItem
        '
        Me.SeDéconnecterToolStripMenuItem.Name = "SeDéconnecterToolStripMenuItem"
        Me.SeDéconnecterToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SeDéconnecterToolStripMenuItem.Text = "Se déconnecter"
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
        'AllerÀToolStripMenuItem
        '
        Me.AllerÀToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisciplinesToolStripMenuItem, Me.DocumentsToolStripMenuItem, Me.LocalisationToolStripMenuItem, Me.UtilisateurSimpleToolStripMenuItem, Me.SuperUtilisateurToolStripMenuItem, Me.PrêtsToolStripMenuItem})
        Me.AllerÀToolStripMenuItem.Name = "AllerÀToolStripMenuItem"
        Me.AllerÀToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AllerÀToolStripMenuItem.Text = "Aller à"
        '
        'DisciplinesToolStripMenuItem
        '
        Me.DisciplinesToolStripMenuItem.Name = "DisciplinesToolStripMenuItem"
        Me.DisciplinesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DisciplinesToolStripMenuItem.Text = "Disciplines"
        '
        'DocumentsToolStripMenuItem
        '
        Me.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem"
        Me.DocumentsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DocumentsToolStripMenuItem.Text = "Documents"
        '
        'LocalisationToolStripMenuItem
        '
        Me.LocalisationToolStripMenuItem.Name = "LocalisationToolStripMenuItem"
        Me.LocalisationToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.LocalisationToolStripMenuItem.Text = "Localisation"
        '
        'UtilisateurSimpleToolStripMenuItem
        '
        Me.UtilisateurSimpleToolStripMenuItem.Name = "UtilisateurSimpleToolStripMenuItem"
        Me.UtilisateurSimpleToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UtilisateurSimpleToolStripMenuItem.Text = "Utilisateur simple"
        '
        'SuperUtilisateurToolStripMenuItem
        '
        Me.SuperUtilisateurToolStripMenuItem.Name = "SuperUtilisateurToolStripMenuItem"
        Me.SuperUtilisateurToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SuperUtilisateurToolStripMenuItem.Text = "Super utilisateur"
        '
        'PrêtsToolStripMenuItem
        '
        Me.PrêtsToolStripMenuItem.Name = "PrêtsToolStripMenuItem"
        Me.PrêtsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PrêtsToolStripMenuItem.Text = "Prêts"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherLaideToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'AfficherLaideToolStripMenuItem
        '
        Me.AfficherLaideToolStripMenuItem.Name = "AfficherLaideToolStripMenuItem"
        Me.AfficherLaideToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AfficherLaideToolStripMenuItem.Text = "Afficher l'aide"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AProposToolStripMenuItem.Text = "À propos"
        '
        'BT_localisation
        '
        Me.BT_localisation.BackColor = System.Drawing.Color.Teal
        Me.BT_localisation.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.localisation2
        Me.BT_localisation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_localisation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_localisation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_localisation.ForeColor = System.Drawing.Color.White
        Me.BT_localisation.Location = New System.Drawing.Point(444, 194)
        Me.BT_localisation.Name = "BT_localisation"
        Me.BT_localisation.Size = New System.Drawing.Size(210, 271)
        Me.BT_localisation.TabIndex = 22
        Me.BT_localisation.Text = "LOCALISATION"
        Me.BT_localisation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_localisation.UseVisualStyleBackColor = False
        '
        'BT_prets
        '
        Me.BT_prets.BackColor = System.Drawing.Color.Teal
        Me.BT_prets.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.prets
        Me.BT_prets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_prets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_prets.ForeColor = System.Drawing.Color.White
        Me.BT_prets.Location = New System.Drawing.Point(1136, 194)
        Me.BT_prets.Name = "BT_prets"
        Me.BT_prets.Size = New System.Drawing.Size(206, 271)
        Me.BT_prets.TabIndex = 11
        Me.BT_prets.Text = "PRÊTS"
        Me.BT_prets.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_prets.UseVisualStyleBackColor = False
        '
        'BT_super
        '
        Me.BT_super.BackColor = System.Drawing.Color.Teal
        Me.BT_super.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.usuper
        Me.BT_super.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_super.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_super.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_super.ForeColor = System.Drawing.Color.White
        Me.BT_super.Location = New System.Drawing.Point(919, 194)
        Me.BT_super.Name = "BT_super"
        Me.BT_super.Size = New System.Drawing.Size(199, 271)
        Me.BT_super.TabIndex = 11
        Me.BT_super.Text = "SUPER UTILISATEURS"
        Me.BT_super.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_super.UseVisualStyleBackColor = False
        '
        'BT_usimple
        '
        Me.BT_usimple.BackColor = System.Drawing.Color.Teal
        Me.BT_usimple.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.usimple
        Me.BT_usimple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_usimple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_usimple.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_usimple.ForeColor = System.Drawing.Color.White
        Me.BT_usimple.Location = New System.Drawing.Point(685, 194)
        Me.BT_usimple.Name = "BT_usimple"
        Me.BT_usimple.Size = New System.Drawing.Size(210, 271)
        Me.BT_usimple.TabIndex = 11
        Me.BT_usimple.Text = "UTILISATEURS SIMPLE"
        Me.BT_usimple.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_usimple.UseVisualStyleBackColor = False
        '
        'BT_documents
        '
        Me.BT_documents.BackColor = System.Drawing.Color.Teal
        Me.BT_documents.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.document2
        Me.BT_documents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_documents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_documents.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_documents.ForeColor = System.Drawing.Color.White
        Me.BT_documents.Location = New System.Drawing.Point(225, 194)
        Me.BT_documents.Name = "BT_documents"
        Me.BT_documents.Size = New System.Drawing.Size(190, 271)
        Me.BT_documents.TabIndex = 11
        Me.BT_documents.Text = "DOCUMENTS"
        Me.BT_documents.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_documents.UseVisualStyleBackColor = False
        '
        'BT_disciplines
        '
        Me.BT_disciplines.BackColor = System.Drawing.Color.Teal
        Me.BT_disciplines.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.disciplines2
        Me.BT_disciplines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_disciplines.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_disciplines.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_disciplines.ForeColor = System.Drawing.Color.White
        Me.BT_disciplines.Location = New System.Drawing.Point(12, 194)
        Me.BT_disciplines.Name = "BT_disciplines"
        Me.BT_disciplines.Size = New System.Drawing.Size(189, 271)
        Me.BT_disciplines.TabIndex = 11
        Me.BT_disciplines.Text = "DISCIPLINES"
        Me.BT_disciplines.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_disciplines.UseVisualStyleBackColor = False
        '
        'BT_logouasz
        '
        Me.BT_logouasz.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.UASZ
        Me.BT_logouasz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_logouasz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_logouasz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BT_logouasz.Location = New System.Drawing.Point(12, 36)
        Me.BT_logouasz.Name = "BT_logouasz"
        Me.BT_logouasz.Size = New System.Drawing.Size(96, 88)
        Me.BT_logouasz.TabIndex = 26
        Me.BT_logouasz.UseVisualStyleBackColor = True
        '
        'BT_logomi
        '
        Me.BT_logomi.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.logo_ufr_couleur
        Me.BT_logomi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_logomi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_logomi.Location = New System.Drawing.Point(1100, 36)
        Me.BT_logomi.Name = "BT_logomi"
        Me.BT_logomi.Size = New System.Drawing.Size(242, 88)
        Me.BT_logomi.TabIndex = 27
        Me.BT_logomi.UseVisualStyleBackColor = True
        '
        'LBL_description
        '
        Me.LBL_description.AutoSize = True
        Me.LBL_description.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_description.ForeColor = System.Drawing.Color.White
        Me.LBL_description.Location = New System.Drawing.Point(12, 558)
        Me.LBL_description.Name = "LBL_description"
        Me.LBL_description.Size = New System.Drawing.Size(348, 73)
        Me.LBL_description.TabIndex = 28
        Me.LBL_description.Text = "Description"
        '
        'Applications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.LBL_description)
        Me.Controls.Add(Me.BT_logomi)
        Me.Controls.Add(Me.BT_logouasz)
        Me.Controls.Add(Me.MS_applications)
        Me.Controls.Add(Me.BT_localisation)
        Me.Controls.Add(Me.LBL_heure)
        Me.Controls.Add(Me.LBL_date)
        Me.Controls.Add(Me.LBL_universite)
        Me.Controls.Add(Me.BT_prets)
        Me.Controls.Add(Me.BT_super)
        Me.Controls.Add(Me.BT_usimple)
        Me.Controls.Add(Me.BT_documents)
        Me.Controls.Add(Me.BT_disciplines)
        Me.Controls.Add(Me.LBL_gestion)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Applications"
        Me.Text = "Applications"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MS_applications.ResumeLayout(False)
        Me.MS_applications.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_gestion As Label
    Friend WithEvents BT_disciplines As Button
    Friend WithEvents BT_documents As Button
    Friend WithEvents BT_usimple As Button
    Friend WithEvents BT_super As Button
    Friend WithEvents BT_prets As Button
    Friend WithEvents LBL_universite As Label
    Friend WithEvents LBL_date As Label
    Friend WithEvents LBL_heure As Label
    Friend WithEvents TM_applications As Timer
    Friend WithEvents BT_localisation As Button
    Friend WithEvents MS_applications As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDeDonnéeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VérifierLaConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeConnecterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BT_logouasz As Button
    Friend WithEvents BT_logomi As Button
    Friend WithEvents LBL_description As Label
    Friend WithEvents CompteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeDéconnecterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherLaideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllerÀToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisciplinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalisationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilisateurSimpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuperUtilisateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrêtsToolStripMenuItem As ToolStripMenuItem
End Class
