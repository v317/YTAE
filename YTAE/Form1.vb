Imports System.IO
Imports YoutubeExplode
Imports YoutubeExplode.Models.MediaStreams
Imports YoutubeExplode.Models
Imports YoutubeExplode.Videos.Streams
Imports System.Threading

Public Class Form1
    Private scrollPosition As Integer = 0
    Private scrollSpeed As Integer = 2 ' Adjust the speed as needed
    Public Sub New()
        InitializeComponent()

        ' Set the form's size
        Me.Size = New Size(393, 463)

        ' Center the form on the screen
        Me.StartPosition = FormStartPosition.CenterScreen


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        versionInfoLabel.Text = ("Version " & My.Application.Info.Version.ToString & " - " & "By Alt")

        'THEME
        Me.BackColor = Color.FromArgb(24, 26, 27)
        Me.ForeColor = Color.White
        ScrollingText.ForeColor = Color.White
        versionInfoLabel.ForeColor = Color.White
        extractAudioButton.ForeColor = Color.Black
        OpenDirBtn.ForeColor = Color.Black

        'Start scrolling text time
        ScrollingText.Font = New Font("Segoe UI Emoji", 9)
        Timer1.Interval = 20 'Adjust the interval as needed
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Get the current position of the label's text
        Dim currentPosition As Point = ScrollingText.Location

        'Calculate the new position based on the scroll speed
        currentPosition.X -= scrollSpeed

        'If the text has scrolled off the form, loop it back to the beginning
        If currentPosition.X < -ScrollingText.Width Then
            currentPosition.X = Me.ClientSize.Width
        End If

        'Update the label's position
        ScrollingText.Location = currentPosition
    End Sub
    Private Async Sub extractAudioButton_Click(sender As Object, e As EventArgs) Handles extractAudioButton.Click
        Dim videoUrl As String = videoUrlTextBox.Text.Trim()

        If Not String.IsNullOrEmpty(videoUrl) Then
            Try
                extractionStatusLabel.Text = "Status: Starting..."
                Dim youtube As New YoutubeClient()
                Dim videoInfo = Await youtube.Videos.GetAsync(videoUrl)

                ' Retrieve the video title and remove unwanted characters
                Dim videoTitle As String = videoInfo.Title
                videoTitle = videoTitle.Replace("<", "").Replace(">", "").Replace(":", "").Replace("""", "").Replace("/", "").Replace("\", "").Replace("|", "").Replace("?", "").Replace("*", "")
                ' Display the modified video title in the TextBox
                VideoTitleTxt.Text = videoTitle

                ' Retrieve the audio stream with the highest bitrate
                Dim streamManifest = Await youtube.Videos.Streams.GetManifestAsync(videoInfo.Id)
                Dim audioStreamInfo = streamManifest.GetAudioOnlyStreams.GetWithHighestBitrate()

                If audioStreamInfo IsNot Nothing Then
                    ' Prepare the UI for extraction
                    ProgressBar1.Value = 0
                    extractionStatusLabel.Text = "Status: Extracting audio..."
                    extractionStatusLabel.Visible = True

                    ' Create a progress tracker
                    Dim progress = New Progress(Of Double)(Sub(p) ProgressBar1.Value = CInt(p * 100))

                    ' Check if "Downloads" folder exists in the application directory
                    Dim downloadsFolderPath As String = Path.Combine(Application.StartupPath, "Downloads")
                    If Not Directory.Exists(downloadsFolderPath) Then
                        ' Create the "Downloads" folder if it doesn't exist
                        Directory.CreateDirectory(downloadsFolderPath)
                    End If

                    ' Download the audio stream to a file
                    Dim audioFilePath As String = Path.Combine(Application.StartupPath & "/Downloads/" & VideoTitleTxt.Text & ".mp3")
                    Await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, audioFilePath, progress)

                    ' Update the UI after extraction
                    extractionStatusLabel.Text = "Status: Audio extracted successfully!"
                Else
                    extractionStatusLabel.Text = "Status: No audio stream found for the video."
                End If
            Catch ex As Exception
                extractionStatusLabel.Text = "Status: Error extracting audio: " & ex.Message
            End Try
        Else
            extractionStatusLabel.Text = "Status: Please enter a valid YouTube video URL."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OpenDirBtn.Click
        ' Open the "Downloads" folder in Explorer
        Dim downloadsFolderPath As String = Path.Combine(Application.StartupPath, "Downloads")
        Process.Start("explorer.exe", downloadsFolderPath)
    End Sub
End Class
