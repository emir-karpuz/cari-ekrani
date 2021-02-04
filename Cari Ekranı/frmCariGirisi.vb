Public Class frmCariGirisi

    Private Sub btnYeniKayit_Click(sender As Object, e As EventArgs) Handles btnYeniKayit.Click
        ClearTextBox(Me)
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        'TO DO: EĞER KAYIT VARSA UPDATE İŞLEMİ YAPILACAK YOKSA YENİ KAYIT OLUŞTURULACAK
        Dim recordID As Integer = CInt(SQLQuery.cmd("SELECT Kod FROM CarAna WHERE Kod = '" & txtKod.Text & "'"))

        If txtKod.Text <> "" Then
            If recordID = 0 Then
                Try
                    SQLQuery.cmdMaker("INSERT INTO CarAna (Kod, Ad, Adres, Semt, Sehir, PostaKodu, KapiNo, Ulke, Telefon, Fax, CepTelefon,
                                        VerDar, VerNo, OdemeNotu, MuhHesKodu, TcKimlikNo, BankaHesapNo, IbanNo, BankaKodu, SubeKodu)
                            VALUES('" & txtKod.Text & "', '" & txtAd.Text & "', '" & txtAdres.Text & "', '" & txtSemt.Text & "', '" & cmbSehir.Text & "',
                                   '" & txtPostaKodu.Text & "', '" & txtKapiNo.Text & "', '" & txtUlke.Text & "', '" & txtTelefon.Text & "', '" & txtFax.Text & "',
                                   '" & txtCepNo.Text & "', '" & txtVergiDaire.Text & "', '" & txtVergiNo.Text & "', '" & txtOdemeNotu.Text & "', '" & txtMuhHesapNo.Text & "',
                                   '" & txtTC.Text & "', '" & txtHesapNo.Text & "', '" & txtIBAN.Text & "', '" & txtBankaKodu.Text & "', '" & txtSubeKodu.Text & "')")
                    MessageBox.Show("Kayıt başarıyla oluşturuldu.", "Info")
                Catch ex As Exception
                    MessageBox.Show("Hata oluştu: " & ex.Message & Environment.NewLine & ex.StackTrace, "Error")
                End Try
            Else
                Try
                    SQLQuery.cmdMaker("UPDATE CarAna SET Ad = '" & txtAd.Text & "',
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
        frmGridView.ShowDialog()

        If frmGridView.row.Index <> -1 Then
            txtKod.Text = frmGridView.row.Cells(1).Value.ToString       'Otomatikleştirilecek
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
            SQLQuery.cmdMaker("DELETE FROM CarAna WHERE Kod = '" & txtKod.Text & "'")
            MessageBox.Show("Silme işlemi başarıyla tamamlandı", "Info")
            ClearTextBox(Me)
        Catch ex As Exception
            MessageBox.Show("Silme sırasında hata oluştu: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Close()
    End Sub

    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

End Class