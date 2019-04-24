<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Serveur
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
        Me.LB_serveur = New System.Windows.Forms.Label()
        Me.GB_serveur = New System.Windows.Forms.GroupBox()
        Me.TXT_base_donnee = New System.Windows.Forms.TextBox()
        Me.TXT_mot_passe = New System.Windows.Forms.TextBox()
        Me.TXT_nom_utilisateur = New System.Windows.Forms.TextBox()
        Me.TXT_server = New System.Windows.Forms.TextBox()
        Me.LBL_base_donnee = New System.Windows.Forms.Label()
        Me.LBL_mot_passe = New System.Windows.Forms.Label()
        Me.LBL_nom_utilisateur = New System.Windows.Forms.Label()
        Me.BT_verifier = New System.Windows.Forms.Button()
        Me.BT_valider = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_fermer = New System.Windows.Forms.Label()
        Me.PB_serveur = New System.Windows.Forms.PictureBox()
        Me.GB_serveur.SuspendLayout()
        CType(Me.PB_serveur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LB_serveur
        '
        Me.LB_serveur.AutoSize = True
        Me.LB_serveur.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_serveur.Location = New System.Drawing.Point(9, 58)
        Me.LB_serveur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_serveur.Name = "LB_serveur"
        Me.LB_serveur.Size = New System.Drawing.Size(62, 19)
        Me.LB_serveur.TabIndex = 0
        Me.LB_serveur.Text = "Serveur"
        '
        'GB_serveur
        '
        Me.GB_serveur.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GB_serveur.Controls.Add(Me.PB_serveur)
        Me.GB_serveur.Controls.Add(Me.TXT_base_donnee)
        Me.GB_serveur.Controls.Add(Me.TXT_mot_passe)
        Me.GB_serveur.Controls.Add(Me.TXT_nom_utilisateur)
        Me.GB_serveur.Controls.Add(Me.TXT_server)
        Me.GB_serveur.Controls.Add(Me.LBL_base_donnee)
        Me.GB_serveur.Controls.Add(Me.LBL_mot_passe)
        Me.GB_serveur.Controls.Add(Me.LBL_nom_utilisateur)
        Me.GB_serveur.Controls.Add(Me.LB_serveur)
        Me.GB_serveur.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_serveur.ForeColor = System.Drawing.Color.White
        Me.GB_serveur.Location = New System.Drawing.Point(18, 38)
        Me.GB_serveur.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_serveur.Name = "GB_serveur"
        Me.GB_serveur.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_serveur.Size = New System.Drawing.Size(632, 240)
        Me.GB_serveur.TabIndex = 1
        Me.GB_serveur.TabStop = False
        Me.GB_serveur.Text = "Connexion à la base de donnée"
        '
        'TXT_base_donnee
        '
        Me.TXT_base_donnee.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_base_donnee.Location = New System.Drawing.Point(154, 178)
        Me.TXT_base_donnee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_base_donnee.Name = "TXT_base_donnee"
        Me.TXT_base_donnee.Size = New System.Drawing.Size(307, 22)
        Me.TXT_base_donnee.TabIndex = 1
        '
        'TXT_mot_passe
        '
        Me.TXT_mot_passe.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_mot_passe.Location = New System.Drawing.Point(154, 137)
        Me.TXT_mot_passe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_mot_passe.Name = "TXT_mot_passe"
        Me.TXT_mot_passe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_mot_passe.Size = New System.Drawing.Size(307, 22)
        Me.TXT_mot_passe.TabIndex = 1
        '
        'TXT_nom_utilisateur
        '
        Me.TXT_nom_utilisateur.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_nom_utilisateur.Location = New System.Drawing.Point(154, 96)
        Me.TXT_nom_utilisateur.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_nom_utilisateur.Name = "TXT_nom_utilisateur"
        Me.TXT_nom_utilisateur.Size = New System.Drawing.Size(307, 22)
        Me.TXT_nom_utilisateur.TabIndex = 1
        '
        'TXT_server
        '
        Me.TXT_server.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_server.Location = New System.Drawing.Point(154, 55)
        Me.TXT_server.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_server.Name = "TXT_server"
        Me.TXT_server.Size = New System.Drawing.Size(307, 22)
        Me.TXT_server.TabIndex = 1
        '
        'LBL_base_donnee
        '
        Me.LBL_base_donnee.AutoSize = True
        Me.LBL_base_donnee.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_base_donnee.Location = New System.Drawing.Point(9, 181)
        Me.LBL_base_donnee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_base_donnee.Name = "LBL_base_donnee"
        Me.LBL_base_donnee.Size = New System.Drawing.Size(115, 19)
        Me.LBL_base_donnee.TabIndex = 0
        Me.LBL_base_donnee.Text = "Base de donnée"
        '
        'LBL_mot_passe
        '
        Me.LBL_mot_passe.AutoSize = True
        Me.LBL_mot_passe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_mot_passe.Location = New System.Drawing.Point(9, 140)
        Me.LBL_mot_passe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_mot_passe.Name = "LBL_mot_passe"
        Me.LBL_mot_passe.Size = New System.Drawing.Size(100, 19)
        Me.LBL_mot_passe.TabIndex = 0
        Me.LBL_mot_passe.Text = "Mot de passe"
        '
        'LBL_nom_utilisateur
        '
        Me.LBL_nom_utilisateur.AutoSize = True
        Me.LBL_nom_utilisateur.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nom_utilisateur.Location = New System.Drawing.Point(9, 99)
        Me.LBL_nom_utilisateur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_nom_utilisateur.Name = "LBL_nom_utilisateur"
        Me.LBL_nom_utilisateur.Size = New System.Drawing.Size(124, 19)
        Me.LBL_nom_utilisateur.TabIndex = 0
        Me.LBL_nom_utilisateur.Text = "Nom d'utilisateur"
        '
        'BT_verifier
        '
        Me.BT_verifier.BackColor = System.Drawing.Color.Teal
        Me.BT_verifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_verifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_verifier.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_verifier.ForeColor = System.Drawing.Color.White
        Me.BT_verifier.Location = New System.Drawing.Point(18, 286)
        Me.BT_verifier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_verifier.Name = "BT_verifier"
        Me.BT_verifier.Size = New System.Drawing.Size(316, 28)
        Me.BT_verifier.TabIndex = 4
        Me.BT_verifier.Text = "Vérifier la connexion"
        Me.BT_verifier.UseVisualStyleBackColor = False
        '
        'BT_valider
        '
        Me.BT_valider.BackColor = System.Drawing.Color.Teal
        Me.BT_valider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_valider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_valider.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_valider.ForeColor = System.Drawing.Color.White
        Me.BT_valider.Location = New System.Drawing.Point(342, 286)
        Me.BT_valider.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BT_valider.Name = "BT_valider"
        Me.BT_valider.Size = New System.Drawing.Size(308, 28)
        Me.BT_valider.TabIndex = 2
        Me.BT_valider.Text = "Valider les informations"
        Me.BT_valider.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 20
        '
        'LBL_fermer
        '
        Me.LBL_fermer.AutoSize = True
        Me.LBL_fermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBL_fermer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_fermer.ForeColor = System.Drawing.Color.White
        Me.LBL_fermer.Location = New System.Drawing.Point(592, 9)
        Me.LBL_fermer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_fermer.Name = "LBL_fermer"
        Me.LBL_fermer.Size = New System.Drawing.Size(58, 19)
        Me.LBL_fermer.TabIndex = 5
        Me.LBL_fermer.Text = "Fermer"
        '
        'PB_serveur
        '
        Me.PB_serveur.Image = Global.pvb_bmi.My.Resources.Resources.serveur_web___infoclip
        Me.PB_serveur.Location = New System.Drawing.Point(468, 55)
        Me.PB_serveur.Name = "PB_serveur"
        Me.PB_serveur.Size = New System.Drawing.Size(145, 145)
        Me.PB_serveur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_serveur.TabIndex = 2
        Me.PB_serveur.TabStop = False
        '
        'Serveur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(673, 332)
        Me.Controls.Add(Me.LBL_fermer)
        Me.Controls.Add(Me.BT_valider)
        Me.Controls.Add(Me.BT_verifier)
        Me.Controls.Add(Me.GB_serveur)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Serveur"
        Me.Opacity = 0.9R
        Me.Text = "Serveur"
        Me.GB_serveur.ResumeLayout(False)
        Me.GB_serveur.PerformLayout()
        CType(Me.PB_serveur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_serveur As Label
    Friend WithEvents GB_serveur As GroupBox
    Friend WithEvents BT_valider As Button
    Friend WithEvents TXT_base_donnee As TextBox
    Friend WithEvents TXT_mot_passe As TextBox
    Friend WithEvents TXT_nom_utilisateur As TextBox
    Friend WithEvents TXT_server As TextBox
    Friend WithEvents LBL_base_donnee As Label
    Friend WithEvents LBL_mot_passe As Label
    Friend WithEvents LBL_nom_utilisateur As Label
    Friend WithEvents BT_verifier As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LBL_fermer As Label
    Friend WithEvents PB_serveur As PictureBox
End Class
