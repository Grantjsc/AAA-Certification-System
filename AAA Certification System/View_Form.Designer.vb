<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Form
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFailed = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPassed = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboVaLStream = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(303, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 53)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "VIEW RECORD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.AutoScroll = True
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Orange
        Me.Guna2CustomGradientPanel1.BorderThickness = 10
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnAll)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnFailed)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnPassed)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cboVaLStream)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.DataGridView1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(861, 711)
        Me.Guna2CustomGradientPanel1.TabIndex = 4
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.BorderThickness = 5
        Me.Guna2GroupBox1.Controls.Add(Me.lblCount)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SeaGreen
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(43, 30)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 20
        Me.Guna2GroupBox1.ShadowDecoration.Depth = 15
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(176, 111)
        Me.Guna2GroupBox1.TabIndex = 187
        Me.Guna2GroupBox1.Text = "TOTAL"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Font = New System.Drawing.Font("Impact", 30.0!)
        Me.lblCount.ForeColor = System.Drawing.Color.DimGray
        Me.lblCount.Location = New System.Drawing.Point(20, 39)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(141, 67)
        Me.lblCount.TabIndex = 186
        Me.lblCount.Text = "100000"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.Transparent
        Me.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAll.FillColor = System.Drawing.Color.Transparent
        Me.btnAll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.ForeColor = System.Drawing.Color.Black
        Me.btnAll.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAll.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAll.Location = New System.Drawing.Point(43, 164)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(77, 29)
        Me.btnAll.TabIndex = 185
        Me.btnAll.Text = "ALL"
        '
        'btnFailed
        '
        Me.btnFailed.BackColor = System.Drawing.Color.Transparent
        Me.btnFailed.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFailed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFailed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFailed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFailed.FillColor = System.Drawing.Color.Transparent
        Me.btnFailed.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFailed.ForeColor = System.Drawing.Color.Black
        Me.btnFailed.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnFailed.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFailed.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnFailed.Location = New System.Drawing.Point(197, 164)
        Me.btnFailed.Name = "btnFailed"
        Me.btnFailed.Size = New System.Drawing.Size(77, 29)
        Me.btnFailed.TabIndex = 184
        Me.btnFailed.Text = "FAILED"
        '
        'btnPassed
        '
        Me.btnPassed.BackColor = System.Drawing.Color.Transparent
        Me.btnPassed.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPassed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPassed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPassed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPassed.FillColor = System.Drawing.Color.Transparent
        Me.btnPassed.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassed.ForeColor = System.Drawing.Color.Black
        Me.btnPassed.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPassed.HoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassed.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnPassed.Location = New System.Drawing.Point(120, 164)
        Me.btnPassed.Name = "btnPassed"
        Me.btnPassed.Size = New System.Drawing.Size(77, 29)
        Me.btnPassed.TabIndex = 183
        Me.btnPassed.Text = "PASSED"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(375, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 22)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "Select Value Stream:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboVaLStream
        '
        Me.cboVaLStream.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboVaLStream.BackColor = System.Drawing.Color.Transparent
        Me.cboVaLStream.BorderRadius = 15
        Me.cboVaLStream.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboVaLStream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVaLStream.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboVaLStream.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboVaLStream.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cboVaLStream.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboVaLStream.ItemHeight = 30
        Me.cboVaLStream.Items.AddRange(New Object() {"TR/TE", "SQUARE NANO", "PICO/SMF/BARRIER", "CERAMIC FUSE", "THIN FILM", "REED SWITCH", "PLANT QUALITY", "ALL"})
        Me.cboVaLStream.Location = New System.Drawing.Point(593, 157)
        Me.cboVaLStream.Name = "cboVaLStream"
        Me.cboVaLStream.ShadowDecoration.BorderRadius = 20
        Me.cboVaLStream.ShadowDecoration.Depth = 10
        Me.cboVaLStream.ShadowDecoration.Enabled = True
        Me.cboVaLStream.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.cboVaLStream.Size = New System.Drawing.Size(229, 36)
        Me.cboVaLStream.TabIndex = 180
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 199)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(779, 465)
        Me.DataGridView1.TabIndex = 163
        '
        'View_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 711)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "View_Form"
        Me.Text = "View_Form"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cboVaLStream As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnFailed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPassed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCount As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
End Class
