<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        lblTitle = New Label()
        MenuStrip1 = New MenuStrip()
        BooksToolStripMenuItem = New ToolStripMenuItem()
        AddBookToolStripMenuItem = New ToolStripMenuItem()
        SearchBookToolStripMenuItem = New ToolStripMenuItem()
        ViewBooksToolStripMenuItem = New ToolStripMenuItem()
        MembersToolStripMenuItem = New ToolStripMenuItem()
        RegisterMemberToolStripMenuItem = New ToolStripMenuItem()
        ViewMembersToolStripMenuItem = New ToolStripMenuItem()
        SearchMembersToolStripMenuItem = New ToolStripMenuItem()
        BorrowReturnToolStripMenuItem = New ToolStripMenuItem()
        BorrowBookToolStripMenuItem = New ToolStripMenuItem()
        ReturnBookToolStripMenuItem = New ToolStripMenuItem()
        RToolStripMenuItem = New ToolStripMenuItem()
        RecordsToolStripMenuItem = New ToolStripMenuItem()
        MonthlyRToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Panel1 = New Panel()
        btnAvailableBooks = New Button()
        Button1 = New Button()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Segoe UI", 14F)
        lblTitle.ForeColor = Color.DarkGreen
        lblTitle.Location = New Point(0, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(336, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Library Management System Dashboar"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {BooksToolStripMenuItem, MembersToolStripMenuItem, BorrowReturnToolStripMenuItem, RToolStripMenuItem})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(1084, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' BooksToolStripMenuItem
        ' 
        BooksToolStripMenuItem.BackColor = Color.WhiteSmoke
        BooksToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddBookToolStripMenuItem, SearchBookToolStripMenuItem, ViewBooksToolStripMenuItem})
        BooksToolStripMenuItem.ForeColor = Color.DarkGreen
        BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        BooksToolStripMenuItem.Size = New Size(51, 20)
        BooksToolStripMenuItem.Text = "Books"
        ' 
        ' AddBookToolStripMenuItem
        ' 
        AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem"
        AddBookToolStripMenuItem.Size = New Size(144, 22)
        AddBookToolStripMenuItem.Text = "Add Book"
        ' 
        ' SearchBookToolStripMenuItem
        ' 
        SearchBookToolStripMenuItem.Name = "SearchBookToolStripMenuItem"
        SearchBookToolStripMenuItem.Size = New Size(144, 22)
        SearchBookToolStripMenuItem.Text = "Search Books"
        ' 
        ' ViewBooksToolStripMenuItem
        ' 
        ViewBooksToolStripMenuItem.Name = "ViewBooksToolStripMenuItem"
        ViewBooksToolStripMenuItem.Size = New Size(144, 22)
        ViewBooksToolStripMenuItem.Text = "View Books"
        ' 
        ' MembersToolStripMenuItem
        ' 
        MembersToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegisterMemberToolStripMenuItem, ViewMembersToolStripMenuItem, SearchMembersToolStripMenuItem})
        MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        MembersToolStripMenuItem.Size = New Size(69, 20)
        MembersToolStripMenuItem.Text = "Members"
        ' 
        ' RegisterMemberToolStripMenuItem
        ' 
        RegisterMemberToolStripMenuItem.Name = "RegisterMemberToolStripMenuItem"
        RegisterMemberToolStripMenuItem.Size = New Size(164, 22)
        RegisterMemberToolStripMenuItem.Text = "Register Member"
        ' 
        ' ViewMembersToolStripMenuItem
        ' 
        ViewMembersToolStripMenuItem.Name = "ViewMembersToolStripMenuItem"
        ViewMembersToolStripMenuItem.Size = New Size(164, 22)
        ViewMembersToolStripMenuItem.Text = "View Members"
        ' 
        ' SearchMembersToolStripMenuItem
        ' 
        SearchMembersToolStripMenuItem.Name = "SearchMembersToolStripMenuItem"
        SearchMembersToolStripMenuItem.Size = New Size(164, 22)
        SearchMembersToolStripMenuItem.Text = "Search Members"
        ' 
        ' BorrowReturnToolStripMenuItem
        ' 
        BorrowReturnToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BorrowBookToolStripMenuItem, ReturnBookToolStripMenuItem})
        BorrowReturnToolStripMenuItem.Name = "BorrowReturnToolStripMenuItem"
        BorrowReturnToolStripMenuItem.Size = New Size(97, 20)
        BorrowReturnToolStripMenuItem.Text = "Borrow/Return"
        ' 
        ' BorrowBookToolStripMenuItem
        ' 
        BorrowBookToolStripMenuItem.Name = "BorrowBookToolStripMenuItem"
        BorrowBookToolStripMenuItem.Size = New Size(142, 22)
        BorrowBookToolStripMenuItem.Text = "Borrow Book"
        ' 
        ' ReturnBookToolStripMenuItem
        ' 
        ReturnBookToolStripMenuItem.Name = "ReturnBookToolStripMenuItem"
        ReturnBookToolStripMenuItem.Size = New Size(142, 22)
        ReturnBookToolStripMenuItem.Text = "Return Book"
        ' 
        ' RToolStripMenuItem
        ' 
        RToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RecordsToolStripMenuItem, MonthlyRToolStripMenuItem})
        RToolStripMenuItem.Name = "RToolStripMenuItem"
        RToolStripMenuItem.Size = New Size(61, 20)
        RToolStripMenuItem.Text = "Records"
        ' 
        ' RecordsToolStripMenuItem
        ' 
        RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        RecordsToolStripMenuItem.Size = New Size(157, 22)
        RecordsToolStripMenuItem.Text = "Daily Report"
        ' 
        ' MonthlyRToolStripMenuItem
        ' 
        MonthlyRToolStripMenuItem.Name = "MonthlyRToolStripMenuItem"
        MonthlyRToolStripMenuItem.Size = New Size(157, 22)
        MonthlyRToolStripMenuItem.Text = "Monthly Report"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(186, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Controls.Add(btnAvailableBooks)
        Panel1.Location = New Point(30, 71)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(306, 107)
        Panel1.TabIndex = 3
        ' 
        ' btnAvailableBooks
        ' 
        btnAvailableBooks.Location = New Point(10, 17)
        btnAvailableBooks.Name = "btnAvailableBooks"
        btnAvailableBooks.Size = New Size(118, 23)
        btnAvailableBooks.TabIndex = 0
        btnAvailableBooks.Text = "Available Books"
        btnAvailableBooks.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(29, 234)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1084, 661)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Controls.Add(MenuStrip1)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Library Management System - Dashboard"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchMembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthlyRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAvailableBooks As Button
    Friend WithEvents Button1 As Button
End Class
