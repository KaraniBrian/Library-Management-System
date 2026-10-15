<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowseBooks
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
        lblUserSearch = New Label()
        txtUserSearch = New TextBox()
        btnUserSearch = New Button()
        dgvUserSearchBooks = New DataGridView()
        ISBN = New DataGridViewTextBoxColumn()
        Title = New DataGridViewTextBoxColumn()
        Author = New DataGridViewTextBoxColumn()
        Category = New DataGridViewTextBoxColumn()
        Available = New DataGridViewTextBoxColumn()
        View = New DataGridViewButtonColumn()
        CType(dgvUserSearchBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUserSearch
        ' 
        lblUserSearch.AutoSize = True
        lblUserSearch.BackColor = Color.Lime
        lblUserSearch.Location = New Point(3, 25)
        lblUserSearch.Name = "lblUserSearch"
        lblUserSearch.Padding = New Padding(15, 5, 15, 5)
        lblUserSearch.Size = New Size(123, 30)
        lblUserSearch.TabIndex = 0
        lblUserSearch.Text = "Search here :"
        ' 
        ' txtUserSearch
        ' 
        txtUserSearch.Location = New Point(156, 28)
        txtUserSearch.Name = "txtUserSearch"
        txtUserSearch.PlaceholderText = "Search by title, ISBN or author......"
        txtUserSearch.Size = New Size(443, 27)
        txtUserSearch.TabIndex = 1
        ' 
        ' btnUserSearch
        ' 
        btnUserSearch.BackColor = Color.Lime
        btnUserSearch.Location = New Point(690, 14)
        btnUserSearch.Name = "btnUserSearch"
        btnUserSearch.Size = New Size(134, 55)
        btnUserSearch.TabIndex = 2
        btnUserSearch.Text = "Search"
        btnUserSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvUserSearchBooks
        ' 
        dgvUserSearchBooks.AllowUserToAddRows = False
        dgvUserSearchBooks.AllowUserToDeleteRows = False
        dgvUserSearchBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUserSearchBooks.BackgroundColor = Color.Lime
        dgvUserSearchBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUserSearchBooks.Columns.AddRange(New DataGridViewColumn() {ISBN, Title, Author, Category, Available, View})
        dgvUserSearchBooks.Location = New Point(3, 171)
        dgvUserSearchBooks.Name = "dgvUserSearchBooks"
        dgvUserSearchBooks.ReadOnly = True
        dgvUserSearchBooks.RowHeadersWidth = 51
        dgvUserSearchBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUserSearchBooks.Size = New Size(821, 274)
        dgvUserSearchBooks.TabIndex = 3
        ' 
        ' ISBN
        ' 
        ISBN.HeaderText = "ISBN"
        ISBN.MinimumWidth = 6
        ISBN.Name = "ISBN"
        ISBN.ReadOnly = True
        ' 
        ' Title
        ' 
        Title.HeaderText = "Title"
        Title.MinimumWidth = 6
        Title.Name = "Title"
        Title.ReadOnly = True
        ' 
        ' Author
        ' 
        Author.HeaderText = "Author"
        Author.MinimumWidth = 6
        Author.Name = "Author"
        Author.ReadOnly = True
        ' 
        ' Category
        ' 
        Category.HeaderText = "Category"
        Category.MinimumWidth = 6
        Category.Name = "Category"
        Category.ReadOnly = True
        ' 
        ' Available
        ' 
        Available.HeaderText = "Available"
        Available.MinimumWidth = 6
        Available.Name = "Available"
        Available.ReadOnly = True
        ' 
        ' View
        ' 
        View.HeaderText = "View"
        View.MinimumWidth = 6
        View.Name = "View"
        View.ReadOnly = True
        ' 
        ' BrowseBooks
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Aqua
        ClientSize = New Size(846, 640)
        Controls.Add(dgvUserSearchBooks)
        Controls.Add(btnUserSearch)
        Controls.Add(txtUserSearch)
        Controls.Add(lblUserSearch)
        Name = "BrowseBooks"
        Text = "Browse Books"
        CType(dgvUserSearchBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUserSearch As Label
    Friend WithEvents txtUserSearch As TextBox
    Friend WithEvents btnUserSearch As Button
    Friend WithEvents dgvUserSearchBooks As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Available As DataGridViewTextBoxColumn
    Friend WithEvents View As DataGridViewButtonColumn
End Class
