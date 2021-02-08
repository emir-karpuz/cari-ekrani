Public Class frmCariGirisi

    Private Sub btnYeniKayit_Click(sender As Object, e As EventArgs) Handles btnYeniKayit.Click
        tcCariAnaBilgi.SelectedTab = tpDetay
        ClearTextBoxes.ClearTextBox(Me)
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        'TO DO: EĞER KAYIT VARSA UPDATE İŞLEMİ YAPILACAK YOKSA YENİ KAYIT OLUŞTURULACAK
        Dim recordID As Integer = SQLQuery.cmdFirstData("SELECT Kod FROM CarAna WHERE Kod = '" & txtKod.Text & "'")

        If cmbSehir.Text = "İL SEÇİNİZ" Then    'MegaSehir Tablosunda
            cmbSehir.Text = String.Empty
        End If

        If txtKod.Text <> "" Then
            If recordID = 0 Then
                Try
                    SQLQuery.cmdDataTable("INSERT INTO CarAna (Kod, Ad, Adres, Semt, Sehir, PostaKodu, KapiNo, Ulke, Telefon, Fax, CepTelefon,
                                        VerDar, VerNo, OdemeNotu, MuhHesKodu, TcKimlikNo, BankaHesapNo, IbanNo, BankaKodu, SubeKodu)
                            VALUES('" & txtKod.Text & "', '" & txtAd.Text & "', '" & txtAdres.Text & "', '" & txtSemt.Text & "', '" & cmbSehir.Text & "',
                                   '" & txtPostaKodu.Text & "', '" & txtKapiNo.Text & "', '" & txtUlke.Text & "', '" & txtTelefon.Text & "', '" & txtFax.Text & "',
                                   '" & txtCepNo.Text & "', '" & txtVergiDaire.Text & "', '" & txtVergiNo.Text & "', '" & txtOdemeNotu.Text & "', '" & txtMuhHesapNo.Text & "',
                                   '" & txtTC.Text & "', '" & txtHesapNo.Text & "', '" & txtIBAN.Text & "', '" & txtBankaKodu.Text & "', '" & txtSubeKodu.Text & "')")
                    MessageBox.Show("Kayıt başarıyla oluşturuldu.", "Info")
                    ClearTextBoxes.ClearTextBox(Me)
                    dgvKayitlar.DataSource = SQLQuery.cmdDataTable("SELECT Kod, Ad, Adres, Semt, PostaKodu, KapiNo, Sehir, Ulke FROM CarAna(NOLOCK)")
                Catch ex As Exception
                    MessageBox.Show("Hata oluştu: " & ex.Message & Environment.NewLine & ex.StackTrace, "Error")
                End Try
            Else
                Try
                    SQLQuery.cmdDataTable("UPDATE CarAna SET Ad = '" & txtAd.Text & "',
                                                     Adres = '" & txtAdres.Text & "',
                                                     Semt = '" & txtSemt.Text & "',
                                                     Sehir = '" & cmbSehir.Text & "',
                                                     PostaKodu = '" & txtPostaKodu.Text & "',
                                                     KapiNo = '" & txtKapiNo.Text & "',
                                                     Ulke = '" & txtUlke.Text & "',
                                                     Telefon = '" & txtTelefon.Text & "',
                                                     Fax = '" & txtFax.Text & "',
                                                     CepTelefon = '" & txtCepNo.Text & "',
                                                     VerDar = '" & txtVergiDaire.Text & "',
                                                     VerNo = '" & txtVergiNo.Text & "',
                                                     OdemeNotu = '" & txtOdemeNotu.Text & "',
                                                     MuhHesKodu = '" & txtMuhHesapNo.Text & "',
                                                     TcKimlikNo = '" & txtTC.Text & "',
                                                     BankaHesapNo = '" & txtHesapNo.Text & "',
                                                     IbanNo = '" & txtIBAN.Text & "',
                                                     BankaKodu = '" & txtBankaKodu.Text & "',
                                                     SubeKodu = '" & txtSubeKodu.Text & "'
                                                     WHERE Kod = '" & txtKod.Text & "'")

                    MessageBox.Show("Kayıt başarıyla güncellendi.", "Info")
                    ClearTextBoxes.ClearTextBox(Me)
                    dgvKayitlar.DataSource = SQLQuery.cmdDataTable("SELECT Kod, Ad, Adres, Semt, PostaKodu, KapiNo, Sehir, Ulke FROM CarAna(NOLOCK)")
                Catch ex As Exception
                    MessageBox.Show("Hata oluştu: " & ex.Message & Environment.NewLine & ex.StackTrace, "Error")
                End Try
            End If
        Else
            MessageBox.Show("Kod bölgesi boş bırakılamaz", "Error")
        End If
    End Sub

    Private Sub btnGetir_Click(sender As Object, e As EventArgs) Handles btnGetir.Click
        Dim frmGridView As New frmGridView
        frmGridView.tablo = "CarAna"
        frmGridView.ShowDialog()

        If frmGridView.row.Index <> -1 Then
            txtKod.Text = frmGridView.row.Cells(1).Value.ToString       'Otomatikleştirilecek SELECT'i Id'ye göre çektirip txtBox'lara yerleştirilecek
            txtAd.Text = frmGridView.row.Cells(3).Value.ToString
            txtAdres.Text = frmGridView.row.Cells(4).Value.ToString
            txtSemt.Text = frmGridView.row.Cells(5).Value.ToString
            txtPostaKodu.Text = frmGridView.row.Cells(7).Value.ToString
            txtKapiNo.Text = frmGridView.row.Cells(87).Value.ToString
            txtUlke.Text = frmGridView.row.Cells(8).Value.ToString
            txtTelefon.Text = frmGridView.row.Cells(9).Value.ToString
            txtFax.Text = frmGridView.row.Cells(10).Value.ToString
            txtCepNo.Text = frmGridView.row.Cells(63).Value.ToString
            txtTC.Text = frmGridView.row.Cells(66).Value.ToString
            txtVergiDaire.Text = frmGridView.row.Cells(11).Value.ToString
            txtVergiNo.Text = frmGridView.row.Cells(12).Value.ToString
            txtMuhHesapNo.Text = frmGridView.row.Cells(19).Value.ToString
            txtOdemeNotu.Text = frmGridView.row.Cells(18).Value.ToString
            txtIBAN.Text = frmGridView.row.Cells(70).Value.ToString
            txtBankaKodu.Text = frmGridView.row.Cells(72).Value.ToString
            txtSubeKodu.Text = frmGridView.row.Cells(73).Value.ToString
            txtHesapNo.Text = frmGridView.row.Cells(69).Value.ToString
        End If

    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Try
            SQLQuery.cmdDataTable("DELETE FROM CarAna WHERE Kod = '" & txtKod.Text & "'")
            MessageBox.Show("Silme işlemi başarıyla tamamlandı", "Info")
            ClearTextBoxes.ClearTextBox(Me)
        Catch ex As Exception
            MessageBox.Show("Silme sırasında hata oluştu: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Close()
    End Sub

    Private Sub frmCariGirisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvKayitlar.DataSource = SQLQuery.cmdDataTable("SELECT Kod, Ad, Adres, Semt, PostaKodu, KapiNo, Sehir, Ulke FROM CarAna(NOLOCK)")
    End Sub

    Private Sub dgwKayitlar_DoubleClick(sender As Object, e As EventArgs) Handles dgvKayitlar.DoubleClick
        txtKod.Text = dgvKayitlar.CurrentRow.Cells(0).Value.ToString
        txtAd.Text = dgvKayitlar.CurrentRow.Cells(1).Value.ToString
        txtAdres.Text = dgvKayitlar.CurrentRow.Cells(2).Value.ToString
        txtSemt.Text = dgvKayitlar.CurrentRow.Cells(3).Value.ToString
        txtPostaKodu.Text = dgvKayitlar.CurrentRow.Cells(4).Value.ToString
        txtKapiNo.Text = dgvKayitlar.CurrentRow.Cells(5).Value.ToString
        cmbSehir.Text = dgvKayitlar.CurrentRow.Cells(6).Value.ToString
        txtUlke.Text = dgvKayitlar.CurrentRow.Cells(7).Value.ToString
        tcCariAnaBilgi.SelectedTab = tpDetay
    End Sub
End Class