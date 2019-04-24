<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Localisation
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
        Me.LBL_date = New System.Windows.Forms.Label()
        Me.LBL_heure = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TM_Localisation = New System.Windows.Forms.Timer(Me.components)
        Me.TC_localisation = New System.Windows.Forms.TabControl()
        Me.TP_rayons = New System.Windows.Forms.TabPage()
        Me.GB_rayon_rayon_localisation = New System.Windows.Forms.GroupBox()
        Me.LBL_num_ray_rayons_loca = New System.Windows.Forms.Label()
        Me.BT_supprimer_rayons_loca = New System.Windows.Forms.Button()
        Me.TXT_num_ray_rayons_loca = New System.Windows.Forms.TextBox()
        Me.BT_modifier_rayons_loca = New System.Windows.Forms.Button()
        Me.LBL_intitule_rayons_loca = New System.Windows.Forms.Label()
        Me.BT_ajouter_rayons_loca = New System.Windows.Forms.Button()
        Me.TXT_intitule_rayons_loca = New System.Windows.Forms.TextBox()
        Me.DGV_rayons_rayons_loca = New System.Windows.Forms.DataGridView()
        Me.TP_groupes = New System.Windows.Forms.TabPage()
        Me.GB_groupe_localisation = New System.Windows.Forms.GroupBox()
        Me.LBL_code_groupe_groupes_loca = New System.Windows.Forms.Label()
        Me.BT_supprimer_groupes_loca = New System.Windows.Forms.Button()
        Me.TXT_code_groupe_groupes_loca = New System.Windows.Forms.TextBox()
        Me.BT_modifier_groupes_loca = New System.Windows.Forms.Button()
        Me.TXT_libelle_groupes_loca = New System.Windows.Forms.TextBox()
        Me.BT_ajouter_groupes_loca = New System.Windows.Forms.Button()
        Me.LBL_libelle_groupes_loca = New System.Windows.Forms.Label()
        Me.DGV_groupes_groupes_loca = New System.Windows.Forms.DataGridView()
        Me.LBL_localisation = New System.Windows.Forms.Label()
        Me.MS_form1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeDéconnecterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDeDonnéeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VérifierLaConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeConnecterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllerÀToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccueilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherLaideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BT_logouasz = New System.Windows.Forms.Button()
        Me.BT_logomi = New System.Windows.Forms.Button()
        Me.DisciplinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilisateurSimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuperUtilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrêtsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TC_localisation.SuspendLayout()
        Me.TP_rayons.SuspendLayout()
        Me.GB_rayon_rayon_localisation.SuspendLayout()
        CType(Me.DGV_rayons_rayons_loca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_groupes.SuspendLayout()
        Me.GB_groupe_localisation.SuspendLayout()
        CType(Me.DGV_groupes_groupes_loca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MS_form1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_date
        '
        Me.LBL_date.AutoSize = True
        Me.LBL_date.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_date.ForeColor = System.Drawing.Color.White
        Me.LBL_date.Location = New System.Drawing.Point(249, 80)
        Me.LBL_date.Name = "LBL_date"
        Me.LBL_date.Size = New System.Drawing.Size(88, 40)
        Me.LBL_date.TabIndex = 18
        Me.LBL_date.Text = "Date"
        '
        'LBL_heure
        '
        Me.LBL_heure.AutoSize = True
        Me.LBL_heure.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_heure.ForeColor = System.Drawing.Color.White
        Me.LBL_heure.Location = New System.Drawing.Point(808, 80)
        Me.LBL_heure.Name = "LBL_heure"
        Me.LBL_heure.Size = New System.Drawing.Size(110, 40)
        Me.LBL_heure.TabIndex = 17
        Me.LBL_heure.Text = "Heure"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(209, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(769, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Université Assane SECK de Ziguinchor - Département Mathématique et Informatique"
        '
        'TM_Localisation
        '
        Me.TM_Localisation.Interval = 1000
        '
        'TC_localisation
        '
        Me.TC_localisation.Controls.Add(Me.TP_rayons)
        Me.TC_localisation.Controls.Add(Me.TP_groupes)
        Me.TC_localisation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TC_localisation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC_localisation.Location = New System.Drawing.Point(7, 136)
        Me.TC_localisation.Name = "TC_localisation"
        Me.TC_localisation.SelectedIndex = 0
        Me.TC_localisation.Size = New System.Drawing.Size(1335, 567)
        Me.TC_localisation.TabIndex = 19
        '
        'TP_rayons
        '
        Me.TP_rayons.BackColor = System.Drawing.Color.Teal
        Me.TP_rayons.Controls.Add(Me.GB_rayon_rayon_localisation)
        Me.TP_rayons.Controls.Add(Me.DGV_rayons_rayons_loca)
        Me.TP_rayons.Location = New System.Drawing.Point(4, 28)
        Me.TP_rayons.Name = "TP_rayons"
        Me.TP_rayons.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_rayons.Size = New System.Drawing.Size(1327, 535)
        Me.TP_rayons.TabIndex = 0
        Me.TP_rayons.Text = "Rayons"
        '
        'GB_rayon_rayon_localisation
        '
        Me.GB_rayon_rayon_localisation.BackColor = System.Drawing.Color.Teal
        Me.GB_rayon_rayon_localisation.Controls.Add(Me.LBL_num_ray_rayons_loca)
        Me.GB_rayon_rayon_localisation.Controls.Add(Me.BT_supprimer_rayons_loca)
        Me.GB_rayon_rayon_localisation.Controls.Add(Me.TXT_num_ray_rayons_loca)
        Me.GB_rayon_rayon_localisation.Controls.Add(Me.BT_modifier_rayons_loca)
        Me.GB_rayon_rayon_localisation.Controls.Add(Me.LBL_intitule_rayons_loca)
        Me.GB_rayon_rayon_localisation.Controls.Add(Me.BT_ajouter_rayons_loca)
        Me.GB_rayon_rayon_localisation.Controls.Add(Me.TXT_intitule_rayons_loca)
        Me.GB_rayon_rayon_localisation.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_rayon_rayon_localisation.ForeColor = System.Drawing.Color.White
        Me.GB_rayon_rayon_localisation.Location = New System.Drawing.Point(347, 22)
        Me.GB_rayon_rayon_localisation.Name = "GB_rayon_rayon_localisation"
        Me.GB_rayon_rayon_localisation.Size = New System.Drawing.Size(426, 135)
        Me.GB_rayon_rayon_localisation.TabIndex = 4
        Me.GB_rayon_rayon_localisation.TabStop = False
        Me.GB_rayon_rayon_localisation.Text = "Ajouter rayon"
        '
        'LBL_num_ray_rayons_loca
        '
        Me.LBL_num_ray_rayons_loca.AutoSize = True
        Me.LBL_num_ray_rayons_loca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_num_ray_rayons_loca.Location = New System.Drawing.Point(7, 39)
        Me.LBL_num_ray_rayons_loca.Name = "LBL_num_ray_rayons_loca"
        Me.LBL_num_ray_rayons_loca.Size = New System.Drawing.Size(105, 19)
        Me.LBL_num_ray_rayons_loca.TabIndex = 0
        Me.LBL_num_ray_rayons_loca.Text = "Numéro rayon"
        '
        'BT_supprimer_rayons_loca
        '
        Me.BT_supprimer_rayons_loca.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_supprimer_rayons_loca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_supprimer_rayons_loca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_supprimer_rayons_loca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_supprimer_rayons_loca.ForeColor = System.Drawing.Color.White
        Me.BT_supprimer_rayons_loca.Location = New System.Drawing.Point(322, 92)
        Me.BT_supprimer_rayons_loca.Name = "BT_supprimer_rayons_loca"
        Me.BT_supprimer_rayons_loca.Size = New System.Drawing.Size(88, 27)
        Me.BT_supprimer_rayons_loca.TabIndex = 3
        Me.BT_supprimer_rayons_loca.Text = "Supprimer"
        Me.BT_supprimer_rayons_loca.UseVisualStyleBackColor = False
        '
        'TXT_num_ray_rayons_loca
        '
        Me.TXT_num_ray_rayons_loca.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_num_ray_rayons_loca.Location = New System.Drawing.Point(144, 36)
        Me.TXT_num_ray_rayons_loca.Name = "TXT_num_ray_rayons_loca"
        Me.TXT_num_ray_rayons_loca.Size = New System.Drawing.Size(101, 22)
        Me.TXT_num_ray_rayons_loca.TabIndex = 1
        '
        'BT_modifier_rayons_loca
        '
        Me.BT_modifier_rayons_loca.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_modifier_rayons_loca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_modifier_rayons_loca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_modifier_rayons_loca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_modifier_rayons_loca.ForeColor = System.Drawing.Color.White
        Me.BT_modifier_rayons_loca.Location = New System.Drawing.Point(225, 92)
        Me.BT_modifier_rayons_loca.Name = "BT_modifier_rayons_loca"
        Me.BT_modifier_rayons_loca.Size = New System.Drawing.Size(86, 27)
        Me.BT_modifier_rayons_loca.TabIndex = 3
        Me.BT_modifier_rayons_loca.Text = "Modifier"
        Me.BT_modifier_rayons_loca.UseVisualStyleBackColor = False
        '
        'LBL_intitule_rayons_loca
        '
        Me.LBL_intitule_rayons_loca.AutoSize = True
        Me.LBL_intitule_rayons_loca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_intitule_rayons_loca.Location = New System.Drawing.Point(7, 67)
        Me.LBL_intitule_rayons_loca.Name = "LBL_intitule_rayons_loca"
        Me.LBL_intitule_rayons_loca.Size = New System.Drawing.Size(57, 19)
        Me.LBL_intitule_rayons_loca.TabIndex = 0
        Me.LBL_intitule_rayons_loca.Text = "Intitulé"
        '
        'BT_ajouter_rayons_loca
        '
        Me.BT_ajouter_rayons_loca.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_ajouter_rayons_loca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_ajouter_rayons_loca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_ajouter_rayons_loca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ajouter_rayons_loca.ForeColor = System.Drawing.Color.White
        Me.BT_ajouter_rayons_loca.Location = New System.Drawing.Point(144, 92)
        Me.BT_ajouter_rayons_loca.Name = "BT_ajouter_rayons_loca"
        Me.BT_ajouter_rayons_loca.Size = New System.Drawing.Size(75, 27)
        Me.BT_ajouter_rayons_loca.TabIndex = 3
        Me.BT_ajouter_rayons_loca.Text = "Ajouter"
        Me.BT_ajouter_rayons_loca.UseVisualStyleBackColor = False
        '
        'TXT_intitule_rayons_loca
        '
        Me.TXT_intitule_rayons_loca.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_intitule_rayons_loca.Location = New System.Drawing.Point(144, 64)
        Me.TXT_intitule_rayons_loca.Name = "TXT_intitule_rayons_loca"
        Me.TXT_intitule_rayons_loca.Size = New System.Drawing.Size(266, 22)
        Me.TXT_intitule_rayons_loca.TabIndex = 1
        '
        'DGV_rayons_rayons_loca
        '
        Me.DGV_rayons_rayons_loca.BackgroundColor = System.Drawing.Color.White
        Me.DGV_rayons_rayons_loca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_rayons_rayons_loca.Location = New System.Drawing.Point(347, 163)
        Me.DGV_rayons_rayons_loca.Name = "DGV_rayons_rayons_loca"
        Me.DGV_rayons_rayons_loca.Size = New System.Drawing.Size(426, 287)
        Me.DGV_rayons_rayons_loca.TabIndex = 2
        '
        'TP_groupes
        '
        Me.TP_groupes.BackColor = System.Drawing.Color.Teal
        Me.TP_groupes.Controls.Add(Me.GB_groupe_localisation)
        Me.TP_groupes.Controls.Add(Me.DGV_groupes_groupes_loca)
        Me.TP_groupes.Location = New System.Drawing.Point(4, 28)
        Me.TP_groupes.Name = "TP_groupes"
        Me.TP_groupes.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_groupes.Size = New System.Drawing.Size(1327, 535)
        Me.TP_groupes.TabIndex = 1
        Me.TP_groupes.Text = "Groupes"
        '
        'GB_groupe_localisation
        '
        Me.GB_groupe_localisation.BackColor = System.Drawing.Color.Teal
        Me.GB_groupe_localisation.Controls.Add(Me.LBL_code_groupe_groupes_loca)
        Me.GB_groupe_localisation.Controls.Add(Me.BT_supprimer_groupes_loca)
        Me.GB_groupe_localisation.Controls.Add(Me.TXT_code_groupe_groupes_loca)
        Me.GB_groupe_localisation.Controls.Add(Me.BT_modifier_groupes_loca)
        Me.GB_groupe_localisation.Controls.Add(Me.TXT_libelle_groupes_loca)
        Me.GB_groupe_localisation.Controls.Add(Me.BT_ajouter_groupes_loca)
        Me.GB_groupe_localisation.Controls.Add(Me.LBL_libelle_groupes_loca)
        Me.GB_groupe_localisation.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_groupe_localisation.ForeColor = System.Drawing.Color.White
        Me.GB_groupe_localisation.Location = New System.Drawing.Point(347, 22)
        Me.GB_groupe_localisation.Name = "GB_groupe_localisation"
        Me.GB_groupe_localisation.Size = New System.Drawing.Size(440, 136)
        Me.GB_groupe_localisation.TabIndex = 12
        Me.GB_groupe_localisation.TabStop = False
        Me.GB_groupe_localisation.Text = "Ajouter groupe"
        '
        'LBL_code_groupe_groupes_loca
        '
        Me.LBL_code_groupe_groupes_loca.AutoSize = True
        Me.LBL_code_groupe_groupes_loca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_code_groupe_groupes_loca.Location = New System.Drawing.Point(6, 42)
        Me.LBL_code_groupe_groupes_loca.Name = "LBL_code_groupe_groupes_loca"
        Me.LBL_code_groupe_groupes_loca.Size = New System.Drawing.Size(94, 19)
        Me.LBL_code_groupe_groupes_loca.TabIndex = 5
        Me.LBL_code_groupe_groupes_loca.Text = "Code groupe"
        '
        'BT_supprimer_groupes_loca
        '
        Me.BT_supprimer_groupes_loca.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_supprimer_groupes_loca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_supprimer_groupes_loca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_supprimer_groupes_loca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_supprimer_groupes_loca.ForeColor = System.Drawing.Color.White
        Me.BT_supprimer_groupes_loca.Location = New System.Drawing.Point(341, 95)
        Me.BT_supprimer_groupes_loca.Name = "BT_supprimer_groupes_loca"
        Me.BT_supprimer_groupes_loca.Size = New System.Drawing.Size(92, 27)
        Me.BT_supprimer_groupes_loca.TabIndex = 9
        Me.BT_supprimer_groupes_loca.Text = "Supprimer"
        Me.BT_supprimer_groupes_loca.UseVisualStyleBackColor = False
        '
        'TXT_code_groupe_groupes_loca
        '
        Me.TXT_code_groupe_groupes_loca.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_code_groupe_groupes_loca.Location = New System.Drawing.Point(129, 39)
        Me.TXT_code_groupe_groupes_loca.Name = "TXT_code_groupe_groupes_loca"
        Me.TXT_code_groupe_groupes_loca.Size = New System.Drawing.Size(128, 22)
        Me.TXT_code_groupe_groupes_loca.TabIndex = 7
        '
        'BT_modifier_groupes_loca
        '
        Me.BT_modifier_groupes_loca.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_modifier_groupes_loca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_modifier_groupes_loca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_modifier_groupes_loca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_modifier_groupes_loca.ForeColor = System.Drawing.Color.White
        Me.BT_modifier_groupes_loca.Location = New System.Drawing.Point(236, 95)
        Me.BT_modifier_groupes_loca.Name = "BT_modifier_groupes_loca"
        Me.BT_modifier_groupes_loca.Size = New System.Drawing.Size(84, 27)
        Me.BT_modifier_groupes_loca.TabIndex = 10
        Me.BT_modifier_groupes_loca.Text = "Modifier"
        Me.BT_modifier_groupes_loca.UseVisualStyleBackColor = False
        '
        'TXT_libelle_groupes_loca
        '
        Me.TXT_libelle_groupes_loca.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_libelle_groupes_loca.Location = New System.Drawing.Point(129, 67)
        Me.TXT_libelle_groupes_loca.Name = "TXT_libelle_groupes_loca"
        Me.TXT_libelle_groupes_loca.Size = New System.Drawing.Size(304, 22)
        Me.TXT_libelle_groupes_loca.TabIndex = 6
        '
        'BT_ajouter_groupes_loca
        '
        Me.BT_ajouter_groupes_loca.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_ajouter_groupes_loca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_ajouter_groupes_loca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_ajouter_groupes_loca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ajouter_groupes_loca.ForeColor = System.Drawing.Color.White
        Me.BT_ajouter_groupes_loca.Location = New System.Drawing.Point(129, 95)
        Me.BT_ajouter_groupes_loca.Name = "BT_ajouter_groupes_loca"
        Me.BT_ajouter_groupes_loca.Size = New System.Drawing.Size(85, 27)
        Me.BT_ajouter_groupes_loca.TabIndex = 11
        Me.BT_ajouter_groupes_loca.Text = "Ajouter"
        Me.BT_ajouter_groupes_loca.UseVisualStyleBackColor = False
        '
        'LBL_libelle_groupes_loca
        '
        Me.LBL_libelle_groupes_loca.AutoSize = True
        Me.LBL_libelle_groupes_loca.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_libelle_groupes_loca.Location = New System.Drawing.Point(6, 70)
        Me.LBL_libelle_groupes_loca.Name = "LBL_libelle_groupes_loca"
        Me.LBL_libelle_groupes_loca.Size = New System.Drawing.Size(55, 19)
        Me.LBL_libelle_groupes_loca.TabIndex = 4
        Me.LBL_libelle_groupes_loca.Text = "Libellé"
        '
        'DGV_groupes_groupes_loca
        '
        Me.DGV_groupes_groupes_loca.BackgroundColor = System.Drawing.Color.White
        Me.DGV_groupes_groupes_loca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_groupes_groupes_loca.Location = New System.Drawing.Point(348, 164)
        Me.DGV_groupes_groupes_loca.Name = "DGV_groupes_groupes_loca"
        Me.DGV_groupes_groupes_loca.Size = New System.Drawing.Size(439, 286)
        Me.DGV_groupes_groupes_loca.TabIndex = 8
        '
        'LBL_localisation
        '
        Me.LBL_localisation.AutoSize = True
        Me.LBL_localisation.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_localisation.ForeColor = System.Drawing.Color.White
        Me.LBL_localisation.Location = New System.Drawing.Point(496, 89)
        Me.LBL_localisation.Name = "LBL_localisation"
        Me.LBL_localisation.Size = New System.Drawing.Size(159, 31)
        Me.LBL_localisation.TabIndex = 20
        Me.LBL_localisation.Text = "Localisation"
        '
        'MS_form1
        '
        Me.MS_form1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CompteToolStripMenuItem, Me.OutilsToolStripMenuItem, Me.AllerÀToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MS_form1.Location = New System.Drawing.Point(0, 0)
        Me.MS_form1.Name = "MS_form1"
        Me.MS_form1.Size = New System.Drawing.Size(1354, 24)
        Me.MS_form1.TabIndex = 26
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
        Me.AllerÀToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccueilToolStripMenuItem, Me.DisciplinesToolStripMenuItem, Me.DocumentsToolStripMenuItem, Me.UtilisateurSimpleToolStripMenuItem, Me.SuperUtilisateurToolStripMenuItem, Me.PrêtsToolStripMenuItem})
        Me.AllerÀToolStripMenuItem.Name = "AllerÀToolStripMenuItem"
        Me.AllerÀToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AllerÀToolStripMenuItem.Text = "Aller à"
        '
        'AccueilToolStripMenuItem
        '
        Me.AccueilToolStripMenuItem.Name = "AccueilToolStripMenuItem"
        Me.AccueilToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AccueilToolStripMenuItem.Text = "Accueil"
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
        'BT_logouasz
        '
        Me.BT_logouasz.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.UASZ
        Me.BT_logouasz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_logouasz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_logouasz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BT_logouasz.Location = New System.Drawing.Point(7, 32)
        Me.BT_logouasz.Name = "BT_logouasz"
        Me.BT_logouasz.Size = New System.Drawing.Size(96, 88)
        Me.BT_logouasz.TabIndex = 36
        Me.BT_logouasz.UseVisualStyleBackColor = True
        '
        'BT_logomi
        '
        Me.BT_logomi.BackgroundImage = Global.pvb_bmi.My.Resources.Resources.logo_ufr_couleur
        Me.BT_logomi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_logomi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_logomi.Location = New System.Drawing.Point(1108, 32)
        Me.BT_logomi.Name = "BT_logomi"
        Me.BT_logomi.Size = New System.Drawing.Size(234, 88)
        Me.BT_logomi.TabIndex = 37
        Me.BT_logomi.UseVisualStyleBackColor = True
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
        'Localisation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.BT_logomi)
        Me.Controls.Add(Me.BT_logouasz)
        Me.Controls.Add(Me.MS_form1)
        Me.Controls.Add(Me.LBL_localisation)
        Me.Controls.Add(Me.TC_localisation)
        Me.Controls.Add(Me.LBL_date)
        Me.Controls.Add(Me.LBL_heure)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Localisation"
        Me.Text = "Localisation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TC_localisation.ResumeLayout(False)
        Me.TP_rayons.ResumeLayout(False)
        Me.GB_rayon_rayon_localisation.ResumeLayout(False)
        Me.GB_rayon_rayon_localisation.PerformLayout()
        CType(Me.DGV_rayons_rayons_loca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_groupes.ResumeLayout(False)
        Me.GB_groupe_localisation.ResumeLayout(False)
        Me.GB_groupe_localisation.PerformLayout()
        CType(Me.DGV_groupes_groupes_loca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MS_form1.ResumeLayout(False)
        Me.MS_form1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_date As Label
    Friend WithEvents LBL_heure As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TM_Localisation As Timer
    Friend WithEvents TC_localisation As TabControl
    Friend WithEvents TP_rayons As TabPage
    Friend WithEvents TP_groupes As TabPage
    Friend WithEvents TXT_intitule_rayons_loca As TextBox
    Friend WithEvents TXT_num_ray_rayons_loca As TextBox
    Friend WithEvents LBL_intitule_rayons_loca As Label
    Friend WithEvents LBL_num_ray_rayons_loca As Label
    Friend WithEvents BT_ajouter_rayons_loca As Button
    Friend WithEvents DGV_rayons_rayons_loca As DataGridView
    Friend WithEvents BT_supprimer_rayons_loca As Button
    Friend WithEvents BT_modifier_rayons_loca As Button
    Friend WithEvents BT_supprimer_groupes_loca As Button
    Friend WithEvents BT_modifier_groupes_loca As Button
    Friend WithEvents BT_ajouter_groupes_loca As Button
    Friend WithEvents DGV_groupes_groupes_loca As DataGridView
    Friend WithEvents TXT_libelle_groupes_loca As TextBox
    Friend WithEvents TXT_code_groupe_groupes_loca As TextBox
    Friend WithEvents LBL_libelle_groupes_loca As Label
    Friend WithEvents LBL_code_groupe_groupes_loca As Label
    Friend WithEvents LBL_localisation As Label
    Friend WithEvents MS_form1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDeDonnéeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VérifierLaConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeConnecterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GB_rayon_rayon_localisation As GroupBox
    Friend WithEvents GB_groupe_localisation As GroupBox
    Friend WithEvents BT_logouasz As Button
    Friend WithEvents BT_logomi As Button
    Friend WithEvents CompteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeDéconnecterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllerÀToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccueilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherLaideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisciplinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilisateurSimpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuperUtilisateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrêtsToolStripMenuItem As ToolStripMenuItem
End Class
