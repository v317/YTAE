<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.videoUrlTextBox = New System.Windows.Forms.TextBox()
        Me.extractAudioButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VideoTitleTxt = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.extractionStatusLabel = New System.Windows.Forms.Label()
        Me.ScrollingText = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.versionInfoLabel = New System.Windows.Forms.Label()
        Me.OpenDirBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'videoUrlTextBox
        '
        Me.videoUrlTextBox.Location = New System.Drawing.Point(15, 160)
        Me.videoUrlTextBox.Name = "videoUrlTextBox"
        Me.videoUrlTextBox.Size = New System.Drawing.Size(351, 22)
        Me.videoUrlTextBox.TabIndex = 0
        '
        'extractAudioButton
        '
        Me.extractAudioButton.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extractAudioButton.Location = New System.Drawing.Point(87, 241)
        Me.extractAudioButton.Name = "extractAudioButton"
        Me.extractAudioButton.Size = New System.Drawing.Size(198, 36)
        Me.extractAudioButton.TabIndex = 1
        Me.extractAudioButton.Text = "Extract Audio"
        Me.extractAudioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Youtube URL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Audio Title:"
        '
        'VideoTitleTxt
        '
        Me.VideoTitleTxt.Location = New System.Drawing.Point(15, 203)
        Me.VideoTitleTxt.Name = "VideoTitleTxt"
        Me.VideoTitleTxt.ReadOnly = True
        Me.VideoTitleTxt.Size = New System.Drawing.Size(351, 22)
        Me.VideoTitleTxt.TabIndex = 3
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 358)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(354, 27)
        Me.ProgressBar1.TabIndex = 5
        '
        'extractionStatusLabel
        '
        Me.extractionStatusLabel.AutoSize = True
        Me.extractionStatusLabel.Location = New System.Drawing.Point(9, 339)
        Me.extractionStatusLabel.Name = "extractionStatusLabel"
        Me.extractionStatusLabel.Size = New System.Drawing.Size(86, 15)
        Me.extractionStatusLabel.TabIndex = 6
        Me.extractionStatusLabel.Text = "Status: Waiting"
        '
        'ScrollingText
        '
        Me.ScrollingText.AutoSize = True
        Me.ScrollingText.ForeColor = System.Drawing.Color.Black
        Me.ScrollingText.Location = New System.Drawing.Point(9, 400)
        Me.ScrollingText.Name = "ScrollingText"
        Me.ScrollingText.Size = New System.Drawing.Size(514, 15)
        Me.ScrollingText.TabIndex = 7
        Me.ScrollingText.Text = "Welcome to YTAE - Extract audio from your favourite videos in mp3.... This softwa" &
    "re is in beta stage!"
        '
        'Timer1
        '
        '
        'versionInfoLabel
        '
        Me.versionInfoLabel.AutoSize = True
        Me.versionInfoLabel.ForeColor = System.Drawing.Color.Black
        Me.versionInfoLabel.Location = New System.Drawing.Point(125, 91)
        Me.versionInfoLabel.Name = "versionInfoLabel"
        Me.versionInfoLabel.Size = New System.Drawing.Size(85, 15)
        Me.versionInfoLabel.TabIndex = 9
        Me.versionInfoLabel.Text = "Version - By Alt"
        '
        'OpenDirBtn
        '
        Me.OpenDirBtn.Location = New System.Drawing.Point(87, 283)
        Me.OpenDirBtn.Name = "OpenDirBtn"
        Me.OpenDirBtn.Size = New System.Drawing.Size(198, 36)
        Me.OpenDirBtn.TabIndex = 10
        Me.OpenDirBtn.Text = "Open Downloads Folder..."
        Me.OpenDirBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.YTAE.My.Resources.Resources.YTAE3
        Me.PictureBox1.Location = New System.Drawing.Point(12, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 424)
        Me.Controls.Add(Me.OpenDirBtn)
        Me.Controls.Add(Me.versionInfoLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ScrollingText)
        Me.Controls.Add(Me.extractionStatusLabel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VideoTitleTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.extractAudioButton)
        Me.Controls.Add(Me.videoUrlTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "YTAE - YouTube Audio Extractor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents videoUrlTextBox As TextBox
    Friend WithEvents extractAudioButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VideoTitleTxt As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents extractionStatusLabel As Label
    Friend WithEvents ScrollingText As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents versionInfoLabel As Label
    Friend WithEvents OpenDirBtn As Button
End Class
