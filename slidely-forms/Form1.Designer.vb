<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeading = New Label()
        btnViewSubmissions = New Button()
        btnNewSubmissions = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeading.ForeColor = Color.White
        lblHeading.Location = New Point(172, 70)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(477, 28)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Mohammad Shahid, Slidely Task 2 - Slidely Form App"
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnViewSubmissions.Location = New Point(144, 170)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(551, 80)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "View Submissions ( CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnNewSubmissions
        ' 
        btnNewSubmissions.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnNewSubmissions.Location = New Point(144, 282)
        btnNewSubmissions.Name = "btnNewSubmissions"
        btnNewSubmissions.Size = New Size(551, 80)
        btnNewSubmissions.TabIndex = 2
        btnNewSubmissions.Text = "Create New Submissions ( CTRL + N)"
        btnNewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(800, 450)
        Controls.Add(btnNewSubmissions)
        Controls.Add(btnViewSubmissions)
        Controls.Add(lblHeading)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnNewSubmissions As Button

End Class
