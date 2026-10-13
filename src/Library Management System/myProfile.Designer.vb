<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(myProfile))
        Label1 = New Label()
        picProfile = New PictureBox()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(22, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 37)
        Label1.TabIndex = 0
        Label1.Text = "My Profile"
        ' 
        ' picProfile
        ' 
        picProfile.Image = CType(resources.GetObject("picProfile.Image"), Image)
        picProfile.Location = New Point(258, 121)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(77, 45)
        picProfile.SizeMode = PictureBoxSizeMode.Zoom
        picProfile.TabIndex = 1
        picProfile.TabStop = False
        ' 
        ' myProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(picProfile)
        Controls.Add(Label1)
        Name = "myProfile"
        Text = "myProfile"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picProfile As PictureBox
End Class
