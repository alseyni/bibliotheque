<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UASZ
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PB_logo = New System.Windows.Forms.PictureBox()
        Me.LBL_titre = New System.Windows.Forms.Label()
        Me.LBL_adresse = New System.Windows.Forms.Label()
        Me.LBL_infosadresse = New System.Windows.Forms.Label()
        Me.LBL_tel = New System.Windows.Forms.Label()
        Me.LBL_infostel = New System.Windows.Forms.Label()
        Me.LBL_telecopie = New System.Windows.Forms.Label()
        Me.LBL_infostelecopie = New System.Windows.Forms.Label()
        Me.LBL_web = New System.Windows.Forms.Label()
        Me.LL_infosweb = New System.Windows.Forms.LinkLabel()
        Me.LBL_fermer = New System.Windows.Forms.Label()
        CType(Me.PB_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_logo
        '
        Me.PB_logo.Image = Global.pvb_bmi.My.Resources.Resources.UASZ
        Me.PB_logo.Location = New System.Drawing.Point(159, 12)
        Me.PB_logo.Name = "PB_logo"
        Me.PB_logo.Size = New System.Drawing.Size(100, 99)
        Me.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_logo.TabIndex = 0
        Me.PB_logo.TabStop = False
        '
        'LBL_titre
        '
        Me.LBL_titre.AutoSize = True
        Me.LBL_titre.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_titre.ForeColor = System.Drawing.Color.White
        Me.LBL_titre.Location = New System.Drawing.Point(50, 114)
        Me.LBL_titre.Name = "LBL_titre"
        Me.LBL_titre.Size = New System.Drawing.Size(329, 22)
        Me.LBL_titre.TabIndex = 1
        Me.LBL_titre.Text = "Université Assane SECK de Ziguinchor"
        '
        'LBL_adresse
        '
        Me.LBL_adresse.AutoSize = True
        Me.LBL_adresse.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_adresse.ForeColor = System.Drawing.Color.White
        Me.LBL_adresse.Location = New System.Drawing.Point(12, 163)
        Me.LBL_adresse.Name = "LBL_adresse"
        Me.LBL_adresse.Size = New System.Drawing.Size(64, 19)
        Me.LBL_adresse.TabIndex = 2
        Me.LBL_adresse.Text = "Adresse"
        '
        'LBL_infosadresse
        '
        Me.LBL_infosadresse.AutoSize = True
        Me.LBL_infosadresse.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_infosadresse.ForeColor = System.Drawing.Color.White
        Me.LBL_infosadresse.Location = New System.Drawing.Point(37, 198)
        Me.LBL_infosadresse.Name = "LBL_infosadresse"
        Me.LBL_infosadresse.Size = New System.Drawing.Size(260, 19)
        Me.LBL_infosadresse.TabIndex = 2
        Me.LBL_infosadresse.Text = "Diabir - Ziguinchor - BP 523 - Ziguinchor"
        '
        'LBL_tel
        '
        Me.LBL_tel.AutoSize = True
        Me.LBL_tel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_tel.ForeColor = System.Drawing.Color.White
        Me.LBL_tel.Location = New System.Drawing.Point(12, 233)
        Me.LBL_tel.Name = "LBL_tel"
        Me.LBL_tel.Size = New System.Drawing.Size(79, 19)
        Me.LBL_tel.TabIndex = 2
        Me.LBL_tel.Text = "Téléphone"
        '
        'LBL_infostel
        '
        Me.LBL_infostel.AutoSize = True
        Me.LBL_infostel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_infostel.ForeColor = System.Drawing.Color.White
        Me.LBL_infostel.Location = New System.Drawing.Point(37, 264)
        Me.LBL_infostel.Name = "LBL_infostel"
        Me.LBL_infostel.Size = New System.Drawing.Size(189, 19)
        Me.LBL_infostel.TabIndex = 2
        Me.LBL_infostel.Text = "33 991 68 09 / 33 991 68 85"
        '
        'LBL_telecopie
        '
        Me.LBL_telecopie.AutoSize = True
        Me.LBL_telecopie.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_telecopie.ForeColor = System.Drawing.Color.White
        Me.LBL_telecopie.Location = New System.Drawing.Point(12, 297)
        Me.LBL_telecopie.Name = "LBL_telecopie"
        Me.LBL_telecopie.Size = New System.Drawing.Size(74, 19)
        Me.LBL_telecopie.TabIndex = 2
        Me.LBL_telecopie.Text = "Télécopie"
        '
        'LBL_infostelecopie
        '
        Me.LBL_infostelecopie.AutoSize = True
        Me.LBL_infostelecopie.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_infostelecopie.ForeColor = System.Drawing.Color.White
        Me.LBL_infostelecopie.Location = New System.Drawing.Point(37, 332)
        Me.LBL_infostelecopie.Name = "LBL_infostelecopie"
        Me.LBL_infostelecopie.Size = New System.Drawing.Size(93, 19)
        Me.LBL_infostelecopie.TabIndex = 2
        Me.LBL_infostelecopie.Text = "33 991 68 09"
        '
        'LBL_web
        '
        Me.LBL_web.AutoSize = True
        Me.LBL_web.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_web.ForeColor = System.Drawing.Color.White
        Me.LBL_web.Location = New System.Drawing.Point(12, 361)
        Me.LBL_web.Name = "LBL_web"
        Me.LBL_web.Size = New System.Drawing.Size(65, 19)
        Me.LBL_web.TabIndex = 2
        Me.LBL_web.Text = "Site web"
        '
        'LL_infosweb
        '
        Me.LL_infosweb.AutoSize = True
        Me.LL_infosweb.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LL_infosweb.LinkColor = System.Drawing.Color.White
        Me.LL_infosweb.Location = New System.Drawing.Point(38, 396)
        Me.LL_infosweb.Name = "LL_infosweb"
        Me.LL_infosweb.Size = New System.Drawing.Size(128, 15)
        Me.LL_infosweb.TabIndex = 3
        Me.LL_infosweb.TabStop = True
        Me.LL_infosweb.Text = "http://www.univ-zig.sn"
        '
        'LBL_fermer
        '
        Me.LBL_fermer.AutoSize = True
        Me.LBL_fermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBL_fermer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_fermer.ForeColor = System.Drawing.Color.White
        Me.LBL_fermer.Location = New System.Drawing.Point(321, 12)
        Me.LBL_fermer.Name = "LBL_fermer"
        Me.LBL_fermer.Size = New System.Drawing.Size(58, 19)
        Me.LBL_fermer.TabIndex = 4
        Me.LBL_fermer.Text = "Fermer"
        '
        'UASZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(429, 430)
        Me.Controls.Add(Me.LBL_fermer)
        Me.Controls.Add(Me.LL_infosweb)
        Me.Controls.Add(Me.LBL_web)
        Me.Controls.Add(Me.LBL_infostelecopie)
        Me.Controls.Add(Me.LBL_telecopie)
        Me.Controls.Add(Me.LBL_infostel)
        Me.Controls.Add(Me.LBL_tel)
        Me.Controls.Add(Me.LBL_infosadresse)
        Me.Controls.Add(Me.LBL_adresse)
        Me.Controls.Add(Me.LBL_titre)
        Me.Controls.Add(Me.PB_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UASZ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UASZ"
        CType(Me.PB_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB_logo As PictureBox
    Friend WithEvents LBL_titre As Label
    Friend WithEvents LBL_adresse As Label
    Friend WithEvents LBL_infosadresse As Label
    Friend WithEvents LBL_tel As Label
    Friend WithEvents LBL_infostel As Label
    Friend WithEvents LBL_telecopie As Label
    Friend WithEvents LBL_infostelecopie As Label
    Friend WithEvents LBL_web As Label
    Friend WithEvents LL_infosweb As LinkLabel
    Friend WithEvents LBL_fermer As Label
End Class
