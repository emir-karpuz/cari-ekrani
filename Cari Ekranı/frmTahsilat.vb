Public Class frmTahsilat
    Private Sub frmTahsilat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTarih.Text = Now.ToString("yyyy/MM/dd")
        dgvTahsilat.DataSource = SQLQuery.cmdDataTable("SELECT CarAna.Kod, Ad, BelgeTipi, BelgeSeri, BelgeNo, Tarih, Aciklama, KasaKod, KapTutar, Borc, Alac 
                                                                FROM CarHarDet INNER JOIN CarAna ON CarAna.Kod = CarHarDet.Kod")
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Close()
    End Sub

    Private Sub btnYeniKayit_Click(sender As Object, e As EventArgs) Handles btnYeniKayit.Click
        tcTahsilat.SelectedTab = tpDetay
        ClearTextBoxes.ClearTextBox(Me)
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        'UPDATE YAZILACAK
        Try
            SQLQuery.cmdFirstData("INSERT INTO CarHarDet (BelgeTipi, BelgeSeri, BelgeNo, Tarih, Kod, Aciklama, KasaKod, KapTutar, Borc, Alac) 
                                                  VALUES ('" & cmbBelgeTipi.Text & "', '" & txtBelgeSeri.Text & "', '" & txtBelgeNo.Text & "', '" & txtTarih.Text & "', '" & txtKod.Text & "',
                                                            '" & txtAciklama.Text & "', '" & txtKasaKodu.Text & "', '" & txtTutar.Text & "',
                                                                '" & txtBorc.Text & "', '" & txtAlacak.Text & "' )")
            MessageBox.Show("Kayıt başarıyla oluşturuldu.", "Info")
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message & Environment.NewLine & ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click

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
        txtKod.Text = dgvTahsilat.CurrentRow.Cells(0).Value.ToString        '0 = KOD
        txtAd.Text = dgvTahsilat.CurrentRow.Cells(1).Value.ToString         '1 = AD
        cmbBelgeTipi.Text = dgvTahsilat.CurrentRow.Cells(2).Value.ToString  '2 = BELGE TİPİ
        txtBelgeSeri.Text = dgvTahsilat.CurrentRow.Cells(3).Value.ToString  '3 = BELGE SERİ
        txtBelgeNo.Text = dgvTahsilat.CurrentRow.Cells(4).Value.ToString    '4 = BELGE NO
        txtTarih.Text = dgvTahsilat.CurrentRow.Cells(5).Value.ToString      '5 = TARİH
        txtAciklama.Text = dgvTahsilat.CurrentRow.Cells(6).Value.ToString   '6 = AÇIKLAMA
        txtKasaKodu.Text = dgvTahsilat.CurrentRow.Cells(7).Value.ToString   '7 = KASA KOD
        txtTutar.Text = dgvTahsilat.CurrentRow.Cells(8).Value.ToString      '8 = TUTAR
        txtBorc.Text = dgvTahsilat.CurrentRow.Cells(9).Value.ToString       '9 = BORÇ
        txtAlacak.Text = dgvTahsilat.CurrentRow.Cells(10).Value.ToString     '10 = ALACAK
        txtBakiye.Text = CStr(CInt(txtBorc.Text) + CInt(txtAlacak.Text))
        tcTahsilat.SelectedTab = tpDetay
    End Sub
End Class