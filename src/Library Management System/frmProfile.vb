Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

' Page 20 - Student Profile (logic only; controls live in frmProfile.Designer.vb)
Public Class frmProfile

    ' Values loaded from the database, used to restore the form on Cancel
    Private original As (First As String, Last As String, Phone As String)

    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfile()
        SetEditMode(False)
    End Sub

    ' ---------- Data ----------
    ' TODO: load the LOGGED-IN student's record from LibraryManagement.Core
    Private Sub LoadProfile()
        ' Dim s = studentService.GetById(CurrentSession.UserId)
        ' txtAdmissionNo.Text = s.AdmissionNo : txtFirstName.Text = s.FirstName ...
        txtAdmissionNo.Text = "S001"
        txtFirstName.Text = "Alice"
        txtLastName.Text = "Brown"
        txtEmail.Text = "alice@school.com"
        txtPhone.Text = "0712345678"
        original = (txtFirstName.Text, txtLastName.Text, txtPhone.Text)
    End Sub

    ' ---------- Edit mode ----------
    ' Admission number and email are always read-only; only name and phone can change.
    Private Sub SetEditMode(editing As Boolean)
        txtAdmissionNo.ReadOnly = True
        txtEmail.ReadOnly = True
        txtFirstName.ReadOnly = Not editing
        txtLastName.ReadOnly = Not editing
        txtPhone.ReadOnly = Not editing
        btnEdit.Visible = Not editing
        btnSave.Visible = editing
        btnCancel.Visible = editing
        btnChangePhoto.Enabled = editing
        lblMessage.Text = ""
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SetEditMode(True)
        txtFirstName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtFirstName.Text = original.First
        txtLastName.Text = original.Last
        txtPhone.Text = original.Phone
        SetEditMode(False)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtLastName.Text) Then
            lblMessage.ForeColor = Color.Firebrick
            lblMessage.Text = "First name and last name are required."
            Return
        End If
        If Not Regex.IsMatch(txtPhone.Text.Trim(), "^\+?\d{9,15}$") Then
            lblMessage.ForeColor = Color.Firebrick
            lblMessage.Text = "Enter a valid phone number (digits only, 9-15)."
            Return
        End If

        ' TODO: studentService.UpdateProfile(CurrentSession.UserId, first, last, phone)
        ' Use the Core method (parameterized SQL) - never SQL in this click handler.

        original = (txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtPhone.Text.Trim())
        SetEditMode(False)
        lblMessage.ForeColor = Color.DarkGreen
        lblMessage.Text = "Profile updated successfully."
    End Sub

    Private Sub btnChangePhoto_Click(sender As Object, e As EventArgs) Handles btnChangePhoto.Click
        Using dlg As New OpenFileDialog With {.Filter = "Images|*.png;*.jpg;*.jpeg"}
            If dlg.ShowDialog() = DialogResult.OK Then
                picProfile.Image = Image.FromFile(dlg.FileName)
                ' TODO: save the photo path/bytes through Core if the team supports photos
            End If
        End Using
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ' TODO: open frmChangePassword once it is pushed
        MessageBox.Show("Change Password is not connected yet.")
    End Sub

End Class