<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chargement
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
        Me.components = New System.ComponentModel.Container()
        Me.TM_chargement = New System.Windows.Forms.Timer(Me.components)
        Me.PGB_chargement = New System.Windows.Forms.ProgressBar()
        Me.LBL_nom = New System.Windows.Forms.Label()
        Me.LBL_message = New System.Windows.Forms.Label()
        Me.LBL_version = New System.Windows.Forms.Label()
        Me.LBL_droit = New System.Windows.Forms.Label()
        Me.LBL_valeur = New System.Windows.Forms.Label()
        Me.PB_logo4 = New System.Windows.Forms.PictureBox()
        Me.PB_logo3 = New System.Windows.Forms.PictureBox()
        Me.PB_logo1 = New System.Windows.Forms.PictureBox()
        Me.PB_logo2 = New System.Windows.Forms.PictureBox()
        CType(Me.PB_logo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_logo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_logo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_logo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TM_chargement
        '
        '
        'PGB_chargement
        '
        Me.PGB_chargement.Location = New System.Drawing.Point(118, 126)
        Me.PGB_chargement.Margin = New System.Windows.Forms.Padding(4)
        Me.PGB_chargement.Name = "PGB_chargement"
        Me.PGB_chargement.Size = New System.Drawing.Size(227, 20)
        Me.PGB_chargement.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PGB_chargement.TabIndex = 0
        '
        'LBL_nom
        '
        Me.LBL_nom.AutoSize = True
        Me.LBL_nom.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nom.ForeColor = System.Drawing.Color.White
        Me.LBL_nom.Location = New System.Drawing.Point(118, 9)
        Me.LBL_nom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_nom.Name = "LBL_nom"
        Me.LBL_nom.Size = New System.Drawing.Size(227, 109)
        Me.LBL_nom.TabIndex = 2
        Me.LBL_nom.Text = "BMI"
        '
        'LBL_message
        '
        Me.LBL_message.AutoSize = True
        Me.LBL_message.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_message.ForeColor = System.Drawing.Color.White
        Me.LBL_message.Location = New System.Drawing.Point(73, 173)
        Me.LBL_message.Name = "LBL_message"
        Me.LBL_message.Size = New System.Drawing.Size(334, 22)
        Me.LBL_message.TabIndex = 3
        Me.LBL_message.Text = "Chargement de l'application en cours ..."
        '
        'LBL_version
        '
        Me.LBL_version.AutoSize = True
        Me.LBL_version.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_version.ForeColor = System.Drawing.Color.White
        Me.LBL_version.Location = New System.Drawing.Point(133, 103)
        Me.LBL_version.Name = "LBL_version"
        Me.LBL_version.Size = New System.Drawing.Size(84, 19)
        Me.LBL_version.TabIndex = 4
        Me.LBL_version.Text = "Version 1.0"
        '
        'LBL_droit
        '
        Me.LBL_droit.AutoSize = True
        Me.LBL_droit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_droit.ForeColor = System.Drawing.Color.White
        Me.LBL_droit.Location = New System.Drawing.Point(97, 349)
        Me.LBL_droit.Name = "LBL_droit"
        Me.LBL_droit.Size = New System.Drawing.Size(276, 19)
        Me.LBL_droit.TabIndex = 5
        Me.LBL_droit.Text = "Copyright 2013 - 2016 Seinaly Software "
        '
        'LBL_valeur
        '
        Me.LBL_valeur.AutoSize = True
        Me.LBL_valeur.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_valeur.ForeColor = System.Drawing.Color.White
        Me.LBL_valeur.Location = New System.Drawing.Point(163, 235)
        Me.LBL_valeur.Name = "LBL_valeur"
        Me.LBL_valeur.Size = New System.Drawing.Size(162, 73)
        Me.LBL_valeur.TabIndex = 6
        Me.LBL_valeur.Text = "O %"
        '
        'PB_logo4
        '
        Me.PB_logo4.Image = Global.pvb_bmi.My.Resources.Resources.micon_01
        Me.PB_logo4.Location = New System.Drawing.Point(353, 212)
        Me.PB_logo4.Margin = New System.Windows.Forms.Padding(4)
        Me.PB_logo4.Name = "PB_logo4"
        Me.PB_logo4.Size = New System.Drawing.Size(101, 133)
        Me.PB_logo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_logo4.TabIndex = 1
        Me.PB_logo4.TabStop = False
        '
        'PB_logo3
        '
        Me.PB_logo3.Image = Global.pvb_bmi.My.Resources.Resources.micon_01
        Me.PB_logo3.Location = New System.Drawing.Point(13, 212)
        Me.PB_logo3.Margin = New System.Windows.Forms.Padding(4)
        Me.PB_logo3.Name = "PB_logo3"
        Me.PB_logo3.Size = New System.Drawing.Size(97, 133)
        Me.PB_logo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_logo3.TabIndex = 1
        Me.PB_logo3.TabStop = False
        '
        'PB_logo1
        '
        Me.PB_logo1.Image = Global.pvb_bmi.My.Resources.Resources.micon_01
        Me.PB_logo1.Location = New System.Drawing.Point(13, 13)
        Me.PB_logo1.Margin = New System.Windows.Forms.Padding(4)
        Me.PB_logo1.Name = "PB_logo1"
        Me.PB_logo1.Size = New System.Drawing.Size(97, 133)
        Me.PB_logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_logo1.TabIndex = 1
        Me.PB_logo1.TabStop = False
        '
        'PB_logo2
        '
        Me.PB_logo2.Image = Global.pvb_bmi.My.Resources.Resources.micon_01
        Me.PB_logo2.Location = New System.Drawing.Point(353, 13)
        Me.PB_logo2.Margin = New System.Windows.Forms.Padding(4)
        Me.PB_logo2.Name = "PB_logo2"
        Me.PB_logo2.Size = New System.Drawing.Size(101, 133)
        Me.PB_logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_logo2.TabIndex = 1
        Me.PB_logo2.TabStop = False
        '
        'Chargement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(467, 377)
        Me.Controls.Add(Me.LBL_droit)
        Me.Controls.Add(Me.LBL_version)
        Me.Controls.Add(Me.LBL_message)
        Me.Controls.Add(Me.PB_logo1)
        Me.Controls.Add(Me.PB_logo3)
        Me.Controls.Add(Me.PB_logo2)
        Me.Controls.Add(Me.PB_logo4)
        Me.Controls.Add(Me.PGB_chargement)
        Me.Controls.Add(Me.LBL_nom)
        Me.Controls.Add(Me.LBL_valeur)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Chargement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chargement"
        CType(Me.PB_logo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_logo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_logo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_logo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TM_chargement As Timer
    Friend WithEvents PGB_chargement As ProgressBar
    Friend WithEvents LBL_nom As Label
    Friend WithEvents LBL_message As Label
    Friend WithEvents LBL_version As Label
    Friend WithEvents LBL_droit As Label
    Friend WithEvents LBL_valeur As Label
    Friend WithEvents PB_logo4 As PictureBox
    Friend WithEvents PB_logo3 As PictureBox
    Friend WithEvents PB_logo1 As PictureBox
    Friend WithEvents PB_logo2 As PictureBox
End Class
