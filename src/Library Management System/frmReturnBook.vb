Imports System.Drawing
Imports System.Windows.Forms

' Page 8 - Return Book (librarian): look up a loan by Borrowing ID, review details, confirm return
Public Class frmReturnBook

    Private Const FineRatePerDay As Decimal = 1D   ' TODO: read from Library Settings (Page 12)

    ' Simple holder for the looked-up loan (replace with Core's loan model later)
    Private Class LoanInfo
        Public Property BorrowingId As String
        Public Property StudentName As String
        Public Property BookTitle As String
        Public Property IssueDate As Date
        Public Property DueDate As Date
        Public Property IsReturned As Boolean
    End Class

    Private currentLoan As LoanInfo
    Private currentFine As Decimal

    Private Sub frmReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearDetails()
    End Sub

    ' ---------- Data (placeholder) ----------
    ' TODO: loanService.FindLoan(borrowingId) from LibraryManagement.Core (no SQL here)
    ' Try IDs B001 (active), B002 (overdue), B003 (already returned)
    Private Function FindLoan(id As String) As LoanInfo
        Select Case id.ToUpperInvariant()
            Case "B001"
                Return New LoanInfo With {.BorrowingId = "B001", .StudentName = "S001 - Alice Brown",
                    .BookTitle = "Clean Code", .IssueDate = Date.Today.AddDays(-9), .DueDate = Date.Today.AddDays(5)}
            Case "B002"
                Return New LoanInfo With {.BorrowingId = "B002", .StudentName = "S002 - Bob Smith",
                    .BookTitle = "The Hobbit", .IssueDate = Date.Today.AddDays(-18), .DueDate = Date.Today.AddDays(-4)}
            Case "B003"
                Return New LoanInfo With {.BorrowingId = "B003", .StudentName = "S003 - Carol White",
                    .BookTitle = "Python Basics", .IssueDate = Date.Today.AddDays(-30), .DueDate = Date.Today.AddDays(-16),
                    .IsReturned = True}
            Case Else
                Return Nothing
        End Select
    End Function

    ' ---------- Lookup ----------
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim id As String = txtSearch.Text.Trim()
        If id = "" Then
            ShowError("Enter a Borrowing ID.")
            Return
        End If

        Dim loan As LoanInfo = FindLoan(id)
        If loan Is Nothing Then
            ClearDetails()
            ShowError("No loan found for Borrowing ID '" & id & "'.")
            Return
        End If
        If loan.IsReturned Then
            ClearDetails()
            ShowError("That book has already been returned.")
            Return
        End If

        currentLoan = loan
        txtStudent.Text = loan.StudentName
        txtBook.Text = loan.BookTitle
        txtIssueDate.Text = loan.IssueDate.ToString("yyyy-MM-dd")
        txtDueDate.Text = loan.DueDate.ToString("yyyy-MM-dd")

        dtpReturnDate.MinDate = loan.IssueDate
        dtpReturnDate.Value = Date.Today
        SetLoanLoaded(True)
        CalculateFine()
        lblMessage.Text = ""
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSearch.PerformClick()
        End If
    End Sub

    ' ---------- Fine ----------
    Private Sub CalculateFine()
        If currentLoan Is Nothing Then Return
        Dim daysLate As Integer = Math.Max(0, (dtpReturnDate.Value.Date - currentLoan.DueDate.Date).Days)
        currentFine = daysLate * FineRatePerDay
        txtFine.Text = "KES " & currentFine.ToString("N2")
        If daysLate > 0 Then
            lblMessage.ForeColor = Color.Firebrick
            lblMessage.Text = daysLate & " day(s) overdue."
        Else
            lblMessage.Text = ""
        End If
    End Sub

    Private Sub dtpReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReturnDate.ValueChanged
        CalculateFine()
    End Sub

    Private Sub btnCalculateFine_Click(sender As Object, e As EventArgs) Handles btnCalculateFine.Click
        CalculateFine()
    End Sub

    ' ---------- Confirm return ----------
    Private Sub btnProcessReturn_Click(sender As Object, e As EventArgs) Handles btnProcessReturn.Click
        If currentLoan Is Nothing Then
            ShowError("Look up a Borrowing ID first.")
            Return
        End If

        Dim text As String = $"Confirm return of ""{currentLoan.BookTitle}"" from {currentLoan.StudentName}?"
        If currentFine > 0 Then
            text &= vbCrLf & "Fine due: KES " & currentFine.ToString("N2")
        End If
        If MessageBox.Show(text, "Confirm Return", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        ' TODO: loanService.ReturnBook(currentLoan.BorrowingId, dtpReturnDate.Value, currentFine)
        '       Core must record the return, create the fine (if any) and mark the copy
        '       available again in ONE transaction.

        Dim title As String = currentLoan.BookTitle
        txtSearch.Clear()
        ClearDetails()
        lblMessage.ForeColor = Color.DarkGreen
        lblMessage.Text = """" & title & """ returned successfully."
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' ---------- Helpers ----------
    Private Sub SetLoanLoaded(loaded As Boolean)
        dtpReturnDate.Enabled = loaded
        btnCalculateFine.Enabled = loaded
        btnProcessReturn.Enabled = loaded
    End Sub

    Private Sub ClearDetails()
        currentLoan = Nothing
        currentFine = 0D
        txtStudent.Clear()
        txtBook.Clear()
        txtIssueDate.Clear()
        txtDueDate.Clear()
        txtFine.Clear()
        dtpReturnDate.MinDate = DateTimePicker.MinimumDateTime
        dtpReturnDate.Value = Date.Today
        SetLoanLoaded(False)
        lblMessage.Text = ""
    End Sub

    Private Sub ShowError(text As String)
        lblMessage.ForeColor = Color.Firebrick
        lblMessage.Text = text
    End Sub

End Class