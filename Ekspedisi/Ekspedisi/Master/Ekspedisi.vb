Public Class Ekspedisi
    Private Sub Ekspedisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call con_getsetting()
        If con_open() = True Then
            listcabang()
            listexp(cmbExp)
            listexp(cmbExp2)
            listexp(cmbEkspedisi)
            Ekspedisidgv("", "")
            With dgvEkspedisi
                .ReadOnly = True
            End With
        Else
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            MsgBox("Database tidak terhubung", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            cmbExp2.Enabled = True
        ElseIf CheckBox1.Checked = False Then
            cmbExp2.Enabled = False
            cmbExp2.Text = ""
        End If
    End Sub

    Private Sub cmbnamaCabang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbnamaCabang.SelectedIndexChanged
        getID(cmbnamaCabang.Text, "nama_cabang", "cabang", lblIDcab)
        checkdata(lblIDcab.Text)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cmbnamaCabang.Text <> "" And txtHp.Text <> "" And cmbExp.Text <> "" Then
            If lblrep.Text = "Label9" Then
                lblrep.Text = 0
            End If
            Dim hp, ckb As String
            hp = txtHp.Text
            ckb = hp.Replace(".", "")
            saveEkspedisi(lblIDcab.Text, ckb, lblrep.Text, lblIDexp.Text)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtNE.Enabled = True
            btnSimpanexp.Enabled = True
            GroupBox1.Enabled = False
        Else
            txtNE.Enabled = False
            btnSimpanexp.Enabled = False
            GroupBox1.Enabled = True
        End If
    End Sub

    Public Sub cmbExp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExp.SelectedIndexChanged
        getID(cmbExp.Text, "nama_ekspedisi", "ekspedisi", lblIDexp)
    End Sub

    Private Sub btnSimpanexp_Click(sender As Object, e As EventArgs) Handles btnSimpanexp.Click
        If txtNE.Text <> "" Then
            simpannewEXp(txtNE.Text)
        Else
            MsgBox("Nama Ekspedisi Wajib Diisi", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub

    Private Sub cmbExp2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExp2.SelectedIndexChanged
        getID(cmbExp2.Text, "nama_ekspedisi", "ekspedisi", lblrep)
    End Sub

    Private Sub txtHp_TextChanged(sender As Object, e As EventArgs) Handles txtHp.TextChanged
        If Microsoft.VisualBasic.Len(txtHp.Text) = 0 Then
            Exit Sub
        End If
        txtHp.Text = FormatNumber(txtHp.Text, 0)
        txtHp.SelectionStart = Microsoft.VisualBasic.Len(txtHp.Text)
    End Sub

    Private Sub txtHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHp.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse KeyAscii = Keys.Back _
            OrElse KeyAscii = Keys.Return _
            OrElse KeyAscii = Keys.Delete) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)
    End Sub
    Private Sub cmbTcabang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTcabang.SelectedIndexChanged
        If cmbTcabang.Text <> "" Then
            Ekspedisidgv(cmbTcabang.Text, "c.nama_cabang")
        End If
    End Sub

    Private Sub cmbEkspedisi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEkspedisi.SelectedIndexChanged
        If cmbEkspedisi.Text <> "" Then
            Ekspedisidgv(cmbEkspedisi.Text, "e.nama_ekspedisi")
        End If
    End Sub
    Private Sub txtNE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNE.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
End Class