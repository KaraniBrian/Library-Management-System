<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvailableBooks
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
        lblHeading = New Label()
        Label1 = New Label()
        lblSubHeading = New Label()
        lblSearch = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnRefresh = New Button()
        dgvBooks = New DataGridView()
        btnBack = New Button()
        colBookID = New DataGridViewTextBoxColumn()
        colTitle = New DataGridViewTextBoxColumn()
        colAuthor = New DataGridViewTextBoxColumn()
        colCategory = New DataGridViewTextBoxColumn()
        colQuantity = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.BackColor = Color.ForestGreen
        lblHeading.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.White
        lblHeading.Location = New Point(20, 0)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(940, 60)
        lblHeading.TabIndex = 0
        lblHeading.Text = "LIBRARY MANAGEMENT SYSTEM"
        lblHeading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' lblSubHeading
        ' 
        lblSubHeading.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubHeading.ForeColor = Color.Green
        lblSubHeading.Location = New Point(20, 90)
        lblSubHeading.Name = "lblSubHeading"
        lblSubHeading.Size = New Size(940, 35)
        lblSubHeading.TabIndex = 2
        lblSubHeading.Text = "Available Books"
        lblSubHeading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSearch.ForeColor = Color.Green
        lblSearch.Location = New Point(156, 153)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(162, 17)
        lblSearch.TabIndex = 3
        lblSearch.Text = "Search by Title or Author:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(339, 150)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(300, 25)
        txtSearch.TabIndex = 4
        txtSearch.Text = "Clear This Existing Text"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Green
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(679, 147)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(90, 30)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.SlateGray
        btnRefresh.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(793, 145)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(90, 30)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvBooks
        ' 
        dgvBooks.AllowUserToAddRows = False
        dgvBooks.AllowUserToDeleteRows = False
        dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBooks.BackgroundColor = Color.Green
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Columns.AddRange(New DataGridViewColumn() {colBookID, colTitle, colAuthor, colCategory, colQuantity, colStatus})
        dgvBooks.Location = New Point(276, 206)
        dgvBooks.MultiSelect = False
        dgvBooks.Name = "dgvBooks"
        dgvBooks.SelectionMode = DataGridViewSelectionMode.FullColumnSelect
        dgvBooks.Size = New Size(533, 302)
        dgvBooks.TabIndex = 7
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DimGray
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(802, 514)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(120, 35)
        btnBack.TabIndex = 8
        btnBack.Text = "Back To Menu"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' colBookID
        ' 
        colBookID.HeaderText = "Book ID"
        colBookID.Name = "colBookID"
        colBookID.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colTitle
        ' 
        colTitle.HeaderText = "Title"
        colTitle.Name = "colTitle"
        colTitle.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colAuthor
        ' 
        colAuthor.HeaderText = "Author"
        colAuthor.Name = "colAuthor"
        colAuthor.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colCategory
        ' 
        colCategory.HeaderText = "Category"
        colCategory.Name = "colCategory"
        colCategory.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colQuantity
        ' 
        colQuantity.HeaderText = "Quantity"
        colQuantity.Name = "colQuantity"
        colQuantity.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' AvailableBooks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(984, 561)
        Controls.Add(btnBack)
        Controls.Add(dgvBooks)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(lblSubHeading)
        Controls.Add(Label1)
        Controls.Add(lblHeading)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "AvailableBooks"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AvailableBooks"
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubHeading As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents colBookID As DataGridViewTextBoxColumn
    Friend WithEvents colTitle As DataGridViewTextBoxColumn
    Friend WithEvents colAuthor As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
End Class
