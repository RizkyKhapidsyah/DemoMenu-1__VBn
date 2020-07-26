<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.labelPesan = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWarna = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWarnaMerah = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWarnaHijau = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWarnaBiru = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWarnaHitam = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuWarnaVisibel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpTentang = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelPesan
        '
        Me.labelPesan.AutoSize = True
        Me.labelPesan.Location = New System.Drawing.Point(77, 119)
        Me.labelPesan.Name = "labelPesan"
        Me.labelPesan.Size = New System.Drawing.Size(65, 13)
        Me.labelPesan.TabIndex = 0
        Me.labelPesan.Text = "Hallo Dunia!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuWarna, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileKeluar})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileKeluar
        '
        Me.mnuFileKeluar.Name = "mnuFileKeluar"
        Me.mnuFileKeluar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.mnuFileKeluar.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileKeluar.Text = "&Keluar"
        '
        'mnuWarna
        '
        Me.mnuWarna.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWarnaMerah, Me.mnuWarnaHijau, Me.mnuWarnaBiru, Me.mnuWarnaHitam, Me.ToolStripMenuItem1, Me.mnuWarnaVisibel})
        Me.mnuWarna.Name = "mnuWarna"
        Me.mnuWarna.Size = New System.Drawing.Size(53, 20)
        Me.mnuWarna.Text = "&Warna"
        '
        'mnuWarnaMerah
        '
        Me.mnuWarnaMerah.Name = "mnuWarnaMerah"
        Me.mnuWarnaMerah.Size = New System.Drawing.Size(152, 22)
        Me.mnuWarnaMerah.Text = "&Merah"
        '
        'mnuWarnaHijau
        '
        Me.mnuWarnaHijau.Name = "mnuWarnaHijau"
        Me.mnuWarnaHijau.Size = New System.Drawing.Size(152, 22)
        Me.mnuWarnaHijau.Text = "&Hijau"
        '
        'mnuWarnaBiru
        '
        Me.mnuWarnaBiru.Name = "mnuWarnaBiru"
        Me.mnuWarnaBiru.Size = New System.Drawing.Size(152, 22)
        Me.mnuWarnaBiru.Text = "&Biru"
        '
        'mnuWarnaHitam
        '
        Me.mnuWarnaHitam.Name = "mnuWarnaHitam"
        Me.mnuWarnaHitam.Size = New System.Drawing.Size(152, 22)
        Me.mnuWarnaHitam.Text = "H&itam"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuWarnaVisibel
        '
        Me.mnuWarnaVisibel.Checked = True
        Me.mnuWarnaVisibel.CheckOnClick = True
        Me.mnuWarnaVisibel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuWarnaVisibel.Name = "mnuWarnaVisibel"
        Me.mnuWarnaVisibel.Size = New System.Drawing.Size(152, 22)
        Me.mnuWarnaVisibel.Text = "Visibel"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpTentang})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "H&elp"
        '
        'mnuHelpTentang
        '
        Me.mnuHelpTentang.Name = "mnuHelpTentang"
        Me.mnuHelpTentang.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpTentang.Text = "&Tentang"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.labelPesan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Demo Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelPesan As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWarna As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWarnaMerah As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWarnaHijau As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWarnaBiru As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWarnaHitam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuWarnaVisibel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpTentang As System.Windows.Forms.ToolStripMenuItem

End Class
