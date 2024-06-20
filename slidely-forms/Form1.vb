Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewSubmissions.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check for key combinations and trigger actions
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl + N to go to create a new submission
            btnNewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
            ' Ctrl + V to go to view submission
            btnViewSubmissions.PerformClick()
        End If
    End Sub

End Class
