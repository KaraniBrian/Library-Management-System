Imports Library_Management_system

Public Class BorrowBook

    Private Sub btnBorrow_Click(sender As Object,
                                e As EventArgs) Handles btnBorrow.Click

        If txtBookID.Text.Trim() = "" OrElse
           txtBorrowerName.Text.Trim() = "" Then

            MessageBox.Show("Please enter the Book ID and Borrower Name.",
                            "Missing Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show("Borrow details entered successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBookID.Clear()
        txtBorrowerName.Clear()
        dtpBorrowDate.Value = DateTime.Now
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmDashboard.Show()
        Me.Close()
    End Sub
End Class
