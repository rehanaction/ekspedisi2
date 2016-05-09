Public Class User_Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text <> "" And PasswordTextBox.Text <> "" And cmbType.Text <> "" Then
            cekLogin(UsernameTextBox.Text, PasswordTextBox.Text, cmbType.Text)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub User_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbType.Items.Add("SA")
        cmbType.Items.Add("ADMIN")
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Daftar_User_Baru.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Database_Configuration.Show()
    End Sub

    Private Sub User_Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call con_getsetting()
        If con_open() = False Then
            UsernameTextBox.Enabled = False
            PasswordTextBox.Enabled = False
            cmbType.Enabled = False
            btnDaftar.Enabled = False
            OK.Enabled = False
        Else
            UsernameTextBox.Enabled = True
            PasswordTextBox.Enabled = True
            cmbType.Enabled = True
            btnDaftar.Enabled = True
            OK.Enabled = True
        End If
    End Sub



    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
End Class
