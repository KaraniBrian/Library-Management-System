<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeading = New Label()
        lblSubHeading = New Label()
        lblBookID = New Label()
        txtBookID = New TextBox()
        lblBorrowerName = New Label()
        txtBorrowerName = New TextBox()
        lblReturnDate = New Label()
        dtpReturnDate = New DateTimePicker()
        btnReturn = New Button()
        btnClear = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.BackColor = Color.Green
        lblHeading.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.White
        lblHeading.Location = New Point(250, 40)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(400, 35)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Library Management System"
        lblHeading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSubHeading
        ' 
        lblSubHeading.Font = New Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubHeading.ForeColor = Color.Green
        lblSubHeading.Location = New Point(331, 95)
        lblSubHeading.Name = "lblSubHeading"
        lblSubHeading.Size = New Size(238, 30)
        lblSubHeading.TabIndex = 1
        lblSubHeading.Text = "Return Book"
        lblSubHeading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBookID
        ' 
        lblBookID.BackColor = Color.White
        lblBookID.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookID.ForeColor = Color.Green
        lblBookID.Location = New Point(169, 180)
        lblBookID.Name = "lblBookID"
        lblBookID.Size = New Size(106, 25)
        lblBookID.TabIndex = 2
        lblBookID.Text = "Book ID:"
        lblBookID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtBookID
        ' 
        txtBookID.Location = New Point(330, 180)
        txtBookID.Name = "txtBookID"
        txtBookID.Size = New Size(250, 23)
        txtBookID.TabIndex = 3
        ' 
        ' lblBorrowerName
        ' 
        lblBorrowerName.BackColor = Color.White
        lblBorrowerName.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBorrowerName.ForeColor = Color.Green
        lblBorrowerName.Location = New Point(128, 231)
        lblBorrowerName.Name = "lblBorrowerName"
        lblBorrowerName.Size = New Size(147, 25)
        lblBorrowerName.TabIndex = 4
        lblBorrowerName.Text = "Borrower's Name:"
        lblBorrowerName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtBorrowerName
        ' 
        txtBorrowerName.Location = New Point(330, 230)
        txtBorrowerName.Name = "txtBorrowerName"
        txtBorrowerName.Size = New Size(250, 23)
        txtBorrowerName.TabIndex = 5
        ' 
        ' lblReturnDate
        ' 
        lblReturnDate.BackColor = Color.White
        lblReturnDate.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReturnDate.ForeColor = Color.Green
        lblReturnDate.Location = New Point(169, 284)
        lblReturnDate.Name = "lblReturnDate"
        lblReturnDate.Size = New Size(110, 25)
        lblReturnDate.TabIndex = 6
        lblReturnDate.Text = "Return Date:"
        ' 
        ' dtpReturnDate
        ' 
        dtpReturnDate.Format = DateTimePickerFormat.Short
        dtpReturnDate.Location = New Point(330, 280)
        dtpReturnDate.Name = "dtpReturnDate"
        dtpReturnDate.Size = New Size(110, 23)
        dtpReturnDate.TabIndex = 7
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Green
        btnReturn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(330, 340)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(130, 40)
        btnReturn.TabIndex = 8
        btnReturn.Text = "Return Book"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Green
        btnClear.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(480, 340)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(100, 40)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Green
        btnBack.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(30, 510)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 35)
        btnBack.TabIndex = 10
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' ReturnBook
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(884, 561)
        Controls.Add(btnBack)
        Controls.Add(btnClear)
        Controls.Add(btnReturn)
        Controls.Add(dtpReturnDate)
        Controls.Add(lblReturnDate)
        Controls.Add(txtBorrowerName)
        Controls.Add(lblBorrowerName)
        Controls.Add(txtBookID)
        Controls.Add(lblBookID)
        Controls.Add(lblSubHeading)
        Controls.Add(lblHeading)
        Name = "ReturnBook"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Return Book"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubHeading As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents lblBorrowerName As Label
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents lblReturnDate As Label
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button

End Class
