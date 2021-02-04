<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnaMenu
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ana Bilgi Girişi")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ana Bilgi (Katalog)")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ana Bilgi (Katalog - Yatay)")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ana Bilgi", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tahsilat Makbuzu Girişi")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tediye Makbuzu Girişi")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Havale Girişi")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hareketler", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Me.msAnaMenu = New System.Windows.Forms.MenuStrip()
        Me.tsAnaBilgi = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAnaBilgiGirisi = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsProgramdanCikis = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsYardim = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsHakkinda = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssAnaMenu = New System.Windows.Forms.StatusStrip()
        Me.tsDurum = New System.Windows.Forms.ToolStripStatusLabel()
        Me.spYanMenu = New System.Windows.Forms.Splitter()
        Me.tvYanMenu = New System.Windows.Forms.TreeView()
        Me.cmbYanMenu = New System.Windows.Forms.ComboBox()
        Me.msAnaMenu.SuspendLayout()
        Me.ssAnaMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'msAnaMenu
        '
        Me.msAnaMenu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.msAnaMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAnaBilgi, Me.tsYardim})
        Me.msAnaMenu.Location = New System.Drawing.Point(0, 0)
        Me.msAnaMenu.Name = "msAnaMenu"
        Me.msAnaMenu.Size = New System.Drawing.Size(919, 24)
        Me.msAnaMenu.TabIndex = 1
        Me.msAnaMenu.Text = "MenuStrip1"
        '
        'tsAnaBilgi
        '
        Me.tsAnaBilgi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAnaBilgiGirisi, Me.tsProgramdanCikis})
        Me.tsAnaBilgi.Name = "tsAnaBilgi"
        Me.tsAnaBilgi.Size = New System.Drawing.Size(67, 20)
        Me.tsAnaBilgi.Text = "Ana Bilgi"
        '
        'tsAnaBilgiGirisi
        '
        Me.tsAnaBilgiGirisi.Name = "tsAnaBilgiGirisi"
        Me.tsAnaBilgiGirisi.Size = New System.Drawing.Size(180, 22)
        Me.tsAnaBilgiGirisi.Text = "Ana Bilgi Girişi"
        '
        'tsProgramdanCikis
        '
        Me.tsProgramdanCikis.Name = "tsProgramdanCikis"
        Me.tsProgramdanCikis.Size = New System.Drawing.Size(180, 22)
        Me.tsProgramdanCikis.Text = "Programdan Çıkış"
        '
        'tsYardim
        '
        Me.tsYardim.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsHakkinda})
        Me.tsYardim.Name = "tsYardim"
        Me.tsYardim.Size = New System.Drawing.Size(57, 20)
        Me.tsYardim.Text = "Yardım"
        '
        'tsHakkinda
        '
        Me.tsHakkinda.Name = "tsHakkinda"
        Me.tsHakkinda.Size = New System.Drawing.Size(180, 22)
        Me.tsHakkinda.Text = "Hakkında"
        '
        'ssAnaMenu
        '
        Me.ssAnaMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDurum})
        Me.ssAnaMenu.Location = New System.Drawing.Point(0, 716)
        Me.ssAnaMenu.Name = "ssAnaMenu"
        Me.ssAnaMenu.Size = New System.Drawing.Size(919, 22)
        Me.ssAnaMenu.TabIndex = 2
        Me.ssAnaMenu.Text = "StatusStrip1"
        '
        'tsDurum
        '
        Me.tsDurum.BackColor = System.Drawing.SystemColors.Control
        Me.tsDurum.Name = "tsDurum"
        Me.tsDurum.Size = New System.Drawing.Size(44, 17)
        Me.tsDurum.Text = "Durum"
        '
        'spYanMenu
        '
        Me.spYanMenu.BackColor = System.Drawing.Color.MediumTurquoise
        Me.spYanMenu.Cursor = System.Windows.Forms.Cursors.Default
        Me.spYanMenu.Location = New System.Drawing.Point(0, 24)
        Me.spYanMenu.Name = "spYanMenu"
        Me.spYanMenu.Size = New System.Drawing.Size(242, 692)
        Me.spYanMenu.TabIndex = 4
        Me.spYanMenu.TabStop = False
        '
        'tvYanMenu
        '
        Me.tvYanMenu.BackColor = System.Drawing.Color.LightCyan
        Me.tvYanMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvYanMenu.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tvYanMenu.Location = New System.Drawing.Point(12, 75)
        Me.tvYanMenu.Name = "tvYanMenu"
        TreeNode1.Name = "nodeAnaBilgiGirisi"
        TreeNode1.Tag = "01"
        TreeNode1.Text = "Ana Bilgi Girişi"
        TreeNode2.Name = "nodeAnaBilgiKatalog"
        TreeNode2.Tag = "02"
        TreeNode2.Text = "Ana Bilgi (Katalog)"
        TreeNode3.Name = "nodeAnaBilgiYKatalog"
        TreeNode3.Tag = "03"
        TreeNode3.Text = "Ana Bilgi (Katalog - Yatay)"
        TreeNode4.Name = "nodeAnaBilgi"
        TreeNode4.Tag = "0"
        TreeNode4.Text = "Ana Bilgi"
        TreeNode5.Name = "nodeTahsilat"
        TreeNode5.Tag = "11"
        TreeNode5.Text = "Tahsilat Makbuzu Girişi"
        TreeNode6.Name = "nodeTediye"
        TreeNode6.Tag = "12"
        TreeNode6.Text = "Tediye Makbuzu Girişi"
        TreeNode7.Name = "nodeHavale"
        TreeNode7.Tag = "13"
        TreeNode7.Text = "Havale Girişi"
        TreeNode8.Name = "nodeHareketler"
        TreeNode8.Tag = "1"
        TreeNode8.Text = "Hareketler"
        Me.tvYanMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8})
        Me.tvYanMenu.Size = New System.Drawing.Size(216, 155)
        Me.tvYanMenu.TabIndex = 6
        Me.tvYanMenu.TabStop = False
        '
        'cmbYanMenu
        '
        Me.cmbYanMenu.BackColor = System.Drawing.Color.LightCyan
        Me.cmbYanMenu.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbYanMenu.FormattingEnabled = True
        Me.cmbYanMenu.Items.AddRange(New Object() {"CARİ", "DÖVİZ"})
        Me.cmbYanMenu.Location = New System.Drawing.Point(12, 42)
        Me.cmbYanMenu.Name = "cmbYanMenu"
        Me.cmbYanMenu.Size = New System.Drawing.Size(216, 25)
        Me.cmbYanMenu.TabIndex = 8
        '
        'frmAnaMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = Global.Cari_Ekranı.My.Resources.Resources.mega_yazılım_logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(919, 738)
        Me.Controls.Add(Me.cmbYanMenu)
        Me.Controls.Add(Me.tvYanMenu)
        Me.Controls.Add(Me.spYanMenu)
        Me.Controls.Add(Me.ssAnaMenu)
        Me.Controls.Add(Me.msAnaMenu)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msAnaMenu
        Me.Name = "frmAnaMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Ekranı Ana Menü"
        Me.msAnaMenu.ResumeLayout(False)
        Me.msAnaMenu.PerformLayout()
        Me.ssAnaMenu.ResumeLayout(False)
        Me.ssAnaMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msAnaMenu As MenuStrip
    Friend WithEvents tsAnaBilgi As ToolStripMenuItem
    Friend WithEvents tsAnaBilgiGirisi As ToolStripMenuItem
    Friend WithEvents tsProgramdanCikis As ToolStripMenuItem
    Friend WithEvents tsYardim As ToolStripMenuItem
    Friend WithEvents tsHakkinda As ToolStripMenuItem
    Friend WithEvents ssAnaMenu As StatusStrip
    Friend WithEvents tsDurum As ToolStripStatusLabel
    Friend WithEvents spYanMenu As Splitter
    Friend WithEvents tvYanMenu As TreeView
    Friend WithEvents cmbYanMenu As ComboBox
End Class
