<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnPrev = New Button()
        btnNext = New Button()
        txtStopWatch = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitLink = New TextBox()
        txtName = New TextBox()
        lblPhoneNum = New Label()
        lblGitLink = New Label()
        lblEmail = New Label()
        lblName = New Label()
        lblHeading = New Label()
        lblStopWatch = New Label()
        btnDelete = New Button()
        btnEdit = New Button()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnResetSearch = New Button()
        SuspendLayout()
        ' 
        ' btnPrev
        ' 
        btnPrev.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnPrev.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnPrev.Location = New Point(92, 378)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(247, 56)
        btnPrev.TabIndex = 26
        btnPrev.Text = "Previous ( CTRL + P)"
        btnPrev.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnNext.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnNext.Location = New Point(356, 378)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(237, 56)
        btnNext.TabIndex = 25
        btnNext.Text = "Next ( CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' txtStopWatch
        ' 
        txtStopWatch.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtStopWatch.ForeColor = Color.White
        txtStopWatch.Location = New Point(276, 315)
        txtStopWatch.Margin = New Padding(1)
        txtStopWatch.MaxLength = 100
        txtStopWatch.Name = "txtStopWatch"
        txtStopWatch.Size = New Size(318, 27)
        txtStopWatch.TabIndex = 24
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(276, 183)
        txtEmail.Margin = New Padding(1)
        txtEmail.MaxLength = 100
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(317, 27)
        txtEmail.TabIndex = 22
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtPhone.ForeColor = Color.White
        txtPhone.Location = New Point(276, 222)
        txtPhone.Margin = New Padding(1)
        txtPhone.MaxLength = 100
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(317, 27)
        txtPhone.TabIndex = 21
        ' 
        ' txtGitLink
        ' 
        txtGitLink.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtGitLink.ForeColor = Color.White
        txtGitLink.Location = New Point(276, 262)
        txtGitLink.Margin = New Padding(1)
        txtGitLink.MaxLength = 100
        txtGitLink.Name = "txtGitLink"
        txtGitLink.Size = New Size(317, 27)
        txtGitLink.TabIndex = 20
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtName.ForeColor = Color.White
        txtName.Location = New Point(276, 143)
        txtName.Margin = New Padding(1)
        txtName.MaxLength = 100
        txtName.Name = "txtName"
        txtName.Size = New Size(317, 27)
        txtName.TabIndex = 19
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.ForeColor = Color.White
        lblPhoneNum.Location = New Point(93, 225)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(86, 20)
        lblPhoneNum.TabIndex = 18
        lblPhoneNum.Text = "Phone Num"
        ' 
        ' lblGitLink
        ' 
        lblGitLink.AutoSize = True
        lblGitLink.ForeColor = Color.White
        lblGitLink.Location = New Point(93, 269)
        lblGitLink.Name = "lblGitLink"
        lblGitLink.Size = New Size(151, 20)
        lblGitLink.TabIndex = 17
        lblGitLink.Text = "Github Link For Task 2"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.ForeColor = Color.White
        lblEmail.Location = New Point(90, 186)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 16
        lblEmail.Text = "Email"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.ForeColor = Color.White
        lblName.Location = New Point(90, 150)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 15
        lblName.Text = "Name"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeading.ForeColor = Color.White
        lblHeading.Location = New Point(93, 21)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(477, 28)
        lblHeading.TabIndex = 14
        lblHeading.Text = "Mohammad Shahid, Slidely Task 2 - Slidely Form App"
        ' 
        ' lblStopWatch
        ' 
        lblStopWatch.AutoSize = True
        lblStopWatch.ForeColor = Color.White
        lblStopWatch.Location = New Point(93, 322)
        lblStopWatch.Name = "lblStopWatch"
        lblStopWatch.Size = New Size(116, 20)
        lblStopWatch.TabIndex = 27
        lblStopWatch.Text = "Stopwatch Time"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.White
        btnDelete.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnDelete.Location = New Point(92, 454)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(247, 56)
        btnDelete.TabIndex = 28
        btnDelete.Text = "Delete (CTRL + D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Gray
        btnEdit.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnEdit.Location = New Point(356, 454)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(238, 56)
        btnEdit.TabIndex = 29
        btnEdit.Text = "Edit (CTRL + E)"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(276, 101)
        txtSearch.Margin = New Padding(1)
        txtSearch.MaxLength = 100
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(318, 27)
        txtSearch.TabIndex = 30
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnSearch.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnSearch.Location = New Point(90, 93)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(168, 35)
        btnSearch.TabIndex = 31
        btnSearch.Text = "Search With Email"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnResetSearch
        ' 
        btnResetSearch.BackColor = Color.FromArgb(CByte(25), CByte(236), CByte(153))
        btnResetSearch.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        btnResetSearch.Location = New Point(425, 52)
        btnResetSearch.Name = "btnResetSearch"
        btnResetSearch.Size = New Size(168, 43)
        btnResetSearch.TabIndex = 32
        btnResetSearch.Text = "Veiw All Results"
        btnResetSearch.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(684, 541)
        Controls.Add(btnResetSearch)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(lblStopWatch)
        Controls.Add(btnPrev)
        Controls.Add(btnNext)
        Controls.Add(txtStopWatch)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGitLink)
        Controls.Add(txtName)
        Controls.Add(lblPhoneNum)
        Controls.Add(lblGitLink)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(lblHeading)
        ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtStopWatch As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitLink As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblGitLink As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblStopWatch As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnResetSearch As Button
End Class
