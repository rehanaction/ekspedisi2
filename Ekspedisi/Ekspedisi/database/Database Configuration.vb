Public Class Database_Configuration
    Dim charactersDisallowed As String = "'"",.<>?/%!&*()-+;:`~|\"
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Call con_savesetting(txtHost.Text, txtUsername.Text, TxtPwd.Text)
        MessageBox.Show("Setting Saved!")
        Me.Close()
        If con_open() = True Then
            User_Login.UsernameTextBox.Enabled = True
            User_Login.PasswordTextBox.Enabled = True
            User_Login.cmbType.Enabled = True
            User_Login.btnDaftar.Enabled = True
            User_Login.OK.Enabled = True
            User_Login.Show()
        Else
            MsgBox("Database Tidak Terhubung")
            User_Login.UsernameTextBox.Enabled = False
            User_Login.PasswordTextBox.Enabled = False
            User_Login.cmbType.Enabled = False
            User_Login.btnDaftar.Enabled = False
            User_Login.OK.Enabled = False
        End If
    End Sub

    Private Sub Database_Configuration_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        User_Login.Show()
    End Sub

    Private Sub Database_Configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtHost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHost.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = Keys.Delete Or
           Asc(e.KeyChar) = Keys.Right Or Asc(e.KeyChar) = Keys.Left Or Asc(e.KeyChar) = Keys.Delete Or Asc(e.KeyChar) = Keys.Back Then
            Return
        End If
        e.Handled = True
    End Sub

    Private Sub txtHost_LostFocus(sender As Object, e As EventArgs) Handles txtHost.LostFocus
        Dim IP() As String = txtHost.Text.Split(".")
        Dim Test As Integer
        If IP.Length = 4 Then 'If 3 "."
            Dim Proper As Boolean = True
            For I As Integer = 0 To 3
                Test = Integer.Parse(IP(I)) 'Parse the string for an integer, if its not return -1
                If Test < 0 Or Test > 255 Then 'If not between 0-255 then the ip is not a proper format
                    MsgBox("IP Address is not in a proper format! All numbers entered must be between 0 - 255")
                    txtHost.Focus()
                    txtHost.SelectionStart = txtHost.Text.Length
                    Return
                End If
            Next
        Else
            MsgBox("IP Address is not in a proper format! There must be 4 numbers entered, in XXX.XXX.XXX.XXX format")
            txtHost.Focus()
            txtHost.SelectionStart = txtHost.Text.Length
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPwd_TextChanged(sender As Object, e As EventArgs) Handles TxtPwd.TextChanged
        Dim theText As String = TxtPwd.Text
        Dim Letter As String
        For x As Integer = 0 To TxtPwd.Text.Length - 1
            Letter = TxtPwd.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
            End If
        Next
        TxtPwd.Text = theText
        TxtPwd.Select(TxtPwd.Text.Length, 0)
    End Sub
End Class