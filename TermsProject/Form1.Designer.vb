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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SBreakTrackbar = New System.Windows.Forms.TrackBar()
        Me.PomodoroTrackbar = New System.Windows.Forms.TrackBar()
        Me.TimerLbn = New System.Windows.Forms.Label()
        Me.PomodoroName = New System.Windows.Forms.TextBox()
        Me.AutoStartBreak = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AutoStartPomodoro = New System.Windows.Forms.CheckBox()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.PauseBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBreakTimeLbn = New System.Windows.Forms.Label()
        Me.LBreakLbn = New System.Windows.Forms.Label()
        Me.LBreakTrackbar = New System.Windows.Forms.TrackBar()
        Me.SBreakTimeLbn = New System.Windows.Forms.Label()
        Me.PomodoroTimeLbn = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SBreakTimeSetLbn = New System.Windows.Forms.Label()
        Me.PomodoroTimeSetLbn = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StateLbn = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SBreakTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PomodoroTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LBreakTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 31)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(596, 10)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 410)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(599, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'SBreakTrackbar
        '
        Me.SBreakTrackbar.Location = New System.Drawing.Point(117, 55)
        Me.SBreakTrackbar.Maximum = 30
        Me.SBreakTrackbar.Name = "SBreakTrackbar"
        Me.SBreakTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.SBreakTrackbar.Size = New System.Drawing.Size(56, 181)
        Me.SBreakTrackbar.TabIndex = 2
        Me.SBreakTrackbar.TickFrequency = 5
        '
        'PomodoroTrackbar
        '
        Me.PomodoroTrackbar.Location = New System.Drawing.Point(29, 55)
        Me.PomodoroTrackbar.Maximum = 60
        Me.PomodoroTrackbar.Name = "PomodoroTrackbar"
        Me.PomodoroTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PomodoroTrackbar.Size = New System.Drawing.Size(56, 181)
        Me.PomodoroTrackbar.TabIndex = 3
        Me.PomodoroTrackbar.TickFrequency = 5
        '
        'TimerLbn
        '
        Me.TimerLbn.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLbn.Location = New System.Drawing.Point(0, 112)
        Me.TimerLbn.Name = "TimerLbn"
        Me.TimerLbn.Size = New System.Drawing.Size(321, 92)
        Me.TimerLbn.TabIndex = 4
        Me.TimerLbn.Text = "Timer"
        Me.TimerLbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PomodoroName
        '
        Me.PomodoroName.Location = New System.Drawing.Point(3, 32)
        Me.PomodoroName.Name = "PomodoroName"
        Me.PomodoroName.Size = New System.Drawing.Size(318, 22)
        Me.PomodoroName.TabIndex = 5
        Me.PomodoroName.Text = "Pomodoro Name"
        '
        'AutoStartBreak
        '
        Me.AutoStartBreak.AutoSize = True
        Me.AutoStartBreak.Location = New System.Drawing.Point(16, 59)
        Me.AutoStartBreak.Name = "AutoStartBreak"
        Me.AutoStartBreak.Size = New System.Drawing.Size(134, 21)
        Me.AutoStartBreak.TabIndex = 6
        Me.AutoStartBreak.Text = "Auto Start Break"
        Me.AutoStartBreak.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AutoStartPomodoro)
        Me.GroupBox1.Controls.Add(Me.AutoStartBreak)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 103)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'AutoStartPomodoro
        '
        Me.AutoStartPomodoro.AutoSize = True
        Me.AutoStartPomodoro.Location = New System.Drawing.Point(16, 32)
        Me.AutoStartPomodoro.Name = "AutoStartPomodoro"
        Me.AutoStartPomodoro.Size = New System.Drawing.Size(162, 21)
        Me.AutoStartPomodoro.TabIndex = 7
        Me.AutoStartPomodoro.Text = "Auto Start Pomodoro"
        Me.AutoStartPomodoro.UseVisualStyleBackColor = True
        '
        'StartBtn
        '
        Me.StartBtn.Location = New System.Drawing.Point(3, 311)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(318, 26)
        Me.StartBtn.TabIndex = 8
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'PauseBtn
        '
        Me.PauseBtn.Location = New System.Drawing.Point(3, 339)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.Size = New System.Drawing.Size(318, 28)
        Me.PauseBtn.TabIndex = 9
        Me.PauseBtn.Text = "Pause"
        Me.PauseBtn.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(263, 281)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(58, 24)
        Me.ResetBtn.TabIndex = 10
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LBreakTimeLbn)
        Me.Panel1.Controls.Add(Me.LBreakLbn)
        Me.Panel1.Controls.Add(Me.LBreakTrackbar)
        Me.Panel1.Controls.Add(Me.SBreakTimeLbn)
        Me.Panel1.Controls.Add(Me.PomodoroTimeLbn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.SBreakTimeSetLbn)
        Me.Panel1.Controls.Add(Me.PomodoroTimeSetLbn)
        Me.Panel1.Controls.Add(Me.PomodoroTrackbar)
        Me.Panel1.Controls.Add(Me.SBreakTrackbar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(327, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 401)
        Me.Panel1.TabIndex = 11
        '
        'LBreakTimeLbn
        '
        Me.LBreakTimeLbn.AutoSize = True
        Me.LBreakTimeLbn.Location = New System.Drawing.Point(184, 236)
        Me.LBreakTimeLbn.Name = "LBreakTimeLbn"
        Me.LBreakTimeLbn.Size = New System.Drawing.Size(62, 17)
        Me.LBreakTimeLbn.TabIndex = 15
        Me.LBreakTimeLbn.Text = "0 Minute"
        '
        'LBreakLbn
        '
        Me.LBreakLbn.AutoSize = True
        Me.LBreakLbn.Location = New System.Drawing.Point(184, 35)
        Me.LBreakLbn.Name = "LBreakLbn"
        Me.LBreakLbn.Size = New System.Drawing.Size(81, 17)
        Me.LBreakLbn.TabIndex = 14
        Me.LBreakLbn.Text = "Long Break"
        '
        'LBreakTrackbar
        '
        Me.LBreakTrackbar.Location = New System.Drawing.Point(209, 55)
        Me.LBreakTrackbar.Maximum = 30
        Me.LBreakTrackbar.Name = "LBreakTrackbar"
        Me.LBreakTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.LBreakTrackbar.Size = New System.Drawing.Size(56, 181)
        Me.LBreakTrackbar.TabIndex = 13
        Me.LBreakTrackbar.TickFrequency = 5
        '
        'SBreakTimeLbn
        '
        Me.SBreakTimeLbn.AutoSize = True
        Me.SBreakTimeLbn.Location = New System.Drawing.Point(98, 239)
        Me.SBreakTimeLbn.Name = "SBreakTimeLbn"
        Me.SBreakTimeLbn.Size = New System.Drawing.Size(62, 17)
        Me.SBreakTimeLbn.TabIndex = 12
        Me.SBreakTimeLbn.Text = "0 Minute"
        '
        'PomodoroTimeLbn
        '
        Me.PomodoroTimeLbn.AutoSize = True
        Me.PomodoroTimeLbn.Location = New System.Drawing.Point(16, 239)
        Me.PomodoroTimeLbn.Name = "PomodoroTimeLbn"
        Me.PomodoroTimeLbn.Size = New System.Drawing.Size(62, 17)
        Me.PomodoroTimeLbn.TabIndex = 11
        Me.PomodoroTimeLbn.Text = "0 Minute"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Time Set"
        '
        'SBreakTimeSetLbn
        '
        Me.SBreakTimeSetLbn.AutoSize = True
        Me.SBreakTimeSetLbn.Location = New System.Drawing.Point(98, 35)
        Me.SBreakTimeSetLbn.Name = "SBreakTimeSetLbn"
        Me.SBreakTimeSetLbn.Size = New System.Drawing.Size(83, 17)
        Me.SBreakTimeSetLbn.TabIndex = 9
        Me.SBreakTimeSetLbn.Text = "Short Break"
        '
        'PomodoroTimeSetLbn
        '
        Me.PomodoroTimeSetLbn.AutoSize = True
        Me.PomodoroTimeSetLbn.Location = New System.Drawing.Point(12, 35)
        Me.PomodoroTimeSetLbn.Name = "PomodoroTimeSetLbn"
        Me.PomodoroTimeSetLbn.Size = New System.Drawing.Size(73, 17)
        Me.PomodoroTimeSetLbn.TabIndex = 8
        Me.PomodoroTimeSetLbn.Text = "Pomodoro"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.StateLbn)
        Me.Panel2.Controls.Add(Me.ResetBtn)
        Me.Panel2.Controls.Add(Me.PauseBtn)
        Me.Panel2.Controls.Add(Me.StartBtn)
        Me.Panel2.Controls.Add(Me.PomodoroName)
        Me.Panel2.Controls.Add(Me.TimerLbn)
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(324, 401)
        Me.Panel2.TabIndex = 12
        '
        'StateLbn
        '
        Me.StateLbn.Location = New System.Drawing.Point(67, 233)
        Me.StateLbn.Name = "StateLbn"
        Me.StateLbn.Size = New System.Drawing.Size(182, 23)
        Me.StateLbn.TabIndex = 11
        Me.StateLbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimerToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(599, 28)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TimerToolStripMenuItem
        '
        Me.TimerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.TimerToolStripMenuItem.Name = "TimerToolStripMenuItem"
        Me.TimerToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.TimerToolStripMenuItem.Text = "&Timer"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.StartToolStripMenuItem.Text = "&Start"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.PauseToolStripMenuItem.Text = "&Pause"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 432)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pomodoro Timer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.SBreakTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PomodoroTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LBreakTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SBreakTrackbar As TrackBar
    Friend WithEvents PomodoroTrackbar As TrackBar
    Friend WithEvents TimerLbn As Label
    Friend WithEvents PomodoroName As TextBox
    Friend WithEvents AutoStartBreak As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AutoStartPomodoro As CheckBox
    Friend WithEvents StartBtn As Button
    Friend WithEvents PauseBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SBreakTimeSetLbn As Label
    Friend WithEvents PomodoroTimeSetLbn As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents SBreakTimeLbn As Label
    Friend WithEvents PomodoroTimeLbn As Label
    Friend WithEvents StateLbn As Label
    Friend WithEvents LBreakLbn As Label
    Friend WithEvents LBreakTrackbar As TrackBar
    Friend WithEvents LBreakTimeLbn As Label
End Class
