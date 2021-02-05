Public Class frmAnaMenu

    Private Sub tsAnaBilgiGirisi_Click(sender As Object, e As EventArgs) Handles tsAnaBilgiGirisi.Click
        menuDock(frmCariGirisi)
        frmCariGirisi.Show()
    End Sub

    Private Sub tsHakkinda_Click(sender As Object, e As EventArgs) Handles tsHakkinda.Click
        Dim frmHakkinda As New frmHakkinda
        frmHakkinda.MdiParent = Me
        frmHakkinda.Show()
    End Sub

    Private Sub tsProgramdanCikis_Click(sender As Object, e As EventArgs) Handles tsProgramdanCikis.Click
        Close()
    End Sub

    Private Sub tvYanMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvYanMenu.AfterSelect
        menuDock(frmCariGirisi)
        menuDock(frmTahsilat)
        Select Case tvYanMenu.SelectedNode.Tag
            Case "01"
                frmCariGirisi.Show()
            Case "11"
                frmTahsilat.Show()
            Case Else
                MessageBox.Show("Geliştirilme aşamasındadır.", "Error")
        End Select
    End Sub

    Private Sub frmAnaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controls.OfType(Of MdiClient).FirstOrDefault.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub menuDock(frm As Form)
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
    End Sub

End Class
