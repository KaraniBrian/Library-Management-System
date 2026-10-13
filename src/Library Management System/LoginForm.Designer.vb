<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        pnlLoginCard = New Panel()
        btnExit = New Button()
        btnLogin = New Button()
        cmbRole = New ComboBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblRole = New Label()
        lblPassword = New Label()
        lblUsername = New Label()
        lblTitle = New Label()
        pnlLoginCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.BackColor = Color.Green
        pnlLoginCard.BorderStyle = BorderStyle.FixedSingle
        pnlLoginCard.Controls.Add(btnExit)
        pnlLoginCard.Controls.Add(btnLogin)
        pnlLoginCard.Controls.Add(cmbRole)
        pnlLoginCard.Controls.Add(txtPassword)
        pnlLoginCard.Controls.Add(txtUsername)
        pnlLoginCard.Controls.Add(lblRole)
        pnlLoginCard.Controls.Add(lblPassword)
        pnlLoginCard.Controls.Add(lblUsername)
        pnlLoginCard.Cursor = Cursors.Hand
        pnlLoginCard.Location = New Point(200, 100)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(400, 300)
        pnlLoginCard.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Gray
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(222, 239)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.DarkGreen
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(107, 239)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' cmbRole
        ' 
        cmbRole.Font = New Font("Segoe UI", 9F)
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Admin", "User"})
        cmbRole.Location = New Point(82, 191)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(100, 23)
        cmbRole.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(82, 132)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Enter Password"
        txtPassword.Size = New Size(180, 23)
        txtPassword.TabIndex = 2
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(82, 74)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter Username"
        txtUsername.Size = New Size(180, 23)
        txtUsername.TabIndex = 3
        ' 
        ' lblRole
        ' 
        lblRole.Font = New Font("Segoe UI", 12F)
        lblRole.ForeColor = Color.White
        lblRole.Location = New Point(82, 168)
        lblRole.MaximumSize = New Size(100, 30)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(49, 20)
        lblRole.TabIndex = 3
        lblRole.Text = "Role"
        ' 
        ' lblPassword
        ' 
        lblPassword.Font = New Font("Segoe UI", 12F)
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(82, 109)
        lblPassword.MaximumSize = New Size(100, 40)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(77, 20)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' lblUsername
        ' 
        lblUsername.Font = New Font("Segoe UI", 12F)
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(82, 46)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(83, 25)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F)
        lblTitle.ForeColor = Color.Green
        lblTitle.Location = New Point(274, 55)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(289, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Library Management System"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTitle)
        Controls.Add(pnlLoginCard)
        ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Library Management System - Login"
        pnlLoginCard.ResumeLayout(False)
        pnlLoginCard.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button

End Class
