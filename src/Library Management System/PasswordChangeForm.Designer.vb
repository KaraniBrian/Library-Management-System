<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordChangeForm
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
        Panel1 = New Panel()
        Label1 = New Label()
        txtCurrentPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        btnChangePassword = New Button()
        btnCancel = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnChangePassword)
        Panel1.Controls.Add(txtCurrentPassword)
        Panel1.Controls.Add(txtNewPassword)
        Panel1.Controls.Add(txtConfirmPassword)
        Panel1.Controls.Add(Label1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(200, 89)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 336)
        Panel1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(42, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 37)
        Label1.TabIndex = 0
        Label1.Text = "Change Password"
        ' 
        ' txtCurrentPassword
        ' 
        txtCurrentPassword.Font = New Font("Segoe UI", 12F)
        txtCurrentPassword.Location = New Point(52, 89)
        txtCurrentPassword.Name = "txtCurrentPassword"
        txtCurrentPassword.PlaceholderText = "Current Password"
        txtCurrentPassword.Size = New Size(268, 29)
        txtCurrentPassword.TabIndex = 5
        txtCurrentPassword.UseSystemPasswordChar = True
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Font = New Font("Segoe UI", 12F)
        txtNewPassword.Location = New Point(52, 158)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PlaceholderText = "New Password"
        txtNewPassword.Size = New Size(268, 29)
        txtNewPassword.TabIndex = 6
        txtNewPassword.UseSystemPasswordChar = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 12F)
        txtConfirmPassword.Location = New Point(52, 224)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Confirm Password"
        txtConfirmPassword.Size = New Size(268, 29)
        txtConfirmPassword.TabIndex = 7
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.BackColor = Color.DarkGreen
        btnChangePassword.Font = New Font("Segoe UI", 12F)
        btnChangePassword.Location = New Point(73, 278)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(226, 30)
        btnChangePassword.TabIndex = 8
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Silver
        btnCancel.ForeColor = Color.Black
        btnCancel.Location = New Point(325, 310)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 26)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Close"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' PasswordChangeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "PasswordChangeForm"
        Text = "PasswordChangeForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnCancel As Button
End Class
