Public Class frmAnaMenu
    Private Sub tsAnaBilgiGirisi_Click(sender As Object, e As EventArgs) Handles tsAnaBilgiGirisi.Click
        Dim frmCariGirisi As New frmCariGirisi
        frmCariGirisi.MdiParent = Me
        frmCariGirisi.Dock = DockStyle.Fill
        frmCariGirisi.Show()
    End Sub

    Private Sub frmAnaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controls.OfType(Of MdiClient).FirstOrDefault.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub tsHakkinda_Click(sender As Object, e As EventArgs) Handles tsHakkinda.Click
        Dim frmHakkinda As New frmHakkinda
        frmHakkinda.MdiParent = Me
        frmHakkinda.Show()
    End Sub

    Private Sub tsProgramdanCikis_Click(sender As Object, e As EventArgs) Handles tsProgramdanCikis.Click
        Me.Close()
    End Sub

    Private Sub tvYanMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvYanMenu.AfterSelect

        Dim frmCariGirisi As New frmCariGirisi 'KOD TEKRARI YAPILDI
        frmCariGirisi.MdiParent = Me
        frmCariGirisi.Dock = DockStyle.Fill

        Select Case tvYanMenu.SelectedNode.Tag
            Case "01"
                frmCariGirisi.Show()
            Case "02"
                Me.Close()
            Case Else
                Me.Close()
        End Select
    End Sub
End Class
