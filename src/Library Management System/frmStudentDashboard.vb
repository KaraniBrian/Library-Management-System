Imports System.Data
Imports System.Windows.Forms

' Page 13 - Student Dashboard (logic only; controls live in frmStudentDashboard.Designer.vb)
Public Class frmStudentDashboard

    Private Sub frmStudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSummary()
    End Sub

    ' ---------- Data ----------
    ' TODO: replace the placeholders with calls into LibraryManagement.Core
    ' (ask the teammate who owns borrowing/fines for the method names).
    ' Do NOT write SQL here - and only load the LOGGED-IN student's own data.
    Private Sub LoadSummary()
        ' lblWelcome.Text = "Welcome, " & currentStudent.FirstName
        ' lblBorrowedBooksValue.Text = loanService.CountActiveLoans(studentId).ToString()
        ' lblDueSoonValue.Text = loanService.CountDueSoon(studentId).ToString()
        ' lblOverdueValue.Text = loanService.CountOverdue(studentId).ToString()
        ' lblFineBalanceValue.Text = "KES " & fineService.GetOutstanding(studentId).ToString("N2")
        ' dgvMyBorrowings.DataSource = loanService.GetRecentLoans(studentId)

        ' Temporary sample data so the grid shows something while Core isn't ready
        Dim dt As New DataTable()
        dt.Columns.Add("Title")
        dt.Columns.Add("Borrow Date")
        dt.Columns.Add("Due Date")
        dt.Columns.Add("Status")
        dt.Rows.Add("Clean Code", "2025-05-01", "2025-05-15", "Active")
        dt.Rows.Add("The Hobbit", "2025-04-28", "2025-05-12", "Overdue")
        dgvMyBorrowings.DataSource = dt
        dgvMyBorrowings.ClearSelection()
    End Sub

    ' ---------- Navigation ----------
    Private Sub ShowHome()
        pnlPageHost.Controls.Clear()
        pnlPageHost.Visible = False
        pnlHome.Visible = True
        LoadSummary()
    End Sub

    Private Sub ShowPage(page As Form)
        pnlPageHost.Controls.Clear()
        page.TopLevel = False
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill
        pnlPageHost.Controls.Add(page)
        pnlHome.Visible = False
        pnlPageHost.Visible = True
        page.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowHome()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ShowPage(New frmProfile())
    End Sub

    ' Pages owned by teammates - hook these up once their forms are pushed
    Private Sub btnCatalogue_Click(sender As Object, e As EventArgs) Handles btnCatalogue.Click
        ' ShowPage(New BookCatalogueForm())
        MessageBox.Show("Browse Books is not connected yet.")
    End Sub

    Private Sub btnMyBorrowedBooks_Click(sender As Object, e As EventArgs) Handles btnMyBorrowedBooks.Click
        ' ShowPage(New MyBorrowedBooksForm())
        MessageBox.Show("My Borrowed Books is not connected yet.")
    End Sub

    Private Sub btnMyFines_Click(sender As Object, e As EventArgs) Handles btnMyFines.Click
        ' ShowPage(New MyFinesForm())
        MessageBox.Show("My Fines and Payments is not connected yet.")
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ' ShowPage(New ChangePasswordForm())
        MessageBox.Show("Change Password is not connected yet.")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            ' TODO: clear the session, then show frmLogin
            Me.Close()
        End If
    End Sub

End Class