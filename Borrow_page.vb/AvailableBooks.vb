Public Class AvailableBooks

    Private Sub AvailableBooks_Load(sender As Object,
                                   e As EventArgs) Handles MyBase.Load

        dgvBooks.Rows.Clear()

        dgvBooks.Rows.Add("B001", "Things Fall Apart",
                          "Chinua Achebe", "Fiction", 5, "Available")

        dgvBooks.Rows.Add("B002", "The River Between",
                          "Ngugi wa Thiong'o", "Fiction", 0, "Borrowed")

        dgvBooks.Rows.Add("B003", "Animal Farm",
                          "George Orwell", "Satire", 3, "Available")

    End Sub

End Class