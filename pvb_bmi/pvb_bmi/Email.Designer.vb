<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Email
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
        Me.GB_envoyer = New System.Windows.Forms.GroupBox()
        Me.BT_effacer = New System.Windows.Forms.Button()
        Me.BT_envoyer = New System.Windows.Forms.Button()
        Me.RTB_message = New System.Windows.Forms.RichTextBox()
        Me.TXT_sujet = New System.Windows.Forms.TextBox()
        Me.TXT_destinataire = New System.Windows.Forms.TextBox()
        Me.LBL_message = New System.Windows.Forms.Label()
        Me.LBL_sujet = New System.Windows.Forms.Label()
        Me.LBL_destinataire = New System.Windows.Forms.Label()
        Me.GB_compte = New System.Windows.Forms.GroupBox()
        Me.LBL_passe = New System.Windows.Forms.Label()
        Me.LBL_email = New System.Windows.Forms.Label()
        Me.TXT_email = New System.Windows.Forms.TextBox()
        Me.TXT_passe = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PB_googlemail = New System.Windows.Forms.PictureBox()
        Me.LBL_fermer = New System.Windows.Forms.Label()
        Me.GB_envoyer.SuspendLayout()
        Me.GB_compte.SuspendLayout()
        CType(Me.PB_googlemail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_envoyer
        '
        Me.GB_envoyer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GB_envoyer.Controls.Add(Me.BT_effacer)
        Me.GB_envoyer.Controls.Add(Me.BT_envoyer)
        Me.GB_envoyer.Controls.Add(Me.RTB_message)
        Me.GB_envoyer.Controls.Add(Me.TXT_sujet)
        Me.GB_envoyer.Controls.Add(Me.TXT_destinataire)
        Me.GB_envoyer.Controls.Add(Me.LBL_message)
        Me.GB_envoyer.Controls.Add(Me.LBL_sujet)
        Me.GB_envoyer.Controls.Add(Me.LBL_destinataire)
        Me.GB_envoyer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_envoyer.ForeColor = System.Drawing.Color.White
        Me.GB_envoyer.Location = New System.Drawing.Point(12, 136)
        Me.GB_envoyer.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_envoyer.Name = "GB_envoyer"
        Me.GB_envoyer.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_envoyer.Size = New System.Drawing.Size(407, 315)
        Me.GB_envoyer.TabIndex = 0
        Me.GB_envoyer.TabStop = False
        Me.GB_envoyer.Text = "Envoyer"
        '
        'BT_effacer
        '
        Me.BT_effacer.BackColor = System.Drawing.Color.Teal
        Me.BT_effacer.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.balai
        Me.BT_effacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_effacer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_effacer.ForeColor = System.Drawing.Color.White
        Me.BT_effacer.Location = New System.Drawing.Point(291, 264)
        Me.BT_effacer.Name = "BT_effacer"
        Me.BT_effacer.Size = New System.Drawing.Size(85, 39)
        Me.BT_effacer.TabIndex = 4
        Me.BT_effacer.Text = "Effacer"
        Me.BT_effacer.UseVisualStyleBackColor = False
        '
        'BT_envoyer
        '
        Me.BT_envoyer.BackColor = System.Drawing.Color.Teal
        Me.BT_envoyer.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.hi_512_10
        Me.BT_envoyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_envoyer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_envoyer.ForeColor = System.Drawing.Color.White
        Me.BT_envoyer.Location = New System.Drawing.Point(118, 264)
        Me.BT_envoyer.Name = "BT_envoyer"
        Me.BT_envoyer.Size = New System.Drawing.Size(89, 39)
        Me.BT_envoyer.TabIndex = 3
        Me.BT_envoyer.Text = "Envoyer"
        Me.BT_envoyer.UseVisualStyleBackColor = False
        '
        'RTB_message
        '
        Me.RTB_message.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_message.Location = New System.Drawing.Point(118, 85)
        Me.RTB_message.Name = "RTB_message"
        Me.RTB_message.Size = New System.Drawing.Size(259, 173)
        Me.RTB_message.TabIndex = 2
        Me.RTB_message.Text = ""
        '
        'TXT_sujet
        '
        Me.TXT_sujet.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_sujet.Location = New System.Drawing.Point(118, 57)
        Me.TXT_sujet.Name = "TXT_sujet"
        Me.TXT_sujet.Size = New System.Drawing.Size(258, 22)
        Me.TXT_sujet.TabIndex = 1
        '
        'TXT_destinataire
        '
        Me.TXT_destinataire.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_destinataire.Location = New System.Drawing.Point(118, 29)
        Me.TXT_destinataire.Name = "TXT_destinataire"
        Me.TXT_destinataire.Size = New System.Drawing.Size(258, 22)
        Me.TXT_destinataire.TabIndex = 1
        '
        'LBL_message
        '
        Me.LBL_message.AutoSize = True
        Me.LBL_message.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_message.Location = New System.Drawing.Point(6, 85)
        Me.LBL_message.Name = "LBL_message"
        Me.LBL_message.Size = New System.Drawing.Size(71, 19)
        Me.LBL_message.TabIndex = 0
        Me.LBL_message.Text = "Message"
        '
        'LBL_sujet
        '
        Me.LBL_sujet.AutoSize = True
        Me.LBL_sujet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_sujet.Location = New System.Drawing.Point(6, 60)
        Me.LBL_sujet.Name = "LBL_sujet"
        Me.LBL_sujet.Size = New System.Drawing.Size(43, 19)
        Me.LBL_sujet.TabIndex = 0
        Me.LBL_sujet.Text = "Sujet"
        '
        'LBL_destinataire
        '
        Me.LBL_destinataire.AutoSize = True
        Me.LBL_destinataire.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_destinataire.Location = New System.Drawing.Point(6, 36)
        Me.LBL_destinataire.Name = "LBL_destinataire"
        Me.LBL_destinataire.Size = New System.Drawing.Size(92, 19)
        Me.LBL_destinataire.TabIndex = 0
        Me.LBL_destinataire.Text = "Destinataire"
        '
        'GB_compte
        '
        Me.GB_compte.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GB_compte.Controls.Add(Me.LBL_passe)
        Me.GB_compte.Controls.Add(Me.LBL_email)
        Me.GB_compte.Controls.Add(Me.TXT_email)
        Me.GB_compte.Controls.Add(Me.TXT_passe)
        Me.GB_compte.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_compte.ForeColor = System.Drawing.Color.White
        Me.GB_compte.Location = New System.Drawing.Point(12, 30)
        Me.GB_compte.Name = "GB_compte"
        Me.GB_compte.Size = New System.Drawing.Size(407, 107)
        Me.GB_compte.TabIndex = 3
        Me.GB_compte.TabStop = False
        Me.GB_compte.Text = "Compte google"
        '
        'LBL_passe
        '
        Me.LBL_passe.AutoSize = True
        Me.LBL_passe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_passe.Location = New System.Drawing.Point(6, 63)
        Me.LBL_passe.Name = "LBL_passe"
        Me.LBL_passe.Size = New System.Drawing.Size(100, 19)
        Me.LBL_passe.TabIndex = 0
        Me.LBL_passe.Text = "Mot de passe"
        '
        'LBL_email
        '
        Me.LBL_email.AutoSize = True
        Me.LBL_email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_email.Location = New System.Drawing.Point(6, 32)
        Me.LBL_email.Name = "LBL_email"
        Me.LBL_email.Size = New System.Drawing.Size(47, 19)
        Me.LBL_email.TabIndex = 0
        Me.LBL_email.Text = "Email"
        '
        'TXT_email
        '
        Me.TXT_email.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_email.Location = New System.Drawing.Point(118, 32)
        Me.TXT_email.Name = "TXT_email"
        Me.TXT_email.Size = New System.Drawing.Size(258, 22)
        Me.TXT_email.TabIndex = 1
        '
        'TXT_passe
        '
        Me.TXT_passe.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_passe.Location = New System.Drawing.Point(118, 60)
        Me.TXT_passe.Name = "TXT_passe"
        Me.TXT_passe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_passe.Size = New System.Drawing.Size(258, 22)
        Me.TXT_passe.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 20
        '
        'PB_googlemail
        '
        Me.PB_googlemail.BackColor = System.Drawing.Color.White
        Me.PB_googlemail.Image = Global.pvb_bmi.My.Resources.Resources.googlemail3
        Me.PB_googlemail.Location = New System.Drawing.Point(425, 30)
        Me.PB_googlemail.Name = "PB_googlemail"
        Me.PB_googlemail.Size = New System.Drawing.Size(394, 421)
        Me.PB_googlemail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_googlemail.TabIndex = 4
        Me.PB_googlemail.TabStop = False
        '
        'LBL_fermer
        '
        Me.LBL_fermer.AutoSize = True
        Me.LBL_fermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBL_fermer.ForeColor = System.Drawing.Color.White
        Me.LBL_fermer.Location = New System.Drawing.Point(764, 9)
        Me.LBL_fermer.Name = "LBL_fermer"
        Me.LBL_fermer.Size = New System.Drawing.Size(58, 19)
        Me.LBL_fermer.TabIndex = 5
        Me.LBL_fermer.Text = "Fermer"
        '
        'Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(832, 467)
        Me.Controls.Add(Me.LBL_fermer)
        Me.Controls.Add(Me.PB_googlemail)
        Me.Controls.Add(Me.GB_compte)
        Me.Controls.Add(Me.GB_envoyer)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Email"
        Me.Opacity = 0.9R
        Me.Text = "Email"
        Me.GB_envoyer.ResumeLayout(False)
        Me.GB_envoyer.PerformLayout()
        Me.GB_compte.ResumeLayout(False)
        Me.GB_compte.PerformLayout()
        CType(Me.PB_googlemail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_envoyer As GroupBox
    Friend WithEvents RTB_message As RichTextBox
    Friend WithEvents TXT_sujet As TextBox
    Friend WithEvents TXT_destinataire As TextBox
    Friend WithEvents LBL_message As Label
    Friend WithEvents LBL_sujet As Label
    Friend WithEvents LBL_destinataire As Label
    Friend WithEvents GB_compte As GroupBox
    Friend WithEvents LBL_passe As Label
    Friend WithEvents LBL_email As Label
    Friend WithEvents TXT_email As TextBox
    Friend WithEvents TXT_passe As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BT_effacer As Button
    Friend WithEvents BT_envoyer As Button
    Friend WithEvents PB_googlemail As PictureBox
    Friend WithEvents LBL_fermer As Label
End Class
