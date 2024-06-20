<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        lblHeading = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblGitLink = New Label()
        lblPhoneNum = New Label()
        txtName = New TextBox()
        txtGitLink = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        btnToggleStop = New Button()
        txtStopWatch = New TextBox()
        btnSaveSubmissions = New Button()
        btnPing = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Microsoft YaHei UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeading.ForeColor = Color.White
        lblHeading.Location = New Point(21, 32)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(552, 27)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Mohammad Shahid, Slidely Task 2 - Slidely Form App"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.ForeColor = Color.White
        lblName.Location = New Point(33, 102)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 2
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.ForeColor = Color.White
        lblEmail.Location = New Point(33, 138)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email"
        ' 
        ' lblGitLink
        ' 
        lblGitLink.AutoSize = True
        lblGitLink.ForeColor = Color.White
        lblGitLink.Location = New Point(36, 221)
        lblGitLink.Name = "lblGitLink"
        lblGitLink.Size = New Size(151, 20)
        lblGitLink.TabIndex = 4
        lblGitLink.Text = "Github Link For Task 2"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.ForeColor = Color.White
        lblPhoneNum.Location = New Point(36, 177)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(86, 20)
        lblPhoneNum.TabIndex = 5
        lblPhoneNum.Text = "Phone Num"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtName.ForeColor = Color.White
        txtName.Location = New Point(219, 95)
        txtName.Name = "txtName"
        txtName.Size = New Size(317, 27)
        txtName.TabIndex = 6
        ' 
        ' txtGitLink
        ' 
        txtGitLink.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtGitLink.ForeColor = Color.White
        txtGitLink.Location = New Point(219, 214)
        txtGitLink.Name = "txtGitLink"
        txtGitLink.Size = New Size(317, 27)
        txtGitLink.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtPhone.ForeColor = Color.White
        txtPhone.Location = New Point(219, 174)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(317, 27)
        txtPhone.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(219, 135)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(317, 27)
        txtEmail.TabIndex = 9
        ' 
        ' btnToggleStop
        ' 
        btnToggleStop.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnToggleStop.Location = New Point(36, 302)
        btnToggleStop.Name = "btnToggleStop"
        btnToggleStop.Size = New Size(254, 38)
        btnToggleStop.TabIndex = 10
        btnToggleStop.Text = "Toggle Stopwatch( CRTL +T)"
        btnToggleStop.UseVisualStyleBackColor = False
        ' 
        ' txtStopWatch
        ' 
        txtStopWatch.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        txtStopWatch.ForeColor = Color.White
        txtStopWatch.Location = New Point(310, 313)
        txtStopWatch.Name = "txtStopWatch"
        txtStopWatch.Size = New Size(227, 27)
        txtStopWatch.TabIndex = 11
        ' 
        ' btnSaveSubmissions
        ' 
        btnSaveSubmissions.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnSaveSubmissions.Location = New Point(36, 433)
        btnSaveSubmissions.Name = "btnSaveSubmissions"
        btnSaveSubmissions.Size = New Size(501, 56)
        btnSaveSubmissions.TabIndex = 12
        btnSaveSubmissions.Text = "Submit ( CTRL + S)"
        btnSaveSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnPing
        ' 
        btnPing.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnPing.Location = New Point(36, 371)
        btnPing.Name = "btnPing"
        btnPing.Size = New Size(501, 56)
        btnPing.TabIndex = 13
        btnPing.Text = "Ping"
        btnPing.UseVisualStyleBackColor = False
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(575, 578)
        Controls.Add(btnPing)
        Controls.Add(btnSaveSubmissions)
        Controls.Add(txtStopWatch)
        Controls.Add(btnToggleStop)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGitLink)
        Controls.Add(txtName)
        Controls.Add(lblPhoneNum)
        Controls.Add(lblGitLink)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(lblHeading)
        Name = "CreateSubmissionForm"
        Text = "d"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblGitLink As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGitLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnToggleStop As Button
    Friend WithEvents txtStopWatch As TextBox
    Friend WithEvents btnSaveSubmissions As Button
    Friend WithEvents btnPing As Button
End Class
