Public Class frmTahsilat
    Private Sub frmTahsilat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTahsilat.DataSource = SQLQuery.cmdDataTable("SELECT CarAna.Kod, Ad, BelgeTipi, BelgeSeri, BelgeNo, convert(nvarchar(20), Tarih, 104) 'Tarih', Aciklama, KasaKod, Borc, Alac 
                                                                FROM CarHarDet INNER JOIN CarAna ON CarAna.Kod = CarHarDet.Kod 
                                                                WHERE BelgeTipi = 'CarTahsil'")
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Close()
    End Sub

    Private Sub btnYeniKayit_Click(sender As Object, e As EventArgs) Handles btnYeniKayit.Click
        tcTahsilat.SelectedTab = tpDetay
        ClearTextBoxes.ClearTextBox(Me)
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click

        Dim belgeTipi As String

        Dim recordID As Integer = SQLQuery.cmdFirstData("SELECT Kod FROM CarHarDet WHERE Kod = '" & txtKod.Text & "' AND 
                                                                                         BelgeTipi = '" & cmbBelgeTipi.Text & "' AND
                                                                                         BelgeSeri = '" & txtBelgeSeri.Text & "' AND
                                                                                         BelgeNo = '" & txtBelgeNo.Text & "' ")

        If txtKod.Text <> String.Empty Or cmbBelgeTipi.Text <> Nothing Or txtBelgeSeri.Text <> String.Empty Or txtBelgeNo.Text <> String.Empty Then '(??)
            If recordID = 0 Then
                Try
                    If cmbBelgeTipi.Text = "TAHSİLAT" Then      'ComboBox'ın ValueMember ve DisplayMember özelliklerini kullan
                        belgeTipi = "CarTahsil"
                    Else
                        belgeTipi = "CarTediye"
                    End If

                    SQLQuery.cmdFirstData("INSERT INTO CarHarDet (BelgeTipi, BelgeSeri, BelgeNo, Tarih, Kod, Aciklama, KasaKod, Alac) 
                                                  VALUES ('" & belgeTipi & "', '" & txtBelgeSeri.Text & "', '" & txtBelgeNo.Text & "',
                                                            '" & dtpTarih.Value.ToString("yyyy-MM-dd") & "', '" & txtKod.Text & "',
                                                                '" & txtAciklama.Text & "', '" & txtKasaKodu.Text & "', '" & txtTutar.Text & "')")
                    MessageBox.Show("Kayıt başarıyla oluşturuldu.", "Info")
                    frmTahsilat_Load(sender, e)
                Catch ex As Exception
                    MessageBox.Show("Hata oluştu: " & ex.Message, "Error")
                End Try
            Else
                Try
                    SQLQuery.cmdDataTable("UPDATE CarHarDet SET Tarih = '" & dtpTarih.Value.ToString("yyyy-MM-dd") & "',
                                                                Aciklama = '" & txtAciklama.Text & "',
                                                                KasaKod = '" & txtKasaKodu.Text & "',
                                                                Alac = '" & txtTutar.Text & "'
                                                                WHERE Kod = '" & txtKod.Text & "' AND 
                                                                      BelgeTipi = '" & cmbBelgeTipi.Text & "' AND
                                                                      BelgeSeri = '" & txtBelgeSeri.Text & "' AND
                                                                      BelgeNo = '" & txtBelgeNo.Text & "' ")

                    MessageBox.Show("Kayıt başarıyla güncellendi.", "Info")
                    frmTahsilat_Load(sender, e)
                Catch ex As Exception
                    MessageBox.Show("Hata oluştu: " & ex.Message, "Error")
                End Try
            End If
        Else
            MessageBox.Show("Zorunlu alanlar boş bırakılamaz", "Error")
        End If

    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Try
            SQLQuery.cmdDataTable("DELETE FROM CarHarDet WHERE Kod = '" & txtKod.Text & "' AND 
                                                         BelgeTipi = '" & cmbBelgeTipi.Text & "' AND
                                                         BelgeSeri = '" & txtBelgeSeri.Text & "' AND
                                                         BelgeNo = '" & txtBelgeNo.Text & "' ")
            MessageBox.Show("Silme işlemi başarıyla tamamlandı", "Info")
            frmTahsilat_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show("Silme sırasında hata oluştu: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnGetir_Click(sender As Object, e As EventArgs) Handles btnGetir.Click
        Dim frmGridView As New frmGridView
        frmGridView.tablo = "CarAna"
        frmGridView.ShowDialog()

        If frmGridView.row.Index <> -1 Then
            txtKod.Text = frmGridView.row.Cells(1).Value.ToString       'Otomatikleştirilecek SELECT'i Id'ye göre çektirip txtBox'lara yerleştirilecek
            txtAd.Text = frmGridView.row.Cells(3).Value.ToString
        End If
    End Sub

    Private Sub dgvTahsilat_DoubleClick(sender As Object, e As EventArgs) Handles dgvTahsilat.DoubleClick
        txtKod.Text = dgvTahsilat.CurrentRow.Cells(0).Value.ToString        '0 = KOD            'Otomatikleştirilecek
        txtAd.Text = dgvTahsilat.CurrentRow.Cells(1).Value.ToString         '1 = AD
        cmbBelgeTipi.Text = dgvTahsilat.CurrentRow.Cells(2).Value.ToString  '2 = BELGE TİPİ
        txtBelgeSeri.Text = dgvTahsilat.CurrentRow.Cells(3).Value.ToString  '3 = BELGE SERİ
        txtBelgeNo.Text = dgvTahsilat.CurrentRow.Cells(4).Value.ToString    '4 = BELGE NO
        dtpTarih.Value = CDate(dgvTahsilat.CurrentRow.Cells(5).Value.ToString) '5 = TARİH
        txtAciklama.Text = dgvTahsilat.CurrentRow.Cells(6).Value.ToString   '6 = AÇIKLAMA
        txtKasaKodu.Text = dgvTahsilat.CurrentRow.Cells(7).Value.ToString   '7 = KASA KOD
        txtTutar.Text = SQLQuery.cmdFirstData("SELECT convert(int, Alac) 'Alac' FROM CarHarDet WHERE Kod = '" & txtKod.Text & "' AND 
                                                                                                     BelgeTipi = '" & cmbBelgeTipi.Text & "' AND
                                                                                                     BelgeSeri = '" & txtBelgeSeri.Text & "' AND
                                                                                                     BelgeNo = '" & txtBelgeNo.Text & "' ")
        txtBorc.Text = SQLQuery.cmdFirstData("SELECT SUM(Borc) FROM CarHarDet WHERE Kod = '" & txtKod.Text & "' ")
        txtAlacak.Text = SQLQuery.cmdFirstData("SELECT SUM(Alac) FROM CarHarDet WHERE Kod = '" & txtKod.Text & "' ")
        txtBakiye.Text = CStr(CInt(txtBorc.Text) - CInt(txtAlacak.Text))
        tcTahsilat.SelectedTab = tpDetay
    End Sub
End Class