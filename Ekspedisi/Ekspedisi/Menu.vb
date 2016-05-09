Public Class Menu
    Private Sub Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub EkspedisiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EkspedisiToolStripMenuItem.Click
        Ekspedisi.Show()
    End Sub
    Private Sub InputSuratJalanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputSuratJalanToolStripMenuItem.Click
        Input_Surat_jalan.Show()
    End Sub

    Private Sub ReportEkspedisiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportEkspedisiToolStripMenuItem.Click
        Invoice_Report.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Date.Now().ToString("dd MMM yyyy - HH:mm:ss")
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class