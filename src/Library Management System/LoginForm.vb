Public Class frmLogin
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Check if fields are empty
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or cmbRole.SelectedIndex = -1 Then
            MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Temporary check (replace with database later)
        If txtUsername.Text = "admin" And txtPassword.Text = "1234" And cmbRole.Text = "Admin" Then
            MessageBox.Show("Login successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim dashboard As New myProfile()
            dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged

    End Sub
End Class
