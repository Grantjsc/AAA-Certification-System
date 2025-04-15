<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPath_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPath_Form))
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnImage_Change = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtImagePath = New System.Windows.Forms.TextBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBoxTitle = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtSavePath = New System.Windows.Forms.TextBox()
        Me.btnSaving_Change = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnImage_NewPath = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSaving_NewPath = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.GroupBoxTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.BorderRadius = 10
        Me.Guna2CustomGradientPanel1.BorderThickness = 7
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnClose)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.GroupBoxTitle)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(737, 401)
        Me.Guna2CustomGradientPanel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 45)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Settings"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.BorderThickness = 5
        Me.Guna2GroupBox1.Controls.Add(Me.btnImage_NewPath)
        Me.Guna2GroupBox1.Controls.Add(Me.btnImage_Change)
        Me.Guna2GroupBox1.Controls.Add(Me.txtImagePath)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(33, 63)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(661, 148)
        Me.Guna2GroupBox1.TabIndex = 10
        Me.Guna2GroupBox1.Text = "Change Image Path"
        '
        'btnImage_Change
        '
        Me.btnImage_Change.BackColor = System.Drawing.Color.Transparent
        Me.btnImage_Change.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnImage_Change.BorderRadius = 10
        Me.btnImage_Change.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnImage_Change.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnImage_Change.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImage_Change.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImage_Change.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnImage_Change.FillColor = System.Drawing.Color.Orange
        Me.btnImage_Change.FillColor2 = System.Drawing.Color.Moccasin
        Me.btnImage_Change.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImage_Change.ForeColor = System.Drawing.Color.Black
        Me.btnImage_Change.Location = New System.Drawing.Point(531, 87)
        Me.btnImage_Change.Name = "btnImage_Change"
        Me.btnImage_Change.ShadowDecoration.BorderRadius = 10
        Me.btnImage_Change.ShadowDecoration.Depth = 17
        Me.btnImage_Change.ShadowDecoration.Enabled = True
        Me.btnImage_Change.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.btnImage_Change.Size = New System.Drawing.Size(104, 38)
        Me.btnImage_Change.TabIndex = 85
        Me.btnImage_Change.Text = "Change"
        '
        'txtImagePath
        '
        Me.txtImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImagePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagePath.Location = New System.Drawing.Point(21, 49)
        Me.txtImagePath.Margin = New System.Windows.Forms.Padding(2)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.ReadOnly = True
        Me.txtImagePath.Size = New System.Drawing.Size(614, 29)
        Me.txtImagePath.TabIndex = 18
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnClose.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnClose.Location = New System.Drawing.Point(680, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.DarkGray
        Me.btnClose.PressedDepth = 0
        Me.btnClose.Size = New System.Drawing.Size(37, 37)
        Me.btnClose.TabIndex = 9
        '
        'GroupBoxTitle
        '
        Me.GroupBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBoxTitle.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxTitle.BorderColor = System.Drawing.Color.Black
        Me.GroupBoxTitle.BorderRadius = 10
        Me.GroupBoxTitle.BorderThickness = 5
        Me.GroupBoxTitle.Controls.Add(Me.btnSaving_NewPath)
        Me.GroupBoxTitle.Controls.Add(Me.txtSavePath)
        Me.GroupBoxTitle.Controls.Add(Me.btnSaving_Change)
        Me.GroupBoxTitle.CustomBorderColor = System.Drawing.Color.Transparent
        Me.GroupBoxTitle.FillColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBoxTitle.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxTitle.Location = New System.Drawing.Point(33, 228)
        Me.GroupBoxTitle.Name = "GroupBoxTitle"
        Me.GroupBoxTitle.Size = New System.Drawing.Size(661, 148)
        Me.GroupBoxTitle.TabIndex = 2
        Me.GroupBoxTitle.Text = "Change Saving Path of ARR"
        '
        'txtSavePath
        '
        Me.txtSavePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSavePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSavePath.Location = New System.Drawing.Point(19, 49)
        Me.txtSavePath.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSavePath.Name = "txtSavePath"
        Me.txtSavePath.ReadOnly = True
        Me.txtSavePath.Size = New System.Drawing.Size(616, 29)
        Me.txtSavePath.TabIndex = 86
        '
        'btnSaving_Change
        '
        Me.btnSaving_Change.BackColor = System.Drawing.Color.Transparent
        Me.btnSaving_Change.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSaving_Change.BorderRadius = 10
        Me.btnSaving_Change.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSaving_Change.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSaving_Change.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaving_Change.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaving_Change.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSaving_Change.FillColor = System.Drawing.Color.Orange
        Me.btnSaving_Change.FillColor2 = System.Drawing.Color.Moccasin
        Me.btnSaving_Change.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaving_Change.ForeColor = System.Drawing.Color.Black
        Me.btnSaving_Change.Location = New System.Drawing.Point(531, 89)
        Me.btnSaving_Change.Name = "btnSaving_Change"
        Me.btnSaving_Change.ShadowDecoration.BorderRadius = 10
        Me.btnSaving_Change.ShadowDecoration.Depth = 17
        Me.btnSaving_Change.ShadowDecoration.Enabled = True
        Me.btnSaving_Change.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.btnSaving_Change.Size = New System.Drawing.Size(104, 38)
        Me.btnSaving_Change.TabIndex = 82
        Me.btnSaving_Change.Text = "Change"
        '
        'btnImage_NewPath
        '
        Me.btnImage_NewPath.BackColor = System.Drawing.Color.Transparent
        Me.btnImage_NewPath.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnImage_NewPath.BorderRadius = 10
        Me.btnImage_NewPath.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnImage_NewPath.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnImage_NewPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImage_NewPath.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImage_NewPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnImage_NewPath.FillColor = System.Drawing.Color.Orange
        Me.btnImage_NewPath.FillColor2 = System.Drawing.Color.Moccasin
        Me.btnImage_NewPath.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImage_NewPath.ForeColor = System.Drawing.Color.Black
        Me.btnImage_NewPath.Location = New System.Drawing.Point(400, 87)
        Me.btnImage_NewPath.Name = "btnImage_NewPath"
        Me.btnImage_NewPath.ShadowDecoration.BorderRadius = 10
        Me.btnImage_NewPath.ShadowDecoration.Depth = 17
        Me.btnImage_NewPath.ShadowDecoration.Enabled = True
        Me.btnImage_NewPath.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.btnImage_NewPath.Size = New System.Drawing.Size(104, 38)
        Me.btnImage_NewPath.TabIndex = 86
        Me.btnImage_NewPath.Text = "New Path"
        '
        'btnSaving_NewPath
        '
        Me.btnSaving_NewPath.BackColor = System.Drawing.Color.Transparent
        Me.btnSaving_NewPath.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSaving_NewPath.BorderRadius = 10
        Me.btnSaving_NewPath.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSaving_NewPath.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSaving_NewPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaving_NewPath.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaving_NewPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSaving_NewPath.FillColor = System.Drawing.Color.Orange
        Me.btnSaving_NewPath.FillColor2 = System.Drawing.Color.Moccasin
        Me.btnSaving_NewPath.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaving_NewPath.ForeColor = System.Drawing.Color.Black
        Me.btnSaving_NewPath.Location = New System.Drawing.Point(400, 89)
        Me.btnSaving_NewPath.Name = "btnSaving_NewPath"
        Me.btnSaving_NewPath.ShadowDecoration.BorderRadius = 10
        Me.btnSaving_NewPath.ShadowDecoration.Depth = 17
        Me.btnSaving_NewPath.ShadowDecoration.Enabled = True
        Me.btnSaving_NewPath.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.btnSaving_NewPath.Size = New System.Drawing.Size(104, 38)
        Me.btnSaving_NewPath.TabIndex = 87
        Me.btnSaving_NewPath.Text = "New Path"
        '
        'EditPath_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 401)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditPath_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EditPath_Form"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.GroupBoxTitle.ResumeLayout(False)
        Me.GroupBoxTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnImage_Change As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtImagePath As TextBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBoxTitle As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnSaving_Change As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtSavePath As TextBox
    Friend WithEvents btnImage_NewPath As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSaving_NewPath As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
End Class
