<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Form
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
        Me.txtEmpNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValueStream = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.cboStation = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboLine = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEmpNum
        '
        Me.txtEmpNum.BorderColor = System.Drawing.Color.DarkGray
        Me.txtEmpNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmpNum.DefaultText = ""
        Me.txtEmpNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmpNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmpNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmpNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmpNum.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpNum.ForeColor = System.Drawing.Color.Black
        Me.txtEmpNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmpNum.Location = New System.Drawing.Point(277, 73)
        Me.txtEmpNum.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtEmpNum.Name = "txtEmpNum"
        Me.txtEmpNum.PlaceholderText = ""
        Me.txtEmpNum.SelectedText = ""
        Me.txtEmpNum.ShadowDecoration.Depth = 10
        Me.txtEmpNum.ShadowDecoration.Enabled = True
        Me.txtEmpNum.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.txtEmpNum.Size = New System.Drawing.Size(379, 40)
        Me.txtEmpNum.TabIndex = 0
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.DimGray
        Me.lblDay.Location = New System.Drawing.Point(91, 81)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(176, 24)
        Me.lblDay.TabIndex = 154
        Me.lblDay.Text = "Employee No. :"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(273, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 15)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "(Note: Type your employee number here then press enter)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(181, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Name: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(105, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 24)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Value Stream:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(271, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 53)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "ADD NEW RECORD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtName.BorderColor = System.Drawing.Color.DarkGray
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(277, 137)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.PlaceholderText = ""
        Me.txtName.ReadOnly = True
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Depth = 10
        Me.txtName.ShadowDecoration.Enabled = True
        Me.txtName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.txtName.Size = New System.Drawing.Size(379, 40)
        Me.txtName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(173, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 24)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Station:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(203, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "Line:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValueStream
        '
        Me.txtValueStream.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtValueStream.BorderColor = System.Drawing.Color.DarkGray
        Me.txtValueStream.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValueStream.DefaultText = ""
        Me.txtValueStream.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtValueStream.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtValueStream.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtValueStream.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtValueStream.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtValueStream.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValueStream.ForeColor = System.Drawing.Color.Black
        Me.txtValueStream.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtValueStream.Location = New System.Drawing.Point(277, 202)
        Me.txtValueStream.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtValueStream.Name = "txtValueStream"
        Me.txtValueStream.PlaceholderText = ""
        Me.txtValueStream.ReadOnly = True
        Me.txtValueStream.SelectedText = ""
        Me.txtValueStream.ShadowDecoration.Depth = 10
        Me.txtValueStream.ShadowDecoration.Enabled = True
        Me.txtValueStream.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.txtValueStream.Size = New System.Drawing.Size(379, 40)
        Me.txtValueStream.TabIndex = 2
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.AutoScroll = True
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Orange
        Me.Guna2CustomGradientPanel1.BorderThickness = 10
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(861, 711)
        Me.Guna2CustomGradientPanel1.TabIndex = 1
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.BorderThickness = 6
        Me.Guna2GroupBox1.Controls.Add(Me.btnClear)
        Me.Guna2GroupBox1.Controls.Add(Me.btnAdd)
        Me.Guna2GroupBox1.Controls.Add(Me.cboStation)
        Me.Guna2GroupBox1.Controls.Add(Me.cboLine)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtValueStream)
        Me.Guna2GroupBox1.Controls.Add(Me.txtEmpNum)
        Me.Guna2GroupBox1.Controls.Add(Me.lblDay)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.txtName)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(56, 111)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 15
        Me.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.White
        Me.Guna2GroupBox1.ShadowDecoration.Depth = 20
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(20)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(757, 478)
        Me.Guna2GroupBox1.TabIndex = 172
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BorderColor = System.Drawing.Color.Red
        Me.btnClear.BorderRadius = 10
        Me.btnClear.BorderThickness = 3
        Me.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.FillColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DimGray
        Me.btnClear.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnClear.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClear.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnClear.Location = New System.Drawing.Point(421, 391)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.BorderRadius = 15
        Me.btnClear.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.ShadowDecoration.Enabled = True
        Me.btnClear.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnClear.Size = New System.Drawing.Size(160, 56)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.BorderRadius = 10
        Me.btnAdd.BorderThickness = 3
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DimGray
        Me.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdd.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnAdd.Location = New System.Drawing.Point(179, 391)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.BorderRadius = 15
        Me.btnAdd.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.ShadowDecoration.Enabled = True
        Me.btnAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(7)
        Me.btnAdd.Size = New System.Drawing.Size(160, 56)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Record"
        '
        'cboStation
        '
        Me.cboStation.BackColor = System.Drawing.Color.Transparent
        Me.cboStation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStation.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboStation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboStation.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cboStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboStation.ItemHeight = 30
        Me.cboStation.Items.AddRange(New Object() {"FA", "FI", "VI"})
        Me.cboStation.Location = New System.Drawing.Point(277, 320)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.ShadowDecoration.Depth = 10
        Me.cboStation.ShadowDecoration.Enabled = True
        Me.cboStation.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.cboStation.Size = New System.Drawing.Size(379, 36)
        Me.cboStation.TabIndex = 4
        '
        'cboLine
        '
        Me.cboLine.BackColor = System.Drawing.Color.Transparent
        Me.cboLine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLine.DropDownHeight = 300
        Me.cboLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLine.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboLine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboLine.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cboLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboLine.IntegralHeight = False
        Me.cboLine.ItemHeight = 30
        Me.cboLine.Location = New System.Drawing.Point(277, 264)
        Me.cboLine.Name = "cboLine"
        Me.cboLine.ShadowDecoration.Depth = 10
        Me.cboLine.ShadowDecoration.Enabled = True
        Me.cboLine.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.cboLine.Size = New System.Drawing.Size(379, 36)
        Me.cboLine.TabIndex = 3
        '
        'Create_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 711)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Create_Form"
        Me.Text = "Create_Form"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtEmpNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtValueStream As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cboStation As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboLine As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
End Class
