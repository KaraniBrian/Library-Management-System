Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.Text
Imports System.Windows.Forms

' Page 10 - Borrowing / Returns Records (librarian): master loan table with filters and status colours
Public Class frmBorrowingRecords

    Private allRecords As DataTable
    Private view As DataView

    Private Sub frmBorrowingRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.Items.AddRange(New Object() {"All", "Active", "Returned", "Overdue"})
        cmbStatus.SelectedIndex = 0
        ResetDates()
        LoadRecords()
    End Sub

    ' ---------- Data (placeholder) ----------
    ' TODO: replace with loanService.GetAllLoans() from LibraryManagement.Core (no SQL here).
    ' Status should come from Core/the database; the helper below only fakes it.
    Private Sub LoadRecords()
        Dim dt As New DataTable()
        dt.Columns.Add("Loan ID", GetType(String))
        dt.Columns.Add("Student", GetType(String))
        dt.Columns.Add("Book", GetType(String))
        dt.Columns.Add("Borrow Date", GetType(Date))
        dt.Columns.Add("Due Date", GetType(Date))
        dt.Columns.Add("Return Date", GetType(Date))
        dt.Columns.Add("Status", GetType(String))

        Dim today As Date = Date.Today
        AddLoan(dt, "B001", "Alice Brown", "Clean Code", today.AddDays(-5), today.AddDays(9), Nothing)
        AddLoan(dt, "B002", "Bob Smith", "The Hobbit", today.AddDays(-20), today.AddDays(-6), Nothing)
        AddLoan(dt, "B003", "Carol White", "Python Basics", today.AddDays(-30), today.AddDays(-16), today.AddDays(-14))
        AddLoan(dt, "B004", "Alice Brown", "The Hobbit", today.AddDays(-2), today.AddDays(12), Nothing)
        AddLoan(dt, "B005", "Bob Smith", "Clean Code", today.AddDays(-40), today.AddDays(-26), Nothing)

        allRecords = dt
        view = New DataView(dt)
        dgvRecords.DataSource = view

        For Each name As String In New String() {"Borrow Date", "Due Date", "Return Date"}
            dgvRecords.Columns(name).DefaultCellStyle.Format = "yyyy-MM-dd"
        Next
        ApplyFilters()
    End Sub

    Private Sub AddLoan(dt As DataTable, id As String, student As String, book As String,
                        borrowed As Date, due As Date, returned As Date?)
        Dim row As DataRow = dt.NewRow()
        row("Loan ID") = id
        row("Student") = student
        row("Book") = book
        row("Borrow Date") = borrowed
        row("Due Date") = due
        row("Return Date") = If(returned.HasValue, CObj(returned.Value), DBNull.Value)
        row("Status") = If(returned.HasValue, "Returned", If(due < Date.Today, "Overdue", "Active"))
        dt.Rows.Add(row)
    End Sub

    ' ---------- Filtering ----------
    Private Sub ApplyFilters()
        If view Is Nothing Then Return

        If dtpFromDate.Value.Date > dtpToDate.Value.Date Then
            MessageBox.Show("The From date can't be after the To date.", "Date range",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim parts As New List(Of String)

        Dim text As String = txtSearch.Text.Trim()
        If text <> "" Then
            Dim t As String = EscapeLike(text)
            parts.Add($"([Loan ID] LIKE '%{t}%' OR [Student] LIKE '%{t}%' OR [Book] LIKE '%{t}%')")
        End If

        If cmbStatus.Text <> "All" AndAlso cmbStatus.Text <> "" Then
            parts.Add($"[Status] = '{cmbStatus.Text}'")
        End If

        Dim fromText As String = dtpFromDate.Value.Date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
        Dim toText As String = dtpToDate.Value.Date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
        parts.Add($"[Borrow Date] >= #{fromText}# AND [Borrow Date] <= #{toText} 23:59:59#")

        view.RowFilter = String.Join(" AND ", parts)
        lblRecordCount.Text = "Records: " & view.Count
    End Sub

    Private Function EscapeLike(s As String) As String
        Dim sb As New StringBuilder()
        For Each c As Char In s
            Select Case c
                Case "'"c
                    sb.Append("''")
                Case "["c, "]"c, "%"c, "*"c
                    sb.Append("[").Append(c).Append("]")
                Case Else
                    sb.Append(c)
            End Select
        Next
        Return sb.ToString()
    End Function

    Private Sub ResetDates()
        dtpFromDate.Value = Date.Today.AddMonths(-6)
        dtpToDate.Value = Date.Today
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilters()
    End Sub

    Private Sub cmbStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbStatus.SelectionChangeCommitted
        ApplyFilters()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        ApplyFilters()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSearch.Clear()
        cmbStatus.SelectedIndex = 0
        ResetDates()
        ApplyFilters()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRecords()
    End Sub

    ' ---------- Status indicators ----------
    Private Sub dgvRecords_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRecords.CellFormatting
        If e.RowIndex < 0 OrElse dgvRecords.Columns(e.ColumnIndex).Name <> "Status" Then Return

        Select Case Convert.ToString(e.Value)
            Case "Active"
                e.CellStyle.ForeColor = Color.DarkGreen
                e.CellStyle.BackColor = Color.Honeydew
            Case "Overdue"
                e.CellStyle.ForeColor = Color.Firebrick
                e.CellStyle.BackColor = Color.MistyRose
            Case "Returned"
                e.CellStyle.ForeColor = Color.DimGray
                e.CellStyle.BackColor = Color.Gainsboro
        End Select
    End Sub

    ' ---------- Details / export ----------
    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        Dim drv As DataRowView = TryCast(dgvRecords.CurrentRow?.DataBoundItem, DataRowView)
        If drv Is Nothing Then
            MessageBox.Show("Select a record first.", "View Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim returned As String = If(drv("Return Date") Is DBNull.Value, "Not returned yet",
                                    CDate(drv("Return Date")).ToString("yyyy-MM-dd"))
        MessageBox.Show(
            "Loan ID: " & drv("Loan ID").ToString() & vbCrLf &
            "Student: " & drv("Student").ToString() & vbCrLf &
            "Book: " & drv("Book").ToString() & vbCrLf &
            "Borrowed: " & CDate(drv("Borrow Date")).ToString("yyyy-MM-dd") & vbCrLf &
            "Due: " & CDate(drv("Due Date")).ToString("yyyy-MM-dd") & vbCrLf &
            "Returned: " & returned & vbCrLf &
            "Status: " & drv("Status").ToString(),
            "Loan Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If view Is Nothing OrElse view.Count = 0 Then
            MessageBox.Show("There are no records to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using sfd As New SaveFileDialog With {.Filter = "CSV files|*.csv", .FileName = "borrowing-records.csv"}
            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Dim sb As New StringBuilder()
            Dim headers As New List(Of String)
            For Each col As DataColumn In allRecords.Columns
                headers.Add(col.ColumnName)
            Next
            sb.AppendLine(String.Join(",", headers))

            For Each drv As DataRowView In view
                Dim fields As New List(Of String)
                For Each col As DataColumn In allRecords.Columns
                    Dim v As Object = drv(col.ColumnName)
                    Dim cell As String = ""
                    If TypeOf v Is Date Then
                        cell = CDate(v).ToString("yyyy-MM-dd")
                    ElseIf v IsNot DBNull.Value Then
                        cell = v.ToString()
                    End If
                    fields.Add("""" & cell.Replace("""", """""") & """")
                Next
                sb.AppendLine(String.Join(",", fields))
            Next

            IO.File.WriteAllText(sfd.FileName, sb.ToString(), New UTF8Encoding(True))
        End Using
    End Sub

End Class