<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exam_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Exam_Form))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGood = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNG = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox_TestNum = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtTrial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAttempt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_TestNum.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(46, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(596, 417)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnGood
        '
        Me.btnGood.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnGood.BackColor = System.Drawing.Color.Transparent
        Me.btnGood.BorderColor = System.Drawing.Color.Green
        Me.btnGood.BorderRadius = 10
        Me.btnGood.BorderThickness = 3
        Me.btnGood.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGood.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGood.FillColor = System.Drawing.Color.White
        Me.btnGood.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGood.ForeColor = System.Drawing.Color.Green
        Me.btnGood.HoverState.FillColor = System.Drawing.Color.Green
        Me.btnGood.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnGood.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnGood.Image = CType(resources.GetObject("btnGood.Image"), System.Drawing.Image)
        Me.btnGood.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnGood.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnGood.Location = New System.Drawing.Point(145, 497)
        Me.btnGood.Name = "btnGood"
        Me.btnGood.ShadowDecoration.BorderRadius = 15
        Me.btnGood.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGood.ShadowDecoration.Enabled = True
        Me.btnGood.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnGood.Size = New System.Drawing.Size(160, 69)
        Me.btnGood.TabIndex = 7
        Me.btnGood.Text = "GOOD"
        Me.btnGood.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnNG
        '
        Me.btnNG.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnNG.BackColor = System.Drawing.Color.Transparent
        Me.btnNG.BorderColor = System.Drawing.Color.Red
        Me.btnNG.BorderRadius = 10
        Me.btnNG.BorderThickness = 3
        Me.btnNG.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNG.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNG.FillColor = System.Drawing.Color.White
        Me.btnNG.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNG.ForeColor = System.Drawing.Color.Red
        Me.btnNG.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnNG.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnNG.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnNG.Image = CType(resources.GetObject("btnNG.Image"), System.Drawing.Image)
        Me.btnNG.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnNG.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnNG.Location = New System.Drawing.Point(374, 497)
        Me.btnNG.Name = "btnNG"
        Me.btnNG.ShadowDecoration.BorderRadius = 15
        Me.btnNG.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNG.ShadowDecoration.Enabled = True
        Me.btnNG.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnNG.Size = New System.Drawing.Size(160, 69)
        Me.btnNG.TabIndex = 8
        Me.btnNG.Text = "NO GOOD"
        Me.btnNG.TextOffset = New System.Drawing.Point(-25, 0)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(163, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 152
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(210, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(596, 39)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "ATTRIBUTE AGREEMENT ANALYSIS EXAMINATION"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox_TestNum
        '
        Me.GroupBox_TestNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox_TestNum.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox_TestNum.BorderColor = System.Drawing.Color.SeaGreen
        Me.GroupBox_TestNum.BorderRadius = 10
        Me.GroupBox_TestNum.BorderThickness = 5
        Me.GroupBox_TestNum.Controls.Add(Me.Label3)
        Me.GroupBox_TestNum.Controls.Add(Me.PictureBox1)
        Me.GroupBox_TestNum.Controls.Add(Me.btnGood)
        Me.GroupBox_TestNum.Controls.Add(Me.btnNG)
        Me.GroupBox_TestNum.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.GroupBox_TestNum.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.GroupBox_TestNum.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_TestNum.ForeColor = System.Drawing.Color.Green
        Me.GroupBox_TestNum.Location = New System.Drawing.Point(272, 84)
        Me.GroupBox_TestNum.Name = "GroupBox_TestNum"
        Me.GroupBox_TestNum.Size = New System.Drawing.Size(677, 603)
        Me.GroupBox_TestNum.TabIndex = 161
        Me.GroupBox_TestNum.Text = "Test number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(193, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 15)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "(Note: Double click on the button to proceed)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.BorderThickness = 5
        Me.Guna2GroupBox1.Controls.Add(Me.lblName)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 110)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(237, 128)
        Me.Guna2GroupBox1.TabIndex = 162
        Me.Guna2GroupBox1.Text = "Name"
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.DimGray
        Me.lblName.Location = New System.Drawing.Point(9, 47)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(219, 71)
        Me.lblName.TabIndex = 159
        Me.lblName.Text = "CATAPANG, GRANT JONATHAN"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTrial
        '
        Me.txtTrial.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtTrial.ForeColor = System.Drawing.Color.Lime
        Me.txtTrial.Location = New System.Drawing.Point(99, 99)
        Me.txtTrial.Name = "txtTrial"
        Me.txtTrial.ReadOnly = True
        Me.txtTrial.Size = New System.Drawing.Size(100, 35)
        Me.txtTrial.TabIndex = 166
        Me.txtTrial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(29, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 22)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Trial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAttempt
        '
        Me.txtAttempt.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtAttempt.ForeColor = System.Drawing.Color.Lime
        Me.txtAttempt.Location = New System.Drawing.Point(99, 57)
        Me.txtAttempt.Name = "txtAttempt"
        Me.txtAttempt.ReadOnly = True
        Me.txtAttempt.Size = New System.Drawing.Size(100, 35)
        Me.txtAttempt.TabIndex = 164
        Me.txtAttempt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(24, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 22)
        Me.Label7.TabIndex = 162
        Me.Label7.Text = "Exam:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStation
        '
        Me.lblStation.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStation.BackColor = System.Drawing.Color.Transparent
        Me.lblStation.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStation.ForeColor = System.Drawing.Color.DimGray
        Me.lblStation.Location = New System.Drawing.Point(8, 43)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(219, 59)
        Me.lblStation.TabIndex = 169
        Me.lblStation.Text = "FA"
        Me.lblStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox2.BorderRadius = 10
        Me.Guna2GroupBox2.BorderThickness = 5
        Me.Guna2GroupBox2.Controls.Add(Me.lblStation)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(12, 371)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(237, 111)
        Me.Guna2GroupBox2.TabIndex = 171
        Me.Guna2GroupBox2.Text = "Station"
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox3.BorderRadius = 10
        Me.Guna2GroupBox3.BorderThickness = 5
        Me.Guna2GroupBox3.Controls.Add(Me.lblLine)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(12, 249)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(237, 111)
        Me.Guna2GroupBox3.TabIndex = 172
        Me.Guna2GroupBox3.Text = "Line"
        '
        'lblLine
        '
        Me.lblLine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLine.BackColor = System.Drawing.Color.Transparent
        Me.lblLine.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLine.ForeColor = System.Drawing.Color.DimGray
        Me.lblLine.Location = New System.Drawing.Point(8, 43)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(219, 59)
        Me.lblLine.TabIndex = 169
        Me.lblLine.Text = "Pico Coated and Uncoated"
        Me.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox4.BorderRadius = 10
        Me.Guna2GroupBox4.BorderThickness = 5
        Me.Guna2GroupBox4.Controls.Add(Me.txtAttempt)
        Me.Guna2GroupBox4.Controls.Add(Me.Label7)
        Me.Guna2GroupBox4.Controls.Add(Me.txtTrial)
        Me.Guna2GroupBox4.Controls.Add(Me.Label1)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(12, 493)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(237, 165)
        Me.Guna2GroupBox4.TabIndex = 173
        Me.Guna2GroupBox4.Text = "Exam Details"
        '
        'Exam_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.Guna2GroupBox4)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.GroupBox_TestNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Exam_Form"
        Me.Text = "Exam_Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_TestNum.ResumeLayout(False)
        Me.GroupBox_TestNum.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGood As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNG As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox_TestNum As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTrial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAttempt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblLine As Label
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
End Class
