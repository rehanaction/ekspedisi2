Public Class Invoice_Report
    Dim charactersDisallowed As String = "':;<>,.{}~`|+$%^&*)(!@#?"
    Private Sub Invoice_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call con_getsetting()
        If con_open() = True Then
            listexp(cmbExp)
        Else
            GroupBox1.Enabled = False
            MsgBox("Database Tidak Terhubung", MsgBoxStyle.Exclamation, "Peringatan")
        End If

    End Sub
    Private Sub cmbExp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExp.SelectedIndexChanged
        If cmbExp.Text <> "" Then
            getID(cmbExp.Text, "nama_ekspedisi", "ekspedisi", lblID)
            dgvReport.Columns.Clear()
            dgvReport.DataSource = Nothing
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If RbtnSemua.Checked = True Then
            If cmbExp.Text <> "" And dtpDari.Text <> "" And dtpSampai.Text <> "" Then
                ReportEkspedisi(lblID.Text, dtpDari.Text, dtpSampai.Text, dgvReport, "")
            ElseIf dtpSampai.Text < dtpDari.Text Then
                MsgBox("Tidak Dapat Menjalan Perintah Inputan tanggal sampai tidak sesuai", MsgBoxStyle.Exclamation, "Informasi")
            Else
                MsgBox("Semua data wajib diisi", MsgBoxStyle.Exclamation, "Informasi")
            End If
        ElseIf RbtnLunas.Checked = True Then
            If cmbExp.Text <> "" And dtpDari.Text <> "" And dtpSampai.Text <> "" Then
                ReportEkspedisi(lblID.Text, dtpDari.Text, dtpSampai.Text, dgvReport, "1")
            ElseIf dtpSampai.Text < dtpDari.Text Then
                MsgBox("Tidak Dapat Menjalan Perintah Inputan tanggal sampai tidak sesuai", MsgBoxStyle.Exclamation, "Informasi")
            Else
                MsgBox("Semua data wajib diisi", MsgBoxStyle.Exclamation, "Informasi")
            End If
        ElseIf RbtnBelum.Checked = True Then
            If cmbExp.Text <> "" And dtpDari.Text <> "" And dtpSampai.Text <> "" Then
                ReportEkspedisi(lblID.Text, dtpDari.Text, dtpSampai.Text, dgvReport, "0")
            ElseIf dtpSampai.Text < dtpDari.Text Then
                MsgBox("Tidak Dapat Menjalan Perintah Inputan tanggal sampai tidak sesuai", MsgBoxStyle.Exclamation, "Informasi")
            Else
                MsgBox("Semua data wajib diisi", MsgBoxStyle.Exclamation, "Informasi")
            End If
        Else
            MsgBox("Harap Pilih terlebih Dahulu criteria data yang akan di tampilkan", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        If dgvReport.DataSource IsNot Nothing And txtNoInvoice.Text <> "" And dtpInvoice.Text <> "" Then
            For baris As Integer = 0 To dgvReport.RowCount - 2
                updateStatus(dgvReport.Rows(baris).Cells(0).Value, dgvReport.Rows(baris).Cells(8).Value, txtNoInvoice.Text, dtpInvoice.Text, User_Login.Label2.Text)
            Next
        Else
            MsgBox("Tidak Dapat Memperbaharui data kosong/No. Invoice / Tanggal belum diisi", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub

    Private Sub RbtnSemua_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnSemua.CheckedChanged

    End Sub

    Private Sub RbtnBelum_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnBelum.CheckedChanged
        If RbtnBelum.Checked Then
            Label4.Visible = True
            Label5.Visible = True
            dtpInvoice.Visible = True
            txtNoInvoice.Visible = True
        Else
            Label4.Visible = False
            Label5.Visible = False
            dtpInvoice.Visible = False
            txtNoInvoice.Visible = False
        End If
    End Sub

    Private Sub txtNoInvoice_TextChanged(sender As Object, e As EventArgs) Handles txtNoInvoice.TextChanged
        Dim theText As String = txtNoInvoice.Text
        Dim Letter As String
        For x As Integer = 0 To txtNoInvoice.Text.Length - 1
            Letter = txtNoInvoice.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
            End If
        Next
        txtNoInvoice.Text = theText
        txtNoInvoice.Select(txtNoInvoice.Text.Length, 0)
    End Sub
End Class