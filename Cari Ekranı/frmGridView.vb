﻿Public Class frmGridView

    Public row As New DataGridViewRow
    Dim frmCari As New frmCariGirisi

    Private Sub frmGridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvKayitListesi.DataSource = SQLQuery.cmdMaker("SELECT * FROM CarAna(NOLOCK)")
    End Sub

    Private Sub dgvKayitListesi_DoubleClick(sender As Object, e As EventArgs) Handles dgvKayitListesi.DoubleClick

        row = dgvKayitListesi.CurrentRow

        MessageBox.Show(row.Cells(1).Value.ToString, "Kod")
        Close()

    End Sub

End Class