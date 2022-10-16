Public Class Form1
    ' initilize variable
    Dim m As Integer = 0
    Dim s As Integer = 0
    Dim pomodoroTime As Integer = 0
    Dim sbreakTime As Integer = 0
    Dim lbreakTime As Integer = 0
    Dim interval As Integer = 1
    Dim state As String = "pomodoro"

    Private Sub PomodoroTrackbar_Scroll(sender As Object, e As EventArgs) Handles PomodoroTrackbar.Scroll
        ' get pomodoro trackbar value to text
        PomodoroTimeLbn.Text = PomodoroTrackbar.Value & " minute"
        ' get pomodoro trackbar value to pomodoroTime
        pomodoroTime = PomodoroTrackbar.Value * 60
    End Sub

    Private Sub SBreakTrackbar_Scroll(sender As Object, e As EventArgs) Handles SBreakTrackbar.Scroll
        ' get short break trackbar value to text
        SBreakTimeLbn.Text = SBreakTrackbar.Value & " minute"
        ' get short break trackbar value to sbreakTime
        sbreakTime = SBreakTrackbar.Value * 60
    End Sub

    Private Sub LBreakTrackbar_Scroll(sender As Object, e As EventArgs) Handles LBreakTrackbar.Scroll
        ' get long break trackbar value to text
        LBreakTimeLbn.Text = LBreakTrackbar.Value & " minute"
        ' get long break trackbar value to lbreakTime
        lbreakTime = LBreakTrackbar.Value * 60
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        ' when start button is click do the following

        ' enable timer
        Timer1.Enabled = True
        ' set prgressbar1 to visible
        ProgressBar1.Visible = True
        ' set statusbar to show pomodoro or interval
        ToolStripStatusLabel1.Text = "Pomodoro (interval): " & interval


        ' set progressbar maximum according to the state of the program
        If state = "pomodoro" Then
            ProgressBar1.Maximum = PomodoroTrackbar.Value * 60
        ElseIf state = "sbreak" Then
            ProgressBar1.Maximum = SBreakTrackbar.Value * 60
        ElseIf state = "lbreak" Then
            ProgressBar1.Maximum = LBreakTrackbar.Value * 60
        End If

        ' disable all trackbar
        PomodoroTrackbar.Enabled = False
        SBreakTrackbar.Enabled = False
        LBreakTrackbar.Enabled = False

    End Sub

    Private Sub PauseBtn_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        ' when pause button is clicked do the following

        ' disable timer
        Timer1.Enabled = False
        ' set state lebel to display "Pause"
        StateLbn.Text = "Pause"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' when timer is enabled do the following

        ' check state of the program
        If state = "pomodoro" Then
            ' set to Focus mode
            StateLbn.Text = "Focus!"
            Panel2.BackColor = Color.Crimson
            TimerLbn.ForeColor = Color.White
            StateLbn.ForeColor = Color.White

            If pomodoroTime > 0 Then
                ' start countdown
                s = pomodoroTime Mod 60
                m = pomodoroTime \ 60
                ' time countdown
                pomodoroTime = pomodoroTime - 1
                ' tarckbar running
                ProgressBar1.Value = ProgressBar1.Value + 1
                TimerLbn.Text = m & ":" & s

            ElseIf pomodoroTime = 0 Then
                ' when timer reach 0 then
                ' set to default mode
                Panel2.BackColor = Color.WhiteSmoke
                TimerLbn.ForeColor = Color.Black
                StateLbn.ForeColor = Color.Black
                ' reset progressbar
                ProgressBar1.Value = 0
                ProgressBar1.Visible = False
                ' get pomodoroTime
                pomodoroTime = PomodoroTrackbar.Value * 60

                ' check if it's the last poromodo
                If interval = 4 Then
                    ' if it's the last pomodoro then change state to long break
                    StateLbn.Text = "Long Break Time"
                    state = "lbreak"
                    ' long break time mod 60 to store only second
                    s = lbreakTime Mod 60
                    ' long break time \ 60 to store only minute and discard decimal
                    m = lbreakTime \ 60
                    TimerLbn.Text = m & ":" & s
                    ' check auto start break
                    If AutoStartBreak.Checked = True Then
                        ' set progressbar maximum to long break track bar value
                        ProgressBar1.Maximum = LBreakTrackbar.Value * 60
                        ProgressBar1.Visible = True
                        ' set status text
                        ToolStripStatusLabel1.Text = "Pomodoro (interval): " & interval
                        Timer1.Enabled = True
                    ElseIf AutoStartBreak.Checked = False Then
                        Timer1.Enabled = False
                    End If
                ElseIf interval <> 4 Then
                    StateLbn.Text = "Short Break Time"
                    state = "sbreak"
                    s = sbreakTime Mod 60
                    m = sbreakTime \ 60
                    TimerLbn.Text = m & ":" & s
                    If AutoStartBreak.Checked = True Then
                        ProgressBar1.Maximum = SBreakTrackbar.Value * 60
                        ProgressBar1.Visible = True
                        ToolStripStatusLabel1.Text = "Pomodoro (interval): " & interval
                        Timer1.Enabled = True
                    ElseIf AutoStartBreak.Checked = False Then
                        Timer1.Enabled = False
                    End If
                End If
            End If

        ElseIf state = "sbreak" Then
            StateLbn.Text = "Short Break Time"
            Panel2.BackColor = Color.LightGreen
            TimerLbn.ForeColor = Color.Black
            StateLbn.ForeColor = Color.Black
            If sbreakTime > 0 Then
                s = sbreakTime Mod 60
                m = sbreakTime \ 60
                sbreakTime = sbreakTime - 1
                ProgressBar1.Value = ProgressBar1.Value + 1
                TimerLbn.Text = m & ":" & s
            ElseIf sbreakTime = 0 Then
                Panel2.BackColor = Color.WhiteSmoke
                TimerLbn.ForeColor = Color.Black
                StateLbn.ForeColor = Color.Black
                ProgressBar1.Value = 0
                ProgressBar1.Visible = False
                s = pomodoroTime Mod 60
                m = pomodoroTime \ 60
                TimerLbn.Text = m & ":" & s
                StateLbn.Text = "Focus!"
                state = "pomodoro"
                interval = interval + 1
                sbreakTime = SBreakTrackbar.Value * 60
                If AutoStartPomodoro.Checked = True Then
                    ProgressBar1.Maximum = PomodoroTrackbar.Value * 60
                    ProgressBar1.Visible = True
                    ToolStripStatusLabel1.Text = "Pomodoro (interval): " & interval
                    Timer1.Enabled = True
                ElseIf AutoStartPomodoro.Checked = False Then
                    Timer1.Enabled = False
                End If
            End If

        ElseIf state = "lbreak" Then
            StateLbn.Text = "Long Break Time"
            Panel2.BackColor = Color.LightGreen
            TimerLbn.ForeColor = Color.Black
            StateLbn.ForeColor = Color.Black
            If lbreakTime > 0 Then
                s = lbreakTime Mod 60
                m = lbreakTime \ 60
                lbreakTime = lbreakTime - 1
                ProgressBar1.Value = ProgressBar1.Value + 1
                TimerLbn.Text = m & ":" & s
            ElseIf lbreakTime = 0 Then
                Panel2.BackColor = Color.WhiteSmoke
                TimerLbn.ForeColor = Color.Black
                StateLbn.ForeColor = Color.Black
                ProgressBar1.Value = 0
                ProgressBar1.Visible = False
                s = pomodoroTime Mod 60
                m = pomodoroTime \ 60
                TimerLbn.Text = m & ":" & s
                StateLbn.Text = "Focus!"
                state = "pomodoro"
                interval = 1
                lbreakTime = LBreakTrackbar.Value * 60
                PomodoroTrackbar.Enabled = True
                SBreakTrackbar.Enabled = True
                LBreakTrackbar.Enabled = True
                state = "pomodoro"
                Timer1.Enabled = False
                TimerLbn.Text = "Timer"
                StateLbn.Text = ""
                ProgressBar1.Value = 0
                Panel2.BackColor = Color.WhiteSmoke
                TimerLbn.ForeColor = Color.Black
                StateLbn.ForeColor = Color.Black
                ToolStripStatusLabel1.Text = "Pomodoro (interval): " & interval

            End If
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        interval = 1
        pomodoroTime = PomodoroTrackbar.Value * 60
        sbreakTime = SBreakTrackbar.Value * 60
        lbreakTime = LBreakTrackbar.Value * 60
        PomodoroTrackbar.Enabled = True
        SBreakTrackbar.Enabled = True
        LBreakTrackbar.Enabled = True
        state = "pomodoro"
        Timer1.Enabled = False
        TimerLbn.Text = "Timer"
        StateLbn.Text = ""
        ProgressBar1.Value = 0
        Panel2.BackColor = Color.WhiteSmoke
        TimerLbn.ForeColor = Color.Black
        StateLbn.ForeColor = Color.Black
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        Timer1.Enabled = True
        ProgressBar1.Visible = True
        ToolStripStatusLabel1.Text = "Pomodoro (interval): " & interval

        PomodoroTrackbar.Enabled = True
        SBreakTrackbar.Enabled = True
        LBreakTrackbar.Enabled = True
        If state = "pomodoro" Then
            ProgressBar1.Maximum = PomodoroTrackbar.Value * 60
        ElseIf state = "sbreak" Then
            ProgressBar1.Maximum = SBreakTrackbar.Value * 60
        ElseIf state = "lbreak" Then
            ProgressBar1.Maximum = LBreakTrackbar.Value * 60
        End If
        PomodoroTrackbar.Enabled = False
        SBreakTrackbar.Enabled = False
        LBreakTrackbar.Enabled = False
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        Timer1.Enabled = False
        StateLbn.Text = "Pause"
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        interval = 1
        pomodoroTime = PomodoroTrackbar.Value * 60
        sbreakTime = SBreakTrackbar.Value * 60
        lbreakTime = LBreakTrackbar.Value * 60
        PomodoroTrackbar.Enabled = True
        SBreakTrackbar.Enabled = True
        LBreakTrackbar.Enabled = True
        state = "pomodoro"
        Timer1.Enabled = False
        TimerLbn.Text = "Timer"
        StateLbn.Text = ""
        ProgressBar1.Value = 0
        Panel2.BackColor = Color.WhiteSmoke
        TimerLbn.ForeColor = Color.Black
        StateLbn.ForeColor = Color.Black
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub PomodoroName_Click(sender As Object, e As EventArgs) Handles PomodoroName.Click
        If PomodoroName.Text = "Pomodoro Name" Then
            PomodoroName.Text = ""
        End If
    End Sub
End Class
