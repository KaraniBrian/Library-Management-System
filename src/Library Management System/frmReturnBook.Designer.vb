<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReturnBook
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.txtStudent = New System.Windows.Forms.TextBox()
        Me.lblBook = New System.Windows.Forms.Label()
        Me.txtBook = New System.Windows.Forms.TextBox()
        Me.lblIssueDate = New System.Windows.Forms.Label()
        Me.txtIssueDate = New System.Windows.Forms.TextBox()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.txtDueDate = New System.Windows.Forms.TextBox()
        Me.lblReturnDate = New System.Windows.Forms.Label()
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFine = New System.Windows.Forms.Label()
        Me.txtFine = New System.Windows.Forms.TextBox()
        Me.btnCalculateFine = New System.Windows.Forms.Button()
        Me.btnProcessReturn = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(30, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Return Book"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(40, 100)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Borrowing ID:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(260, 95)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Enter Borrowing ID"
        Me.txtSearch.Size = New System.Drawing.Size(250, 30)
        Me.txtSearch.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.Location = New System.Drawing.Point(525, 93)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 34)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Look Up"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetails.Location = New System.Drawing.Point(40, 155)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.TabIndex = 4
        Me.lblDetails.Text = "Loan Details"
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Location = New System.Drawing.Point(40, 205)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.TabIndex = 5
        Me.lblStudent.Text = "Student:"
        '
        'txtStudent
        '
        Me.txtStudent.Location = New System.Drawing.Point(260, 200)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.ReadOnly = True
        Me.txtStudent.Size = New System.Drawing.Size(350, 30)
        Me.txtStudent.TabIndex = 6
        '
        'lblBook
        '
        Me.lblBook.AutoSize = True
        Me.lblBook.Location = New System.Drawing.Point(40, 255)
        Me.lblBook.Name = "lblBook"
        Me.lblBook.TabIndex = 7
        Me.lblBook.Text = "Book:"
        '
        'txtBook
        '
        Me.txtBook.Location = New System.Drawing.Point(260, 250)
        Me.txtBook.Name = "txtBook"
        Me.txtBook.ReadOnly = True
        Me.txtBook.Size = New System.Drawing.Size(350, 30)
        Me.txtBook.TabIndex = 8
        '
        'lblIssueDate
        '
        Me.lblIssueDate.AutoSize = True
        Me.lblIssueDate.Location = New System.Drawing.Point(40, 305)
        Me.lblIssueDate.Name = "lblIssueDate"
        Me.lblIssueDate.TabIndex = 9
        Me.lblIssueDate.Text = "Issue Date:"
        '
        'txtIssueDate
        '
        Me.txtIssueDate.Location = New System.Drawing.Point(260, 300)
        Me.txtIssueDate.Name = "txtIssueDate"
        Me.txtIssueDate.ReadOnly = True
        Me.txtIssueDate.Size = New System.Drawing.Size(200, 30)
        Me.txtIssueDate.TabIndex = 10
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(40, 355)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.TabIndex = 11
        Me.lblDueDate.Text = "Due Date:"
        '
        'txtDueDate
        '
        Me.txtDueDate.Location = New System.Drawing.Point(260, 350)
        Me.txtDueDate.Name = "txtDueDate"
        Me.txtDueDate.ReadOnly = True
        Me.txtDueDate.Size = New System.Drawing.Size(200, 30)
        Me.txtDueDate.TabIndex = 12
        '
        'lblReturnDate
        '
        Me.lblReturnDate.AutoSize = True
        Me.lblReturnDate.Location = New System.Drawing.Point(40, 405)
        Me.lblReturnDate.Name = "lblReturnDate"
        Me.lblReturnDate.TabIndex = 13
        Me.lblReturnDate.Text = "Return Date:"
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.Enabled = False
        Me.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpReturnDate.Location = New System.Drawing.Point(260, 400)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.Size = New System.Drawing.Size(200, 30)
        Me.dtpReturnDate.TabIndex = 14
        '
        'lblFine
        '
        Me.lblFine.AutoSize = True
        Me.lblFine.Location = New System.Drawing.Point(40, 455)
        Me.lblFine.Name = "lblFine"
        Me.lblFine.TabIndex = 15
        Me.lblFine.Text = "Fine Amount:"
        '
        'txtFine
        '
        Me.txtFine.Location = New System.Drawing.Point(260, 450)
        Me.txtFine.Name = "txtFine"
        Me.txtFine.ReadOnly = True
        Me.txtFine.Size = New System.Drawing.Size(200, 30)
        Me.txtFine.TabIndex = 16
        '
        'btnCalculateFine
        '
        Me.btnCalculateFine.Enabled = False
        Me.btnCalculateFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateFine.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculateFine.Location = New System.Drawing.Point(475, 448)
        Me.btnCalculateFine.Name = "btnCalculateFine"
        Me.btnCalculateFine.Size = New System.Drawing.Size(140, 34)
        Me.btnCalculateFine.TabIndex = 17
        Me.btnCalculateFine.Text = "Calculate Fine"
        Me.btnCalculateFine.UseVisualStyleBackColor = True
        '
        'btnProcessReturn
        '
        Me.btnProcessReturn.BackColor = System.Drawing.Color.DarkGreen
        Me.btnProcessReturn.Enabled = False
        Me.btnProcessReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcessReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProcessReturn.ForeColor = System.Drawing.Color.White
        Me.btnProcessReturn.Location = New System.Drawing.Point(260, 515)
        Me.btnProcessReturn.Name = "btnProcessReturn"
        Me.btnProcessReturn.Size = New System.Drawing.Size(160, 40)
        Me.btnProcessReturn.TabIndex = 18
        Me.btnProcessReturn.Text = "Confirm Return"
        Me.btnProcessReturn.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(435, 515)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 40)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.lblMessage.Location = New System.Drawing.Point(260, 575)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.TabIndex = 20
        '
        'frmReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(900, 640)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.txtStudent)
        Me.Controls.Add(Me.lblBook)
        Me.Controls.Add(Me.txtBook)
        Me.Controls.Add(Me.lblIssueDate)
        Me.Controls.Add(Me.txtIssueDate)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.txtDueDate)
        Me.Controls.Add(Me.lblReturnDate)
        Me.Controls.Add(Me.dtpReturnDate)
        Me.Controls.Add(Me.lblFine)
        Me.Controls.Add(Me.txtFine)
        Me.Controls.Add(Me.btnCalculateFine)
        Me.Controls.Add(Me.btnProcessReturn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Name = "frmReturnBook"
        Me.Text = "Return Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblStudent As System.Windows.Forms.Label
    Friend WithEvents txtStudent As System.Windows.Forms.TextBox
    Friend WithEvents lblBook As System.Windows.Forms.Label
    Friend WithEvents txtBook As System.Windows.Forms.TextBox
    Friend WithEvents lblIssueDate As System.Windows.Forms.Label
    Friend WithEvents txtIssueDate As System.Windows.Forms.TextBox
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents txtDueDate As System.Windows.Forms.TextBox
    Friend WithEvents lblReturnDate As System.Windows.Forms.Label
    Friend WithEvents dtpReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFine As System.Windows.Forms.Label
    Friend WithEvents txtFine As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateFine As System.Windows.Forms.Button
    Friend WithEvents btnProcessReturn As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class