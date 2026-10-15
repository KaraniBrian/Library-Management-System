<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetails
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
        lblBookTitle = New Label()
        txtBookTitle = New TextBox()
        lblBookAuthor = New Label()
        txtBookAuthor = New TextBox()
        lblBookCategory = New Label()
        txtBookCategory = New TextBox()
        lblBookISBN = New Label()
        txtBookISBN = New TextBox()
        lblBookAvailability = New Label()
        txtBookAvailability = New TextBox()
        btnBorrowBook = New Button()
        btnCloseBookView = New Button()
        SuspendLayout()
        ' 
        ' lblBookTitle
        ' 
        lblBookTitle.AutoSize = True
        lblBookTitle.BackColor = Color.Lime
        lblBookTitle.Location = New Point(39, 31)
        lblBookTitle.Name = "lblBookTitle"
        lblBookTitle.Padding = New Padding(15, 5, 15, 5)
        lblBookTitle.Size = New Size(113, 30)
        lblBookTitle.TabIndex = 0
        lblBookTitle.Text = "Book Title :"
        ' 
        ' txtBookTitle
        ' 
        txtBookTitle.Location = New Point(231, 34)
        txtBookTitle.Name = "txtBookTitle"
        txtBookTitle.ReadOnly = True
        txtBookTitle.Size = New Size(518, 27)
        txtBookTitle.TabIndex = 1
        txtBookTitle.TabStop = False
        ' 
        ' lblBookAuthor
        ' 
        lblBookAuthor.AutoSize = True
        lblBookAuthor.BackColor = Color.Lime
        lblBookAuthor.Location = New Point(39, 101)
        lblBookAuthor.Name = "lblBookAuthor"
        lblBookAuthor.Padding = New Padding(25, 5, 25, 5)
        lblBookAuthor.Size = New Size(111, 30)
        lblBookAuthor.TabIndex = 2
        lblBookAuthor.Text = "Author :"
        ' 
        ' txtBookAuthor
        ' 
        txtBookAuthor.Location = New Point(231, 101)
        txtBookAuthor.Name = "txtBookAuthor"
        txtBookAuthor.ReadOnly = True
        txtBookAuthor.Size = New Size(518, 27)
        txtBookAuthor.TabIndex = 3
        txtBookAuthor.TabStop = False
        ' 
        ' lblBookCategory
        ' 
        lblBookCategory.AutoSize = True
        lblBookCategory.BackColor = Color.Lime
        lblBookCategory.Location = New Point(39, 194)
        lblBookCategory.Name = "lblBookCategory"
        lblBookCategory.Padding = New Padding(15, 5, 15, 5)
        lblBookCategory.Size = New Size(106, 30)
        lblBookCategory.TabIndex = 4
        lblBookCategory.Text = "Category :"
        ' 
        ' txtBookCategory
        ' 
        txtBookCategory.Location = New Point(231, 197)
        txtBookCategory.Name = "txtBookCategory"
        txtBookCategory.ReadOnly = True
        txtBookCategory.Size = New Size(518, 27)
        txtBookCategory.TabIndex = 5
        txtBookCategory.TabStop = False
        ' 
        ' lblBookISBN
        ' 
        lblBookISBN.AutoSize = True
        lblBookISBN.BackColor = Color.Lime
        lblBookISBN.Location = New Point(39, 305)
        lblBookISBN.Name = "lblBookISBN"
        lblBookISBN.Padding = New Padding(25, 5, 25, 5)
        lblBookISBN.Size = New Size(98, 30)
        lblBookISBN.TabIndex = 6
        lblBookISBN.Text = "ISBN :"
        ' 
        ' txtBookISBN
        ' 
        txtBookISBN.Location = New Point(231, 317)
        txtBookISBN.Name = "txtBookISBN"
        txtBookISBN.ReadOnly = True
        txtBookISBN.Size = New Size(518, 27)
        txtBookISBN.TabIndex = 7
        txtBookISBN.TabStop = False
        ' 
        ' lblBookAvailability
        ' 
        lblBookAvailability.AutoSize = True
        lblBookAvailability.BackColor = Color.Lime
        lblBookAvailability.Location = New Point(39, 411)
        lblBookAvailability.Name = "lblBookAvailability"
        lblBookAvailability.Padding = New Padding(5)
        lblBookAvailability.Size = New Size(141, 30)
        lblBookAvailability.TabIndex = 8
        lblBookAvailability.Text = "Available Copies  :"
        ' 
        ' txtBookAvailability
        ' 
        txtBookAvailability.Location = New Point(231, 414)
        txtBookAvailability.Name = "txtBookAvailability"
        txtBookAvailability.ReadOnly = True
        txtBookAvailability.Size = New Size(518, 27)
        txtBookAvailability.TabIndex = 9
        txtBookAvailability.TabStop = False
        ' 
        ' btnBorrowBook
        ' 
        btnBorrowBook.BackColor = Color.Lime
        btnBorrowBook.Location = New Point(157, 523)
        btnBorrowBook.Name = "btnBorrowBook"
        btnBorrowBook.Size = New Size(208, 65)
        btnBorrowBook.TabIndex = 10
        btnBorrowBook.Text = "Borrow"
        btnBorrowBook.UseVisualStyleBackColor = False
        ' 
        ' btnCloseBookView
        ' 
        btnCloseBookView.BackColor = Color.Lime
        btnCloseBookView.Location = New Point(459, 523)
        btnCloseBookView.Name = "btnCloseBookView"
        btnCloseBookView.Size = New Size(190, 65)
        btnCloseBookView.TabIndex = 11
        btnCloseBookView.Text = "Close"
        btnCloseBookView.UseVisualStyleBackColor = False
        ' 
        ' BookDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Aqua
        ClientSize = New Size(922, 660)
        Controls.Add(btnCloseBookView)
        Controls.Add(btnBorrowBook)
        Controls.Add(txtBookAvailability)
        Controls.Add(lblBookAvailability)
        Controls.Add(txtBookISBN)
        Controls.Add(lblBookISBN)
        Controls.Add(txtBookCategory)
        Controls.Add(lblBookCategory)
        Controls.Add(txtBookAuthor)
        Controls.Add(lblBookAuthor)
        Controls.Add(txtBookTitle)
        Controls.Add(lblBookTitle)
        Name = "BookDetails"
        Text = "Book Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBookTitle As Label
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents lblBookAuthor As Label
    Friend WithEvents txtBookAuthor As TextBox
    Friend WithEvents lblBookCategory As Label
    Friend WithEvents txtBookCategory As TextBox
    Friend WithEvents lblBookISBN As Label
    Friend WithEvents txtBookISBN As TextBox
    Friend WithEvents lblBookAvailability As Label
    Friend WithEvents txtBookAvailability As TextBox
    Friend WithEvents btnBorrowBook As Button
    Friend WithEvents btnCloseBookView As Button
End Class
