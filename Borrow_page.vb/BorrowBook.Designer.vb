<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowBook
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
        lblSubHeading = New Label()
        lblBookID = New Label()
        txtBookID = New TextBox()
        txtBorrowerName = New TextBox()
        lblBorrowerName = New Label()
        lblBorrowDate = New Label()
        dtpBorrowDate = New DateTimePicker()
        btnBorrow = New Button()
        btnBookName = New Label()
        txtBookName = New TextBox()
        btnClear = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.BackColor = Color.Green
        lblHeading.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.White
        lblHeading.ImageAlign = ContentAlignment.TopCenter
        lblHeading.Location = New Point(171, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(430, 30)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Library Management System-Borrow Book"
        ' 
        ' lblSubHeading
        ' 
        lblSubHeading.AutoSize = True
        lblSubHeading.BackColor = Color.Green
        lblSubHeading.Font = New Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubHeading.ForeColor = Color.White
        lblSubHeading.Location = New Point(366, 66)
        lblSubHeading.Name = "lblSubHeading"
        lblSubHeading.Size = New Size(114, 19)
        lblSubHeading.TabIndex = 1
        lblSubHeading.Text = "Borrow Book"
        ' 
        ' lblBookID
        ' 
        lblBookID.BackColor = Color.White
        lblBookID.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookID.ForeColor = Color.Green
        lblBookID.ImageAlign = ContentAlignment.MiddleLeft
        lblBookID.Location = New Point(160, 121)
        lblBookID.Name = "lblBookID"
        lblBookID.Size = New Size(110, 25)
        lblBookID.TabIndex = 2
        lblBookID.Text = "Book ID:"
        lblBookID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBookID
        ' 
        txtBookID.Location = New Point(366, 121)
        txtBookID.Name = "txtBookID"
        txtBookID.Size = New Size(250, 23)
        txtBookID.TabIndex = 3
        ' 
        ' txtBorrowerName
        ' 
        txtBorrowerName.Location = New Point(366, 200)
        txtBorrowerName.Name = "txtBorrowerName"
        txtBorrowerName.Size = New Size(250, 23)
        txtBorrowerName.TabIndex = 5
        ' 
        ' lblBorrowerName
        ' 
        lblBorrowerName.BackColor = Color.White
        lblBorrowerName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBorrowerName.ForeColor = Color.Green
        lblBorrowerName.ImageAlign = ContentAlignment.MiddleLeft
        lblBorrowerName.Location = New Point(138, 200)
        lblBorrowerName.Name = "lblBorrowerName"
        lblBorrowerName.Size = New Size(132, 25)
        lblBorrowerName.TabIndex = 6
        lblBorrowerName.Text = "Borrower's Names:"
        lblBorrowerName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBorrowDate
        ' 
        lblBorrowDate.BackColor = Color.White
        lblBorrowDate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBorrowDate.ForeColor = Color.Green
        lblBorrowDate.ImageAlign = ContentAlignment.MiddleLeft
        lblBorrowDate.Location = New Point(160, 240)
        lblBorrowDate.Name = "lblBorrowDate"
        lblBorrowDate.Size = New Size(110, 25)
        lblBorrowDate.TabIndex = 7
        lblBorrowDate.Text = "Borrow Date:"
        lblBorrowDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpBorrowDate
        ' 
        dtpBorrowDate.Format = DateTimePickerFormat.Short
        dtpBorrowDate.Location = New Point(366, 240)
        dtpBorrowDate.Name = "dtpBorrowDate"
        dtpBorrowDate.Size = New Size(129, 23)
        dtpBorrowDate.TabIndex = 8
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = Color.Green
        btnBorrow.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBorrow.ForeColor = Color.White
        btnBorrow.Location = New Point(559, 237)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(130, 31)
        btnBorrow.TabIndex = 9
        btnBorrow.Text = "Borrow Book"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' btnBookName
        ' 
        btnBookName.BackColor = Color.White
        btnBookName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBookName.ForeColor = Color.Green
        btnBookName.ImageAlign = ContentAlignment.MiddleLeft
        btnBookName.Location = New Point(160, 163)
        btnBookName.Name = "btnBookName"
        btnBookName.Size = New Size(110, 25)
        btnBookName.TabIndex = 10
        btnBookName.Text = "Book Name:"
        btnBookName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBookName
        ' 
        txtBookName.Location = New Point(366, 163)
        txtBookName.Name = "txtBookName"
        txtBookName.Size = New Size(250, 23)
        txtBookName.TabIndex = 11
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Green
        btnClear.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(559, 284)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(130, 31)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Green
        btnBack.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 317)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(130, 31)
        btnBack.TabIndex = 13
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' BorrowBook
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(804, 372)
        Controls.Add(btnBack)
        Controls.Add(btnClear)
        Controls.Add(txtBookName)
        Controls.Add(btnBookName)
        Controls.Add(btnBorrow)
        Controls.Add(dtpBorrowDate)
        Controls.Add(lblBorrowDate)
        Controls.Add(lblBorrowerName)
        Controls.Add(txtBorrowerName)
        Controls.Add(txtBookID)
        Controls.Add(lblBookID)
        Controls.Add(lblSubHeading)
        Controls.Add(lblHeading)
        Name = "BorrowBook"
        Text = "BorrowBook"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubHeading As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents lblBorrowerName As Label
    Friend WithEvents lblBorrowDate As Label
    Friend WithEvents dtpBorrowDate As DateTimePicker
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnBookName As Label
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
End Class
