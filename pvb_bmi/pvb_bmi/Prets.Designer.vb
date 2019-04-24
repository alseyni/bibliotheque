<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prets
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_prets = New System.Windows.Forms.Label()
        Me.TC_prets = New System.Windows.Forms.TabControl()
        Me.O_enregistrement_prets = New System.Windows.Forms.TabPage()
        Me.GB_pret_enr_prets = New System.Windows.Forms.GroupBox()
        Me.DTP_date_retour_enr_prets = New System.Windows.Forms.DateTimePicker()
        Me.DTP_date_emprunt_enr_prets = New System.Windows.Forms.DateTimePicker()
        Me.BT_enregistrer_enr_prets = New System.Windows.Forms.Button()
        Me.TXT_num_adherent_enr_prets = New System.Windows.Forms.TextBox()
        Me.LBL_date_emprunt_enr_prets = New System.Windows.Forms.Label()
        Me.TXT_cod_doc_enr_prets = New System.Windows.Forms.TextBox()
        Me.LBL_date_retour_enr_prets = New System.Windows.Forms.Label()
        Me.LBL_cod_doc_enr_prets = New System.Windows.Forms.Label()
        Me.LBL_num_adherent_enr_prets = New System.Windows.Forms.Label()
        Me.DGV_prets_enre_prets = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.O_restitution_prets = New System.Windows.Forms.TabPage()
        Me.GB_restituer_restitution_prets = New System.Windows.Forms.GroupBox()
        Me.BT_restituer_restitution_prets = New System.Windows.Forms.Button()
        Me.TXT_num_adherent_restitution_prets = New System.Windows.Forms.TextBox()
        Me.TXT_code_doc_restitution_prets = New System.Windows.Forms.TextBox()
        Me.LBL_code_doc_restitution_prets = New System.Windows.Forms.Label()
        Me.LBL_num_adherent_restitution_prets = New System.Windows.Forms.Label()
        Me.O_email_prets = New System.Windows.Forms.TabPage()
        Me.GB_email_email_prets = New System.Windows.Forms.GroupBox()
        Me.BT_email_email_prets = New System.Windows.Forms.Button()
        Me.TXT_email_email_prets = New System.Windows.Forms.TextBox()
        Me.TXT_prenom_email_prets = New System.Windows.Forms.TextBox()
        Me.TXT_nom_email_prets = New System.Windows.Forms.TextBox()
        Me.TXT_num_adherent_email_prets = New System.Windows.Forms.TextBox()
        Me.LBL_num_adherent_email_prets = New System.Windows.Forms.Label()
        Me.LBL_email_email_prets = New System.Windows.Forms.Label()
        Me.LBL_prenom_email_prets = New System.Windows.Forms.Label()
        Me.LBL_nom_email_prets = New System.Windows.Forms.Label()
        Me.DGV_email_email_prets = New System.Windows.Forms.DataGridView()
        Me.O_retard_prets = New System.Windows.Forms.TabPage()
        Me.DGV_retard_retard_prets = New System.Windows.Forms.DataGridView()
        Me.O_historique_prets = New System.Windows.Forms.TabPage()
        Me.DGV_historique_prets = New System.Windows.Forms.DataGridView()
        Me.LBL_date = New System.Windows.Forms.Label()
        Me.LBL_heure = New System.Windows.Forms.Label()
        Me.TM_prets = New System.Windows.Forms.Timer(Me.components)
        Me.MS_prets = New System.Windows.Forms.MenuStrip()
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
        Me.LocalisationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilisateurSimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuperUtilisateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TC_prets.SuspendLayout()
        Me.O_enregistrement_prets.SuspendLayout()
        Me.GB_pret_enr_prets.SuspendLayout()
        CType(Me.DGV_prets_enre_prets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.O_restitution_prets.SuspendLayout()
        Me.GB_restituer_restitution_prets.SuspendLayout()
        Me.O_email_prets.SuspendLayout()
        Me.GB_email_email_prets.SuspendLayout()
        CType(Me.DGV_email_email_prets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.O_retard_prets.SuspendLayout()
        CType(Me.DGV_retard_retard_prets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.O_historique_prets.SuspendLayout()
        CType(Me.DGV_historique_prets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MS_prets.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(212, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(769, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Université Assane SECK de Ziguinchor - Département Mathématique et Informatique"
        '
        'LBL_prets
        '
        Me.LBL_prets.AutoSize = True
        Me.LBL_prets.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_prets.ForeColor = System.Drawing.Color.White
        Me.LBL_prets.Location = New System.Drawing.Point(524, 91)
        Me.LBL_prets.Name = "LBL_prets"
        Me.LBL_prets.Size = New System.Drawing.Size(75, 31)
        Me.LBL_prets.TabIndex = 21
        Me.LBL_prets.Text = "Prêts"
        Me.LBL_prets.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TC_prets
        '
        Me.TC_prets.Controls.Add(Me.O_enregistrement_prets)
        Me.TC_prets.Controls.Add(Me.O_restitution_prets)
        Me.TC_prets.Controls.Add(Me.O_email_prets)
        Me.TC_prets.Controls.Add(Me.O_retard_prets)
        Me.TC_prets.Controls.Add(Me.O_historique_prets)
        Me.TC_prets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TC_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC_prets.Location = New System.Drawing.Point(12, 143)
        Me.TC_prets.Name = "TC_prets"
        Me.TC_prets.SelectedIndex = 0
        Me.TC_prets.Size = New System.Drawing.Size(1330, 557)
        Me.TC_prets.TabIndex = 22
        '
        'O_enregistrement_prets
        '
        Me.O_enregistrement_prets.BackColor = System.Drawing.Color.Teal
        Me.O_enregistrement_prets.Controls.Add(Me.GB_pret_enr_prets)
        Me.O_enregistrement_prets.Controls.Add(Me.DGV_prets_enre_prets)
        Me.O_enregistrement_prets.Controls.Add(Me.Label5)
        Me.O_enregistrement_prets.Location = New System.Drawing.Point(4, 28)
        Me.O_enregistrement_prets.Name = "O_enregistrement_prets"
        Me.O_enregistrement_prets.Padding = New System.Windows.Forms.Padding(3)
        Me.O_enregistrement_prets.Size = New System.Drawing.Size(1322, 525)
        Me.O_enregistrement_prets.TabIndex = 0
        Me.O_enregistrement_prets.Text = "Enregistrement"
        '
        'GB_pret_enr_prets
        '
        Me.GB_pret_enr_prets.BackColor = System.Drawing.Color.Teal
        Me.GB_pret_enr_prets.Controls.Add(Me.DTP_date_retour_enr_prets)
        Me.GB_pret_enr_prets.Controls.Add(Me.DTP_date_emprunt_enr_prets)
        Me.GB_pret_enr_prets.Controls.Add(Me.BT_enregistrer_enr_prets)
        Me.GB_pret_enr_prets.Controls.Add(Me.TXT_num_adherent_enr_prets)
        Me.GB_pret_enr_prets.Controls.Add(Me.LBL_date_emprunt_enr_prets)
        Me.GB_pret_enr_prets.Controls.Add(Me.TXT_cod_doc_enr_prets)
        Me.GB_pret_enr_prets.Controls.Add(Me.LBL_date_retour_enr_prets)
        Me.GB_pret_enr_prets.Controls.Add(Me.LBL_cod_doc_enr_prets)
        Me.GB_pret_enr_prets.Controls.Add(Me.LBL_num_adherent_enr_prets)
        Me.GB_pret_enr_prets.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_pret_enr_prets.ForeColor = System.Drawing.Color.White
        Me.GB_pret_enr_prets.Location = New System.Drawing.Point(732, 25)
        Me.GB_pret_enr_prets.Name = "GB_pret_enr_prets"
        Me.GB_pret_enr_prets.Size = New System.Drawing.Size(584, 117)
        Me.GB_pret_enr_prets.TabIndex = 3
        Me.GB_pret_enr_prets.TabStop = False
        Me.GB_pret_enr_prets.Text = "Enregistrement d'un prêt"
        '
        'DTP_date_retour_enr_prets
        '
        Me.DTP_date_retour_enr_prets.CustomFormat = "yyyy/MM/dd"
        Me.DTP_date_retour_enr_prets.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_date_retour_enr_prets.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_date_retour_enr_prets.Location = New System.Drawing.Point(113, 70)
        Me.DTP_date_retour_enr_prets.Name = "DTP_date_retour_enr_prets"
        Me.DTP_date_retour_enr_prets.Size = New System.Drawing.Size(98, 22)
        Me.DTP_date_retour_enr_prets.TabIndex = 3
        '
        'DTP_date_emprunt_enr_prets
        '
        Me.DTP_date_emprunt_enr_prets.CustomFormat = "yyyy/MM/dd"
        Me.DTP_date_emprunt_enr_prets.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_date_emprunt_enr_prets.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_date_emprunt_enr_prets.Location = New System.Drawing.Point(6, 70)
        Me.DTP_date_emprunt_enr_prets.Name = "DTP_date_emprunt_enr_prets"
        Me.DTP_date_emprunt_enr_prets.Size = New System.Drawing.Size(100, 22)
        Me.DTP_date_emprunt_enr_prets.TabIndex = 3
        '
        'BT_enregistrer_enr_prets
        '
        Me.BT_enregistrer_enr_prets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_enregistrer_enr_prets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_enregistrer_enr_prets.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_enregistrer_enr_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_enregistrer_enr_prets.ForeColor = System.Drawing.Color.White
        Me.BT_enregistrer_enr_prets.Location = New System.Drawing.Point(477, 65)
        Me.BT_enregistrer_enr_prets.Name = "BT_enregistrer_enr_prets"
        Me.BT_enregistrer_enr_prets.Size = New System.Drawing.Size(101, 28)
        Me.BT_enregistrer_enr_prets.TabIndex = 2
        Me.BT_enregistrer_enr_prets.Text = "Enregistrer"
        Me.BT_enregistrer_enr_prets.UseVisualStyleBackColor = False
        '
        'TXT_num_adherent_enr_prets
        '
        Me.TXT_num_adherent_enr_prets.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_num_adherent_enr_prets.Location = New System.Drawing.Point(217, 70)
        Me.TXT_num_adherent_enr_prets.Name = "TXT_num_adherent_enr_prets"
        Me.TXT_num_adherent_enr_prets.Size = New System.Drawing.Size(126, 22)
        Me.TXT_num_adherent_enr_prets.TabIndex = 1
        '
        'LBL_date_emprunt_enr_prets
        '
        Me.LBL_date_emprunt_enr_prets.AutoSize = True
        Me.LBL_date_emprunt_enr_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_date_emprunt_enr_prets.Location = New System.Drawing.Point(2, 32)
        Me.LBL_date_emprunt_enr_prets.Name = "LBL_date_emprunt_enr_prets"
        Me.LBL_date_emprunt_enr_prets.Size = New System.Drawing.Size(101, 19)
        Me.LBL_date_emprunt_enr_prets.TabIndex = 0
        Me.LBL_date_emprunt_enr_prets.Text = "Date emprunt"
        '
        'TXT_cod_doc_enr_prets
        '
        Me.TXT_cod_doc_enr_prets.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_cod_doc_enr_prets.Location = New System.Drawing.Point(349, 70)
        Me.TXT_cod_doc_enr_prets.Name = "TXT_cod_doc_enr_prets"
        Me.TXT_cod_doc_enr_prets.Size = New System.Drawing.Size(123, 22)
        Me.TXT_cod_doc_enr_prets.TabIndex = 1
        '
        'LBL_date_retour_enr_prets
        '
        Me.LBL_date_retour_enr_prets.AutoSize = True
        Me.LBL_date_retour_enr_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_date_retour_enr_prets.Location = New System.Drawing.Point(109, 32)
        Me.LBL_date_retour_enr_prets.Name = "LBL_date_retour_enr_prets"
        Me.LBL_date_retour_enr_prets.Size = New System.Drawing.Size(87, 19)
        Me.LBL_date_retour_enr_prets.TabIndex = 0
        Me.LBL_date_retour_enr_prets.Text = "Date retour"
        '
        'LBL_cod_doc_enr_prets
        '
        Me.LBL_cod_doc_enr_prets.AutoSize = True
        Me.LBL_cod_doc_enr_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_cod_doc_enr_prets.Location = New System.Drawing.Point(345, 32)
        Me.LBL_cod_doc_enr_prets.Name = "LBL_cod_doc_enr_prets"
        Me.LBL_cod_doc_enr_prets.Size = New System.Drawing.Size(112, 19)
        Me.LBL_cod_doc_enr_prets.TabIndex = 0
        Me.LBL_cod_doc_enr_prets.Text = "Code document"
        '
        'LBL_num_adherent_enr_prets
        '
        Me.LBL_num_adherent_enr_prets.AutoSize = True
        Me.LBL_num_adherent_enr_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_num_adherent_enr_prets.Location = New System.Drawing.Point(213, 32)
        Me.LBL_num_adherent_enr_prets.Name = "LBL_num_adherent_enr_prets"
        Me.LBL_num_adherent_enr_prets.Size = New System.Drawing.Size(126, 19)
        Me.LBL_num_adherent_enr_prets.TabIndex = 0
        Me.LBL_num_adherent_enr_prets.Text = "Numéro adherent"
        '
        'DGV_prets_enre_prets
        '
        Me.DGV_prets_enre_prets.BackgroundColor = System.Drawing.Color.White
        Me.DGV_prets_enre_prets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_prets_enre_prets.Location = New System.Drawing.Point(6, 25)
        Me.DGV_prets_enre_prets.Name = "DGV_prets_enre_prets"
        Me.DGV_prets_enre_prets.Size = New System.Drawing.Size(720, 443)
        Me.DGV_prets_enre_prets.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(353, -61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Label1"
        '
        'O_restitution_prets
        '
        Me.O_restitution_prets.BackColor = System.Drawing.Color.Teal
        Me.O_restitution_prets.Controls.Add(Me.GB_restituer_restitution_prets)
        Me.O_restitution_prets.Location = New System.Drawing.Point(4, 28)
        Me.O_restitution_prets.Name = "O_restitution_prets"
        Me.O_restitution_prets.Padding = New System.Windows.Forms.Padding(3)
        Me.O_restitution_prets.Size = New System.Drawing.Size(1322, 525)
        Me.O_restitution_prets.TabIndex = 1
        Me.O_restitution_prets.Text = "Restitution"
        '
        'GB_restituer_restitution_prets
        '
        Me.GB_restituer_restitution_prets.BackColor = System.Drawing.Color.Teal
        Me.GB_restituer_restitution_prets.Controls.Add(Me.BT_restituer_restitution_prets)
        Me.GB_restituer_restitution_prets.Controls.Add(Me.TXT_num_adherent_restitution_prets)
        Me.GB_restituer_restitution_prets.Controls.Add(Me.TXT_code_doc_restitution_prets)
        Me.GB_restituer_restitution_prets.Controls.Add(Me.LBL_code_doc_restitution_prets)
        Me.GB_restituer_restitution_prets.Controls.Add(Me.LBL_num_adherent_restitution_prets)
        Me.GB_restituer_restitution_prets.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_restituer_restitution_prets.ForeColor = System.Drawing.Color.White
        Me.GB_restituer_restitution_prets.Location = New System.Drawing.Point(484, 157)
        Me.GB_restituer_restitution_prets.Name = "GB_restituer_restitution_prets"
        Me.GB_restituer_restitution_prets.Size = New System.Drawing.Size(273, 146)
        Me.GB_restituer_restitution_prets.TabIndex = 0
        Me.GB_restituer_restitution_prets.TabStop = False
        Me.GB_restituer_restitution_prets.Text = "Restituer un document"
        '
        'BT_restituer_restitution_prets
        '
        Me.BT_restituer_restitution_prets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_restituer_restitution_prets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_restituer_restitution_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_restituer_restitution_prets.ForeColor = System.Drawing.Color.White
        Me.BT_restituer_restitution_prets.Location = New System.Drawing.Point(142, 97)
        Me.BT_restituer_restitution_prets.Name = "BT_restituer_restitution_prets"
        Me.BT_restituer_restitution_prets.Size = New System.Drawing.Size(126, 32)
        Me.BT_restituer_restitution_prets.TabIndex = 6
        Me.BT_restituer_restitution_prets.Text = "Restituer"
        Me.BT_restituer_restitution_prets.UseVisualStyleBackColor = False
        '
        'TXT_num_adherent_restitution_prets
        '
        Me.TXT_num_adherent_restitution_prets.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_num_adherent_restitution_prets.Location = New System.Drawing.Point(142, 41)
        Me.TXT_num_adherent_restitution_prets.Name = "TXT_num_adherent_restitution_prets"
        Me.TXT_num_adherent_restitution_prets.Size = New System.Drawing.Size(126, 22)
        Me.TXT_num_adherent_restitution_prets.TabIndex = 4
        '
        'TXT_code_doc_restitution_prets
        '
        Me.TXT_code_doc_restitution_prets.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_code_doc_restitution_prets.Location = New System.Drawing.Point(142, 69)
        Me.TXT_code_doc_restitution_prets.Name = "TXT_code_doc_restitution_prets"
        Me.TXT_code_doc_restitution_prets.Size = New System.Drawing.Size(126, 22)
        Me.TXT_code_doc_restitution_prets.TabIndex = 5
        '
        'LBL_code_doc_restitution_prets
        '
        Me.LBL_code_doc_restitution_prets.AutoSize = True
        Me.LBL_code_doc_restitution_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_code_doc_restitution_prets.Location = New System.Drawing.Point(6, 72)
        Me.LBL_code_doc_restitution_prets.Name = "LBL_code_doc_restitution_prets"
        Me.LBL_code_doc_restitution_prets.Size = New System.Drawing.Size(112, 19)
        Me.LBL_code_doc_restitution_prets.TabIndex = 2
        Me.LBL_code_doc_restitution_prets.Text = "Code document"
        '
        'LBL_num_adherent_restitution_prets
        '
        Me.LBL_num_adherent_restitution_prets.AutoSize = True
        Me.LBL_num_adherent_restitution_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_num_adherent_restitution_prets.Location = New System.Drawing.Point(6, 41)
        Me.LBL_num_adherent_restitution_prets.Name = "LBL_num_adherent_restitution_prets"
        Me.LBL_num_adherent_restitution_prets.Size = New System.Drawing.Size(126, 19)
        Me.LBL_num_adherent_restitution_prets.TabIndex = 3
        Me.LBL_num_adherent_restitution_prets.Text = "Numéro adherent"
        '
        'O_email_prets
        '
        Me.O_email_prets.BackColor = System.Drawing.Color.Teal
        Me.O_email_prets.Controls.Add(Me.GB_email_email_prets)
        Me.O_email_prets.Controls.Add(Me.DGV_email_email_prets)
        Me.O_email_prets.Location = New System.Drawing.Point(4, 28)
        Me.O_email_prets.Name = "O_email_prets"
        Me.O_email_prets.Padding = New System.Windows.Forms.Padding(3)
        Me.O_email_prets.Size = New System.Drawing.Size(1322, 525)
        Me.O_email_prets.TabIndex = 2
        Me.O_email_prets.Text = "Email"
        '
        'GB_email_email_prets
        '
        Me.GB_email_email_prets.BackColor = System.Drawing.Color.Teal
        Me.GB_email_email_prets.Controls.Add(Me.BT_email_email_prets)
        Me.GB_email_email_prets.Controls.Add(Me.TXT_email_email_prets)
        Me.GB_email_email_prets.Controls.Add(Me.TXT_prenom_email_prets)
        Me.GB_email_email_prets.Controls.Add(Me.TXT_nom_email_prets)
        Me.GB_email_email_prets.Controls.Add(Me.TXT_num_adherent_email_prets)
        Me.GB_email_email_prets.Controls.Add(Me.LBL_num_adherent_email_prets)
        Me.GB_email_email_prets.Controls.Add(Me.LBL_email_email_prets)
        Me.GB_email_email_prets.Controls.Add(Me.LBL_prenom_email_prets)
        Me.GB_email_email_prets.Controls.Add(Me.LBL_nom_email_prets)
        Me.GB_email_email_prets.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_email_email_prets.ForeColor = System.Drawing.Color.White
        Me.GB_email_email_prets.Location = New System.Drawing.Point(765, 20)
        Me.GB_email_email_prets.Name = "GB_email_email_prets"
        Me.GB_email_email_prets.Size = New System.Drawing.Size(551, 190)
        Me.GB_email_email_prets.TabIndex = 1
        Me.GB_email_email_prets.TabStop = False
        Me.GB_email_email_prets.Text = "Envoyer un mail"
        '
        'BT_email_email_prets
        '
        Me.BT_email_email_prets.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BT_email_email_prets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_email_email_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_email_email_prets.ForeColor = System.Drawing.Color.White
        Me.BT_email_email_prets.Location = New System.Drawing.Point(196, 148)
        Me.BT_email_email_prets.Name = "BT_email_email_prets"
        Me.BT_email_email_prets.Size = New System.Drawing.Size(259, 31)
        Me.BT_email_email_prets.TabIndex = 2
        Me.BT_email_email_prets.Text = "Envoyer un email"
        Me.BT_email_email_prets.UseVisualStyleBackColor = False
        '
        'TXT_email_email_prets
        '
        Me.TXT_email_email_prets.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_email_email_prets.Location = New System.Drawing.Point(196, 120)
        Me.TXT_email_email_prets.Name = "TXT_email_email_prets"
        Me.TXT_email_email_prets.Size = New System.Drawing.Size(259, 22)
        Me.TXT_email_email_prets.TabIndex = 1
        '
        'TXT_prenom_email_prets
        '
        Me.TXT_prenom_email_prets.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_prenom_email_prets.Location = New System.Drawing.Point(196, 92)
        Me.TXT_prenom_email_prets.Name = "TXT_prenom_email_prets"
        Me.TXT_prenom_email_prets.Size = New System.Drawing.Size(259, 22)
        Me.TXT_prenom_email_prets.TabIndex = 1
        '
        'TXT_nom_email_prets
        '
        Me.TXT_nom_email_prets.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_nom_email_prets.Location = New System.Drawing.Point(196, 64)
        Me.TXT_nom_email_prets.Name = "TXT_nom_email_prets"
        Me.TXT_nom_email_prets.Size = New System.Drawing.Size(259, 22)
        Me.TXT_nom_email_prets.TabIndex = 1
        '
        'TXT_num_adherent_email_prets
        '
        Me.TXT_num_adherent_email_prets.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_num_adherent_email_prets.Location = New System.Drawing.Point(196, 36)
        Me.TXT_num_adherent_email_prets.Name = "TXT_num_adherent_email_prets"
        Me.TXT_num_adherent_email_prets.Size = New System.Drawing.Size(259, 22)
        Me.TXT_num_adherent_email_prets.TabIndex = 1
        '
        'LBL_num_adherent_email_prets
        '
        Me.LBL_num_adherent_email_prets.AutoSize = True
        Me.LBL_num_adherent_email_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_num_adherent_email_prets.Location = New System.Drawing.Point(6, 39)
        Me.LBL_num_adherent_email_prets.Name = "LBL_num_adherent_email_prets"
        Me.LBL_num_adherent_email_prets.Size = New System.Drawing.Size(126, 19)
        Me.LBL_num_adherent_email_prets.TabIndex = 0
        Me.LBL_num_adherent_email_prets.Text = "Numéro adherent"
        '
        'LBL_email_email_prets
        '
        Me.LBL_email_email_prets.AutoSize = True
        Me.LBL_email_email_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_email_email_prets.Location = New System.Drawing.Point(6, 123)
        Me.LBL_email_email_prets.Name = "LBL_email_email_prets"
        Me.LBL_email_email_prets.Size = New System.Drawing.Size(104, 19)
        Me.LBL_email_email_prets.TabIndex = 0
        Me.LBL_email_email_prets.Text = "Addresse mail"
        '
        'LBL_prenom_email_prets
        '
        Me.LBL_prenom_email_prets.AutoSize = True
        Me.LBL_prenom_email_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_prenom_email_prets.Location = New System.Drawing.Point(6, 95)
        Me.LBL_prenom_email_prets.Name = "LBL_prenom_email_prets"
        Me.LBL_prenom_email_prets.Size = New System.Drawing.Size(60, 19)
        Me.LBL_prenom_email_prets.TabIndex = 0
        Me.LBL_prenom_email_prets.Text = "Prénom"
        '
        'LBL_nom_email_prets
        '
        Me.LBL_nom_email_prets.AutoSize = True
        Me.LBL_nom_email_prets.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nom_email_prets.Location = New System.Drawing.Point(6, 67)
        Me.LBL_nom_email_prets.Name = "LBL_nom_email_prets"
        Me.LBL_nom_email_prets.Size = New System.Drawing.Size(41, 19)
        Me.LBL_nom_email_prets.TabIndex = 0
        Me.LBL_nom_email_prets.Text = "Nom"
        '
        'DGV_email_email_prets
        '
        Me.DGV_email_email_prets.BackgroundColor = System.Drawing.Color.White
        Me.DGV_email_email_prets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_email_email_prets.Location = New System.Drawing.Point(6, 20)
        Me.DGV_email_email_prets.Name = "DGV_email_email_prets"
        Me.DGV_email_email_prets.Size = New System.Drawing.Size(753, 424)
        Me.DGV_email_email_prets.TabIndex = 0
        '
        'O_retard_prets
        '
        Me.O_retard_prets.BackColor = System.Drawing.Color.Teal
        Me.O_retard_prets.Controls.Add(Me.DGV_retard_retard_prets)
        Me.O_retard_prets.Location = New System.Drawing.Point(4, 28)
        Me.O_retard_prets.Name = "O_retard_prets"
        Me.O_retard_prets.Padding = New System.Windows.Forms.Padding(3)
        Me.O_retard_prets.Size = New System.Drawing.Size(1322, 525)
        Me.O_retard_prets.TabIndex = 3
        Me.O_retard_prets.Text = "Retard"
        '
        'DGV_retard_retard_prets
        '
        Me.DGV_retard_retard_prets.BackgroundColor = System.Drawing.Color.White
        Me.DGV_retard_retard_prets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_retard_retard_prets.Location = New System.Drawing.Point(6, 17)
        Me.DGV_retard_retard_prets.Name = "DGV_retard_retard_prets"
        Me.DGV_retard_retard_prets.Size = New System.Drawing.Size(859, 427)
        Me.DGV_retard_retard_prets.TabIndex = 1
        '
        'O_historique_prets
        '
        Me.O_historique_prets.BackColor = System.Drawing.Color.Teal
        Me.O_historique_prets.Controls.Add(Me.DGV_historique_prets)
        Me.O_historique_prets.Location = New System.Drawing.Point(4, 28)
        Me.O_historique_prets.Name = "O_historique_prets"
        Me.O_historique_prets.Padding = New System.Windows.Forms.Padding(3)
        Me.O_historique_prets.Size = New System.Drawing.Size(1322, 525)
        Me.O_historique_prets.TabIndex = 4
        Me.O_historique_prets.Text = "Historique"
        '
        'DGV_historique_prets
        '
        Me.DGV_historique_prets.BackgroundColor = System.Drawing.Color.White
        Me.DGV_historique_prets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_historique_prets.Location = New System.Drawing.Point(6, 26)
        Me.DGV_historique_prets.Name = "DGV_historique_prets"
        Me.DGV_historique_prets.Size = New System.Drawing.Size(744, 418)
        Me.DGV_historique_prets.TabIndex = 0
        '
        'LBL_date
        '
        Me.LBL_date.AutoSize = True
        Me.LBL_date.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_date.ForeColor = System.Drawing.Color.White
        Me.LBL_date.Location = New System.Drawing.Point(242, 82)
        Me.LBL_date.Name = "LBL_date"
        Me.LBL_date.Size = New System.Drawing.Size(88, 40)
        Me.LBL_date.TabIndex = 25
        Me.LBL_date.Text = "Date"
        '
        'LBL_heure
        '
        Me.LBL_heure.AutoSize = True
        Me.LBL_heure.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_heure.ForeColor = System.Drawing.Color.White
        Me.LBL_heure.Location = New System.Drawing.Point(820, 82)
        Me.LBL_heure.Name = "LBL_heure"
        Me.LBL_heure.Size = New System.Drawing.Size(110, 40)
        Me.LBL_heure.TabIndex = 26
        Me.LBL_heure.Text = "Heure"
        '
        'TM_prets
        '
        Me.TM_prets.Interval = 1000
        '
        'MS_prets
        '
        Me.MS_prets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CompteToolStripMenuItem, Me.OutilsToolStripMenuItem, Me.AllerÀToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MS_prets.Location = New System.Drawing.Point(0, 0)
        Me.MS_prets.Name = "MS_prets"
        Me.MS_prets.Size = New System.Drawing.Size(1354, 24)
        Me.MS_prets.TabIndex = 28
        Me.MS_prets.Text = "MenuStrip1"
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
        Me.AllerÀToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccueilToolStripMenuItem, Me.DisciplinesToolStripMenuItem, Me.DocumentsToolStripMenuItem, Me.LocalisationToolStripMenuItem, Me.UtilisateurSimpleToolStripMenuItem, Me.SuperUtilisateurToolStripMenuItem})
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
        Me.BT_logouasz.Location = New System.Drawing.Point(12, 34)
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
        Me.BT_logomi.Location = New System.Drawing.Point(1100, 34)
        Me.BT_logomi.Name = "BT_logomi"
        Me.BT_logomi.Size = New System.Drawing.Size(242, 88)
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
        'Prets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.BT_logomi)
        Me.Controls.Add(Me.BT_logouasz)
        Me.Controls.Add(Me.MS_prets)
        Me.Controls.Add(Me.LBL_heure)
        Me.Controls.Add(Me.LBL_date)
        Me.Controls.Add(Me.TC_prets)
        Me.Controls.Add(Me.LBL_prets)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Prets"
        Me.Text = "Prêts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TC_prets.ResumeLayout(False)
        Me.O_enregistrement_prets.ResumeLayout(False)
        Me.O_enregistrement_prets.PerformLayout()
        Me.GB_pret_enr_prets.ResumeLayout(False)
        Me.GB_pret_enr_prets.PerformLayout()
        CType(Me.DGV_prets_enre_prets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.O_restitution_prets.ResumeLayout(False)
        Me.GB_restituer_restitution_prets.ResumeLayout(False)
        Me.GB_restituer_restitution_prets.PerformLayout()
        Me.O_email_prets.ResumeLayout(False)
        Me.GB_email_email_prets.ResumeLayout(False)
        Me.GB_email_email_prets.PerformLayout()
        CType(Me.DGV_email_email_prets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.O_retard_prets.ResumeLayout(False)
        CType(Me.DGV_retard_retard_prets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.O_historique_prets.ResumeLayout(False)
        CType(Me.DGV_historique_prets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MS_prets.ResumeLayout(False)
        Me.MS_prets.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents LBL_prets As Label
    Friend WithEvents TC_prets As TabControl
    Friend WithEvents O_enregistrement_prets As TabPage
    Friend WithEvents O_restitution_prets As TabPage
    Friend WithEvents O_email_prets As TabPage
    Friend WithEvents O_retard_prets As TabPage
    Friend WithEvents O_historique_prets As TabPage
    Friend WithEvents LBL_date As Label
    Friend WithEvents LBL_heure As Label
    Friend WithEvents TM_prets As Timer
    Friend WithEvents TXT_cod_doc_enr_prets As TextBox
    Friend WithEvents TXT_num_adherent_enr_prets As TextBox
    Friend WithEvents LBL_num_adherent_enr_prets As Label
    Friend WithEvents LBL_cod_doc_enr_prets As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBL_date_retour_enr_prets As Label
    Friend WithEvents LBL_date_emprunt_enr_prets As Label
    Friend WithEvents DGV_prets_enre_prets As DataGridView
    Friend WithEvents GB_pret_enr_prets As GroupBox
    Friend WithEvents BT_enregistrer_enr_prets As Button
    Friend WithEvents DTP_date_retour_enr_prets As DateTimePicker
    Friend WithEvents DTP_date_emprunt_enr_prets As DateTimePicker
    Friend WithEvents GB_restituer_restitution_prets As GroupBox
    Friend WithEvents BT_restituer_restitution_prets As Button
    Friend WithEvents TXT_num_adherent_restitution_prets As TextBox
    Friend WithEvents TXT_code_doc_restitution_prets As TextBox
    Friend WithEvents LBL_code_doc_restitution_prets As Label
    Friend WithEvents LBL_num_adherent_restitution_prets As Label
    Friend WithEvents GB_email_email_prets As GroupBox
    Friend WithEvents DGV_email_email_prets As DataGridView
    Friend WithEvents TXT_num_adherent_email_prets As TextBox
    Friend WithEvents LBL_num_adherent_email_prets As Label
    Friend WithEvents LBL_nom_email_prets As Label
    Friend WithEvents LBL_prenom_email_prets As Label
    Friend WithEvents LBL_email_email_prets As Label
    Friend WithEvents TXT_nom_email_prets As TextBox
    Friend WithEvents TXT_prenom_email_prets As TextBox
    Friend WithEvents TXT_email_email_prets As TextBox
    Friend WithEvents BT_email_email_prets As Button
    Friend WithEvents DGV_retard_retard_prets As DataGridView
    Friend WithEvents DGV_historique_prets As DataGridView
    Friend WithEvents MS_prets As MenuStrip
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
    Friend WithEvents CompteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeDéconnecterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllerÀToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccueilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherLaideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisciplinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalisationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilisateurSimpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuperUtilisateurToolStripMenuItem As ToolStripMenuItem
End Class
