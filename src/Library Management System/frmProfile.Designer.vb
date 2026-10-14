<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProfile
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
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.btnChangePhoto = New System.Windows.Forms.Button()
        Me.lblAdmissionNo = New System.Windows.Forms.Label()
        Me.txtAdmissionNo = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(30, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Student Profile"
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.White
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(30, 80)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(140, 140)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 1
        Me.picProfile.TabStop = False
        '
        'btnChangePhoto
        '
        Me.btnChangePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePhoto.Location = New System.Drawing.Point(30, 230)
        Me.btnChangePhoto.Name = "btnChangePhoto"
        Me.btnChangePhoto.Size = New System.Drawing.Size(140, 34)
        Me.btnChangePhoto.TabIndex = 2
        Me.btnChangePhoto.Text = "Change Photo"
        Me.btnChangePhoto.UseVisualStyleBackColor = True
        '
        'lblAdmissionNo
        '
        Me.lblAdmissionNo.AutoSize = True
        Me.lblAdmissionNo.Location = New System.Drawing.Point(220, 85)
        Me.lblAdmissionNo.Name = "lblAdmissionNo"
        Me.lblAdmissionNo.TabIndex = 3
        Me.lblAdmissionNo.Text = "Admission Number:"
        '
        'txtAdmissionNo
        '
        Me.txtAdmissionNo.Location = New System.Drawing.Point(400, 80)
        Me.txtAdmissionNo.MaxLength = 50
        Me.txtAdmissionNo.Name = "txtAdmissionNo"
        Me.txtAdmissionNo.ReadOnly = True
        Me.txtAdmissionNo.Size = New System.Drawing.Size(300, 30)
        Me.txtAdmissionNo.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(220, 140)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(400, 135)
        Me.txtFirstName.MaxLength = 100
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(300, 30)
        Me.txtFirstName.TabIndex = 6
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(220, 195)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(400, 190)
        Me.txtLastName.MaxLength = 100
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(300, 30)
        Me.txtLastName.TabIndex = 8
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(220, 250)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(400, 245)
        Me.txtEmail.MaxLength = 255
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(300, 30)
        Me.txtEmail.TabIndex = 10
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(220, 305)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.TabIndex = 11
        Me.lblPhone.Text = "Phone:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(400, 300)
        Me.txtPhone.MaxLength = 20
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(300, 30)
        Me.txtPhone.TabIndex = 12
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(220, 365)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(160, 38)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit Profile"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(220, 365)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 38)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(390, 365)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 38)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnChangePassword.Location = New System.Drawing.Point(510, 365)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(170, 38)
        Me.btnChangePassword.TabIndex = 16
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.lblMessage.Location = New System.Drawing.Point(220, 425)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.TabIndex = 17
        '
        'frmProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.btnChangePhoto)
        Me.Controls.Add(Me.lblAdmissionNo)
        Me.Controls.Add(Me.txtAdmissionNo)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.lblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Name = "frmProfile"
        Me.Text = "Student Profile"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picProfile As System.Windows.Forms.PictureBox
    Friend WithEvents btnChangePhoto As System.Windows.Forms.Button
    Friend WithEvents lblAdmissionNo As System.Windows.Forms.Label
    Friend WithEvents txtAdmissionNo As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class