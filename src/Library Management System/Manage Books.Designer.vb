<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageBooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtSearchOrAddBook = New TextBox()
        btnSearchBook1 = New Button()
        btnAddBook = New Button()
        dgvManageBooks = New DataGridView()
        ISBNColumn = New DataGridViewTextBoxColumn()
        TitleColumn = New DataGridViewTextBoxColumn()
        AuthorColumn = New DataGridViewTextBoxColumn()
        CategoryColumn = New DataGridViewTextBoxColumn()
        StockColumn = New DataGridViewTextBoxColumn()
        EditColumn = New DataGridViewButtonColumn()
        DeleteColumn = New DataGridViewButtonColumn()
        lblManageBookSearch = New Label()
        CType(dgvManageBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearchOrAddBook
        ' 
        txtSearchOrAddBook.Location = New Point(124, 31)
        txtSearchOrAddBook.Name = "txtSearchOrAddBook"
        txtSearchOrAddBook.PlaceholderText = "Search by title, ISBN or author......."
        txtSearchOrAddBook.Size = New Size(531, 27)
        txtSearchOrAddBook.TabIndex = 0
        ' 
        ' btnSearchBook1
        ' 
        btnSearchBook1.BackColor = Color.Lime
        btnSearchBook1.Location = New Point(678, 24)
        btnSearchBook1.Name = "btnSearchBook1"
        btnSearchBook1.Size = New Size(119, 41)
        btnSearchBook1.TabIndex = 1
        btnSearchBook1.Text = "Search"
        btnSearchBook1.UseVisualStyleBackColor = False
        ' 
        ' btnAddBook
        ' 
        btnAddBook.BackColor = Color.Lime
        btnAddBook.Location = New Point(803, 24)
        btnAddBook.Name = "btnAddBook"
        btnAddBook.Size = New Size(101, 41)
        btnAddBook.TabIndex = 2
        btnAddBook.Text = "Add Book"
        btnAddBook.UseVisualStyleBackColor = False
        ' 
        ' dgvManageBooks
        ' 
        dgvManageBooks.AllowUserToAddRows = False
        dgvManageBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvManageBooks.BackgroundColor = Color.Lime
        dgvManageBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvManageBooks.Columns.AddRange(New DataGridViewColumn() {ISBNColumn, TitleColumn, AuthorColumn, CategoryColumn, StockColumn, EditColumn, DeleteColumn})
        dgvManageBooks.Location = New Point(75, 173)
        dgvManageBooks.Name = "dgvManageBooks"
        dgvManageBooks.RowHeadersWidth = 51
        dgvManageBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvManageBooks.Size = New Size(755, 352)
        dgvManageBooks.TabIndex = 3
        ' 
        ' ISBNColumn
        ' 
        ISBNColumn.HeaderText = "ISBN"
        ISBNColumn.MinimumWidth = 6
        ISBNColumn.Name = "ISBNColumn"
        ' 
        ' TitleColumn
        ' 
        TitleColumn.HeaderText = "Title"
        TitleColumn.MinimumWidth = 6
        TitleColumn.Name = "TitleColumn"
        ' 
        ' AuthorColumn
        ' 
        AuthorColumn.HeaderText = "Author"
        AuthorColumn.MinimumWidth = 6
        AuthorColumn.Name = "AuthorColumn"
        ' 
        ' CategoryColumn
        ' 
        CategoryColumn.HeaderText = "Category"
        CategoryColumn.MinimumWidth = 6
        CategoryColumn.Name = "CategoryColumn"
        ' 
        ' StockColumn
        ' 
        StockColumn.HeaderText = "Stock"
        StockColumn.MinimumWidth = 6
        StockColumn.Name = "StockColumn"
        ' 
        ' EditColumn
        ' 
        EditColumn.HeaderText = "Edit"
        EditColumn.MinimumWidth = 6
        EditColumn.Name = "EditColumn"
        ' 
        ' DeleteColumn
        ' 
        DeleteColumn.HeaderText = "Delete"
        DeleteColumn.MinimumWidth = 6
        DeleteColumn.Name = "DeleteColumn"
        ' 
        ' lblManageBookSearch
        ' 
        lblManageBookSearch.AutoSize = True
        lblManageBookSearch.BackColor = Color.Lime
        lblManageBookSearch.Location = New Point(8, 28)
        lblManageBookSearch.Name = "lblManageBookSearch"
        lblManageBookSearch.Padding = New Padding(25, 5, 25, 5)
        lblManageBookSearch.Size = New Size(110, 30)
        lblManageBookSearch.TabIndex = 4
        lblManageBookSearch.Text = "Search :"
        ' 
        ' ManageBooks
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Aqua
        ClientSize = New Size(916, 641)
        Controls.Add(lblManageBookSearch)
        Controls.Add(dgvManageBooks)
        Controls.Add(btnAddBook)
        Controls.Add(btnSearchBook1)
        Controls.Add(txtSearchOrAddBook)
        Name = "ManageBooks"
        Text = "Manage Books"
        CType(dgvManageBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearchOrAddBook As TextBox
    Friend WithEvents btnSearchBook1 As Button
    Friend WithEvents btnAddBook As Button
    Friend WithEvents dgvManageBooks As DataGridView
    Friend WithEvents ISBNColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditColumn As DataGridViewButtonColumn
    Friend WithEvents DeleteColumn As DataGridViewButtonColumn
    Friend WithEvents lblManageBookSearch As Label
End Class
