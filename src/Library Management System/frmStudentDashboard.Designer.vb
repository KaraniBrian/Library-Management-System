<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentDashboard
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnCatalogue = New System.Windows.Forms.Button()
        Me.btnMyBorrowedBooks = New System.Windows.Forms.Button()
        Me.btnMyFines = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.pnlPageHost = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.flpCards = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlBorrowedBooks = New System.Windows.Forms.Panel()
        Me.lblBorrowedBooksTitle = New System.Windows.Forms.Label()
        Me.lblBorrowedBooksValue = New System.Windows.Forms.Label()
        Me.pnlDueSoon = New System.Windows.Forms.Panel()
        Me.lblDueSoonTitle = New System.Windows.Forms.Label()
        Me.lblDueSoonValue = New System.Windows.Forms.Label()
        Me.pnlOverdue = New System.Windows.Forms.Panel()
        Me.lblOverdueTitle = New System.Windows.Forms.Label()
        Me.lblOverdueValue = New System.Windows.Forms.Label()
        Me.pnlFineBalance = New System.Windows.Forms.Panel()
        Me.lblFineBalanceTitle = New System.Windows.Forms.Label()
        Me.lblFineBalanceValue = New System.Windows.Forms.Label()
        Me.lblRecentBorrowings = New System.Windows.Forms.Label()
        Me.dgvMyBorrowings = New System.Windows.Forms.DataGridView()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        Me.flpCards.SuspendLayout()
        Me.pnlBorrowedBooks.SuspendLayout()
        Me.pnlDueSoon.SuspendLayout()
        Me.pnlOverdue.SuspendLayout()
        Me.pnlFineBalance.SuspendLayout()
        CType(Me.dgvMyBorrowings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.DarkGreen
        Me.pnlSidebar.Controls.Add(Me.btnMyFines)
        Me.pnlSidebar.Controls.Add(Me.btnMyBorrowedBooks)
        Me.pnlSidebar.Controls.Add(Me.btnCatalogue)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.lblAppTitle)
        Me.pnlSidebar.Controls.Add(Me.btnProfile)
        Me.pnlSidebar.Controls.Add(Me.btnChangePassword)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 750)
        Me.pnlSidebar.TabIndex = 2
        '
        'lblAppTitle
        '
        Me.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAppTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppTitle.ForeColor = System.Drawing.Color.White
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(220, 70)
        Me.lblAppTitle.TabIndex = 4
        Me.lblAppTitle.Text = "Student Portal"
        Me.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(220, 48)
        Me.btnDashboard.TabIndex = 3
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnCatalogue
        '
        Me.btnCatalogue.BackColor = System.Drawing.Color.DarkGreen
        Me.btnCatalogue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCatalogue.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCatalogue.FlatAppearance.BorderSize = 0
        Me.btnCatalogue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatalogue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCatalogue.ForeColor = System.Drawing.Color.White
        Me.btnCatalogue.Name = "btnCatalogue"
        Me.btnCatalogue.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnCatalogue.Size = New System.Drawing.Size(220, 48)
        Me.btnCatalogue.TabIndex = 2
        Me.btnCatalogue.Text = "Browse Books"
        Me.btnCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatalogue.UseVisualStyleBackColor = False
        '
        'btnMyBorrowedBooks
        '
        Me.btnMyBorrowedBooks.BackColor = System.Drawing.Color.DarkGreen
        Me.btnMyBorrowedBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMyBorrowedBooks.FlatAppearance.BorderSize = 0
        Me.btnMyBorrowedBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnMyBorrowedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyBorrowedBooks.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyBorrowedBooks.ForeColor = System.Drawing.Color.White
        Me.btnMyBorrowedBooks.Name = "btnMyBorrowedBooks"
        Me.btnMyBorrowedBooks.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnMyBorrowedBooks.Size = New System.Drawing.Size(220, 48)
        Me.btnMyBorrowedBooks.TabIndex = 1
        Me.btnMyBorrowedBooks.Text = "My Borrowed Books"
        Me.btnMyBorrowedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMyBorrowedBooks.UseVisualStyleBackColor = False
        '
        'btnMyFines
        '
        Me.btnMyFines.BackColor = System.Drawing.Color.DarkGreen
        Me.btnMyFines.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyFines.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMyFines.FlatAppearance.BorderSize = 0
        Me.btnMyFines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnMyFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyFines.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyFines.ForeColor = System.Drawing.Color.White
        Me.btnMyFines.Name = "btnMyFines"
        Me.btnMyFines.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnMyFines.Size = New System.Drawing.Size(220, 48)
        Me.btnMyFines.TabIndex = 0
        Me.btnMyFines.Text = "My Fines and Payments"
        Me.btnMyFines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMyFines.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.DarkGreen
        Me.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProfile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnProfile.Size = New System.Drawing.Size(220, 48)
        Me.btnProfile.TabIndex = 5
        Me.btnProfile.Text = "My Profile"
        Me.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.DarkGreen
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnChangePassword.Size = New System.Drawing.Size(220, 48)
        Me.btnChangePassword.TabIndex = 6
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkGreen
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(220, 48)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlHome.Controls.Add(Me.dgvMyBorrowings)
        Me.pnlHome.Controls.Add(Me.lblRecentBorrowings)
        Me.pnlHome.Controls.Add(Me.flpCards)
        Me.pnlHome.Controls.Add(Me.lblWelcome)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlHome.Size = New System.Drawing.Size(980, 750)
        Me.pnlHome.TabIndex = 0
        '
        'pnlPageHost
        '
        Me.pnlPageHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPageHost.Name = "pnlPageHost"
        Me.pnlPageHost.Size = New System.Drawing.Size(980, 750)
        Me.pnlPageHost.TabIndex = 1
        Me.pnlPageHost.Visible = False
        '
        'lblWelcome
        '
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(940, 55)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Welcome, Student"
        '
        'flpCards
        '
        Me.flpCards.AutoScroll = True
        Me.flpCards.Controls.Add(Me.pnlBorrowedBooks)
        Me.flpCards.Controls.Add(Me.pnlDueSoon)
        Me.flpCards.Controls.Add(Me.pnlOverdue)
        Me.flpCards.Controls.Add(Me.pnlFineBalance)
        Me.flpCards.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpCards.Name = "flpCards"
        Me.flpCards.Size = New System.Drawing.Size(940, 150)
        Me.flpCards.TabIndex = 2
        Me.flpCards.WrapContents = False
        '
        'pnlBorrowedBooks
        '
        Me.pnlBorrowedBooks.BackColor = System.Drawing.Color.White
        Me.pnlBorrowedBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBorrowedBooks.Controls.Add(Me.lblBorrowedBooksValue)
        Me.pnlBorrowedBooks.Controls.Add(Me.lblBorrowedBooksTitle)
        Me.pnlBorrowedBooks.Margin = New System.Windows.Forms.Padding(0, 5, 20, 5)
        Me.pnlBorrowedBooks.Name = "pnlBorrowedBooks"
        Me.pnlBorrowedBooks.Size = New System.Drawing.Size(220, 120)
        Me.pnlBorrowedBooks.TabIndex = 0
        '
        'lblBorrowedBooksTitle
        '
        Me.lblBorrowedBooksTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBorrowedBooksTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblBorrowedBooksTitle.Name = "lblBorrowedBooksTitle"
        Me.lblBorrowedBooksTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblBorrowedBooksTitle.Size = New System.Drawing.Size(218, 35)
        Me.lblBorrowedBooksTitle.TabIndex = 1
        Me.lblBorrowedBooksTitle.Text = "My Borrowed Books"
        Me.lblBorrowedBooksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBorrowedBooksValue
        '
        Me.lblBorrowedBooksValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBorrowedBooksValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblBorrowedBooksValue.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblBorrowedBooksValue.Name = "lblBorrowedBooksValue"
        Me.lblBorrowedBooksValue.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblBorrowedBooksValue.Size = New System.Drawing.Size(218, 118)
        Me.lblBorrowedBooksValue.TabIndex = 0
        Me.lblBorrowedBooksValue.Text = "0"
        Me.lblBorrowedBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlDueSoon
        '
        Me.pnlDueSoon.BackColor = System.Drawing.Color.White
        Me.pnlDueSoon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDueSoon.Controls.Add(Me.lblDueSoonValue)
        Me.pnlDueSoon.Controls.Add(Me.lblDueSoonTitle)
        Me.pnlDueSoon.Margin = New System.Windows.Forms.Padding(0, 5, 20, 5)
        Me.pnlDueSoon.Name = "pnlDueSoon"
        Me.pnlDueSoon.Size = New System.Drawing.Size(220, 120)
        Me.pnlDueSoon.TabIndex = 1
        '
        'lblDueSoonTitle
        '
        Me.lblDueSoonTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDueSoonTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblDueSoonTitle.Name = "lblDueSoonTitle"
        Me.lblDueSoonTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblDueSoonTitle.Size = New System.Drawing.Size(218, 35)
        Me.lblDueSoonTitle.TabIndex = 1
        Me.lblDueSoonTitle.Text = "Books Due Soon"
        Me.lblDueSoonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDueSoonValue
        '
        Me.lblDueSoonValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDueSoonValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblDueSoonValue.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDueSoonValue.Name = "lblDueSoonValue"
        Me.lblDueSoonValue.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblDueSoonValue.Size = New System.Drawing.Size(218, 118)
        Me.lblDueSoonValue.TabIndex = 0
        Me.lblDueSoonValue.Text = "0"
        Me.lblDueSoonValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlOverdue
        '
        Me.pnlOverdue.BackColor = System.Drawing.Color.White
        Me.pnlOverdue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOverdue.Controls.Add(Me.lblOverdueValue)
        Me.pnlOverdue.Controls.Add(Me.lblOverdueTitle)
        Me.pnlOverdue.Margin = New System.Windows.Forms.Padding(0, 5, 20, 5)
        Me.pnlOverdue.Name = "pnlOverdue"
        Me.pnlOverdue.Size = New System.Drawing.Size(220, 120)
        Me.pnlOverdue.TabIndex = 2
        '
        'lblOverdueTitle
        '
        Me.lblOverdueTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblOverdueTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblOverdueTitle.Name = "lblOverdueTitle"
        Me.lblOverdueTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblOverdueTitle.Size = New System.Drawing.Size(218, 35)
        Me.lblOverdueTitle.TabIndex = 1
        Me.lblOverdueTitle.Text = "Overdue Books"
        Me.lblOverdueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOverdueValue
        '
        Me.lblOverdueValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOverdueValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblOverdueValue.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblOverdueValue.Name = "lblOverdueValue"
        Me.lblOverdueValue.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblOverdueValue.Size = New System.Drawing.Size(218, 118)
        Me.lblOverdueValue.TabIndex = 0
        Me.lblOverdueValue.Text = "0"
        Me.lblOverdueValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlFineBalance
        '
        Me.pnlFineBalance.BackColor = System.Drawing.Color.White
        Me.pnlFineBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFineBalance.Controls.Add(Me.lblFineBalanceValue)
        Me.pnlFineBalance.Controls.Add(Me.lblFineBalanceTitle)
        Me.pnlFineBalance.Margin = New System.Windows.Forms.Padding(0, 5, 20, 5)
        Me.pnlFineBalance.Name = "pnlFineBalance"
        Me.pnlFineBalance.Size = New System.Drawing.Size(220, 120)
        Me.pnlFineBalance.TabIndex = 3
        '
        'lblFineBalanceTitle
        '
        Me.lblFineBalanceTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFineBalanceTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblFineBalanceTitle.Name = "lblFineBalanceTitle"
        Me.lblFineBalanceTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblFineBalanceTitle.Size = New System.Drawing.Size(218, 35)
        Me.lblFineBalanceTitle.TabIndex = 1
        Me.lblFineBalanceTitle.Text = "Outstanding Fine"
        Me.lblFineBalanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFineBalanceValue
        '
        Me.lblFineBalanceValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFineBalanceValue.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblFineBalanceValue.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFineBalanceValue.Name = "lblFineBalanceValue"
        Me.lblFineBalanceValue.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblFineBalanceValue.Size = New System.Drawing.Size(218, 118)
        Me.lblFineBalanceValue.TabIndex = 0
        Me.lblFineBalanceValue.Text = "KES 0.00"
        Me.lblFineBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRecentBorrowings
        '
        Me.lblRecentBorrowings.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRecentBorrowings.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblRecentBorrowings.Name = "lblRecentBorrowings"
        Me.lblRecentBorrowings.Size = New System.Drawing.Size(940, 45)
        Me.lblRecentBorrowings.TabIndex = 1
        Me.lblRecentBorrowings.Text = "My Recent Borrowings"
        Me.lblRecentBorrowings.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'dgvMyBorrowings
        '
        Me.dgvMyBorrowings.AllowUserToAddRows = False
        Me.dgvMyBorrowings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMyBorrowings.BackgroundColor = System.Drawing.Color.White
        Me.dgvMyBorrowings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMyBorrowings.MultiSelect = False
        Me.dgvMyBorrowings.Name = "dgvMyBorrowings"
        Me.dgvMyBorrowings.ReadOnly = True
        Me.dgvMyBorrowings.RowHeadersVisible = False
        Me.dgvMyBorrowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMyBorrowings.Size = New System.Drawing.Size(940, 400)
        Me.dgvMyBorrowings.TabIndex = 0
        '
        'frmStudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1200, 750)
        Me.Controls.Add(Me.pnlHome)
        Me.Controls.Add(Me.pnlPageHost)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MinimumSize = New System.Drawing.Size(1000, 650)
        Me.Name = "frmStudentDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System - Student Portal"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlHome.ResumeLayout(False)
        Me.flpCards.ResumeLayout(False)
        Me.pnlBorrowedBooks.ResumeLayout(False)
        Me.pnlDueSoon.ResumeLayout(False)
        Me.pnlOverdue.ResumeLayout(False)
        Me.pnlFineBalance.ResumeLayout(False)
        CType(Me.dgvMyBorrowings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents lblAppTitle As System.Windows.Forms.Label
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnCatalogue As System.Windows.Forms.Button
    Friend WithEvents btnMyBorrowedBooks As System.Windows.Forms.Button
    Friend WithEvents btnMyFines As System.Windows.Forms.Button
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlHome As System.Windows.Forms.Panel
    Friend WithEvents pnlPageHost As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents flpCards As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlBorrowedBooks As System.Windows.Forms.Panel
    Friend WithEvents lblBorrowedBooksTitle As System.Windows.Forms.Label
    Friend WithEvents lblBorrowedBooksValue As System.Windows.Forms.Label
    Friend WithEvents pnlDueSoon As System.Windows.Forms.Panel
    Friend WithEvents lblDueSoonTitle As System.Windows.Forms.Label
    Friend WithEvents lblDueSoonValue As System.Windows.Forms.Label
    Friend WithEvents pnlOverdue As System.Windows.Forms.Panel
    Friend WithEvents lblOverdueTitle As System.Windows.Forms.Label
    Friend WithEvents lblOverdueValue As System.Windows.Forms.Label
    Friend WithEvents pnlFineBalance As System.Windows.Forms.Panel
    Friend WithEvents lblFineBalanceTitle As System.Windows.Forms.Label
    Friend WithEvents lblFineBalanceValue As System.Windows.Forms.Label
    Friend WithEvents lblRecentBorrowings As System.Windows.Forms.Label
    Friend WithEvents dgvMyBorrowings As System.Windows.Forms.DataGridView

End Class