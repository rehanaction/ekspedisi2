Public Class Daftar_User_Baru
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Daftar_User_Baru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call con_getsetting()
        If con_open() = False Then
            MsgBox("Database Tidak Terbuhung ", MsgBoxStyle.Exclamation, "Peringatan")
            Me.Close()
            User_Login.Show()
        End If
        txtNama.Select()
        cmbType.Items.Add("SA")
        cmbType.Items.Add("ADMIN")
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        If txtNama.Text <> "" And txtUsername.Text <> "" And txtPwd.Text <> "" And cmbType.Text <> "" Then
            newUser(txtNama.Text, txtUsername.Text, txtPwd.Text, cmbType.Text)
        Else
            MsgBox("Semua Data Wajib Diisi !!", MsgBoxStyle.Exclamation, "Peringatan")
        End If

    End Sub
    Sub def()
        txtPwd.Text = ""
        txtNama.Text = ""
        txtUsername.Text = ""
        cmbType.Text = ""
    End Sub

    Private Sub Daftar_User_Baru_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        User_Login.Show()
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
End Class