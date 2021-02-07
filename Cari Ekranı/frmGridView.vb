Public Class frmGridView

    Public row As New DataGridViewRow
    Public tablo As String

    Private Sub frmGridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvKayitListesi.DataSource = SQLQuery.cmdDataTable("SELECT * FROM " & tablo & "(NOLOCK)")
    End Sub

    Private Sub dgvKayitListesi_DoubleClick(sender As Object, e As EventArgs) Handles dgvKayitListesi.DoubleClick

        row = dgvKayitListesi.CurrentRow

        MessageBox.Show(row.Cells(1).Value.ToString, "Kod")
        Close()

    End Sub

End Class