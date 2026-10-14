<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIssueBook
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
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.cmbStudent = New System.Windows.Forms.ComboBox()
        Me.lblBook = New System.Windows.Forms.Label()
        Me.cmbBook = New System.Windows.Forms.ComboBox()
        Me.lblCopy = New System.Windows.Forms.Label()
        Me.cmbBookCopy = New System.Windows.Forms.ComboBox()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.txtAvailability = New System.Windows.Forms.TextBox()
        Me.lblIssueDate = New System.Windows.Forms.Label()
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
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
        Me.lblTitle.Text = "Issue / Borrow Book"
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Location = New System.Drawing.Point(40, 100)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.TabIndex = 1
        Me.lblStudent.Text = "Select Student:"
        '
        'cmbStudent
        '
        Me.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudent.FormattingEnabled = True
        Me.cmbStudent.Location = New System.Drawing.Point(260, 95)
        Me.cmbStudent.Name = "cmbStudent"
        Me.cmbStudent.Size = New System.Drawing.Size(350, 31)
        Me.cmbStudent.TabIndex = 2
        '
        'lblBook
        '
        Me.lblBook.AutoSize = True
        Me.lblBook.Location = New System.Drawing.Point(40, 160)
        Me.lblBook.Name = "lblBook"
        Me.lblBook.TabIndex = 3
        Me.lblBook.Text = "Select Book:"
        '
        'cmbBook
        '
        Me.cmbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBook.FormattingEnabled = True
        Me.cmbBook.Location = New System.Drawing.Point(260, 155)
        Me.cmbBook.Name = "cmbBook"
        Me.cmbBook.Size = New System.Drawing.Size(350, 31)
        Me.cmbBook.TabIndex = 4
        '
        'lblCopy
        '
        Me.lblCopy.AutoSize = True
        Me.lblCopy.Location = New System.Drawing.Point(40, 220)
        Me.lblCopy.Name = "lblCopy"
        Me.lblCopy.TabIndex = 5
        Me.lblCopy.Text = "Select Available Copy:"
        '
        'cmbBookCopy
        '
        Me.cmbBookCopy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBookCopy.FormattingEnabled = True
        Me.cmbBookCopy.Location = New System.Drawing.Point(260, 215)
        Me.cmbBookCopy.Name = "cmbBookCopy"
        Me.cmbBookCopy.Size = New System.Drawing.Size(350, 31)
        Me.cmbBookCopy.TabIndex = 6
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(40, 280)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.TabIndex = 7
        Me.lblAvailability.Text = "Availability:"
        '
        'txtAvailability
        '
        Me.txtAvailability.Location = New System.Drawing.Point(260, 275)
        Me.txtAvailability.Name = "txtAvailability"
        Me.txtAvailability.ReadOnly = True
        Me.txtAvailability.Size = New System.Drawing.Size(350, 30)
        Me.txtAvailability.TabIndex = 8
        '
        'lblIssueDate
        '
        Me.lblIssueDate.AutoSize = True
        Me.lblIssueDate.Location = New System.Drawing.Point(40, 340)
        Me.lblIssueDate.Name = "lblIssueDate"
        Me.lblIssueDate.TabIndex = 9
        Me.lblIssueDate.Text = "Issue Date:"
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.Enabled = False
        Me.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpIssueDate.Location = New System.Drawing.Point(260, 335)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(200, 30)
        Me.dtpIssueDate.TabIndex = 10
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(40, 400)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.TabIndex = 11
        Me.lblDueDate.Text = "Due Date:"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDueDate.Location = New System.Drawing.Point(260, 395)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(200, 30)
        Me.dtpDueDate.TabIndex = 12
        '
        'btnIssue
        '
        Me.btnIssue.BackColor = System.Drawing.Color.DarkGreen
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnIssue.ForeColor = System.Drawing.Color.White
        Me.btnIssue.Location = New System.Drawing.Point(260, 465)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(150, 40)
        Me.btnIssue.TabIndex = 13
        Me.btnIssue.Text = "Issue Book"
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(425, 465)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 40)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(540, 465)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 40)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.lblMessage.Location = New System.Drawing.Point(260, 525)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.TabIndex = 16
        '
        'frmIssueBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.cmbStudent)
        Me.Controls.Add(Me.lblBook)
        Me.Controls.Add(Me.cmbBook)
        Me.Controls.Add(Me.lblCopy)
        Me.Controls.Add(Me.cmbBookCopy)
        Me.Controls.Add(Me.lblAvailability)
        Me.Controls.Add(Me.txtAvailability)
        Me.Controls.Add(Me.lblIssueDate)
        Me.Controls.Add(Me.dtpIssueDate)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.btnIssue)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Name = "frmIssueBook"
        Me.Text = "Issue / Borrow Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblStudent As System.Windows.Forms.Label
    Friend WithEvents cmbStudent As System.Windows.Forms.ComboBox
    Friend WithEvents lblBook As System.Windows.Forms.Label
    Friend WithEvents cmbBook As System.Windows.Forms.ComboBox
    Friend WithEvents lblCopy As System.Windows.Forms.Label
    Friend WithEvents cmbBookCopy As System.Windows.Forms.ComboBox
    Friend WithEvents lblAvailability As System.Windows.Forms.Label
    Friend WithEvents txtAvailability As System.Windows.Forms.TextBox
    Friend WithEvents lblIssueDate As System.Windows.Forms.Label
    Friend WithEvents dtpIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class