<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visualiser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visualiser))
        Me.RTB_visualiser = New System.Windows.Forms.RichTextBox()
        Me.BT_apercu = New System.Windows.Forms.Button()
        Me.BT_imprimer = New System.Windows.Forms.Button()
        Me.PPD_visualiser = New System.Windows.Forms.PrintPreviewDialog()
        Me.PD_visualiser = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_fermer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RTB_visualiser
        '
        Me.RTB_visualiser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_visualiser.Location = New System.Drawing.Point(18, 32)
        Me.RTB_visualiser.Margin = New System.Windows.Forms.Padding(4)
        Me.RTB_visualiser.Name = "RTB_visualiser"
        Me.RTB_visualiser.Size = New System.Drawing.Size(511, 375)
        Me.RTB_visualiser.TabIndex = 0
        Me.RTB_visualiser.Text = ""
        '
        'BT_apercu
        '
        Me.BT_apercu.BackColor = System.Drawing.Color.Teal
        Me.BT_apercu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_apercu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_apercu.ForeColor = System.Drawing.Color.White
        Me.BT_apercu.Location = New System.Drawing.Point(18, 415)
        Me.BT_apercu.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_apercu.Name = "BT_apercu"
        Me.BT_apercu.Size = New System.Drawing.Size(86, 29)
        Me.BT_apercu.TabIndex = 1
        Me.BT_apercu.Text = "Aperçu"
        Me.BT_apercu.UseVisualStyleBackColor = False
        '
        'BT_imprimer
        '
        Me.BT_imprimer.BackColor = System.Drawing.Color.Teal
        Me.BT_imprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_imprimer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_imprimer.ForeColor = System.Drawing.Color.White
        Me.BT_imprimer.Location = New System.Drawing.Point(438, 415)
        Me.BT_imprimer.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_imprimer.Name = "BT_imprimer"
        Me.BT_imprimer.Size = New System.Drawing.Size(91, 29)
        Me.BT_imprimer.TabIndex = 2
        Me.BT_imprimer.Text = "Imprimer"
        Me.BT_imprimer.UseVisualStyleBackColor = False
        '
        'PPD_visualiser
        '
        Me.PPD_visualiser.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PPD_visualiser.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PPD_visualiser.ClientSize = New System.Drawing.Size(400, 300)
        Me.PPD_visualiser.Document = Me.PD_visualiser
        Me.PPD_visualiser.Enabled = True
        Me.PPD_visualiser.Icon = CType(resources.GetObject("PPD_visualiser.Icon"), System.Drawing.Icon)
        Me.PPD_visualiser.Name = "PPD_visualiser"
        Me.PPD_visualiser.Visible = False
        '
        'PD_visualiser
        '
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
        Me.LBL_fermer.ForeColor = System.Drawing.Color.White
        Me.LBL_fermer.Location = New System.Drawing.Point(476, 9)
        Me.LBL_fermer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_fermer.Name = "LBL_fermer"
        Me.LBL_fermer.Size = New System.Drawing.Size(53, 19)
        Me.LBL_fermer.TabIndex = 3
        Me.LBL_fermer.Text = "Fermer"
        '
        'Visualiser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(547, 451)
        Me.Controls.Add(Me.LBL_fermer)
        Me.Controls.Add(Me.BT_imprimer)
        Me.Controls.Add(Me.BT_apercu)
        Me.Controls.Add(Me.RTB_visualiser)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Visualiser"
        Me.Opacity = 0.9R
        Me.Text = "Visualiser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RTB_visualiser As RichTextBox
    Friend WithEvents BT_apercu As Button
    Friend WithEvents BT_imprimer As Button
    Friend WithEvents PPD_visualiser As PrintPreviewDialog
    Friend WithEvents PD_visualiser As Printing.PrintDocument
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LBL_fermer As Label
End Class
