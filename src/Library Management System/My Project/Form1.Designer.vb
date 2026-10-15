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
        txtSearch = New TextBox()
        btnSearch = New Button()
        dgvSearchBooks = New DataGridView()
        IDColumn = New DataGridViewTextBoxColumn()
        TitleColumn = New DataGridViewTextBoxColumn()
        AuthorColumn = New DataGridViewTextBoxColumn()
        CategoryColumn = New DataGridViewTextBoxColumn()
        AvailableColumn = New DataGridViewTextBoxColumn()
        ViewColumn = New DataGridViewButtonColumn()
        CType(dgvSearchBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(12, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = " Search title, author or ISBN"
        txtSearch.Size = New Size(521, 27)
        txtSearch.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.LawnGreen
        btnSearch.Location = New Point(630, 12)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(135, 36)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvSearchBooks
        ' 
        dgvSearchBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSearchBooks.Columns.AddRange(New DataGridViewColumn() {IDColumn, TitleColumn, AuthorColumn, CategoryColumn, AvailableColumn, ViewColumn})
        dgvSearchBooks.Location = New Point(44, 120)
        dgvSearchBooks.Name = "dgvSearchBooks"
        dgvSearchBooks.RowHeadersWidth = 51
        dgvSearchBooks.Size = New Size(779, 436)
        dgvSearchBooks.TabIndex = 2
        ' 
        ' IDColumn
        ' 
        IDColumn.HeaderText = "ID"
        IDColumn.MinimumWidth = 6
        IDColumn.Name = "IDColumn"
        IDColumn.Width = 125
        ' 
        ' TitleColumn
        ' 
        TitleColumn.HeaderText = "Title"
        TitleColumn.MinimumWidth = 6
        TitleColumn.Name = "TitleColumn"
        TitleColumn.Width = 125
        ' 
        ' AuthorColumn
        ' 
        AuthorColumn.HeaderText = "Author"
        AuthorColumn.MinimumWidth = 6
        AuthorColumn.Name = "AuthorColumn"
        AuthorColumn.Width = 125
        ' 
        ' CategoryColumn
        ' 
        CategoryColumn.HeaderText = "Category"
        CategoryColumn.MinimumWidth = 6
        CategoryColumn.Name = "CategoryColumn"
        CategoryColumn.Width = 125
        ' 
        ' AvailableColumn
        ' 
        AvailableColumn.HeaderText = "Available"
        AvailableColumn.MinimumWidth = 6
        AvailableColumn.Name = "AvailableColumn"
        AvailableColumn.Width = 125
        ' 
        ' ViewColumn
        ' 
        ViewColumn.HeaderText = "View"
        ViewColumn.MinimumWidth = 6
        ViewColumn.Name = "ViewColumn"
        ViewColumn.Width = 125
        ' 
        ' BrowseBooks
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(931, 747)
        Controls.Add(dgvSearchBooks)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Name = "BrowseBooks"
        Text = "Browse Books"
        CType(dgvSearchBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvSearchBooks As DataGridView
    Friend WithEvents IDColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvailableColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViewColumn As DataGridViewButtonColumn
End Class
