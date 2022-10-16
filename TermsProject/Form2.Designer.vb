<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.AboutLbn = New System.Windows.Forms.Label()
        Me.AboutHeaderLbn = New System.Windows.Forms.Label()
        Me.AboutMeHeaderLbn = New System.Windows.Forms.Label()
        Me.AboutMePic = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.AboutMePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AboutLbn
        '
        Me.AboutLbn.AutoSize = True
        Me.AboutLbn.Location = New System.Drawing.Point(12, 45)
        Me.AboutLbn.Name = "AboutLbn"
        Me.AboutLbn.Size = New System.Drawing.Size(300, 34)
        Me.AboutLbn.TabIndex = 1
        Me.AboutLbn.Text = "This Program create under an termsproject of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "visual programing subject 75232662" &
    "."
        '
        'AboutHeaderLbn
        '
        Me.AboutHeaderLbn.AutoSize = True
        Me.AboutHeaderLbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutHeaderLbn.Location = New System.Drawing.Point(106, 9)
        Me.AboutHeaderLbn.Name = "AboutHeaderLbn"
        Me.AboutHeaderLbn.Size = New System.Drawing.Size(116, 17)
        Me.AboutHeaderLbn.TabIndex = 2
        Me.AboutHeaderLbn.Text = "About Program"
        '
        'AboutMeHeaderLbn
        '
        Me.AboutMeHeaderLbn.AutoSize = True
        Me.AboutMeHeaderLbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutMeHeaderLbn.Location = New System.Drawing.Point(120, 101)
        Me.AboutMeHeaderLbn.Name = "AboutMeHeaderLbn"
        Me.AboutMeHeaderLbn.Size = New System.Drawing.Size(76, 17)
        Me.AboutMeHeaderLbn.TabIndex = 3
        Me.AboutMeHeaderLbn.Text = "About Me"
        '
        'AboutMePic
        '
        Me.AboutMePic.Image = Global.TermsProject.My.Resources.Resources.Screenshot_2022_10_16_160055
        Me.AboutMePic.Location = New System.Drawing.Point(20, 135)
        Me.AboutMePic.Name = "AboutMePic"
        Me.AboutMePic.Size = New System.Drawing.Size(283, 210)
        Me.AboutMePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AboutMePic.TabIndex = 0
        Me.AboutMePic.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name: Punyarit Klaphachon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "preferred color: Pink, Black, Blue, Red" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(121, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(322, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AboutMeHeaderLbn)
        Me.Controls.Add(Me.AboutHeaderLbn)
        Me.Controls.Add(Me.AboutLbn)
        Me.Controls.Add(Me.AboutMePic)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.AboutMePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AboutMePic As PictureBox
    Friend WithEvents AboutLbn As Label
    Friend WithEvents AboutHeaderLbn As Label
    Friend WithEvents AboutMeHeaderLbn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
