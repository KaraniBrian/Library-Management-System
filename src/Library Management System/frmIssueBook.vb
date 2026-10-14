Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

' Page 7 - Issue / Borrow Book (librarian)
Public Class frmIssueBook

    Private Const DefaultLoanDays As Integer = 14   ' TODO: read from Library Settings (Page 12)

    Private Sub frmIssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
        LoadBooks()
        ResetDates()
    End Sub

    ' ---------- Data (placeholders until Core is ready) ----------
    ' TODO: replace with calls into LibraryManagement.Core (no SQL in this form)
    Private Sub LoadStudents()
        ' TODO: studentService.GetActiveStudents()
        Dim dt As New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Rows.Add(1, "S001 - Alice Brown")
        dt.Rows.Add(2, "S002 - Bob Smith")
        dt.Rows.Add(3, "S003 - Carol White")
        cmbStudent.DataSource = dt
        cmbStudent.DisplayMember = "Name"
        cmbStudent.ValueMember = "Id"
        cmbStudent.SelectedIndex = -1
    End Sub

    Private Sub LoadBooks()
        ' TODO: bookService.GetAllBooks()
        Dim dt As New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Title", GetType(String))
        dt.Rows.Add(1, "Clean Code")
        dt.Rows.Add(2, "The Hobbit")
        dt.Rows.Add(3, "Python Basics")
        cmbBook.DataSource = dt
        cmbBook.DisplayMember = "Title"
        cmbBook.ValueMember = "Id"
        cmbBook.SelectedIndex = -1
    End Sub

    Private Function GetAvailableCopies(bookId As Integer) As DataTable
        ' TODO: copyService.GetAvailableCopies(bookId)
        Dim dt As New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Label", GetType(String))
        Select Case bookId
            Case 1
                dt.Rows.Add(101, "Copy #101")
                dt.Rows.Add(102, "Copy #102")
            Case 2
                dt.Rows.Add(201, "Copy #201")
                ' Book 3 has no available copies (to demo the empty case)
        End Select
        Return dt
    End Function

    ' ---------- Events ----------
    ' SelectionChangeCommitted fires only when the user picks an item
    Private Sub cmbBook_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbBook.SelectionChangeCommitted
        If cmbBook.SelectedValue Is Nothing Then Return

        Dim copies As DataTable = GetAvailableCopies(CInt(cmbBook.SelectedValue))
        cmbBookCopy.DataSource = copies
        cmbBookCopy.DisplayMember = "Label"
        cmbBookCopy.ValueMember = "Id"
        cmbBookCopy.SelectedIndex = If(copies.Rows.Count > 0, 0, -1)

        If copies.Rows.Count = 0 Then
            txtAvailability.Text = "No copies available"
        Else
            txtAvailability.Text = copies.Rows.Count & " copy(ies) available"
        End If
        lblMessage.Text = ""
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        If cmbStudent.SelectedIndex < 0 Then
            ShowError("Select a student.")
            Return
        End If
        If cmbBook.SelectedIndex < 0 Then
            ShowError("Select a book.")
            Return
        End If
        If cmbBookCopy.SelectedIndex < 0 Then
            ShowError("No available copy to issue for this book.")
            Return
        End If
        If dtpDueDate.Value.Date <= dtpIssueDate.Value.Date Then
            ShowError("The due date must be after the issue date.")
            Return
        End If

        ' TODO: also check student eligibility (max books, unpaid fines) via Core

        Dim summary As String = $"Issue ""{cmbBook.Text}"" ({cmbBookCopy.Text}) to {cmbStudent.Text}?" &
                                vbCrLf & "Due date: " & dtpDueDate.Value.ToString("yyyy-MM-dd")
        If MessageBox.Show(summary, "Confirm Issue", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        ' TODO: loanService.IssueBook(studentId, copyId, issueDate, dueDate)
        '       Core must save the loan AND mark the copy unavailable in ONE transaction.

        Dim issuedTo As String = cmbStudent.Text
        ClearForm()
        lblMessage.ForeColor = Color.DarkGreen
        lblMessage.Text = "Book issued to " & issuedTo & "."
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' ---------- Helpers ----------
    Private Sub ResetDates()
        dtpIssueDate.Value = Date.Today
        dtpDueDate.MinDate = Date.Today.AddDays(1)
        dtpDueDate.Value = Date.Today.AddDays(DefaultLoanDays)
    End Sub

    Private Sub ClearForm()
        cmbStudent.SelectedIndex = -1
        cmbBook.SelectedIndex = -1
        cmbBookCopy.DataSource = Nothing
        txtAvailability.Clear()
        ResetDates()
        lblMessage.Text = ""
    End Sub

    Private Sub ShowError(text As String)
        lblMessage.ForeColor = Color.Firebrick
        lblMessage.Text = text
    End Sub

End Class