Public Class ReturnBook
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        If txtBookID.Text.Trim() = "" OrElse
   txtBorrowerName.Text.Trim() = "" Then

            MessageBox.Show("Please enter the Book ID and Borrower Name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show("Return details entered successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtBookID.Clear()
        txtBorrowerName.Clear()
        dtpReturnDate.Value = DateTime.Now

    End Sub
End Class
