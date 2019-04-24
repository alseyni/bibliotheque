<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMI
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
        Me.LBL_tel = New System.Windows.Forms.Label()
        Me.LBL_web = New System.Windows.Forms.Label()
        Me.PB_logo = New System.Windows.Forms.PictureBox()
        Me.LBL_titre = New System.Windows.Forms.Label()
        Me.LBL_fermer = New System.Windows.Forms.Label()
        CType(Me.PB_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_tel
        '
        Me.LBL_tel.AutoSize = True
        Me.LBL_tel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_tel.ForeColor = System.Drawing.Color.White
        Me.LBL_tel.Location = New System.Drawing.Point(12, 241)
        Me.LBL_tel.Name = "LBL_tel"
        Me.LBL_tel.Size = New System.Drawing.Size(79, 19)
        Me.LBL_tel.TabIndex = 0
        Me.LBL_tel.Text = "Téléphone"
        '
        'LBL_web
        '
        Me.LBL_web.AutoSize = True
        Me.LBL_web.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_web.ForeColor = System.Drawing.Color.White
        Me.LBL_web.Location = New System.Drawing.Point(12, 298)
        Me.LBL_web.Name = "LBL_web"
        Me.LBL_web.Size = New System.Drawing.Size(65, 19)
        Me.LBL_web.TabIndex = 0
        Me.LBL_web.Text = "Site web"
        '
        'PB_logo
        '
        Me.PB_logo.Image = Global.pvb_bmi.My.Resources.Resources.logo_ufr_couleur
        Me.PB_logo.Location = New System.Drawing.Point(16, 36)
        Me.PB_logo.Name = "PB_logo"
        Me.PB_logo.Size = New System.Drawing.Size(398, 126)
        Me.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_logo.TabIndex = 1
        Me.PB_logo.TabStop = False
        '
        'LBL_titre
        '
        Me.LBL_titre.AutoSize = True
        Me.LBL_titre.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_titre.ForeColor = System.Drawing.Color.White
        Me.LBL_titre.Location = New System.Drawing.Point(28, 174)
        Me.LBL_titre.Name = "LBL_titre"
        Me.LBL_titre.Size = New System.Drawing.Size(370, 22)
        Me.LBL_titre.TabIndex = 2
        Me.LBL_titre.Text = "Département Mathématique et Informatique"
        '
        'LBL_fermer
        '
        Me.LBL_fermer.AutoSize = True
        Me.LBL_fermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBL_fermer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_fermer.ForeColor = System.Drawing.Color.White
        Me.LBL_fermer.Location = New System.Drawing.Point(356, 9)
        Me.LBL_fermer.Name = "LBL_fermer"
        Me.LBL_fermer.Size = New System.Drawing.Size(58, 19)
        Me.LBL_fermer.TabIndex = 3
        Me.LBL_fermer.Text = "Fermer"
        '
        'DMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(426, 346)
        Me.Controls.Add(Me.LBL_fermer)
        Me.Controls.Add(Me.LBL_titre)
        Me.Controls.Add(Me.PB_logo)
        Me.Controls.Add(Me.LBL_web)
        Me.Controls.Add(Me.LBL_tel)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DMI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DMI"
        CType(Me.PB_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_tel As Label
    Friend WithEvents LBL_web As Label
    Friend WithEvents PB_logo As PictureBox
    Friend WithEvents LBL_titre As Label
    Friend WithEvents LBL_fermer As Label
End Class
