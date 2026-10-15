<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetails
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
        lblTitle = New Label()
        txtTitle = New TextBox()
        txtAuthor = New TextBox()
        txtISBN = New TextBox()
        lblAuthor = New Label()
        lblISBN = New Label()
        txtCategory = New TextBox()
        lblCategory = New Label()
        lblAvailable = New Label()
        txtAvailable = New TextBox()
        btnBorrow = New Button()
        btnCloseView = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(34, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(83, 20)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Book Title :"
        ' 
        ' txtTitle
        ' 
        txtTitle.BackColor = SystemColors.GradientInactiveCaption
        txtTitle.Location = New Point(249, 24)
        txtTitle.Name = "txtTitle"
        txtTitle.ReadOnly = True
        txtTitle.Size = New Size(467, 27)
        txtTitle.TabIndex = 1
        txtTitle.TabStop = False
        txtTitle.Text = " "
        ' 
        ' txtAuthor
        ' 
        txtAuthor.BackColor = SystemColors.GradientInactiveCaption
        txtAuthor.Location = New Point(249, 68)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.ReadOnly = True
        txtAuthor.Size = New Size(467, 27)
        txtAuthor.TabIndex = 2
        txtAuthor.TabStop = False
        ' 
        ' txtISBN
        ' 
        txtISBN.BackColor = SystemColors.GradientInactiveCaption
        txtISBN.Location = New Point(249, 126)
        txtISBN.Name = "txtISBN"
        txtISBN.ReadOnly = True
        txtISBN.Size = New Size(467, 27)
        txtISBN.TabIndex = 3
        txtISBN.TabStop = False
        ' 
        ' lblAuthor
        ' 
        lblAuthor.AutoSize = True
        lblAuthor.Location = New Point(34, 75)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(61, 20)
        lblAuthor.TabIndex = 4
        lblAuthor.Text = "Author :"
        ' 
        ' lblISBN
        ' 
        lblISBN.AutoSize = True
        lblISBN.Location = New Point(34, 126)
        lblISBN.Name = "lblISBN"
        lblISBN.Size = New Size(48, 20)
        lblISBN.TabIndex = 5
        lblISBN.Text = "ISBN :"
        ' 
        ' txtCategory
        ' 
        txtCategory.BackColor = SystemColors.GradientInactiveCaption
        txtCategory.Location = New Point(249, 187)
        txtCategory.Name = "txtCategory"
        txtCategory.ReadOnly = True
        txtCategory.Size = New Size(467, 27)
        txtCategory.TabIndex = 6
        txtCategory.TabStop = False
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(15, 187)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(80, 20)
        lblCategory.TabIndex = 7
        lblCategory.Text = "Category : "
        ' 
        ' lblAvailable
        ' 
        lblAvailable.AutoSize = True
        lblAvailable.Location = New Point(17, 249)
        lblAvailable.Name = "lblAvailable"
        lblAvailable.Size = New Size(78, 20)
        lblAvailable.TabIndex = 8
        lblAvailable.Text = "Available :"
        ' 
        ' txtAvailable
        ' 
        txtAvailable.BackColor = SystemColors.GradientInactiveCaption
        txtAvailable.Location = New Point(249, 242)
        txtAvailable.Name = "txtAvailable"
        txtAvailable.ReadOnly = True
        txtAvailable.Size = New Size(467, 27)
        txtAvailable.TabIndex = 9
        txtAvailable.TabStop = False
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = Color.GreenYellow
        btnBorrow.Location = New Point(238, 341)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(197, 69)
        btnBorrow.TabIndex = 10
        btnBorrow.Text = "Borrow"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' btnCloseView
        ' 
        btnCloseView.BackColor = Color.GreenYellow
        btnCloseView.Location = New Point(502, 341)
        btnCloseView.Name = "btnCloseView"
        btnCloseView.Size = New Size(194, 69)
        btnCloseView.TabIndex = 11
        btnCloseView.Text = "Close"
        btnCloseView.UseVisualStyleBackColor = False
        ' 
        ' BookDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 530)
        Controls.Add(btnCloseView)
        Controls.Add(btnBorrow)
        Controls.Add(txtAvailable)
        Controls.Add(lblAvailable)
        Controls.Add(lblCategory)
        Controls.Add(txtCategory)
        Controls.Add(lblISBN)
        Controls.Add(lblAuthor)
        Controls.Add(txtISBN)
        Controls.Add(txtAuthor)
        Controls.Add(txtTitle)
        Controls.Add(lblTitle)
        Name = "BookDetails"
        Text = "Book Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents txtAvailable As TextBox
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnCloseView As Button
End Class
