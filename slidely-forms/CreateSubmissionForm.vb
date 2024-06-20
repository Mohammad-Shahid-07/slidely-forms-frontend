Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm

    Private stopwatch As New Stopwatch()
    Private WithEvents tmrStopwatch As New Timer()

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHubLink As String
        Public Property StopwatchTime As String
    End Class

    Private Sub btnToggleStop_Click(sender As Object, e As EventArgs) Handles btnToggleStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            tmrStopwatch.Stop()
            btnToggleStop.Text = "Start"
        Else
            stopwatch.Start()
            tmrStopwatch.Start()
            btnToggleStop.Text = "Stop"
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Sub TmrStopwatchTick(sender As Object, e As EventArgs) Handles tmrStopwatch.Tick
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        txtStopWatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSaveSubmissions_Click(sender As Object, e As EventArgs) Handles btnSaveSubmissions.Click
        If ValidateInputs() Then
            Dim newSubmission As New Submission() With {
                .Name = txtName.Text,
                .Email = txtEmail.Text,
                .Phone = txtPhone.Text,
                .GitHubLink = txtGitLink.Text,
                .StopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")
            }

            Await SaveSubmission(newSubmission)

            ' Clear input fields and reset stopwatch
            ClearInputs()
            stopwatch.Reset()
            UpdateStopwatchDisplay()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not IsValidEmail(txtEmail.Text) Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPhone.Text) Then
            MessageBox.Show("Please enter a phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtGitLink.Text) Then
            MessageBox.Show("Please enter a Github Link.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Private Async Function SaveSubmission(submission As Submission) As Task
        Dim client As New HttpClient()

        ' API endpoint URL on your backend
        Dim apiUrl As String = "http://localhost:3000/submit"  ' Replace with your actual backend URL

        ' Convert submission object to JSON string
        Dim jsonSubmission As String = JsonConvert.SerializeObject(submission)

        ' Create HttpContent for POST request
        Dim content As New StringContent(jsonSubmission, Encoding.UTF8, "application/json")

        ' Send POST request
        Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission saved successfully")
        Else
            MessageBox.Show("Failed to save submission: " & response.StatusCode.ToString())
        End If
    End Function

    Private Async Sub btnPing_Click(sender As Object, e As EventArgs) Handles btnPing.Click
        Await PingServer()
    End Sub

    Private Async Function PingServer() As Task
        Dim client As New HttpClient()

        ' API endpoint URL on your backend
        Dim apiUrl As String = "http://localhost:3000/ping"  ' Replace with your actual backend URL

        Try
            ' Send GET request
            Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Server is reachable")
            Else
                MessageBox.Show("Server returned error: " & response.StatusCode.ToString())
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to server: " & ex.Message)
        End Try
    End Function

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStopWatch.Enabled = False
        tmrStopwatch.Interval = 1000 ' Update every second
        Me.KeyPreview = True
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Ctrl + S to Save Submission
            btnSaveSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ' Ctrl + T to Toggle Stopwatch
            btnToggleStop.PerformClick()
        End If
    End Sub

    Private Sub ClearInputs()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGitLink.Text = ""
        txtStopWatch.Text = ""
    End Sub

End Class
