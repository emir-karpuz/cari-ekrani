<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCariGirisi
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
        Me.tcCariAnaBilgi = New System.Windows.Forms.TabControl()
        Me.tpListe = New System.Windows.Forms.TabPage()
        Me.gbDetay = New System.Windows.Forms.GroupBox()
        Me.dgwKayitlar = New System.Windows.Forms.DataGridView()
        Me.tpDetay = New System.Windows.Forms.TabPage()
        Me.gbIletisim = New System.Windows.Forms.GroupBox()
        Me.lblCepNo = New System.Windows.Forms.Label()
        Me.txtCepNo = New System.Windows.Forms.TextBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.lblUlke = New System.Windows.Forms.Label()
        Me.txtUlke = New System.Windows.Forms.TextBox()
        Me.lblSehir = New System.Windows.Forms.Label()
        Me.cmbSehir = New System.Windows.Forms.ComboBox()
        Me.lblSemt = New System.Windows.Forms.Label()
        Me.txtSemt = New System.Windows.Forms.TextBox()
        Me.lblKapiNo = New System.Windows.Forms.Label()
        Me.txtKapiNo = New System.Windows.Forms.TextBox()
        Me.lblPostaKodu = New System.Windows.Forms.Label()
        Me.txtPostaKodu = New System.Windows.Forms.TextBox()
        Me.lblAdres = New System.Windows.Forms.Label()
        Me.txtAdres = New System.Windows.Forms.TextBox()
        Me.gbOdmBilg3 = New System.Windows.Forms.GroupBox()
        Me.gbOdmBilg1 = New System.Windows.Forms.GroupBox()
        Me.lblHesapNo = New System.Windows.Forms.Label()
        Me.lblOdemeNotu = New System.Windows.Forms.Label()
        Me.txtHesapNo = New System.Windows.Forms.TextBox()
        Me.txtOdemeNotu = New System.Windows.Forms.TextBox()
        Me.lblSubeKodu = New System.Windows.Forms.Label()
        Me.lblIskonto = New System.Windows.Forms.Label()
        Me.txtSubeKodu = New System.Windows.Forms.TextBox()
        Me.txtIskonto = New System.Windows.Forms.TextBox()
        Me.lblBankaKodu = New System.Windows.Forms.Label()
        Me.lblMuhHesapNo = New System.Windows.Forms.Label()
        Me.txtBankaKodu = New System.Windows.Forms.TextBox()
        Me.txtMuhHesapNo = New System.Windows.Forms.TextBox()
        Me.lblIBAN = New System.Windows.Forms.Label()
        Me.lblVergiNo = New System.Windows.Forms.Label()
        Me.txtIBAN = New System.Windows.Forms.TextBox()
        Me.txtVergiNo = New System.Windows.Forms.TextBox()
        Me.lblTC = New System.Windows.Forms.Label()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.lblVergiDaire = New System.Windows.Forms.Label()
        Me.txtVergiDaire = New System.Windows.Forms.TextBox()
        Me.txtKod = New System.Windows.Forms.TextBox()
        Me.lblKod = New System.Windows.Forms.Label()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnGetir = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.btnYeniKayit = New System.Windows.Forms.Button()
        Me.tcCariAnaBilgi.SuspendLayout()
        Me.tpListe.SuspendLayout()
        Me.gbDetay.SuspendLayout()
        CType(Me.dgwKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDetay.SuspendLayout()
        Me.gbIletisim.SuspendLayout()
        Me.gbOdmBilg1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcCariAnaBilgi
        '
        Me.tcCariAnaBilgi.Controls.Add(Me.tpListe)
        Me.tcCariAnaBilgi.Controls.Add(Me.tpDetay)
        Me.tcCariAnaBilgi.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tcCariAnaBilgi.Location = New System.Drawing.Point(12, 76)
        Me.tcCariAnaBilgi.Name = "tcCariAnaBilgi"
        Me.tcCariAnaBilgi.SelectedIndex = 0
        Me.tcCariAnaBilgi.Size = New System.Drawing.Size(648, 589)
        Me.tcCariAnaBilgi.TabIndex = 0
        '
        'tpListe
        '
        Me.tpListe.BackColor = System.Drawing.Color.White
        Me.tpListe.Controls.Add(Me.gbDetay)
        Me.tpListe.Location = New System.Drawing.Point(4, 27)
        Me.tpListe.Name = "tpListe"
        Me.tpListe.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListe.Size = New System.Drawing.Size(640, 558)
        Me.tpListe.TabIndex = 0
        Me.tpListe.Text = "Liste"
        '
        'gbDetay
        '
        Me.gbDetay.BackColor = System.Drawing.Color.LightCyan
        Me.gbDetay.Controls.Add(Me.dgwKayitlar)
        Me.gbDetay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbDetay.Location = New System.Drawing.Point(9, 6)
        Me.gbDetay.Name = "gbDetay"
        Me.gbDetay.Size = New System.Drawing.Size(628, 547)
        Me.gbDetay.TabIndex = 4
        Me.gbDetay.TabStop = False
        Me.gbDetay.Text = "Kayıtlar"
        '
        'dgwKayitlar
        '
        Me.dgwKayitlar.AllowUserToAddRows = False
        Me.dgwKayitlar.AllowUserToDeleteRows = False
        Me.dgwKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwKayitlar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwKayitlar.Location = New System.Drawing.Point(3, 16)
        Me.dgwKayitlar.Name = "dgwKayitlar"
        Me.dgwKayitlar.ReadOnly = True
        Me.dgwKayitlar.Size = New System.Drawing.Size(622, 528)
        Me.dgwKayitlar.TabIndex = 0
        '
        'tpDetay
        '
        Me.tpDetay.BackColor = System.Drawing.Color.White
        Me.tpDetay.Controls.Add(Me.gbIletisim)
        Me.tpDetay.Controls.Add(Me.gbOdmBilg3)
        Me.tpDetay.Controls.Add(Me.gbOdmBilg1)
        Me.tpDetay.Location = New System.Drawing.Point(4, 27)
        Me.tpDetay.Name = "tpDetay"
        Me.tpDetay.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDetay.Size = New System.Drawing.Size(640, 558)
        Me.tpDetay.TabIndex = 1
        Me.tpDetay.Text = "Detay"
        '
        'gbIletisim
        '
        Me.gbIletisim.BackColor = System.Drawing.Color.LightCyan
        Me.gbIletisim.Controls.Add(Me.lblCepNo)
        Me.gbIletisim.Controls.Add(Me.txtCepNo)
        Me.gbIletisim.Controls.Add(Me.lblFax)
        Me.gbIletisim.Controls.Add(Me.txtFax)
        Me.gbIletisim.Controls.Add(Me.lblTelefon)
        Me.gbIletisim.Controls.Add(Me.txtTelefon)
        Me.gbIletisim.Controls.Add(Me.lblUlke)
        Me.gbIletisim.Controls.Add(Me.txtUlke)
        Me.gbIletisim.Controls.Add(Me.lblSehir)
        Me.gbIletisim.Controls.Add(Me.cmbSehir)
        Me.gbIletisim.Controls.Add(Me.lblSemt)
        Me.gbIletisim.Controls.Add(Me.txtSemt)
        Me.gbIletisim.Controls.Add(Me.lblKapiNo)
        Me.gbIletisim.Controls.Add(Me.txtKapiNo)
        Me.gbIletisim.Controls.Add(Me.lblPostaKodu)
        Me.gbIletisim.Controls.Add(Me.txtPostaKodu)
        Me.gbIletisim.Controls.Add(Me.lblAdres)
        Me.gbIletisim.Controls.Add(Me.txtAdres)
        Me.gbIletisim.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbIletisim.Location = New System.Drawing.Point(3, 6)
        Me.gbIletisim.Name = "gbIletisim"
        Me.gbIletisim.Size = New System.Drawing.Size(339, 322)
        Me.gbIletisim.TabIndex = 30
        Me.gbIletisim.TabStop = False
        Me.gbIletisim.Text = "İletişim Bilgileri"
        '
        'lblCepNo
        '
        Me.lblCepNo.AutoSize = True
        Me.lblCepNo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCepNo.Location = New System.Drawing.Point(30, 274)
        Me.lblCepNo.Name = "lblCepNo"
        Me.lblCepNo.Size = New System.Drawing.Size(41, 15)
        Me.lblCepNo.TabIndex = 18
        Me.lblCepNo.Text = "Cep No"
        '
        'txtCepNo
        '
        Me.txtCepNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCepNo.Location = New System.Drawing.Point(77, 272)
        Me.txtCepNo.MaxLength = 10
        Me.txtCepNo.Name = "txtCepNo"
        Me.txtCepNo.Size = New System.Drawing.Size(132, 20)
        Me.txtCepNo.TabIndex = 17
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblFax.Location = New System.Drawing.Point(48, 243)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(23, 15)
        Me.lblFax.TabIndex = 16
        Me.lblFax.Text = "Fax"
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtFax.Location = New System.Drawing.Point(77, 241)
        Me.txtFax.MaxLength = 10
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(132, 20)
        Me.txtFax.TabIndex = 15
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTelefon.Location = New System.Drawing.Point(31, 214)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(40, 15)
        Me.lblTelefon.TabIndex = 14
        Me.lblTelefon.Text = "Telefon"
        '
        'txtTelefon
        '
        Me.txtTelefon.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTelefon.Location = New System.Drawing.Point(77, 212)
        Me.txtTelefon.MaxLength = 10
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(132, 20)
        Me.txtTelefon.TabIndex = 13
        '
        'lblUlke
        '
        Me.lblUlke.AutoSize = True
        Me.lblUlke.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblUlke.Location = New System.Drawing.Point(44, 183)
        Me.lblUlke.Name = "lblUlke"
        Me.lblUlke.Size = New System.Drawing.Size(27, 15)
        Me.lblUlke.TabIndex = 12
        Me.lblUlke.Text = "Ülke"
        '
        'txtUlke
        '
        Me.txtUlke.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtUlke.Location = New System.Drawing.Point(77, 181)
        Me.txtUlke.MaxLength = 20
        Me.txtUlke.Name = "txtUlke"
        Me.txtUlke.Size = New System.Drawing.Size(132, 20)
        Me.txtUlke.TabIndex = 11
        '
        'lblSehir
        '
        Me.lblSehir.AutoSize = True
        Me.lblSehir.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSehir.Location = New System.Drawing.Point(40, 150)
        Me.lblSehir.Name = "lblSehir"
        Me.lblSehir.Size = New System.Drawing.Size(31, 15)
        Me.lblSehir.TabIndex = 9
        Me.lblSehir.Text = "Şehir"
        '
        'cmbSehir
        '
        Me.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSehir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbSehir.FormattingEnabled = True
        Me.cmbSehir.Items.AddRange(New Object() {"ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AMASYA", "ANKARA", "ANTALYA", "ARTVİN", "ARTVİN", "BALIKESİR" & Global.Microsoft.VisualBasic.ChrW(9), "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM ", "DENİZLİ", "DİYARBAKIR", "EDİRNE", "ELAZIĞ", "ERZİNCAN", "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ", "HATAY", "ISPARTA", "MERSİN", "İSTANBUL", "İZMİR", "KARS", "KASTAMONU", "KAYSERİ", "KIRKLARELİ", "KIRŞEHİR", "KOCAELİ", "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "KAHRAMANMARAŞ", "MARDİN", "MUĞLA", "MUŞ", "NEVŞEHİR", "NİĞDE", "ORDU", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS", "TEKİRDAĞ", "TOKAT", "TRABZON", "TUNCELİ", "ŞANLIURFA", "UŞAK", "VAN", "YOZGAT", "ZONGULDAK", "AKSARAY", "BAYBURT", "KARAMAN", "KIRIKKALE", "BATMAN", "ŞIRNAK", "BARTIN", "ARDAHAN", "IĞDIR", "YALOVA", "KARABÜK", "KİLİS", "OSMANİYE", "DÜZCE"})
        Me.cmbSehir.Location = New System.Drawing.Point(77, 148)
        Me.cmbSehir.Name = "cmbSehir"
        Me.cmbSehir.Size = New System.Drawing.Size(132, 22)
        Me.cmbSehir.TabIndex = 10
        '
        'lblSemt
        '
        Me.lblSemt.AutoSize = True
        Me.lblSemt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSemt.Location = New System.Drawing.Point(164, 99)
        Me.lblSemt.Name = "lblSemt"
        Me.lblSemt.Size = New System.Drawing.Size(31, 14)
        Me.lblSemt.TabIndex = 7
        Me.lblSemt.Text = "Semt"
        '
        'txtSemt
        '
        Me.txtSemt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSemt.Location = New System.Drawing.Point(201, 96)
        Me.txtSemt.MaxLength = 20
        Me.txtSemt.Name = "txtSemt"
        Me.txtSemt.Size = New System.Drawing.Size(115, 20)
        Me.txtSemt.TabIndex = 6
        '
        'lblKapiNo
        '
        Me.lblKapiNo.AutoSize = True
        Me.lblKapiNo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKapiNo.Location = New System.Drawing.Point(27, 123)
        Me.lblKapiNo.Name = "lblKapiNo"
        Me.lblKapiNo.Size = New System.Drawing.Size(44, 15)
        Me.lblKapiNo.TabIndex = 5
        Me.lblKapiNo.Text = "Kapı No"
        '
        'txtKapiNo
        '
        Me.txtKapiNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKapiNo.Location = New System.Drawing.Point(77, 121)
        Me.txtKapiNo.MaxLength = 4
        Me.txtKapiNo.Name = "txtKapiNo"
        Me.txtKapiNo.Size = New System.Drawing.Size(48, 20)
        Me.txtKapiNo.TabIndex = 4
        '
        'lblPostaKodu
        '
        Me.lblPostaKodu.AutoSize = True
        Me.lblPostaKodu.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblPostaKodu.Location = New System.Drawing.Point(11, 97)
        Me.lblPostaKodu.Name = "lblPostaKodu"
        Me.lblPostaKodu.Size = New System.Drawing.Size(60, 15)
        Me.lblPostaKodu.TabIndex = 3
        Me.lblPostaKodu.Text = "Posta Kodu"
        '
        'txtPostaKodu
        '
        Me.txtPostaKodu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPostaKodu.Location = New System.Drawing.Point(77, 95)
        Me.txtPostaKodu.MaxLength = 5
        Me.txtPostaKodu.Name = "txtPostaKodu"
        Me.txtPostaKodu.Size = New System.Drawing.Size(68, 20)
        Me.txtPostaKodu.TabIndex = 2
        '
        'lblAdres
        '
        Me.lblAdres.AutoSize = True
        Me.lblAdres.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAdres.Location = New System.Drawing.Point(37, 26)
        Me.lblAdres.Name = "lblAdres"
        Me.lblAdres.Size = New System.Drawing.Size(34, 15)
        Me.lblAdres.TabIndex = 1
        Me.lblAdres.Text = "Adres"
        '
        'txtAdres
        '
        Me.txtAdres.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAdres.Location = New System.Drawing.Point(77, 24)
        Me.txtAdres.MaxLength = 50
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(239, 65)
        Me.txtAdres.TabIndex = 0
        '
        'gbOdmBilg3
        '
        Me.gbOdmBilg3.BackColor = System.Drawing.Color.LightCyan
        Me.gbOdmBilg3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbOdmBilg3.Location = New System.Drawing.Point(3, 334)
        Me.gbOdmBilg3.Name = "gbOdmBilg3"
        Me.gbOdmBilg3.Size = New System.Drawing.Size(634, 218)
        Me.gbOdmBilg3.TabIndex = 29
        Me.gbOdmBilg3.TabStop = False
        Me.gbOdmBilg3.Text = "Ödeme Bilgileri - 2"
        '
        'gbOdmBilg1
        '
        Me.gbOdmBilg1.BackColor = System.Drawing.Color.LightCyan
        Me.gbOdmBilg1.Controls.Add(Me.lblHesapNo)
        Me.gbOdmBilg1.Controls.Add(Me.lblOdemeNotu)
        Me.gbOdmBilg1.Controls.Add(Me.txtHesapNo)
        Me.gbOdmBilg1.Controls.Add(Me.txtOdemeNotu)
        Me.gbOdmBilg1.Controls.Add(Me.lblSubeKodu)
        Me.gbOdmBilg1.Controls.Add(Me.lblIskonto)
        Me.gbOdmBilg1.Controls.Add(Me.txtSubeKodu)
        Me.gbOdmBilg1.Controls.Add(Me.txtIskonto)
        Me.gbOdmBilg1.Controls.Add(Me.lblBankaKodu)
        Me.gbOdmBilg1.Controls.Add(Me.lblMuhHesapNo)
        Me.gbOdmBilg1.Controls.Add(Me.txtBankaKodu)
        Me.gbOdmBilg1.Controls.Add(Me.txtMuhHesapNo)
        Me.gbOdmBilg1.Controls.Add(Me.lblIBAN)
        Me.gbOdmBilg1.Controls.Add(Me.lblVergiNo)
        Me.gbOdmBilg1.Controls.Add(Me.txtIBAN)
        Me.gbOdmBilg1.Controls.Add(Me.txtVergiNo)
        Me.gbOdmBilg1.Controls.Add(Me.lblTC)
        Me.gbOdmBilg1.Controls.Add(Me.txtTC)
        Me.gbOdmBilg1.Controls.Add(Me.lblVergiDaire)
        Me.gbOdmBilg1.Controls.Add(Me.txtVergiDaire)
        Me.gbOdmBilg1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbOdmBilg1.Location = New System.Drawing.Point(348, 6)
        Me.gbOdmBilg1.Name = "gbOdmBilg1"
        Me.gbOdmBilg1.Size = New System.Drawing.Size(286, 322)
        Me.gbOdmBilg1.TabIndex = 4
        Me.gbOdmBilg1.TabStop = False
        Me.gbOdmBilg1.Text = "Ödeme Bilgileri - 1"
        '
        'lblHesapNo
        '
        Me.lblHesapNo.AutoSize = True
        Me.lblHesapNo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblHesapNo.Location = New System.Drawing.Point(39, 269)
        Me.lblHesapNo.Name = "lblHesapNo"
        Me.lblHesapNo.Size = New System.Drawing.Size(51, 15)
        Me.lblHesapNo.TabIndex = 28
        Me.lblHesapNo.Text = "Hesap No"
        '
        'lblOdemeNotu
        '
        Me.lblOdemeNotu.AutoSize = True
        Me.lblOdemeNotu.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblOdemeNotu.Location = New System.Drawing.Point(25, 131)
        Me.lblOdemeNotu.Name = "lblOdemeNotu"
        Me.lblOdemeNotu.Size = New System.Drawing.Size(64, 15)
        Me.lblOdemeNotu.TabIndex = 28
        Me.lblOdemeNotu.Text = "Ödeme Notu"
        '
        'txtHesapNo
        '
        Me.txtHesapNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtHesapNo.Location = New System.Drawing.Point(96, 267)
        Me.txtHesapNo.MaxLength = 4
        Me.txtHesapNo.Name = "txtHesapNo"
        Me.txtHesapNo.Size = New System.Drawing.Size(132, 20)
        Me.txtHesapNo.TabIndex = 27
        '
        'txtOdemeNotu
        '
        Me.txtOdemeNotu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtOdemeNotu.Location = New System.Drawing.Point(97, 128)
        Me.txtOdemeNotu.MaxLength = 50
        Me.txtOdemeNotu.Name = "txtOdemeNotu"
        Me.txtOdemeNotu.Size = New System.Drawing.Size(132, 20)
        Me.txtOdemeNotu.TabIndex = 27
        '
        'lblSubeKodu
        '
        Me.lblSubeKodu.AutoSize = True
        Me.lblSubeKodu.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSubeKodu.Location = New System.Drawing.Point(32, 244)
        Me.lblSubeKodu.Name = "lblSubeKodu"
        Me.lblSubeKodu.Size = New System.Drawing.Size(58, 15)
        Me.lblSubeKodu.TabIndex = 26
        Me.lblSubeKodu.Text = "Şube Kodu"
        '
        'lblIskonto
        '
        Me.lblIskonto.AutoSize = True
        Me.lblIskonto.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblIskonto.Location = New System.Drawing.Point(37, 105)
        Me.lblIskonto.Name = "lblIskonto"
        Me.lblIskonto.Size = New System.Drawing.Size(52, 15)
        Me.lblIskonto.TabIndex = 26
        Me.lblIskonto.Text = "İskonto %"
        '
        'txtSubeKodu
        '
        Me.txtSubeKodu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSubeKodu.Location = New System.Drawing.Point(96, 241)
        Me.txtSubeKodu.MaxLength = 4
        Me.txtSubeKodu.Name = "txtSubeKodu"
        Me.txtSubeKodu.Size = New System.Drawing.Size(40, 20)
        Me.txtSubeKodu.TabIndex = 25
        '
        'txtIskonto
        '
        Me.txtIskonto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtIskonto.Location = New System.Drawing.Point(97, 102)
        Me.txtIskonto.MaxLength = 3
        Me.txtIskonto.Name = "txtIskonto"
        Me.txtIskonto.Size = New System.Drawing.Size(40, 20)
        Me.txtIskonto.TabIndex = 25
        '
        'lblBankaKodu
        '
        Me.lblBankaKodu.AutoSize = True
        Me.lblBankaKodu.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBankaKodu.Location = New System.Drawing.Point(27, 217)
        Me.lblBankaKodu.Name = "lblBankaKodu"
        Me.lblBankaKodu.Size = New System.Drawing.Size(63, 15)
        Me.lblBankaKodu.TabIndex = 24
        Me.lblBankaKodu.Text = "Banka Kodu"
        '
        'lblMuhHesapNo
        '
        Me.lblMuhHesapNo.AutoSize = True
        Me.lblMuhHesapNo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMuhHesapNo.Location = New System.Drawing.Point(14, 79)
        Me.lblMuhHesapNo.Name = "lblMuhHesapNo"
        Me.lblMuhHesapNo.Size = New System.Drawing.Size(74, 15)
        Me.lblMuhHesapNo.TabIndex = 24
        Me.lblMuhHesapNo.Text = "Muh Hesap No"
        '
        'txtBankaKodu
        '
        Me.txtBankaKodu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtBankaKodu.Location = New System.Drawing.Point(96, 215)
        Me.txtBankaKodu.MaxLength = 4
        Me.txtBankaKodu.Name = "txtBankaKodu"
        Me.txtBankaKodu.Size = New System.Drawing.Size(132, 20)
        Me.txtBankaKodu.TabIndex = 23
        '
        'txtMuhHesapNo
        '
        Me.txtMuhHesapNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMuhHesapNo.Location = New System.Drawing.Point(97, 76)
        Me.txtMuhHesapNo.MaxLength = 4
        Me.txtMuhHesapNo.Name = "txtMuhHesapNo"
        Me.txtMuhHesapNo.Size = New System.Drawing.Size(132, 20)
        Me.txtMuhHesapNo.TabIndex = 23
        '
        'lblIBAN
        '
        Me.lblIBAN.AutoSize = True
        Me.lblIBAN.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblIBAN.Location = New System.Drawing.Point(43, 191)
        Me.lblIBAN.Name = "lblIBAN"
        Me.lblIBAN.Size = New System.Drawing.Size(47, 15)
        Me.lblIBAN.TabIndex = 22
        Me.lblIBAN.Text = "IBAN No"
        '
        'lblVergiNo
        '
        Me.lblVergiNo.AutoSize = True
        Me.lblVergiNo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblVergiNo.Location = New System.Drawing.Point(43, 53)
        Me.lblVergiNo.Name = "lblVergiNo"
        Me.lblVergiNo.Size = New System.Drawing.Size(47, 15)
        Me.lblVergiNo.TabIndex = 22
        Me.lblVergiNo.Text = "Vergi No"
        '
        'txtIBAN
        '
        Me.txtIBAN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtIBAN.Location = New System.Drawing.Point(96, 189)
        Me.txtIBAN.MaxLength = 26
        Me.txtIBAN.Name = "txtIBAN"
        Me.txtIBAN.Size = New System.Drawing.Size(132, 20)
        Me.txtIBAN.TabIndex = 21
        '
        'txtVergiNo
        '
        Me.txtVergiNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtVergiNo.Location = New System.Drawing.Point(97, 50)
        Me.txtVergiNo.MaxLength = 10
        Me.txtVergiNo.Name = "txtVergiNo"
        Me.txtVergiNo.Size = New System.Drawing.Size(132, 20)
        Me.txtVergiNo.TabIndex = 21
        '
        'lblTC
        '
        Me.lblTC.AutoSize = True
        Me.lblTC.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTC.Location = New System.Drawing.Point(22, 165)
        Me.lblTC.Name = "lblTC"
        Me.lblTC.Size = New System.Drawing.Size(68, 15)
        Me.lblTC.TabIndex = 20
        Me.lblTC.Text = "TC Kimlik No"
        '
        'txtTC
        '
        Me.txtTC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTC.Location = New System.Drawing.Point(96, 163)
        Me.txtTC.MaxLength = 10
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(132, 20)
        Me.txtTC.TabIndex = 19
        '
        'lblVergiDaire
        '
        Me.lblVergiDaire.AutoSize = True
        Me.lblVergiDaire.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblVergiDaire.Location = New System.Drawing.Point(23, 27)
        Me.lblVergiDaire.Name = "lblVergiDaire"
        Me.lblVergiDaire.Size = New System.Drawing.Size(66, 15)
        Me.lblVergiDaire.TabIndex = 20
        Me.lblVergiDaire.Text = "Vergi Dairesi"
        '
        'txtVergiDaire
        '
        Me.txtVergiDaire.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtVergiDaire.Location = New System.Drawing.Point(97, 24)
        Me.txtVergiDaire.MaxLength = 30
        Me.txtVergiDaire.Name = "txtVergiDaire"
        Me.txtVergiDaire.Size = New System.Drawing.Size(132, 20)
        Me.txtVergiDaire.TabIndex = 19
        '
        'txtKod
        '
        Me.txtKod.Location = New System.Drawing.Point(49, 12)
        Me.txtKod.MaxLength = 8
        Me.txtKod.Name = "txtKod"
        Me.txtKod.Size = New System.Drawing.Size(204, 25)
        Me.txtKod.TabIndex = 1
        '
        'lblKod
        '
        Me.lblKod.AutoSize = True
        Me.lblKod.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKod.ForeColor = System.Drawing.Color.Black
        Me.lblKod.Location = New System.Drawing.Point(13, 17)
        Me.lblKod.Name = "lblKod"
        Me.lblKod.Size = New System.Drawing.Size(30, 15)
        Me.lblKod.TabIndex = 2
        Me.lblKod.Text = "Kod*"
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAd.ForeColor = System.Drawing.Color.Black
        Me.lblAd.Location = New System.Drawing.Point(23, 50)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(20, 15)
        Me.lblAd.TabIndex = 4
        Me.lblAd.Text = "Ad"
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(49, 45)
        Me.txtAd.MaxLength = 50
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(204, 25)
        Me.txtAd.TabIndex = 3
        '
        'btnSil
        '
        Me.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSil.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSil.Image = Global.Cari_Ekranı.My.Resources.Resources._058_error1
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSil.Location = New System.Drawing.Point(496, 12)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(70, 33)
        Me.btnSil.TabIndex = 9
        Me.btnSil.Text = "Sil"
        Me.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSil.UseVisualStyleBackColor = True
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
        Me.btnGetir.Location = New System.Drawing.Point(259, 12)
        Me.btnGetir.Name = "btnGetir"
        Me.btnGetir.Size = New System.Drawing.Size(24, 24)
        Me.btnGetir.TabIndex = 8
        Me.btnGetir.UseVisualStyleBackColor = False
        '
        'btnKaydet
        '
        Me.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.Image = Global.Cari_Ekranı.My.Resources.Resources._022_save1
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaydet.Location = New System.Drawing.Point(393, 12)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(97, 33)
        Me.btnKaydet.TabIndex = 7
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
        Me.btnCikis.Location = New System.Drawing.Point(572, 12)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(88, 33)
        Me.btnCikis.TabIndex = 6
        Me.btnCikis.Text = "Çıkış"
        Me.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCikis.UseVisualStyleBackColor = True
        '
        'btnYeniKayit
        '
        Me.btnYeniKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnYeniKayit.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnYeniKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYeniKayit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYeniKayit.Image = Global.Cari_Ekranı.My.Resources.Resources._283_notebook1
        Me.btnYeniKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYeniKayit.Location = New System.Drawing.Point(290, 12)
        Me.btnYeniKayit.Name = "btnYeniKayit"
        Me.btnYeniKayit.Size = New System.Drawing.Size(97, 33)
        Me.btnYeniKayit.TabIndex = 5
        Me.btnYeniKayit.Text = "Yeni Kayıt"
        Me.btnYeniKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnYeniKayit.UseVisualStyleBackColor = True
        '
        'frmCariGirisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(672, 677)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnGetir)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.btnYeniKayit)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.lblKod)
        Me.Controls.Add(Me.txtKod)
        Me.Controls.Add(Me.tcCariAnaBilgi)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCariGirisi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCariGirisi"
        Me.tcCariAnaBilgi.ResumeLayout(False)
        Me.tpListe.ResumeLayout(False)
        Me.gbDetay.ResumeLayout(False)
        CType(Me.dgwKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDetay.ResumeLayout(False)
        Me.gbIletisim.ResumeLayout(False)
        Me.gbIletisim.PerformLayout()
        Me.gbOdmBilg1.ResumeLayout(False)
        Me.gbOdmBilg1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tcCariAnaBilgi As TabControl
    Friend WithEvents tpListe As TabPage
    Friend WithEvents tpDetay As TabPage
    Friend WithEvents txtKod As TextBox
    Friend WithEvents lblKod As Label
    Friend WithEvents lblAd As Label
    Friend WithEvents txtAd As TextBox
    Friend WithEvents btnYeniKayit As Button
    Friend WithEvents btnCikis As Button
    Friend WithEvents btnKaydet As Button
    Friend WithEvents gbOdmBilg3 As GroupBox
    Friend WithEvents lblHesapNo As Label
    Friend WithEvents txtHesapNo As TextBox
    Friend WithEvents lblSubeKodu As Label
    Friend WithEvents txtSubeKodu As TextBox
    Friend WithEvents lblBankaKodu As Label
    Friend WithEvents txtBankaKodu As TextBox
    Friend WithEvents lblIBAN As Label
    Friend WithEvents txtIBAN As TextBox
    Friend WithEvents lblTC As Label
    Friend WithEvents txtTC As TextBox
    Friend WithEvents gbOdmBilg1 As GroupBox
    Friend WithEvents lblOdemeNotu As Label
    Friend WithEvents txtOdemeNotu As TextBox
    Friend WithEvents lblIskonto As Label
    Friend WithEvents txtIskonto As TextBox
    Friend WithEvents lblMuhHesapNo As Label
    Friend WithEvents txtMuhHesapNo As TextBox
    Friend WithEvents lblVergiNo As Label
    Friend WithEvents txtVergiNo As TextBox
    Friend WithEvents lblVergiDaire As Label
    Friend WithEvents txtVergiDaire As TextBox
    Friend WithEvents btnGetir As Button
    Friend WithEvents btnSil As Button
    Friend WithEvents gbDetay As GroupBox
    Friend WithEvents dgwKayitlar As DataGridView
    Friend WithEvents gbIletisim As GroupBox
    Friend WithEvents lblCepNo As Label
    Friend WithEvents txtCepNo As TextBox
    Friend WithEvents lblFax As Label
    Friend WithEvents txtFax As TextBox
    Friend WithEvents lblTelefon As Label
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents lblUlke As Label
    Friend WithEvents txtUlke As TextBox
    Friend WithEvents lblSehir As Label
    Friend WithEvents cmbSehir As ComboBox
    Friend WithEvents lblSemt As Label
    Friend WithEvents txtSemt As TextBox
    Friend WithEvents lblKapiNo As Label
    Friend WithEvents txtKapiNo As TextBox
    Friend WithEvents lblPostaKodu As Label
    Friend WithEvents txtPostaKodu As TextBox
    Friend WithEvents lblAdres As Label
    Friend WithEvents txtAdres As TextBox
End Class
