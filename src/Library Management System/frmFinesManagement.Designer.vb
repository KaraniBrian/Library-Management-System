<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinesManagement
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
        dgvFines = New DataGridView()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnUpdateStatus = New Button()
        CType(dgvFines, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvFines
        ' 
        dgvFines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFines.BackgroundColor = Color.White
        dgvFines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFines.Location = New Point(24, 85)
        dgvFines.Name = "dgvFines"
        dgvFines.RowHeadersWidth = 62
        dgvFines.Size = New Size(753, 206)
        dgvFines.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(35, 25)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(312, 31)
        txtSearch.TabIndex = 1
        txtSearch.Text = "Enter Student ID or Name"
        txtSearch.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(423, 25)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 34)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.BackColor = Color.LightGreen
        btnUpdateStatus.FlatStyle = FlatStyle.Flat
        btnUpdateStatus.Location = New Point(586, 356)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(162, 34)
        btnUpdateStatus.TabIndex = 3
        btnUpdateStatus.Text = "Mark as paid"
        btnUpdateStatus.UseVisualStyleBackColor = False
        ' 
        ' frmFinesManagement
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(btnUpdateStatus)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(dgvFines)
        Name = "frmFinesManagement"
        Text = "frmFinesManagement"
        CType(dgvFines, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvFines As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdateStatus As Button
End Class
