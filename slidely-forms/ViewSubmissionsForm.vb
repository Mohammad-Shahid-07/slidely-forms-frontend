Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm

    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer = 0
    Private submissions As New List(Of Submission)()

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFormControls()
        Await LoadSubmissionsCount()
        Await LoadSubmissions()
    End Sub

    Private Sub InitializeFormControls()
        Me.KeyPreview = True
        txtName.Enabled = False
        txtEmail.Enabled = False
        txtPhone.Enabled = False
        txtGitLink.Enabled = False
        txtStopWatch.Enabled = False
        btnResetSearch.Visible = False
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle key combinations for actions
        Select Case e.KeyData
            Case Keys.Control Or Keys.N
                btnNext.PerformClick()
            Case Keys.Control Or Keys.P
                btnPrev.PerformClick()
            Case Keys.Control Or Keys.E
                btnEdit.PerformClick()
            Case Keys.Control Or Keys.D
                btnDelete.PerformClick()
        End Select
    End Sub

    Private Async Function LoadSubmissions() As Task
        Dim client As New HttpClient()
        Dim apiUrl As String = $"http://localhost:3000/read?index={currentIndex}"

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

            If response.IsSuccessStatusCode Then
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseBody)

                If currentIndex < submissions.Count Then
                    submissions(currentIndex) = submission
                Else
                    submissions.Add(submission)
                End If

                UpdateFormFields()
            Else
                MessageBox.Show($"Failed to fetch submission data: {response.StatusCode}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to connect to server: {ex.Message}")
        End Try
    End Function

    Private Async Function LoadSubmissionsCount() As Task
        Dim client As New HttpClient()
        Dim apiUrl As String = $"http://localhost:3000/count"

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

            If response.IsSuccessStatusCode Then
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim submissionCount As SubmissionCount = JsonConvert.DeserializeObject(Of SubmissionCount)(responseBody)

                totalSubmissions = submissionCount.count
                MessageBox.Show($"Total submissions: {totalSubmissions}")
            Else
                MessageBox.Show($"Failed to fetch submission count: {response.StatusCode}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to connect to server: {ex.Message}")
        End Try
    End Function

    Private Sub UpdateFormFields()
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim submission As Submission = submissions(currentIndex)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGitLink.Text = submission.GitHubLink
            txtStopWatch.Text = submission.StopwatchTime
        Else
            ClearFormFields()
        End If
    End Sub

    Private Sub ClearFormFields()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGitLink.Text = ""
        txtStopWatch.Text = ""
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            Await LoadSubmissions()
        Else
            MessageBox.Show("No more submissions.")
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            UpdateFormFields()
        Else
            MessageBox.Show("Already at the first submission.")
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim client As New HttpClient()
        Dim apiUrl As String = $"http://localhost:3000/delete?index={currentIndex}"

        Try
            Dim response As HttpResponseMessage = Await client.DeleteAsync(apiUrl)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully.")
                Await LoadSubmissionsCount()

                ' Adjust the currentIndex if necessary
                If currentIndex >= totalSubmissions Then
                    currentIndex = totalSubmissions - 1
                End If

                ' Reload submissions and update form fields
                If totalSubmissions > 0 Then
                    Await LoadSubmissions()
                Else
                    ClearFormFields()
                    MessageBox.Show("No more submissions.")
                End If
            Else
                MessageBox.Show($"Failed to delete submission: {response.StatusCode}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to connect to server: {ex.Message}")
        End Try
    End Sub

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit (CTRL + E)" Then
            EnableEditFields()
        ElseIf btnEdit.Text = "Submit" Then
            Await SubmitEditedSubmission()
        End If
    End Sub

    Private Sub EnableEditFields()
        txtName.Enabled = True
        txtEmail.Enabled = True
        txtPhone.Enabled = True
        txtGitLink.Enabled = True
        txtStopWatch.Enabled = True
        txtSearch.Enabled = False
        btnEdit.Text = "Submit"
    End Sub

    Private Async Function SubmitEditedSubmission() As Task
        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGitLink.Text,
            .StopwatchTime = txtStopWatch.Text
        }

        txtSearch.Enabled = True

        Dim client As New HttpClient()
        Dim apiUrl As String = $"http://localhost:3000/edit?index={currentIndex}"
        Dim content As StringContent = New StringContent(JsonConvert.SerializeObject(submission), Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await client.PutAsync(apiUrl, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission updated successfully.")
                DisableEditFields()
                Await LoadSubmissions()
            Else
                MessageBox.Show($"Failed to update submission: {response.StatusCode}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to connect to server: {ex.Message}")
        End Try
    End Function

    Private Sub DisableEditFields()
        txtName.Enabled = False
        txtEmail.Enabled = False
        txtPhone.Enabled = False
        txtGitLink.Enabled = False
        txtStopWatch.Enabled = False
        btnEdit.Text = "Edit (CTRL + E)"
    End Sub

    Private Async Function SearchSubmissionsByEmail(email As String) As Task
        Dim client As New HttpClient()
        Dim apiUrl As String = $"http://localhost:3000/search?email={email}"

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

            If response.IsSuccessStatusCode Then
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim foundSubmissions As List(Of Submission) = JsonConvert.DeserializeObject(Of List(Of Submission))(responseBody)

                If foundSubmissions IsNot Nothing AndAlso foundSubmissions.Count > 0 Then
                    MessageBox.Show($"Found {foundSubmissions.Count} submission(s) with the provided email.")

                    submissions.Clear()
                    submissions.AddRange(foundSubmissions)

                    currentIndex = 0
                    UpdateFormFields()
                    btnResetSearch.Visible = True
                Else
                    MessageBox.Show("No submissions found with the provided email.")
                    btnResetSearch.Visible = False
                End If
            Else
                MessageBox.Show($"Failed to fetch submission data: {response.StatusCode}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to connect to server: {ex.Message}")
        End Try
    End Function

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = txtSearch.Text.Trim()
        If Not String.IsNullOrEmpty(email) Then
            Await SearchSubmissionsByEmail(email)
            txtSearch.Text = ""
        Else
            MessageBox.Show("Please enter an email to search.")
        End If
    End Sub

    Private Async Sub btnResetSearch_Click(sender As Object, e As EventArgs) Handles btnResetSearch.Click
        submissions.Clear()
        currentIndex = 0
        btnResetSearch.Visible = False
        UpdateFormFields()
        Await LoadSubmissions()
    End Sub

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHubLink As String
        Public Property StopwatchTime As String
    End Class

    Public Class SubmissionCount
        Public Property count As Integer
    End Class

End Class
