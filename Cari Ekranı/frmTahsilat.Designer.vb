<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTahsilat
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
        Me.dgvTahsilat = New System.Windows.Forms.DataGridView()
        Me.tcTahsilat = New System.Windows.Forms.TabControl()
        Me.tpListe = New System.Windows.Forms.TabPage()
        Me.tpDetay = New System.Windows.Forms.TabPage()
        Me.gbBelgeBilgileri = New System.Windows.Forms.GroupBox()
        Me.dtpTarih = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBelgeTipi = New System.Windows.Forms.ComboBox()
        Me.lblTarih = New System.Windows.Forms.Label()
        Me.lblBelgeTipi = New System.Windows.Forms.Label()
        Me.lblBelgeSeri = New System.Windows.Forms.Label()
        Me.txtBelgeSeri = New System.Windows.Forms.TextBox()
        Me.txtBelgeNo = New System.Windows.Forms.TextBox()
        Me.lblAciklama = New System.Windows.Forms.Label()
        Me.txtAciklama = New System.Windows.Forms.TextBox()
        Me.gbBakiye = New System.Windows.Forms.GroupBox()
        Me.lblBakiye = New System.Windows.Forms.Label()
        Me.txtBakiye = New System.Windows.Forms.TextBox()
        Me.lblAlacak = New System.Windows.Forms.Label()
        Me.txtAlacak = New System.Windows.Forms.TextBox()
        Me.lblBorc = New System.Windows.Forms.Label()
        Me.txtBorc = New System.Windows.Forms.TextBox()
        Me.gbTutar = New System.Windows.Forms.GroupBox()
        Me.lblKasaKodu = New System.Windows.Forms.Label()
        Me.txtKasaKodu = New System.Windows.Forms.TextBox()
        Me.lblTutar = New System.Windows.Forms.Label()
        Me.txtTutar = New System.Windows.Forms.TextBox()
        Me.btnYeniKayit = New System.Windows.Forms.Button()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.lblKod = New System.Windows.Forms.Label()
        Me.txtKod = New System.Windows.Forms.TextBox()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.btnGetir = New System.Windows.Forms.Button()
        CType(Me.dgvTahsilat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcTahsilat.SuspendLayout()
        Me.tpListe.SuspendLayout()
        Me.tpDetay.SuspendLayout()
        Me.gbBelgeBilgileri.SuspendLayout()
        Me.gbBakiye.SuspendLayout()
        Me.gbTutar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTahsilat
        '
        Me.dgvTahsilat.AllowUserToAddRows = False
        Me.dgvTahsilat.AllowUserToDeleteRows = False
        Me.dgvTahsilat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTahsilat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTahsilat.Location = New System.Drawing.Point(3, 3)
        Me.dgvTahsilat.Name = "dgvTahsilat"
        Me.dgvTahsilat.Size = New System.Drawing.Size(655, 450)
        Me.dgvTahsilat.TabIndex = 61
        '
        'tcTahsilat
        '
        Me.tcTahsilat.Controls.Add(Me.tpListe)
        Me.tcTahsilat.Controls.Add(Me.tpDetay)
        Me.tcTahsilat.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tcTahsilat.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tcTahsilat.Location = New System.Drawing.Point(0, 73)
        Me.tcTahsilat.Name = "tcTahsilat"
        Me.tcTahsilat.SelectedIndex = 0
        Me.tcTahsilat.Size = New System.Drawing.Size(669, 486)
        Me.tcTahsilat.TabIndex = 62
        '
        'tpListe
        '
        Me.tpListe.Controls.Add(Me.dgvTahsilat)
        Me.tpListe.Location = New System.Drawing.Point(4, 26)
        Me.tpListe.Name = "tpListe"
        Me.tpListe.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListe.Size = New System.Drawing.Size(661, 456)
        Me.tpListe.TabIndex = 0
        Me.tpListe.Text = "Liste"
        Me.tpListe.UseVisualStyleBackColor = True
        '
        'tpDetay
        '
        Me.tpDetay.Controls.Add(Me.gbBelgeBilgileri)
        Me.tpDetay.Controls.Add(Me.gbBakiye)
        Me.tpDetay.Controls.Add(Me.gbTutar)
        Me.tpDetay.Location = New System.Drawing.Point(4, 26)
        Me.tpDetay.Name = "tpDetay"
        Me.tpDetay.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDetay.Size = New System.Drawing.Size(661, 456)
        Me.tpDetay.TabIndex = 1
        Me.tpDetay.Text = "Detay"
        Me.tpDetay.UseVisualStyleBackColor = True
        '
        'gbBelgeBilgileri
        '
        Me.gbBelgeBilgileri.BackColor = System.Drawing.Color.LightCyan
        Me.gbBelgeBilgileri.Controls.Add(Me.dtpTarih)
        Me.gbBelgeBilgileri.Controls.Add(Me.Label1)
        Me.gbBelgeBilgileri.Controls.Add(Me.cmbBelgeTipi)
        Me.gbBelgeBilgileri.Controls.Add(Me.lblTarih)
        Me.gbBelgeBilgileri.Controls.Add(Me.lblBelgeTipi)
        Me.gbBelgeBilgileri.Controls.Add(Me.lblBelgeSeri)
        Me.gbBelgeBilgileri.Controls.Add(Me.txtBelgeSeri)
        Me.gbBelgeBilgileri.Controls.Add(Me.txtBelgeNo)
        Me.gbBelgeBilgileri.Controls.Add(Me.lblAciklama)
        Me.gbBelgeBilgileri.Controls.Add(Me.txtAciklama)
        Me.gbBelgeBilgileri.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbBelgeBilgileri.Location = New System.Drawing.Point(6, 6)
        Me.gbBelgeBilgileri.Name = "gbBelgeBilgileri"
        Me.gbBelgeBilgileri.Size = New System.Drawing.Size(404, 336)
        Me.gbBelgeBilgileri.TabIndex = 61
        Me.gbBelgeBilgileri.TabStop = False
        Me.gbBelgeBilgileri.Text = "Belge Bilgileri"
        '
        'dtpTarih
        '
        Me.dtpTarih.CustomFormat = "yyyy/MM/dd"
        Me.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTarih.Location = New System.Drawing.Point(127, 99)
        Me.dtpTarih.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpTarih.MinDate = New Date(1989, 1, 1, 0, 0, 0, 0)
        Me.dtpTarih.Name = "dtpTarih"
        Me.dtpTarih.Size = New System.Drawing.Size(181, 20)
        Me.dtpTarih.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Belge No *"
        '
        'cmbBelgeTipi
        '
        Me.cmbBelgeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBelgeTipi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbBelgeTipi.FormattingEnabled = True
        Me.cmbBelgeTipi.Items.AddRange(New Object() {"TAHSİLAT", "TEDİYE"})
        Me.cmbBelgeTipi.Location = New System.Drawing.Point(127, 18)
        Me.cmbBelgeTipi.Name = "cmbBelgeTipi"
        Me.cmbBelgeTipi.Size = New System.Drawing.Size(82, 23)
        Me.cmbBelgeTipi.TabIndex = 51
        Me.cmbBelgeTipi.TabStop = False
        '
        'lblTarih
        '
        Me.lblTarih.AutoSize = True
        Me.lblTarih.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTarih.Location = New System.Drawing.Point(72, 101)
        Me.lblTarih.Name = "lblTarih"
        Me.lblTarih.Size = New System.Drawing.Size(49, 17)
        Me.lblTarih.TabIndex = 50
        Me.lblTarih.Text = "Tarih *"
        '
        'lblBelgeTipi
        '
        Me.lblBelgeTipi.AutoSize = True
        Me.lblBelgeTipi.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBelgeTipi.Location = New System.Drawing.Point(40, 19)
        Me.lblBelgeTipi.Name = "lblBelgeTipi"
        Me.lblBelgeTipi.Size = New System.Drawing.Size(81, 17)
        Me.lblBelgeTipi.TabIndex = 32
        Me.lblBelgeTipi.Text = "Belge Tipi *"
        '
        'lblBelgeSeri
        '
        Me.lblBelgeSeri.AutoSize = True
        Me.lblBelgeSeri.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBelgeSeri.Location = New System.Drawing.Point(36, 47)
        Me.lblBelgeSeri.Name = "lblBelgeSeri"
        Me.lblBelgeSeri.Size = New System.Drawing.Size(85, 17)
        Me.lblBelgeSeri.TabIndex = 35
        Me.lblBelgeSeri.Text = "Belge Seri *"
        '
        'txtBelgeSeri
        '
        Me.txtBelgeSeri.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtBelgeSeri.Location = New System.Drawing.Point(127, 47)
        Me.txtBelgeSeri.MaxLength = 10
        Me.txtBelgeSeri.Name = "txtBelgeSeri"
        Me.txtBelgeSeri.Size = New System.Drawing.Size(26, 20)
        Me.txtBelgeSeri.TabIndex = 33
        '
        'txtBelgeNo
        '
        Me.txtBelgeNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtBelgeNo.Location = New System.Drawing.Point(127, 73)
        Me.txtBelgeNo.MaxLength = 4
        Me.txtBelgeNo.Name = "txtBelgeNo"
        Me.txtBelgeNo.Size = New System.Drawing.Size(101, 20)
        Me.txtBelgeNo.TabIndex = 37
        '
        'lblAciklama
        '
        Me.lblAciklama.AutoSize = True
        Me.lblAciklama.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAciklama.Location = New System.Drawing.Point(54, 125)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(67, 17)
        Me.lblAciklama.TabIndex = 47
        Me.lblAciklama.Text = "Açıklama"
        '
        'txtAciklama
        '
        Me.txtAciklama.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAciklama.Location = New System.Drawing.Point(127, 125)
        Me.txtAciklama.MaxLength = 10
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(258, 63)
        Me.txtAciklama.TabIndex = 30
        '
        'gbBakiye
        '
        Me.gbBakiye.BackColor = System.Drawing.Color.LightCyan
        Me.gbBakiye.Controls.Add(Me.lblBakiye)
        Me.gbBakiye.Controls.Add(Me.txtBakiye)
        Me.gbBakiye.Controls.Add(Me.lblAlacak)
        Me.gbBakiye.Controls.Add(Me.txtAlacak)
        Me.gbBakiye.Controls.Add(Me.lblBorc)
        Me.gbBakiye.Controls.Add(Me.txtBorc)
        Me.gbBakiye.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbBakiye.Location = New System.Drawing.Point(416, 177)
        Me.gbBakiye.Name = "gbBakiye"
        Me.gbBakiye.Size = New System.Drawing.Size(237, 165)
        Me.gbBakiye.TabIndex = 63
        Me.gbBakiye.TabStop = False
        Me.gbBakiye.Text = "Bakiye"
        '
        'lblBakiye
        '
        Me.lblBakiye.AutoSize = True
        Me.lblBakiye.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBakiye.Location = New System.Drawing.Point(15, 74)
        Me.lblBakiye.Name = "lblBakiye"
        Me.lblBakiye.Size = New System.Drawing.Size(55, 18)
        Me.lblBakiye.TabIndex = 50
        Me.lblBakiye.Text = "Bakiye"
        '
        'txtBakiye
        '
        Me.txtBakiye.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtBakiye.Location = New System.Drawing.Point(72, 74)
        Me.txtBakiye.MaxLength = 4
        Me.txtBakiye.Name = "txtBakiye"
        Me.txtBakiye.ReadOnly = True
        Me.txtBakiye.Size = New System.Drawing.Size(132, 20)
        Me.txtBakiye.TabIndex = 49
        '
        'lblAlacak
        '
        Me.lblAlacak.AutoSize = True
        Me.lblAlacak.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAlacak.Location = New System.Drawing.Point(15, 50)
        Me.lblAlacak.Name = "lblAlacak"
        Me.lblAlacak.Size = New System.Drawing.Size(51, 17)
        Me.lblAlacak.TabIndex = 48
        Me.lblAlacak.Text = "Alacak"
        '
        'txtAlacak
        '
        Me.txtAlacak.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAlacak.Location = New System.Drawing.Point(72, 48)
        Me.txtAlacak.MaxLength = 4
        Me.txtAlacak.Name = "txtAlacak"
        Me.txtAlacak.ReadOnly = True
        Me.txtAlacak.Size = New System.Drawing.Size(132, 20)
        Me.txtAlacak.TabIndex = 46
        '
        'lblBorc
        '
        Me.lblBorc.AutoSize = True
        Me.lblBorc.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBorc.Location = New System.Drawing.Point(27, 22)
        Me.lblBorc.Name = "lblBorc"
        Me.lblBorc.Size = New System.Drawing.Size(39, 17)
        Me.lblBorc.TabIndex = 44
        Me.lblBorc.Text = "Borç"
        '
        'txtBorc
        '
        Me.txtBorc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtBorc.Location = New System.Drawing.Point(72, 22)
        Me.txtBorc.MaxLength = 4
        Me.txtBorc.Name = "txtBorc"
        Me.txtBorc.ReadOnly = True
        Me.txtBorc.Size = New System.Drawing.Size(132, 20)
        Me.txtBorc.TabIndex = 42
        '
        'gbTutar
        '
        Me.gbTutar.BackColor = System.Drawing.Color.LightCyan
        Me.gbTutar.Controls.Add(Me.lblKasaKodu)
        Me.gbTutar.Controls.Add(Me.txtKasaKodu)
        Me.gbTutar.Controls.Add(Me.lblTutar)
        Me.gbTutar.Controls.Add(Me.txtTutar)
        Me.gbTutar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbTutar.Location = New System.Drawing.Point(416, 6)
        Me.gbTutar.Name = "gbTutar"
        Me.gbTutar.Size = New System.Drawing.Size(237, 165)
        Me.gbTutar.TabIndex = 62
        Me.gbTutar.TabStop = False
        Me.gbTutar.Text = "Tutar"
        '
        'lblKasaKodu
        '
        Me.lblKasaKodu.AutoSize = True
        Me.lblKasaKodu.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKasaKodu.Location = New System.Drawing.Point(21, 25)
        Me.lblKasaKodu.Name = "lblKasaKodu"
        Me.lblKasaKodu.Size = New System.Drawing.Size(80, 17)
        Me.lblKasaKodu.TabIndex = 36
        Me.lblKasaKodu.Text = "Kasa Kodu"
        '
        'txtKasaKodu
        '
        Me.txtKasaKodu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKasaKodu.Location = New System.Drawing.Point(107, 25)
        Me.txtKasaKodu.MaxLength = 26
        Me.txtKasaKodu.Name = "txtKasaKodu"
        Me.txtKasaKodu.Size = New System.Drawing.Size(97, 20)
        Me.txtKasaKodu.TabIndex = 55
        '
        'lblTutar
        '
        Me.lblTutar.AutoSize = True
        Me.lblTutar.BackColor = System.Drawing.Color.LightCyan
        Me.lblTutar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTutar.Location = New System.Drawing.Point(29, 53)
        Me.lblTutar.Name = "lblTutar"
        Me.lblTutar.Size = New System.Drawing.Size(72, 17)
        Me.lblTutar.TabIndex = 57
        Me.lblTutar.Text = "Tutar (TL)"
        '
        'txtTutar
        '
        Me.txtTutar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTutar.Location = New System.Drawing.Point(107, 51)
        Me.txtTutar.MaxLength = 4
        Me.txtTutar.Name = "txtTutar"
        Me.txtTutar.Size = New System.Drawing.Size(97, 20)
        Me.txtTutar.TabIndex = 56
        '
        'btnYeniKayit
        '
        Me.btnYeniKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnYeniKayit.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnYeniKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYeniKayit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYeniKayit.Image = Global.Cari_Ekranı.My.Resources.Resources._283_notebook1
        Me.btnYeniKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYeniKayit.Location = New System.Drawing.Point(287, 12)
        Me.btnYeniKayit.Name = "btnYeniKayit"
        Me.btnYeniKayit.Size = New System.Drawing.Size(97, 33)
        Me.btnYeniKayit.TabIndex = 71
        Me.btnYeniKayit.Text = "Yeni Kayıt"
        Me.btnYeniKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnYeniKayit.UseVisualStyleBackColor = True
        '
        'btnSil
        '
        Me.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSil.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSil.Image = Global.Cari_Ekranı.My.Resources.Resources._058_error1
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSil.Location = New System.Drawing.Point(493, 12)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(70, 33)
        Me.btnSil.TabIndex = 70
        Me.btnSil.Text = "Sil"
        Me.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSil.UseVisualStyleBackColor = True
        '
        'btnKaydet
        '
        Me.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.Image = Global.Cari_Ekranı.My.Resources.Resources._022_save1
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaydet.Location = New System.Drawing.Point(390, 12)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(97, 33)
        Me.btnKaydet.TabIndex = 69
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKaydet.UseVisualStyleBackColor = True
        '
        'btnCikis
        '
        Me.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCikis.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCikis.Image = Global.Cari_Ekranı.My.Resources.Resources._321_exit1
        Me.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCikis.Location = New System.Drawing.Point(569, 12)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(88, 33)
        Me.btnCikis.TabIndex = 68
        Me.btnCikis.Text = "Çıkış"
        Me.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCikis.UseVisualStyleBackColor = True
        '
        'lblKod
        '
        Me.lblKod.AutoSize = True
        Me.lblKod.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKod.Location = New System.Drawing.Point(17, 19)
        Me.lblKod.Name = "lblKod"
        Me.lblKod.Size = New System.Drawing.Size(44, 17)
        Me.lblKod.TabIndex = 72
        Me.lblKod.Text = "Kod *"
        '
        'txtKod
        '
        Me.txtKod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKod.Location = New System.Drawing.Point(67, 19)
        Me.txtKod.MaxLength = 50
        Me.txtKod.Name = "txtKod"
        Me.txtKod.Size = New System.Drawing.Size(132, 20)
        Me.txtKod.TabIndex = 75
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAd.Location = New System.Drawing.Point(36, 45)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(25, 17)
        Me.lblAd.TabIndex = 74
        Me.lblAd.Text = "Ad"
        '
        'txtAd
        '
        Me.txtAd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAd.Location = New System.Drawing.Point(67, 45)
        Me.txtAd.MaxLength = 3
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(202, 20)
        Me.txtAd.TabIndex = 73
        '
        'btnGetir
        '
        Me.btnGetir.BackColor = System.Drawing.Color.Transparent
        Me.btnGetir.BackgroundImage = Global.Cari_Ekranı.My.Resources.Resources._313_search1
        Me.btnGetir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGetir.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnGetir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGetir.Location = New System.Drawing.Point(205, 16)
        Me.btnGetir.Name = "btnGetir"
        Me.btnGetir.Size = New System.Drawing.Size(24, 24)
        Me.btnGetir.TabIndex = 53
        Me.btnGetir.UseVisualStyleBackColor = False
        '
        'frmTahsilat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(669, 559)
        Me.Controls.Add(Me.btnGetir)
        Me.Controls.Add(Me.lblKod)
        Me.Controls.Add(Me.txtKod)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.btnYeniKayit)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.tcTahsilat)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTahsilat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tahsilat Makbuzu Girişi"
        CType(Me.dgvTahsilat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcTahsilat.ResumeLayout(False)
        Me.tpListe.ResumeLayout(False)
        Me.tpDetay.ResumeLayout(False)
        Me.gbBelgeBilgileri.ResumeLayout(False)
        Me.gbBelgeBilgileri.PerformLayout()
        Me.gbBakiye.ResumeLayout(False)
        Me.gbBakiye.PerformLayout()
        Me.gbTutar.ResumeLayout(False)
        Me.gbTutar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTahsilat As DataGridView
    Friend WithEvents tcTahsilat As TabControl
    Friend WithEvents tpListe As TabPage
    Friend WithEvents tpDetay As TabPage
    Friend WithEvents gbBelgeBilgileri As GroupBox
    Friend WithEvents lblBelgeTipi As Label
    Friend WithEvents lblBelgeSeri As Label
    Friend WithEvents txtBelgeSeri As TextBox
    Friend WithEvents txtBelgeNo As TextBox
    Friend WithEvents lblAciklama As Label
    Friend WithEvents txtAciklama As TextBox
    Friend WithEvents gbBakiye As GroupBox
    Friend WithEvents lblBakiye As Label
    Friend WithEvents txtBakiye As TextBox
    Friend WithEvents lblAlacak As Label
    Friend WithEvents txtAlacak As TextBox
    Friend WithEvents lblBorc As Label
    Friend WithEvents txtBorc As TextBox
    Friend WithEvents gbTutar As GroupBox
    Friend WithEvents lblKasaKodu As Label
    Friend WithEvents txtKasaKodu As TextBox
    Friend WithEvents lblTutar As Label
    Friend WithEvents txtTutar As TextBox
    Friend WithEvents btnYeniKayit As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnCikis As Button
    Friend WithEvents cmbBelgeTipi As ComboBox
    Friend WithEvents lblTarih As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblKod As Label
    Friend WithEvents txtKod As TextBox
    Friend WithEvents lblAd As Label
    Friend WithEvents txtAd As TextBox
    Friend WithEvents btnGetir As Button
    Friend WithEvents dtpTarih As DateTimePicker
End Class
