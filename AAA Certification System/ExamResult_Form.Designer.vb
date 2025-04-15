<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamResult_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamResult_Form))
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblMistake = New System.Windows.Forms.Label()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblCorrectAns = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblTrialNum = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPrev = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.FocusedColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnClose.Location = New System.Drawing.Point(938, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.Transparent
        Me.btnClose.PressedDepth = 0
        Me.btnClose.Size = New System.Drawing.Size(39, 39)
        Me.btnClose.TabIndex = 175
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(163, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 174
        Me.PictureBox2.TabStop = False
        '
        'lblMistake
        '
        Me.lblMistake.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMistake.BackColor = System.Drawing.Color.Transparent
        Me.lblMistake.Font = New System.Drawing.Font("Impact", 20.0!)
        Me.lblMistake.ForeColor = System.Drawing.Color.DimGray
        Me.lblMistake.Location = New System.Drawing.Point(22, 239)
        Me.lblMistake.Name = "lblMistake"
        Me.lblMistake.Size = New System.Drawing.Size(246, 53)
        Me.lblMistake.TabIndex = 173
        Me.lblMistake.Tag = ""
        Me.lblMistake.Text = "Mistake(s):  25 of 25"
        Me.lblMistake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox4.BorderRadius = 10
        Me.Guna2GroupBox4.BorderThickness = 5
        Me.Guna2GroupBox4.Controls.Add(Me.lblCorrectAns)
        Me.Guna2GroupBox4.Controls.Add(Me.Label2)
        Me.Guna2GroupBox4.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2GroupBox4.Controls.Add(Me.lblQuestion)
        Me.Guna2GroupBox4.Controls.Add(Me.lblMistake)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox4.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(29, 81)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(285, 571)
        Me.Guna2GroupBox4.TabIndex = 171
        Me.Guna2GroupBox4.Text = "Exam Summary"
        '
        'lblCorrectAns
        '
        Me.lblCorrectAns.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCorrectAns.BackColor = System.Drawing.Color.Transparent
        Me.lblCorrectAns.Font = New System.Drawing.Font("Impact", 40.0!)
        Me.lblCorrectAns.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblCorrectAns.Location = New System.Drawing.Point(21, 458)
        Me.lblCorrectAns.Name = "lblCorrectAns"
        Me.lblCorrectAns.Size = New System.Drawing.Size(246, 80)
        Me.lblCorrectAns.TabIndex = 177
        Me.lblCorrectAns.Tag = ""
        Me.lblCorrectAns.Text = "NO GOOD"
        Me.lblCorrectAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(14, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 53)
        Me.Label2.TabIndex = 176
        Me.Label2.Tag = ""
        Me.Label2.Text = "-- CORRECT ANSWER --"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.BorderThickness = 5
        Me.Guna2GroupBox1.Controls.Add(Me.lblTrialNum)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(60, 69)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(171, 148)
        Me.Guna2GroupBox1.TabIndex = 175
        Me.Guna2GroupBox1.Text = "TRIAL"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTrialNum
        '
        Me.lblTrialNum.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTrialNum.BackColor = System.Drawing.Color.Transparent
        Me.lblTrialNum.Font = New System.Drawing.Font("Segoe UI Black", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTrialNum.ForeColor = System.Drawing.Color.DimGray
        Me.lblTrialNum.Location = New System.Drawing.Point(18, 49)
        Me.lblTrialNum.Name = "lblTrialNum"
        Me.lblTrialNum.Size = New System.Drawing.Size(136, 85)
        Me.lblTrialNum.TabIndex = 159
        Me.lblTrialNum.Text = "1"
        Me.lblTrialNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("Impact", 20.0!)
        Me.lblQuestion.ForeColor = System.Drawing.Color.DimGray
        Me.lblQuestion.Location = New System.Drawing.Point(6, 296)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(279, 53)
        Me.lblQuestion.TabIndex = 174
        Me.lblQuestion.Tag = ""
        Me.lblQuestion.Text = "Question Number:  25"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Location = New System.Drawing.Point(355, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(596, 417)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 176
        Me.PictureBox1.TabStop = False
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrev.BackColor = System.Drawing.Color.Transparent
        Me.btnPrev.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrev.BorderRadius = 10
        Me.btnPrev.BorderThickness = 3
        Me.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrev.Enabled = False
        Me.btnPrev.FillColor = System.Drawing.Color.White
        Me.btnPrev.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrev.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrev.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnPrev.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnPrev.Image = CType(resources.GetObject("btnPrev.Image"), System.Drawing.Image)
        Me.btnPrev.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPrev.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPrev.Location = New System.Drawing.Point(466, 581)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.ShadowDecoration.BorderRadius = 15
        Me.btnPrev.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrev.ShadowDecoration.Enabled = True
        Me.btnPrev.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnPrev.Size = New System.Drawing.Size(157, 46)
        Me.btnPrev.TabIndex = 177
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.BorderRadius = 10
        Me.btnNext.BorderThickness = 3
        Me.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNext.FillColor = System.Drawing.Color.White
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnNext.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnNext.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnNext.Location = New System.Drawing.Point(680, 581)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.ShadowDecoration.BorderRadius = 15
        Me.btnNext.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.ShadowDecoration.Enabled = True
        Me.btnNext.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnNext.Size = New System.Drawing.Size(157, 46)
        Me.btnNext.TabIndex = 178
        Me.btnNext.Text = "Next"
        Me.btnNext.TextOffset = New System.Drawing.Point(-10, 0)
        '
        'ExamResult_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Guna2GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamResult_Form"
        Me.Text = "ExamResult_Form"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblMistake As Label
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblTrialNum As Label
    Friend WithEvents lblCorrectAns As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPrev As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
End Class
