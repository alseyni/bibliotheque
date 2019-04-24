<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apropos
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBL_nom = New System.Windows.Forms.Label()
        Me.LBL_version = New System.Windows.Forms.Label()
        Me.LBL_right = New System.Windows.Forms.Label()
        Me.LBL_fermer = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pvb_bmi.My.Resources.Resources.micon_01
        Me.PictureBox1.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LBL_nom
        '
        Me.LBL_nom.AutoSize = True
        Me.LBL_nom.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nom.Location = New System.Drawing.Point(123, 12)
        Me.LBL_nom.Name = "LBL_nom"
        Me.LBL_nom.Size = New System.Drawing.Size(239, 109)
        Me.LBL_nom.TabIndex = 1
        Me.LBL_nom.Text = "BMI"
        '
        'LBL_version
        '
        Me.LBL_version.AutoSize = True
        Me.LBL_version.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_version.Location = New System.Drawing.Point(138, 102)
        Me.LBL_version.Name = "LBL_version"
        Me.LBL_version.Size = New System.Drawing.Size(84, 19)
        Me.LBL_version.TabIndex = 1
        Me.LBL_version.Text = "Version 1.0"
        '
        'LBL_right
        '
        Me.LBL_right.AutoSize = True
        Me.LBL_right.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_right.Location = New System.Drawing.Point(44, 161)
        Me.LBL_right.Name = "LBL_right"
        Me.LBL_right.Size = New System.Drawing.Size(272, 19)
        Me.LBL_right.TabIndex = 1
        Me.LBL_right.Text = "Copyright 2013 - 2016 Seinaly Software"
        '
        'LBL_fermer
        '
        Me.LBL_fermer.AutoSize = True
        Me.LBL_fermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBL_fermer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_fermer.ForeColor = System.Drawing.Color.White
        Me.LBL_fermer.Location = New System.Drawing.Point(277, 9)
        Me.LBL_fermer.Name = "LBL_fermer"
        Me.LBL_fermer.Size = New System.Drawing.Size(58, 19)
        Me.LBL_fermer.TabIndex = 2
        Me.LBL_fermer.Text = "Fermer"
        '
        'Apropos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(358, 189)
        Me.Controls.Add(Me.LBL_fermer)
        Me.Controls.Add(Me.LBL_right)
        Me.Controls.Add(Me.LBL_version)
        Me.Controls.Add(Me.LBL_nom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Apropos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apropos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBL_nom As Label
    Friend WithEvents LBL_version As Label
    Friend WithEvents LBL_right As Label
    Friend WithEvents LBL_fermer As Label
End Class
