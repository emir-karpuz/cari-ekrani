<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGridView
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
        Me.dgvKayitListesi = New System.Windows.Forms.DataGridView()
        CType(Me.dgvKayitListesi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvKayitListesi
        '
        Me.dgvKayitListesi.AllowUserToAddRows = False
        Me.dgvKayitListesi.AllowUserToDeleteRows = False
        Me.dgvKayitListesi.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.dgvKayitListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKayitListesi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvKayitListesi.Location = New System.Drawing.Point(0, 0)
        Me.dgvKayitListesi.Name = "dgvKayitListesi"
        Me.dgvKayitListesi.ReadOnly = True
        Me.dgvKayitListesi.Size = New System.Drawing.Size(984, 336)
        Me.dgvKayitListesi.TabIndex = 0
        '
        'frmGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 336)
        Me.Controls.Add(Me.dgvKayitListesi)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmGridView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kayıt Listesi"
        CType(Me.dgvKayitListesi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvKayitListesi As DataGridView
End Class
